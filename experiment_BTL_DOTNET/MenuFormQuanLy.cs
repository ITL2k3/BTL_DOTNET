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
    public partial class MenuFormQuanLy : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        string mnv;
        private int childFormNumber = 0;

        public MenuFormQuanLy(string mnv)
        {
            this.mnv = mnv;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

   

       

     
        



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            string sql_LayThongTinNhanVien = $"EXEC LayThongTin_NhanVien {this.mnv}";
            DataTable dta = new DataTable();

            dta = kn.Lay_Dulieu(sql_LayThongTinNhanVien);

            txtMNV.Text = dta.Rows[0]["MaNhanVien"].ToString();
            txtHoVaTen.Text = dta.Rows[0]["HoVaTen"].ToString();
            txtEmail.Text = dta.Rows[0]["Email"].ToString();


        }
    }
}
