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
    public partial class FrmChiTietHoaDon : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        private string mhd;
        public FrmChiTietHoaDon(string mhd)
        {
            this.mhd = mhd;
            InitializeComponent();
        }

        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            try
            {

                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM ChiTietHoaDonBanHang Where MaHoaDon = {this.mhd}; ");
                dataGridView1.DataSource = dta;
                tBoxMHD.Text = dta.Rows[0]["MaHoaDon"].ToString();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}
