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
    public partial class FrmQlyHD : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
        public FrmQlyHD()
        {
            InitializeComponent();
        }
        private void reload()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_Dulieu($"SELECT HoaDonBanHang.MaHoaDon,HoaDonBanHang.NgayBan,HoaDonBanHang.MaKhachHang,HoaDonBanHang.MaNhanVien,HoaDonBanHang.GiaBan,HoaDonBanHang.Thue,HoaDonBanHang.TongTien,HoaDonBanHang.DiaChiGiaoHang,DonHang.TinhTrangDonHang AS TinhTrang FROM HoaDonBanHang JOIN DonHang ON HoaDonBanHang.MaHoaDon = DonHang.MaDonHang; ");
            dataGridView1.DataSource = dta;
            
        }
        private void hienThiDuLieu()
        {
            tBoxDCGH.DataBindings.Clear();
            tBoxGiaBan.DataBindings.Clear();
            tBoxMaKhachHang.DataBindings.Clear();
            tBoxMHD.DataBindings.Clear();
            tBoxMNV.DataBindings.Clear();
            tBoxNgayBan.DataBindings.Clear();
            tBoxThue.DataBindings.Clear();
            tBoxTinhTrang.DataBindings.Clear();
            tBoxTongTien.DataBindings.Clear();


            tBoxDCGH.DataBindings.Add("Text", dataGridView1.DataSource, "DiaChiGiaoHang");
            tBoxGiaBan.DataBindings.Add("Text", dataGridView1.DataSource, "GiaBan");
            tBoxMaKhachHang.DataBindings.Add("Text", dataGridView1.DataSource, "MaKhachHang");
            tBoxMHD.DataBindings.Add("Text", dataGridView1.DataSource, "MaHoaDon");
            tBoxMNV.DataBindings.Add("Text", dataGridView1.DataSource, "MaNhanvien");
            tBoxNgayBan.DataBindings.Add("Text", dataGridView1.DataSource, "NgayBan");
            tBoxThue.DataBindings.Add("Text", dataGridView1.DataSource, "Thue");
            tBoxTinhTrang.DataBindings.Add("Text", dataGridView1.DataSource, "TinhTrang");
            tBoxTongTien.DataBindings.Add("Text", dataGridView1.DataSource, "TongTien");
        }
        private void FrmQlyHD_Load(object sender, EventArgs e)
        {
            try
            {
                
                reload();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hủy đơn hàng: Đổi trạng thái các xe.Conhang từ 0 thành 1, cập nhật lại nhanvien.DSBH (-1), cập nhật tình trạng đơn hàng "Đã hủy";

            try
            {
                if(tBoxTinhTrang.Text.Trim() == "Đã thanh toán")
                {
                    throw new Exception("Không thể hủy đơn hàng đã hanh toán!");
                }
                string sql_sua = $"EXEC HuyHoaDon {tBoxMHD.Text}; ";
                kn.ThucThi(sql_sua);
                reload();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void btnSearchHD_Click(object sender, EventArgs e)
        {
            try
            {
                if(tBoxTimKiemHD.Text == "")
                {
                    throw new Exception("Điền vào mã HĐ để tìm kiếm!");
                }
                DataTable dta = new DataTable();
                dta = kn.Lay_Dulieu($"SELECT HoaDonBanHang.MaHoaDon,HoaDonBanHang.NgayBan,HoaDonBanHang.MaKhachHang,HoaDonBanHang.MaNhanVien,HoaDonBanHang.GiaBan,HoaDonBanHang.Thue,HoaDonBanHang.TongTien,HoaDonBanHang.DiaChiGiaoHang,DonHang.TinhTrangDonHang AS TinhTrang FROM HoaDonBanHang JOIN DonHang ON HoaDonBanHang.MaHoaDon = DonHang.MaDonHang Where MaHoaDon = {tBoxTimKiemHD.Text}; ");
                dataGridView1.DataSource = dta;
                hienThiDuLieu();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_sua = $"EXEC CapNhatDiaChiGiaoHang {tBoxMHD.Text}, N'{tBoxDCGH.Text}'; ";
                kn.ThucThi(sql_sua);
                reload();
                hienThiDuLieu();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dta = new DataTable();
                string Sql_tk = "";






                if (radioButton1.Checked == true)
                {
                    if (tBoxTimKiemHD.Text == "")
                    {
                        throw new Exception("Điền vào mã HĐ để tìm kiếm!");
                    }
                    Sql_tk = $"SELECT HoaDonBanHang.MaHoaDon,HoaDonBanHang.NgayBan,HoaDonBanHang.MaKhachHang,HoaDonBanHang.MaNhanVien,HoaDonBanHang.GiaBan,HoaDonBanHang.Thue,HoaDonBanHang.TongTien,HoaDonBanHang.DiaChiGiaoHang,DonHang.TinhTrangDonHang AS TinhTrang FROM HoaDonBanHang JOIN DonHang ON HoaDonBanHang.MaHoaDon = DonHang.MaDonHang Where MaHoaDon = {tBoxTimKiemHD.Text};";
                }
                else if (radioButton2.Checked == true)
                {
                    if (tBoxTimKiemKH.Text == "")
                    {
                        throw new Exception("Điền vào mã KH để tìm kiếm!");
                    }
                    Sql_tk = $"SELECT HoaDonBanHang.MaHoaDon,HoaDonBanHang.NgayBan,HoaDonBanHang.MaKhachHang,HoaDonBanHang.MaNhanVien,HoaDonBanHang.GiaBan,HoaDonBanHang.Thue,HoaDonBanHang.TongTien,HoaDonBanHang.DiaChiGiaoHang,DonHang.TinhTrangDonHang AS TinhTrang FROM HoaDonBanHang JOIN DonHang ON HoaDonBanHang.MaHoaDon = DonHang.MaDonHang Where HoaDonBanHang.MaKhachHang = '{tBoxTimKiemKH.Text}';";
                }
                else
                {
                    if (tBoxTimKiemNV.Text == "")
                    {
                        throw new Exception("Điền vào mã NV để tìm kiếm!");
                    }
                    Sql_tk = $"SELECT HoaDonBanHang.MaHoaDon,HoaDonBanHang.NgayBan,HoaDonBanHang.MaKhachHang,HoaDonBanHang.MaNhanVien,HoaDonBanHang.GiaBan,HoaDonBanHang.Thue,HoaDonBanHang.TongTien,HoaDonBanHang.DiaChiGiaoHang,DonHang.TinhTrangDonHang AS TinhTrang FROM HoaDonBanHang JOIN DonHang ON HoaDonBanHang.MaHoaDon = DonHang.MaDonHang Where HoaDonBanHang.MaNhanVien = {tBoxTimKiemNV.Text};";
                }

                dta = kn.Lay_Dulieu(Sql_tk);
                dataGridView1.DataSource = dta;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
             }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmChiTietHoaDon frm = new FrmChiTietHoaDon(tBoxMHD.Text);
            frm.Show();
        }
    }
}
