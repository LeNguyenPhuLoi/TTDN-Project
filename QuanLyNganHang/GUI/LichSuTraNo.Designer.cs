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
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvMaVay = new System.Windows.Forms.DataGridView();
            this.txtMaLichSu = new System.Windows.Forms.TextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtMaVay = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtTienTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaVay)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(350, 313);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(363, 30);
            this.txtTim.TabIndex = 41;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(30, 310);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(296, 33);
            this.lbTim.TabIndex = 40;
            this.lbTim.Text = "Lịch Sử Khách Hàng Trả:";
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(11, 366);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 62;
            this.dgvLichSu.Size = new System.Drawing.Size(1247, 403);
            this.dgvLichSu.TabIndex = 39;
            this.dgvLichSu.Click += new System.EventHandler(this.dgvLichSu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Lịch Sử:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền gốc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(562, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Vay";
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
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(74, 215);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 46);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHoanTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanTac.Location = new System.Drawing.Point(956, 26);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(122, 37);
            this.btnHoanTac.TabIndex = 12;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(215, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 46);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(362, 215);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(117, 46);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvMaVay
            // 
            this.dgvMaVay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMaVay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaVay.Location = new System.Drawing.Point(568, 127);
            this.dgvMaVay.MultiSelect = false;
            this.dgvMaVay.Name = "dgvMaVay";
            this.dgvMaVay.ReadOnly = true;
            this.dgvMaVay.RowHeadersWidth = 51;
            this.dgvMaVay.Size = new System.Drawing.Size(577, 134);
            this.dgvMaVay.TabIndex = 17;
            this.dgvMaVay.Click += new System.EventHandler(this.dgvMaVay_Click);
            // 
            // txtMaLichSu
            // 
            this.txtMaLichSu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLichSu.Location = new System.Drawing.Point(215, 33);
            this.txtMaLichSu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLichSu.Name = "txtMaLichSu";
            this.txtMaLichSu.Size = new System.Drawing.Size(225, 30);
            this.txtMaLichSu.TabIndex = 20;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(686, 33);
            this.dtpNgayTra.MaxDate = new System.DateTime(2999, 6, 12, 0, 0, 0, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(264, 30);
            this.dtpNgayTra.TabIndex = 21;
            this.dtpNgayTra.Value = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // txtMaVay
            // 
            this.txtMaVay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVay.Location = new System.Drawing.Point(686, 77);
            this.txtMaVay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaVay.Name = "txtMaVay";
            this.txtMaVay.Size = new System.Drawing.Size(290, 30);
            this.txtMaVay.TabIndex = 23;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.txtSoTien);
            this.pnlMain.Controls.Add(this.txtTienTra);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.txtMaVay);
            this.pnlMain.Controls.Add(this.dtpNgayTra);
            this.pnlMain.Controls.Add(this.txtMaLichSu);
            this.pnlMain.Controls.Add(this.dgvMaVay);
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnHoanTac);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(11, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1247, 277);
            this.pnlMain.TabIndex = 38;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Enabled = false;
            this.txtSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(215, 100);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(225, 30);
            this.txtSoTien.TabIndex = 28;
            // 
            // txtTienTra
            // 
            this.txtTienTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienTra.Location = new System.Drawing.Point(215, 162);
            this.txtTienTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienTra.Name = "txtTienTra";
            this.txtTienTra.Size = new System.Drawing.Size(225, 30);
            this.txtTienTra.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 33);
            this.label4.TabIndex = 24;
            this.label4.Text = "Số tiền trả:";
            // 
            // frmLichSuTraNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 590);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLichSuTraNo";
            this.Text = "Quản Lý Lịch Sử Trả Nợ:";
            this.Load += new System.EventHandler(this.frmLichSuTraNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaVay)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvMaVay;
        private System.Windows.Forms.TextBox txtMaLichSu;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.TextBox txtMaVay;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtTienTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTien;
    }
}