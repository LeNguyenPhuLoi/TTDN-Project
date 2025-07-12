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

namespace GUI
{
    public partial class Frm_Report_BienLai : Form
    {
        public Frm_Report_BienLai()
        {
            InitializeComponent();
        }

        BUS_BienLaiRP bUS_BienLai = new BUS_BienLaiRP();

        private void Frm_Report_BienLai_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_BienLai rpt = new GUI.Report.Report_BienLai();
            rpt.SetDataSource(bUS_BienLai.LoadDSBienLai());
            crv_BienLai.ReportSource = rpt;
            crv_BienLai.Refresh();
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

        private void Frm_Report_BienLai_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Report_BienLai rpt = new GUI.Report.Report_BienLai();
                switch (cbo_PhuongThuc.Text)
                {
                    case "Mã Biên Lai":
                        rpt.SetDataSource(bUS_BienLai.LoadDSBienLaiTheoMa(txt_GiaTri.Text));
                        crv_BienLai.ReportSource = rpt;
                        crv_BienLai.Refresh();
                        break;

                    case "Tên Khách Hàng":
                        rpt.SetDataSource(bUS_BienLai.LoadDSBienLaiTheoTenKH(txt_GiaTri.Text));
                        crv_BienLai.ReportSource = rpt;
                        crv_BienLai.Refresh();
                        break;

                    case "Số Tài Khoản":
                        rpt.SetDataSource(bUS_BienLai.LoadDSBienLaiTheoSTK(txt_GiaTri.Text));
                        crv_BienLai.ReportSource = rpt;
                        crv_BienLai.Refresh();
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
