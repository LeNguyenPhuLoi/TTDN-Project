using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmReport_LichSuTraNo : Form
    {
        public frmReport_LichSuTraNo()
        {
            InitializeComponent();
        }
        BUS_LichSuTraNo_RP bus = new BUS_LichSuTraNo_RP();
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtMaVay.Text.Trim();
                GUI.Report.Report_LichSuTraNo rpt = new GUI.Report.Report_LichSuTraNo();
                if (string.IsNullOrEmpty(keyword))
                {
                    rpt.SetDataSource(bus.LoadLSTNRP());
                    crvLishSuTraNo.ReportSource = rpt;
                }
                else
                {
                    rpt.SetDataSource(bus.TimLSTNRP(keyword));
                    crvLishSuTraNo.ReportSource = rpt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                crvLishSuTraNo.Refresh();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaVay.Clear();
            GUI.Report.Report_LichSuTraNo rpt = new GUI.Report.Report_LichSuTraNo();
            rpt.SetDataSource(bus.LoadLSTNRP());
            crvLishSuTraNo.ReportSource = rpt;
            crvLishSuTraNo.Refresh();
            txtMaVay.Focus();
        }

        private void Report_LichSuTraNo_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }
    }
}
