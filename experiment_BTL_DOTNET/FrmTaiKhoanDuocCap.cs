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
    public partial class FrmTaiKhoanDuocCap : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        private string mnv;
        public FrmTaiKhoanDuocCap(string mnv)
        {
            this.mnv = mnv;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void FrmTaiKhoanDuocCap_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM Taikhoan WHERE MaNhanVien = '{this.mnv}'");
                tBoxTTK.Text = dta.Rows[0]["TenTaiKhoan"].ToString();
                tBoxMK.Text = dta.Rows[0]["MatKhau"].ToString();
                tBoxMNV.Text = dta.Rows[0]["MaNhanVien"].ToString();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            string sql_Chen = $"EXEC CapNhatMatKhauTheoMaNhanVien {this.mnv}, '{tBoxMK.Text}' ; ";
            try
            {
                kn.ThucThi(sql_Chen);

                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
               


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
