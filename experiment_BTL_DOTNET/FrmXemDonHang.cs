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
    public partial class FrmXemDonHang : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmXemDonHang()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmXemDonHang_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Chưa thanh toán");
            comboBox1.Items.Add("Đã thanh toán");
            comboBox1.Items.Add("Đã hủy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM DONHANG WHERE MaDonHang = {textBox1.Text}");

                
                if (dta.Rows.Count > 0)
                {
                    string tinhTrang = dta.Rows[0]["TinhTrangDonHang"].ToString().Trim();
                    textBox2.Text = dta.Rows[0]["MaKhachHang"].ToString();
                    textBox3.Text = dta.Rows[0]["NgayDatHang"].ToString();
                    // Nếu tinhTrang không có trong ComboBox, có thể thêm vào
                    if (!comboBox1.Items.Contains(tinhTrang))
                    {
                        comboBox1.Items.Add(tinhTrang);
                    }

                    // Đặt giá trị cho ComboBox
                    comboBox1.SelectedItem = tinhTrang; // Chọn item tương ứng với giá trị trong DataTable
                }
                else
                {
                    MessageBox.Show("Đơn hàng không tồn tại, kiểm tra lại mã hóa đơn!");
                }
            }
            catch (Exception err)
            {
                 if(err.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Đơn hàng không tồn tại!");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_sua = $"EXEC usp_UpdateTinhTrangDonHang {textBox1.Text}, N'{comboBox1.SelectedItem}'; ";
                kn.ThucThi(sql_sua);
                
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);


            }
        }
    }
}
