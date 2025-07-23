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
    public partial class Frm_ChiNhanh : Form
    {
        public Frm_ChiNhanh()
        {
            InitializeComponent();
        }

        BUS_ChiNhanh bus_ChiNhanh = new BUS_ChiNhanh();

        private void Frm_ChiNhanh_Load(object sender, EventArgs e)
        {
            //Đổi màu khi được chọn
            dgv_chinhanh.DefaultCellStyle.SelectionBackColor = Color.Orange;

            //Xen kẽ màu với nhau
            dgv_chinhanh.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv_chinhanh.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            cbo_phuongthuc.SelectedIndex = 0;
            dgv_chinhanh.DataSource = bus_ChiNhanh.LoadDSCN();
        }


        public void Clear()
        {
            txt_macn.Clear();
            txt_tencn.Clear();
            txt_diachicn.Clear();
            txt_sdtcn.Clear();
            txt_giatri.Clear();
            dgv_chinhanh.DataSource = bus_ChiNhanh.LoadDSCN();
            cbo_phuongthuc.SelectedIndex = 0;
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();           
        }

        private void dgv_chinhanh_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_chinhanh.CurrentCell.RowIndex;
                txt_macn.Text = dgv_chinhanh.Rows[dong].Cells[0].Value.ToString();
                txt_tencn.Text = dgv_chinhanh.Rows[dong].Cells[1].Value.ToString();
                txt_diachicn.Text = dgv_chinhanh.Rows[dong].Cells[2].Value.ToString();
                txt_sdtcn.Text = dgv_chinhanh.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ChiNhanh cn = new ET_ChiNhanh(txt_macn.Text,
                                                    txt_tencn.Text,
                                                    txt_diachicn.Text,
                                                    int.Parse(txt_sdtcn.Text));
                if(bus_ChiNhanh.ThemCN(cn) == true)
                {
                    MessageBox.Show("Thêm chi nhánh thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm chi nhánh thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_chinhanh.DataSource = bus_ChiNhanh.LoadDSCN();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ChiNhanh cn = new ET_ChiNhanh(txt_macn.Text,
                                                    txt_tencn.Text,
                                                    txt_diachicn.Text,
                                                    int.Parse(txt_sdtcn.Text));
                if (bus_ChiNhanh.SuaCN(cn) == true)
                {
                    MessageBox.Show("Sửa chi nhánh thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa chi nhánh thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_chinhanh.DataSource = bus_ChiNhanh.LoadDSCN();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_ChiNhanh cn = new ET_ChiNhanh(txt_macn.Text,
                                                    txt_tencn.Text,
                                                    txt_diachicn.Text,
                                                    int.Parse(txt_sdtcn.Text));
                    if (bus_ChiNhanh.XoaCN(cn) == true)
                    {
                        MessageBox.Show("Xóa chi nhánh thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi nhánh thất bại!");
                    }
                }        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_chinhanh.DataSource = bus_ChiNhanh.LoadDSCN();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_phuongthuc.Text)
                {
                    case "Mã Chi Nhánh":
                        dgv_chinhanh.DataSource = bus_ChiNhanh.TimCNTheoMa(txt_giatri.Text);
                        break;
                    case "Tên Chi Nhánh":
                        dgv_chinhanh.DataSource = bus_ChiNhanh.TimCNTheoTen(txt_giatri.Text);
                        break;
                    case "SĐT Chi Nhánh":
                        dgv_chinhanh.DataSource = bus_ChiNhanh.TimCNTheoSDT(int.Parse(txt_giatri.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
