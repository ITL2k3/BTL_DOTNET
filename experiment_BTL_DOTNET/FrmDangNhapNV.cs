using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace experiment_BTL_DOTNET
{
    public partial class FrmDangNhapNV : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        String role = "B";
        public FrmDangNhapNV(string role)
        {
            this.role = role;
            InitializeComponent();
        }


        private void FrmDangNhapNV_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string tk = txtTK.Text;
            string mk = txtMK.Text;

            string sql_login = $"EXEC DANG_NHAP @TenTaiKhoan='{tk}', @MatKhau='{mk}', @PhanQuyen='{this.role}';";
            DataTable dta = new DataTable();

            dta = kn.Lay_Dulieu(sql_login);

             if (dta.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                string mnv = dta.Rows[0]["MaNhanVien"].ToString();
                if(role == "B")//init form nhân viên
                {
                    MenuFormNhanVien frm1 = new MenuFormNhanVien(mnv);
                    this.Hide();
                    frm1.ShowDialog();

                }
                else //init form quản lý
                {
                    MenuFormQuanLy frm2 = new MenuFormQuanLy(mnv);
                    this.Hide();
                    frm2.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
            

        }
    }
}
