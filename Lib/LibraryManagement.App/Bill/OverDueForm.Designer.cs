using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class OverDueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverDueForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet_0 = new System.Data.DataSet();
            this.dataTable_0 = new System.Data.DataTable();
            this.dataColumn_0 = new System.Data.DataColumn();
            this.dataColumn_1 = new System.Data.DataColumn();
            this.dataColumn_2 = new System.Data.DataColumn();
            this.dataColumn_3 = new System.Data.DataColumn();
            this.dataColumn_4 = new System.Data.DataColumn();
            this.dataColumn_5 = new System.Data.DataColumn();
            this.dataColumn_6 = new System.Data.DataColumn();
            this.dataColumn_7 = new System.Data.DataColumn();
            this.dataColumn_8 = new System.Data.DataColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcs_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgoods_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfull_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrtprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldue_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloverday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrans_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.printingSystem_0 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink_0 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "overdue";
            this.gridControl1.DataSource = this.dataSet_0;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(669, 378);
            this.gridControl1.TabIndex = 454;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataSet_0
            // 
            this.dataSet_0.DataSetName = "NewDataSet";
            this.dataSet_0.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable_0});
            // 
            // dataTable_0
            // 
            this.dataTable_0.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_0,
            this.dataColumn_1,
            this.dataColumn_2,
            this.dataColumn_3,
            this.dataColumn_4,
            this.dataColumn_5,
            this.dataColumn_6,
            this.dataColumn_7,
            this.dataColumn_8});
            this.dataTable_0.TableName = "overdue";
            // 
            // dataColumn_0
            // 
            this.dataColumn_0.ColumnName = "cs_id";
            // 
            // dataColumn_1
            // 
            this.dataColumn_1.ColumnName = "fullname";
            // 
            // dataColumn_2
            // 
            this.dataColumn_2.ColumnName = "phone";
            // 
            // dataColumn_3
            // 
            this.dataColumn_3.ColumnName = "goods_id";
            // 
            // dataColumn_4
            // 
            this.dataColumn_4.ColumnName = "full_name";
            // 
            // dataColumn_5
            // 
            this.dataColumn_5.ColumnName = "due_date";
            this.dataColumn_5.DataType = typeof(System.DateTime);
            // 
            // dataColumn_6
            // 
            this.dataColumn_6.ColumnName = "overday";
            this.dataColumn_6.DataType = typeof(double);
            // 
            // dataColumn_7
            // 
            this.dataColumn_7.ColumnName = "trans_num";
            // 
            // dataColumn_8
            // 
            this.dataColumn_8.ColumnName = "rtprice";
            this.dataColumn_8.DataType = typeof(decimal);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcs_id,
            this.colfullname,
            this.colphone,
            this.colgoods_id,
            this.colfull_name,
            this.colrtprice,
            this.coldue_date,
            this.coloverday,
            this.coltrans_num});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colcs_id
            // 
            this.colcs_id.Caption = "Số thẻ";
            this.colcs_id.FieldName = "cs_id";
            this.colcs_id.Name = "colcs_id";
            this.colcs_id.Visible = true;
            this.colcs_id.VisibleIndex = 0;
            // 
            // colfullname
            // 
            this.colfullname.Caption = "Họ tên";
            this.colfullname.FieldName = "fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 1;
            // 
            // colphone
            // 
            this.colphone.Caption = "Điện thoại";
            this.colphone.FieldName = "phone";
            this.colphone.Name = "colphone";
            this.colphone.Visible = true;
            this.colphone.VisibleIndex = 2;
            // 
            // colgoods_id
            // 
            this.colgoods_id.Caption = "Mã sách";
            this.colgoods_id.FieldName = "goods_id";
            this.colgoods_id.Name = "colgoods_id";
            this.colgoods_id.Visible = true;
            this.colgoods_id.VisibleIndex = 4;
            // 
            // colfull_name
            // 
            this.colfull_name.Caption = "Tên sách";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 6;
            // 
            // colrtprice
            // 
            this.colrtprice.Caption = "Giá bìa";
            this.colrtprice.DisplayFormat.FormatString = "n0";
            this.colrtprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colrtprice.FieldName = "rtprice";
            this.colrtprice.Name = "colrtprice";
            this.colrtprice.Visible = true;
            this.colrtprice.VisibleIndex = 5;
            // 
            // coldue_date
            // 
            this.coldue_date.Caption = "Ngày hẹn trả";
            this.coldue_date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldue_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldue_date.FieldName = "due_date";
            this.coldue_date.Name = "coldue_date";
            this.coldue_date.Visible = true;
            this.coldue_date.VisibleIndex = 7;
            // 
            // coloverday
            // 
            this.coloverday.Caption = "Quá hạn(ngày)";
            this.coloverday.FieldName = "overday";
            this.coloverday.Name = "coloverday";
            this.coloverday.Visible = true;
            this.coloverday.VisibleIndex = 8;
            // 
            // coltrans_num
            // 
            this.coltrans_num.Caption = "Số phiếu mượn";
            this.coltrans_num.FieldName = "trans_num";
            this.coltrans_num.Name = "coltrans_num";
            this.coltrans_num.Visible = true;
            this.coltrans_num.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(361, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 476;
            this.btnExit.Text = "ESC-Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(243, 399);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 475;
            this.btnPrint.Text = "In danh mục";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // OverDueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(693, 431);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridControl1);
            this.Name = "OverDueForm";
            this.Text = "FrmOverDueInfo";
            this.Load += new System.EventHandler(this.FrmOverDueInfo_Load);
            this.Activated += new System.EventHandler(this.FrmOverDueInfo_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink_0.ImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        internal SimpleButton btnExit;
        internal SimpleButton btnPrint;
        private GridColumn colcs_id;
        private GridColumn coldue_date;
        private GridColumn colfull_name;
        private GridColumn colfullname;
        private GridColumn colgoods_id;
        private GridColumn coloverday;
        private GridColumn colphone;
        private GridColumn colrtprice;
        private GridColumn coltrans_num;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataSet dataSet_0;
        private DataTable dataTable_0;
        private GridControl gridControl1;
        private GridView gridView1;
        //private IContainer components;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private string string_0;

        #endregion

    }
}
