using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmChangeSysDate
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
            this.Txt_NewDate = new TextEdit();
            this.LabelControl1 = new LabelControl();
            this.Txt_SysDate = new TextEdit();
            this.LabelControl18 = new LabelControl();
            this.btn_Skip = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.Txt_NewDate.Properties.BeginInit();
            this.Txt_SysDate.Properties.BeginInit();
            base.SuspendLayout();
            this.Txt_NewDate.EditValue = new DateTime(0x7d8, 4, 0x18, 13, 0x34, 0x2b, 0x1a5);
            this.Txt_NewDate.Location = new Point(0x93, 0x26);
            this.Txt_NewDate.Name = "Txt_NewDate";
            this.Txt_NewDate.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_NewDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_NewDate.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_NewDate.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_NewDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_NewDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_NewDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_NewDate.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_NewDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_NewDate.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_NewDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_NewDate.Size = new Size(0x57, 20);
            this.Txt_NewDate.TabIndex = 300;
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(0x17, 0x29);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x3b, 13);
            this.LabelControl1.TabIndex = 0x12e;
            this.LabelControl1.Text = "Ng\x00e0y sửa lại";
            this.Txt_SysDate.EditValue = new DateTime(0x7d8, 4, 0x18, 13, 0x34, 0x2b, 0x1a5);
            this.Txt_SysDate.EnterMoveNextControl = true;
            this.Txt_SysDate.Location = new Point(0x93, 12);
            this.Txt_SysDate.Name = "Txt_SysDate";
            this.Txt_SysDate.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_SysDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_SysDate.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_SysDate.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_SysDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_SysDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_SysDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_SysDate.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_SysDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_SysDate.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_SysDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_SysDate.Size = new Size(0x57, 20);
            this.Txt_SysDate.TabIndex = 0x12b;
            this.LabelControl18.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Location = new Point(0x17, 15);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new Size(0x47, 13);
            this.LabelControl18.TabIndex = 0x12d;
            this.LabelControl18.Text = "Ng\x00e0y hệ thống";
            this.btn_Skip.Anchor = AnchorStyles.Bottom;
            this.btn_Skip.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Skip.Location = new Point(0x93, 0x54);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 0x182;
            this.btn_Skip.Text = "ESC-Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.btn_Skip_Click);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Location = new Point(0x2f, 0x54);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new Size(0x4b, 0x17);
            this.btn_Save.TabIndex = 0x181;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new EventHandler(this.btn_Save_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Skip;
            base.ClientSize = new Size(0x10c, 0x77);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Save);
            base.Controls.Add(this.Txt_NewDate);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.Txt_SysDate);
            base.Controls.Add(this.LabelControl18);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.MaximizeBox = false;
            base.Name = "FrmChangeSysDate";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmChangeSysDate";
            base.Load += new EventHandler(this.FrmChangeSysDate_Load);
            this.Txt_NewDate.Properties.EndInit();
            this.Txt_SysDate.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private SimpleButton btn_Save;
        private SimpleButton btn_Skip;
        ////private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl18;
        internal TextEdit Txt_NewDate;
        internal TextEdit Txt_SysDate;


        #endregion
    }
}