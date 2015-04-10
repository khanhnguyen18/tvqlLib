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
    partial class FrmPaymentOrder
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_Today = new DevExpress.XtraEditors.LabelControl();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_TransNum = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Remark = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Voucher = new DevExpress.XtraEditors.TextEdit();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.Txt_TranDate = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TranCode = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TranName = new DevExpress.XtraEditors.LabelControl();
            this.Txt_DbAccId = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_DbAccName = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Amount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_CreAccName = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CreAccId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_PayAccId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_PayerBank = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_PersonCap = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Payer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_PayerBranch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_BenBranch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_BenAccId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_BenBank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Beneficiary = new DevExpress.XtraEditors.TextEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TranDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DbAccId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PayAccId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PayerBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Payer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PayerBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_BenBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_BenAccId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_BenBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Beneficiary.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Today
            // 
            this.Lbl_Today.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Today.Appearance.Options.UseFont = true;
            this.Lbl_Today.Location = new System.Drawing.Point(265, 29);
            this.Lbl_Today.Name = "Lbl_Today";
            this.Lbl_Today.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Today.TabIndex = 169;
            this.Lbl_Today.Text = "01/01/2008";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(-94, 47);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(824, 5);
            this.GroupBox2.TabIndex = 165;
            this.GroupBox2.TabStop = false;
            // 
            // LabelControl20
            // 
            this.LabelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl20.Appearance.Options.UseFont = true;
            this.LabelControl20.Location = new System.Drawing.Point(226, 29);
            this.LabelControl20.Name = "LabelControl20";
            this.LabelControl20.Size = new System.Drawing.Size(32, 13);
            this.LabelControl20.TabIndex = 160;
            this.LabelControl20.Text = "Ngày :";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(23, 31);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(57, 13);
            this.LabelControl2.TabIndex = 159;
            this.LabelControl2.Text = "Số giao dịch";
            // 
            // Txt_TransNum
            // 
            this.Txt_TransNum.Location = new System.Drawing.Point(106, 26);
            this.Txt_TransNum.Name = "Txt_TransNum";
            this.Txt_TransNum.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.Txt_TransNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransNum.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_TransNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_TransNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_TransNum.Properties.MaxLength = 12;
            this.Txt_TransNum.Size = new System.Drawing.Size(102, 20);
            this.Txt_TransNum.TabIndex = 15;
            this.Txt_TransNum.TabStop = false;
            this.Txt_TransNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_TransNum_KeyDown);
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(23, 342);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(42, 13);
            this.LabelControl3.TabIndex = 167;
            this.LabelControl3.Text = "Nội dung";
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.EnterMoveNextControl = true;
            this.Txt_Remark.Location = new System.Drawing.Point(106, 339);
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Remark.Properties.Appearance.Options.UseFont = true;
            this.Txt_Remark.Size = new System.Drawing.Size(416, 20);
            this.Txt_Remark.TabIndex = 14;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(22, 316);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(73, 13);
            this.LabelControl4.TabIndex = 164;
            this.LabelControl4.Text = "Giá trị giao dịch";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(305, 376);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(-114, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 397;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(455, 376);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 20;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(380, 376);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(230, 376);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(155, 376);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(80, 376);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 16;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.iWyIskLbe);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(5, 376);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 204);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 400;
            this.labelControl5.Text = "Tài khoản ghi nợ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(306, 60);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 402;
            this.labelControl8.Text = "Số chứng từ";
            // 
            // Txt_Voucher
            // 
            this.Txt_Voucher.EnterMoveNextControl = true;
            this.Txt_Voucher.Location = new System.Drawing.Point(382, 57);
            this.Txt_Voucher.Name = "Txt_Voucher";
            this.Txt_Voucher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Voucher.Properties.Appearance.Options.UseFont = true;
            this.Txt_Voucher.Properties.MaxLength = 10;
            this.Txt_Voucher.Size = new System.Drawing.Size(140, 20);
            this.Txt_Voucher.TabIndex = 2;
            this.Txt_Voucher.EditValueChanged += new System.EventHandler(this.Txt_Voucher_EditValueChanged);
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 200;
            // 
            // Txt_TranDate
            // 
            this.Txt_TranDate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.Txt_TranDate.EnterMoveNextControl = true;
            this.Txt_TranDate.Location = new System.Drawing.Point(106, 57);
            this.Txt_TranDate.Name = "Txt_TranDate";
            this.Txt_TranDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TranDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_TranDate.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_TranDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_TranDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_TranDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_TranDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_TranDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_TranDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_TranDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.Txt_TranDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_TranDate.Size = new System.Drawing.Size(89, 20);
            this.Txt_TranDate.TabIndex = 1;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(22, 60);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(65, 13);
            this.LabelControl1.TabIndex = 404;
            this.LabelControl1.Text = "Ngày hiệu lực";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 13);
            this.labelControl6.TabIndex = 450;
            this.labelControl6.Text = "Loại giao dịch";
            // 
            // Lbl_TranCode
            // 
            this.Lbl_TranCode.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_TranCode.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_TranCode.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_TranCode.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TranCode.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TranCode.Appearance.Options.UseBackColor = true;
            this.Lbl_TranCode.Appearance.Options.UseBorderColor = true;
            this.Lbl_TranCode.Appearance.Options.UseFont = true;
            this.Lbl_TranCode.Appearance.Options.UseForeColor = true;
            this.Lbl_TranCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_TranCode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_TranCode.Location = new System.Drawing.Point(106, 5);
            this.Lbl_TranCode.Name = "Lbl_TranCode";
            this.Lbl_TranCode.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_TranCode.Size = new System.Drawing.Size(33, 15);
            this.Lbl_TranCode.TabIndex = 449;
            this.Lbl_TranCode.TextChanged += new System.EventHandler(this.Lbl_TranCode_TextChanged);
            // 
            // Lbl_TranName
            // 
            this.Lbl_TranName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_TranName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_TranName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_TranName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TranName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TranName.Appearance.Options.UseBackColor = true;
            this.Lbl_TranName.Appearance.Options.UseBorderColor = true;
            this.Lbl_TranName.Appearance.Options.UseFont = true;
            this.Lbl_TranName.Appearance.Options.UseForeColor = true;
            this.Lbl_TranName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_TranName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_TranName.Location = new System.Drawing.Point(145, 5);
            this.Lbl_TranName.Name = "Lbl_TranName";
            this.Lbl_TranName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_TranName.Size = new System.Drawing.Size(377, 15);
            this.Lbl_TranName.TabIndex = 451;
            // 
            // Txt_DbAccId
            // 
            this.Txt_DbAccId.EnterMoveNextControl = true;
            this.Txt_DbAccId.Location = new System.Drawing.Point(106, 201);
            this.Txt_DbAccId.Name = "Txt_DbAccId";
            this.Txt_DbAccId.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_DbAccId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DbAccId.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_DbAccId.Properties.Appearance.Options.UseFont = true;
            this.Txt_DbAccId.Properties.Mask.EditMask = "####-#-####";
            this.Txt_DbAccId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Txt_DbAccId.Properties.Mask.PlaceHolder = ' ';
            this.Txt_DbAccId.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_DbAccId.Size = new System.Drawing.Size(124, 20);
            this.Txt_DbAccId.TabIndex = 8;
            this.Txt_DbAccId.EditValueChanged += new System.EventHandler(this.Txt_DbAccId_EditValueChanged);
            this.Txt_DbAccId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_DbAccId_KeyDown);
            // 
            // Lbl_DbAccName
            // 
            this.Lbl_DbAccName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_DbAccName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_DbAccName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_DbAccName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DbAccName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_DbAccName.Appearance.Options.UseBackColor = true;
            this.Lbl_DbAccName.Appearance.Options.UseBorderColor = true;
            this.Lbl_DbAccName.Appearance.Options.UseFont = true;
            this.Lbl_DbAccName.Appearance.Options.UseForeColor = true;
            this.Lbl_DbAccName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_DbAccName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_DbAccName.Location = new System.Drawing.Point(236, 205);
            this.Lbl_DbAccName.Name = "Lbl_DbAccName";
            this.Lbl_DbAccName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_DbAccName.Size = new System.Drawing.Size(286, 15);
            this.Lbl_DbAccName.TabIndex = 453;
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.EditValue = "0";
            this.Txt_Amount.EnterMoveNextControl = true;
            this.Txt_Amount.Location = new System.Drawing.Point(106, 313);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Amount.Properties.Appearance.Options.UseFont = true;
            this.Txt_Amount.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Amount.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_Amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Amount.Properties.EditFormat.FormatString = "n2";
            this.Txt_Amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_Amount.Properties.Mask.EditMask = "n2";
            this.Txt_Amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_Amount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Amount.Size = new System.Drawing.Size(124, 20);
            this.Txt_Amount.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(238, 316);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(20, 13);
            this.labelControl7.TabIndex = 454;
            this.labelControl7.Text = "VND";
            // 
            // Lbl_CreAccName
            // 
            this.Lbl_CreAccName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_CreAccName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_CreAccName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_CreAccName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CreAccName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_CreAccName.Appearance.Options.UseBackColor = true;
            this.Lbl_CreAccName.Appearance.Options.UseBorderColor = true;
            this.Lbl_CreAccName.Appearance.Options.UseFont = true;
            this.Lbl_CreAccName.Appearance.Options.UseForeColor = true;
            this.Lbl_CreAccName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_CreAccName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_CreAccName.Location = new System.Drawing.Point(236, 96);
            this.Lbl_CreAccName.Name = "Lbl_CreAccName";
            this.Lbl_CreAccName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_CreAccName.Size = new System.Drawing.Size(286, 15);
            this.Lbl_CreAccName.TabIndex = 457;
            // 
            // Txt_CreAccId
            // 
            this.Txt_CreAccId.EnterMoveNextControl = true;
            this.Txt_CreAccId.Location = new System.Drawing.Point(106, 92);
            this.Txt_CreAccId.Name = "Txt_CreAccId";
            this.Txt_CreAccId.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_CreAccId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreAccId.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_CreAccId.Properties.Appearance.Options.UseFont = true;
            this.Txt_CreAccId.Properties.Mask.EditMask = "####-#-####";
            this.Txt_CreAccId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Txt_CreAccId.Properties.Mask.PlaceHolder = ' ';
            this.Txt_CreAccId.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_CreAccId.Size = new System.Drawing.Size(124, 20);
            this.Txt_CreAccId.TabIndex = 3;
            this.Txt_CreAccId.EditValueChanged += new System.EventHandler(this.Txt_CreAccId_EditValueChanged);
            this.Txt_CreAccId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_CreAccId_KeyDown);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(23, 95);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(77, 13);
            this.labelControl10.TabIndex = 456;
            this.labelControl10.Text = "Tài khoản ghi có";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(380, 120);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(27, 13);
            this.labelControl9.TabIndex = 469;
            this.labelControl9.Text = "Số TK";
            // 
            // Txt_PayAccId
            // 
            this.Txt_PayAccId.EditValue = "";
            this.Txt_PayAccId.EnterMoveNextControl = true;
            this.Txt_PayAccId.Location = new System.Drawing.Point(414, 117);
            this.Txt_PayAccId.Name = "Txt_PayAccId";
            this.Txt_PayAccId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PayAccId.Properties.Appearance.Options.UseFont = true;
            this.Txt_PayAccId.Size = new System.Drawing.Size(108, 20);
            this.Txt_PayAccId.TabIndex = 5;
            this.Txt_PayAccId.EditValueChanged += new System.EventHandler(this.Txt_PayAccId_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(22, 147);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 13);
            this.labelControl11.TabIndex = 468;
            this.labelControl11.Text = "Tại ngân hàng";
            // 
            // Txt_PayerBank
            // 
            this.Txt_PayerBank.EnterMoveNextControl = true;
            this.Txt_PayerBank.Location = new System.Drawing.Point(106, 143);
            this.Txt_PayerBank.Name = "Txt_PayerBank";
            this.Txt_PayerBank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PayerBank.Properties.Appearance.Options.UseFont = true;
            this.Txt_PayerBank.Size = new System.Drawing.Size(416, 20);
            this.Txt_PayerBank.TabIndex = 6;
            // 
            // Lbl_PersonCap
            // 
            this.Lbl_PersonCap.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PersonCap.Appearance.Options.UseFont = true;
            this.Lbl_PersonCap.Location = new System.Drawing.Point(22, 120);
            this.Lbl_PersonCap.Name = "Lbl_PersonCap";
            this.Lbl_PersonCap.Size = new System.Drawing.Size(69, 13);
            this.Lbl_PersonCap.TabIndex = 467;
            this.Lbl_PersonCap.Text = "Đơn vị trả tiền";
            // 
            // Txt_Payer
            // 
            this.Txt_Payer.EnterMoveNextControl = true;
            this.Txt_Payer.Location = new System.Drawing.Point(106, 117);
            this.Txt_Payer.Name = "Txt_Payer";
            this.Txt_Payer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Payer.Properties.Appearance.Options.UseFont = true;
            this.Txt_Payer.Size = new System.Drawing.Size(268, 20);
            this.Txt_Payer.TabIndex = 4;
            this.Txt_Payer.EditValueChanged += new System.EventHandler(this.Txt_Payer_EditValueChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(22, 173);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 471;
            this.labelControl12.Text = "Chi nhánh";
            // 
            // Txt_PayerBranch
            // 
            this.Txt_PayerBranch.EnterMoveNextControl = true;
            this.Txt_PayerBranch.Location = new System.Drawing.Point(106, 169);
            this.Txt_PayerBranch.Name = "Txt_PayerBranch";
            this.Txt_PayerBranch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PayerBranch.Properties.Appearance.Options.UseFont = true;
            this.Txt_PayerBranch.Size = new System.Drawing.Size(416, 20);
            this.Txt_PayerBranch.TabIndex = 7;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(22, 282);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 13);
            this.labelControl13.TabIndex = 479;
            this.labelControl13.Text = "Chi nhánh";
            // 
            // Txt_BenBranch
            // 
            this.Txt_BenBranch.EnterMoveNextControl = true;
            this.Txt_BenBranch.Location = new System.Drawing.Point(106, 278);
            this.Txt_BenBranch.Name = "Txt_BenBranch";
            this.Txt_BenBranch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BenBranch.Properties.Appearance.Options.UseFont = true;
            this.Txt_BenBranch.Size = new System.Drawing.Size(416, 20);
            this.Txt_BenBranch.TabIndex = 12;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(380, 229);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(27, 13);
            this.labelControl14.TabIndex = 477;
            this.labelControl14.Text = "Số TK";
            // 
            // Txt_BenAccId
            // 
            this.Txt_BenAccId.EnterMoveNextControl = true;
            this.Txt_BenAccId.Location = new System.Drawing.Point(414, 226);
            this.Txt_BenAccId.Name = "Txt_BenAccId";
            this.Txt_BenAccId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BenAccId.Properties.Appearance.Options.UseFont = true;
            this.Txt_BenAccId.Size = new System.Drawing.Size(108, 20);
            this.Txt_BenAccId.TabIndex = 10;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(22, 256);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(68, 13);
            this.labelControl15.TabIndex = 476;
            this.labelControl15.Text = "Tại ngân hàng";
            // 
            // Txt_BenBank
            // 
            this.Txt_BenBank.EnterMoveNextControl = true;
            this.Txt_BenBank.Location = new System.Drawing.Point(106, 252);
            this.Txt_BenBank.Name = "Txt_BenBank";
            this.Txt_BenBank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BenBank.Properties.Appearance.Options.UseFont = true;
            this.Txt_BenBank.Size = new System.Drawing.Size(416, 20);
            this.Txt_BenBank.TabIndex = 11;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(22, 229);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(79, 13);
            this.labelControl16.TabIndex = 475;
            this.labelControl16.Text = "Đơn vị nhận tiền";
            // 
            // Txt_Beneficiary
            // 
            this.Txt_Beneficiary.EnterMoveNextControl = true;
            this.Txt_Beneficiary.Location = new System.Drawing.Point(106, 226);
            this.Txt_Beneficiary.Name = "Txt_Beneficiary";
            this.Txt_Beneficiary.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Beneficiary.Properties.Appearance.Options.UseFont = true;
            this.Txt_Beneficiary.Size = new System.Drawing.Size(268, 20);
            this.Txt_Beneficiary.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-145, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(824, 5);
            this.groupBox3.TabIndex = 480;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(-145, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(824, 5);
            this.groupBox4.TabIndex = 481;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(-145, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(824, 5);
            this.groupBox5.TabIndex = 482;
            this.groupBox5.TabStop = false;
            // 
            // FrmPaymentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(534, 410);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.Txt_BenBranch);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.Txt_BenAccId);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.Txt_BenBank);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.Txt_Beneficiary);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.Txt_PayerBranch);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.Txt_PayAccId);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.Txt_PayerBank);
            this.Controls.Add(this.Lbl_PersonCap);
            this.Controls.Add(this.Txt_Payer);
            this.Controls.Add(this.Lbl_CreAccName);
            this.Controls.Add(this.Txt_CreAccId);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.Txt_Amount);
            this.Controls.Add(this.Lbl_DbAccName);
            this.Controls.Add(this.Txt_DbAccId);
            this.Controls.Add(this.Lbl_TranName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Lbl_TranCode);
            this.Controls.Add(this.Txt_TranDate);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.Txt_Voucher);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Lbl_Today);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.LabelControl20);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.Txt_TransNum);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.Txt_Remark);
            this.Controls.Add(this.LabelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPaymentOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaymentOrder";
            this.Load += new System.EventHandler(this.FrmPaymentOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TranDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DbAccId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PayAccId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PayerBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Payer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PayerBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_BenBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_BenAccId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_BenBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Beneficiary.Properties)).EndInit();
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
        private double double_0;
        internal GroupBox groupBox1;
        internal GroupBox GroupBox2;
        internal GroupBox groupBox3;
        internal GroupBox groupBox4;
        internal GroupBox groupBox5;
        //private IContainer components;
        private string IjSwogAv6;
        internal LabelControl LabelControl1;
        internal LabelControl labelControl10;
        internal LabelControl labelControl11;
        internal LabelControl labelControl12;
        internal LabelControl labelControl13;
        internal LabelControl labelControl14;
        internal LabelControl labelControl15;
        internal LabelControl labelControl16;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl20;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl labelControl5;
        private LabelControl labelControl6;
        internal LabelControl labelControl7;
        internal LabelControl labelControl8;
        internal LabelControl labelControl9;
        internal LabelControl Lbl_CreAccName;
        internal LabelControl Lbl_DbAccName;
        internal LabelControl Lbl_PersonCap;
        internal LabelControl Lbl_Today;
        internal LabelControl Lbl_TranCode;
        internal LabelControl Lbl_TranName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private Timer timer_0;
        internal TextEdit Txt_Amount;
        internal TextEdit Txt_BenAccId;
        internal TextEdit Txt_BenBank;
        internal TextEdit Txt_BenBranch;
        internal TextEdit Txt_Beneficiary;
        private TextEdit Txt_CreAccId;
        private TextEdit Txt_DbAccId;
        internal TextEdit Txt_PayAccId;
        internal TextEdit Txt_Payer;
        internal TextEdit Txt_PayerBank;
        internal TextEdit Txt_PayerBranch;
        internal TextEdit Txt_Remark;
        internal TextEdit Txt_TranDate;
        internal TextEdit Txt_TransNum;
        internal TextEdit Txt_Voucher;

        #endregion

    }
}
