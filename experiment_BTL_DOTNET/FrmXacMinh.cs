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
    public partial class FrmXacMinh : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        private string mnv;
        public FrmXacMinh(string mnv)
        {

            this.mnv = mnv;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM TaiKhoan WHERE MaNhanVien = {this.mnv} AND TenTaiKhoan = '{tBoxTK.Text}' AND MatKhau = '{tBoxMK.Text}'");
                if(dta.Rows.Count == 0)
                {
                    throw new Exception("Sai thông tin!");
                }
                
                
                    FrmSuaTTQLY frm = new FrmSuaTTQLY(this.mnv);
                    frm.Show();
                this.Close();
                
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Close();
            }
        }
    }
}
