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
            SetSize();
            dgv_GiaoDich.DataSource = bUS_GiaoDich.LayDSGiaoDich();
            dgv_GiaoDich.Columns["TAIKHOAN"].Visible = false;
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

        private void Frm_GiaoDich_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
    }
}
