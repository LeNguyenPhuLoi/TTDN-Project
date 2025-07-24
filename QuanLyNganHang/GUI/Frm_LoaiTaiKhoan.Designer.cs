namespace GUI
{
    partial class Frm_LoaiTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoaiTaiKhoan));
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
            this.txt_MaLoaiTK = new GUI.Controls.RJTextBox();
            this.rtxt_ChiTiet = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_ChucNang = new GUI.Controls.Rounded_Panel();
            this.btn_Lammoi = new GUI.Controls.RJButton();
            this.btn_Xoa = new GUI.Controls.RJButton();
            this.btn_Sua = new GUI.Controls.RJButton();
            this.btn_Them = new GUI.Controls.RJButton();
            this.panel_DanhSach = new GUI.Controls.Rounded_Panel();
            this.dgv_LoaiTaiKhoan = new System.Windows.Forms.DataGridView();
            this.gb_Timkiem = new GUI.Controls.Rounded_Panel();
            this.txt_GiaTri = new GUI.Controls.RJTextBox();
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
            this.panel_ThongTin.SuspendLayout();
            this.panel_ChucNang.SuspendLayout();
            this.panel_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTaiKhoan)).BeginInit();
            this.gb_Timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(759, 203);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(424, 42);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "Quản Trị Loại Tài Khoản";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.pb);
            this.panel2.Controls.Add(this.pb_DarkMode);
            this.panel2.Controls.Add(this.pb_Them);
            this.panel2.Controls.Add(this.pb_TimKiem);
            this.panel2.Controls.Add(this.pb_Minimize);
            this.panel2.Controls.Add(this.pb_X);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 48);
            this.panel2.TabIndex = 42;
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
            this.panel_ThongTin.Controls.Add(this.txt_MaLoaiTK);
            this.panel_ThongTin.Controls.Add(this.rtxt_ChiTiet);
            this.panel_ThongTin.Controls.Add(this.label2);
            this.panel_ThongTin.Controls.Add(this.label1);
            this.panel_ThongTin.Location = new System.Drawing.Point(1075, 203);
            this.panel_ThongTin.Name = "panel_ThongTin";
            this.panel_ThongTin.Radius = 20;
            this.panel_ThongTin.Size = new System.Drawing.Size(489, 283);
            this.panel_ThongTin.TabIndex = 45;
            this.panel_ThongTin.Thickness = 5F;
            // 
            // txt_MaLoaiTK
            // 
            this.txt_MaLoaiTK.BackColor = System.Drawing.Color.Silver;
            this.txt_MaLoaiTK.BorderColor = System.Drawing.Color.Black;
            this.txt_MaLoaiTK.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaLoaiTK.BorderRadius = 5;
            this.txt_MaLoaiTK.BorderSize = 2;
            this.txt_MaLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoaiTK.ForeColor = System.Drawing.Color.Black;
            this.txt_MaLoaiTK.Location = new System.Drawing.Point(22, 41);
            this.txt_MaLoaiTK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLoaiTK.Multiline = false;
            this.txt_MaLoaiTK.Name = "txt_MaLoaiTK";
            this.txt_MaLoaiTK.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaLoaiTK.PasswordChar = false;
            this.txt_MaLoaiTK.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaLoaiTK.PlaceholderText = "";
            this.txt_MaLoaiTK.Size = new System.Drawing.Size(440, 31);
            this.txt_MaLoaiTK.TabIndex = 47;
            this.txt_MaLoaiTK.UnderlinedStyle = false;
            // 
            // rtxt_ChiTiet
            // 
            this.rtxt_ChiTiet.BackColor = System.Drawing.Color.Silver;
            this.rtxt_ChiTiet.ForeColor = System.Drawing.Color.Black;
            this.rtxt_ChiTiet.Location = new System.Drawing.Point(24, 120);
            this.rtxt_ChiTiet.Name = "rtxt_ChiTiet";
            this.rtxt_ChiTiet.Size = new System.Drawing.Size(438, 126);
            this.rtxt_ChiTiet.TabIndex = 39;
            this.rtxt_ChiTiet.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Chi Tiết:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Loại Tài Khoản:";
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ChucNang.BorderColor = System.Drawing.Color.White;
            this.panel_ChucNang.Controls.Add(this.btn_Lammoi);
            this.panel_ChucNang.Controls.Add(this.btn_Xoa);
            this.panel_ChucNang.Controls.Add(this.btn_Sua);
            this.panel_ChucNang.Controls.Add(this.btn_Them);
            this.panel_ChucNang.Location = new System.Drawing.Point(1075, 118);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Radius = 20;
            this.panel_ChucNang.Size = new System.Drawing.Size(489, 79);
            this.panel_ChucNang.TabIndex = 44;
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
            // panel_DanhSach
            // 
            this.panel_DanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_DanhSach.BorderColor = System.Drawing.Color.White;
            this.panel_DanhSach.Controls.Add(this.dgv_LoaiTaiKhoan);
            this.panel_DanhSach.Location = new System.Drawing.Point(12, 166);
            this.panel_DanhSach.Name = "panel_DanhSach";
            this.panel_DanhSach.Radius = 20;
            this.panel_DanhSach.Size = new System.Drawing.Size(716, 309);
            this.panel_DanhSach.TabIndex = 43;
            this.panel_DanhSach.Thickness = 5F;
            // 
            // dgv_LoaiTaiKhoan
            // 
            this.dgv_LoaiTaiKhoan.AllowUserToAddRows = false;
            this.dgv_LoaiTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_LoaiTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LoaiTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiTaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_LoaiTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_LoaiTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_LoaiTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_LoaiTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LoaiTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_LoaiTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgv_LoaiTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgv_LoaiTaiKhoan.MultiSelect = false;
            this.dgv_LoaiTaiKhoan.Name = "dgv_LoaiTaiKhoan";
            this.dgv_LoaiTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_LoaiTaiKhoan.RowHeadersWidth = 51;
            this.dgv_LoaiTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiTaiKhoan.Size = new System.Drawing.Size(536, 309);
            this.dgv_LoaiTaiKhoan.TabIndex = 12;
            this.dgv_LoaiTaiKhoan.Click += new System.EventHandler(this.dgv_LoaiTaiKhoan_Click);
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_Timkiem.BorderColor = System.Drawing.Color.White;
            this.gb_Timkiem.Controls.Add(this.txt_GiaTri);
            this.gb_Timkiem.Controls.Add(this.cbo_PhuongThuc);
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Location = new System.Drawing.Point(12, 62);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Radius = 20;
            this.gb_Timkiem.Size = new System.Drawing.Size(984, 71);
            this.gb_Timkiem.TabIndex = 39;
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
            this.txt_GiaTri.Location = new System.Drawing.Point(572, 22);
            this.txt_GiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaTri.Multiline = false;
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_GiaTri.PasswordChar = false;
            this.txt_GiaTri.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_GiaTri.PlaceholderText = "";
            this.txt_GiaTri.Size = new System.Drawing.Size(315, 31);
            this.txt_GiaTri.TabIndex = 46;
            this.txt_GiaTri.UnderlinedStyle = true;
            // 
            // cbo_PhuongThuc
            // 
            this.cbo_PhuongThuc.BackColor = System.Drawing.Color.Silver;
            this.cbo_PhuongThuc.BorderColor = System.Drawing.Color.Black;
            this.cbo_PhuongThuc.BorderSize = 2;
            this.cbo_PhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_PhuongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_PhuongThuc.ForeColor = System.Drawing.Color.Black;
            this.cbo_PhuongThuc.IconColor = System.Drawing.Color.Black;
            this.cbo_PhuongThuc.Items.AddRange(new object[] {
            "Mã Loại",
            "Chi Tiết"});
            this.cbo_PhuongThuc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_PhuongThuc.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_PhuongThuc.Location = new System.Drawing.Point(176, 23);
            this.cbo_PhuongThuc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_PhuongThuc.Name = "cbo_PhuongThuc";
            this.cbo_PhuongThuc.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_PhuongThuc.Size = new System.Drawing.Size(315, 30);
            this.cbo_PhuongThuc.TabIndex = 46;
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
            this.btn_Tim.Location = new System.Drawing.Point(893, 22);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 30);
            this.btn_Tim.TabIndex = 39;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.TextColor = System.Drawing.Color.Black;
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phương Thức Tìm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(497, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá Trị:";
            // 
            // Frm_LoaiTaiKhoan
            // 
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel_ThongTin);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.panel_DanhSach);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoaiTaiKhoan";
            this.Text = "Quản Trị Loại Tài Khoản";
            this.Load += new System.EventHandler(this.Frm_LoaiTaiKhoan_Load);
            this.Resize += new System.EventHandler(this.Frm_LoaiTaiKhoan_Resize);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTaiKhoan)).EndInit();
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxt_ChiTiet;
        private Controls.Rounded_Panel gb_Timkiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.PictureBox pb_DarkMode;
        private System.Windows.Forms.PictureBox pb_Them;
        private System.Windows.Forms.PictureBox pb_TimKiem;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_X;
        private Controls.Rounded_Panel panel_DanhSach;
        private Controls.Rounded_Panel panel_ChucNang;
        private Controls.Rounded_Panel panel_ThongTin;
        private System.Windows.Forms.DataGridView dgv_LoaiTaiKhoan;
        private Controls.RJButton btn_Tim;
        private Controls.RJButton btn_Lammoi;
        private Controls.RJButton btn_Xoa;
        private Controls.RJButton btn_Sua;
        private Controls.RJButton btn_Them;
        private System.Windows.Forms.Timer timer_TimKiem;
        private System.Windows.Forms.Timer timer_ChucNang;
        private Controls.RJComboBox cbo_PhuongThuc;
        private Controls.RJTextBox txt_GiaTri;
        private Controls.RJTextBox txt_MaLoaiTK;
    }
}
