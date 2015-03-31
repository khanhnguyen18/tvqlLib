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
using DevExpress.XtraGrid.Views.Base;

namespace LibraryManagement.App
{
    partial class FrmBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBalance));
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_PlusQty = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_EndQty = new DevExpress.XtraEditors.TextEdit();
            this.Txt_TransNum = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.GrdTran = new DevExpress.XtraGrid.GridControl();
            this.TransDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.Txt_Price = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_MinusQty = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_MercName = new DevExpress.XtraEditors.LabelControl();
            this.xTveRubwQ = new DevExpress.XtraEditors.LabelControl();
            this.Txt_GoodsId = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_StockId = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_Date = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Lbl_StockName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_Unit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PlusQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_EndQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MinusQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StockId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Unit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(511, 115);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(20, 13);
            this.LabelControl4.TabIndex = 368;
            this.LabelControl4.Text = "VND";
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(381, 88);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(4, 13);
            this.LabelControl5.TabIndex = 4;
            this.LabelControl5.Text = "/";
            // 
            // Txt_PlusQty
            // 
            this.Txt_PlusQty.EnterMoveNextControl = true;
            this.Txt_PlusQty.Location = new System.Drawing.Point(395, 85);
            this.Txt_PlusQty.Name = "Txt_PlusQty";
            this.Txt_PlusQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PlusQty.Properties.Appearance.Options.UseFont = true;
            this.Txt_PlusQty.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_PlusQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_PlusQty.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_PlusQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_PlusQty.Properties.EditFormat.FormatString = "n2";
            this.Txt_PlusQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_PlusQty.Properties.Mask.EditMask = "n2";
            this.Txt_PlusQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_PlusQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_PlusQty.Size = new System.Drawing.Size(53, 20);
            this.Txt_PlusQty.TabIndex = 366;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(530, 88);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(40, 13);
            this.LabelControl1.TabIndex = 365;
            this.LabelControl1.Text = "Hiện tồn";
            // 
            // Txt_EndQty
            // 
            this.Txt_EndQty.EnterMoveNextControl = true;
            this.Txt_EndQty.Location = new System.Drawing.Point(576, 85);
            this.Txt_EndQty.Name = "Txt_EndQty";
            this.Txt_EndQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EndQty.Properties.Appearance.Options.UseFont = true;
            this.Txt_EndQty.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_EndQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_EndQty.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_EndQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_EndQty.Properties.EditFormat.FormatString = "n2";
            this.Txt_EndQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_EndQty.Properties.Mask.EditMask = "n2";
            this.Txt_EndQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_EndQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_EndQty.Size = new System.Drawing.Size(48, 20);
            this.Txt_EndQty.TabIndex = 364;
            this.Txt_EndQty.TabStop = false;
            // 
            // Txt_TransNum
            // 
            this.Txt_TransNum.EditValue = "";
            this.Txt_TransNum.EnterMoveNextControl = true;
            this.Txt_TransNum.Location = new System.Drawing.Point(110, 12);
            this.Txt_TransNum.Name = "Txt_TransNum";
            this.Txt_TransNum.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_TransNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransNum.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_TransNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_TransNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_TransNum.Properties.Mask.PlaceHolder = ' ';
            this.Txt_TransNum.Properties.MaxLength = 12;
            this.Txt_TransNum.Properties.ValidateOnEnterKey = true;
            this.Txt_TransNum.Size = new System.Drawing.Size(120, 20);
            this.Txt_TransNum.TabIndex = 363;
            this.Txt_TransNum.EditValueChanged += new System.EventHandler(this.Txt_TransNum_EditValueChanged);
            this.Txt_TransNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_TransNum_KeyDown);
            // 
            // LabelControl14
            // 
            this.LabelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new System.Drawing.Point(26, 352);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(35, 13);
            this.LabelControl14.TabIndex = 362;
            this.LabelControl14.Text = "Ghi chú";
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Remark.EnterMoveNextControl = true;
            this.Txt_Remark.Location = new System.Drawing.Point(90, 345);
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Remark.Properties.Appearance.Options.UseFont = true;
            this.Txt_Remark.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Remark.Size = new System.Drawing.Size(570, 20);
            this.Txt_Remark.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(-13, 69);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(682, 5);
            this.GroupBox1.TabIndex = 352;
            this.GroupBox1.TabStop = false;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(-13, 35);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(682, 5);
            this.GroupBox4.TabIndex = 351;
            this.GroupBox4.TabStop = false;
            // 
            // GrdTran
            // 
            this.GrdTran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTran.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrdTran.Location = new System.Drawing.Point(26, 137);
            this.GrdTran.MainView = this.TransDetail;
            this.GrdTran.Name = "GrdTran";
            this.GrdTran.Size = new System.Drawing.Size(634, 202);
            this.GrdTran.TabIndex = 350;
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
            // btn_Add
            // 
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageIndex = 0;
            this.btn_Add.ImageList = this.imageList_0;
            this.btn_Add.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_Add.Location = new System.Drawing.Point(548, 109);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(82, 22);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "arrow_down_blue.png");
            // 
            // Txt_Price
            // 
            this.Txt_Price.EnterMoveNextControl = true;
            this.Txt_Price.Location = new System.Drawing.Point(412, 111);
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
            this.Txt_Price.Size = new System.Drawing.Size(93, 20);
            this.Txt_Price.TabIndex = 336;
            // 
            // LabelControl22
            // 
            this.LabelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new System.Drawing.Point(250, 89);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(65, 13);
            this.LabelControl22.TabIndex = 348;
            this.LabelControl22.Text = "SL thiếu/thừa";
            // 
            // Txt_MinusQty
            // 
            this.Txt_MinusQty.EnterMoveNextControl = true;
            this.Txt_MinusQty.Location = new System.Drawing.Point(324, 85);
            this.Txt_MinusQty.Name = "Txt_MinusQty";
            this.Txt_MinusQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MinusQty.Properties.Appearance.Options.UseFont = true;
            this.Txt_MinusQty.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_MinusQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_MinusQty.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_MinusQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_MinusQty.Properties.EditFormat.FormatString = "n2";
            this.Txt_MinusQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_MinusQty.Properties.Mask.EditMask = "n2";
            this.Txt_MinusQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_MinusQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_MinusQty.Size = new System.Drawing.Size(53, 20);
            this.Txt_MinusQty.TabIndex = 3;
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
            this.Lbl_MercName.Location = new System.Drawing.Point(26, 111);
            this.Lbl_MercName.Name = "Lbl_MercName";
            this.Lbl_MercName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_MercName.Size = new System.Drawing.Size(323, 17);
            this.Lbl_MercName.TabIndex = 346;
            // 
            // xTveRubwQ
            // 
            this.xTveRubwQ.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xTveRubwQ.Appearance.Options.UseFont = true;
            this.xTveRubwQ.Location = new System.Drawing.Point(26, 88);
            this.xTveRubwQ.Name = "xTveRubwQ";
            this.xTveRubwQ.Size = new System.Drawing.Size(72, 13);
            this.xTveRubwQ.TabIndex = 345;
            this.xTveRubwQ.Text = "Mã hàng hóa";
            // 
            // Txt_GoodsId
            // 
            this.Txt_GoodsId.EditValue = "";
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new System.Drawing.Point(110, 85);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GoodsId.Properties.Appearance.Options.UseFont = true;
            this.Txt_GoodsId.Size = new System.Drawing.Size(131, 20);
            this.Txt_GoodsId.TabIndex = 2;
            this.Txt_GoodsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_GoodsId_KeyDown);
            // 
            // LabelControl17
            // 
            this.LabelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl17.Appearance.Options.UseFont = true;
            this.LabelControl17.Location = new System.Drawing.Point(26, 50);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(34, 13);
            this.LabelControl17.TabIndex = 343;
            this.LabelControl17.Text = "Tại kho";
            // 
            // Txt_StockId
            // 
            this.Txt_StockId.EnterMoveNextControl = true;
            this.Txt_StockId.Location = new System.Drawing.Point(110, 47);
            this.Txt_StockId.Name = "Txt_StockId";
            this.Txt_StockId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_StockId.Properties.Appearance.Options.UseFont = true;
            this.Txt_StockId.Size = new System.Drawing.Size(93, 20);
            this.Txt_StockId.TabIndex = 1;
            this.Txt_StockId.EditValueChanged += new System.EventHandler(this.Txt_StockId_EditValueChanged);
            this.Txt_StockId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_StockId_KeyDown);
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date.Appearance.Options.UseFont = true;
            this.Lbl_Date.Location = new System.Drawing.Point(290, 16);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Date.TabIndex = 339;
            this.Lbl_Date.Text = "22/12/2009";
            // 
            // LabelControl9
            // 
            this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl9.Appearance.Options.UseFont = true;
            this.LabelControl9.Location = new System.Drawing.Point(26, 15);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(67, 13);
            this.LabelControl9.TabIndex = 338;
            this.LabelControl9.Text = "Số giao dịch";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(382, 381);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(-9, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 5);
            this.groupBox2.TabIndex = 405;
            this.groupBox2.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(548, 381);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(465, 381);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(299, 381);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(216, 381);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(133, 381);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 8;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(50, 381);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Lbl_StockName
            // 
            this.Lbl_StockName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_StockName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_StockName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_StockName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_StockName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_StockName.Appearance.Options.UseBackColor = true;
            this.Lbl_StockName.Appearance.Options.UseBorderColor = true;
            this.Lbl_StockName.Appearance.Options.UseFont = true;
            this.Lbl_StockName.Appearance.Options.UseForeColor = true;
            this.Lbl_StockName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_StockName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_StockName.Location = new System.Drawing.Point(208, 49);
            this.Lbl_StockName.Name = "Lbl_StockName";
            this.Lbl_StockName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_StockName.Size = new System.Drawing.Size(415, 17);
            this.Lbl_StockName.TabIndex = 407;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(361, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 408;
            this.labelControl3.Text = "Giá vốn";
            // 
            // LabelControl18
            // 
            this.LabelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Location = new System.Drawing.Point(250, 16);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(34, 13);
            this.LabelControl18.TabIndex = 409;
            this.LabelControl18.Text = "Ngày :";
            // 
            // Cmb_Unit
            // 
            this.Cmb_Unit.EnterMoveNextControl = true;
            this.Cmb_Unit.Location = new System.Drawing.Point(453, 85);
            this.Cmb_Unit.Name = "Cmb_Unit";
            this.Cmb_Unit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Unit.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Unit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_Unit.Size = new System.Drawing.Size(52, 20);
            this.Cmb_Unit.TabIndex = 410;
            this.Cmb_Unit.TabStop = false;
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // FrmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 416);
            this.Controls.Add(this.Cmb_Unit);
            this.Controls.Add(this.LabelControl18);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Lbl_StockName);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.LabelControl5);
            this.Controls.Add(this.Txt_PlusQty);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.Txt_EndQty);
            this.Controls.Add(this.Txt_TransNum);
            this.Controls.Add(this.LabelControl14);
            this.Controls.Add(this.Txt_Remark);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GrdTran);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Txt_Price);
            this.Controls.Add(this.LabelControl22);
            this.Controls.Add(this.Txt_MinusQty);
            this.Controls.Add(this.Lbl_MercName);
            this.Controls.Add(this.xTveRubwQ);
            this.Controls.Add(this.Txt_GoodsId);
            this.Controls.Add(this.LabelControl17);
            this.Controls.Add(this.Txt_StockId);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.LabelControl9);
            this.Name = "FrmBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBalance";
            this.Load += new System.EventHandler(this.FrmBalance_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBalance_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PlusQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_EndQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MinusQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StockId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Unit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private bool bool_0;
        internal SimpleButton btn_Add;
        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal ComboBoxEdit Cmb_Unit;
        internal GridControl GrdTran;
        internal GroupBox GroupBox1;
        internal GroupBox groupBox2;
        internal GroupBox GroupBox4;
        private ImageList imageList_0;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl14;
        internal LabelControl LabelControl17;
        internal LabelControl LabelControl18;
        internal LabelControl LabelControl22;
        internal LabelControl labelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl5;
        internal LabelControl LabelControl9;
        internal LabelControl Lbl_Date;
        internal LabelControl Lbl_MercName;
        internal LabelControl Lbl_StockName;
        private OleDbConnection oleDbConnection_0;
        private OleDbConnection oleDbConnection_1;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private string string_3;
        private Timer timer_0;
        internal GridView TransDetail;
        internal TextEdit Txt_EndQty;
        internal TextEdit Txt_GoodsId;
        internal TextEdit Txt_MinusQty;
        internal TextEdit Txt_PlusQty;
        internal TextEdit Txt_Price;
        internal TextEdit Txt_Remark;
        internal TextEdit Txt_StockId;
        internal TextEdit Txt_TransNum;
        internal LabelControl xTveRubwQ;


        #endregion

    }
}