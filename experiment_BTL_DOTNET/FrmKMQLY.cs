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
    public partial class FrmKMQLY : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmKMQLY()
        {
            InitializeComponent();
        }

        private void tBoxMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void reloadKM()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT * FROM KhuyenMai");
            dataGridView1.DataSource = dta;
        }
        private void hienThiDuLieu()
        {
            tBoxDKAD.DataBindings.Clear();
            tBoxMKM.DataBindings.Clear();
            tBoxMoTa.DataBindings.Clear();
            tBoxTCT.DataBindings.Clear();
            tBoxTGAD.DataBindings.Clear();
            tBoxDKAD.DataBindings.Add("Text", dataGridView1.DataSource, "DieuKienApDung");
            tBoxMKM.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhuyenMai");
            tBoxMoTa.DataBindings.Add("Text", dataGridView1.DataSource, "MoTa");
            tBoxTCT.DataBindings.Add("Text", dataGridView1.DataSource, "TenChuongTrinh");
            tBoxTGAD.DataBindings.Add("Text", dataGridView1.DataSource, "ThoiGianApDung");
        }
        private void tBoxMaKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
            private void FrmKMQLY_Load(object sender, EventArgs e)
        {
            try
            {
                tBoxMKM.KeyPress += tBoxMaKM_KeyPress;

                reloadKM();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            tBoxDKAD.Text = "";
            tBoxMKM.Text = "";
            tBoxMoTa.Text = "";
            tBoxTCT.Text = "";
            tBoxTGAD.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql_Chen = $" EXEC InsertKhuyenMai {tBoxMKM.Text}, N'{tBoxTCT.Text}', N'{tBoxMoTa.Text}', N'{tBoxTGAD.Text}', N'{tBoxDKAD.Text}';";
            try
            {
                kn.ThucThi(sql_Chen);


                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM KhuyenMai");

                dataGridView1.DataSource = dta;
                hienThiDuLieu();

            }
            catch (Exception err)
            {
                if (err.Message.Contains("PRIMARY KEY") || err.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Mã khuyến mãi đã tồn tại");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }
            }

           
        }

        private void btnSKM_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_sua = $"EXEC UpdateKhuyenMai {tBoxMKM.Text}, N'{tBoxTCT.Text}', N'{tBoxMoTa.Text}', N'{tBoxTGAD.Text}', N'{tBoxDKAD.Text}'; ";
                kn.ThucThi(sql_sua);
                reloadKM();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                if (err.Message.Contains("FOREIGN KEY"))
                {
                    MessageBox.Show("Nhà sản xuất không tồn tại, đề nghị xem lại mã nhà sản xuất!");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }


            }
        }

        private void btnXKM_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Xóa khuyến mãi sẽ xóa toàn bộ dữ liệu liên quan đến khuyến mãi, bạn có muốn xóa dữ liệu không?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (thongbao == DialogResult.OK)
                {
                    string sql_xoa = $"EXEC DeleteKhuyenMai {tBoxMKM.Text} ";
                    kn.ThucThi(sql_xoa);
                    reloadKM();
                    hienThiDuLieu();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reloadKM();
            hienThiDuLieu();
        }
    }
}
