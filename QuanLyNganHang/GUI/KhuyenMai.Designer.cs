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
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDKApDung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(268, 296);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(409, 30);
            this.txtTim.TabIndex = 23;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(38, 293);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(202, 33);
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
            this.dgvKhuyenMai.Location = new System.Drawing.Point(13, 347);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.RowHeadersWidth = 62;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(1292, 309);
            this.dgvKhuyenMai.TabIndex = 21;
            this.dgvKhuyenMai.Click += new System.EventHandler(this.dgvKhuyenMai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khuyến mãi:";
            // 
            // txtMaKM
            // 
            this.txtMaKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKM.Location = new System.Drawing.Point(313, 38);
            this.txtMaKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(223, 30);
            this.txtMaKM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khuyến mãi:";
            // 
            // txtTenKM
            // 
            this.txtTenKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKM.Location = new System.Drawing.Point(313, 93);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(223, 30);
            this.txtTenKM.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nội dung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điều kiện áp dụng:";
            // 
            // txtDKApDung
            // 
            this.txtDKApDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDKApDung.Location = new System.Drawing.Point(902, 142);
            this.txtDKApDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtDKApDung.Name = "txtDKApDung";
            this.txtDKApDung.Size = new System.Drawing.Size(255, 30);
            this.txtDKApDung.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày bắt đầu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(673, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày kết thúc:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(658, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 41);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(973, 206);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 41);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(816, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 41);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(1136, 206);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 41);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Hoàn tác";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBatDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBatDau.Location = new System.Drawing.Point(901, 39);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(197, 30);
            this.dtNgayBatDau.TabIndex = 13;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(902, 88);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(196, 30);
            this.dtNgayKetThuc.TabIndex = 13;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(240, 143);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(296, 104);
            this.txtNoiDung.TabIndex = 14;
            this.txtNoiDung.Text = "";
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
            this.pnlMain.Size = new System.Drawing.Size(1293, 257);
            this.pnlMain.TabIndex = 20;
            // 
            // frmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 675);
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
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDKApDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Panel pnlMain;
    }
}