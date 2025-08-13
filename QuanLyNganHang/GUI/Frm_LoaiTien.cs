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
    public partial class Frm_LoaiTien : Form
    {
        public Frm_LoaiTien()
        {
            InitializeComponent();
        }

        BUS_LoaiTien bUS_LoaiTien = new BUS_LoaiTien();

        private void Frm_LoaiTien_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            SetSize();
            Clear();
        }

        private void Frm_LoaiTien_Resize(object sender, EventArgs e)
        {
            SetSize();
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
            panel2.BringToFront();

        }

        public void Clear()
        {
            txt_MaLoaiTien.Text = null;
            txt_TenLoaiTien.Text = null;
            txt_KyHieu.Text = null;
            txt_QuocGia.Text = null;
            cbo_TrangThai.Text = null;
            cbo_PhuongThuc.SelectedIndex = 0;
            txt_GiaTri.Text = null;
            dgv_LoaiTien.DataSource = bUS_LoaiTien.LayDSLoaiTien();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_LoaiTien lt = new ET_LoaiTien(txt_MaLoaiTien.Text,
                                                    txt_TenLoaiTien.Text,
                                                    txt_KyHieu.Text,
                                                    txt_QuocGia.Text,
                                                    cbo_TrangThai.Text);
                if (bUS_LoaiTien.ThemLoaiTien(lt) == true)
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
            dgv_LoaiTien.DataSource = bUS_LoaiTien.LayDSLoaiTien();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_LoaiTien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_LoaiTien.CurrentCell.RowIndex;
                txt_MaLoaiTien.Text = dgv_LoaiTien.Rows[dong].Cells[0].Value.ToString();
                txt_TenLoaiTien.Text = dgv_LoaiTien.Rows[dong].Cells[1].Value.ToString();
                txt_KyHieu.Text = dgv_LoaiTien.Rows[dong].Cells[2].Value.ToString();
                txt_QuocGia.Text = dgv_LoaiTien.Rows[dong].Cells[3].Value.ToString();
                cbo_TrangThai.Text = dgv_LoaiTien.Rows[dong].Cells[4].Value.ToString();

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
                ET_LoaiTien lt = new ET_LoaiTien(txt_MaLoaiTien.Text,
                                                    txt_TenLoaiTien.Text,
                                                    txt_KyHieu.Text,
                                                    txt_QuocGia.Text,
                                                    cbo_TrangThai.Text);
                if (bUS_LoaiTien.SuaThongTinLoaiTien(lt) == true)
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
            dgv_LoaiTien.DataSource = bUS_LoaiTien.LayDSLoaiTien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_LoaiTien lt = new ET_LoaiTien(txt_MaLoaiTien.Text,
                                                    txt_TenLoaiTien.Text,
                                                    txt_KyHieu.Text,
                                                    txt_QuocGia.Text,
                                                    cbo_TrangThai.Text);
                    if (bUS_LoaiTien.XoaLoaiTien(lt) == true)
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
            dgv_LoaiTien.DataSource = bUS_LoaiTien.LayDSLoaiTien();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThuc.Text)
                {
                    case "Mã Loại Tiền":
                        dgv_LoaiTien.DataSource = bUS_LoaiTien.TimLoaiTienTheoMa(txt_GiaTri.Text);
                        break;

                    case "Tên Loại Tiền":
                        dgv_LoaiTien.DataSource = bUS_LoaiTien.TimLoaiTienTheoTen(txt_GiaTri.Text);
                        break;

                    case "Quốc Gia":
                        dgv_LoaiTien.DataSource = bUS_LoaiTien.TimLoaiTienTheoQG(txt_GiaTri.Text);
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
                dgv_LoaiTien.BackgroundColor = Color.FromArgb(43, 43, 43);

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

                label6.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
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
                dgv_LoaiTien.BackgroundColor = Color.FromArgb(224, 224, 224);

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

                label6.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;

                darkmode = false;
            }
        }
    }
}
