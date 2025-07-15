using System;
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

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlLogo.BackColor = ColorTranslator.FromHtml("#000000");

            label1.ForeColor = ColorTranslator.FromHtml("#52362A");
            label2.ForeColor = ColorTranslator.FromHtml("#52362A");
            label3.ForeColor = ColorTranslator.FromHtml("#52362A");

            btnLogin.BackColor = ColorTranslator.FromHtml("#52362A");
            btnLogin.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            btnThoat.BackColor = ColorTranslator.FromHtml("#DED4CA");
            btnThoat.ForeColor = ColorTranslator.FromHtml("#AF262E");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtMaDN.Text;
            string password = txtPass.Text;

            // Kiểm tra thông tin đăng nhập
            var account = bs.DangNhap(username, password);
            if (account != null )
            {

                if (bs.IsAdmin(account))
                {
                    NextForm = new frmMainAddmin();
                }
                else if (bs.IsNhanVien(account))
                {
                    NextForm = new Form1();
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
    }
}
