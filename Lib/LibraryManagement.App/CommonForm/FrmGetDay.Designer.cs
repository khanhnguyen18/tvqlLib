using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmGetDay
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
            this.Txt_InDay = new TextEdit();
            this.LabelControl1 = new LabelControl();
            this.Txt_InDay.Properties.BeginInit();
            base.SuspendLayout();
            this.Txt_InDay.EditValue = new DateTime(0x7d8, 4, 0x18, 13, 0x34, 0x2b, 0x1a5);
            this.Txt_InDay.EnterMoveNextControl = true;
            this.Txt_InDay.Location = new Point(0x5e, 12);
            this.Txt_InDay.Name = "Txt_InDay";
            this.Txt_InDay.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_InDay.Properties.Appearance.Options.UseFont = true;
            this.Txt_InDay.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_InDay.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_InDay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_InDay.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_InDay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_InDay.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_InDay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_InDay.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_InDay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_InDay.Size = new Size(0x59, 20);
            this.Txt_InDay.TabIndex = 0x129;
            this.Txt_InDay.EditValueChanged += new EventHandler(this.Txt_InDay_EditValueChanged);
            this.Txt_InDay.KeyDown += new KeyEventHandler(this.Txt_InDay_KeyDown);
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(0x21, 15);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x37, 13);
            this.LabelControl1.TabIndex = 0x12a;
            this.LabelControl1.Text = "Trong ng\x00e0y";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(230, 40);
            base.Controls.Add(this.Txt_InDay);
            base.Controls.Add(this.LabelControl1);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Name = "FrmGetDay";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = " Chọn ng\x00e0y";
            base.Load += new EventHandler(this.FrmGetDay_Load);
            base.KeyDown += new KeyEventHandler(this.FrmGetDay_KeyDown);
            this.Txt_InDay.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal TextEdit Txt_InDay;

        #endregion

    }
}
