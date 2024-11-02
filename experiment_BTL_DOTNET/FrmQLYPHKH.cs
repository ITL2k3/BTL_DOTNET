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
    public partial class FrmQLYPHKH : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmQLYPHKH()
        {
            InitializeComponent();
        }
        private void reload()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT * FROM PhanHoiKhachHang");
            dataGridView1.DataSource = dta;
        }
        private void hienThiDuLieu()
        {
            tBoxMaPhanHoi.DataBindings.Clear();
            tBoxBL.DataBindings.Clear();
            tBoxMaXe.DataBindings.Clear();
            tBoxMKH.DataBindings.Clear();
            cBoxDgia.DataBindings.Clear();

            tBoxMaPhanHoi.DataBindings.Add("Text", dataGridView1.DataSource, "MaPhanHoi");
            tBoxMKH.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhachHang");
            tBoxBL.DataBindings.Add("Text", dataGridView1.DataSource, "BinhLuan");
            tBoxMaXe.DataBindings.Add("Text", dataGridView1.DataSource, "MaXe");
            cBoxDgia.DataBindings.Add("Text", dataGridView1.DataSource, "DanhGia");
        }
        private void FrmQLYPHKH_Load(object sender, EventArgs e)
        {
            try
            {

                reload();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Bạn có muốn xóa phản hồi này không?",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (thongbao == DialogResult.OK)
                {
                    string sql_xoa = $"EXEC XoaPhanHoiKhachHang {tBoxMaPhanHoi.Text} ";
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
            hienThiDuLieu();
        }
    }
}
