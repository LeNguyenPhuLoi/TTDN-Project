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
    public partial class Frm_TaiKhoan : GUI.Form1
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
            dgv_TaiKhoan.DataSource = bUS_TaiKhoan.LayDSTaiKhoan();
            dgv_TaiKhoan.Columns["KHACHHANG"].Visible = false;
            dgv_TaiKhoan.Columns["LOAITIEN"].Visible = false;
            dgv_TaiKhoan.Columns["LOAITAIKHOAN"].Visible = false;
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
    }
}
