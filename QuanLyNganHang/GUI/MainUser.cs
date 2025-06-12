using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            this.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlMenu.BackColor = ColorTranslator.FromHtml("#B12830");

            btnThoat.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            btnThoat.BackColor = ColorTranslator.FromHtml("#B12830");

            btnTaiKhoan.BackColor = ColorTranslator.FromHtml("#52362A");
            btnTaiKhoan.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnVay.BackColor = ColorTranslator.FromHtml("#52362A");
            btnVay.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnKH.BackColor = ColorTranslator.FromHtml("#52362A");
            btnKH.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnCK.BackColor = ColorTranslator.FromHtml("#52362A");
            btnCK.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnLichSu.BackColor = ColorTranslator.FromHtml("#52362A");
            btnLichSu.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnKhuyenMai.BackColor = ColorTranslator.FromHtml("#52362A");
            btnKhuyenMai.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnPhieuVay.BackColor = ColorTranslator.FromHtml("#52362A");
            btnPhieuVay.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnPhieuNo.BackColor = ColorTranslator.FromHtml("#52362A");
            btnPhieuNo.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnBL.BackColor = ColorTranslator.FromHtml("#52362A");
            btnBL.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnDangXuat.BackColor = ColorTranslator.FromHtml("#52362A");
            btnDangXuat.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnInBL.BackColor = ColorTranslator.FromHtml("#52362A");
            btnInBL.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            btnGD.BackColor = ColorTranslator.FromHtml("#52362A");
            btnGD.ForeColor = ColorTranslator.FromHtml("#DED4CA");
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
      
        }
    }
}
