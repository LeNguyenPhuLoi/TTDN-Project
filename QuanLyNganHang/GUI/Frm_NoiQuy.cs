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
    public partial class Frm_NoiQuy : Form
    {
        public Frm_NoiQuy()
        {
            InitializeComponent();
        }

        BUS_NoiQuy bus_NoiQuy = new BUS_NoiQuy();

        private void Frm_NoiQuy_Load(object sender, EventArgs e)
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
            dgv_noiquy.DataSource = bus_NoiQuy.LoadDSNQ();
        }

        private void Frm_NoiQuy_Resize(object sender, EventArgs e)
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
            txt_manq.Clear();
            txt_tieude.Clear();
            txt_mota.Clear();
            dtp_ngaybanhanh.Text = dtp_ngaybanhanh.MaxDate.ToString();
            txt_loaiapdung.Clear();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgv_noiquy_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgv_noiquy.CurrentCell.RowIndex;
                txt_manq.Text = dgv_noiquy.Rows[dong].Cells[0].Value.ToString();
                txt_tieude.Text = dgv_noiquy.Rows[dong].Cells[1].Value.ToString();
                txt_mota.Text = dgv_noiquy.Rows[dong].Cells[2].Value.ToString();
                dtp_ngaybanhanh.Text = dgv_noiquy.Rows[dong].Cells[3].Value.ToString();
                txt_loaiapdung.Text = dgv_noiquy.Rows[dong].Cells[4].Value.ToString();
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
                ET_NoiQuy nq = new ET_NoiQuy(txt_manq.Text,
                                                txt_tieude.Text,
                                                txt_mota.Text,
                                                dtp_ngaybanhanh.Value,
                                                txt_loaiapdung.Text);
                if (bus_NoiQuy.ThemNQ(nq) == true)
                {
                    MessageBox.Show("Thêm nội quy thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm nội quy thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_noiquy.DataSource = bus_NoiQuy.LoadDSNQ();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ET_NoiQuy nq = new ET_NoiQuy(txt_manq.Text,
                                                txt_tieude.Text,
                                                txt_mota.Text,
                                                dtp_ngaybanhanh.Value,
                                                txt_loaiapdung.Text);
                if (bus_NoiQuy.SuaNQ(nq) == true)
                {
                    MessageBox.Show("Sửa nội quy thành công!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Sửa nội quy thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_noiquy.DataSource = bus_NoiQuy.LoadDSNQ();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    ET_NoiQuy nq = new ET_NoiQuy(txt_manq.Text,
                                                txt_tieude.Text,
                                                txt_mota.Text,
                                                dtp_ngaybanhanh.Value,
                                                txt_loaiapdung.Text);
                    if (bus_NoiQuy.XoaNQ(nq) == true)
                    {
                        MessageBox.Show("Xóa nội quy thành công!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nội quy thất bại!");
                    }
                }                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            dgv_noiquy.DataSource = bus_NoiQuy.LoadDSNQ();
        }
    }
}
