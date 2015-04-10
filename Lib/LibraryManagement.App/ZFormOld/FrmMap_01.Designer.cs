using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmMap_01
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
            this.Txt_FirstLevel = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VnName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FirstLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_EngName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroupBox2.Location = new System.Drawing.Point(-116, 84);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(762, 5);
            this.GroupBox2.TabIndex = 442;
            this.GroupBox2.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(303, 96);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "&Xóa";
            // 
            // Txt_VnName
            // 
            this.Txt_VnName.EnterMoveNextControl = true;
            this.Txt_VnName.Location = new System.Drawing.Point(204, 22);
            this.Txt_VnName.Name = "Txt_VnName";
            this.Txt_VnName.Size = new System.Drawing.Size(295, 20);
            this.Txt_VnName.TabIndex = 2;
            // 
            // Txt_FirstLevel
            // 
            this.Txt_FirstLevel.EnterMoveNextControl = true;
            this.Txt_FirstLevel.Location = new System.Drawing.Point(57, 22);
            this.Txt_FirstLevel.Name = "Txt_FirstLevel";
            this.Txt_FirstLevel.Properties.Appearance.Options.UseFont = true;
            this.Txt_FirstLevel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_FirstLevel.Properties.MaxLength = 1;
            this.Txt_FirstLevel.Size = new System.Drawing.Size(36, 20);
            this.Txt_FirstLevel.TabIndex = 1;
            this.Txt_FirstLevel.ToolTip = "Nhấn F2 để tìm kiếm";
            this.Txt_FirstLevel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.Txt_FirstLevel.ToolTipTitle = "Lưu ý";
            this.Txt_FirstLevel.EditValueChanged += new System.EventHandler(this.Txt_FirstLevel_EditValueChanged);
            this.Txt_FirstLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_FirstLevel_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(115, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 436;
            this.labelControl2.Text = "Tên tiếng Anh";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 435;
            this.labelControl1.Text = "Cấp 1";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(453, 96);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Th&oát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(378, 96);
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
            this.btn_Edit.Location = new System.Drawing.Point(228, 96);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 6;
            this.btn_Edit.Text = "&Sửa";
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(153, 96);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(78, 96);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 5;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(3, 96);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Txt_EngName
            // 
            this.Txt_EngName.EnterMoveNextControl = true;
            this.Txt_EngName.Location = new System.Drawing.Point(204, 48);
            this.Txt_EngName.Name = "Txt_EngName";
            this.Txt_EngName.Size = new System.Drawing.Size(295, 20);
            this.Txt_EngName.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(115, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 443;
            this.labelControl4.Text = "Tên tiếng Việt";
            // 
            // FrmMap_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(530, 126);
            this.Controls.Add(this.Txt_EngName);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.Txt_VnName);
            this.Controls.Add(this.Txt_FirstLevel);
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
            this.Name = "FrmMap_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMap_01";
            this.Load += new System.EventHandler(this.FrmMap_01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VnName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FirstLevel.Properties)).EndInit();
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
        private LabelControl labelControl4;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private TextEdit Txt_EngName;
        private TextEdit Txt_FirstLevel;
        private TextEdit Txt_VnName;

        #endregion

    }
}
