﻿namespace GUI
{
    partial class frmKhoanVay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoanVay));
            this.txtMaLaiSuat = new System.Windows.Forms.TextBox();
            this.dgvLaiSuat = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvKhoanVay = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtTienThang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoTienVay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaVay = new System.Windows.Forms.TextBox();
            this.lbSoThang = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpThoiHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVay = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaLaiSuat
            // 
            this.txtMaLaiSuat.AllowDrop = true;
            this.txtMaLaiSuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLaiSuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLaiSuat.Location = new System.Drawing.Point(203, 120);
            this.txtMaLaiSuat.Name = "txtMaLaiSuat";
            this.txtMaLaiSuat.Size = new System.Drawing.Size(365, 30);
            this.txtMaLaiSuat.TabIndex = 18;
            this.txtMaLaiSuat.TextChanged += new System.EventHandler(this.txtMaLaiSuat_TextChanged);
            // 
            // dgvLaiSuat
            // 
            this.dgvLaiSuat.AllowDrop = true;
            this.dgvLaiSuat.AllowUserToResizeColumns = false;
            this.dgvLaiSuat.AllowUserToResizeRows = false;
            this.dgvLaiSuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaiSuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaiSuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaiSuat.Location = new System.Drawing.Point(3, 0);
            this.dgvLaiSuat.MultiSelect = false;
            this.dgvLaiSuat.Name = "dgvLaiSuat";
            this.dgvLaiSuat.ReadOnly = true;
            this.dgvLaiSuat.RowHeadersVisible = false;
            this.dgvLaiSuat.RowHeadersWidth = 51;
            this.dgvLaiSuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaiSuat.Size = new System.Drawing.Size(800, 123);
            this.dgvLaiSuat.TabIndex = 17;
            this.dgvLaiSuat.Click += new System.EventHandler(this.dgvLaiSuat_Click);
            // 
            // btnSua
            // 
            this.btnSua.AllowDrop = true;
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(217, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 49);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AllowDrop = true;
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(357, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 49);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.AllowDrop = true;
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTac.BackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHoanTac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHoanTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.Location = new System.Drawing.Point(492, 22);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(112, 49);
            this.btnHoanTac.TabIndex = 12;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = false;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(86, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 49);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thời hạn:";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Lãi Suất:";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày vay:";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(240, 401);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(414, 30);
            this.txtTim.TabIndex = 33;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(37, 398);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(195, 33);
            this.lbTim.TabIndex = 32;
            this.lbTim.Text = "Tìm Khoản Vay:";
            // 
            // dgvKhoanVay
            // 
            this.dgvKhoanVay.AllowUserToResizeColumns = false;
            this.dgvKhoanVay.AllowUserToResizeRows = false;
            this.dgvKhoanVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvKhoanVay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanVay.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhoanVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanVay.Location = new System.Drawing.Point(3, 3);
            this.dgvKhoanVay.MultiSelect = false;
            this.dgvKhoanVay.Name = "dgvKhoanVay";
            this.dgvKhoanVay.ReadOnly = true;
            this.dgvKhoanVay.RowHeadersVisible = false;
            this.dgvKhoanVay.RowHeadersWidth = 62;
            this.dgvKhoanVay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhoanVay.Size = new System.Drawing.Size(2000, 215);
            this.dgvKhoanVay.TabIndex = 31;
            this.dgvKhoanVay.Click += new System.EventHandler(this.dgvKhoanVay_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.txtTienThang);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtTong);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.cboTrangThai);
            this.pnlMain.Controls.Add(this.cboMaKH);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtSoTienVay);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtMaVay);
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(601, 300);
            this.pnlMain.TabIndex = 30;
            // 
            // txtTienThang
            // 
            this.txtTienThang.AllowDrop = true;
            this.txtTienThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienThang.Enabled = false;
            this.txtTienThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThang.Location = new System.Drawing.Point(189, 153);
            this.txtTienThang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThang.Name = "txtTienThang";
            this.txtTienThang.Size = new System.Drawing.Size(328, 30);
            this.txtTienThang.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 33);
            this.label9.TabIndex = 36;
            this.label9.Text = "Tiền Tháng:";
            // 
            // txtTong
            // 
            this.txtTong.AllowDrop = true;
            this.txtTong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(189, 106);
            this.txtTong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(328, 30);
            this.txtTong.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 33);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tổng Tiền:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.AllowDrop = true;
            this.cboTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang vay",
            "Đã trả xong",
            "Còn nợ"});
            this.cboTrangThai.Location = new System.Drawing.Point(189, 248);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(328, 30);
            this.cboTrangThai.TabIndex = 33;
            // 
            // cboMaKH
            // 
            this.cboMaKH.AllowDrop = true;
            this.cboMaKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(189, 199);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(328, 30);
            this.cboMaKH.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 33);
            this.label7.TabIndex = 27;
            this.label7.Text = "Trạng Thái:";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 33);
            this.label6.TabIndex = 28;
            this.label6.Text = "Khách Hàng:";
            // 
            // txtSoTienVay
            // 
            this.txtSoTienVay.AllowDrop = true;
            this.txtSoTienVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoTienVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienVay.Location = new System.Drawing.Point(189, 62);
            this.txtSoTienVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTienVay.Name = "txtSoTienVay";
            this.txtSoTienVay.Size = new System.Drawing.Size(328, 30);
            this.txtSoTienVay.TabIndex = 31;
            this.txtSoTienVay.Leave += new System.EventHandler(this.txtSoTienVay_Leave);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 33);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã Vay:";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số tiền:";
            // 
            // txtMaVay
            // 
            this.txtMaVay.AllowDrop = true;
            this.txtMaVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVay.Location = new System.Drawing.Point(189, 18);
            this.txtMaVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaVay.Name = "txtMaVay";
            this.txtMaVay.Size = new System.Drawing.Size(328, 30);
            this.txtMaVay.TabIndex = 20;
            // 
            // lbSoThang
            // 
            this.lbSoThang.AllowDrop = true;
            this.lbSoThang.AutoSize = true;
            this.lbSoThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoThang.Location = new System.Drawing.Point(207, 89);
            this.lbSoThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoThang.Name = "lbSoThang";
            this.lbSoThang.Size = new System.Drawing.Size(20, 22);
            this.lbSoThang.TabIndex = 29;
            this.lbSoThang.Text = "0";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 33);
            this.label10.TabIndex = 28;
            this.label10.Text = "Số Tháng:";
            // 
            // dtpThoiHan
            // 
            this.dtpThoiHan.AllowDrop = true;
            this.dtpThoiHan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpThoiHan.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiHan.Location = new System.Drawing.Point(203, 52);
            this.dtpThoiHan.MaxDate = new System.DateTime(2999, 11, 11, 0, 0, 0, 0);
            this.dtpThoiHan.Name = "dtpThoiHan";
            this.dtpThoiHan.Size = new System.Drawing.Size(233, 30);
            this.dtpThoiHan.TabIndex = 22;
            this.dtpThoiHan.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.dtpThoiHan.ValueChanged += new System.EventHandler(this.dtpThoiHan_ValueChanged);
            // 
            // dtpNgayVay
            // 
            this.dtpNgayVay.AllowDrop = true;
            this.dtpNgayVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayVay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVay.Location = new System.Drawing.Point(203, 18);
            this.dtpNgayVay.MaxDate = new System.DateTime(2999, 6, 12, 0, 0, 0, 0);
            this.dtpNgayVay.Name = "dtpNgayVay";
            this.dtpNgayVay.Size = new System.Drawing.Size(233, 30);
            this.dtpNgayVay.TabIndex = 21;
            this.dtpNgayVay.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.dtpNgayVay.ValueChanged += new System.EventHandler(this.dtpNgayVay_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1214, 307);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbSoThang);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpThoiHan);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpNgayVay);
            this.panel1.Controls.Add(this.txtMaLaiSuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(610, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 300);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dgvLaiSuat);
            this.panel2.Location = new System.Drawing.Point(33, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 147);
            this.panel2.TabIndex = 30;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1116, 22);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 49);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1244, 50);
            this.label5.TabIndex = 45;
            this.label5.Text = "QUẢN TRỊ KHOẢN VAY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.dgvKhoanVay);
            this.panel3.Location = new System.Drawing.Point(15, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1211, 242);
            this.panel3.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnHoanTac);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 685);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1244, 86);
            this.panel4.TabIndex = 47;
            // 
            // frmKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 771);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhoanVay";
            this.Text = "Quản Lý Khoản Vay";
            this.Load += new System.EventHandler(this.KhoanVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaiSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaLaiSuat;
        private System.Windows.Forms.DataGridView dgvLaiSuat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.DataGridView dgvKhoanVay;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtMaVay;
        private System.Windows.Forms.DateTimePicker dtpThoiHan;
        private System.Windows.Forms.DateTimePicker dtpNgayVay;
        private System.Windows.Forms.Label lbSoThang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTienThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTienVay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}