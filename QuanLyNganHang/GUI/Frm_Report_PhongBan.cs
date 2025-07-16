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
    public partial class Frm_Report_PhongBan : Form
    {
        public Frm_Report_PhongBan()
        {
            InitializeComponent();
        }

        BUS_ReportPhongBan bus_pb = new BUS_ReportPhongBan();

        private void Frm_Report_PhongBan_Load(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_PhongBan rpt = new GUI.Report.Report_PhongBan();
            rpt.SetDataSource(bus_pb.LoadDSPhongBan());
            crv_PhongBan.ReportSource = rpt;
            crv_PhongBan.Refresh();
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
                    GUI.Report.Report_PhongBan rpt = new GUI.Report.Report_PhongBan();
                    switch (cbo_PhuongThuc.Text)
                    {
                        case "Mã Phòng Ban":
                            rpt.SetDataSource(bus_pb.TimRPPhongBanTheoMa(txt_GiaTri.Text));
                            crv_PhongBan.ReportSource = rpt;
                            crv_PhongBan.Refresh();
                            break;

                        case "Tên Phòng Ban":
                            rpt.SetDataSource(bus_pb.TimRPPhongBanTheoTen(txt_GiaTri.Text));
                            crv_PhongBan.ReportSource = rpt;
                            crv_PhongBan.Refresh();
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
