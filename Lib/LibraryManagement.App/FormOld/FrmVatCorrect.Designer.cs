using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    partial class FrmVatCorrect
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
            this.lblMercName = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGoodsId = new DevExpress.XtraEditors.TextEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.cmbVatRate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblOldTaxRate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVatRate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMercName
            // 
            this.lblMercName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblMercName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblMercName.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblMercName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMercName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblMercName.Appearance.Options.UseBackColor = true;
            this.lblMercName.Appearance.Options.UseBorderColor = true;
            this.lblMercName.Appearance.Options.UseFont = true;
            this.lblMercName.Appearance.Options.UseForeColor = true;
            this.lblMercName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMercName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblMercName.Location = new System.Drawing.Point(42, 38);
            this.lblMercName.Name = "lblMercName";
            this.lblMercName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblMercName.Size = new System.Drawing.Size(342, 16);
            this.lblMercName.TabIndex = 378;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(42, 15);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(44, 13);
            this.LabelControl1.TabIndex = 377;
            this.LabelControl1.Text = "Mã hàng ";
            // 
            // txtGoodsId
            // 
            this.txtGoodsId.EnterMoveNextControl = true;
            this.txtGoodsId.Location = new System.Drawing.Point(109, 12);
            this.txtGoodsId.Name = "txtGoodsId";
            this.txtGoodsId.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtGoodsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsId.Properties.Appearance.Options.UseBackColor = true;
            this.txtGoodsId.Properties.Appearance.Options.UseFont = true;
            this.txtGoodsId.Properties.Mask.PlaceHolder = ' ';
            this.txtGoodsId.Properties.MaxLength = 20;
            this.txtGoodsId.Properties.ValidateOnEnterKey = true;
            this.txtGoodsId.Size = new System.Drawing.Size(123, 20);
            this.txtGoodsId.TabIndex = 376;
            this.txtGoodsId.ToolTip = "Ấn F5 để tìm kiếm";
            this.txtGoodsId.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.txtGoodsId.ToolTipTitle = "Lưu ý";
            this.txtGoodsId.EditValueChanged += new System.EventHandler(this.txtGoodsId_EditValueChanged);
            this.txtGoodsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoodsId_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(216, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 380;
            this.btnExit.Text = "ESC-Thoát";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.Location = new System.Drawing.Point(110, 145);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 23);
            this.btnConfirm.TabIndex = 379;
            this.btnConfirm.Text = "Hiệu chỉnh";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(-174, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 383;
            this.groupBox1.TabStop = false;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(42, 82);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(67, 13);
            this.labelControl19.TabIndex = 386;
            this.labelControl19.Text = "Thuế suất mới";
            // 
            // cmbVatRate
            // 
            this.cmbVatRate.EnterMoveNextControl = true;
            this.cmbVatRate.Location = new System.Drawing.Point(147, 81);
            this.cmbVatRate.Name = "cmbVatRate";
            this.cmbVatRate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVatRate.Properties.Appearance.Options.UseFont = true;
            this.cmbVatRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVatRate.Properties.Items.AddRange(new object[] {
            "10%   Thuế phải nộp đầu ra",
            " 5%    Thuế phải nộp đầu ra",
            " 0%    Không chịu thuế"});
            this.cmbVatRate.Properties.MaxLength = 3;
            this.cmbVatRate.Size = new System.Drawing.Size(237, 20);
            this.cmbVatRate.TabIndex = 385;
            // 
            // lblOldTaxRate
            // 
            this.lblOldTaxRate.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblOldTaxRate.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.lblOldTaxRate.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblOldTaxRate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldTaxRate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblOldTaxRate.Appearance.Options.UseBackColor = true;
            this.lblOldTaxRate.Appearance.Options.UseBorderColor = true;
            this.lblOldTaxRate.Appearance.Options.UseFont = true;
            this.lblOldTaxRate.Appearance.Options.UseForeColor = true;
            this.lblOldTaxRate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOldTaxRate.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblOldTaxRate.Location = new System.Drawing.Point(147, 60);
            this.lblOldTaxRate.Name = "lblOldTaxRate";
            this.lblOldTaxRate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblOldTaxRate.Size = new System.Drawing.Size(30, 16);
            this.lblOldTaxRate.TabIndex = 387;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(42, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 388;
            this.labelControl3.Text = "Thuế suất hiện thời";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(182, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 13);
            this.labelControl2.TabIndex = 389;
            this.labelControl2.Text = "%";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(42, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(291, 13);
            this.labelControl4.TabIndex = 390;
            this.labelControl4.Text = "Hiệu chỉnh lại thuế suất đầu ra của mặt hàng đã bán";
            // 
            // FrmVatCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(415, 174);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblOldTaxRate);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.cmbVatRate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblMercName);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.txtGoodsId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmVatCorrect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVatCorrect";
            this.Load += new System.EventHandler(this.FrmVatCorrect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVatRate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal SimpleButton btnConfirm;
        internal SimpleButton btnExit;
        internal ComboBoxEdit cmbVatRate;
        internal GroupBox groupBox1;
        //private IContainer components;
        private string IjSwogAv6;
        internal LabelControl LabelControl1;
        internal LabelControl labelControl19;
        internal LabelControl labelControl2;
        internal LabelControl labelControl3;
        internal LabelControl labelControl4;
        internal LabelControl lblMercName;
        internal LabelControl lblOldTaxRate;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        internal TextEdit txtGoodsId;

        #endregion

    }
}
