using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class MainForm
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
        private ComponentResourceManager manager;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager_0 = new DevExpress.XtraBars.BarManager(this.components);
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.menuBar = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem6 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem7 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem8 = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem18 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem17 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem19 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem20 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem21 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem22 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem23 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem24 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem25 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem26 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem27 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem28 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem29 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem30 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem31 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem32 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem33 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem34 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem35 = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barCheckItem9 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem10 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem11 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem12 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem13 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem14 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem15 = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem16 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_2 = new DevExpress.XtraBars.Bar();
            this.blbiBook = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiPrintCard = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiSupplierReturn = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiBuyOld = new DevExpress.XtraBars.BarLargeButtonItem();
            this.blbiChangePass = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem5 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControl_0 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_3 = new DevExpress.XtraBars.BarDockControl();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.iPass = new DevExpress.XtraBars.BarButtonItem();
            this.Txt_Date = new DevExpress.XtraBars.BarStaticItem();
            this.iMail = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem5 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem6 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem7 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem8 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.imageCollection_0 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.bar_3 = new DevExpress.XtraBars.Bar();
            this.barDockControl_4 = new DevExpress.XtraBars.BarDockControl();
            this.imageList_1 = new System.Windows.Forms.ImageList(this.components);
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
            this.cnvLekth7 = new DevExpress.XtraEditors.PanelControl();
            this.defaultLookAndFeel_0 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnvLekth7)).BeginInit();
            this.cnvLekth7.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager_0
            // 
            this.barManager_0.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.statusBar,
            this.menuBar,
            this.bar_2});
            this.barManager_0.DockControls.Add(this.barDockControl_0);
            this.barManager_0.DockControls.Add(this.barDockControl_1);
            this.barManager_0.DockControls.Add(this.barDockControl_2);
            this.barManager_0.DockControls.Add(this.barDockControl_3);
            this.barManager_0.Form = this;
            this.barManager_0.Images = this.imageList_0;
            this.barManager_0.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.iPass,
            this.Txt_Date,
            this.iMail,
            this.blbiBook,
            this.blbiPrintCard,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4,
            this.blbiSupplierReturn,
            this.blbiBuyOld,
            this.blbiChangePass,
            this.barLargeButtonItem5,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barStaticItem4,
            this.barStaticItem5,
            this.barStaticItem6,
            this.barStaticItem7,
            this.barStaticItem8,
            this.barCheckItem1,
            this.barCheckItem2,
            this.barCheckItem3,
            this.barSubItem5,
            this.barCheckItem4,
            this.barCheckItem5,
            this.barCheckItem6,
            this.barCheckItem7,
            this.barCheckItem8,
            this.barCheckItem9,
            this.barCheckItem10,
            this.barCheckItem11,
            this.barCheckItem12,
            this.barCheckItem13,
            this.barCheckItem14,
            this.barCheckItem15,
            this.barCheckItem16,
            this.barCheckItem17,
            this.barCheckItem18,
            this.barCheckItem19,
            this.barCheckItem20,
            this.barCheckItem21,
            this.barCheckItem22,
            this.barCheckItem23,
            this.barCheckItem24,
            this.barCheckItem25,
            this.barCheckItem26,
            this.barCheckItem27,
            this.barCheckItem28,
            this.barCheckItem29,
            this.barCheckItem30,
            this.barCheckItem31,
            this.barCheckItem32,
            this.barCheckItem33,
            this.barCheckItem34,
            this.barCheckItem35,
            this.barButtonItem1});
            this.barManager_0.LargeImages = this.imageCollection_0;
            this.barManager_0.MainMenu = this.menuBar;
            this.barManager_0.MaxItemId = 72;
            this.barManager_0.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager_0.StatusBar = this.statusBar;
            this.barManager_0.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barManager_0_ItemClick);
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Programed by Nguyen Duy Khanh - Tel : 0907002999 - Email : nduykhanh181088@yahoo." +
                "com";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // menuBar
            // 
            this.menuBar.BarName = "Custom 4";
            this.menuBar.DockCol = 0;
            this.menuBar.DockRow = 0;
            this.menuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.menuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.menuBar.OptionsBar.AllowQuickCustomization = false;
            this.menuBar.OptionsBar.MultiLine = true;
            this.menuBar.OptionsBar.UseWholeRow = true;
            this.menuBar.Text = "Custom 4";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Giao diện";
            this.barSubItem1.Id = 20;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Skin";
            this.barSubItem3.Id = 22;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem8)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.Caption = "Black";
            this.barCheckItem2.GroupIndex = 1;
            this.barCheckItem2.Id = 32;
            this.barCheckItem2.Name = "barCheckItem2";
            // 
            // barCheckItem3
            // 
            this.barCheckItem3.Caption = "Blue";
            this.barCheckItem3.GroupIndex = 1;
            this.barCheckItem3.Id = 33;
            this.barCheckItem3.Name = "barCheckItem3";
            // 
            // barCheckItem4
            // 
            this.barCheckItem4.Caption = "Caramel";
            this.barCheckItem4.GroupIndex = 1;
            this.barCheckItem4.Id = 35;
            this.barCheckItem4.Name = "barCheckItem4";
            // 
            // barCheckItem5
            // 
            this.barCheckItem5.Caption = "iMaginary";
            this.barCheckItem5.GroupIndex = 1;
            this.barCheckItem5.Id = 36;
            this.barCheckItem5.Name = "barCheckItem5";
            // 
            // barCheckItem6
            // 
            this.barCheckItem6.Caption = "Lilian";
            this.barCheckItem6.GroupIndex = 1;
            this.barCheckItem6.Id = 37;
            this.barCheckItem6.Name = "barCheckItem6";
            // 
            // barCheckItem7
            // 
            this.barCheckItem7.Caption = "Money Twins";
            this.barCheckItem7.GroupIndex = 1;
            this.barCheckItem7.Id = 38;
            this.barCheckItem7.Name = "barCheckItem7";
            // 
            // barCheckItem8
            // 
            this.barCheckItem8.Caption = "The Asphalt World";
            this.barCheckItem8.GroupIndex = 1;
            this.barCheckItem8.Id = 39;
            this.barCheckItem8.Name = "barCheckItem8";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Bonus skin";
            this.barSubItem2.Id = 21;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem17),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem19),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem20),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem21),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem22),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem23),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem24),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem25),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem26),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem27),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem28),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem29),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem30),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem31),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem32),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem33),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem34),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem35)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Summer 2008";
            this.barCheckItem1.GroupIndex = 1;
            this.barCheckItem1.Id = 31;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barCheckItem18
            // 
            this.barCheckItem18.Caption = "Coffee";
            this.barCheckItem18.GroupIndex = 1;
            this.barCheckItem18.Id = 50;
            this.barCheckItem18.Name = "barCheckItem18";
            // 
            // barCheckItem17
            // 
            this.barCheckItem17.Caption = "Dark Side";
            this.barCheckItem17.GroupIndex = 1;
            this.barCheckItem17.Id = 49;
            this.barCheckItem17.Name = "barCheckItem17";
            // 
            // barCheckItem19
            // 
            this.barCheckItem19.Caption = "Darkroom";
            this.barCheckItem19.GroupIndex = 1;
            this.barCheckItem19.Id = 51;
            this.barCheckItem19.Name = "barCheckItem19";
            // 
            // barCheckItem20
            // 
            this.barCheckItem20.Caption = "DevExpress Style";
            this.barCheckItem20.GroupIndex = 1;
            this.barCheckItem20.Id = 52;
            this.barCheckItem20.Name = "barCheckItem20";
            // 
            // barCheckItem21
            // 
            this.barCheckItem21.Caption = "Foggy";
            this.barCheckItem21.GroupIndex = 1;
            this.barCheckItem21.Id = 53;
            this.barCheckItem21.Name = "barCheckItem21";
            // 
            // barCheckItem22
            // 
            this.barCheckItem22.Caption = "Glass Oceans";
            this.barCheckItem22.GroupIndex = 1;
            this.barCheckItem22.Id = 54;
            this.barCheckItem22.Name = "barCheckItem22";
            // 
            // barCheckItem23
            // 
            this.barCheckItem23.Caption = "High Contrast";
            this.barCheckItem23.GroupIndex = 1;
            this.barCheckItem23.Id = 55;
            this.barCheckItem23.Name = "barCheckItem23";
            // 
            // barCheckItem24
            // 
            this.barCheckItem24.Caption = "Liquid Sky";
            this.barCheckItem24.GroupIndex = 1;
            this.barCheckItem24.Id = 56;
            this.barCheckItem24.Name = "barCheckItem24";
            // 
            // barCheckItem25
            // 
            this.barCheckItem25.Caption = "London Liquid Sky";
            this.barCheckItem25.GroupIndex = 1;
            this.barCheckItem25.Id = 57;
            this.barCheckItem25.Name = "barCheckItem25";
            // 
            // barCheckItem26
            // 
            this.barCheckItem26.Caption = "McSkin";
            this.barCheckItem26.GroupIndex = 1;
            this.barCheckItem26.Id = 58;
            this.barCheckItem26.Name = "barCheckItem26";
            // 
            // barCheckItem27
            // 
            this.barCheckItem27.Caption = "Pumpkin";
            this.barCheckItem27.GroupIndex = 1;
            this.barCheckItem27.Id = 59;
            this.barCheckItem27.Name = "barCheckItem27";
            // 
            // barCheckItem28
            // 
            this.barCheckItem28.Caption = "Seven";
            this.barCheckItem28.GroupIndex = 1;
            this.barCheckItem28.Id = 60;
            this.barCheckItem28.Name = "barCheckItem28";
            // 
            // barCheckItem29
            // 
            this.barCheckItem29.Caption = "Seven Classic";
            this.barCheckItem29.GroupIndex = 1;
            this.barCheckItem29.Id = 61;
            this.barCheckItem29.Name = "barCheckItem29";
            // 
            // barCheckItem30
            // 
            this.barCheckItem30.Caption = "Sharp";
            this.barCheckItem30.GroupIndex = 1;
            this.barCheckItem30.Id = 62;
            this.barCheckItem30.Name = "barCheckItem30";
            // 
            // barCheckItem31
            // 
            this.barCheckItem31.Caption = "Sharp Plus";
            this.barCheckItem31.GroupIndex = 1;
            this.barCheckItem31.Id = 63;
            this.barCheckItem31.Name = "barCheckItem31";
            // 
            // barCheckItem32
            // 
            this.barCheckItem32.Caption = "Springtime";
            this.barCheckItem32.GroupIndex = 1;
            this.barCheckItem32.Id = 64;
            this.barCheckItem32.Name = "barCheckItem32";
            // 
            // barCheckItem33
            // 
            this.barCheckItem33.Caption = "Stardust";
            this.barCheckItem33.GroupIndex = 1;
            this.barCheckItem33.Id = 65;
            this.barCheckItem33.Name = "barCheckItem33";
            // 
            // barCheckItem34
            // 
            this.barCheckItem34.Caption = "Valentine";
            this.barCheckItem34.GroupIndex = 1;
            this.barCheckItem34.Id = 66;
            this.barCheckItem34.Name = "barCheckItem34";
            // 
            // barCheckItem35
            // 
            this.barCheckItem35.Caption = "Xmas 2008 Blue";
            this.barCheckItem35.GroupIndex = 1;
            this.barCheckItem35.Id = 67;
            this.barCheckItem35.Name = "barCheckItem35";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Office";
            this.barSubItem4.Id = 23;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem14),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem16)});
            this.barSubItem4.Name = "barSubItem4";
            this.barSubItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barCheckItem9
            // 
            this.barCheckItem9.Caption = "Office 2007 Black";
            this.barCheckItem9.GroupIndex = 1;
            this.barCheckItem9.Id = 40;
            this.barCheckItem9.Name = "barCheckItem9";
            // 
            // barCheckItem10
            // 
            this.barCheckItem10.Caption = "Office 2007 Blue";
            this.barCheckItem10.GroupIndex = 1;
            this.barCheckItem10.Id = 41;
            this.barCheckItem10.Name = "barCheckItem10";
            // 
            // barCheckItem11
            // 
            this.barCheckItem11.Caption = "Office 2007 Green";
            this.barCheckItem11.GroupIndex = 1;
            this.barCheckItem11.Id = 42;
            this.barCheckItem11.Name = "barCheckItem11";
            // 
            // barCheckItem12
            // 
            this.barCheckItem12.Caption = "Office 2007 Black Pink";
            this.barCheckItem12.GroupIndex = 1;
            this.barCheckItem12.Id = 43;
            this.barCheckItem12.Name = "barCheckItem12";
            // 
            // barCheckItem13
            // 
            this.barCheckItem13.Caption = "Office 2007 Silver";
            this.barCheckItem13.GroupIndex = 1;
            this.barCheckItem13.Id = 44;
            this.barCheckItem13.Name = "barCheckItem13";
            // 
            // barCheckItem14
            // 
            this.barCheckItem14.Caption = "Office 2010 Black";
            this.barCheckItem14.GroupIndex = 1;
            this.barCheckItem14.Id = 45;
            this.barCheckItem14.Name = "barCheckItem14";
            // 
            // barCheckItem15
            // 
            this.barCheckItem15.Caption = "Office 2010 Blue";
            this.barCheckItem15.GroupIndex = 1;
            this.barCheckItem15.Id = 46;
            this.barCheckItem15.Name = "barCheckItem15";
            // 
            // barCheckItem16
            // 
            this.barCheckItem16.Caption = "Office 2010 Silver";
            this.barCheckItem16.GroupIndex = 1;
            this.barCheckItem16.Id = 48;
            this.barCheckItem16.Name = "barCheckItem16";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Phục hồi";
            this.barButtonItem1.Id = 71;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bar_2
            // 
            this.bar_2.BarName = "Custom 5";
            this.bar_2.DockCol = 0;
            this.bar_2.DockRow = 1;
            this.bar_2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar_2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiBook),
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiPrintCard),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiSupplierReturn),
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiBuyOld),
            new DevExpress.XtraBars.LinkPersistInfo(this.blbiChangePass),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem5)});
            this.bar_2.OptionsBar.MultiLine = true;
            this.bar_2.OptionsBar.UseWholeRow = true;
            this.bar_2.Text = "Custom 5";
            // 
            // blbiBook
            // 
            this.blbiBook.Caption = "Quản lý sách";
            this.blbiBook.Id = 9;
            this.blbiBook.LargeImageIndex = 2;
            this.blbiBook.Name = "blbiBook";
            this.blbiBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiBook_ItemClick);
            // 
            // blbiPrintCard
            // 
            this.blbiPrintCard.Caption = "In thẻ thư viện";
            this.blbiPrintCard.Id = 10;
            this.blbiPrintCard.LargeImageIndex = 3;
            this.blbiPrintCard.Name = "blbiPrintCard";
            this.blbiPrintCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiPrintCard_ItemClick);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Quản lý bạn đọc";
            this.barLargeButtonItem1.Id = 11;
            this.barLargeButtonItem1.LargeImageIndex = 1;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            this.barLargeButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem1_ItemClick);
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Sách quá hạn trả";
            this.barLargeButtonItem2.Id = 12;
            this.barLargeButtonItem2.LargeImageIndex = 4;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            this.barLargeButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem2_ItemClick);
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Nhập Kho NCC";
            this.barLargeButtonItem3.Id = 13;
            this.barLargeButtonItem3.LargeImageIndex = 5;
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            this.barLargeButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem3_ItemClick);
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "Hàng tồn kho ";
            this.barLargeButtonItem4.Id = 14;
            this.barLargeButtonItem4.LargeImageIndex = 7;
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
            this.barLargeButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem4_ItemClick);
            // 
            // blbiSupplierReturn
            // 
            this.blbiSupplierReturn.Caption = "Trả hàng NCC";
            this.blbiSupplierReturn.Id = 16;
            this.blbiSupplierReturn.LargeImageIndex = 9;
            this.blbiSupplierReturn.Name = "blbiSupplierReturn";
            this.blbiSupplierReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiSupplierReturn_ItemClick);
            // 
            // blbiBuyOld
            // 
            this.blbiBuyOld.Caption = "Thanh lý sách";
            this.blbiBuyOld.Id = 17;
            this.blbiBuyOld.LargeImageIndex = 8;
            this.blbiBuyOld.Name = "blbiBuyOld";
            this.blbiBuyOld.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiBuyOld_ItemClick);
            // 
            // blbiChangePass
            // 
            this.blbiChangePass.Caption = "Đổi mật khẩu";
            this.blbiChangePass.Id = 18;
            this.blbiChangePass.LargeImageIndex = 10;
            this.blbiChangePass.Name = "blbiChangePass";
            this.blbiChangePass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.blbiChangePass_ItemClick);
            // 
            // barLargeButtonItem5
            // 
            this.barLargeButtonItem5.Caption = "Backup";
            this.barLargeButtonItem5.Id = 19;
            this.barLargeButtonItem5.LargeImageIndex = 11;
            this.barLargeButtonItem5.Name = "barLargeButtonItem5";
            this.barLargeButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem5_ItemClick);
            // 
            // barDockControl_0
            // 
            this.barDockControl_0.CausesValidation = false;
            this.barDockControl_0.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl_0.Location = new System.Drawing.Point(0, 0);
            this.barDockControl_0.Size = new System.Drawing.Size(942, 87);
            // 
            // barDockControl_1
            // 
            this.barDockControl_1.CausesValidation = false;
            this.barDockControl_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl_1.Location = new System.Drawing.Point(0, 489);
            this.barDockControl_1.Size = new System.Drawing.Size(942, 26);
            // 
            // barDockControl_2
            // 
            this.barDockControl_2.CausesValidation = false;
            this.barDockControl_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl_2.Location = new System.Drawing.Point(0, 87);
            this.barDockControl_2.Size = new System.Drawing.Size(0, 402);
            // 
            // barDockControl_3
            // 
            this.barDockControl_3.CausesValidation = false;
            this.barDockControl_3.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl_3.Location = new System.Drawing.Point(942, 87);
            this.barDockControl_3.Size = new System.Drawing.Size(0, 402);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "FrmMain1_16_0.png");
            this.imageList_0.Images.SetKeyName(1, "FrmMain1_16_1.png");
            this.imageList_0.Images.SetKeyName(2, "FrmMain1_16_2.png");
            this.imageList_0.Images.SetKeyName(3, "FrmMain1_16_3.png");
            this.imageList_0.Images.SetKeyName(4, "FrmMain1_16_4.png");
            this.imageList_0.Images.SetKeyName(5, "FrmMain1_16_5.png");
            this.imageList_0.Images.SetKeyName(6, "FrmMain1_16_6.png");
            this.imageList_0.Images.SetKeyName(7, "FrmMain1_16_7.png");
            this.imageList_0.Images.SetKeyName(8, "FrmMain1_16_8.png");
            this.imageList_0.Images.SetKeyName(9, "FrmMain1_16_9.png");
            this.imageList_0.Images.SetKeyName(10, "FrmMain1_16_10.png");
            this.imageList_0.Images.SetKeyName(11, "FrmMain1_16_11.png");
            this.imageList_0.Images.SetKeyName(12, "FrmMain1_16_12.png");
            this.imageList_0.Images.SetKeyName(13, "FrmMain1_16_13.png");
            this.imageList_0.Images.SetKeyName(14, "FrmMain1_16_14.png");
            this.imageList_0.Images.SetKeyName(15, "FrmMain1_16_15.png");
            this.imageList_0.Images.SetKeyName(16, "FrmMain1_16_16.png");
            this.imageList_0.Images.SetKeyName(17, "folder2_green.png");
            this.imageList_0.Images.SetKeyName(18, "FrmMain1_16_18.png");
            this.imageList_0.Images.SetKeyName(19, "FrmMain1_16_19.png");
            this.imageList_0.Images.SetKeyName(20, "document_view.png");
            this.imageList_0.Images.SetKeyName(21, "FrmMain1_16_21.png");
            this.imageList_0.Images.SetKeyName(22, "FrmMain1_16_22.png");
            this.imageList_0.Images.SetKeyName(23, "check.png");
            // 
            // iPass
            // 
            this.iPass.Caption = "Đổi mật khẩu";
            this.iPass.Id = 3;
            this.iPass.ImageIndex = 2;
            this.iPass.Name = "iPass";
            this.iPass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iPass_ItemClick);
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
            this.iMail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iMail_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Black";
            this.barStaticItem2.Id = 24;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Blue";
            this.barStaticItem3.Id = 25;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Caramel";
            this.barStaticItem4.Id = 26;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem5
            // 
            this.barStaticItem5.Caption = "iMaginary";
            this.barStaticItem5.Id = 27;
            this.barStaticItem5.Name = "barStaticItem5";
            this.barStaticItem5.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem6
            // 
            this.barStaticItem6.Caption = "Lilian";
            this.barStaticItem6.Id = 28;
            this.barStaticItem6.Name = "barStaticItem6";
            this.barStaticItem6.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem7
            // 
            this.barStaticItem7.Caption = "Money twins";
            this.barStaticItem7.Id = 29;
            this.barStaticItem7.Name = "barStaticItem7";
            this.barStaticItem7.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem8
            // 
            this.barStaticItem8.Caption = "Summer 2008";
            this.barStaticItem8.Id = 30;
            this.barStaticItem8.Name = "barStaticItem8";
            this.barStaticItem8.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Caramel";
            this.barSubItem5.Id = 34;
            this.barSubItem5.Name = "barSubItem5";
            // 
            // imageCollection_0
            // 
            this.imageCollection_0.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection_0.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection_0.ImageStream")));
            this.imageCollection_0.Images.SetKeyName(0, "32box.png");
            this.imageCollection_0.Images.SetKeyName(1, "32businessman.png");
            this.imageCollection_0.Images.SetKeyName(2, "32book_blue.png");
            this.imageCollection_0.Images.SetKeyName(3, "32printer.png");
            this.imageCollection_0.Images.SetKeyName(4, "32stopwatch_red.png");
            this.imageCollection_0.Images.SetKeyName(5, "32export2.png");
            this.imageCollection_0.Images.SetKeyName(6, "32firewall.png");
            this.imageCollection_0.Images.SetKeyName(7, "Goods_warehouse_products_shipping_Fix1.png");
            this.imageCollection_0.Images.SetKeyName(8, "1428956435_palet03.png");
            this.imageCollection_0.Images.SetKeyName(9, "32truck_red.png");
            this.imageCollection_0.Images.SetKeyName(10, "32key.png");
            this.imageCollection_0.Images.SetKeyName(11, "32gear.png");
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
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
            // imageList_1
            // 
            this.imageList_1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_1.ImageStream")));
            this.imageList_1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_1.Images.SetKeyName(0, "FrmMain1_32_0.png");
            this.imageList_1.Images.SetKeyName(1, "FrmMain1_32_1.png");
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
            this.navBarControl1.LargeImages = this.imageCollection_0;
            this.navBarControl1.Location = new System.Drawing.Point(1, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 196;
            this.navBarControl1.Size = new System.Drawing.Size(203, 632);
            this.navBarControl1.SmallImages = this.imageList_0;
            this.navBarControl1.TabIndex = 6;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Quản lý phiếu";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.iLoan),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iReturn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iLoanList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.iBookFinder)});
            this.navBarGroup1.LargeImageIndex = 0;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // iLoan
            // 
            this.iLoan.Caption = "Phiếu mượn sách";
            this.iLoan.Name = "iLoan";
            this.iLoan.SmallImageIndex = 17;
            this.iLoan.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.iLoan_LinkClicked);
            // 
            // iReturn
            // 
            this.iReturn.Caption = "Phiếu trả sách";
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
            this.navBarGroup2.LargeImageIndex = 1;
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
            // cnvLekth7
            // 
            this.cnvLekth7.Controls.Add(this.navBarControl1);
            this.cnvLekth7.Dock = System.Windows.Forms.DockStyle.Left;
            this.cnvLekth7.Location = new System.Drawing.Point(0, 87);
            this.cnvLekth7.Name = "cnvLekth7";
            this.cnvLekth7.Size = new System.Drawing.Size(206, 402);
            this.cnvLekth7.TabIndex = 7;
            // 
            // defaultLookAndFeel_0
            // 
            this.defaultLookAndFeel_0.LookAndFeel.SkinName = "DevExpress Style";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 515);
            this.Controls.Add(this.cnvLekth7);
            this.Controls.Add(this.barDockControl_4);
            this.Controls.Add(this.barDockControl_2);
            this.Controls.Add(this.barDockControl_3);
            this.Controls.Add(this.barDockControl_1);
            this.Controls.Add(this.barDockControl_0);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnvLekth7)).EndInit();
            this.cnvLekth7.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Bar statusBar;
        private Bar menuBar;
        private Bar bar_2;
        private Bar bar_3;
        private BarDockControl barDockControl_0;
        private BarDockControl barDockControl_1;
        private BarDockControl barDockControl_2;
        private BarDockControl barDockControl_3;
        private BarDockControl barDockControl_4;
        private BarManager barManager_0;
        private BarStaticItem barStaticItem1;
        private PanelControl cnvLekth7;
        private DefaultLookAndFeel defaultLookAndFeel_0;
        private Form form_0;
        private NavBarItem iBookFinder;
        private NavBarItem iCardDef;
        //private IContainer components;
        private NavBarItem iLoan;
        private NavBarItem iLoanList;
        private DevExpress.Utils.ImageCollection imageCollection_0;
        private ImageList imageList_0;
        private ImageList imageList_1;
        private BarButtonItem iMail;
        private BarButtonItem iPass;
        private NavBarItem iReaderInfo;
        private NavBarItem iReaderList;
        private NavBarItem iReturn;
        private NavBarControl navBarControl1;
        private NavBarGroup navBarGroup1;
        private NavBarGroup navBarGroup2;
        private NavBarItem navBarItem10;
        private NavBarItem navBarItem11;
        private NavBarItem navBarItem12;
        private NavBarItem navBarItem7;
        private NavBarItem navBarItem8;
        private NavBarItem navBarItem9;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private BarStaticItem Txt_Date;

        #endregion
        private BarLargeButtonItem blbiBook;
        private BarLargeButtonItem blbiPrintCard;
        private BarLargeButtonItem barLargeButtonItem1;
        private BarLargeButtonItem barLargeButtonItem2;
        private BarLargeButtonItem barLargeButtonItem3;
        private BarLargeButtonItem barLargeButtonItem4;
        private BarLargeButtonItem blbiSupplierReturn;
        private BarLargeButtonItem blbiBuyOld;
        private BarLargeButtonItem blbiChangePass;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private BarLargeButtonItem barLargeButtonItem5;
        private BarSubItem barSubItem1;
        private BarSubItem barSubItem2;
        private BarSubItem barSubItem3;
        private BarSubItem barSubItem4;
        private BarStaticItem barStaticItem2;
        private BarStaticItem barStaticItem3;
        private BarStaticItem barStaticItem4;
        private BarStaticItem barStaticItem5;
        private BarStaticItem barStaticItem6;
        private BarStaticItem barStaticItem7;
        private BarStaticItem barStaticItem8;
        private BarCheckItem barCheckItem2;
        private BarCheckItem barCheckItem1;
        private BarCheckItem barCheckItem3;
        private BarCheckItem barCheckItem4;
        private BarCheckItem barCheckItem5;
        private BarCheckItem barCheckItem6;
        private BarCheckItem barCheckItem7;
        private BarSubItem barSubItem5;
        private BarCheckItem barCheckItem8;
        private BarCheckItem barCheckItem18;
        private BarCheckItem barCheckItem17;
        private BarCheckItem barCheckItem19;
        private BarCheckItem barCheckItem20;
        private BarCheckItem barCheckItem21;
        private BarCheckItem barCheckItem22;
        private BarCheckItem barCheckItem23;
        private BarCheckItem barCheckItem24;
        private BarCheckItem barCheckItem25;
        private BarCheckItem barCheckItem9;
        private BarCheckItem barCheckItem10;
        private BarCheckItem barCheckItem11;
        private BarCheckItem barCheckItem12;
        private BarCheckItem barCheckItem13;
        private BarCheckItem barCheckItem14;
        private BarCheckItem barCheckItem15;
        private BarCheckItem barCheckItem16;
        private BarCheckItem barCheckItem26;
        private BarCheckItem barCheckItem27;
        private BarCheckItem barCheckItem28;
        private BarCheckItem barCheckItem29;
        private BarCheckItem barCheckItem30;
        private BarCheckItem barCheckItem31;
        private BarCheckItem barCheckItem32;
        private BarCheckItem barCheckItem33;
        private BarCheckItem barCheckItem34;
        private BarCheckItem barCheckItem35;
        private BarButtonItem barButtonItem1;

    }
}
