using DevExpress.XtraGrid.Views.Base;
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
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    partial class FrmReports
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
            this.btn_Exit = new SimpleButton();
            this.btn_Confirm = new SimpleButton();
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.labelControl1 = new LabelControl();
            this.chkSummary = new CheckEdit();
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            this.chkSummary.Properties.BeginInit();
            base.SuspendLayout();
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x1a7, 0x145);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x58, 0x17);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "ESC-Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Confirm.Location = new Point(0x141, 0x145);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new Size(0x58, 0x17);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Tạo b\x00e1o c\x00e1o";
            this.btn_Confirm.Click += new EventHandler(this.btn_Confirm_Click);
            this.gridControl1.Location = new Point(12, 0x2b);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new Size(0x1fc, 0x112);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.gridControl1.Click += new EventHandler(this.gridControl1_Click);
            this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.labelControl1.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new Size(0xb8, 0x19);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Lựa chọn b\x00e1o c\x00e1o";
            this.chkSummary.Location = new Point(12, 0x149);
            this.chkSummary.Name = "chkSummary";
            this.chkSummary.Properties.Caption = "Tạo b\x00e1o c\x00e1o t\x00f3m tắt";
            this.chkSummary.Size = new Size(170, 0x13);
            this.chkSummary.TabIndex = 9;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x213, 360);
            base.Controls.Add(this.chkSummary);
            base.Controls.Add(this.labelControl1);
            base.Controls.Add(this.gridControl1);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Confirm);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "FrmReports";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmReports";
            base.Load += new EventHandler(this.FrmReports_Load);
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            this.chkSummary.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        public static int _status;
        public static string _stktype;
        public static bool _sumrp;
        public static string _trcode;
        private BindingSource bindingSource_0;
        private bool bool_0;
        private SimpleButton btn_Confirm;
        private SimpleButton btn_Exit;
        private CheckEdit chkSummary;
        private GridControl gridControl1;
        private GridView gridView1;
        //private IContainer components;
        private LabelControl labelControl1;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private string string_2;
        #endregion
    }
}
