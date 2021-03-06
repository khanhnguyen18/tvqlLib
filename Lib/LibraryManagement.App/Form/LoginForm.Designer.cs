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
using LibraryManagement.App.Properties;

namespace LibraryManagement.App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.IjSwogAv6 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.Txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(205, 247);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(80, 23);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "ESC-Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // IjSwogAv6
            // 
            this.IjSwogAv6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IjSwogAv6.Location = new System.Drawing.Point(71, 247);
            this.IjSwogAv6.Name = "IjSwogAv6";
            this.IjSwogAv6.Size = new System.Drawing.Size(80, 23);
            this.IjSwogAv6.TabIndex = 2;
            this.IjSwogAv6.Text = "Đăng nhập";
            this.IjSwogAv6.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(-210, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 383;
            this.groupBox1.TabStop = false;
            // 
            // LabelControl15
            // 
            this.LabelControl15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl15.Appearance.Options.UseFont = true;
            this.LabelControl15.Location = new System.Drawing.Point(15, 215);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(44, 13);
            this.LabelControl15.TabIndex = 387;
            this.LabelControl15.Text = "Mật khẩu";
            // 
            // LabelControl14
            // 
            this.LabelControl14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new System.Drawing.Point(15, 189);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(72, 13);
            this.LabelControl14.TabIndex = 386;
            this.LabelControl14.Text = "Tên đăng nhập";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Txt_Password.EnterMoveNextControl = true;
            this.Txt_Password.Location = new System.Drawing.Point(95, 212);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.Properties.Appearance.Options.UseFont = true;
            this.Txt_Password.Properties.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(207, 20);
            this.Txt_Password.TabIndex = 1;
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Password_KeyDown);
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Txt_UserName.EditValue = "ThuVien";
            this.Txt_UserName.EnterMoveNextControl = true;
            this.Txt_UserName.Location = new System.Drawing.Point(95, 186);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserName.Properties.Appearance.Options.UseFont = true;
            this.Txt_UserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_UserName.Properties.MaxLength = 26;
            this.Txt_UserName.Size = new System.Drawing.Size(207, 20);
            this.Txt_UserName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(296, 22);
            this.labelControl1.TabIndex = 391;
            this.labelControl1.Text = "PHẦN MỀM QUẢN LÝ THƯ VIỆN";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::LibraryManagement.App.Properties.Resources.Book;
            this.pictureEdit1.Location = new System.Drawing.Point(91, 56);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImage")));
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(171, 121);
            this.pictureEdit1.TabIndex = 390;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(343, 277);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.LabelControl15);
            this.Controls.Add(this.LabelControl14);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.IjSwogAv6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Opacity = 0.95;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogIn";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private bool bool_0;
        private SimpleButton btn_Exit;
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