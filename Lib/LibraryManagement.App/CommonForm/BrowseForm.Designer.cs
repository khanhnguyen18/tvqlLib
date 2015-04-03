using System.ComponentModel;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using System;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.Utils;
namespace LibraryManagement.App
{
    partial class BrowseForm
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
            manager = new ComponentResourceManager(typeof(BrowseForm));
            this.grd_Look = new GridControl();
            this.Look_View = new GridView();
            this.printingSystem_0 = new PrintingSystem(this.components);
            this.printableComponentLink_0 = new PrintableComponentLink(this.components);
            this.grd_Look.BeginInit();
            this.Look_View.BeginInit();
            ((ISupportInitialize)this.printingSystem_0).BeginInit();
            this.printableComponentLink_0.ImageCollection.BeginInit();
            base.SuspendLayout();
            this.grd_Look.Dock = DockStyle.Fill;
            this.grd_Look.Location = new Point(0, 0);
            this.grd_Look.MainView = this.Look_View;
            this.grd_Look.Name = "grd_Look";
            this.grd_Look.Size = new Size(0x28e, 0x1b7);
            this.grd_Look.TabIndex = 0;
            this.grd_Look.ViewCollection.AddRange(new BaseView[] { this.Look_View });
            this.grd_Look.DoubleClick += new EventHandler(this.grd_Look_DoubleClick);
            this.Look_View.GridControl = this.grd_Look;
            this.Look_View.Name = "Look_View";
            this.Look_View.OptionsView.ShowAutoFilterRow = true;
            this.Look_View.OptionsView.ShowFooter = true;
            this.Look_View.OptionsView.ShowGroupPanel = false;
            this.printingSystem_0.Links.AddRange(new object[] { this.printableComponentLink_0 });
            this.printableComponentLink_0.Component = this.grd_Look;
            this.printableComponentLink_0.ImageCollection.ImageStream = (ImageCollectionStreamer)manager.GetObject("printableComponentLink1.ImageCollection.ImageStream");
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x28e, 0x1b7);
            base.Controls.Add(this.grd_Look);
            base.KeyPreview = true;
            base.Name = "FrmBrowse";
            this.Text = "FrmBrowse";
            base.Load += new EventHandler(this.FrmBrowse_Load);
            base.KeyDown += new KeyEventHandler(this.FrmBrowse_KeyDown);
            this.grd_Look.EndInit();
            this.Look_View.EndInit();
            ((ISupportInitialize)this.printingSystem_0).EndInit();
            this.printableComponentLink_0.ImageCollection.EndInit();
            base.ResumeLayout(false);

        }

        public GridControl grd_Look;
        //private IContainer components;
        private GridView Look_View;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;



        #endregion

    }
}
