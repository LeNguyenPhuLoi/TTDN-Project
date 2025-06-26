namespace GUI
{
    partial class Frm_BienLai
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
            this.gb_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.gb_ThongTin = new System.Windows.Forms.GroupBox();
            this.cbo_SoTien = new System.Windows.Forms.ComboBox();
            this.rtxt_MoTa = new System.Windows.Forms.RichTextBox();
            this.cbo_TrangThai = new System.Windows.Forms.ComboBox();
            this.cbo_TenLoaiTien = new System.Windows.Forms.ComboBox();
            this.cbo_TenNV = new System.Windows.Forms.ComboBox();
            this.cbo_SoTK = new System.Windows.Forms.ComboBox();
            this.cbo_MaGD = new System.Windows.Forms.ComboBox();
            this.cbo_TenKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LoaiBL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MaBL = new System.Windows.Forms.TextBox();
            this.gb_Timkiem = new System.Windows.Forms.GroupBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_PhuongThuc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_GiaTri = new System.Windows.Forms.TextBox();
            this.gb_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_BienLai = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_ChucNang.SuspendLayout();
            this.gb_ThongTin.SuspendLayout();
            this.gb_Timkiem.SuspendLayout();
            this.gb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BienLai)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ChucNang
            // 
            this.gb_ChucNang.Controls.Add(this.btn_Them);
            this.gb_ChucNang.Controls.Add(this.btn_Lammoi);
            this.gb_ChucNang.Controls.Add(this.btn_Sua);
            this.gb_ChucNang.Controls.Add(this.btn_Xoa);
            this.gb_ChucNang.Location = new System.Drawing.Point(1068, 86);
            this.gb_ChucNang.Name = "gb_ChucNang";
            this.gb_ChucNang.Size = new System.Drawing.Size(431, 79);
            this.gb_ChucNang.TabIndex = 41;
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
            this.gb_ThongTin.Controls.Add(this.cbo_SoTien);
            this.gb_ThongTin.Controls.Add(this.rtxt_MoTa);
            this.gb_ThongTin.Controls.Add(this.cbo_TrangThai);
            this.gb_ThongTin.Controls.Add(this.cbo_TenLoaiTien);
            this.gb_ThongTin.Controls.Add(this.cbo_TenNV);
            this.gb_ThongTin.Controls.Add(this.cbo_SoTK);
            this.gb_ThongTin.Controls.Add(this.cbo_MaGD);
            this.gb_ThongTin.Controls.Add(this.cbo_TenKH);
            this.gb_ThongTin.Controls.Add(this.label1);
            this.gb_ThongTin.Controls.Add(this.label2);
            this.gb_ThongTin.Controls.Add(this.label3);
            this.gb_ThongTin.Controls.Add(this.label4);
            this.gb_ThongTin.Controls.Add(this.txt_LoaiBL);
            this.gb_ThongTin.Controls.Add(this.label5);
            this.gb_ThongTin.Controls.Add(this.label6);
            this.gb_ThongTin.Controls.Add(this.label7);
            this.gb_ThongTin.Controls.Add(this.label8);
            this.gb_ThongTin.Controls.Add(this.label9);
            this.gb_ThongTin.Controls.Add(this.label10);
            this.gb_ThongTin.Controls.Add(this.txt_MaBL);
            this.gb_ThongTin.Location = new System.Drawing.Point(1068, 171);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Size = new System.Drawing.Size(489, 678);
            this.gb_ThongTin.TabIndex = 40;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Thông Tin Biên Lai";
            // 
            // cbo_SoTien
            // 
            this.cbo_SoTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SoTien.FormattingEnabled = true;
            this.cbo_SoTien.Location = new System.Drawing.Point(174, 311);
            this.cbo_SoTien.Name = "cbo_SoTien";
            this.cbo_SoTien.Size = new System.Drawing.Size(297, 31);
            this.cbo_SoTien.TabIndex = 43;
            // 
            // rtxt_MoTa
            // 
            this.rtxt_MoTa.Location = new System.Drawing.Point(175, 475);
            this.rtxt_MoTa.Name = "rtxt_MoTa";
            this.rtxt_MoTa.Size = new System.Drawing.Size(297, 129);
            this.rtxt_MoTa.TabIndex = 42;
            this.rtxt_MoTa.Text = "";
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrangThai.FormattingEnabled = true;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Chưa in",
            "Đã in"});
            this.cbo_TrangThai.Location = new System.Drawing.Point(174, 628);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Size = new System.Drawing.Size(297, 31);
            this.cbo_TrangThai.TabIndex = 33;
            // 
            // cbo_TenLoaiTien
            // 
            this.cbo_TenLoaiTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenLoaiTien.FormattingEnabled = true;
            this.cbo_TenLoaiTien.Location = new System.Drawing.Point(175, 367);
            this.cbo_TenLoaiTien.Name = "cbo_TenLoaiTien";
            this.cbo_TenLoaiTien.Size = new System.Drawing.Size(297, 31);
            this.cbo_TenLoaiTien.TabIndex = 32;
            // 
            // cbo_TenNV
            // 
            this.cbo_TenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenNV.FormattingEnabled = true;
            this.cbo_TenNV.Location = new System.Drawing.Point(174, 257);
            this.cbo_TenNV.Name = "cbo_TenNV";
            this.cbo_TenNV.Size = new System.Drawing.Size(297, 31);
            this.cbo_TenNV.TabIndex = 31;
            // 
            // cbo_SoTK
            // 
            this.cbo_SoTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SoTK.FormattingEnabled = true;
            this.cbo_SoTK.Location = new System.Drawing.Point(175, 200);
            this.cbo_SoTK.Name = "cbo_SoTK";
            this.cbo_SoTK.Size = new System.Drawing.Size(297, 31);
            this.cbo_SoTK.TabIndex = 30;
            this.cbo_SoTK.SelectedIndexChanged += new System.EventHandler(this.cbo_SoTK_SelectedIndexChanged);
            // 
            // cbo_MaGD
            // 
            this.cbo_MaGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaGD.FormattingEnabled = true;
            this.cbo_MaGD.Location = new System.Drawing.Point(175, 87);
            this.cbo_MaGD.Name = "cbo_MaGD";
            this.cbo_MaGD.Size = new System.Drawing.Size(297, 31);
            this.cbo_MaGD.TabIndex = 29;
            this.cbo_MaGD.SelectedIndexChanged += new System.EventHandler(this.cbo_MaGD_SelectedIndexChanged);
            // 
            // cbo_TenKH
            // 
            this.cbo_TenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenKH.FormattingEnabled = true;
            this.cbo_TenKH.Location = new System.Drawing.Point(175, 143);
            this.cbo_TenKH.Name = "cbo_TenKH";
            this.cbo_TenKH.Size = new System.Drawing.Size(297, 31);
            this.cbo_TenKH.TabIndex = 28;
            this.cbo_TenKH.SelectedIndexChanged += new System.EventHandler(this.cbo_TenKH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Biên Lai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Giao Dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Tài Khoản ";
            // 
            // txt_LoaiBL
            // 
            this.txt_LoaiBL.Location = new System.Drawing.Point(175, 420);
            this.txt_LoaiBL.Name = "txt_LoaiBL";
            this.txt_LoaiBL.Size = new System.Drawing.Size(297, 32);
            this.txt_LoaiBL.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Tiền ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên Loại Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Loại Biên Lai";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mô Tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 631);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Trạng Thái";
            // 
            // txt_MaBL
            // 
            this.txt_MaBL.Location = new System.Drawing.Point(174, 37);
            this.txt_MaBL.Name = "txt_MaBL";
            this.txt_MaBL.Size = new System.Drawing.Size(297, 32);
            this.txt_MaBL.TabIndex = 19;
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.cbo_PhuongThuc);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Controls.Add(this.txt_GiaTri);
            this.gb_Timkiem.Location = new System.Drawing.Point(9, 54);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Size = new System.Drawing.Size(984, 84);
            this.gb_Timkiem.TabIndex = 39;
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
            this.gb_DanhSach.Controls.Add(this.dgv_BienLai);
            this.gb_DanhSach.Location = new System.Drawing.Point(9, 158);
            this.gb_DanhSach.Name = "gb_DanhSach";
            this.gb_DanhSach.Size = new System.Drawing.Size(716, 337);
            this.gb_DanhSach.TabIndex = 38;
            this.gb_DanhSach.TabStop = false;
            this.gb_DanhSach.Text = "Danh Sách";
            // 
            // dgv_BienLai
            // 
            this.dgv_BienLai.AllowUserToAddRows = false;
            this.dgv_BienLai.AllowUserToDeleteRows = false;
            this.dgv_BienLai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BienLai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_BienLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BienLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BienLai.Location = new System.Drawing.Point(3, 28);
            this.dgv_BienLai.MultiSelect = false;
            this.dgv_BienLai.Name = "dgv_BienLai";
            this.dgv_BienLai.ReadOnly = true;
            this.dgv_BienLai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BienLai.Size = new System.Drawing.Size(710, 306);
            this.dgv_BienLai.TabIndex = 11;
            this.dgv_BienLai.Click += new System.EventHandler(this.dgv_BienLai_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(798, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(308, 42);
            this.lbl_title.TabIndex = 37;
            this.lbl_title.Text = "Quản Trị Biên Lai";
            // 
            // Frm_BienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.gb_ChucNang);
            this.Controls.Add(this.gb_ThongTin);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.gb_DanhSach);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_BienLai";
            this.Text = "Quản Trị Biên Lai";
            this.Load += new System.EventHandler(this.Frm_BienLai_Load);
            this.Resize += new System.EventHandler(this.Frm_BienLai_Resize);
            this.gb_ChucNang.ResumeLayout(false);
            this.gb_ThongTin.ResumeLayout(false);
            this.gb_ThongTin.PerformLayout();
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.gb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BienLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txt_LoaiBL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MaBL;
        private System.Windows.Forms.GroupBox gb_Timkiem;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_PhuongThuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_GiaTri;
        private System.Windows.Forms.GroupBox gb_DanhSach;
        private System.Windows.Forms.DataGridView dgv_BienLai;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cbo_TenNV;
        private System.Windows.Forms.ComboBox cbo_SoTK;
        private System.Windows.Forms.ComboBox cbo_MaGD;
        private System.Windows.Forms.ComboBox cbo_TenKH;
        private System.Windows.Forms.RichTextBox rtxt_MoTa;
        private System.Windows.Forms.ComboBox cbo_TrangThai;
        private System.Windows.Forms.ComboBox cbo_TenLoaiTien;
        private System.Windows.Forms.ComboBox cbo_SoTien;
    }
}
