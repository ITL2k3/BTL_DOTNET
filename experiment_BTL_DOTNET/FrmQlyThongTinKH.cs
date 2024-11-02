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
    public partial class FrmQlyThongTinKH : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmQlyThongTinKH()
        {
            InitializeComponent();
        }

        private void hienThiDuLieu()
        {
            tBoxMKH.DataBindings.Clear();
            tBoxMKH.DataBindings.Add("Text", dataGridView2.DataSource, "MaKhachHang");
            tBoxHvT.DataBindings.Clear();
            tBoxHvT.DataBindings.Add("Text", dataGridView2.DataSource, "HoVaTen");
            tBoxNS.DataBindings.Clear();
            tBoxNS.DataBindings.Add("Text", dataGridView2.DataSource, "NgaySinh");
            tBoxDC.DataBindings.Clear();
            tBoxDC.DataBindings.Add("Text", dataGridView2.DataSource, "DiaChi");
            tBoxSDT.DataBindings.Clear();
            tBoxSDT.DataBindings.Add("Text", dataGridView2.DataSource, "SoDienThoai");
            tBoxEmail.DataBindings.Clear();
            tBoxEmail.DataBindings.Add("Text", dataGridView2.DataSource, "Email");
            cBoxGT.DataBindings.Clear();
            cBoxGT.DataBindings.Add("Text", dataGridView2.DataSource, "GioiTinh");
            tBoxLSMH.DataBindings.Clear();
            tBoxLSMH.DataBindings.Add("Text", dataGridView2.DataSource, "LichSuMuaHang");
        }

        private void reloadKH()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT * FROM KhachHang");
            dataGridView2.DataSource = dta;
        }
        private void FrmQlyThongTinKH_Load(object sender, EventArgs e)
        {
            try
            {
                cBoxGT.DropDownStyle = ComboBoxStyle.DropDownList;
                reloadKH();
                hienThiDuLieu();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
           

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            tBoxMKH.Text = "";
            tBoxHvT.Text = "";
            tBoxNS.Text = "";
            tBoxDC.Text = "";
            tBoxSDT.Text = "";
            tBoxEmail.Text = "";
            cBoxGT.SelectedIndex = -1;  // Xóa lựa chọn hiện tại
            tBoxLSMH.Text = "";

            
            //reloadKH();
            //hienThiDuLieu();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonTKH_Click(object sender, EventArgs e)
        {
            
            string sql_Chen = $"EXEC ThemkhachHang N'{tBoxMKH.Text}',N'{tBoxHvT.Text}','{tBoxNS.Text}', N'{ tBoxDC.Text}','{tBoxSDT.Text}','{tBoxEmail.Text}',N'{cBoxGT.SelectedItem}', N'{tBoxLSMH.Text}'; ";
            try
            {
                kn.ThucThi(sql_Chen);


                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM KhachHang");

                dataGridView2.DataSource = dta;
                hienThiDuLieu();

            }
            catch (Exception err)
            {
                if (err.Message.Contains("PRIMARY KEY") || err.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Khách hàng đã tồn tại");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reloadKH();
            hienThiDuLieu();
        }

        private void btnSKH_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_sua = $"EXEC UpdateKhachhang N'{tBoxMKH.Text}',N'{tBoxHvT.Text}','{tBoxNS.Text}', N'{ tBoxDC.Text}','{tBoxSDT.Text}','{tBoxEmail.Text}',N'{cBoxGT.SelectedItem}', N'{tBoxLSMH.Text}'; ";
                kn.ThucThi(sql_sua);
                reloadKH();
                hienThiDuLieu();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnXKH_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Xóa khách hàng sẽ xóa toàn bộ dữ liệu liên quan đến khách hàng, bạn có muốn xóa dữ liệu không?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (thongbao == DialogResult.OK)
                {
                    string sql_xoa = $"EXEC XoaKhachHang '{tBoxMKH.Text}' ";
                    kn.ThucThi(sql_xoa);
                    reloadKH();
                    hienThiDuLieu();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnTKKH_Click(object sender, EventArgs e)
        {
            FrmTimKiemKH frm1 = new FrmTimKiemKH();
            frm1.Show();
        }
    }
}
