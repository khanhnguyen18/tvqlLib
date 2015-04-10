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
    partial class FrmFrPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrPromotion));
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_MercName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ImpName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ExpName = new DevExpress.XtraEditors.LabelControl();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Voucher = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Date = new DevExpress.XtraEditors.TextEdit();
            this.Txt_GoodsId = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(-10, 92);
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
            // LabelControl14
            // 
            this.LabelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new System.Drawing.Point(25, 355);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(35, 13);
            this.LabelControl14.TabIndex = 374;
            this.LabelControl14.Text = "Ghi chú";
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_Remark.EnterMoveNextControl = true;
            this.Txt_Remark.Location = new System.Drawing.Point(116, 348);
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
            this.Lbl_MercName.Location = new System.Drawing.Point(21, 127);
            this.Lbl_MercName.Name = "Lbl_MercName";
            this.Lbl_MercName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_MercName.Size = new System.Drawing.Size(363, 17);
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
            this.Lbl_ImpName.Location = new System.Drawing.Point(178, 67);
            this.Lbl_ImpName.Name = "Lbl_ImpName";
            this.Lbl_ImpName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_ImpName.Size = new System.Drawing.Size(287, 17);
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
            this.Lbl_ExpName.Location = new System.Drawing.Point(178, 40);
            this.Lbl_ExpName.Name = "Lbl_ExpName";
            this.Lbl_ExpName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_ExpName.Size = new System.Drawing.Size(287, 17);
            this.Lbl_ExpName.TabIndex = 378;
            // 
            // chkLabelPrn
            // 
            this.chkLabelPrn.EditValue = true;
            this.chkLabelPrn.Location = new System.Drawing.Point(497, 65);
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
            this.Txt_TransNum.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
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
            this.Txt_ExpID.EditValue = "";
            this.Txt_ExpID.EnterMoveNextControl = true;
            this.Txt_ExpID.Location = new System.Drawing.Point(119, 39);
            this.Txt_ExpID.Name = "Txt_ExpID";
            this.Txt_ExpID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ExpID.Properties.Appearance.Options.UseFont = true;
            this.Txt_ExpID.Properties.MaxLength = 5;
            this.Txt_ExpID.Size = new System.Drawing.Size(56, 20);
            this.Txt_ExpID.TabIndex = 2;
            this.Txt_ExpID.EditValueChanged += new System.EventHandler(this.Txt_ExpID_EditValueChanged);
            this.Txt_ExpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ExpID_KeyDown);
            // 
            // LabelControl17
            // 
            this.LabelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl17.Appearance.Options.UseFont = true;
            this.LabelControl17.Location = new System.Drawing.Point(24, 42);
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
            this.Txt_ImpID.Location = new System.Drawing.Point(119, 65);
            this.Txt_ImpID.Name = "Txt_ImpID";
            this.Txt_ImpID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ImpID.Properties.Appearance.Options.UseFont = true;
            this.Txt_ImpID.Properties.MaxLength = 5;
            this.Txt_ImpID.Size = new System.Drawing.Size(56, 20);
            this.Txt_ImpID.TabIndex = 3;
            this.Txt_ImpID.EditValueChanged += new System.EventHandler(this.Txt_ImpID_EditValueChanged);
            this.Txt_ImpID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ImpID_KeyDown);
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(24, 68);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(69, 13);
            this.LabelControl1.TabIndex = 366;
            this.LabelControl1.Text = "Nơi nhập hàng";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(24, 106);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(72, 13);
            this.LabelControl2.TabIndex = 367;
            this.LabelControl2.Text = "Mã hàng hóa";
            // 
            // Txt_Qty
            // 
            this.Txt_Qty.EnterMoveNextControl = true;
            this.Txt_Qty.Location = new System.Drawing.Point(473, 99);
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
            this.Txt_Qty.Size = new System.Drawing.Size(67, 20);
            this.Txt_Qty.TabIndex = 5;
            // 
            // LabelControl22
            // 
            this.LabelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new System.Drawing.Point(423, 102);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(42, 13);
            this.LabelControl22.TabIndex = 368;
            this.LabelControl22.Text = "Số lượng";
            // 
            // Txt_Price
            // 
            this.Txt_Price.EnterMoveNextControl = true;
            this.Txt_Price.Location = new System.Drawing.Point(438, 126);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Price.Properties.Appearance.Options.UseFont = true;
            this.Txt_Price.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Price.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_Price.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Price.Properties.EditFormat.FormatString = "n2";
            this.Txt_Price.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Price.Properties.Mask.EditMask = "n2";
            this.Txt_Price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Price.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Price.Size = new System.Drawing.Size(102, 20);
            this.Txt_Price.TabIndex = 6;
            this.Txt_Price.EditValueChanged += new System.EventHandler(this.Txt_Price_EditValueChanged);
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(390, 131);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(42, 13);
            this.LabelControl3.TabIndex = 369;
            this.LabelControl3.Text = "Giá nhập";
            // 
            // Cmb_Unit
            // 
            this.Cmb_Unit.Location = new System.Drawing.Point(546, 99);
            this.Cmb_Unit.Name = "Cmb_Unit";
            this.Cmb_Unit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Unit.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Unit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_Unit.Size = new System.Drawing.Size(55, 20);
            this.Cmb_Unit.TabIndex = 370;
            this.Cmb_Unit.SelectedIndexChanged += new System.EventHandler(this.Cmb_Unit_SelectedIndexChanged);
            // 
            // GrdTran
            // 
            this.GrdTran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTran.Location = new System.Drawing.Point(15, 156);
            this.GrdTran.MainView = this.TransDetail;
            this.GrdTran.Name = "GrdTran";
            this.GrdTran.Size = new System.Drawing.Size(637, 186);
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
            this.btnAdd.Location = new System.Drawing.Point(546, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "FrmFrPromotion_16_0.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-55, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 5);
            this.groupBox1.TabIndex = 389;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(548, 383);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(465, 383);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(299, 383);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(216, 383);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(133, 383);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 11;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(50, 383);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(382, 383);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.kCnalMegv);
            // 
            // Txt_Voucher
            // 
            this.Txt_Voucher.EnterMoveNextControl = true;
            this.Txt_Voucher.Location = new System.Drawing.Point(475, 3);
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
            this.labelControl6.Location = new System.Drawing.Point(410, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 393;
            this.labelControl6.Text = "Số chứng từ";
            // 
            // Txt_Date
            // 
            this.Txt_Date.EditValue = "";
            this.Txt_Date.EnterMoveNextControl = true;
            this.Txt_Date.Location = new System.Drawing.Point(277, 3);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Date.Properties.Appearance.Options.UseFont = true;
            this.Txt_Date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_Date.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_Date.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Txt_Date.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Date.Size = new System.Drawing.Size(70, 20);
            this.Txt_Date.TabIndex = 416;
            // 
            // Txt_GoodsId
            // 
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new System.Drawing.Point(119, 103);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Size = new System.Drawing.Size(177, 20);
            this.Txt_GoodsId.TabIndex = 4;
            this.Txt_GoodsId.TabStop = false;
            this.Txt_GoodsId.EditValueChanged += new System.EventHandler(this.Txt_GoodsId_EditValueChanged);
            this.Txt_GoodsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_GoodsId_KeyDown);
            // 
            // FrmFrPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 416);
            this.Controls.Add(this.Txt_Date);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Txt_Voucher);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.LabelControl14);
            this.Controls.Add(this.Txt_Remark);
            this.Controls.Add(this.Lbl_MercName);
            this.Controls.Add(this.Lbl_ImpName);
            this.Controls.Add(this.Lbl_ExpName);
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
            this.Controls.Add(this.Txt_GoodsId);
            this.KeyPreview = true;
            this.Name = "FrmFrPromotion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFrPromotion";
            this.Load += new System.EventHandler(this.FrmFrPromotion_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFrPromotion_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFrPromotion_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal SimpleButton btnAdd;
        internal CheckEdit chkLabelPrn;
        internal ComboBoxEdit Cmb_Unit;
        internal GridControl GrdTran;
        internal GroupBox groupBox1;
        internal GroupBox GroupBox3;
        internal GroupBox GroupBox4;
        //private IContainer components;
        private ImageList imageList_0;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl14;
        internal LabelControl LabelControl17;
        internal LabelControl LabelControl18;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl22;
        internal LabelControl LabelControl3;
        internal LabelControl labelControl6;
        internal LabelControl LabelControl9;
        internal LabelControl Lbl_ExpName;
        internal LabelControl Lbl_ImpName;
        internal LabelControl Lbl_MercName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private string string_3;
        internal GridView TransDetail;
        internal TextEdit Txt_Date;
        internal TextEdit Txt_ExpID;
        private TextEdit Txt_GoodsId;
        internal TextEdit Txt_ImpID;
        internal TextEdit Txt_Price;
        internal TextEdit Txt_Qty;
        internal TextEdit Txt_Remark;
        internal TextEdit Txt_TransNum;
        internal TextEdit Txt_Voucher;

        #endregion

    }
}
