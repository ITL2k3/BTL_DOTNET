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
    public partial class FrmBCTK : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmBCTK()
        {
            InitializeComponent();
        }

        private void FrmBCTK_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM HoaDonBanHang;";
            try
            {
                DataTable dta = new DataTable();
                BCTK hd = new BCTK();
                dta = kn.Lay_Dulieu(sql);
                hd.SetDataSource(dta);
                crystalReportViewer2.ReportSource = hd;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                MessageBox.Show(sql);
            }
        }
    }
}
