using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmEncyptCode
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
            this.btnDecrypt = new SimpleButton();
            this.btnEncrypt = new SimpleButton();
            this.LabelControl4 = new LabelControl();
            this.LabelControl5 = new LabelControl();
            this.LabelControl6 = new LabelControl();
            this.LabelControl3 = new LabelControl();
            this.LabelControl2 = new LabelControl();
            this.LabelControl1 = new LabelControl();
            this.txtDecrypted = new TextEdit();
            this.txtPassword1 = new TextEdit();
            this.txtEncrypted1 = new TextEdit();
            this.txtEncrypted = new TextEdit();
            this.txtPassword = new TextEdit();
            this.txtOriginal = new TextEdit();
            this.txtDecrypted.Properties.BeginInit();
            this.txtPassword1.Properties.BeginInit();
            this.txtEncrypted1.Properties.BeginInit();
            this.txtEncrypted.Properties.BeginInit();
            this.txtPassword.Properties.BeginInit();
            this.txtOriginal.Properties.BeginInit();
            base.SuspendLayout();
            this.btnDecrypt.Location = new Point(0x1a2, 0x72);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new Size(0x4b, 0x17);
            this.btnDecrypt.TabIndex = 0x20;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new EventHandler(this.btnDecrypt_Click);
            this.btnEncrypt.Location = new Point(0x1a2, 0x1c);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new Size(0x4b, 0x17);
            this.btnEncrypt.TabIndex = 0x1f;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new EventHandler(this.RrqIxZxw5);
            this.LabelControl4.Location = new Point(9, 0x5d);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new Size(80, 13);
            this.LabelControl4.TabIndex = 30;
            this.LabelControl4.Text = "Encrypted String";
            this.LabelControl5.Location = new Point(9, 0x77);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new Size(0x2e, 13);
            this.LabelControl5.TabIndex = 0x1d;
            this.LabelControl5.Text = "Password";
            this.LabelControl6.Location = new Point(9, 0x91);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new Size(0x43, 13);
            this.LabelControl6.TabIndex = 0x1c;
            this.LabelControl6.Text = "Original String";
            this.LabelControl3.Location = new Point(9, 0x3a);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(80, 13);
            this.LabelControl3.TabIndex = 0x1b;
            this.LabelControl3.Text = "Encrypted String";
            this.LabelControl2.Location = new Point(9, 0x20);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new Size(0x2e, 13);
            this.LabelControl2.TabIndex = 0x1a;
            this.LabelControl2.Text = "Password";
            this.LabelControl1.Location = new Point(9, 6);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x43, 13);
            this.LabelControl1.TabIndex = 0x19;
            this.LabelControl1.Text = "Original String";
            this.txtDecrypted.EnterMoveNextControl = true;
            this.txtDecrypted.Location = new Point(0x60, 0x8e);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new Size(0x18d, 20);
            this.txtDecrypted.TabIndex = 0x18;
            this.txtPassword1.EnterMoveNextControl = true;
            this.txtPassword1.Location = new Point(0x60, 0x74);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new Size(0x13c, 20);
            this.txtPassword1.TabIndex = 0x17;
            this.txtEncrypted1.EnterMoveNextControl = true;
            this.txtEncrypted1.Location = new Point(0x60, 90);
            this.txtEncrypted1.Name = "txtEncrypted1";
            this.txtEncrypted1.Size = new Size(0x18d, 20);
            this.txtEncrypted1.TabIndex = 0x16;
            this.txtEncrypted.EnterMoveNextControl = true;
            this.txtEncrypted.Location = new Point(0x60, 0x37);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new Size(0x18d, 20);
            this.txtEncrypted.TabIndex = 0x15;
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new Point(0x60, 0x1d);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(0x13c, 20);
            this.txtPassword.TabIndex = 20;
            this.txtOriginal.EnterMoveNextControl = true;
            this.txtOriginal.Location = new Point(0x60, 3);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new Size(0x18d, 20);
            this.txtOriginal.TabIndex = 0x13;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x1f3, 0xa6);
            base.Controls.Add(this.btnDecrypt);
            base.Controls.Add(this.btnEncrypt);
            base.Controls.Add(this.LabelControl4);
            base.Controls.Add(this.LabelControl5);
            base.Controls.Add(this.LabelControl6);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.LabelControl2);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.txtDecrypted);
            base.Controls.Add(this.txtPassword1);
            base.Controls.Add(this.txtEncrypted1);
            base.Controls.Add(this.txtEncrypted);
            base.Controls.Add(this.txtPassword);
            base.Controls.Add(this.txtOriginal);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.MaximizeBox = false;
            base.Name = "FrmEncyptCode";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmEncyptCode";
            base.Load += new EventHandler(this.FrmEncyptCode_Load);
            this.txtDecrypted.Properties.EndInit();
            this.txtPassword1.Properties.EndInit();
            this.txtEncrypted1.Properties.EndInit();
            this.txtEncrypted.Properties.EndInit();
            this.txtPassword.Properties.EndInit();
            this.txtOriginal.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        internal SimpleButton btnDecrypt;
        internal SimpleButton btnEncrypt;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl5;
        internal LabelControl LabelControl6;
        internal TextEdit txtDecrypted;
        internal TextEdit txtEncrypted;
        internal TextEdit txtEncrypted1;
        internal TextEdit txtOriginal;
        internal TextEdit txtPassword;
        internal TextEdit txtPassword1;

        #endregion
    }
}
