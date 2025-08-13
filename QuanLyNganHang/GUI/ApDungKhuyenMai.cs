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
    public partial class frmApDungKhuyenMai : Form
    {
        public frmApDungKhuyenMai()
        {
            InitializeComponent();
        }

        BUS_ChuyenKhoan bsck = new BUS_ChuyenKhoan();
        BUS_ApDungKhuyenMai bs = new BUS_ApDungKhuyenMai();

        private void frmApDungKhuyenMai_Load(object sender, EventArgs e)
        {

            //ko doi mau khi chon vao
            dgvApDungKhuyenMai.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvKhuyenMai.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvKH.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvApDungKhuyenMai.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvApDungKhuyenMai.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow
            dgvKH.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow
            dgvKhuyenMai.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvApDungKhuyenMai.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvApDungKhuyenMai.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvApDungKhuyenMai.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvApDungKhuyenMai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvApDungKhuyenMai.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvApDungKhuyenMai.RowsDefaultCellStyle.BackColor = Color.White;
            dgvApDungKhuyenMai.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng
            dgvKhuyenMai.RowsDefaultCellStyle.BackColor = Color.White;
            dgvKhuyenMai.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng
            dgvKH.RowsDefaultCellStyle.BackColor = Color.White;
            dgvKH.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvApDungKhuyenMai.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvApDungKhuyenMai.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvApDungKhuyenMai.DataSource = bs.LoadDSApDungKhuyenMai();
            dgvKH.DataSource = bs.LoadDSKhachHang();
            dgvKhuyenMai.DataSource = bs.LoadDSKM();
            
            btnHoanTac.PerformClick();
        }

        public void AddToCombo(IQueryable list, ComboBox c)
        {
            foreach (var a in list)
            {
                c.Items.Add(a);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ApDungKhuyenMai et = new ET_ApDungKhuyenMai(txtMaKM.Text, txtMaKH.Text, cboMaTK.Text, dtpNgayApDung.Value);
                string error = "";
                if (bs.ThemApDungKhuyenMai(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvApDungKhuyenMai.DataSource = bs.LoadDSApDungKhuyenMai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ET_ApDungKhuyenMai et = new ET_ApDungKhuyenMai(txtMaKM.Text, txtMaKH.Text, cboMaTK.Text, dtpNgayApDung.Value);
                    string error = "";
                    if (bs.XoaApDungKhuyenMai(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvApDungKhuyenMai.DataSource = bs.LoadDSApDungKhuyenMai();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ApDungKhuyenMai et = new ET_ApDungKhuyenMai(txtMaKM.Text, txtMaKH.Text, cboMaTK.Text, dtpNgayApDung.Value);
                string error = "";
                if (bs.CapNhatApDungKhuyenMai(et, out error) == true)
                {
                    MessageBox.Show("Cập Nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvApDungKhuyenMai.DataSource = bs.LoadDSApDungKhuyenMai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvApDungKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvApDungKhuyenMai.CurrentRow.Index;
                txtMaKM.Text = dgvApDungKhuyenMai.Rows[dong].Cells[0].Value.ToString();
                txtMaKH.Text = dgvApDungKhuyenMai.Rows[dong].Cells[1].Value.ToString();
                cboMaTK.Text = dgvApDungKhuyenMai.Rows[dong].Cells[2].Value.ToString();
                dtpNgayApDung.Text = dgvApDungKhuyenMai.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaKM.Clear();
            txtMaKH.Clear();
            cboMaTK.SelectedIndex = -1; // Đặt lại ComboBox về trạng thái không chọn
            dtpNgayApDung.Value = DateTime.Now; // Đặt lại ngày áp dụng về ngày hiện tại
            cboMaTK.Focus(); // Đặt con trỏ vào ô mã khuyến mãi để nhập tiếp
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTim.Text.Trim();

            // Nếu người dùng chưa nhập gì hoặc chỉ gõ tạm thời
            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgvApDungKhuyenMai.DataSource = bs.LoadDSApDungKhuyenMai();
                return;
            }

            // Nếu keyword có vẻ là ngày nhưng chưa đúng -> bỏ qua tìm theo ngày
            DateTime ngayTim;
            bool isValidDate = DateTime.TryParse(keyword, out ngayTim) && ngayTim >= new DateTime(1753, 1, 1);

            try
            {
                dgvApDungKhuyenMai.DataSource = bs.TimKiemApDungKhuyenMai(keyword); // Trong đó đã xử lý isValidDate rồi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKH.CurrentRow.Index;
                txtMaKH.Text = dgvKH.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKhuyenMai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKhuyenMai.CurrentRow.Index;
                txtMaKM.Text = dgvKhuyenMai.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string maKHCu = "";
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            string maKHmoi = txtMaKH.Text.Trim();

            if (maKHmoi != maKHCu) // Nếu khác giá trị cũ
            {
                maKHCu = maKHmoi; // Cập nhật giá trị mới

                // Xóa toàn bộ dữ liệu trong ComboBox
                cboMaTK.Items.Clear();

                // Nếu muốn load mới khi khác thì bật dòng dưới:
                AddToCombo(bs.LoadDSTKtheoMa(maKHmoi), cboMaTK);
            }

        }
    }
}
