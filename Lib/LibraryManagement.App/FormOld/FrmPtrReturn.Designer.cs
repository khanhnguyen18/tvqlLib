using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
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
    partial class FrmPtrReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPtrReturn));
            this.Lbl_Date = new DevExpress.XtraEditors.LabelControl();
            this.Txt_TransNum = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Txt_OldTrans = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_OldDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_MercName = new DevExpress.XtraEditors.LabelControl();
            this.Txt_GoodsId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Qty = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.GrdTran = new DevExpress.XtraGrid.GridControl();
            this.TransDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Amount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Discount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Unit = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_PosId = new DevExpress.XtraEditors.TextEdit();
            this.Txt_OldQty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.Txt_Surplus = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Vatamt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldTrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Qty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Discount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PosId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Surplus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Vatamt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date.Appearance.Options.UseFont = true;
            this.Lbl_Date.Location = new System.Drawing.Point(275, 15);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Date.TabIndex = 381;
            this.Lbl_Date.Text = "01/01/2008";
            // 
            // Txt_TransNum
            // 
            this.Txt_TransNum.EnterMoveNextControl = true;
            this.Txt_TransNum.Location = new System.Drawing.Point(110, 12);
            this.Txt_TransNum.Name = "Txt_TransNum";
            this.Txt_TransNum.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_TransNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransNum.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_TransNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_TransNum.Properties.Mask.PlaceHolder = ' ';
            this.Txt_TransNum.Properties.MaxLength = 10;
            this.Txt_TransNum.Properties.ValidateOnEnterKey = true;
            this.Txt_TransNum.Size = new System.Drawing.Size(104, 20);
            this.Txt_TransNum.TabIndex = 380;
            // 
            // LabelControl9
            // 
            this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl9.Appearance.Options.UseFont = true;
            this.LabelControl9.Location = new System.Drawing.Point(15, 15);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(67, 13);
            this.LabelControl9.TabIndex = 378;
            this.LabelControl9.Text = "Số giao dịch";
            // 
            // LabelControl18
            // 
            this.LabelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Location = new System.Drawing.Point(231, 15);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(34, 13);
            this.LabelControl18.TabIndex = 379;
            this.LabelControl18.Text = "Ngày :";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(-16, 35);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(704, 5);
            this.GroupBox4.TabIndex = 385;
            this.GroupBox4.TabStop = false;
            // 
            // Txt_OldTrans
            // 
            this.Txt_OldTrans.EnterMoveNextControl = true;
            this.Txt_OldTrans.Location = new System.Drawing.Point(110, 56);
            this.Txt_OldTrans.Name = "Txt_OldTrans";
            this.Txt_OldTrans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OldTrans.Properties.Appearance.Options.UseFont = true;
            this.Txt_OldTrans.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_OldTrans.Properties.MaxLength = 12;
            this.Txt_OldTrans.Size = new System.Drawing.Size(104, 20);
            this.Txt_OldTrans.TabIndex = 1;
            this.Txt_OldTrans.EditValueChanged += new System.EventHandler(this.Txt_OldTrans_EditValueChanged);
            this.Txt_OldTrans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_OldTrans_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 13);
            this.labelControl1.TabIndex = 387;
            this.labelControl1.Text = "Theo giao dịch số";
            // 
            // Txt_OldDate
            // 
            this.Txt_OldDate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.Txt_OldDate.EnterMoveNextControl = true;
            this.Txt_OldDate.Location = new System.Drawing.Point(275, 56);
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
            this.Txt_OldDate.TabIndex = 388;
            this.Txt_OldDate.EditValueChanged += new System.EventHandler(this.Txt_OldDate_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(231, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 389;
            this.labelControl2.Text = "Ngày";
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
            this.Lbl_MercName.Location = new System.Drawing.Point(15, 107);
            this.Lbl_MercName.Name = "Lbl_MercName";
            this.Lbl_MercName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_MercName.Size = new System.Drawing.Size(236, 17);
            this.Lbl_MercName.TabIndex = 394;
            // 
            // Txt_GoodsId
            // 
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new System.Drawing.Point(110, 82);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GoodsId.Properties.Appearance.Options.UseFont = true;
            this.Txt_GoodsId.Size = new System.Drawing.Size(104, 20);
            this.Txt_GoodsId.TabIndex = 2;
            this.Txt_GoodsId.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_GoodsId_Validating);
            this.Txt_GoodsId.EditValueChanged += new System.EventHandler(this.Txt_GoodsId_EditValueChanged);
            this.Txt_GoodsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_GoodsId_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 392;
            this.labelControl3.Text = "Mã hàng hóa";
            // 
            // Txt_Qty
            // 
            this.Txt_Qty.EditValue = "1";
            this.Txt_Qty.EnterMoveNextControl = true;
            this.Txt_Qty.Location = new System.Drawing.Point(292, 104);
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
            this.Txt_Qty.Size = new System.Drawing.Size(64, 20);
            this.Txt_Qty.TabIndex = 3;
            // 
            // LabelControl22
            // 
            this.LabelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new System.Drawing.Point(257, 107);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(29, 13);
            this.LabelControl22.TabIndex = 393;
            this.LabelControl22.Text = "Trả lại";
            // 
            // GrdTran
            // 
            this.GrdTran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTran.Location = new System.Drawing.Point(15, 137);
            this.GrdTran.MainView = this.TransDetail;
            this.GrdTran.Name = "GrdTran";
            this.GrdTran.Size = new System.Drawing.Size(645, 231);
            this.GrdTran.TabIndex = 395;
            this.GrdTran.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TransDetail});
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
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "FrmPtrReturn_16_0.png");
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imageList_0;
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAdd.Location = new System.Drawing.Point(372, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.EnterMoveNextControl = true;
            this.Txt_Amount.Location = new System.Drawing.Point(540, 42);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Amount.Properties.Appearance.Options.UseFont = true;
            this.Txt_Amount.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Amount.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_Amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Amount.Properties.EditFormat.FormatString = "n2";
            this.Txt_Amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Amount.Properties.Mask.EditMask = "n2";
            this.Txt_Amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Amount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Amount.Size = new System.Drawing.Size(120, 20);
            this.Txt_Amount.TabIndex = 397;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(477, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 398;
            this.labelControl4.Text = "Tổng thu";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(444, 385);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 23);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(343, 385);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(88, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(242, 385);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(88, 23);
            this.btn_Skip.TabIndex = 6;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(141, 385);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(88, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-60, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 5);
            this.groupBox1.TabIndex = 406;
            this.groupBox1.TabStop = false;
            // 
            // Txt_Discount
            // 
            this.Txt_Discount.EnterMoveNextControl = true;
            this.Txt_Discount.Location = new System.Drawing.Point(540, 65);
            this.Txt_Discount.Name = "Txt_Discount";
            this.Txt_Discount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Discount.Properties.Appearance.Options.UseFont = true;
            this.Txt_Discount.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Discount.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_Discount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Discount.Properties.EditFormat.FormatString = "n2";
            this.Txt_Discount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Discount.Properties.Mask.EditMask = "n2";
            this.Txt_Discount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Discount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Discount.Size = new System.Drawing.Size(120, 20);
            this.Txt_Discount.TabIndex = 407;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(477, 68);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 13);
            this.labelControl5.TabIndex = 408;
            this.labelControl5.Text = "Chiết khấu";
            // 
            // Lbl_Unit
            // 
            this.Lbl_Unit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Unit.Appearance.Options.UseFont = true;
            this.Lbl_Unit.Location = new System.Drawing.Point(362, 75);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new System.Drawing.Size(18, 13);
            this.Lbl_Unit.TabIndex = 409;
            this.Lbl_Unit.Text = "CAI";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(456, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 13);
            this.labelControl6.TabIndex = 411;
            this.labelControl6.Text = "Quầy";
            // 
            // Txt_PosId
            // 
            this.Txt_PosId.EnterMoveNextControl = true;
            this.Txt_PosId.Location = new System.Drawing.Point(540, 12);
            this.Txt_PosId.Name = "Txt_PosId";
            this.Txt_PosId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PosId.Properties.Appearance.Options.UseFont = true;
            this.Txt_PosId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_PosId.Properties.MaxLength = 12;
            this.Txt_PosId.Size = new System.Drawing.Size(120, 20);
            this.Txt_PosId.TabIndex = 412;
            // 
            // Txt_OldQty
            // 
            this.Txt_OldQty.EnterMoveNextControl = true;
            this.Txt_OldQty.Location = new System.Drawing.Point(292, 82);
            this.Txt_OldQty.Name = "Txt_OldQty";
            this.Txt_OldQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OldQty.Properties.Appearance.Options.UseFont = true;
            this.Txt_OldQty.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_OldQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_OldQty.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_OldQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_OldQty.Properties.EditFormat.FormatString = "n2";
            this.Txt_OldQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_OldQty.Properties.Mask.EditMask = "n2";
            this.Txt_OldQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_OldQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_OldQty.Size = new System.Drawing.Size(64, 20);
            this.Txt_OldQty.TabIndex = 413;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(220, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 13);
            this.labelControl7.TabIndex = 414;
            this.labelControl7.Text = "Lượng đã bán";
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 200;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // Txt_Surplus
            // 
            this.Txt_Surplus.EnterMoveNextControl = true;
            this.Txt_Surplus.Location = new System.Drawing.Point(540, 88);
            this.Txt_Surplus.Name = "Txt_Surplus";
            this.Txt_Surplus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Surplus.Properties.Appearance.Options.UseFont = true;
            this.Txt_Surplus.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Surplus.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Surplus.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_Surplus.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Surplus.Properties.EditFormat.FormatString = "n2";
            this.Txt_Surplus.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Surplus.Properties.Mask.EditMask = "n2";
            this.Txt_Surplus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Surplus.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Surplus.Size = new System.Drawing.Size(120, 20);
            this.Txt_Surplus.TabIndex = 415;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(477, 91);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 416;
            this.labelControl8.Text = "Lãi bán lẻ";
            // 
            // Txt_Vatamt
            // 
            this.Txt_Vatamt.EnterMoveNextControl = true;
            this.Txt_Vatamt.Location = new System.Drawing.Point(540, 111);
            this.Txt_Vatamt.Name = "Txt_Vatamt";
            this.Txt_Vatamt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Vatamt.Properties.Appearance.Options.UseFont = true;
            this.Txt_Vatamt.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Vatamt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Vatamt.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_Vatamt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Vatamt.Properties.EditFormat.FormatString = "n2";
            this.Txt_Vatamt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Vatamt.Properties.Mask.EditMask = "n2";
            this.Txt_Vatamt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Vatamt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Vatamt.Size = new System.Drawing.Size(120, 20);
            this.Txt_Vatamt.TabIndex = 417;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(477, 114);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(46, 13);
            this.labelControl10.TabIndex = 418;
            this.labelControl10.Text = "Thuế VAT";
            // 
            // FrmPtrReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 416);
            this.Controls.Add(this.Txt_Vatamt);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.Txt_Surplus);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.Txt_OldQty);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.Txt_PosId);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Lbl_Unit);
            this.Controls.Add(this.Txt_Discount);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Txt_Amount);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GrdTran);
            this.Controls.Add(this.Lbl_MercName);
            this.Controls.Add(this.Txt_GoodsId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Txt_Qty);
            this.Controls.Add(this.LabelControl22);
            this.Controls.Add(this.Txt_OldDate);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Txt_OldTrans);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Txt_TransNum);
            this.Controls.Add(this.LabelControl9);
            this.Controls.Add(this.LabelControl18);
            this.Name = "FrmPtrReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPtrReturn";
            this.Load += new System.EventHandler(this.FrmPtrReturn_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPtrReturn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldTrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Qty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Discount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PosId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Surplus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Vatamt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Skip;
        internal SimpleButton btnAdd;
        private OleDbDataAdapter cnvLekth7;
        internal GridControl GrdTran;
        internal GroupBox groupBox1;
        internal GroupBox GroupBox4;
        //private IContainer components;
        private ImageList imageList_0;
        internal LabelControl labelControl1;
        internal LabelControl labelControl10;
        internal LabelControl LabelControl18;
        internal LabelControl labelControl2;
        internal LabelControl LabelControl22;
        internal LabelControl labelControl3;
        internal LabelControl labelControl4;
        internal LabelControl labelControl5;
        internal LabelControl labelControl6;
        internal LabelControl labelControl7;
        internal LabelControl labelControl8;
        internal LabelControl LabelControl9;
        internal LabelControl Lbl_Date;
        internal LabelControl Lbl_MercName;
        internal LabelControl Lbl_Unit;
        private OleDbConnection oleDbConnection_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private Timer timer_0;
        internal GridView TransDetail;
        internal TextEdit Txt_Amount;
        internal TextEdit Txt_Discount;
        internal TextEdit Txt_GoodsId;
        internal TextEdit Txt_OldDate;
        internal TextEdit Txt_OldQty;
        internal TextEdit Txt_OldTrans;
        internal TextEdit Txt_PosId;
        internal TextEdit Txt_Qty;
        internal TextEdit Txt_Surplus;
        internal TextEdit Txt_TransNum;
        internal TextEdit Txt_Vatamt;

        #endregion

    }
}
