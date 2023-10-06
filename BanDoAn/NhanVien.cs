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
    public partial class NhanVien : Form
    {
        clsNhanVien kh = new clsNhanVien();
        bool cotthem;
        public NhanVien()
        {
            InitializeComponent();
        }
        void setNull()
        {
            txtmaNv.Text = "";
            txttenNV.Text = "";
            txtdiachi.Text = "";
            dtpNgaySinh.Text = "";
            cbCV.Text = "";

        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;

        }
        public void HienThiNhanVien()
        {
            DataTable dt = kh.LayDsNhanVien();
            lstNhanVien.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lstNhanVien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());

            }
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThiNhanVien();
            setButton(true);
            setNull();
            txtmaNv.Focus();
        }

        private void lstNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedIndices.Count > 0)
            {
                txtmaNv.Text = lstNhanVien.SelectedItems[0].SubItems[0].Text;
                txttenNV.Text = lstNhanVien.SelectedItems[0].SubItems[1].Text;
                cbCV.Text = lstNhanVien.SelectedItems[0].SubItems[2].Text;
                dtpNgaySinh.Text = lstNhanVien.SelectedItems[0].SubItems[3].Text;
                txtdiachi.Text = lstNhanVien.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cotthem = true;
            setButton(false);
            txtmaNv.Focus();
            setNull();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa Nhân Viên", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaNV(lstNhanVien.SelectedItems[0].SubItems[0].Text);
                    HienThiNhanVien();
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
            if(lstNhanVien.SelectedIndices.Count > 0)
            {
                cotthem = false;
                setButton(false);
                txtmaNv.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 suất ăn", "Thông báo");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try { 
            string ngay = String.Format("{0:dd/MM/yyyy}", dtpNgaySinh.Value);
            if (cotthem)
            {
                kh.ThemNV(txtmaNv.Text,txttenNV.Text,cbCV.Text,ngay,txtdiachi.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                kh.CapNhapSuatAn(lstNhanVien.SelectedItems[0].SubItems[0].Text, txtmaNv.Text, txttenNV.Text, 
                    cbCV.Text, ngay, txtdiachi.Text);
                MessageBox.Show("Cập nhật thành công");
            }}
            catch
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            finally { 
            HienThiNhanVien();
            setButton(true);
            setNull();}
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
    }
}
