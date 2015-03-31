using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmTransCode
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
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_TransCode = new DevExpress.XtraEditors.TextEdit();
            this.LstTransCode = new DevExpress.XtraEditors.ListBoxControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LstTransCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(17, 23);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(64, 13);
            this.LabelControl1.TabIndex = 115;
            this.LabelControl1.Text = "Loại giao dịch";
            // 
            // Txt_TransCode
            // 
            this.Txt_TransCode.EnterMoveNextControl = true;
            this.Txt_TransCode.Location = new System.Drawing.Point(117, 20);
            this.Txt_TransCode.Name = "Txt_TransCode";
            this.Txt_TransCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TransCode.Properties.Appearance.Options.UseFont = true;
            this.Txt_TransCode.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_TransCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Txt_TransCode.Size = new System.Drawing.Size(233, 20);
            this.Txt_TransCode.TabIndex = 114;
            // 
            // LstTransCode
            // 
            this.LstTransCode.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstTransCode.Appearance.Options.UseFont = true;
            this.LstTransCode.Location = new System.Drawing.Point(12, 46);
            this.LstTransCode.Name = "LstTransCode";
            this.LstTransCode.Size = new System.Drawing.Size(338, 188);
            this.LstTransCode.TabIndex = 113;
            this.LstTransCode.DoubleClick += new System.EventHandler(this.LstTransCode_DoubleClick);
            this.LstTransCode.Click += new System.EventHandler(this.LstTransCode_Click);
            this.LstTransCode.SelectedIndexChanged += new System.EventHandler(this.LstTransCode_SelectedIndexChanged);
            this.LstTransCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstTransCode_KeyDown);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(12, 240);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit1.Size = new System.Drawing.Size(338, 46);
            this.memoEdit1.TabIndex = 377;
            // 
            // FrmTransCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 295);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.Txt_TransCode);
            this.Controls.Add(this.LstTransCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmTransCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Chọn loại giao dịch";
            this.Load += new System.EventHandler(this.FrmTransCode_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTransCode_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_TransCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LstTransCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private IContainer components;
        internal LabelControl LabelControl1;
        internal ListBoxControl LstTransCode;
        private MemoEdit memoEdit1;
        internal TextEdit Txt_TransCode;


        #endregion

    }
}
