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
    public partial class FrmQlyXe : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmQlyXe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void reloadXe()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT * FROM Xe");
            dataGridView1.DataSource = dta;
        }
        private void hienThiDuLieu()
        {
            tBoxMaXe.DataBindings.Clear();
            tBoxMaXe.DataBindings.Add("Text", dataGridView1.DataSource, "MaXe");
            tBoxNhaSX.DataBindings.Clear();
            tBoxNhaSX.DataBindings.Add("Text", dataGridView1.DataSource, "NhaSanXuat");
            tBoxMauXe.DataBindings.Clear();
            tBoxMauXe.DataBindings.Add("Text", dataGridView1.DataSource, "MauXe");
            tBoxNamSX.DataBindings.Clear();
            tBoxNamSX.DataBindings.Add("Text", dataGridView1.DataSource, "NamSanXuat");
            tBoxGiaBan.DataBindings.Clear();
            tBoxGiaBan.DataBindings.Add("Text", dataGridView1.DataSource, "GiaBan");
            tBoxTinhTrang.DataBindings.Clear();
            tBoxTinhTrang.DataBindings.Add("Text", dataGridView1.DataSource, "TinhTrang");
            tBoxMauSac.DataBindings.Clear();
            tBoxMauSac.DataBindings.Add("Text", dataGridView1.DataSource, "MauSac");
            tBoxSoKM.DataBindings.Clear();
            tBoxSoKM.DataBindings.Add("Text", dataGridView1.DataSource, "SoKM");
            tBoxTinhNang.DataBindings.Clear();
            tBoxTinhNang.DataBindings.Add("Text", dataGridView1.DataSource, "TinhNang");

            cBoxConXe.DataBindings.Clear();
            cBoxConXe.DataBindings.Add("Text", dataGridView1.DataSource, "ConHang");
        }
        private void tBoxSoKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                if (tBoxSoKM.Text.Contains('.') || tBoxSoKM.Text.Contains(','))
                {
                    e.Handled = true;
                }
            }
        }
        private void tBoxGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }

            if (e.KeyChar == '.' )
            {
                if (tBoxGiaBan.Text.Contains('.') || tBoxGiaBan.Text.Contains(','))
                {
                    e.Handled = true; 
                }
            }
        }
        private void tBoxMaXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            
        }
        private void FrmQlyXe_Load(object sender, EventArgs e)
        {
            try
            {
                tBoxMaXe.KeyPress += tBoxMaXe_KeyPress;
                tBoxGiaBan.KeyPress += tBoxGiaBan_KeyPress;
                tBoxSoKM.KeyPress += tBoxSoKM_KeyPress;
                reloadXe();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTMX_Click(object sender, EventArgs e)
        {
            tBoxMaXe.Text = "";
            tBoxNhaSX.Text = "";
            tBoxMauXe.Text = "";
            tBoxNamSX.Text = "";
            tBoxGiaBan.Text = "";
            tBoxTinhTrang.Text = "";
            tBoxMauSac.Text = "";
            tBoxSoKM.Text = "";
            tBoxTinhNang.Text ="";

        }
        public string ConvertCommaToDot(string input)
        {
            // Kiểm tra nếu chuỗi không rỗng hoặc null
            if (string.IsNullOrEmpty(input))
            {
                return input; // Trả về chuỗi gốc nếu nó rỗng hoặc null
            }

            // Thay thế dấu phẩy bằng dấu chấm
            string output = input.Replace(',', '.');

            return output;
        }
        private void btnThemXe_Click(object sender, EventArgs e)
        {
            
            string numOfCost = ConvertCommaToDot(tBoxGiaBan.Text);
            string numOfKM = "0";
            
            if(tBoxSoKM.Text != "")
            {
                numOfKM = tBoxSoKM.Text;
            }
            string sql_Chen = $"EXEC InsertXe {tBoxMaXe.Text}, N'{tBoxNhaSX.Text}', N'{tBoxMauXe.Text}', {tBoxNamSX.Text}, {numOfCost}, N'{tBoxTinhTrang.Text}', N'{tBoxMauSac.Text}', {numOfKM}, N'{tBoxTinhNang.Text}', {cBoxConXe.SelectedItem}; ";
            try
            {
                kn.ThucThi(sql_Chen);


                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM Xe");

                dataGridView1.DataSource = dta;
                hienThiDuLieu();

            }
            catch (Exception err)
            {
                if (err.Message.Contains("PRIMARY KEY") || err.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Xe đã tồn tại");
                }else if (err.Message.Contains("FOREIGN KEY"))
                {
                    MessageBox.Show("Nhà sản xuất không tồn tại, đề nghị xem lại mã nhà sản xuất!");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnCNX_Click(object sender, EventArgs e)
        {
            string numOfCost = ConvertCommaToDot(tBoxGiaBan.Text);
            string numOfKM = "0";

            if (tBoxSoKM.Text != "")
            {
                numOfKM = tBoxSoKM.Text;
            }
            try
            {
                string sql_sua = $"EXEC UpdateXe {tBoxMaXe.Text}, N'{tBoxNhaSX.Text}', N'{tBoxMauXe.Text}', {tBoxNamSX.Text}, {numOfCost}, N'{tBoxTinhTrang.Text}', N'{tBoxMauSac.Text}', {numOfKM}, N'{tBoxTinhNang.Text}', {cBoxConXe.SelectedItem}; ";
                kn.ThucThi(sql_sua);
                reloadXe();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                if(err.Message.Contains("FOREIGN KEY"))
                {
                    MessageBox.Show("Nhà sản xuất không tồn tại, đề nghị xem lại mã nhà sản xuất!");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }

               
            }
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Xóa xe sẽ xóa toàn bộ dữ liệu liên quan đến xe, bạn có muốn xóa dữ liệu không?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (thongbao == DialogResult.OK)
                {
                    string sql_xoa = $"EXEC DeleteXe {tBoxMaXe.Text} ";
                    kn.ThucThi(sql_xoa);
                    reloadXe();
                    hienThiDuLieu();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNhaSanXuatcs FRM1 = new FrmNhaSanXuatcs(tBoxNhaSX.Text);
            FRM1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reloadXe();
            hienThiDuLieu();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
