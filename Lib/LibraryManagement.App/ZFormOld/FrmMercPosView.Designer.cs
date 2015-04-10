using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    partial class FrmMercPosView
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
            this.Txt_GoodsId = new TextEdit();
            this.IipWvDcZu = new LabelControl();
            this.LabelControl1 = new LabelControl();
            this.Lbl_GrpName = new LabelControl();
            this.Lbl_MercName = new LabelControl();
            this.Lbl_GrpId = new LabelControl();
            this.Lbl_Rtprice = new LabelControl();
            this.labelControl2 = new LabelControl();
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.btn_Exit = new SimpleButton();
            this.Cmb_Barcode = new ComboBoxEdit();
            this.gridControl2 = new GridControl();
            this.gridView2 = new GridView();
            this.Txt_GoodsId.Properties.BeginInit();
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            this.Cmb_Barcode.Properties.BeginInit();
            this.gridControl2.BeginInit();
            this.gridView2.BeginInit();
            base.SuspendLayout();
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new Point(140, 11);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Properties.Appearance.BackColor = Color.PapayaWhip;
            this.Txt_GoodsId.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_GoodsId.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_GoodsId.Properties.Appearance.Options.UseFont = true;
            this.Txt_GoodsId.Properties.Mask.PlaceHolder = ' ';
            this.Txt_GoodsId.Properties.MaxLength = 20;
            this.Txt_GoodsId.Properties.ValidateOnEnterKey = true;
            this.Txt_GoodsId.Size = new Size(0x98, 20);
            this.Txt_GoodsId.TabIndex = 360;
            this.Txt_GoodsId.EditValueChanged += new EventHandler(this.Txt_GoodsId_EditValueChanged);
            this.Txt_GoodsId.KeyDown += new KeyEventHandler(this.Txt_GoodsId_KeyDown);
            this.IipWvDcZu.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.IipWvDcZu.Appearance.Options.UseFont = true;
            this.IipWvDcZu.Location = new Point(0x1d, 40);
            this.IipWvDcZu.Name = "LabelControl5";
            this.IipWvDcZu.Size = new Size(0x3a, 13);
            this.IipWvDcZu.TabIndex = 0x16c;
            this.IipWvDcZu.Text = "Thuộc nh\x00f3m";
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(0x1d, 14);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x2c, 13);
            this.LabelControl1.TabIndex = 0x16a;
            this.LabelControl1.Text = "M\x00e3 h\x00e0ng ";
            this.Lbl_GrpName.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_GrpName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_GrpName.Appearance.BorderColor = Color.White;
            this.Lbl_GrpName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_GrpName.Appearance.ForeColor = Color.Black;
            this.Lbl_GrpName.Appearance.Options.UseBackColor = true;
            this.Lbl_GrpName.Appearance.Options.UseBorderColor = true;
            this.Lbl_GrpName.Appearance.Options.UseFont = true;
            this.Lbl_GrpName.Appearance.Options.UseForeColor = true;
            this.Lbl_GrpName.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_GrpName.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_GrpName.Location = new Point(0xe1, 0x26);
            this.Lbl_GrpName.Name = "Lbl_GrpName";
            this.Lbl_GrpName.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_GrpName.Size = new Size(0x100, 0x11);
            this.Lbl_GrpName.TabIndex = 0x16f;
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
            this.Lbl_MercName.Location = new Point(0x12a, 14);
            this.Lbl_MercName.Name = "Lbl_MercName";
            this.Lbl_MercName.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_MercName.Size = new Size(0x128, 0x11);
            this.Lbl_MercName.TabIndex = 0x170;
            this.Lbl_GrpId.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_GrpId.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_GrpId.Appearance.BorderColor = Color.White;
            this.Lbl_GrpId.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_GrpId.Appearance.ForeColor = Color.Black;
            this.Lbl_GrpId.Appearance.Options.UseBackColor = true;
            this.Lbl_GrpId.Appearance.Options.UseBorderColor = true;
            this.Lbl_GrpId.Appearance.Options.UseFont = true;
            this.Lbl_GrpId.Appearance.Options.UseForeColor = true;
            this.Lbl_GrpId.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_GrpId.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_GrpId.Location = new Point(140, 0x26);
            this.Lbl_GrpId.Name = "Lbl_GrpId";
            this.Lbl_GrpId.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_GrpId.Size = new Size(0x4f, 0x11);
            this.Lbl_GrpId.TabIndex = 0x171;
            this.Lbl_GrpId.TextChanged += new EventHandler(this.Lbl_GrpId_TextChanged);
            this.Lbl_Rtprice.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_Rtprice.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_Rtprice.Appearance.BorderColor = Color.White;
            this.Lbl_Rtprice.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_Rtprice.Appearance.ForeColor = Color.Black;
            this.Lbl_Rtprice.Appearance.Options.UseBackColor = true;
            this.Lbl_Rtprice.Appearance.Options.UseBorderColor = true;
            this.Lbl_Rtprice.Appearance.Options.UseFont = true;
            this.Lbl_Rtprice.Appearance.Options.UseForeColor = true;
            this.Lbl_Rtprice.Appearance.Options.UseTextOptions = true;
            this.Lbl_Rtprice.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Lbl_Rtprice.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_Rtprice.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_Rtprice.Location = new Point(0x8d, 0x3d);
            this.Lbl_Rtprice.Name = "Lbl_Rtprice";
            this.Lbl_Rtprice.Padding = new Padding(3, 0, 3, 0);
            this.Lbl_Rtprice.Size = new Size(130, 0x11);
            this.Lbl_Rtprice.TabIndex = 0x175;
            this.labelControl2.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new Point(0x1d, 0x3e);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new Size(0x2f, 13);
            this.labelControl2.TabIndex = 0x174;
            this.labelControl2.Text = "Gi\x00e1 b\x00e1n lẻ";
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.Location = new Point(0x1d, 0x55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(0x26e, 0x7a);
            this.gridControl1.TabIndex = 0x17a;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.gridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x11f, 0x17a);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x58, 0x17);
            this.btn_Exit.TabIndex = 0x17d;
            this.btn_Exit.Text = "ESC-Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.Cmb_Barcode.Location = new Point(0x115, 0x3b);
            this.Cmb_Barcode.Name = "Cmb_Barcode";
            this.Cmb_Barcode.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.Cmb_Barcode.Size = new Size(0xcc, 20);
            this.Cmb_Barcode.TabIndex = 0x17e;
            this.gridControl2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl2.Location = new Point(0x1d, 0xd5);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new Size(0x26e, 0x9f);
            this.gridControl2.TabIndex = 0x17f;
            this.gridControl2.ViewCollection.AddRange(new BaseView[] { this.gridView2 });
            this.gridControl2.Click += new EventHandler(this.gridControl2_Click);
            this.gridView2.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x297, 0x1a0);
            base.Controls.Add(this.gridControl2);
            base.Controls.Add(this.Cmb_Barcode);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.gridControl1);
            base.Controls.Add(this.Lbl_Rtprice);
            base.Controls.Add(this.labelControl2);
            base.Controls.Add(this.Txt_GoodsId);
            base.Controls.Add(this.IipWvDcZu);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.Lbl_GrpName);
            base.Controls.Add(this.Lbl_MercName);
            base.Controls.Add(this.Lbl_GrpId);
            base.Name = "FrmMercPosView";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmMercPosView";
            base.FormClosing += new FormClosingEventHandler(this.FrmMercPosView_FormClosing);
            base.Load += new EventHandler(this.FrmMercPosView_Load);
            this.Txt_GoodsId.Properties.EndInit();
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            this.Cmb_Barcode.Properties.EndInit();
            this.gridControl2.EndInit();
            this.gridView2.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        internal SimpleButton btn_Exit;
        private ComboBoxEdit Cmb_Barcode;
        private GridControl gridControl1;
        private GridControl gridControl2;
        private GridView gridView1;
        private GridView gridView2;
        //private IContainer components;
        internal LabelControl IipWvDcZu;
        internal LabelControl LabelControl1;
        internal LabelControl labelControl2;
        internal LabelControl Lbl_GrpId;
        internal LabelControl Lbl_GrpName;
        internal LabelControl Lbl_MercName;
        internal LabelControl Lbl_Rtprice;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        internal TextEdit Txt_GoodsId;

        #endregion

    }
}
