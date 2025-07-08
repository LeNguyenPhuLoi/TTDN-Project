using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ET;
using BUS;

namespace GUI
{
    public partial class Frm_KhachHang : GUI.Form1
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }

        BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            dtp_NgayTao.MaxDate = DateTime.Now;
            SetSize();
            dgv_KhachHang.DataSource = bUS_KhachHang.LoadDSKhachHang();
            Clear();
        }

        private void Frm_KhachHang_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        public void Clear()
        {
            txt_MaKH.Clear();
            txt_TenKH.Clear();
            rdb_Nam.Checked = true;
            txt_CCCD.Clear();
            txt_SDT.Clear();
            txt_Email.Clear();
            txt_DiaChi.Clear();
            txt_QuocTich.Clear();
            cbo_DoiTuong.Text = null;
            dtp_NgayTao.Text = dtp_NgayTao.MaxDate.ToString();
            cbo_PhuongThuc.SelectedIndex = 0;
            txt_GiaTri.Clear();
            dgv_KhachHang.DataSource = bUS_KhachHang.LoadDSKhachHang();
        }

        public void SetSize()
        {
            int width = this.Width;
            int height = this.Height;
            lbl_title.Location = new Point((width / 2) - 170, 0);
            gb_Timkiem.Location = new Point(10, 50);
            gb_DanhSach.Location = new Point(10, 150);
            gb_DanhSach.Height = height - 200;
            gb_DanhSach.Width = (width / 3) * 2;
            gb_ThongTin.Location = new Point(width - 510, 150);
            gb_ChucNang.Location = new Point(width - 510, 50);
        }

        public string LayGioiTinh()
        {
            if (rdb_Nam.Checked)
            {
                return rdb_Nam.Text;
            }
            else 
            {
                return rdb_Nu.Text;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhachHang kh = new ET_KhachHang(txt_MaKH.Text,
                                                    txt_TenKH.Text,
                                                    LayGioiTinh(),
                                                    txt_CCCD.Text,
                                                    txt_SDT.Text,
                                                    txt_Email.Text,
                                                    txt_DiaChi.Text,
                                                    txt_QuocTich.Text,
                                                    cbo_DoiTuong.Text,
                                                    dtp_NgayTao.Value);
                if (bUS_KhachHang.ThemKhachHang(kh) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    Clear();
                }
                else 
                {
                    MessageBox.Show("Thêm không thành công!");
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
            dgv_KhachHang.DataSource = bUS_KhachHang.LoadDSKhachHang();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void KTGioiTinh(string t)
        {
            if(t == "NAM")
            {
                rdb_Nam.Checked = true;
            }
            else
            {
                rdb_Nu.Checked = true;
            }
        }

        private void dgv_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_KhachHang.CurrentCell.RowIndex;
                txt_MaKH.Text = dgv_KhachHang.Rows[dong].Cells[0].Value.ToString();
                txt_TenKH.Text = dgv_KhachHang.Rows[dong].Cells[1].Value.ToString();
                KTGioiTinh(dgv_KhachHang.Rows[dong].Cells[2].Value.ToString());
                txt_CCCD.Text = dgv_KhachHang.Rows[dong].Cells[3].Value.ToString();
                txt_SDT.Text = dgv_KhachHang.Rows[dong].Cells[4].Value.ToString();
                txt_Email.Text = dgv_KhachHang.Rows[dong].Cells[5].Value.ToString();
                txt_DiaChi.Text = dgv_KhachHang.Rows[dong].Cells[6].Value.ToString();
                txt_QuocTich.Text = dgv_KhachHang.Rows[dong].Cells[7].Value.ToString();
                cbo_DoiTuong.Text = dgv_KhachHang.Rows[dong].Cells[8].Value.ToString();
                dtp_NgayTao.Text = dgv_KhachHang.Rows[dong].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_KhachHang kh = new ET_KhachHang(txt_MaKH.Text,
                                                    txt_TenKH.Text,
                                                    LayGioiTinh(),
                                                    txt_CCCD.Text,
                                                    txt_SDT.Text,
                                                    txt_Email.Text,
                                                    txt_DiaChi.Text,
                                                    txt_QuocTich.Text,
                                                    cbo_DoiTuong.Text,
                                                    dtp_NgayTao.Value);
                if (bUS_KhachHang.SuaThongTinKhachHang(kh) == true)
                {
                    MessageBox.Show("Sửa thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            dgv_KhachHang.DataSource = bUS_KhachHang.LoadDSKhachHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_KhachHang kh = new ET_KhachHang(txt_MaKH.Text,
                                                    txt_TenKH.Text,
                                                    LayGioiTinh(),
                                                    txt_CCCD.Text,
                                                    txt_SDT.Text,
                                                    txt_Email.Text,
                                                    txt_DiaChi.Text,
                                                    txt_QuocTich.Text,
                                                    cbo_DoiTuong.Text,
                                                    dtp_NgayTao.Value);
                    if (bUS_KhachHang.XoaKhachHang(kh) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            dgv_KhachHang.DataSource = bUS_KhachHang.LoadDSKhachHang();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThuc.Text) 
                {
                    case "Mã Khách Hàng":
                        dgv_KhachHang.DataSource = bUS_KhachHang.TimKHTheoMa(txt_GiaTri.Text);
                        break;

                    case "Tên Khách Hàng":
                        dgv_KhachHang.DataSource = bUS_KhachHang.TimKHTheoTen(txt_GiaTri.Text);
                        break;

                    case "Số CCCD/CMND":
                        dgv_KhachHang.DataSource = bUS_KhachHang.TimKHTheoCCCD(txt_GiaTri.Text);
                        break;

                    case "Số Điện Thoại":
                        dgv_KhachHang.DataSource = bUS_KhachHang.TimKHTheoSDT(txt_GiaTri.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
