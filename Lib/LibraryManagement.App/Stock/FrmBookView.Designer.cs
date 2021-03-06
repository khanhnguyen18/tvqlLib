using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    partial class FrmBookView
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
            this.btn_Exit = new SimpleButton();
            this.btn_History = new SimpleButton();
            this.gridControl1 = new GridControl();
            this.bindingSource_0 = new BindingSource(this.components);
            this.layoutView1 = new LayoutView();
            this.colgoods_id = new LayoutViewColumn();
            this.layoutViewField_colgoods_id = new LayoutViewField();
            this.colfull_name = new LayoutViewColumn();
            this.layoutViewField_colfull_name = new LayoutViewField();
            this.colimage = new LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new RepositoryItemPictureEdit();
            this.layoutViewField_colimage = new LayoutViewField();
            this.layoutViewCard1 = new LayoutViewCard();
            this.repositoryItemImageEdit1 = new RepositoryItemImageEdit();
            this.gridControl1.BeginInit();
            ((ISupportInitialize)this.bindingSource_0).BeginInit();
            this.layoutView1.BeginInit();
            this.layoutViewField_colgoods_id.BeginInit();
            this.layoutViewField_colfull_name.BeginInit();
            this.repositoryItemPictureEdit1.BeginInit();
            this.layoutViewField_colimage.BeginInit();
            this.layoutViewCard1.BeginInit();
            this.repositoryItemImageEdit1.BeginInit();
            base.SuspendLayout();
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x193, 0x1ca);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x58, 0x17);
            this.btn_Exit.TabIndex = 0x17d;
            this.btn_Exit.Text = "ESC-Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_History.Anchor = AnchorStyles.Bottom;
            this.btn_History.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btn_History.Appearance.Options.UseFont = true;
            this.btn_History.Location = new Point(0x12a, 0x1ca);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new Size(0x58, 0x17);
            this.btn_History.TabIndex = 0x17b;
            this.btn_History.Text = "In";
            this.btn_History.Click += new EventHandler(this.btn_History_Click);
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.DataSource = this.bindingSource_0;
            this.gridControl1.Location = new Point(12, 12);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[] { this.repositoryItemPictureEdit1, this.repositoryItemImageEdit1 });
            this.gridControl1.Size = new Size(0x2fc, 430);
            this.gridControl1.TabIndex = 0x17e;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.layoutView1 });
            this.bindingSource_0.DataMember = "tblGoods";
            this.layoutView1.Columns.AddRange(new LayoutViewColumn[] { this.colgoods_id, this.colfull_name, this.colimage });
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.HiddenItems.AddRange(new BaseLayoutItem[] { this.layoutViewField_colgoods_id });
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ShowCardBorderIfCaptionHidden = false;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ViewMode = LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            this.colgoods_id.Caption = "M\x00e3 quản l\x00fd";
            this.colgoods_id.FieldName = "goods_id";
            this.colgoods_id.LayoutViewField = this.layoutViewField_colgoods_id;
            this.colgoods_id.Name = "colgoods_id";
            this.layoutViewField_colgoods_id.EditorPreferredWidth = 0x91;
            this.layoutViewField_colgoods_id.Location = new Point(0, 0);
            this.layoutViewField_colgoods_id.Name = "layoutViewField_colgoods_id";
            this.layoutViewField_colgoods_id.Size = new Size(0xd1, 20);
            this.layoutViewField_colgoods_id.TextSize = new Size(0x38, 13);
            this.layoutViewField_colgoods_id.TextToControlDistance = 5;
            this.colfull_name.AppearanceCell.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.colfull_name.AppearanceCell.Options.UseFont = true;
            this.colfull_name.AppearanceCell.Options.UseTextOptions = true;
            this.colfull_name.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            this.colfull_name.Caption = "T\x00ean s\x00e1ch";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.LayoutViewField = this.layoutViewField_colfull_name;
            this.colfull_name.Name = "colfull_name";
            this.layoutViewField_colfull_name.EditorPreferredWidth = 0x91;
            this.layoutViewField_colfull_name.Location = new Point(0, 0);
            this.layoutViewField_colfull_name.Name = "layoutViewField_colfull_name";
            this.layoutViewField_colfull_name.Size = new Size(200, 20);
            this.layoutViewField_colfull_name.TextSize = new Size(0x2f, 13);
            this.colimage.Caption = "Ảnh b\x00eca";
            this.colimage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colimage.FieldName = "image";
            this.colimage.LayoutViewField = this.layoutViewField_colimage;
            this.colimage.Name = "colimage";
            this.repositoryItemPictureEdit1.AllowFocused = false;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = PictureSizeMode.Zoom;
            this.layoutViewField_colimage.EditorPreferredWidth = 0x91;
            this.layoutViewField_colimage.Location = new Point(0, 20);
            this.layoutViewField_colimage.MinSize = new Size(200, 100);
            this.layoutViewField_colimage.Name = "layoutViewField_colimage";
            this.layoutViewField_colimage.Size = new Size(200, 0x1a);
            this.layoutViewField_colimage.SizeConstraintsType = SizeConstraintsType.Custom;
            this.layoutViewField_colimage.TextSize = new Size(0x2f, 13);
            this.layoutViewCard1.ExpandButtonLocation = GroupElementLocation.AfterText;
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.Items.AddRange(new BaseLayoutItem[] { this.layoutViewField_colfull_name, this.layoutViewField_colimage });
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x314, 0x1e8);
            base.Controls.Add(this.gridControl1);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_History);
            base.Name = "FrmBookView";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmBookView";
            base.Activated += new EventHandler(this.FrmBookView_Activated);
            base.FormClosing += new FormClosingEventHandler(this.FrmBookView_FormClosing);
            base.Load += new EventHandler(this.FrmBookView_Load);
            this.gridControl1.EndInit();
            ((ISupportInitialize)this.bindingSource_0).EndInit();
            this.layoutView1.EndInit();
            this.layoutViewField_colgoods_id.EndInit();
            this.layoutViewField_colfull_name.EndInit();
            this.repositoryItemPictureEdit1.EndInit();
            this.layoutViewField_colimage.EndInit();
            this.layoutViewCard1.EndInit();
            this.repositoryItemImageEdit1.EndInit();
            base.ResumeLayout(false);
        }

        private BindingSource bindingSource_0;
        internal SimpleButton btn_Exit;
        internal SimpleButton btn_History;
        private LayoutViewColumn colfull_name;
        private LayoutViewColumn colgoods_id;
        private LayoutViewColumn colimage;
        private GridControl gridControl1;
        //private IContainer components;
        //private tblGoodsTableAdapter kCnalMegv;
        private LayoutView layoutView1;
        private LayoutViewCard layoutViewCard1;
        private LayoutViewField layoutViewField_colfull_name;
        private LayoutViewField layoutViewField_colgoods_id;
        private LayoutViewField layoutViewField_colimage;
        //private library_dataDataSet library_dataDataSet_0;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private RepositoryItemImageEdit repositoryItemImageEdit1;
        private RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private string string_0;

        #endregion

    }
}