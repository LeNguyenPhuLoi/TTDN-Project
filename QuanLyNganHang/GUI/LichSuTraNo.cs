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
        BUS_KhoanVay bsKhoanVay = new BUS_KhoanVay();

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
                                                    decimal.Parse(txtSoTien.Text),
                                                    decimal.Parse(txtTienTra.Text),dtpNgayTra.Value);
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
                                                    decimal.Parse(txtSoTien.Text),
                                                    decimal.Parse(txtTienTra.Text), dtpNgayTra.Value);
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
                                                        decimal.Parse(txtSoTien.Text),
                                                        decimal.Parse(txtTienTra.Text), dtpNgayTra.Value);
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
            txtSoTien.Clear();
            txtTienTra.Clear();
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
                txtSoTien.Text = dgvLichSu.Rows[dong].Cells[2].Value.ToString(); 
                txtTienTra.Text = dgvLichSu.Rows[dong].Cells[3].Value.ToString();
                dtpNgayTra.Text = dgvLichSu.Rows[dong].Cells[4].Value.ToString();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtMaVay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string maVay = txtMaVay.Text.Trim();
                if (string.IsNullOrEmpty(maVay)) return;

                foreach (DataGridViewRow row in dgvMaVay.Rows)
                {
                    if (row.IsNewRow) continue; // bỏ dòng thêm mới

                    if (row.Cells.Count < 7) continue; // đủ cột chưa?

                    string cellMaVay = row.Cells[0].Value?.ToString();
                    if (!string.IsNullOrEmpty(cellMaVay) && cellMaVay.Equals(maVay, StringComparison.OrdinalIgnoreCase))
                    {
                        decimal soTienVay = decimal.Parse(row.Cells[1].Value.ToString());
                        string ngayVayStr = Convert.ToDateTime(row.Cells[3].Value).ToString("dd/MM/yyyy");
                        string maLaiSuat = row.Cells[6].Value.ToString();

                        decimal tienLai = bsKhoanVay.TinhTienLai(soTienVay, maLaiSuat, ngayVayStr, dtpNgayTra.Value.ToString("dd/MM/yyyy"));
                        decimal tongTra = soTienVay + tienLai;

                        txtSoTien.Text = tongTra.ToString();
                        return;
                    }
                }

                // Nếu không tìm thấy mã
                txtSoTien.Text = "";
            }
            catch (Exception ex)
            {
                txtSoTien.Text = "";
                MessageBox.Show("Lỗi tính tiền: " + ex.Message);
            }
        }
    }
}
