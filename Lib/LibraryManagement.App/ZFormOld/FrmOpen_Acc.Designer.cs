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
    partial class FrmOpen_Acc
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
            this.Txt_basic = new DevExpress.XtraEditors.TextEdit();
            this.Txt_ThirdLevel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Account = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_EngName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_VietName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ShortName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CustId = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_CustName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_basic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ThirdLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ShortName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CustId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroupBox2.Location = new System.Drawing.Point(-116, 175);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(762, 5);
            this.GroupBox2.TabIndex = 442;
            this.GroupBox2.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(303, 187);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "&Xóa";
            // 
            // Txt_basic
            // 
            this.Txt_basic.EnterMoveNextControl = true;
            this.Txt_basic.Location = new System.Drawing.Point(114, 71);
            this.Txt_basic.Name = "Txt_basic";
            this.Txt_basic.Properties.MaxLength = 4;
            this.Txt_basic.Size = new System.Drawing.Size(75, 20);
            this.Txt_basic.TabIndex = 2;
            this.Txt_basic.EditValueChanged += new System.EventHandler(this.Txt_basic_EditValueChanged);
            this.Txt_basic.Validated += new System.EventHandler(this.Txt_basic_Validated);
            // 
            // Txt_ThirdLevel
            // 
            this.Txt_ThirdLevel.EnterMoveNextControl = true;
            this.Txt_ThirdLevel.Location = new System.Drawing.Point(58, 11);
            this.Txt_ThirdLevel.Name = "Txt_ThirdLevel";
            this.Txt_ThirdLevel.Properties.Appearance.Options.UseFont = true;
            this.Txt_ThirdLevel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_ThirdLevel.Properties.MaxLength = 4;
            this.Txt_ThirdLevel.Size = new System.Drawing.Size(41, 20);
            this.Txt_ThirdLevel.TabIndex = 1;
            this.Txt_ThirdLevel.ToolTip = "Nhấn F2 để tìm kiếm";
            this.Txt_ThirdLevel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.Txt_ThirdLevel.ToolTipTitle = "Lưu ý";
            this.Txt_ThirdLevel.EditValueChanged += new System.EventHandler(this.Txt_ThirdLevel_EditValueChanged);
            this.Txt_ThirdLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ThirdLevel_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 436;
            this.labelControl2.Text = "Số tài khoản";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 435;
            this.labelControl1.Text = "Cấp 3";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(453, 187);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Th&oát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(378, 187);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Edit.Location = new System.Drawing.Point(228, 187);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(153, 187);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(78, 187);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 7;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(3, 187);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Txt_Account
            // 
            this.Txt_Account.EnterMoveNextControl = true;
            this.Txt_Account.Location = new System.Drawing.Point(114, 95);
            this.Txt_Account.Name = "Txt_Account";
            this.Txt_Account.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.Txt_Account.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Account.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_Account.Properties.Appearance.Options.UseFont = true;
            this.Txt_Account.Properties.Mask.EditMask = "####-#-####";
            this.Txt_Account.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.Txt_Account.Properties.Mask.PlaceHolder = ' ';
            this.Txt_Account.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_Account.Size = new System.Drawing.Size(137, 20);
            this.Txt_Account.TabIndex = 3;
            this.Txt_Account.EditValueChanged += new System.EventHandler(this.Txt_Account_EditValueChanged);
            this.Txt_Account.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Account_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 74);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 443;
            this.labelControl4.Text = "Số chi tiết";
            // 
            // Lbl_EngName
            // 
            this.Lbl_EngName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_EngName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_EngName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_EngName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EngName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_EngName.Appearance.Options.UseBackColor = true;
            this.Lbl_EngName.Appearance.Options.UseBorderColor = true;
            this.Lbl_EngName.Appearance.Options.UseFont = true;
            this.Lbl_EngName.Appearance.Options.UseForeColor = true;
            this.Lbl_EngName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_EngName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_EngName.Location = new System.Drawing.Point(186, 37);
            this.Lbl_EngName.Name = "Lbl_EngName";
            this.Lbl_EngName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_EngName.Size = new System.Drawing.Size(314, 17);
            this.Lbl_EngName.TabIndex = 447;
            // 
            // Lbl_VietName
            // 
            this.Lbl_VietName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_VietName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_VietName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_VietName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_VietName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_VietName.Appearance.Options.UseBackColor = true;
            this.Lbl_VietName.Appearance.Options.UseBorderColor = true;
            this.Lbl_VietName.Appearance.Options.UseFont = true;
            this.Lbl_VietName.Appearance.Options.UseForeColor = true;
            this.Lbl_VietName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_VietName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_VietName.Location = new System.Drawing.Point(186, 12);
            this.Lbl_VietName.Name = "Lbl_VietName";
            this.Lbl_VietName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_VietName.Size = new System.Drawing.Size(314, 17);
            this.Lbl_VietName.TabIndex = 446;
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
            // Txt_ShortName
            // 
            this.Txt_ShortName.EnterMoveNextControl = true;
            this.Txt_ShortName.Location = new System.Drawing.Point(114, 119);
            this.Txt_ShortName.Name = "Txt_ShortName";
            this.Txt_ShortName.Properties.Appearance.Options.UseFont = true;
            this.Txt_ShortName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_ShortName.Properties.MaxLength = 30;
            this.Txt_ShortName.Size = new System.Drawing.Size(215, 20);
            this.Txt_ShortName.TabIndex = 4;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(24, 122);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(56, 13);
            this.labelControl15.TabIndex = 460;
            this.labelControl15.Text = "Tên viết tắt";
            // 
            // Txt_Name
            // 
            this.Txt_Name.EnterMoveNextControl = true;
            this.Txt_Name.Location = new System.Drawing.Point(114, 144);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Properties.Appearance.Options.UseFont = true;
            this.Txt_Name.Size = new System.Drawing.Size(386, 20);
            this.Txt_Name.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 147);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 462;
            this.labelControl3.Text = "Tên đầy đủ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(319, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 13);
            this.labelControl7.TabIndex = 464;
            this.labelControl7.Text = "Mã số khách hàng";
            // 
            // Txt_CustId
            // 
            this.Txt_CustId.EnterMoveNextControl = true;
            this.Txt_CustId.Location = new System.Drawing.Point(425, 71);
            this.Txt_CustId.Name = "Txt_CustId";
            this.Txt_CustId.Properties.MaxLength = 5;
            this.Txt_CustId.Size = new System.Drawing.Size(75, 20);
            this.Txt_CustId.TabIndex = 3;
            this.Txt_CustId.ToolTip = "Nhấn F2 để tìm kiếm";
            this.Txt_CustId.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.Txt_CustId.ToolTipTitle = "Lưu ý";
            this.Txt_CustId.EditValueChanged += new System.EventHandler(this.Txt_CustId_EditValueChanged);
            this.Txt_CustId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_CustId_KeyDown);
            // 
            // Lbl_CustName
            // 
            this.Lbl_CustName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_CustName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_CustName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_CustName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CustName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_CustName.Appearance.Options.UseBackColor = true;
            this.Lbl_CustName.Appearance.Options.UseBorderColor = true;
            this.Lbl_CustName.Appearance.Options.UseFont = true;
            this.Lbl_CustName.Appearance.Options.UseForeColor = true;
            this.Lbl_CustName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_CustName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_CustName.Location = new System.Drawing.Point(257, 98);
            this.Lbl_CustName.Name = "Lbl_CustName";
            this.Lbl_CustName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_CustName.Size = new System.Drawing.Size(243, 17);
            this.Lbl_CustName.TabIndex = 465;
            // 
            // FrmOpen_Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(531, 217);
            this.Controls.Add(this.Lbl_CustName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.Txt_CustId);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Txt_ShortName);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Lbl_EngName);
            this.Controls.Add(this.Lbl_VietName);
            this.Controls.Add(this.Txt_Account);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.Txt_basic);
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
            this.Name = "FrmOpen_Acc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOpen_Acc";
            this.Load += new System.EventHandler(this.FrmOpen_Acc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_basic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ThirdLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ShortName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CustId.Properties)).EndInit();
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
        internal GroupBox GroupBox2;
        //private IContainer components;
        private LabelControl labelControl1;
        private LabelControl labelControl15;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        private LabelControl labelControl7;
        internal LabelControl Lbl_CustName;
        internal LabelControl Lbl_EngName;
        internal LabelControl Lbl_VietName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private TextEdit Txt_Account;
        private TextEdit Txt_basic;
        private TextEdit Txt_CustId;
        private TextEdit Txt_Name;
        private TextEdit Txt_ShortName;
        private TextEdit Txt_ThirdLevel;

        #endregion

    }
}
