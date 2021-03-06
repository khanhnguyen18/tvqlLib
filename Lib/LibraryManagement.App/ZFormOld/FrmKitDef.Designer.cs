using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmKitDef
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitDef));
            this.Lbl_MercName = new DevExpress.XtraEditors.LabelControl();
            this.Txt_GoodsId = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Qty = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ddvqeXfa4 = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.CwwJoLjYp = new System.Windows.Forms.ImageList(this.components);
            this.Txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.welftZbha = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Txt_RtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Unit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Description = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_PackUnit = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Qty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddvqeXfa4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Unit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_PackUnit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_MercName
            // 
            this.Lbl_MercName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_MercName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_MercName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_MercName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MercName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_MercName.Appearance.Options.UseBackColor = true;
            this.Lbl_MercName.Appearance.Options.UseBorderColor = true;
            this.Lbl_MercName.Appearance.Options.UseFont = true;
            this.Lbl_MercName.Appearance.Options.UseForeColor = true;
            this.Lbl_MercName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_MercName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_MercName.Location = new System.Drawing.Point(18, 97);
            this.Lbl_MercName.Name = "Lbl_MercName";
            this.Lbl_MercName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_MercName.Size = new System.Drawing.Size(267, 17);
            this.Lbl_MercName.TabIndex = 386;
            // 
            // Txt_GoodsId
            // 
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new System.Drawing.Point(113, 68);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GoodsId.Properties.Appearance.Options.UseFont = true;
            this.Txt_GoodsId.Size = new System.Drawing.Size(109, 20);
            this.Txt_GoodsId.TabIndex = 4;
            this.Txt_GoodsId.EditValueChanged += new System.EventHandler(this.Txt_GoodsId_EditValueChanged);
            this.Txt_GoodsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_GoodsId_KeyDown);
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(18, 71);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(62, 13);
            this.LabelControl2.TabIndex = 383;
            this.LabelControl2.Text = "Mã hàng hóa";
            // 
            // Txt_Qty
            // 
            this.Txt_Qty.EnterMoveNextControl = true;
            this.Txt_Qty.Location = new System.Drawing.Point(289, 68);
            this.Txt_Qty.Name = "Txt_Qty";
            this.Txt_Qty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Qty.Properties.Appearance.Options.UseFont = true;
            this.Txt_Qty.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Qty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Qty.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_Qty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Qty.Properties.EditFormat.FormatString = "n2";
            this.Txt_Qty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Qty.Properties.Mask.EditMask = "n2";
            this.Txt_Qty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Qty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Qty.Size = new System.Drawing.Size(53, 20);
            this.Txt_Qty.TabIndex = 5;
            // 
            // LabelControl22
            // 
            this.LabelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new System.Drawing.Point(238, 71);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(42, 13);
            this.LabelControl22.TabIndex = 384;
            this.LabelControl22.Text = "Số lượng";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(295, 99);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(47, 13);
            this.LabelControl3.TabIndex = 385;
            this.LabelControl3.Text = "Giá bán lẻ";
            // 
            // ddvqeXfa4
            // 
            this.ddvqeXfa4.EnterMoveNextControl = true;
            this.ddvqeXfa4.Location = new System.Drawing.Point(359, 92);
            this.ddvqeXfa4.Name = "ddvqeXfa4";
            this.ddvqeXfa4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddvqeXfa4.Properties.Appearance.Options.UseFont = true;
            this.ddvqeXfa4.Properties.Appearance.Options.UseTextOptions = true;
            this.ddvqeXfa4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ddvqeXfa4.Properties.DisplayFormat.FormatString = "n2";
            this.ddvqeXfa4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ddvqeXfa4.Properties.EditFormat.FormatString = "n2";
            this.ddvqeXfa4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ddvqeXfa4.Properties.Mask.EditMask = "n2";
            this.ddvqeXfa4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ddvqeXfa4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ddvqeXfa4.Size = new System.Drawing.Size(102, 20);
            this.ddvqeXfa4.TabIndex = 387;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.CwwJoLjYp;
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(478, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Click += new System.EventHandler(this.pfeZyQnoF);
            // 
            // CwwJoLjYp
            // 
            this.CwwJoLjYp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CwwJoLjYp.ImageStream")));
            this.CwwJoLjYp.TransparentColor = System.Drawing.Color.Transparent;
            this.CwwJoLjYp.Images.SetKeyName(0, "FrmKitDef_16_0.png");
            // 
            // Txt_Id
            // 
            this.Txt_Id.EnterMoveNextControl = true;
            this.Txt_Id.Location = new System.Drawing.Point(113, 3);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.Txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_Id.Properties.Appearance.Options.UseFont = true;
            this.Txt_Id.Properties.MaxLength = 6;
            this.Txt_Id.Size = new System.Drawing.Size(109, 20);
            this.Txt_Id.TabIndex = 1;
            this.Txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Id_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 390;
            this.labelControl1.Text = "Mã gói, bó";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(-82, 55);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(739, 5);
            this.GroupBox4.TabIndex = 391;
            this.GroupBox4.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(328, 347);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 399;
            this.btn_Delete.Text = "&Xóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-111, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 398;
            this.groupBox1.TabStop = false;
            // 
            // welftZbha
            // 
            this.welftZbha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.welftZbha.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.welftZbha.Location = new System.Drawing.Point(478, 347);
            this.welftZbha.Name = "welftZbha";
            this.welftZbha.Size = new System.Drawing.Size(75, 23);
            this.welftZbha.TabIndex = 397;
            this.welftZbha.Text = "&Thoát";
            this.welftZbha.Click += new System.EventHandler(this.welftZbha_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(403, 347);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 396;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(253, 347);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 395;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(178, 347);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(103, 347);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 393;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(28, 347);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 392;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(18, 122);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(546, 206);
            this.gridControl1.TabIndex = 400;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.GridView2});
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // GridView2
            // 
            this.GridView2.GridControl = this.gridControl1;
            this.GridView2.Name = "GridView2";
            // 
            // Txt_RtPrice
            // 
            this.Txt_RtPrice.EnterMoveNextControl = true;
            this.Txt_RtPrice.Location = new System.Drawing.Point(289, 3);
            this.Txt_RtPrice.Name = "Txt_RtPrice";
            this.Txt_RtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RtPrice.Properties.Appearance.Options.UseFont = true;
            this.Txt_RtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_RtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_RtPrice.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_RtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_RtPrice.Properties.EditFormat.FormatString = "n2";
            this.Txt_RtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_RtPrice.Properties.Mask.EditMask = "n2";
            this.Txt_RtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_RtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_RtPrice.Size = new System.Drawing.Size(102, 20);
            this.Txt_RtPrice.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(238, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 401;
            this.labelControl4.Text = "Giá bán lẻ";
            // 
            // Txt_Unit
            // 
            this.Txt_Unit.EnterMoveNextControl = true;
            this.Txt_Unit.Location = new System.Drawing.Point(440, 66);
            this.Txt_Unit.Name = "Txt_Unit";
            this.Txt_Unit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Unit.Properties.Appearance.Options.UseFont = true;
            this.Txt_Unit.Size = new System.Drawing.Size(67, 20);
            this.Txt_Unit.TabIndex = 403;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(360, 69);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 404;
            this.labelControl5.Text = "Đơn vị";
            // 
            // Txt_Description
            // 
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new System.Drawing.Point(113, 29);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Description.Properties.Appearance.Options.UseFont = true;
            this.Txt_Description.Size = new System.Drawing.Size(278, 20);
            this.Txt_Description.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(18, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 13);
            this.labelControl6.TabIndex = 406;
            this.labelControl6.Text = "Mô tả";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(405, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 408;
            this.labelControl7.Text = "Đơn vị tính";
            // 
            // Cmb_PackUnit
            // 
            this.Cmb_PackUnit.EnterMoveNextControl = true;
            this.Cmb_PackUnit.Location = new System.Drawing.Point(463, 29);
            this.Cmb_PackUnit.Name = "Cmb_PackUnit";
            this.Cmb_PackUnit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_PackUnit.Properties.Appearance.Options.UseFont = true;
            this.Cmb_PackUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_PackUnit.Properties.MaxLength = 3;
            this.Cmb_PackUnit.Size = new System.Drawing.Size(63, 20);
            this.Cmb_PackUnit.TabIndex = 407;
            // 
            // FrmKitDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.welftZbha;
            this.ClientSize = new System.Drawing.Size(576, 382);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.Cmb_PackUnit);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Txt_Unit);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Txt_RtPrice);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.welftZbha);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ddvqeXfa4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Lbl_MercName);
            this.Controls.Add(this.Txt_GoodsId);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.Txt_Qty);
            this.Controls.Add(this.LabelControl22);
            this.Controls.Add(this.LabelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKitDef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitDef";
            this.Load += new System.EventHandler(this.FrmKitDef_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKitDef_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Qty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddvqeXfa4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Unit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_PackUnit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal SimpleButton btnAdd;
        internal ComboBoxEdit Cmb_PackUnit;
        private ImageList CwwJoLjYp;
        internal TextEdit ddvqeXfa4;
        internal GridControl gridControl1;
        internal GridView gridView1;
        internal GridView GridView2;
        internal GroupBox groupBox1;
        internal GroupBox GroupBox4;
        //private IContainer components;
        internal LabelControl labelControl1;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl22;
        internal LabelControl LabelControl3;
        internal LabelControl labelControl4;
        internal LabelControl labelControl5;
        internal LabelControl labelControl6;
        internal LabelControl labelControl7;
        internal LabelControl Lbl_MercName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        internal TextEdit Txt_Description;
        internal TextEdit Txt_GoodsId;
        internal TextEdit Txt_Id;
        internal TextEdit Txt_Qty;
        internal TextEdit Txt_RtPrice;
        internal TextEdit Txt_Unit;
        private SimpleButton welftZbha;


        #endregion

    }
}
