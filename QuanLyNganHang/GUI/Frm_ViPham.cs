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
    public partial class Frm_ViPham : Form
    {
        public Frm_ViPham()
        {
            InitializeComponent();
        }

        BUS_ViPham bus_ViPham = new BUS_ViPham();

        private void Frm_ViPham_Load(object sender, EventArgs e)
        {
            //Đổi màu khi được chọn
            dgv_vipham.DefaultCellStyle.SelectionBackColor = Color.Orange;

            //Xen kẽ màu với nhau
            dgv_vipham.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv_vipham.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgv_vipham.DataSource = bus_ViPham.LoadDSVP();
            cbo_timnq.Visible = false;
            AddToCBO(bus_ViPham.LoadNQ(), cbo_manq);
            AddToCBO(bus_ViPham.LoadNV(), cbo_manv);
            AddToCBO(bus_ViPham.LoadKH(), cbo_makh);
            AddToCBO(bus_ViPham.LoadMoTa(), cbo_motavp);
            AddToCBO(bus_ViPham.LoadMoTa(), cbo_timnq);
        }


        public void AddToCBO(IQueryable list, ComboBox cbo)
        {
            foreach (var item in list)
            {
                cbo.Items.Add(item);
            }
        }

        public void Clear()
        {
            txt_mavp.Clear();
            cbo_manq.Text = null;
            cbo_manv.Text = null;
            cbo_makh.Text = null;
            dtp_ngayvp.Text = dtp_ngayvp.MaxDate.ToString();
            cbo_motavp.Text = null;
            txt_giatri.Clear();
            txt_hinhthucxl.Clear();
            cbo_trangthai.Text = null;
            dgv_vipham.DataSource = bus_ViPham.LoadDSVP();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_vipham_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_vipham.CurrentCell.RowIndex;
                txt_mavp.Text = dgv_vipham.Rows[dong].Cells[0].Value.ToString();
                cbo_manq.Text = bus_ViPham.LayTieuDeNQTheoMa(dgv_vipham.Rows[dong].Cells[1].Value.ToString());
                cbo_manv.Text = bus_ViPham.LayTenNVTheoMa(dgv_vipham.Rows[dong].Cells[2].Value != null ? dgv_vipham.Rows[dong].Cells[2].Value.ToString() : null);
                cbo_makh.Text = bus_ViPham.LayTenKHTheoMa(dgv_vipham.Rows[dong].Cells[3].Value != null ? dgv_vipham.Rows[dong].Cells[3].Value.ToString(): null);
                dtp_ngayvp.Text = dgv_vipham.Rows[dong].Cells[4].Value.ToString();
                cbo_motavp.Text = dgv_vipham.Rows[dong].Cells[5].Value.ToString();
                txt_hinhthucxl.Text = dgv_vipham.Rows[dong].Cells[6].Value.ToString();
                cbo_trangthai.Text = dgv_vipham.Rows[dong].Cells[7].Value.ToString();
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
                ET_ViPham vp = new ET_ViPham(txt_mavp.Text,
                                                bus_ViPham.LayMaNQTheoTieuDe(cbo_manq.Text),
                                                bus_ViPham.LayMaNVTheoTen(cbo_manv.Text),
                                                bus_ViPham.LayMaKHTheoTen(cbo_makh.Text),
                                                dtp_ngayvp.Value,
                                                cbo_motavp.Text,
                                                txt_hinhthucxl.Text,
                                                cbo_trangthai.Text);
                if(bus_ViPham.ThemVP(vp) == true)
                {
                    MessageBox.Show("Thêm vi phạm thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm vi phạm thất bại!");
                }
                                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_vipham.DataSource = bus_ViPham.LoadDSVP();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_ViPham vp = new ET_ViPham(txt_mavp.Text,
                                                bus_ViPham.LayMaNQTheoTieuDe(cbo_manq.Text),
                                                bus_ViPham.LayMaNVTheoTen(cbo_manv.Text),
                                                bus_ViPham.LayMaKHTheoTen(cbo_makh.Text),
                                                dtp_ngayvp.Value,
                                                cbo_motavp.Text,
                                                txt_hinhthucxl.Text,
                                                cbo_trangthai.Text);
                if (bus_ViPham.SuaVP(vp) == true)
                {
                    MessageBox.Show("Sửa vi phạm thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa vi phạm thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_vipham.DataSource = bus_ViPham.LoadDSVP();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_ViPham vp = new ET_ViPham(txt_mavp.Text,
                                                bus_ViPham.LayMaNQTheoTieuDe(cbo_manq.Text),
                                                bus_ViPham.LayMaNVTheoTen(cbo_manv.Text),
                                                bus_ViPham.LayMaKHTheoTen(cbo_makh.Text),
                                                dtp_ngayvp.Value,
                                                cbo_motavp.Text,
                                                txt_hinhthucxl.Text,
                                                cbo_trangthai.Text);
                    if (bus_ViPham.XoaVP(vp) == true)
                    {
                        MessageBox.Show("Xóa vi phạm thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa vi phạm thất bại!");
                    }
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_vipham.DataSource = bus_ViPham.LoadDSVP();
        }



        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_phuongthuc.Text)
                {
                    case "Mã Vi Phạm":
                        dgv_vipham.DataSource = bus_ViPham.TimVPTheoMa(txt_giatri.Text);
                        break;
                    case "Mã Nội Quy":
                        dgv_vipham.DataSource = bus_ViPham.TimVPTheoNQ(txt_giatri.Text);                       
                        break;
                    case "Mã Nhân Viên":
                        dgv_vipham.DataSource = bus_ViPham.TimVPTheoNV(txt_giatri.Text);
                        break;
                    case "Mã Khách Hàng":
                        dgv_vipham.DataSource = bus_ViPham.TimVPTheoKH(txt_giatri.Text);
                        break;
                    case "Mô Tả Vi Phạm":
                        dgv_vipham.DataSource = bus_ViPham.TimVPTheoMoTa(cbo_timnq.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void cbo_phuongthuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_phuongthuc.Text == "Mô Tả Vi Phạm")
                {
                    cbo_timnq.Visible = true;
                    txt_giatri.Visible = false;
                }
                else
                {
                    cbo_timnq.Visible = false;
                    txt_giatri.Visible = true;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

    }
}
