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
    partial class FrmOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderList));
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Remark = new DevExpress.XtraEditors.LabelControl();
            this.IipWvDcZu = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_UserName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TransNum = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TranDate = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ExpId = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ExpName = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.GrdTranDetail = new DevExpress.XtraGrid.GridControl();
            this.DetailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdTransList = new DevExpress.XtraGrid.GridControl();
            this.TransView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.printingSystem_0 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink_0 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.Lbl_Delevery = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTranDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl7
            // 
            this.LabelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl7.Appearance.Options.UseFont = true;
            this.LabelControl7.Location = new System.Drawing.Point(32, 411);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(35, 13);
            this.LabelControl7.TabIndex = 383;
            this.LabelControl7.Text = "Ghi chú";
            // 
            // Lbl_Remark
            // 
            this.Lbl_Remark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Lbl_Remark.Location = new System.Drawing.Point(119, 407);
            this.Lbl_Remark.Name = "Lbl_Remark";
            this.Lbl_Remark.Size = new System.Drawing.Size(484, 17);
            this.Lbl_Remark.TabIndex = 382;
            // 
            // IipWvDcZu
            // 
            this.IipWvDcZu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IipWvDcZu.Appearance.Options.UseFont = true;
            this.IipWvDcZu.Location = new System.Drawing.Point(431, 241);
            this.IipWvDcZu.Name = "IipWvDcZu";
            this.IipWvDcZu.Size = new System.Drawing.Size(74, 13);
            this.IipWvDcZu.TabIndex = 381;
            this.IipWvDcZu.Text = "Người đặt hàng";
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
            this.Lbl_UserName.Location = new System.Drawing.Point(511, 239);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_UserName.Size = new System.Drawing.Size(149, 17);
            this.Lbl_UserName.TabIndex = 380;
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
            this.Lbl_TransNum.Location = new System.Drawing.Point(119, 240);
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
            this.Lbl_TranDate.Location = new System.Drawing.Point(229, 240);
            this.Lbl_TranDate.Name = "Lbl_TranDate";
            this.Lbl_TranDate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_TranDate.Size = new System.Drawing.Size(72, 17);
            this.Lbl_TranDate.TabIndex = 377;
            // 
            // Lbl_ExpId
            // 
            this.Lbl_ExpId.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_ExpId.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_ExpId.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_ExpId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ExpId.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_ExpId.Appearance.Options.UseBackColor = true;
            this.Lbl_ExpId.Appearance.Options.UseBorderColor = true;
            this.Lbl_ExpId.Appearance.Options.UseFont = true;
            this.Lbl_ExpId.Appearance.Options.UseForeColor = true;
            this.Lbl_ExpId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_ExpId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_ExpId.Location = new System.Drawing.Point(119, 262);
            this.Lbl_ExpId.Name = "Lbl_ExpId";
            this.Lbl_ExpId.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_ExpId.Size = new System.Drawing.Size(61, 17);
            this.Lbl_ExpId.TabIndex = 374;
            // 
            // Lbl_ExpName
            // 
            this.Lbl_ExpName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_ExpName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_ExpName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_ExpName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ExpName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_ExpName.Appearance.Options.UseBackColor = true;
            this.Lbl_ExpName.Appearance.Options.UseBorderColor = true;
            this.Lbl_ExpName.Appearance.Options.UseFont = true;
            this.Lbl_ExpName.Appearance.Options.UseForeColor = true;
            this.Lbl_ExpName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_ExpName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_ExpName.Location = new System.Drawing.Point(186, 262);
            this.Lbl_ExpName.Name = "Lbl_ExpName";
            this.Lbl_ExpName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_ExpName.Size = new System.Drawing.Size(263, 17);
            this.Lbl_ExpName.TabIndex = 372;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(32, 264);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(65, 13);
            this.LabelControl2.TabIndex = 369;
            this.LabelControl2.Text = "Nhà cung cấp";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(32, 240);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(60, 13);
            this.LabelControl1.TabIndex = 368;
            this.LabelControl1.Text = "Số đơn hàng";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(439, 438);
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
            this.btnPrintInvoice.Location = new System.Drawing.Point(145, 438);
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
            this.btnPrint.Location = new System.Drawing.Point(243, 438);
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
            this.GrdTranDetail.Location = new System.Drawing.Point(13, 285);
            this.GrdTranDetail.MainView = this.DetailView;
            this.GrdTranDetail.Name = "GrdTranDetail";
            this.GrdTranDetail.Size = new System.Drawing.Size(647, 116);
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
            this.GrdTransList.Location = new System.Drawing.Point(13, 11);
            this.GrdTransList.MainView = this.TransView;
            this.GrdTransList.Name = "GrdTransList";
            this.GrdTransList.Size = new System.Drawing.Size(647, 222);
            this.GrdTransList.TabIndex = 363;
            this.GrdTransList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TransView,
            this.GridView2});
            this.GrdTransList.Click += new System.EventHandler(this.GrdTransList_Click);
            // 
            // TransView
            // 
            this.TransView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransView.Appearance.FooterPanel.Options.UseFont = true;
            this.TransView.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransView.Appearance.GroupPanel.Options.UseFont = true;
            this.TransView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransView.Appearance.HeaderPanel.Options.UseFont = true;
            this.TransView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransView.Appearance.Row.Options.UseFont = true;
            this.TransView.GridControl = this.GrdTransList;
            this.TransView.Name = "TransView";
            this.TransView.OptionsView.ShowAutoFilterRow = true;
            this.TransView.OptionsView.ShowGroupPanel = false;
            this.TransView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.TransView_FocusedRowChanged);
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
            // Lbl_Delevery
            // 
            this.Lbl_Delevery.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_Delevery.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_Delevery.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_Delevery.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Delevery.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Delevery.Appearance.Options.UseBackColor = true;
            this.Lbl_Delevery.Appearance.Options.UseBorderColor = true;
            this.Lbl_Delevery.Appearance.Options.UseFont = true;
            this.Lbl_Delevery.Appearance.Options.UseForeColor = true;
            this.Lbl_Delevery.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_Delevery.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_Delevery.Location = new System.Drawing.Point(570, 262);
            this.Lbl_Delevery.Name = "Lbl_Delevery";
            this.Lbl_Delevery.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_Delevery.Size = new System.Drawing.Size(90, 17);
            this.Lbl_Delevery.TabIndex = 385;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(478, 266);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 384;
            this.labelControl4.Text = "Ngày giao hàng";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(341, 438);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 23);
            this.btn_Delete.TabIndex = 386;
            this.btn_Delete.Text = "Xóa đơn hàng";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // FrmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(672, 475);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.Lbl_Delevery);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.LabelControl7);
            this.Controls.Add(this.Lbl_Remark);
            this.Controls.Add(this.IipWvDcZu);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.Lbl_TransNum);
            this.Controls.Add(this.Lbl_TranDate);
            this.Controls.Add(this.Lbl_ExpId);
            this.Controls.Add(this.Lbl_ExpName);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.GrdTranDetail);
            this.Controls.Add(this.GrdTransList);
            this.Name = "FrmOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderList";
            this.Load += new System.EventHandler(this.FrmOrderList_Load);
            this.Activated += new System.EventHandler(this.FrmOrderList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTranDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTransList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal SimpleButton btn_Delete;
        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        internal SimpleButton btnPrintInvoice;
        internal GridView DetailView;
        internal GridControl GrdTranDetail;
        internal GridControl GrdTransList;
        internal GridView GridView2;
        //private IContainer components;
        internal LabelControl IipWvDcZu;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl2;
        internal LabelControl labelControl4;
        internal LabelControl LabelControl7;
        internal LabelControl Lbl_Delevery;
        internal LabelControl Lbl_ExpId;
        internal LabelControl Lbl_ExpName;
        internal LabelControl Lbl_Remark;
        internal LabelControl Lbl_TranDate;
        internal LabelControl Lbl_TransNum;
        internal LabelControl Lbl_UserName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private string string_0;
        internal GridView TransView;

        #endregion

    }
}
