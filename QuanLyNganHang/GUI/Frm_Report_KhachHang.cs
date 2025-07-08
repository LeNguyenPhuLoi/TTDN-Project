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
using GUI.Report;

namespace GUI
{
    public partial class Frm_Report_KhachHang : Form
    {
        public Frm_Report_KhachHang()
        {
            InitializeComponent();
        }

        BUS_KhachHangRP bus_kh = new BUS_KhachHangRP();

        private void Frm_Report_KhachHang_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_KhachHang rpt = new GUI.Report.Report_KhachHang();
            rpt.SetDataSource(bus_kh.LoadDSKhachHang());
            crv_KhachHang.ReportSource = rpt;
            crv_KhachHang.Refresh();
        }

        public void SetSize()
        {
            int width = this.Width;
            int height = this.Height;
            gb_TimKiem.Location = new Point(5, 5);
            gb_DanhSachKhacHang.Height = height-125;
        }

        private void Frm_Report_KhachHang_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Report_KhachHang rpt = new GUI.Report.Report_KhachHang();
                switch (cbo_PhuongThuc.Text) 
                {
                    case "Mã Khách Hàng":                     
                        rpt.SetDataSource(bus_kh.LoadDSKhachHangTheoMa(txt_GiaTri.Text));
                        crv_KhachHang.ReportSource = rpt;
                        crv_KhachHang.Refresh();
                        break;

                    case "Tên Khách Hàng":
                        rpt.SetDataSource(bus_kh.LoadDSKhachHangTheoTen(txt_GiaTri.Text));
                        crv_KhachHang.ReportSource = rpt;
                        crv_KhachHang.Refresh();
                        break;

                    case "Số Điện Thoại":
                        rpt.SetDataSource(bus_kh.LoadDSKhachHangTheosdt(txt_GiaTri.Text));
                        crv_KhachHang.ReportSource = rpt;
                        crv_KhachHang.Refresh();
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
