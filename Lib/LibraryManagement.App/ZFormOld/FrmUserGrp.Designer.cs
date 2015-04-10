using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmUserGrp
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
        private ComponentResourceManager manager;
        private void InitializeComponent()
        {
            this.Txt_Status = new TextEdit();
            this.LabelControl4 = new LabelControl();
            this.Txt_Description = new TextEdit();
            this.LabelControl3 = new LabelControl();
            this.Txt_Name = new TextEdit();
            this.LabelControl2 = new LabelControl();
            this.IjSwogAv6 = new TextEdit();
            this.btn_Delete = new SimpleButton();
            this.GroupBox2 = new GroupBox();
            this.btn_Exit = new SimpleButton();
            this.btn_Edit = new SimpleButton();
            this.btn_New = new SimpleButton();
            this.btn_Skip = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.btn_ReportRight = new SimpleButton();
            this.btn_MenusRight = new SimpleButton();
            this.btn_Search = new SimpleButton();
            this.Txt_Status.Properties.BeginInit();
            this.Txt_Description.Properties.BeginInit();
            this.Txt_Name.Properties.BeginInit();
            this.IjSwogAv6.Properties.BeginInit();
            base.SuspendLayout();
            this.Txt_Status.Location = new Point(0x10b, 8);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new Size(0x68, 20);
            this.Txt_Status.TabIndex = 0x89;
            this.LabelControl4.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl4.Location = new Point(0x2b, 0x3f);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new Size(40, 13);
            this.LabelControl4.TabIndex = 0x88;
            this.LabelControl4.Text = "Diễn giải";
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new Point(0x6b, 60);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Description.Properties.Appearance.Options.UseFont = true;
            this.Txt_Description.Size = new Size(0x108, 20);
            this.Txt_Description.TabIndex = 0x84;
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Location = new Point(0x2b, 0x24);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x2f, 13);
            this.LabelControl3.TabIndex = 0x87;
            this.LabelControl3.Text = "T\x00ean nh\x00f3m";
            this.Txt_Name.EnterMoveNextControl = true;
            this.Txt_Name.Location = new Point(0x6b, 0x22);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Name.Properties.Appearance.Options.UseFont = true;
            this.Txt_Name.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_Name.Size = new Size(0x108, 20);
            this.Txt_Name.TabIndex = 0x83;
            this.LabelControl2.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl2.Location = new Point(0x2b, 11);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new Size(0x2b, 13);
            this.LabelControl2.TabIndex = 0x86;
            this.LabelControl2.Text = "M\x00e3 nh\x00f3m";
            this.IjSwogAv6.EnterMoveNextControl = true;
            this.IjSwogAv6.Location = new Point(0x6b, 8);
            this.IjSwogAv6.Name = "Txt_Id";
            this.IjSwogAv6.Properties.Appearance.BackColor = Color.PapayaWhip;
            this.IjSwogAv6.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.IjSwogAv6.Properties.Appearance.Options.UseBackColor = true;
            this.IjSwogAv6.Properties.Appearance.Options.UseFont = true;
            this.IjSwogAv6.Size = new Size(0x51, 20);
            this.IjSwogAv6.TabIndex = 0x85;
            this.IjSwogAv6.EditValueChanged += new EventHandler(this.IjSwogAv6_EditValueChanged);
            this.IjSwogAv6.KeyDown += new KeyEventHandler(this.IjSwogAv6_KeyDown);
            this.btn_Delete.Anchor = AnchorStyles.Bottom;
            this.btn_Delete.Location = new Point(0x13f, 0x63);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new Size(0x4b, 0x17);
            this.btn_Delete.TabIndex = 0x1a2;
            this.btn_Delete.Text = "&X\x00f3a";
            this.btn_Delete.Click += new EventHandler(this.btn_Delete_Click);
            this.GroupBox2.Anchor = AnchorStyles.Bottom;
            this.GroupBox2.Location = new Point(-95, 0x56);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x2fa, 5);
            this.GroupBox2.TabIndex = 0x1a1;
            this.GroupBox2.TabStop = false;
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x1d5, 0x63);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 0x1a0;
            this.btn_Exit.Text = "&Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Edit.Anchor = AnchorStyles.Bottom;
            this.btn_Edit.Location = new Point(0xf4, 0x63);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new Size(0x4b, 0x17);
            this.btn_Edit.TabIndex = 0x19f;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new EventHandler(this.btn_Edit_Click);
            this.btn_New.Anchor = AnchorStyles.Bottom;
            this.btn_New.Location = new Point(0xa9, 0x63);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new Size(0x4b, 0x17);
            this.btn_New.TabIndex = 0x19e;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new EventHandler(this.btn_New_Click);
            this.btn_Skip.Anchor = AnchorStyles.Bottom;
            this.btn_Skip.Location = new Point(0x5e, 0x63);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 0x19d;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.iWyIskLbe);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Location = new Point(0x13, 0x63);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new Size(0x4b, 0x17);
            this.btn_Save.TabIndex = 0x19c;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new EventHandler(this.btn_Save_Click);
            this.btn_ReportRight.Anchor = AnchorStyles.Bottom;
            this.btn_ReportRight.Location = new Point(0x18a, 0x3a);
            this.btn_ReportRight.Name = "btn_ReportRight";
            this.btn_ReportRight.Size = new Size(0x85, 0x17);
            this.btn_ReportRight.TabIndex = 430;
            this.btn_ReportRight.Text = "Sử dụng b\x00e1o c\x00e1o";
            this.btn_ReportRight.Click += new EventHandler(this.btn_ReportRight_Click);
            this.btn_MenusRight.Anchor = AnchorStyles.Bottom;
            this.btn_MenusRight.Location = new Point(0x18a, 0x1d);
            this.btn_MenusRight.Name = "btn_MenusRight";
            this.btn_MenusRight.Size = new Size(0x85, 0x17);
            this.btn_MenusRight.TabIndex = 0x1ad;
            this.btn_MenusRight.Text = "Sử dụng menus";
            this.btn_MenusRight.Click += new EventHandler(this.btn_MenusRight_Click);
            this.btn_Search.Anchor = AnchorStyles.Bottom;
            this.btn_Search.Location = new Point(0x18a, 0x63);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new Size(0x4b, 0x17);
            this.btn_Search.TabIndex = 0x1af;
            this.btn_Search.Text = "T\x00ec&m";
            this.btn_Search.Click += new EventHandler(this.btn_Search_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x233, 0x86);
            base.Controls.Add(this.btn_Search);
            base.Controls.Add(this.btn_ReportRight);
            base.Controls.Add(this.btn_MenusRight);
            base.Controls.Add(this.btn_Delete);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Edit);
            base.Controls.Add(this.btn_New);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Save);
            base.Controls.Add(this.Txt_Status);
            base.Controls.Add(this.LabelControl4);
            base.Controls.Add(this.Txt_Description);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.Txt_Name);
            base.Controls.Add(this.LabelControl2);
            base.Controls.Add(this.IjSwogAv6);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "FrmUserGrp";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmUserGrp";
            base.Load += new EventHandler(this.FrmUserGrp_Load);
            this.Txt_Status.Properties.EndInit();
            this.Txt_Description.Properties.EndInit();
            this.Txt_Name.Properties.EndInit();
            this.IjSwogAv6.Properties.EndInit();
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
        internal GroupBox GroupBox2;
        //private IContainer components;
        internal TextEdit IjSwogAv6;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal TextEdit Txt_Description;
        internal TextEdit Txt_Name;
        internal TextEdit Txt_Status;


        #endregion

    }
}
