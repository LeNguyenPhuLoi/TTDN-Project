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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            //Đổi màu khi được chọn
            dgv_nhanvien.DefaultCellStyle.SelectionBackColor = Color.Orange;

            //Xen kẽ màu với nhau
            dgv_nhanvien.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv_nhanvien.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgv_nhanvien.DataSource = bus_NhanVien.LoadDSNV();
            rdb_nam.Checked = true;
            cbo_timcn.Visible = false;
            txt_giatri.Visible = true;
            AddToCBO(bus_NhanVien.LoadTenPB(), cbo_mapb);
            AddToCBO(bus_NhanVien.LoadTenCN(), cbo_macn);
            AddToCBO(bus_NhanVien.LoadTenCN(), cbo_timcn);
            cbo_phuongthuc.SelectedIndex = 0;
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
            
            txt_manv.Clear();
            txt_tennv.Clear();
            rdb_nam.Checked = true;
            dtp_ngaysinh.Text = dtp_ngaysinh.MaxDate.ToString();
            txt_chuc.Clear();
            txt_luong.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            cbo_mapb.Text = null;
            cbo_macn.Text = null;
            txt_giatri.Clear();
            cbo_timcn.Text = null;
            cbo_phuongthuc.SelectedIndex = 0;
            dgv_nhanvien.DataSource = bus_NhanVien.LoadDSNV();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_nhanvien_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_nhanvien.CurrentCell.RowIndex;
                txt_manv.Text = dgv_nhanvien.Rows[dong].Cells[0].Value.ToString();
                txt_tennv.Text = dgv_nhanvien.Rows[dong].Cells[1].Value.ToString();
                if (dgv_nhanvien.Rows[dong].Cells[2].Value.ToString() == "NAM")
                    rdb_nam.Checked = true;
                else
                    rdb_nu.Checked = true;
                dtp_ngaysinh.Text = dgv_nhanvien.Rows[dong].Cells[3].Value.ToString();
                txt_chuc.Text = dgv_nhanvien.Rows[dong].Cells[4].Value.ToString();
                txt_luong.Text = dgv_nhanvien.Rows[dong].Cells[5].Value.ToString();
                txt_diachi.Text = dgv_nhanvien.Rows[dong].Cells[6].Value.ToString();
                txt_sdt.Text = dgv_nhanvien.Rows[dong].Cells[7].Value.ToString();
                cbo_mapb.Text = bus_NhanVien.LayTenPBTheoMa(Convert.ToInt32(dgv_nhanvien.Rows[dong].Cells[8].Value.ToString()));
                cbo_macn.Text = bus_NhanVien.LayTenCNTheoMa(dgv_nhanvien.Rows[dong].Cells[9].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        public string LayGioiTinh()
        {
            if (rdb_nam.Checked == true)
            {
                return "NAM";
            }
            else
            {
                return "NỮ";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NhanVien nv = new ET_NhanVien(txt_manv.Text,
                                                            txt_tennv.Text,
                                                            LayGioiTinh(),
                                                            dtp_ngaysinh.Value,
                                                            txt_chuc.Text,
                                                            float.Parse(txt_luong.Text),
                                                            txt_diachi.Text,
                                                            int.Parse(txt_sdt.Text),
                                                            bus_NhanVien.LayMaPBTheoTen(cbo_mapb.Text),
                                                            bus_NhanVien.LayMaCNTheoTen(cbo_macn.Text));
                if(bus_NhanVien.ThemNV(nv) == true)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_nhanvien.DataSource = bus_NhanVien.LoadDSNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NhanVien nv = new ET_NhanVien(txt_manv.Text,
                                                            txt_tennv.Text,
                                                            LayGioiTinh(),
                                                            dtp_ngaysinh.Value,
                                                            txt_chuc.Text,
                                                            int.Parse(txt_luong.Text),
                                                            txt_diachi.Text,
                                                            int.Parse(txt_sdt.Text),
                                                            bus_NhanVien.LayMaPBTheoTen(cbo_mapb.Text),
                                                            bus_NhanVien.LayMaCNTheoTen(cbo_macn.Text));
                if (bus_NhanVien.SuaNV(nv) == true)
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_nhanvien.DataSource = bus_NhanVien.LoadDSNV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult == DialogResult.Yes)
                {
                    ET_NhanVien nv = new ET_NhanVien(txt_manv.Text,
                                                            txt_tennv.Text,
                                                            LayGioiTinh(),
                                                            dtp_ngaysinh.Value,
                                                            txt_chuc.Text,
                                                            int.Parse(txt_luong.Text),
                                                            txt_diachi.Text,
                                                            int.Parse(txt_sdt.Text),
                                                            bus_NhanVien.LayMaPBTheoTen(cbo_mapb.Text),
                                                            bus_NhanVien.LayMaCNTheoTen(cbo_macn.Text));
                    if (bus_NhanVien.XoaNV(nv) == true)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_nhanvien.DataSource = bus_NhanVien.LoadDSNV();
        }

        private void cbo_phuongthuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbo_phuongthuc.Text == "Chi Nhánh")
                {
                    cbo_timcn.Visible = true;
                    txt_giatri.Visible = false;
                }
                else
                {
                    cbo_timcn.Visible = false;
                    txt_giatri.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cbo_phuongthuc.Text)
                {
                    case "Mã Nhân Viên":
                        dgv_nhanvien.DataSource = bus_NhanVien.TimNVTheoMa(txt_giatri.Text);
                        break;
                    case "Tên Nhân Viên":
                        dgv_nhanvien.DataSource = bus_NhanVien.TimNVTheoTen(txt_giatri.Text);
                        break;
                    case "SĐT":
                        dgv_nhanvien.DataSource = bus_NhanVien.TimNVTheoSDT(int.Parse(txt_giatri.Text));
                        break;
                    case "Chi Nhánh":
                        dgv_nhanvien.DataSource = bus_NhanVien.TimNVTheoTenCN(cbo_timcn.Text);
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
