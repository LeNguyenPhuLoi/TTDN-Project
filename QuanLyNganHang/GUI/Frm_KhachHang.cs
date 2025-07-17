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
    public partial class Frm_KhachHang : Form
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
            txt_MaKH.Text = null;
            txt_TenKH.Text = null;
            rdb_Nam.Checked = true;
            txt_CCCD.Text = null;
            txt_SDT.Text = null;
            txt_Email.Text = null;
            txt_DiaChi.Text = null;
            txt_QuocTich.Text = null;
            cbo_DoiTuong.Text = null;
            dtp_NgayTao.Text = dtp_NgayTao.MaxDate.ToString();
            cbo_PhuongThuc.SelectedIndex = 0;
            txt_GiaTri.Text = null;
            dgv_KhachHang.DataSource = bUS_KhachHang.LoadDSKhachHang();
        }

        public void SetSize()
        {
            int width = this.Width;
            int height = this.Height;
            lbl_title.Location = new Point((width / 2) - 170, 0);
            gb_Timkiem.Location = new Point(10, 50);
            panel_DanhSach.Location = new Point(10, 150);
            panel_DanhSach.Height = height - 200;
            panel_DanhSach.Width = width - 550;
            panel_ThongTin.Location = new Point(width - 510, 150);
            panel_ChucNang.Location = new Point(width - 510, 50);
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

        private void pb_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool MaxState = false;

        private void pb_Minimize_Click(object sender, EventArgs e)
        {
            if(MaxState == true)
            {
                this.WindowState = FormWindowState.Normal;
                MaxState = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                MaxState = true;
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized) 
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void pb_TimKiem_Click(object sender, EventArgs e)
        {
            timer_TimKiem.Start();
        }

        private void pb_Them_Click(object sender, EventArgs e)
        {
            timer_ChucNang.Start();
        }

        bool darkmode = false;

        private void pb_DarkMode_Click(object sender, EventArgs e)
        {
            if (darkmode == false)
            {
                lbl_title.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(30,30,30);

                panel_ChucNang.BackColor = Color.FromArgb(43, 43, 43);
                panel_ChucNang.BorderColor = Color.FromArgb(43, 43, 43);
                panel_DanhSach.BackColor = Color.FromArgb(43, 43, 43);
                panel_DanhSach.BorderColor = Color.FromArgb(43, 43, 43);
                panel_ThongTin.BackColor = Color.FromArgb(43, 43, 43);
                panel_ThongTin.BorderColor = Color.FromArgb(43, 43, 43);
                gb_Timkiem.BackColor = Color.FromArgb(43, 43, 43);
                gb_Timkiem.BorderColor = Color.FromArgb(43, 43, 43);
                dgv_KhachHang.BackgroundColor = Color.FromArgb(43, 43, 43);

                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;

                btn_Tim.ForeColor = Color.White;
                btn_Tim.BorderColor = Color.White;
                btn_Tim.BackColor = Color.FromArgb(47, 52, 52);
                btn_Them.ForeColor = Color.White;
                btn_Them.BorderColor = Color.White;
                btn_Them.BackColor = Color.FromArgb(47, 52, 52);
                btn_Sua.ForeColor = Color.White;
                btn_Sua.BorderColor = Color.White;
                btn_Sua.BackColor = Color.FromArgb(47, 52, 52);
                btn_Xoa.ForeColor = Color.White;
                btn_Xoa.BorderColor = Color.White;
                btn_Xoa.BackColor = Color.FromArgb(47, 52, 52);
                btn_Lammoi.ForeColor = Color.White;
                btn_Lammoi.BorderColor = Color.White;
                btn_Lammoi.BackColor = Color.FromArgb(47, 52, 52);

                darkmode = true;
            }
            else 
            {
                lbl_title.ForeColor = Color.Red;
                this.BackColor = SystemColors.Control;

                panel_ChucNang.BackColor = Color.FromArgb(224, 224, 224);
                panel_ChucNang.BorderColor = Color.FromArgb(224, 224, 224);
                panel_DanhSach.BackColor = Color.FromArgb(224, 224, 224);
                panel_DanhSach.BorderColor = Color.FromArgb(224, 224, 224);
                panel_ThongTin.BackColor = Color.FromArgb(224, 224, 224);
                panel_ThongTin.BorderColor = Color.FromArgb(224, 224, 224);
                gb_Timkiem.BackColor = Color.FromArgb(224, 224, 224);
                gb_Timkiem.BorderColor = Color.FromArgb(224, 224, 224);
                dgv_KhachHang.BackgroundColor = Color.FromArgb(224, 224, 224);

                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;

                btn_Tim.ForeColor = Color.Black;
                btn_Tim.BorderColor = Color.Black;
                btn_Tim.BackColor = Color.Silver;
                btn_Them.ForeColor = Color.Black;
                btn_Them.BorderColor = Color.Black;
                btn_Them.BackColor = Color.Silver;
                btn_Sua.ForeColor = Color.Black;
                btn_Sua.BorderColor = Color.Black;
                btn_Sua.BackColor = Color.Silver;
                btn_Xoa.ForeColor = Color.Black;
                btn_Xoa.BorderColor = Color.Black;
                btn_Xoa.BackColor = Color.Silver;
                btn_Lammoi.ForeColor = Color.Black;
                btn_Lammoi.BorderColor = Color.Black;
                btn_Lammoi.BackColor = Color.Silver;

                darkmode = false;
            }
        }

        bool timkiem = true;

        private void timer_TimKiem_Tick(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            if (timkiem) 
            {
                gb_Timkiem.Location = new Point(10, gb_Timkiem.Location.Y - 10);
                panel_DanhSach.Location = new Point(panel_DanhSach.Location.X, panel_DanhSach.Location.Y - 10);
                panel_DanhSach.Height = panel_DanhSach.Height + 10;
                if(panel_DanhSach.Location.Y <= 50)
                {
                    timer_TimKiem.Stop();
                    timkiem = false;
                }
            }
            else
            {
                gb_Timkiem.Location = new Point(10, gb_Timkiem.Location.Y + 10);
                panel_DanhSach.Location = new Point(panel_DanhSach.Location.X, panel_DanhSach.Location.Y + 10);
                panel_DanhSach.Height = panel_DanhSach.Height - 10;
                if (panel_DanhSach.Location.Y >= 148)
                {
                    timer_TimKiem.Stop();
                    timkiem = true;
                }
            }
        }

        bool chucnang = true;

        private void timer_ChucNang_Tick(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            if (chucnang) 
            {
                panel_ChucNang.Location = new Point(panel_ChucNang.Location.X + 20, panel_ChucNang.Location.Y);
                panel_ThongTin.Location = new Point(panel_ThongTin.Location.X + 20, panel_ThongTin.Location.Y);
                panel_DanhSach.Width = panel_DanhSach.Width + 20;
                if(panel_DanhSach.Width >= width - 30)
                {
                    timer_ChucNang.Stop();
                    chucnang = false;
                }
            }
            else
            {
                panel_ChucNang.Location = new Point(panel_ChucNang.Location.X - 20, panel_ChucNang.Location.Y);
                panel_ThongTin.Location = new Point(panel_ThongTin.Location.X - 20, panel_ThongTin.Location.Y);
                panel_DanhSach.Width = panel_DanhSach.Width - 20;
                if (panel_DanhSach.Width <= width - 570)
                {
                    timer_ChucNang.Stop();
                    chucnang = true;
                }
            }
        }
    }
}
