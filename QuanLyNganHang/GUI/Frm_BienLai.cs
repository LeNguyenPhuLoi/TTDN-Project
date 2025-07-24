using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ET;
using BUS;
using System.Linq;
using GUI.Controls;

namespace GUI
{
    public partial class Frm_BienLai : Form
    {
        public Frm_BienLai()
        {
            InitializeComponent();
        }

        BUS_BienLai bUS_BienLai = new BUS_BienLai();

        private void Frm_BienLai_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            Clear();
            dgv_BienLai.Columns["KHACHHANG"].Visible = false;
            dgv_BienLai.Columns["NHANVIEN"].Visible = false;
            ThemVaoCBOCustom(bUS_BienLai.LayMaGD(), cbo_MaGD);
            ThemVaoCBOCustom(bUS_BienLai.LayDSTenNV(), cbo_TenNV);
            panel2.BringToFront();
        }

        public void ThemVaoCBO(IQueryable list, ComboBox cbo)
        {
            foreach (var item in list) 
            { 
                cbo.Items.Add(item);
            }
        }

        public void ThemVaoCBOCustom(IQueryable list, RJComboBox cbo)
        {
            foreach (var item in list)
            {
                cbo.Items.Add(item);
            }
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

        private void Frm_BienLai_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        public void Clear()
        {
            txt_MaBL.Text = null;
            cbo_MaGD.Text = null;
            cbo_TenKH.Text = null;
            cbo_SoTK.Text = null;
            cbo_SoTK.Items.Clear();
            cbo_TenNV.Text = null;
            cbo_SoTien.Text = null;
            cbo_TenLoaiTien.Text = null;
            txt_LoaiBL.Text = null;
            rtxt_MoTa.Clear();
            cbo_TrangThai.Text = null;
            txt_GiaTri.Text = null;
            cbo_PhuongThuc.SelectedIndex = 0;
            dgv_BienLai.DataSource = bUS_BienLai.LayDSBienLai();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbo_MaGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbo_TenKH.Items.Clear();
                ThemVaoCBOCustom(bUS_BienLai.LayTenKHTheoMaBL(cbo_MaGD.Text), cbo_TenKH);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbo_TenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbo_SoTK.Items.Clear();
                ThemVaoCBOCustom(bUS_BienLai.LaySoTKTheoTen(cbo_TenKH.Text), cbo_SoTK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbo_SoTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbo_SoTien.Items.Clear();
                ThemVaoCBOCustom(bUS_BienLai.LayDSSoTienTheoSTK(cbo_SoTK.Text), cbo_SoTien);
                cbo_TenLoaiTien.Items.Clear();
                ThemVaoCBOCustom(bUS_BienLai.LayTenLoaiTienTheoSTK(cbo_SoTK.Text), cbo_TenLoaiTien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_BienLai_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_BienLai.CurrentCell.RowIndex;
                txt_MaBL.Text = dgv_BienLai.Rows[dong].Cells[0].Value.ToString();
                cbo_MaGD.Text = dgv_BienLai.Rows[dong].Cells[1].Value.ToString();
                cbo_TenKH.Text = bUS_BienLai.LayTenKHTheoMaKH(dgv_BienLai.Rows[dong].Cells[2].Value.ToString());
                cbo_SoTK.Text = bUS_BienLai.LaySoTKTheoMaTK(dgv_BienLai.Rows[dong].Cells[3].Value.ToString());
                cbo_TenNV.Text = bUS_BienLai.LayTenNVTheoMa(dgv_BienLai.Rows[dong].Cells[4].Value.ToString());
                cbo_SoTien.Text = dgv_BienLai.Rows[dong].Cells[5].Value.ToString();
                cbo_TenLoaiTien.Text = bUS_BienLai.LayTenLTTheoMaLT(dgv_BienLai.Rows[dong].Cells[6].Value.ToString());
                txt_LoaiBL.Text = dgv_BienLai.Rows[dong].Cells[7].Value.ToString();
                rtxt_MoTa.Text = dgv_BienLai.Rows[dong].Cells[8].Value.ToString();
                cbo_TrangThai.Text = dgv_BienLai.Rows[dong].Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_BienLai bl = new ET_BienLai(txt_MaBL.Text,
                                                cbo_MaGD.Text,
                                                bUS_BienLai.LayMaKHTheoTen(cbo_TenKH.Text),
                                                bUS_BienLai.LayMaTKTheoSo(cbo_SoTK.Text),
                                                bUS_BienLai.LayMaNVTheoTen(cbo_TenNV.Text),
                                                Convert.ToDecimal(cbo_SoTien.Text),
                                                bUS_BienLai.LayMaLoaiTienTheoTen(cbo_TenLoaiTien.Text),
                                                txt_LoaiBL.Text,
                                                rtxt_MoTa.Text,
                                                cbo_TrangThai.Text);
                if (bUS_BienLai.ThemBienLai(bl) == true)
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
            dgv_BienLai.DataSource = bUS_BienLai.LayDSBienLai();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_BienLai bl = new ET_BienLai(txt_MaBL.Text,
                                                cbo_MaGD.Text,
                                                bUS_BienLai.LayMaKHTheoTen(cbo_TenKH.Text),
                                                bUS_BienLai.LayMaTKTheoSo(cbo_SoTK.Text),
                                                bUS_BienLai.LayMaNVTheoTen(cbo_TenNV.Text),
                                                Convert.ToDecimal(cbo_SoTien.Text),
                                                bUS_BienLai.LayMaLoaiTienTheoTen(cbo_TenLoaiTien.Text),
                                                txt_LoaiBL.Text,
                                                rtxt_MoTa.Text,
                                                cbo_TrangThai.Text);
                if (bUS_BienLai.SuaBienLai(bl) == true)
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
            dgv_BienLai.DataSource = bUS_BienLai.LayDSBienLai();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_BienLai bl = new ET_BienLai(txt_MaBL.Text,
                                                cbo_MaGD.Text,
                                                bUS_BienLai.LayMaKHTheoTen(cbo_TenKH.Text),
                                                bUS_BienLai.LayMaTKTheoSo(cbo_SoTK.Text),
                                                bUS_BienLai.LayMaNVTheoTen(cbo_TenNV.Text),
                                                Convert.ToDecimal(cbo_SoTien.Text),
                                                bUS_BienLai.LayMaLoaiTienTheoTen(cbo_TenLoaiTien.Text),
                                                txt_LoaiBL.Text,
                                                rtxt_MoTa.Text,
                                                cbo_TrangThai.Text);
                    if (bUS_BienLai.XoaBienLai(bl) == true)
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
            dgv_BienLai.DataSource = bUS_BienLai.LayDSBienLai();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThuc.Text)
                {
                    case "Mã Biên Lai":
                        dgv_BienLai.DataSource = bUS_BienLai.TimBLTheoMaBl(txt_GiaTri.Text);
                        break;

                    case "Mã Giao Dịch":
                        dgv_BienLai.DataSource = bUS_BienLai.TimBLTheoMaGD(txt_GiaTri.Text);
                        break;

                    case "Tên Khách Hàng":
                        dgv_BienLai.DataSource = bUS_BienLai.TimBLTheoTenKH(cbo_GiaTri.Text);
                        break;

                    case "Số Tài Khoản":
                        dgv_BienLai.DataSource = bUS_BienLai.TimBLTheoSTK(cbo_GiaTri.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbo_PhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_PhuongThuc.SelectedIndex == 2)
                {
                    cbo_GiaTri.Items.Clear();
                    ThemVaoCBOCustom(bUS_BienLai.LayTenKH(), cbo_GiaTri);
                    txt_GiaTri.Visible = false;
                    cbo_GiaTri.Visible = true;
                }
                else if (cbo_PhuongThuc.SelectedIndex == 3)
                {
                    cbo_GiaTri.Items.Clear();
                    ThemVaoCBOCustom(bUS_BienLai.LaySTK(), cbo_GiaTri);
                    txt_GiaTri.Visible = false;
                    cbo_GiaTri.Visible = true;
                }
                else
                {
                    txt_GiaTri.Visible = true;
                    cbo_GiaTri.Visible = false;
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
                dgv_BienLai.BackgroundColor = Color.FromArgb(43, 43, 43);

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
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
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
                dgv_BienLai.BackgroundColor = Color.FromArgb(224, 224, 224);

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
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;

                darkmode = false;
            }
        }
    }
}
