namespace GUI
{
    partial class Frm_Report_PhongBan
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
            this.gb_DanhSachPhongBan = new System.Windows.Forms.GroupBox();
            this.crv_PhongBan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report_PhongBan1 = new GUI.Report.Report_PhongBan();
            this.gb_TimKiem.SuspendLayout();
            this.gb_DanhSachPhongBan.SuspendLayout();
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
            this.gb_TimKiem.Location = new System.Drawing.Point(3, 5);
            this.gb_TimKiem.Margin = new System.Windows.Forms.Padding(5);
            this.gb_TimKiem.Name = "gb_TimKiem";
            this.gb_TimKiem.Padding = new System.Windows.Forms.Padding(5);
            this.gb_TimKiem.Size = new System.Drawing.Size(1219, 71);
            this.gb_TimKiem.TabIndex = 3;
            this.gb_TimKiem.TabStop = false;
            this.gb_TimKiem.Text = "Tìm Kiếm";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Location = new System.Drawing.Point(1014, 24);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(146, 32);
            this.btn_LamMoi.TabIndex = 25;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(933, 25);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 32);
            this.btn_Tim.TabIndex = 24;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_GiaTri
            // 
            this.txt_GiaTri.Location = new System.Drawing.Point(603, 25);
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Size = new System.Drawing.Size(315, 35);
            this.txt_GiaTri.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "Phương Thức Tìm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(511, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 26);
            this.label12.TabIndex = 21;
            this.label12.Text = "Giá Trị";
            // 
            // cbo_PhuongThuc
            // 
            this.cbo_PhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PhuongThuc.FormattingEnabled = true;
            this.cbo_PhuongThuc.Items.AddRange(new object[] {
            "Mã Phòng Ban",
            "Tên Phòng Ban"});
            this.cbo_PhuongThuc.Location = new System.Drawing.Point(233, 29);
            this.cbo_PhuongThuc.Name = "cbo_PhuongThuc";
            this.cbo_PhuongThuc.Size = new System.Drawing.Size(272, 34);
            this.cbo_PhuongThuc.TabIndex = 23;
            // 
            // gb_DanhSachPhongBan
            // 
            this.gb_DanhSachPhongBan.Controls.Add(this.crv_PhongBan);
            this.gb_DanhSachPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_DanhSachPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DanhSachPhongBan.Location = new System.Drawing.Point(0, 84);
            this.gb_DanhSachPhongBan.Name = "gb_DanhSachPhongBan";
            this.gb_DanhSachPhongBan.Size = new System.Drawing.Size(1227, 686);
            this.gb_DanhSachPhongBan.TabIndex = 4;
            this.gb_DanhSachPhongBan.TabStop = false;
            this.gb_DanhSachPhongBan.Text = "Danh Sách Phòng Ban";
            // 
            // crv_PhongBan
            // 
            this.crv_PhongBan.ActiveViewIndex = 0;
            this.crv_PhongBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_PhongBan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_PhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_PhongBan.Location = new System.Drawing.Point(3, 30);
            this.crv_PhongBan.Margin = new System.Windows.Forms.Padding(5);
            this.crv_PhongBan.Name = "crv_PhongBan";
            this.crv_PhongBan.ReportSource = this.Report_PhongBan1;
            this.crv_PhongBan.Size = new System.Drawing.Size(1221, 653);
            this.crv_PhongBan.TabIndex = 0;
            this.crv_PhongBan.ToolPanelWidth = 333;
            // 
            // Frm_Report_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 770);
            this.Controls.Add(this.gb_DanhSachPhongBan);
            this.Controls.Add(this.gb_TimKiem);
            this.Name = "Frm_Report_PhongBan";
            this.Text = "Frm_Report_PhongBan";
            this.Load += new System.EventHandler(this.Frm_Report_PhongBan_Load);
            this.gb_TimKiem.ResumeLayout(false);
            this.gb_TimKiem.PerformLayout();
            this.gb_DanhSachPhongBan.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gb_DanhSachPhongBan;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_PhongBan;
        private Report.Report_PhongBan Report_PhongBan1;
    }
}