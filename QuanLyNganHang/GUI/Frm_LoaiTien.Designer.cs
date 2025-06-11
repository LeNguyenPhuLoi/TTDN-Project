namespace GUI
{
    partial class Frm_LoaiTien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Timkiem = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_PhuongThuc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_GiaTri = new System.Windows.Forms.TextBox();
            this.gb_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_LoaiTien = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.gb_ThongTin = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb_Timkiem.SuspendLayout();
            this.gb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTien)).BeginInit();
            this.gb_ChucNang.SuspendLayout();
            this.gb_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.cbo_PhuongThuc);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Controls.Add(this.txt_GiaTri);
            this.gb_Timkiem.Location = new System.Drawing.Point(12, 52);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Size = new System.Drawing.Size(984, 84);
            this.gb_Timkiem.TabIndex = 21;
            this.gb_Timkiem.TabStop = false;
            this.gb_Timkiem.Text = "Tìm Kiếm";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(889, 32);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 32);
            this.btn_Tim.TabIndex = 19;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phương Thức Tìm";
            // 
            // cbo_PhuongThuc
            // 
            this.cbo_PhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PhuongThuc.FormattingEnabled = true;
            this.cbo_PhuongThuc.Location = new System.Drawing.Point(172, 34);
            this.cbo_PhuongThuc.Name = "cbo_PhuongThuc";
            this.cbo_PhuongThuc.Size = new System.Drawing.Size(315, 31);
            this.cbo_PhuongThuc.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(493, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá Trị";
            // 
            // txt_GiaTri
            // 
            this.txt_GiaTri.Location = new System.Drawing.Point(568, 33);
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Size = new System.Drawing.Size(315, 32);
            this.txt_GiaTri.TabIndex = 16;
            // 
            // gb_DanhSach
            // 
            this.gb_DanhSach.Controls.Add(this.dgv_LoaiTien);
            this.gb_DanhSach.Location = new System.Drawing.Point(12, 156);
            this.gb_DanhSach.Name = "gb_DanhSach";
            this.gb_DanhSach.Size = new System.Drawing.Size(716, 337);
            this.gb_DanhSach.TabIndex = 20;
            this.gb_DanhSach.TabStop = false;
            this.gb_DanhSach.Text = "Danh Sách";
            // 
            // dgv_LoaiTien
            // 
            this.dgv_LoaiTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiTien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_LoaiTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LoaiTien.Location = new System.Drawing.Point(3, 28);
            this.dgv_LoaiTien.Name = "dgv_LoaiTien";
            this.dgv_LoaiTien.Size = new System.Drawing.Size(710, 306);
            this.dgv_LoaiTien.TabIndex = 11;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(801, 7);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(324, 42);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "Quản Trị Loại Tiền";
            // 
            // gb_ChucNang
            // 
            this.gb_ChucNang.Controls.Add(this.btn_Them);
            this.gb_ChucNang.Controls.Add(this.btn_Lammoi);
            this.gb_ChucNang.Controls.Add(this.btn_Sua);
            this.gb_ChucNang.Controls.Add(this.btn_Xoa);
            this.gb_ChucNang.Location = new System.Drawing.Point(1080, 84);
            this.gb_ChucNang.Name = "gb_ChucNang";
            this.gb_ChucNang.Size = new System.Drawing.Size(431, 79);
            this.gb_ChucNang.TabIndex = 38;
            this.gb_ChucNang.TabStop = false;
            this.gb_ChucNang.Text = "Chức Năng";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(17, 31);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 37);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Location = new System.Drawing.Point(318, 31);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(97, 37);
            this.btn_Lammoi.TabIndex = 35;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(118, 31);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 37);
            this.btn_Sua.TabIndex = 33;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(216, 31);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 37);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // gb_ThongTin
            // 
            this.gb_ThongTin.Controls.Add(this.comboBox1);
            this.gb_ThongTin.Controls.Add(this.textBox5);
            this.gb_ThongTin.Controls.Add(this.label1);
            this.gb_ThongTin.Controls.Add(this.label2);
            this.gb_ThongTin.Controls.Add(this.label3);
            this.gb_ThongTin.Controls.Add(this.label4);
            this.gb_ThongTin.Controls.Add(this.label5);
            this.gb_ThongTin.Controls.Add(this.textBox3);
            this.gb_ThongTin.Controls.Add(this.textBox2);
            this.gb_ThongTin.Controls.Add(this.textBox1);
            this.gb_ThongTin.Location = new System.Drawing.Point(1080, 169);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Size = new System.Drawing.Size(489, 303);
            this.gb_ThongTin.TabIndex = 37;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Thông Tin Loại Tiền";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 31);
            this.comboBox1.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(331, 32);
            this.textBox5.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Loại Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ký Hiệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quốc Gia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trạng Thái";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(331, 32);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 32);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 32);
            this.textBox1.TabIndex = 19;
            // 
            // Frm_LoaiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.gb_ChucNang);
            this.Controls.Add(this.gb_ThongTin);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.gb_DanhSach);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_LoaiTien";
            this.Text = "Quản Trị Loại Tiền";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_LoaiTien_Load);
            this.Resize += new System.EventHandler(this.Frm_LoaiTien_Resize);
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.gb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTien)).EndInit();
            this.gb_ChucNang.ResumeLayout(false);
            this.gb_ThongTin.ResumeLayout(false);
            this.gb_ThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Timkiem;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_PhuongThuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_GiaTri;
        private System.Windows.Forms.GroupBox gb_DanhSach;
        private System.Windows.Forms.DataGridView dgv_LoaiTien;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gb_ChucNang;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox gb_ThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
