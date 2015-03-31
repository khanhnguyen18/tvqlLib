
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    partial class FrmSuppInfo
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
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Contactperson = new DevExpress.XtraEditors.TextEdit();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_VatNumber = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Id = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Fax = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Address = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_ShortName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuppMerc = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrans = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Detail = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Contactperson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VatNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Fax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ShortName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelControl11
            // 
            this.LabelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl11.Appearance.Options.UseFont = true;
            this.LabelControl11.Location = new System.Drawing.Point(33, 157);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(62, 13);
            this.LabelControl11.TabIndex = 370;
            this.LabelControl11.Text = "Người liên hệ";
            // 
            // Txt_Contactperson
            // 
            this.Txt_Contactperson.EnterMoveNextControl = true;
            this.Txt_Contactperson.Location = new System.Drawing.Point(108, 154);
            this.Txt_Contactperson.Name = "Txt_Contactperson";
            this.Txt_Contactperson.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contactperson.Properties.Appearance.Options.UseFont = true;
            this.Txt_Contactperson.Size = new System.Drawing.Size(415, 20);
            this.Txt_Contactperson.TabIndex = 358;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Location = new System.Drawing.Point(-122, 64);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(762, 5);
            this.GroupBox2.TabIndex = 369;
            this.GroupBox2.TabStop = false;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(34, 155);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(18, 13);
            this.LabelControl5.TabIndex = 368;
            this.LabelControl5.Text = "Fax";
            // 
            // LabelControl10
            // 
            this.LabelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl10.Appearance.Options.UseFont = true;
            this.LabelControl10.Location = new System.Drawing.Point(315, 131);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(53, 13);
            this.LabelControl10.TabIndex = 367;
            this.LabelControl10.Text = "Mã số thuế";
            // 
            // Txt_VatNumber
            // 
            this.Txt_VatNumber.EnterMoveNextControl = true;
            this.Txt_VatNumber.Location = new System.Drawing.Point(379, 128);
            this.Txt_VatNumber.Name = "Txt_VatNumber";
            this.Txt_VatNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_VatNumber.Properties.Appearance.Options.UseFont = true;
            this.Txt_VatNumber.Size = new System.Drawing.Size(144, 20);
            this.Txt_VatNumber.TabIndex = 357;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(34, 15);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(28, 13);
            this.LabelControl4.TabIndex = 365;
            this.LabelControl4.Text = "Mã số";
            // 
            // Txt_Id
            // 
            this.Txt_Id.EnterMoveNextControl = true;
            this.Txt_Id.Location = new System.Drawing.Point(108, 12);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.Txt_Id.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Id.Properties.Appearance.Options.UseBackColor = true;
            this.Txt_Id.Properties.Appearance.Options.UseFont = true;
            this.Txt_Id.Properties.Mask.PlaceHolder = ' ';
            this.Txt_Id.Properties.MaxLength = 5;
            this.Txt_Id.Properties.ValidateOnEnterKey = true;
            this.Txt_Id.Size = new System.Drawing.Size(123, 20);
            this.Txt_Id.TabIndex = 0;
            this.Txt_Id.EditValueChanged += new System.EventHandler(this.Txt_Id_EditValueChanged);
            this.Txt_Id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Id_KeyDown);
            // 
            // Txt_Fax
            // 
            this.Txt_Fax.EnterMoveNextControl = true;
            this.Txt_Fax.Location = new System.Drawing.Point(108, 128);
            this.Txt_Fax.Name = "Txt_Fax";
            this.Txt_Fax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Fax.Properties.Appearance.Options.UseFont = true;
            this.Txt_Fax.Size = new System.Drawing.Size(183, 20);
            this.Txt_Fax.TabIndex = 356;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(34, 105);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(62, 13);
            this.LabelControl2.TabIndex = 362;
            this.LabelControl2.Text = "Số điện thoại";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(34, 79);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(32, 13);
            this.LabelControl1.TabIndex = 361;
            this.LabelControl1.Text = "Địa chỉ";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.EnterMoveNextControl = true;
            this.Txt_Phone.Location = new System.Drawing.Point(108, 102);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Phone.Properties.Appearance.Options.UseFont = true;
            this.Txt_Phone.Size = new System.Drawing.Size(415, 20);
            this.Txt_Phone.TabIndex = 355;
            // 
            // Txt_Address
            // 
            this.Txt_Address.EnterMoveNextControl = true;
            this.Txt_Address.Location = new System.Drawing.Point(108, 76);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Address.Properties.Appearance.Options.UseFont = true;
            this.Txt_Address.Size = new System.Drawing.Size(415, 20);
            this.Txt_Address.TabIndex = 354;
            // 
            // LabelControl14
            // 
            this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelControl14.Appearance.Options.UseFont = true;
            this.LabelControl14.Location = new System.Drawing.Point(33, 41);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(40, 13);
            this.LabelControl14.TabIndex = 359;
            this.LabelControl14.Text = "Diễn giải";
            // 
            // Txt_ShortName
            // 
            this.Txt_ShortName.EnterMoveNextControl = true;
            this.Txt_ShortName.Location = new System.Drawing.Point(108, 38);
            this.Txt_ShortName.Name = "Txt_ShortName";
            this.Txt_ShortName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ShortName.Properties.Appearance.Options.UseFont = true;
            this.Txt_ShortName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Txt_ShortName.Size = new System.Drawing.Size(415, 20);
            this.Txt_ShortName.TabIndex = 352;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(33, 131);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 13);
            this.labelControl6.TabIndex = 371;
            this.labelControl6.Text = "Fax";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(382, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "ESC-Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSuppMerc
            // 
            this.btnSuppMerc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSuppMerc.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppMerc.Appearance.Options.UseFont = true;
            this.btnSuppMerc.Location = new System.Drawing.Point(88, 202);
            this.btnSuppMerc.Name = "btnSuppMerc";
            this.btnSuppMerc.Size = new System.Drawing.Size(75, 23);
            this.btnSuppMerc.TabIndex = 1;
            this.btnSuppMerc.Text = "&Hàng tồn";
            this.btnSuppMerc.Click += new System.EventHandler(this.btnSuppMerc_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTrans.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.Appearance.Options.UseFont = true;
            this.btnTrans.Location = new System.Drawing.Point(186, 202);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(75, 23);
            this.btnTrans.TabIndex = 2;
            this.btnTrans.Text = "&Giao dịch";
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Location = new System.Drawing.Point(-109, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 5);
            this.groupBox1.TabIndex = 375;
            this.groupBox1.TabStop = false;
            // 
            // btn_Detail
            // 
            this.btn_Detail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Detail.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detail.Appearance.Options.UseFont = true;
            this.btn_Detail.Location = new System.Drawing.Point(284, 202);
            this.btn_Detail.Name = "btn_Detail";
            this.btn_Detail.Size = new System.Drawing.Size(75, 23);
            this.btn_Detail.TabIndex = 376;
            this.btn_Detail.Text = "&Chi tiết";
            this.btn_Detail.Click += new System.EventHandler(this.btn_Detail_Click);
            // 
            // FrmSuppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(545, 237);
            this.Controls.Add(this.btn_Detail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSuppMerc);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.LabelControl11);
            this.Controls.Add(this.Txt_Contactperson);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.LabelControl5);
            this.Controls.Add(this.LabelControl10);
            this.Controls.Add(this.Txt_VatNumber);
            this.Controls.Add(this.LabelControl4);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Txt_Fax);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.Txt_Phone);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.LabelControl14);
            this.Controls.Add(this.Txt_ShortName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSuppInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuppInfo";
            this.Load += new System.EventHandler(this.FrmSuppInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Contactperson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_VatNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Fax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ShortName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal SimpleButton btn_Detail;
        internal SimpleButton btnExit;
        internal SimpleButton btnSuppMerc;
        internal SimpleButton btnTrans;
        internal GroupBox groupBox1;
        internal GroupBox GroupBox2;
        //private IContainer components;
        internal LabelControl LabelControl1;
        internal LabelControl LabelControl10;
        internal LabelControl LabelControl11;
        internal LabelControl LabelControl14;
        internal LabelControl LabelControl2;
        internal LabelControl LabelControl4;
        internal LabelControl LabelControl5;
        internal LabelControl labelControl6;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private string string_0;
        internal TextEdit Txt_Address;
        internal TextEdit Txt_Contactperson;
        internal TextEdit Txt_Fax;
        internal TextEdit Txt_Id;
        internal TextEdit Txt_Phone;
        internal TextEdit Txt_ShortName;
        internal TextEdit Txt_VatNumber;


        #endregion

    }
}
