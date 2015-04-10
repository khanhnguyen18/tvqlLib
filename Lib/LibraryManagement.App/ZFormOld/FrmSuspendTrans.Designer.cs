using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraEditors;
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
    partial class FrmSuspendTrans
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
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.btnExit = new SimpleButton();
            this.btnPrint = new SimpleButton();
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            base.SuspendLayout();
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.Location = new Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(0x288, 0x19b);
            this.gridControl1.TabIndex = 0x17b;
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
            this.btnExit.Anchor = AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new Point(0x159, 0x1bf);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x58, 0x17);
            this.btnExit.TabIndex = 0x17d;
            this.btnExit.Text = "ESC-Tho\x00e1t";
            this.btnPrint.Anchor = AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new Point(0xef, 0x1bf);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(0x58, 0x17);
            this.btnPrint.TabIndex = 380;
            this.btnPrint.Text = "In to\x00e0n bộ";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x2a0, 0x1e2);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.btnPrint);
            base.Controls.Add(this.gridControl1);
            base.Name = "FrmSuspendTrans";
            this.Text = "FrmSuspendTrans";
            base.Load += new EventHandler(this.iWyIskLbe);
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            base.ResumeLayout(false);
        }
        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        private GridControl gridControl1;
        private GridView gridView1;
        //private IContainer components;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;


        #endregion

    }
}
