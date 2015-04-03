using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmReaderDef
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
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtCsId = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Status = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersonId = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_OpenDate = new DevExpress.XtraEditors.TextEdit();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtDuedate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnImage = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPlaceOfIssue = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog_0 = new System.Windows.Forms.OpenFileDialog();
            this.lblCopyright = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OpenDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuedate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaceOfIssue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(493, 211);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 15;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(418, 211);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(268, 211);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(193, 211);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(118, 211);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 11;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.RrqIxZxw5);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(43, 211);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(343, 211);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-91, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 389;
            this.groupBox1.TabStop = false;
            // 
            // LabelControl14
            // 
            this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new System.Drawing.Point(152, 38);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(47, 13);
            this.LabelControl14.TabIndex = 335;
            this.LabelControl14.Text = "Họ và tên";
            // 
            // txtPhone
            // 
            this.txtPhone.EnterMoveNextControl = true;
            this.txtPhone.Location = new System.Drawing.Point(242, 106);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Properties.Appearance.Options.UseBackColor = true;
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(197, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(152, 61);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(32, 13);
            this.LabelControl1.TabIndex = 337;
            this.LabelControl1.Text = "Địa chỉ";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(152, 109);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(62, 13);
            this.LabelControl2.TabIndex = 338;
            this.LabelControl2.Text = "Số điện thoại";
            // 
            // txtFax
            // 
            this.txtFax.EnterMoveNextControl = true;
            this.txtFax.Location = new System.Drawing.Point(469, 106);
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtFax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Properties.Appearance.Options.UseBackColor = true;
            this.txtFax.Properties.Appearance.Options.UseFont = true;
            this.txtFax.Size = new System.Drawing.Size(123, 20);
            this.txtFax.TabIndex = 5;
            // 
            // txtCsId
            // 
            this.txtCsId.EnterMoveNextControl = true;
            this.txtCsId.Location = new System.Drawing.Point(242, 12);
            this.txtCsId.Name = "txtCsId";
            this.txtCsId.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCsId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsId.Properties.Appearance.Options.UseBackColor = true;
            this.txtCsId.Properties.Appearance.Options.UseFont = true;
            this.txtCsId.Properties.Mask.PlaceHolder = ' ';
            this.txtCsId.Properties.MaxLength = 6;
            this.txtCsId.Properties.ValidateOnEnterKey = true;
            this.txtCsId.Size = new System.Drawing.Size(90, 20);
            this.txtCsId.TabIndex = 339;
            this.txtCsId.EditValueChanged += new System.EventHandler(this.txtCsId_EditValueChanged);
            this.txtCsId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCsId_KeyDown);
            // 
            // Txt_Status
            // 
            this.Txt_Status.EnterMoveNextControl = true;
            this.Txt_Status.Location = new System.Drawing.Point(12, 8);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Status.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new System.Drawing.Size(124, 20);
            this.Txt_Status.TabIndex = 340;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(152, 15);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(55, 13);
            this.LabelControl4.TabIndex = 341;
            this.LabelControl4.Text = "Mã số thẻ";
            // 
            // txtPersonId
            // 
            this.txtPersonId.EnterMoveNextControl = true;
            this.txtPersonId.Location = new System.Drawing.Point(242, 152);
            this.txtPersonId.Name = "txtPersonId";
            this.txtPersonId.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtPersonId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonId.Properties.Appearance.Options.UseBackColor = true;
            this.txtPersonId.Properties.Appearance.Options.UseFont = true;
            this.txtPersonId.Size = new System.Drawing.Size(126, 20);
            this.txtPersonId.TabIndex = 7;
            // 
            // LabelControl8
            // 
            this.LabelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl8.Appearance.Options.UseFont = true;
            this.LabelControl8.Location = new System.Drawing.Point(152, 156);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(79, 13);
            this.LabelControl8.TabIndex = 343;
            this.LabelControl8.Text = "CMTND/hộ chiếu";
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(445, 109);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(18, 13);
            this.LabelControl5.TabIndex = 346;
            this.LabelControl5.Text = "Fax";
            // 
            // Txt_OpenDate
            // 
            this.Txt_OpenDate.EnterMoveNextControl = true;
            this.Txt_OpenDate.Location = new System.Drawing.Point(504, 35);
            this.Txt_OpenDate.Name = "Txt_OpenDate";
            this.Txt_OpenDate.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_OpenDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OpenDate.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_OpenDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_OpenDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_OpenDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_OpenDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Txt_OpenDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_OpenDate.Size = new System.Drawing.Size(89, 20);
            this.Txt_OpenDate.TabIndex = 16;
            // 
            // txtRemark
            // 
            this.txtRemark.EnterMoveNextControl = true;
            this.txtRemark.Location = new System.Drawing.Point(242, 176);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtRemark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Properties.Appearance.Options.UseBackColor = true;
            this.txtRemark.Properties.Appearance.Options.UseFont = true;
            this.txtRemark.Size = new System.Drawing.Size(351, 20);
            this.txtRemark.TabIndex = 9;
            // 
            // LabelControl7
            // 
            this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl7.Appearance.Options.UseFont = true;
            this.LabelControl7.Location = new System.Drawing.Point(152, 179);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(35, 13);
            this.LabelControl7.TabIndex = 350;
            this.LabelControl7.Text = "Ghi chú";
            // 
            // txtEmail
            // 
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(242, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(351, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // LabelControl11
            // 
            this.LabelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl11.Appearance.Options.UseFont = true;
            this.LabelControl11.Location = new System.Drawing.Point(152, 132);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(24, 13);
            this.LabelControl11.TabIndex = 351;
            this.LabelControl11.Text = "Email";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 34);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(125, 131);
            this.pictureEdit1.TabIndex = 392;
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(242, 58);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.Properties.Appearance.Options.UseBackColor = true;
            this.txtAddress.Size = new System.Drawing.Size(351, 45);
            this.txtAddress.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Location = new System.Drawing.Point(242, 35);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(256, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtDuedate
            // 
            this.txtDuedate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.txtDuedate.EnterMoveNextControl = true;
            this.txtDuedate.Location = new System.Drawing.Point(504, 12);
            this.txtDuedate.Name = "txtDuedate";
            this.txtDuedate.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtDuedate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuedate.Properties.Appearance.Options.UseBackColor = true;
            this.txtDuedate.Properties.Appearance.Options.UseFont = true;
            this.txtDuedate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDuedate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDuedate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtDuedate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDuedate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtDuedate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDuedate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtDuedate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtDuedate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDuedate.Size = new System.Drawing.Size(89, 20);
            this.txtDuedate.TabIndex = 1;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(407, 16);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(91, 13);
            this.labelControl13.TabIndex = 395;
            this.labelControl13.Text = "Có giá trị đến ngày";
            // 
            // btnImage
            // 
            this.btnImage.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Appearance.Options.UseFont = true;
            this.btnImage.Location = new System.Drawing.Point(38, 171);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(73, 19);
            this.btnImage.TabIndex = 396;
            this.btnImage.Text = "Chọn";
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(377, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 398;
            this.labelControl3.Text = "Nơi cấp";
            // 
            // txtPlaceOfIssue
            // 
            this.txtPlaceOfIssue.EnterMoveNextControl = true;
            this.txtPlaceOfIssue.Location = new System.Drawing.Point(418, 152);
            this.txtPlaceOfIssue.Name = "txtPlaceOfIssue";
            this.txtPlaceOfIssue.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtPlaceOfIssue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceOfIssue.Properties.Appearance.Options.UseBackColor = true;
            this.txtPlaceOfIssue.Properties.Appearance.Options.UseFont = true;
            this.txtPlaceOfIssue.Size = new System.Drawing.Size(175, 20);
            this.txtPlaceOfIssue.TabIndex = 8;
            // 
            // openFileDialog_0
            // 
            this.openFileDialog_0.FileName = "*.jpg";
            this.openFileDialog_0.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_0_FileOk);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCopyright.Appearance.BackColor2 = System.Drawing.Color.WhiteSmoke;
            this.lblCopyright.Appearance.BorderColor = System.Drawing.Color.White;
            this.lblCopyright.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCopyright.Appearance.Options.UseBackColor = true;
            this.lblCopyright.Appearance.Options.UseBorderColor = true;
            this.lblCopyright.Appearance.Options.UseFont = true;
            this.lblCopyright.Appearance.Options.UseForeColor = true;
            this.lblCopyright.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lblCopyright.Location = new System.Drawing.Point(0, 239);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCopyright.Size = new System.Drawing.Size(610, 17);
            this.lblCopyright.TabIndex = 399;
            // 
            // FrmReaderDef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(610, 256);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPlaceOfIssue);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.txtDuedate);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.LabelControl11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.LabelControl7);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.Txt_OpenDate);
            this.Controls.Add(this.LabelControl5);
            this.Controls.Add(this.LabelControl8);
            this.Controls.Add(this.txtPersonId);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.Txt_Status);
            this.Controls.Add(this.txtCsId);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.LabelControl14);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmReaderDef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReaderDef";
            this.Load += new System.EventHandler(this.FrmReaderDef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCsId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OpenDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuedate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaceOfIssue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal SimpleButton btnImage;
        internal GroupBox groupBox1;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl11;
        internal LabelControl labelControl13;
        internal LabelControl LabelControl14;
        internal LabelControl LabelControl2;
        internal LabelControl labelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl5;
        internal LabelControl LabelControl7;
        internal LabelControl LabelControl8;
        internal LabelControl lblCopyright;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        internal OpenFileDialog openFileDialog_0;
        private PictureEdit pictureEdit1;
        private string string_0;
        private string string_1;
        internal TextEdit Txt_OpenDate;
        internal TextEdit Txt_Status;
        private MemoEdit txtAddress;
        internal TextEdit txtCsId;
        internal TextEdit txtDuedate;
        internal TextEdit txtEmail;
        internal TextEdit txtFax;
        internal TextEdit txtName;
        internal TextEdit txtPersonId;
        internal TextEdit txtPhone;
        internal TextEdit txtPlaceOfIssue;
        internal TextEdit txtRemark;

        #endregion
    }
}
