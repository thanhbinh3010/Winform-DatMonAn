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
    public partial class KhachHang : Form
    {
        clsKhachHang kh = new clsKhachHang();
        bool cotthem;
        public KhachHang()
        {
            InitializeComponent();
        }
        void setNull()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdienthoaikh.Text = "";
            txtdiachikh.Text = "";
            txtEmail.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;

        }
   
        public void HienthiKhachHang()
        {
            DataTable dt = kh.LayDSKhachHang();
            lstkhachhang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lstkhachhang.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());


            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienthiKhachHang();
            setButton(true);
            setNull();
            txtmakh.Focus();
            
        }

        private void lstkhachhang_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstkhachhang.SelectedIndices.Count > 0)
            {
                txtmakh.Text = lstkhachhang.SelectedItems[0].SubItems[0].Text;
                txttenkh.Text = lstkhachhang.SelectedItems[0].SubItems[1].Text;            
                txtdiachikh.Text = lstkhachhang.SelectedItems[0].SubItems[2].Text;
                txtEmail.Text = lstkhachhang.SelectedItems[0].SubItems[3].Text;
                txtdienthoaikh.Text = lstkhachhang.SelectedItems[0].SubItems[4].Text;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            cotthem = true;
            setButton(false);
 
            txtmakh.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstkhachhang.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa Khách Hàng", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaKhachHang(lstkhachhang.SelectedItems[0].SubItems[0].Text);
                    HienthiKhachHang();            
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
            if (lstkhachhang.SelectedIndices.Count > 0)
            {
                cotthem = false;
                setButton(false);
                txtmakh.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 khách hàng", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try { 
            if (cotthem)
            {
               kh.ThemKhachHang(txttenkh.Text,txtEmail.Text,txtdiachikh.Text ,txtmakh.Text, txtdienthoaikh.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                kh.CapNhapKhachHang(lstkhachhang.SelectedItems[0].SubItems[0].Text,txttenkh.Text, txtEmail.Text,txtdiachikh.Text,txtmakh.Text,txtdienthoaikh.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            }
            catch
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }
            finally { 
            HienthiKhachHang();
           setButton(true);
            setNull();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
          
        }

  
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            setNull();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
