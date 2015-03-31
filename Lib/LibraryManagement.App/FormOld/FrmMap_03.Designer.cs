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
    partial class FrmMap_03
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_VnName = new DevExpress.XtraEditors.TextEdit();
            this.Txt_ThirdLevel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_EngName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_FstLevelEName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_FstLevelName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_FstLevel = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_SecondLevel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_SndLevelEName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_SndLevelName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Negative = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_OtherEqui = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VnName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ThirdLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_EngName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Negative.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OtherEqui.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroupBox2.Location = new System.Drawing.Point(-116, 216);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(762, 5);
            this.GroupBox2.TabIndex = 442;
            this.GroupBox2.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(303, 228);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "&Xóa";
            // 
            // Txt_VnName
            // 
            this.Txt_VnName.EnterMoveNextControl = true;
            this.Txt_VnName.Location = new System.Drawing.Point(186, 131);
            this.Txt_VnName.Name = "Txt_VnName";
            this.Txt_VnName.Size = new System.Drawing.Size(314, 20);
            this.Txt_VnName.TabIndex = 2;
            // 
            // Txt_ThirdLevel
            // 
            this.Txt_ThirdLevel.EnterMoveNextControl = true;
            this.Txt_ThirdLevel.Location = new System.Drawing.Point(49, 131);
            this.Txt_ThirdLevel.Name = "Txt_ThirdLevel";
            this.Txt_ThirdLevel.Properties.Appearance.Options.UseFont = true;
            this.Txt_ThirdLevel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_ThirdLevel.Properties.MaxLength = 4;
            this.Txt_ThirdLevel.Size = new System.Drawing.Size(50, 20);
            this.Txt_ThirdLevel.TabIndex = 1;
            this.Txt_ThirdLevel.ToolTip = "Nhấn F5 để tìm kiếm";
            this.Txt_ThirdLevel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.Txt_ThirdLevel.ToolTipTitle = "Lưu ý";
            this.Txt_ThirdLevel.EditValueChanged += new System.EventHandler(this.Txt_ThirdLevel_EditValueChanged);
            this.Txt_ThirdLevel.Validated += new System.EventHandler(this.Txt_ThirdLevel_Validated);
            this.Txt_ThirdLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ThirdLevel_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(113, 160);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 436;
            this.labelControl2.Text = "Tên tiếng Anh";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 134);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 435;
            this.labelControl1.Text = "Cấp 3";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(453, 228);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Th&oát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(378, 228);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Edit.Location = new System.Drawing.Point(228, 228);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(153, 228);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(78, 228);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 5;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(3, 228);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Txt_EngName
            // 
            this.Txt_EngName.EnterMoveNextControl = true;
            this.Txt_EngName.Location = new System.Drawing.Point(186, 157);
            this.Txt_EngName.Name = "Txt_EngName";
            this.Txt_EngName.Size = new System.Drawing.Size(314, 20);
            this.Txt_EngName.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(114, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 443;
            this.labelControl4.Text = "Tên tiếng Việt";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 445;
            this.labelControl3.Text = "Cấp 1";
            // 
            // Lbl_FstLevelEName
            // 
            this.Lbl_FstLevelEName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_FstLevelEName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_FstLevelEName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_FstLevelEName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FstLevelEName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_FstLevelEName.Appearance.Options.UseBackColor = true;
            this.Lbl_FstLevelEName.Appearance.Options.UseBorderColor = true;
            this.Lbl_FstLevelEName.Appearance.Options.UseFont = true;
            this.Lbl_FstLevelEName.Appearance.Options.UseForeColor = true;
            this.Lbl_FstLevelEName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_FstLevelEName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_FstLevelEName.Location = new System.Drawing.Point(186, 37);
            this.Lbl_FstLevelEName.Name = "Lbl_FstLevelEName";
            this.Lbl_FstLevelEName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_FstLevelEName.Size = new System.Drawing.Size(314, 17);
            this.Lbl_FstLevelEName.TabIndex = 447;
            // 
            // Lbl_FstLevelName
            // 
            this.Lbl_FstLevelName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_FstLevelName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_FstLevelName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_FstLevelName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FstLevelName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_FstLevelName.Appearance.Options.UseBackColor = true;
            this.Lbl_FstLevelName.Appearance.Options.UseBorderColor = true;
            this.Lbl_FstLevelName.Appearance.Options.UseFont = true;
            this.Lbl_FstLevelName.Appearance.Options.UseForeColor = true;
            this.Lbl_FstLevelName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_FstLevelName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_FstLevelName.Location = new System.Drawing.Point(186, 12);
            this.Lbl_FstLevelName.Name = "Lbl_FstLevelName";
            this.Lbl_FstLevelName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_FstLevelName.Size = new System.Drawing.Size(314, 17);
            this.Lbl_FstLevelName.TabIndex = 446;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(114, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 449;
            this.labelControl5.Text = "Tên tiếng Việt";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(114, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 448;
            this.labelControl6.Text = "Tên tiếng Anh";
            // 
            // Lbl_FstLevel
            // 
            this.Lbl_FstLevel.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_FstLevel.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_FstLevel.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_FstLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FstLevel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_FstLevel.Appearance.Options.UseBackColor = true;
            this.Lbl_FstLevel.Appearance.Options.UseBorderColor = true;
            this.Lbl_FstLevel.Appearance.Options.UseFont = true;
            this.Lbl_FstLevel.Appearance.Options.UseForeColor = true;
            this.Lbl_FstLevel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_FstLevel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_FstLevel.Location = new System.Drawing.Point(49, 12);
            this.Lbl_FstLevel.Name = "Lbl_FstLevel";
            this.Lbl_FstLevel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_FstLevel.Size = new System.Drawing.Size(50, 17);
            this.Lbl_FstLevel.TabIndex = 450;
            this.Lbl_FstLevel.TextChanged += new System.EventHandler(this.Lbl_FstLevel_TextChanged);
            this.Lbl_FstLevel.Click += new System.EventHandler(this.Lbl_FstLevel_Click);
            // 
            // Lbl_SecondLevel
            // 
            this.Lbl_SecondLevel.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_SecondLevel.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_SecondLevel.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_SecondLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SecondLevel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_SecondLevel.Appearance.Options.UseBackColor = true;
            this.Lbl_SecondLevel.Appearance.Options.UseBorderColor = true;
            this.Lbl_SecondLevel.Appearance.Options.UseFont = true;
            this.Lbl_SecondLevel.Appearance.Options.UseForeColor = true;
            this.Lbl_SecondLevel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_SecondLevel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_SecondLevel.Location = new System.Drawing.Point(49, 71);
            this.Lbl_SecondLevel.Name = "Lbl_SecondLevel";
            this.Lbl_SecondLevel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_SecondLevel.Size = new System.Drawing.Size(50, 17);
            this.Lbl_SecondLevel.TabIndex = 456;
            this.Lbl_SecondLevel.TextChanged += new System.EventHandler(this.Lbl_SecondLevel_TextChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(114, 73);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(66, 13);
            this.labelControl9.TabIndex = 455;
            this.labelControl9.Text = "Tên tiếng Việt";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(114, 98);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(67, 13);
            this.labelControl10.TabIndex = 454;
            this.labelControl10.Text = "Tên tiếng Anh";
            // 
            // Lbl_SndLevelEName
            // 
            this.Lbl_SndLevelEName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_SndLevelEName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_SndLevelEName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_SndLevelEName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SndLevelEName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_SndLevelEName.Appearance.Options.UseBackColor = true;
            this.Lbl_SndLevelEName.Appearance.Options.UseBorderColor = true;
            this.Lbl_SndLevelEName.Appearance.Options.UseFont = true;
            this.Lbl_SndLevelEName.Appearance.Options.UseForeColor = true;
            this.Lbl_SndLevelEName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_SndLevelEName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_SndLevelEName.Location = new System.Drawing.Point(186, 96);
            this.Lbl_SndLevelEName.Name = "Lbl_SndLevelEName";
            this.Lbl_SndLevelEName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_SndLevelEName.Size = new System.Drawing.Size(314, 17);
            this.Lbl_SndLevelEName.TabIndex = 453;
            // 
            // Lbl_SndLevelName
            // 
            this.Lbl_SndLevelName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_SndLevelName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_SndLevelName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_SndLevelName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SndLevelName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_SndLevelName.Appearance.Options.UseBackColor = true;
            this.Lbl_SndLevelName.Appearance.Options.UseBorderColor = true;
            this.Lbl_SndLevelName.Appearance.Options.UseFont = true;
            this.Lbl_SndLevelName.Appearance.Options.UseForeColor = true;
            this.Lbl_SndLevelName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_SndLevelName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_SndLevelName.Location = new System.Drawing.Point(186, 71);
            this.Lbl_SndLevelName.Name = "Lbl_SndLevelName";
            this.Lbl_SndLevelName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_SndLevelName.Size = new System.Drawing.Size(314, 17);
            this.Lbl_SndLevelName.TabIndex = 452;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(15, 73);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(28, 13);
            this.labelControl13.TabIndex = 451;
            this.labelControl13.Text = "Cấp 2";
            // 
            // cmb_Negative
            // 
            this.cmb_Negative.Location = new System.Drawing.Point(113, 188);
            this.cmb_Negative.Name = "cmb_Negative";
            this.cmb_Negative.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Negative.Properties.Items.AddRange(new object[] {
            "Y | Tài khoản dư nợ, dư có",
            "N | Tài khoản chỉ dư nợ",
            "C | Tài khoản chỉ dư có"});
            this.cmb_Negative.Size = new System.Drawing.Size(197, 20);
            this.cmb_Negative.TabIndex = 457;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(15, 191);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(49, 13);
            this.labelControl14.TabIndex = 458;
            this.labelControl14.Text = "Loại số dư";
            // 
            // Txt_OtherEqui
            // 
            this.Txt_OtherEqui.EnterMoveNextControl = true;
            this.Txt_OtherEqui.Location = new System.Drawing.Point(418, 188);
            this.Txt_OtherEqui.Name = "Txt_OtherEqui";
            this.Txt_OtherEqui.Properties.Appearance.Options.UseFont = true;
            this.Txt_OtherEqui.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_OtherEqui.Properties.MaxLength = 4;
            this.Txt_OtherEqui.Size = new System.Drawing.Size(82, 20);
            this.Txt_OtherEqui.TabIndex = 459;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(347, 191);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(65, 13);
            this.labelControl15.TabIndex = 460;
            this.labelControl15.Text = "Tương đương";
            // 
            // FrmMap_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(531, 258);
            this.Controls.Add(this.Txt_OtherEqui);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.cmb_Negative);
            this.Controls.Add(this.Lbl_SecondLevel);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.Lbl_SndLevelEName);
            this.Controls.Add(this.Lbl_SndLevelName);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.Lbl_FstLevel);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Lbl_FstLevelEName);
            this.Controls.Add(this.Lbl_FstLevelName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Txt_EngName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.Txt_VnName);
            this.Controls.Add(this.Txt_ThirdLevel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMap_03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMap_03";
            this.Load += new System.EventHandler(this.FrmMap_03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VnName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ThirdLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_EngName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Negative.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OtherEqui.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        private ComboBoxEdit cmb_Negative;
        internal GroupBox GroupBox2;
        //private IContainer components;
        private LabelControl labelControl1;
        private LabelControl labelControl10;
        private LabelControl labelControl13;
        private LabelControl labelControl14;
        private LabelControl labelControl15;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private LabelControl labelControl9;
        internal LabelControl Lbl_FstLevel;
        internal LabelControl Lbl_FstLevelEName;
        internal LabelControl Lbl_FstLevelName;
        internal LabelControl Lbl_SecondLevel;
        internal LabelControl Lbl_SndLevelEName;
        internal LabelControl Lbl_SndLevelName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private TextEdit Txt_EngName;
        private TextEdit Txt_OtherEqui;
        private TextEdit Txt_ThirdLevel;
        private TextEdit Txt_VnName;

        #endregion

    }
}
