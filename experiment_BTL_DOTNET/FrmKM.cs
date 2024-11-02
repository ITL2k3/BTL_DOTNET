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
    public partial class FrmKM : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmKM()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void reloadKM()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT * FROM KhuyenMai");
            dataGridView1.DataSource = dta;
        }
        private void hienThiDuLieu()
        {
            tBoxDKAD.DataBindings.Clear();
            tBoxMKM.DataBindings.Clear();
            tBoxMoTa.DataBindings.Clear();
            tBoxTCT.DataBindings.Clear();
            tBoxTGAD.DataBindings.Clear();
            tBoxDKAD.DataBindings.Add("Text", dataGridView1.DataSource, "DieuKienApDung");
            tBoxMKM.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhuyenMai");
            tBoxMoTa.DataBindings.Add("Text", dataGridView1.DataSource, "MoTa");
            tBoxTCT.DataBindings.Add("Text", dataGridView1.DataSource, "TenChuongTrinh");
            tBoxTGAD.DataBindings.Add("Text", dataGridView1.DataSource, "ThoiGianApDung");
        }
        private void FrmKM_Load(object sender, EventArgs e)
        {
            try
            {
                reloadKM();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
