namespace QLDSV
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDANGXUAT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnLOP = new DevExpress.XtraBars.BarButtonItem();
            this.btnSINHVIEN = new DevExpress.XtraBars.BarButtonItem();
            this.btnMONHOC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDIEM = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.manv = new System.Windows.Forms.ToolStripStatusLabel();
            this.hoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.nhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDANGXUAT,
            this.btnThoat,
            this.btnLOP,
            this.btnSINHVIEN,
            this.btnMONHOC,
            this.btnDIEM});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(766, 146);
            // 
            // btnDANGXUAT
            // 
            this.btnDANGXUAT.Caption = "Đăng xuất";
            this.btnDANGXUAT.Id = 1;
            this.btnDANGXUAT.ImageOptions.Image = global::QLDSV.Properties.Resources.Login_48_icon;
            this.btnDANGXUAT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDANGXUAT.ImageOptions.LargeImage")));
            this.btnDANGXUAT.Name = "btnDANGXUAT";
            this.btnDANGXUAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 2;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnLOP
            // 
            this.btnLOP.Caption = "Lớp";
            this.btnLOP.Id = 3;
            this.btnLOP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLOP.ImageOptions.Image")));
            this.btnLOP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLOP.ImageOptions.LargeImage")));
            this.btnLOP.Name = "btnLOP";
            this.btnLOP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLOP_ItemClick);
            // 
            // btnSINHVIEN
            // 
            this.btnSINHVIEN.Caption = "Sinh viên";
            this.btnSINHVIEN.Id = 5;
            this.btnSINHVIEN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSINHVIEN.ImageOptions.Image")));
            this.btnSINHVIEN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSINHVIEN.ImageOptions.LargeImage")));
            this.btnSINHVIEN.Name = "btnSINHVIEN";
            this.btnSINHVIEN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSINHVIEN_ItemClick);
            // 
            // btnMONHOC
            // 
            this.btnMONHOC.Caption = "Môn học";
            this.btnMONHOC.Id = 6;
            this.btnMONHOC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMONHOC.ImageOptions.Image")));
            this.btnMONHOC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMONHOC.ImageOptions.LargeImage")));
            this.btnMONHOC.Name = "btnMONHOC";
            this.btnMONHOC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMONHOC_ItemClick);
            // 
            // btnDIEM
            // 
            this.btnDIEM.Caption = "Điểm";
            this.btnDIEM.Id = 7;
            this.btnDIEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDIEM.ImageOptions.Image")));
            this.btnDIEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDIEM.ImageOptions.LargeImage")));
            this.btnDIEM.Name = "btnDIEM";
            this.btnDIEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDIEM_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLOP);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSINHVIEN);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMONHOC);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDIEM);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDANGXUAT);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài khoản";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manv,
            this.hoTen,
            this.nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // manv
            // 
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(37, 17);
            this.manv.Text = "manv";
            // 
            // hoTen
            // 
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(40, 17);
            this.hoTen.Text = "hoTen";
            // 
            // nhom
            // 
            this.nhom.Name = "nhom";
            this.nhom.Size = new System.Drawing.Size(39, 17);
            this.nhom.Text = "nhom";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 364);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDANGXUAT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel manv;
        public System.Windows.Forms.ToolStripStatusLabel hoTen;
        public System.Windows.Forms.ToolStripStatusLabel nhom;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnLOP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnSINHVIEN;
        private DevExpress.XtraBars.BarButtonItem btnMONHOC;
        private DevExpress.XtraBars.BarButtonItem btnDIEM;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

