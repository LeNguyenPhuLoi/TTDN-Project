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
    public partial class Frm_Report_NhanVien : Form
    {
        public Frm_Report_NhanVien()
        {
            InitializeComponent();
        }

        BUS_ReportNhanVien bus_nv = new BUS_ReportNhanVien();

        private void Frm_Report_NhanVien_Load(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_NhanVien rpt = new GUI.Report.Report_NhanVien();
            rpt.SetDataSource(bus_nv.LoadDSNhanVien());
            crv_NhanVien.ReportSource = rpt;
            crv_NhanVien.Refresh();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    GUI.Report.Report_NhanVien rpt = new GUI.Report.Report_NhanVien();
                    switch (cbo_PhuongThuc.Text)
                    {
                        case "Mã Nhân Viên":
                            rpt.SetDataSource(bus_nv.TimRPNhanVienTheoMa(txt_GiaTri.Text));
                            crv_NhanVien.ReportSource = rpt;
                            crv_NhanVien.Refresh();
                            break;

                        case "Tên Nhân Viên":
                            rpt.SetDataSource(bus_nv.TimRPNhanVienTheoTen(txt_GiaTri.Text));
                            crv_NhanVien.ReportSource = rpt;
                            crv_NhanVien.Refresh();
                            break;

                        case "Số Điện Thoại":
                            rpt.SetDataSource(bus_nv.TimRPNhanVienTheoSdt(txt_GiaTri.Text));
                            crv_NhanVien.ReportSource = rpt;
                            crv_NhanVien.Refresh();
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
}
    

