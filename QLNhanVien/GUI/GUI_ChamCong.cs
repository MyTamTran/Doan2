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
    public partial class GUI_ChamCong : Form
    {
        BUS_ChamCong CC = new BUS_ChamCong();
        public GUI_ChamCong()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void LoadDSNV()
        {
            dgv_chamcong.DataSource = CC.LayDSChamCong();
            dgv_chamcong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_chamcong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadNV(string MaNV)
        {
            dgv_chamcong.DataSource = CC.LayDSChamCong(MaNV);
            dgv_chamcong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_chamcong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GUI_ChamCong_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string manv = txt_MaNV.Text.Trim();
            int songaylam = int.Parse(txt_SoNgayLam.Text.Trim());
            int songaynghi = int.Parse(txt_SoNgayNghi.Text.Trim());
            ChamCong chamcong = new ChamCong()
            {
                MaNV = manv,
                SoNgayLam=songaylam,
                SoNgayNghi=songaynghi,
            };
            CC.Them(chamcong);
            LoadDSNV();
        }
    }
}
