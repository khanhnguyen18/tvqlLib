using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    partial class FrmHisPrice
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
            manager = new ComponentResourceManager(typeof(FrmHisPrice));
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.btnExit = new SimpleButton();
            this.btnPrint = new SimpleButton();
            this.printingSystem_0 = new PrintingSystem(this.components);
            this.printableComponentLink_0 = new PrintableComponentLink(this.components);
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            ((ISupportInitialize)this.printingSystem_0).BeginInit();
            this.printableComponentLink_0.ImageCollection.BeginInit();
            base.SuspendLayout();
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.Location = new Point(12, 6);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(0x25e, 0x147);
            this.gridControl1.TabIndex = 0x19d;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.btnExit.Anchor = AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new Point(0x144, 0x15b);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x58, 0x17);
            this.btnExit.TabIndex = 0x19f;
            this.btnExit.Text = "ESC-Tho\x00e1t";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.btnPrint.Anchor = AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new Point(0xda, 0x15b);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(0x58, 0x17);
            this.btnPrint.TabIndex = 0x19e;
            this.btnPrint.Text = "Ctrl+P In";
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            this.printingSystem_0.Links.AddRange(new object[] { this.printableComponentLink_0 });
            this.printingSystem_0.EndPrint += new EventHandler(this.printingSystem_0_EndPrint);
            this.printableComponentLink_0.Component = this.gridControl1;
            this.printableComponentLink_0.ImageCollection.ImageStream = (ImageCollectionStreamer)manager.GetObject("printableComponentLink1.ImageCollection.ImageStream");
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(630, 0x17e);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.btnPrint);
            base.Controls.Add(this.gridControl1);
            base.KeyPreview = true;
            base.Name = "FrmHisPrice";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmHisPrice";
            base.Load += new EventHandler(this.FrmHisPrice_Load);
            base.Activated += new EventHandler(this.FrmHisPrice_Activated);
            base.KeyDown += new KeyEventHandler(this.FrmHisPrice_KeyDown);
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            ((ISupportInitialize)this.printingSystem_0).EndInit();
            this.printableComponentLink_0.ImageCollection.EndInit();
            base.ResumeLayout(false);
        }
        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        private GridControl gridControl1;
        private GridView gridView1;
        //private IContainer components;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private string string_0;

        #endregion
    }
}