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
    partial class FrmUser
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
            this.btn_Exit = new SimpleButton();
            this.btn_Edit = new SimpleButton();
            this.btn_New = new SimpleButton();
            this.btn_Skip = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.btn_Delete = new SimpleButton();
            this.LabelControl7 = new LabelControl();
            this.Txt_Password1 = new TextEdit();
            this.LabelControl6 = new LabelControl();
            this.Txt_Password = new TextEdit();
            this.LabelControl5 = new LabelControl();
            this.Cmb_Group = new ComboBoxEdit();
            this.LabelControl2 = new LabelControl();
            this.LabelControl3 = new LabelControl();
            this.LabelControl12 = new LabelControl();
            this.LabelControl1 = new LabelControl();
            this.Txt_FullName = new TextEdit();
            this.Txt_Status = new TextEdit();
            this.Txt_ShortName = new TextEdit();
            this.Txt_Id = new TextEdit();
            this.btn_ReportRight = new SimpleButton();
            this.btn_MenusRight = new SimpleButton();
            this.btn_Search = new SimpleButton();
            this.Txt_Password1.Properties.BeginInit();
            this.Txt_Password.Properties.BeginInit();
            this.Cmb_Group.Properties.BeginInit();
            this.Txt_FullName.Properties.BeginInit();
            this.Txt_Status.Properties.BeginInit();
            this.Txt_ShortName.Properties.BeginInit();
            this.Txt_Id.Properties.BeginInit();
            base.SuspendLayout();
            this.GroupBox2.Anchor = AnchorStyles.Bottom;
            this.GroupBox2.Location = new Point(-105, 180);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x2fa, 5);
            this.GroupBox2.TabIndex = 410;
            this.GroupBox2.TabStop = false;
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x1db, 0xc1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 0x199;
            this.btn_Exit.Text = "&Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Edit.Anchor = AnchorStyles.Bottom;
            this.btn_Edit.Location = new Point(0xf4, 0xc1);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new Size(0x4b, 0x17);
            this.btn_Edit.TabIndex = 0x197;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new EventHandler(this.btn_Edit_Click);
            this.btn_New.Anchor = AnchorStyles.Bottom;
            this.btn_New.Location = new Point(0xa7, 0xc1);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new Size(0x4b, 0x17);
            this.btn_New.TabIndex = 0x196;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new EventHandler(this.btn_New_Click);
            this.btn_Skip.Anchor = AnchorStyles.Bottom;
            this.btn_Skip.Location = new Point(90, 0xc1);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 0x195;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.btn_Skip_Click);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Location = new Point(13, 0xc1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new Size(0x4b, 0x17);
            this.btn_Save.TabIndex = 0x194;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new EventHandler(this.btn_Save_Click);
            this.btn_Delete.Anchor = AnchorStyles.Bottom;
            this.btn_Delete.Location = new Point(0x141, 0xc1);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new Size(0x4b, 0x17);
            this.btn_Delete.TabIndex = 0x19b;
            this.btn_Delete.Text = "&X\x00f3a";
            this.btn_Delete.Click += new EventHandler(this.btn_Delete_Click);
            this.LabelControl7.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl7.Appearance.Options.UseFont = true;
            this.LabelControl7.Location = new Point(0x19, 0x99);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new Size(0x37, 13);
            this.LabelControl7.TabIndex = 0x1a9;
            this.LabelControl7.Text = "Nhập lại MK";
            this.Txt_Password1.EnterMoveNextControl = true;
            this.Txt_Password1.Location = new Point(0x67, 0x93);
            this.Txt_Password1.Name = "Txt_Password1";
            this.Txt_Password1.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Password1.Properties.Appearance.Options.UseFont = true;
            this.Txt_Password1.Properties.AppearanceDisabled.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Txt_Password1.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_Password1.Properties.PasswordChar = '*';
            this.Txt_Password1.Size = new Size(0x119, 20);
            this.Txt_Password1.TabIndex = 0x1a0;
            this.LabelControl6.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl6.Appearance.Options.UseFont = true;
            this.LabelControl6.Location = new Point(0x19, 0x7b);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new Size(0x2c, 13);
            this.LabelControl6.TabIndex = 0x1a8;
            this.LabelControl6.Text = "Mật khẩu";
            this.Txt_Password.EnterMoveNextControl = true;
            this.Txt_Password.Location = new Point(0x67, 120);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Password.Properties.Appearance.Options.UseFont = true;
            this.Txt_Password.Properties.AppearanceDisabled.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Txt_Password.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_Password.Properties.PasswordChar = '*';
            this.Txt_Password.Size = new Size(0x119, 20);
            this.Txt_Password.TabIndex = 0x19f;
            this.LabelControl5.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new Point(0x19, 0x60);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new Size(0x1b, 13);
            this.LabelControl5.TabIndex = 0x1a7;
            this.LabelControl5.Text = "Nh\x00f3m";
            this.Cmb_Group.EnterMoveNextControl = true;
            this.Cmb_Group.Location = new Point(0x67, 0x5d);
            this.Cmb_Group.Name = "Cmb_Group";
            this.Cmb_Group.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Cmb_Group.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Group.Properties.AppearanceDisabled.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Cmb_Group.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Cmb_Group.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.Cmb_Group.Size = new Size(0x1b7, 20);
            this.Cmb_Group.TabIndex = 0x19e;
            this.Cmb_Group.SelectedIndexChanged += new EventHandler(this.Cmb_Group_SelectedIndexChanged);
            this.LabelControl2.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new Point(0x19, 0x45);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new Size(0x36, 13);
            this.LabelControl2.TabIndex = 0x1a6;
            this.LabelControl2.Text = "T\x00ean đầy đủ";
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new Point(0x14f, 15);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x31, 13);
            this.LabelControl3.TabIndex = 0x1a5;
            this.LabelControl3.Text = "Trạng th\x00e1i";
            this.LabelControl12.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl12.Appearance.Options.UseFont = true;
            this.LabelControl12.Location = new Point(0x19, 0x2a);
            this.LabelControl12.Name = "LabelControl12";
            this.LabelControl12.Size = new Size(60, 13);
            this.LabelControl12.TabIndex = 420;
            this.LabelControl12.Text = "T\x00ean sử dụng";
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new Point(0x19, 15);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x1c, 13);
            this.LabelControl1.TabIndex = 0x1a3;
            this.LabelControl1.Text = "M\x00e3 số";
            this.Txt_FullName.EnterMoveNextControl = true;
            this.Txt_FullName.Location = new Point(0x67, 0x42);
            this.Txt_FullName.Name = "Txt_FullName";
            this.Txt_FullName.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_FullName.Properties.Appearance.Options.UseFont = true;
            this.Txt_FullName.Properties.AppearanceDisabled.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Txt_FullName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_FullName.Size = new Size(0x1b7, 20);
            this.Txt_FullName.TabIndex = 0x19d;
            this.Txt_Status.Location = new Point(0x199, 12);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new Size(0x85, 20);
            this.Txt_Status.TabIndex = 0x1a2;
            this.Txt_ShortName.EnterMoveNextControl = true;
            this.Txt_ShortName.Location = new Point(0x67, 0x27);
            this.Txt_ShortName.Name = "Txt_ShortName";
            this.Txt_ShortName.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_ShortName.Properties.Appearance.Options.UseFont = true;
            this.Txt_ShortName.Properties.AppearanceDisabled.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Txt_ShortName.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_ShortName.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_ShortName.Size = new Size(0x1b7, 20);
            this.Txt_ShortName.TabIndex = 0x19c;
            this.Txt_Id.EnterMoveNextControl = true;
            this.Txt_Id.Location = new Point(0x67, 12);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.Appearance.BackColor = Color.PapayaWhip;
            this.Txt_Id.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Id.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_Id.Properties.Appearance.Options.UseFont = true;
            this.Txt_Id.Properties.AppearanceDisabled.BackColor = Color.PapayaWhip;
            this.Txt_Id.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.Txt_Id.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_Id.Size = new Size(0x5d, 20);
            this.Txt_Id.TabIndex = 0x1a1;
            this.Txt_Id.EditValueChanged += new EventHandler(this.Txt_Id_EditValueChanged);
            this.Txt_Id.KeyDown += new KeyEventHandler(this.Txt_Id_KeyDown);
            this.btn_ReportRight.Anchor = AnchorStyles.Bottom;
            this.btn_ReportRight.Location = new Point(0x199, 0x91);
            this.btn_ReportRight.Name = "btn_ReportRight";
            this.btn_ReportRight.Size = new Size(0x85, 0x17);
            this.btn_ReportRight.TabIndex = 0x1ac;
            this.btn_ReportRight.Text = "Sử dụng b\x00e1o c\x00e1o";
            this.btn_ReportRight.Click += new EventHandler(this.btn_ReportRight_Click);
            this.btn_MenusRight.Anchor = AnchorStyles.Bottom;
            this.btn_MenusRight.Location = new Point(0x199, 0x76);
            this.btn_MenusRight.Name = "btn_MenusRight";
            this.btn_MenusRight.Size = new Size(0x85, 0x17);
            this.btn_MenusRight.TabIndex = 0x1ab;
            this.btn_MenusRight.Text = "Sử dụng menus";
            this.btn_MenusRight.Click += new EventHandler(this.btn_MenusRight_Click);
            this.btn_Search.Anchor = AnchorStyles.Bottom;
            this.btn_Search.Location = new Point(0x18e, 0xc1);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new Size(0x4b, 0x17);
            this.btn_Search.TabIndex = 0x1ad;
            this.btn_Search.Text = "T\x00ec&m";
            this.btn_Search.Click += new EventHandler(this.btn_Search_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x233, 0xe0);
            base.Controls.Add(this.btn_Search);
            base.Controls.Add(this.btn_ReportRight);
            base.Controls.Add(this.btn_MenusRight);
            base.Controls.Add(this.LabelControl7);
            base.Controls.Add(this.Txt_Password1);
            base.Controls.Add(this.LabelControl6);
            base.Controls.Add(this.Txt_Password);
            base.Controls.Add(this.LabelControl5);
            base.Controls.Add(this.Cmb_Group);
            base.Controls.Add(this.LabelControl2);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.LabelControl12);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.Txt_FullName);
            base.Controls.Add(this.Txt_Status);
            base.Controls.Add(this.Txt_ShortName);
            base.Controls.Add(this.Txt_Id);
            base.Controls.Add(this.btn_Delete);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Edit);
            base.Controls.Add(this.btn_New);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Save);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "FrmUser";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmUser";
            base.Load += new EventHandler(this.FrmUser_Load);
            this.Txt_Password1.Properties.EndInit();
            this.Txt_Password.Properties.EndInit();
            this.Cmb_Group.Properties.EndInit();
            this.Txt_FullName.Properties.EndInit();
            this.Txt_Status.Properties.EndInit();
            this.Txt_ShortName.Properties.EndInit();
            this.Txt_Id.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        internal SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_MenusRight;
        private SimpleButton btn_New;
        private SimpleButton btn_ReportRight;
        private SimpleButton btn_Save;
        internal SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal ComboBoxEdit Cmb_Group;
        internal GroupBox GroupBox2;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl12;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl5;
        internal LabelControl LabelControl6;
        internal LabelControl LabelControl7;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        internal TextEdit Txt_FullName;
        internal TextEdit Txt_Id;
        internal TextEdit Txt_Password;
        internal TextEdit Txt_Password1;
        internal TextEdit Txt_ShortName;
        internal TextEdit Txt_Status;

        #endregion

    }
}
