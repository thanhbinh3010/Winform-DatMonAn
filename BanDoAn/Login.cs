﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FrmBanSuatAn table = new FrmBanSuatAn();
            this.Hide();
            table.ShowDialog();
            this.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        { }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Equals(""))
            {
                lblTb.Text = "Bạn chưa nhập tài khoản";
                txtTaiKhoan.Focus();
            }
            else if (txtMatKhau.Text.Equals(""))
            {

                lblTb.Text = "Bạn chưa nhập mật khẩu";
                txtMatKhau.Focus();
            }
            else if (txtTaiKhoan.Text.Equals("admin") && txtMatKhau.Text.Equals("admin"))
            {

            
           FrmBanSuatAn table = new FrmBanSuatAn();
            this.Hide();
            table.ShowDialog();
            this.Show();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            }
            else
            {
                lblTb.Text=  "Sai tài khoản hoặc mật khẩu";
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();

            }


            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Application.Exit(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
