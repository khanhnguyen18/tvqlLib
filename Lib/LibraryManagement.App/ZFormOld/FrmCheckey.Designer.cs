
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmCheckey
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
            this.Tx4 = new TextBox();
            this.Tx3 = new TextBox();
            this.Tx2 = new TextBox();
            this.Tx1 = new TextBox();
            this.IipWvDcZu = new Button();
            this.btnExit = new Button();
            this.txtUserName = new TextBox();
            this.txtCompany = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.lblHDDserial = new Label();
            this.groupBox1 = new GroupBox();
            this.groupBox2 = new GroupBox();
            base.SuspendLayout();
            this.Tx4.CharacterCasing = CharacterCasing.Upper;
            this.Tx4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Tx4.Location = new Point(0x102, 0x57);
            this.Tx4.MaxLength = 6;
            this.Tx4.Name = "Tx4";
            this.Tx4.Size = new Size(0x38, 0x15);
            this.Tx4.TabIndex = 5;
            this.Tx4.TextAlign = HorizontalAlignment.Center;
            this.Tx3.CharacterCasing = CharacterCasing.Upper;
            this.Tx3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Tx3.Location = new Point(0xd9, 0x57);
            this.Tx3.MaxLength = 3;
            this.Tx3.Name = "Tx3";
            this.Tx3.Size = new Size(0x23, 0x15);
            this.Tx3.TabIndex = 4;
            this.Tx3.TextAlign = HorizontalAlignment.Center;
            this.Tx2.CharacterCasing = CharacterCasing.Upper;
            this.Tx2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Tx2.Location = new Point(0xb0, 0x57);
            this.Tx2.MaxLength = 3;
            this.Tx2.Name = "Tx2";
            this.Tx2.Size = new Size(0x23, 0x15);
            this.Tx2.TabIndex = 3;
            this.Tx2.TextAlign = HorizontalAlignment.Center;
            this.Tx1.CharacterCasing = CharacterCasing.Upper;
            this.Tx1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Tx1.Location = new Point(0x7a, 0x57);
            this.Tx1.MaxLength = 4;
            this.Tx1.Name = "Tx1";
            this.Tx1.Size = new Size(0x30, 0x15);
            this.Tx1.TabIndex = 2;
            this.Tx1.TextAlign = HorizontalAlignment.Center;
            this.IipWvDcZu.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.IipWvDcZu.Location = new Point(0x55, 0x87);
            this.IipWvDcZu.Name = "btnConfirm";
            this.IipWvDcZu.Size = new Size(0x4b, 0x17);
            this.IipWvDcZu.TabIndex = 6;
            this.IipWvDcZu.Text = "X\x00e1c nhận";
            this.IipWvDcZu.UseVisualStyleBackColor = true;
            this.IipWvDcZu.Click += new EventHandler(this.IipWvDcZu_Click);
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Location = new Point(0xb1, 0x87);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x4b, 0x17);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Tho\x00e1t";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.txtUserName.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtUserName.Location = new Point(0x7a, 0x23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new Size(0xc0, 0x15);
            this.txtUserName.TabIndex = 0;
            this.txtCompany.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCompany.Location = new Point(0x7a, 0x3d);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new Size(0xc0, 0x15);
            this.txtCompany.TabIndex = 1;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label1.Location = new Point(0x15, 0x26);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x4c, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Người đăng k\x00fd";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label2.Location = new Point(0x15, 0x40);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x40, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "T\x00ean c\x00f4ng ty";
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.Location = new Point(0x15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x4c, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "M\x00e3 số đăng k\x00fd";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.Location = new Point(0x15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "M\x00e3 số bản quyền";
            this.lblHDDserial.AutoSize = true;
            this.lblHDDserial.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblHDDserial.Location = new Point(0x77, 9);
            this.lblHDDserial.Name = "lblHDDserial";
            this.lblHDDserial.Size = new Size(0x8b, 13);
            this.lblHDDserial.TabIndex = 0x10;
            this.lblHDDserial.Text = "DS78-8UY-HFD-D56GT8";
            this.groupBox1.Location = new Point(-10, 0x15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1a1, 10);
            this.groupBox1.TabIndex = 0x11;
            this.groupBox1.TabStop = false;
            this.groupBox2.Location = new Point(-39, 0x75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x1a1, 10);
            this.groupBox2.TabIndex = 0x12;
            this.groupBox2.TabStop = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(0x152, 0xa7);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.lblHDDserial);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.txtCompany);
            base.Controls.Add(this.txtUserName);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.IipWvDcZu);
            base.Controls.Add(this.Tx4);
            base.Controls.Add(this.Tx3);
            base.Controls.Add(this.Tx2);
            base.Controls.Add(this.Tx1);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.Name = "FrmCheckey";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Đăng k\x00fd bản quyền";
            base.TopMost = true;
            base.Load += new EventHandler(this.FrmCheckey_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private Button btnExit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        //private IContainer components;
        private Button IipWvDcZu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblHDDserial;
        private string string_0;
        private TextBox Tx1;
        private TextBox Tx2;
        private TextBox Tx3;
        private TextBox Tx4;
        private TextBox txtCompany;
        private TextBox txtUserName;

        #endregion
    }
}