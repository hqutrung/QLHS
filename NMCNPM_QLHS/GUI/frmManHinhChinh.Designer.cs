namespace NMCNPM_QLHS.GUI
{
    partial class frmManHinhChinh
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barLop = new DevExpress.XtraBars.BarButtonItem();
            this.barKhoi = new DevExpress.XtraBars.BarButtonItem();
            this.barHocky = new DevExpress.XtraBars.BarButtonItem();
            this.barNamHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barHocSinh = new DevExpress.XtraBars.BarButtonItem();
            this.barPhanLop = new DevExpress.XtraBars.BarButtonItem();
            this.barrpHK_Lop = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barQuyDinhTuoi = new DevExpress.XtraBars.BarButtonItem();
            this.barQuyDinhSiSo = new DevExpress.XtraBars.BarButtonItem();
            this.barQuyDinhDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barDiemCT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageTraCuu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQuyDinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barLop,
            this.barKhoi,
            this.barHocky,
            this.barNamHoc,
            this.barMonHoc,
            this.barDiem,
            this.barHocSinh,
            this.barPhanLop,
            this.barrpHK_Lop,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barQuyDinhTuoi,
            this.barQuyDinhSiSo,
            this.barQuyDinhDiem,
            this.barDiemCT,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 27;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageQuanLy,
            this.ribbonPageThongKe,
            this.ribbonPageTraCuu,
            this.ribbonPageQuyDinh});
            this.ribbon.Size = new System.Drawing.Size(917, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barLop
            // 
            this.barLop.Caption = "Lớp";
            this.barLop.Id = 3;
            this.barLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.lophoc;
            this.barLop.Name = "barLop";
            this.barLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLop_ItemClick);
            // 
            // barKhoi
            // 
            this.barKhoi.Caption = "Khối lớp";
            this.barKhoi.Id = 4;
            this.barKhoi.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.khoilop;
            this.barKhoi.Name = "barKhoi";
            this.barKhoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barKhoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKhoi_ItemClick);
            // 
            // barHocky
            // 
            this.barHocky.Caption = "Học kỳ";
            this.barHocky.Id = 5;
            this.barHocky.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.hocky;
            this.barHocky.Name = "barHocky";
            this.barHocky.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barHocky.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHocky_ItemClick);
            // 
            // barNamHoc
            // 
            this.barNamHoc.Caption = "Năm học";
            this.barNamHoc.Id = 6;
            this.barNamHoc.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.namhoc;
            this.barNamHoc.Name = "barNamHoc";
            this.barNamHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNamHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNamHoc_ItemClick);
            // 
            // barMonHoc
            // 
            this.barMonHoc.Caption = "Môn học";
            this.barMonHoc.Id = 7;
            this.barMonHoc.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.monhoc;
            this.barMonHoc.Name = "barMonHoc";
            this.barMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMonHoc_ItemClick);
            // 
            // barDiem
            // 
            this.barDiem.Caption = "Điểm";
            this.barDiem.Id = 8;
            this.barDiem.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.diem;
            this.barDiem.Name = "barDiem";
            this.barDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDiem_ItemClick);
            // 
            // barHocSinh
            // 
            this.barHocSinh.Caption = "Học sinh";
            this.barHocSinh.Id = 9;
            this.barHocSinh.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.pupils;
            this.barHocSinh.Name = "barHocSinh";
            this.barHocSinh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barHocSinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHocSinh_ItemClick);
            // 
            // barPhanLop
            // 
            this.barPhanLop.Caption = "Phân lớp";
            this.barPhanLop.Id = 10;
            this.barPhanLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.phanlop;
            this.barPhanLop.Name = "barPhanLop";
            this.barPhanLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barPhanLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barPhanLop_ItemClick);
            // 
            // barrpHK_Lop
            // 
            this.barrpHK_Lop.Caption = "Kết quả học kỳ theo lớp";
            this.barrpHK_Lop.Id = 11;
            this.barrpHK_Lop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.kqhockytheolop;
            this.barrpHK_Lop.Name = "barrpHK_Lop";
            this.barrpHK_Lop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barrpHK_Lop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barrpHK_Lop_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Kết quả học kỳ theo môn học";
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.kqhockytheomon;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Kết quả cả năm theo lớp";
            this.barButtonItem11.Id = 13;
            this.barButtonItem11.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.kqcnamtheolop;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Kết quả cả năm theo môn học";
            this.barButtonItem12.Id = 14;
            this.barButtonItem12.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.kqcnamtheomon;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Danh sách học sinh";
            this.barButtonItem13.Id = 15;
            this.barButtonItem13.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.dshocsinh;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Danh sách lớp học";
            this.barButtonItem14.Id = 16;
            this.barButtonItem14.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.dslophoc;
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Tra cứu học sinh";
            this.barButtonItem15.Id = 17;
            this.barButtonItem15.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.tracuuhocsinh;
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barQuyDinhTuoi
            // 
            this.barQuyDinhTuoi.Caption = "Quy định tuổi";
            this.barQuyDinhTuoi.Id = 18;
            this.barQuyDinhTuoi.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.qddotuoi;
            this.barQuyDinhTuoi.Name = "barQuyDinhTuoi";
            this.barQuyDinhTuoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barQuyDinhTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQuyDinhTuoi_ItemClick);
            // 
            // barQuyDinhSiSo
            // 
            this.barQuyDinhSiSo.Caption = "Quy định sỉ số";
            this.barQuyDinhSiSo.Id = 19;
            this.barQuyDinhSiSo.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.qdsiso;
            this.barQuyDinhSiSo.Name = "barQuyDinhSiSo";
            this.barQuyDinhSiSo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barQuyDinhSiSo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQuyDinhSiSo_ItemClick);
            // 
            // barQuyDinhDiem
            // 
            this.barQuyDinhDiem.Caption = "Quy định điểm";
            this.barQuyDinhDiem.Id = 20;
            this.barQuyDinhDiem.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.qdthangdiem;
            this.barQuyDinhDiem.Name = "barQuyDinhDiem";
            this.barQuyDinhDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barQuyDinhDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQuyDinhDiem_ItemClick);
            // 
            // barDiemCT
            // 
            this.barDiemCT.Caption = "Tra cứ điểm học sinh";
            this.barDiemCT.Id = 25;
            this.barDiemCT.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.phancong;
            this.barDiemCT.Name = "barDiemCT";
            this.barDiemCT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDiemCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDiemCT_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 26;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barLop);
            this.ribbonPageGroup1.ItemLinks.Add(this.barKhoi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lớp - Khối lớp";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barHocky);
            this.ribbonPageGroup2.ItemLinks.Add(this.barNamHoc);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Năm học";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barMonHoc);
            this.ribbonPageGroup3.ItemLinks.Add(this.barDiem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Môn học";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barHocSinh);
            this.ribbonPageGroup4.ItemLinks.Add(this.barPhanLop);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Học Sinh";
            // 
            // ribbonPageThongKe
            // 
            this.ribbonPageThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPageThongKe.Name = "ribbonPageThongKe";
            this.ribbonPageThongKe.Text = "Thống kê";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barrpHK_Lop);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kết quả Học kỳ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Kết quả cuối năm";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem14);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Xuất danh sách";
            // 
            // ribbonPageTraCuu
            // 
            this.ribbonPageTraCuu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPageTraCuu.Name = "ribbonPageTraCuu";
            this.ribbonPageTraCuu.Text = "Tra cứu";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem15);
            this.ribbonPageGroup8.ItemLinks.Add(this.barDiemCT);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Tra cứu";
            // 
            // ribbonPageQuyDinh
            // 
            this.ribbonPageQuyDinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribbonPageQuyDinh.Name = "ribbonPageQuyDinh";
            this.ribbonPageQuyDinh.Text = "Quy định";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barQuyDinhTuoi);
            this.ribbonPageGroup9.ItemLinks.Add(this.barQuyDinhSiSo);
            this.ribbonPageGroup9.ItemLinks.Add(this.barQuyDinhDiem);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Quy định chung";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 507);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(917, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 538);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IsMdiContainer = true;
            this.Name = "frmManHinhChinh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Học Sinh";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageTraCuu;
        private DevExpress.XtraBars.BarButtonItem barLop;
        private DevExpress.XtraBars.BarButtonItem barKhoi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuyDinh;
        private DevExpress.XtraBars.BarButtonItem barHocky;
        private DevExpress.XtraBars.BarButtonItem barNamHoc;
        private DevExpress.XtraBars.BarButtonItem barMonHoc;
        private DevExpress.XtraBars.BarButtonItem barDiem;
        private DevExpress.XtraBars.BarButtonItem barHocSinh;
        private DevExpress.XtraBars.BarButtonItem barPhanLop;
        private DevExpress.XtraBars.BarButtonItem barrpHK_Lop;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barQuyDinhTuoi;
        private DevExpress.XtraBars.BarButtonItem barQuyDinhSiSo;
        private DevExpress.XtraBars.BarButtonItem barQuyDinhDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barDiemCT;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}