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
    public partial class SuatAn : Form
    {
        clsSuatAn kh = new clsSuatAn();
        bool cotthem;
        public SuatAn()
        {
            InitializeComponent();
        }
        void setNull()
        {
            txtMSSA.Text = "";
            txtTenSA.Text = "";
            txtDonGia.Text = "";
            txtThanhPhan.Text = "";
            dtpNgayAD.Text = "";
           
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;

        }
        public void HienthiSuatAn()
        {
            DataTable dt = kh.LayDsSuatAn();
            lstSuatAn.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lstSuatAn.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());

            }
        }
        private void MonAn_Load(object sender, EventArgs e)
        {
            HienthiSuatAn();
            setButton(true);
            setNull();
            txtMSSA.Focus();
        }

        private void lstSuatAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSuatAn.SelectedIndices.Count > 0)
            {
                txtMSSA.Text = lstSuatAn.SelectedItems[0].SubItems[0].Text;
                txtTenSA.Text = lstSuatAn.SelectedItems[0].SubItems[1].Text;
                txtThanhPhan.Text = lstSuatAn.SelectedItems[0].SubItems[2].Text;
                txtDonGia.Text = lstSuatAn.SelectedItems[0].SubItems[3].Text;
                dtpNgayAD.Text = lstSuatAn.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cotthem = true;
            setButton(false);
            txtMSSA.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSuatAn.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa Suất Ăn", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaSuatAn(lstSuatAn.SelectedItems[0].SubItems[0].Text);
                    HienthiSuatAn();
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
            if (lstSuatAn.SelectedIndices.Count > 0)
            {
                cotthem = false;
                setButton(false);
                txtMSSA.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 suất ăn", "Thông báo");
            }
        }  
        private void btnLuu_Click(object sender, EventArgs e)
        {     try
            {
                string ngay = String.Format("{0:yyyy/MM/dd}", dtpNgayAD.Value);
                if (cotthem)
                {
                    kh.ThemSuatAn(txtTenSA.Text, ngay, txtThanhPhan.Text, txtMSSA.Text, txtDonGia.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    kh.CapNhapSuatAn(lstSuatAn.SelectedItems[0].SubItems[0].Text, txtTenSA.Text, 
                        ngay, txtThanhPhan.Text, txtMSSA.Text, txtDonGia.Text);
                    MessageBox.Show("Cập nhật thành công");
                } }
            catch
            {
                MessageBox.Show("Mã suất ăn đã tồn tại");   }
            finally
            { 
            HienthiSuatAn();
            setButton(true);
            setNull();}
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
