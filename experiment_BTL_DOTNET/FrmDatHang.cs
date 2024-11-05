using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experiment_BTL_DOTNET
{
    public partial class FrmDatHang : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public string ConvertCommaToDot(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
            }

            // Xóa tất cả dấu chấm và dấu phẩy
            string result = input.Replace(".", "").Replace(",", "");
            if (result.Length >= 2)
            {
                // Xóa 2 ký tự cuối
                result = result.Substring(0, result.Length - 2);
            }
            return result;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // tạo hóa đơn: 
            //tạo hóa đơn tổng -> tạo chi tiết hóa đơn (thêm các xe vào hóa đơn, đồng thời cập nhật lại tình trạng xe thành đã bán)
            //-> tạo đơn hàng tương ứng với hóa đơn đó -> Cập nhật doanh số bán của nhân viên 

            List<string> allItems = new List<string>();
            List<string> allGiaBan = new List<string>();
            foreach (var item in listBoxXeDaChon.Items)
            {
                // Ép kiểu item thành DataRowView
                DataRowView dataRowView = item as DataRowView;
                if (dataRowView != null)
                {
                    // Lấy giá trị của trường "MaXe" và thêm vào danh sách
                    allItems.Add(dataRowView["MaXe"].ToString());
                    allGiaBan.Add(ConvertCommaToDot(dataRowView["GiaBan"].ToString()));
                }
            }





            string sql_Chen = $"EXEC InsertHoaDonBanHang {tBoxMHD.Text},N'{tBoxMKH.Text}',{tBoxMNV.Text}, { ConvertCommaToDot(tBoxTongTien.Text)},{ConvertCommaToDot(tBoxThue.Text)},{ConvertCommaToDot(tBoxChotTien.Text)},N'{tBoxDCGH.Text}'; ";

            try
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Kiểm tra lại toàn bộ thông tin trước khi tạo hóa đơn!",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if(allItems.Count == 0)
                {
                    throw new Exception("Vui lòng chọn 1 xe.");
                }
                if (thongbao == DialogResult.OK)
                {
                    kn.ThucThi(sql_Chen);

                    for (int i = 0; i < allItems.Count; i++)
                    {
                        string maXe = allItems[i];
                        string giaBan = allGiaBan[i];

                        // Tạo chuỗi SQL để gọi thủ tục InsertChiTietHoaDonBanHang
                        sql_Chen = $"EXEC InsertChiTietHoaDonBanHang @MaHoaDon = {tBoxMHD.Text}, @MaXe = {maXe}, @GiaBan = {giaBan}";

                        kn.ThucThi(sql_Chen);
                        sql_Chen = $"EXEC UpdateConHang {maXe}, 0";
                        kn.ThucThi(sql_Chen);
                    }

                    sql_Chen = $"EXEC InsertDonHang {tBoxMHD.Text}, N'{tBoxMKH.Text}'";
                    kn.ThucThi(sql_Chen);

                    sql_Chen = $"EXEC CapNhatDoanhSoBanHang {tBoxMNV.Text}";
                    kn.ThucThi(sql_Chen);



                }
                FrmXemHoaDon frm = new FrmXemHoaDon(tBoxMHD.Text);
                frm.Show();
                MessageBox.Show("Tạo hóa đơn thành công!");

               
            }
            catch (Exception err)
            {
              
                if(err.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Hóa đơn đã tồn tại, vui lòng xem lại Mã hóa đơn!");
                }else if (err.Message.Contains("'MaNhanVien'."))
                {
                    MessageBox.Show("Nhân viên không tồn tại, vui lòng xem lại mã nhân viên!");
                }else if (err.Message.Contains("'MaKhachHang'."))
                {
                    MessageBox.Show("Khách hàng không tồn tại, vui lòng xem lại mã khách hàng!");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }
           
            }

        }

        private void listBoxXeTrongKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void reload()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT * FROM Xe Where ConHang = 1 ");
            listBoxXeTrongKho.DataSource = dta;
            listBoxXeTrongKho.DisplayMember = "MaXe";
        }
        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            reload();
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxXeTrongKho.SelectedItem != null)
            {
                // Lấy item được chọn từ ListBox1
                var selectedItem = (DataRowView)listBoxXeTrongKho.SelectedItem;

                // Kiểm tra xem item đã có trong ListBox2 chưa
                if (!listBoxXeDaChon.Items.Contains(selectedItem))
                {
                    // Nếu chưa có, thêm item vào ListBox2
                    listBoxXeDaChon.Items.Add(selectedItem);
                    listBoxXeDaChon.DisplayMember = "MaXe";

                    // Lấy giá trị GiaBan từ selectedItem
                    decimal giaBan = Convert.ToDecimal(selectedItem["GiaBan"]);

                    // Cộng giá trị GiaBan vào tBoxTongTien
                    decimal currentTongTien = string.IsNullOrEmpty(tBoxTongTien.Text) ? 0 : Convert.ToDecimal(tBoxTongTien.Text);
                    decimal Final = currentTongTien + giaBan;
                    tBoxTongTien.Text = Final.ToString("N2"); // Định dạng giá trị với 2 chữ số thập phân
                    tBoxThue.Text = (Final * 0.12m).ToString("N2");
                    tBoxChotTien.Text = (Final + Final * 0.12m).ToString("N2");



                }
                else
                {
                    // Nếu đã có, hiển thị thông báo
                    MessageBox.Show("Xe đã tồn tại trong list!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 xe.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBoxXeDaChon.SelectedItem != null)
            {
                // Lấy item được chọn từ ListBox2
                var selectedItem = (DataRowView)listBoxXeDaChon.SelectedItem;

                // Lấy giá trị GiaBan từ selectedItem
                decimal giaBan = Convert.ToDecimal(selectedItem["GiaBan"]);

                // Trừ GiaBan khỏi tBoxTongTien
                decimal currentTongTien = string.IsNullOrEmpty(tBoxTongTien.Text) ? 0 : Convert.ToDecimal(tBoxTongTien.Text);
                decimal Final = currentTongTien - giaBan;
                

                tBoxTongTien.Text = (currentTongTien - giaBan).ToString("N2"); // Định dạng giá trị với 2 chữ số thập phân
                tBoxThue.Text = (Final * 0.12m).ToString("N2");
                tBoxChotTien.Text = (Final + Final * 0.12m).ToString("N2");
                // Xóa item khỏi ListBox2
                listBoxXeDaChon.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 xe.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
