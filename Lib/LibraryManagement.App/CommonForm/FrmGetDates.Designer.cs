using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmGetDates
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
            this.Txt_ToDate = new TextEdit();
            this.LabelControl1 = new LabelControl();
            this.Txt_FrDate = new TextEdit();
            this.LabelControl18 = new LabelControl();
            this.Txt_ToDate.Properties.BeginInit();
            this.Txt_FrDate.Properties.BeginInit();
            base.SuspendLayout();
            this.Txt_ToDate.EditValue = new DateTime(0x7d8, 4, 0x18, 13, 0x34, 0x2b, 0x1a5);
            this.Txt_ToDate.Location = new Point(0xf3, 9);
            this.Txt_ToDate.Name = "Txt_ToDate";
            this.Txt_ToDate.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_ToDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_ToDate.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_ToDate.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_ToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_ToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_ToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_ToDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_ToDate.Size = new Size(0x57, 20);
            this.Txt_ToDate.TabIndex = 1;
            this.Txt_ToDate.KeyDown += new KeyEventHandler(this.Txt_ToDate_KeyDown);
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(0xb7, 12);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x2d, 13);
            this.LabelControl1.TabIndex = 0x12a;
            this.LabelControl1.Text = "đến ng\x00e0y";
            this.Txt_FrDate.EditValue = new DateTime(0x7d8, 4, 0x18, 13, 0x34, 0x2b, 0x1a5);
            this.Txt_FrDate.EnterMoveNextControl = true;
            this.Txt_FrDate.Location = new Point(0x44, 9);
            this.Txt_FrDate.Name = "Txt_FrDate";
            this.Txt_FrDate.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_FrDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_FrDate.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_FrDate.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_FrDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_FrDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_FrDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_FrDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_FrDate.Size = new Size(0x57, 20);
            this.Txt_FrDate.TabIndex = 0;
            this.LabelControl18.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Location = new Point(0x13, 12);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new Size(40, 13);
            this.LabelControl18.TabIndex = 0x129;
            this.LabelControl18.Text = "Từ ng\x00e0y";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x166, 40);
            base.Controls.Add(this.Txt_ToDate);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.Txt_FrDate);
            base.Controls.Add(this.LabelControl18);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Name = "FrmGetDates";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = " Chọn khoảng thời gian";
            base.Load += new EventHandler(this.FrmGetDates_Load);
            base.KeyDown += new KeyEventHandler(this.FrmGetDates_KeyDown);
            this.Txt_ToDate.Properties.EndInit();
            this.Txt_FrDate.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl18;
        internal TextEdit Txt_FrDate;
        internal TextEdit Txt_ToDate;

        #endregion
    }
}
