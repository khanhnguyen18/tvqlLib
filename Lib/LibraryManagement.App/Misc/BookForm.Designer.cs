using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Skip = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtRtPrice = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Status = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtGoodsid = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog_0 = new System.Windows.Forms.OpenFileDialog();
            this.timer_0 = new System.Windows.Forms.Timer(this.components);
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cmbGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtAuthor = new DevExpress.XtraEditors.TextEdit();
            this.CdCbuygdy = new DevExpress.XtraEditors.TextEdit();
            this.txtPublish = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtWeight = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumOfPage = new DevExpress.XtraEditors.TextEdit();
            this.txtDimension = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cmbYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbForm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddGrp = new DevExpress.XtraEditors.SimpleButton();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.cmbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnUnit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUnit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnFormType = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtIntro = new DevExpress.XtraEditors.MemoEdit();
            this.Txt_OpenDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodsid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CdCbuygdy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOfPage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDimension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnit.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OpenDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OpenDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(43, 360);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Skip
            // 
            this.btn_Skip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Skip.Location = new System.Drawing.Point(118, 360);
            this.btn_Skip.Name = "btn_Skip";
            this.btn_Skip.Size = new System.Drawing.Size(75, 23);
            this.btn_Skip.TabIndex = 18;
            this.btn_Skip.Text = "&Bỏ qua";
            this.btn_Skip.Click += new System.EventHandler(this.btn_Skip_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_New.Location = new System.Drawing.Point(193, 360);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "&Tạo";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Edit.Location = new System.Drawing.Point(268, 360);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 19;
            this.btn_Edit.Text = "&Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Search.Location = new System.Drawing.Point(418, 360);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "Tì&m";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(493, 360);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 22;
            this.btn_Exit.Text = "Th&oát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Appearance.Options.UseFont = true;
            this.btnChoose.Location = new System.Drawing.Point(474, 229);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(73, 19);
            this.btnChoose.TabIndex = 17;
            this.btnChoose.TabStop = false;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.EditValue = "1234567890123456";
            this.txtBarcode.EnterMoveNextControl = true;
            this.txtBarcode.Location = new System.Drawing.Point(274, 105);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtBarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Properties.Appearance.Options.UseBackColor = true;
            this.txtBarcode.Properties.Appearance.Options.UseFont = true;
            this.txtBarcode.Size = new System.Drawing.Size(103, 20);
            this.txtBarcode.TabIndex = 5;
            // 
            // LabelControl11
            // 
            this.LabelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl11.Appearance.Options.UseFont = true;
            this.LabelControl11.Location = new System.Drawing.Point(245, 110);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(23, 13);
            this.LabelControl11.TabIndex = 365;
            this.LabelControl11.Text = "ISBN";
            // 
            // LabelControl12
            // 
            this.LabelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl12.Appearance.Options.UseFont = true;
            this.LabelControl12.Location = new System.Drawing.Point(428, 231);
            this.LabelControl12.Name = "LabelControl12";
            this.LabelControl12.Size = new System.Drawing.Size(36, 13);
            this.LabelControl12.TabIndex = 369;
            this.LabelControl12.Text = "Ảnh bìa";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl7.Appearance.Options.UseFont = true;
            this.LabelControl7.Location = new System.Drawing.Point(29, 108);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(32, 13);
            this.LabelControl7.TabIndex = 356;
            this.LabelControl7.Text = "Giá bìa";
            // 
            // txtRtPrice
            // 
            this.txtRtPrice.EditValue = "";
            this.txtRtPrice.EnterMoveNextControl = true;
            this.txtRtPrice.Location = new System.Drawing.Point(120, 105);
            this.txtRtPrice.Name = "txtRtPrice";
            this.txtRtPrice.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtRtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtRtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtRtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRtPrice.Properties.DisplayFormat.FormatString = "n0";
            this.txtRtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRtPrice.Properties.EditFormat.FormatString = "n0";
            this.txtRtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRtPrice.Properties.Mask.EditMask = "n0";
            this.txtRtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRtPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtRtPrice.Size = new System.Drawing.Size(88, 20);
            this.txtRtPrice.TabIndex = 4;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(29, 204);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(67, 13);
            this.LabelControl5.TabIndex = 354;
            this.LabelControl5.Text = "Năm xuất bản";
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(29, 13);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(34, 13);
            this.LabelControl4.TabIndex = 353;
            this.LabelControl4.Text = "Tác giả";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(29, 37);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(37, 13);
            this.LabelControl3.TabIndex = 352;
            this.LabelControl3.Text = "Dịch giả";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(338, 15);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(49, 13);
            this.LabelControl2.TabIndex = 351;
            this.LabelControl2.Text = "Trạng thái";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(25, 15);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(61, 13);
            this.LabelControl1.TabIndex = 350;
            this.LabelControl1.Text = "Mã quản lý";
            // 
            // Txt_Status
            // 
            this.Txt_Status.EnterMoveNextControl = true;
            this.Txt_Status.Location = new System.Drawing.Point(402, 12);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Status.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Status.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_Status.Properties.Appearance.Options.UseFont = true;
            this.Txt_Status.Size = new System.Drawing.Size(159, 20);
            this.Txt_Status.TabIndex = 349;
            // 
            // LabelControl14
            // 
            this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new System.Drawing.Point(25, 38);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(43, 13);
            this.LabelControl14.TabIndex = 347;
            this.LabelControl14.Text = "Tên sách";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Location = new System.Drawing.Point(119, 35);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.MaxLength = 200;
            this.txtName.Size = new System.Drawing.Size(340, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtGoodsid
            // 
            this.txtGoodsid.EnterMoveNextControl = true;
            this.txtGoodsid.Location = new System.Drawing.Point(119, 12);
            this.txtGoodsid.Name = "txtGoodsid";
            this.txtGoodsid.Properties.Appearance.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtGoodsid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsid.Properties.Appearance.Options.UseBackColor = true;
            this.txtGoodsid.Properties.Appearance.Options.UseFont = true;
            this.txtGoodsid.Properties.Mask.PlaceHolder = ' ';
            this.txtGoodsid.Properties.MaxLength = 20;
            this.txtGoodsid.Properties.ValidateOnEnterKey = true;
            this.txtGoodsid.Size = new System.Drawing.Size(123, 20);
            this.txtGoodsid.TabIndex = 343;
            this.txtGoodsid.ToolTip = "Ấn F2 để tìm kiếm";
            this.txtGoodsid.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.txtGoodsid.ToolTipTitle = "Lưu ý";
            this.txtGoodsid.EditValueChanged += new System.EventHandler(this.txtGoodsid_EditValueChanged);
            this.txtGoodsid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoodsid_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-84, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 5);
            this.groupBox1.TabIndex = 382;
            this.groupBox1.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Delete.Location = new System.Drawing.Point(343, 360);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "&Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // openFileDialog_0
            // 
            this.openFileDialog_0.FileName = "*.jpg";
            this.openFileDialog_0.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_0_FileOk);
            // 
            // timer_0
            // 
            this.timer_0.Enabled = true;
            this.timer_0.Tick += new System.EventHandler(this.timer_0_Tick);
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(274, 132);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(41, 13);
            this.labelControl20.TabIndex = 387;
            this.labelControl20.Text = "Số trang";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(29, 132);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 393;
            this.labelControl8.Text = "Ngôn ngữ";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.EnterMoveNextControl = true;
            this.cmbLanguage.Location = new System.Drawing.Point(120, 129);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmbLanguage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguage.Properties.Appearance.Options.UseBackColor = true;
            this.cmbLanguage.Properties.Appearance.Options.UseFont = true;
            this.cmbLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLanguage.Properties.MaxLength = 3;
            this.cmbLanguage.Size = new System.Drawing.Size(137, 20);
            this.cmbLanguage.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(29, 155);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 13);
            this.labelControl9.TabIndex = 395;
            this.labelControl9.Text = "Thể loại";
            // 
            // cmbGroup
            // 
            this.cmbGroup.EnterMoveNextControl = true;
            this.cmbGroup.Location = new System.Drawing.Point(120, 154);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmbGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.Properties.Appearance.Options.UseBackColor = true;
            this.cmbGroup.Properties.Appearance.Options.UseFont = true;
            this.cmbGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGroup.Properties.MaxLength = 3;
            this.cmbGroup.Size = new System.Drawing.Size(228, 20);
            this.cmbGroup.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.EnterMoveNextControl = true;
            this.txtAuthor.Location = new System.Drawing.Point(120, 10);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtAuthor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Properties.Appearance.Options.UseBackColor = true;
            this.txtAuthor.Properties.Appearance.Options.UseFont = true;
            this.txtAuthor.Properties.MaxLength = 200;
            this.txtAuthor.Size = new System.Drawing.Size(257, 20);
            this.txtAuthor.TabIndex = 0;
            // 
            // CdCbuygdy
            // 
            this.CdCbuygdy.EnterMoveNextControl = true;
            this.CdCbuygdy.Location = new System.Drawing.Point(120, 34);
            this.CdCbuygdy.Name = "CdCbuygdy";
            this.CdCbuygdy.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.CdCbuygdy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdCbuygdy.Properties.Appearance.Options.UseBackColor = true;
            this.CdCbuygdy.Properties.Appearance.Options.UseFont = true;
            this.CdCbuygdy.Properties.MaxLength = 200;
            this.CdCbuygdy.Size = new System.Drawing.Size(257, 20);
            this.CdCbuygdy.TabIndex = 1;
            // 
            // txtPublish
            // 
            this.txtPublish.EnterMoveNextControl = true;
            this.txtPublish.Location = new System.Drawing.Point(120, 57);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtPublish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublish.Properties.Appearance.Options.UseBackColor = true;
            this.txtPublish.Properties.Appearance.Options.UseFont = true;
            this.txtPublish.Properties.MaxLength = 40;
            this.txtPublish.Size = new System.Drawing.Size(257, 20);
            this.txtPublish.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(29, 61);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(65, 13);
            this.labelControl10.TabIndex = 398;
            this.labelControl10.Text = "Nhà xuất bản";
            // 
            // txtWeight
            // 
            this.txtWeight.EditValue = "0";
            this.txtWeight.EnterMoveNextControl = true;
            this.txtWeight.Location = new System.Drawing.Point(297, 226);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtWeight.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Properties.Appearance.Options.UseBackColor = true;
            this.txtWeight.Properties.Appearance.Options.UseFont = true;
            this.txtWeight.Properties.Appearance.Options.UseTextOptions = true;
            this.txtWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtWeight.Properties.DisplayFormat.FormatString = "n0";
            this.txtWeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWeight.Properties.EditFormat.FormatString = "n0";
            this.txtWeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtWeight.Properties.Mask.EditMask = "n0";
            this.txtWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWeight.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtWeight.Size = new System.Drawing.Size(51, 20);
            this.txtWeight.TabIndex = 12;
            // 
            // LabelControl22
            // 
            this.LabelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl22.Appearance.Options.UseFont = true;
            this.LabelControl22.Location = new System.Drawing.Point(233, 229);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(58, 13);
            this.LabelControl22.TabIndex = 401;
            this.LabelControl22.Text = "Trọng lượng";
            // 
            // txtNumOfPage
            // 
            this.txtNumOfPage.EditValue = "0";
            this.txtNumOfPage.EnterMoveNextControl = true;
            this.txtNumOfPage.Location = new System.Drawing.Point(327, 129);
            this.txtNumOfPage.Name = "txtNumOfPage";
            this.txtNumOfPage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtNumOfPage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfPage.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumOfPage.Properties.Appearance.Options.UseFont = true;
            this.txtNumOfPage.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumOfPage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumOfPage.Properties.DisplayFormat.FormatString = "n0";
            this.txtNumOfPage.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtNumOfPage.Properties.EditFormat.FormatString = "n0";
            this.txtNumOfPage.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtNumOfPage.Properties.Mask.EditMask = "n0";
            this.txtNumOfPage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumOfPage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNumOfPage.Size = new System.Drawing.Size(50, 20);
            this.txtNumOfPage.TabIndex = 7;
            // 
            // txtDimension
            // 
            this.txtDimension.EditValue = "125x120";
            this.txtDimension.EnterMoveNextControl = true;
            this.txtDimension.Location = new System.Drawing.Point(120, 226);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtDimension.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimension.Properties.Appearance.Options.UseBackColor = true;
            this.txtDimension.Properties.Appearance.Options.UseFont = true;
            this.txtDimension.Properties.MaxLength = 50;
            this.txtDimension.Size = new System.Drawing.Size(100, 20);
            this.txtDimension.TabIndex = 11;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(29, 229);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(50, 13);
            this.labelControl13.TabIndex = 403;
            this.labelControl13.Text = "Kích thước";
            // 
            // cmbYear
            // 
            this.cmbYear.EnterMoveNextControl = true;
            this.cmbYear.Location = new System.Drawing.Point(166, 201);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmbYear.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.Properties.Appearance.Options.UseBackColor = true;
            this.cmbYear.Properties.Appearance.Options.UseFont = true;
            this.cmbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYear.Properties.MaxLength = 3;
            this.cmbYear.Size = new System.Drawing.Size(54, 20);
            this.cmbYear.TabIndex = 405;
            // 
            // cmbForm
            // 
            this.cmbForm.EnterMoveNextControl = true;
            this.cmbForm.Location = new System.Drawing.Point(120, 81);
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmbForm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbForm.Properties.Appearance.Options.UseBackColor = true;
            this.cmbForm.Properties.Appearance.Options.UseFont = true;
            this.cmbForm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbForm.Properties.Items.AddRange(new object[] {
            "Bìa mềm",
            "Bìa cứng"});
            this.cmbForm.Properties.MaxLength = 3;
            this.cmbForm.Size = new System.Drawing.Size(225, 20);
            this.cmbForm.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(29, 84);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 406;
            this.labelControl6.Text = "Hình thức";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(353, 229);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(24, 13);
            this.labelControl15.TabIndex = 408;
            this.labelControl15.Text = "gram";
            // 
            // btnAddGrp
            // 
            this.btnAddGrp.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrp.Appearance.Options.UseFont = true;
            this.btnAddGrp.ImageIndex = 0;
            this.btnAddGrp.ImageList = this.imageList_0;
            this.btnAddGrp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddGrp.Location = new System.Drawing.Point(351, 155);
            this.btnAddGrp.Name = "btnAddGrp";
            this.btnAddGrp.Size = new System.Drawing.Size(26, 19);
            this.btnAddGrp.TabIndex = 409;
            this.btnAddGrp.TabStop = false;
            this.btnAddGrp.ToolTip = "Thêm loại sách";
            this.btnAddGrp.Click += new System.EventHandler(this.IipWvDcZu);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "FrmBookDef_16_0.png");
            // 
            // cmbMonth
            // 
            this.cmbMonth.EnterMoveNextControl = true;
            this.cmbMonth.Location = new System.Drawing.Point(120, 201);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmbMonth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.Properties.Appearance.Options.UseBackColor = true;
            this.cmbMonth.Properties.Appearance.Options.UseFont = true;
            this.cmbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMonth.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMonth.Properties.MaxLength = 3;
            this.cmbMonth.Size = new System.Drawing.Size(43, 20);
            this.cmbMonth.TabIndex = 10;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 58);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(586, 294);
            this.xtraTabControl1.TabIndex = 412;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pictureEdit1);
            this.xtraTabPage1.Controls.Add(this.btnUnit);
            this.xtraTabPage1.Controls.Add(this.labelControl16);
            this.xtraTabPage1.Controls.Add(this.cmbUnit);
            this.xtraTabPage1.Controls.Add(this.btnFormType);
            this.xtraTabPage1.Controls.Add(this.cmbMonth);
            this.xtraTabPage1.Controls.Add(this.LabelControl3);
            this.xtraTabPage1.Controls.Add(this.LabelControl4);
            this.xtraTabPage1.Controls.Add(this.btnAddGrp);
            this.xtraTabPage1.Controls.Add(this.LabelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl15);
            this.xtraTabPage1.Controls.Add(this.txtRtPrice);
            this.xtraTabPage1.Controls.Add(this.cmbForm);
            this.xtraTabPage1.Controls.Add(this.LabelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.cmbYear);
            this.xtraTabPage1.Controls.Add(this.LabelControl12);
            this.xtraTabPage1.Controls.Add(this.txtDimension);
            this.xtraTabPage1.Controls.Add(this.LabelControl11);
            this.xtraTabPage1.Controls.Add(this.labelControl13);
            this.xtraTabPage1.Controls.Add(this.txtBarcode);
            this.xtraTabPage1.Controls.Add(this.txtNumOfPage);
            this.xtraTabPage1.Controls.Add(this.btnChoose);
            this.xtraTabPage1.Controls.Add(this.txtWeight);
            this.xtraTabPage1.Controls.Add(this.labelControl20);
            this.xtraTabPage1.Controls.Add(this.LabelControl22);
            this.xtraTabPage1.Controls.Add(this.txtPublish);
            this.xtraTabPage1.Controls.Add(this.cmbLanguage);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.CdCbuygdy);
            this.xtraTabPage1.Controls.Add(this.cmbGroup);
            this.xtraTabPage1.Controls.Add(this.txtAuthor);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(578, 265);
            this.xtraTabPage1.Text = "Thông tin";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(416, 13);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(148, 208);
            this.pictureEdit1.TabIndex = 416;
            // 
            // btnUnit
            // 
            this.btnUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.Appearance.Options.UseFont = true;
            this.btnUnit.ImageIndex = 0;
            this.btnUnit.ImageList = this.imageList_0;
            this.btnUnit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUnit.Location = new System.Drawing.Point(352, 178);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(26, 19);
            this.btnUnit.TabIndex = 415;
            this.btnUnit.TabStop = false;
            this.btnUnit.ToolTip = "Thêm loại sách";
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(29, 180);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(52, 13);
            this.labelControl16.TabIndex = 413;
            this.labelControl16.Text = "Đơn vị tính";
            // 
            // cmbUnit
            // 
            this.cmbUnit.EnterMoveNextControl = true;
            this.cmbUnit.Location = new System.Drawing.Point(120, 177);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cmbUnit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.Properties.Appearance.Options.UseBackColor = true;
            this.cmbUnit.Properties.Appearance.Options.UseFont = true;
            this.cmbUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUnit.Properties.MaxLength = 3;
            this.cmbUnit.Size = new System.Drawing.Size(228, 20);
            this.cmbUnit.TabIndex = 9;
            // 
            // btnFormType
            // 
            this.btnFormType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormType.Appearance.Options.UseFont = true;
            this.btnFormType.ImageIndex = 0;
            this.btnFormType.ImageList = this.imageList_0;
            this.btnFormType.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFormType.Location = new System.Drawing.Point(351, 80);
            this.btnFormType.Name = "btnFormType";
            this.btnFormType.Size = new System.Drawing.Size(26, 19);
            this.btnFormType.TabIndex = 412;
            this.btnFormType.TabStop = false;
            this.btnFormType.ToolTip = "Thêm hình thức";
            this.btnFormType.Click += new System.EventHandler(this.btnFormType_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtIntro);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(579, 265);
            this.xtraTabPage2.Text = "Giới thiệu";
            // 
            // txtIntro
            // 
            this.txtIntro.EditValue = "Giới thiệu về nội dung";
            this.txtIntro.Location = new System.Drawing.Point(7, 3);
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Properties.MaxLength = 1500;
            this.txtIntro.Size = new System.Drawing.Size(569, 259);
            this.txtIntro.TabIndex = 391;
            // 
            // Txt_OpenDate
            // 
            this.Txt_OpenDate.EditValue = new System.DateTime(2015, 4, 11, 11, 26, 36, 0);
            this.Txt_OpenDate.Location = new System.Drawing.Point(465, 35);
            this.Txt_OpenDate.Name = "Txt_OpenDate";
            this.Txt_OpenDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Txt_OpenDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_OpenDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_OpenDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_OpenDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Txt_OpenDate.Size = new System.Drawing.Size(96, 20);
            this.Txt_OpenDate.TabIndex = 413;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(610, 406);
            this.Controls.Add(this.Txt_OpenDate);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.Txt_Status);
            this.Controls.Add(this.LabelControl14);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGoodsid);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Skip);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.FrmBookDef_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodsid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CdCbuygdy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPublish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWeight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumOfPage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDimension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnit.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIntro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OpenDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_OpenDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private SimpleButton btn_Delete;
        private SimpleButton btn_Edit;
        private SimpleButton btn_Exit;
        private SimpleButton btn_New;
        private SimpleButton btn_Save;
        private SimpleButton btn_Search;
        private SimpleButton btn_Skip;
        internal SimpleButton btnAddGrp;
        internal SimpleButton btnChoose;
        internal SimpleButton btnFormType;
        internal SimpleButton btnUnit;
        internal TextEdit CdCbuygdy;
        internal ComboBoxEdit cmbForm;
        internal ComboBoxEdit cmbGroup;
        internal ComboBoxEdit cmbLanguage;
        internal ComboBoxEdit cmbMonth;
        internal ComboBoxEdit cmbUnit;
        internal ComboBoxEdit cmbYear;
        internal GroupBox groupBox1;
        //private IContainer components;
        private ImageList imageList_0;
        internal LabelControl LabelControl1;
        internal LabelControl labelControl10;
        internal LabelControl LabelControl11;
        internal LabelControl LabelControl12;
        internal LabelControl labelControl13;
        internal LabelControl LabelControl14;
        internal LabelControl labelControl15;
        internal LabelControl labelControl16;
        internal LabelControl LabelControl2;
        internal LabelControl labelControl20;
        internal LabelControl LabelControl22;
        internal LabelControl LabelControl3;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl5;
        internal LabelControl labelControl6;
        internal LabelControl LabelControl7;
        internal LabelControl labelControl8;
        internal LabelControl labelControl9;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        internal OpenFileDialog openFileDialog_0;
        private PictureEdit pictureEdit1;
        private string string_0;
        private string string_1;
        private Timer timer_0;
        internal TextEdit Txt_Status;
        internal TextEdit txtAuthor;
        internal TextEdit txtBarcode;
        internal TextEdit txtDimension;
        internal TextEdit txtGoodsid;
        private MemoEdit txtIntro;
        internal TextEdit txtName;
        internal TextEdit txtNumOfPage;
        internal TextEdit txtPublish;
        internal TextEdit txtRtPrice;
        internal TextEdit txtWeight;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private XtraTabPage xtraTabPage2;
        private DateEdit Txt_OpenDate;
    }
}

