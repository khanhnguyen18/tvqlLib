using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmPtrDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPtrDelete));
            this.Lbl_Date = new DevExpress.XtraEditors.LabelControl();
            this.Txt_TransNum = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.GrdTran = new DevExpress.XtraGrid.GridControl();
            this.TransDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_TransName = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_TransCode = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_PosId = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_PosName = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Lbl_UserName = new DevExpress.XtraEditors.LabelControl();
            this.Cmb_Type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Type.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Date.Appearance.Options.UseFont = true;
            this.Lbl_Date.Location = new System.Drawing.Point(275, 15);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Date.TabIndex = 381;
            this.Lbl_Date.Text = "01/01/2008";
            // 
            // Txt_TransNum
            // 
            this.Txt_TransNum.EnterMoveNextControl = true;
            this.Txt_TransNum.Location = new System.Drawing.Point(110, 12);
            this.Txt_TransNum.Name = "Txt_TransNum";
            this.Txt_TransNum.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.Txt_TransNum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransNum.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_TransNum.Properties.Appearance.Options.UseFont = true;
            this.Txt_TransNum.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_TransNum.Properties.Mask.PlaceHolder = ' ';
            this.Txt_TransNum.Properties.MaxLength = 12;
            this.Txt_TransNum.Properties.ValidateOnEnterKey = true;
            this.Txt_TransNum.Size = new System.Drawing.Size(104, 20);
            this.Txt_TransNum.TabIndex = 2;
            this.Txt_TransNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_TransNum_KeyDown);
            // 
            // LabelControl9
            // 
            this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl9.Appearance.Options.UseFont = true;
            this.LabelControl9.Location = new System.Drawing.Point(15, 15);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(67, 13);
            this.LabelControl9.TabIndex = 378;
            this.LabelControl9.Text = "Số giao dịch";
            // 
            // LabelControl18
            // 
            this.LabelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Location = new System.Drawing.Point(231, 15);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(34, 13);
            this.LabelControl18.TabIndex = 379;
            this.LabelControl18.Text = "Ngày :";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(-16, 35);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(704, 5);
            this.GroupBox4.TabIndex = 385;
            this.GroupBox4.TabStop = false;
            // 
            // GrdTran
            // 
            this.GrdTran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTran.Location = new System.Drawing.Point(15, 91);
            this.GrdTran.MainView = this.TransDetail;
            this.GrdTran.Name = "GrdTran";
            this.GrdTran.Size = new System.Drawing.Size(645, 277);
            this.GrdTran.TabIndex = 395;
            this.GrdTran.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TransDetail});
            // 
            // TransDetail
            // 
            this.TransDetail.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransDetail.Appearance.FooterPanel.Options.UseFont = true;
            this.TransDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransDetail.Appearance.HeaderPanel.Options.UseFont = true;
            this.TransDetail.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransDetail.Appearance.Row.Options.UseFont = true;
            this.TransDetail.GridControl = this.GrdTran;
            this.TransDetail.Name = "TransDetail";
            this.TransDetail.OptionsView.ShowFooter = true;
            this.TransDetail.OptionsView.ShowGroupPanel = false;
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "FrmPtrDelete_16_0.png");
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(450, 385);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 23);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(240, 385);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(88, 23);
            this.btn_Skip.TabIndex = 4;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-60, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 5);
            this.groupBox1.TabIndex = 406;
            this.groupBox1.TabStop = false;
            // 
            // Lbl_TransName
            // 
            this.Lbl_TransName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_TransName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_TransName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_TransName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TransName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TransName.Appearance.Options.UseBackColor = true;
            this.Lbl_TransName.Appearance.Options.UseBorderColor = true;
            this.Lbl_TransName.Appearance.Options.UseFont = true;
            this.Lbl_TransName.Appearance.Options.UseForeColor = true;
            this.Lbl_TransName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_TransName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_TransName.Location = new System.Drawing.Point(221, 46);
            this.Lbl_TransName.Name = "Lbl_TransName";
            this.Lbl_TransName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_TransName.Size = new System.Drawing.Size(197, 17);
            this.Lbl_TransName.TabIndex = 412;
            // 
            // Lbl_TransCode
            // 
            this.Lbl_TransCode.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_TransCode.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_TransCode.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_TransCode.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TransCode.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_TransCode.Appearance.Options.UseBackColor = true;
            this.Lbl_TransCode.Appearance.Options.UseBorderColor = true;
            this.Lbl_TransCode.Appearance.Options.UseFont = true;
            this.Lbl_TransCode.Appearance.Options.UseForeColor = true;
            this.Lbl_TransCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_TransCode.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_TransCode.Location = new System.Drawing.Point(121, 46);
            this.Lbl_TransCode.Name = "Lbl_TransCode";
            this.Lbl_TransCode.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_TransCode.Size = new System.Drawing.Size(90, 17);
            this.Lbl_TransCode.TabIndex = 411;
            this.Lbl_TransCode.TabStopChanged += new System.EventHandler(this.Lbl_TransCode_TabStopChanged);
            // 
            // Lbl_PosId
            // 
            this.Lbl_PosId.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_PosId.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_PosId.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_PosId.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PosId.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_PosId.Appearance.Options.UseBackColor = true;
            this.Lbl_PosId.Appearance.Options.UseBorderColor = true;
            this.Lbl_PosId.Appearance.Options.UseFont = true;
            this.Lbl_PosId.Appearance.Options.UseForeColor = true;
            this.Lbl_PosId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_PosId.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_PosId.Location = new System.Drawing.Point(121, 68);
            this.Lbl_PosId.Name = "Lbl_PosId";
            this.Lbl_PosId.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_PosId.Size = new System.Drawing.Size(90, 17);
            this.Lbl_PosId.TabIndex = 410;
            this.Lbl_PosId.TextChanged += new System.EventHandler(this.Lbl_PosId_TextChanged);
            // 
            // Lbl_PosName
            // 
            this.Lbl_PosName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_PosName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_PosName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_PosName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PosName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_PosName.Appearance.Options.UseBackColor = true;
            this.Lbl_PosName.Appearance.Options.UseBorderColor = true;
            this.Lbl_PosName.Appearance.Options.UseFont = true;
            this.Lbl_PosName.Appearance.Options.UseForeColor = true;
            this.Lbl_PosName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_PosName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_PosName.Location = new System.Drawing.Point(221, 68);
            this.Lbl_PosName.Name = "Lbl_PosName";
            this.Lbl_PosName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_PosName.Size = new System.Drawing.Size(197, 17);
            this.Lbl_PosName.TabIndex = 409;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(34, 46);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(36, 13);
            this.LabelControl4.TabIndex = 408;
            this.LabelControl4.Text = "Loại GD";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(34, 69);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(63, 13);
            this.LabelControl3.TabIndex = 407;
            this.LabelControl3.Text = "Nơi bán hàng";
            // 
            // LabelControl6
            // 
            this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl6.Appearance.Options.UseFont = true;
            this.LabelControl6.Location = new System.Drawing.Point(449, 47);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(48, 13);
            this.LabelControl6.TabIndex = 414;
            this.LabelControl6.Text = "Nhân viên";
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Lbl_UserName.Appearance.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.Lbl_UserName.Appearance.BorderColor = System.Drawing.Color.White;
            this.Lbl_UserName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Lbl_UserName.Appearance.Options.UseBackColor = true;
            this.Lbl_UserName.Appearance.Options.UseBorderColor = true;
            this.Lbl_UserName.Appearance.Options.UseFont = true;
            this.Lbl_UserName.Appearance.Options.UseForeColor = true;
            this.Lbl_UserName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.Lbl_UserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Lbl_UserName.Location = new System.Drawing.Point(511, 46);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_UserName.Size = new System.Drawing.Size(149, 17);
            this.Lbl_UserName.TabIndex = 413;
            // 
            // Cmb_Type
            // 
            this.Cmb_Type.EnterMoveNextControl = true;
            this.Cmb_Type.Location = new System.Drawing.Point(472, 8);
            this.Cmb_Type.Name = "Cmb_Type";
            this.Cmb_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Type.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_Type.Properties.Items.AddRange(new object[] {
            "Giao dịch bị hoãn trong ngày",
            "Giao dịch bán lẻ trong ngày"});
            this.Cmb_Type.Size = new System.Drawing.Size(188, 20);
            this.Cmb_Type.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(135, 385);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 23);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(345, 385);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(88, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 200;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // FrmPtrDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 416);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.Cmb_Type);
            this.Controls.Add(this.LabelControl6);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.Lbl_TransName);
            this.Controls.Add(this.Lbl_TransCode);
            this.Controls.Add(this.Lbl_PosId);
            this.Controls.Add(this.Lbl_PosName);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.GrdTran);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Txt_TransNum);
            this.Controls.Add(this.LabelControl9);
            this.Controls.Add(this.LabelControl18);
            this.Name = "FrmPtrDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPtrDelete";
            this.Load += new System.EventHandler(this.FrmPtrDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Type.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Delete;
        private SimpleButton btn_Exit;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal ComboBoxEdit Cmb_Type;
        internal GridControl GrdTran;
        internal GroupBox groupBox1;
        internal GroupBox GroupBox4;
        //private IContainer components;
        private string IipWvDcZu;
        private ImageList imageList_0;
        internal LabelControl LabelControl18;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl6;
        internal LabelControl LabelControl9;
        internal LabelControl Lbl_Date;
        internal LabelControl Lbl_PosId;
        internal LabelControl Lbl_PosName;
        internal LabelControl Lbl_TransCode;
        internal LabelControl Lbl_TransName;
        internal LabelControl Lbl_UserName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private Timer timer_0;
        internal GridView TransDetail;
        internal TextEdit Txt_TransNum;


        #endregion

    }
}
