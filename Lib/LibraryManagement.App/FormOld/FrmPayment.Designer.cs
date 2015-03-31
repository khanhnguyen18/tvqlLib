using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmPayment
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

        private ComponentResourceManager manager;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.Txt_TotalAmt = new DevExpress.XtraEditors.TextEdit();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.Lbl_AccName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_AccountId = new DevExpress.XtraEditors.LabelControl();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TotalAmt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(19, 34);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Ghi nợ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Thanh toán 1 phần"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Thanh toán hết")});
            this.radioGroup1.Size = new System.Drawing.Size(407, 30);
            this.radioGroup1.TabIndex = 0;
            // 
            // Txt_TotalAmt
            // 
            this.Txt_TotalAmt.EnterMoveNextControl = true;
            this.Txt_TotalAmt.Location = new System.Drawing.Point(309, 12);
            this.Txt_TotalAmt.Name = "Txt_TotalAmt";
            this.Txt_TotalAmt.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_TotalAmt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalAmt.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_TotalAmt.Properties.Appearance.Options.UseFont = true;
            this.Txt_TotalAmt.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_TotalAmt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_TotalAmt.Properties.DisplayFormat.FormatString = "n0";
            this.Txt_TotalAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_TotalAmt.Properties.EditFormat.FormatString = "n0";
            this.Txt_TotalAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_TotalAmt.Properties.Mask.EditMask = "n0";
            this.Txt_TotalAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_TotalAmt.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_TotalAmt.Size = new System.Drawing.Size(117, 20);
            this.Txt_TotalAmt.TabIndex = 406;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.Location = new System.Drawing.Point(168, 82);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 23);
            this.btnConfirm.TabIndex = 416;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Lbl_AccName
            // 
            this.Lbl_AccName.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Lbl_AccName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AccName.Appearance.Options.UseBackColor = true;
            this.Lbl_AccName.Appearance.Options.UseFont = true;
            this.Lbl_AccName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_AccName.Location = new System.Drawing.Point(88, 12);
            this.Lbl_AccName.Name = "Lbl_AccName";
            this.Lbl_AccName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_AccName.Size = new System.Drawing.Size(211, 16);
            this.Lbl_AccName.TabIndex = 420;
            // 
            // Lbl_AccountId
            // 
            this.Lbl_AccountId.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Lbl_AccountId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AccountId.Appearance.Options.UseBackColor = true;
            this.Lbl_AccountId.Appearance.Options.UseFont = true;
            this.Lbl_AccountId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_AccountId.Location = new System.Drawing.Point(19, 12);
            this.Lbl_AccountId.Name = "Lbl_AccountId";
            this.Lbl_AccountId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_AccountId.Size = new System.Drawing.Size(63, 16);
            this.Lbl_AccountId.TabIndex = 421;
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 119);
            this.Controls.Add(this.Lbl_AccountId);
            this.Controls.Add(this.Lbl_AccName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.Txt_TotalAmt);
            this.Controls.Add(this.radioGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hình thức thanh toán";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TotalAmt.Properties)).EndInit();
            this.ResumeLayout(false);

        }
        internal SimpleButton btnConfirm;
        //private IContainer components;
        internal LabelControl Lbl_AccName;
        internal LabelControl Lbl_AccountId;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private RadioGroup radioGroup1;
        private Timer timer_0;
        internal TextEdit Txt_TotalAmt;
    }
}
