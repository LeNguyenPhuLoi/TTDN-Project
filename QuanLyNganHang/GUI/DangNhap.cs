﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        BUS_DangNhap bs = new BUS_DangNhap();
        public Form NextForm { get; set; } // Lưu form tiếp theo


        private void btnZoom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtMaDN.Text;
            string password = txtPass.Text;

            // Kiểm tra thông tin đăng nhập
            var account = bs.DangNhap(username, password);
            if (account != null)
            {

                if (bs.IsAdmin(account))
                {
                    NextForm = new frmMainAddmin();
                }
                else if (bs.IsNhanVien(account))
                {
                    NextForm = new Frm_MainUser();
                }
                else
                {
                    MessageBox.Show("Không xác định quyền người dùng.");
                    return;
                }


                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Vui lòng nhập đúng tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtMaDN.Clear();
                txtMaDN.Focus();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
