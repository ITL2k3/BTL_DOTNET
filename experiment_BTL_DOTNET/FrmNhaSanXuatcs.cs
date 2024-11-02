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
    public partial class FrmNhaSanXuatcs : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        private string msnx;
        public FrmNhaSanXuatcs(string mnsx)
        {
            this.msnx = mnsx;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmNhaSanXuatcs_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM NhaCungCap WHERE MaNhaCungCap = '{msnx}'");
                tBoxDC.Text = dta.Rows[0]["DiaChi"].ToString();
                tBoxEmail.Text = dta.Rows[0]["Email"].ToString();
                tBoxGT.Text = dta.Rows[0]["SanPhamCungCap"].ToString();
                tBoxMNCC.Text = dta.Rows[0]["MaNhaCungCap"].ToString();
                tBoxSDT.Text = dta.Rows[0]["SoDienThoai"].ToString();
                tBoxTNCC.Text = dta.Rows[0]["TenNhaCungCap"].ToString();
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Đề nghị xem lại mã số nhà sản xuất!");
                Close();
            }
        }
    }
    
}
