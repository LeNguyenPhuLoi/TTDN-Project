namespace GUI
{
    partial class Frm_GiaoDich
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GiaoDich));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.pb_DarkMode = new System.Windows.Forms.PictureBox();
            this.pb_Them = new System.Windows.Forms.PictureBox();
            this.pb_TimKiem = new System.Windows.Forms.PictureBox();
            this.pb_Minimize = new System.Windows.Forms.PictureBox();
            this.pb_X = new System.Windows.Forms.PictureBox();
            this.timer_TimKiem = new System.Windows.Forms.Timer(this.components);
            this.timer_ChucNang = new System.Windows.Forms.Timer(this.components);
            this.panel_ThongTin = new GUI.Controls.Rounded_Panel();
            this.dtp_ThoiGian = new CustomControls.RJControls.RJDatePicker();
            this.txt_SoTien = new GUI.Controls.RJTextBox();
            this.txt_LoaiGD = new GUI.Controls.RJTextBox();
            this.txt_MaGD = new GUI.Controls.RJTextBox();
            this.cbo_TrangThai = new GUI.Controls.RJComboBox();
            this.cbo_SoTK = new GUI.Controls.RJComboBox();
            this.rtxt_MoTa = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_ChucNang = new GUI.Controls.Rounded_Panel();
            this.btn_Lammoi = new GUI.Controls.RJButton();
            this.btn_Xoa = new GUI.Controls.RJButton();
            this.btn_Them = new GUI.Controls.RJButton();
            this.panel_DanhSach = new GUI.Controls.Rounded_Panel();
            this.dgv_GiaoDich = new System.Windows.Forms.DataGridView();
            this.gb_Timkiem = new GUI.Controls.Rounded_Panel();
            this.cbo_PhuongThuc = new GUI.Controls.RJComboBox();
            this.txt_GiaTri = new GUI.Controls.RJTextBox();
            this.cbo_STKTK = new GUI.Controls.RJComboBox();
            this.btn_Tim = new GUI.Controls.RJButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_X)).BeginInit();
            this.panel_ThongTin.SuspendLayout();
            this.panel_ChucNang.SuspendLayout();
            this.panel_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoDich)).BeginInit();
            this.gb_Timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(717, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(332, 42);
            this.lbl_title.TabIndex = 37;
            this.lbl_title.Text = "Quản Trị Giao Dịch";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.pb);
            this.panel2.Controls.Add(this.pb_DarkMode);
            this.panel2.Controls.Add(this.pb_Them);
            this.panel2.Controls.Add(this.pb_TimKiem);
            this.panel2.Controls.Add(this.pb_Minimize);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Controls.Add(this.pb_X);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 48);
            this.panel2.TabIndex = 43;
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(1460, 10);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(32, 32);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb.TabIndex = 42;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb_DarkMode
            // 
            this.pb_DarkMode.Image = ((System.Drawing.Image)(resources.GetObject("pb_DarkMode.Image")));
            this.pb_DarkMode.Location = new System.Drawing.Point(106, 10);
            this.pb_DarkMode.Name = "pb_DarkMode";
            this.pb_DarkMode.Size = new System.Drawing.Size(32, 32);
            this.pb_DarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_DarkMode.TabIndex = 42;
            this.pb_DarkMode.TabStop = false;
            this.pb_DarkMode.Click += new System.EventHandler(this.pb_DarkMode_Click);
            // 
            // pb_Them
            // 
            this.pb_Them.Image = ((System.Drawing.Image)(resources.GetObject("pb_Them.Image")));
            this.pb_Them.Location = new System.Drawing.Point(59, 10);
            this.pb_Them.Name = "pb_Them";
            this.pb_Them.Size = new System.Drawing.Size(32, 32);
            this.pb_Them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Them.TabIndex = 42;
            this.pb_Them.TabStop = false;
            this.pb_Them.Click += new System.EventHandler(this.pb_Them_Click);
            // 
            // pb_TimKiem
            // 
            this.pb_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("pb_TimKiem.Image")));
            this.pb_TimKiem.Location = new System.Drawing.Point(12, 10);
            this.pb_TimKiem.Name = "pb_TimKiem";
            this.pb_TimKiem.Size = new System.Drawing.Size(32, 32);
            this.pb_TimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_TimKiem.TabIndex = 42;
            this.pb_TimKiem.TabStop = false;
            this.pb_TimKiem.Click += new System.EventHandler(this.pb_TimKiem_Click);
            // 
            // pb_Minimize
            // 
            this.pb_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_Minimize.Image")));
            this.pb_Minimize.Location = new System.Drawing.Point(1505, 10);
            this.pb_Minimize.Name = "pb_Minimize";
            this.pb_Minimize.Size = new System.Drawing.Size(32, 32);
            this.pb_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Minimize.TabIndex = 42;
            this.pb_Minimize.TabStop = false;
            this.pb_Minimize.Click += new System.EventHandler(this.pb_Minimize_Click);
            // 
            // pb_X
            // 
            this.pb_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_X.Image = ((System.Drawing.Image)(resources.GetObject("pb_X.Image")));
            this.pb_X.Location = new System.Drawing.Point(1549, 10);
            this.pb_X.Name = "pb_X";
            this.pb_X.Size = new System.Drawing.Size(32, 32);
            this.pb_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_X.TabIndex = 42;
            this.pb_X.TabStop = false;
            this.pb_X.Click += new System.EventHandler(this.pb_X_Click);
            // 
            // timer_TimKiem
            // 
            this.timer_TimKiem.Interval = 10;
            this.timer_TimKiem.Tick += new System.EventHandler(this.timer_TimKiem_Tick);
            // 
            // timer_ChucNang
            // 
            this.timer_ChucNang.Interval = 10;
            this.timer_ChucNang.Tick += new System.EventHandler(this.timer_ChucNang_Tick);
            // 
            // panel_ThongTin
            // 
            this.panel_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ThongTin.BorderColor = System.Drawing.Color.White;
            this.panel_ThongTin.Controls.Add(this.dtp_ThoiGian);
            this.panel_ThongTin.Controls.Add(this.txt_SoTien);
            this.panel_ThongTin.Controls.Add(this.txt_LoaiGD);
            this.panel_ThongTin.Controls.Add(this.txt_MaGD);
            this.panel_ThongTin.Controls.Add(this.cbo_TrangThai);
            this.panel_ThongTin.Controls.Add(this.cbo_SoTK);
            this.panel_ThongTin.Controls.Add(this.rtxt_MoTa);
            this.panel_ThongTin.Controls.Add(this.label1);
            this.panel_ThongTin.Controls.Add(this.label2);
            this.panel_ThongTin.Controls.Add(this.label7);
            this.panel_ThongTin.Controls.Add(this.label6);
            this.panel_ThongTin.Controls.Add(this.label3);
            this.panel_ThongTin.Controls.Add(this.label5);
            this.panel_ThongTin.Controls.Add(this.label4);
            this.panel_ThongTin.Location = new System.Drawing.Point(1066, 182);
            this.panel_ThongTin.Name = "panel_ThongTin";
            this.panel_ThongTin.Radius = 20;
            this.panel_ThongTin.Size = new System.Drawing.Size(489, 495);
            this.panel_ThongTin.TabIndex = 47;
            this.panel_ThongTin.Thickness = 5F;
            // 
            // dtp_ThoiGian
            // 
            this.dtp_ThoiGian.BorderColor = System.Drawing.Color.Black;
            this.dtp_ThoiGian.BorderSize = 2;
            this.dtp_ThoiGian.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtp_ThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtp_ThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ThoiGian.Location = new System.Drawing.Point(165, 242);
            this.dtp_ThoiGian.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            this.dtp_ThoiGian.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtp_ThoiGian.Name = "dtp_ThoiGian";
            this.dtp_ThoiGian.Size = new System.Drawing.Size(297, 35);
            this.dtp_ThoiGian.SkinColor = System.Drawing.Color.Silver;
            this.dtp_ThoiGian.TabIndex = 48;
            this.dtp_ThoiGian.TextColor = System.Drawing.Color.Black;
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.BackColor = System.Drawing.Color.Silver;
            this.txt_SoTien.BorderColor = System.Drawing.Color.Black;
            this.txt_SoTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_SoTien.BorderRadius = 5;
            this.txt_SoTien.BorderSize = 2;
            this.txt_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTien.ForeColor = System.Drawing.Color.Black;
            this.txt_SoTien.Location = new System.Drawing.Point(165, 189);
            this.txt_SoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoTien.Multiline = false;
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_SoTien.PasswordChar = false;
            this.txt_SoTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SoTien.PlaceholderText = "";
            this.txt_SoTien.Size = new System.Drawing.Size(297, 31);
            this.txt_SoTien.TabIndex = 53;
            this.txt_SoTien.UnderlinedStyle = false;
            // 
            // txt_LoaiGD
            // 
            this.txt_LoaiGD.BackColor = System.Drawing.Color.Silver;
            this.txt_LoaiGD.BorderColor = System.Drawing.Color.Black;
            this.txt_LoaiGD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_LoaiGD.BorderRadius = 5;
            this.txt_LoaiGD.BorderSize = 2;
            this.txt_LoaiGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiGD.ForeColor = System.Drawing.Color.Black;
            this.txt_LoaiGD.Location = new System.Drawing.Point(165, 128);
            this.txt_LoaiGD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoaiGD.Multiline = false;
            this.txt_LoaiGD.Name = "txt_LoaiGD";
            this.txt_LoaiGD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_LoaiGD.PasswordChar = false;
            this.txt_LoaiGD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_LoaiGD.PlaceholderText = "";
            this.txt_LoaiGD.Size = new System.Drawing.Size(297, 31);
            this.txt_LoaiGD.TabIndex = 52;
            this.txt_LoaiGD.UnderlinedStyle = false;
            // 
            // txt_MaGD
            // 
            this.txt_MaGD.BackColor = System.Drawing.Color.Silver;
            this.txt_MaGD.BorderColor = System.Drawing.Color.Black;
            this.txt_MaGD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaGD.BorderRadius = 5;
            this.txt_MaGD.BorderSize = 2;
            this.txt_MaGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGD.ForeColor = System.Drawing.Color.Black;
            this.txt_MaGD.Location = new System.Drawing.Point(165, 26);
            this.txt_MaGD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaGD.Multiline = false;
            this.txt_MaGD.Name = "txt_MaGD";
            this.txt_MaGD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaGD.PasswordChar = false;
            this.txt_MaGD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaGD.PlaceholderText = "";
            this.txt_MaGD.Size = new System.Drawing.Size(297, 31);
            this.txt_MaGD.TabIndex = 50;
            this.txt_MaGD.UnderlinedStyle = false;
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.BackColor = System.Drawing.Color.Silver;
            this.cbo_TrangThai.BorderColor = System.Drawing.Color.Black;
            this.cbo_TrangThai.BorderSize = 2;
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_TrangThai.ForeColor = System.Drawing.Color.Black;
            this.cbo_TrangThai.IconColor = System.Drawing.Color.Black;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Thành Công",
            "Thất Bại",
            "Hủy"});
            this.cbo_TrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_TrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_TrangThai.Location = new System.Drawing.Point(166, 426);
            this.cbo_TrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_TrangThai.Size = new System.Drawing.Size(297, 30);
            this.cbo_TrangThai.TabIndex = 51;
            // 
            // cbo_SoTK
            // 
            this.cbo_SoTK.BackColor = System.Drawing.Color.Silver;
            this.cbo_SoTK.BorderColor = System.Drawing.Color.Black;
            this.cbo_SoTK.BorderSize = 2;
            this.cbo_SoTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_SoTK.ForeColor = System.Drawing.Color.Black;
            this.cbo_SoTK.IconColor = System.Drawing.Color.Black;
            this.cbo_SoTK.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_SoTK.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_SoTK.Location = new System.Drawing.Point(165, 76);
            this.cbo_SoTK.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_SoTK.Name = "cbo_SoTK";
            this.cbo_SoTK.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_SoTK.Size = new System.Drawing.Size(297, 30);
            this.cbo_SoTK.TabIndex = 50;
            // 
            // rtxt_MoTa
            // 
            this.rtxt_MoTa.BackColor = System.Drawing.Color.Silver;
            this.rtxt_MoTa.Location = new System.Drawing.Point(165, 300);
            this.rtxt_MoTa.Name = "rtxt_MoTa";
            this.rtxt_MoTa.Size = new System.Drawing.Size(297, 100);
            this.rtxt_MoTa.TabIndex = 29;
            this.rtxt_MoTa.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Giao Dịch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số Tài Khoản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng Thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mô Tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại Giao Dịch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời Gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Tiền:";
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ChucNang.BorderColor = System.Drawing.Color.White;
            this.panel_ChucNang.Controls.Add(this.btn_Lammoi);
            this.panel_ChucNang.Controls.Add(this.btn_Xoa);
            this.panel_ChucNang.Controls.Add(this.btn_Them);
            this.panel_ChucNang.Location = new System.Drawing.Point(1066, 86);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Radius = 20;
            this.panel_ChucNang.Size = new System.Drawing.Size(489, 79);
            this.panel_ChucNang.TabIndex = 46;
            this.panel_ChucNang.Thickness = 5F;
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.BackColor = System.Drawing.Color.Silver;
            this.btn_Lammoi.BackgroundColor = System.Drawing.Color.Silver;
            this.btn_Lammoi.BorderColor = System.Drawing.Color.Black;
            this.btn_Lammoi.BorderRadius = 5;
            this.btn_Lammoi.BorderSize = 2;
            this.btn_Lammoi.FlatAppearance.BorderSize = 0;
            this.btn_Lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lammoi.ForeColor = System.Drawing.Color.Black;
            this.btn_Lammoi.Location = new System.Drawing.Point(353, 22);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(97, 37);
            this.btn_Lammoi.TabIndex = 47;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.TextColor = System.Drawing.Color.Black;
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Silver;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.Silver;
            this.btn_Xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa.BorderRadius = 5;
            this.btn_Xoa.BorderSize = 2;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(202, 21);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 37);
            this.btn_Xoa.TabIndex = 46;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.Black;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Silver;
            this.btn_Them.BackgroundColor = System.Drawing.Color.Silver;
            this.btn_Them.BorderColor = System.Drawing.Color.Black;
            this.btn_Them.BorderRadius = 5;
            this.btn_Them.BorderSize = 2;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Location = new System.Drawing.Point(50, 22);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 37);
            this.btn_Them.TabIndex = 44;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.Black;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel_DanhSach
            // 
            this.panel_DanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_DanhSach.BorderColor = System.Drawing.Color.White;
            this.panel_DanhSach.Controls.Add(this.dgv_GiaoDich);
            this.panel_DanhSach.Location = new System.Drawing.Point(7, 160);
            this.panel_DanhSach.Name = "panel_DanhSach";
            this.panel_DanhSach.Radius = 20;
            this.panel_DanhSach.Size = new System.Drawing.Size(716, 324);
            this.panel_DanhSach.TabIndex = 45;
            this.panel_DanhSach.Thickness = 5F;
            // 
            // dgv_GiaoDich
            // 
            this.dgv_GiaoDich.AllowUserToAddRows = false;
            this.dgv_GiaoDich.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_GiaoDich.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_GiaoDich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GiaoDich.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_GiaoDich.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_GiaoDich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_GiaoDich.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiaoDich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_GiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_GiaoDich.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_GiaoDich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_GiaoDich.EnableHeadersVisualStyles = false;
            this.dgv_GiaoDich.Location = new System.Drawing.Point(0, 0);
            this.dgv_GiaoDich.MultiSelect = false;
            this.dgv_GiaoDich.Name = "dgv_GiaoDich";
            this.dgv_GiaoDich.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiaoDich.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_GiaoDich.RowHeadersWidth = 51;
            this.dgv_GiaoDich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GiaoDich.Size = new System.Drawing.Size(716, 324);
            this.dgv_GiaoDich.TabIndex = 13;
            this.dgv_GiaoDich.Click += new System.EventHandler(this.dgv_GiaoDich_Click);
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_Timkiem.BorderColor = System.Drawing.Color.White;
            this.gb_Timkiem.Controls.Add(this.cbo_PhuongThuc);
            this.gb_Timkiem.Controls.Add(this.txt_GiaTri);
            this.gb_Timkiem.Controls.Add(this.cbo_STKTK);
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Location = new System.Drawing.Point(7, 54);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Radius = 20;
            this.gb_Timkiem.Size = new System.Drawing.Size(984, 70);
            this.gb_Timkiem.TabIndex = 44;
            this.gb_Timkiem.Thickness = 5F;
            // 
            // cbo_PhuongThuc
            // 
            this.cbo_PhuongThuc.BackColor = System.Drawing.Color.Silver;
            this.cbo_PhuongThuc.BorderColor = System.Drawing.Color.Black;
            this.cbo_PhuongThuc.BorderSize = 2;
            this.cbo_PhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PhuongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_PhuongThuc.ForeColor = System.Drawing.Color.Black;
            this.cbo_PhuongThuc.IconColor = System.Drawing.Color.Black;
            this.cbo_PhuongThuc.Items.AddRange(new object[] {
            "Mã Giao Dịch",
            "Số Tài Khoản",
            "Loại Giao Dịch"});
            this.cbo_PhuongThuc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_PhuongThuc.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_PhuongThuc.Location = new System.Drawing.Point(179, 21);
            this.cbo_PhuongThuc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_PhuongThuc.Name = "cbo_PhuongThuc";
            this.cbo_PhuongThuc.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_PhuongThuc.Size = new System.Drawing.Size(315, 30);
            this.cbo_PhuongThuc.TabIndex = 48;
            this.cbo_PhuongThuc.SelectedIndexChanged += new System.EventHandler(this.cbo_PhuongThuc_SelectedIndexChanged);
            // 
            // txt_GiaTri
            // 
            this.txt_GiaTri.BackColor = System.Drawing.Color.Silver;
            this.txt_GiaTri.BorderColor = System.Drawing.Color.Black;
            this.txt_GiaTri.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_GiaTri.BorderRadius = 5;
            this.txt_GiaTri.BorderSize = 2;
            this.txt_GiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaTri.ForeColor = System.Drawing.Color.Black;
            this.txt_GiaTri.Location = new System.Drawing.Point(575, 20);
            this.txt_GiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaTri.Multiline = false;
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_GiaTri.PasswordChar = false;
            this.txt_GiaTri.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_GiaTri.PlaceholderText = "";
            this.txt_GiaTri.Size = new System.Drawing.Size(315, 31);
            this.txt_GiaTri.TabIndex = 48;
            this.txt_GiaTri.UnderlinedStyle = true;
            // 
            // cbo_STKTK
            // 
            this.cbo_STKTK.BackColor = System.Drawing.Color.Silver;
            this.cbo_STKTK.BorderColor = System.Drawing.Color.Black;
            this.cbo_STKTK.BorderSize = 2;
            this.cbo_STKTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_STKTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_STKTK.ForeColor = System.Drawing.Color.Black;
            this.cbo_STKTK.IconColor = System.Drawing.Color.Black;
            this.cbo_STKTK.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_STKTK.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_STKTK.Location = new System.Drawing.Point(575, 20);
            this.cbo_STKTK.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_STKTK.Name = "cbo_STKTK";
            this.cbo_STKTK.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_STKTK.Size = new System.Drawing.Size(315, 30);
            this.cbo_STKTK.TabIndex = 49;
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.Silver;
            this.btn_Tim.BackgroundColor = System.Drawing.Color.Silver;
            this.btn_Tim.BorderColor = System.Drawing.Color.Black;
            this.btn_Tim.BorderRadius = 5;
            this.btn_Tim.BorderSize = 2;
            this.btn_Tim.FlatAppearance.BorderSize = 0;
            this.btn_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tim.ForeColor = System.Drawing.Color.Black;
            this.btn_Tim.Location = new System.Drawing.Point(896, 19);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 30);
            this.btn_Tim.TabIndex = 40;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.TextColor = System.Drawing.Color.Black;
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phương Thức Tìm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(500, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá Trị:";
            // 
            // Frm_GiaoDich
            // 
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel_ThongTin);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.panel_DanhSach);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_GiaoDich";
            this.Text = "Quản Trị Giao Dịch";
            this.Load += new System.EventHandler(this.Frm_GiaoDich_Load);
            this.Resize += new System.EventHandler(this.Frm_GiaoDich_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_X)).EndInit();
            this.panel_ThongTin.ResumeLayout(false);
            this.panel_ThongTin.PerformLayout();
            this.panel_ChucNang.ResumeLayout(false);
            this.panel_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaoDich)).EndInit();
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.RichTextBox rtxt_MoTa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.PictureBox pb_DarkMode;
        private System.Windows.Forms.PictureBox pb_Them;
        private System.Windows.Forms.PictureBox pb_TimKiem;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_X;
        private Controls.Rounded_Panel gb_Timkiem;
        private Controls.Rounded_Panel panel_DanhSach;
        private System.Windows.Forms.DataGridView dgv_GiaoDich;
        private Controls.Rounded_Panel panel_ChucNang;
        private Controls.Rounded_Panel panel_ThongTin;
        private Controls.RJButton btn_Tim;
        private Controls.RJButton btn_Them;
        private Controls.RJButton btn_Xoa;
        private Controls.RJButton btn_Lammoi;
        private System.Windows.Forms.Timer timer_TimKiem;
        private System.Windows.Forms.Timer timer_ChucNang;
        private Controls.RJComboBox cbo_PhuongThuc;
        private Controls.RJComboBox cbo_TrangThai;
        private Controls.RJComboBox cbo_SoTK;
        private Controls.RJComboBox cbo_STKTK;
        private Controls.RJTextBox txt_GiaTri;
        private Controls.RJTextBox txt_MaGD;
        private Controls.RJTextBox txt_SoTien;
        private Controls.RJTextBox txt_LoaiGD;
        private CustomControls.RJControls.RJDatePicker dtp_ThoiGian;
    }
}
