using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    partial class FrmGetPercent
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
            this.Txt_Percent = new TextEdit();
            this.Txt_Percent.Properties.BeginInit();
            base.SuspendLayout();
            this.Txt_Percent.EditValue = "0";
            this.Txt_Percent.Location = new Point(12, 14);
            this.Txt_Percent.Name = "Txt_Percent";
            this.Txt_Percent.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Txt_Percent.Properties.Appearance.Options.UseFont = true;
            this.Txt_Percent.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Percent.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_Percent.Properties.DisplayFormat.FormatString = "P1";
            this.Txt_Percent.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.Txt_Percent.Properties.EditFormat.FormatString = "P1";
            this.Txt_Percent.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.Txt_Percent.Properties.Mask.EditMask = "P1";
            this.Txt_Percent.Properties.Mask.MaskType = MaskType.Numeric;
            this.Txt_Percent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Percent.Size = new Size(0xc4, 0x20);
            this.Txt_Percent.TabIndex = 0x171;
            this.Txt_Percent.EditValueChanged += new EventHandler(this.Txt_Percent_EditValueChanged);
            this.Txt_Percent.KeyDown += new KeyEventHandler(this.Txt_Percent_KeyDown);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(220, 60);
            base.Controls.Add(this.Txt_Percent);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.MaximizeBox = false;
            base.Name = "FrmGetPercent";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Chiết khấu th\x00eam";
            base.Load += new EventHandler(this.FrmGetPercent_Load);
            base.FormClosing += new FormClosingEventHandler(this.FrmGetPercent_FormClosing);
            this.Txt_Percent.Properties.EndInit();
            base.ResumeLayout(false);
        }
        //private IContainer components;
        private TextEdit Txt_Percent;


        #endregion
    }
}
