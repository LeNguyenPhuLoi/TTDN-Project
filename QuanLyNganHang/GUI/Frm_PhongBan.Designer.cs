namespace GUI
{
    partial class Frm_PhongBan
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
            this.cbo_phuongthuc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_giatri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_phongban = new System.Windows.Forms.DataGridView();
            this.gb_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.gb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_tenpb = new System.Windows.Forms.TextBox();
            this.txt_mapb = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_Timkiem.SuspendLayout();
            this.gb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phongban)).BeginInit();
            this.gb_ChucNang.SuspendLayout();
            this.gb_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.cbo_phuongthuc);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Controls.Add(this.txt_giatri);
            this.gb_Timkiem.Location = new System.Drawing.Point(16, 65);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Size = new System.Drawing.Size(984, 84);
            this.gb_Timkiem.TabIndex = 44;
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
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phương Thức Tìm";
            // 
            // cbo_phuongthuc
            // 
            this.cbo_phuongthuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phuongthuc.FormattingEnabled = true;
            this.cbo_phuongthuc.Location = new System.Drawing.Point(172, 34);
            this.cbo_phuongthuc.Name = "cbo_phuongthuc";
            this.cbo_phuongthuc.Size = new System.Drawing.Size(315, 24);
            this.cbo_phuongthuc.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(493, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá Trị";
            // 
            // txt_giatri
            // 
            this.txt_giatri.Location = new System.Drawing.Point(568, 33);
            this.txt_giatri.Name = "txt_giatri";
            this.txt_giatri.Size = new System.Drawing.Size(315, 22);
            this.txt_giatri.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phòng Ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phòng Ban";
            // 
            // gb_DanhSach
            // 
            this.gb_DanhSach.Controls.Add(this.dgv_phongban);
            this.gb_DanhSach.Location = new System.Drawing.Point(16, 158);
            this.gb_DanhSach.Name = "gb_DanhSach";
            this.gb_DanhSach.Size = new System.Drawing.Size(716, 337);
            this.gb_DanhSach.TabIndex = 43;
            this.gb_DanhSach.TabStop = false;
            this.gb_DanhSach.Text = "Danh Sách";
            // 
            // dgv_phongban
            // 
            this.dgv_phongban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phongban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_phongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phongban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phongban.Location = new System.Drawing.Point(3, 18);
            this.dgv_phongban.Name = "dgv_phongban";
            this.dgv_phongban.RowHeadersWidth = 51;
            this.dgv_phongban.Size = new System.Drawing.Size(710, 316);
            this.dgv_phongban.TabIndex = 11;
            this.dgv_phongban.Click += new System.EventHandler(this.dgv_phongban_Click);
            // 
            // gb_ChucNang
            // 
            this.gb_ChucNang.Controls.Add(this.btn_Them);
            this.gb_ChucNang.Controls.Add(this.btn_Lammoi);
            this.gb_ChucNang.Controls.Add(this.btn_Sua);
            this.gb_ChucNang.Controls.Add(this.btn_Xoa);
            this.gb_ChucNang.Location = new System.Drawing.Point(1075, 86);
            this.gb_ChucNang.Name = "gb_ChucNang";
            this.gb_ChucNang.Size = new System.Drawing.Size(431, 79);
            this.gb_ChucNang.TabIndex = 46;
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
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Location = new System.Drawing.Point(318, 31);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(97, 37);
            this.btn_Lammoi.TabIndex = 35;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = true;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(118, 31);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 37);
            this.btn_Sua.TabIndex = 33;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(216, 31);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 37);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // gb_ThongTin
            // 
            this.gb_ThongTin.Controls.Add(this.label1);
            this.gb_ThongTin.Controls.Add(this.label2);
            this.gb_ThongTin.Controls.Add(this.txt_tenpb);
            this.gb_ThongTin.Controls.Add(this.txt_mapb);
            this.gb_ThongTin.Location = new System.Drawing.Point(1075, 171);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Size = new System.Drawing.Size(489, 135);
            this.gb_ThongTin.TabIndex = 45;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Thông Tin Phòng Ban";
            // 
            // txt_tenpb
            // 
            this.txt_tenpb.Location = new System.Drawing.Point(175, 87);
            this.txt_tenpb.Name = "txt_tenpb";
            this.txt_tenpb.Size = new System.Drawing.Size(297, 22);
            this.txt_tenpb.TabIndex = 20;
            // 
            // txt_mapb
            // 
            this.txt_mapb.Location = new System.Drawing.Point(174, 37);
            this.txt_mapb.Name = "txt_mapb";
            this.txt_mapb.Size = new System.Drawing.Size(297, 22);
            this.txt_mapb.TabIndex = 19;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(805, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(436, 53);
            this.lbl_title.TabIndex = 42;
            this.lbl_title.Text = "Quản Lý Phòng Ban";
            // 
            // Frm_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 511);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.gb_DanhSach);
            this.Controls.Add(this.gb_ChucNang);
            this.Controls.Add(this.gb_ThongTin);
            this.Controls.Add(this.lbl_title);
            this.Name = "Frm_PhongBan";
            this.Text = "Frm_PhongBan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_PhongBan_Load);
            this.Resize += new System.EventHandler(this.Frm_PhongBan_Resize);
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.gb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phongban)).EndInit();
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
        private System.Windows.Forms.ComboBox cbo_phuongthuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_giatri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_DanhSach;
        private System.Windows.Forms.DataGridView dgv_phongban;
        private System.Windows.Forms.GroupBox gb_ChucNang;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox gb_ThongTin;
        private System.Windows.Forms.TextBox txt_tenpb;
        private System.Windows.Forms.TextBox txt_mapb;
        private System.Windows.Forms.Label lbl_title;
    }
}