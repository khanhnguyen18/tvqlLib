using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmMessageQue
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
            this.pfeZyQnoF = new DevExpress.XtraEditors.LabelControl();
            this.lblSendDate = new DevExpress.XtraEditors.LabelControl();
            this.lblSendTime = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblSenderName = new DevExpress.XtraEditors.LabelControl();
            this.lblStationName = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pfeZyQnoF
            // 
            this.pfeZyQnoF.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pfeZyQnoF.Appearance.Options.UseFont = true;
            this.pfeZyQnoF.Location = new System.Drawing.Point(12, 33);
            this.pfeZyQnoF.Name = "pfeZyQnoF";
            this.pfeZyQnoF.Size = new System.Drawing.Size(59, 13);
            this.pfeZyQnoF.TabIndex = 373;
            this.pfeZyQnoF.Text = "Người gửi :";
            // 
            // lblSendDate
            // 
            this.lblSendDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSendDate.Appearance.Options.UseFont = true;
            this.lblSendDate.Location = new System.Drawing.Point(385, 33);
            this.lblSendDate.Name = "lblSendDate";
            this.lblSendDate.Size = new System.Drawing.Size(56, 13);
            this.lblSendDate.TabIndex = 372;
            this.lblSendDate.Text = "20/08/2008";
            // 
            // lblSendTime
            // 
            this.lblSendTime.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSendTime.Appearance.Options.UseFont = true;
            this.lblSendTime.Location = new System.Drawing.Point(348, 33);
            this.lblSendTime.Name = "lblSendTime";
            this.lblSendTime.Size = new System.Drawing.Size(28, 13);
            this.lblSendTime.TabIndex = 371;
            this.lblSendTime.Text = "20:35";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(289, 33);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(46, 13);
            this.LabelControl2.TabIndex = 370;
            this.LabelControl2.Text = "vào lúc :";
            // 
            // lblSenderName
            // 
            this.lblSenderName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSenderName.Appearance.Options.UseFont = true;
            this.lblSenderName.Location = new System.Drawing.Point(121, 33);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(54, 13);
            this.lblSenderName.TabIndex = 369;
            this.lblSenderName.Text = "NGUOI GUI";
            // 
            // lblStationName
            // 
            this.lblStationName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStationName.Appearance.Options.UseFont = true;
            this.lblStationName.Location = new System.Drawing.Point(121, 14);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(50, 13);
            this.lblStationName.TabIndex = 368;
            this.lblStationName.Text = "TEN TRAM";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(12, 14);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(91, 13);
            this.LabelControl1.TabIndex = 367;
            this.LabelControl1.Text = "Tin nhắn gửi từ :";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 54);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.txtMessage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMessage.Properties.Appearance.Options.UseBackColor = true;
            this.txtMessage.Properties.Appearance.Options.UseFont = true;
            this.txtMessage.Properties.MaxLength = 255;
            this.txtMessage.Properties.ReadOnly = true;
            this.txtMessage.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.Size = new System.Drawing.Size(446, 58);
            this.txtMessage.TabIndex = 374;
            this.txtMessage.TabStop = false;
            // 
            // lbl_id
            // 
            this.lbl_id.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_id.Appearance.Options.UseFont = true;
            this.lbl_id.Appearance.Options.UseTextOptions = true;
            this.lbl_id.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_id.Location = new System.Drawing.Point(391, 12);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(50, 13);
            this.lbl_id.TabIndex = 375;
            this.lbl_id.Text = "TEN TRAM";
            this.lbl_id.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(394, 115);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 376;
            this.labelControl4.Text = "ESC - Thoát";
            // 
            // FrmMessageQue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 131);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pfeZyQnoF);
            this.Controls.Add(this.lblSendDate);
            this.Controls.Add(this.lblSendTime);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.lblSenderName);
            this.Controls.Add(this.lblStationName);
            this.Controls.Add(this.LabelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmMessageQue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESC - Thoát";
            this.Load += new System.EventHandler(this.FrmMessageQue_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMessageQue_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMessageQue_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl2;
        internal LabelControl labelControl4;
        internal LabelControl lbl_id;
        internal LabelControl lblSendDate;
        internal LabelControl lblSenderName;
        internal LabelControl lblSendTime;
        internal LabelControl lblStationName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        internal LabelControl pfeZyQnoF;
        private string string_0;
        internal MemoEdit txtMessage;

        #endregion

    }
}
