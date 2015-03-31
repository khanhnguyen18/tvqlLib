using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.OleDb;
using DevExpress.XtraPrinting;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;

namespace LibraryManagement.App
{
    partial class FrmFastSlow
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
            this.components = new Container();
            manager = new ComponentResourceManager(typeof(FrmFastSlow));
            this.btnExit = new SimpleButton();
            this.btnPrint = new SimpleButton();
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.Lbl_duaration = new LabelControl();
            this.printingSystem_0 = new PrintingSystem(this.components);
            this.printableComponentLink_0 = new PrintableComponentLink(this.components);
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            ((ISupportInitialize)this.printingSystem_0).BeginInit();
            this.printableComponentLink_0.ImageCollection.BeginInit();
            base.SuspendLayout();
            this.btnExit.Anchor = AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new Point(0x185, 0x1a9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x58, 0x17);
            this.btnExit.TabIndex = 380;
            this.btnExit.Text = "ESC-Tho\x00e1t";
            this.btnPrint.Anchor = AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new Point(0x113, 0x1a9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(0x58, 0x17);
            this.btnPrint.TabIndex = 0x17b;
            this.btnPrint.Text = "Ctrl+P In";
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.Location = new Point(12, 0x1f);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(0x2d8, 0x184);
            this.gridControl1.TabIndex = 0x17a;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.gridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.Lbl_duaration.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.Lbl_duaration.Appearance.ForeColor = Color.DarkBlue;
            this.Lbl_duaration.Appearance.Options.UseFont = true;
            this.Lbl_duaration.Appearance.Options.UseForeColor = true;
            this.Lbl_duaration.Location = new Point(12, 12);
            this.Lbl_duaration.Name = "Lbl_duaration";
            this.Lbl_duaration.Size = new Size(0xf3, 13);
            this.Lbl_duaration.TabIndex = 0x17d;
            this.Lbl_duaration.Text = "Từ ng\x00e0y 20/01/2010 đến ng\x00e0y 30/01/2010";
            this.printingSystem_0.Links.AddRange(new object[] { this.printableComponentLink_0 });
            this.printableComponentLink_0.Component = this.gridControl1;
            this.printableComponentLink_0.ImageCollection.ImageStream = (ImageCollectionStreamer)manager.GetObject("printableComponentLink1.ImageCollection.ImageStream");
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(0x2f0, 460);
            base.Controls.Add(this.Lbl_duaration);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.btnPrint);
            base.Controls.Add(this.gridControl1);
            base.KeyPreview = true;
            base.Name = "FrmFastSlow";
            this.Text = "FrmFastSlow";
            base.Load += new EventHandler(this.FrmFastSlow_Load);
            base.Activated += new EventHandler(this.FrmFastSlow_Activated);
            base.KeyDown += new KeyEventHandler(this.FrmFastSlow_KeyDown);
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            ((ISupportInitialize)this.printingSystem_0).EndInit();
            this.printableComponentLink_0.ImageCollection.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        private GridControl gridControl1;
        private GridView gridView1;
        private LabelControl Lbl_duaration;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private ComponentResourceManager manager;

        #endregion
    }
}