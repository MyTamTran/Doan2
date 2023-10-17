using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhanVien.DAL;
using QLNhanVien.DTO;
namespace QLNhanVien.BLL
{
    internal class BUS_ChamCong
    {
        DAL_ChamCong DAL = new DAL_ChamCong();
        public int Them(ChamCong cc)
        {
            int ketqua = DAL.Them(cc);
            return ketqua;
            
        }
        public int Sua(ChamCong cc)
        {
            int ketqua = DAL.Sua(cc);
            return ketqua;
        }
        public int Xoa(string id)
        {
            int ketqua = DAL.Xoa(id);
            return ketqua;
        }
        public List<ChamCong> LayDSChamCong()
        {
            return DAL.LayDSChamCong();
        }
        public List<ChamCong> LayDSChamCong(string id)
        {
            return DAL.LayDSChamCong(id);

        }
    }
}
