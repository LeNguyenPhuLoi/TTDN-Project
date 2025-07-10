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
    public partial class Frm_Report_TaiKhoan : Form
    {
        public Frm_Report_TaiKhoan()
        {
            InitializeComponent();
        }

        BUS_TaiKhoanRP bus_tk = new BUS_TaiKhoanRP();

        private void Frm_Report_TaiKhoan_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_TaiKhoan rpt = new GUI.Report.Report_TaiKhoan();
            rpt.SetDataSource(bus_tk.LoadDSTaiKhoan());
            crv_TaiKhoan.ReportSource = rpt;
            crv_TaiKhoan.Refresh();
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

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Report_TaiKhoan rpt = new GUI.Report.Report_TaiKhoan();
                switch (cbo_PhuongThuc.Text) 
                {
                    case "Mã Tài Khoản":
                        rpt.SetDataSource(bus_tk.LoadDSTaiKhoanTheoMa(txt_GiaTri.Text));
                        crv_TaiKhoan.ReportSource = rpt;
                        crv_TaiKhoan.Refresh();
                        break;

                    case "Tên Khách Hàng":
                        rpt.SetDataSource(bus_tk.LoadDSTaiKhoanTheoTenKH(txt_GiaTri.Text));
                        crv_TaiKhoan.ReportSource = rpt;
                        crv_TaiKhoan.Refresh();
                        break;

                    case "Số Tài Khoản":
                        rpt.SetDataSource(bus_tk.LoadDSTaiKhoanTheoSoTK(txt_GiaTri.Text));
                        crv_TaiKhoan.ReportSource = rpt;
                        crv_TaiKhoan.Refresh();
                        break;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Frm_Report_TaiKhoan_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
    }
}
