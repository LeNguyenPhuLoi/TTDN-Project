namespace GUI
{
    partial class frmKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhuyenMai));
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDKApDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Location = new System.Drawing.Point(156, 96);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(242, 104);
            this.txtNoiDung.TabIndex = 14;
            this.txtNoiDung.Text = "";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(541, 63);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(120, 22);
            this.dtNgayKetThuc.TabIndex = 13;
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBatDau.Location = new System.Drawing.Point(541, 30);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(120, 22);
            this.dtNgayBatDau.TabIndex = 13;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(419, 159);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 41);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Hoàn tác";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(744, 143);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 41);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(744, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 41);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(744, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 41);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày kết thúc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày bắt đầu:";
            // 
            // txtDKApDung
            // 
            this.txtDKApDung.Location = new System.Drawing.Point(541, 99);
            this.txtDKApDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtDKApDung.Name = "txtDKApDung";
            this.txtDKApDung.Size = new System.Drawing.Size(196, 22);
            this.txtDKApDung.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điều kiện áp dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nội dung:";
            // 
            // txtTenKM
            // 
            this.txtTenKM.Location = new System.Drawing.Point(156, 64);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(242, 22);
            this.txtTenKM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khuyến mãi:";
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(156, 32);
            this.txtMaKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(141, 22);
            this.txtMaKM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khuyến mãi:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(127, 256);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(303, 22);
            this.txtTim.TabIndex = 23;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Location = new System.Drawing.Point(12, 259);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(104, 16);
            this.lbTim.TabIndex = 22;
            this.lbTim.Text = "Tìm khuyến mãi:";
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(13, 291);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.RowHeadersWidth = 62;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(949, 365);
            this.dgvKhuyenMai.TabIndex = 21;
            this.dgvKhuyenMai.Click += new System.EventHandler(this.dgvKhuyenMai_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.txtNoiDung);
            this.pnlMain.Controls.Add(this.dtNgayKetThuc);
            this.pnlMain.Controls.Add(this.dtNgayBatDau);
            this.pnlMain.Controls.Add(this.btnNew);
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.txtDKApDung);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtTenKM);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.txtMaKM);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(12, 19);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(950, 219);
            this.pnlMain.TabIndex = 20;
            // 
            // frmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 675);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.dgvKhuyenMai);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhuyenMai";
            this.Text = "Quản Lý Khuyến Mãi";
            this.Load += new System.EventHandler(this.frmKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDKApDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.Panel pnlMain;
    }
}