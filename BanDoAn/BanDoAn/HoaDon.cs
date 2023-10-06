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
    public partial class HoaDon : Form
    {
        clsHoaDon kh = new clsHoaDon();
        bool cotthem;
        public HoaDon()
        {
            InitializeComponent();
        }
        void setNull()
        {
            txtSDD.Text = "";
            txtSHD.Text = "";
            txtThanhTien.Text = "";
            txtThueVAT.Text = "";
            dtpNLD.Text = "";
            txtMANV.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;

        }
        public void HienthiHoaDon()
        {
            DataTable dt = kh.LayDSHoaDon();
            lstHoaDon.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lstHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cotthem = true;
            setButton(false);
            txtSHD.Focus();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            HienthiHoaDon();
            setButton(true);
            setNull();
            txtSHD.Focus();
    
        }

        private void lstHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHoaDon.SelectedIndices.Count > 0)
            {
                txtSHD.Text = lstHoaDon.SelectedItems[0].SubItems[0].Text;
                txtSDD.Text = lstHoaDon.SelectedItems[0].SubItems[1].Text;
                txtMANV.Text = lstHoaDon.SelectedItems[0].SubItems[2].Text;
                dtpNLD.Text = lstHoaDon.SelectedItems[0].SubItems[3].Text;
                txtThanhTien.Text = lstHoaDon.SelectedItems[0].SubItems[4].Text;
                txtThueVAT.Text = lstHoaDon.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstHoaDon.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa Hóa Đơn", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaHoaDon(lstHoaDon.SelectedItems[0].SubItems[0].Text);
                    HienthiHoaDon();
                    setButton(true);
                    setNull();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng cần xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstHoaDon.SelectedIndices.Count > 0)
            {
                cotthem = false;
                setButton(false);
                txtSHD.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn", "Thông báo");
            }
        } 

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string ngay = String.Format("{0:yyyy/MM/dd}", dtpNLD.Value);
                if (cotthem)
                {
                    kh.ThemHoaDon(txtSHD.Text, txtSDD.Text, txtMANV.Text,ngay, txtThanhTien.Text,
                        txtThueVAT.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    kh.CapNhatHoaDon(lstHoaDon.SelectedItems[0].SubItems[0].Text, txtSHD.Text,
                        txtSDD.Text,txtMANV.Text,ngay, txtThanhTien.Text, txtThueVAT.Text);
                    MessageBox.Show("Cập nhật thành công");
                }
            }
            catch
            {
                MessageBox.Show("Chưa có đơn đặt");
            }
            finally
            {
                HienthiHoaDon();
                setButton(true);
                setNull();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
               setButton(true);
            setNull();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

