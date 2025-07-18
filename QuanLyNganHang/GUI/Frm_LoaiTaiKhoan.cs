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
    public partial class Frm_LoaiTaiKhoan : Form
    {
        public Frm_LoaiTaiKhoan()
        {
            InitializeComponent();
        }

        BUS_LoaiTaiKhoan bUS_LoaiTaiKhoan = new BUS_LoaiTaiKhoan();

        private void Frm_LoaiTaiKhoan_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            Clear();
        }

        private void Frm_LoaiTaiKhoan_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        public void Clear()
        {
            txt_MaLoaiTK.Text = null;
            rtxt_ChiTiet.Clear();
            cbo_PhuongThuc.SelectedIndex = 0;
            txt_GiaTri.Text = null;
            dgv_LoaiTaiKhoan.DataSource = bUS_LoaiTaiKhoan.LoadDSLoaiTaiKhoan();
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

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LoaiTaiKhoan ltk = new ET_LoaiTaiKhoan(txt_MaLoaiTK.Text,
                                                            rtxt_ChiTiet.Text);
                if (bUS_LoaiTaiKhoan.ThemLoaiTaiKhoan(ltk) == true)
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
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            dgv_LoaiTaiKhoan.DataSource = bUS_LoaiTaiKhoan.LoadDSLoaiTaiKhoan();
        }

        private void dgv_LoaiTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_LoaiTaiKhoan.CurrentCell.RowIndex;
                txt_MaLoaiTK.Text = dgv_LoaiTaiKhoan.Rows[dong].Cells[0].Value.ToString();
                rtxt_ChiTiet.Text = dgv_LoaiTaiKhoan.Rows[dong].Cells[1].Value.ToString();
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
                ET_LoaiTaiKhoan ltk = new ET_LoaiTaiKhoan(txt_MaLoaiTK.Text,
                                                            rtxt_ChiTiet.Text);
                if (bUS_LoaiTaiKhoan.SuaThongTinLoaiTaiKhoan(ltk) == true)
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
            dgv_LoaiTaiKhoan.DataSource = bUS_LoaiTaiKhoan.LoadDSLoaiTaiKhoan();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_LoaiTaiKhoan ltk = new ET_LoaiTaiKhoan(txt_MaLoaiTK.Text,
                                                                rtxt_ChiTiet.Text);
                    if (bUS_LoaiTaiKhoan.XoaLoaiTaiKhoan(ltk) == true)
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
            dgv_LoaiTaiKhoan.DataSource = bUS_LoaiTaiKhoan.LoadDSLoaiTaiKhoan();

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThuc.Text)
                {
                    case "Mã Loại":
                        dgv_LoaiTaiKhoan.DataSource = bUS_LoaiTaiKhoan.LayLTKTheoMa(txt_GiaTri.Text);
                        break;

                    case "Chi Tiết":
                        dgv_LoaiTaiKhoan.DataSource = bUS_LoaiTaiKhoan.LayLTKTheoChiTiet(txt_GiaTri.Text);
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
            if (MaxState == true)
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
                if (panel_DanhSach.Location.Y <= 50)
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
                if (panel_DanhSach.Width >= width - 30)
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

        bool darkmode = false;

        private void pb_DarkMode_Click(object sender, EventArgs e)
        {
            if (darkmode == false)
            {
                lbl_title.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(30, 30, 30);

                panel_ChucNang.BackColor = Color.FromArgb(43, 43, 43);
                panel_ChucNang.BorderColor = Color.FromArgb(43, 43, 43);
                panel_DanhSach.BackColor = Color.FromArgb(43, 43, 43);
                panel_DanhSach.BorderColor = Color.FromArgb(43, 43, 43);
                panel_ThongTin.BackColor = Color.FromArgb(43, 43, 43);
                panel_ThongTin.BorderColor = Color.FromArgb(43, 43, 43);
                gb_Timkiem.BackColor = Color.FromArgb(43, 43, 43);
                gb_Timkiem.BorderColor = Color.FromArgb(43, 43, 43);
                dgv_LoaiTaiKhoan.BackgroundColor = Color.FromArgb(43, 43, 43);

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

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;

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
                dgv_LoaiTaiKhoan.BackgroundColor = Color.FromArgb(224, 224, 224);

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

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;

                darkmode = false;
            }
        }
    }
}
