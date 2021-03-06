using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class LoanBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanBookForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet_0 = new System.Data.DataSet();
            this.dataTable_0 = new System.Data.DataTable();
            this.dataColumn_0 = new System.Data.DataColumn();
            this.dataColumn_1 = new System.Data.DataColumn();
            this.dataColumn_2 = new System.Data.DataColumn();
            this.dataColumn_3 = new System.Data.DataColumn();
            this.dataColumn_4 = new System.Data.DataColumn();
            this.dataColumn_5 = new System.Data.DataColumn();
            this.dataColumn_6 = new System.Data.DataColumn();
            this.dataColumn_7 = new System.Data.DataColumn();
            this.dataColumn_8 = new System.Data.DataColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgoods_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldue_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCsId = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGoodsid = new DevExpress.XtraEditors.TextEdit();
            this.txtDuedate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Move = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.lblBookName = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.cnvLekth7 = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtTransNum = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddGrp = new DevExpress.XtraEditors.SimpleButton();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodsid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuedate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "loantran";
            this.gridControl1.DataSource = this.dataSet_0;
            this.gridControl1.Location = new System.Drawing.Point(16, 220);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(580, 150);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSet_0
            // 
            this.dataSet_0.DataSetName = "NewDataSet";
            this.dataSet_0.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable_0});
            // 
            // dataTable_0
            // 
            this.dataTable_0.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_0,
            this.dataColumn_1,
            this.dataColumn_2,
            this.dataColumn_3,
            this.dataColumn_4,
            this.dataColumn_5,
            this.dataColumn_6,
            this.dataColumn_7,
            this.dataColumn_8});
            this.dataTable_0.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "goods_id"}, true)});
            this.dataTable_0.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn_1};
            this.dataTable_0.TableName = "loantran";
            // 
            // dataColumn_0
            // 
            this.dataColumn_0.ColumnName = "idx";
            this.dataColumn_0.DataType = typeof(short);
            // 
            // dataColumn_1
            // 
            this.dataColumn_1.AllowDBNull = false;
            this.dataColumn_1.ColumnName = "goods_id";
            this.dataColumn_1.MaxLength = 6;
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
            // dataColumn_4
            // 
            this.dataColumn_4.ColumnName = "csname";
            // 
            // dataColumn_5
            // 
            this.dataColumn_5.ColumnName = "address";
            // 
            // dataColumn_6
            // 
            this.dataColumn_6.ColumnName = "phone";
            // 
            // dataColumn_7
            // 
            this.dataColumn_7.ColumnName = "trannum";
            // 
            // dataColumn_8
            // 
            this.dataColumn_8.ColumnName = "remark";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidx,
            this.colgoods_id,
            this.colfull_name,
            this.coldue_date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colidx
            // 
            this.colidx.Caption = "TT";
            this.colidx.FieldName = "idx";
            this.colidx.Name = "colidx";
            this.colidx.SummaryItem.DisplayFormat = "{0:n0}";
            this.colidx.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colidx.Visible = true;
            this.colidx.VisibleIndex = 0;
            this.colidx.Width = 40;
            // 
            // colgoods_id
            // 
            this.colgoods_id.Caption = "Mã sách";
            this.colgoods_id.FieldName = "goods_id";
            this.colgoods_id.Name = "colgoods_id";
            this.colgoods_id.Visible = true;
            this.colgoods_id.VisibleIndex = 1;
            this.colgoods_id.Width = 70;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Tên sách";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 2;
            this.colfull_name.Width = 350;
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
            this.coldue_date.Width = 99;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(466, 45);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(127, 134);
            this.pictureEdit1.TabIndex = 393;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(21, 38);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(55, 13);
            this.LabelControl4.TabIndex = 397;
            this.LabelControl4.Text = "Mã số thẻ";
            // 
            // txtCsId
            // 
            this.txtCsId.EnterMoveNextControl = true;
            this.txtCsId.Location = new System.Drawing.Point(113, 33);
            this.txtCsId.Name = "txtCsId";
            this.txtCsId.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsId.Properties.Appearance.Options.UseBackColor = true;
            this.txtCsId.Properties.Appearance.Options.UseFont = true;
            this.txtCsId.Properties.Mask.PlaceHolder = ' ';
            this.txtCsId.Properties.MaxLength = 8;
            this.txtCsId.Properties.ValidateOnEnterKey = true;
            this.txtCsId.Size = new System.Drawing.Size(89, 20);
            this.txtCsId.TabIndex = 1;
            this.txtCsId.EditValueChanged += new System.EventHandler(this.txtCsId_EditValueChanged);
            this.txtCsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCsId_KeyDown);
            // 
            // LabelControl11
            // 
            this.LabelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl11.Appearance.Options.UseFont = true;
            this.LabelControl11.Location = new System.Drawing.Point(21, 80);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(24, 13);
            this.LabelControl11.TabIndex = 401;
            this.LabelControl11.Text = "Email";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(21, 59);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(62, 13);
            this.LabelControl2.TabIndex = 400;
            this.LabelControl2.Text = "Số điện thoại";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(12, 17);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(46, 13);
            this.LabelControl1.TabIndex = 405;
            this.LabelControl1.Text = "Mã sách";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 404;
            this.labelControl3.Text = "Tên sách";
            // 
            // txtGoodsid
            // 
            this.txtGoodsid.EnterMoveNextControl = true;
            this.txtGoodsid.Location = new System.Drawing.Point(110, 15);
            this.txtGoodsid.Name = "txtGoodsid";
            this.txtGoodsid.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtGoodsid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsid.Properties.Appearance.Options.UseBackColor = true;
            this.txtGoodsid.Properties.Appearance.Options.UseFont = true;
            this.txtGoodsid.Properties.Mask.PlaceHolder = ' ';
            this.txtGoodsid.Properties.MaxLength = 20;
            this.txtGoodsid.Properties.ValidateOnEnterKey = true;
            this.txtGoodsid.Size = new System.Drawing.Size(89, 20);
            this.txtGoodsid.TabIndex = 0;
            this.txtGoodsid.ToolTip = "Ấn F2 để tìm kiếm";
            this.txtGoodsid.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.txtGoodsid.ToolTipTitle = "Lưu ý";
            this.txtGoodsid.EditValueChanged += new System.EventHandler(this.txtGoodsid_EditValueChanged);
            this.txtGoodsid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoodsid_KeyDown);
            // 
            // txtDuedate
            // 
            this.txtDuedate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.txtDuedate.EnterMoveNextControl = true;
            this.txtDuedate.Location = new System.Drawing.Point(110, 58);
            this.txtDuedate.Name = "txtDuedate";
            this.txtDuedate.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtDuedate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuedate.Properties.Appearance.Options.UseBackColor = true;
            this.txtDuedate.Properties.Appearance.Options.UseFont = true;
            this.txtDuedate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDuedate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDuedate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtDuedate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDuedate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtDuedate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDuedate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtDuedate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDuedate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDuedate.Size = new System.Drawing.Size(89, 20);
            this.txtDuedate.TabIndex = 406;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(12, 60);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(63, 13);
            this.labelControl13.TabIndex = 407;
            this.labelControl13.Text = "Ngày hẹn trả";
            // 
            // btn_Move
            // 
            this.btn_Move.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move.Appearance.Options.UseFont = true;
            this.btn_Move.Location = new System.Drawing.Point(459, 188);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(56, 20);
            this.btn_Move.TabIndex = 409;
            this.btn_Move.TabStop = false;
            this.btn_Move.Text = "Bớt";
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Location = new System.Drawing.Point(521, 188);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 20);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblBookName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblBookName.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblBookName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.Appearance.Options.UseBackColor = true;
            this.lblBookName.Appearance.Options.UseBorderColor = true;
            this.lblBookName.Appearance.Options.UseFont = true;
            this.lblBookName.Appearance.Options.UseForeColor = true;
            this.lblBookName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBookName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBookName.Location = new System.Drawing.Point(110, 38);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblBookName.Size = new System.Drawing.Size(304, 17);
            this.lblBookName.TabIndex = 415;
            // 
            // lblName
            // 
            this.lblName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblName.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblName.Appearance.Options.UseBackColor = true;
            this.lblName.Appearance.Options.UseBorderColor = true;
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Appearance.Options.UseForeColor = true;
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblName.Location = new System.Drawing.Point(210, 36);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblName.Size = new System.Drawing.Size(240, 17);
            this.lblName.TabIndex = 416;
            // 
            // cnvLekth7
            // 
            this.cnvLekth7.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.cnvLekth7.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.cnvLekth7.Appearance.BorderColor = System.Drawing.Color.White;
            this.cnvLekth7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnvLekth7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cnvLekth7.Appearance.Options.UseBackColor = true;
            this.cnvLekth7.Appearance.Options.UseBorderColor = true;
            this.cnvLekth7.Appearance.Options.UseFont = true;
            this.cnvLekth7.Appearance.Options.UseForeColor = true;
            this.cnvLekth7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.cnvLekth7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cnvLekth7.Location = new System.Drawing.Point(113, 57);
            this.cnvLekth7.Name = "cnvLekth7";
            this.cnvLekth7.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cnvLekth7.Size = new System.Drawing.Size(337, 17);
            this.cnvLekth7.TabIndex = 417;
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblEmail.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblEmail.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Appearance.Options.UseBackColor = true;
            this.lblEmail.Appearance.Options.UseBorderColor = true;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblEmail.Location = new System.Drawing.Point(113, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEmail.Size = new System.Drawing.Size(296, 17);
            this.lblEmail.TabIndex = 418;
            // 
            // txtDate
            // 
            this.txtDate.EditValue = "";
            this.txtDate.EnterMoveNextControl = true;
            this.txtDate.Location = new System.Drawing.Point(276, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDate.Size = new System.Drawing.Size(70, 20);
            this.txtDate.TabIndex = 422;
            // 
            // txtTransNum
            // 
            this.txtTransNum.EnterMoveNextControl = true;
            this.txtTransNum.Location = new System.Drawing.Point(113, 4);
            this.txtTransNum.Name = "txtTransNum";
            this.txtTransNum.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtTransNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransNum.Properties.Appearance.Options.UseBackColor = true;
            this.txtTransNum.Properties.Appearance.Options.UseFont = true;
            this.txtTransNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransNum.Properties.Mask.PlaceHolder = ' ';
            this.txtTransNum.Properties.MaxLength = 12;
            this.txtTransNum.Properties.ValidateOnEnterKey = true;
            this.txtTransNum.Size = new System.Drawing.Size(104, 20);
            this.txtTransNum.TabIndex = 421;
            this.txtTransNum.EditValueChanged += new System.EventHandler(this.txtTransNum_EditValueChanged);
            // 
            // LabelControl9
            // 
            this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl9.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabelControl9.Appearance.Options.UseFont = true;
            this.LabelControl9.Appearance.Options.UseForeColor = true;
            this.LabelControl9.Location = new System.Drawing.Point(21, 7);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(48, 13);
            this.LabelControl9.TabIndex = 419;
            this.LabelControl9.Text = "Số phiếu";
            // 
            // LabelControl18
            // 
            this.LabelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl18.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Appearance.Options.UseForeColor = true;
            this.LabelControl18.Location = new System.Drawing.Point(234, 7);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(31, 13);
            this.LabelControl18.TabIndex = 420;
            this.LabelControl18.Text = "Ngày ";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(-48, 25);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(704, 5);
            this.GroupBox4.TabIndex = 423;
            this.GroupBox4.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(312, 401);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 428;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(492, 401);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 430;
            this.btn_Exit.Text = "Th&oát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(402, 401);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 429;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(222, 401);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(132, 401);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 426;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(42, 401);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 425;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.txtGoodsid);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.LabelControl1);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.txtDuedate);
            this.panelControl1.Controls.Add(this.lblBookName);
            this.panelControl1.Location = new System.Drawing.Point(16, 125);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(434, 86);
            this.panelControl1.TabIndex = 431;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.ImageList = this.imageList_0;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(205, 15);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(34, 20);
            this.simpleButton1.TabIndex = 433;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.ToolTip = "Bổ sung, sửa đổi thông tin sách";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "FrmLoanInfo_16_0.png");
            // 
            // btnAddGrp
            // 
            this.btnAddGrp.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrp.Appearance.Options.UseFont = true;
            this.btnAddGrp.ImageIndex = 0;
            this.btnAddGrp.ImageList = this.imageList_0;
            this.btnAddGrp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddGrp.Location = new System.Drawing.Point(415, 77);
            this.btnAddGrp.Name = "btnAddGrp";
            this.btnAddGrp.Size = new System.Drawing.Size(34, 20);
            this.btnAddGrp.TabIndex = 432;
            this.btnAddGrp.TabStop = false;
            this.btnAddGrp.ToolTip = "Bổ sung, sửa đổi thông tin bạn đọc";
            this.btnAddGrp.Click += new System.EventHandler(this.btnAddGrp_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblAddress.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblAddress.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Appearance.Options.UseBackColor = true;
            this.lblAddress.Appearance.Options.UseBorderColor = true;
            this.lblAddress.Appearance.Options.UseFont = true;
            this.lblAddress.Appearance.Options.UseForeColor = true;
            this.lblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAddress.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblAddress.Location = new System.Drawing.Point(112, 99);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblAddress.Size = new System.Drawing.Size(337, 17);
            this.lblAddress.TabIndex = 434;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(20, 101);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 433;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRemark.EnterMoveNextControl = true;
            this.txtRemark.Location = new System.Drawing.Point(73, 375);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtRemark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Properties.Appearance.Options.UseBackColor = true;
            this.txtRemark.Properties.Appearance.Options.UseFont = true;
            this.txtRemark.Properties.Mask.PlaceHolder = ' ';
            this.txtRemark.Properties.ValidateOnEnterKey = true;
            this.txtRemark.Size = new System.Drawing.Size(523, 20);
            this.txtRemark.TabIndex = 436;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(19, 379);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 435;
            this.labelControl5.Text = "Ghi chú";
            // 
            // LoanBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(608, 446);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnAddGrp);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTransNum);
            this.Controls.Add(this.LabelControl9);
            this.Controls.Add(this.LabelControl18);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cnvLekth7);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btn_Move);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.LabelControl11);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.txtCsId);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.gridControl1);
            this.Name = "LoanBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoanBookForm";
            this.Load += new System.EventHandler(this.FrmLoanInfo_Load);
            this.Activated += new System.EventHandler(this.FrmLoanInfo_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodsid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuedate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal SimpleButton btn_Add;
        private SimpleButton btn_Delete;
        private SimpleButton btn_Exit;
        internal SimpleButton btn_Move;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal SimpleButton btnAddGrp;
        internal LabelControl cnvLekth7;
        private GridColumn coldue_date;
        private GridColumn colfull_name;
        private GridColumn colgoods_id;
        private GridColumn colidx;
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
        private GridControl gridControl1;
        private GridView gridView1;
        internal GroupBox GroupBox4;
        //private IContainer components;
        private ImageList imageList_0;
        private int int_0;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl11;
        internal LabelControl labelControl13;
        internal LabelControl LabelControl18;
        internal LabelControl LabelControl2;
        internal LabelControl labelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl labelControl5;
        internal LabelControl labelControl6;
        internal LabelControl LabelControl9;
        internal LabelControl lblAddress;
        internal LabelControl lblBookName;
        internal LabelControl lblEmail;
        internal LabelControl lblName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PanelControl panelControl1;
        private PictureEdit pictureEdit1;
        internal SimpleButton simpleButton1;
        private string string_0;
        private string status;
        private string string_2;
        internal TextEdit txtCsId;
        internal TextEdit txtDate;
        internal TextEdit txtDuedate;
        internal TextEdit txtGoodsid;
        internal TextEdit txtRemark;
        internal TextEdit txtTransNum;

        #endregion

    }
}