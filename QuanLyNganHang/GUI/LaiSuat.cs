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
    public partial class frmLaiSuat : Form
    {
        public frmLaiSuat()
        {
            InitializeComponent();
        }
        BUS_LaiSuat bs = new BUS_LaiSuat();

        private void frmLaiSuat_Load(object sender, EventArgs e)
        {
            //ko doi mau khi chon vao
            dgvLaiSuat.DefaultCellStyle.SelectionForeColor = Color.Black;


            // Màu nền khi chọn ô (dòng)
            dgvLaiSuat.DefaultCellStyle.SelectionBackColor = Color.Yellow; // hoặc Color.Yellow

            // Cỡ chữ cho toàn bộ lưới
            dgvLaiSuat.Font = new Font("Segoe UI", 12);

            // Cỡ chữ cho tiêu đề cột
            dgvLaiSuat.EnableHeadersVisualStyles = false; // Cho phép dùng style tùy chỉnh
            dgvLaiSuat.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;
            dgvLaiSuat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLaiSuat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            // Xem kẽ màu dòng
            dgvLaiSuat.RowsDefaultCellStyle.BackColor = Color.White;
            dgvLaiSuat.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; // xanh dương sáng

            // Cỡ chữ cho ô dữ liệu
            dgvLaiSuat.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            dgvLaiSuat.DataSource = bs.LoadDSLaiSuat();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LaiSuat et = new ET_LaiSuat(txtMaLS.Text, txtTenLoai.Text,
                                                             int.Parse(txtLaiSuat.Text),
                                                             cboKL.Text);
                string errorMessage;
                if (bs.ThemLaiSuat(et, out errorMessage) == true)
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvLaiSuat.DataSource = bs.LoadDSLaiSuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Vui lòng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ET_LaiSuat et = new ET_LaiSuat(txtMaLS.Text, txtTenLoai.Text,
                                                 int.Parse(txtLaiSuat.Text),
                                                 cboKL.Text);
                    string errorMessage;
                    if (bs.XoaLaiSuat(et, out errorMessage) == true)
                    {
                        MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                    }
                    else
                    {
                        MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvLaiSuat.DataSource = bs.LoadDSLaiSuat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Vui lòng chọn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LaiSuat et = new ET_LaiSuat(txtMaLS.Text, txtTenLoai.Text,
                                                             int.Parse(txtLaiSuat.Text),
                                                             cboKL.Text);
                string errorMessage;
                if (bs.CapNhatLaiSuat(et, out errorMessage) == true)
                {
                    MessageBox.Show("Cập Nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvLaiSuat.DataSource = bs.LoadDSLaiSuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Vui lòng chọn để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtLaiSuat.Clear();
            txtMaLS.Clear();
            txtTenLoai.Clear();
            cboKL.SelectedIndex = -1; // Đặt lại ComboBox về trạng thái không chọn
            txtMaLS.Focus();
        }

        private void dgvLaiSuat_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvLaiSuat.CurrentRow.Index;
                txtMaLS.Text = dgvLaiSuat.Rows[dong].Cells[0].Value.ToString();
                txtTenLoai.Text = dgvLaiSuat.Rows[dong].Cells[1].Value.ToString();
                txtLaiSuat.Text = dgvLaiSuat.Rows[dong].Cells[2].Value.ToString();
                cboKL.Text = dgvLaiSuat.Rows[dong].Cells[3].Value.ToString();
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
    }
}
