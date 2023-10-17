using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien.DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string MaPhong { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string MaCV { get; set; }
        public string MaTD { get; set; }
        public int BacLuong { get; set; }
     public NhanVien(string maNV, string hoTen, string gioiTinh, string ngaySinh, string maPhong, string diaChi, string sDT, string email, string macv,string matd, int bacluong)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            MaPhong = maPhong;
            DiaChi = diaChi;
            SDT = sDT;
            Email = email;
            MaCV = macv;
            MaTD = matd;
            BacLuong = bacluong;
        }

        public NhanVien() {  }
    }
}
