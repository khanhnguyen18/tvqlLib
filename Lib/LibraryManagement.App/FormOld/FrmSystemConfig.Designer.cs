using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmSystemConfig
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_DbPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_DbName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Confirm = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_ServerName = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Menus = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DbPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DbName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ServerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(367, 225);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.Txt_DbPass);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.Txt_UserName);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.Txt_DbName);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.btn_Confirm);
            this.xtraTabPage1.Controls.Add(this.Txt_ServerName);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(363, 200);
            this.xtraTabPage1.Text = "Config";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Password";
            // 
            // Txt_DbPass
            // 
            this.Txt_DbPass.Location = new System.Drawing.Point(135, 113);
            this.Txt_DbPass.Name = "Txt_DbPass";
            this.Txt_DbPass.Properties.PasswordChar = '*';
            this.Txt_DbPass.Size = new System.Drawing.Size(193, 20);
            this.Txt_DbPass.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "User Name";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(135, 87);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_UserName.Size = new System.Drawing.Size(193, 20);
            this.Txt_UserName.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Database\'s Name";
            // 
            // Txt_DbName
            // 
            this.Txt_DbName.Location = new System.Drawing.Point(135, 61);
            this.Txt_DbName.Name = "Txt_DbName";
            this.Txt_DbName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_DbName.Size = new System.Drawing.Size(193, 20);
            this.Txt_DbName.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Server\'s Name";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(135, 157);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // Txt_ServerName
            // 
            this.Txt_ServerName.Location = new System.Drawing.Point(135, 35);
            this.Txt_ServerName.Name = "Txt_ServerName";
            this.Txt_ServerName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_ServerName.Properties.PasswordChar = '*';
            this.Txt_ServerName.Size = new System.Drawing.Size(193, 20);
            this.Txt_ServerName.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(360, 196);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(137, 248);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Reset Data";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Menus
            // 
            this.btn_Menus.Location = new System.Drawing.Point(218, 248);
            this.btn_Menus.Name = "btn_Menus";
            this.btn_Menus.Size = new System.Drawing.Size(75, 23);
            this.btn_Menus.TabIndex = 5;
            this.btn_Menus.Text = "Menus";
            this.btn_Menus.Click += new System.EventHandler(this.btn_Menus_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(299, 248);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "ESC-Exit";
            // 
            // FrmSystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(391, 276);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Menus);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSystemConfig";
            this.Text = "FrmSystemConfig";
            this.Load += new System.EventHandler(this.FrmSystemConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DbPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DbName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ServerName.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        private SimpleButton btn_Confirm;
        private SimpleButton btn_Exit;
        private SimpleButton btn_Menus;
        private SimpleButton btn_Reset;
        //private IContainer components;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private SqlCommand sqlCommand_0;
        private SqlConnection sqlConnection_0;
        private string string_0;
        private TextEdit Txt_DbName;
        private TextEdit Txt_DbPass;
        private TextEdit Txt_ServerName;
        private TextEdit Txt_UserName;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;


        #endregion

    }
}
