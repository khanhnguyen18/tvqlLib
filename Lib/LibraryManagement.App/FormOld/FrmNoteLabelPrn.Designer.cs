using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmNoteLabelPrn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoteLabelPrn));
            this.Lbl_PosName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_Rtprice = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_SuppId = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_SuppName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_GrpId = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_FullName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_ShortName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_GrpName = new DevExpress.XtraEditors.LabelControl();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Qty = new DevExpress.XtraEditors.TextEdit();
            this.btn_Move = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_PosId = new DevExpress.XtraEditors.TextEdit();
            this.Grd_Labels = new DevExpress.XtraGrid.GridControl();
            this.Labels_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_GoodsId = new DevExpress.XtraEditors.TextEdit();
            this.printingSystem_0 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink_0 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.btn_ListPrn = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Print108 = new DevExpress.XtraEditors.SimpleButton();
            this.Chk_SelectAll = new DevExpress.XtraEditors.CheckEdit();
            this.cnvLekth7 = new DevExpress.XtraEditors.RadioGroup();
            this.Lbl_Barcode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Qty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PosId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Labels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Labels_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_SelectAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnvLekth7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_PosName
            // 
            this.Lbl_PosName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_PosName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_PosName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_PosName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PosName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_PosName.Appearance.Options.UseBackColor = true;
            this.Lbl_PosName.Appearance.Options.UseBorderColor = true;
            this.Lbl_PosName.Appearance.Options.UseFont = true;
            this.Lbl_PosName.Appearance.Options.UseForeColor = true;
            this.Lbl_PosName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_PosName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_PosName.Location = new System.Drawing.Point(202, 10);
            this.Lbl_PosName.Name = "Lbl_PosName";
            this.Lbl_PosName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_PosName.Size = new System.Drawing.Size(316, 17);
            this.Lbl_PosName.TabIndex = 358;
            // 
            // Lbl_Rtprice
            // 
            this.Lbl_Rtprice.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_Rtprice.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_Rtprice.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_Rtprice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rtprice.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Rtprice.Appearance.Options.UseBackColor = true;
            this.Lbl_Rtprice.Appearance.Options.UseBorderColor = true;
            this.Lbl_Rtprice.Appearance.Options.UseFont = true;
            this.Lbl_Rtprice.Appearance.Options.UseForeColor = true;
            this.Lbl_Rtprice.Appearance.Options.UseTextOptions = true;
            this.Lbl_Rtprice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Lbl_Rtprice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_Rtprice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_Rtprice.Location = new System.Drawing.Point(403, 35);
            this.Lbl_Rtprice.Name = "Lbl_Rtprice";
            this.Lbl_Rtprice.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Lbl_Rtprice.Size = new System.Drawing.Size(115, 17);
            this.Lbl_Rtprice.TabIndex = 357;
            // 
            // Lbl_SuppId
            // 
            this.Lbl_SuppId.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_SuppId.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_SuppId.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_SuppId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SuppId.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_SuppId.Appearance.Options.UseBackColor = true;
            this.Lbl_SuppId.Appearance.Options.UseBorderColor = true;
            this.Lbl_SuppId.Appearance.Options.UseFont = true;
            this.Lbl_SuppId.Appearance.Options.UseForeColor = true;
            this.Lbl_SuppId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_SuppId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_SuppId.Location = new System.Drawing.Point(111, 126);
            this.Lbl_SuppId.Name = "Lbl_SuppId";
            this.Lbl_SuppId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_SuppId.Size = new System.Drawing.Size(85, 17);
            this.Lbl_SuppId.TabIndex = 356;
            this.Lbl_SuppId.TextChanged += new System.EventHandler(this.Lbl_SuppId_TextChanged);
            // 
            // Lbl_SuppName
            // 
            this.Lbl_SuppName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_SuppName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_SuppName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_SuppName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SuppName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_SuppName.Appearance.Options.UseBackColor = true;
            this.Lbl_SuppName.Appearance.Options.UseBorderColor = true;
            this.Lbl_SuppName.Appearance.Options.UseFont = true;
            this.Lbl_SuppName.Appearance.Options.UseForeColor = true;
            this.Lbl_SuppName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_SuppName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_SuppName.Location = new System.Drawing.Point(202, 126);
            this.Lbl_SuppName.Name = "Lbl_SuppName";
            this.Lbl_SuppName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_SuppName.Size = new System.Drawing.Size(316, 17);
            this.Lbl_SuppName.TabIndex = 355;
            // 
            // Lbl_GrpId
            // 
            this.Lbl_GrpId.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_GrpId.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_GrpId.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_GrpId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GrpId.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_GrpId.Appearance.Options.UseBackColor = true;
            this.Lbl_GrpId.Appearance.Options.UseBorderColor = true;
            this.Lbl_GrpId.Appearance.Options.UseFont = true;
            this.Lbl_GrpId.Appearance.Options.UseForeColor = true;
            this.Lbl_GrpId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_GrpId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_GrpId.Location = new System.Drawing.Point(111, 104);
            this.Lbl_GrpId.Name = "Lbl_GrpId";
            this.Lbl_GrpId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_GrpId.Size = new System.Drawing.Size(57, 17);
            this.Lbl_GrpId.TabIndex = 354;
            this.Lbl_GrpId.TextChanged += new System.EventHandler(this.Lbl_GrpId_TextChanged);
            // 
            // Lbl_FullName
            // 
            this.Lbl_FullName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_FullName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_FullName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_FullName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FullName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_FullName.Appearance.Options.UseBackColor = true;
            this.Lbl_FullName.Appearance.Options.UseBorderColor = true;
            this.Lbl_FullName.Appearance.Options.UseFont = true;
            this.Lbl_FullName.Appearance.Options.UseForeColor = true;
            this.Lbl_FullName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_FullName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_FullName.Location = new System.Drawing.Point(111, 81);
            this.Lbl_FullName.Name = "Lbl_FullName";
            this.Lbl_FullName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_FullName.Size = new System.Drawing.Size(407, 17);
            this.Lbl_FullName.TabIndex = 353;
            // 
            // Lbl_ShortName
            // 
            this.Lbl_ShortName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_ShortName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_ShortName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_ShortName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ShortName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_ShortName.Appearance.Options.UseBackColor = true;
            this.Lbl_ShortName.Appearance.Options.UseBorderColor = true;
            this.Lbl_ShortName.Appearance.Options.UseFont = true;
            this.Lbl_ShortName.Appearance.Options.UseForeColor = true;
            this.Lbl_ShortName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_ShortName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_ShortName.Location = new System.Drawing.Point(111, 58);
            this.Lbl_ShortName.Name = "Lbl_ShortName";
            this.Lbl_ShortName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_ShortName.Size = new System.Drawing.Size(220, 17);
            this.Lbl_ShortName.TabIndex = 352;
            // 
            // Lbl_GrpName
            // 
            this.Lbl_GrpName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_GrpName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_GrpName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_GrpName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GrpName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_GrpName.Appearance.Options.UseBackColor = true;
            this.Lbl_GrpName.Appearance.Options.UseBorderColor = true;
            this.Lbl_GrpName.Appearance.Options.UseFont = true;
            this.Lbl_GrpName.Appearance.Options.UseForeColor = true;
            this.Lbl_GrpName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_GrpName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_GrpName.Location = new System.Drawing.Point(174, 104);
            this.Lbl_GrpName.Name = "Lbl_GrpName";
            this.Lbl_GrpName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_GrpName.Size = new System.Drawing.Size(216, 17);
            this.Lbl_GrpName.TabIndex = 351;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Reset.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Appearance.Options.UseFont = true;
            this.btn_Reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Reset.Location = new System.Drawing.Point(317, 451);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Khởi tạo";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(326, 36);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(47, 13);
            this.LabelControl5.TabIndex = 349;
            this.LabelControl5.Text = "Giá bán lẻ";
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.EnterMoveNextControl = true;
            this.Txt_Remark.Location = new System.Drawing.Point(111, 148);
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Remark.Properties.Appearance.Options.UseFont = true;
            this.Txt_Remark.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Remark.Size = new System.Drawing.Size(407, 20);
            this.Txt_Remark.TabIndex = 1;
            this.Txt_Remark.TabStop = false;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(27, 150);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(35, 13);
            this.LabelControl4.TabIndex = 348;
            this.LabelControl4.Text = "Ghi chú";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(400, 451);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // LabelControl22
            // 
            this.LabelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new System.Drawing.Point(237, 178);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(42, 13);
            this.LabelControl22.TabIndex = 345;
            this.LabelControl22.Text = "Số lượng";
            // 
            // Txt_Qty
            // 
            this.Txt_Qty.EditValue = "1";
            this.Txt_Qty.EnterMoveNextControl = true;
            this.Txt_Qty.Location = new System.Drawing.Point(301, 175);
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
            this.Txt_Qty.Size = new System.Drawing.Size(52, 20);
            this.Txt_Qty.TabIndex = 2;
            // 
            // btn_Move
            // 
            this.btn_Move.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move.Appearance.Options.UseFont = true;
            this.btn_Move.Location = new System.Drawing.Point(364, 173);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(75, 23);
            this.btn_Move.TabIndex = 344;
            this.btn_Move.Text = "Bớt";
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Location = new System.Drawing.Point(443, 173);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(27, 127);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(65, 13);
            this.LabelControl2.TabIndex = 343;
            this.LabelControl2.Text = "Nhà cung cấp";
            // 
            // LabelControl17
            // 
            this.LabelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl17.Appearance.Options.UseFont = true;
            this.LabelControl17.Location = new System.Drawing.Point(27, 10);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(49, 13);
            this.LabelControl17.TabIndex = 342;
            this.LabelControl17.Text = "Thuộc kho";
            // 
            // Txt_PosId
            // 
            this.Txt_PosId.EnterMoveNextControl = true;
            this.Txt_PosId.Location = new System.Drawing.Point(111, 7);
            this.Txt_PosId.Name = "Txt_PosId";
            this.Txt_PosId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PosId.Properties.Appearance.Options.UseFont = true;
            this.Txt_PosId.Size = new System.Drawing.Size(85, 20);
            this.Txt_PosId.TabIndex = 7;
            this.Txt_PosId.EditValueChanged += new System.EventHandler(this.Txt_PosId_EditValueChanged);
            // 
            // Grd_Labels
            // 
            this.Grd_Labels.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grd_Labels.Location = new System.Drawing.Point(27, 232);
            this.Grd_Labels.MainView = this.Labels_View;
            this.Grd_Labels.Name = "Grd_Labels";
            this.Grd_Labels.Size = new System.Drawing.Size(491, 207);
            this.Grd_Labels.TabIndex = 340;
            this.Grd_Labels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Labels_View});
            this.Grd_Labels.Click += new System.EventHandler(this.Grd_Labels_Click);
            // 
            // Labels_View
            // 
            this.Labels_View.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labels_View.Appearance.FooterPanel.Options.UseFont = true;
            this.Labels_View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labels_View.Appearance.HeaderPanel.Options.UseFont = true;
            this.Labels_View.GridControl = this.Grd_Labels;
            this.Labels_View.Name = "Labels_View";
            this.Labels_View.OptionsView.ShowFooter = true;
            this.Labels_View.OptionsView.ShowGroupPanel = false;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(27, 106);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(58, 13);
            this.LabelControl3.TabIndex = 339;
            this.LabelControl3.Text = "Thuộc nhóm";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(27, 36);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(44, 13);
            this.LabelControl1.TabIndex = 338;
            this.LabelControl1.Text = "Mã hàng ";
            // 
            // LabelControl15
            // 
            this.LabelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl15.Appearance.Options.UseFont = true;
            this.LabelControl15.Location = new System.Drawing.Point(27, 83);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(54, 13);
            this.LabelControl15.TabIndex = 337;
            this.LabelControl15.Text = "Tên đầy đủ";
            // 
            // LabelControl14
            // 
            this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new System.Drawing.Point(27, 60);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(56, 13);
            this.LabelControl14.TabIndex = 336;
            this.LabelControl14.Text = "Tên viết tắt";
            // 
            // Txt_GoodsId
            // 
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new System.Drawing.Point(111, 33);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_GoodsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_GoodsId.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_GoodsId.Properties.Appearance.Options.UseFont = true;
            this.Txt_GoodsId.Properties.Mask.PlaceHolder = ' ';
            this.Txt_GoodsId.Properties.ValidateOnEnterKey = true;
            this.Txt_GoodsId.Size = new System.Drawing.Size(123, 20);
            this.Txt_GoodsId.TabIndex = 0;
            this.Txt_GoodsId.EditValueChanged += new System.EventHandler(this.Txt_GoodsId_EditValueChanged);
            this.Txt_GoodsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_GoodsId_KeyDown);
            // 
            // printingSystem_0
            // 
            this.printingSystem_0.Links.AddRange(new object[] {
            this.printableComponentLink_0});
            // 
            // printableComponentLink_0
            // 
            this.printableComponentLink_0.Component = this.Grd_Labels;
            // 
            // 
            // 
            this.printableComponentLink_0.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink_0.ImageCollection.ImageStream")));
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            // 
            // btn_ListPrn
            // 
            this.btn_ListPrn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_ListPrn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListPrn.Appearance.Options.UseFont = true;
            this.btn_ListPrn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ListPrn.Location = new System.Drawing.Point(234, 451);
            this.btn_ListPrn.Name = "btn_ListPrn";
            this.btn_ListPrn.Size = new System.Drawing.Size(75, 23);
            this.btn_ListPrn.TabIndex = 359;
            this.btn_ListPrn.Text = "In danh sách";
            this.btn_ListPrn.Click += new System.EventHandler(this.btn_ListPrn_Click);
            // 
            // btn_Print108
            // 
            this.btn_Print108.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Print108.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print108.Appearance.Options.UseFont = true;
            this.btn_Print108.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Print108.Location = new System.Drawing.Point(70, 451);
            this.btn_Print108.Name = "btn_Print108";
            this.btn_Print108.Size = new System.Drawing.Size(158, 23);
            this.btn_Print108.TabIndex = 360;
            this.btn_Print108.Text = "In bảng cài kệ";
            this.btn_Print108.Click += new System.EventHandler(this.btn_Print108_Click);
            // 
            // Chk_SelectAll
            // 
            this.Chk_SelectAll.Location = new System.Drawing.Point(27, 178);
            this.Chk_SelectAll.Name = "Chk_SelectAll";
            this.Chk_SelectAll.Properties.Caption = "In toàn bộ các mặt hàng";
            this.Chk_SelectAll.Size = new System.Drawing.Size(153, 18);
            this.Chk_SelectAll.TabIndex = 361;
            this.Chk_SelectAll.CheckedChanged += new System.EventHandler(this.Chk_SelectAll_CheckedChanged);
            // 
            // cnvLekth7
            // 
            this.cnvLekth7.Location = new System.Drawing.Point(29, 203);
            this.cnvLekth7.Name = "cnvLekth7";
            this.cnvLekth7.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "In theo mã nội bộ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "In theo mã vạch nhà sản xuất")});
            this.cnvLekth7.Size = new System.Drawing.Size(489, 23);
            this.cnvLekth7.TabIndex = 362;
            // 
            // Lbl_Barcode
            // 
            this.Lbl_Barcode.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_Barcode.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_Barcode.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_Barcode.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Barcode.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Barcode.Appearance.Options.UseBackColor = true;
            this.Lbl_Barcode.Appearance.Options.UseBorderColor = true;
            this.Lbl_Barcode.Appearance.Options.UseFont = true;
            this.Lbl_Barcode.Appearance.Options.UseForeColor = true;
            this.Lbl_Barcode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_Barcode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_Barcode.Location = new System.Drawing.Point(382, 58);
            this.Lbl_Barcode.Name = "Lbl_Barcode";
            this.Lbl_Barcode.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_Barcode.Size = new System.Drawing.Size(136, 17);
            this.Lbl_Barcode.TabIndex = 364;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(337, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 13);
            this.labelControl7.TabIndex = 363;
            this.labelControl7.Text = "Barcode";
            // 
            // FrmNoteLabelPrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(544, 484);
            this.Controls.Add(this.Lbl_Barcode);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.cnvLekth7);
            this.Controls.Add(this.Chk_SelectAll);
            this.Controls.Add(this.btn_Print108);
            this.Controls.Add(this.btn_ListPrn);
            this.Controls.Add(this.Lbl_PosName);
            this.Controls.Add(this.Lbl_Rtprice);
            this.Controls.Add(this.Lbl_SuppId);
            this.Controls.Add(this.Lbl_SuppName);
            this.Controls.Add(this.Lbl_GrpId);
            this.Controls.Add(this.Lbl_FullName);
            this.Controls.Add(this.Lbl_ShortName);
            this.Controls.Add(this.Lbl_GrpName);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.LabelControl5);
            this.Controls.Add(this.Txt_Remark);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.LabelControl22);
            this.Controls.Add(this.Txt_Qty);
            this.Controls.Add(this.btn_Move);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl17);
            this.Controls.Add(this.Txt_PosId);
            this.Controls.Add(this.Grd_Labels);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.LabelControl15);
            this.Controls.Add(this.LabelControl14);
            this.Controls.Add(this.Txt_GoodsId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNoteLabelPrn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNoteLabelPrn";
            this.Load += new System.EventHandler(this.FrmNoteLabelPrn_Load);
            this.Activated += new System.EventHandler(this.FrmNoteLabelPrn_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Qty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PosId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Labels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Labels_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GoodsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_SelectAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnvLekth7.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public static bool _notebarcode;
        internal SimpleButton btn_Add;
        internal SimpleButton btn_Exit;
        internal SimpleButton btn_ListPrn;
        internal SimpleButton btn_Move;
        internal SimpleButton btn_Print108;
        internal SimpleButton btn_Reset;
        private CheckEdit Chk_SelectAll;
        private RadioGroup cnvLekth7;
        internal GridControl Grd_Labels;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl14;
        internal LabelControl LabelControl15;
        internal LabelControl LabelControl17;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl22;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl5;
        internal LabelControl labelControl7;
        internal GridView Labels_View;
        internal LabelControl Lbl_Barcode;
        internal LabelControl Lbl_FullName;
        internal LabelControl Lbl_GrpId;
        internal LabelControl Lbl_GrpName;
        internal LabelControl Lbl_PosName;
        internal LabelControl Lbl_Rtprice;
        internal LabelControl Lbl_ShortName;
        internal LabelControl Lbl_SuppId;
        internal LabelControl Lbl_SuppName;
        private OleDbConnection oleDbConnection_0;
        private OleDbConnection oleDbConnection_1;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private string string_0;
        internal TextEdit Txt_GoodsId;
        internal TextEdit Txt_PosId;
        internal TextEdit Txt_Qty;
        internal TextEdit Txt_Remark;


        #endregion

    }
}
