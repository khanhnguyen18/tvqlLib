﻿using DevExpress.Utils;
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
    partial class FrmAutoOrder
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
        private void InitializeComponent()
        {
            this.Lbl_Unit = new LabelControl();
            this.btn_Add = new SimpleButton();
            this.Txt_DtDelivery = new TextEdit();
            this.labelControl2 = new LabelControl();
            this.Txt_Qty = new TextEdit();
            this.LabelControl22 = new LabelControl();
            this.Txt_Price = new TextEdit();
            this.LabelControl3 = new LabelControl();
            this.Lbl_ExpName = new LabelControl();
            this.Txt_ExpID = new TextEdit();
            this.ddvqeXfa4 = new LabelControl();
            this.Txt_GoodsId = new TextEdit();
            this.LabelControl1 = new LabelControl();
            this.Lbl_MercName = new LabelControl();
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.gridControl2 = new GridControl();
            this.welftZbha = new GridView();
            this.btnReset = new SimpleButton();
            this.btnExit = new SimpleButton();
            this.btnCreateTrans = new SimpleButton();
            this.LabelControl14 = new LabelControl();
            this.Txt_Remark = new TextEdit();
            this.CwwJoLjYp = new TextEdit();
            this.labelControl4 = new LabelControl();
            this.Txt_DtDelivery.Properties.BeginInit();
            this.Txt_Qty.Properties.BeginInit();
            this.Txt_Price.Properties.BeginInit();
            this.Txt_ExpID.Properties.BeginInit();
            this.Txt_GoodsId.Properties.BeginInit();
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            this.gridControl2.BeginInit();
            this.welftZbha.BeginInit();
            this.Txt_Remark.Properties.BeginInit();
            this.CwwJoLjYp.Properties.BeginInit();
            base.SuspendLayout();
            this.Lbl_Unit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_Unit.Appearance.Options.UseFont = true;
            this.Lbl_Unit.Location = new Point(0xc4, 0x3d);
            this.Lbl_Unit.Name = "Lbl_Unit";
            this.Lbl_Unit.Size = new Size(0x12, 13);
            this.Lbl_Unit.TabIndex = 0x19b;
            this.Lbl_Unit.Text = "CAI";
            this.btn_Add.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Location = new Point(0x202, 60);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new Size(0x4b, 0x17);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Th\x00eam";
            this.btn_Add.Click += new EventHandler(this.btn_Add_Click);
            this.Txt_DtDelivery.EditValue = "";
            this.Txt_DtDelivery.EnterMoveNextControl = true;
            this.Txt_DtDelivery.Location = new Point(0x201, 0x1f);
            this.Txt_DtDelivery.Name = "Txt_DtDelivery";
            this.Txt_DtDelivery.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_DtDelivery.Properties.Appearance.Options.UseFont = true;
            this.Txt_DtDelivery.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_DtDelivery.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_DtDelivery.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_DtDelivery.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_DtDelivery.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_DtDelivery.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_DtDelivery.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_DtDelivery.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_DtDelivery.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_DtDelivery.Size = new Size(0x4c, 20);
            this.Txt_DtDelivery.TabIndex = 2;
            this.labelControl2.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new Point(0x1cb, 0x22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new Size(0x30, 13);
            this.labelControl2.TabIndex = 410;
            this.labelControl2.Text = "Ng\x00e0y giao";
            this.Txt_Qty.EnterMoveNextControl = true;
            this.Txt_Qty.Location = new Point(120, 0x39);
            this.Txt_Qty.Name = "Txt_Qty";
            this.Txt_Qty.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Qty.Properties.Appearance.Options.UseFont = true;
            this.Txt_Qty.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Qty.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_Qty.Properties.DisplayFormat.FormatString = "n0";
            this.Txt_Qty.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.Txt_Qty.Properties.EditFormat.FormatString = "n0";
            this.Txt_Qty.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.Txt_Qty.Properties.Mask.EditMask = "n0";
            this.Txt_Qty.Properties.Mask.MaskType = MaskType.Numeric;
            this.Txt_Qty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Qty.Size = new Size(70, 20);
            this.Txt_Qty.TabIndex = 3;
            this.LabelControl22.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new Point(0x1d, 60);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new Size(0x3d, 13);
            this.LabelControl22.TabIndex = 0x198;
            this.LabelControl22.Text = "Số lượng đặt";
            this.Txt_Price.EnterMoveNextControl = true;
            this.Txt_Price.Location = new Point(0x14f, 0x3a);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Price.Properties.Appearance.Options.UseFont = true;
            this.Txt_Price.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Price.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_Price.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_Price.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.Txt_Price.Properties.EditFormat.FormatString = "n2";
            this.Txt_Price.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.Txt_Price.Properties.Mask.EditMask = "n2";
            this.Txt_Price.Properties.Mask.MaskType = MaskType.Numeric;
            this.Txt_Price.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Price.Size = new Size(0x66, 20);
            this.Txt_Price.TabIndex = 4;
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new Point(0xf9, 0x3d);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(80, 13);
            this.LabelControl3.TabIndex = 0x199;
            this.LabelControl3.Text = "Gi\x00e1 nhập đề nghị";
            this.Lbl_ExpName.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_ExpName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_ExpName.Appearance.BorderColor = Color.White;
            this.Lbl_ExpName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_ExpName.Appearance.ForeColor = Color.Black;
            this.Lbl_ExpName.Appearance.Options.UseBackColor = true;
            this.Lbl_ExpName.Appearance.Options.UseBorderColor = true;
            this.Lbl_ExpName.Appearance.Options.UseFont = true;
            this.Lbl_ExpName.Appearance.Options.UseForeColor = true;
            this.Lbl_ExpName.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_ExpName.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_ExpName.Location = new Point(0xc4, 0x22);
            this.Lbl_ExpName.Name = "Lbl_ExpName";
            this.Lbl_ExpName.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_ExpName.Size = new Size(0x102, 0x11);
            this.Lbl_ExpName.TabIndex = 0x197;
            this.Txt_ExpID.EditValue = "";
            this.Txt_ExpID.EnterMoveNextControl = true;
            this.Txt_ExpID.Location = new Point(120, 0x1f);
            this.Txt_ExpID.Name = "Txt_ExpID";
            this.Txt_ExpID.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_ExpID.Properties.Appearance.Options.UseFont = true;
            this.Txt_ExpID.Properties.MaxLength = 5;
            this.Txt_ExpID.Size = new Size(70, 20);
            this.Txt_ExpID.TabIndex = 1;
            this.Txt_ExpID.EditValueChanged += new EventHandler(this.Txt_ExpID_EditValueChanged);
            this.Txt_ExpID.KeyDown += new KeyEventHandler(this.Txt_ExpID_KeyDown);
            this.ddvqeXfa4.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ddvqeXfa4.Appearance.Options.UseFont = true;
            this.ddvqeXfa4.Location = new Point(0x1d, 0x22);
            this.ddvqeXfa4.Name = "LabelControl17";
            this.ddvqeXfa4.Size = new Size(0x41, 13);
            this.ddvqeXfa4.TabIndex = 0x196;
            this.ddvqeXfa4.Text = "Nh\x00e0 cung cấp";
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new Point(120, 6);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Padding = new Padding(3, 0, 0, 0);
            this.Txt_GoodsId.Properties.Appearance.BackColor = Color.PapayaWhip;
            this.Txt_GoodsId.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_GoodsId.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_GoodsId.Properties.Appearance.Options.UseFont = true;
            this.Txt_GoodsId.Properties.Mask.PlaceHolder = ' ';
            this.Txt_GoodsId.Properties.MaxLength = 20;
            this.Txt_GoodsId.Properties.ValidateOnEnterKey = true;
            this.Txt_GoodsId.Size = new Size(0x5e, 20);
            this.Txt_GoodsId.TabIndex = 0;
            this.Txt_GoodsId.EditValueChanged += new EventHandler(this.Txt_GoodsId_EditValueChanged);
            this.Txt_GoodsId.KeyDown += new KeyEventHandler(this.pfeZyQnoF);
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(0x1d, 11);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x2c, 13);
            this.LabelControl1.TabIndex = 0x194;
            this.LabelControl1.Text = "M\x00e3 h\x00e0ng ";
            this.Lbl_MercName.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_MercName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_MercName.Appearance.BorderColor = Color.White;
            this.Lbl_MercName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Lbl_MercName.Appearance.ForeColor = Color.Black;
            this.Lbl_MercName.Appearance.Options.UseBackColor = true;
            this.Lbl_MercName.Appearance.Options.UseBorderColor = true;
            this.Lbl_MercName.Appearance.Options.UseFont = true;
            this.Lbl_MercName.Appearance.Options.UseForeColor = true;
            this.Lbl_MercName.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_MercName.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_MercName.Location = new Point(0xd9, 9);
            this.Lbl_MercName.Name = "Lbl_MercName";
            this.Lbl_MercName.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_MercName.Size = new Size(0xed, 0x11);
            this.Lbl_MercName.TabIndex = 0x195;
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.Location = new Point(12, 0xbc);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(0x25e, 0x80);
            this.gridControl1.TabIndex = 0x19c;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridControl2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.gridControl2.Location = new Point(12, 0x56);
            this.gridControl2.MainView = this.welftZbha;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new Size(0x25e, 0x63);
            this.gridControl2.TabIndex = 0x19d;
            this.gridControl2.ViewCollection.AddRange(new BaseView[] { this.welftZbha });
            this.welftZbha.GridControl = this.gridControl2;
            this.welftZbha.Name = "gridView2";
            this.welftZbha.OptionsBehavior.Editable = false;
            this.welftZbha.OptionsView.ShowGroupPanel = false;
            this.btnReset.Anchor = AnchorStyles.Bottom;
            this.btnReset.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Location = new Point(0x116, 0x160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(0x4b, 0x17);
            this.btnReset.TabIndex = 0x1a1;
            this.btnReset.Text = "Khởi tạo";
            this.btnReset.Click += new EventHandler(this.btnReset_Click);
            this.btnExit.Anchor = AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new Point(0x16e, 0x160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x4b, 0x17);
            this.btnExit.TabIndex = 0x1a0;
            this.btnExit.Text = "ESC-Tho\x00e1t";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.btnCreateTrans.Anchor = AnchorStyles.Bottom;
            this.btnCreateTrans.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCreateTrans.Appearance.Options.UseFont = true;
            this.btnCreateTrans.Location = new Point(190, 0x160);
            this.btnCreateTrans.Name = "btnCreateTrans";
            this.btnCreateTrans.Size = new Size(0x4b, 0x17);
            this.btnCreateTrans.TabIndex = 0x19e;
            this.btnCreateTrans.Text = "Tạo G/D";
            this.btnCreateTrans.Click += new EventHandler(this.btnCreateTrans_Click);
            this.LabelControl14.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.LabelControl14.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new Point(14, 0x145);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new Size(0x23, 13);
            this.LabelControl14.TabIndex = 0x1a3;
            this.LabelControl14.Text = "Ghi ch\x00fa";
            this.Txt_Remark.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Txt_Remark.EnterMoveNextControl = true;
            this.Txt_Remark.Location = new Point(0x37, 0x142);
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Remark.Properties.Appearance.Options.UseFont = true;
            this.Txt_Remark.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Remark.Size = new Size(0x1fd, 20);
            this.Txt_Remark.TabIndex = 0x1a2;
            this.CwwJoLjYp.EnterMoveNextControl = true;
            this.CwwJoLjYp.Location = new Point(0x217, 5);
            this.CwwJoLjYp.Name = "Txt_EndQty";
            this.CwwJoLjYp.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CwwJoLjYp.Properties.Appearance.Options.UseFont = true;
            this.CwwJoLjYp.Properties.Appearance.Options.UseTextOptions = true;
            this.CwwJoLjYp.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.CwwJoLjYp.Properties.DisplayFormat.FormatString = "n2";
            this.CwwJoLjYp.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.CwwJoLjYp.Properties.EditFormat.FormatString = "n2";
            this.CwwJoLjYp.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.CwwJoLjYp.Properties.Mask.EditMask = "n2";
            this.CwwJoLjYp.Properties.Mask.MaskType = MaskType.Numeric;
            this.CwwJoLjYp.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CwwJoLjYp.Size = new Size(0x36, 20);
            this.CwwJoLjYp.TabIndex = 420;
            this.labelControl4.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new Point(0x1e9, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new Size(40, 13);
            this.labelControl4.TabIndex = 0x1a5;
            this.labelControl4.Text = "Hiện tồn";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(630, 0x17e);
            base.Controls.Add(this.CwwJoLjYp);
            base.Controls.Add(this.labelControl4);
            base.Controls.Add(this.LabelControl14);
            base.Controls.Add(this.Txt_Remark);
            base.Controls.Add(this.btnReset);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.btnCreateTrans);
            base.Controls.Add(this.gridControl2);
            base.Controls.Add(this.gridControl1);
            base.Controls.Add(this.Lbl_Unit);
            base.Controls.Add(this.btn_Add);
            base.Controls.Add(this.Txt_DtDelivery);
            base.Controls.Add(this.labelControl2);
            base.Controls.Add(this.Txt_Qty);
            base.Controls.Add(this.LabelControl22);
            base.Controls.Add(this.Txt_Price);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.Lbl_ExpName);
            base.Controls.Add(this.Txt_ExpID);
            base.Controls.Add(this.ddvqeXfa4);
            base.Controls.Add(this.Txt_GoodsId);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.Lbl_MercName);
            base.Name = "FrmAutoOrder";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmAutoOrder";
            base.Load += new EventHandler(this.FrmAutoOrder_Load);
            base.Activated += new EventHandler(this.FrmAutoOrder_Activated);
            base.FormClosing += new FormClosingEventHandler(this.FrmAutoOrder_FormClosing);
            this.Txt_DtDelivery.Properties.EndInit();
            this.Txt_Qty.Properties.EndInit();
            this.Txt_Price.Properties.EndInit();
            this.Txt_ExpID.Properties.EndInit();
            this.Txt_GoodsId.Properties.EndInit();
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            this.gridControl2.EndInit();
            this.welftZbha.EndInit();
            this.Txt_Remark.Properties.EndInit();
            this.CwwJoLjYp.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        internal SimpleButton btn_Add;
        internal SimpleButton btnCreateTrans;
        internal SimpleButton btnExit;
        internal SimpleButton btnReset;
        internal TextEdit CwwJoLjYp;
        internal LabelControl ddvqeXfa4;
        private GridControl gridControl1;
        private GridControl gridControl2;
        private GridView gridView1;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl14;
        internal LabelControl labelControl2;
        internal LabelControl LabelControl22;
        internal LabelControl LabelControl3;
        internal LabelControl labelControl4;
        internal LabelControl Lbl_ExpName;
        internal LabelControl Lbl_MercName;
        internal LabelControl Lbl_Unit;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private string string_2;
        internal TextEdit Txt_DtDelivery;
        internal TextEdit Txt_ExpID;
        internal TextEdit Txt_GoodsId;
        internal TextEdit Txt_Price;
        internal TextEdit Txt_Qty;
        internal TextEdit Txt_Remark;
        private GridView welftZbha;

        

        #endregion
    }
}