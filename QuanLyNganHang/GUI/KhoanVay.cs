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
    public partial class frmKhoanVay : Form
    {
        public frmKhoanVay()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_ENTERSIZEMOVE = 0x0231;
            const int WM_EXITSIZEMOVE = 0x0232;

            if (m.Msg == WM_ENTERSIZEMOVE)
            {
                this.SuspendLayout(); // Bắt đầu kéo form → dừng layout
            }
            else if (m.Msg == WM_EXITSIZEMOVE)
            {
                this.ResumeLayout();  // Kết thúc kéo form → resume lại layout
            }

            base.WndProc(ref m);
        }

        BUS_KhoanVay bs = new BUS_KhoanVay();
        BUS_LaiSuat bsLaiSuat = new BUS_LaiSuat();

        private void KhoanVay_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvKhoanVay.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvLaiSuat.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Màu nền khi chọn ô (dòng)
            dgvKhoanVay.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow
            dgvLaiSuat.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvKhoanVay.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvKhoanVay.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvKhoanVay.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvKhoanVay.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhoanVay.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvKhoanVay.RowsDefaultCellStyle.BackColor = Color.White;
            dgvKhoanVay.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng
            dgvLaiSuat.RowsDefaultCellStyle.BackColor = Color.White;
            dgvLaiSuat.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvKhoanVay.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvKhoanVay.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvKhoanVay.DataSource = bs.LoadDSKhoanVay();
            dgvLaiSuat.DataSource = bsLaiSuat.LoadDSLaiSuat();
            AddToCombo(bs.LoadTenKhachHang(), cboMaKH);
            btnHoanTac_Click(sender, e);
        }

        // Thêm dữ liệu vào ComboBox
        public void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaVay.Clear();
            txtTienThang.Clear();
            txtSoTienVay.Clear();
            txtTong.Clear();
            cboMaKH.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtpNgayVay.Value = DateTime.Now;
            dtpThoiHan.Value = DateTime.Now;
            txtMaLaiSuat.Clear();
            txtMaVay.Focus();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhoanVay et = new ET_KhoanVay(txtMaVay.Text,
                                                decimal.Parse(txtSoTienVay.Text),
                                                decimal.Parse(txtTong.Text),
                                                decimal.Parse(txtTienThang.Text),
                                                dtpNgayVay.Value,
                                                dtpThoiHan.Value,
                                                int.Parse(lbSoThang.Text),
                                                cboTrangThai.Text,
                                                bs.GetMaKhachHang(cboMaKH.Text),
                                                txtMaLaiSuat.Text
                                                );
                string error = "";
                if (bs.ThemKhoanVay(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvKhoanVay.DataSource = bs.LoadDSKhoanVay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui Lòng Không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhoanVay et = new ET_KhoanVay(txtMaVay.Text,
                                                    decimal.Parse(txtSoTienVay.Text),
                                                    decimal.Parse(txtTong.Text),
                                                    decimal.Parse(txtTienThang.Text),
                                                    dtpNgayVay.Value,
                                                    dtpThoiHan.Value,
                                                    int.Parse(lbSoThang.Text),
                                                    cboTrangThai.Text,
                                                    bs.GetMaKhachHang(cboMaKH.Text),
                                                    txtMaLaiSuat.Text
                                                    );
                string error = "";
                if (bs.CapNhatKhoanVay(et, out error) == true)
                {
                    MessageBox.Show("Cập Nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvKhoanVay.DataSource = bs.LoadDSKhoanVay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui Lòng Không để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_KhoanVay et = new ET_KhoanVay(txtMaVay.Text,
                                                decimal.Parse(txtSoTienVay.Text),
                                                decimal.Parse(txtTong.Text),
                                                decimal.Parse(txtTienThang.Text),
                                                dtpNgayVay.Value,
                                                dtpThoiHan.Value,
                                                int.Parse(lbSoThang.Text),
                                                cboTrangThai.Text,
                                                bs.GetMaKhachHang(cboMaKH.Text),
                                                txtMaLaiSuat.Text
                                                );
                string error = "";
                if (bs.XoaKhoanVay(et, out error) == true)
                {
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvKhoanVay.DataSource = bs.LoadDSKhoanVay();
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Vui Lòng chọn để xóa" , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void dgvKhoanVay_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKhoanVay.CurrentRow.Index;
                txtMaVay.Text = dgvKhoanVay.Rows[dong].Cells[0].Value.ToString();
                txtSoTienVay.Text = dgvKhoanVay.Rows[dong].Cells[1].Value.ToString();
                txtTong.Text = dgvKhoanVay.Rows[dong].Cells[2].Value?.ToString() ?? "0";
                txtTienThang.Text = dgvKhoanVay.Rows[dong].Cells[3].Value?.ToString() ?? "0";// Giả sử tiền tháng là tổng tiền
                dtpNgayVay.Text = dgvKhoanVay.Rows[dong].Cells[4].Value.ToString();
                dtpThoiHan.Text = dgvKhoanVay.Rows[dong].Cells[5].Value.ToString();
                lbSoThang.Text = dgvKhoanVay.Rows[dong].Cells[6].Value.ToString();
                cboTrangThai.Text = dgvKhoanVay.Rows[dong].Cells[7].Value.ToString();
                cboMaKH.Text = bs.GetTenKhachHang(dgvKhoanVay.Rows[dong].Cells[8].Value.ToString());
                txtMaLaiSuat.Text = dgvKhoanVay.Rows[dong].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLaiSuat_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvLaiSuat.CurrentRow.Index;
                txtMaLaiSuat.Text = dgvLaiSuat.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void TinhSoThang()
        {
            DateTime ngayVay = dtpNgayVay.Value;
            DateTime thoiHan = dtpThoiHan.Value;

            if (thoiHan > ngayVay)
            {
                int soThang = (thoiHan.Year - ngayVay.Year) * 12 + (thoiHan.Month - ngayVay.Month);

                if (thoiHan.Day < ngayVay.Day)
                    soThang--;

                lbSoThang.Text = soThang.ToString();
            }
            else
            {
                lbSoThang.Text = "0";
            }
        }

        private void dtpNgayVay_ValueChanged(object sender, EventArgs e)
        {
            TinhSoThang();
            TinhTienKhoanVay();
        }

        private void dtpThoiHan_ValueChanged(object sender, EventArgs e)
        {
            TinhSoThang();
            TinhTienKhoanVay();
        }

        private void TinhTienKhoanVay()
        {
            try
            {
                if (!decimal.TryParse(txtSoTienVay.Text, out decimal soTienVay)) return;
                if (!int.TryParse(lbSoThang.Text, out int soThang)) return;
                if (string.IsNullOrEmpty(txtMaLaiSuat.Text)) return;

                // Lấy lãi suất từ DataGridView
                var dong = dgvLaiSuat.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells[0].Value?.ToString() == txtMaLaiSuat.Text);

                if (dong == null) return;

                decimal laiSuat = Convert.ToDecimal(dong.Cells[2].Value); // LAISUAT
                string loaiLai = dong.Cells[3].Value.ToString(); // LOAIVAY: "THÁNG" hoặc "NĂM"

                // Tính tiền
                decimal tienGocThang = soTienVay / soThang;
                decimal tienLaiThang = (loaiLai.ToUpper() == "NĂM")
                                        ? soTienVay * (laiSuat / 100) / 12
                                        : soTienVay * (laiSuat / 100);

                decimal tienHangThang = tienGocThang + tienLaiThang;
                decimal tongTien = tienHangThang * soThang;

                // Gán vào textbox
                txtTienThang.Text = tienHangThang.ToString("N0"); // định dạng 1,000
                txtTong.Text = tongTien.ToString("N0");
            }
            catch
            {
                // Tránh crash nếu dữ liệu chưa đầy đủ
            }
        }

        private void txtSoTienVay_TextChanged(object sender, EventArgs e)
        {
            TinhTienKhoanVay();
        }

        private void txtMaLaiSuat_TextChanged(object sender, EventArgs e)
        {
            TinhTienKhoanVay();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();

            // Nếu người dùng chưa nhập gì hoặc chỉ gõ tạm thời
            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgvKhoanVay.DataSource = bs.LoadDSKhoanVay();
                return;
            }

            // Nếu keyword có vẻ là ngày nhưng chưa đúng -> bỏ qua tìm theo ngày
            DateTime ngayTim;
            bool isValidDate = DateTime.TryParse(keyword, out ngayTim) && ngayTim >= new DateTime(1753, 1, 1);

            try
            {
                dgvKhoanVay.DataSource = bs.TimKiemKhoanVay(keyword); // Trong đó đã xử lý isValidDate rồi
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

        private void txtSoTienVay_Leave(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtSoTienVay.Text))
            {
                errorProvider1.SetError(txtSoTienVay, ""); // Xóa lỗi
                txtSoTienVay.BackColor = Color.White; // Trả lại màu bình thường
                return;
            }

            //Ktra nhập có đúng định dạng số không
            if (!decimal.TryParse(txtSoTienVay.Text, out _))
            {
                txtSoTienVay.BackColor = Color.LightPink; // Highlight đỏ hồng khi sai
                errorProvider1.SetError(txtSoTienVay, "Vui lòng nhập số hợp lệ."); // hiện icon lỗi
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienVay.Clear(); // Xóa nội dung ô nhập
                txtSoTienVay.Focus(); // Trả lại con trỏ để sửa
            }
            else
            {
                errorProvider1.SetError(txtSoTienVay, ""); // Xóa icon lỗi
                txtSoTienVay.BackColor = Color.White; // Đúng thì trả về màu bình thường
            }
        }
    }
}
