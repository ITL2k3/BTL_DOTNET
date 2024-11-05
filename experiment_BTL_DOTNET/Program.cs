using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experiment_BTL_DOTNET
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new FrmQlyThongTinKH());
            //Application.Run(new FrmQLYPHKH());
            //Application.Run(new FrmDatHang());
            //Application.Run(new FrmXemHoaDon("6"));
            //Application.Run(new FrmBCTK());
            //Application.Run(new FrmQlyHD());

        }
    }
}
