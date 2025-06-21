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
            this.dtpThoiHan = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayVay = new System.Windows.Forms.DateTimePicker();
            this.txtMaVay = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaiSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaLaiSuat
            // 
            this.txtMaLaiSuat.Location = new System.Drawing.Point(445, 81);
            this.txtMaLaiSuat.Name = "txtMaLaiSuat";
            this.txtMaLaiSuat.Size = new System.Drawing.Size(304, 22);
            this.txtMaLaiSuat.TabIndex = 18;
            // 
            // dgvLaiSuat
            // 
            this.dgvLaiSuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLaiSuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaiSuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaiSuat.Location = new System.Drawing.Point(331, 117);
            this.dgvLaiSuat.MultiSelect = false;
            this.dgvLaiSuat.Name = "dgvLaiSuat";
            this.dgvLaiSuat.ReadOnly = true;
            this.dgvLaiSuat.RowHeadersWidth = 51;
            this.dgvLaiSuat.Size = new System.Drawing.Size(420, 153);
            this.dgvLaiSuat.TabIndex = 17;
            this.dgvLaiSuat.Click += new System.EventHandler(this.dgvLaiSuat_Click);
            // 
            // cboMaKH
            // 
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(122, 82);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(182, 24);
            this.cboMaKH.TabIndex = 15;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(212, 176);
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
            this.btnXoa.Location = new System.Drawing.Point(114, 176);
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
            this.btnHoanTac.Location = new System.Drawing.Point(663, 18);
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
            this.btnThem.Location = new System.Drawing.Point(16, 176);
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
            this.label5.Location = new System.Drawing.Point(359, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách Hàng:";
            // 
            // txtSoTienVay
            // 
            this.txtSoTienVay.Location = new System.Drawing.Point(98, 50);
            this.txtSoTienVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTienVay.Name = "txtSoTienVay";
            this.txtSoTienVay.Size = new System.Drawing.Size(142, 22);
            this.txtSoTienVay.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thời hạn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Lãi Suất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày vay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Vay:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(132, 299);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(303, 22);
            this.txtTim.TabIndex = 33;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Location = new System.Drawing.Point(14, 302);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(101, 16);
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
            this.dgvKhoanVay.Location = new System.Drawing.Point(18, 334);
            this.dgvKhoanVay.MultiSelect = false;
            this.dgvKhoanVay.Name = "dgvKhoanVay";
            this.dgvKhoanVay.ReadOnly = true;
            this.dgvKhoanVay.RowHeadersWidth = 62;
            this.dgvKhoanVay.Size = new System.Drawing.Size(770, 328);
            this.dgvKhoanVay.TabIndex = 31;
            this.dgvKhoanVay.Click += new System.EventHandler(this.dgvKhoanVay_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnlMain.Size = new System.Drawing.Size(770, 273);
            this.pnlMain.TabIndex = 30;
            // 
            // dtpThoiHan
            // 
            this.dtpThoiHan.CustomFormat = "dd/MM/yyyy";
            this.dtpThoiHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiHan.Location = new System.Drawing.Point(445, 49);
            this.dtpThoiHan.MaxDate = new System.DateTime(2999, 11, 11, 0, 0, 0, 0);
            this.dtpThoiHan.Name = "dtpThoiHan";
            this.dtpThoiHan.Size = new System.Drawing.Size(180, 22);
            this.dtpThoiHan.TabIndex = 22;
            this.dtpThoiHan.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // dtpNgayVay
            // 
            this.dtpNgayVay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVay.Location = new System.Drawing.Point(445, 19);
            this.dtpNgayVay.MaxDate = new System.DateTime(2999, 6, 12, 0, 0, 0, 0);
            this.dtpNgayVay.Name = "dtpNgayVay";
            this.dtpNgayVay.Size = new System.Drawing.Size(180, 22);
            this.dtpNgayVay.TabIndex = 21;
            this.dtpNgayVay.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // txtMaVay
            // 
            this.txtMaVay.Location = new System.Drawing.Point(98, 21);
            this.txtMaVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaVay.Name = "txtMaVay";
            this.txtMaVay.Size = new System.Drawing.Size(142, 22);
            this.txtMaVay.TabIndex = 20;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang vay",
            "Đã trả xong"});
            this.cboTrangThai.Location = new System.Drawing.Point(122, 120);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(182, 24);
            this.cboTrangThai.TabIndex = 19;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(442, 302);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 37;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // frmKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTim);
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
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtpThoiHan;
        private System.Windows.Forms.DateTimePicker dtpNgayVay;
    }
}