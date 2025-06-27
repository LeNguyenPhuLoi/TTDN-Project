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
    public partial class frmLichSuTraNo : Form
    {
        public frmLichSuTraNo()
        {
            InitializeComponent();
        }

        BUS_LichSuTraNo bs = new BUS_LichSuTraNo();

        private void frmLichSuTraNo_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#263238");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DCDCDC");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            dgvMaVay.DataSource = bs.LoadDSKhoanVay();
            dgvLichSu.DataSource = bs.LoadDSLichSuTraNo();

            btnHoanTac.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_LichSuTraNo et = new ET_LichSuTraNo(txtMaLichSu.Text,txtMaVay.Text,
                                                    decimal.Parse(txtSoTienTra.Text),dtpNgayTra.Value);
            string error = "";
            if (bs.ThemLichSuTraNo(et, out error) == true)
            {
                MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvMaVay.DataSource = bs.LoadDSKhoanVay();
            dgvLichSu.DataSource = bs.LoadDSLichSuTraNo();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_LichSuTraNo et = new ET_LichSuTraNo(txtMaLichSu.Text, txtMaVay.Text,
                                                    decimal.Parse(txtSoTienTra.Text), dtpNgayTra.Value);
            string error = "";
            if (bs.CapNhatLichSuTraNo(et, out error) == true)
            {
                MessageBox.Show("Cập Nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvMaVay.DataSource = bs.LoadDSKhoanVay();
            dgvLichSu.DataSource = bs.LoadDSLichSuTraNo();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_LichSuTraNo et = new ET_LichSuTraNo(txtMaLichSu.Text, txtMaVay.Text,
                                                    decimal.Parse(txtSoTienTra.Text), dtpNgayTra.Value);
                string error = "";
                if (bs.XoaLichSuTraNo(et, out error) == true)
                {
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvMaVay.DataSource = bs.LoadDSKhoanVay();
                dgvLichSu.DataSource = bs.LoadDSLichSuTraNo();
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaLichSu.Clear();
            txtMaVay.Clear();
            txtSoTienTra.Clear();
            dtpNgayTra.Value = DateTime.Now;
            txtMaLichSu.Focus(); // Đặt con trỏ vào ô nhập mã lịch sử
        }

        private void dgvLichSu_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvLichSu.CurrentRow.Index;
                txtMaLichSu.Text = dgvLichSu.Rows[dong].Cells[0].Value.ToString();
                txtMaVay.Text = dgvLichSu.Rows[dong].Cells[1].Value.ToString();
                txtSoTienTra.Text = dgvLichSu.Rows[dong].Cells[2].Value.ToString();
                dtpNgayTra.Text = dgvLichSu.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMaVay_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvMaVay.CurrentRow.Index;
                txtMaVay.Text = dgvMaVay.Rows[dong].Cells[0].Value.ToString();
                txtSoTienTra.Text = dgvMaVay.Rows[dong].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
