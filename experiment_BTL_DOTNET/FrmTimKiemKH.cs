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
    public partial class FrmTimKiemKH : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public FrmTimKiemKH()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTimKiemKH_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu("SELECT * FROM KHACHHANG");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataTable dta = new DataTable();
                string Sql_tk = "";

                if (optNhapMKH.Checked == true)
                {
                    Sql_tk = $"SELECT * FROM KhachHang WHERE MaKhachHang = '{tBoxMKH.Text}';";
                }
                else if (optTenKH.Checked == true)
                {
                    Sql_tk = $"SELECT * FROM KhachHang WHERE HoVaTen LIKE '%' + N'{tBoxTKH.Text}' + '%';";
                }
                else if (optSDT.Checked == true)
                {
                    Sql_tk = $"SELECT * FROM KhachHang WHERE SoDienThoai = '{tBoxSDT.Text}';";

                }
                else
                {
                    Sql_tk = $"SELECT * FROM KhachHang WHERE email = '{tBoxEmail.Text}'";
                }
                dta = kn.Lay_Dulieu(Sql_tk);
                dataGridView1.DataSource = dta;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            

        }

        private void optNhapMKH_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
