namespace GUI
{
    partial class Frm_NhanVien
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
            this.cbo_macn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_mapb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_chuc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.gb_Timkiem = new System.Windows.Forms.GroupBox();
            this.cbo_timcn = new System.Windows.Forms.ComboBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_phuongthuc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_giatri = new System.Windows.Forms.TextBox();
            this.gb_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gb_ChucNang.SuspendLayout();
            this.gb_ThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_Timkiem.SuspendLayout();
            this.gb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ChucNang
            // 
            this.gb_ChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_ChucNang.BackColor = System.Drawing.Color.White;
            this.gb_ChucNang.Controls.Add(this.btn_Them);
            this.gb_ChucNang.Controls.Add(this.btn_Lammoi);
            this.gb_ChucNang.Controls.Add(this.btn_Sua);
            this.gb_ChucNang.Controls.Add(this.btn_Xoa);
            this.gb_ChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ChucNang.Location = new System.Drawing.Point(1037, 70);
            this.gb_ChucNang.Name = "gb_ChucNang";
            this.gb_ChucNang.Size = new System.Drawing.Size(489, 79);
            this.gb_ChucNang.TabIndex = 41;
            this.gb_ChucNang.TabStop = false;
            this.gb_ChucNang.Text = "Chức Năng";
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.BackColor = System.Drawing.Color.Bisque;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(17, 31);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 37);
            this.btn_Them.TabIndex = 32;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Lammoi.BackColor = System.Drawing.Color.Bisque;
            this.btn_Lammoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Lammoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_Lammoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.Location = new System.Drawing.Point(318, 31);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(110, 37);
            this.btn_Lammoi.TabIndex = 35;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.BackColor = System.Drawing.Color.Bisque;
            this.btn_Sua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(118, 31);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 37);
            this.btn_Sua.TabIndex = 33;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.BackColor = System.Drawing.Color.Bisque;
            this.btn_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(216, 31);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 37);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // gb_ThongTin
            // 
            this.gb_ThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_ThongTin.BackColor = System.Drawing.Color.White;
            this.gb_ThongTin.Controls.Add(this.cbo_macn);
            this.gb_ThongTin.Controls.Add(this.label1);
            this.gb_ThongTin.Controls.Add(this.panel1);
            this.gb_ThongTin.Controls.Add(this.label2);
            this.gb_ThongTin.Controls.Add(this.dtp_ngaysinh);
            this.gb_ThongTin.Controls.Add(this.label3);
            this.gb_ThongTin.Controls.Add(this.cbo_mapb);
            this.gb_ThongTin.Controls.Add(this.label4);
            this.gb_ThongTin.Controls.Add(this.txt_sdt);
            this.gb_ThongTin.Controls.Add(this.label5);
            this.gb_ThongTin.Controls.Add(this.txt_diachi);
            this.gb_ThongTin.Controls.Add(this.label6);
            this.gb_ThongTin.Controls.Add(this.txt_luong);
            this.gb_ThongTin.Controls.Add(this.label7);
            this.gb_ThongTin.Controls.Add(this.txt_chuc);
            this.gb_ThongTin.Controls.Add(this.label8);
            this.gb_ThongTin.Controls.Add(this.label9);
            this.gb_ThongTin.Controls.Add(this.txt_tennv);
            this.gb_ThongTin.Controls.Add(this.label10);
            this.gb_ThongTin.Controls.Add(this.txt_manv);
            this.gb_ThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ThongTin.Location = new System.Drawing.Point(1037, 154);
            this.gb_ThongTin.Name = "gb_ThongTin";
            this.gb_ThongTin.Size = new System.Drawing.Size(489, 582);
            this.gb_ThongTin.TabIndex = 40;
            this.gb_ThongTin.TabStop = false;
            this.gb_ThongTin.Text = "Thông Tin Nhân Viên";
            // 
            // cbo_macn
            // 
            this.cbo_macn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_macn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_macn.FormattingEnabled = true;
            this.cbo_macn.Location = new System.Drawing.Point(174, 531);
            this.cbo_macn.Name = "cbo_macn";
            this.cbo_macn.Size = new System.Drawing.Size(297, 33);
            this.cbo_macn.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rdb_nam);
            this.panel1.Controls.Add(this.rdb_nu);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(175, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 32);
            this.panel1.TabIndex = 30;
            // 
            // rdb_nam
            // 
            this.rdb_nam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Checked = true;
            this.rdb_nam.Location = new System.Drawing.Point(51, 1);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(81, 29);
            this.rdb_nam.TabIndex = 28;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "NAM";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // rdb_nu
            // 
            this.rdb_nu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Location = new System.Drawing.Point(190, 1);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(63, 29);
            this.rdb_nu.TabIndex = 29;
            this.rdb_nu.Text = "NỮ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaysinh.Location = new System.Drawing.Point(174, 203);
            this.dtp_ngaysinh.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaysinh.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(297, 30);
            this.dtp_ngaysinh.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới Tính";
            // 
            // cbo_mapb
            // 
            this.cbo_mapb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_mapb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_mapb.FormattingEnabled = true;
            this.cbo_mapb.Location = new System.Drawing.Point(175, 475);
            this.cbo_mapb.Name = "cbo_mapb";
            this.cbo_mapb.Size = new System.Drawing.Size(297, 33);
            this.cbo_mapb.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Sinh";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sdt.Location = new System.Drawing.Point(175, 420);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(297, 30);
            this.txt_sdt.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chức";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diachi.Location = new System.Drawing.Point(175, 367);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(297, 30);
            this.txt_diachi.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lương";
            // 
            // txt_luong
            // 
            this.txt_luong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luong.Location = new System.Drawing.Point(175, 311);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(297, 30);
            this.txt_luong.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Địa Chỉ";
            // 
            // txt_chuc
            // 
            this.txt_chuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_chuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chuc.Location = new System.Drawing.Point(175, 257);
            this.txt_chuc.Name = "txt_chuc";
            this.txt_chuc.Size = new System.Drawing.Size(297, 30);
            this.txt_chuc.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "SĐT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã Phòng Ban";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennv.Location = new System.Drawing.Point(175, 87);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(297, 30);
            this.txt_tennv.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã Chi Nhánh";
            // 
            // txt_manv
            // 
            this.txt_manv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(174, 37);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(297, 30);
            this.txt_manv.TabIndex = 19;
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Timkiem.BackColor = System.Drawing.Color.White;
            this.gb_Timkiem.Controls.Add(this.cbo_timcn);
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.cbo_phuongthuc);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Controls.Add(this.txt_giatri);
            this.gb_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Timkiem.Location = new System.Drawing.Point(17, 65);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Size = new System.Drawing.Size(1014, 84);
            this.gb_Timkiem.TabIndex = 39;
            this.gb_Timkiem.TabStop = false;
            this.gb_Timkiem.Text = "Tìm Kiếm";
            // 
            // cbo_timcn
            // 
            this.cbo_timcn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_timcn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_timcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_timcn.FormattingEnabled = true;
            this.cbo_timcn.Location = new System.Drawing.Point(589, 34);
            this.cbo_timcn.Name = "cbo_timcn";
            this.cbo_timcn.Size = new System.Drawing.Size(315, 33);
            this.cbo_timcn.TabIndex = 20;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(903, 32);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 32);
            this.btn_Tim.TabIndex = 19;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phương Thức Tìm";
            // 
            // cbo_phuongthuc
            // 
            this.cbo_phuongthuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_phuongthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phuongthuc.FormattingEnabled = true;
            this.cbo_phuongthuc.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên",
            "SĐT",
            "Chi Nhánh"});
            this.cbo_phuongthuc.Location = new System.Drawing.Point(190, 34);
            this.cbo_phuongthuc.Name = "cbo_phuongthuc";
            this.cbo_phuongthuc.Size = new System.Drawing.Size(315, 33);
            this.cbo_phuongthuc.TabIndex = 17;
            this.cbo_phuongthuc.TextChanged += new System.EventHandler(this.cbo_phuongthuc_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(505, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá Trị";
            // 
            // txt_giatri
            // 
            this.txt_giatri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_giatri.Location = new System.Drawing.Point(589, 35);
            this.txt_giatri.Name = "txt_giatri";
            this.txt_giatri.Size = new System.Drawing.Size(315, 30);
            this.txt_giatri.TabIndex = 16;
            // 
            // gb_DanhSach
            // 
            this.gb_DanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_DanhSach.BackColor = System.Drawing.Color.White;
            this.gb_DanhSach.Controls.Add(this.dgv_nhanvien);
            this.gb_DanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DanhSach.Location = new System.Drawing.Point(17, 155);
            this.gb_DanhSach.Name = "gb_DanhSach";
            this.gb_DanhSach.Size = new System.Drawing.Size(1014, 582);
            this.gb_DanhSach.TabIndex = 38;
            this.gb_DanhSach.TabStop = false;
            this.gb_DanhSach.Text = "Danh Sách";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhanvien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Location = new System.Drawing.Point(0, 27);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersVisible = false;
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhanvien.Size = new System.Drawing.Size(1008, 652);
            this.dgv_nhanvien.TabIndex = 11;
            this.dgv_nhanvien.Click += new System.EventHandler(this.dgv_nhanvien_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(806, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(428, 53);
            this.lbl_title.TabIndex = 37;
            this.lbl_title.Text = "Quản Lý Nhân Viên";
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 765);
            this.Controls.Add(this.gb_ChucNang);
            this.Controls.Add(this.gb_ThongTin);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.gb_DanhSach);
            this.Controls.Add(this.lbl_title);
            this.Name = "Frm_NhanVien";
            this.Text = "Frm_NhanVien";
            this.Load += new System.EventHandler(this.Frm_NhanVien_Load);
            this.gb_ChucNang.ResumeLayout(false);
            this.gb_ThongTin.ResumeLayout(false);
            this.gb_ThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.gb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_mapb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_chuc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.GroupBox gb_Timkiem;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_phuongthuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_giatri;
        private System.Windows.Forms.GroupBox gb_DanhSach;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cbo_macn;
        private System.Windows.Forms.ComboBox cbo_timcn;
    }
}