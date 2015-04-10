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
    partial class FrmCreateTran
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
            this.labelControl11 = new LabelControl();
            this.txtDescription = new TextEdit();
            this.Lbl_PersonCap = new LabelControl();
            this.txtId = new TextEdit();
            this.btn_Delete = new SimpleButton();
            this.btn_Exit = new SimpleButton();
            this.btn_Search = new SimpleButton();
            this.btn_Edit = new SimpleButton();
            this.btn_New = new SimpleButton();
            this.btn_Skip = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.groupBox1 = new GroupBox();
            this.cmbTranType = new ComboBoxEdit();
            this.labelControl1 = new LabelControl();
            this.LabelControl3 = new LabelControl();
            this.Txt_Status = new TextEdit();
            this.txtDescription.Properties.BeginInit();
            this.txtId.Properties.BeginInit();
            this.cmbTranType.Properties.BeginInit();
            this.Txt_Status.Properties.BeginInit();
            base.SuspendLayout();
            this.labelControl11.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new Point(0x27, 0x2a);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new Size(0x40, 13);
            this.labelControl11.TabIndex = 0x1d2;
            this.labelControl11.Text = "Loại giao dịch";
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new Point(130, 0x3e);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Size = new Size(0x141, 20);
            this.txtDescription.TabIndex = 3;
            this.Lbl_PersonCap.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_PersonCap.Appearance.Options.UseFont = true;
            this.Lbl_PersonCap.Location = new Point(0x27, 15);
            this.Lbl_PersonCap.Name = "Lbl_PersonCap";
            this.Lbl_PersonCap.Size = new Size(0x3b, 13);
            this.Lbl_PersonCap.TabIndex = 0x1d1;
            this.Lbl_PersonCap.Text = "M\x00e3 giao dịch";
            this.txtId.EnterMoveNextControl = true;
            this.txtId.Location = new Point(130, 12);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.BackColor = Color.PapayaWhip;
            this.txtId.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtId.Properties.Appearance.Options.UseBackColor = true;
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Properties.MaxLength = 2;
            this.txtId.Size = new Size(40, 20);
            this.txtId.TabIndex = 1;
            this.txtId.EditValueChanged += new EventHandler(this.txtId_EditValueChanged);
            this.txtId.KeyDown += new KeyEventHandler(this.txtId_KeyDown);
            this.btn_Delete.Anchor = AnchorStyles.Bottom;
            this.btn_Delete.Location = new Point(300, 0x6c);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new Size(0x4b, 0x17);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "&X\x00f3a";
            this.btn_Delete.Click += new EventHandler(this.btn_Delete_Click);
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(450, 0x6c);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "&Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Search.Anchor = AnchorStyles.Bottom;
            this.btn_Search.Location = new Point(0x177, 0x6c);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new Size(0x4b, 0x17);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "T\x00ec&m";
            this.btn_Search.Click += new EventHandler(this.btn_Search_Click);
            this.btn_Edit.Anchor = AnchorStyles.Bottom;
            this.btn_Edit.Location = new Point(0xe1, 0x6c);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new Size(0x4b, 0x17);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new EventHandler(this.btn_Edit_Click);
            this.btn_New.Anchor = AnchorStyles.Bottom;
            this.btn_New.Location = new Point(150, 0x6c);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new Size(0x4b, 0x17);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new EventHandler(this.btn_New_Click);
            this.btn_Skip.Anchor = AnchorStyles.Bottom;
            this.btn_Skip.Location = new Point(0x4b, 0x6c);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 5;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.btn_Skip_Click);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Location = new Point(0, 0x6c);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new Size(0x4b, 0x17);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new EventHandler(this.btn_Save_Click);
            this.groupBox1.Anchor = AnchorStyles.Bottom;
            this.groupBox1.Location = new Point(-119, 0x5f);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x2fa, 5);
            this.groupBox1.TabIndex = 0x1da;
            this.groupBox1.TabStop = false;
            this.cmbTranType.EnterMoveNextControl = true;
            this.cmbTranType.Location = new Point(130, 0x25);
            this.cmbTranType.Name = "cmbTranType";
            this.cmbTranType.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.cmbTranType.Properties.Items.AddRange(new object[] { "1. Giao dịch một nợ một c\x00f3", "2. Giao dịch một nợ nhiều c\x00f3", "3. Giao dịch một c\x00f3 nhiều nợ", "4. Phiếu thu/chi" });
            this.cmbTranType.Size = new Size(0x141, 20);
            this.cmbTranType.TabIndex = 2;
            this.labelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new Point(0x27, 0x41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new Size(40, 13);
            this.labelControl1.TabIndex = 0x1dc;
            this.labelControl1.Text = "Diễn giải";
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new Point(0xf4, 15);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x31, 13);
            this.LabelControl3.TabIndex = 0x1de;
            this.LabelControl3.Text = "Trạng th\x00e1i";
            this.Txt_Status.Location = new Point(0x13e, 12);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new Size(0x85, 20);
            this.Txt_Status.TabIndex = 0x1dd;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x20d, 0x8a);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.Txt_Status);
            base.Controls.Add(this.labelControl1);
            base.Controls.Add(this.cmbTranType);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btn_Delete);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Search);
            base.Controls.Add(this.btn_Edit);
            base.Controls.Add(this.btn_New);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Save);
            base.Controls.Add(this.labelControl11);
            base.Controls.Add(this.txtDescription);
            base.Controls.Add(this.Lbl_PersonCap);
            base.Controls.Add(this.txtId);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.Name = "FrmCreateTran";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmCreateTran";
            base.Load += new EventHandler(this.FrmCreateTran_Load);
            this.txtDescription.Properties.EndInit();
            this.txtId.Properties.EndInit();
            this.cmbTranType.Properties.EndInit();
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
        private ComboBoxEdit cmbTranType;
        internal GroupBox groupBox1;
        //private IContainer components;
        private string kCnalMegv;
        internal LabelControl labelControl1;
        internal LabelControl labelControl11;
        internal LabelControl LabelControl3;
        internal LabelControl Lbl_PersonCap;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        internal TextEdit Txt_Status;
        internal TextEdit txtDescription;
        internal TextEdit txtId;

        #endregion

    }
}
