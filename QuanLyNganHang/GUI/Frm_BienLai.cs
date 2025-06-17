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
    public partial class Frm_BienLai : GUI.Form1
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
            dgv_BienLai.DataSource = bUS_BienLai.LayDSBienLai();
            dgv_BienLai.Columns["KHACHHANG"].Visible = false;
            dgv_BienLai.Columns["NHANVIEN"].Visible = false;
            ThemVaoCBO(bUS_BienLai.LayMaGD(), cbo_MaGD);
            ThemVaoCBO(bUS_BienLai.LayDSTenNV(), cbo_TenNV);
        }

        public void ThemVaoCBO(IQueryable list, ComboBox cbo)
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
            gb_DanhSach.Location = new Point(10, 150);
            gb_DanhSach.Height = height - 200;
            gb_DanhSach.Width = (width / 3) * 2;
            gb_ThongTin.Location = new Point(width - 510, 150);
            gb_ChucNang.Location = new Point(width - 510, 50);
        }

        private void Frm_BienLai_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        public void Clear()
        {
            txt_MaBL.Clear();
            cbo_MaGD.Text = null;
            cbo_TenKH.Text = null;
            cbo_SoTK.Text = null;
            cbo_SoTK.Items.Clear();
            cbo_TenNV.Text = null;
            cbo_SoTien.Text = null;
            cbo_TenLoaiTien.Text = null;
            txt_LoaiBL.Clear();
            rtxt_MoTa.Clear();
            cbo_TrangThai.Text = null;
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
                ThemVaoCBO(bUS_BienLai.LayTenKHTheoMaBL(cbo_MaGD.Text), cbo_TenKH);
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
                ThemVaoCBO(bUS_BienLai.LaySoTKTheoTen(cbo_TenKH.Text), cbo_SoTK);
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
                ThemVaoCBO(bUS_BienLai.LayDSSoTienTheoSTK(cbo_SoTK.Text), cbo_SoTien);
                cbo_TenLoaiTien.Items.Clear();
                ThemVaoCBO(bUS_BienLai.LayTenLoaiTienTheoSTK(cbo_SoTK.Text), cbo_TenLoaiTien);
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
    }
}
