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
    partial class FrmTran_1_1
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
            this.xTveRubwQ = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_CreAccName = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CreAccId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TranDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DbAccId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId.Properties)).BeginInit();
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
            this.GroupBox2.Location = new System.Drawing.Point(-94, 52);
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
            this.LabelControl3.Location = new System.Drawing.Point(23, 182);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(40, 13);
            this.LabelControl3.TabIndex = 167;
            this.LabelControl3.Text = "Diễn giải";
            // 
            // Txt_Remark
            // 
            this.Txt_Remark.EnterMoveNextControl = true;
            this.Txt_Remark.Location = new System.Drawing.Point(106, 179);
            this.Txt_Remark.Name = "Txt_Remark";
            this.Txt_Remark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Remark.Properties.Appearance.Options.UseFont = true;
            this.Txt_Remark.Size = new System.Drawing.Size(416, 20);
            this.Txt_Remark.TabIndex = 6;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(22, 92);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(73, 13);
            this.LabelControl4.TabIndex = 164;
            this.LabelControl4.Text = "Giá trị giao dịch";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(305, 217);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(-114, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 397;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(455, 217);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(380, 217);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(230, 217);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(155, 217);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(80, 217);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 8;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(5, 217);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 133);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 400;
            this.labelControl5.Text = "Tài khoản ghi nợ";
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
            // 
            // Txt_TranDate
            // 
            this.Txt_TranDate.EditValue = new System.DateTime(2008, 4, 24, 13, 52, 43, 421);
            this.Txt_TranDate.EnterMoveNextControl = true;
            this.Txt_TranDate.Location = new System.Drawing.Point(106, 63);
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
            this.Txt_DbAccId.Location = new System.Drawing.Point(106, 130);
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
            this.Txt_DbAccId.TabIndex = 4;
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
            this.Lbl_DbAccName.Location = new System.Drawing.Point(236, 134);
            this.Lbl_DbAccName.Name = "Lbl_DbAccName";
            this.Lbl_DbAccName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_DbAccName.Size = new System.Drawing.Size(286, 15);
            this.Lbl_DbAccName.TabIndex = 453;
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.EditValue = "0";
            this.Txt_Amount.EnterMoveNextControl = true;
            this.Txt_Amount.Location = new System.Drawing.Point(106, 89);
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
            this.Txt_Amount.TabIndex = 3;
            // 
            // xTveRubwQ
            // 
            this.xTveRubwQ.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xTveRubwQ.Appearance.Options.UseFont = true;
            this.xTveRubwQ.Location = new System.Drawing.Point(236, 92);
            this.xTveRubwQ.Name = "xTveRubwQ";
            this.xTveRubwQ.Size = new System.Drawing.Size(20, 13);
            this.xTveRubwQ.TabIndex = 454;
            this.xTveRubwQ.Text = "VND";
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
            this.Lbl_CreAccName.Location = new System.Drawing.Point(236, 158);
            this.Lbl_CreAccName.Name = "Lbl_CreAccName";
            this.Lbl_CreAccName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_CreAccName.Size = new System.Drawing.Size(286, 15);
            this.Lbl_CreAccName.TabIndex = 457;
            // 
            // Txt_CreAccId
            // 
            this.Txt_CreAccId.EnterMoveNextControl = true;
            this.Txt_CreAccId.Location = new System.Drawing.Point(106, 154);
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
            this.Txt_CreAccId.TabIndex = 5;
            this.Txt_CreAccId.EditValueChanged += new System.EventHandler(this.Txt_CreAccId_EditValueChanged);
            this.Txt_CreAccId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_CreAccId_KeyDown);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(23, 157);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(77, 13);
            this.labelControl10.TabIndex = 456;
            this.labelControl10.Text = "Tài khoản ghi có";
            // 
            // FrmTran_1_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(534, 251);
            this.Controls.Add(this.Lbl_CreAccName);
            this.Controls.Add(this.Txt_CreAccId);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.xTveRubwQ);
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
            this.Name = "FrmTran_1_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTran_1-1";
            this.Load += new System.EventHandler(this.FrmTran_1_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Voucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TranDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DbAccId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CreAccId.Properties)).EndInit();
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
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl labelControl10;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl20;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl labelControl5;
        private LabelControl labelControl6;
        internal LabelControl labelControl8;
        internal LabelControl Lbl_CreAccName;
        internal LabelControl Lbl_DbAccName;
        internal LabelControl Lbl_Today;
        internal LabelControl Lbl_TranCode;
        internal LabelControl Lbl_TranName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private Timer timer_0;
        internal TextEdit Txt_Amount;
        private TextEdit Txt_CreAccId;
        private TextEdit Txt_DbAccId;
        internal TextEdit Txt_Remark;
        internal TextEdit Txt_TranDate;
        internal TextEdit Txt_TransNum;
        internal TextEdit Txt_Voucher;
        internal LabelControl xTveRubwQ;

        #endregion

    }
}
