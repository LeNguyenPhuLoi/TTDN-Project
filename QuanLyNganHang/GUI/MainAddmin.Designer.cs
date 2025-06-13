namespace GUI
{
    partial class frmMainAddmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAddmin));
            this.imgListBanners = new System.Windows.Forms.ImageList(this.components);
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thuNhỏToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phóngToToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrBannerLoop = new System.Windows.Forms.Timer(this.components);
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnTệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biênLaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nộiQuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viPhạmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiNhánhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.khuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ápDụngKhuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lãiSuátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửTrảNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoảnVayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tKĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListBanners
            // 
            this.imgListBanners.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListBanners.ImageStream")));
            this.imgListBanners.TransparentColor = System.Drawing.Color.Black;
            this.imgListBanners.Images.SetKeyName(0, "menu.png");
            this.imgListBanners.Images.SetKeyName(1, "banner1.jpg");
            this.imgListBanners.Images.SetKeyName(2, "banner2.jpg");
            this.imgListBanners.Images.SetKeyName(3, "banner3.jpg");
            this.imgListBanners.Images.SetKeyName(4, "banner4.jpg");
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(167, 30);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            // 
            // thuNhỏToolStripMenuItem1
            // 
            this.thuNhỏToolStripMenuItem1.Name = "thuNhỏToolStripMenuItem1";
            this.thuNhỏToolStripMenuItem1.Size = new System.Drawing.Size(167, 30);
            this.thuNhỏToolStripMenuItem1.Text = "Thu nhỏ";
            // 
            // phóngToToolStripMenuItem1
            // 
            this.phóngToToolStripMenuItem1.Name = "phóngToToolStripMenuItem1";
            this.phóngToToolStripMenuItem1.Size = new System.Drawing.Size(167, 30);
            this.phóngToToolStripMenuItem1.Text = "Phóng to";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phóngToToolStripMenuItem1,
            this.thuNhỏToolStripMenuItem1,
            this.thoátToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 94);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.báoCáoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("báoCáoToolStripMenuItem.Image")));
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.loạiTàiKhoảnToolStripMenuItem,
            this.tiềnTệToolStripMenuItem,
            this.chuyểnKhoảnToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // loạiTàiKhoảnToolStripMenuItem
            // 
            this.loạiTàiKhoảnToolStripMenuItem.Name = "loạiTàiKhoảnToolStripMenuItem";
            this.loạiTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.loạiTàiKhoảnToolStripMenuItem.Text = "Loại Tài Khoản";
            this.loạiTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.loạiTàiKhoảnToolStripMenuItem_Click);
            // 
            // tiềnTệToolStripMenuItem
            // 
            this.tiềnTệToolStripMenuItem.Name = "tiềnTệToolStripMenuItem";
            this.tiềnTệToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.tiềnTệToolStripMenuItem.Text = "Tiền Tệ";
            this.tiềnTệToolStripMenuItem.Click += new System.EventHandler(this.tiềnTệToolStripMenuItem_Click);
            // 
            // chuyểnKhoảnToolStripMenuItem
            // 
            this.chuyểnKhoảnToolStripMenuItem.Name = "chuyểnKhoảnToolStripMenuItem";
            this.chuyểnKhoảnToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.chuyểnKhoảnToolStripMenuItem.Text = "Chuyển Khoản";
            this.chuyểnKhoảnToolStripMenuItem.Click += new System.EventHandler(this.chuyểnKhoảnToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDịchToolStripMenuItem,
            this.biênLaiToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.giaoDịchToolStripMenuItem.Text = "Giao Dịch";
            this.giaoDịchToolStripMenuItem.Click += new System.EventHandler(this.giaoDịchToolStripMenuItem_Click);
            // 
            // biênLaiToolStripMenuItem
            // 
            this.biênLaiToolStripMenuItem.Name = "biênLaiToolStripMenuItem";
            this.biênLaiToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.biênLaiToolStripMenuItem.Text = "Biên Lai";
            this.biênLaiToolStripMenuItem.Click += new System.EventHandler(this.biênLaiToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.phòngBanToolStripMenuItem,
            this.chiNhánhToolStripMenuItem,
            this.toolStripMenuItem1,
            this.khuyếnMãiToolStripMenuItem,
            this.lãiSuátToolStripMenuItem,
            this.tKĐăngNhậpToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.quảnLýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýToolStripMenuItem.Image")));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nộiQuyToolStripMenuItem,
            this.viPhạmToolStripMenuItem});
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.phòngBanToolStripMenuItem.Text = "Phòng Ban";
            this.phòngBanToolStripMenuItem.Click += new System.EventHandler(this.phòngBanToolStripMenuItem_Click);
            // 
            // nộiQuyToolStripMenuItem
            // 
            this.nộiQuyToolStripMenuItem.Name = "nộiQuyToolStripMenuItem";
            this.nộiQuyToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.nộiQuyToolStripMenuItem.Text = "Nội Quy";
            this.nộiQuyToolStripMenuItem.Click += new System.EventHandler(this.nộiQuyToolStripMenuItem_Click);
            // 
            // viPhạmToolStripMenuItem
            // 
            this.viPhạmToolStripMenuItem.Name = "viPhạmToolStripMenuItem";
            this.viPhạmToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.viPhạmToolStripMenuItem.Text = "Vi Phạm";
            this.viPhạmToolStripMenuItem.Click += new System.EventHandler(this.viPhạmToolStripMenuItem_Click);
            // 
            // chiNhánhToolStripMenuItem
            // 
            this.chiNhánhToolStripMenuItem.Name = "chiNhánhToolStripMenuItem";
            this.chiNhánhToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.chiNhánhToolStripMenuItem.Text = "Chi Nhánh";
            this.chiNhánhToolStripMenuItem.Click += new System.EventHandler(this.chiNhánhToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 6);
            // 
            // khuyếnMãiToolStripMenuItem
            // 
            this.khuyếnMãiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ápDụngKhuyếnMãiToolStripMenuItem});
            this.khuyếnMãiToolStripMenuItem.Name = "khuyếnMãiToolStripMenuItem";
            this.khuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.khuyếnMãiToolStripMenuItem.Text = "Khuyến Mãi";
            this.khuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.khuyếnMãiToolStripMenuItem_Click);
            // 
            // ápDụngKhuyếnMãiToolStripMenuItem
            // 
            this.ápDụngKhuyếnMãiToolStripMenuItem.Name = "ápDụngKhuyếnMãiToolStripMenuItem";
            this.ápDụngKhuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.ápDụngKhuyếnMãiToolStripMenuItem.Text = "Áp Dụng Khuyến Mãi";
            this.ápDụngKhuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.ápDụngKhuyếnMãiToolStripMenuItem_Click);
            // 
            // lãiSuátToolStripMenuItem
            // 
            this.lãiSuátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửTrảNợToolStripMenuItem,
            this.khoảnVayToolStripMenuItem});
            this.lãiSuátToolStripMenuItem.Name = "lãiSuátToolStripMenuItem";
            this.lãiSuátToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.lãiSuátToolStripMenuItem.Text = "Lãi Suát";
            this.lãiSuátToolStripMenuItem.Click += new System.EventHandler(this.lãiSuátToolStripMenuItem_Click);
            // 
            // lịchSửTrảNợToolStripMenuItem
            // 
            this.lịchSửTrảNợToolStripMenuItem.Name = "lịchSửTrảNợToolStripMenuItem";
            this.lịchSửTrảNợToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.lịchSửTrảNợToolStripMenuItem.Text = "Lịch Sử Trả Nợ";
            this.lịchSửTrảNợToolStripMenuItem.Click += new System.EventHandler(this.lịchSửTrảNợToolStripMenuItem_Click);
            // 
            // khoảnVayToolStripMenuItem
            // 
            this.khoảnVayToolStripMenuItem.Name = "khoảnVayToolStripMenuItem";
            this.khoảnVayToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.khoảnVayToolStripMenuItem.Text = "Khoản Vay";
            this.khoảnVayToolStripMenuItem.Click += new System.EventHandler(this.khoảnVayToolStripMenuItem_Click);
            // 
            // tKĐăngNhậpToolStripMenuItem
            // 
            this.tKĐăngNhậpToolStripMenuItem.Name = "tKĐăngNhậpToolStripMenuItem";
            this.tKĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.tKĐăngNhậpToolStripMenuItem.Text = "TK Đăng Nhập";
            this.tKĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.tKĐăngNhậpToolStripMenuItem_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(1042, 35);
            this.mnuMain.TabIndex = 4;
            this.mnuMain.Text = "menuStrip1";
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1042, 633);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 5;
            this.picBanner.TabStop = false;
            this.picBanner.Click += new System.EventHandler(this.picBanner_Click);
            // 
            // frmMainAddmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 633);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.picBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainAddmin";
            this.Text = "MainAddmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainAddmin_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgListBanners;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thuNhỏToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phóngToToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Timer tmrBannerLoop;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnTệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biênLaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nộiQuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viPhạmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiNhánhToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chuyểnKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuyếnMãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ápDụngKhuyếnMãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lãiSuátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửTrảNợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoảnVayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tKĐăngNhậpToolStripMenuItem;
    }
}