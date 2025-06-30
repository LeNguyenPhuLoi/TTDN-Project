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
            this.BackColor = ColorTranslator.FromHtml("#263238");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DCDCDC");
            

            dgvLaiSuat.DataSource =bs.LoadDSLaiSuat();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_LaiSuat et = new ET_LaiSuat(txtMaLS.Text, txtTenLoai.Text,
                                             int.Parse(txtLaiSuat.Text),
                                             cboKL.Text);
            if (bs.ThemLaiSuat(et) == true)
            {
                MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvLaiSuat.DataSource = bs.LoadDSLaiSuat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_LaiSuat et = new ET_LaiSuat(txtMaLS.Text, txtTenLoai.Text,
                                             int.Parse(txtLaiSuat.Text),
                                             cboKL.Text);
                if (bs.XoaLaiSuat(et) == true)
                {
                    MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnHoanTac.PerformClick(); // Gọi hàm hoàn tác để làm sạch các trường nhập
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvLaiSuat.DataSource = bs.LoadDSLaiSuat();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_LaiSuat et = new ET_LaiSuat(txtMaLS.Text, txtTenLoai.Text,
                                             int.Parse(txtLaiSuat.Text),
                                             cboKL.Text);
            if (bs.CapNhatLaiSuat(et) == true)
            {
                MessageBox.Show("Cập Nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập Nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvLaiSuat.DataSource = bs.LoadDSLaiSuat();
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
    }
}
