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
    partial class FrmStore
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
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.IipWvDcZu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Txt_Status = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Description = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_OpenDate = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Address = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IipWvDcZu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OpenDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Name
            // 
            this.Txt_Name.EnterMoveNextControl = true;
            this.Txt_Name.Location = new System.Drawing.Point(119, 38);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.Properties.Appearance.Options.UseFont = true;
            this.Txt_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Name.Size = new System.Drawing.Size(194, 20);
            this.Txt_Name.TabIndex = 1;
            // 
            // IipWvDcZu
            // 
            this.IipWvDcZu.EnterMoveNextControl = true;
            this.IipWvDcZu.Location = new System.Drawing.Point(119, 89);
            this.IipWvDcZu.Name = "IipWvDcZu";
            this.IipWvDcZu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IipWvDcZu.Properties.Appearance.Options.UseFont = true;
            this.IipWvDcZu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IipWvDcZu.Properties.Items.AddRange(new object[] {
            "Cửa hàng bán lẻ",
            "Kho hàng"});
            this.IipWvDcZu.Size = new System.Drawing.Size(352, 20);
            this.IipWvDcZu.TabIndex = 3;
            // 
            // Txt_Status
            // 
            this.Txt_Status.EnterMoveNextControl = true;
            this.Txt_Status.Location = new System.Drawing.Point(347, 12);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new System.Drawing.Size(124, 20);
            this.Txt_Status.TabIndex = 100;
            // 
            // Txt_Id
            // 
            this.Txt_Id.EnterMoveNextControl = true;
            this.Txt_Id.Location = new System.Drawing.Point(119, 12);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_Id.Properties.Appearance.Options.UseFont = true;
            this.Txt_Id.Properties.Mask.PlaceHolder = ' ';
            this.Txt_Id.Properties.MaxLength = 5;
            this.Txt_Id.Properties.ValidateOnEnterKey = true;
            this.Txt_Id.Size = new System.Drawing.Size(92, 20);
            this.Txt_Id.TabIndex = 99;
            this.Txt_Id.EditValueChanged += new System.EventHandler(this.Txt_Id_EditValueChanged);
            this.Txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Id_KeyDown);
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(36, 15);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(28, 13);
            this.LabelControl4.TabIndex = 101;
            this.LabelControl4.Text = "Mã số";
            // 
            // Txt_Description
            // 
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new System.Drawing.Point(119, 63);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Description.Properties.Appearance.Options.UseFont = true;
            this.Txt_Description.Size = new System.Drawing.Size(352, 20);
            this.Txt_Description.TabIndex = 2;
            // 
            // LabelControl6
            // 
            this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl6.Appearance.Options.UseFont = true;
            this.LabelControl6.Location = new System.Drawing.Point(36, 92);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(19, 13);
            this.LabelControl6.TabIndex = 104;
            this.LabelControl6.Text = "Loại";
            // 
            // LabelControl15
            // 
            this.LabelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl15.Appearance.Options.UseFont = true;
            this.LabelControl15.Location = new System.Drawing.Point(36, 66);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(40, 13);
            this.LabelControl15.TabIndex = 103;
            this.LabelControl15.Text = "Diễn giải";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(36, 41);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(18, 13);
            this.LabelControl3.TabIndex = 102;
            this.LabelControl3.Text = "Tên";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Location = new System.Drawing.Point(303, 185);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-118, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 405;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(453, 185);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Appearance.Options.UseFont = true;
            this.btn_Edit.Location = new System.Drawing.Point(228, 185);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Location = new System.Drawing.Point(153, 185);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Skip.Appearance.Options.UseFont = true;
            this.btn_Skip.Location = new System.Drawing.Point(78, 185);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 7;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Location = new System.Drawing.Point(3, 185);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(378, 185);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Txt_OpenDate
            // 
            this.Txt_OpenDate.EnterMoveNextControl = true;
            this.Txt_OpenDate.Location = new System.Drawing.Point(347, 38);
            this.Txt_OpenDate.Name = "Txt_OpenDate";
            this.Txt_OpenDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OpenDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_OpenDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_OpenDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_OpenDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Txt_OpenDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_OpenDate.Size = new System.Drawing.Size(124, 20);
            this.Txt_OpenDate.TabIndex = 431;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(36, 144);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(62, 13);
            this.LabelControl2.TabIndex = 435;
            this.LabelControl2.Text = "Số điện thoại";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(36, 118);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(32, 13);
            this.LabelControl1.TabIndex = 434;
            this.LabelControl1.Text = "Địa chỉ";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.EnterMoveNextControl = true;
            this.Txt_Phone.Location = new System.Drawing.Point(119, 141);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Phone.Properties.Appearance.Options.UseFont = true;
            this.Txt_Phone.Size = new System.Drawing.Size(352, 20);
            this.Txt_Phone.TabIndex = 5;
            // 
            // Txt_Address
            // 
            this.Txt_Address.EnterMoveNextControl = true;
            this.Txt_Address.Location = new System.Drawing.Point(119, 115);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Address.Properties.Appearance.Options.UseFont = true;
            this.Txt_Address.Size = new System.Drawing.Size(352, 20);
            this.Txt_Address.TabIndex = 4;
            // 
            // FrmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(531, 216);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.Txt_Phone);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.Txt_OpenDate);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.IipWvDcZu);
            this.Controls.Add(this.Txt_Status);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.LabelControl6);
            this.Controls.Add(this.LabelControl15);
            this.Controls.Add(this.LabelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStore";
            this.Load += new System.EventHandler(this.FrmStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IipWvDcZu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OpenDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        internal SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal GroupBox groupBox1;
        //private IContainer components;
        internal ComboBoxEdit IipWvDcZu;
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
