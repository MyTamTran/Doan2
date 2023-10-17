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
using QLNhanVien.DAL;
namespace QLNhanVien
{
    public partial class Form1 : Form
    {
        BUS_NhanVien nv = new BUS_NhanVien();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manv = MaNV.Text.Trim();
            string hoten = TenNV.Text.Trim();
            string ngaysinh = NgaySinh.Text.Trim();
            string gioitinh = GioiTinh.Text.Trim();
            string diachi = DiaChi.Text.Trim();
            string sdt = SDT.Text.Trim();
            string email = Email.Text.Trim();
            string maphg = MaPhong.Text.Trim();


            NhanVien nhanvien = new NhanVien()
            {
                MaNV = manv,
                HoTen = hoten,
                NgaySinh = ngaysinh,
                GioiTinh = gioitinh,
                DiaChi = diachi,
                SDT = sdt,
                Email = email,
                MaPhong= maphg,

            };
            nv.Them(nhanvien);
            loadnv();
            
        }
        private void loadnv()
        {
            dgvDSNV.DataSource = nv.LayDSNhanVien();
            dgvDSNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void loadnv2(string MaNV)
        {
            dgvDSNV.DataSource = nv.LayDSNhanVien(MaNV);
            dgvDSNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDSNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int dong = dgvDSNV.CurrentCell.RowIndex;
                if (dgvDSNV.Rows[dong].Cells["MANV"].Value != null)
                {
                    MaNV.Text = dgvDSNV.Rows[dong].Cells["MANV"].Value.ToString();
                }

                if (dgvDSNV.Rows[dong].Cells["HOTEN"].Value != null)
                {
                    TenNV.Text = dgvDSNV.Rows[dong].Cells["HOTEN"].Value.ToString();
                }

                if (dgvDSNV.Rows[dong].Cells["NGAYSINH"].Value != null)
                {
                    NgaySinh.Text = dgvDSNV.Rows[dong].Cells["NGAYSINH"].Value.ToString();
                 
                }

                if (dgvDSNV.Rows[dong].Cells["GIOITINH"].Value != null)
                {
                    GioiTinh.Text = dgvDSNV.Rows[dong].Cells["GIOITINH"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadnv();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string manv = MaNV.Text.Trim();
            string hoten = TenNV.Text.Trim();
            string ngaysinh = NgaySinh.Text.Trim();
            string gioitinh = GioiTinh.Text.Trim();
            string diachi = DiaChi.Text.Trim();
            string sdt = SDT.Text.Trim();
            string email = Email.Text.Trim();
            string maphg = MaPhong.Text.Trim();


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

            };
            nv.Sua(nhanvien);
            loadnv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string manv = MaNV.Text.Trim();
            string hoten = TenNV.Text.Trim();
            string ngaysinh = NgaySinh.Text.Trim();
            string gioitinh = GioiTinh.Text.Trim();
            string diachi = DiaChi.Text.Trim();
            string sdt = SDT.Text.Trim();
            string email = Email.Text.Trim();
            string maphg = MaPhong.Text.Trim();


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

            };
            nv.Xoa(nhanvien.MaNV);
            loadnv();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string manv = MaNV.Text.Trim();
            string hoten = TenNV.Text.Trim();
            string ngaysinh = NgaySinh.Text.Trim();
            string gioitinh = GioiTinh.Text.Trim();
            string diachi = DiaChi.Text.Trim();
            string sdt = SDT.Text.Trim();
            string email = Email.Text.Trim();
            string maphg = MaPhong.Text.Trim();


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

            };
            nv.LayDSNhanVien(nhanvien.MaNV);
            loadnv2(nhanvien.MaNV);
        }
    }
}
