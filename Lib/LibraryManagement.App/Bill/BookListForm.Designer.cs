using System.ComponentModel;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraEditors.Repository;
using System.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using System;
using DevExpress.Utils;
namespace LibraryManagement.App
{
    partial class BookListForm
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
        private void InitializeComponent()
        {
            this.components = new Container();
            manager = new ComponentResourceManager(typeof(BookListForm));
            this.gridControl1 = new GridControl();
            this.gridView1 = new GridView();
            this.colgoods_id = new GridColumn();
            this.kCnalMegv = new GridColumn();
            this.colimage = new GridColumn();
            this.repositoryItemImageEdit1 = new RepositoryItemImageEdit();
            this.colintroinfo = new GridColumn();
            this.repositoryItemMemoExEdit1 = new RepositoryItemMemoExEdit();
            this.colauthor = new GridColumn();
            this.coltranslator = new GridColumn();
            this.colpublish = new GridColumn();
            this.colbarcode = new GridColumn();
            this.colpl_month = new GridColumn();
            this.colpl_year = new GridColumn();
            this.coldimension = new GridColumn();
            this.colweight = new GridColumn();
            this.colpages = new GridColumn();
            this.colgrpname = new GridColumn();
            this.collangguge = new GridColumn();
            this.colfrmtype = new GridColumn();
            this.repositoryItemMemoEdit1 = new RepositoryItemMemoEdit();
            this.btn_Exit = new SimpleButton();
            this.btnPrint = new SimpleButton();
            this.printingSystem_0 = new PrintingSystem(this.components);
            this.printableComponentLink_0 = new PrintableComponentLink(this.components);
            this.gridControl1.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemImageEdit1.BeginInit();
            this.repositoryItemMemoExEdit1.BeginInit();
            this.repositoryItemMemoEdit1.BeginInit();
            ((ISupportInitialize)this.printingSystem_0).BeginInit();
            base.SuspendLayout();
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.Location = new Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[] { this.repositoryItemImageEdit1, this.repositoryItemMemoEdit1, this.repositoryItemMemoExEdit1 });
            this.gridControl1.Size = new Size(0x2ef, 0x19c);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.gridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new GridColumn[] { this.colgoods_id, this.kCnalMegv, this.colimage, this.colintroinfo, this.colauthor, this.coltranslator, this.colpublish, this.colbarcode, this.colpl_month, this.colpl_year, this.coldimension, this.colweight, this.colpages, this.colgrpname, this.collangguge, this.colfrmtype });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.colgoods_id.AppearanceCell.BackColor = Color.Gainsboro;
            this.colgoods_id.AppearanceCell.Options.UseBackColor = true;
            this.colgoods_id.Caption = "M\x00e3 số";
            this.colgoods_id.FieldName = "goods_id";
            this.colgoods_id.Fixed = FixedStyle.Left;
            this.colgoods_id.Name = "colgoods_id";
            this.colgoods_id.OptionsColumn.AllowEdit = false;
            this.colgoods_id.Visible = true;
            this.colgoods_id.VisibleIndex = 0;
            this.kCnalMegv.AppearanceCell.BackColor = Color.Gainsboro;
            this.kCnalMegv.AppearanceCell.BackColor2 = Color.WhiteSmoke;
            this.kCnalMegv.AppearanceCell.Options.UseBackColor = true;
            this.kCnalMegv.Caption = "T\x00ean s\x00e1ch";
            this.kCnalMegv.FieldName = "full_name";
            this.kCnalMegv.Fixed = FixedStyle.Left;
            this.kCnalMegv.Name = "colfull_name";
            this.kCnalMegv.OptionsColumn.AllowEdit = false;
            this.kCnalMegv.Visible = true;
            this.kCnalMegv.VisibleIndex = 1;
            this.colimage.Caption = "B\x00eca";
            this.colimage.ColumnEdit = this.repositoryItemImageEdit1;
            this.colimage.FieldName = "image";
            this.colimage.Name = "colimage";
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 3;
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.SizeMode = PictureSizeMode.Zoom;
            this.colintroinfo.Caption = "Giới thiệu";
            this.colintroinfo.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colintroinfo.FieldName = "introinfo";
            this.colintroinfo.Name = "colintroinfo";
            this.colintroinfo.Visible = true;
            this.colintroinfo.VisibleIndex = 2;
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.colauthor.Caption = "T\x00e1c giả";
            this.colauthor.FieldName = "author";
            this.colauthor.Name = "colauthor";
            this.colauthor.Visible = true;
            this.colauthor.VisibleIndex = 4;
            this.coltranslator.Caption = "Dịch giả";
            this.coltranslator.FieldName = "translator";
            this.coltranslator.Name = "coltranslator";
            this.coltranslator.Visible = true;
            this.coltranslator.VisibleIndex = 5;
            this.colpublish.Caption = "Nh\x00e0 xuất bản";
            this.colpublish.FieldName = "publish";
            this.colpublish.Name = "colpublish";
            this.colpublish.Visible = true;
            this.colpublish.VisibleIndex = 6;
            this.colbarcode.Caption = "ISBN";
            this.colbarcode.FieldName = "barcode";
            this.colbarcode.Name = "colbarcode";
            this.colbarcode.Visible = true;
            this.colbarcode.VisibleIndex = 7;
            this.colpl_month.Caption = "Th\x00e1ng XB";
            this.colpl_month.FieldName = "pl_month";
            this.colpl_month.Name = "colpl_month";
            this.colpl_month.Visible = true;
            this.colpl_month.VisibleIndex = 8;
            this.colpl_year.Caption = "Năm XB";
            this.colpl_year.FieldName = "pl_year";
            this.colpl_year.Name = "colpl_year";
            this.colpl_year.Visible = true;
            this.colpl_year.VisibleIndex = 9;
            this.coldimension.Caption = "K\x00edch cỡ";
            this.coldimension.FieldName = "dimension";
            this.coldimension.Name = "coldimension";
            this.coldimension.Visible = true;
            this.coldimension.VisibleIndex = 10;
            this.colweight.Caption = "T.lượng";
            this.colweight.FieldName = "weight";
            this.colweight.Name = "colweight";
            this.colweight.Visible = true;
            this.colweight.VisibleIndex = 11;
            this.colpages.Caption = "Số trang";
            this.colpages.FieldName = "pages";
            this.colpages.Name = "colpages";
            this.colpages.Visible = true;
            this.colpages.VisibleIndex = 12;
            this.colgrpname.Caption = "Thuộc nh\x00f3m";
            this.colgrpname.FieldName = "grpname";
            this.colgrpname.Name = "colgrpname";
            this.colgrpname.Visible = true;
            this.colgrpname.VisibleIndex = 13;
            this.collangguge.Caption = "Ng\x00f4n ngữ";
            this.collangguge.FieldName = "langguge";
            this.collangguge.Name = "collangguge";
            this.collangguge.Visible = true;
            this.collangguge.VisibleIndex = 14;
            this.colfrmtype.Caption = "H\x00ecnh thức";
            this.colfrmtype.FieldName = "frmtype";
            this.colfrmtype.Name = "colfrmtype";
            this.colfrmtype.Visible = true;
            this.colfrmtype.VisibleIndex = 15;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Exit.Appearance.Options.UseFont = true;
            //this.btn_Exit.DialogResult = DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x18c, 0x1bb);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x58, 0x17);
            this.btn_Exit.TabIndex = 0x17f;
            this.btn_Exit.Text = "ESC-Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btnPrint.Anchor = AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new Point(0x123, 0x1bb);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(0x58, 0x17);
            this.btnPrint.TabIndex = 0x17e;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            this.printingSystem_0.Links.AddRange(new object[] { this.printableComponentLink_0 });
            this.printableComponentLink_0.Component = this.gridControl1;
            this.printableComponentLink_0.ImageCollection.ImageStream = (ImageCollectionStreamer)manager.GetObject("printableComponentLink1.ImageCollection.ImageStream");
            this.printableComponentLink_0.PrintingSystem = this.printingSystem_0;
            this.printableComponentLink_0.PrintingSystemBase = this.printingSystem_0;
            this.printableComponentLink_0.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_0_CreateReportHeaderArea);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x307, 0x1de);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btnPrint);
            base.Controls.Add(this.gridControl1);
            base.Name = "FrmBookList";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmBookList";
            base.Activated += new EventHandler(this.FrmBookList_Activated);
            base.Load += new EventHandler(this.FrmBookList_Load);
            this.gridControl1.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemImageEdit1.EndInit();
            this.repositoryItemMemoExEdit1.EndInit();
            this.repositoryItemMemoEdit1.EndInit();
            ((ISupportInitialize)this.printingSystem_0).EndInit();
            base.ResumeLayout(false);
        }

        #endregion

        internal SimpleButton btn_Exit;
        internal SimpleButton btnPrint;
        private GridColumn colauthor;
        private GridColumn colbarcode;
        private GridColumn coldimension;
        private GridColumn colfrmtype;
        private GridColumn colgoods_id;
        private GridColumn colgrpname;
        private GridColumn colimage;
        private GridColumn colintroinfo;
        private GridColumn collangguge;
        private GridColumn colpages;
        private GridColumn colpl_month;
        private GridColumn colpl_year;
        private GridColumn colpublish;
        private GridColumn coltranslator;
        private GridColumn colweight;
        private GridControl gridControl1;
        private GridView gridView1;
        private GridColumn kCnalMegv;
        private PrintableComponentLink printableComponentLink_0;
        private PrintingSystem printingSystem_0;
        private RepositoryItemImageEdit repositoryItemImageEdit1;
        private RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private ComponentResourceManager manager;
    }
}