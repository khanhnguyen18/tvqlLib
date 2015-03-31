using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmMercDisc
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
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_DiscPercent = new DevExpress.XtraEditors.TextEdit();
            this.Txt_FrDate = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ToDate = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Confirm = new DevExpress.XtraEditors.SimpleButton();
            this.IipWvDcZu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_GoodsId = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_MercName = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_RtPrice = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DiscPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FrDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RtPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl18
            // 
            this.LabelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Location = new System.Drawing.Point(235, 112);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(40, 13);
            this.LabelControl18.TabIndex = 380;
            this.LabelControl18.Text = "Giảm giá";
            // 
            // Txt_DiscPercent
            // 
            this.Txt_DiscPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Txt_DiscPercent.EnterMoveNextControl = true;
            this.Txt_DiscPercent.Location = new System.Drawing.Point(284, 109);
            this.Txt_DiscPercent.Name = "Txt_DiscPercent";
            this.Txt_DiscPercent.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DiscPercent.Properties.Appearance.Options.UseFont = true;
            this.Txt_DiscPercent.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_DiscPercent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_DiscPercent.Properties.DisplayFormat.FormatString = "P1";
            this.Txt_DiscPercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_DiscPercent.Properties.EditFormat.FormatString = "P1";
            this.Txt_DiscPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_DiscPercent.Properties.Mask.EditMask = "P1";
            this.Txt_DiscPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_DiscPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_DiscPercent.Size = new System.Drawing.Size(61, 20);
            this.Txt_DiscPercent.TabIndex = 377;
            // 
            // Txt_FrDate
            // 
            this.Txt_FrDate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.Txt_FrDate.EnterMoveNextControl = true;
            this.Txt_FrDate.Location = new System.Drawing.Point(110, 83);
            this.Txt_FrDate.Name = "Txt_FrDate";
            this.Txt_FrDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FrDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_FrDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_FrDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_FrDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Txt_FrDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_FrDate.Size = new System.Drawing.Size(88, 20);
            this.Txt_FrDate.TabIndex = 375;
            // 
            // LabelControl17
            // 
            this.LabelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl17.Appearance.Options.UseFont = true;
            this.LabelControl17.Location = new System.Drawing.Point(26, 86);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(40, 13);
            this.LabelControl17.TabIndex = 379;
            this.LabelControl17.Text = "Từ ngày";
            // 
            // Txt_ToDate
            // 
            this.Txt_ToDate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.Txt_ToDate.EnterMoveNextControl = true;
            this.Txt_ToDate.Location = new System.Drawing.Point(110, 109);
            this.Txt_ToDate.Name = "Txt_ToDate";
            this.Txt_ToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ToDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_ToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_ToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_ToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Txt_ToDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_ToDate.Size = new System.Drawing.Size(88, 20);
            this.Txt_ToDate.TabIndex = 376;
            // 
            // LabelControl16
            // 
            this.LabelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl16.Appearance.Options.UseFont = true;
            this.LabelControl16.Location = new System.Drawing.Point(26, 112);
            this.LabelControl16.Name = "LabelControl16";
            this.LabelControl16.Size = new System.Drawing.Size(47, 13);
            this.LabelControl16.TabIndex = 378;
            this.LabelControl16.Text = "Đến ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(-194, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 5);
            this.groupBox2.TabIndex = 413;
            this.groupBox2.TabStop = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Confirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Confirm.Location = new System.Drawing.Point(100, 149);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(80, 23);
            this.btn_Confirm.TabIndex = 411;
            this.btn_Confirm.Text = "Thực hiện";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // IipWvDcZu
            // 
            this.IipWvDcZu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IipWvDcZu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IipWvDcZu.Location = new System.Drawing.Point(200, 149);
            this.IipWvDcZu.Name = "IipWvDcZu";
            this.IipWvDcZu.Size = new System.Drawing.Size(75, 23);
            this.IipWvDcZu.TabIndex = 412;
            this.IipWvDcZu.Text = "ESC-Thoát";
            this.IipWvDcZu.Click += new System.EventHandler(this.IipWvDcZu_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(21, 10);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 416;
            this.labelControl6.Text = "Mã hàng";
            // 
            // Lbl_GoodsId
            // 
            this.Lbl_GoodsId.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Lbl_GoodsId.Appearance.BackColor2 = System.Drawing.Color.Yellow;
            this.Lbl_GoodsId.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_GoodsId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GoodsId.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_GoodsId.Appearance.Options.UseBackColor = true;
            this.Lbl_GoodsId.Appearance.Options.UseBorderColor = true;
            this.Lbl_GoodsId.Appearance.Options.UseFont = true;
            this.Lbl_GoodsId.Appearance.Options.UseForeColor = true;
            this.Lbl_GoodsId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_GoodsId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_GoodsId.Location = new System.Drawing.Point(110, 8);
            this.Lbl_GoodsId.Name = "Lbl_GoodsId";
            this.Lbl_GoodsId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_GoodsId.Size = new System.Drawing.Size(70, 17);
            this.Lbl_GoodsId.TabIndex = 417;
            // 
            // LabelControl15
            // 
            this.LabelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl15.Appearance.Options.UseFont = true;
            this.LabelControl15.Location = new System.Drawing.Point(21, 31);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(66, 13);
            this.LabelControl15.TabIndex = 414;
            this.LabelControl15.Text = "Tên hàng hóa";
            // 
            // Lbl_MercName
            // 
            this.Lbl_MercName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_MercName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_MercName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_MercName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MercName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_MercName.Appearance.Options.UseBackColor = true;
            this.Lbl_MercName.Appearance.Options.UseBorderColor = true;
            this.Lbl_MercName.Appearance.Options.UseFont = true;
            this.Lbl_MercName.Appearance.Options.UseForeColor = true;
            this.Lbl_MercName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_MercName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_MercName.Location = new System.Drawing.Point(110, 29);
            this.Lbl_MercName.Name = "Lbl_MercName";
            this.Lbl_MercName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_MercName.Size = new System.Drawing.Size(255, 17);
            this.Lbl_MercName.TabIndex = 415;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-187, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 418;
            this.groupBox1.TabStop = false;
            // 
            // Txt_RtPrice
            // 
            this.Txt_RtPrice.EditValue = "0";
            this.Txt_RtPrice.EnterMoveNextControl = true;
            this.Txt_RtPrice.Location = new System.Drawing.Point(110, 52);
            this.Txt_RtPrice.Name = "Txt_RtPrice";
            this.Txt_RtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RtPrice.Properties.Appearance.Options.UseFont = true;
            this.Txt_RtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_RtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_RtPrice.Properties.DisplayFormat.FormatString = "n0";
            this.Txt_RtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_RtPrice.Properties.EditFormat.FormatString = "n0";
            this.Txt_RtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_RtPrice.Properties.Mask.EditMask = "n0";
            this.Txt_RtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_RtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_RtPrice.Size = new System.Drawing.Size(82, 20);
            this.Txt_RtPrice.TabIndex = 419;
            // 
            // LabelControl22
            // 
            this.LabelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new System.Drawing.Point(21, 55);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(47, 13);
            this.LabelControl22.TabIndex = 420;
            this.LabelControl22.Text = "Giá bán lẻ";
            // 
            // FrmMercDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.IipWvDcZu;
            this.ClientSize = new System.Drawing.Size(389, 184);
            this.Controls.Add(this.Txt_RtPrice);
            this.Controls.Add(this.LabelControl22);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Lbl_GoodsId);
            this.Controls.Add(this.LabelControl15);
            this.Controls.Add(this.Lbl_MercName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.IipWvDcZu);
            this.Controls.Add(this.LabelControl18);
            this.Controls.Add(this.Txt_DiscPercent);
            this.Controls.Add(this.Txt_FrDate);
            this.Controls.Add(this.LabelControl17);
            this.Controls.Add(this.Txt_ToDate);
            this.Controls.Add(this.LabelControl16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMercDisc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMercDisc";
            this.Load += new System.EventHandler(this.FrmMercDisc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DiscPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FrDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RtPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Confirm;
        internal GroupBox groupBox1;
        internal GroupBox groupBox2;
        //private IContainer components;
        private SimpleButton IipWvDcZu;
        internal LabelControl LabelControl15;
        internal LabelControl LabelControl16;
        internal LabelControl LabelControl17;
        internal LabelControl LabelControl18;
        internal LabelControl LabelControl22;
        internal LabelControl labelControl6;
        internal LabelControl Lbl_GoodsId;
        internal LabelControl Lbl_MercName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        internal TextEdit Txt_DiscPercent;
        internal TextEdit Txt_FrDate;
        internal TextEdit Txt_RtPrice;
        internal TextEdit Txt_ToDate;


        #endregion

    }
}
