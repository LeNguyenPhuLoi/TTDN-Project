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
    public partial class Frm_Report_ViPham : Form
    {
        public Frm_Report_ViPham()
        {
            InitializeComponent();
        }

        BUS_ReportViPham bus_vp = new BUS_ReportViPham();

        private void Frm_Report_ViPham_Load(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_ViPham rpt = new GUI.Report.Report_ViPham();
            rpt.SetDataSource(bus_vp.LoadDSViPham());
            crv_ViPham.ReportSource = rpt;
            crv_ViPham.Refresh();
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
                    GUI.Report.Report_ViPham rpt = new GUI.Report.Report_ViPham();
                    switch (cbo_PhuongThuc.Text)
                    {
                        case "Mã Vi Phạm":
                            rpt.SetDataSource(bus_vp.TimRPViPhamTheoMa(txt_GiaTri.Text));
                            crv_ViPham.ReportSource = rpt;
                            crv_ViPham.Refresh();
                            break;

                        case "Mã Nhân Viên":
                            rpt.SetDataSource(bus_vp.TimRPViPhamTheoMaNV(txt_GiaTri.Text));
                            crv_ViPham.ReportSource = rpt;
                            crv_ViPham.Refresh();
                            break;
                        case "Mã Khách Hàng":
                            rpt.SetDataSource(bus_vp.TimRPViPhamTheoMaKH(txt_GiaTri.Text));
                            crv_ViPham.ReportSource = rpt;
                            crv_ViPham.Refresh();
                            break;
                        case "Mô Tả Vi Phạm":
                            rpt.SetDataSource(bus_vp.TimRPViPhamTheoMoTa(txt_GiaTri.Text));
                            crv_ViPham.ReportSource = rpt;
                            crv_ViPham.Refresh();
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
