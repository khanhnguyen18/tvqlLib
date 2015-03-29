using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmChangePass
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
            this.GroupBox2 = new GroupBox();
            this.Txt_UserName = new TextEdit();
            this.pfeZyQnoF = new LabelControl();
            this.GroupBox1 = new GroupBox();
            this.LabelControl3 = new LabelControl();
            this.Txt_OldPass = new TextEdit();
            this.Txt_ConfirmPass = new TextEdit();
            this.LabelControl2 = new LabelControl();
            this.LabelControl1 = new LabelControl();
            this.btnExit = new SimpleButton();
            this.btnAccept = new SimpleButton();
            this.Txt_NewPass = new TextEdit();
            this.Txt_UserName.Properties.BeginInit();
            this.Txt_OldPass.Properties.BeginInit();
            this.Txt_ConfirmPass.Properties.BeginInit();
            this.Txt_NewPass.Properties.BeginInit();
            base.SuspendLayout();
            this.GroupBox2.Location = new Point(-184, 0x20);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x2ba, 5);
            this.GroupBox2.TabIndex = 0x68;
            this.GroupBox2.TabStop = false;
            this.Txt_UserName.Enabled = false;
            this.Txt_UserName.EnterMoveNextControl = true;
            this.Txt_UserName.Location = new Point(0x73, 6);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Properties.Appearance.BackColor = Color.RoyalBlue;
            this.Txt_UserName.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_UserName.Properties.Appearance.ForeColor = Color.White;
            this.Txt_UserName.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_UserName.Properties.Appearance.Options.UseFont = true;
            this.Txt_UserName.Properties.Appearance.Options.UseForeColor = true;
            this.Txt_UserName.Properties.AppearanceDisabled.BackColor = Color.RoyalBlue;
            this.Txt_UserName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_UserName.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_UserName.Size = new Size(0xcf, 20);
            this.Txt_UserName.TabIndex = 0x66;
            this.pfeZyQnoF.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.pfeZyQnoF.Appearance.Options.UseFont = true;
            this.pfeZyQnoF.Location = new Point(0x18, 9);
            this.pfeZyQnoF.Name = "LabelControl4";
            this.pfeZyQnoF.Size = new Size(70, 13);
            this.pfeZyQnoF.TabIndex = 0x67;
            this.pfeZyQnoF.Text = "Người sử dụng";
            this.GroupBox1.Location = new Point(-178, 0x8f);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x2ba, 5);
            this.GroupBox1.TabIndex = 0x65;
            this.GroupBox1.TabStop = false;
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new Point(0x18, 0x71);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x37, 13);
            this.LabelControl3.TabIndex = 100;
            this.LabelControl3.Text = "Nhập lại MK";
            this.Txt_OldPass.EnterMoveNextControl = true;
            this.Txt_OldPass.Location = new Point(0x73, 0x38);
            this.Txt_OldPass.Name = "Txt_OldPass";
            this.Txt_OldPass.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_OldPass.Properties.Appearance.Options.UseFont = true;
            this.Txt_OldPass.Properties.AppearanceDisabled.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Txt_OldPass.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_OldPass.Properties.PasswordChar = '*';
            this.Txt_OldPass.Size = new Size(0xcf, 20);
            this.Txt_OldPass.TabIndex = 0x5d;
            this.Txt_ConfirmPass.EnterMoveNextControl = true;
            this.Txt_ConfirmPass.Location = new Point(0x73, 110);
            this.Txt_ConfirmPass.Name = "Txt_ConfirmPass";
            this.Txt_ConfirmPass.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_ConfirmPass.Properties.Appearance.Options.UseFont = true;
            this.Txt_ConfirmPass.Properties.AppearanceDisabled.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Txt_ConfirmPass.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_ConfirmPass.Properties.PasswordChar = '*';
            this.Txt_ConfirmPass.Size = new Size(0xcf, 20);
            this.Txt_ConfirmPass.TabIndex = 0x5f;
            this.LabelControl2.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new Point(0x18, 0x56);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new Size(0x3f, 13);
            this.LabelControl2.TabIndex = 0x63;
            this.LabelControl2.Text = "Mật khẩu mới";
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(0x18, 0x3b);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x3a, 13);
            this.LabelControl1.TabIndex = 0x62;
            this.LabelControl1.Text = "Mật khẩu cũ";
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new Point(0xb1, 0x99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x58, 0x17);
            this.btnExit.TabIndex = 0x61;
            this.btnExit.Text = "ESC-Tho\x00e1t";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.btnAccept.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new Point(0x48, 0x99);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new Size(0x58, 0x17);
            this.btnAccept.TabIndex = 0x60;
            this.btnAccept.Text = "X\x00e1c nhận";
            this.btnAccept.Click += new EventHandler(this.btnAccept_Click);
            this.Txt_NewPass.EnterMoveNextControl = true;
            this.Txt_NewPass.Location = new Point(0x73, 0x53);
            this.Txt_NewPass.Name = "Txt_NewPass";
            this.Txt_NewPass.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_NewPass.Properties.Appearance.Options.UseFont = true;
            this.Txt_NewPass.Properties.AppearanceDisabled.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Txt_NewPass.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_NewPass.Properties.PasswordChar = '*';
            this.Txt_NewPass.Size = new Size(0xcf, 20);
            this.Txt_NewPass.TabIndex = 0x5e;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(0x150, 0xb9);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.Txt_UserName);
            base.Controls.Add(this.pfeZyQnoF);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.Txt_OldPass);
            base.Controls.Add(this.Txt_ConfirmPass);
            base.Controls.Add(this.LabelControl2);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.btnAccept);
            base.Controls.Add(this.Txt_NewPass);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "FrmChangePass";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmChangePass";
            base.Load += new EventHandler(this.FrmChangePass_Load);
            this.Txt_UserName.Properties.EndInit();
            this.Txt_OldPass.Properties.EndInit();
            this.Txt_ConfirmPass.Properties.EndInit();
            this.Txt_NewPass.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }


        internal SimpleButton btnAccept;
        internal SimpleButton btnExit;
        internal GroupBox GroupBox1;
        internal GroupBox GroupBox2;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl pfeZyQnoF;
        internal TextEdit Txt_ConfirmPass;
        internal TextEdit Txt_NewPass;
        internal TextEdit Txt_OldPass;
        internal TextEdit Txt_UserName;




        #endregion

    }
}