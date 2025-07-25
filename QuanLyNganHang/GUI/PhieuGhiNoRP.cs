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
    public partial class frmPhieuGhiNoRP : Form
    {
        public frmPhieuGhiNoRP()
        {
            InitializeComponent();
        }

        BUS_KhoanVay_RP bus = new BUS_KhoanVay_RP();

        private void frmPhieuGhiNoRP_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtMaVay.Text.Trim();
                GUI.Report.Report_PhieuVay rpt = new GUI.Report.Report_PhieuVay();
                if (string.IsNullOrEmpty(keyword))
                {
                    rpt.SetDataSource(bus.LoadKhoanVayRP());
                    crvPhieuVay.ReportSource = rpt;
                }
                else
                {
                    rpt.SetDataSource(bus.TimKiemKhoanVayRP(keyword));
                    crvPhieuVay.ReportSource = rpt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                crvPhieuVay.Refresh();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaVay.Clear();
            GUI.Report.Report_PhieuVay rpt = new GUI.Report.Report_PhieuVay();
            rpt.SetDataSource(bus.LoadKhoanVayRP());
            crvPhieuVay.ReportSource = rpt;
            crvPhieuVay.Refresh();
            txtMaVay.Focus();
        }

        private void txtMaVay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
