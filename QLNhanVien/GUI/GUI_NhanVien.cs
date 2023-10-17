using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanVien.BLL;
using QLNhanVien.DTO;
namespace QLNhanVien.GUI
{
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien NV = new BUS_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
       
        private void LoadDSNV()
        {
            
        
        dgv_nhanvien.DataSource = NV.LayDSNhanVien();
            dgv_nhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Thêm cột STT vào DataGridView
            DataGridViewColumn sttColumn = new DataGridViewColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            sttColumn.CellTemplate = new DataGridViewTextBoxCell();

            dgv_nhanvien.Columns.Insert(0, sttColumn);

            // Thêm giá trị cho cột STT
            for (int i = 0; i < dgv_nhanvien.Rows.Count; i++)
            {
                dgv_nhanvien.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
        private void LoadNV(string MaNV)
        {
        
            dgv_nhanvien.DataSource = NV.LayDSNhanVien(MaNV);
            dgv_nhanvien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = dgv_nhanvien.CurrentCell.RowIndex;
                if (dgv_nhanvien.Rows[dong].Cells["MANV"].Value != null)
                {
                    txt_MaNV.Text = dgv_nhanvien.Rows[dong].Cells["MANV"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["HOTEN"].Value != null)
                {
                    txt_TenNV.Text = dgv_nhanvien.Rows[dong].Cells["HOTEN"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["NGAYSINH"].Value != null)
                {
                    txt_NamSinh.Text = dgv_nhanvien.Rows[dong].Cells["NGAYSINH"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["GIOITINH"].Value != null)
                {
                    txt_GioiTinh.Text = dgv_nhanvien.Rows[dong].Cells["GIOITINH"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["MAPHONG"].Value != null)
                {
                    txt_MaPhong.Text = dgv_nhanvien.Rows[dong].Cells["MAPHONG"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["DIACHI"].Value != null)
                {
                    txt_DiaChi.Text = dgv_nhanvien.Rows[dong].Cells["DIACHI"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["SDT"].Value != null)
                {
                    txt_SDT.Text = dgv_nhanvien.Rows[dong].Cells["SDT"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["EMAIL"].Value != null)
                {
                    txt_Email.Text = dgv_nhanvien.Rows[dong].Cells["EMAIL"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["MATD"].Value != null)
                {
                    txt_MaTD.Text = dgv_nhanvien.Rows[dong].Cells["MATD"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["BACLUONG"].Value != null)
                {
                    txt_BacLuong.Text = dgv_nhanvien.Rows[dong].Cells["BACLUONG"].Value.ToString();
                }
                if (dgv_nhanvien.Rows[dong].Cells["MACV"].Value != null)
                {
                    txt_MaCV.Text = dgv_nhanvien.Rows[dong].Cells["MACV"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNV.Text.Trim();
           
            
            string gioitinh = txt_GioiTinh.Text.Trim();
          
            string hoten = txt_TenNV.Text.Trim();
            string ngaysinh = txt_NamSinh.Text.Trim();
          
            string diachi = txt_DiaChi.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            string email = txt_Email.Text.Trim();
            string maphg = txt_MaPhong.Text.Trim();
            string matd=txt_MaTD.Text.Trim();
            int bacluong=int.Parse(txt_BacLuong.Text.Trim());
            string macv=txt_MaCV.Text.Trim();
           
            
            NhanVien nhanvien = new NhanVien()
            {
                MaNV = manv,
                HoTen = hoten,
                NgaySinh = ngaysinh,
                GioiTinh = gioitinh,
                DiaChi = diachi,
                SDT = sdt,
                Email = email,
                MaPhong = maphg,
                MaTD = matd,
                BacLuong = bacluong,
                MaCV = macv,

            };
          
                NV.Them(nhanvien);
                LoadDSNV();
            
           

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDSNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNV.Text.Trim();
            string hoten = txt_TenNV.Text.Trim();
            string ngaysinh = txt_NamSinh.Text.Trim();
            string gioitinh = txt_GioiTinh.Text.Trim();
            string diachi = txt_DiaChi.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            string email = txt_Email.Text.Trim();
            string maphg = txt_MaPhong.Text.Trim();
            string matd = txt_MaTD.Text.Trim();
            int bacluong = int.Parse(txt_BacLuong.Text.Trim());
            string macv = txt_MaCV.Text.Trim();
            NhanVien nhanvien = new NhanVien()
            {
                MaNV = manv,
                HoTen = hoten,
                NgaySinh = ngaysinh,
                GioiTinh = gioitinh,
                DiaChi = diachi,
                SDT = sdt,
                Email = email,
                MaPhong = maphg,
                MaTD = matd,
                BacLuong = bacluong,
                MaCV = macv,

            };
            NV.Sua(nhanvien);
            LoadDSNV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNV.Text.Trim();
            string hoten = txt_TenNV.Text.Trim();
            string ngaysinh = txt_NamSinh.Text.Trim();
            string gioitinh = txt_GioiTinh.Text.Trim();
            string diachi = txt_DiaChi.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            string email = txt_Email.Text.Trim();
            string maphg = txt_MaPhong.Text.Trim();
            string matd = txt_MaTD.Text.Trim();
            int bacluong = int.Parse(txt_BacLuong.Text.Trim());
            string macv = txt_MaCV.Text.Trim();
            NhanVien nhanvien = new NhanVien()
            {
                MaNV = manv,
                HoTen = hoten,
                NgaySinh = ngaysinh,
                GioiTinh = gioitinh,
                DiaChi = diachi,
                SDT = sdt,
                Email = email,
                MaPhong = maphg,
                MaTD = matd,
                BacLuong = bacluong,
                MaCV = macv,

            };
            NV.Xoa(nhanvien.MaNV);
            LoadDSNV();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNV.Text.Trim();
            string hoten = txt_TenNV.Text.Trim();
            string ngaysinh = txt_NamSinh.Text.Trim();
            string gioitinh = txt_GioiTinh.Text.Trim();
            string diachi = txt_DiaChi.Text.Trim();
            string sdt = txt_SDT.Text.Trim();
            string email = txt_Email.Text.Trim();
            string maphg = txt_MaPhong.Text.Trim();
            string matd = txt_MaTD.Text.Trim();
            int bacluong = int.Parse(txt_BacLuong.Text.Trim());
            string macv = txt_MaCV.Text.Trim();
            NhanVien nhanvien = new NhanVien()
            {
                MaNV = manv,
                HoTen = hoten,
                NgaySinh = ngaysinh,
                GioiTinh = gioitinh,
                DiaChi = diachi,
                SDT = sdt,
                Email = email,
                MaPhong = maphg,
                MaTD = matd,
                BacLuong = bacluong,
                MaCV = macv,

            };
            NV.LayDSNhanVien(nhanvien.MaNV);
            LoadNV(nhanvien.MaNV);
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MaNV.Clear();
            txt_TenNV.Clear();
            txt_NamSinh.Clear();
            txt_GioiTinh.Clear();
            txt_Email.Clear();
            txt_DiaChi.Clear();
            txt_BacLuong.Clear();
            txt_MaPhong.Clear();
            txt_MaCV.Clear();
            txt_SDT.Clear();
            txt_MaTD.Clear();
        }

        private void txt_MaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
