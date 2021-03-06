using DevExpress.XtraGrid.Views.Base;
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
    partial class FrmKitLabelPrn
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
            this.components = new Container();
            manager = new ComponentResourceManager(typeof(FrmKitLabelPrn));
            this.Lbl_PosName = new LabelControl();
            this.Lbl_Rtprice = new LabelControl();
            this.Lbl_FullName = new LabelControl();
            this.btn_Reset = new SimpleButton();
            this.LabelControl5 = new LabelControl();
            this.btn_Exit = new SimpleButton();
            this.LabelControl22 = new LabelControl();
            this.Txt_Qty = new TextEdit();
            this.btn_Move = new SimpleButton();
            this.btn_Add = new SimpleButton();
            this.LabelControl17 = new LabelControl();
            this.Txt_PosId = new TextEdit();
            this.Grd_Labels = new GridControl();
            this.Labels_View = new GridView();
            this.LabelControl1 = new LabelControl();
            this.LabelControl15 = new LabelControl();
            this.Txt_GoodsId = new TextEdit();
            this.printingSystem_0 = new PrintingSystem(this.components);
            this.printableComponentLink_0 = new PrintableComponentLink(this.components);
            this.btn_ListPrn = new SimpleButton();
            this.btn_Print108 = new SimpleButton();
            this.Txt_Qty.Properties.BeginInit();
            this.Txt_PosId.Properties.BeginInit();
            this.Grd_Labels.BeginInit();
            this.Labels_View.BeginInit();
            this.Txt_GoodsId.Properties.BeginInit();
            ((ISupportInitialize)this.printingSystem_0).BeginInit();
            this.printableComponentLink_0.ImageCollection.BeginInit();
            base.SuspendLayout();
            this.Lbl_PosName.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_PosName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_PosName.Appearance.BorderColor = Color.White;
            this.Lbl_PosName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_PosName.Appearance.ForeColor = Color.Black;
            this.Lbl_PosName.Appearance.Options.UseBackColor = true;
            this.Lbl_PosName.Appearance.Options.UseBorderColor = true;
            this.Lbl_PosName.Appearance.Options.UseFont = true;
            this.Lbl_PosName.Appearance.Options.UseForeColor = true;
            this.Lbl_PosName.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_PosName.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_PosName.Location = new Point(0xca, 10);
            this.Lbl_PosName.Name = "Lbl_PosName";
            this.Lbl_PosName.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_PosName.Size = new Size(0x13c, 0x11);
            this.Lbl_PosName.TabIndex = 0x166;
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
            this.Lbl_Rtprice.Location = new Point(0x193, 0x23);
            this.Lbl_Rtprice.Name = "Lbl_Rtprice";
            this.Lbl_Rtprice.Padding = new Padding(3, 0, 3, 0);
            this.Lbl_Rtprice.Size = new Size(0x73, 0x11);
            this.Lbl_Rtprice.TabIndex = 0x165;
            this.Lbl_FullName.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_FullName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_FullName.Appearance.BorderColor = Color.White;
            this.Lbl_FullName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_FullName.Appearance.ForeColor = Color.Black;
            this.Lbl_FullName.Appearance.Options.UseBackColor = true;
            this.Lbl_FullName.Appearance.Options.UseBorderColor = true;
            this.Lbl_FullName.Appearance.Options.UseFont = true;
            this.Lbl_FullName.Appearance.Options.UseForeColor = true;
            this.Lbl_FullName.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_FullName.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_FullName.Location = new Point(0x6f, 0x3a);
            this.Lbl_FullName.Name = "Lbl_FullName";
            this.Lbl_FullName.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_FullName.Size = new Size(0x197, 0x11);
            this.Lbl_FullName.TabIndex = 0x161;
            this.btn_Reset.Anchor = AnchorStyles.Bottom;
            this.btn_Reset.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Reset.Appearance.Options.UseFont = true;
            this.btn_Reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Reset.Location = new Point(0x13d, 0x1c3);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new Size(0x4b, 0x17);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Khởi tạo";
            this.btn_Reset.Click += new EventHandler(this.btn_Reset_Click);
            this.LabelControl5.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new Point(0x146, 0x24);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new Size(0x2f, 13);
            this.LabelControl5.TabIndex = 0x15d;
            this.LabelControl5.Text = "Gi\x00e1 b\x00e1n lẻ";
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(400, 0x1c3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "&Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.LabelControl22.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new Point(0xe7, 0x56);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new Size(0x3f, 13);
            this.LabelControl22.TabIndex = 0x159;
            this.LabelControl22.Text = "Số lượng tem";
            this.Txt_Qty.EditValue = "1";
            this.Txt_Qty.EnterMoveNextControl = true;
            this.Txt_Qty.Location = new Point(300, 0x53);
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
            this.Txt_Qty.Size = new Size(0x34, 20);
            this.Txt_Qty.TabIndex = 2;
            this.btn_Move.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Move.Appearance.Options.UseFont = true;
            this.btn_Move.Location = new Point(0x16b, 0x51);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new Size(0x4b, 0x17);
            this.btn_Move.TabIndex = 0x158;
            this.btn_Move.Text = "Bớt";
            this.btn_Move.Click += new EventHandler(this.btn_Move_Click);
            this.btn_Add.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Location = new Point(0x1ba, 0x51);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new Size(0x4b, 0x17);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Th\x00eam";
            this.btn_Add.Click += new EventHandler(this.btn_Add_Click);
            this.LabelControl17.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl17.Appearance.Options.UseFont = true;
            this.LabelControl17.Location = new Point(0x1b, 10);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new Size(0x31, 13);
            this.LabelControl17.TabIndex = 0x156;
            this.LabelControl17.Text = "Thuộc kho";
            this.Txt_PosId.EnterMoveNextControl = true;
            this.Txt_PosId.Location = new Point(0x6f, 7);
            this.Txt_PosId.Name = "Txt_PosId";
            this.Txt_PosId.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_PosId.Properties.Appearance.Options.UseFont = true;
            this.Txt_PosId.Size = new Size(0x55, 20);
            this.Txt_PosId.TabIndex = 7;
            this.Txt_PosId.EditValueChanged += new EventHandler(this.Txt_PosId_EditValueChanged);
            this.Grd_Labels.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Grd_Labels.Location = new Point(0x1b, 110);
            this.Grd_Labels.MainView = this.Labels_View;
            this.Grd_Labels.Name = "Grd_Labels";
            this.Grd_Labels.Size = new Size(0x1eb, 0x149);
            this.Grd_Labels.TabIndex = 340;
            this.Grd_Labels.ViewCollection.AddRange(new BaseView[] { this.Labels_View });
            this.Grd_Labels.Click += new EventHandler(this.Grd_Labels_Click);
            this.Labels_View.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Labels_View.Appearance.FooterPanel.Options.UseFont = true;
            this.Labels_View.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Labels_View.Appearance.HeaderPanel.Options.UseFont = true;
            this.Labels_View.GridControl = this.Grd_Labels;
            this.Labels_View.Name = "Labels_View";
            this.Labels_View.OptionsView.ShowFooter = true;
            this.Labels_View.OptionsView.ShowGroupPanel = false;
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(0x1b, 0x24);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x4a, 13);
            this.LabelControl1.TabIndex = 0x152;
            this.LabelControl1.Text = "M\x00e3 b\x00f3/g\x00f3i h\x00e0ng";
            this.LabelControl15.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl15.Appearance.Options.UseFont = true;
            this.LabelControl15.Location = new Point(0x1b, 60);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new Size(0x1b, 13);
            this.LabelControl15.TabIndex = 0x151;
            this.LabelControl15.Text = "M\x00f4 tả";
            this.Txt_GoodsId.EnterMoveNextControl = true;
            this.Txt_GoodsId.Location = new Point(0x6f, 0x21);
            this.Txt_GoodsId.Name = "Txt_GoodsId";
            this.Txt_GoodsId.Properties.Appearance.BackColor = Color.PapayaWhip;
            this.Txt_GoodsId.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_GoodsId.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_GoodsId.Properties.Appearance.Options.UseFont = true;
            this.Txt_GoodsId.Properties.Mask.PlaceHolder = ' ';
            this.Txt_GoodsId.Properties.MaxLength = 6;
            this.Txt_GoodsId.Properties.ValidateOnEnterKey = true;
            this.Txt_GoodsId.Size = new Size(0x7b, 20);
            this.Txt_GoodsId.TabIndex = 0;
            this.Txt_GoodsId.EditValueChanged += new EventHandler(this.Txt_GoodsId_EditValueChanged);
            this.Txt_GoodsId.KeyDown += new KeyEventHandler(this.Txt_GoodsId_KeyDown);
            this.printingSystem_0.Links.AddRange(new object[] { this.printableComponentLink_0 });
            this.printableComponentLink_0.Component = this.Grd_Labels;
            this.printableComponentLink_0.ImageCollection.ImageStream = (ImageCollectionStreamer)manager.GetObject("printableComponentLink1.ImageCollection.ImageStream");
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            this.btn_ListPrn.Anchor = AnchorStyles.Bottom;
            this.btn_ListPrn.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_ListPrn.Appearance.Options.UseFont = true;
            this.btn_ListPrn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ListPrn.Location = new Point(0xea, 0x1c3);
            this.btn_ListPrn.Name = "btn_ListPrn";
            this.btn_ListPrn.Size = new Size(0x4b, 0x17);
            this.btn_ListPrn.TabIndex = 0x167;
            this.btn_ListPrn.Text = "In danh s\x00e1ch";
            this.btn_ListPrn.Click += new EventHandler(this.btn_ListPrn_Click);
            this.btn_Print108.Anchor = AnchorStyles.Bottom;
            this.btn_Print108.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Print108.Appearance.Options.UseFont = true;
            this.btn_Print108.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Print108.Location = new Point(70, 0x1c3);
            this.btn_Print108.Name = "btn_Print108";
            this.btn_Print108.Size = new Size(0x9e, 0x17);
            this.btn_Print108.TabIndex = 360;
            this.btn_Print108.Text = "In tem b\x00f3 g\x00f3i h\x00e0ng A4";
            this.btn_Print108.Click += new EventHandler(this.btn_Print108_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x220, 0x1e4);
            base.Controls.Add(this.btn_Print108);
            base.Controls.Add(this.btn_ListPrn);
            base.Controls.Add(this.Lbl_PosName);
            base.Controls.Add(this.Lbl_Rtprice);
            base.Controls.Add(this.Lbl_FullName);
            base.Controls.Add(this.btn_Reset);
            base.Controls.Add(this.LabelControl5);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.LabelControl22);
            base.Controls.Add(this.Txt_Qty);
            base.Controls.Add(this.btn_Move);
            base.Controls.Add(this.btn_Add);
            base.Controls.Add(this.LabelControl17);
            base.Controls.Add(this.Txt_PosId);
            base.Controls.Add(this.Grd_Labels);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.LabelControl15);
            base.Controls.Add(this.Txt_GoodsId);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "FrmKitLabelPrn";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmKitLabelPrn";
            base.Load += new EventHandler(this.FrmKitLabelPrn_Load);
            base.Activated += new EventHandler(this.FrmKitLabelPrn_Activated);
            this.Txt_Qty.Properties.EndInit();
            this.Txt_PosId.Properties.EndInit();
            this.Grd_Labels.EndInit();
            this.Labels_View.EndInit();
            this.Txt_GoodsId.Properties.EndInit();
            ((ISupportInitialize)this.printingSystem_0).EndInit();
            this.printableComponentLink_0.ImageCollection.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        internal SimpleButton btn_Add;
        internal SimpleButton btn_Exit;
        internal SimpleButton btn_ListPrn;
        internal SimpleButton btn_Move;
        internal SimpleButton btn_Print108;
        internal SimpleButton btn_Reset;
        internal GridControl Grd_Labels;
        ////private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl15;
        internal LabelControl LabelControl17;
        internal LabelControl LabelControl22;
        internal LabelControl LabelControl5;
        internal GridView Labels_View;
        internal LabelControl Lbl_FullName;
        internal LabelControl Lbl_PosName;
        internal LabelControl Lbl_Rtprice;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private string string_0;
        internal TextEdit Txt_GoodsId;
        internal TextEdit Txt_PosId;
        internal TextEdit Txt_Qty;


        #endregion

    }
}