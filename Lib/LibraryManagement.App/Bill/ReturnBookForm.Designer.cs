using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace LibraryManagement.App
{
    partial class ReturnBookForm
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
        private ComponentResourceManager manager;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.btnAddGrp = new DevExpress.XtraEditors.SimpleButton();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.IjSwogAv6 = new System.Windows.Forms.GroupBox();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.txtTransNum = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCsId = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
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
            this.dataColumn_9 = new System.Data.DataColumn();
            this.dataColumn_10 = new System.Data.DataColumn();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchk_rb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colgoods_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cololdtran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldue_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.lblCopyright = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.lblAddress.Location = new System.Drawing.Point(15, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblAddress.Size = new System.Drawing.Size(337, 17);
            this.lblAddress.TabIndex = 450;
            // 
            // btnAddGrp
            // 
            this.btnAddGrp.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrp.Appearance.Options.UseFont = true;
            this.btnAddGrp.ImageIndex = 0;
            this.btnAddGrp.ImageList = this.imageList_0;
            this.btnAddGrp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddGrp.Location = new System.Drawing.Point(318, 58);
            this.btnAddGrp.Name = "btnAddGrp";
            this.btnAddGrp.Size = new System.Drawing.Size(34, 20);
            this.btnAddGrp.TabIndex = 448;
            this.btnAddGrp.TabStop = false;
            this.btnAddGrp.ToolTip = "Bổ sung, sửa đổi thông tin bạn đọc";
            this.btnAddGrp.Click += new System.EventHandler(this.btnAddGrp_Click);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "NewTask.png");
            // 
            // IjSwogAv6
            // 
            this.IjSwogAv6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IjSwogAv6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IjSwogAv6.Location = new System.Drawing.Point(-26, 26);
            this.IjSwogAv6.Name = "IjSwogAv6";
            this.IjSwogAv6.Size = new System.Drawing.Size(768, 5);
            this.IjSwogAv6.TabIndex = 447;
            this.IjSwogAv6.TabStop = false;
            // 
            // txtDate
            // 
            this.txtDate.EditValue = "";
            this.txtDate.EnterMoveNextControl = true;
            this.txtDate.Location = new System.Drawing.Point(284, 4);
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
            this.txtDate.TabIndex = 446;
            // 
            // txtTransNum
            // 
            this.txtTransNum.EnterMoveNextControl = true;
            this.txtTransNum.Location = new System.Drawing.Point(121, 4);
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
            this.txtTransNum.TabIndex = 445;
            this.txtTransNum.EditValueChanged += new System.EventHandler(this.txtTransNum_EditValueChanged);
            // 
            // LabelControl9
            // 
            this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl9.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabelControl9.Appearance.Options.UseFont = true;
            this.LabelControl9.Appearance.Options.UseForeColor = true;
            this.LabelControl9.Location = new System.Drawing.Point(29, 7);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(48, 13);
            this.LabelControl9.TabIndex = 443;
            this.LabelControl9.Text = "Số phiếu";
            // 
            // LabelControl18
            // 
            this.LabelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl18.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Appearance.Options.UseForeColor = true;
            this.LabelControl18.Location = new System.Drawing.Point(242, 7);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(31, 13);
            this.LabelControl18.TabIndex = 444;
            this.LabelControl18.Text = "Ngày ";
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
            this.lblEmail.Location = new System.Drawing.Point(16, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEmail.Size = new System.Drawing.Size(296, 17);
            this.lblEmail.TabIndex = 442;
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblPhone.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblPhone.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Appearance.Options.UseBackColor = true;
            this.lblPhone.Appearance.Options.UseBorderColor = true;
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Appearance.Options.UseForeColor = true;
            this.lblPhone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPhone.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblPhone.Location = new System.Drawing.Point(16, 39);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPhone.Size = new System.Drawing.Size(337, 17);
            this.lblPhone.TabIndex = 441;
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
            this.lblName.Location = new System.Drawing.Point(16, 18);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblName.Size = new System.Drawing.Size(337, 17);
            this.lblName.TabIndex = 440;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(41, 74);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(55, 13);
            this.LabelControl4.TabIndex = 437;
            this.LabelControl4.Text = "Mã số thẻ";
            // 
            // txtCsId
            // 
            this.txtCsId.EnterMoveNextControl = true;
            this.txtCsId.Location = new System.Drawing.Point(27, 93);
            this.txtCsId.Name = "txtCsId";
            this.txtCsId.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsId.Properties.Appearance.Options.UseBackColor = true;
            this.txtCsId.Properties.Appearance.Options.UseFont = true;
            this.txtCsId.Properties.Mask.PlaceHolder = ' ';
            this.txtCsId.Properties.MaxLength = 8;
            this.txtCsId.Properties.ValidateOnEnterKey = true;
            this.txtCsId.Size = new System.Drawing.Size(89, 20);
            this.txtCsId.TabIndex = 435;
            this.txtCsId.EditValueChanged += new System.EventHandler(this.txtCsId_EditValueChanged);
            this.txtCsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCsId_KeyDown);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(373, 9);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(87, 96);
            this.pictureEdit1.TabIndex = 436;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblName);
            this.groupControl1.Controls.Add(this.lblAddress);
            this.groupControl1.Controls.Add(this.btnAddGrp);
            this.groupControl1.Controls.Add(this.lblPhone);
            this.groupControl1.Controls.Add(this.lblEmail);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Location = new System.Drawing.Point(130, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(471, 113);
            this.groupControl1.TabIndex = 451;
            this.groupControl1.Text = "groupControl1";
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
            this.dataColumn_8,
            this.dataColumn_9,
            this.dataColumn_10});
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
            // dataColumn_9
            // 
            this.dataColumn_9.ColumnName = "chk_rb";
            this.dataColumn_9.DataType = typeof(bool);
            this.dataColumn_9.DefaultValue = false;
            // 
            // dataColumn_10
            // 
            this.dataColumn_10.ColumnName = "oldtran";
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRemark.EnterMoveNextControl = true;
            this.txtRemark.Location = new System.Drawing.Point(81, 337);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtRemark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Properties.Appearance.Options.UseBackColor = true;
            this.txtRemark.Properties.Appearance.Options.UseFont = true;
            this.txtRemark.Properties.Mask.PlaceHolder = ' ';
            this.txtRemark.Properties.ValidateOnEnterKey = true;
            this.txtRemark.Size = new System.Drawing.Size(523, 20);
            this.txtRemark.TabIndex = 454;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(27, 341);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 453;
            this.labelControl5.Text = "Ghi chú";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "loantran";
            this.gridControl1.DataSource = this.dataSet_0;
            this.gridControl1.Location = new System.Drawing.Point(24, 154);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(580, 177);
            this.gridControl1.TabIndex = 452;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidx,
            this.colchk_rb,
            this.colgoods_id,
            this.cololdtran,
            this.colfull_name,
            this.coldue_date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colidx
            // 
            this.colidx.Caption = "TT";
            this.colidx.FieldName = "idx";
            this.colidx.Name = "colidx";
            this.colidx.OptionsColumn.AllowEdit = false;
            this.colidx.SummaryItem.DisplayFormat = "{0:n0}";
            this.colidx.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colidx.Visible = true;
            this.colidx.VisibleIndex = 0;
            this.colidx.Width = 40;
            // 
            // colchk_rb
            // 
            this.colchk_rb.Caption = "Trả";
            this.colchk_rb.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colchk_rb.FieldName = "chk_rb";
            this.colchk_rb.Name = "colchk_rb";
            this.colchk_rb.Visible = true;
            this.colchk_rb.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colgoods_id
            // 
            this.colgoods_id.Caption = "Mã sách";
            this.colgoods_id.FieldName = "goods_id";
            this.colgoods_id.Name = "colgoods_id";
            this.colgoods_id.OptionsColumn.AllowEdit = false;
            this.colgoods_id.Visible = true;
            this.colgoods_id.VisibleIndex = 2;
            this.colgoods_id.Width = 70;
            // 
            // cololdtran
            // 
            this.cololdtran.Caption = "Số phiếu";
            this.cololdtran.FieldName = "oldtran";
            this.cololdtran.Name = "cololdtran";
            this.cololdtran.OptionsColumn.AllowEdit = false;
            this.cololdtran.Visible = true;
            this.cololdtran.VisibleIndex = 4;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Tên sách";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.OptionsColumn.AllowEdit = false;
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 3;
            this.colfull_name.Width = 350;
            // 
            // coldue_date
            // 
            this.coldue_date.Caption = "Ngày hẹn trả";
            this.coldue_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldue_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldue_date.FieldName = "due_date";
            this.coldue_date.Name = "coldue_date";
            this.coldue_date.OptionsColumn.AllowEdit = false;
            this.coldue_date.Visible = true;
            this.coldue_date.VisibleIndex = 5;
            this.coldue_date.Width = 99;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(424, 366);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 462;
            this.btn_Exit.Text = "Th&oát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(322, 366);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 455;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(220, 366);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 458;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(118, 366);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 457;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCopyright.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.lblCopyright.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblCopyright.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCopyright.Appearance.Options.UseBackColor = true;
            this.lblCopyright.Appearance.Options.UseBorderColor = true;
            this.lblCopyright.Appearance.Options.UseFont = true;
            this.lblCopyright.Appearance.Options.UseForeColor = true;
            this.lblCopyright.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lblCopyright.Location = new System.Drawing.Point(-1, 394);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCopyright.Size = new System.Drawing.Size(619, 17);
            this.lblCopyright.TabIndex = 456;
            // 
            // FrmBookRb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(617, 411);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.IjSwogAv6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTransNum);
            this.Controls.Add(this.LabelControl9);
            this.Controls.Add(this.LabelControl18);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.txtCsId);
            this.Name = "FrmBookRb";
            this.Text = "FrmBookRb";
            this.Load += new System.EventHandler(this.FrmBookRb_Load);
            this.Activated += new System.EventHandler(this.FrmBookRb_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Skip;
        internal SimpleButton btnAddGrp;
        private GridColumn colchk_rb;
        private GridColumn coldue_date;
        private GridColumn colfull_name;
        private GridColumn colgoods_id;
        private GridColumn colidx;
        private GridColumn cololdtran;
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
        private GridControl gridControl1;
        private GridView gridView1;
        private GroupControl groupControl1;        
        internal GroupBox IjSwogAv6;
        private ImageList imageList_0;
        private int int_0;
        internal LabelControl LabelControl18;
        internal LabelControl LabelControl4;
        internal LabelControl labelControl5;
        internal LabelControl LabelControl9;
        internal LabelControl lblAddress;
        internal LabelControl lblCopyright;
        internal LabelControl lblEmail;
        internal LabelControl lblName;
        internal LabelControl lblPhone;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PictureEdit pictureEdit1;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private string string_0;
        private string string_1;
        private string string_2;
        internal TextEdit txtCsId;
        internal TextEdit txtDate;
        internal TextEdit txtRemark;
        internal TextEdit txtTransNum;

        #endregion
    }
}