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

namespace GUI
{
    public partial class Frm_TaiKhoan : Form
    {
        public Frm_TaiKhoan()
        {
            InitializeComponent();
        }

        BUS_TaiKhoan bUS_TaiKhoan = new BUS_TaiKhoan();

        private void Frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            dtp_NgayMoTK.MaxDate = DateTime.Now;
            Clear();
            dgv_TaiKhoan.Columns["KHACHHANG"].Visible = false;
            dgv_TaiKhoan.Columns["LOAITIEN"].Visible = false;
            dgv_TaiKhoan.Columns["LOAITAIKHOAN"].Visible = false;
            ThemVaoCBO(cbo_TenKH, bUS_TaiKhoan.LayDSTenKH());
            ThemVaoCBO(cbo_LoaiTaiKhoan, bUS_TaiKhoan.LayDSLoaiTaiKhoan());
            ThemVaoCBO(cbo_LoaiTien, bUS_TaiKhoan.LayDSTenLoaiTien());
        }

        public void ThemVaoCBO(ComboBox cbo, IQueryable list)
        {
            foreach (string s in list) 
            { 
                cbo.Items.Add(s);
            }
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
            gb_ThongTin.Location = new Point(width - 520, 150);
            gb_ChucNang.Location = new Point(width - 520, 50);
        }

        private void Frm_TaiKhoan_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        public void Clear()
        {
            txt_MaTK.Clear();
            cbo_TenKH.Text = null;
            txt_SoTK.Clear();
            cbo_LoaiTaiKhoan.Text = null;
            txt_SoDu.Clear();
            cbo_LoaiTien.Text = null;
            dtp_NgayMoTK.Text = dtp_NgayMoTK.MaxDate.ToString();
            cbo_TrangThai.Text = null;
            cbo_PhuongThuc.SelectedIndex = 0;
            txt_GiaTri.Clear();
            dgv_TaiKhoan.DataSource = bUS_TaiKhoan.LayDSTaiKhoan();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_TaiKhoan tk = new ET_TaiKhoan(txt_MaTK.Text,
                                                    bUS_TaiKhoan.LayMaKHTheoTen(cbo_TenKH.Text),
                                                    txt_SoTK.Text,
                                                    bUS_TaiKhoan.LayMaLTKTheoChiTiet(cbo_LoaiTaiKhoan.Text),
                                                    Convert.ToDecimal(txt_SoDu.Text),
                                                    bUS_TaiKhoan.LayMaLTTheoTen(cbo_LoaiTien.Text),
                                                    dtp_NgayMoTK.Value,
                                                    cbo_TrangThai.Text);
                if (bUS_TaiKhoan.ThemTaiKhoan(tk) == true)
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
            dgv_TaiKhoan.DataSource = bUS_TaiKhoan.LayDSTaiKhoan();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_TaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_TaiKhoan.CurrentCell.RowIndex;
                txt_MaTK.Text = dgv_TaiKhoan.Rows[dong].Cells[0].Value.ToString();
                cbo_TenKH.Text = bUS_TaiKhoan.LayTenKHTheoMa(dgv_TaiKhoan.Rows[dong].Cells[1].Value.ToString());
                txt_SoTK.Text = dgv_TaiKhoan.Rows[dong].Cells[2].Value.ToString();
                cbo_LoaiTaiKhoan.Text = bUS_TaiKhoan.LayChiTietTheoMaLTK(dgv_TaiKhoan.Rows[dong].Cells[3].Value.ToString());
                txt_SoDu.Text = dgv_TaiKhoan.Rows[dong].Cells[4].Value.ToString();
                cbo_LoaiTien.Text = bUS_TaiKhoan.LayTenTheoMaLT(dgv_TaiKhoan.Rows[dong].Cells[5].Value.ToString());
                dtp_NgayMoTK.Text = dgv_TaiKhoan.Rows[dong].Cells[6].Value.ToString();
                cbo_TrangThai.Text = dgv_TaiKhoan.Rows[dong].Cells[7].Value.ToString();
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
                ET_TaiKhoan tk = new ET_TaiKhoan(txt_MaTK.Text,
                                                    bUS_TaiKhoan.LayMaKHTheoTen(cbo_TenKH.Text),
                                                    txt_SoTK.Text,
                                                    bUS_TaiKhoan.LayMaLTKTheoChiTiet(cbo_LoaiTaiKhoan.Text),
                                                    Convert.ToDecimal(txt_SoDu.Text),
                                                    bUS_TaiKhoan.LayMaLTTheoTen(cbo_LoaiTien.Text),
                                                    dtp_NgayMoTK.Value,
                                                    cbo_TrangThai.Text);
                if (bUS_TaiKhoan.SuaTaiKhoan(tk) == true)
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
            dgv_TaiKhoan.DataSource = bUS_TaiKhoan.LayDSTaiKhoan();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_TaiKhoan tk = new ET_TaiKhoan(txt_MaTK.Text,
                                                    bUS_TaiKhoan.LayMaKHTheoTen(cbo_TenKH.Text),
                                                    txt_SoTK.Text,
                                                    bUS_TaiKhoan.LayMaLTKTheoChiTiet(cbo_LoaiTaiKhoan.Text),
                                                    Convert.ToDecimal(txt_SoDu.Text),
                                                    bUS_TaiKhoan.LayMaLTTheoTen(cbo_LoaiTien.Text),
                                                    dtp_NgayMoTK.Value,
                                                    cbo_TrangThai.Text);
                    if (bUS_TaiKhoan.XoaTaiKhoan(tk) == true)
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
            dgv_TaiKhoan.DataSource = bUS_TaiKhoan.LayDSTaiKhoan();
        }

        private void cbo_PhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_PhuongThuc.Text == "Tên Khách Hàng")
                {
                    cbo_TenKHTK.Visible = true;
                    cbo_TenKHTK.Items.Clear();
                    ThemVaoCBO(cbo_TenKHTK, bUS_TaiKhoan.LayDSTenKH());
                    txt_GiaTri.Visible = false;
                }
                else
                {
                    txt_GiaTri.Visible = true;
                    cbo_TenKHTK.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThuc.Text)
                {
                    case "Mã Tài Khoản":
                        dgv_TaiKhoan.DataSource = bUS_TaiKhoan.TimTKTheoMaTK(txt_GiaTri.Text);
                        break;

                    case "Tên Khách Hàng":
                        dgv_TaiKhoan.DataSource = bUS_TaiKhoan.TimTKTheoTenKH(cbo_TenKHTK.Text);
                        break;

                    case "Số Tài Khoản":
                        dgv_TaiKhoan.DataSource = bUS_TaiKhoan.TimTKTheoSTK(txt_GiaTri.Text);
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
