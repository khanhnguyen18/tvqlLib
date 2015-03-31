using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    partial class FrmRegister
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
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Serial = new DevExpress.XtraEditors.TextEdit();
            this.Txt_HDDinfo = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Confirm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Serial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_HDDinfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl15
            // 
            this.LabelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl15.Appearance.Options.UseFont = true;
            this.LabelControl15.Location = new System.Drawing.Point(22, 35);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(68, 13);
            this.LabelControl15.TabIndex = 395;
            this.LabelControl15.Text = "Mã bản quyền";
            // 
            // LabelControl14
            // 
            this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new System.Drawing.Point(22, 9);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(50, 13);
            this.LabelControl14.TabIndex = 394;
            this.LabelControl14.Text = "Mã ổ cứng";
            // 
            // Txt_Serial
            // 
            this.Txt_Serial.EnterMoveNextControl = true;
            this.Txt_Serial.Location = new System.Drawing.Point(116, 32);
            this.Txt_Serial.Name = "Txt_Serial";
            this.Txt_Serial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Serial.Properties.Appearance.Options.UseFont = true;
            this.Txt_Serial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Serial.Size = new System.Drawing.Size(237, 20);
            this.Txt_Serial.TabIndex = 390;
            // 
            // Txt_HDDinfo
            // 
            this.Txt_HDDinfo.EnterMoveNextControl = true;
            this.Txt_HDDinfo.Location = new System.Drawing.Point(116, 6);
            this.Txt_HDDinfo.Name = "Txt_HDDinfo";
            this.Txt_HDDinfo.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_HDDinfo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_HDDinfo.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_HDDinfo.Properties.Appearance.Options.UseFont = true;
            this.Txt_HDDinfo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_HDDinfo.Properties.MaxLength = 26;
            this.Txt_HDDinfo.Size = new System.Drawing.Size(237, 20);
            this.Txt_HDDinfo.TabIndex = 389;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(-195, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 393;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(189, 74);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(80, 23);
            this.btn_Exit.TabIndex = 392;
            this.btn_Exit.Text = "ESC-Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Confirm.Location = new System.Drawing.Point(103, 74);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(80, 23);
            this.btn_Confirm.TabIndex = 391;
            this.btn_Confirm.Text = "Đăng ký";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 103);
            this.Controls.Add(this.LabelControl15);
            this.Controls.Add(this.LabelControl14);
            this.Controls.Add(this.Txt_Serial);
            this.Controls.Add(this.Txt_HDDinfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegister_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Serial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_HDDinfo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Confirm;
        private SimpleButton btn_Exit;
        internal GroupBox groupBox1;
        //private IContainer components;
        internal LabelControl LabelControl14;
        internal LabelControl LabelControl15;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        internal TextEdit Txt_HDDinfo;
        internal TextEdit Txt_Serial;

        #endregion

    }
}
