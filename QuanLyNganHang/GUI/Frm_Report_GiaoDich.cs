using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ET;
using BUS;
using System.Configuration;

namespace GUI
{
    public partial class Frm_Report_GiaoDich : Form
    {
        public Frm_Report_GiaoDich()
        {
            InitializeComponent();
        }

        BUS_GiaoDichRP bus_gd = new BUS_GiaoDichRP();

        private void Frm_Report_GiaoDich_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_GiaoDich rpt = new GUI.Report.Report_GiaoDich();
            rpt.SetDataSource(bus_gd.LoadDSGiaoDich());
            crv_GiaoDich.ReportSource = rpt;
            crv_GiaoDich.Refresh();
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

        private void Frm_Report_GiaoDich_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Report_GiaoDich rpt = new GUI.Report.Report_GiaoDich();
                switch (cbo_PhuongThuc.Text) 
                {
                    case "Mã Giao Dịch":
                        rpt.SetDataSource(bus_gd.LoadDSGiaoDichTheoMa(txt_GiaTri.Text));
                        crv_GiaoDich.ReportSource = rpt;
                        crv_GiaoDich.Refresh();
                        break;

                    case "Số Tài Khoản":
                        rpt.SetDataSource(bus_gd.LoadDSGiaoDichTheoSTK(txt_GiaTri.Text));
                        crv_GiaoDich.ReportSource = rpt;
                        crv_GiaoDich.Refresh();
                        break;

                    case "Loại Giao Dịch":
                        rpt.SetDataSource(bus_gd.LoadDSGiaoDichTheoLoaiGD(txt_GiaTri.Text));
                        crv_GiaoDich.ReportSource = rpt;
                        crv_GiaoDich.Refresh();
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
