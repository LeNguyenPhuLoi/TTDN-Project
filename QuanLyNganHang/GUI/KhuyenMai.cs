using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKhuyenMai : Form
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        BUS_KhuyenMai bs = new BUS_KhuyenMai();

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            btnNew.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
            this.BackColor = ColorTranslator.FromHtml("#263238");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DCDCDC");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            dgvKhuyenMai.DataSource = bs.LoadDSKhuyenMai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_KhuyenMai et = new ET_KhuyenMai(txtMaKM.Text, txtTenKM.Text,
                                                txtNoiDung.Text,dtNgayBatDau.Value,
                                                dtNgayKetThuc.Value,txtDKApDung.Text);
            string error = "";
            if (bs.ThemKhuyenMai(et, out error) == true)
            {
                MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNew.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvKhuyenMai.DataSource = bs.LoadDSKhuyenMai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_KhuyenMai et = new ET_KhuyenMai(txtMaKM.Text, txtTenKM.Text,
                                                txtNoiDung.Text, dtNgayBatDau.Value,
                                                dtNgayKetThuc.Value, txtDKApDung.Text);
                string error = "";
                if (bs.XoaKhuyenMai(et, out error) == true)
                {
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvKhuyenMai.DataSource = bs.LoadDSKhuyenMai();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_KhuyenMai et = new ET_KhuyenMai(txtMaKM.Text, txtTenKM.Text,
                                                txtNoiDung.Text, dtNgayBatDau.Value,
                                                dtNgayKetThuc.Value, txtDKApDung.Text);
            string error = "";
            if (bs.CapNhatKhuyenMai(et, out error) == true)
            {
                MessageBox.Show("Cập Nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvKhuyenMai.DataSource = bs.LoadDSKhuyenMai();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTenKM.Clear();
            txtMaKM.Clear();
            txtNoiDung.Clear();
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayKetThuc.Value = DateTime.Now; // Đặt lại ngày kết thúc về ngày hiện tại
            txtDKApDung.Clear();
            txtMaKM.Focus(); // Đặt con trỏ vào ô nhập mã khuyến mãi để người dùng có thể nhập ngay
        }

        private void dgvKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKhuyenMai.CurrentRow.Index;
                txtMaKM.Text = dgvKhuyenMai.Rows[dong].Cells[0].Value.ToString();
                txtTenKM.Text = dgvKhuyenMai.Rows[dong].Cells[1].Value.ToString();
                txtNoiDung.Text = dgvKhuyenMai.Rows[dong].Cells[2].Value.ToString();
                dtNgayBatDau.Text = dgvKhuyenMai.Rows[dong].Cells[3].Value.ToString();
                dtNgayKetThuc.Text = dgvKhuyenMai.Rows[dong].Cells[4].Value.ToString();
                txtDKApDung.Text = dgvKhuyenMai.Rows[dong].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
