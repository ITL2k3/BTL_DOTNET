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
    public partial class FrmPHKH : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmPHKH()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
       
        private void FrmPHKH_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql_chen = $"EXEC ThemPhanHoiKhachHang '{tBoxMKH.Text}', {tBoxMaXe.Text}, {cBoxDgia.SelectedIndex}, N'{tBoxBL.Text}';";
            try
            {
                kn.ThucThi(sql_chen);
                MessageBox.Show("Thêm phản hồi thành công!");
            }
            catch(Exception err)
            {
                if (err.Message.Contains("MaXe"))
                {
                    MessageBox.Show("Xe không tồn tại, đề nghị kiểm tra lại mã xe!");
                }else if (err.Message.Contains("MaKhachHang"))
                {
                    MessageBox.Show("Khách hàng không tồn tại trong hệ thống, đề nghị xem lại mã khách hàng");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }
                

            }
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            tBoxBL.Text = "";
            tBoxMaXe.Text = "";
            tBoxMKH.Text = "";
            
            
        }
    }
}
