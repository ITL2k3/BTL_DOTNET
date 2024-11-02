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
    public partial class FrmThemNhanVien_TK : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        private string mnv;
        private string hvt;
        private string vtcv;
        private string sdt;
        private string email;
      
        

        public FrmThemNhanVien_TK(string mnv, string hvt, string vtcv, string sdt, string email)
        {
            this.mnv = mnv;
            this.hvt = hvt;
            this.vtcv = vtcv;
            this.sdt = sdt;
            this.email = email;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string sql_Chen = $"EXEC ThemNhanVien {tBoxMNV.Text}, N'{tBoxHvT.Text}', N'{tBoxVTCV.Text}', N'{tBoxSDT.Text}', N'{tBoxEmail.Text}', 0,N'{tBoxTTK.Text}', N'{tBoxMK.Text}', 'B'; ";
            try
            {
                kn.ThucThi(sql_Chen);


                MessageBox.Show("Thêm nhân viên và tạo tài khoản thành công!");
                this.Close();
            }
            catch (Exception err)
            {
                if (err.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Nhân viên đã tồn tại ");
                }
                else if (err.Message.Contains("UNIQUE KEY"))
                {
                    MessageBox.Show("Số điện thoại hoặc email đã tồn tại, đề nghị xem lại!");
                }else
                {
                    MessageBox.Show(err.Message);
                }
                this.Close();
            }
        }

        private void FrmThemNhanVien_TK_Load(object sender, EventArgs e)
        {
            tBoxEmail.Text = this.email;
            tBoxHvT.Text = this.hvt;
            tBoxMNV.Text = this.mnv;
            tBoxSDT.Text = this.sdt;
            tBoxVTCV.Text = this.vtcv;
        }
    }
}
