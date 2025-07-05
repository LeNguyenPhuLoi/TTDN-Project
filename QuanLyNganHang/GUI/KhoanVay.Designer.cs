namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoanVay));
            this.txtMaLaiSuat = new System.Windows.Forms.TextBox();
            this.dgvLaiSuat = new System.Windows.Forms.DataGridView();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoTienVay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvKhoanVay = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lbSoThang = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienThang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpThoiHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVay = new System.Windows.Forms.DateTimePicker();
            this.txtMaVay = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaLaiSuat
            // 
            this.txtMaLaiSuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLaiSuat.Location = new System.Drawing.Point(607, 125);
            this.txtMaLaiSuat.Name = "txtMaLaiSuat";
            this.txtMaLaiSuat.Size = new System.Drawing.Size(291, 30);
            this.txtMaLaiSuat.TabIndex = 18;
            this.txtMaLaiSuat.TextChanged += new System.EventHandler(this.txtMaLaiSuat_TextChanged);
            // 
            // dgvLaiSuat
            // 
            this.dgvLaiSuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLaiSuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaiSuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaiSuat.Location = new System.Drawing.Point(437, 162);
            this.dgvLaiSuat.MultiSelect = false;
            this.dgvLaiSuat.Name = "dgvLaiSuat";
            this.dgvLaiSuat.ReadOnly = true;
            this.dgvLaiSuat.RowHeadersWidth = 51;
            this.dgvLaiSuat.Size = new System.Drawing.Size(461, 124);
            this.dgvLaiSuat.TabIndex = 17;
            this.dgvLaiSuat.Click += new System.EventHandler(this.dgvLaiSuat_Click);
            // 
            // cboMaKH
            // 
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(186, 204);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(224, 30);
            this.cboMaKH.TabIndex = 15;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(933, 81);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 46);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(933, 134);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 46);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.Location = new System.Drawing.Point(933, 186);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(88, 37);
            this.btnHoanTac.TabIndex = 12;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(933, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 46);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách Hàng:";
            // 
            // txtSoTienVay
            // 
            this.txtSoTienVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienVay.Location = new System.Drawing.Point(186, 67);
            this.txtSoTienVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTienVay.Name = "txtSoTienVay";
            this.txtSoTienVay.Size = new System.Drawing.Size(200, 30);
            this.txtSoTienVay.TabIndex = 1;
            this.txtSoTienVay.TextChanged += new System.EventHandler(this.txtSoTienVay_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(431, 53);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thời hạn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Lãi Suất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày vay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Vay:";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(260, 345);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(303, 30);
            this.txtTim.TabIndex = 33;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(57, 342);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(195, 33);
            this.lbTim.TabIndex = 32;
            this.lbTim.Text = "Tìm Khoản Vay:";
            // 
            // dgvKhoanVay
            // 
            this.dgvKhoanVay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhoanVay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanVay.Location = new System.Drawing.Point(12, 395);
            this.dgvKhoanVay.MultiSelect = false;
            this.dgvKhoanVay.Name = "dgvKhoanVay";
            this.dgvKhoanVay.ReadOnly = true;
            this.dgvKhoanVay.RowHeadersWidth = 62;
            this.dgvKhoanVay.Size = new System.Drawing.Size(1072, 456);
            this.dgvKhoanVay.TabIndex = 31;
            this.dgvKhoanVay.Click += new System.EventHandler(this.dgvKhoanVay_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.lbSoThang);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.txtTienThang);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtTong);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.dtpThoiHan);
            this.pnlMain.Controls.Add(this.dtpNgayVay);
            this.pnlMain.Controls.Add(this.txtMaVay);
            this.pnlMain.Controls.Add(this.cboTrangThai);
            this.pnlMain.Controls.Add(this.txtMaLaiSuat);
            this.pnlMain.Controls.Add(this.dgvLaiSuat);
            this.pnlMain.Controls.Add(this.cboMaKH);
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnHoanTac);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtSoTienVay);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(18, 16);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1072, 302);
            this.pnlMain.TabIndex = 30;
            // 
            // lbSoThang
            // 
            this.lbSoThang.AutoSize = true;
            this.lbSoThang.Location = new System.Drawing.Point(445, 86);
            this.lbSoThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoThang.Name = "lbSoThang";
            this.lbSoThang.Size = new System.Drawing.Size(0, 16);
            this.lbSoThang.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 33);
            this.label10.TabIndex = 28;
            this.label10.Text = "Số Tháng:";
            // 
            // txtTienThang
            // 
            this.txtTienThang.Enabled = false;
            this.txtTienThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThang.Location = new System.Drawing.Point(186, 158);
            this.txtTienThang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThang.Name = "txtTienThang";
            this.txtTienThang.Size = new System.Drawing.Size(200, 30);
            this.txtTienThang.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 33);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tiền Tháng:";
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(186, 111);
            this.txtTong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(200, 30);
            this.txtTong.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tổng Tiền:";
            // 
            // dtpThoiHan
            // 
            this.dtpThoiHan.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiHan.Location = new System.Drawing.Point(607, 53);
            this.dtpThoiHan.MaxDate = new System.DateTime(2999, 11, 11, 0, 0, 0, 0);
            this.dtpThoiHan.Name = "dtpThoiHan";
            this.dtpThoiHan.Size = new System.Drawing.Size(233, 30);
            this.dtpThoiHan.TabIndex = 22;
            this.dtpThoiHan.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.dtpThoiHan.ValueChanged += new System.EventHandler(this.dtpThoiHan_ValueChanged);
            // 
            // dtpNgayVay
            // 
            this.dtpNgayVay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayVay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVay.Location = new System.Drawing.Point(607, 23);
            this.dtpNgayVay.MaxDate = new System.DateTime(2999, 6, 12, 0, 0, 0, 0);
            this.dtpNgayVay.Name = "dtpNgayVay";
            this.dtpNgayVay.Size = new System.Drawing.Size(233, 30);
            this.dtpNgayVay.TabIndex = 21;
            this.dtpNgayVay.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            this.dtpNgayVay.ValueChanged += new System.EventHandler(this.dtpNgayVay_ValueChanged);
            // 
            // txtMaVay
            // 
            this.txtMaVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVay.Location = new System.Drawing.Point(186, 24);
            this.txtMaVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaVay.Name = "txtMaVay";
            this.txtMaVay.Size = new System.Drawing.Size(200, 30);
            this.txtMaVay.TabIndex = 20;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang vay",
            "Đã trả xong",
            "Còn nợ"});
            this.cboTrangThai.Location = new System.Drawing.Point(186, 253);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(224, 30);
            this.cboTrangThai.TabIndex = 19;
            // 
            // frmKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 578);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.dgvKhoanVay);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhoanVay";
            this.Text = "Quản Lý Khoản Vay";
            this.Load += new System.EventHandler(this.KhoanVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaiSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaLaiSuat;
        private System.Windows.Forms.DataGridView dgvLaiSuat;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTienVay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.DataGridView dgvKhoanVay;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtMaVay;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.DateTimePicker dtpThoiHan;
        private System.Windows.Forms.DateTimePicker dtpNgayVay;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTienThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSoThang;
        private System.Windows.Forms.Label label10;
    }
}