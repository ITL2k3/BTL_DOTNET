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
    public partial class FrmTimHoaDon : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL(); 
        public FrmTimHoaDon()
        {
            InitializeComponent();
        }

        private void FrmTimHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM HoaDonBanHang WHERE MaHoaDon = {textBox1.Text}");
                if(dta.Rows.Count > 0)
                {
                    FrmXemHoaDon frm = new FrmXemHoaDon(textBox1.Text);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hóa đơn không tồn tại!");
                }
                
            }
            catch(Exception err)
            {
                if(err.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Hóa đơn không tồn tại!");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }
            }

            
        }
    }
}
