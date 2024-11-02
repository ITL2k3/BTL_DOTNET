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
    public partial class FrmQlyNCC : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmQlyNCC()
        {
            InitializeComponent();
        }
        private void reloadNCC()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT * FROM NhaCungCap");
            dataGridView1.DataSource = dta;
        }
        private void hienThiDuLieu()
        {
            tBoxDC.DataBindings.Clear();
            tBoxEmail.DataBindings.Clear();
            tBoxGT.DataBindings.Clear();
            tBoxMNCC.DataBindings.Clear();
            tBoxSDT.DataBindings.Clear();
            tBoxTNCC.DataBindings.Clear();

            tBoxDC.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChi");
            tBoxEmail.DataBindings.Add("Text", dataGridView1.DataSource, "Email");
            tBoxGT.DataBindings.Add("Text", dataGridView1.DataSource, "SanPhamCungCap");
            tBoxMNCC.DataBindings.Add("Text", dataGridView1.DataSource, "MaNhaCungCap");
            tBoxSDT.DataBindings.Add("Text", dataGridView1.DataSource, "SoDienThoai");
            tBoxTNCC.DataBindings.Add("Text", dataGridView1.DataSource, "TenNhaCungCap");
        }

        private void FrmQlyNCC_Load(object sender, EventArgs e)
        {
            try
            {
                
                reloadNCC();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            tBoxDC.Text = "";
            tBoxEmail.Text = "";
            tBoxGT.Text = "";
            tBoxMNCC.Text = "";
            tBoxSDT.Text = "";
            tBoxTNCC.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

    
            string sql_Chen = $"EXEC InsertNhaCungCap '{tBoxMNCC.Text}', N'{tBoxTNCC.Text}', N'{tBoxDC.Text}', '{tBoxSDT.Text}', '{tBoxEmail.Text}', N'{tBoxGT.Text}'; ";
            try
            {
                kn.ThucThi(sql_Chen);


                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT * FROM NhaCungCap");

                dataGridView1.DataSource = dta;
                hienThiDuLieu();

            }
            catch (Exception err)
            {
                if (err.Message.Contains("PRIMARY KEY") || err.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại");
                }
                
                else
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_sua = $"EXEC  UpdateNhaCungCap '{tBoxMNCC.Text}', N'{tBoxTNCC.Text}', N'{tBoxDC.Text}', '{tBoxSDT.Text}', '{tBoxEmail.Text}', N'{tBoxGT.Text}'; ";
                kn.ThucThi(sql_sua);
                reloadNCC();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                if (err.Message.Contains("FOREIGN KEY"))
                {
                    MessageBox.Show("Nhà sản xuất không tồn tại, đề nghị xem lại mã nhà sản xuất!");
                }
                else
                {
                    MessageBox.Show(err.Message);
                }


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Xóa nhà cung cấp sẽ xóa tất cả mọi thông tin bao gồm tất cả các xe, hóa đơn thuộc nhà cung cấp, bạn có chắc chắn muốn xóa không? ",
                    "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (thongbao == DialogResult.OK)
                {
                    string sql_xoa = $"EXEC XoaNhaCungCap {tBoxMNCC.Text} ";
                    kn.ThucThi(sql_xoa);
                    reloadNCC();
                    hienThiDuLieu();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reloadNCC();
            hienThiDuLieu();
        }
    }
}
