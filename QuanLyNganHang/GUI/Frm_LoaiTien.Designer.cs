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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LoaiTien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgv_LoaiTien = new System.Windows.Forms.DataGridView();
            this.panel_ChucNang = new GUI.Controls.Rounded_Panel();
            this.btn_Lammoi = new GUI.Controls.RJButton();
            this.btn_Xoa = new GUI.Controls.RJButton();
            this.btn_Sua = new GUI.Controls.RJButton();
            this.btn_Them = new GUI.Controls.RJButton();
            this.panel_ThongTin = new GUI.Controls.Rounded_Panel();
            this.cbo_TrangThai = new GUI.Controls.RJComboBox();
            this.txt_QuocGia = new GUI.Controls.RJTextBox();
            this.txt_KyHieu = new GUI.Controls.RJTextBox();
            this.txt_TenLoaiTien = new GUI.Controls.RJTextBox();
            this.txt_MaLoaiTien = new GUI.Controls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTien)).BeginInit();
            this.panel_ChucNang.SuspendLayout();
            this.panel_ThongTin.SuspendLayout();
            this.gb_Timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(751, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(324, 42);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "Quản Trị Loại Tiền";
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
            this.panel2.TabIndex = 44;
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
            this.panel_DanhSach.Controls.Add(this.dgv_LoaiTien);
            this.panel_DanhSach.Location = new System.Drawing.Point(12, 156);
            this.panel_DanhSach.Name = "panel_DanhSach";
            this.panel_DanhSach.Radius = 20;
            this.panel_DanhSach.Size = new System.Drawing.Size(716, 321);
            this.panel_DanhSach.TabIndex = 47;
            this.panel_DanhSach.Thickness = 5F;
            // 
            // dgv_LoaiTien
            // 
            this.dgv_LoaiTien.AllowUserToAddRows = false;
            this.dgv_LoaiTien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_LoaiTien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LoaiTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiTien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_LoaiTien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_LoaiTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_LoaiTien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiTien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_LoaiTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_LoaiTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_LoaiTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LoaiTien.EnableHeadersVisualStyles = false;
            this.dgv_LoaiTien.Location = new System.Drawing.Point(0, 0);
            this.dgv_LoaiTien.MultiSelect = false;
            this.dgv_LoaiTien.Name = "dgv_LoaiTien";
            this.dgv_LoaiTien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiTien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_LoaiTien.RowHeadersWidth = 51;
            this.dgv_LoaiTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiTien.Size = new System.Drawing.Size(716, 321);
            this.dgv_LoaiTien.TabIndex = 13;
            this.dgv_LoaiTien.Click += new System.EventHandler(this.dgv_LoaiTien_Click);
            // 
            // panel_ChucNang
            // 
            this.panel_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ChucNang.BorderColor = System.Drawing.Color.White;
            this.panel_ChucNang.Controls.Add(this.btn_Lammoi);
            this.panel_ChucNang.Controls.Add(this.btn_Xoa);
            this.panel_ChucNang.Controls.Add(this.btn_Sua);
            this.panel_ChucNang.Controls.Add(this.btn_Them);
            this.panel_ChucNang.Location = new System.Drawing.Point(1080, 84);
            this.panel_ChucNang.Name = "panel_ChucNang";
            this.panel_ChucNang.Radius = 20;
            this.panel_ChucNang.Size = new System.Drawing.Size(489, 65);
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
            this.btn_Lammoi.Location = new System.Drawing.Point(369, 14);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(97, 37);
            this.btn_Lammoi.TabIndex = 50;
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
            this.btn_Xoa.Location = new System.Drawing.Point(253, 14);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 37);
            this.btn_Xoa.TabIndex = 49;
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
            this.btn_Sua.Location = new System.Drawing.Point(143, 14);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(85, 37);
            this.btn_Sua.TabIndex = 48;
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
            this.btn_Them.Location = new System.Drawing.Point(23, 14);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(85, 37);
            this.btn_Them.TabIndex = 47;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.Black;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel_ThongTin
            // 
            this.panel_ThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_ThongTin.BorderColor = System.Drawing.Color.White;
            this.panel_ThongTin.Controls.Add(this.cbo_TrangThai);
            this.panel_ThongTin.Controls.Add(this.txt_QuocGia);
            this.panel_ThongTin.Controls.Add(this.txt_KyHieu);
            this.panel_ThongTin.Controls.Add(this.txt_TenLoaiTien);
            this.panel_ThongTin.Controls.Add(this.txt_MaLoaiTien);
            this.panel_ThongTin.Controls.Add(this.label6);
            this.panel_ThongTin.Controls.Add(this.label2);
            this.panel_ThongTin.Controls.Add(this.label3);
            this.panel_ThongTin.Controls.Add(this.label5);
            this.panel_ThongTin.Controls.Add(this.label4);
            this.panel_ThongTin.Location = new System.Drawing.Point(1080, 169);
            this.panel_ThongTin.Name = "panel_ThongTin";
            this.panel_ThongTin.Radius = 20;
            this.panel_ThongTin.Size = new System.Drawing.Size(489, 290);
            this.panel_ThongTin.TabIndex = 45;
            this.panel_ThongTin.Thickness = 5F;
            // 
            // cbo_TrangThai
            // 
            this.cbo_TrangThai.BackColor = System.Drawing.Color.Silver;
            this.cbo_TrangThai.BorderColor = System.Drawing.Color.Black;
            this.cbo_TrangThai.BorderSize = 2;
            this.cbo_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_TrangThai.ForeColor = System.Drawing.Color.Black;
            this.cbo_TrangThai.IconColor = System.Drawing.Color.Black;
            this.cbo_TrangThai.Items.AddRange(new object[] {
            "Còn Hoạt Động",
            "Ngưng Hoạt Động"});
            this.cbo_TrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_TrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_TrangThai.Location = new System.Drawing.Point(144, 238);
            this.cbo_TrangThai.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_TrangThai.Name = "cbo_TrangThai";
            this.cbo_TrangThai.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_TrangThai.Size = new System.Drawing.Size(331, 30);
            this.cbo_TrangThai.TabIndex = 49;
            // 
            // txt_QuocGia
            // 
            this.txt_QuocGia.BackColor = System.Drawing.Color.Silver;
            this.txt_QuocGia.BorderColor = System.Drawing.Color.Black;
            this.txt_QuocGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_QuocGia.BorderRadius = 5;
            this.txt_QuocGia.BorderSize = 2;
            this.txt_QuocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuocGia.ForeColor = System.Drawing.Color.Black;
            this.txt_QuocGia.Location = new System.Drawing.Point(144, 181);
            this.txt_QuocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_QuocGia.Multiline = false;
            this.txt_QuocGia.Name = "txt_QuocGia";
            this.txt_QuocGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_QuocGia.PasswordChar = false;
            this.txt_QuocGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_QuocGia.PlaceholderText = "";
            this.txt_QuocGia.Size = new System.Drawing.Size(332, 31);
            this.txt_QuocGia.TabIndex = 52;
            this.txt_QuocGia.UnderlinedStyle = false;
            // 
            // txt_KyHieu
            // 
            this.txt_KyHieu.BackColor = System.Drawing.Color.Silver;
            this.txt_KyHieu.BorderColor = System.Drawing.Color.Black;
            this.txt_KyHieu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_KyHieu.BorderRadius = 5;
            this.txt_KyHieu.BorderSize = 2;
            this.txt_KyHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KyHieu.ForeColor = System.Drawing.Color.Black;
            this.txt_KyHieu.Location = new System.Drawing.Point(144, 124);
            this.txt_KyHieu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_KyHieu.Multiline = false;
            this.txt_KyHieu.Name = "txt_KyHieu";
            this.txt_KyHieu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_KyHieu.PasswordChar = false;
            this.txt_KyHieu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_KyHieu.PlaceholderText = "";
            this.txt_KyHieu.Size = new System.Drawing.Size(332, 31);
            this.txt_KyHieu.TabIndex = 51;
            this.txt_KyHieu.UnderlinedStyle = false;
            // 
            // txt_TenLoaiTien
            // 
            this.txt_TenLoaiTien.BackColor = System.Drawing.Color.Silver;
            this.txt_TenLoaiTien.BorderColor = System.Drawing.Color.Black;
            this.txt_TenLoaiTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenLoaiTien.BorderRadius = 5;
            this.txt_TenLoaiTien.BorderSize = 2;
            this.txt_TenLoaiTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoaiTien.ForeColor = System.Drawing.Color.Black;
            this.txt_TenLoaiTien.Location = new System.Drawing.Point(144, 68);
            this.txt_TenLoaiTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenLoaiTien.Multiline = false;
            this.txt_TenLoaiTien.Name = "txt_TenLoaiTien";
            this.txt_TenLoaiTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenLoaiTien.PasswordChar = false;
            this.txt_TenLoaiTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenLoaiTien.PlaceholderText = "";
            this.txt_TenLoaiTien.Size = new System.Drawing.Size(332, 31);
            this.txt_TenLoaiTien.TabIndex = 50;
            this.txt_TenLoaiTien.UnderlinedStyle = false;
            // 
            // txt_MaLoaiTien
            // 
            this.txt_MaLoaiTien.BackColor = System.Drawing.Color.Silver;
            this.txt_MaLoaiTien.BorderColor = System.Drawing.Color.Black;
            this.txt_MaLoaiTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaLoaiTien.BorderRadius = 5;
            this.txt_MaLoaiTien.BorderSize = 2;
            this.txt_MaLoaiTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLoaiTien.ForeColor = System.Drawing.Color.Black;
            this.txt_MaLoaiTien.Location = new System.Drawing.Point(144, 18);
            this.txt_MaLoaiTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLoaiTien.Multiline = false;
            this.txt_MaLoaiTien.Name = "txt_MaLoaiTien";
            this.txt_MaLoaiTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaLoaiTien.PasswordChar = false;
            this.txt_MaLoaiTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaLoaiTien.PlaceholderText = "";
            this.txt_MaLoaiTien.Size = new System.Drawing.Size(332, 31);
            this.txt_MaLoaiTien.TabIndex = 49;
            this.txt_MaLoaiTien.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mã Loại Tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ký Hiệu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Trạng Thái:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quốc Gia:";
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
            this.gb_Timkiem.Location = new System.Drawing.Point(12, 52);
            this.gb_Timkiem.Name = "gb_Timkiem";
            this.gb_Timkiem.Radius = 20;
            this.gb_Timkiem.Size = new System.Drawing.Size(984, 70);
            this.gb_Timkiem.TabIndex = 43;
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
            this.txt_GiaTri.Location = new System.Drawing.Point(579, 23);
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
            "Mã Loại Tiền",
            "Tên Loại Tiền",
            "Quốc Gia"});
            this.cbo_PhuongThuc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_PhuongThuc.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_PhuongThuc.Location = new System.Drawing.Point(183, 24);
            this.cbo_PhuongThuc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_PhuongThuc.Name = "cbo_PhuongThuc";
            this.cbo_PhuongThuc.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_PhuongThuc.Size = new System.Drawing.Size(315, 30);
            this.cbo_PhuongThuc.TabIndex = 48;
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
            this.btn_Tim.Location = new System.Drawing.Point(900, 22);
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
            this.label11.Location = new System.Drawing.Point(17, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Phương Thức Tìm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(504, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Giá Trị:";
            // 
            // Frm_LoaiTien
            // 
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel_DanhSach);
            this.Controls.Add(this.panel_ChucNang);
            this.Controls.Add(this.panel_ThongTin);
            this.Controls.Add(this.gb_Timkiem);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_LoaiTien";
            this.Text = "Quản Trị Loại Tiền";
            this.Load += new System.EventHandler(this.Frm_LoaiTien_Load);
            this.Resize += new System.EventHandler(this.Frm_LoaiTien_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_X)).EndInit();
            this.panel_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiTien)).EndInit();
            this.panel_ChucNang.ResumeLayout(false);
            this.panel_ThongTin.ResumeLayout(false);
            this.panel_ThongTin.PerformLayout();
            this.gb_Timkiem.ResumeLayout(false);
            this.gb_Timkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.PictureBox pb_DarkMode;
        private System.Windows.Forms.PictureBox pb_Them;
        private System.Windows.Forms.PictureBox pb_TimKiem;
        private System.Windows.Forms.PictureBox pb_Minimize;
        private System.Windows.Forms.PictureBox pb_X;
        private Controls.Rounded_Panel gb_Timkiem;
        private Controls.Rounded_Panel panel_ThongTin;
        private System.Windows.Forms.Label label6;
        private Controls.Rounded_Panel panel_ChucNang;
        private Controls.RJButton btn_Lammoi;
        private Controls.RJButton btn_Xoa;
        private Controls.RJButton btn_Sua;
        private Controls.RJButton btn_Them;
        private Controls.RJButton btn_Tim;
        private Controls.Rounded_Panel panel_DanhSach;
        private System.Windows.Forms.Timer timer_TimKiem;
        private System.Windows.Forms.Timer timer_ChucNang;
        private Controls.RJComboBox cbo_PhuongThuc;
        private Controls.RJTextBox txt_GiaTri;
        private Controls.RJTextBox txt_QuocGia;
        private Controls.RJTextBox txt_KyHieu;
        private Controls.RJTextBox txt_TenLoaiTien;
        private Controls.RJTextBox txt_MaLoaiTien;
        private Controls.RJComboBox cbo_TrangThai;
        private System.Windows.Forms.DataGridView dgv_LoaiTien;
    }
}
