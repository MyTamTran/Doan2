using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien.DTO
{
    public class ChamCong
    {
        public string MaNV { get; set; }
        public int SoNgayLam { get; set; }
        public int SoNgayNghi { get; set; }
        public ChamCong() { }
        public ChamCong(string manv,int songaylam,int songaynghi)
        {
            MaNV=manv;
            SoNgayLam = songaylam;
            SoNgayNghi = songaynghi;
        }
    }
    
}
