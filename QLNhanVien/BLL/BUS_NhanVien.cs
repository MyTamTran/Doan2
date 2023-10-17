using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhanVien.DAL;
using QLNhanVien.DTO;
namespace QLNhanVien.BLL
{
    public class BUS_NhanVien
    {
        DAL_NhanVien DAL = new DAL_NhanVien();
        public int Them(NhanVien nv)
        {
            int ketqua = DAL.Them(nv);
            return ketqua;
        }
        public int Sua(NhanVien nv)
        {
            int ketqua = DAL.Sua(nv);
            return ketqua;
        }
      public bool Check(string id)
        {
            bool kq = DAL.KiemTraTonTaiMaNV(id);
            return kq;
        }
        public int Xoa(string id)
        {
            int ketqua = DAL.Xoa(id);
            return ketqua;
        }
        public List<NhanVien> LayDSNhanVien()
        {
            return DAL.LayDSNhanVien();
        }
        public List<NhanVien> LayDSNhanVien(string id)
        {
            return DAL.LayDSNhanVien(id);

        }
    }
}
