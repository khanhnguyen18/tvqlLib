using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using LIBRARY_MANAGEMENT.library_dataDataSetTableAdapters;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmBooksLocation
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
            this.kCnalMegv = new Container();
            StyleFormatCondition condition = new StyleFormatCondition();
            this.colcheck = new GridColumn();
            this.repositoryItemCheckEdit1 = new RepositoryItemCheckEdit();
            this.gridControl1 = new GridControl();
            this.bindingSource_0 = new BindingSource(this.kCnalMegv);
            this.library_dataDataSet_0 = new library_dataDataSet();
            this.gridView1 = new GridView();
            this.colgoods_id = new GridColumn();
            this.colfull_name = new GridColumn();
            this.colgrp_id = new GridColumn();
            this.colimage = new GridColumn();
            this.repositoryItemImageEdit1 = new RepositoryItemImageEdit();
            this.btnConfirm = new SimpleButton();
            this.btnExit = new SimpleButton();
            this.txtSymbol = new TextEdit();
            this.labelControl1 = new LabelControl();
            this.lblStkName = new LabelControl();
            this.txtStkId = new TextEdit();
            this.LabelControl17 = new LabelControl();
            this.lblLocationName = new LabelControl();
            this.merclocTableAdapter_0 = new merclocTableAdapter();
            this.btnRefresh = new SimpleButton();
            this.timer_0 = new Timer(this.kCnalMegv);
            this.repositoryItemCheckEdit1.BeginInit();
            this.gridControl1.BeginInit();
            ((ISupportInitialize)this.bindingSource_0).BeginInit();
            this.library_dataDataSet_0.BeginInit();
            this.gridView1.BeginInit();
            this.repositoryItemImageEdit1.BeginInit();
            this.txtSymbol.Properties.BeginInit();
            this.txtStkId.Properties.BeginInit();
            base.SuspendLayout();
            this.colcheck.Caption = "Chọn";
            this.colcheck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 4;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = CheckStyles.Radio;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.gridControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.gridControl1.DataSource = this.bindingSource_0;
            this.gridControl1.Location = new Point(12, 0x3b);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new RepositoryItem[] { this.repositoryItemImageEdit1, this.repositoryItemCheckEdit1 });
            this.gridControl1.Size = new Size(0x288, 0x163);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new BaseView[] { this.gridView1 });
            this.bindingSource_0.DataMember = "mercloc";
            this.bindingSource_0.DataSource = this.library_dataDataSet_0;
            this.library_dataDataSet_0.DataSetName = "library_dataDataSet";
            this.library_dataDataSet_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.gridView1.Appearance.FooterPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new GridColumn[] { this.colgoods_id, this.colfull_name, this.colgrp_id, this.colimage, this.colcheck });
            condition.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            condition.Appearance.Options.UseFont = true;
            condition.ApplyToRow = true;
            condition.Column = this.colcheck;
            condition.Condition = FormatConditionEnum.Equal;
            condition.Value1 = true;
            this.gridView1.FormatConditions.AddRange(new StyleFormatCondition[] { condition });
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.colgoods_id.Caption = "M\x00e3 s\x00e1ch";
            this.colgoods_id.FieldName = "goods_id";
            this.colgoods_id.Name = "colgoods_id";
            this.colgoods_id.OptionsColumn.AllowEdit = false;
            this.colgoods_id.Visible = true;
            this.colgoods_id.VisibleIndex = 0;
            this.colfull_name.Caption = "T\x00ean s\x00e1ch";
            this.colfull_name.FieldName = "full_name";
            this.colfull_name.Name = "colfull_name";
            this.colfull_name.OptionsColumn.AllowEdit = false;
            this.colfull_name.Visible = true;
            this.colfull_name.VisibleIndex = 1;
            this.colgrp_id.Caption = "Nh\x00f3m";
            this.colgrp_id.FieldName = "grp_id";
            this.colgrp_id.Name = "colgrp_id";
            this.colgrp_id.OptionsColumn.AllowEdit = false;
            this.colgrp_id.Visible = true;
            this.colgrp_id.VisibleIndex = 2;
            this.colimage.Caption = "Ảnh b\x00eca";
            this.colimage.ColumnEdit = this.repositoryItemImageEdit1;
            this.colimage.FieldName = "image";
            this.colimage.Name = "colimage";
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 3;
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.SizeMode = PictureSizeMode.Zoom;
            this.btnConfirm.Anchor = AnchorStyles.Bottom;
            this.btnConfirm.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.Location = new Point(0xf4, 0x1a7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new Size(0x58, 0x17);
            this.btnConfirm.TabIndex = 0x183;
            this.btnConfirm.Text = "Lưu";
            this.btnConfirm.Click += new EventHandler(this.btnConfirm_Click);
            this.btnExit.Anchor = AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;;
            this.btnExit.Location = new Point(0x155, 0x1a7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(0x58, 0x17);
            this.btnExit.TabIndex = 0x182;
            this.btnExit.Text = "&Tho\x00e1t";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            this.txtSymbol.EnterMoveNextControl = true;
            this.txtSymbol.Location = new Point(0x77, 0x21);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Properties.Appearance.Options.UseFont = true;
            this.txtSymbol.Properties.CharacterCasing = CharacterCasing.Upper;
            this.txtSymbol.Properties.MaxLength = 4;
            this.txtSymbol.Size = new Size(0x38, 20);
            this.txtSymbol.TabIndex = 0x1ba;
            this.txtSymbol.ToolTip = "Nhấn F5 để t\x00ecm kiếm";
            this.txtSymbol.ToolTipIconType = ToolTipIconType.Information;
            this.txtSymbol.ToolTipTitle = "Lưu \x00fd";
            this.txtSymbol.EditValueChanged += new EventHandler(this.txtSymbol_EditValueChanged);
            this.txtSymbol.KeyDown += new KeyEventHandler(this.txtSymbol_KeyDown);
            this.labelControl1.Location = new Point(0x15, 0x25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new Size(0x35, 13);
            this.labelControl1.TabIndex = 0x1bd;
            this.labelControl1.Text = "M\x00e3 kệ s\x00e1ch";
            this.lblStkName.Appearance.BackColor = Color.MediumTurquoise;
            this.lblStkName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblStkName.Appearance.BorderColor = Color.White;
            this.lblStkName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblStkName.Appearance.ForeColor = Color.Black;
            this.lblStkName.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblStkName.BorderStyle = BorderStyles.UltraFlat;
            this.lblStkName.Location = new Point(0xb1, 12);
            this.lblStkName.Name = "lblStkName";
            this.lblStkName.Padding = new Padding(3, 0, 0, 0);
            this.lblStkName.Size = new Size(0x1e3, 0x11);
            this.lblStkName.TabIndex = 0x1bc;
            this.txtStkId.EditValue = "";
            this.txtStkId.EnterMoveNextControl = true;
            this.txtStkId.Location = new Point(0x77, 10);
            this.txtStkId.Name = "txtStkId";
            this.txtStkId.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtStkId.Properties.Appearance.Options.UseFont = true;
            this.txtStkId.Properties.MaxLength = 5;
            this.txtStkId.Size = new Size(0x38, 20);
            this.txtStkId.TabIndex = 0x1b9;
            this.txtStkId.EditValueChanged += new EventHandler(this.txtStkId_EditValueChanged);
            this.txtStkId.KeyDown += new KeyEventHandler(this.txtStkId_KeyDown);
            this.txtStkId.Validating += new CancelEventHandler(this.txtStkId_Validating);
            this.LabelControl17.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl17.Location = new Point(0x15, 14);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new Size(0x4e, 13);
            this.LabelControl17.TabIndex = 0x1bb;
            this.LabelControl17.Text = "Tại thư viện/kho";
            this.lblLocationName.Appearance.BackColor = Color.MediumTurquoise;
            this.lblLocationName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.lblLocationName.Appearance.BorderColor = Color.White;
            this.lblLocationName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblLocationName.Appearance.ForeColor = Color.Black;
            this.lblLocationName.AutoSizeMode = LabelAutoSizeMode.None;
            this.lblLocationName.BorderStyle = BorderStyles.UltraFlat;
            this.lblLocationName.Location = new Point(0xb1, 0x23);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Padding = new Padding(3, 0, 0, 0);
            this.lblLocationName.Size = new Size(0x11f, 0x11);
            this.lblLocationName.TabIndex = 0x1be;
            this.merclocTableAdapter_0.ClearBeforeFill = true;
            this.btnRefresh.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new Point(0x1df, 0x23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(0x49, 0x12);
            this.btnRefresh.TabIndex = 0x1bf;
            this.btnRefresh.Text = "Bắt đầu";
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 200;
            this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.btnExit;
            base.ClientSize = new Size(0x2a0, 0x1ca);
            base.Controls.Add(this.btnRefresh);
            base.Controls.Add(this.lblLocationName);
            base.Controls.Add(this.txtSymbol);
            base.Controls.Add(this.labelControl1);
            base.Controls.Add(this.lblStkName);
            base.Controls.Add(this.txtStkId);
            base.Controls.Add(this.LabelControl17);
            base.Controls.Add(this.btnConfirm);
            base.Controls.Add(this.btnExit);
            base.Controls.Add(this.gridControl1);
            base.HelpButton = true;
            base.Name = "FrmBooksLocation";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "FrmBooksLocation";
            base.Activated += new EventHandler(this.FrmBooksLocation_Activated);
            base.Load += new EventHandler(this.FrmBooksLocation_Load);
            this.repositoryItemCheckEdit1.EndInit();
            this.gridControl1.EndInit();
            ((ISupportInitialize)this.bindingSource_0).EndInit();
            this.library_dataDataSet_0.EndInit();
            this.gridView1.EndInit();
            this.repositoryItemImageEdit1.EndInit();
            this.txtSymbol.Properties.EndInit();
            this.txtStkId.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private BindingSource bindingSource_0;
        internal SimpleButton btnConfirm;
        internal SimpleButton btnExit;
        internal SimpleButton btnRefresh;
        private GridColumn colcheck;
        private GridColumn colfull_name;
        private GridColumn colgoods_id;
        private GridColumn colgrp_id;
        private GridColumn colimage;
        private GridControl gridControl1;
        private GridView gridView1;
        private IContainer kCnalMegv;
        private LabelControl labelControl1;
        internal LabelControl LabelControl17;
        internal LabelControl lblLocationName;
        internal LabelControl lblStkName;
        private library_dataDataSet library_dataDataSet_0;
        private merclocTableAdapter merclocTableAdapter_0;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private RepositoryItemImageEdit repositoryItemImageEdit1;
        private string string_0;
        private Timer timer_0;
        internal TextEdit txtStkId;
        private TextEdit txtSymbol;

        #endregion

    }
}