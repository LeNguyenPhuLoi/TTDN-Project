namespace GUI
{
    partial class Frm_Report_GiaoDich
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
            this.gb_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_GiaTri = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_PhuongThuc = new System.Windows.Forms.ComboBox();
            this.gb_DanhSach = new System.Windows.Forms.GroupBox();
            this.crv_GiaoDich = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report_GiaoDich1 = new GUI.Report.Report_GiaoDich();
            this.gb_TimKiem.SuspendLayout();
            this.gb_DanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TimKiem
            // 
            this.gb_TimKiem.Controls.Add(this.btn_LamMoi);
            this.gb_TimKiem.Controls.Add(this.btn_Tim);
            this.gb_TimKiem.Controls.Add(this.txt_GiaTri);
            this.gb_TimKiem.Controls.Add(this.label11);
            this.gb_TimKiem.Controls.Add(this.label12);
            this.gb_TimKiem.Controls.Add(this.cbo_PhuongThuc);
            this.gb_TimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_TimKiem.Location = new System.Drawing.Point(14, 14);
            this.gb_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.gb_TimKiem.Name = "gb_TimKiem";
            this.gb_TimKiem.Padding = new System.Windows.Forms.Padding(5);
            this.gb_TimKiem.Size = new System.Drawing.Size(1077, 71);
            this.gb_TimKiem.TabIndex = 2;
            this.gb_TimKiem.TabStop = false;
            this.gb_TimKiem.Text = "Tìm Kiếm";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(974, 28);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(95, 32);
            this.btn_LamMoi.TabIndex = 25;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(893, 29);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 32);
            this.btn_Tim.TabIndex = 24;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_GiaTri
            // 
            this.txt_GiaTri.Location = new System.Drawing.Point(572, 30);
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Size = new System.Drawing.Size(315, 29);
            this.txt_GiaTri.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Phương Thức Tìm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(497, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Giá Trị";
            // 
            // cbo_PhuongThuc
            // 
            this.cbo_PhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PhuongThuc.FormattingEnabled = true;
            this.cbo_PhuongThuc.Items.AddRange(new object[] {
            "Mã Giao Dịch",
            "Số Tài Khoản",
            "Loại Giao Dịch"});
            this.cbo_PhuongThuc.Location = new System.Drawing.Point(176, 31);
            this.cbo_PhuongThuc.Name = "cbo_PhuongThuc";
            this.cbo_PhuongThuc.Size = new System.Drawing.Size(315, 30);
            this.cbo_PhuongThuc.TabIndex = 23;
            // 
            // gb_DanhSach
            // 
            this.gb_DanhSach.Controls.Add(this.crv_GiaoDich);
            this.gb_DanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_DanhSach.Location = new System.Drawing.Point(0, 93);
            this.gb_DanhSach.Name = "gb_DanhSach";
            this.gb_DanhSach.Size = new System.Drawing.Size(1333, 634);
            this.gb_DanhSach.TabIndex = 3;
            this.gb_DanhSach.TabStop = false;
            this.gb_DanhSach.Text = "Danh Sách Giao Dịch";
            // 
            // crv_GiaoDich
            // 
            this.crv_GiaoDich.ActiveViewIndex = 0;
            this.crv_GiaoDich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_GiaoDich.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_GiaoDich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_GiaoDich.Location = new System.Drawing.Point(3, 25);
            this.crv_GiaoDich.Margin = new System.Windows.Forms.Padding(5);
            this.crv_GiaoDich.Name = "crv_GiaoDich";
            this.crv_GiaoDich.ReportSource = this.Report_GiaoDich1;
            this.crv_GiaoDich.Size = new System.Drawing.Size(1327, 606);
            this.crv_GiaoDich.TabIndex = 0;
            this.crv_GiaoDich.ToolPanelWidth = 333;
            // 
            // Frm_Report_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.gb_DanhSach);
            this.Controls.Add(this.gb_TimKiem);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_Report_GiaoDich";
            this.Text = "Danh Sách Giao Dịch";
            this.Load += new System.EventHandler(this.Frm_Report_GiaoDich_Load);
            this.Resize += new System.EventHandler(this.Frm_Report_GiaoDich_Resize);
            this.gb_TimKiem.ResumeLayout(false);
            this.gb_TimKiem.PerformLayout();
            this.gb_DanhSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TimKiem;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_GiaTri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbo_PhuongThuc;
        private System.Windows.Forms.GroupBox gb_DanhSach;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_GiaoDich;
        private Report.Report_GiaoDich Report_GiaoDich1;
    }
}