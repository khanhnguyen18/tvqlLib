using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
    partial class FrmReaderInfo
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReaderInfo));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet_0 = new System.Data.DataSet();
            this.dataTable_0 = new System.Data.DataTable();
            this.dataColumn_0 = new System.Data.DataColumn();
            this.dataColumn_1 = new System.Data.DataColumn();
            this.dataColumn_2 = new System.Data.DataColumn();
            this.dataColumn_3 = new System.Data.DataColumn();
            this.dataTable_1 = new System.Data.DataTable();
            this.dataColumn_4 = new System.Data.DataColumn();
            this.dataColumn_5 = new System.Data.DataColumn();
            this.dataColumn_6 = new System.Data.DataColumn();
            this.dataColumn_7 = new System.Data.DataColumn();
            this.dataColumn_8 = new System.Data.DataColumn();
            this.kCnalMegv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltrans_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgoods_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldue_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_History = new DevExpress.XtraEditors.SimpleButton();
            this.printingSystem_0 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink_0 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblDueDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblOpenDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblFullName = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtCsId = new DevExpress.XtraEditors.TextEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltrans_num1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltran_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltran_time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrans_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCnalMegv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "booklst";
            this.gridControl1.DataSource = this.dataSet_0;
            this.gridControl1.Location = new System.Drawing.Point(26, 151);
            this.gridControl1.MainView = this.kCnalMegv;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gridControl1.Size = new System.Drawing.Size(615, 133);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.kCnalMegv});
            // 
            // dataSet_0
            // 
            this.dataSet_0.DataSetName = "NewDataSet";
            this.dataSet_0.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable_0,
            this.dataTable_1});
            // 
            // dataTable_0
            // 
            this.dataTable_0.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_0,
            this.dataColumn_1,
            this.dataColumn_2,
            this.dataColumn_3});
            this.dataTable_0.TableName = "booklst";
            // 
            // dataColumn_0
            // 
            this.dataColumn_0.ColumnName = "trans_num";
            // 
            // dataColumn_1
            // 
            this.dataColumn_1.ColumnName = "goods_id";
            // 
            // dataColumn_2
            // 
            this.dataColumn_2.ColumnName = "full_name";
            // 
            // dataColumn_3
            // 
            this.dataColumn_3.ColumnName = "due_date";
            this.dataColumn_3.DataType = typeof(System.DateTime);
            // 
            // dataTable_1
            // 
            this.dataTable_1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_4,
            this.dataColumn_5,
            this.dataColumn_6,
            this.dataColumn_7,
            this.dataColumn_8});
            this.dataTable_1.TableName = "histrans";
            // 
            // dataColumn_4
            // 
            this.dataColumn_4.ColumnName = "trans_num";
            // 
            // dataColumn_5
            // 
            this.dataColumn_5.ColumnName = "tran_date";
            this.dataColumn_5.DataType = typeof(System.DateTime);
            // 
            // dataColumn_6
            // 
            this.dataColumn_6.ColumnName = "tran_time";
            // 
            // dataColumn_7
            // 
            this.dataColumn_7.ColumnName = "trans_code";
            // 
            // dataColumn_8
            // 
            this.dataColumn_8.ColumnName = "remark";
            // 
            // kCnalMegv
            // 
            this.kCnalMegv.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kCnalMegv.Appearance.FooterPanel.Options.UseFont = true;
            this.kCnalMegv.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kCnalMegv.Appearance.GroupFooter.Options.UseFont = true;
            this.kCnalMegv.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kCnalMegv.Appearance.HeaderPanel.Options.UseFont = true;
            this.kCnalMegv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltrans_num,
            this.colgoods_id,
            this.colfull_name,
            this.coldue_date});
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = false;
            this.kCnalMegv.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.kCnalMegv.GridControl = this.gridControl1;
            this.kCnalMegv.Name = "kCnalMegv";
            this.kCnalMegv.OptionsView.ShowAutoFilterRow = true;
            this.kCnalMegv.OptionsView.ShowFooter = true;
            this.kCnalMegv.OptionsView.ShowGroupPanel = false;
            // 
            // coltrans_num
            // 
            this.coltrans_num.Caption = "Số phiếu";
            this.coltrans_num.FieldName = "trans_num";
            this.coltrans_num.Name = "coltrans_num";
            this.coltrans_num.SummaryItem.DisplayFormat = "Tổng : {0:n0}";
            this.coltrans_num.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.coltrans_num.Visible = true;
            this.coltrans_num.VisibleIndex = 0;
            // 
            // colgoods_id
            // 
            this.colgoods_id.Caption = "Mã sách";
            this.colgoods_id.FieldName = "goods_id";
            this.colgoods_id.Name = "colgoods_id";
            this.colgoods_id.Visible = true;
            this.colgoods_id.VisibleIndex = 1;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Tên sách";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 2;
            // 
            // coldue_date
            // 
            this.coldue_date.Caption = "Ngày hẹn trả";
            this.coldue_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldue_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldue_date.FieldName = "due_date";
            this.coldue_date.Name = "coldue_date";
            this.coldue_date.Visible = true;
            this.coldue_date.VisibleIndex = 3;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(340, 450);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 23);
            this.btn_Exit.TabIndex = 383;
            this.btn_Exit.Text = "ESC-Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_History
            // 
            this.btn_History.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_History.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Appearance.Options.UseFont = true;
            this.btn_History.Location = new System.Drawing.Point(235, 450);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(88, 23);
            this.btn_History.TabIndex = 382;
            this.btn_History.Text = "In";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // printingSystem_0
            // 
            this.printingSystem_0.Links.AddRange(new object[] {
            this.printableComponentLink_0});
            // 
            // printableComponentLink_0
            // 
            this.printableComponentLink_0.Component = this.gridControl1;
            // 
            // 
            // 
            this.printableComponentLink_0.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink_0.ImageCollection.ImageStream")));
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(434, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(84, 89);
            this.pictureEdit1.TabIndex = 409;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblDueDate.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblDueDate.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblDueDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblDueDate.Appearance.Options.UseBackColor = true;
            this.lblDueDate.Appearance.Options.UseBorderColor = true;
            this.lblDueDate.Appearance.Options.UseFont = true;
            this.lblDueDate.Appearance.Options.UseForeColor = true;
            this.lblDueDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDueDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblDueDate.Location = new System.Drawing.Point(299, 54);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblDueDate.Size = new System.Drawing.Size(98, 15);
            this.lblDueDate.TabIndex = 408;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(234, 54);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 407;
            this.labelControl8.Text = "Hiệu lực đến";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblOpenDate.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblOpenDate.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblOpenDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblOpenDate.Appearance.Options.UseBackColor = true;
            this.lblOpenDate.Appearance.Options.UseBorderColor = true;
            this.lblOpenDate.Appearance.Options.UseFont = true;
            this.lblOpenDate.Appearance.Options.UseForeColor = true;
            this.lblOpenDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOpenDate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblOpenDate.Location = new System.Drawing.Point(116, 54);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblOpenDate.Size = new System.Drawing.Size(97, 15);
            this.lblOpenDate.TabIndex = 406;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(32, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 405;
            this.labelControl6.Text = "Ngày đăng ký";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(32, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 404;
            this.labelControl4.Text = "Email";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdit.Location = new System.Drawing.Point(220, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 20);
            this.btnEdit.TabIndex = 403;
            this.btnEdit.Text = "Bổ sung";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblPhone.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblPhone.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Appearance.Options.UseBackColor = true;
            this.lblPhone.Appearance.Options.UseBorderColor = true;
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Appearance.Options.UseForeColor = true;
            this.lblPhone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPhone.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblPhone.Location = new System.Drawing.Point(116, 73);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPhone.Size = new System.Drawing.Size(281, 15);
            this.lblPhone.TabIndex = 402;
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblEmail.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblEmail.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Appearance.Options.UseBackColor = true;
            this.lblEmail.Appearance.Options.UseBorderColor = true;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblEmail.Location = new System.Drawing.Point(116, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEmail.Size = new System.Drawing.Size(281, 15);
            this.lblEmail.TabIndex = 401;
            // 
            // lblFullName
            // 
            this.lblFullName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblFullName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblFullName.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblFullName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Appearance.Options.UseBackColor = true;
            this.lblFullName.Appearance.Options.UseBorderColor = true;
            this.lblFullName.Appearance.Options.UseFont = true;
            this.lblFullName.Appearance.Options.UseForeColor = true;
            this.lblFullName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFullName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblFullName.Location = new System.Drawing.Point(116, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFullName.Size = new System.Drawing.Size(281, 15);
            this.lblFullName.TabIndex = 400;
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblAddress.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblAddress.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Appearance.Options.UseBackColor = true;
            this.lblAddress.Appearance.Options.UseBorderColor = true;
            this.lblAddress.Appearance.Options.UseFont = true;
            this.lblAddress.Appearance.Options.UseForeColor = true;
            this.lblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAddress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblAddress.Location = new System.Drawing.Point(116, 111);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblAddress.Size = new System.Drawing.Size(407, 15);
            this.lblAddress.TabIndex = 399;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(32, 75);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(49, 13);
            this.LabelControl2.TabIndex = 398;
            this.LabelControl2.Text = "Điện thoại";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(32, 94);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(32, 13);
            this.LabelControl3.TabIndex = 397;
            this.LabelControl3.Text = "Địa chỉ";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(32, 15);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(33, 13);
            this.LabelControl1.TabIndex = 396;
            this.LabelControl1.Text = "Mã thẻ";
            // 
            // LabelControl15
            // 
            this.LabelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl15.Appearance.Options.UseFont = true;
            this.LabelControl15.Location = new System.Drawing.Point(32, 35);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(32, 13);
            this.LabelControl15.TabIndex = 395;
            this.LabelControl15.Text = "Họ tên";
            // 
            // txtCsId
            // 
            this.txtCsId.EnterMoveNextControl = true;
            this.txtCsId.Location = new System.Drawing.Point(116, 12);
            this.txtCsId.Name = "txtCsId";
            this.txtCsId.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsId.Properties.Appearance.Options.UseBackColor = true;
            this.txtCsId.Properties.Appearance.Options.UseFont = true;
            this.txtCsId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCsId.Properties.Mask.PlaceHolder = ' ';
            this.txtCsId.Properties.MaxLength = 8;
            this.txtCsId.Properties.ValidateOnEnterKey = true;
            this.txtCsId.Size = new System.Drawing.Size(98, 20);
            this.txtCsId.TabIndex = 394;
            this.txtCsId.EditValueChanged += new System.EventHandler(this.txtCsId_EditValueChanged);
            this.txtCsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCsId_KeyDown);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataMember = "histrans";
            this.gridControl2.DataSource = this.dataSet_0;
            this.gridControl2.Location = new System.Drawing.Point(26, 316);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit2});
            this.gridControl2.Size = new System.Drawing.Size(615, 126);
            this.gridControl2.TabIndex = 410;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltrans_num1,
            this.coltran_date,
            this.coltran_time,
            this.coltrans_code,
            this.colremark});
            styleFormatCondition3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            styleFormatCondition3.Appearance.Options.UseFont = true;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = false;
            this.gridView2.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition3});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // coltrans_num1
            // 
            this.coltrans_num1.Caption = "Số phiếu";
            this.coltrans_num1.FieldName = "trans_num";
            this.coltrans_num1.Name = "coltrans_num1";
            this.coltrans_num1.Visible = true;
            this.coltrans_num1.VisibleIndex = 0;
            // 
            // coltran_date
            // 
            this.coltran_date.Caption = "Ngày";
            this.coltran_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coltran_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coltran_date.FieldName = "tran_date";
            this.coltran_date.Name = "coltran_date";
            this.coltran_date.Visible = true;
            this.coltran_date.VisibleIndex = 1;
            // 
            // coltran_time
            // 
            this.coltran_time.Caption = "Giờ";
            this.coltran_time.FieldName = "tran_time";
            this.coltran_time.Name = "coltran_time";
            this.coltran_time.Visible = true;
            this.coltran_time.VisibleIndex = 2;
            // 
            // coltrans_code
            // 
            this.coltrans_code.Caption = "Loại";
            this.coltrans_code.FieldName = "trans_code";
            this.coltrans_code.Name = "coltrans_code";
            this.coltrans_code.Visible = true;
            this.coltrans_code.VisibleIndex = 3;
            // 
            // colremark
            // 
            this.colremark.Caption = "Diễn giải";
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            this.colremark.Visible = true;
            this.colremark.VisibleIndex = 4;
            // 
            // repositoryItemImageEdit2
            // 
            this.repositoryItemImageEdit2.AutoHeight = false;
            this.repositoryItemImageEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit2.Name = "repositoryItemImageEdit2";
            this.repositoryItemImageEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(31, 134);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(136, 13);
            this.labelControl5.TabIndex = 411;
            this.labelControl5.Text = "Danh mục sách chưa trả";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(32, 297);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(117, 13);
            this.labelControl7.TabIndex = 412;
            this.labelControl7.Text = "Quá trình mượn sách";
            // 
            // btnView
            // 
            this.btnView.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Appearance.Options.UseFont = true;
            this.btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnView.Location = new System.Drawing.Point(155, 293);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 20);
            this.btnView.TabIndex = 413;
            this.btnView.Text = "Xem";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // FrmReaderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(662, 485);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lblOpenDate);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.LabelControl15);
            this.Controls.Add(this.txtCsId);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmReaderInfo";
            this.Text = "FrmReaderInfo";
            this.Load += new System.EventHandler(this.FrmReaderInfo_Load);
            this.Activated += new System.EventHandler(this.FrmReaderInfo_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCnalMegv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal SimpleButton btn_Exit;
        internal SimpleButton btn_History;
        internal SimpleButton btnEdit;
        internal SimpleButton btnView;
        private GridColumn coldue_date;
        private GridColumn colfull_name;
        private GridColumn colgoods_id;
        private GridColumn colremark;
        private GridColumn coltran_date;
        private GridColumn coltran_time;
        private GridColumn coltrans_code;
        private GridColumn coltrans_num;
        private GridColumn coltrans_num1;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataSet dataSet_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private GridControl gridControl1;
        private GridControl gridControl2;
        private GridView gridView2;
        //private IContainer components;
        private GridView kCnalMegv;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl15;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl labelControl4;
        internal LabelControl labelControl5;
        internal LabelControl labelControl6;
        internal LabelControl labelControl7;
        internal LabelControl labelControl8;
        internal LabelControl lblAddress;
        internal LabelControl lblDueDate;
        internal LabelControl lblEmail;
        internal LabelControl lblFullName;
        internal LabelControl lblOpenDate;
        internal LabelControl lblPhone;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PictureEdit pictureEdit1;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private RepositoryItemImageEdit repositoryItemImageEdit1;
        private RepositoryItemImageEdit repositoryItemImageEdit2;
        private string string_0;
        internal TextEdit txtCsId;
        #endregion

    }
}
