namespace GUI
{
    partial class Frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KhachHang));
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
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.panel_ThongTin = new GUI.Controls.Rounded_Panel();
            this.dtp_NgayTao = new CustomControls.RJControls.RJDatePicker();
            this.txt_QuocTich = new GUI.Controls.RJTextBox();
            this.txt_DiaChi = new GUI.Controls.RJTextBox();
            this.txt_Email = new GUI.Controls.RJTextBox();
            this.txt_SDT = new GUI.Controls.RJTextBox();
            this.txt_CCCD = new GUI.Controls.RJTextBox();
            this.txt_TenKH = new GUI.Controls.RJTextBox();
            this.txt_MaKH = new GUI.Controls.RJTextBox();
            this.cbo_DoiTuong = new GUI.Controls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_ChucNang = new GUI.Controls.Rounded_Panel();
            this.btn_Lammoi = new GUI.Controls.RJButton();
            this.btn_Xoa = new GUI.Controls.RJButton();
            this.btn_Sua = new GUI.Controls.RJButton();
            this.btn_Them = new GUI.Controls.RJButton();
            this.gb_Timkiem = new GUI.Controls.Rounded_Panel();
            this.btn_Tim = new GUI.Controls.RJButton();
            this.txt_GiaTri = new GUI.Controls.RJTextBox();
            this.cbo_PhuongThuc = new GUI.Controls.RJComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.panel_ThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_ChucNang.SuspendLayout();
            this.gb_Timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(620, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(376, 42);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Quản Trị Khách Hàng";
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
            this.panel2.TabIndex = 41;
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
            this.panel_DanhSach.BorderColor = System.Drawing.Color.White;
            this.panel_DanhSach.Controls.Add(this.dgv_KhachHang);
            this.panel_DanhSach.Location = new System.Drawing.Point(12, 158);
            this.panel_DanhSach.Name = "panel_DanhSach";
            this.panel_DanhSach.Radius = 20;
            this.panel_DanhSach.Size = new System.Drawing.Size(716, 324);
            this.panel_DanhSach.TabIndex = 40;
            this.panel_DanhSach.Thickness = 5F;
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowUserToAddRows = false;
            this.dgv_KhachHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_KhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_KhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_KhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_KhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KhachHang.EnableHeadersVisualStyles = false;
            this.dgv_KhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgv_KhachHang.MultiSelect = false;
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_KhachHang.RowHeadersWidth = 51;
            this.dgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhachHang.Size = new System.Drawing.Size(716, 324);
            this.dgv_KhachHang.TabIndex = 11;
            this.dgv_KhachHang.Click += new System.EventHandler(this.dgv_KhachHang_Click);
            // 
            // panel_ThongTin
            // 
            this.panel_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ThongTin.BorderColor = System.Drawing.Color.White;
            this.panel_ThongTin.Controls.Add(this.dtp_NgayTao);
            this.panel_ThongTin.Controls.Add(this.txt_QuocTich);
            this.panel_ThongTin.Controls.Add(this.txt_DiaChi);
            this.panel_ThongTin.Controls.Add(this.txt_Email);
            this.panel_ThongTin.Controls.Add(this.txt_SDT);
            this.panel_ThongTin.Controls.Add(this.txt_CCCD);
            this.panel_ThongTin.Controls.Add(this.txt_TenKH);
            this.panel_ThongTin.Controls.Add(this.txt_MaKH);
            this.panel_ThongTin.Controls.Add(this.cbo_DoiTuong);
            this.panel_ThongTin.Controls.Add(this.label1);
            this.panel_ThongTin.Controls.Add(this.panel1);
            this.panel_ThongTin.Controls.Add(this.label10);
            this.panel_ThongTin.Controls.Add(this.label2);
            this.panel_ThongTin.Controls.Add(this.label9);
            this.panel_ThongTin.Controls.Add(this.label3);
            this.panel_ThongTin.Controls.Add(this.label8);
            this.panel_ThongTin.Controls.Add(this.label4);
            this.panel_ThongTin.Controls.Add(this.label7);
            this.panel_ThongTin.Controls.Add(this.label5);
            this.panel_ThongTin.Controls.Add(this.label6);
            this.panel_ThongTin.Location = new System.Drawing.Point(1071, 171);
            this.panel_ThongTin.Name = "panel_ThongTin";
            this.panel_ThongTin.Radius = 20;
            this.panel_ThongTin.Size = new System.Drawing.Size(489, 566);
            this.panel_ThongTin.TabIndex = 39;
            this.panel_ThongTin.Thickness = 5F;
            // 
            // dtp_NgayTao
            // 
            this.dtp_NgayTao.BorderColor = System.Drawing.Color.Black;
            this.dtp_NgayTao.BorderSize = 2;
            this.dtp_NgayTao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtp_NgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtp_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayTao.Location = new System.Drawing.Point(175, 510);
            this.dtp_NgayTao.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            this.dtp_NgayTao.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtp_NgayTao.Name = "dtp_NgayTao";
            this.dtp_NgayTao.Size = new System.Drawing.Size(297, 35);
            this.dtp_NgayTao.SkinColor = System.Drawing.Color.Silver;
            this.dtp_NgayTao.TabIndex = 42;
            this.dtp_NgayTao.TextColor = System.Drawing.Color.Black;
            // 
            // txt_QuocTich
            // 
            this.txt_QuocTich.BackColor = System.Drawing.Color.Silver;
            this.txt_QuocTich.BorderColor = System.Drawing.Color.Black;
            this.txt_QuocTich.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_QuocTich.BorderRadius = 5;
            this.txt_QuocTich.BorderSize = 2;
            this.txt_QuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuocTich.ForeColor = System.Drawing.Color.Black;
            this.txt_QuocTich.Location = new System.Drawing.Point(175, 403);
            this.txt_QuocTich.Margin = new System.Windows.Forms.Padding(4);
            this.txt_QuocTich.Multiline = false;
            this.txt_QuocTich.Name = "txt_QuocTich";
            this.txt_QuocTich.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_QuocTich.PasswordChar = false;
            this.txt_QuocTich.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_QuocTich.PlaceholderText = "";
            this.txt_QuocTich.Size = new System.Drawing.Size(297, 31);
            this.txt_QuocTich.TabIndex = 45;
            this.txt_QuocTich.UnderlinedStyle = false;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.Color.Silver;
            this.txt_DiaChi.BorderColor = System.Drawing.Color.Black;
            this.txt_DiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DiaChi.BorderRadius = 5;
            this.txt_DiaChi.BorderSize = 2;
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.Location = new System.Drawing.Point(175, 350);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Multiline = false;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DiaChi.PasswordChar = false;
            this.txt_DiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(297, 31);
            this.txt_DiaChi.TabIndex = 44;
            this.txt_DiaChi.UnderlinedStyle = false;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.Silver;
            this.txt_Email.BorderColor = System.Drawing.Color.Black;
            this.txt_Email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Email.BorderRadius = 5;
            this.txt_Email.BorderSize = 2;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.Location = new System.Drawing.Point(175, 294);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Multiline = false;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Email.PasswordChar = false;
            this.txt_Email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.Size = new System.Drawing.Size(297, 31);
            this.txt_Email.TabIndex = 43;
            this.txt_Email.UnderlinedStyle = false;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.Color.Silver;
            this.txt_SDT.BorderColor = System.Drawing.Color.Black;
            this.txt_SDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_SDT.BorderRadius = 5;
            this.txt_SDT.BorderSize = 2;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.ForeColor = System.Drawing.Color.Black;
            this.txt_SDT.Location = new System.Drawing.Point(175, 240);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Multiline = false;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_SDT.PasswordChar = false;
            this.txt_SDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SDT.PlaceholderText = "";
            this.txt_SDT.Size = new System.Drawing.Size(297, 31);
            this.txt_SDT.TabIndex = 42;
            this.txt_SDT.UnderlinedStyle = false;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BackColor = System.Drawing.Color.Silver;
            this.txt_CCCD.BorderColor = System.Drawing.Color.Black;
            this.txt_CCCD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_CCCD.BorderRadius = 5;
            this.txt_CCCD.BorderSize = 2;
            this.txt_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CCCD.ForeColor = System.Drawing.Color.Black;
            this.txt_CCCD.Location = new System.Drawing.Point(175, 183);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CCCD.Multiline = false;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_CCCD.PasswordChar = false;
            this.txt_CCCD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_CCCD.PlaceholderText = "";
            this.txt_CCCD.Size = new System.Drawing.Size(297, 31);
            this.txt_CCCD.TabIndex = 41;
            this.txt_CCCD.UnderlinedStyle = false;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.BackColor = System.Drawing.Color.Silver;
            this.txt_TenKH.BorderColor = System.Drawing.Color.Black;
            this.txt_TenKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenKH.BorderRadius = 5;
            this.txt_TenKH.BorderSize = 2;
            this.txt_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.ForeColor = System.Drawing.Color.Black;
            this.txt_TenKH.Location = new System.Drawing.Point(175, 70);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKH.Multiline = false;
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenKH.PasswordChar = false;
            this.txt_TenKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenKH.PlaceholderText = "";
            this.txt_TenKH.Size = new System.Drawing.Size(297, 31);
            this.txt_TenKH.TabIndex = 40;
            this.txt_TenKH.UnderlinedStyle = false;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.Color.Silver;
            this.txt_MaKH.BorderColor = System.Drawing.Color.Black;
            this.txt_MaKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaKH.BorderRadius = 5;
            this.txt_MaKH.BorderSize = 2;
            this.txt_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.ForeColor = System.Drawing.Color.Black;
            this.txt_MaKH.Location = new System.Drawing.Point(174, 20);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKH.Multiline = false;
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaKH.PasswordChar = false;
            this.txt_MaKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaKH.PlaceholderText = "";
            this.txt_MaKH.Size = new System.Drawing.Size(297, 31);
            this.txt_MaKH.TabIndex = 39;
            this.txt_MaKH.UnderlinedStyle = false;
            // 
            // cbo_DoiTuong
            // 
            this.cbo_DoiTuong.BackColor = System.Drawing.Color.Silver;
            this.cbo_DoiTuong.BorderColor = System.Drawing.Color.Black;
            this.cbo_DoiTuong.BorderSize = 2;
            this.cbo_DoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_DoiTuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_DoiTuong.ForeColor = System.Drawing.Color.Black;
            this.cbo_DoiTuong.IconColor = System.Drawing.Color.Black;
            this.cbo_DoiTuong.Items.AddRange(new object[] {
            "Cá Nhân",
            "Doanh Nghiệp"});
            this.cbo_DoiTuong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_DoiTuong.ListTextColor = System.Drawing.Color.Black;
            this.cbo_DoiTuong.Location = new System.Drawing.Point(175, 458);
            this.cbo_DoiTuong.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_DoiTuong.Name = "cbo_DoiTuong";
            this.cbo_DoiTuong.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_DoiTuong.Size = new System.Drawing.Size(297, 30);
            this.cbo_DoiTuong.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdb_Nam);
            this.panel1.Controls.Add(this.rdb_Nu);
            this.panel1.Location = new System.Drawing.Point(175, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 32);
            this.panel1.TabIndex = 30;
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Checked = true;
            this.rdb_Nam.Location = new System.Drawing.Point(50, 1);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(75, 27);
            this.rdb_Nam.TabIndex = 28;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "NAM";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Location = new System.Drawing.Point(190, 1);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(59, 27);
            this.rdb_Nu.TabIndex = 29;
            this.rdb_Nu.Text = "NỮ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ngày Tạo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Đối Tượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới Tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quốc Tịch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số CCCD/CMND:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email:";
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ChucNang.BorderColor = System.Drawing.Color.White;
            this.panel_ChucNang.Controls.Add(this.btn_Lammoi);
            this.panel_ChucNang.Controls.Add(this.btn_Xoa);
            this.panel_ChucNang.Controls.Add(this.btn_Sua);
            this.panel_ChucNang.Controls.Add(this.btn_Them);
            this.panel_ChucNang.Location = new System.Drawing.Point(1071, 86);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Radius = 20;
            this.panel_ChucNang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_ChucNang.Size = new System.Drawing.Size(489, 68);
            this.panel_ChucNang.TabIndex = 38;
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
            this.btn_Lammoi.Location = new System.Drawing.Point(369, 13);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(97, 37);
            this.btn_Lammoi.TabIndex = 42;
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
            this.btn_Xoa.Location = new System.Drawing.Point(253, 13);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 37);
            this.btn_Xoa.TabIndex = 41;
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
            this.btn_Sua.Location = new System.Drawing.Point(143, 13);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 37);
            this.btn_Sua.TabIndex = 40;
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
            this.btn_Them.Location = new System.Drawing.Point(23, 13);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 37);
            this.btn_Them.TabIndex = 39;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.Black;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // gb_Timkiem
            // 
            this.gb_Timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_Timkiem.BorderColor = System.Drawing.Color.White;
            this.gb_Timkiem.Controls.Add(this.btn_Tim);
            this.gb_Timkiem.Controls.Add(this.txt_GiaTri);
            this.gb_Timkiem.Controls.Add(this.cbo_PhuongThuc);
            this.gb_Timkiem.Controls.Add(this.label11);
            this.gb_Timkiem.Controls.Add(this.label12);
            this.gb_Timkiem.Location = new System.Drawing.Point(12, 54);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Radius = 20;
            this.gb_Timkiem.Size = new System.Drawing.Size(984, 68);
            this.gb_Timkiem.TabIndex = 37;
            this.gb_Timkiem.Thickness = 5F;
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
            this.btn_Tim.Location = new System.Drawing.Point(896, 16);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 30);
            this.btn_Tim.TabIndex = 38;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.TextColor = System.Drawing.Color.Black;
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_GiaTri
            // 
            this.txt_GiaTri.BackColor = System.Drawing.Color.Silver;
            this.txt_GiaTri.BorderColor = System.Drawing.Color.Black;
            this.txt_GiaTri.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_GiaTri.BorderRadius = 0;
            this.txt_GiaTri.BorderSize = 2;
            this.txt_GiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaTri.ForeColor = System.Drawing.Color.Black;
            this.txt_GiaTri.Location = new System.Drawing.Point(575, 17);
            this.txt_GiaTri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaTri.Multiline = false;
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_GiaTri.PasswordChar = false;
            this.txt_GiaTri.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_GiaTri.PlaceholderText = "";
            this.txt_GiaTri.Size = new System.Drawing.Size(315, 31);
            this.txt_GiaTri.TabIndex = 38;
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
            "Mã Khách Hàng",
            "Tên Khách Hàng",
            "Số CCCD/CMND",
            "Số Điện Thoại"});
            this.cbo_PhuongThuc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_PhuongThuc.ListTextColor = System.Drawing.Color.Black;
            this.cbo_PhuongThuc.Location = new System.Drawing.Point(179, 18);
            this.cbo_PhuongThuc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_PhuongThuc.Name = "cbo_PhuongThuc";
            this.cbo_PhuongThuc.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_PhuongThuc.Size = new System.Drawing.Size(315, 30);
            this.cbo_PhuongThuc.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phương Thức Tìm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(500, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá Trị:";
            // 
            // Frm_KhachHang
            // 
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_DanhSach);
            this.Controls.Add(this.panel_ThongTin);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.gb_Timkiem);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_KhachHang";
            this.Text = "Quản Trị Khách Hàng";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            this.Resize += new System.EventHandler(this.Frm_KhachHang_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_X)).EndInit();
            this.panel_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.panel_ThongTin.ResumeLayout(false);
            this.panel_ThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_ChucNang.ResumeLayout(false);
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
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
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.Panel panel1;
        private Controls.Rounded_Panel gb_Timkiem;
        private Controls.RJComboBox cbo_PhuongThuc;
        private Controls.RJTextBox txt_GiaTri;
        private Controls.RJButton btn_Tim;
        private Controls.Rounded_Panel panel_ChucNang;
        private Controls.Rounded_Panel panel_ThongTin;
        private Controls.Rounded_Panel panel_DanhSach;
        private Controls.RJComboBox cbo_DoiTuong;
        private Controls.RJTextBox txt_MaKH;
        private Controls.RJTextBox txt_SDT;
        private Controls.RJTextBox txt_CCCD;
        private Controls.RJTextBox txt_TenKH;
        private Controls.RJTextBox txt_QuocTich;
        private Controls.RJTextBox txt_DiaChi;
        private Controls.RJTextBox txt_Email;
        private Controls.RJButton btn_Lammoi;
        private Controls.RJButton btn_Xoa;
        private Controls.RJButton btn_Sua;
        private Controls.RJButton btn_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_X;
        private System.Windows.Forms.PictureBox pb_Them;
        private System.Windows.Forms.PictureBox pb_TimKiem;
        private System.Windows.Forms.PictureBox pb_DarkMode;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Timer timer_TimKiem;
        private System.Windows.Forms.Timer timer_ChucNang;
        private CustomControls.RJControls.RJDatePicker dtp_NgayTao;
    }
}
