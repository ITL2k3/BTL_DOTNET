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
    public partial class FrmSuaTTQLY : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        private string mnv;
        public FrmSuaTTQLY(string mnv)
        {
            this.mnv = mnv;
            InitializeComponent();
        }

        private void FrmSuaTTQLY_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT TaiKhoan.MaNhanVien, TaiKhoan.MatKhau,NhanVien.SoDienThoai,TaiKhoan.TenTaiKhoan,NhanVien.Email,NhanVien.HoVaTen FROM NHANVIEN JOIN Taikhoan ON NhanVien.MaNhanVien = TaiKhoan.MaNhanVien WHERE TaiKhoan.MaNhanVien = '{this.mnv}'");
                tBoxMK.Text = dta.Rows[0]["MatKhau"].ToString();
                tBoxSDT.Text = dta.Rows[0]["SoDienThoai"].ToString();
                tBoxTK.Text = dta.Rows[0]["TenTaiKhoan"].ToString();
                txtEmail.Text = dta.Rows[0]["Email"].ToString();
                txtHoVaTen.Text = dta.Rows[0]["HoVaTen"].ToString();
                txtMNV.Text = dta.Rows[0]["MaNhanVien"].ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql_Chen = $"EXEC sp_UpdateNhanVienAndTaiKhoan {txtMNV.Text}, N'{txtHoVaTen.Text}', N'{tBoxSDT.Text}', N'{txtEmail.Text}',N'{tBoxMK.Text}' ; ";
            try
            {
                kn.ThucThi(sql_Chen);

                MessageBox.Show("Cập nhật thông tin thành công!");
                this.Close();



            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
