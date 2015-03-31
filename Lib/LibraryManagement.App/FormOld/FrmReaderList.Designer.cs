using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmReaderList
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReaderList));
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperson_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldue_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.colopen_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_History = new DevExpress.XtraEditors.SimpleButton();
            this.printingSystem_0 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink_0 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 9;
            // 
            // bindingSource_0
            // 
            this.bindingSource_0.DataMember = "tblCustomer";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bindingSource_0;
            this.gridControl1.Location = new System.Drawing.Point(13, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1});
            this.gridControl1.Size = new System.Drawing.Size(637, 432);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colfullname,
            this.coladdress,
            this.colphone,
            this.colperson_id,
            this.colemail,
            this.coldue_date,
            this.colimage,
            this.colopen_date,
            this.colStatus});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colStatus;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = false;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colid
            // 
            this.colid.Caption = "Số thẻ";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.SummaryItem.DisplayFormat = "{0:n0}";
            this.colid.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colfullname
            // 
            this.colfullname.Caption = "Họ tên";
            this.colfullname.FieldName = "fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.OptionsColumn.AllowEdit = false;
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 1;
            // 
            // coladdress
            // 
            this.coladdress.Caption = "Địa chỉ";
            this.coladdress.FieldName = "address";
            this.coladdress.Name = "coladdress";
            this.coladdress.OptionsColumn.AllowEdit = false;
            this.coladdress.Visible = true;
            this.coladdress.VisibleIndex = 6;
            // 
            // colphone
            // 
            this.colphone.Caption = "Điện thoại";
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.OptionsColumn.AllowEdit = false;
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 4;
            // 
            // colperson_id
            // 
            this.colperson_id.Caption = "Số CMTND";
            this.colperson_id.FieldName = "person_id";
            this.colperson_id.Name = "colperson_id";
            this.colperson_id.OptionsColumn.AllowEdit = false;
            this.colperson_id.Visible = true;
            this.colperson_id.VisibleIndex = 7;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 5;
            // 
            // coldue_date
            // 
            this.coldue_date.AppearanceCell.BackColor = System.Drawing.Color.LightCyan;
            this.coldue_date.AppearanceCell.Options.UseBackColor = true;
            this.coldue_date.Caption = "Ngày hết hạn";
            this.coldue_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldue_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldue_date.FieldName = "due_date";
            this.coldue_date.Name = "coldue_date";
            this.coldue_date.OptionsColumn.AllowEdit = false;
            this.coldue_date.Visible = true;
            this.coldue_date.VisibleIndex = 3;
            // 
            // colimage
            // 
            this.colimage.Caption = "Ảnh";
            this.colimage.ColumnEdit = this.repositoryItemImageEdit1;
            this.colimage.FieldName = "image";
            this.colimage.Name = "colimage";
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 8;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // colopen_date
            // 
            this.colopen_date.Caption = "Ngày cấp";
            this.colopen_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colopen_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colopen_date.FieldName = "open_date";
            this.colopen_date.Name = "colopen_date";
            this.colopen_date.OptionsColumn.AllowEdit = false;
            this.colopen_date.Visible = true;
            this.colopen_date.VisibleIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(340, 450);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(88, 23);
            this.btn_Exit.TabIndex = 383;
            this.btn_Exit.Text = "ESC-Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_History
            // 
            this.btn_History.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_History.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Appearance.Options.UseFont = true;
            this.btn_History.Location = new System.Drawing.Point(235, 450);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(88, 23);
            this.btn_History.TabIndex = 382;
            this.btn_History.Text = "In";
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // printingSystem_0
            // 
            this.printingSystem_0.Links.AddRange(new object[] {
            this.printableComponentLink_0});
            // 
            // printableComponentLink_0
            // 
            this.printableComponentLink_0.Component = this.gridControl1;
            // 
            // 
            // 
            this.printableComponentLink_0.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink_0.ImageCollection.ImageStream")));
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            // 
            // FrmReaderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(662, 485);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmReaderList";
            this.Text = "FrmReaderList";
            this.Load += new System.EventHandler(this.RrqIxZxw5);
            this.Activated += new System.EventHandler(this.FrmReaderList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).EndInit();
            this.ResumeLayout(false);

        }
        private BindingSource bindingSource_0;
        internal SimpleButton btn_Exit;
        internal SimpleButton btn_History;
        private GridColumn coladdress;
        private GridColumn coldue_date;
        private GridColumn colemail;
        private GridColumn colfullname;
        private GridColumn colid;
        private GridColumn colimage;
        private GridColumn colopen_date;
        private GridColumn colperson_id;
        private GridColumn colphone;
        private GridColumn colStatus;
        private GridControl gridControl1;
        private GridView gridView1;
        //private IContainer components;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private RepositoryItemImageEdit repositoryItemImageEdit1;


        #endregion

    }
}
