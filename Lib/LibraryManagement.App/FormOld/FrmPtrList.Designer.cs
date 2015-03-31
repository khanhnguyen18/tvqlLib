using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmPtrList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPtrList));
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_UserName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TransName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TransNum = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TranDate = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TransCode = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_PosId = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_PosName = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.GrdTranDetail = new DevExpress.XtraGrid.GridControl();
            this.DetailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdTransList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.printingSystem_0 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink_0 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Remark = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_duaration = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTranDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl6
            // 
            this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl6.Appearance.Options.UseFont = true;
            this.LabelControl6.Location = new System.Drawing.Point(367, 196);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(48, 13);
            this.LabelControl6.TabIndex = 381;
            this.LabelControl6.Text = "Nhân viên";
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_UserName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_UserName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_UserName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_UserName.Appearance.Options.UseBackColor = true;
            this.Lbl_UserName.Appearance.Options.UseBorderColor = true;
            this.Lbl_UserName.Appearance.Options.UseFont = true;
            this.Lbl_UserName.Appearance.Options.UseForeColor = true;
            this.Lbl_UserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_UserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_UserName.Location = new System.Drawing.Point(421, 195);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_UserName.Size = new System.Drawing.Size(221, 17);
            this.Lbl_UserName.TabIndex = 380;
            // 
            // Lbl_TransName
            // 
            this.Lbl_TransName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_TransName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_TransName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_TransName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TransName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TransName.Appearance.Options.UseBackColor = true;
            this.Lbl_TransName.Appearance.Options.UseBorderColor = true;
            this.Lbl_TransName.Appearance.Options.UseFont = true;
            this.Lbl_TransName.Appearance.Options.UseForeColor = true;
            this.Lbl_TransName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_TransName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_TransName.Location = new System.Drawing.Point(156, 219);
            this.Lbl_TransName.Name = "Lbl_TransName";
            this.Lbl_TransName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_TransName.Size = new System.Drawing.Size(196, 17);
            this.Lbl_TransName.TabIndex = 379;
            // 
            // Lbl_TransNum
            // 
            this.Lbl_TransNum.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Lbl_TransNum.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_TransNum.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_TransNum.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TransNum.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TransNum.Appearance.Options.UseBackColor = true;
            this.Lbl_TransNum.Appearance.Options.UseBorderColor = true;
            this.Lbl_TransNum.Appearance.Options.UseFont = true;
            this.Lbl_TransNum.Appearance.Options.UseForeColor = true;
            this.Lbl_TransNum.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_TransNum.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_TransNum.Location = new System.Drawing.Point(119, 196);
            this.Lbl_TransNum.Name = "Lbl_TransNum";
            this.Lbl_TransNum.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_TransNum.Size = new System.Drawing.Size(104, 17);
            this.Lbl_TransNum.TabIndex = 378;
            this.Lbl_TransNum.TextChanged += new System.EventHandler(this.Lbl_TransNum_TextChanged);
            // 
            // Lbl_TranDate
            // 
            this.Lbl_TranDate.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_TranDate.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_TranDate.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_TranDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TranDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TranDate.Appearance.Options.UseBackColor = true;
            this.Lbl_TranDate.Appearance.Options.UseBorderColor = true;
            this.Lbl_TranDate.Appearance.Options.UseFont = true;
            this.Lbl_TranDate.Appearance.Options.UseForeColor = true;
            this.Lbl_TranDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_TranDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_TranDate.Location = new System.Drawing.Point(229, 196);
            this.Lbl_TranDate.Name = "Lbl_TranDate";
            this.Lbl_TranDate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_TranDate.Size = new System.Drawing.Size(72, 17);
            this.Lbl_TranDate.TabIndex = 377;
            // 
            // Lbl_TransCode
            // 
            this.Lbl_TransCode.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_TransCode.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_TransCode.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_TransCode.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TransCode.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TransCode.Appearance.Options.UseBackColor = true;
            this.Lbl_TransCode.Appearance.Options.UseBorderColor = true;
            this.Lbl_TransCode.Appearance.Options.UseFont = true;
            this.Lbl_TransCode.Appearance.Options.UseForeColor = true;
            this.Lbl_TransCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_TransCode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_TransCode.Location = new System.Drawing.Point(119, 219);
            this.Lbl_TransCode.Name = "Lbl_TransCode";
            this.Lbl_TransCode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_TransCode.Size = new System.Drawing.Size(32, 17);
            this.Lbl_TransCode.TabIndex = 376;
            this.Lbl_TransCode.TextChanged += new System.EventHandler(this.Lbl_TransCode_TextChanged);
            // 
            // Lbl_PosId
            // 
            this.Lbl_PosId.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_PosId.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_PosId.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_PosId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PosId.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_PosId.Appearance.Options.UseBackColor = true;
            this.Lbl_PosId.Appearance.Options.UseBorderColor = true;
            this.Lbl_PosId.Appearance.Options.UseFont = true;
            this.Lbl_PosId.Appearance.Options.UseForeColor = true;
            this.Lbl_PosId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_PosId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_PosId.Location = new System.Drawing.Point(119, 241);
            this.Lbl_PosId.Name = "Lbl_PosId";
            this.Lbl_PosId.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_PosId.Size = new System.Drawing.Size(90, 17);
            this.Lbl_PosId.TabIndex = 375;
            this.Lbl_PosId.TextChanged += new System.EventHandler(this.Lbl_PosId_TextChanged);
            // 
            // Lbl_PosName
            // 
            this.Lbl_PosName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_PosName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_PosName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_PosName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PosName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_PosName.Appearance.Options.UseBackColor = true;
            this.Lbl_PosName.Appearance.Options.UseBorderColor = true;
            this.Lbl_PosName.Appearance.Options.UseFont = true;
            this.Lbl_PosName.Appearance.Options.UseForeColor = true;
            this.Lbl_PosName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_PosName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_PosName.Location = new System.Drawing.Point(219, 241);
            this.Lbl_PosName.Name = "Lbl_PosName";
            this.Lbl_PosName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_PosName.Size = new System.Drawing.Size(423, 17);
            this.Lbl_PosName.TabIndex = 373;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(32, 219);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(36, 13);
            this.LabelControl4.TabIndex = 371;
            this.LabelControl4.Text = "Loại GD";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(32, 242);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(58, 13);
            this.LabelControl3.TabIndex = 370;
            this.LabelControl3.Text = "Quầy bán lẻ";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(32, 196);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(57, 13);
            this.LabelControl1.TabIndex = 368;
            this.LabelControl1.Text = "Số giao dịch";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(398, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 367;
            this.btnExit.Text = "ESC-Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrintInvoice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.Appearance.Options.UseFont = true;
            this.btnPrintInvoice.Location = new System.Drawing.Point(186, 445);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(88, 23);
            this.btnPrintInvoice.TabIndex = 365;
            this.btnPrintInvoice.Text = "In giao dịch";
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(292, 445);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 366;
            this.btnPrint.Text = "In toàn bộ";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // GrdTranDetail
            // 
            this.GrdTranDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTranDetail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrdTranDetail.Location = new System.Drawing.Point(13, 264);
            this.GrdTranDetail.MainView = this.DetailView;
            this.GrdTranDetail.Name = "GrdTranDetail";
            this.GrdTranDetail.Size = new System.Drawing.Size(647, 163);
            this.GrdTranDetail.TabIndex = 364;
            this.GrdTranDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DetailView});
            // 
            // DetailView
            // 
            this.DetailView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailView.Appearance.FooterPanel.Options.UseFont = true;
            this.DetailView.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailView.Appearance.GroupFooter.Options.UseFont = true;
            this.DetailView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailView.Appearance.HeaderPanel.Options.UseFont = true;
            this.DetailView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailView.Appearance.Row.Options.UseFont = true;
            this.DetailView.GridControl = this.GrdTranDetail;
            this.DetailView.Name = "DetailView";
            this.DetailView.OptionsView.ShowAutoFilterRow = true;
            this.DetailView.OptionsView.ShowFooter = true;
            this.DetailView.OptionsView.ShowGroupPanel = false;
            // 
            // GrdTransList
            // 
            this.GrdTransList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTransList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrdTransList.Location = new System.Drawing.Point(13, 27);
            this.GrdTransList.MainView = this.gridView1;
            this.GrdTransList.Name = "GrdTransList";
            this.GrdTransList.Size = new System.Drawing.Size(647, 162);
            this.GrdTransList.TabIndex = 363;
            this.GrdTransList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.GridView2});
            this.GrdTransList.CursorChanged += new System.EventHandler(this.GrdTransList_CursorChanged);
            this.GrdTransList.Click += new System.EventHandler(this.GrdTransList_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.GrdTransList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // GridView2
            // 
            this.GridView2.GridControl = this.GrdTransList;
            this.GridView2.Name = "GridView2";
            // 
            // printingSystem_0
            // 
            this.printingSystem_0.Links.AddRange(new object[] {
            this.printableComponentLink_0});
            // 
            // printableComponentLink_0
            // 
            this.printableComponentLink_0.Component = this.GrdTransList;
            // 
            // 
            // 
            this.printableComponentLink_0.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink_0.ImageCollection.ImageStream")));
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(367, 220);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 383;
            this.labelControl2.Text = "Ghi chú";
            // 
            // Lbl_Remark
            // 
            this.Lbl_Remark.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_Remark.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_Remark.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_Remark.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Remark.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Remark.Appearance.Options.UseBackColor = true;
            this.Lbl_Remark.Appearance.Options.UseBorderColor = true;
            this.Lbl_Remark.Appearance.Options.UseFont = true;
            this.Lbl_Remark.Appearance.Options.UseForeColor = true;
            this.Lbl_Remark.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_Remark.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_Remark.Location = new System.Drawing.Point(421, 219);
            this.Lbl_Remark.Name = "Lbl_Remark";
            this.Lbl_Remark.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_Remark.Size = new System.Drawing.Size(221, 17);
            this.Lbl_Remark.TabIndex = 382;
            // 
            // Lbl_duaration
            // 
            this.Lbl_duaration.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_duaration.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbl_duaration.Appearance.Options.UseFont = true;
            this.Lbl_duaration.Appearance.Options.UseForeColor = true;
            this.Lbl_duaration.Location = new System.Drawing.Point(13, 8);
            this.Lbl_duaration.Name = "Lbl_duaration";
            this.Lbl_duaration.Size = new System.Drawing.Size(243, 13);
            this.Lbl_duaration.TabIndex = 384;
            this.Lbl_duaration.Text = "Từ ngày 20/01/2010 đến ngày 30/01/2010";
            // 
            // FrmPtrList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(672, 482);
            this.Controls.Add(this.Lbl_duaration);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Lbl_Remark);
            this.Controls.Add(this.LabelControl6);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.Lbl_TransName);
            this.Controls.Add(this.Lbl_TransNum);
            this.Controls.Add(this.Lbl_TranDate);
            this.Controls.Add(this.Lbl_TransCode);
            this.Controls.Add(this.Lbl_PosId);
            this.Controls.Add(this.Lbl_PosName);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.GrdTranDetail);
            this.Controls.Add(this.GrdTransList);
            this.Name = "FrmPtrList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPtrList";
            this.Load += new System.EventHandler(this.FrmPtrList_Load);
            this.Activated += new System.EventHandler(this.FrmPtrList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTranDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        internal SimpleButton btnPrintInvoice;
        internal GridView DetailView;
        internal GridControl GrdTranDetail;
        internal GridControl GrdTransList;
        internal GridView gridView1;
        internal GridView GridView2;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl labelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl6;
        private LabelControl Lbl_duaration;
        internal LabelControl Lbl_PosId;
        internal LabelControl Lbl_PosName;
        internal LabelControl Lbl_Remark;
        internal LabelControl Lbl_TranDate;
        internal LabelControl Lbl_TransCode;
        internal LabelControl Lbl_TransName;
        internal LabelControl Lbl_TransNum;
        internal LabelControl Lbl_UserName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private string string_0;
        #endregion

    }
}
