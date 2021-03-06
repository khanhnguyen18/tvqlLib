using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class ChangePassForm
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.pfeZyQnoF = new DevExpress.XtraEditors.LabelControl();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_OldPass = new DevExpress.XtraEditors.TextEdit();
            this.Txt_ConfirmPass = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_NewPass = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ConfirmPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NewPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Location = new System.Drawing.Point(-184, 32);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(698, 5);
            this.GroupBox2.TabIndex = 104;
            this.GroupBox2.TabStop = false;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.EnterMoveNextControl = true;
            this.Txt_UserName.Location = new System.Drawing.Point(115, 6);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Properties.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.Txt_UserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Txt_UserName.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_UserName.Properties.Appearance.Options.UseFont = true;
            this.Txt_UserName.Properties.Appearance.Options.UseForeColor = true;
            this.Txt_UserName.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.PeachPuff;
            this.Txt_UserName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_UserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_UserName.Size = new System.Drawing.Size(207, 20);
            this.Txt_UserName.TabIndex = 102;
            // 
            // pfeZyQnoF
            // 
            this.pfeZyQnoF.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfeZyQnoF.Appearance.Options.UseFont = true;
            this.pfeZyQnoF.Location = new System.Drawing.Point(24, 9);
            this.pfeZyQnoF.Name = "pfeZyQnoF";
            this.pfeZyQnoF.Size = new System.Drawing.Size(70, 13);
            this.pfeZyQnoF.TabIndex = 103;
            this.pfeZyQnoF.Text = "Người sử dụng";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Location = new System.Drawing.Point(-178, 143);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(698, 5);
            this.GroupBox1.TabIndex = 101;
            this.GroupBox1.TabStop = false;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(24, 113);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(41, 13);
            this.LabelControl3.TabIndex = 100;
            this.LabelControl3.Text = "Nhập lại ";
            // 
            // Txt_OldPass
            // 
            this.Txt_OldPass.EnterMoveNextControl = true;
            this.Txt_OldPass.Location = new System.Drawing.Point(115, 56);
            this.Txt_OldPass.Name = "Txt_OldPass";
            this.Txt_OldPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OldPass.Properties.Appearance.Options.UseFont = true;
            this.Txt_OldPass.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_OldPass.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_OldPass.Properties.PasswordChar = '*';
            this.Txt_OldPass.Size = new System.Drawing.Size(207, 20);
            this.Txt_OldPass.TabIndex = 93;
            // 
            // Txt_ConfirmPass
            // 
            this.Txt_ConfirmPass.EnterMoveNextControl = true;
            this.Txt_ConfirmPass.Location = new System.Drawing.Point(115, 110);
            this.Txt_ConfirmPass.Name = "Txt_ConfirmPass";
            this.Txt_ConfirmPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConfirmPass.Properties.Appearance.Options.UseFont = true;
            this.Txt_ConfirmPass.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_ConfirmPass.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_ConfirmPass.Properties.PasswordChar = '*';
            this.Txt_ConfirmPass.Size = new System.Drawing.Size(207, 20);
            this.Txt_ConfirmPass.TabIndex = 95;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(24, 86);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(63, 13);
            this.LabelControl2.TabIndex = 99;
            this.LabelControl2.Text = "Mật khẩu mới";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(24, 59);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(58, 13);
            this.LabelControl1.TabIndex = 98;
            this.LabelControl1.Text = "Mật khẩu cũ";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(177, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 97;
            this.btnExit.Text = "ESC-Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAccept.Location = new System.Drawing.Point(72, 153);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(88, 23);
            this.btnAccept.TabIndex = 96;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // Txt_NewPass
            // 
            this.Txt_NewPass.EnterMoveNextControl = true;
            this.Txt_NewPass.Location = new System.Drawing.Point(115, 83);
            this.Txt_NewPass.Name = "Txt_NewPass";
            this.Txt_NewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NewPass.Properties.Appearance.Options.UseFont = true;
            this.Txt_NewPass.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_NewPass.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_NewPass.Properties.PasswordChar = '*';
            this.Txt_NewPass.Size = new System.Drawing.Size(207, 20);
            this.Txt_NewPass.TabIndex = 94;
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(336, 185);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.pfeZyQnoF);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.Txt_OldPass);
            this.Controls.Add(this.Txt_ConfirmPass);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.Txt_NewPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi pass";
            this.Load += new System.EventHandler(this.FrmChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ConfirmPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NewPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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