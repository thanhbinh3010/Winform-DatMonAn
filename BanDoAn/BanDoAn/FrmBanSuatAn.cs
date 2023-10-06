using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanDoAn
{
    public partial class FrmBanSuatAn : Form
    {
        public FrmBanSuatAn()
        {
            InitializeComponent();
        }
     

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            SuatAn ma= new SuatAn();
            ma.TopLevel = false;
            panel2.Controls.Add(ma);
            ma.Dock = DockStyle.Fill;
            ma.BringToFront();
            ma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KhachHang ka = new KhachHang();

            ka.TopLevel = false;
            panel2.Controls.Add(ka);
            ka.Dock = DockStyle.Fill;
            ka.BringToFront();
            ka.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMB_Click(object sender, EventArgs e)
        {
            active.Height = btnSA.Height;
            active.Top = btnSA.Top;
            SuatAn ma = new SuatAn();
            ma.TopLevel = false;
            panel2.Controls.Add(ma);
            ma.Dock = DockStyle.Fill;
            ma.BringToFront();
            ma.Show();
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            active.Height = btnKH.Height;
            active.Top = btnKH.Top;
            KhachHang ka = new KhachHang();

            ka.TopLevel = false;
            panel2.Controls.Add(ka);
            ka.Dock = DockStyle.Fill;
            ka.BringToFront();
            ka.Show();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            active.Height = btnNV.Height;
            active.Top = btnNV.Top;
            NhanVien nv = new NhanVien();
            nv.TopLevel = false;
            panel2.Controls.Add(nv);
            nv.Dock = DockStyle.Fill;
            nv.BringToFront();
            nv.Show();
        }

        private void btnDSA_Click(object sender, EventArgs e)
        {
            active.Height = btnDSA.Height;
            active.Top = btnDSA.Top;
            DatSuatAn z = new DatSuatAn();
            z.TopLevel = false;
            panel2.Controls.Add(z);
            z.Dock = DockStyle.Fill;
            z.BringToFront();
           z.Show();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            active.Height = btnHD.Height;
            active.Top = btnHD.Top;
            HoaDon b = new HoaDon();
            b.TopLevel = false;
            panel2.Controls.Add(b);
            b.Dock = DockStyle.Fill;
           b.BringToFront();
            b.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
            
        }

        private void FrmBanSuatAn_Load(object sender, EventArgs e)
        {
            SuatAn ma = new SuatAn();
            ma.TopLevel = false;
            panel2.Controls.Add(ma);
            ma.Dock = DockStyle.Fill;
            ma.BringToFront();
            ma.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
