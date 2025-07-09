using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET;
using GUI;

namespace GUI
{
    public partial class Frm_Report_LoaiTien : Form
    {
        public Frm_Report_LoaiTien()
        {
            InitializeComponent();
        }

        BUS_LoaiTienRP bUS_LoaiTien = new BUS_LoaiTienRP();

        private void Frm_Report_LoaiTien_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_LoaiTien rpt = new GUI.Report.Report_LoaiTien();
            rpt.SetDataSource(bUS_LoaiTien.LoadDSLoaiTien());
            crv_LoaiTien.ReportSource = rpt;
            crv_LoaiTien.Refresh();
        }

        public void SetSize()
        {
            int width = this.Width;
            int height = this.Height;
            gb_TimKiem.Location = new Point(5, 5);
            gb_DanhSach.Height = height - 125;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Frm_Report_LoaiTien_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Report_LoaiTien rpt = new GUI.Report.Report_LoaiTien();
                switch (cbo_PhuongThuc.Text)
                {
                    case "Mã Loại Tiền":
                        rpt.SetDataSource(bUS_LoaiTien.LoadDSLoaiTienTheoMa(txt_GiaTri.Text));
                        crv_LoaiTien.ReportSource = rpt;
                        crv_LoaiTien.Refresh();
                        break;

                    case "Tên Loại Tiền":
                        rpt.SetDataSource(bUS_LoaiTien.LoadDSLoaiTienTheoTen(txt_GiaTri.Text));
                        crv_LoaiTien.ReportSource = rpt;
                        crv_LoaiTien.Refresh();
                        break;

                    case "Quốc Gia":
                        rpt.SetDataSource(bUS_LoaiTien.LoadDSLoaiTienTheoQG(txt_GiaTri.Text));
                        crv_LoaiTien.ReportSource = rpt;
                        crv_LoaiTien.Refresh();
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
