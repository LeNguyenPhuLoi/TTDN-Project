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
            //ko doi mau khi chon vao
            dgvLichSu.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMaVay.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu nền khi chọn ô (dòng)
            dgvLichSu.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow
            dgvMaVay.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvLichSu.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvLichSu.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvLichSu.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvLichSu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLichSu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvLichSu.RowsDefaultCellStyle.BackColor = Color.White;
            dgvLichSu.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng
            dgvMaVay.RowsDefaultCellStyle.BackColor = Color.White;
            dgvMaVay.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvLichSu.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvLichSu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvMaVay.DataSource = bs.LoadDSKhoanVay();
            dgvLichSu.DataSource = bs.LoadDSLichSuTraNo();

            btnHoanTac.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LichSuTraNo et = new ET_LichSuTraNo(txtMaLichSu.Text, txtMaVay.Text,
                                                                    decimal.Parse(txtSoTien.Text),
                                                                    decimal.Parse(txtTienTra.Text), dtpNgayTra.Value);
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Vui lòng không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Vui lòng chọn để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Vui lòng chọn để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaLichSu.Clear();
            txtMaVay.Clear();
            txtTienTra.Clear();
            txtSoTien.Clear();

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
                txtSoTien.Text = dgvLichSu.Rows[dong].Cells[2].Value?.ToString() ?? "0";
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
                txtSoTien.Text = dgvMaVay.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();

            // Nếu người dùng chưa nhập gì hoặc chỉ gõ tạm thời
            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgvLichSu.DataSource = bs.LoadDSLichSuTraNo();
                return;
            }

            // Nếu keyword có vẻ là ngày nhưng chưa đúng -> bỏ qua tìm theo ngày
            DateTime ngayTim;
            bool isValidDate = DateTime.TryParse(keyword, out ngayTim) && ngayTim >= new DateTime(1753, 1, 1);

            try
            {
                dgvLichSu.DataSource = bs.TimKiemLichSuTraNo(keyword); // Trong đó đã xử lý isValidDate rồi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTienTra_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtTienTra.Text))
            {
                errorProvider1.SetError(txtTienTra, ""); // Xóa lỗi
                txtTienTra.BackColor = Color.White; // Trả lại màu bình thường
                return;
            }

            //Ktra nhập có đúng định dạng số không
            if (!decimal.TryParse(txtTienTra.Text, out _))
            {
                txtTienTra.BackColor = Color.LightPink; // Highlight đỏ hồng khi sai
                errorProvider1.SetError(txtTienTra, "Vui lòng nhập số hợp lệ."); // hiện icon lỗi
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienTra.Clear(); // Xóa nội dung ô nhập
                txtTienTra.Focus(); // Trả lại con trỏ để sửa
            }
            else
            {
                errorProvider1.SetError(txtTienTra, ""); // Xóa icon lỗi
                txtTienTra.BackColor = Color.White; // Đúng thì trả về màu bình thường
            }
        }
    }
}
