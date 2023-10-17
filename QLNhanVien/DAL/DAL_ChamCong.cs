using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhanVien.DTO;
using System.Data;
namespace QLNhanVien.DAL
{
    public class DAL_ChamCong
    {
        public int Them(ChamCong cc)
        {
            string query =
               $"INSERT INTO ChamCong( MaNV, SoNgayLam, SoNgayNghi) " +
               $"VALUES('{cc.MaNV}', '{cc.SoNgayLam}', '{cc.SoNgayNghi}')";
            return DBHelper.NonQuery(query, null);
            
        }
        
        public int Sua(ChamCong cc)
        {
            string query =
                $"UPDATE ChamCong SET MaNV ='{cc.MaNV}', SoNgayLam='{cc.SoNgayLam}', SoNgayNghi ='{cc.SoNgayNghi}' " +
                $"WHERE MANV='{cc.MaNV}'";
            return DBHelper.NonQuery(query, null);
        }
        public int Xoa(string id)
        {
            string query = $"DELETE FROM ChamCong WHERE MANV ='{id}'";
            return DBHelper.NonQuery(query, null);
        }
        //lấy list all chấm công trong database
        public List<ChamCong> LayDSChamCong()
        {
            List<ChamCong> chamCongs = new List<ChamCong>();
            string query = "SELECT * FROM ChamCong";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                ChamCong chamCong = new ChamCong()
                {
                    MaNV = row["MaNV"] as string,  
                    SoNgayLam = row["SoNgayLam"] as int? ?? 0,
                    SoNgayNghi = row["SoNgayNghi"] as int? ?? 0,


                };
                chamCongs.Add(chamCong);

            }
            return chamCongs;

        }

        //lấy 1 chấm công theo id
        public List<ChamCong> LayDSChamCong(string id)
        {
            List<ChamCong> chamCongs = new List<ChamCong>();
            ChamCong chamcong = new ChamCong();
            string query = $"SELECT * FROM ChamCong where MaNV='{id}'";
            DataTable table = DBHelper.Query(query, null);
            foreach (DataRow row in table.Rows)
            {
                ChamCong chamCong = new ChamCong()
                {
                    MaNV = row["MaNV"] as string,
                    SoNgayLam = row["SoNgayLam"] as int? ?? 0,
                    SoNgayNghi = row["SoNgayNghi"] as int? ?? 0,


                };
                chamCongs.Add(chamCong);

            }
            return chamCongs;

        }
    }
}
