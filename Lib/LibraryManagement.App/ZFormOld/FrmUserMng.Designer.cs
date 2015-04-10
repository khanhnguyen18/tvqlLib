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
    partial class FrmUserMng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserMng));
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Description = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.IipWvDcZu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.Tls_Menus1 = new DevExpress.XtraTreeList.TreeList();
            this.Txt_ShortName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tls_Menus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ShortName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(10, 42);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(54, 13);
            this.LabelControl3.TabIndex = 123;
            this.LabelControl3.Text = "Tên đầy đủ";
            // 
            // Txt_Description
            // 
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new System.Drawing.Point(114, 39);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Description.Properties.Appearance.Options.UseFont = true;
            this.Txt_Description.Size = new System.Drawing.Size(163, 20);
            this.Txt_Description.TabIndex = 122;
            this.Txt_Description.EditValueChanged += new System.EventHandler(this.Txt_Description_EditValueChanged);
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(10, 15);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(70, 13);
            this.LabelControl1.TabIndex = 121;
            this.LabelControl1.Text = "Người sử dụng";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox3.Location = new System.Drawing.Point(-50, 420);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(762, 5);
            this.GroupBox3.TabIndex = 119;
            this.GroupBox3.TabStop = false;
            // 
            // IipWvDcZu
            // 
            this.IipWvDcZu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IipWvDcZu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.IipWvDcZu.Location = new System.Drawing.Point(265, 431);
            this.IipWvDcZu.Name = "IipWvDcZu";
            this.IipWvDcZu.Size = new System.Drawing.Size(75, 23);
            this.IipWvDcZu.TabIndex = 412;
            this.IipWvDcZu.Text = "&Thoát";
            this.IipWvDcZu.Click += new System.EventHandler(this.IipWvDcZu_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(140, 431);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 410;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList_0.Images.SetKeyName(0, "FrmUserMng_16_0.png");
            this.imageList_0.Images.SetKeyName(1, "FrmUserMng_16_1.png");
            this.imageList_0.Images.SetKeyName(2, "FrmUserMng_16_2.png");
            // 
            // Tls_Menus1
            // 
            this.Tls_Menus1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tls_Menus1.Appearance.HeaderPanel.Options.UseFont = true;
            this.Tls_Menus1.Location = new System.Drawing.Point(6, 75);
            this.Tls_Menus1.Name = "Tls_Menus1";
            this.Tls_Menus1.OptionsBehavior.Editable = false;
            this.Tls_Menus1.OptionsSelection.MultiSelect = true;
            this.Tls_Menus1.Size = new System.Drawing.Size(469, 346);
            this.Tls_Menus1.StateImageList = this.imageList_0;
            this.Tls_Menus1.TabIndex = 437;
            this.Tls_Menus1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tls_Menus1_MouseDown);
            this.Tls_Menus1.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.Tls_Menus1_GetStateImage);
            // 
            // Txt_ShortName
            // 
            this.Txt_ShortName.EnterMoveNextControl = true;
            this.Txt_ShortName.Location = new System.Drawing.Point(114, 12);
            this.Txt_ShortName.Name = "Txt_ShortName";
            this.Txt_ShortName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ShortName.Properties.Appearance.Options.UseFont = true;
            this.Txt_ShortName.Size = new System.Drawing.Size(163, 20);
            this.Txt_ShortName.TabIndex = 438;
            this.Txt_ShortName.EditValueChanged += new System.EventHandler(this.Txt_ShortName_EditValueChanged);
            // 
            // FrmUserMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.IipWvDcZu;
            this.ClientSize = new System.Drawing.Size(481, 465);
            this.Controls.Add(this.Txt_ShortName);
            this.Controls.Add(this.Tls_Menus1);
            this.Controls.Add(this.IipWvDcZu);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmUserMng";
            this.Text = "FrmUserMng";
            this.Load += new System.EventHandler(this.FrmUserMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tls_Menus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ShortName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Save;
        internal GroupBox GroupBox3;
        //private IContainer components;
        private SimpleButton IipWvDcZu;
        private ImageList imageList_0;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl3;
        internal TreeList Tls_Menus1;
        internal TextEdit Txt_Description;
        internal TextEdit Txt_ShortName;


        #endregion
    }
}
