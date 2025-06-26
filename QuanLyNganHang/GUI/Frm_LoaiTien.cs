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
    public partial class Frm_LoaiTien : GUI.Form1
    {
        public Frm_LoaiTien()
        {
            InitializeComponent();
        }

        BUS_LoaiTien bUS_LoaiTien = new BUS_LoaiTien();

        private void Frm_LoaiTien_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
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
            gb_DanhSach.Location = new Point(10, 150);
            gb_DanhSach.Height = height - 200;
            gb_DanhSach.Width = (width / 3) * 2;
            gb_ThongTin.Location = new Point(width - 510, 150);
            gb_ChucNang.Location = new Point(width - 510, 50);
        }

        public void Clear()
        {
            txt_MaLoaiTien.Clear();
            txt_TenLoaiTien.Clear();
            txt_KyHieu.Clear();
            txt_QuocGia.Clear();
            cbo_TrangThai.Text = null;
            cbo_PhuongThuc.SelectedIndex = 0;
            txt_GiaTri.Clear();
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
    }
}
