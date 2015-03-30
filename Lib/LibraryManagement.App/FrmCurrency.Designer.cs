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
    partial class FrmCurrency
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
            this.groupControl1 = new GroupControl();
            this.btn_Exit = new SimpleButton();
            this.btn_Search = new SimpleButton();
            this.btn_Edit = new SimpleButton();
            this.btn_New = new SimpleButton();
            this.btn_Skip = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.labelControl1 = new LabelControl();
            this.labelControl2 = new LabelControl();
            this.Txt_Id = new TextEdit();
            this.Txt_Description = new TextEdit();
            this.groupBox1 = new GroupBox();
            this.Txt_ExchangeRate = new TextEdit();
            this.LabelControl5 = new LabelControl();
            this.btn_Delete = new SimpleButton();
            this.LabelControl3 = new LabelControl();
            this.Txt_Status = new TextEdit();
            this.groupControl1.BeginInit();
            this.Txt_Id.Properties.BeginInit();
            this.Txt_Description.Properties.BeginInit();
            this.Txt_ExchangeRate.Properties.BeginInit();
            this.Txt_Status.Properties.BeginInit();
            base.SuspendLayout();
            this.groupControl1.Anchor = AnchorStyles.Bottom;
            this.groupControl1.Location = new Point(-22, 0x56);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new Size(0x31a, 2);
            this.groupControl1.TabIndex = 13;
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x1c5, 0x5e);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Th&o\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Search.Anchor = AnchorStyles.Bottom;
            this.btn_Search.Location = new Point(0x17a, 0x5e);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new Size(0x4b, 0x17);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "T\x00ec&m";
            this.btn_Search.Click += new EventHandler(this.btn_Search_Click);
            this.btn_Edit.Anchor = AnchorStyles.Bottom;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Edit.Location = new Point(0xe4, 0x5e);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new Size(0x4b, 0x17);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new EventHandler(this.btn_Edit_Click);
            this.btn_New.Anchor = AnchorStyles.Bottom;
            this.btn_New.Location = new Point(0x99, 0x5e);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new Size(0x4b, 0x17);
            this.btn_New.TabIndex = 9;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new EventHandler(this.btn_New_Click);
            this.btn_Skip.Anchor = AnchorStyles.Bottom;
            this.btn_Skip.Location = new Point(0x4e, 0x5e);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 8;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.btn_Skip_Click);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Location = new Point(3, 0x5e);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new Size(0x4b, 0x17);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new EventHandler(this.btn_Save_Click);
            this.labelControl1.Location = new Point(0x2b, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new Size(0x23, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "K\x00fd hiệu";
            this.labelControl2.Location = new Point(0x2b, 0x26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new Size(40, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Diễn giải";
            this.Txt_Id.EnterMoveNextControl = true;
            this.Txt_Id.Location = new Point(0x81, 12);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_Id.Properties.MaxLength = 3;
            this.Txt_Id.Size = new Size(100, 20);
            this.Txt_Id.TabIndex = 0x10;
            this.Txt_Id.EditValueChanged += new EventHandler(this.Txt_Id_EditValueChanged);
            this.Txt_Id.KeyDown += new KeyEventHandler(this.Txt_Id_KeyDown);
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new Point(0x81, 0x23);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new Size(0x152, 20);
            this.Txt_Description.TabIndex = 0x11;
            this.groupBox1.Anchor = AnchorStyles.Bottom;
            this.groupBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(-116, 0x53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x2fa, 5);
            this.groupBox1.TabIndex = 0x196;
            this.groupBox1.TabStop = false;
            this.Txt_ExchangeRate.EnterMoveNextControl = true;
            this.Txt_ExchangeRate.Location = new Point(0x81, 0x3a);
            this.Txt_ExchangeRate.Name = "Txt_ExchangeRate";
            this.Txt_ExchangeRate.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_ExchangeRate.Properties.Appearance.Options.UseFont = true;
            this.Txt_ExchangeRate.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_ExchangeRate.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_ExchangeRate.Properties.DisplayFormat.FormatString = "n0";
            this.Txt_ExchangeRate.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.Txt_ExchangeRate.Properties.EditFormat.FormatString = "n0";
            this.Txt_ExchangeRate.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.Txt_ExchangeRate.Properties.Mask.EditMask = "n0";
            this.Txt_ExchangeRate.Properties.Mask.MaskType = MaskType.Numeric;
            this.Txt_ExchangeRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_ExchangeRate.Size = new Size(0x87, 20);
            this.Txt_ExchangeRate.TabIndex = 0x197;
            this.LabelControl5.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new Point(0x2b, 0x3d);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new Size(0x1d, 13);
            this.LabelControl5.TabIndex = 0x198;
            this.LabelControl5.Text = "Tỷ gi\x00e1";
            this.btn_Delete.Anchor = AnchorStyles.Bottom;
            this.btn_Delete.Location = new Point(0x12f, 0x5e);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new Size(0x4b, 0x17);
            this.btn_Delete.TabIndex = 0x199;
            this.btn_Delete.Text = "&X\x00f3a";
            this.btn_Delete.Click += new EventHandler(this.btn_Delete_Click);
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new Point(0x103, 15);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x31, 13);
            this.LabelControl3.TabIndex = 0x19b;
            this.LabelControl3.Text = "Trạng th\x00e1i";
            this.Txt_Status.EnterMoveNextControl = true;
            this.Txt_Status.Location = new Point(0x157, 12);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new Size(0x7c, 20);
            this.Txt_Status.TabIndex = 410;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x213, 0x7f);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.Txt_Status);
            base.Controls.Add(this.btn_Delete);
            base.Controls.Add(this.Txt_ExchangeRate);
            base.Controls.Add(this.LabelControl5);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.Txt_Description);
            base.Controls.Add(this.Txt_Id);
            base.Controls.Add(this.labelControl2);
            base.Controls.Add(this.labelControl1);
            base.Controls.Add(this.groupControl1);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Search);
            base.Controls.Add(this.btn_Edit);
            base.Controls.Add(this.btn_New);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Save);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.Name = "FrmCurrency";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmCurrency";
            base.Load += new EventHandler(this.FrmCurrency_Load);
            this.groupControl1.EndInit();
            this.Txt_Id.Properties.EndInit();
            this.Txt_Description.Properties.EndInit();
            this.Txt_ExchangeRate.Properties.EndInit();
            this.Txt_Status.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal GroupBox groupBox1;
        private GroupControl groupControl1;
        //private IContainer components;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl5;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private TextEdit Txt_Description;
        internal TextEdit Txt_ExchangeRate;
        private TextEdit Txt_Id;
        internal TextEdit Txt_Status;

        #endregion
    }
}
