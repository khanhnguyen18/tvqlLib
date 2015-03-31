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
    partial class FrmStations
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
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.Txt_StationName = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Description = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_StationList = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Status = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_Stock = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Lbl_Stock = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_PrnPorts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Chk_Printer = new DevExpress.XtraEditors.CheckEdit();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_StationList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Stock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_PrnPorts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_Printer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(305, 181);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(-113, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 397;
            this.groupBox1.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(455, 181);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(380, 181);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(230, 181);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(155, 181);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Tạ&o";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(80, 181);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 6;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.RrqIxZxw5);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(5, 181);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Txt_Id
            // 
            this.Txt_Id.EnterMoveNextControl = true;
            this.Txt_Id.Location = new System.Drawing.Point(161, 44);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id.Properties.Appearance.Options.UseFont = true;
            this.Txt_Id.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_Id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_Id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_Id.Size = new System.Drawing.Size(77, 20);
            this.Txt_Id.TabIndex = 10;
            // 
            // Txt_StationName
            // 
            this.Txt_StationName.EnterMoveNextControl = true;
            this.Txt_StationName.Location = new System.Drawing.Point(161, 67);
            this.Txt_StationName.Name = "Txt_StationName";
            this.Txt_StationName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_StationName.Properties.Appearance.Options.UseFont = true;
            this.Txt_StationName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_StationName.Size = new System.Drawing.Size(347, 20);
            this.Txt_StationName.TabIndex = 1;
            // 
            // Txt_Description
            // 
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new System.Drawing.Point(161, 90);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Description.Properties.Appearance.Options.UseFont = true;
            this.Txt_Description.Size = new System.Drawing.Size(347, 20);
            this.Txt_Description.TabIndex = 2;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(51, 47);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(28, 13);
            this.LabelControl5.TabIndex = 406;
            this.LabelControl5.Text = "Mã số";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(51, 70);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(43, 13);
            this.LabelControl2.TabIndex = 403;
            this.LabelControl2.Text = "Tên trạm";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(51, 93);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(40, 13);
            this.LabelControl3.TabIndex = 404;
            this.LabelControl3.Text = "Diễn giải";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(51, 11);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(68, 13);
            this.LabelControl1.TabIndex = 409;
            this.LabelControl1.Text = "Trạm máy tính";
            // 
            // Cmb_StationList
            // 
            this.Cmb_StationList.EnterMoveNextControl = true;
            this.Cmb_StationList.Location = new System.Drawing.Point(161, 8);
            this.Cmb_StationList.Name = "Cmb_StationList";
            this.Cmb_StationList.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_StationList.Properties.Appearance.Options.UseFont = true;
            this.Cmb_StationList.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_StationList.Properties.AppearanceDropDown.Options.UseFont = true;
            this.Cmb_StationList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_StationList.Size = new System.Drawing.Size(347, 20);
            this.Cmb_StationList.TabIndex = 9;
            this.Cmb_StationList.SelectedIndexChanged += new System.EventHandler(this.Cmb_StationList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-86, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 5);
            this.groupBox2.TabIndex = 410;
            this.groupBox2.TabStop = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(311, 47);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 412;
            this.labelControl4.Text = "Trạng thái";
            // 
            // Txt_Status
            // 
            this.Txt_Status.EnterMoveNextControl = true;
            this.Txt_Status.Location = new System.Drawing.Point(384, 44);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new System.Drawing.Size(124, 20);
            this.Txt_Status.TabIndex = 411;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(51, 139);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 13);
            this.labelControl6.TabIndex = 414;
            this.labelControl6.Text = "Thuộc thư viện";
            // 
            // Cmb_Stock
            // 
            this.Cmb_Stock.EnterMoveNextControl = true;
            this.Cmb_Stock.Location = new System.Drawing.Point(161, 136);
            this.Cmb_Stock.Name = "Cmb_Stock";
            this.Cmb_Stock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Stock.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Stock.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Stock.Properties.AppearanceDropDown.Options.UseFont = true;
            this.Cmb_Stock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_Stock.Size = new System.Drawing.Size(77, 20);
            this.Cmb_Stock.TabIndex = 4;
            this.Cmb_Stock.SelectedIndexChanged += new System.EventHandler(this.Cmb_Stock_SelectedIndexChanged);
            this.Cmb_Stock.TextChanged += new System.EventHandler(this.Cmb_Stock_TextChanged);
            // 
            // Lbl_Stock
            // 
            this.Lbl_Stock.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_Stock.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_Stock.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_Stock.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Stock.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Stock.Appearance.Options.UseBackColor = true;
            this.Lbl_Stock.Appearance.Options.UseBorderColor = true;
            this.Lbl_Stock.Appearance.Options.UseFont = true;
            this.Lbl_Stock.Appearance.Options.UseForeColor = true;
            this.Lbl_Stock.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_Stock.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_Stock.Location = new System.Drawing.Point(244, 137);
            this.Lbl_Stock.Name = "Lbl_Stock";
            this.Lbl_Stock.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Lbl_Stock.Size = new System.Drawing.Size(264, 17);
            this.Lbl_Stock.TabIndex = 415;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(51, 116);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 13);
            this.labelControl7.TabIndex = 417;
            this.labelControl7.Text = "Cổng máy in";
            // 
            // Cmb_PrnPorts
            // 
            this.Cmb_PrnPorts.EnterMoveNextControl = true;
            this.Cmb_PrnPorts.Location = new System.Drawing.Point(161, 113);
            this.Cmb_PrnPorts.Name = "Cmb_PrnPorts";
            this.Cmb_PrnPorts.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_PrnPorts.Properties.Appearance.Options.UseFont = true;
            this.Cmb_PrnPorts.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_PrnPorts.Properties.AppearanceDropDown.Options.UseFont = true;
            this.Cmb_PrnPorts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_PrnPorts.Properties.Items.AddRange(new object[] {
            "LPT1",
            "USB"});
            this.Cmb_PrnPorts.Size = new System.Drawing.Size(77, 20);
            this.Cmb_PrnPorts.TabIndex = 3;
            // 
            // Chk_Printer
            // 
            this.Chk_Printer.Location = new System.Drawing.Point(244, 116);
            this.Chk_Printer.Name = "Chk_Printer";
            this.Chk_Printer.Properties.Caption = "Sử dụng máy in mặc định của Windows";
            this.Chk_Printer.Size = new System.Drawing.Size(224, 18);
            this.Chk_Printer.TabIndex = 418;
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 200;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // FrmStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 216);
            this.Controls.Add(this.Chk_Printer);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.Cmb_PrnPorts);
            this.Controls.Add(this.Lbl_Stock);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Cmb_Stock);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.Txt_Status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.Cmb_StationList);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Txt_StationName);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.LabelControl5);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStations";
            this.Load += new System.EventHandler(this.FrmStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_StationList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Stock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_PrnPorts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_Printer.Properties)).EndInit();
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
        private CheckEdit Chk_Printer;
        internal ComboBoxEdit Cmb_PrnPorts;
        internal ComboBoxEdit Cmb_StationList;
        internal ComboBoxEdit Cmb_Stock;
        internal GroupBox groupBox1;
        internal GroupBox groupBox2;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl3;
        internal LabelControl labelControl4;
        internal LabelControl LabelControl5;
        internal LabelControl labelControl6;
        internal LabelControl labelControl7;
        internal LabelControl Lbl_Stock;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private string string_1;
        private Timer timer_0;
        internal TextEdit Txt_Description;
        internal TextEdit Txt_Id;
        internal TextEdit Txt_StationName;
        internal TextEdit Txt_Status;

        #endregion

    }
}
