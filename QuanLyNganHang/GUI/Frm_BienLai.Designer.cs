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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BienLai));
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
            this.panel_DanhSach = new GUI.Controls.Rounded_Panel();
            this.dgv_BienLai = new System.Windows.Forms.DataGridView();
            this.panel_ThongTin = new GUI.Controls.Rounded_Panel();
            this.cbo_TrangThai = new GUI.Controls.RJComboBox();
            this.txt_LoaiBL = new GUI.Controls.RJTextBox();
            this.cbo_TenLoaiTien = new GUI.Controls.RJComboBox();
            this.cbo_SoTien = new GUI.Controls.RJComboBox();
            this.cbo_TenNV = new GUI.Controls.RJComboBox();
            this.cbo_SoTK = new GUI.Controls.RJComboBox();
            this.cbo_TenKH = new GUI.Controls.RJComboBox();
            this.cbo_MaGD = new GUI.Controls.RJComboBox();
            this.txt_MaBL = new GUI.Controls.RJTextBox();
            this.rtxt_MoTa = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_ChucNang = new GUI.Controls.Rounded_Panel();
            this.btn_Lammoi = new GUI.Controls.RJButton();
            this.btn_Xoa = new GUI.Controls.RJButton();
            this.btn_Sua = new GUI.Controls.RJButton();
            this.btn_Them = new GUI.Controls.RJButton();
            this.gb_Timkiem = new GUI.Controls.Rounded_Panel();
            this.txt_GiaTri = new GUI.Controls.RJTextBox();
            this.cbo_GiaTri = new GUI.Controls.RJComboBox();
            this.cbo_PhuongThuc = new GUI.Controls.RJComboBox();
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
            this.panel_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BienLai)).BeginInit();
            this.panel_ThongTin.SuspendLayout();
            this.panel_ChucNang.SuspendLayout();
            this.gb_Timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(723, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(308, 42);
            this.lbl_title.TabIndex = 37;
            this.lbl_title.Text = "Quản Trị Biên Lai";
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
            // panel_DanhSach
            // 
            this.panel_DanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_DanhSach.BorderColor = System.Drawing.Color.White;
            this.panel_DanhSach.Controls.Add(this.dgv_BienLai);
            this.panel_DanhSach.Location = new System.Drawing.Point(12, 190);
            this.panel_DanhSach.Name = "panel_DanhSach";
            this.panel_DanhSach.Radius = 20;
            this.panel_DanhSach.Size = new System.Drawing.Size(716, 309);
            this.panel_DanhSach.TabIndex = 47;
            this.panel_DanhSach.Thickness = 5F;
            // 
            // dgv_BienLai
            // 
            this.dgv_BienLai.AllowUserToAddRows = false;
            this.dgv_BienLai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_BienLai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BienLai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BienLai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_BienLai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_BienLai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_BienLai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BienLai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BienLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BienLai.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BienLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BienLai.EnableHeadersVisualStyles = false;
            this.dgv_BienLai.Location = new System.Drawing.Point(0, 0);
            this.dgv_BienLai.MultiSelect = false;
            this.dgv_BienLai.Name = "dgv_BienLai";
            this.dgv_BienLai.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BienLai.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_BienLai.RowHeadersWidth = 51;
            this.dgv_BienLai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BienLai.Size = new System.Drawing.Size(716, 309);
            this.dgv_BienLai.TabIndex = 12;
            this.dgv_BienLai.Click += new System.EventHandler(this.dgv_BienLai_Click);
            // 
            // panel_ThongTin
            // 
            this.panel_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ThongTin.BorderColor = System.Drawing.Color.White;
            this.panel_ThongTin.Controls.Add(this.cbo_TrangThai);
            this.panel_ThongTin.Controls.Add(this.txt_LoaiBL);
            this.panel_ThongTin.Controls.Add(this.cbo_TenLoaiTien);
            this.panel_ThongTin.Controls.Add(this.cbo_SoTien);
            this.panel_ThongTin.Controls.Add(this.cbo_TenNV);
            this.panel_ThongTin.Controls.Add(this.cbo_SoTK);
            this.panel_ThongTin.Controls.Add(this.cbo_TenKH);
            this.panel_ThongTin.Controls.Add(this.cbo_MaGD);
            this.panel_ThongTin.Controls.Add(this.txt_MaBL);
            this.panel_ThongTin.Controls.Add(this.rtxt_MoTa);
            this.panel_ThongTin.Controls.Add(this.label10);
            this.panel_ThongTin.Controls.Add(this.label9);
            this.panel_ThongTin.Controls.Add(this.label8);
            this.panel_ThongTin.Controls.Add(this.label7);
            this.panel_ThongTin.Controls.Add(this.label6);
            this.panel_ThongTin.Controls.Add(this.label5);
            this.panel_ThongTin.Controls.Add(this.label1);
            this.panel_ThongTin.Controls.Add(this.label2);
            this.panel_ThongTin.Controls.Add(this.label4);
            this.panel_ThongTin.Controls.Add(this.label3);
            this.panel_ThongTin.Location = new System.Drawing.Point(1068, 170);
            this.panel_ThongTin.Name = "panel_ThongTin";
            this.panel_ThongTin.Radius = 20;
            this.panel_ThongTin.Size = new System.Drawing.Size(489, 679);
            this.panel_ThongTin.TabIndex = 46;
            this.panel_ThongTin.Thickness = 5F;
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
            "Chưa in",
            "Đã in"});
            this.cbo_TrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_TrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_TrangThai.Location = new System.Drawing.Point(173, 611);
            this.cbo_TrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_TrangThai.Size = new System.Drawing.Size(297, 30);
            this.cbo_TrangThai.TabIndex = 56;
            // 
            // txt_LoaiBL
            // 
            this.txt_LoaiBL.BackColor = System.Drawing.Color.Silver;
            this.txt_LoaiBL.BorderColor = System.Drawing.Color.Black;
            this.txt_LoaiBL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_LoaiBL.BorderRadius = 5;
            this.txt_LoaiBL.BorderSize = 2;
            this.txt_LoaiBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiBL.ForeColor = System.Drawing.Color.Black;
            this.txt_LoaiBL.Location = new System.Drawing.Point(174, 403);
            this.txt_LoaiBL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoaiBL.Multiline = false;
            this.txt_LoaiBL.Name = "txt_LoaiBL";
            this.txt_LoaiBL.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_LoaiBL.PasswordChar = false;
            this.txt_LoaiBL.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_LoaiBL.PlaceholderText = "";
            this.txt_LoaiBL.Size = new System.Drawing.Size(298, 31);
            this.txt_LoaiBL.TabIndex = 55;
            this.txt_LoaiBL.UnderlinedStyle = false;
            // 
            // cbo_TenLoaiTien
            // 
            this.cbo_TenLoaiTien.BackColor = System.Drawing.Color.Silver;
            this.cbo_TenLoaiTien.BorderColor = System.Drawing.Color.Black;
            this.cbo_TenLoaiTien.BorderSize = 2;
            this.cbo_TenLoaiTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenLoaiTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_TenLoaiTien.ForeColor = System.Drawing.Color.Black;
            this.cbo_TenLoaiTien.IconColor = System.Drawing.Color.Black;
            this.cbo_TenLoaiTien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_TenLoaiTien.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_TenLoaiTien.Location = new System.Drawing.Point(174, 350);
            this.cbo_TenLoaiTien.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_TenLoaiTien.Name = "cbo_TenLoaiTien";
            this.cbo_TenLoaiTien.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_TenLoaiTien.Size = new System.Drawing.Size(297, 30);
            this.cbo_TenLoaiTien.TabIndex = 54;
            // 
            // cbo_SoTien
            // 
            this.cbo_SoTien.BackColor = System.Drawing.Color.Silver;
            this.cbo_SoTien.BorderColor = System.Drawing.Color.Black;
            this.cbo_SoTien.BorderSize = 2;
            this.cbo_SoTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_SoTien.ForeColor = System.Drawing.Color.Black;
            this.cbo_SoTien.IconColor = System.Drawing.Color.Black;
            this.cbo_SoTien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_SoTien.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_SoTien.Location = new System.Drawing.Point(173, 294);
            this.cbo_SoTien.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_SoTien.Name = "cbo_SoTien";
            this.cbo_SoTien.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_SoTien.Size = new System.Drawing.Size(297, 30);
            this.cbo_SoTien.TabIndex = 53;
            // 
            // cbo_TenNV
            // 
            this.cbo_TenNV.BackColor = System.Drawing.Color.Silver;
            this.cbo_TenNV.BorderColor = System.Drawing.Color.Black;
            this.cbo_TenNV.BorderSize = 2;
            this.cbo_TenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_TenNV.ForeColor = System.Drawing.Color.Black;
            this.cbo_TenNV.IconColor = System.Drawing.Color.Black;
            this.cbo_TenNV.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_TenNV.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_TenNV.Location = new System.Drawing.Point(173, 240);
            this.cbo_TenNV.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_TenNV.Name = "cbo_TenNV";
            this.cbo_TenNV.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_TenNV.Size = new System.Drawing.Size(297, 30);
            this.cbo_TenNV.TabIndex = 52;
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
            this.cbo_SoTK.Location = new System.Drawing.Point(174, 183);
            this.cbo_SoTK.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_SoTK.Name = "cbo_SoTK";
            this.cbo_SoTK.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_SoTK.Size = new System.Drawing.Size(297, 30);
            this.cbo_SoTK.TabIndex = 51;
            this.cbo_SoTK.SelectedIndexChanged += new System.EventHandler(this.cbo_SoTK_SelectedIndexChanged);
            // 
            // cbo_TenKH
            // 
            this.cbo_TenKH.BackColor = System.Drawing.Color.Silver;
            this.cbo_TenKH.BorderColor = System.Drawing.Color.Black;
            this.cbo_TenKH.BorderSize = 2;
            this.cbo_TenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_TenKH.ForeColor = System.Drawing.Color.Black;
            this.cbo_TenKH.IconColor = System.Drawing.Color.Black;
            this.cbo_TenKH.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_TenKH.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_TenKH.Location = new System.Drawing.Point(174, 126);
            this.cbo_TenKH.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_TenKH.Name = "cbo_TenKH";
            this.cbo_TenKH.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_TenKH.Size = new System.Drawing.Size(297, 30);
            this.cbo_TenKH.TabIndex = 50;
            this.cbo_TenKH.SelectedIndexChanged += new System.EventHandler(this.cbo_TenKH_SelectedIndexChanged);
            // 
            // cbo_MaGD
            // 
            this.cbo_MaGD.BackColor = System.Drawing.Color.Silver;
            this.cbo_MaGD.BorderColor = System.Drawing.Color.Black;
            this.cbo_MaGD.BorderSize = 2;
            this.cbo_MaGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MaGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_MaGD.ForeColor = System.Drawing.Color.Black;
            this.cbo_MaGD.IconColor = System.Drawing.Color.Black;
            this.cbo_MaGD.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_MaGD.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_MaGD.Location = new System.Drawing.Point(174, 70);
            this.cbo_MaGD.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_MaGD.Name = "cbo_MaGD";
            this.cbo_MaGD.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_MaGD.Size = new System.Drawing.Size(297, 30);
            this.cbo_MaGD.TabIndex = 49;
            this.cbo_MaGD.SelectedIndexChanged += new System.EventHandler(this.cbo_MaGD_SelectedIndexChanged);
            // 
            // txt_MaBL
            // 
            this.txt_MaBL.BackColor = System.Drawing.Color.Silver;
            this.txt_MaBL.BorderColor = System.Drawing.Color.Black;
            this.txt_MaBL.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaBL.BorderRadius = 5;
            this.txt_MaBL.BorderSize = 2;
            this.txt_MaBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaBL.ForeColor = System.Drawing.Color.Black;
            this.txt_MaBL.Location = new System.Drawing.Point(173, 20);
            this.txt_MaBL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaBL.Multiline = false;
            this.txt_MaBL.Name = "txt_MaBL";
            this.txt_MaBL.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaBL.PasswordChar = false;
            this.txt_MaBL.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaBL.PlaceholderText = "";
            this.txt_MaBL.Size = new System.Drawing.Size(298, 31);
            this.txt_MaBL.TabIndex = 49;
            this.txt_MaBL.UnderlinedStyle = false;
            // 
            // rtxt_MoTa
            // 
            this.rtxt_MoTa.BackColor = System.Drawing.Color.Silver;
            this.rtxt_MoTa.ForeColor = System.Drawing.Color.Black;
            this.rtxt_MoTa.Location = new System.Drawing.Point(174, 458);
            this.rtxt_MoTa.Name = "rtxt_MoTa";
            this.rtxt_MoTa.Size = new System.Drawing.Size(297, 129);
            this.rtxt_MoTa.TabIndex = 42;
            this.rtxt_MoTa.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 614);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Trạng Thái:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mô Tả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Loại Biên Lai:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên Loại Tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Biên Lai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Giao Dịch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số Tài Khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khách Hàng:";
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ChucNang.BorderColor = System.Drawing.Color.White;
            this.panel_ChucNang.Controls.Add(this.btn_Lammoi);
            this.panel_ChucNang.Controls.Add(this.btn_Xoa);
            this.panel_ChucNang.Controls.Add(this.btn_Sua);
            this.panel_ChucNang.Controls.Add(this.btn_Them);
            this.panel_ChucNang.Location = new System.Drawing.Point(1068, 85);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Radius = 20;
            this.panel_ChucNang.Size = new System.Drawing.Size(489, 79);
            this.panel_ChucNang.TabIndex = 45;
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
            this.btn_Lammoi.Location = new System.Drawing.Point(369, 21);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(97, 37);
            this.btn_Lammoi.TabIndex = 46;
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
            this.btn_Xoa.Location = new System.Drawing.Point(253, 21);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 37);
            this.btn_Xoa.TabIndex = 45;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.Black;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Silver;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.Silver;
            this.btn_Sua.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua.BorderRadius = 5;
            this.btn_Sua.BorderSize = 2;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Location = new System.Drawing.Point(143, 21);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 37);
            this.btn_Sua.TabIndex = 44;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.Black;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
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
            this.btn_Them.Location = new System.Drawing.Point(23, 21);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 37);
            this.btn_Them.TabIndex = 43;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.Black;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_Timkiem.BorderColor = System.Drawing.Color.White;
            this.gb_Timkiem.Controls.Add(this.txt_GiaTri);
            this.gb_Timkiem.Controls.Add(this.cbo_GiaTri);
            this.gb_Timkiem.Controls.Add(this.cbo_PhuongThuc);
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Location = new System.Drawing.Point(12, 65);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Radius = 20;
            this.gb_Timkiem.Size = new System.Drawing.Size(990, 76);
            this.gb_Timkiem.TabIndex = 44;
            this.gb_Timkiem.Thickness = 5F;
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
            this.txt_GiaTri.Location = new System.Drawing.Point(580, 21);
            this.txt_GiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaTri.Multiline = false;
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_GiaTri.PasswordChar = false;
            this.txt_GiaTri.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_GiaTri.PlaceholderText = "";
            this.txt_GiaTri.Size = new System.Drawing.Size(315, 31);
            this.txt_GiaTri.TabIndex = 47;
            this.txt_GiaTri.UnderlinedStyle = true;
            // 
            // cbo_GiaTri
            // 
            this.cbo_GiaTri.BackColor = System.Drawing.Color.Silver;
            this.cbo_GiaTri.BorderColor = System.Drawing.Color.Black;
            this.cbo_GiaTri.BorderSize = 2;
            this.cbo_GiaTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_GiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_GiaTri.ForeColor = System.Drawing.Color.Black;
            this.cbo_GiaTri.IconColor = System.Drawing.Color.Black;
            this.cbo_GiaTri.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_GiaTri.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_GiaTri.Location = new System.Drawing.Point(580, 21);
            this.cbo_GiaTri.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_GiaTri.Name = "cbo_GiaTri";
            this.cbo_GiaTri.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_GiaTri.Size = new System.Drawing.Size(315, 30);
            this.cbo_GiaTri.TabIndex = 48;
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
            "Mã Biên Lai",
            "Mã Giao Dịch",
            "Tên Khách Hàng",
            "Số Tài Khoản"});
            this.cbo_PhuongThuc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_PhuongThuc.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_PhuongThuc.Location = new System.Drawing.Point(184, 22);
            this.cbo_PhuongThuc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_PhuongThuc.Name = "cbo_PhuongThuc";
            this.cbo_PhuongThuc.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_PhuongThuc.Size = new System.Drawing.Size(315, 30);
            this.cbo_PhuongThuc.TabIndex = 47;
            this.cbo_PhuongThuc.SelectedIndexChanged += new System.EventHandler(this.cbo_PhuongThuc_SelectedIndexChanged);
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
            this.btn_Tim.Location = new System.Drawing.Point(901, 21);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 30);
            this.btn_Tim.TabIndex = 43;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.TextColor = System.Drawing.Color.Black;
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phương Thức Tìm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá Trị:";
            // 
            // Frm_BienLai
            // 
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel_DanhSach);
            this.Controls.Add(this.panel_ThongTin);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BienLai";
            this.Text = "Quản Trị Biên Lai";
            this.Load += new System.EventHandler(this.Frm_BienLai_Load);
            this.Resize += new System.EventHandler(this.Frm_BienLai_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_X)).EndInit();
            this.panel_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BienLai)).EndInit();
            this.panel_ThongTin.ResumeLayout(false);
            this.panel_ThongTin.PerformLayout();
            this.panel_ChucNang.ResumeLayout(false);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Controls.Rounded_Panel panel_ChucNang;
        private Controls.RJButton btn_Lammoi;
        private Controls.RJButton btn_Xoa;
        private Controls.RJButton btn_Sua;
        private Controls.RJButton btn_Them;
        private Controls.RJButton btn_Tim;
        private Controls.Rounded_Panel panel_ThongTin;
        private Controls.RJComboBox cbo_PhuongThuc;
        private Controls.RJComboBox cbo_GiaTri;
        private Controls.RJTextBox txt_GiaTri;
        private Controls.Rounded_Panel panel_DanhSach;
        private System.Windows.Forms.DataGridView dgv_BienLai;
        private Controls.RJComboBox cbo_MaGD;
        private Controls.RJTextBox txt_MaBL;
        private Controls.RJComboBox cbo_TenNV;
        private Controls.RJComboBox cbo_SoTK;
        private Controls.RJComboBox cbo_TenKH;
        private Controls.RJTextBox txt_LoaiBL;
        private Controls.RJComboBox cbo_TenLoaiTien;
        private Controls.RJComboBox cbo_SoTien;
        private Controls.RJComboBox cbo_TrangThai;
        private System.Windows.Forms.Timer timer_TimKiem;
        private System.Windows.Forms.Timer timer_ChucNang;
    }
}
