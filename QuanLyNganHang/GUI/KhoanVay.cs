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
            
        }

        BUS_KhoanVay bs = new BUS_KhoanVay();
        BUS_LaiSuat bsLaiSuat = new BUS_LaiSuat();

        private void KhoanVay_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#263238");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DED4CA");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

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
            txtSoTienVay.Clear();
            cboMaKH.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtpNgayVay.Value = DateTime.Now;
            dtpThoiHan.Value = DateTime.Now;
            txtMaLaiSuat.Clear();
            txtMaVay.Focus();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_KhoanVay et = new ET_KhoanVay(txtMaVay.Text,decimal.Parse(txtSoTienVay.Text),
                                                dtpNgayVay.Value,dtpThoiHan.Value,
                                                cboTrangThai.Text,bs.GetMaKhachHang(cboMaKH.Text),txtMaLaiSuat.Text
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_KhoanVay et = new ET_KhoanVay(txtMaVay.Text, decimal.Parse(txtSoTienVay.Text),
                                                dtpNgayVay.Value, dtpThoiHan.Value,
                                                cboTrangThai.Text, bs.GetMaKhachHang(cboMaKH.Text), txtMaLaiSuat.Text
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ET_KhoanVay et = new ET_KhoanVay(txtMaVay.Text, decimal.Parse(txtSoTienVay.Text),
                                                dtpNgayVay.Value, dtpThoiHan.Value,
                                                cboTrangThai.Text, bs.GetMaKhachHang(cboMaKH.Text), txtMaLaiSuat.Text
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

        private void dgvKhoanVay_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvKhoanVay.CurrentRow.Index;
                txtMaVay.Text = dgvKhoanVay.Rows[dong].Cells[0].Value.ToString();
                txtSoTienVay.Text = dgvKhoanVay.Rows[dong].Cells[1].Value.ToString();
                dtpNgayVay.Text = dgvKhoanVay.Rows[dong].Cells[2].Value.ToString();
                dtpThoiHan.Text = dgvKhoanVay.Rows[dong].Cells[3].Value.ToString();
                cboTrangThai.Text = dgvKhoanVay.Rows[dong].Cells[4].Value.ToString();
                cboMaKH.Text = bs.GetTenKhachHang(dgvKhoanVay.Rows[dong].Cells[5].Value.ToString());
                txtMaLaiSuat.Text = dgvKhoanVay.Rows[dong].Cells[6].Value.ToString();
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
    }
}
