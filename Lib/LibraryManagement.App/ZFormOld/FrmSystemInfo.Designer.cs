using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    partial class FrmSystemInfo
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
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_FullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Fax = new DevExpress.XtraEditors.TextEdit();
            this.kCnalMegv = new DevExpress.XtraEditors.LabelControl();
            this.Txt_VatNumb = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Confirm = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Address = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chk_Minus = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Fax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VatNumb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_Minus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(262, 199);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "ESC-Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 13);
            this.labelControl1.TabIndex = 246;
            this.labelControl1.Text = "Tên công ty, doanh nghiệp";
            // 
            // Txt_FullName
            // 
            this.Txt_FullName.EnterMoveNextControl = true;
            this.Txt_FullName.Location = new System.Drawing.Point(170, 21);
            this.Txt_FullName.Name = "Txt_FullName";
            this.Txt_FullName.Size = new System.Drawing.Size(298, 20);
            this.Txt_FullName.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 248;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.EnterMoveNextControl = true;
            this.Txt_Phone.Location = new System.Drawing.Point(170, 73);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Size = new System.Drawing.Size(298, 20);
            this.Txt_Phone.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 250;
            this.labelControl3.Text = "Số điện thoại";
            // 
            // Txt_Fax
            // 
            this.Txt_Fax.EnterMoveNextControl = true;
            this.Txt_Fax.Location = new System.Drawing.Point(170, 99);
            this.Txt_Fax.Name = "Txt_Fax";
            this.Txt_Fax.Size = new System.Drawing.Size(298, 20);
            this.Txt_Fax.TabIndex = 3;
            // 
            // kCnalMegv
            // 
            this.kCnalMegv.Location = new System.Drawing.Point(21, 102);
            this.kCnalMegv.Name = "kCnalMegv";
            this.kCnalMegv.Size = new System.Drawing.Size(18, 13);
            this.kCnalMegv.TabIndex = 252;
            this.kCnalMegv.Text = "Fax";
            // 
            // Txt_VatNumb
            // 
            this.Txt_VatNumb.EnterMoveNextControl = true;
            this.Txt_VatNumb.Location = new System.Drawing.Point(170, 125);
            this.Txt_VatNumb.Name = "Txt_VatNumb";
            this.Txt_VatNumb.Size = new System.Drawing.Size(298, 20);
            this.Txt_VatNumb.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 128);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 254;
            this.labelControl5.Text = "Mã số thuế";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Confirm.Location = new System.Drawing.Point(162, 199);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(80, 23);
            this.btn_Confirm.TabIndex = 5;
            this.btn_Confirm.Text = "Thực hiện";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // Txt_Address
            // 
            this.Txt_Address.EnterMoveNextControl = true;
            this.Txt_Address.Location = new System.Drawing.Point(170, 47);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(298, 20);
            this.Txt_Address.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(-132, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 384;
            this.groupBox1.TabStop = false;
            // 
            // Chk_Minus
            // 
            this.Chk_Minus.Location = new System.Drawing.Point(168, 151);
            this.Chk_Minus.Name = "Chk_Minus";
            this.Chk_Minus.Properties.Caption = " Được phép xuất âm";
            this.Chk_Minus.Size = new System.Drawing.Size(145, 18);
            this.Chk_Minus.TabIndex = 385;
            // 
            // FrmSystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(499, 231);
            this.Controls.Add(this.Chk_Minus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.Txt_VatNumb);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Txt_Fax);
            this.Controls.Add(this.kCnalMegv);
            this.Controls.Add(this.Txt_Phone);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Txt_FullName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSystemInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSystemInfo";
            this.Load += new System.EventHandler(this.FrmSystemInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Fax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VatNumb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chk_Minus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private SimpleButton btn_Confirm;
        private SimpleButton btn_Exit;
        private CheckEdit Chk_Minus;
        internal GroupBox groupBox1;
        //private IContainer components;
        private LabelControl kCnalMegv;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private LabelControl labelControl5;
        private TextEdit Txt_Address;
        private TextEdit Txt_Fax;
        private TextEdit Txt_FullName;
        private TextEdit Txt_Phone;
        private TextEdit Txt_VatNumb;


        #endregion

    }
}
