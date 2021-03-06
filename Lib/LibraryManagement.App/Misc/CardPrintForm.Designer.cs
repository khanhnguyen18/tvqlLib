using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    partial class CardPrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardPrintForm));
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblFullName = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Move = new DevExpress.XtraEditors.SimpleButton();
            this.IjSwogAv6 = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet_0 = new System.Data.DataSet();
            this.dataTable_0 = new System.Data.DataTable();
            this.dataColumn_0 = new System.Data.DataColumn();
            this.dataColumn_1 = new System.Data.DataColumn();
            this.dataColumn_2 = new System.Data.DataColumn();
            this.dataColumn_3 = new System.Data.DataColumn();
            this.dataColumn_4 = new System.Data.DataColumn();
            this.dataColumn_5 = new System.Data.DataColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcard_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtCsId = new DevExpress.XtraEditors.TextEdit();
            this.printingSystem_0 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink_0 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Print108 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblOpenDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblDueDate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.lblPhone.Location = new System.Drawing.Point(111, 73);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPhone.Size = new System.Drawing.Size(281, 15);
            this.lblPhone.TabIndex = 356;
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
            this.lblEmail.Location = new System.Drawing.Point(111, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEmail.Size = new System.Drawing.Size(281, 15);
            this.lblEmail.TabIndex = 355;
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
            this.lblFullName.Location = new System.Drawing.Point(111, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFullName.Size = new System.Drawing.Size(281, 15);
            this.lblFullName.TabIndex = 353;
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
            this.lblAddress.Location = new System.Drawing.Point(111, 111);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblAddress.Size = new System.Drawing.Size(407, 15);
            this.lblAddress.TabIndex = 351;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Reset.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Appearance.Options.UseFont = true;
            this.btn_Reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Reset.Location = new System.Drawing.Point(235, 460);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Khởi tạo";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(344, 460);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Move
            // 
            this.btn_Move.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move.Appearance.Options.UseFont = true;
            this.btn_Move.Location = new System.Drawing.Point(369, 132);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(69, 20);
            this.btn_Move.TabIndex = 344;
            this.btn_Move.Text = "Bớt";
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // IjSwogAv6
            // 
            this.IjSwogAv6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IjSwogAv6.Appearance.Options.UseFont = true;
            this.IjSwogAv6.Location = new System.Drawing.Point(447, 132);
            this.IjSwogAv6.Name = "IjSwogAv6";
            this.IjSwogAv6.Size = new System.Drawing.Size(69, 20);
            this.IjSwogAv6.TabIndex = 3;
            this.IjSwogAv6.Text = "Thêm";
            this.IjSwogAv6.Click += new System.EventHandler(this.IjSwogAv6_Click);
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(27, 75);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(49, 13);
            this.LabelControl2.TabIndex = 343;
            this.LabelControl2.Text = "Điện thoại";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "CardPrint";
            this.gridControl1.DataSource = this.dataSet_0;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(12, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(506, 281);
            this.gridControl1.TabIndex = 340;
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
            this.dataColumn_5});
            this.dataTable_0.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "card_id"}, false)});
            this.dataTable_0.TableName = "CardPrint";
            // 
            // dataColumn_0
            // 
            this.dataColumn_0.ColumnName = "idx";
            this.dataColumn_0.DataType = typeof(short);
            // 
            // dataColumn_1
            // 
            this.dataColumn_1.ColumnName = "card_id";
            // 
            // dataColumn_2
            // 
            this.dataColumn_2.ColumnName = "fullname";
            // 
            // dataColumn_3
            // 
            this.dataColumn_3.ColumnName = "image";
            this.dataColumn_3.DataType = typeof(byte[]);
            // 
            // dataColumn_4
            // 
            this.dataColumn_4.ColumnName = "open_date";
            this.dataColumn_4.DataType = typeof(System.DateTime);
            // 
            // dataColumn_5
            // 
            this.dataColumn_5.ColumnName = "due_date";
            this.dataColumn_5.DataType = typeof(System.DateTime);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidx,
            this.colcard_id,
            this.colfullname});
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
            // 
            // colcard_id
            // 
            this.colcard_id.Caption = "Số thẻ";
            this.colcard_id.FieldName = "card_id";
            this.colcard_id.Name = "colcard_id";
            this.colcard_id.Visible = true;
            this.colcard_id.VisibleIndex = 1;
            // 
            // colfullname
            // 
            this.colfullname.Caption = "Họ tên";
            this.colfullname.FieldName = "fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 2;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(27, 94);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(32, 13);
            this.LabelControl3.TabIndex = 339;
            this.LabelControl3.Text = "Địa chỉ";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(27, 15);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(33, 13);
            this.LabelControl1.TabIndex = 338;
            this.LabelControl1.Text = "Mã thẻ";
            // 
            // LabelControl15
            // 
            this.LabelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl15.Appearance.Options.UseFont = true;
            this.LabelControl15.Location = new System.Drawing.Point(27, 35);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(32, 13);
            this.LabelControl15.TabIndex = 337;
            this.LabelControl15.Text = "Họ tên";
            // 
            // txtCsId
            // 
            this.txtCsId.EnterMoveNextControl = true;
            this.txtCsId.Location = new System.Drawing.Point(111, 12);
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
            this.txtCsId.TabIndex = 0;
            this.txtCsId.EditValueChanged += new System.EventHandler(this.txtCsId_EditValueChanged);
            this.txtCsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCsId_KeyDown);
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
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdit.Location = new System.Drawing.Point(215, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 359;
            this.btnEdit.Text = "Bổ sung";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btn_Print108
            // 
            this.btn_Print108.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Print108.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print108.Appearance.Options.UseFont = true;
            this.btn_Print108.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Print108.Location = new System.Drawing.Point(126, 460);
            this.btn_Print108.Name = "btn_Print108";
            this.btn_Print108.Size = new System.Drawing.Size(75, 23);
            this.btn_Print108.TabIndex = 360;
            this.btn_Print108.Text = "In thẻ";
            this.btn_Print108.Click += new System.EventHandler(this.btn_Print108_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 361;
            this.labelControl4.Text = "Email";
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
            this.lblOpenDate.Location = new System.Drawing.Point(111, 54);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblOpenDate.Size = new System.Drawing.Size(97, 15);
            this.lblOpenDate.TabIndex = 363;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(27, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 362;
            this.labelControl6.Text = "Ngày đăng ký";
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
            this.lblDueDate.Location = new System.Drawing.Point(294, 54);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblDueDate.Size = new System.Drawing.Size(98, 15);
            this.lblDueDate.TabIndex = 365;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(229, 54);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 364;
            this.labelControl8.Text = "Hiệu lực đến";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(429, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(84, 89);
            this.pictureEdit1.TabIndex = 393;
            // 
            // CardPrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(544, 493);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lblOpenDate);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btn_Print108);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Move);
            this.Controls.Add(this.IjSwogAv6);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.LabelControl15);
            this.Controls.Add(this.txtCsId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CardPrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCardPrint";
            this.Load += new System.EventHandler(this.FrmCardPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        internal SimpleButton btn_Exit;
        internal SimpleButton btn_Move;
        internal SimpleButton btn_Print108;
        internal SimpleButton btn_Reset;
        internal SimpleButton btnEdit;
        private GridColumn colcard_id;
        private GridColumn colfullname;
        private GridColumn colidx;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataSet dataSet_0;
        private DataTable dataTable_0;
        internal GridControl gridControl1;
        internal GridView gridView1;
        ////private IContainer components;
        internal SimpleButton IjSwogAv6;
        private int int_0;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl15;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl labelControl4;
        internal LabelControl labelControl6;
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
        internal TextEdit txtCsId;


        #endregion

    }
}