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
    public partial class Frm_GiaoDich : GUI.Form1
    {
        public Frm_GiaoDich()
        {
            InitializeComponent();
        }

        BUS_GiaoDich bUS_GiaoDich = new BUS_GiaoDich();

        private void Frm_GiaoDich_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            dtp_ThoiGian.MaxDate = DateTime.Now;
            SetSize();
            Clear();
            dgv_GiaoDich.Columns["TAIKHOAN"].Visible = false;
            ThemVaoCBO(bUS_GiaoDich.LaySoTK(), cbo_SoTK);
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

        public void Clear()
        {
            txt_MaGD.Clear();
            cbo_SoTK.Text = null;
            txt_LoaiGD.Clear();
            txt_SoTien.Clear();
            dtp_ThoiGian.Text = dtp_ThoiGian.MaxDate.ToString();
            rtxt_MoTa.Clear();
            cbo_TrangThai.Text = null;
            cbo_PhuongThuc.SelectedIndex = 0;
            txt_GiaTri.Clear();
            dgv_GiaoDich.DataSource = bUS_GiaoDich.LayDSGiaoDich();
        }

        private void Frm_GiaoDich_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (bUS_GiaoDich.KTTienTrongTK(cbo_SoTK.Text, Convert.ToDecimal(txt_SoTien.Text)) == false)
                {

                    MessageBox.Show("Thêm Giao Dịch Thất Bại! Số Tiền Trong Tài Khoản Không Đủ!", "Thông Báo");
                }
                else
                {
                    ET_GiaoDich gd = new ET_GiaoDich(txt_MaGD.Text,
                                                bUS_GiaoDich.LayMaTKTheoSo(cbo_SoTK.Text),
                                                txt_LoaiGD.Text,
                                                Convert.ToDecimal(txt_SoTien.Text),
                                                dtp_ThoiGian.Value,
                                                rtxt_MoTa.Text,
                                                cbo_TrangThai.Text);
                    if (bUS_GiaoDich.ThemGiaoDich(gd) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        bUS_GiaoDich.TruTien(Convert.ToDecimal(txt_SoTien.Text), cbo_SoTK.Text);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            dgv_GiaoDich.DataSource = bUS_GiaoDich.LayDSGiaoDich();
        }

        private void dgv_GiaoDich_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_GiaoDich.CurrentCell.RowIndex;
                txt_MaGD.Text = dgv_GiaoDich.Rows[dong].Cells[0].Value.ToString();
                cbo_SoTK.Text = bUS_GiaoDich.LaySoTKTheoMa(dgv_GiaoDich.Rows[dong].Cells[1].Value.ToString());
                txt_LoaiGD.Text = dgv_GiaoDich.Rows[dong].Cells[2].Value.ToString();
                txt_SoTien.Text = dgv_GiaoDich.Rows[dong].Cells[3].Value.ToString();
                dtp_ThoiGian.Text = dgv_GiaoDich.Rows[dong].Cells[4].Value.ToString();
                rtxt_MoTa.Text = dgv_GiaoDich.Rows[dong].Cells[5].Value.ToString();
                cbo_TrangThai.Text = dgv_GiaoDich.Rows[dong].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_GiaoDich gd = new ET_GiaoDich(txt_MaGD.Text,
                                                bUS_GiaoDich.LayMaTKTheoSo(cbo_SoTK.Text),
                                                txt_LoaiGD.Text,
                                                Convert.ToDecimal(txt_SoTien.Text),
                                                dtp_ThoiGian.Value,
                                                rtxt_MoTa.Text,
                                                cbo_TrangThai.Text);
                    if (bUS_GiaoDich.XoaGiaoDich(gd) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        bUS_GiaoDich.ThemTienVaoLaiTK(Convert.ToDecimal(txt_SoTien.Text),cbo_SoTK.Text);
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
            dgv_GiaoDich.DataSource = bUS_GiaoDich.LayDSGiaoDich();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_PhuongThuc.Text)
                {
                    case "Mã Giao Dịch":
                        dgv_GiaoDich.DataSource = bUS_GiaoDich.TimGDTheoMa(txt_GiaTri.Text);
                        break;

                    case "Số Tài Khoản":
                        dgv_GiaoDich.DataSource = bUS_GiaoDich.TimGDTheoSTK(cbo_STKTK.Text);
                        break;

                    case "Loại Giao Dịch":
                        dgv_GiaoDich.DataSource = bUS_GiaoDich.TimGDTheoLoai(txt_GiaTri.Text);
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
                if(cbo_PhuongThuc.Text == "Số Tài Khoản")
                {
                    cbo_STKTK.Visible = true;
                    txt_GiaTri.Visible = false;
                    cbo_STKTK.Items.Clear();
                    ThemVaoCBO(bUS_GiaoDich.LaySoTK(),cbo_STKTK);
                }
                else
                {
                    cbo_STKTK.Visible = false;
                    txt_GiaTri.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
