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
    partial class FrmMap_02
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
            this.Txt_SecondLevel = new DevExpress.XtraEditors.TextEdit();
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
            this.Lbl_FirstLevel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VnName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SecondLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_EngName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroupBox2.Location = new System.Drawing.Point(-116, 127);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(762, 5);
            this.GroupBox2.TabIndex = 442;
            this.GroupBox2.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(303, 139);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "&Xóa";
            // 
            // Txt_VnName
            // 
            this.Txt_VnName.EnterMoveNextControl = true;
            this.Txt_VnName.Location = new System.Drawing.Point(186, 70);
            this.Txt_VnName.Name = "Txt_VnName";
            this.Txt_VnName.Size = new System.Drawing.Size(314, 20);
            this.Txt_VnName.TabIndex = 2;
            // 
            // Txt_SecondLevel
            // 
            this.Txt_SecondLevel.EnterMoveNextControl = true;
            this.Txt_SecondLevel.Location = new System.Drawing.Point(49, 70);
            this.Txt_SecondLevel.Name = "Txt_SecondLevel";
            this.Txt_SecondLevel.Properties.Appearance.Options.UseFont = true;
            this.Txt_SecondLevel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_SecondLevel.Properties.MaxLength = 3;
            this.Txt_SecondLevel.Size = new System.Drawing.Size(41, 20);
            this.Txt_SecondLevel.TabIndex = 1;
            this.Txt_SecondLevel.ToolTip = "Nhấn F2 để tìm kiếm";
            this.Txt_SecondLevel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.Txt_SecondLevel.ToolTipTitle = "Lưu ý";
            this.Txt_SecondLevel.EditValueChanged += new System.EventHandler(this.Txt_SecondLevel_EditValueChanged);
            this.Txt_SecondLevel.Validated += new System.EventHandler(this.Txt_SecondLevel_Validated);
            this.Txt_SecondLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SecondLevel_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(113, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 436;
            this.labelControl2.Text = "Tên tiếng Anh";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 435;
            this.labelControl1.Text = "Cấp 2";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(453, 139);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Th&oát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(378, 139);
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
            this.btn_Edit.Location = new System.Drawing.Point(228, 139);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(153, 139);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(78, 139);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 5;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(3, 139);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Txt_EngName
            // 
            this.Txt_EngName.EnterMoveNextControl = true;
            this.Txt_EngName.Location = new System.Drawing.Point(186, 96);
            this.Txt_EngName.Name = "Txt_EngName";
            this.Txt_EngName.Size = new System.Drawing.Size(314, 20);
            this.Txt_EngName.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(114, 73);
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
            // Lbl_FirstLevel
            // 
            this.Lbl_FirstLevel.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_FirstLevel.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_FirstLevel.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_FirstLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FirstLevel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_FirstLevel.Appearance.Options.UseBackColor = true;
            this.Lbl_FirstLevel.Appearance.Options.UseBorderColor = true;
            this.Lbl_FirstLevel.Appearance.Options.UseFont = true;
            this.Lbl_FirstLevel.Appearance.Options.UseForeColor = true;
            this.Lbl_FirstLevel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_FirstLevel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_FirstLevel.Location = new System.Drawing.Point(49, 12);
            this.Lbl_FirstLevel.Name = "Lbl_FirstLevel";
            this.Lbl_FirstLevel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_FirstLevel.Size = new System.Drawing.Size(41, 17);
            this.Lbl_FirstLevel.TabIndex = 450;
            this.Lbl_FirstLevel.TextChanged += new System.EventHandler(this.Lbl_FirstLevel_TextChanged);
            // 
            // FrmMap_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(531, 169);
            this.Controls.Add(this.Lbl_FirstLevel);
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
            this.Controls.Add(this.Txt_SecondLevel);
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
            this.Name = "FrmMap_02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMap_02";
            this.Load += new System.EventHandler(this.FrmMap_02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VnName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SecondLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_EngName.Properties)).EndInit();
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
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl4;
        private LabelControl labelControl5;
        private LabelControl labelControl6;
        internal LabelControl Lbl_FirstLevel;
        internal LabelControl Lbl_FstLevelEName;
        internal LabelControl Lbl_FstLevelName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private TextEdit Txt_EngName;
        private TextEdit Txt_SecondLevel;
        private TextEdit Txt_VnName;


        #endregion

    }
}
