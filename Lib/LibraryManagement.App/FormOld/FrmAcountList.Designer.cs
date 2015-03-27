using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Data.OleDb;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Drawing;
using DevExpress.Utils;
namespace LibraryManagement.App
{
    partial class FrmAcountList
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
            manager = new ComponentResourceManager(typeof(FrmAcountList));
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.btn_History = new SimpleButton();
            this.btnExit = new SimpleButton();
            this.btnPrint = new SimpleButton();
            this.printingSystem_0 = new PrintingSystem(this.components);
            this.printableComponentLink_0 = new PrintableComponentLink(this.components);
            this.btn_Detail = new SimpleButton();
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            ((ISupportInitialize)this.printingSystem_0).BeginInit();
            this.printableComponentLink_0.ImageCollection.BeginInit();
            base.SuspendLayout();
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.Location = new Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(0x288, 0x166);
            this.gridControl1.TabIndex = 0x188;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.gridControl1.Click += new EventHandler(this.pfeZyQnoF);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.btn_History.Anchor = AnchorStyles.Bottom;
            this.btn_History.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_History.Appearance.Options.UseFont = true;
            this.btn_History.Location = new Point(0x152, 0x184);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new Size(0x58, 0x17);
            this.btn_History.TabIndex = 0x18b;
            this.btn_History.Text = "Giao dịch";
            this.btnExit.Anchor = AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = DialogResult.Cancel;
            this.btnExit.Location = new Point(0x1b0, 0x184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x58, 0x17);
            this.btnExit.TabIndex = 0x18a;
            this.btnExit.Text = "&Tho\x00e1t";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.btnPrint.Anchor = AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new Point(0xf4, 0x184);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(0x58, 0x17);
            this.btnPrint.TabIndex = 0x189;
            this.btnPrint.Text = "Ctrl+P In";
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            this.printingSystem_0.Links.AddRange(new object[] { this.printableComponentLink_0 });
            this.printableComponentLink_0.Component = this.gridControl1;
            this.printableComponentLink_0.ImageCollection.ImageStream = (ImageCollectionStreamer)manager.GetObject("printableComponentLink1.ImageCollection.ImageStream");
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            this.btn_Detail.Anchor = AnchorStyles.Bottom;
            this.btn_Detail.DialogResult = DialogResult.Cancel;
            this.btn_Detail.Location = new Point(150, 0x184);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new Size(0x58, 0x17);
            this.btn_Detail.TabIndex = 0x1ef;
            this.btn_Detail.Text = "&Chi tiết";
            this.btn_Detail.Click += new EventHandler(this.btn_Detail_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(0x2a0, 0x1a7);
            base.Controls.Add(this.btn_Detail);
            base.Controls.Add(this.btn_History);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.btnPrint);
            base.Controls.Add(this.gridControl1);
            base.KeyPreview = true;
            base.Name = "FrmAcountList";
            this.Text = "FrmAcountList";
            base.Load += new EventHandler(this.FrmAcountList_Load);
            base.Activated += new EventHandler(this.FrmAcountList_Activated);
            base.FormClosing += new FormClosingEventHandler(this.FrmAcountList_FormClosing);
            base.KeyDown += new KeyEventHandler(this.FrmAcountList_KeyDown);
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            ((ISupportInitialize)this.printingSystem_0).EndInit();
            this.printableComponentLink_0.ImageCollection.EndInit();
            base.ResumeLayout(false);
        }

        
        private SimpleButton btn_Detail;
        internal SimpleButton btn_History;
        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        private GridControl gridControl1;
        private GridView gridView1;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private ComponentResourceManager manager;

        #endregion
    }
}