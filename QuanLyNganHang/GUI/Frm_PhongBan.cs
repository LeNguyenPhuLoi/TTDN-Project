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
    public partial class Frm_PhongBan : Form
    {
        public Frm_PhongBan()
        {
            InitializeComponent();
        }

        BUS_PhongBan bus_PhongBan = new BUS_PhongBan();

        private void Frm_PhongBan_Load(object sender, EventArgs e)
        {
            //Đổi màu khi được chọn
            dgv_phongban.DefaultCellStyle.SelectionBackColor = Color.Orange;

            //Xen kẽ màu với nhau
            dgv_phongban.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgv_phongban.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgv_phongban.DataSource = bus_PhongBan.LoadDSPB();
            cbo_timtenpb.Visible = false;
            cbo_phuongthuc.SelectedIndex = 0;
            AddToCBO(bus_PhongBan.LoadTenPB(), cbo_timtenpb);
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
            txt_mapb.Clear();
            txt_tenpb.Clear();
            txt_giatri.Clear();
            cbo_timtenpb.Text = null;
            dgv_phongban.DataSource = bus_PhongBan.LoadDSPB();
            cbo_phuongthuc.SelectedIndex = 0;
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_phongban_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_phongban.CurrentCell.RowIndex;
                txt_mapb.Text = dgv_phongban.Rows[dong].Cells[0].Value.ToString();
                txt_tenpb.Text = dgv_phongban.Rows[dong].Cells[1].Value.ToString();
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
                ET_PhongBan pb = new ET_PhongBan(int.Parse(txt_mapb.Text),
                                                    txt_tenpb.Text);
                if(bus_PhongBan.ThemPB(pb) == true)
                {
                    MessageBox.Show("Thêm phòng ban thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm phòng ban thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_phongban.DataSource = bus_PhongBan.LoadDSPB();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_PhongBan pb = new ET_PhongBan(int.Parse(txt_mapb.Text),
                                                    txt_tenpb.Text);
                if (bus_PhongBan.SuaPB(pb) == true)
                {
                    MessageBox.Show("Sửa phòng ban thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa phòng ban thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_phongban.DataSource = bus_PhongBan.LoadDSPB();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_PhongBan pb = new ET_PhongBan(int.Parse(txt_mapb.Text),
                                               txt_tenpb.Text);
                    if (bus_PhongBan.XoaPB(pb) == true)
                    {
                        MessageBox.Show("Xóa phòng ban thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phòng ban thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_phongban.DataSource = bus_PhongBan.LoadDSPB();
        }

        private void cbo_phuongthuc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_phuongthuc.Text == "Tên Phòng Ban")
                {
                    cbo_timtenpb.Visible = true;
                    txt_giatri.Visible = false;
                }
                else
                {
                    cbo_timtenpb.Visible = false;
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
                    case "Mã Phòng Ban":
                        dgv_phongban.DataSource = bus_PhongBan.TimPBTheoMa(int.Parse(txt_giatri.Text));
                        break;
                    case "Tên Phòng Ban":
                        dgv_phongban.DataSource = bus_PhongBan.TimPBTheoTen(cbo_timtenpb.Text);
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
