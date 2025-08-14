using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace GUI
{
    public partial class frmChuyenKhoan : Form
    {
        public frmChuyenKhoan()
        {
            InitializeComponent();
        }
        BUS_ChuyenKhoan bs = new BUS_ChuyenKhoan();
        private void frmChuyenKhoan_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvChuyenKhoan.DefaultCellStyle.SelectionForeColor = Color.Black;

            //bỏ tiêu đề cột trống
            dgvChuyenKhoan.RowHeadersVisible = false;
            // Màu nền khi chọn ô (dòng)
            dgvChuyenKhoan.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvChuyenKhoan.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvChuyenKhoan.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvChuyenKhoan.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvChuyenKhoan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChuyenKhoan.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvChuyenKhoan.RowsDefaultCellStyle.BackColor = Color.White;
            dgvChuyenKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvChuyenKhoan.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Canh giữa dữ liệu nếu cần
            dgvChuyenKhoan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            btnHoanTac.PerformClick();

            dgvChuyenKhoan.DataSource = bs.LoadDSTK();
            AddToCombo(bs.LoadMaTK(),cboMaTKGui);
            AddToCombo(bs.LoadMaTK(), cboMaTKNhan);
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
                ET_ChuyenKhoan et = new ET_ChuyenKhoan(txtMaCK.Text, dtpNgayChuyen.Value,
                                                   int.Parse(txtSoTien.Text), cboMaTKGui.Text,
                                                   cboMaTKNhan.Text, txtNoiDung.Text);
                string error = "";
                if (bs.ThemChuyenKhoan(et, out error) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvChuyenKhoan.DataSource = bs.LoadDSTK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ChuyenKhoan et = new ET_ChuyenKhoan(txtMaCK.Text, dtpNgayChuyen.Value,
                                                    int.Parse(txtSoTien.Text), cboMaTKGui.Text,
                                                    cboMaTKNhan.Text, txtNoiDung.Text);
                string error = "";
                if (bs.CapNhatChuyenKhoan(et, out error) == true)
                {
                    MessageBox.Show("Cập Nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvChuyenKhoan.DataSource = bs.LoadDSTK();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng không để trống khi sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ET_ChuyenKhoan et = new ET_ChuyenKhoan(txtMaCK.Text, dtpNgayChuyen.Value,
                                                        int.Parse(txtSoTien.Text), cboMaTKGui.Text,
                                                        cboMaTKNhan.Text, txtNoiDung.Text);
                    string error = "";
                    if (bs.XoaChuyenKhoan(et, out error) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvChuyenKhoan.DataSource = bs.LoadDSTK();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu muốn xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaCK.Clear();
            txtSoTien.Clear();
            txtNoiDung.Clear();
            txtTim.Clear();
            cboMaTKGui.SelectedIndex = -1;
            cboMaTKNhan.SelectedIndex = -1;
            dtpNgayChuyen.Value = DateTime.Now; // Đặt lại ngày chuyển về ngày hiện tại
            txtMaCK.Focus(); // Đặt con trỏ vào ô nhập mã chuyển khoản
            dgvChuyenKhoan.DataSource = bs.LoadDSTK();
        }

        private void dgvChuyenKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvChuyenKhoan.CurrentRow.Index;
                txtMaCK.Text = dgvChuyenKhoan.Rows[dong].Cells[0].Value.ToString();
                dtpNgayChuyen.Text = dgvChuyenKhoan.Rows[dong].Cells[1].Value.ToString();
                txtSoTien.Text = dgvChuyenKhoan.Rows[dong].Cells[2].Value.ToString();
                cboMaTKGui.Text = dgvChuyenKhoan.Rows[dong].Cells[3].Value.ToString();
                cboMaTKNhan.Text = dgvChuyenKhoan.Rows[dong].Cells[4].Value.ToString();
                txtNoiDung.Text = dgvChuyenKhoan.Rows[dong].Cells[5].Value.ToString();
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
                dgvChuyenKhoan.DataSource = bs.LoadDSTK();
                return;
            }

            // Nếu keyword có vẻ là ngày nhưng chưa đúng -> bỏ qua tìm theo ngày
            DateTime ngayTim;
            bool isValidDate = DateTime.TryParse(keyword, out ngayTim) && ngayTim >= new DateTime(1753, 1, 1);

            try
            {
                dgvChuyenKhoan.DataSource = bs.TimChuyenKhoan(keyword); // Trong đó đã xử lý isValidDate rồi
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

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            // Nếu để trống thì không làm gì cả
            if (string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                errorProvider1.SetError(txtSoTien, ""); // Xóa lỗi
                txtSoTien.BackColor = Color.White; // Trả lại màu bình thường
                return;
            }

            //Ktra nhập có đúng định dạng số không
            if (!decimal.TryParse(txtSoTien.Text, out _))
            {
                txtSoTien.BackColor = Color.LightPink; // Highlight đỏ hồng khi sai
                errorProvider1.SetError(txtSoTien, "Vui lòng nhập số hợp lệ."); // hiện icon lỗi
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Clear(); // Xóa nội dung ô nhập
                txtSoTien.Focus(); // Trả lại con trỏ để sửa
            }
            else
            {
                errorProvider1.SetError(txtSoTien, ""); // Xóa icon lỗi
                txtSoTien.BackColor = Color.White; // Đúng thì trả về màu bình thường
            }
        }
    }
}
