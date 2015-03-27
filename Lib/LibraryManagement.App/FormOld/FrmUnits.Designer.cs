using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Drawing;
using System;
using DevExpress.Utils;
namespace LibraryManagement.App
{
    partial class FrmUnits
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
            this.btn_Exit = new SimpleButton();
            this.btn_Search = new SimpleButton();
            this.btn_Edit = new SimpleButton();
            this.btn_New = new SimpleButton();
            this.btn_Skip = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.labelControl1 = new LabelControl();
            this.IjSwogAv6 = new LabelControl();
            this.Txt_Id = new TextEdit();
            this.Txt_Description = new TextEdit();
            this.btn_Delete = new SimpleButton();
            this.LabelControl3 = new LabelControl();
            this.Txt_Status = new TextEdit();
            this.GroupBox2 = new GroupBox();
            this.Txt_Id.Properties.BeginInit();
            this.Txt_Description.Properties.BeginInit();
            this.Txt_Status.Properties.BeginInit();
            base.SuspendLayout();
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x1c4, 0x53);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Th&o\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Search.Anchor = AnchorStyles.Bottom;
            this.btn_Search.Location = new Point(0x179, 0x53);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new Size(0x4b, 0x17);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "T\x00ec&m";
            this.btn_Search.Click += new EventHandler(this.btn_Search_Click);
            this.btn_Edit.Anchor = AnchorStyles.Bottom;
            this.btn_Edit.DialogResult = DialogResult.Cancel;
            this.btn_Edit.Location = new Point(0xe3, 0x53);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new Size(0x4b, 0x17);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new EventHandler(this.btn_Edit_Click);
            this.btn_New.Anchor = AnchorStyles.Bottom;
            this.btn_New.Location = new Point(0x98, 0x53);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new Size(0x4b, 0x17);
            this.btn_New.TabIndex = 9;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new EventHandler(this.btn_New_Click);
            this.btn_Skip.Anchor = AnchorStyles.Bottom;
            this.btn_Skip.Location = new Point(0x4d, 0x53);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 8;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.btn_Skip_Click);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Location = new Point(2, 0x53);
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
            this.IjSwogAv6.Location = new Point(0x2b, 0x2a);
            this.IjSwogAv6.Name = "labelControl2";
            this.IjSwogAv6.Size = new Size(40, 13);
            this.IjSwogAv6.TabIndex = 15;
            this.IjSwogAv6.Text = "Diễn giải";
            this.Txt_Id.EnterMoveNextControl = true;
            this.Txt_Id.Location = new Point(0x81, 12);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.Appearance.Options.UseFont = true;
            this.Txt_Id.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_Id.Properties.MaxLength = 3;
            this.Txt_Id.Size = new Size(100, 20);
            this.Txt_Id.TabIndex = 0x10;
            this.Txt_Id.ToolTip = "Nhấn F5 để t\x00ecm kiếm";
            this.Txt_Id.ToolTipIconType = ToolTipIconType.Information;
            this.Txt_Id.ToolTipTitle = "Lưu \x00fd";
            this.Txt_Id.EditValueChanged += new EventHandler(this.Txt_Id_EditValueChanged);
            this.Txt_Id.KeyDown += new KeyEventHandler(this.Txt_Id_KeyDown);
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new Point(0x81, 0x27);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new Size(0x156, 20);
            this.Txt_Description.TabIndex = 0x11;
            this.btn_Delete.Anchor = AnchorStyles.Bottom;
            this.btn_Delete.Location = new Point(0x12e, 0x53);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new Size(0x4b, 0x17);
            this.btn_Delete.TabIndex = 0x196;
            this.btn_Delete.Text = "&X\x00f3a";
            this.btn_Delete.Click += new EventHandler(this.btn_Delete_Click);
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new Point(0x108, 0x10);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x31, 13);
            this.LabelControl3.TabIndex = 0x1ab;
            this.LabelControl3.Text = "Trạng th\x00e1i";
            this.Txt_Status.Location = new Point(0x152, 13);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new Size(0x85, 20);
            this.Txt_Status.TabIndex = 0x1aa;
            this.GroupBox2.Anchor = AnchorStyles.Bottom;
            this.GroupBox2.Location = new Point(-117, 70);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x2fa, 5);
            this.GroupBox2.TabIndex = 0x1ac;
            this.GroupBox2.TabStop = false;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x210, 0x72);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.Txt_Status);
            base.Controls.Add(this.btn_Delete);
            base.Controls.Add(this.Txt_Description);
            base.Controls.Add(this.Txt_Id);
            base.Controls.Add(this.IjSwogAv6);
            base.Controls.Add(this.labelControl1);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Search);
            base.Controls.Add(this.btn_Edit);
            base.Controls.Add(this.btn_New);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Save);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.KeyPreview = true;
            base.MaximizeBox = false;
            base.Name = "FrmUnits";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmUnits";
            base.Load += new EventHandler(this.FrmUnits_Load);
            this.Txt_Id.Properties.EndInit();
            this.Txt_Description.Properties.EndInit();
            this.Txt_Status.Properties.EndInit();
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
        private LabelControl IjSwogAv6;
        private LabelControl labelControl1;
        internal LabelControl LabelControl3;

        private TextEdit Txt_Description;
        private TextEdit Txt_Id;
        internal TextEdit Txt_Status;

        #endregion
    }
}