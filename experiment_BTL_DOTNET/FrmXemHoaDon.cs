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
    public partial class FrmXemHoaDon : Form
    {
        private string mhd = "5";
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmXemHoaDon(string mhd)
        {
            this.mhd = mhd;
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void FrmXemHoaDon_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT * from HoaDonBanHang join ChiTietHoaDonBanHang ON HoaDonBanHang.MaHoaDon = ChiTietHoaDonBanHang.MaHoaDon JOIN KhachHang ON HoaDonBanHang.MaKhachHang = KhachHang.MaKhachHang WHERE HoaDonBanHang.MaHoaDon = {this.mhd};";
            try
            {
                DataTable dta = new DataTable();
                HoaDon hd = new HoaDon();
                dta = kn.Lay_Dulieu(sql);
                hd.SetDataSource(dta);
                crystalReportViewer1.ReportSource = hd;

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                MessageBox.Show(sql);
            }
            
        }
    }
}
