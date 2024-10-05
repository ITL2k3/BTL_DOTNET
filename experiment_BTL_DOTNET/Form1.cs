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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmDangNhapNV FrmDNNV = new FrmDangNhapNV("B");
            this.Hide();
            if (FrmDNNV.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            FrmDangNhapNV FrmDNNV = new FrmDangNhapNV("Q");
            this.Hide();
            if (FrmDNNV.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
    }
}
