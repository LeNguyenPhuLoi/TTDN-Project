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
    public partial class Frm_LoaiTaiKhoan : GUI.Form1
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
            txt_MaLoaiTK.Clear();
            rtxt_ChiTiet.Clear();
            cbo_PhuongThuc.SelectedIndex = 0;
            txt_GiaTri.Clear();
            dgv_LoaiTaiKhoan.DataSource = bUS_LoaiTaiKhoan.LoadDSLoaiTaiKhoan();
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
    }
}
