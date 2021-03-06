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
    partial class LibraryLocationForm
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
            this.GroupBox2 = new GroupBox();
            this.btn_Delete = new SimpleButton();
            this.btn_Exit = new SimpleButton();
            this.btn_Search = new SimpleButton();
            this.btn_Edit = new SimpleButton();
            this.btn_New = new SimpleButton();
            this.btn_Skip = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.lblStkName = new LabelControl();
            this.txtStkId = new TextEdit();
            this.LabelControl17 = new LabelControl();
            this.LabelControl3 = new LabelControl();
            this.Txt_Status = new TextEdit();
            this.txtDescription = new TextEdit();
            this.txtSymbol = new TextEdit();
            this.labelControl2 = new LabelControl();
            this.labelControl1 = new LabelControl();
            this.txtStkId.Properties.BeginInit();
            this.Txt_Status.Properties.BeginInit();
            this.txtDescription.Properties.BeginInit();
            this.txtSymbol.Properties.BeginInit();
            base.SuspendLayout();
            this.GroupBox2.Anchor = AnchorStyles.Bottom;
            this.GroupBox2.Location = new Point(-116, 0x5c);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x2fa, 5);
            this.GroupBox2.TabIndex = 0x1b4;
            this.GroupBox2.TabStop = false;
            this.btn_Delete.Anchor = AnchorStyles.Bottom;
            this.btn_Delete.Location = new Point(0x131, 0x69);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new Size(0x4b, 0x17);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "&X\x00f3a";
            this.btn_Delete.Click += new EventHandler(this.btn_Delete_Click);
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x1c7, 0x69);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Th&o\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Search.Anchor = AnchorStyles.Bottom;
            this.btn_Search.Location = new Point(380, 0x69);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new Size(0x4b, 0x17);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "T\x00ec&m";
            this.btn_Search.Click += new EventHandler(this.btn_Search_Click);
            this.btn_Edit.Anchor = AnchorStyles.Bottom;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Edit.Location = new Point(230, 0x69);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new Size(0x4b, 0x17);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new EventHandler(this.btn_Edit_Click);
            this.btn_New.Anchor = AnchorStyles.Bottom;
            this.btn_New.Location = new Point(0x9b, 0x69);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new Size(0x4b, 0x17);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new EventHandler(this.btn_New_Click);
            this.btn_Skip.Anchor = AnchorStyles.Bottom;
            this.btn_Skip.Location = new Point(80, 0x69);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 5;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.btn_Skip_Click);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Location = new Point(5, 0x69);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new Size(0x4b, 0x17);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new EventHandler(this.btn_Save_Click);
            this.lblStkName.Appearance.BackColor = Color.MediumTurquoise;
            this.lblStkName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblStkName.Appearance.BorderColor = Color.White;
            this.lblStkName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblStkName.Appearance.ForeColor = Color.Black;
            this.lblStkName.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblStkName.BorderStyle = BorderStyles.UltraFlat;
            this.lblStkName.Location = new Point(0xab, 13);
            this.lblStkName.Name = "lblStkName";
            this.lblStkName.Padding = new Padding(3, 0, 0, 0);
            this.lblStkName.Size = new Size(0x11f, 0x11);
            this.lblStkName.TabIndex = 0x1b7;
            this.txtStkId.EditValue = "";
            this.txtStkId.EnterMoveNextControl = true;
            this.txtStkId.Location = new Point(0x71, 11);
            this.txtStkId.Name = "txtStkId";
            this.txtStkId.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtStkId.Properties.Appearance.Options.UseFont = true;
            this.txtStkId.Properties.MaxLength = 5;
            this.txtStkId.Size = new Size(0x38, 20);
            this.txtStkId.TabIndex = 1;
            this.txtStkId.EditValueChanged += new EventHandler(this.txtStkId_EditValueChanged);
            this.txtStkId.KeyDown += new KeyEventHandler(this.txtStkId_KeyDown);
            this.LabelControl17.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl17.Location = new Point(0x16, 15);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new Size(0x4e, 13);
            this.LabelControl17.TabIndex = 0x1b6;
            this.LabelControl17.Text = "Tại thư viện/kho";
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Location = new Point(0xf8, 0x29);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x31, 13);
            this.LabelControl3.TabIndex = 0x1bd;
            this.LabelControl3.Text = "Trạng th\x00e1i";
            this.Txt_Status.Location = new Point(0x145, 0x25);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new Size(0x85, 20);
            this.Txt_Status.TabIndex = 0x1bc;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new Point(0x71, 0x3e);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new Size(0x159, 20);
            this.txtDescription.TabIndex = 3;
            this.txtSymbol.EnterMoveNextControl = true;
            this.txtSymbol.Location = new Point(0x71, 0x25);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Properties.Appearance.Options.UseFont = true;
            this.txtSymbol.Properties.CharacterCasing = CharacterCasing.Upper;
            this.txtSymbol.Properties.MaxLength = 4;
            this.txtSymbol.Size = new Size(100, 20);
            this.txtSymbol.TabIndex = 2;
            this.txtSymbol.ToolTip = "Nhấn F2 để t\x00ecm kiếm";
            this.txtSymbol.ToolTipIconType = ToolTipIconType.Information;
            this.txtSymbol.ToolTipTitle = "Lưu \x00fd";
            this.txtSymbol.EditValueChanged += new EventHandler(this.txtSymbol_EditValueChanged);
            this.txtSymbol.KeyDown += new KeyEventHandler(this.txtSymbol_KeyDown);
            this.labelControl2.Location = new Point(0x16, 0x42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new Size(40, 13);
            this.labelControl2.TabIndex = 0x1b9;
            this.labelControl2.Text = "Diễn giải";
            this.labelControl1.Location = new Point(0x16, 0x29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new Size(0x23, 13);
            this.labelControl1.TabIndex = 440;
            this.labelControl1.Text = "K\x00fd hiệu";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x217, 0x86);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.Txt_Status);
            base.Controls.Add(this.txtDescription);
            base.Controls.Add(this.txtSymbol);
            base.Controls.Add(this.labelControl2);
            base.Controls.Add(this.labelControl1);
            base.Controls.Add(this.lblStkName);
            base.Controls.Add(this.txtStkId);
            base.Controls.Add(this.LabelControl17);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.btn_Delete);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Search);
            base.Controls.Add(this.btn_Edit);
            base.Controls.Add(this.btn_New);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Save);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "FrmLibraryLoc";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmLibraryLoc";
            base.Load += new EventHandler(this.FrmLibraryLoc_Load);
            this.txtStkId.Properties.EndInit();
            this.Txt_Status.Properties.EndInit();
            this.txtDescription.Properties.EndInit();
            this.txtSymbol.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        internal SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal GroupBox GroupBox2;
        //private IContainer components;
        private LabelControl labelControl1;
        internal LabelControl LabelControl17;
        private LabelControl labelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl lblStkName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        internal TextEdit Txt_Status;
        private TextEdit txtDescription;
        internal TextEdit txtStkId;
        private TextEdit txtSymbol;

        #endregion

    }
}