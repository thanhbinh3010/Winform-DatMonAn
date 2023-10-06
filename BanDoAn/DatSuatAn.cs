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
    public partial class DatSuatAn : Form
    {

        clsDatSuatAn kh = new clsDatSuatAn();
        bool cotthem;
        public DatSuatAn()
        {
            InitializeComponent();
        }
        void setNull()
        {
            txtDcGiao.Text = "";
            txtMakh.Text = "";
            txtxSodondat.Text = "";
            cbXacNhan.Text = "";
            cbTinhTrang.Text = "";
            txtManv.Text = "";
            

        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;

        }
        public void HienthiDatSuatAn()
        {
            DataTable dt = kh.LayDsDatSuatAn();
            lstDatSuatAn.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lstDatSuatAn.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());

            }
        }
        private void DatSuatAn_Load(object sender, EventArgs e)
        {
            HienthiDatSuatAn();
            setButton(true);
            setNull();
            txtxSodondat.Focus();
  
        }
        private void lstDatSuatAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDatSuatAn.SelectedIndices.Count > 0)
            {
                txtxSodondat.Text = lstDatSuatAn.SelectedItems[0].SubItems[0].Text;
                 dtpNGD.Text = lstDatSuatAn.SelectedItems[0].SubItems[1].Text;
                dtpNGG.Text = lstDatSuatAn.SelectedItems[0].SubItems[2].Text;
                txtDcGiao.Text = lstDatSuatAn.SelectedItems[0].SubItems[3].Text;
                cbXacNhan.Text = lstDatSuatAn.SelectedItems[0].SubItems[4].Text;
                cbTinhTrang.Text = lstDatSuatAn.SelectedItems[0].SubItems[5].Text;
                txtMakh.Text = lstDatSuatAn.SelectedItems[0].SubItems[6].Text;
                 txtManv.Text = lstDatSuatAn.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cotthem = true;
            setButton(false);
            txtxSodondat.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDatSuatAn.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa Đặt Suất Ăn", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaDatSuatAn(lstDatSuatAn.SelectedItems[0].SubItems[0].Text);
                    HienthiDatSuatAn();
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
            if (lstDatSuatAn.SelectedIndices.Count > 0)
            {
                cotthem = false;
                setButton(false);
                txtxSodondat.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 suất ăn", "Thông báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string ngaydat = String.Format("{0:yyyy/MM/dd}", dtpNGD.Value);
                string ngaygiao = String.Format("{0:yyyy/MM/dd}", dtpNGG.Value);


                if (cotthem)
                {
                    kh.ThemDatSuatAn(txtxSodondat.Text, ngaydat, ngaygiao, txtDcGiao.Text, cbXacNhan.Text,
                        cbTinhTrang.Text, txtMakh.Text,txtManv.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    kh.CapNhapDatSuatAn(lstDatSuatAn.SelectedItems[0].SubItems[0].Text, txtxSodondat.Text,
              ngaydat, ngaygiao, txtDcGiao.Text, cbXacNhan.Text, cbTinhTrang.Text, txtMakh.Text, txtManv.Text);
                    MessageBox.Show("Cập nhật thành công");
                }
            }
            catch
            {
                MessageBox.Show("Chưa có khách hàng");
            }
            finally
            {
                HienthiDatSuatAn();
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
