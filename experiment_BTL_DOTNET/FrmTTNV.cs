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
    public partial class FrmTTNV : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public FrmTTNV()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxMNV_TextChanged(object sender, EventArgs e)
        {

        }
        private void reload()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT NhanVien.MaNhanVien, HoVaTen, ViTriCongViec, SoDienThoai, Email, DoanhSoBanHang FROM NhanVien JOIN TaiKhoan ON NhanVien.MaNhanVien = TaiKhoan.MaNhanVien  WHERE TaiKhoan.PhanQuyen = 'B' ");
            dataGridView1.DataSource = dta;
        }
        private void hienThiDuLieu()
        {
            tBoxDS.DataBindings.Clear();
            tBoxEmail.DataBindings.Clear();
            tBoxHvT.DataBindings.Clear();
            tBoxMNV.DataBindings.Clear();
            tBoxSDT.DataBindings.Clear();
            tBoxVTCV.DataBindings.Clear();

            tBoxDS.DataBindings.Add("Text", dataGridView1.DataSource, "DoanhSoBanHang");
            tBoxMNV.DataBindings.Add("Text", dataGridView1.DataSource, "MaNhanVien");
            tBoxEmail.DataBindings.Add("Text", dataGridView1.DataSource, "Email");
            tBoxHvT.DataBindings.Add("Text", dataGridView1.DataSource, "HoVaTen");
            tBoxSDT.DataBindings.Add("Text", dataGridView1.DataSource, "SoDienThoai");
            tBoxVTCV.DataBindings.Add("Text", dataGridView1.DataSource, "ViTriCongViec");



        }
        private void tBoxNumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }


        private void FrmTTNV_Load(object sender, EventArgs e)
        {
            try
            {
                tBoxSDT.KeyPress += tBoxNumOnly_KeyPress;
                tBoxMNV.KeyPress += tBoxNumOnly_KeyPress;


                reload();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTaiKhoanDuocCap frm = new FrmTaiKhoanDuocCap(tBoxMNV.Text);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tBoxDS.Text = "0";
            tBoxEmail.Text = "";
            tBoxHvT.Text = "";
            tBoxMNV.Text = "";
            tBoxSDT.Text = "";
            tBoxVTCV.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tBoxDS.Text = "";
            tBoxEmail.Text = "";
            tBoxHvT.Text = "";
            tBoxMNV.Text = "";
            tBoxSDT.Text = "";
            tBoxVTCV.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien_TK frm = new FrmThemNhanVien_TK(tBoxMNV.Text, tBoxHvT.Text, tBoxVTCV.Text, tBoxSDT.Text, tBoxEmail.Text);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reload();
            hienThiDuLieu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_sua = $"EXEC CapNhatNhanVien {tBoxMNV.Text}, N'{tBoxHvT.Text}', N'{tBoxVTCV.Text}', '{tBoxSDT.Text}', '{tBoxEmail.Text}', {tBoxDS.Text}; ";
                kn.ThucThi(sql_sua);
                reload();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Xóa nhân viên sẽ xóa toàn bộ dữ liệu liên quan đến nhân viên bao gồm tài khoản và hóa đơn, bạn có muốn xóa dữ liệu không?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (thongbao == DialogResult.OK)
                {
                    string sql_xoa = $"EXEC XoaNhanVien {tBoxMNV.Text} ";
                    kn.ThucThi(sql_xoa);
                    reload();
                    hienThiDuLieu();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
