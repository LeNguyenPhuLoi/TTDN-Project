namespace GUI
{
    partial class frmMainUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainUser));
            this.imgListBanners = new System.Windows.Forms.ImageList(this.components);
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnGD = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.thuNhỏToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phóngToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLichSu = new System.Windows.Forms.Button();
            this.tmrBannerLoop = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPhieuNo = new System.Windows.Forms.Button();
            this.btnPhieuVay = new System.Windows.Forms.Button();
            this.btnVay = new System.Windows.Forms.Button();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnCK = new System.Windows.Forms.Button();
            this.btnInBL = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.picBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListBanners
            // 
            this.imgListBanners.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBanners.ImageStream")));
            this.imgListBanners.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListBanners.Images.SetKeyName(0, "menu.png");
            this.imgListBanners.Images.SetKeyName(1, "banner1.jpg");
            this.imgListBanners.Images.SetKeyName(2, "banner2.jpg");
            this.imgListBanners.Images.SetKeyName(3, "banner3.jpg");
            this.imgListBanners.Images.SetKeyName(4, "banner4.jpg");
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(0, 846);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(225, 50);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnGD
            // 
            this.btnGD.FlatAppearance.BorderSize = 0;
            this.btnGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD.Image = ((System.Drawing.Image)(resources.GetObject("btnGD.Image")));
            this.btnGD.Location = new System.Drawing.Point(0, 398);
            this.btnGD.Name = "btnGD";
            this.btnGD.Size = new System.Drawing.Size(225, 50);
            this.btnGD.TabIndex = 4;
            this.btnGD.Text = "GIAO DỊCH";
            this.btnGD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD.UseVisualStyleBackColor = true;
            this.btnGD.Click += new System.EventHandler(this.btnGD_Click);
            // 
            // btnKH
            // 
            this.btnKH.FlatAppearance.BorderSize = 0;
            this.btnKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.Image")));
            this.btnKH.Location = new System.Drawing.Point(0, 566);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(225, 50);
            this.btnKH.TabIndex = 4;
            this.btnKH.Text = "KHÁCH HÀNG";
            this.btnKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.FlatAppearance.BorderSize = 0;
            this.btnKhuyenMai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuyenMai.Image = ((System.Drawing.Image)(resources.GetObject("btnKhuyenMai.Image")));
            this.btnKhuyenMai.Location = new System.Drawing.Point(0, 790);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(225, 50);
            this.btnKhuyenMai.TabIndex = 3;
            this.btnKhuyenMai.Text = "KHUYẾN MÃI";
            this.btnKhuyenMai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhuyenMai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // thuNhỏToolStripMenuItem
            // 
            this.thuNhỏToolStripMenuItem.Name = "thuNhỏToolStripMenuItem";
            this.thuNhỏToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.thuNhỏToolStripMenuItem.Text = "Thu nhỏ";
            // 
            // phóngToToolStripMenuItem
            // 
            this.phóngToToolStripMenuItem.Name = "phóngToToolStripMenuItem";
            this.phóngToToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.phóngToToolStripMenuItem.Text = "Phóng to";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phóngToToolStripMenuItem,
            this.thuNhỏToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 94);
            // 
            // btnLichSu
            // 
            this.btnLichSu.FlatAppearance.BorderSize = 0;
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSu.Image = ((System.Drawing.Image)(resources.GetObject("btnLichSu.Image")));
            this.btnLichSu.Location = new System.Drawing.Point(0, 454);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(226, 50);
            this.btnLichSu.TabIndex = 2;
            this.btnLichSu.Text = "LỊCH SỬ";
            this.btnLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLichSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnPhieuNo);
            this.pnlMenu.Controls.Add(this.btnPhieuVay);
            this.pnlMenu.Controls.Add(this.btnVay);
            this.pnlMenu.Controls.Add(this.btnBL);
            this.pnlMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlMenu.Controls.Add(this.btnCK);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnInBL);
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.btnGD);
            this.pnlMenu.Controls.Add(this.btnKH);
            this.pnlMenu.Controls.Add(this.btnKhuyenMai);
            this.pnlMenu.Controls.Add(this.btnLichSu);
            this.pnlMenu.Controls.Add(this.btnThoat);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(228, 975);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnPhieuNo
            // 
            this.btnPhieuNo.FlatAppearance.BorderSize = 0;
            this.btnPhieuNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNo.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuNo.Image")));
            this.btnPhieuNo.Location = new System.Drawing.Point(0, 734);
            this.btnPhieuNo.Name = "btnPhieuNo";
            this.btnPhieuNo.Size = new System.Drawing.Size(225, 50);
            this.btnPhieuNo.TabIndex = 13;
            this.btnPhieuNo.Text = "PHIẾU TRẢ NỢ";
            this.btnPhieuNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhieuNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhieuNo.UseVisualStyleBackColor = true;
            // 
            // btnPhieuVay
            // 
            this.btnPhieuVay.FlatAppearance.BorderSize = 0;
            this.btnPhieuVay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuVay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuVay.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuVay.Image")));
            this.btnPhieuVay.Location = new System.Drawing.Point(0, 678);
            this.btnPhieuVay.Name = "btnPhieuVay";
            this.btnPhieuVay.Size = new System.Drawing.Size(225, 50);
            this.btnPhieuVay.TabIndex = 12;
            this.btnPhieuVay.Text = "PHIẾU VAY";
            this.btnPhieuVay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhieuVay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhieuVay.UseVisualStyleBackColor = true;
            // 
            // btnVay
            // 
            this.btnVay.FlatAppearance.BorderSize = 0;
            this.btnVay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVay.Image = ((System.Drawing.Image)(resources.GetObject("btnVay.Image")));
            this.btnVay.Location = new System.Drawing.Point(0, 344);
            this.btnVay.Name = "btnVay";
            this.btnVay.Size = new System.Drawing.Size(226, 50);
            this.btnVay.TabIndex = 11;
            this.btnVay.Text = "VAY LÃI SUẤT";
            this.btnVay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVay.UseVisualStyleBackColor = true;
            this.btnVay.Click += new System.EventHandler(this.btnVay_Click);
            // 
            // btnBL
            // 
            this.btnBL.FlatAppearance.BorderSize = 0;
            this.btnBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBL.Image = ((System.Drawing.Image)(resources.GetObject("btnBL.Image")));
            this.btnBL.Location = new System.Drawing.Point(0, 510);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(226, 50);
            this.btnBL.TabIndex = 10;
            this.btnBL.Text = "BIÊN LAI";
            this.btnBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.btnBL_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 232);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(225, 50);
            this.btnTaiKhoan.TabIndex = 9;
            this.btnTaiKhoan.Text = "QL TÀI KHOẢN";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnCK
            // 
            this.btnCK.FlatAppearance.BorderSize = 0;
            this.btnCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCK.Image = ((System.Drawing.Image)(resources.GetObject("btnCK.Image")));
            this.btnCK.Location = new System.Drawing.Point(0, 288);
            this.btnCK.Name = "btnCK";
            this.btnCK.Size = new System.Drawing.Size(226, 50);
            this.btnCK.TabIndex = 8;
            this.btnCK.Text = "CHUYỂN KHOẢN";
            this.btnCK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCK.UseVisualStyleBackColor = true;
            this.btnCK.Click += new System.EventHandler(this.btnCK_Click);
            // 
            // btnInBL
            // 
            this.btnInBL.FlatAppearance.BorderSize = 0;
            this.btnInBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBL.Image = ((System.Drawing.Image)(resources.GetObject("btnInBL.Image")));
            this.btnInBL.Location = new System.Drawing.Point(1, 622);
            this.btnInBL.Name = "btnInBL";
            this.btnInBL.Size = new System.Drawing.Size(225, 50);
            this.btnInBL.TabIndex = 5;
            this.btnInBL.Text = "IN BIÊN LAI";
            this.btnInBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInBL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInBL.UseVisualStyleBackColor = true;
            this.btnInBL.Click += new System.EventHandler(this.btnInBL_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(12, 926);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 37);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(800, 975);
            this.picBanner.TabIndex = 4;
            this.picBanner.TabStop = false;
            // 
            // frmMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 975);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.picBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainUser";
            this.Text = "MainUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgListBanners;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnGD;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnKhuyenMai;
        private System.Windows.Forms.ToolStripMenuItem thuNhỏToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phóngToToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Timer tmrBannerLoop;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Button btnCK;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Button btnInBL;
        private System.Windows.Forms.Button btnVay;
        private System.Windows.Forms.Button btnPhieuNo;
        private System.Windows.Forms.Button btnPhieuVay;
    }
}