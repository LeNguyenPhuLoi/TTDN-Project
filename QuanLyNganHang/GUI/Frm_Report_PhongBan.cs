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
        BUS_PhongBan bus_PhongBan = new BUS_PhongBan();

        private void Frm_Report_PhongBan_Load(object sender, EventArgs e)
        {
            btn_LamMoi_Click(sender, e);
            AddToCBO(bus_PhongBan.LoadTenPB(), cbo_tenpb);
        }
        public void AddToCBO(IQueryable list, ComboBox cbo)
        {
            foreach (var item in list)
            {
                cbo.Items.Add(item);
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            GUI.Report.Report_PhongBan rpt = new GUI.Report.Report_PhongBan();
            rpt.SetDataSource(bus_pb.TimRPPhongBanTheoMa("1"));
            crv_PhongBan.ReportSource = rpt;
            crv_PhongBan.Refresh();
            txt_GiaTri.Clear();
            cbo_PhuongThuc.SelectedIndex = -1;
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
                            rpt.SetDataSource(bus_pb.TimRPPhongBanTheoTen(cbo_tenpb.Text));
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

        private void cbo_PhuongThuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_PhuongThuc.Text == "Tên Phòng Ban")
                {
                    cbo_tenpb.Visible = true;
                    txt_GiaTri.Visible = false;
                }
                else
                {
                    cbo_tenpb.Visible = false;
                    txt_GiaTri.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

    }
}
