using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
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
    partial class FrmFromDealer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFromDealer));
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.CwwJoLjYp = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_MercName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ImpName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ExpName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Date = new DevExpress.XtraEditors.LabelControl();
            this.chkLabelPrn = new DevExpress.XtraEditors.CheckEdit();
            this.Txt_TransNum = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ExpID = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ImpID = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Qty = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Price = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_Unit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GrdTran = new DevExpress.XtraGrid.GridControl();
            this.TransDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_DiscPc = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.TgwIjsrYqS = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Voucher = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ImpAmt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_TotalAmt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_DiscAmt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_VatAmt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_GoodsId = new DevExpress.XtraEditors.ButtonEdit();
            this.Txt_OldTrans = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_OldDate = new DevExpress.XtraEditors.TextEdit();
            this.barManager_0 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar_0 = new DevExpress.XtraBars.Bar();
            this.iGoods = new DevExpress.XtraBars.BarButtonItem();
            this.iGoodsGrp = new DevExpress.XtraBars.BarButtonItem();
            this.iStore = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl_0 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl_3 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLabelPrn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ExpID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ImpID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Qty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Unit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DiscPc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ImpAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TotalAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DiscAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VatAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldTrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_0)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(-10, 113);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(694, 5);
            this.GroupBox3.TabIndex = 382;
            this.GroupBox3.TabStop = false;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(-10, 25);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(704, 5);
            this.GroupBox4.TabIndex = 381;
            this.GroupBox4.TabStop = false;
            // 
            // CwwJoLjYp
            // 
            this.CwwJoLjYp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CwwJoLjYp.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CwwJoLjYp.Appearance.Options.UseFont = true;
            this.CwwJoLjYp.Location = new System.Drawing.Point(25, 359);
            this.CwwJoLjYp.Name = "CwwJoLjYp";
            this.CwwJoLjYp.Size = new System.Drawing.Size(35, 13);
            this.CwwJoLjYp.TabIndex = 374;
            this.CwwJoLjYp.Text = "Ghi chú";
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_Remark.EnterMoveNextControl = true;
            this.Txt_Remark.Location = new System.Drawing.Point(116, 356);
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Remark.Properties.Appearance.Options.UseFont = true;
            this.Txt_Remark.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Remark.Size = new System.Drawing.Size(532, 20);
            this.Txt_Remark.TabIndex = 9;
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
            this.Lbl_MercName.Location = new System.Drawing.Point(21, 152);
            this.Lbl_MercName.Name = "Lbl_MercName";
            this.Lbl_MercName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_MercName.Size = new System.Drawing.Size(266, 17);
            this.Lbl_MercName.TabIndex = 380;
            // 
            // Lbl_ImpName
            // 
            this.Lbl_ImpName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_ImpName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_ImpName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_ImpName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ImpName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_ImpName.Appearance.Options.UseBackColor = true;
            this.Lbl_ImpName.Appearance.Options.UseBorderColor = true;
            this.Lbl_ImpName.Appearance.Options.UseFont = true;
            this.Lbl_ImpName.Appearance.Options.UseForeColor = true;
            this.Lbl_ImpName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_ImpName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_ImpName.Location = new System.Drawing.Point(207, 90);
            this.Lbl_ImpName.Name = "Lbl_ImpName";
            this.Lbl_ImpName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_ImpName.Size = new System.Drawing.Size(440, 17);
            this.Lbl_ImpName.TabIndex = 379;
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
            this.Lbl_ExpName.Location = new System.Drawing.Point(207, 63);
            this.Lbl_ExpName.Name = "Lbl_ExpName";
            this.Lbl_ExpName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_ExpName.Size = new System.Drawing.Size(440, 17);
            this.Lbl_ExpName.TabIndex = 378;
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date.Appearance.Options.UseFont = true;
            this.Lbl_Date.Location = new System.Drawing.Point(281, 6);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Date.TabIndex = 377;
            this.Lbl_Date.Text = "01/01/2008";
            // 
            // chkLabelPrn
            // 
            this.chkLabelPrn.EditValue = true;
            this.chkLabelPrn.Location = new System.Drawing.Point(489, 123);
            this.chkLabelPrn.Name = "chkLabelPrn";
            this.chkLabelPrn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLabelPrn.Properties.Appearance.Options.UseFont = true;
            this.chkLabelPrn.Properties.Caption = "Tạo danh sách in tem";
            this.chkLabelPrn.Size = new System.Drawing.Size(163, 19);
            this.chkLabelPrn.TabIndex = 376;
            this.chkLabelPrn.TabStop = false;
            // 
            // Txt_TransNum
            // 
            this.Txt_TransNum.EnterMoveNextControl = true;
            this.Txt_TransNum.Location = new System.Drawing.Point(116, 3);
            this.Txt_TransNum.Name = "Txt_TransNum";
            this.Txt_TransNum.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_TransNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransNum.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_TransNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_TransNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_TransNum.Properties.Mask.PlaceHolder = ' ';
            this.Txt_TransNum.Properties.MaxLength = 12;
            this.Txt_TransNum.Properties.ValidateOnEnterKey = true;
            this.Txt_TransNum.Size = new System.Drawing.Size(104, 20);
            this.Txt_TransNum.TabIndex = 375;
            this.Txt_TransNum.EditValueChanged += new System.EventHandler(this.Txt_TransNum_EditValueChanged);
            this.Txt_TransNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_TransNum_KeyDown);
            // 
            // LabelControl9
            // 
            this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl9.Appearance.Options.UseFont = true;
            this.LabelControl9.Location = new System.Drawing.Point(21, 6);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(67, 13);
            this.LabelControl9.TabIndex = 363;
            this.LabelControl9.Text = "Số giao dịch";
            // 
            // Txt_ExpID
            // 
            this.Txt_ExpID.EnterMoveNextControl = true;
            this.Txt_ExpID.Location = new System.Drawing.Point(116, 62);
            this.Txt_ExpID.Name = "Txt_ExpID";
            this.Txt_ExpID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ExpID.Properties.Appearance.Options.UseFont = true;
            this.Txt_ExpID.Properties.MaxLength = 5;
            this.Txt_ExpID.Size = new System.Drawing.Size(85, 20);
            this.Txt_ExpID.TabIndex = 2;
            this.Txt_ExpID.EditValueChanged += new System.EventHandler(this.Txt_ExpID_EditValueChanged);
            this.Txt_ExpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ExpID_KeyDown);
            // 
            // LabelControl17
            // 
            this.LabelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl17.Appearance.Options.UseFont = true;
            this.LabelControl17.Location = new System.Drawing.Point(21, 65);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(67, 13);
            this.LabelControl17.TabIndex = 365;
            this.LabelControl17.Text = "Nơi xuất hàng";
            // 
            // LabelControl18
            // 
            this.LabelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Location = new System.Drawing.Point(237, 6);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(34, 13);
            this.LabelControl18.TabIndex = 364;
            this.LabelControl18.Text = "Ngày :";
            // 
            // Txt_ImpID
            // 
            this.Txt_ImpID.EnterMoveNextControl = true;
            this.Txt_ImpID.Location = new System.Drawing.Point(116, 88);
            this.Txt_ImpID.Name = "Txt_ImpID";
            this.Txt_ImpID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ImpID.Properties.Appearance.Options.UseFont = true;
            this.Txt_ImpID.Properties.MaxLength = 5;
            this.Txt_ImpID.Size = new System.Drawing.Size(85, 20);
            this.Txt_ImpID.TabIndex = 3;
            this.Txt_ImpID.EditValueChanged += new System.EventHandler(this.Txt_ImpID_EditValueChanged);
            this.Txt_ImpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ImpID_KeyDown);
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(21, 91);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(69, 13);
            this.LabelControl1.TabIndex = 366;
            this.LabelControl1.Text = "Nơi nhập hàng";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(21, 126);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(72, 13);
            this.LabelControl2.TabIndex = 367;
            this.LabelControl2.Text = "Mã hàng hóa";
            // 
            // Txt_Qty
            // 
            this.Txt_Qty.EnterMoveNextControl = true;
            this.Txt_Qty.Location = new System.Drawing.Point(292, 123);
            this.Txt_Qty.Name = "Txt_Qty";
            this.Txt_Qty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Qty.Properties.Appearance.Options.UseFont = true;
            this.Txt_Qty.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Qty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Qty.Properties.DisplayFormat.FormatString = "n0";
            this.Txt_Qty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Qty.Properties.EditFormat.FormatString = "n0";
            this.Txt_Qty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Qty.Properties.Mask.EditMask = "n0";
            this.Txt_Qty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Qty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Qty.Size = new System.Drawing.Size(58, 20);
            this.Txt_Qty.TabIndex = 5;
            // 
            // LabelControl22
            // 
            this.LabelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new System.Drawing.Point(244, 126);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(42, 13);
            this.LabelControl22.TabIndex = 368;
            this.LabelControl22.Text = "Số lượng";
            // 
            // Txt_Price
            // 
            this.Txt_Price.EnterMoveNextControl = true;
            this.Txt_Price.Location = new System.Drawing.Point(356, 150);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Price.Properties.Appearance.Options.UseFont = true;
            this.Txt_Price.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Price.Properties.DisplayFormat.FormatString = "n0";
            this.Txt_Price.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Price.Properties.EditFormat.FormatString = "n0";
            this.Txt_Price.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Price.Properties.Mask.EditMask = "n0";
            this.Txt_Price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Price.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Price.Size = new System.Drawing.Size(97, 20);
            this.Txt_Price.TabIndex = 6;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(295, 154);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(55, 13);
            this.LabelControl3.TabIndex = 369;
            this.LabelControl3.Text = "Giá nhập lại";
            // 
            // Cmb_Unit
            // 
            this.Cmb_Unit.Location = new System.Drawing.Point(356, 123);
            this.Cmb_Unit.Name = "Cmb_Unit";
            this.Cmb_Unit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Unit.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Unit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_Unit.Size = new System.Drawing.Size(52, 20);
            this.Cmb_Unit.TabIndex = 370;
            // 
            // GrdTran
            // 
            this.GrdTran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTran.Location = new System.Drawing.Point(15, 178);
            this.GrdTran.MainView = this.TransDetail;
            this.GrdTran.Name = "GrdTran";
            this.GrdTran.Size = new System.Drawing.Size(637, 120);
            this.GrdTran.TabIndex = 372;
            this.GrdTran.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TransDetail});
            this.GrdTran.Click += new System.EventHandler(this.GrdTran_Click);
            // 
            // TransDetail
            // 
            this.TransDetail.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransDetail.Appearance.FooterPanel.Options.UseFont = true;
            this.TransDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransDetail.Appearance.HeaderPanel.Options.UseFont = true;
            this.TransDetail.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransDetail.Appearance.Row.Options.UseFont = true;
            this.TransDetail.GridControl = this.GrdTran;
            this.TransDetail.Name = "TransDetail";
            this.TransDetail.OptionsView.ShowFooter = true;
            this.TransDetail.OptionsView.ShowGroupPanel = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imageList_0;
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(563, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "FrmFromDealer_16_0.png");
            this.imageList_0.Images.SetKeyName(1, "FrmFromDealer_16_1.png");
            this.imageList_0.Images.SetKeyName(2, "FrmFromDealer_16_2.png");
            this.imageList_0.Images.SetKeyName(3, "FrmFromDealer_16_3.png");
            this.imageList_0.Images.SetKeyName(4, "FrmFromDealer_16_4.png");
            this.imageList_0.Images.SetKeyName(5, "FrmFromDealer_16_5.png");
            this.imageList_0.Images.SetKeyName(6, "FrmFromDealer_16_6.png");
            this.imageList_0.Images.SetKeyName(7, "FrmFromDealer_16_7.png");
            this.imageList_0.Images.SetKeyName(8, "FrmFromDealer_16_8.png");
            this.imageList_0.Images.SetKeyName(9, "FrmFromDealer_16_9.png");
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(467, 154);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(13, 13);
            this.LabelControl4.TabIndex = 371;
            this.LabelControl4.Text = "CK";
            // 
            // Txt_DiscPc
            // 
            this.Txt_DiscPc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.Txt_DiscPc.Enabled = false;
            this.Txt_DiscPc.EnterMoveNextControl = true;
            this.Txt_DiscPc.Location = new System.Drawing.Point(490, 151);
            this.Txt_DiscPc.Name = "Txt_DiscPc";
            this.Txt_DiscPc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DiscPc.Properties.Appearance.Options.UseFont = true;
            this.Txt_DiscPc.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_DiscPc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_DiscPc.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_DiscPc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_DiscPc.Properties.EditFormat.FormatString = "n2";
            this.Txt_DiscPc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_DiscPc.Properties.Mask.EditMask = "n2";
            this.Txt_DiscPc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_DiscPc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_DiscPc.Size = new System.Drawing.Size(50, 20);
            this.Txt_DiscPc.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-55, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 5);
            this.groupBox1.TabIndex = 389;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(548, 387);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(465, 387);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(299, 387);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // TgwIjsrYqS
            // 
            this.TgwIjsrYqS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TgwIjsrYqS.Location = new System.Drawing.Point(216, 387);
            this.TgwIjsrYqS.Name = "TgwIjsrYqS";
            this.TgwIjsrYqS.Size = new System.Drawing.Size(75, 23);
            this.TgwIjsrYqS.TabIndex = 0;
            this.TgwIjsrYqS.Text = "Tạ&o";
            this.TgwIjsrYqS.Click += new System.EventHandler(this.TgwIjsrYqS_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(133, 387);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 11;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(50, 387);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(382, 387);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(546, 154);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(11, 13);
            this.labelControl5.TabIndex = 391;
            this.labelControl5.Text = "%";
            // 
            // Txt_Voucher
            // 
            this.Txt_Voucher.EnterMoveNextControl = true;
            this.Txt_Voucher.Location = new System.Drawing.Point(473, 3);
            this.Txt_Voucher.Name = "Txt_Voucher";
            this.Txt_Voucher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Voucher.Properties.Appearance.Options.UseFont = true;
            this.Txt_Voucher.Properties.MaxLength = 20;
            this.Txt_Voucher.Size = new System.Drawing.Size(155, 20);
            this.Txt_Voucher.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(394, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 393;
            this.labelControl6.Text = "Số chứng từ";
            // 
            // Txt_ImpAmt
            // 
            this.Txt_ImpAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_ImpAmt.EnterMoveNextControl = true;
            this.Txt_ImpAmt.Location = new System.Drawing.Point(506, 304);
            this.Txt_ImpAmt.Name = "Txt_ImpAmt";
            this.Txt_ImpAmt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ImpAmt.Properties.Appearance.Options.UseFont = true;
            this.Txt_ImpAmt.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_ImpAmt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_ImpAmt.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_ImpAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_ImpAmt.Properties.EditFormat.FormatString = "n2";
            this.Txt_ImpAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_ImpAmt.Properties.Mask.EditMask = "n2";
            this.Txt_ImpAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_ImpAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_ImpAmt.Size = new System.Drawing.Size(117, 20);
            this.Txt_ImpAmt.TabIndex = 394;
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(394, 307);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 13);
            this.labelControl7.TabIndex = 395;
            this.labelControl7.Text = "Tổng giao dịch";
            // 
            // Txt_TotalAmt
            // 
            this.Txt_TotalAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_TotalAmt.EnterMoveNextControl = true;
            this.Txt_TotalAmt.Location = new System.Drawing.Point(506, 330);
            this.Txt_TotalAmt.Name = "Txt_TotalAmt";
            this.Txt_TotalAmt.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_TotalAmt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalAmt.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_TotalAmt.Properties.Appearance.Options.UseFont = true;
            this.Txt_TotalAmt.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_TotalAmt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_TotalAmt.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_TotalAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_TotalAmt.Properties.EditFormat.FormatString = "n2";
            this.Txt_TotalAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_TotalAmt.Properties.Mask.EditMask = "n2";
            this.Txt_TotalAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_TotalAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_TotalAmt.Size = new System.Drawing.Size(117, 20);
            this.Txt_TotalAmt.TabIndex = 396;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(394, 333);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 13);
            this.labelControl8.TabIndex = 397;
            this.labelControl8.Text = "Phải thanh toán";
            // 
            // Txt_DiscAmt
            // 
            this.Txt_DiscAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_DiscAmt.EnterMoveNextControl = true;
            this.Txt_DiscAmt.Location = new System.Drawing.Point(116, 330);
            this.Txt_DiscAmt.Name = "Txt_DiscAmt";
            this.Txt_DiscAmt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DiscAmt.Properties.Appearance.Options.UseFont = true;
            this.Txt_DiscAmt.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_DiscAmt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_DiscAmt.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_DiscAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_DiscAmt.Properties.EditFormat.FormatString = "n2";
            this.Txt_DiscAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_DiscAmt.Properties.Mask.EditMask = "n2";
            this.Txt_DiscAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_DiscAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_DiscAmt.Size = new System.Drawing.Size(117, 20);
            this.Txt_DiscAmt.TabIndex = 400;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(25, 333);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(76, 13);
            this.labelControl10.TabIndex = 401;
            this.labelControl10.Text = "Tổng chiết khấu";
            // 
            // Txt_VatAmt
            // 
            this.Txt_VatAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_VatAmt.EnterMoveNextControl = true;
            this.Txt_VatAmt.Location = new System.Drawing.Point(116, 304);
            this.Txt_VatAmt.Name = "Txt_VatAmt";
            this.Txt_VatAmt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_VatAmt.Properties.Appearance.Options.UseFont = true;
            this.Txt_VatAmt.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_VatAmt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_VatAmt.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_VatAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_VatAmt.Properties.EditFormat.FormatString = "n2";
            this.Txt_VatAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_VatAmt.Properties.Mask.EditMask = "n2";
            this.Txt_VatAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_VatAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_VatAmt.Size = new System.Drawing.Size(117, 20);
            this.Txt_VatAmt.TabIndex = 398;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(25, 307);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(71, 13);
            this.labelControl11.TabIndex = 399;
            this.labelControl11.Text = "Tổng thuế VAT";
            // 
            // labelControl12
            // 
            this.labelControl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(628, 307);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(20, 13);
            this.labelControl12.TabIndex = 402;
            this.labelControl12.Text = "VND";
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(628, 333);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(20, 13);
            this.labelControl13.TabIndex = 403;
            this.labelControl13.Text = "VND";
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(239, 333);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(20, 13);
            this.labelControl15.TabIndex = 405;
            this.labelControl15.Text = "VND";
            // 
            // labelControl16
            // 
            this.labelControl16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(239, 307);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(20, 13);
            this.labelControl16.TabIndex = 404;
            this.labelControl16.Text = "VND";
            // 
            // Txt_GoodsId
            // 
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new System.Drawing.Point(116, 123);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Txt_GoodsId.Size = new System.Drawing.Size(114, 20);
            this.Txt_GoodsId.TabIndex = 4;
            this.Txt_GoodsId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Txt_GoodsId_ButtonClick);
            this.Txt_GoodsId.EditValueChanged += new System.EventHandler(this.Txt_GoodsId_EditValueChanged);
            this.Txt_GoodsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_GoodsId_KeyDown);
            // 
            // Txt_OldTrans
            // 
            this.Txt_OldTrans.EnterMoveNextControl = true;
            this.Txt_OldTrans.Location = new System.Drawing.Point(116, 36);
            this.Txt_OldTrans.Name = "Txt_OldTrans";
            this.Txt_OldTrans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OldTrans.Properties.Appearance.Options.UseFont = true;
            this.Txt_OldTrans.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_OldTrans.Properties.MaxLength = 12;
            this.Txt_OldTrans.Size = new System.Drawing.Size(104, 20);
            this.Txt_OldTrans.TabIndex = 406;
            this.Txt_OldTrans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_OldTrans_KeyDown);
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(21, 39);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(83, 13);
            this.labelControl20.TabIndex = 409;
            this.labelControl20.Text = "Theo giao dịch số";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(237, 39);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(25, 13);
            this.labelControl19.TabIndex = 408;
            this.labelControl19.Text = "Ngày";
            // 
            // Txt_OldDate
            // 
            this.Txt_OldDate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.Txt_OldDate.EnterMoveNextControl = true;
            this.Txt_OldDate.Location = new System.Drawing.Point(281, 36);
            this.Txt_OldDate.Name = "Txt_OldDate";
            this.Txt_OldDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OldDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_OldDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OldDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_OldDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OldDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_OldDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_OldDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Txt_OldDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_OldDate.Size = new System.Drawing.Size(81, 20);
            this.Txt_OldDate.TabIndex = 407;
            // 
            // barManager_0
            // 
            this.barManager_0.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar_0});
            this.barManager_0.DockControls.Add(this.barDockControl_0);
            this.barManager_0.DockControls.Add(this.barDockControl_1);
            this.barManager_0.DockControls.Add(this.barDockControl_2);
            this.barManager_0.DockControls.Add(this.barDockControl_3);
            this.barManager_0.Form = this;
            this.barManager_0.Images = this.imageList_0;
            this.barManager_0.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.iGoods,
            this.iGoodsGrp,
            this.iStore});
            this.barManager_0.MaxItemId = 3;
            this.barManager_0.StatusBar = this.bar_0;
            // 
            // bar_0
            // 
            this.bar_0.BarName = "Status bar";
            this.bar_0.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar_0.DockCol = 0;
            this.bar_0.DockRow = 0;
            this.bar_0.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar_0.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iGoods),
            new DevExpress.XtraBars.LinkPersistInfo(this.iGoodsGrp),
            new DevExpress.XtraBars.LinkPersistInfo(this.iStore)});
            this.bar_0.OptionsBar.AllowQuickCustomization = false;
            this.bar_0.OptionsBar.DrawDragBorder = false;
            this.bar_0.OptionsBar.UseWholeRow = true;
            this.bar_0.Text = "Status bar";
            // 
            // iGoods
            // 
            this.iGoods.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.iGoods.Caption = "iGoods";
            this.iGoods.Id = 0;
            this.iGoods.ImageIndex = 3;
            this.iGoods.Name = "iGoods";
            this.iGoods.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iGoods_ItemClick);
            // 
            // iGoodsGrp
            // 
            this.iGoodsGrp.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.iGoodsGrp.Caption = "iGoodsGrp";
            this.iGoodsGrp.Id = 1;
            this.iGoodsGrp.ImageIndex = 6;
            this.iGoodsGrp.Name = "iGoodsGrp";
            // 
            // iStore
            // 
            this.iStore.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.iStore.Caption = "iStore";
            this.iStore.Id = 2;
            this.iStore.ImageIndex = 1;
            this.iStore.Name = "iStore";
            // 
            // barDockControl_0
            // 
            this.barDockControl_0.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl_0.Location = new System.Drawing.Point(0, 0);
            this.barDockControl_0.Size = new System.Drawing.Size(672, 0);
            // 
            // barDockControl_1
            // 
            this.barDockControl_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl_1.Location = new System.Drawing.Point(0, 416);
            this.barDockControl_1.Size = new System.Drawing.Size(672, 26);
            // 
            // barDockControl_2
            // 
            this.barDockControl_2.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl_2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl_2.Size = new System.Drawing.Size(0, 416);
            // 
            // barDockControl_3
            // 
            this.barDockControl_3.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl_3.Location = new System.Drawing.Point(672, 0);
            this.barDockControl_3.Size = new System.Drawing.Size(0, 416);
            // 
            // FrmFromDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 442);
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.Txt_OldDate);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.Txt_OldTrans);
            this.Controls.Add(this.Txt_GoodsId);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.Txt_DiscAmt);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.Txt_VatAmt);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.Txt_TotalAmt);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.Txt_ImpAmt);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Txt_Voucher);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.TgwIjsrYqS);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.CwwJoLjYp);
            this.Controls.Add(this.Txt_Remark);
            this.Controls.Add(this.Lbl_MercName);
            this.Controls.Add(this.Lbl_ImpName);
            this.Controls.Add(this.Lbl_ExpName);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.chkLabelPrn);
            this.Controls.Add(this.Txt_TransNum);
            this.Controls.Add(this.LabelControl9);
            this.Controls.Add(this.Txt_ExpID);
            this.Controls.Add(this.LabelControl17);
            this.Controls.Add(this.LabelControl18);
            this.Controls.Add(this.Txt_ImpID);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.Txt_Qty);
            this.Controls.Add(this.LabelControl22);
            this.Controls.Add(this.Txt_Price);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.Cmb_Unit);
            this.Controls.Add(this.GrdTran);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.Txt_DiscPc);
            this.Controls.Add(this.barDockControl_2);
            this.Controls.Add(this.barDockControl_3);
            this.Controls.Add(this.barDockControl_1);
            this.Controls.Add(this.barDockControl_0);
            this.Name = "FrmFromDealer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFromDealer";
            this.Load += new System.EventHandler(this.FrmFromDealer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pfeZyQnoF);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLabelPrn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ExpID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ImpID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Qty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Unit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DiscPc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ImpAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TotalAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DiscAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VatAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldTrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Bar bar_0;
        private BarDockControl barDockControl_0;
        private BarDockControl barDockControl_1;
        private BarDockControl barDockControl_2;
        private BarDockControl barDockControl_3;
        private BarManager barManager_0;
        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal SimpleButton btnAdd;
        internal CheckEdit chkLabelPrn;
        internal ComboBoxEdit Cmb_Unit;
        internal LabelControl CwwJoLjYp;
        internal GridControl GrdTran;
        internal GroupBox groupBox1;
        internal GroupBox GroupBox3;
        internal GroupBox GroupBox4;
        //private IContainer components;
        private BarButtonItem iGoods;
        private BarButtonItem iGoodsGrp;
        private ImageList imageList_0;
        private BarButtonItem iStore;
        internal LabelControl LabelControl1;
        internal LabelControl labelControl10;
        internal LabelControl labelControl11;
        internal LabelControl labelControl12;
        internal LabelControl labelControl13;
        internal LabelControl labelControl15;
        internal LabelControl labelControl16;
        internal LabelControl LabelControl17;
        internal LabelControl LabelControl18;
        internal LabelControl labelControl19;
        internal LabelControl LabelControl2;
        internal LabelControl labelControl20;
        internal LabelControl LabelControl22;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl labelControl5;
        internal LabelControl labelControl6;
        internal LabelControl labelControl7;
        internal LabelControl labelControl8;
        internal LabelControl LabelControl9;
        internal LabelControl Lbl_Date;
        internal LabelControl Lbl_ExpName;
        internal LabelControl Lbl_ImpName;
        internal LabelControl Lbl_MercName;
        private OleDbConnection oleDbConnection_0;
        private OleDbConnection oleDbConnection_1;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private SimpleButton TgwIjsrYqS;
        internal GridView TransDetail;
        internal TextEdit Txt_DiscAmt;
        internal TextEdit Txt_DiscPc;
        internal TextEdit Txt_ExpID;
        private ButtonEdit Txt_GoodsId;
        internal TextEdit Txt_ImpAmt;
        internal TextEdit Txt_ImpID;
        internal TextEdit Txt_OldDate;
        internal TextEdit Txt_OldTrans;
        internal TextEdit Txt_Price;
        internal TextEdit Txt_Qty;
        internal TextEdit Txt_Remark;
        internal TextEdit Txt_TotalAmt;
        internal TextEdit Txt_TransNum;
        internal TextEdit Txt_VatAmt;
        internal TextEdit Txt_Voucher;
        private string welftZbha;

        #endregion
    }
}
