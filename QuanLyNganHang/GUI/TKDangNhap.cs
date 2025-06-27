using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;

namespace GUI
{
    public partial class frmTKDangNhap : Form
    {
        public frmTKDangNhap()
        {
            InitializeComponent();
        }
        BUS_TKDangNhap bustkdn = new BUS_TKDangNhap();
        private void frmTKDangNhap_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#263238");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DCDCDC");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            dgvTaiKhoan.DataSource = bustkdn.LoadTKL();
            dgvNhanVien.DataSource = bustkdn.LoadDSNV();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvNhanVien.CurrentRow.Index;
                txtMaNV.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvTaiKhoan.CurrentRow.Index;
                txtMaDN.Text = dgvTaiKhoan.Rows[dong].Cells[0].Value.ToString();
                txtPass.Text = dgvTaiKhoan.Rows[dong].Cells[1].Value.ToString();
                cboQuyen.Text = dgvTaiKhoan.Rows[dong].Cells[2].Value.ToString();
                txtMaNV.Text = dgvTaiKhoan.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtPass.Clear();
            cboQuyen.SelectedIndex = -1 ;
            txtMaDN.Clear();
            txtMaDN.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_DangNhap et = new ET_DangNhap(txtMaDN.Text, txtPass.Text,
                                             cboQuyen.Text, txtMaNV.Text);
            if (bustkdn.ThemTKL(et) == true)
            {
                MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvTaiKhoan.DataSource = bustkdn.LoadTKL();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_DangNhap et = new ET_DangNhap(txtMaDN.Text, txtPass.Text,
                                             cboQuyen.Text, txtMaNV.Text);
            if (bustkdn.CapNhatTKL(et) == true)
            {
                MessageBox.Show("Cập Nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập Nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvTaiKhoan.DataSource = bustkdn.LoadTKL();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_DangNhap et = new ET_DangNhap(txtMaDN.Text, txtPass.Text,
                                             cboQuyen.Text, txtMaNV.Text);
                if (bustkdn.XoaTKL(et) == true)
                {
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvTaiKhoan.DataSource = bustkdn.LoadTKL();
            }
        }
    }
}
