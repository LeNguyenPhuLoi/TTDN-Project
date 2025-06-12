namespace GUI
{
    partial class frmLichSuTraNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuTraNo));
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvKhoanVay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoTienTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvLaiSuat = new System.Windows.Forms.DataGridView();
            this.txtMaLichSu = new System.Windows.Forms.TextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtMaVay = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaiSuat)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(504, 265);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 42;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(194, 266);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(303, 22);
            this.txtTim.TabIndex = 41;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Location = new System.Drawing.Point(7, 269);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(153, 16);
            this.lbTim.TabIndex = 40;
            this.lbTim.Text = "Lịch Sử Khách Hàng Trả:";
            // 
            // dgvKhoanVay
            // 
            this.dgvKhoanVay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhoanVay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanVay.Location = new System.Drawing.Point(11, 301);
            this.dgvKhoanVay.MultiSelect = false;
            this.dgvKhoanVay.Name = "dgvKhoanVay";
            this.dgvKhoanVay.ReadOnly = true;
            this.dgvKhoanVay.RowHeadersWidth = 62;
            this.dgvKhoanVay.Size = new System.Drawing.Size(770, 328);
            this.dgvKhoanVay.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Lịch Sử:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Vay";
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.Location = new System.Drawing.Point(114, 62);
            this.txtSoTienTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Size = new System.Drawing.Size(190, 22);
            this.txtSoTienTra.TabIndex = 1;
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
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(16, 119);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 46);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTac.Location = new System.Drawing.Point(647, 11);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(88, 37);
            this.btnHoanTac.TabIndex = 12;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(114, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 46);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(212, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 46);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // dgvLaiSuat
            // 
            this.dgvLaiSuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLaiSuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaiSuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaiSuat.Location = new System.Drawing.Point(331, 95);
            this.dgvLaiSuat.MultiSelect = false;
            this.dgvLaiSuat.Name = "dgvLaiSuat";
            this.dgvLaiSuat.ReadOnly = true;
            this.dgvLaiSuat.RowHeadersWidth = 51;
            this.dgvLaiSuat.Size = new System.Drawing.Size(420, 122);
            this.dgvLaiSuat.TabIndex = 17;
            // 
            // txtMaLichSu
            // 
            this.txtMaLichSu.Location = new System.Drawing.Point(112, 22);
            this.txtMaLichSu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLichSu.Name = "txtMaLichSu";
            this.txtMaLichSu.Size = new System.Drawing.Size(190, 22);
            this.txtMaLichSu.TabIndex = 20;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(445, 19);
            this.dtpNgayTra.MaxDate = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(180, 22);
            this.dtpNgayTra.TabIndex = 21;
            this.dtpNgayTra.Value = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // txtMaVay
            // 
            this.txtMaVay.Location = new System.Drawing.Point(445, 62);
            this.txtMaVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaVay.Name = "txtMaVay";
            this.txtMaVay.Size = new System.Drawing.Size(290, 22);
            this.txtMaVay.TabIndex = 23;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.txtMaVay);
            this.pnlMain.Controls.Add(this.dtpNgayTra);
            this.pnlMain.Controls.Add(this.txtMaLichSu);
            this.pnlMain.Controls.Add(this.dgvLaiSuat);
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnHoanTac);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.txtSoTienTra);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(11, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(770, 242);
            this.pnlMain.TabIndex = 38;
            // 
            // frmLichSuTraNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.dgvKhoanVay);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLichSuTraNo";
            this.Text = "Quản Lý Lịch Sử Trả Nợ:";
            this.Load += new System.EventHandler(this.frmLichSuTraNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanVay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaiSuat)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.DataGridView dgvKhoanVay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoTienTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvLaiSuat;
        private System.Windows.Forms.TextBox txtMaLichSu;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.TextBox txtMaVay;
        private System.Windows.Forms.Panel pnlMain;
    }
}