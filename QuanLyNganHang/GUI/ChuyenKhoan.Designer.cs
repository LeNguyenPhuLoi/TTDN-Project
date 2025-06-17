namespace GUI
{
    partial class frmChuyenKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenKhoan));
            this.btnInDS = new System.Windows.Forms.Button();
            this.cboMaTKGui = new System.Windows.Forms.ComboBox();
            this.dtpNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHoanTac = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaTKNhan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaCK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTim = new System.Windows.Forms.Label();
            this.dgvChuyenKhoan = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInDS
            // 
            this.btnInDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDS.Location = new System.Drawing.Point(689, 770);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(91, 35);
            this.btnInDS.TabIndex = 35;
            this.btnInDS.Text = "In DS kho";
            this.btnInDS.UseVisualStyleBackColor = true;
            // 
            // cboMaTKGui
            // 
            this.cboMaTKGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTKGui.FormattingEnabled = true;
            this.cboMaTKGui.Location = new System.Drawing.Point(190, 96);
            this.cboMaTKGui.Name = "cboMaTKGui";
            this.cboMaTKGui.Size = new System.Drawing.Size(182, 24);
            this.cboMaTKGui.TabIndex = 15;
            // 
            // dtpNgayChuyen
            // 
            this.dtpNgayChuyen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChuyen.Location = new System.Drawing.Point(531, 26);
            this.dtpNgayChuyen.MaxDate = new System.DateTime(9998, 6, 11, 0, 0, 0, 0);
            this.dtpNgayChuyen.Name = "dtpNgayChuyen";
            this.dtpNgayChuyen.Size = new System.Drawing.Size(180, 22);
            this.dtpNgayChuyen.TabIndex = 13;
            this.dtpNgayChuyen.Value = new System.DateTime(2025, 6, 11, 0, 0, 0, 0);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(131, 187);
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
            this.btnXoa.Location = new System.Drawing.Point(229, 187);
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
            this.btnHoanTac.Location = new System.Drawing.Point(327, 192);
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
            this.btnThem.Location = new System.Drawing.Point(33, 187);
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
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(182, 298);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(303, 22);
            this.txtTim.TabIndex = 34;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.txtNoiDung);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.cboMaTKNhan);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.txtSoTien);
            this.pnlMain.Controls.Add(this.cboMaTKGui);
            this.pnlMain.Controls.Add(this.dtpNgayChuyen);
            this.pnlMain.Controls.Add(this.btnSua);
            this.pnlMain.Controls.Add(this.btnXoa);
            this.pnlMain.Controls.Add(this.btnHoanTac);
            this.pnlMain.Controls.Add(this.btnThem);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.txtMaCK);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(770, 276);
            this.pnlMain.TabIndex = 31;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Location = new System.Drawing.Point(469, 59);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(242, 104);
            this.txtNoiDung.TabIndex = 23;
            this.txtNoiDung.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nội dung:";
            // 
            // cboMaTKNhan
            // 
            this.cboMaTKNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTKNhan.FormattingEnabled = true;
            this.cboMaTKNhan.Location = new System.Drawing.Point(190, 133);
            this.cboMaTKNhan.Name = "cboMaTKNhan";
            this.cboMaTKNhan.Size = new System.Drawing.Size(182, 24);
            this.cboMaTKNhan.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Tài Khoản Nhận:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(190, 61);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(142, 22);
            this.txtSoTien.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Tài Khoản Nhận:";
            // 
            // txtMaCK
            // 
            this.txtMaCK.Location = new System.Drawing.Point(190, 33);
            this.txtMaCK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCK.Name = "txtMaCK";
            this.txtMaCK.Size = new System.Drawing.Size(142, 22);
            this.txtMaCK.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Chuyển Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Chuyển Khoản:";
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Location = new System.Drawing.Point(42, 298);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(122, 16);
            this.lbTim.TabIndex = 33;
            this.lbTim.Text = "Tìm Chuyển Khoản:";
            // 
            // dgvChuyenKhoan
            // 
            this.dgvChuyenKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChuyenKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenKhoan.Location = new System.Drawing.Point(12, 330);
            this.dgvChuyenKhoan.MultiSelect = false;
            this.dgvChuyenKhoan.Name = "dgvChuyenKhoan";
            this.dgvChuyenKhoan.ReadOnly = true;
            this.dgvChuyenKhoan.RowHeadersWidth = 62;
            this.dgvChuyenKhoan.Size = new System.Drawing.Size(770, 434);
            this.dgvChuyenKhoan.TabIndex = 32;
            this.dgvChuyenKhoan.Click += new System.EventHandler(this.dgvChuyenKhoan_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(492, 298);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 36;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // frmChuyenKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.dgvChuyenKhoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChuyenKhoan";
            this.Text = "Quản Lý Chuyển Khoản";
            this.Load += new System.EventHandler(this.frmChuyenKhoan_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.ComboBox cboMaTKGui;
        private System.Windows.Forms.DateTimePicker dtpNgayChuyen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHoanTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaCK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaTKNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvChuyenKhoan;
        private System.Windows.Forms.Button btnTim;
    }
}