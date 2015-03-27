using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
namespace LibraryManagement.App
{
    partial class FrmGetAmount
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
            this.Txt_Amount = new TextEdit();
            this.Txt_Amount.Properties.BeginInit();
            base.SuspendLayout();
            this.Txt_Amount.EditValue = "0";
            this.Txt_Amount.Location = new Point(12, 14);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Txt_Amount.Properties.Appearance.Options.UseFont = true;
            this.Txt_Amount.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Amount.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_Amount.Properties.DisplayFormat.FormatString = "n0";
            this.Txt_Amount.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.Txt_Amount.Properties.EditFormat.FormatString = "n0";
            this.Txt_Amount.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.Txt_Amount.Properties.Mask.EditMask = "n0";
            this.Txt_Amount.Properties.Mask.MaskType = MaskType.Numeric;
            this.Txt_Amount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Amount.Size = new Size(0xc4, 0x20);
            this.Txt_Amount.TabIndex = 0x171;
            this.Txt_Amount.KeyDown += new KeyEventHandler(this.Txt_Amount_KeyDown);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(220, 0x35);
            base.Controls.Add(this.Txt_Amount);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.MaximizeBox = false;
            base.Name = "FrmGetAmount";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lấy gi\x00e1 trị";
            base.Load += new EventHandler(this.FrmGetAmount_Load);
            this.Txt_Amount.Properties.EndInit();
            base.ResumeLayout(false);

        }

        private TextEdit Txt_Amount;

        #endregion

    }
}