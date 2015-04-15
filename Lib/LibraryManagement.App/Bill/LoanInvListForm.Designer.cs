using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
    partial class FrmLoanInvList
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
            this.components = new Container();
            manager = new ComponentResourceManager(typeof(FrmLoanInvList));
            this.gridControl1 = new GridControl();
            this.dataSet_0 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.IjSwogAv6 = new DataColumn();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.dataColumn_9 = new DataColumn();
            this.dataColumn_10 = new DataColumn();
            this.dataTable_1 = new DataTable();
            this.dataColumn_6 = new DataColumn();
            this.dataColumn_7 = new DataColumn();
            this.dataColumn_8 = new DataColumn();
            this.gridView1 = new GridView();
            this.coltran_date = new GridColumn();
            this.coltrans_num = new GridColumn();
            this.coltrans_code = new GridColumn();
            this.coltran_time = new GridColumn();
            this.colcs_id = new GridColumn();
            this.colfullname = new GridColumn();
            this.colphone = new GridColumn();
            this.colremark = new GridColumn();
            this.coluser_name = new GridColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.gridControl2 = new GridControl();
            this.gridView2 = new GridView();
            this.colgoods_id = new GridColumn();
            this.colgoods_name = new GridColumn();
            this.coldue_date = new GridColumn();
            this.repositoryItemCheckEdit2 = new RepositoryItemCheckEdit();
            this.btnExit = new SimpleButton();
            this.btnPrintInvoice = new SimpleButton();
            this.btnPrint = new SimpleButton();
            this.LabelControl6 = new LabelControl();
            this.lblUserName = new LabelControl();
            this.lblTransName = new LabelControl();
            this.lblTransNum = new LabelControl();
            this.lblTranDate = new LabelControl();
            this.lblTransCode = new LabelControl();
            this.lblCsId = new LabelControl();
            this.lblLibraryId = new LabelControl();
            this.lblCsName = new LabelControl();
            this.lblLibraryName = new LabelControl();
            this.LabelControl4 = new LabelControl();
            this.LabelControl3 = new LabelControl();
            this.LabelControl2 = new LabelControl();
            this.LabelControl1 = new LabelControl();
            this.Lbl_duaration = new LabelControl();
            this.btnReset = new SimpleButton();
            this.printingSystem_0 = new PrintingSystem(this.components);
            this.printableComponentLink_0 = new PrintableComponentLink(this.components);
            this.gridControl1.BeginInit();
            this.dataSet_0.BeginInit();
            this.dataTable_0.BeginInit();
            this.dataTable_1.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemCheckEdit1.BeginInit();
            this.gridControl2.BeginInit();
            this.gridView2.BeginInit();
            this.repositoryItemCheckEdit2.BeginInit();
            ((ISupportInitialize)this.printingSystem_0).BeginInit();
            base.SuspendLayout();
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.gridControl1.DataMember = "loantran";
            this.gridControl1.DataSource = this.dataSet_0;
            this.gridControl1.Location = new Point(12, 0x1f);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[] { this.repositoryItemCheckEdit1 });
            this.gridControl1.Size = new Size(0x267, 0xfb);
            this.gridControl1.TabIndex = 0x1c5;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.dataSet_0.DataSetName = "NewDataSet";
            this.dataSet_0.Tables.AddRange(new DataTable[] { this.dataTable_0, this.dataTable_1 });
            this.dataTable_0.Columns.AddRange(new DataColumn[] { this.IjSwogAv6, this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4, this.dataColumn_5, this.dataColumn_9, this.dataColumn_10 });
            this.dataTable_0.TableName = "loantran";
            this.IjSwogAv6.ColumnName = "tran_date";
            this.IjSwogAv6.DataType = typeof(DateTime);
            this.dataColumn_0.ColumnName = "trans_num";
            this.dataColumn_1.ColumnName = "trans_code";
            this.dataColumn_2.ColumnName = "tran_time";
            this.dataColumn_3.ColumnName = "cs_id";
            this.dataColumn_4.ColumnName = "fullname";
            this.dataColumn_5.ColumnName = "remark";
            this.dataColumn_9.ColumnName = "phone";
            this.dataColumn_10.ColumnName = "user_name";
            this.dataTable_1.Columns.AddRange(new DataColumn[] { this.dataColumn_6, this.dataColumn_7, this.dataColumn_8 });
            this.dataTable_1.TableName = "loandetail";
            this.dataColumn_6.ColumnName = "goods_id";
            this.dataColumn_7.ColumnName = "full_name";
            this.dataColumn_8.ColumnName = "due_date";
            this.dataColumn_8.DataType = typeof(DateTime);
            this.gridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new GridColumn[] { this.coltran_date, this.coltrans_num, this.coltrans_code, this.coltran_time, this.colcs_id, this.colfullname, this.colphone, this.colremark, this.coluser_name });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.coltran_date.Caption = "Ng\x00e0y";
            this.coltran_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coltran_date.DisplayFormat.FormatType = FormatType.DateTime;
            this.coltran_date.FieldName = "tran_date";
            this.coltran_date.Name = "coltran_date";
            this.coltran_date.Visible = true;
            this.coltran_date.VisibleIndex = 0;
            this.coltrans_num.Caption = "Số phiếu mượn/trả";
            this.coltrans_num.FieldName = "trans_num";
            this.coltrans_num.Name = "coltrans_num";
            this.coltrans_num.Visible = true;
            this.coltrans_num.VisibleIndex = 2;
            this.coltrans_code.Caption = "Loại";
            this.coltrans_code.FieldName = "trans_code";
            this.coltrans_code.Name = "coltrans_code";
            this.coltrans_code.Visible = true;
            this.coltrans_code.VisibleIndex = 3;
            this.coltran_time.Caption = "Giờ";
            this.coltran_time.FieldName = "tran_time";
            this.coltran_time.Name = "coltran_time";
            this.coltran_time.Visible = true;
            this.coltran_time.VisibleIndex = 1;
            this.colcs_id.Caption = "Số thẻ";
            this.colcs_id.FieldName = "cs_id";
            this.colcs_id.Name = "colcs_id";
            this.colcs_id.Visible = true;
            this.colcs_id.VisibleIndex = 4;
            this.colfullname.Caption = "Họ t\x00ean";
            this.colfullname.FieldName = "fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 5;
            this.colphone.Caption = "Điện thoại";
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 6;
            this.colremark.Caption = "Ghi ch\x00fa";
            this.colremark.FieldName = "remark";
            this.colremark.Name = "colremark";
            this.colremark.Visible = true;
            this.colremark.VisibleIndex = 7;
            this.coluser_name.Caption = "Người lập phiếu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.Name = "coluser_name";
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.gridControl2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl2.DataMember = "loandetail";
            this.gridControl2.DataSource = this.dataSet_0;
            this.gridControl2.Location = new Point(12, 0x161);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new RepositoryItem[] { this.repositoryItemCheckEdit2 });
            this.gridControl2.Size = new Size(0x267, 80);
            this.gridControl2.TabIndex = 0x1c6;
            this.gridControl2.ViewCollection.AddRange(new BaseView[] { this.gridView2 });
            this.gridView2.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new GridColumn[] { this.colgoods_id, this.colgoods_name, this.coldue_date });
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.colgoods_id.Caption = "M\x00e3 s\x00e1ch";
            this.colgoods_id.FieldName = "goods_id";
            this.colgoods_id.Name = "colgoods_id";
            this.colgoods_id.Visible = true;
            this.colgoods_id.VisibleIndex = 0;
            this.colgoods_name.Caption = "T\x00ean s\x00e1ch";
            this.colgoods_name.FieldName = "full_name";
            this.colgoods_name.Name = "colgoods_name";
            this.colgoods_name.Visible = true;
            this.colgoods_name.VisibleIndex = 1;
            this.coldue_date.Caption = "Ng\x00e0y hẹn trả";
            this.coldue_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldue_date.DisplayFormat.FormatType = FormatType.DateTime;
            this.coldue_date.FieldName = "due_date";
            this.coldue_date.Name = "coldue_date";
            this.coldue_date.Visible = true;
            this.coldue_date.VisibleIndex = 2;
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.btnExit.Anchor = AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new Point(0x1a3, 0x1b7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x58, 0x17);
            this.btnExit.TabIndex = 0x1c9;
            this.btnExit.Text = "ESC-Tho\x00e1t";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.btnPrintInvoice.Anchor = AnchorStyles.Bottom;
            this.btnPrintInvoice.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrintInvoice.Appearance.Options.UseFont = true;
            this.btnPrintInvoice.Location = new Point(0x83, 0x1b7);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new Size(0x58, 0x17);
            this.btnPrintInvoice.TabIndex = 0x1c7;
            this.btnPrintInvoice.Text = "In phiếu";
            this.btnPrintInvoice.Click += new EventHandler(this.btnPrintInvoice_Click);
            this.btnPrint.Anchor = AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new Point(0xe3, 0x1b7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(0x58, 0x17);
            this.btnPrint.TabIndex = 0x1c8;
            this.btnPrint.Text = "In danh mục";
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            this.LabelControl6.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl6.Appearance.Options.UseFont = true;
            this.LabelControl6.Location = new Point(0x18d, 0x137);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new Size(0x4a, 13);
            this.LabelControl6.TabIndex = 0x1d7;
            this.LabelControl6.Text = "Người lập phiếu";
            this.lblUserName.Appearance.BackColor = Color.MediumTurquoise;
            this.lblUserName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblUserName.Appearance.BorderColor = Color.White;
            this.lblUserName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblUserName.Appearance.ForeColor = Color.Black;
            this.lblUserName.Appearance.Options.UseBackColor = true;
            this.lblUserName.Appearance.Options.UseBorderColor = true;
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.Appearance.Options.UseForeColor = true;
            this.lblUserName.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblUserName.BorderStyle = BorderStyles.UltraFlat;
            this.lblUserName.Location = new Point(0x1dd, 0x135);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new Padding(5, 0, 0, 0);
            this.lblUserName.Size = new Size(150, 0x11);
            this.lblUserName.TabIndex = 470;
            this.lblTransName.Appearance.BackColor = Color.MediumTurquoise;
            this.lblTransName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblTransName.Appearance.BorderColor = Color.White;
            this.lblTransName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTransName.Appearance.ForeColor = Color.Black;
            this.lblTransName.Appearance.Options.UseBackColor = true;
            this.lblTransName.Appearance.Options.UseBorderColor = true;
            this.lblTransName.Appearance.Options.UseFont = true;
            this.lblTransName.Appearance.Options.UseForeColor = true;
            this.lblTransName.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblTransName.BorderStyle = BorderStyles.UltraFlat;
            this.lblTransName.Location = new Point(0x1dd, 0x121);
            this.lblTransName.Name = "lblTransName";
            this.lblTransName.Padding = new Padding(5, 0, 0, 0);
            this.lblTransName.Size = new Size(150, 0x11);
            this.lblTransName.TabIndex = 0x1d5;
            this.lblTransNum.Appearance.BackColor = Color.PapayaWhip;
            this.lblTransNum.Appearance.BackColor2 = Color.FromArgb(0xff, 0xff, 0xc0);
            this.lblTransNum.Appearance.BorderColor = Color.White;
            this.lblTransNum.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblTransNum.Appearance.ForeColor = Color.Black;
            this.lblTransNum.Appearance.Options.UseBackColor = true;
            this.lblTransNum.Appearance.Options.UseBorderColor = true;
            this.lblTransNum.Appearance.Options.UseFont = true;
            this.lblTransNum.Appearance.Options.UseForeColor = true;
            this.lblTransNum.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblTransNum.BorderStyle = BorderStyles.UltraFlat;
            this.lblTransNum.Location = new Point(0x66, 0x120);
            this.lblTransNum.Name = "lblTransNum";
            this.lblTransNum.Padding = new Padding(5, 0, 0, 0);
            this.lblTransNum.Size = new Size(0x68, 0x11);
            this.lblTransNum.TabIndex = 0x1d4;
            this.lblTransNum.TextChanged += new EventHandler(this.lblTransNum_TextChanged);
            this.lblTranDate.Appearance.BackColor = Color.MediumTurquoise;
            this.lblTranDate.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblTranDate.Appearance.BorderColor = Color.White;
            this.lblTranDate.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTranDate.Appearance.ForeColor = Color.Black;
            this.lblTranDate.Appearance.Options.UseBackColor = true;
            this.lblTranDate.Appearance.Options.UseBorderColor = true;
            this.lblTranDate.Appearance.Options.UseFont = true;
            this.lblTranDate.Appearance.Options.UseForeColor = true;
            this.lblTranDate.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblTranDate.BorderStyle = BorderStyles.UltraFlat;
            this.lblTranDate.Location = new Point(0xd4, 0x120);
            this.lblTranDate.Name = "lblTranDate";
            this.lblTranDate.Padding = new Padding(5, 0, 0, 0);
            this.lblTranDate.Size = new Size(0x48, 0x11);
            this.lblTranDate.TabIndex = 0x1d3;
            this.lblTransCode.Appearance.BackColor = Color.MediumTurquoise;
            this.lblTransCode.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblTransCode.Appearance.BorderColor = Color.White;
            this.lblTransCode.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTransCode.Appearance.ForeColor = Color.Black;
            this.lblTransCode.Appearance.Options.UseBackColor = true;
            this.lblTransCode.Appearance.Options.UseBorderColor = true;
            this.lblTransCode.Appearance.Options.UseFont = true;
            this.lblTransCode.Appearance.Options.UseForeColor = true;
            this.lblTransCode.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblTransCode.BorderStyle = BorderStyles.UltraFlat;
            this.lblTransCode.Location = new Point(430, 0x120);
            this.lblTransCode.Name = "lblTransCode";
            this.lblTransCode.Padding = new Padding(5, 0, 0, 0);
            this.lblTransCode.Size = new Size(0x29, 0x11);
            this.lblTransCode.TabIndex = 0x1d2;
            this.lblCsId.Appearance.BackColor = Color.MediumTurquoise;
            this.lblCsId.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblCsId.Appearance.BorderColor = Color.White;
            this.lblCsId.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCsId.Appearance.ForeColor = Color.Black;
            this.lblCsId.Appearance.Options.UseBackColor = true;
            this.lblCsId.Appearance.Options.UseBorderColor = true;
            this.lblCsId.Appearance.Options.UseFont = true;
            this.lblCsId.Appearance.Options.UseForeColor = true;
            this.lblCsId.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblCsId.BorderStyle = BorderStyles.UltraFlat;
            this.lblCsId.Location = new Point(0x68, 0x135);
            this.lblCsId.Name = "lblCsId";
            this.lblCsId.Padding = new Padding(5, 0, 0, 0);
            this.lblCsId.Size = new Size(0x47, 0x11);
            this.lblCsId.TabIndex = 0x1d1;
            this.lblLibraryId.Appearance.BackColor = Color.MediumTurquoise;
            this.lblLibraryId.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblLibraryId.Appearance.BorderColor = Color.White;
            this.lblLibraryId.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblLibraryId.Appearance.ForeColor = Color.Black;
            this.lblLibraryId.Appearance.Options.UseBackColor = true;
            this.lblLibraryId.Appearance.Options.UseBorderColor = true;
            this.lblLibraryId.Appearance.Options.UseFont = true;
            this.lblLibraryId.Appearance.Options.UseForeColor = true;
            this.lblLibraryId.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblLibraryId.BorderStyle = BorderStyles.UltraFlat;
            this.lblLibraryId.Location = new Point(0x68, 0x149);
            this.lblLibraryId.Name = "lblLibraryId";
            this.lblLibraryId.Padding = new Padding(5, 0, 0, 0);
            this.lblLibraryId.Size = new Size(0x47, 0x11);
            this.lblLibraryId.TabIndex = 0x1d0;
            this.lblCsName.Appearance.BackColor = Color.MediumTurquoise;
            this.lblCsName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblCsName.Appearance.BorderColor = Color.White;
            this.lblCsName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCsName.Appearance.ForeColor = Color.Black;
            this.lblCsName.Appearance.Options.UseBackColor = true;
            this.lblCsName.Appearance.Options.UseBorderColor = true;
            this.lblCsName.Appearance.Options.UseFont = true;
            this.lblCsName.Appearance.Options.UseForeColor = true;
            this.lblCsName.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblCsName.BorderStyle = BorderStyles.UltraFlat;
            this.lblCsName.Location = new Point(0xb5, 0x135);
            this.lblCsName.Name = "lblCsName";
            this.lblCsName.Padding = new Padding(5, 0, 0, 0);
            this.lblCsName.Size = new Size(210, 0x11);
            this.lblCsName.TabIndex = 0x1cf;
            this.lblLibraryName.Appearance.BackColor = Color.MediumTurquoise;
            this.lblLibraryName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblLibraryName.Appearance.BorderColor = Color.White;
            this.lblLibraryName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblLibraryName.Appearance.ForeColor = Color.Black;
            this.lblLibraryName.Appearance.Options.UseBackColor = true;
            this.lblLibraryName.Appearance.Options.UseBorderColor = true;
            this.lblLibraryName.Appearance.Options.UseFont = true;
            this.lblLibraryName.Appearance.Options.UseForeColor = true;
            this.lblLibraryName.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblLibraryName.BorderStyle = BorderStyles.UltraFlat;
            this.lblLibraryName.Location = new Point(0xb5, 0x149);
            this.lblLibraryName.Name = "lblLibraryName";
            this.lblLibraryName.Padding = new Padding(5, 0, 0, 0);
            this.lblLibraryName.Size = new Size(0x1be, 0x11);
            this.lblLibraryName.TabIndex = 0x1ce;
            this.LabelControl4.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new Point(0x195, 290);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new Size(0x13, 13);
            this.LabelControl4.TabIndex = 0x1cd;
            this.LabelControl4.Text = "Loại";
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new Point(0x11, 310);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x21, 13);
            this.LabelControl3.TabIndex = 460;
            this.LabelControl3.Text = "M\x00e3 thẻ";
            this.LabelControl2.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new Point(0x11, 0x14c);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new Size(0x48, 13);
            this.LabelControl2.TabIndex = 0x1cb;
            this.LabelControl2.Text = "Thuộc thư viện";
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(15, 0x120);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x29, 13);
            this.LabelControl1.TabIndex = 0x1ca;
            this.LabelControl1.Text = "Số phiếu";
            this.Lbl_duaration.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.Lbl_duaration.Appearance.ForeColor = Color.DarkBlue;
            this.Lbl_duaration.Appearance.Options.UseFont = true;
            this.Lbl_duaration.Appearance.Options.UseForeColor = true;
            this.Lbl_duaration.Location = new Point(12, 12);
            this.Lbl_duaration.Name = "Lbl_duaration";
            this.Lbl_duaration.Size = new Size(0xf3, 13);
            this.Lbl_duaration.TabIndex = 0x1d8;
            this.Lbl_duaration.Text = "Từ ng\x00e0y 20/01/2010 đến ng\x00e0y 30/01/2010";
            this.btnReset.Anchor = AnchorStyles.Bottom;
            this.btnReset.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Location = new Point(0x143, 0x1b7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(0x58, 0x17);
            this.btnReset.TabIndex = 0x1d9;
            this.btnReset.Text = "Khởi tạo";
            this.btnReset.Click += new EventHandler(this.btnReset_Click);
            this.printingSystem_0.Links.AddRange(new object[] { this.printableComponentLink_0 });
            this.printableComponentLink_0.Component = this.gridControl1;
            this.printableComponentLink_0.ImageCollection.ImageStream = (ImageCollectionStreamer)manager.GetObject("printableComponentLink1.ImageCollection.ImageStream");
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(0x27f, 0x1d5);
            base.Controls.Add(this.btnReset);
            base.Controls.Add(this.Lbl_duaration);
            base.Controls.Add(this.LabelControl6);
            base.Controls.Add(this.lblUserName);
            base.Controls.Add(this.lblTransName);
            base.Controls.Add(this.lblTransNum);
            base.Controls.Add(this.lblTranDate);
            base.Controls.Add(this.lblTransCode);
            base.Controls.Add(this.lblCsId);
            base.Controls.Add(this.lblLibraryId);
            base.Controls.Add(this.lblCsName);
            base.Controls.Add(this.lblLibraryName);
            base.Controls.Add(this.LabelControl4);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.LabelControl2);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.btnPrintInvoice);
            base.Controls.Add(this.btnPrint);
            base.Controls.Add(this.gridControl2);
            base.Controls.Add(this.gridControl1);
            base.Name = "FrmLoanInvList";
            this.Text = "FrmLoanInvList";
            base.Activated += new EventHandler(this.FrmLoanInvList_Activated);
            base.Load += new EventHandler(this.iWyIskLbe);
            this.gridControl1.EndInit();
            this.dataSet_0.EndInit();
            this.dataTable_0.EndInit();
            this.dataTable_1.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemCheckEdit1.EndInit();
            this.gridControl2.EndInit();
            this.gridView2.EndInit();
            this.repositoryItemCheckEdit2.EndInit();
            ((ISupportInitialize)this.printingSystem_0).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        internal SimpleButton btnPrintInvoice;
        internal SimpleButton btnReset;
        private GridColumn colcs_id;
        private GridColumn coldue_date;
        private GridColumn colfullname;
        private GridColumn colgoods_id;
        private GridColumn colgoods_name;
        private GridColumn colphone;
        private GridColumn colremark;
        private GridColumn coltran_date;
        private GridColumn coltran_time;
        private GridColumn coltrans_code;
        private GridColumn coltrans_num;
        private GridColumn coluser_name;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_10;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataColumn dataColumn_9;
        private DataSet dataSet_0;
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private GridControl gridControl1;
        private GridControl gridControl2;
        private GridView gridView1;
        private GridView gridView2;
        //private IContainer components;
        private DataColumn IjSwogAv6;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl6;
        private LabelControl Lbl_duaration;
        internal LabelControl lblCsId;
        internal LabelControl lblCsName;
        internal LabelControl lblLibraryId;
        internal LabelControl lblLibraryName;
        internal LabelControl lblTranDate;
        internal LabelControl lblTransCode;
        internal LabelControl lblTransName;
        internal LabelControl lblTransNum;
        internal LabelControl lblUserName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private string string_0;


        #endregion

    }
}