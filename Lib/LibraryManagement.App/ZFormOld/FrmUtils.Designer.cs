using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmUtils
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
            this.GrdUtils = new DevExpress.XtraGrid.GridControl();
            this.DetailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Confirm = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUtils)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdUtils
            // 
            this.GrdUtils.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdUtils.Location = new System.Drawing.Point(12, 39);
            this.GrdUtils.MainView = this.DetailView;
            this.GrdUtils.Name = "GrdUtils";
            this.GrdUtils.Size = new System.Drawing.Size(478, 160);
            this.GrdUtils.TabIndex = 373;
            this.GrdUtils.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DetailView});
            this.GrdUtils.Click += new System.EventHandler(this.GrdUtils_Click);
            // 
            // DetailView
            // 
            this.DetailView.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailView.Appearance.FooterPanel.Options.UseFont = true;
            this.DetailView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailView.Appearance.HeaderPanel.Options.UseFont = true;
            this.DetailView.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailView.Appearance.Row.Options.UseFont = true;
            this.DetailView.GridControl = this.GrdUtils;
            this.DetailView.Name = "DetailView";
            this.DetailView.OptionsBehavior.Editable = false;
            this.DetailView.OptionsView.ShowGroupPanel = false;
            this.DetailView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.DetailView_FocusedRowChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(259, 279);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 23);
            this.btn_Exit.TabIndex = 375;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Confirm.Location = new System.Drawing.Point(151, 279);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(88, 23);
            this.btn_Confirm.TabIndex = 374;
            this.btn_Confirm.Text = "Thực hiện";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(12, 205);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit1.Size = new System.Drawing.Size(478, 66);
            this.memoEdit1.TabIndex = 376;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(273, 25);
            this.labelControl1.TabIndex = 377;
            this.labelControl1.Text = "Tiện ích hỗ trợ người dùng";
            // 
            // FrmUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(499, 314);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.GrdUtils);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUtils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUtils";
            this.Load += new System.EventHandler(this.FrmUtils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdUtils)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Confirm;
        private SimpleButton btn_Exit;
        internal GridView DetailView;
        internal GridControl GrdUtils;
        //private IContainer components;
        private LabelControl labelControl1;
        private MemoEdit memoEdit1;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;

        #endregion
    }
}
