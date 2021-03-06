﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmMsgbox
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
            this.btn_Accept = new SimpleButton();
            this.btn_Skip = new SimpleButton();
            this.btn_Ok = new SimpleButton();
            this.Lbl_Info = new LabelControl();
            base.SuspendLayout();
            this.btn_Accept.Location = new Point(0x7b, 0x48);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new Size(0x4b, 0x17);
            this.btn_Accept.TabIndex = 0;
            this.btn_Accept.Text = "Đồng \x00fd";
            this.btn_Accept.Click += new EventHandler(this.btn_Accept_Click);
            this.btn_Skip.Location = new Point(0xcc, 0x48);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 1;
            this.btn_Skip.Text = "Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.btn_Skip_Click);
            this.btn_Ok.Location = new Point(0xa4, 0x48);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new Size(0x4b, 0x17);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "Tiếp tục";
            this.btn_Ok.Click += new EventHandler(this.btn_Ok_Click);
            this.Lbl_Info.Appearance.Options.UseTextOptions = true;
            this.Lbl_Info.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            this.Lbl_Info.Appearance.TextOptions.VAlignment = VertAlignment.Center;
            this.Lbl_Info.AutoSizeMode = LabelAutoSizeMode.Vertical;
            this.Lbl_Info.Location = new Point(12, 0x18);
            this.Lbl_Info.Name = "Lbl_Info";
            this.Lbl_Info.Size = new Size(0x17b, 13);
            this.Lbl_Info.TabIndex = 3;
            this.Lbl_Info.Text = "labelControl1";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x193, 100);
            base.Controls.Add(this.Lbl_Info);
            base.Controls.Add(this.btn_Ok);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Accept);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.Name = "FrmMsgbox";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmMsgbox";
            base.TopMost = true;
            base.Load += new EventHandler(this.FrmMsgbox_Load);
            base.ResumeLayout(false);
        }
        public SimpleButton btn_Accept;
        public SimpleButton btn_Ok;
        public SimpleButton btn_Skip;
        //private IContainer components;
        public LabelControl Lbl_Info;
        public int ret;

        #endregion
    }
}
