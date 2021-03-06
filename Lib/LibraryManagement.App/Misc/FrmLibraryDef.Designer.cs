using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmLibraryDef
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
            this.Txt_Name = new TextEdit();
            this.Cmb_Type = new ComboBoxEdit();
            this.Txt_Status = new TextEdit();
            this.Txt_Id = new TextEdit();
            this.LabelControl4 = new LabelControl();
            this.Txt_Description = new TextEdit();
            this.LabelControl6 = new LabelControl();
            this.LabelControl15 = new LabelControl();
            this.LabelControl3 = new LabelControl();
            this.btn_Delete = new SimpleButton();
            this.groupBox1 = new GroupBox();
            this.btn_Exit = new SimpleButton();
            this.btn_Edit = new SimpleButton();
            this.btn_New = new SimpleButton();
            this.btn_Skip = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.btn_Search = new SimpleButton();
            this.Txt_OpenDate = new TextEdit();
            this.LabelControl2 = new LabelControl();
            this.LabelControl1 = new LabelControl();
            this.Txt_Phone = new TextEdit();
            this.Txt_Address = new TextEdit();
            this.Txt_Name.Properties.BeginInit();
            this.Cmb_Type.Properties.BeginInit();
            this.Txt_Status.Properties.BeginInit();
            this.Txt_Id.Properties.BeginInit();
            this.Txt_Description.Properties.BeginInit();
            this.Txt_OpenDate.Properties.BeginInit();
            this.Txt_Phone.Properties.BeginInit();
            this.Txt_Address.Properties.BeginInit();
            base.SuspendLayout();
            this.Txt_Name.EnterMoveNextControl = true;
            this.Txt_Name.Location = new Point(0x77, 0x26);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Name.Properties.Appearance.Options.UseFont = true;
            this.Txt_Name.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_Name.Size = new Size(0xc2, 20);
            this.Txt_Name.TabIndex = 1;
            this.Cmb_Type.EnterMoveNextControl = true;
            this.Cmb_Type.Location = new Point(0x77, 0x59);
            this.Cmb_Type.Name = "Cmb_Type";
            this.Cmb_Type.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Cmb_Type.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Type.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.Cmb_Type.Properties.Items.AddRange(new object[] { "Thư viện", "Kho s\x00e1ch" });
            this.Cmb_Type.Size = new Size(0x160, 20);
            this.Cmb_Type.TabIndex = 3;
            this.Txt_Status.EnterMoveNextControl = true;
            this.Txt_Status.Location = new Point(0x15b, 12);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new Size(0x7c, 20);
            this.Txt_Status.TabIndex = 100;
            this.Txt_Id.EnterMoveNextControl = true;
            this.Txt_Id.Location = new Point(0x77, 12);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.Appearance.BackColor = Color.PapayaWhip;
            this.Txt_Id.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Id.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_Id.Properties.Appearance.Options.UseFont = true;
            this.Txt_Id.Properties.Mask.PlaceHolder = ' ';
            this.Txt_Id.Properties.MaxLength = 5;
            this.Txt_Id.Properties.ValidateOnEnterKey = true;
            this.Txt_Id.Size = new Size(0x5c, 20);
            this.Txt_Id.TabIndex = 0x63;
            this.Txt_Id.EditValueChanged += new EventHandler(this.Txt_Id_EditValueChanged);
            this.Txt_Id.KeyDown += new KeyEventHandler(this.Txt_Id_KeyDown);
            this.LabelControl4.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl4.Location = new Point(0x24, 15);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new Size(0x1c, 13);
            this.LabelControl4.TabIndex = 0x65;
            this.LabelControl4.Text = "M\x00e3 số";
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new Point(0x77, 0x3f);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Description.Properties.Appearance.Options.UseFont = true;
            this.Txt_Description.Size = new Size(0x160, 20);
            this.Txt_Description.TabIndex = 2;
            this.LabelControl6.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl6.Location = new Point(0x24, 0x5c);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new Size(0x13, 13);
            this.LabelControl6.TabIndex = 0x68;
            this.LabelControl6.Text = "Loại";
            this.LabelControl15.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl15.Location = new Point(0x24, 0x42);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new Size(40, 13);
            this.LabelControl15.TabIndex = 0x67;
            this.LabelControl15.Text = "Diễn giải";
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Location = new Point(0x24, 0x29);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x12, 13);
            this.LabelControl3.TabIndex = 0x66;
            this.LabelControl3.Text = "T\x00ean";
            this.btn_Delete.Anchor = AnchorStyles.Bottom;
            this.btn_Delete.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new Point(0x12f, 0xb9);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new Size(0x4b, 0x17);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "&X\x00f3a";
            this.btn_Delete.Click += new EventHandler(this.btn_Delete_Click);
            this.groupBox1.Anchor = AnchorStyles.Bottom;
            this.groupBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox1.Location = new Point(-118, 0xab);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x2fa, 5);
            this.groupBox1.TabIndex = 0x195;
            this.groupBox1.TabStop = false;
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x1c5, 0xb9);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "&Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Edit.Anchor = AnchorStyles.Bottom;
            this.btn_Edit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Location = new Point(0xe4, 0xb9);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new Size(0x4b, 0x17);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new EventHandler(this.btn_Edit_Click);
            this.btn_New.Anchor = AnchorStyles.Bottom;
            this.btn_New.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Location = new Point(0x99, 0xb9);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new Size(0x4b, 0x17);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new EventHandler(this.btn_New_Click);
            this.btn_Skip.Anchor = AnchorStyles.Bottom;
            this.btn_Skip.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Skip.Appearance.Options.UseFont = true;
            this.btn_Skip.Location = new Point(0x4e, 0xb9);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new Size(0x4b, 0x17);
            this.btn_Skip.TabIndex = 7;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new EventHandler(this.btn_Skip_Click);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Location = new Point(3, 0xb9);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new Size(0x4b, 0x17);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new EventHandler(this.btn_Save_Click);
            this.btn_Search.Anchor = AnchorStyles.Bottom;
            this.btn_Search.Location = new Point(0x17a, 0xb9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new Size(0x4b, 0x17);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "T\x00ec&m";
            this.btn_Search.Click += new EventHandler(this.btn_Search_Click);
            this.Txt_OpenDate.EnterMoveNextControl = true;
            this.Txt_OpenDate.Location = new Point(0x15b, 0x26);
            this.Txt_OpenDate.Name = "Txt_OpenDate";
            this.Txt_OpenDate.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_OpenDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_OpenDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_OpenDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_OpenDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_OpenDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_OpenDate.Size = new Size(0x7c, 20);
            this.Txt_OpenDate.TabIndex = 0x1af;
            this.LabelControl2.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl2.Location = new Point(0x24, 0x90);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new Size(0x3e, 13);
            this.LabelControl2.TabIndex = 0x1b3;
            this.LabelControl2.Text = "Số điện thoại";
            this.LabelControl1.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl1.Location = new Point(0x24, 0x76);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new Size(0x20, 13);
            this.LabelControl1.TabIndex = 0x1b2;
            this.LabelControl1.Text = "Địa chỉ";
            this.Txt_Phone.EnterMoveNextControl = true;
            this.Txt_Phone.Location = new Point(0x77, 0x8d);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Phone.Properties.Appearance.Options.UseFont = true;
            this.Txt_Phone.Size = new Size(0x160, 20);
            this.Txt_Phone.TabIndex = 5;
            this.Txt_Address.EnterMoveNextControl = true;
            this.Txt_Address.Location = new Point(0x77, 0x73);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_Address.Properties.Appearance.Options.UseFont = true;
            this.Txt_Address.Size = new Size(0x160, 20);
            this.Txt_Address.TabIndex = 4;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x213, 0xd8);
            base.Controls.Add(this.LabelControl2);
            base.Controls.Add(this.LabelControl1);
            base.Controls.Add(this.Txt_Phone);
            base.Controls.Add(this.Txt_Address);
            base.Controls.Add(this.Txt_OpenDate);
            base.Controls.Add(this.btn_Search);
            base.Controls.Add(this.btn_Delete);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Edit);
            base.Controls.Add(this.btn_New);
            base.Controls.Add(this.btn_Skip);
            base.Controls.Add(this.btn_Save);
            base.Controls.Add(this.Txt_Name);
            base.Controls.Add(this.Cmb_Type);
            base.Controls.Add(this.Txt_Status);
            base.Controls.Add(this.Txt_Id);
            base.Controls.Add(this.LabelControl4);
            base.Controls.Add(this.Txt_Description);
            base.Controls.Add(this.LabelControl6);
            base.Controls.Add(this.LabelControl15);
            base.Controls.Add(this.LabelControl3);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "FrmLibraryDef";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmLibraryDef";
            base.Load += new EventHandler(this.FrmLibraryDef_Load);
            this.Txt_Name.Properties.EndInit();
            this.Cmb_Type.Properties.EndInit();
            this.Txt_Status.Properties.EndInit();
            this.Txt_Id.Properties.EndInit();
            this.Txt_Description.Properties.EndInit();
            this.Txt_OpenDate.Properties.EndInit();
            this.Txt_Phone.Properties.EndInit();
            this.Txt_Address.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        internal SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal ComboBoxEdit Cmb_Type;
        internal GroupBox groupBox1;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl15;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl6;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        internal TextEdit Txt_Address;
        internal TextEdit Txt_Description;
        internal TextEdit Txt_Id;
        internal TextEdit Txt_Name;
        internal TextEdit Txt_OpenDate;
        internal TextEdit Txt_Phone;
        internal TextEdit Txt_Status;


        #endregion

    }
}