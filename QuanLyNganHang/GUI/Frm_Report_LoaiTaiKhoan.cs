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
    public partial class Frm_Report_LoaiTaiKhoan : Form
    {
        public Frm_Report_LoaiTaiKhoan()
        {
            InitializeComponent();
        }

        BUS_LoaiTaiKhoanRP bus_ltk = new BUS_LoaiTaiKhoanRP();

        private void Frm_Report_LoaiTaiKhoan_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            SetSize();
            Clear();
        }

        public void Clear()
        {
            cbo_PhuongThuc.Text = null;
            txt_GiaTri.Clear();
            GUI.Report.Report_LoaiTaiKhoan rpt = new GUI.Report.Report_LoaiTaiKhoan();
            rpt.SetDataSource(bus_ltk.LoadDSLoaiTaiKhoan());
            crv_LoaiTaiKhoan.ReportSource = rpt;
            crv_LoaiTaiKhoan.Refresh();
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

        private void Frm_Report_LoaiTaiKhoan_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.Report.Report_LoaiTaiKhoan rpt = new GUI.Report.Report_LoaiTaiKhoan();
                switch (cbo_PhuongThuc.Text) 
                {
                    case "Mã Loại Tài Khoản":
                        rpt.SetDataSource(bus_ltk.LoadDSLoaiTaiKhoanTheoMa(txt_GiaTri.Text));
                        crv_LoaiTaiKhoan.ReportSource = rpt;
                        crv_LoaiTaiKhoan.Refresh();
                        break;

                    case "Chi Tiết":
                        rpt.SetDataSource(bus_ltk.LoadDSLoaiTaiKhoanTheoChiTiet(txt_GiaTri.Text));
                        crv_LoaiTaiKhoan.ReportSource = rpt;
                        crv_LoaiTaiKhoan.Refresh();
                        break;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }

    }
}
