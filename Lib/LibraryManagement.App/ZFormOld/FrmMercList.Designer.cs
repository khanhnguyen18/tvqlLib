using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
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
    partial class FrmMercList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMercList));
            this.GrdMercList = new DevExpress.XtraGrid.GridControl();
            this.Merc_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.printingSystem_0 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink_0 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.ddvqeXfa4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ChangePrice = new DevExpress.XtraEditors.SimpleButton();
            this.btn_History = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMercList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merc_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdMercList
            // 
            this.GrdMercList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdMercList.Location = new System.Drawing.Point(12, 41);
            this.GrdMercList.MainView = this.Merc_View;
            this.GrdMercList.Name = "GrdMercList";
            this.GrdMercList.Size = new System.Drawing.Size(648, 327);
            this.GrdMercList.TabIndex = 373;
            this.GrdMercList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Merc_View});
            // 
            // Merc_View
            // 
            this.Merc_View.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Merc_View.Appearance.FooterPanel.Options.UseFont = true;
            this.Merc_View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Merc_View.Appearance.HeaderPanel.Options.UseFont = true;
            this.Merc_View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Merc_View.Appearance.Row.Options.UseFont = true;
            this.Merc_View.GridControl = this.GrdMercList;
            this.Merc_View.Name = "Merc_View";
            this.Merc_View.OptionsView.ShowAutoFilterRow = true;
            this.Merc_View.OptionsView.ShowFooter = true;
            this.Merc_View.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.pfeZyQnoF);
            this.Merc_View.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.Merc_View_FocusedColumnChanged);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(389, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 375;
            this.btnExit.Text = "&Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(195, 388);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 374;
            this.btnPrint.Text = "Ctrl+P In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printingSystem_0
            // 
            this.printingSystem_0.Links.AddRange(new object[] {
            this.printableComponentLink_0});
            // 
            // printableComponentLink_0
            // 
            this.printableComponentLink_0.Component = this.GrdMercList;
            // 
            // 
            // 
            this.printableComponentLink_0.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink_0.ImageCollection.ImageStream")));
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            // 
            // ddvqeXfa4
            // 
            this.ddvqeXfa4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddvqeXfa4.Appearance.Options.UseFont = true;
            this.ddvqeXfa4.Location = new System.Drawing.Point(154, 12);
            this.ddvqeXfa4.Name = "ddvqeXfa4";
            this.ddvqeXfa4.Size = new System.Drawing.Size(125, 23);
            this.ddvqeXfa4.TabIndex = 384;
            this.ddvqeXfa4.Text = "Đặt chiết khấu bán lẻ";
            this.ddvqeXfa4.Visible = false;
            this.ddvqeXfa4.Click += new System.EventHandler(this.ddvqeXfa4_Click);
            // 
            // btn_ChangePrice
            // 
            this.btn_ChangePrice.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePrice.Appearance.Options.UseFont = true;
            this.btn_ChangePrice.Location = new System.Drawing.Point(16, 12);
            this.btn_ChangePrice.Name = "btn_ChangePrice";
            this.btn_ChangePrice.Size = new System.Drawing.Size(125, 23);
            this.btn_ChangePrice.TabIndex = 383;
            this.btn_ChangePrice.Text = "Thay đổi giá bán lẻ";
            this.btn_ChangePrice.Visible = false;
            this.btn_ChangePrice.Click += new System.EventHandler(this.btn_ChangePrice_Click);
            // 
            // btn_History
            // 
            this.btn_History.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_History.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Appearance.Options.UseFont = true;
            this.btn_History.Location = new System.Drawing.Point(292, 388);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(88, 23);
            this.btn_History.TabIndex = 385;
            this.btn_History.Text = "Giao dịch";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // FrmMercList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(672, 423);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.ddvqeXfa4);
            this.Controls.Add(this.btn_ChangePrice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.GrdMercList);
            this.KeyPreview = true;
            this.Name = "FrmMercList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMercList";
            this.Load += new System.EventHandler(this.FrmMercList_Load);
            this.Activated += new System.EventHandler(this.FrmMercList_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMercList_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMercList_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMercList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Merc_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).EndInit();
            this.ResumeLayout(false);

        }
        internal SimpleButton btn_ChangePrice;
        internal SimpleButton btn_History;
        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        internal SimpleButton ddvqeXfa4;
        internal GridControl GrdMercList;
        //private IContainer components;
        internal GridView Merc_View;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private string string_0;
        private string string_1;
        private string string_2;


        #endregion

    }
}
