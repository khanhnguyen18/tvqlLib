using DevExpress.XtraEditors;
using System.Drawing;
using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using LibraryManagement.App.Properties;
namespace LibraryManagement.App
{
    partial class AboutForm
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
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.PictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Appearance.Options.UseForeColor = true;
            this.LabelControl4.Appearance.Options.UseTextOptions = true;
            this.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelControl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelControl4.Location = new System.Drawing.Point(12, 104);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(299, 0);
            this.LabelControl4.TabIndex = 421;
            this.LabelControl4.Click += new System.EventHandler(this.LabelControl4_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(220, 22);
            this.labelControl2.TabIndex = 426;
            this.labelControl2.Text = "Phần mềm quản lý thư viện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 427;
            this.label1.Text = "Version 1.0.0.0";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(83, 15);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(192, 20);
            this.textEdit1.TabIndex = 428;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 429;
            this.labelControl1.Text = "Số đăng ký";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(83, 69);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 430;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(83, 43);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(192, 20);
            this.textEdit2.TabIndex = 431;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 432;
            this.labelControl3.Text = "Số licence";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEdit2);
            this.panelControl1.Controls.Add(this.btnRegister);
            this.panelControl1.Location = new System.Drawing.Point(15, 183);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(300, 112);
            this.panelControl1.TabIndex = 433;
            // 
            // PictureEdit1
            // 
            this.PictureEdit1.EditValue = global::LibraryManagement.App.Properties.Resources.Book;
            this.PictureEdit1.Location = new System.Drawing.Point(109, 12);
            this.PictureEdit1.Name = "PictureEdit1";
            this.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PictureEdit1.Size = new System.Drawing.Size(89, 56);
            this.PictureEdit1.TabIndex = 423;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(120, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 434;
            this.btnExit.Text = "Thoát";
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(327, 303);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.PictureEdit1);
            this.Controls.Add(this.LabelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal LabelControl labelControl2;
        internal LabelControl LabelControl4;
        #endregion
        private Label label1;
        private TextEdit textEdit1;
        private LabelControl labelControl1;
        private SimpleButton btnRegister;
        private TextEdit textEdit2;
        private LabelControl labelControl3;
        private PanelControl panelControl1;
        internal PictureEdit PictureEdit1;
        private SimpleButton btnExit;
    }
}