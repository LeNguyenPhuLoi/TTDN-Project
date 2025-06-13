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
            int width = this.Width;
            int height = this.Height;
            lbl_title.Location = new Point((width / 2) - 170, 0);
            gb_Timkiem.Location = new Point(10, 50);
            gb_DanhSach.Location = new Point(10, 150);
            gb_DanhSach.Height = height - 200;
            gb_DanhSach.Width = (width / 3) * 2;
            gb_ThongTin.Location = new Point(width - 510, 150);
            gb_ChucNang.Location = new Point(width - 510, 50);
            dgv_phongban.DataSource = bus_PhongBan.LoadDSPB();
        }

        private void Frm_PhongBan_Resize(object sender, EventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            lbl_title.Location = new Point((width / 2) - 170, 0);
            gb_Timkiem.Location = new Point(10, 50);
            gb_DanhSach.Location = new Point(10, 150);
            gb_DanhSach.Height = height - 200;
            gb_DanhSach.Width = (width / 3) * 2;
            gb_ThongTin.Location = new Point(width - 510, 150);
            gb_ChucNang.Location = new Point(width - 510, 50);
        }

        public void Clear()
        {
            txt_mapb.Clear();
            txt_tenpb.Clear();
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
    }
}
