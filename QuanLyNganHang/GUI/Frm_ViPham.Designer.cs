namespace GUI
{
    partial class Frm_ViPham
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
            this.dtp_ngayvp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hinhthucxl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_vipham = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.gb_ThongTin = new System.Windows.Forms.GroupBox();
            this.cbo_trangthai = new System.Windows.Forms.ComboBox();
            this.cbo_makh = new System.Windows.Forms.ComboBox();
            this.cbo_manv = new System.Windows.Forms.ComboBox();
            this.cbo_manq = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mavp = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.cbo_motavp = new System.Windows.Forms.ComboBox();
            this.cbo_timnq = new System.Windows.Forms.ComboBox();
            this.gb_Timkiem.SuspendLayout();
            this.gb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vipham)).BeginInit();
            this.gb_ChucNang.SuspendLayout();
            this.gb_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.cbo_phuongthuc);
            this.gb_Timkiem.Controls.Add(this.cbo_timnq);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Controls.Add(this.txt_giatri);
            this.gb_Timkiem.Location = new System.Drawing.Point(27, 69);
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
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
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
            this.cbo_phuongthuc.Items.AddRange(new object[] {
            "Mã Vi Phạm",
            "Mã Nội Quy",
            "Mã Nhân Viên",
            "Mã Khách Hàng",
            "Mô Tả Vi Phạm"});
            this.cbo_phuongthuc.Location = new System.Drawing.Point(172, 34);
            this.cbo_phuongthuc.Name = "cbo_phuongthuc";
            this.cbo_phuongthuc.Size = new System.Drawing.Size(315, 24);
            this.cbo_phuongthuc.TabIndex = 17;
            this.cbo_phuongthuc.TextChanged += new System.EventHandler(this.cbo_phuongthuc_TextChanged);
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
            this.label2.Location = new System.Drawing.Point(46, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nội Quy";
            // 
            // dtp_ngayvp
            // 
            this.dtp_ngayvp.Location = new System.Drawing.Point(174, 255);
            this.dtp_ngayvp.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_ngayvp.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_ngayvp.Name = "dtp_ngayvp";
            this.dtp_ngayvp.Size = new System.Drawing.Size(297, 22);
            this.dtp_ngayvp.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Vi Phạm";
            // 
            // txt_hinhthucxl
            // 
            this.txt_hinhthucxl.Location = new System.Drawing.Point(175, 367);
            this.txt_hinhthucxl.Name = "txt_hinhthucxl";
            this.txt_hinhthucxl.Size = new System.Drawing.Size(297, 22);
            this.txt_hinhthucxl.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Vi Phạm";
            // 
            // gb_DanhSach
            // 
            this.gb_DanhSach.Controls.Add(this.dgv_vipham);
            this.gb_DanhSach.Location = new System.Drawing.Point(27, 162);
            this.gb_DanhSach.Name = "gb_DanhSach";
            this.gb_DanhSach.Size = new System.Drawing.Size(716, 337);
            this.gb_DanhSach.TabIndex = 43;
            this.gb_DanhSach.TabStop = false;
            this.gb_DanhSach.Text = "Danh Sách";
            // 
            // dgv_vipham
            // 
            this.dgv_vipham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vipham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_vipham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vipham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vipham.Location = new System.Drawing.Point(3, 18);
            this.dgv_vipham.Name = "dgv_vipham";
            this.dgv_vipham.RowHeadersWidth = 51;
            this.dgv_vipham.Size = new System.Drawing.Size(710, 316);
            this.dgv_vipham.TabIndex = 11;
            this.dgv_vipham.Click += new System.EventHandler(this.dgv_vipham_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mô Tả Vi Phạm";
            // 
            // gb_ChucNang
            // 
            this.gb_ChucNang.Controls.Add(this.btn_Them);
            this.gb_ChucNang.Controls.Add(this.btn_Lammoi);
            this.gb_ChucNang.Controls.Add(this.btn_Sua);
            this.gb_ChucNang.Controls.Add(this.btn_Xoa);
            this.gb_ChucNang.Location = new System.Drawing.Point(1086, 90);
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
            this.gb_ThongTin.Controls.Add(this.cbo_motavp);
            this.gb_ThongTin.Controls.Add(this.cbo_trangthai);
            this.gb_ThongTin.Controls.Add(this.cbo_makh);
            this.gb_ThongTin.Controls.Add(this.cbo_manv);
            this.gb_ThongTin.Controls.Add(this.cbo_manq);
            this.gb_ThongTin.Controls.Add(this.label1);
            this.gb_ThongTin.Controls.Add(this.label2);
            this.gb_ThongTin.Controls.Add(this.dtp_ngayvp);
            this.gb_ThongTin.Controls.Add(this.label3);
            this.gb_ThongTin.Controls.Add(this.label4);
            this.gb_ThongTin.Controls.Add(this.label5);
            this.gb_ThongTin.Controls.Add(this.txt_hinhthucxl);
            this.gb_ThongTin.Controls.Add(this.label6);
            this.gb_ThongTin.Controls.Add(this.label7);
            this.gb_ThongTin.Controls.Add(this.label8);
            this.gb_ThongTin.Controls.Add(this.txt_mavp);
            this.gb_ThongTin.Location = new System.Drawing.Point(1086, 175);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Size = new System.Drawing.Size(489, 579);
            this.gb_ThongTin.TabIndex = 45;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Thông Tin Vi Phạm";
            // 
            // cbo_trangthai
            // 
            this.cbo_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trangthai.FormattingEnabled = true;
            this.cbo_trangthai.Items.AddRange(new object[] {
            "ĐÃ XỬ LÝ",
            "CHƯA XỬ LÝ"});
            this.cbo_trangthai.Location = new System.Drawing.Point(175, 423);
            this.cbo_trangthai.Name = "cbo_trangthai";
            this.cbo_trangthai.Size = new System.Drawing.Size(298, 24);
            this.cbo_trangthai.TabIndex = 31;
            // 
            // cbo_makh
            // 
            this.cbo_makh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_makh.FormattingEnabled = true;
            this.cbo_makh.Location = new System.Drawing.Point(174, 203);
            this.cbo_makh.Name = "cbo_makh";
            this.cbo_makh.Size = new System.Drawing.Size(298, 24);
            this.cbo_makh.TabIndex = 30;
            // 
            // cbo_manv
            // 
            this.cbo_manv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_manv.FormattingEnabled = true;
            this.cbo_manv.Location = new System.Drawing.Point(175, 146);
            this.cbo_manv.Name = "cbo_manv";
            this.cbo_manv.Size = new System.Drawing.Size(296, 24);
            this.cbo_manv.TabIndex = 29;
            // 
            // cbo_manq
            // 
            this.cbo_manq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_manq.FormattingEnabled = true;
            this.cbo_manq.Location = new System.Drawing.Point(174, 87);
            this.cbo_manq.Name = "cbo_manq";
            this.cbo_manq.Size = new System.Drawing.Size(298, 24);
            this.cbo_manq.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hình Thức Xử Lý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Trạng Thái Xử Lý";
            // 
            // txt_mavp
            // 
            this.txt_mavp.Location = new System.Drawing.Point(174, 37);
            this.txt_mavp.Name = "txt_mavp";
            this.txt_mavp.Size = new System.Drawing.Size(297, 22);
            this.txt_mavp.TabIndex = 19;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(816, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(388, 53);
            this.lbl_title.TabIndex = 42;
            this.lbl_title.Text = "Quản Lý Vi Phạm";
            // 
            // cbo_motavp
            // 
            this.cbo_motavp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_motavp.FormattingEnabled = true;
            this.cbo_motavp.Location = new System.Drawing.Point(174, 317);
            this.cbo_motavp.Name = "cbo_motavp";
            this.cbo_motavp.Size = new System.Drawing.Size(298, 24);
            this.cbo_motavp.TabIndex = 32;
            // 
            // cbo_timnq
            // 
            this.cbo_timnq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_timnq.FormattingEnabled = true;
            this.cbo_timnq.Location = new System.Drawing.Point(568, 33);
            this.cbo_timnq.Name = "cbo_timnq";
            this.cbo_timnq.Size = new System.Drawing.Size(315, 24);
            this.cbo_timnq.TabIndex = 20;
            // 
            // Frm_ViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 766);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.gb_DanhSach);
            this.Controls.Add(this.gb_ChucNang);
            this.Controls.Add(this.gb_ThongTin);
            this.Controls.Add(this.lbl_title);
            this.Name = "Frm_ViPham";
            this.Text = "Frm_ViPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ViPham_Load);
            this.Resize += new System.EventHandler(this.Frm_ViPham_Resize);
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.gb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vipham)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtp_ngayvp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hinhthucxl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_DanhSach;
        private System.Windows.Forms.DataGridView dgv_vipham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gb_ChucNang;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox gb_ThongTin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mavp;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cbo_makh;
        private System.Windows.Forms.ComboBox cbo_manv;
        private System.Windows.Forms.ComboBox cbo_manq;
        private System.Windows.Forms.ComboBox cbo_trangthai;
        private System.Windows.Forms.ComboBox cbo_motavp;
        private System.Windows.Forms.ComboBox cbo_timnq;
    }
}