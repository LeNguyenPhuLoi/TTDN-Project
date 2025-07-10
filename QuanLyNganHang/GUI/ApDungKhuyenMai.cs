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
            this.BackColor = ColorTranslator.FromHtml("#263238");
            pnlMain.BackColor = ColorTranslator.FromHtml("#DCDCDC");
            lbTim.ForeColor = ColorTranslator.FromHtml("#DED4CA");

            dgvApDungKhuyenMai.DataSource = bs.LoadDSApDungKhuyenMai();
            dgvKH.DataSource = bs.LoadDSKhachHang();
            dgvKhuyenMai.DataSource = bs.LoadDSKM();
            
            // Thêm dữ liệu vào các ComboBox
            AddToCombo(bsck.LoadMaTK(), cboMaTK);
            
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
            ET_ApDungKhuyenMai et = new ET_ApDungKhuyenMai(txtMaKM.Text, txtMaKH.Text, cboMaTK.Text, dtpNgayApDung.Value);
            string error= "";
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

        private void btnXoa_Click(object sender, EventArgs e)
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

        private void btnSua_Click(object sender, EventArgs e)
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


        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            txtMaKM.Clear();
            txtMaKH.Clear();
            cboMaTK.SelectedIndex = -1; // Đặt lại ComboBox về trạng thái không chọn
            dtpNgayApDung.Value = DateTime.Now; // Đặt lại ngày áp dụng về ngày hiện tại
            cboMaTK.Focus(); // Đặt con trỏ vào ô mã khuyến mãi để nhập tiếp
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

        private void lbTim_Click(object sender, EventArgs e)
        {

        }
    }
}
