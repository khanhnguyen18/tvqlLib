using DevExpress.XtraEditors;
using System.Drawing;
using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
namespace LibraryManagement.App
{
    partial class FrmAbout
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
            this.LabelControl4 = new LabelControl();
            this.btn_Exit = new SimpleButton();
            this.labelControl2 = new LabelControl();
            this.PictureEdit1 = new PictureEdit();
            this.PictureEdit1.Properties.BeginInit();
            base.SuspendLayout();
            this.LabelControl4.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LabelControl4.Appearance.ForeColor = Color.RoyalBlue;
            this.LabelControl4.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            this.LabelControl4.AutoSizeMode = LabelAutoSizeMode.Vertical;
            this.LabelControl4.Cursor = Cursors.Hand;
            this.LabelControl4.Location = new Point(12, 0x68);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new Size(0x12b, 0x40);
            this.LabelControl4.TabIndex = 0x1a5;
            this.LabelControl4.Text = "";
            this.LabelControl4.Click += new EventHandler(this.LabelControl4_Click);
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x7b, 0xb2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(80, 0x17);
            this.btn_Exit.TabIndex = 0x1a9;
            this.btn_Exit.Text = "&Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.labelControl2.Appearance.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.labelControl2.Location = new Point(0x38, 0x4a);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new Size(220, 0x16);
            this.labelControl2.TabIndex = 0x1aa;
            this.labelControl2.Text = "Phần mềm quản l\x00fd thư viện";
            //TODO
            //this.PictureEdit1.EditValue = Resources.books_trans;
            this.PictureEdit1.Location = new Point(0x7b, 12);
            this.PictureEdit1.Name = "PictureEdit1";
            this.PictureEdit1.Properties.Appearance.BackColor = Color.Transparent;
            this.PictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.PictureEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
            this.PictureEdit1.Properties.SizeMode = PictureSizeMode.Stretch;
            this.PictureEdit1.Size = new Size(0x44, 0x38);
            this.PictureEdit1.TabIndex = 0x1a7;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode =System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x147, 0xd5);
            base.Controls.Add(this.labelControl2);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.PictureEdit1);
            base.Controls.Add(this.LabelControl4);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.MaximizeBox = false;
            base.Name = "FrmAbout";
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            base.Load += new EventHandler(this.FrmAbout_Load);
            this.PictureEdit1.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private SimpleButton btn_Exit;
        internal LabelControl labelControl2;
        internal LabelControl LabelControl4;
        internal PictureEdit PictureEdit1;
        #endregion
    }
}