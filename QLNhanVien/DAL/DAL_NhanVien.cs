using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhanVien.DTO;
using System.Data;
using System.Data.SqlClient;
namespace QLNhanVien.DAL
{
    public class DAL_NhanVien
    {
        /* 
         Thêm nhân viên
         */
        public int Them(NhanVien nv)
        {
            string query =
               $"INSERT INTO NhanVien( MaNV, HoTen, GioiTinh, NgaySinh, MaPhong, DiaChi, SDT, Email, MaCV, BacLuong, MaTD) " +
               $"VALUES('{nv.MaNV}', N'{nv.HoTen}', '{nv.GioiTinh}','{nv.NgaySinh}','{nv.MaPhong}',N'{nv.DiaChi}','{nv.SDT}','{nv.Email}','{nv.MaCV}','{nv.BacLuong}','{nv.MaTD}')";
             return DBHelper.NonQuery(query, null);
        }
       
        public int Sua(NhanVien nv)
        {
            string query =
                $"UPDATE NhanVien SET HoTen =N'{nv.HoTen}', GioiTinh='{nv.GioiTinh}', NgaySinh ='{nv.NgaySinh}'," +
                $" MaPhong='{nv.MaPhong}', DiaChi=N'{nv.DiaChi}',SDT='{nv.SDT}',Email='{nv.Email}',MaCV='{nv.MaCV}',BacLuong='{nv.BacLuong},'MaTD='{nv.MaTD}' WHERE MANV='{nv.MaNV}'";
            return DBHelper.NonQuery(query, null);
        }
        public int Xoa(string id)
        {
            string query = $"DELETE FROM NHANVIEN WHERE MANV ='{id}'";
            return DBHelper.NonQuery(query, null);
        }
        //lấy list all nhân viên trong database
        public bool KiemTraTonTaiMaNV(string maNV)
        {
            string query = $"SELECT COUNT(*) FROM NhanVien WHERE MaNV = '{maNV}'";
            int count = (int)DBHelper.NonQuery(query, null);
            return count > 0;
        }

        public List<NhanVien> LayDSNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string query = "SELECT * FROM NhanVien";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                NhanVien nhanVien = new NhanVien()
                {
                    MaNV = row["MaNV"] as string,
                    HoTen = row["HoTen"] as string,
                    GioiTinh = row["GioiTinh"] as string,
                    NgaySinh = row["NgaySinh"] as string,
                    MaPhong= row["MaPhong"] as string,
                    DiaChi = row["DiaChi"] as string,
                    SDT = row["SDT"] as string,
                    Email = row["EMAIL"] as string,
                    MaCV = row["MaCV"] as string,
                    BacLuong = row["BacLuong"] as int ? ?? 0,
                    MaTD = row["MaTD"] as string,

                };
                nhanViens.Add(nhanVien);

            }
            return nhanViens;

        }

        //lấy 1 nhân viên theo id
        public List<NhanVien> LayDSNhanVien(string id)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            NhanVien nhanvien = new NhanVien();
            string query = $"SELECT * FROM NhanVien where MaNV='{id}'";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows) 
            {
                nhanvien = new NhanVien()
                {
                    MaNV = row["MaNV"] as string,
                    HoTen = row["HoTen"] as string,
                    GioiTinh = row["GioiTinh"] as string,
                    NgaySinh = row["NgaySinh"] as string,
                    MaPhong = row["MaPhong"] as string,
                    DiaChi = row["DiaChi"] as string,
                    SDT = row["SDT"] as string,
                    Email = row["EMAIL"] as string,
                    MaCV = row["MaCV"] as string,
                    BacLuong = row["BacLuong"] as int? ?? 0,
                    MaTD = row["MaTD"] as string,

                };
                nhanViens.Add(nhanvien);

            }
            return nhanViens;

        }


    }
}
