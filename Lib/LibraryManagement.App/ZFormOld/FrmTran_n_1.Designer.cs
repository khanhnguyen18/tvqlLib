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
    partial class FrmTran_n_1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.Txt_CreAccId1 = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_CreAccName1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CreAmt1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_DebAccName = new DevExpress.XtraEditors.LabelControl();
            this.Txt_DebAccId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_CreAccName2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CreAccId2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_CreAccName3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CreAccId3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CreAmt2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CreAmt3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_DebitAmt = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TranDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAmt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DebAccId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAmt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAmt3.Properties)).BeginInit();
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
            this.GroupBox2.Controls.Add(this.groupBox3);
            this.GroupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(-94, 52);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(824, 5);
            this.GroupBox2.TabIndex = 165;
            this.GroupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(824, 5);
            this.groupBox3.TabIndex = 166;
            this.groupBox3.TabStop = false;
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
            this.Txt_TransNum.Location = new System.Drawing.Point(116, 26);
            this.Txt_TransNum.Name = "Txt_TransNum";
            this.Txt_TransNum.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.Txt_TransNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransNum.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_TransNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_TransNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_TransNum.Properties.MaxLength = 12;
            this.Txt_TransNum.Properties.ReadOnly = true;
            this.Txt_TransNum.Size = new System.Drawing.Size(102, 20);
            this.Txt_TransNum.TabIndex = 15;
            this.Txt_TransNum.TabStop = false;
            this.Txt_TransNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_TransNum_KeyDown);
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(23, 301);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(40, 13);
            this.LabelControl3.TabIndex = 167;
            this.LabelControl3.Text = "Diễn giải";
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.EnterMoveNextControl = true;
            this.Txt_Remark.Location = new System.Drawing.Point(116, 298);
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Remark.Properties.Appearance.Options.UseFont = true;
            this.Txt_Remark.Size = new System.Drawing.Size(406, 20);
            this.Txt_Remark.TabIndex = 10;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(22, 124);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(28, 13);
            this.LabelControl4.TabIndex = 164;
            this.LabelControl4.Text = "Giá trị";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(305, 335);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "&Xóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(-114, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 397;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(455, 335);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(380, 335);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(230, 335);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 13;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(155, 335);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(80, 335);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 12;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(5, 335);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 13);
            this.labelControl5.TabIndex = 400;
            this.labelControl5.Text = "Tài khoản ghi có 1";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(306, 66);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 402;
            this.labelControl8.Text = "Số chứng từ";
            // 
            // Txt_Voucher
            // 
            this.Txt_Voucher.EnterMoveNextControl = true;
            this.Txt_Voucher.Location = new System.Drawing.Point(382, 63);
            this.Txt_Voucher.Name = "Txt_Voucher";
            this.Txt_Voucher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Voucher.Properties.Appearance.Options.UseFont = true;
            this.Txt_Voucher.Properties.MaxLength = 10;
            this.Txt_Voucher.Size = new System.Drawing.Size(140, 20);
            this.Txt_Voucher.TabIndex = 2;
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 200;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // Txt_TranDate
            // 
            this.Txt_TranDate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.Txt_TranDate.EnterMoveNextControl = true;
            this.Txt_TranDate.Location = new System.Drawing.Point(116, 63);
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
            this.Txt_TranDate.Size = new System.Drawing.Size(79, 20);
            this.Txt_TranDate.TabIndex = 1;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(22, 66);
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
            this.Lbl_TranCode.Location = new System.Drawing.Point(116, 5);
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
            this.Lbl_TranName.Location = new System.Drawing.Point(155, 5);
            this.Lbl_TranName.Name = "Lbl_TranName";
            this.Lbl_TranName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_TranName.Size = new System.Drawing.Size(367, 15);
            this.Lbl_TranName.TabIndex = 451;
            // 
            // Txt_CreAccId1
            // 
            this.Txt_CreAccId1.EnterMoveNextControl = true;
            this.Txt_CreAccId1.Location = new System.Drawing.Point(116, 97);
            this.Txt_CreAccId1.Name = "Txt_CreAccId1";
            this.Txt_CreAccId1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_CreAccId1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreAccId1.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_CreAccId1.Properties.Appearance.Options.UseFont = true;
            this.Txt_CreAccId1.Properties.Mask.EditMask = "####-#-####";
            this.Txt_CreAccId1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Txt_CreAccId1.Properties.Mask.PlaceHolder = ' ';
            this.Txt_CreAccId1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_CreAccId1.Size = new System.Drawing.Size(114, 20);
            this.Txt_CreAccId1.TabIndex = 3;
            this.Txt_CreAccId1.EditValueChanged += new System.EventHandler(this.Txt_CreAccId1_EditValueChanged);
            this.Txt_CreAccId1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_CreAccId1_KeyDown);
            // 
            // Lbl_CreAccName1
            // 
            this.Lbl_CreAccName1.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_CreAccName1.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_CreAccName1.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_CreAccName1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CreAccName1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_CreAccName1.Appearance.Options.UseBackColor = true;
            this.Lbl_CreAccName1.Appearance.Options.UseBorderColor = true;
            this.Lbl_CreAccName1.Appearance.Options.UseFont = true;
            this.Lbl_CreAccName1.Appearance.Options.UseForeColor = true;
            this.Lbl_CreAccName1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_CreAccName1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_CreAccName1.Location = new System.Drawing.Point(236, 101);
            this.Lbl_CreAccName1.Name = "Lbl_CreAccName1";
            this.Lbl_CreAccName1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_CreAccName1.Size = new System.Drawing.Size(286, 15);
            this.Lbl_CreAccName1.TabIndex = 453;
            // 
            // Txt_CreAmt1
            // 
            this.Txt_CreAmt1.EditValue = "0";
            this.Txt_CreAmt1.EnterMoveNextControl = true;
            this.Txt_CreAmt1.Location = new System.Drawing.Point(116, 121);
            this.Txt_CreAmt1.Name = "Txt_CreAmt1";
            this.Txt_CreAmt1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreAmt1.Properties.Appearance.Options.UseFont = true;
            this.Txt_CreAmt1.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_CreAmt1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_CreAmt1.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_CreAmt1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_CreAmt1.Properties.EditFormat.FormatString = "n2";
            this.Txt_CreAmt1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_CreAmt1.Properties.Mask.EditMask = "n2";
            this.Txt_CreAmt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_CreAmt1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_CreAmt1.Size = new System.Drawing.Size(114, 20);
            this.Txt_CreAmt1.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(236, 124);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(20, 13);
            this.labelControl7.TabIndex = 454;
            this.labelControl7.Text = "VND";
            // 
            // Lbl_DebAccName
            // 
            this.Lbl_DebAccName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_DebAccName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_DebAccName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_DebAccName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DebAccName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_DebAccName.Appearance.Options.UseBackColor = true;
            this.Lbl_DebAccName.Appearance.Options.UseBorderColor = true;
            this.Lbl_DebAccName.Appearance.Options.UseFont = true;
            this.Lbl_DebAccName.Appearance.Options.UseForeColor = true;
            this.Lbl_DebAccName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_DebAccName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_DebAccName.Location = new System.Drawing.Point(236, 277);
            this.Lbl_DebAccName.Name = "Lbl_DebAccName";
            this.Lbl_DebAccName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_DebAccName.Size = new System.Drawing.Size(286, 15);
            this.Lbl_DebAccName.TabIndex = 457;
            // 
            // Txt_DebAccId
            // 
            this.Txt_DebAccId.EnterMoveNextControl = true;
            this.Txt_DebAccId.Location = new System.Drawing.Point(116, 273);
            this.Txt_DebAccId.Name = "Txt_DebAccId";
            this.Txt_DebAccId.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_DebAccId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_DebAccId.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_DebAccId.Properties.Appearance.Options.UseFont = true;
            this.Txt_DebAccId.Properties.Mask.EditMask = "####-#-####";
            this.Txt_DebAccId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Txt_DebAccId.Properties.Mask.PlaceHolder = ' ';
            this.Txt_DebAccId.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_DebAccId.Size = new System.Drawing.Size(114, 20);
            this.Txt_DebAccId.TabIndex = 9;
            this.Txt_DebAccId.EditValueChanged += new System.EventHandler(this.Txt_DebAccId_EditValueChanged);
            this.Txt_DebAccId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_DebAccId_KeyDown);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(23, 276);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(78, 13);
            this.labelControl10.TabIndex = 456;
            this.labelControl10.Text = "Tài khoản ghi nợ";
            // 
            // Lbl_CreAccName2
            // 
            this.Lbl_CreAccName2.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_CreAccName2.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_CreAccName2.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_CreAccName2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CreAccName2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_CreAccName2.Appearance.Options.UseBackColor = true;
            this.Lbl_CreAccName2.Appearance.Options.UseBorderColor = true;
            this.Lbl_CreAccName2.Appearance.Options.UseFont = true;
            this.Lbl_CreAccName2.Appearance.Options.UseForeColor = true;
            this.Lbl_CreAccName2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_CreAccName2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_CreAccName2.Location = new System.Drawing.Point(236, 152);
            this.Lbl_CreAccName2.Name = "Lbl_CreAccName2";
            this.Lbl_CreAccName2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_CreAccName2.Size = new System.Drawing.Size(286, 15);
            this.Lbl_CreAccName2.TabIndex = 460;
            // 
            // Txt_CreAccId2
            // 
            this.Txt_CreAccId2.EnterMoveNextControl = true;
            this.Txt_CreAccId2.Location = new System.Drawing.Point(116, 147);
            this.Txt_CreAccId2.Name = "Txt_CreAccId2";
            this.Txt_CreAccId2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_CreAccId2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreAccId2.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_CreAccId2.Properties.Appearance.Options.UseFont = true;
            this.Txt_CreAccId2.Properties.Mask.EditMask = "####-#-####";
            this.Txt_CreAccId2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Txt_CreAccId2.Properties.Mask.PlaceHolder = ' ';
            this.Txt_CreAccId2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_CreAccId2.Size = new System.Drawing.Size(114, 20);
            this.Txt_CreAccId2.TabIndex = 5;
            this.Txt_CreAccId2.EditValueChanged += new System.EventHandler(this.Txt_CreAccId2_EditValueChanged);
            this.Txt_CreAccId2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_CreAccId2_KeyDown);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(22, 150);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(86, 13);
            this.labelControl11.TabIndex = 459;
            this.labelControl11.Text = "Tài khoản ghi có 2";
            // 
            // Lbl_CreAccName3
            // 
            this.Lbl_CreAccName3.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_CreAccName3.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_CreAccName3.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_CreAccName3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CreAccName3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_CreAccName3.Appearance.Options.UseBackColor = true;
            this.Lbl_CreAccName3.Appearance.Options.UseBorderColor = true;
            this.Lbl_CreAccName3.Appearance.Options.UseFont = true;
            this.Lbl_CreAccName3.Appearance.Options.UseForeColor = true;
            this.Lbl_CreAccName3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_CreAccName3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_CreAccName3.Location = new System.Drawing.Point(236, 200);
            this.Lbl_CreAccName3.Name = "Lbl_CreAccName3";
            this.Lbl_CreAccName3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_CreAccName3.Size = new System.Drawing.Size(286, 15);
            this.Lbl_CreAccName3.TabIndex = 463;
            // 
            // Txt_CreAccId3
            // 
            this.Txt_CreAccId3.EnterMoveNextControl = true;
            this.Txt_CreAccId3.Location = new System.Drawing.Point(116, 195);
            this.Txt_CreAccId3.Name = "Txt_CreAccId3";
            this.Txt_CreAccId3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_CreAccId3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreAccId3.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_CreAccId3.Properties.Appearance.Options.UseFont = true;
            this.Txt_CreAccId3.Properties.Mask.EditMask = "####-#-####";
            this.Txt_CreAccId3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Txt_CreAccId3.Properties.Mask.PlaceHolder = ' ';
            this.Txt_CreAccId3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_CreAccId3.Size = new System.Drawing.Size(114, 20);
            this.Txt_CreAccId3.TabIndex = 7;
            this.Txt_CreAccId3.EditValueChanged += new System.EventHandler(this.kCnalMegv);
            this.Txt_CreAccId3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_CreAccId3_KeyDown);
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(23, 198);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(86, 13);
            this.labelControl13.TabIndex = 462;
            this.labelControl13.Text = "Tài khoản ghi có 3";
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(-145, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(824, 5);
            this.groupBox4.TabIndex = 464;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(-145, 243);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(824, 5);
            this.groupBox5.TabIndex = 465;
            this.groupBox5.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(236, 174);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(20, 13);
            this.labelControl9.TabIndex = 468;
            this.labelControl9.Text = "VND";
            // 
            // Txt_CreAmt2
            // 
            this.Txt_CreAmt2.EditValue = "0";
            this.Txt_CreAmt2.EnterMoveNextControl = true;
            this.Txt_CreAmt2.Location = new System.Drawing.Point(116, 171);
            this.Txt_CreAmt2.Name = "Txt_CreAmt2";
            this.Txt_CreAmt2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreAmt2.Properties.Appearance.Options.UseFont = true;
            this.Txt_CreAmt2.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_CreAmt2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_CreAmt2.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_CreAmt2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_CreAmt2.Properties.EditFormat.FormatString = "n2";
            this.Txt_CreAmt2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_CreAmt2.Properties.Mask.EditMask = "n2";
            this.Txt_CreAmt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_CreAmt2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_CreAmt2.Size = new System.Drawing.Size(114, 20);
            this.Txt_CreAmt2.TabIndex = 6;
            this.Txt_CreAmt2.EditValueChanged += new System.EventHandler(this.Txt_CreAmt2_EditValueChanged);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(22, 174);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(28, 13);
            this.labelControl12.TabIndex = 467;
            this.labelControl12.Text = "Giá trị";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(236, 224);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(20, 13);
            this.labelControl14.TabIndex = 471;
            this.labelControl14.Text = "VND";
            // 
            // Txt_CreAmt3
            // 
            this.Txt_CreAmt3.EditValue = "0";
            this.Txt_CreAmt3.EnterMoveNextControl = true;
            this.Txt_CreAmt3.Location = new System.Drawing.Point(116, 221);
            this.Txt_CreAmt3.Name = "Txt_CreAmt3";
            this.Txt_CreAmt3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreAmt3.Properties.Appearance.Options.UseFont = true;
            this.Txt_CreAmt3.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_CreAmt3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_CreAmt3.Properties.DisplayFormat.FormatString = "n2";
            this.Txt_CreAmt3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_CreAmt3.Properties.EditFormat.FormatString = "n2";
            this.Txt_CreAmt3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Txt_CreAmt3.Properties.Mask.EditMask = "n2";
            this.Txt_CreAmt3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Txt_CreAmt3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_CreAmt3.Size = new System.Drawing.Size(114, 20);
            this.Txt_CreAmt3.TabIndex = 8;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(22, 224);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(28, 13);
            this.labelControl15.TabIndex = 470;
            this.labelControl15.Text = "Giá trị";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(22, 252);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(60, 13);
            this.labelControl16.TabIndex = 473;
            this.labelControl16.Text = "Giá trị ghi nợ";
            // 
            // Lbl_DebitAmt
            // 
            this.Lbl_DebitAmt.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_DebitAmt.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_DebitAmt.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_DebitAmt.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DebitAmt.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_DebitAmt.Appearance.Options.UseBackColor = true;
            this.Lbl_DebitAmt.Appearance.Options.UseBorderColor = true;
            this.Lbl_DebitAmt.Appearance.Options.UseFont = true;
            this.Lbl_DebitAmt.Appearance.Options.UseForeColor = true;
            this.Lbl_DebitAmt.Appearance.Options.UseTextOptions = true;
            this.Lbl_DebitAmt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Lbl_DebitAmt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_DebitAmt.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_DebitAmt.Location = new System.Drawing.Point(116, 252);
            this.Lbl_DebitAmt.Name = "Lbl_DebitAmt";
            this.Lbl_DebitAmt.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Lbl_DebitAmt.Size = new System.Drawing.Size(114, 15);
            this.Lbl_DebitAmt.TabIndex = 472;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(238, 253);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(20, 13);
            this.labelControl18.TabIndex = 474;
            this.labelControl18.Text = "VND";
            // 
            // FrmTran_n_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(534, 369);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.Lbl_DebitAmt);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.Txt_CreAmt3);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.Txt_CreAmt2);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Lbl_CreAccName3);
            this.Controls.Add(this.Txt_CreAccId3);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.Lbl_CreAccName2);
            this.Controls.Add(this.Txt_CreAccId2);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.Lbl_DebAccName);
            this.Controls.Add(this.Txt_DebAccId);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.Txt_CreAmt1);
            this.Controls.Add(this.Lbl_CreAccName1);
            this.Controls.Add(this.Txt_CreAccId1);
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
            this.Name = "FrmTran_n_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao dịch một nợ nhiều có";
            this.Load += new System.EventHandler(this.FrmTran_n_1_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TranDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAmt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DebAccId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAmt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAmt3.Properties)).EndInit();
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
        internal GroupBox groupBox1;
        internal GroupBox GroupBox2;
        internal GroupBox groupBox3;
        internal GroupBox groupBox4;
        internal GroupBox groupBox5;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl labelControl10;
        internal LabelControl labelControl11;
        internal LabelControl labelControl12;
        internal LabelControl labelControl13;
        internal LabelControl labelControl14;
        internal LabelControl labelControl15;
        private LabelControl labelControl16;
        internal LabelControl labelControl18;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl20;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl labelControl5;
        private LabelControl labelControl6;
        internal LabelControl labelControl7;
        internal LabelControl labelControl8;
        internal LabelControl labelControl9;
        internal LabelControl Lbl_CreAccName1;
        internal LabelControl Lbl_CreAccName2;
        internal LabelControl Lbl_CreAccName3;
        internal LabelControl Lbl_DebAccName;
        internal LabelControl Lbl_DebitAmt;
        internal LabelControl Lbl_Today;
        internal LabelControl Lbl_TranCode;
        internal LabelControl Lbl_TranName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private Timer timer_0;
        private TextEdit Txt_CreAccId1;
        private TextEdit Txt_CreAccId2;
        private TextEdit Txt_CreAccId3;
        internal TextEdit Txt_CreAmt1;
        internal TextEdit Txt_CreAmt2;
        internal TextEdit Txt_CreAmt3;
        private TextEdit Txt_DebAccId;
        internal TextEdit Txt_Remark;
        internal TextEdit Txt_TranDate;
        internal TextEdit Txt_TransNum;
        internal TextEdit Txt_Voucher;



        #endregion

    }
}
