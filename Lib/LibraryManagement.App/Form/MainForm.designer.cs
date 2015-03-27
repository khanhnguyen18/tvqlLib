using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

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
            DevExpress.XtraBars.Alerter.AlertButton alertButton3 = new DevExpress.XtraBars.Alerter.AlertButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar_0 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.Lbl_IpAddress = new DevExpress.XtraBars.BarStaticItem();
            this.menuBar = new DevExpress.XtraBars.Bar();
            this.bar_2 = new DevExpress.XtraBars.Bar();
            this.iPass = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.Txt_Date = new DevExpress.XtraBars.BarStaticItem();
            this.iMail = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl_0 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_3 = new DevExpress.XtraBars.BarDockControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bar_3 = new DevExpress.XtraBars.Bar();
            this.barDockControl_4 = new DevExpress.XtraBars.BarDockControl();
            this.alertControl_0 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.iLoan = new DevExpress.XtraNavBar.NavBarItem();
            this.iReturn = new DevExpress.XtraNavBar.NavBarItem();
            this.iLoanList = new DevExpress.XtraNavBar.NavBarItem();
            this.iBookFinder = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.iCardDef = new DevExpress.XtraNavBar.NavBarItem();
            this.iReaderList = new DevExpress.XtraNavBar.NavBarItem();
            this.iReaderInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.cnvLekth7 = new DevExpress.XtraEditors.PanelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnvLekth7)).BeginInit();
            this.cnvLekth7.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar_0,
            this.menuBar,
            this.bar_2});
            this.barManager1.DockControls.Add(this.barDockControl_0);
            this.barManager1.DockControls.Add(this.barDockControl_1);
            this.barManager1.DockControls.Add(this.barDockControl_2);
            this.barManager1.DockControls.Add(this.barDockControl_3);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageList1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.iPass,
            this.barStaticItem2,
            this.Txt_Date,
            this.iExit,
            this.Lbl_IpAddress,
            this.iMail});
            this.barManager1.MainMenu = this.menuBar;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar_0;
            // 
            // bar_0
            // 
            this.bar_0.BarName = "Status bar";
            this.bar_0.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar_0.DockCol = 0;
            this.bar_0.DockRow = 0;
            this.bar_0.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar_0.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.Lbl_IpAddress)});
            this.bar_0.OptionsBar.AllowQuickCustomization = false;
            this.bar_0.OptionsBar.DrawDragBorder = false;
            this.bar_0.OptionsBar.UseWholeRow = true;
            this.bar_0.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Nguyen Duy Khanh - Tel : 0907002999 - Email : outdoor1988@gmail.com";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // Lbl_IpAddress
            // 
            this.Lbl_IpAddress.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.Lbl_IpAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_IpAddress.Appearance.Options.UseFont = true;
            this.Lbl_IpAddress.Caption = "IpAddress";
            this.Lbl_IpAddress.Id = 7;
            this.Lbl_IpAddress.Name = "Lbl_IpAddress";
            this.Lbl_IpAddress.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // menuBar
            // 
            this.menuBar.BarName = "Custom 4";
            this.menuBar.DockCol = 0;
            this.menuBar.DockRow = 0;
            this.menuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.menuBar.OptionsBar.AllowQuickCustomization = false;
            this.menuBar.OptionsBar.UseWholeRow = true;
            this.menuBar.Text = "Custom 4";
            // 
            // bar_2
            // 
            this.bar_2.BarName = "Custom 5";
            this.bar_2.DockCol = 0;
            this.bar_2.DockRow = 1;
            this.bar_2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar_2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.iPass, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barStaticItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.Txt_Date),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.iMail, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.iExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar_2.Text = "Custom 5";
            // 
            // iPass
            // 
            this.iPass.Caption = "Đổi mật khẩu";
            this.iPass.Id = 3;
            this.iPass.ImageIndex = 2;
            this.iPass.Name = "iPass";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Ngày làm việc hiện thời";
            this.barStaticItem2.Id = 4;
            this.barStaticItem2.ImageIndex = 4;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // Txt_Date
            // 
            this.Txt_Date.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Date.Appearance.Options.UseFont = true;
            this.Txt_Date.Caption = "12/02/2010";
            this.Txt_Date.Id = 5;
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // iMail
            // 
            this.iMail.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iMail.Appearance.Options.UseFont = true;
            this.iMail.Caption = "Tin nhắn";
            this.iMail.Id = 8;
            this.iMail.ImageIndex = 15;
            this.iMail.Name = "iMail";
            // 
            // iExit
            // 
            this.iExit.Caption = "THOÁT";
            this.iExit.Id = 6;
            this.iExit.ImageIndex = 10;
            this.iExit.Name = "iExit";
            // 
            // barDockControl_0
            // 
            this.barDockControl_0.CausesValidation = false;
            this.barDockControl_0.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl_0.Location = new System.Drawing.Point(0, 0);
            this.barDockControl_0.Size = new System.Drawing.Size(787, 54);
            // 
            // barDockControl_1
            // 
            this.barDockControl_1.CausesValidation = false;
            this.barDockControl_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl_1.Location = new System.Drawing.Point(0, 489);
            this.barDockControl_1.Size = new System.Drawing.Size(787, 26);
            // 
            // barDockControl_2
            // 
            this.barDockControl_2.CausesValidation = false;
            this.barDockControl_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl_2.Location = new System.Drawing.Point(0, 54);
            this.barDockControl_2.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControl_3
            // 
            this.barDockControl_3.CausesValidation = false;
            this.barDockControl_3.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl_3.Location = new System.Drawing.Point(787, 54);
            this.barDockControl_3.Size = new System.Drawing.Size(0, 435);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.png");
            this.imageList1.Images.SetKeyName(1, "disk_blue.png");
            this.imageList1.Images.SetKeyName(2, "keys.png");
            this.imageList1.Images.SetKeyName(3, "home.png");
            this.imageList1.Images.SetKeyName(4, "calendar.png");
            this.imageList1.Images.SetKeyName(5, "lock_information.png");
            this.imageList1.Images.SetKeyName(6, "cashier.png");
            this.imageList1.Images.SetKeyName(7, "businessmen.png");
            this.imageList1.Images.SetKeyName(8, "funnel_add.png");
            this.imageList1.Images.SetKeyName(9, "businessman_view.png");
            this.imageList1.Images.SetKeyName(10, "delete2.png");
            this.imageList1.Images.SetKeyName(11, "box_add.png");
            this.imageList1.Images.SetKeyName(12, "package_add.png");
            this.imageList1.Images.SetKeyName(13, "paperclip.png");
            this.imageList1.Images.SetKeyName(14, "mail.png");
            this.imageList1.Images.SetKeyName(15, "mail_add.png");
            this.imageList1.Images.SetKeyName(16, "books.png");
            this.imageList1.Images.SetKeyName(17, "book_blue_next.png");
            this.imageList1.Images.SetKeyName(18, "book_blue_view.png");
            this.imageList1.Images.SetKeyName(19, "user1_into.png");
            this.imageList1.Images.SetKeyName(20, "user1_view.png");
            this.imageList1.Images.SetKeyName(21, "user1_information.png");
            this.imageList1.Images.SetKeyName(22, "table_selection_column.png");
            this.imageList1.Images.SetKeyName(23, "certificate.png");
            // 
            // bar_3
            // 
            this.bar_3.BarName = "Custom 4";
            this.bar_3.DockCol = 0;
            this.bar_3.DockRow = 0;
            this.bar_3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar_3.OptionsBar.AllowQuickCustomization = false;
            this.bar_3.OptionsBar.UseWholeRow = true;
            this.bar_3.Text = "Custom 4";
            // 
            // barDockControl_4
            // 
            this.barDockControl_4.CausesValidation = false;
            this.barDockControl_4.Location = new System.Drawing.Point(0, 0);
            this.barDockControl_4.Size = new System.Drawing.Size(0, 0);
            // 
            // alertControl_0
            // 
            this.alertControl_0.AutoFormDelay = 9000;
            alertButton3.Hint = "Đóng";
            alertButton3.Name = "close";
            this.alertControl_0.Buttons.Add(alertButton3);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.iLoan,
            this.iReturn,
            this.iLoanList,
            this.iCardDef,
            this.iReaderList,
            this.iReaderInfo,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem11,
            this.navBarItem12,
            this.iBookFinder});
            this.navBarControl1.LargeImages = this.imageCollection1;
            this.navBarControl1.Location = new System.Drawing.Point(1, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 196;
            this.navBarControl1.Size = new System.Drawing.Size(203, 512);
            this.navBarControl1.SmallImages = this.imageList1;
            this.navBarControl1.TabIndex = 6;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản lý thư viện";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.iLoan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iReturn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iLoanList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iBookFinder)});
            this.navBarGroup1.LargeImageIndex = 23;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // iLoan
            // 
            this.iLoan.Caption = "Phiếu cho mượn sách";
            this.iLoan.Name = "iLoan";
            this.iLoan.SmallImageIndex = 17;
            this.iLoan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.iLoan_LinkClicked);
            // 
            // iReturn
            // 
            this.iReturn.Caption = "Phiếu nhận trả sách";
            this.iReturn.Name = "iReturn";
            this.iReturn.SmallImageIndex = 16;
            this.iReturn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.iReturn_LinkClicked);
            // 
            // iLoanList
            // 
            this.iLoanList.Caption = "Danh sách phiếu";
            this.iLoanList.Name = "iLoanList";
            this.iLoanList.SmallImageIndex = 22;
            this.iLoanList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.iLoanList_LinkClicked);
            // 
            // iBookFinder
            // 
            this.iBookFinder.Caption = "Tìm kiếm sách nhanh";
            this.iBookFinder.Name = "iBookFinder";
            this.iBookFinder.SmallImageIndex = 18;
            this.iBookFinder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.iBookFinder_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Quản lý bạn đọc";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.iCardDef),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iReaderList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iReaderInfo)});
            this.navBarGroup2.LargeImageIndex = 14;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // iCardDef
            // 
            this.iCardDef.Caption = "Đăng ký thẻ thư viện";
            this.iCardDef.Name = "iCardDef";
            this.iCardDef.SmallImageIndex = 23;
            this.iCardDef.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.iCardDef_LinkClicked);
            // 
            // iReaderList
            // 
            this.iReaderList.Caption = "Danh sách bạn đọc";
            this.iReaderList.Name = "iReaderList";
            this.iReaderList.SmallImageIndex = 7;
            this.iReaderList.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.iReaderList_LinkClicked);
            // 
            // iReaderInfo
            // 
            this.iReaderInfo.Caption = "Tra cứu thông tin bạn đọc";
            this.iReaderInfo.Name = "iReaderInfo";
            this.iReaderInfo.SmallImageIndex = 20;
            this.iReaderInfo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.iReaderInfo_LinkClicked);
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Đăng ký giờ làm chính";
            this.navBarItem7.Name = "navBarItem7";
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Đăng ký ca làm việc";
            this.navBarItem8.Name = "navBarItem8";
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Chi tiết theo nhân viên";
            this.navBarItem9.Name = "navBarItem9";
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "Đăng ký người sử dụng";
            this.navBarItem10.Name = "navBarItem10";
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "Tối ưu dữ liệu";
            this.navBarItem11.Name = "navBarItem11";
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "Sao lưu dữ liệu";
            this.navBarItem12.Name = "navBarItem12";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // cnvLekth7
            // 
            this.cnvLekth7.Controls.Add(this.navBarControl1);
            this.cnvLekth7.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnvLekth7.Location = new System.Drawing.Point(0, 54);
            this.cnvLekth7.Name = "cnvLekth7";
            this.cnvLekth7.Size = new System.Drawing.Size(206, 435);
            this.cnvLekth7.TabIndex = 7;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Style";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(787, 515);
            this.Controls.Add(this.cnvLekth7);
            this.Controls.Add(this.barDockControl_4);
            this.Controls.Add(this.barDockControl_2);
            this.Controls.Add(this.barDockControl_3);
            this.Controls.Add(this.barDockControl_1);
            this.Controls.Add(this.barDockControl_0);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "QUẢN LÝ THƯ VIỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnvLekth7)).EndInit();
            this.cnvLekth7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private AlertControl alertControl_0;
        private Bar bar_0;
        private Bar menuBar;
        private Bar bar_2;
        private Bar bar_3;
        private BarDockControl barDockControl_0;
        private BarDockControl barDockControl_1;
        private BarDockControl barDockControl_2;
        private BarDockControl barDockControl_3;
        private BarDockControl barDockControl_4;
        private BarManager barManager1;
        private BarStaticItem barStaticItem1;
        private BarStaticItem barStaticItem2;
        private PanelControl cnvLekth7;
        private DefaultLookAndFeel defaultLookAndFeel1;
        private Form form_0;
        private NavBarItem iBookFinder;
        private NavBarItem iCardDef;
        private IContainer components;
        private BarButtonItem iExit;
        private NavBarItem iLoan;
        private NavBarItem iLoanList;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private ImageList imageList1;
        private ImageList imageList2;
        private BarButtonItem iMail;
        private BarButtonItem iPass;
        private NavBarItem iReaderInfo;
        private NavBarItem iReaderList;
        private NavBarItem iReturn;
        private BarStaticItem Lbl_IpAddress;
        private NavBarControl navBarControl1;
        private NavBarGroup navBarGroup1;
        private NavBarGroup navBarGroup2;
        private NavBarItem navBarItem10;
        private NavBarItem navBarItem11;
        private NavBarItem navBarItem12;
        private NavBarItem navBarItem7;
        private NavBarItem navBarItem8;
        private NavBarItem navBarItem9;
        private string string_0;
        private string string_1;
        private BarStaticItem Txt_Date;
        private ComponentResourceManager manager;
        #endregion
    }
}