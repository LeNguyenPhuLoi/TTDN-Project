namespace GUI
{
    partial class frmApDungKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApDungKhuyenMai));
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvApDungKhuyenMai = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cboMaTK = new System.Windows.Forms.ComboBox();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.dtpNgayApDung = new System.Windows.Forms.DateTimePicker();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApDungKhuyenMai)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Location = new System.Drawing.Point(1115, 228);
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.Size = new System.Drawing.Size(115, 41);
            this.btnHoanTac.TabIndex = 13;
            this.btnHoanTac.Text = "Hoàn tác";
            this.btnHoanTac.UseVisualStyleBackColor = true;
            this.btnHoanTac.Click += new System.EventHandler(this.btnHoanTac_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1104, 158);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 41);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1104, 96);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 41);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1104, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 41);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Áp Dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Tài Khoản:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(253, 74);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(242, 30);
            this.txtMaKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khuyến Mãi:";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(235, 368);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(334, 30);
            this.txtTim.TabIndex = 28;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(27, 364);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(200, 33);
            this.lbTim.TabIndex = 27;
            this.lbTim.Text = "Tìm khách hàng:";
            this.lbTim.Click += new System.EventHandler(this.lbTim_Click);
            // 
            // dgvApDungKhuyenMai
            // 
            this.dgvApDungKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApDungKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApDungKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApDungKhuyenMai.Location = new System.Drawing.Point(25, 421);
            this.dgvApDungKhuyenMai.MultiSelect = false;
            this.dgvApDungKhuyenMai.Name = "dgvApDungKhuyenMai";
            this.dgvApDungKhuyenMai.ReadOnly = true;
            this.dgvApDungKhuyenMai.RowHeadersWidth = 62;
            this.dgvApDungKhuyenMai.Size = new System.Drawing.Size(1278, 263);
            this.dgvApDungKhuyenMai.TabIndex = 26;
            this.dgvApDungKhuyenMai.Click += new System.EventHandler(this.dgvApDungKhuyenMai_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.cboMaTK);
            this.pnlMain.Controls.Add(this.txtMaKM);
            this.pnlMain.Controls.Add(this.dtpNgayApDung);
            this.pnlMain.Controls.Add(this.dgvKH);
            this.pnlMain.Controls.Add(this.dgvKhuyenMai);
            this.pnlMain.Controls.Add(this.btnHoanTac);
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.txtMaKH);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(25, 22);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1279, 318);
            this.pnlMain.TabIndex = 25;
            // 
            // cboMaTK
            // 
            this.cboMaTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaTK.FormattingEnabled = true;
            this.cboMaTK.Location = new System.Drawing.Point(253, 28);
            this.cboMaTK.Name = "cboMaTK";
            this.cboMaTK.Size = new System.Drawing.Size(182, 30);
            this.cboMaTK.TabIndex = 24;
            // 
            // txtMaKM
            // 
            this.txtMaKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKM.Location = new System.Drawing.Point(797, 28);
            this.txtMaKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(272, 30);
            this.txtMaKM.TabIndex = 23;
            // 
            // dtpNgayApDung
            // 
            this.dtpNgayApDung.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayApDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayApDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayApDung.Location = new System.Drawing.Point(797, 241);
            this.dtpNgayApDung.MaxDate = new System.DateTime(2999, 6, 12, 0, 0, 0, 0);
            this.dtpNgayApDung.Name = "dtpNgayApDung";
            this.dtpNgayApDung.Size = new System.Drawing.Size(272, 30);
            this.dtpNgayApDung.TabIndex = 22;
            this.dtpNgayApDung.Value = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // dgvKH
            // 
            this.dgvKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(38, 123);
            this.dgvKH.MultiSelect = false;
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.Size = new System.Drawing.Size(457, 166);
            this.dgvKH.TabIndex = 19;
            this.dgvKH.Click += new System.EventHandler(this.dgvKH_Click);
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(590, 81);
            this.dgvKhuyenMai.MultiSelect = false;
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(479, 131);
            this.dgvKhuyenMai.TabIndex = 18;
            this.dgvKhuyenMai.Click += new System.EventHandler(this.dgvKhuyenMai_Click);
            // 
            // frmApDungKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 696);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.dgvApDungKhuyenMai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmApDungKhuyenMai";
            this.Text = "Áp Dụng Khuyến Mãi";
            this.Load += new System.EventHandler(this.frmApDungKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApDungKhuyenMai)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.DataGridView dgvApDungKhuyenMai;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.DateTimePicker dtpNgayApDung;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.ComboBox cboMaTK;
    }
}