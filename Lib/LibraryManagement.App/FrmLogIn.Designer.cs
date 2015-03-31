using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmLogIn
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
            this.btn_Exit = new SimpleButton();
            this.IjSwogAv6 = new SimpleButton();
            this.groupBox1 = new GroupBox();
            this.LabelControl15 = new LabelControl();
            this.LabelControl14 = new LabelControl();
            this.Txt_Password = new TextEdit();
            this.Txt_UserName = new TextEdit();
            this.btnAutoUpdate = new SimpleButton();
            this.labelControl1 = new LabelControl();
            this.pictureEdit1 = new PictureEdit();
            this.Txt_Password.Properties.BeginInit();
            this.Txt_UserName.Properties.BeginInit();
            this.pictureEdit1.Properties.BeginInit();
            base.SuspendLayout();
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x83, 0xf7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(80, 0x17);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "ESC-Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.IjSwogAv6.Anchor = AnchorStyles.Bottom;
            this.IjSwogAv6.Location = new Point(40, 0xf7);
            this.IjSwogAv6.Name = "btn_Confirm";
            this.IjSwogAv6.Size = new Size(80, 0x17);
            this.IjSwogAv6.TabIndex = 2;
            this.IjSwogAv6.Text = "Đăng nhập";
            this.IjSwogAv6.Click += new EventHandler(this.IjSwogAv6_Click);
            this.groupBox1.Anchor = AnchorStyles.Bottom;
            this.groupBox1.Location = new Point(-210, 0xed);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x2fa, 5);
            this.groupBox1.TabIndex = 0x17f;
            this.groupBox1.TabStop = false;
            this.LabelControl15.Anchor = AnchorStyles.Bottom;
            this.LabelControl15.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl15.Location = new Point(15, 0xd7);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new Size(0x2c, 13);
            this.LabelControl15.TabIndex = 0x183;
            this.LabelControl15.Text = "Mật khẩu";
            this.LabelControl14.Anchor = AnchorStyles.Bottom;
            this.LabelControl14.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl14.Location = new Point(15, 0xbd);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new Size(0x48, 13);
            this.LabelControl14.TabIndex = 0x182;
            this.LabelControl14.Text = "T\x00ean đăng nhập";
            this.Txt_Password.Anchor = AnchorStyles.Bottom;
            this.Txt_Password.EnterMoveNextControl = true;
            this.Txt_Password.Location = new Point(0x5f, 0xd4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Password.Properties.Appearance.Options.UseFont = true;
            this.Txt_Password.Properties.PasswordChar = '*';
            this.Txt_Password.Size = new Size(0xcf, 20);
            this.Txt_Password.TabIndex = 1;
            this.Txt_Password.KeyDown += new KeyEventHandler(this.Txt_Password_KeyDown);
            this.Txt_UserName.Anchor = AnchorStyles.Bottom;
            this.Txt_UserName.EnterMoveNextControl = true;
            this.Txt_UserName.Location = new Point(0x5f, 0xba);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_UserName.Properties.Appearance.Options.UseFont = true;
            this.Txt_UserName.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_UserName.Properties.MaxLength = 0x1a;
            this.Txt_UserName.Size = new Size(0xcf, 20);
            this.Txt_UserName.TabIndex = 0;
            this.btnAutoUpdate.Anchor = AnchorStyles.Bottom;
            this.btnAutoUpdate.Location = new Point(0xde, 0xf7);
            this.btnAutoUpdate.Name = "btnAutoUpdate";
            this.btnAutoUpdate.Size = new Size(80, 0x17);
            this.btnAutoUpdate.TabIndex = 0x185;
            this.btnAutoUpdate.Text = "Update";
            this.btnAutoUpdate.Click += new EventHandler(this.btnAutoUpdate_Click);
            this.labelControl1.Anchor = AnchorStyles.Bottom;
            this.labelControl1.Appearance.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.labelControl1.Location = new Point(0x1a, 0x16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new Size(0x128, 0x16);
            this.labelControl1.TabIndex = 0x187;
            this.labelControl1.Text = "PHẦN MỀM QUẢN L\x00dd THƯ VIỆN";
            //this.pictureEdit1.EditValue = Resources.books2;
            this.pictureEdit1.Location = new Point(0x5b, 0x38);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new Size(0xab, 0x79);
            this.pictureEdit1.TabIndex = 390;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x157, 0x115);
            base.Controls.Add(this.labelControl1);
            base.Controls.Add(this.pictureEdit1);
            base.Controls.Add(this.btnAutoUpdate);
            base.Controls.Add(this.LabelControl15);
            base.Controls.Add(this.LabelControl14);
            base.Controls.Add(this.Txt_Password);
            base.Controls.Add(this.Txt_UserName);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.IjSwogAv6);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.Name = "FrmLogIn";
            base.Opacity = 0.95;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmLogIn";
            base.TopMost = true;
            base.Load += new EventHandler(this.FrmLogIn_Load);
            base.KeyDown += new KeyEventHandler(this.FrmLogIn_KeyDown);
            this.Txt_Password.Properties.EndInit();
            this.Txt_UserName.Properties.EndInit();
            this.pictureEdit1.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private bool bool_0;
        private SimpleButton btn_Exit;
        private SimpleButton btnAutoUpdate;
        internal GroupBox groupBox1;
        //private IContainer components;
        private SimpleButton IjSwogAv6;
        internal LabelControl labelControl1;
        internal LabelControl LabelControl14;
        internal LabelControl LabelControl15;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PictureEdit pictureEdit1;
        private string string_0;
        private string string_1;
        private string string_2;
        internal TextEdit Txt_Password;
        internal TextEdit Txt_UserName;

        #endregion

    }
}