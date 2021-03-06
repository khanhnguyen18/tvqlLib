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
    partial class FrmLibraryInfo
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
            manager = new ComponentResourceManager(typeof(FrmLibraryInfo));
            this.GrdStockInfo = new GridControl();
            this.gridView1 = new GridView();
            this.btnExit = new SimpleButton();
            this.btnPrint = new SimpleButton();
            this.groupBox1 = new GroupBox();
            this.Lbl_StockName = new LabelControl();
            this.LabelControl17 = new LabelControl();
            this.Txt_StockId = new TextEdit();
            this.printingSystem_0 = new PrintingSystem(this.components);
            this.IjSwogAv6 = new PrintableComponentLink(this.components);
            this.GrdStockInfo.BeginInit();
            this.gridView1.BeginInit();
            this.Txt_StockId.Properties.BeginInit();
            ((ISupportInitialize)this.printingSystem_0).BeginInit();
            base.SuspendLayout();
            this.GrdStockInfo.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.GrdStockInfo.Location = new Point(12, 0x26);
            this.GrdStockInfo.MainView = this.gridView1;
            this.GrdStockInfo.Name = "GrdStockInfo";
            this.GrdStockInfo.Size = new Size(0x285, 0x144);
            this.GrdStockInfo.TabIndex = 0x175;
            this.GrdStockInfo.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.gridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.GrdStockInfo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.btnExit.Anchor = AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new Point(0x159, 0x17d);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x58, 0x17);
            this.btnExit.TabIndex = 0x178;
            this.btnExit.Text = "&Tho\x00e1t";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.btnPrint.Anchor = AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new Point(0xef, 0x17d);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(0x58, 0x17);
            this.btnPrint.TabIndex = 0x177;
            this.btnPrint.Text = "Ctrl+P In";
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            this.groupBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.groupBox1.Location = new Point(-60, 0x170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x318, 5);
            this.groupBox1.TabIndex = 390;
            this.groupBox1.TabStop = false;
            this.Lbl_StockName.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_StockName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_StockName.Appearance.BorderColor = Color.White;
            this.Lbl_StockName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_StockName.Appearance.ForeColor = Color.Black;
            this.Lbl_StockName.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_StockName.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_StockName.Location = new Point(0xc4, 15);
            this.Lbl_StockName.Name = "Lbl_StockName";
            this.Lbl_StockName.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_StockName.Size = new Size(0x100, 0x11);
            this.Lbl_StockName.TabIndex = 410;
            this.LabelControl17.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LabelControl17.Location = new Point(12, 15);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new Size(0x4c, 13);
            this.LabelControl17.TabIndex = 0x199;
            this.LabelControl17.Text = "Thư viện/kho";
            this.Txt_StockId.EnterMoveNextControl = true;
            this.Txt_StockId.Location = new Point(0x61, 12);
            this.Txt_StockId.Name = "Txt_StockId";
            this.Txt_StockId.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_StockId.Properties.Appearance.Options.UseFont = true;
            this.Txt_StockId.Size = new Size(0x5d, 20);
            this.Txt_StockId.TabIndex = 0x198;
            this.Txt_StockId.EditValueChanged += new EventHandler(this.Txt_StockId_EditValueChanged);
            this.Txt_StockId.KeyDown += new KeyEventHandler(this.Txt_StockId_KeyDown);
            this.printingSystem_0.Links.AddRange(new object[] { this.IjSwogAv6 });
            this.IjSwogAv6.Component = this.GrdStockInfo;
            this.IjSwogAv6.ImageCollection.ImageStream = (ImageCollectionStreamer)manager.GetObject("printableComponentLink1.ImageCollection.ImageStream");
            this.IjSwogAv6.PrintingSystem = this.printingSystem_0;
            this.IjSwogAv6.PrintingSystemBase = this.printingSystem_0;
            this.IjSwogAv6.CreateReportHeaderArea += new CreateAreaEventHandler(this.IjSwogAv6_CreateReportHeaderArea);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(0x2a0, 0x1a0);
            base.Controls.Add(this.Lbl_StockName);
            base.Controls.Add(this.LabelControl17);
            base.Controls.Add(this.Txt_StockId);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.btnPrint);
            base.Controls.Add(this.GrdStockInfo);
            base.KeyPreview = true;
            base.Name = "FrmLibraryInfo";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmLibraryInfo";
            base.Activated += new EventHandler(this.FrmLibraryInfo_Activated);
            base.Load += new EventHandler(this.iWyIskLbe);
            base.KeyDown += new KeyEventHandler(this.FrmLibraryInfo_KeyDown);
            this.GrdStockInfo.EndInit();
            this.gridView1.EndInit();
            this.Txt_StockId.Properties.EndInit();
            ((ISupportInitialize)this.printingSystem_0).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        internal GridControl GrdStockInfo;
        internal GridView gridView1;
        internal GroupBox groupBox1;
        //private IContainer components;
        private PrintableComponentLink IjSwogAv6;
        internal LabelControl LabelControl17;
        internal LabelControl Lbl_StockName;
        private PrintingSystem printingSystem_0;
        internal TextEdit Txt_StockId;

        #endregion

    }
}