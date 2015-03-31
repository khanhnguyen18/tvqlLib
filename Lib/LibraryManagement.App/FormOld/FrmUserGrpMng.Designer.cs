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
    partial class FrmUserGrpMng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserGrpMng));
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Tls_Menus = new DevExpress.XtraTreeList.TreeList();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Description = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ShortName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Tls_Menus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ShortName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(249, 420);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 418;
            this.btn_Exit.Text = "&Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(149, 420);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 416;
            this.btn_Save.Text = "&Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupBox3.Location = new System.Drawing.Point(-12, 409);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(762, 5);
            this.GroupBox3.TabIndex = 415;
            this.GroupBox3.TabStop = false;
            // 
            // Tls_Menus
            // 
            this.Tls_Menus.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tls_Menus.Appearance.HeaderPanel.Options.UseFont = true;
            this.Tls_Menus.Location = new System.Drawing.Point(7, 71);
            this.Tls_Menus.Name = "Tls_Menus";
            this.Tls_Menus.OptionsSelection.MultiSelect = true;
            this.Tls_Menus.Size = new System.Drawing.Size(460, 339);
            this.Tls_Menus.StateImageList = this.imageList_0;
            this.Tls_Menus.TabIndex = 425;
            this.Tls_Menus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tls_Menus_MouseDown);
            this.Tls_Menus.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.Tls_Menus_GetStateImage);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList_0.Images.SetKeyName(0, "FrmUserGrpMng_16_0.png");
            this.imageList_0.Images.SetKeyName(1, "FrmUserGrpMng_16_1.png");
            this.imageList_0.Images.SetKeyName(2, "FrmUserGrpMng_16_2.png");
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(12, 42);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(54, 13);
            this.LabelControl3.TabIndex = 424;
            this.LabelControl3.Text = "Tên đầy đủ";
            // 
            // Txt_Description
            // 
            this.Txt_Description.EnterMoveNextControl = true;
            this.Txt_Description.Location = new System.Drawing.Point(116, 39);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Description.Properties.Appearance.Options.UseFont = true;
            this.Txt_Description.Size = new System.Drawing.Size(163, 20);
            this.Txt_Description.TabIndex = 423;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(12, 15);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(70, 13);
            this.LabelControl1.TabIndex = 422;
            this.LabelControl1.Text = "Người sử dụng";
            // 
            // Txt_ShortName
            // 
            this.Txt_ShortName.EnterMoveNextControl = true;
            this.Txt_ShortName.Location = new System.Drawing.Point(116, 12);
            this.Txt_ShortName.Name = "Txt_ShortName";
            this.Txt_ShortName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ShortName.Properties.Appearance.Options.UseFont = true;
            this.Txt_ShortName.Size = new System.Drawing.Size(163, 20);
            this.Txt_ShortName.TabIndex = 439;
            this.Txt_ShortName.EditValueChanged += new System.EventHandler(this.Txt_ShortName_EditValueChanged);
            // 
            // FrmUserGrpMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(479, 455);
            this.Controls.Add(this.Txt_ShortName);
            this.Controls.Add(this.Tls_Menus);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.Txt_Description);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUserGrpMng";
            this.Text = "FrmUserGrpMng";
            this.Load += new System.EventHandler(this.FrmUserGrpMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tls_Menus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ShortName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private SimpleButton btn_Exit;
        private SimpleButton btn_Save;
        internal GroupBox GroupBox3;
        //private IContainer components;
        private ImageList imageList_0;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl3;
        internal TreeList Tls_Menus;
        internal TextEdit Txt_Description;
        internal TextEdit Txt_ShortName;

        #endregion

    }
}
