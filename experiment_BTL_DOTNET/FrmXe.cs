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
    public partial class FrmXe : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmXe()
        {
            InitializeComponent();
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
            tBoxConHang.DataBindings.Clear();
            tBoxConHang.DataBindings.Add("Text", dataGridView1.DataSource, "ConHang");

            if (tBoxConHang.Text == "1")
            {

                tBoxHienThiConHang.Text = "Còn Hàng";
            }
            else if (tBoxConHang.Text == "0")
            {
                tBoxHienThiConHang.Text = "Đã bán";
            }
            else
            {
                tBoxHienThiConHang.Text = ""; // Xử lý trường hợp khác nếu cần
            }

            tBoxConHang.TextChanged += (sender, e) =>
            {
                if (tBoxConHang.Text == "1")
                {
                    tBoxHienThiConHang.Text = "Còn Hàng";
                }
                else if (tBoxConHang.Text == "0")
                {
                    tBoxHienThiConHang.Text = "Đã bán";
                   
                }
                else
                {
                    tBoxHienThiConHang.Text = ""; // Xử lý trường hợp khác nếu cần
                }
            };
        }

        private void FrmXe_Load(object sender, EventArgs e)
        {
            try
            {
               
                reloadXe();
                hienThiDuLieu();
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

        private void tBoxConHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
