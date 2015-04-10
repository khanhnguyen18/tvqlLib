using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmUserReport
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
            this.components = new Container();
            manager = new ComponentResourceManager(typeof(FrmUserReport));
            this.imageList_0 = new ImageList(this.components);
            this.treeList1 = new TreeList();
            this.btn_Exit = new SimpleButton();
            this.btn_Save = new SimpleButton();
            this.treeList1.BeginInit();
            base.SuspendLayout();
            this.imageList_0.ImageStream = (ImageListStreamer)manager.GetObject("imageList1.ImageStream");
            this.imageList_0.TransparentColor = Color.Magenta;
            this.imageList_0.Images.SetKeyName(0, "");
            this.imageList_0.Images.SetKeyName(1, "");
            this.imageList_0.Images.SetKeyName(2, "");
            this.treeList1.Location = new Point(12, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new Size(0x25b, 0x19c);
            this.treeList1.StateImageList = this.imageList_0;
            this.treeList1.TabIndex = 0;
            this.treeList1.GetStateImage += new GetStateImageEventHandler(this.treeList1_GetStateImage);
            this.treeList1.MouseDown += new MouseEventHandler(this.treeList1_MouseDown);
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0x152, 430);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(0x4b, 0x17);
            this.btn_Exit.TabIndex = 0x19e;
            this.btn_Exit.Text = "&Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.btn_Save.Anchor = AnchorStyles.Bottom;
            this.btn_Save.Location = new Point(0xd5, 430);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new Size(0x4b, 0x17);
            this.btn_Save.TabIndex = 0x19d;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new EventHandler(this.btn_Save_Click);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x273, 0x1d1);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.btn_Save);
            base.Controls.Add(this.treeList1);
            base.Name = "FrmUserReport";
            this.Text = "FrmUserReport";
            base.Load += new EventHandler(this.FrmUserReport_Load);
            this.treeList1.EndInit();
            base.ResumeLayout(false);
        }
        private SimpleButton btn_Exit;
        private SimpleButton btn_Save;
        //private IContainer components;
        private ImageList imageList_0;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        private TreeList treeList1;

        #endregion

    }
}
