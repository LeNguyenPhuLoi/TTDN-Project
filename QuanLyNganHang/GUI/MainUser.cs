using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GUI
{
    public partial class frmMainUser : Form
    {
        public frmMainUser()
        {
            InitializeComponent();
        }

        // Biến tạm
        Form currentForm = new Form();
        private void OpenMain(Form childForm)
        {
            // Tắt form hiện tại để chuyển form mới
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            // Chỉnh sửa thuộc tính của form mới
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Đưa form mới vào main menu
            childForm.Show();
            currentForm = childForm;
            // Tắt banner, tránh chạy ngầm
            tmrBannerLoop.Stop();
            picBanner.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMainUser_Load(object sender, EventArgs e)
        {
            tmrBannerLoop.Interval = 6000;
            tmrBannerLoop.Start();
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Margin = new Padding(0, 10, 0, 10);
            pictureBox1.BackColor = Color.Transparent;

            // Màu nền chính nhẹ nhàng
            this.BackColor = ColorTranslator.FromHtml("#F5F7FA");

            // Màu menu trái (sidebar) đậm, chuyên nghiệp
            pnlMenu.BackColor = ColorTranslator.FromHtml("#263238");

            // Nút Thoát - đỏ nổi bật
            btnThoat.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            btnThoat.BackColor = ColorTranslator.FromHtml("#E53935");

            // Màu nền nút menu - xám đậm
            Color buttonBackColor = ColorTranslator.FromHtml("#37474F");
            // Màu chữ trên nút - trắng
            Color buttonForeColor = ColorTranslator.FromHtml("#FFFFFF");

            // Gán cho các nút
            btnTaiKhoan.BackColor = buttonBackColor; btnTaiKhoan.ForeColor = buttonForeColor;
            btnVay.BackColor = buttonBackColor; btnVay.ForeColor = buttonForeColor;
            btnKH.BackColor = buttonBackColor; btnKH.ForeColor = buttonForeColor;
            btnCK.BackColor = buttonBackColor; btnCK.ForeColor = buttonForeColor;
            btnLichSu.BackColor = buttonBackColor; btnLichSu.ForeColor = buttonForeColor;
            btnKhuyenMai.BackColor = buttonBackColor; btnKhuyenMai.ForeColor = buttonForeColor;
            btnPhieuVay.BackColor = buttonBackColor; btnPhieuVay.ForeColor = buttonForeColor;
            btnPhieuNo.BackColor = buttonBackColor; btnPhieuNo.ForeColor = buttonForeColor;
            btnBL.BackColor = buttonBackColor; btnBL.ForeColor = buttonForeColor;
            btnDangXuat.BackColor = buttonBackColor; btnDangXuat.ForeColor = buttonForeColor;
            btnInBL.BackColor = buttonBackColor; btnInBL.ForeColor = buttonForeColor;
            btnGD.BackColor = buttonBackColor; btnGD.ForeColor = buttonForeColor;
        }

        private void btnVay_Click(object sender, EventArgs e)
        {
            frmKhoanVay frm = new frmKhoanVay();
            OpenMain(frm);
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmLichSuTraNo frm = new frmLichSuTraNo();
            OpenMain(frm);
        }

        private void btnBL_Click(object sender, EventArgs e)
        {
            Frm_BienLai frm = new Frm_BienLai();
            OpenMain(frm);
        }

        private void btnInBL_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Frm_TaiKhoan frm = new Frm_TaiKhoan();
            OpenMain(frm);
        }

        private void btnCK_Click(object sender, EventArgs e)
        {
            frmChuyenKhoan frm = new frmChuyenKhoan();
            OpenMain(frm);
        }

        private void btnGD_Click(object sender, EventArgs e)
        {
            Frm_GiaoDich frm = new Frm_GiaoDich();
            OpenMain(frm);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            Frm_KhachHang frm = new Frm_KhachHang();
            OpenMain(frm);
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            frmApDungKhuyenMai frm = new frmApDungKhuyenMai();
            OpenMain(frm);
        }
    }
}
