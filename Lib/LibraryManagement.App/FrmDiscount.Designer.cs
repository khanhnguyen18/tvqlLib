using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    partial class FrmDiscount
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
            this.Lbl_GrpName = new LabelControl();
            this.LabelControl3 = new LabelControl();
            this.Txt_GoodsGrp = new TextEdit();
            this.LabelControl18 = new LabelControl();
            this.Txt_DiscPercent = new TextEdit();
            this.Txt_FrDate = new TextEdit();
            this.LabelControl17 = new LabelControl();
            this.Txt_ToDate = new TextEdit();
            this.IipWvDcZu = new LabelControl();
            this.radioGroup1 = new RadioGroup();
            this.btn_Confirm = new SimpleButton();
            this.btn_Exit = new SimpleButton();
            this.groupBox1 = new GroupBox();
            this.labelControl1 = new LabelControl();
            this.timer_0 = new Timer(this.components);
            this.Txt_GoodsGrp.Properties.BeginInit();
            this.Txt_DiscPercent.Properties.BeginInit();
            this.Txt_FrDate.Properties.BeginInit();
            this.Txt_ToDate.Properties.BeginInit();
            this.radioGroup1.Properties.BeginInit();
            base.SuspendLayout();
            this.Lbl_GrpName.Appearance.BackColor = Color.MediumTurquoise;
            this.Lbl_GrpName.Appearance.BackColor2 = Color.PaleTurquoise;
            this.Lbl_GrpName.Appearance.BorderColor = Color.White;
            this.Lbl_GrpName.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Lbl_GrpName.Appearance.ForeColor = Color.Black;
            this.Lbl_GrpName.Appearance.Options.UseBackColor = true;
            this.Lbl_GrpName.Appearance.Options.UseBorderColor = true;
            this.Lbl_GrpName.Appearance.Options.UseFont = true;
            this.Lbl_GrpName.Appearance.Options.UseForeColor = true;
            this.Lbl_GrpName.AutoSizeMode = LabelAutoSizeMode.None;
            this.Lbl_GrpName.BorderStyle = BorderStyles.UltraFlat;
            this.Lbl_GrpName.Location = new Point(0xd3, 0x4e);
            this.Lbl_GrpName.Name = "Lbl_GrpName";
            this.Lbl_GrpName.Padding = new Padding(3, 0, 0, 0);
            this.Lbl_GrpName.Size = new Size(0xd4, 0x11);
            this.Lbl_GrpName.TabIndex = 0x17a;
            this.LabelControl3.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new Point(0x20, 80);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new Size(0x36, 13);
            this.LabelControl3.TabIndex = 0x179;
            this.LabelControl3.Text = "Nh\x00f3m h\x00e0ng";
            this.Txt_GoodsGrp.EnterMoveNextControl = true;
            this.Txt_GoodsGrp.Location = new Point(0x75, 0x4b);
            this.Txt_GoodsGrp.Name = "Txt_GoodsGrp";
            this.Txt_GoodsGrp.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_GoodsGrp.Properties.Appearance.Options.UseFont = true;
            this.Txt_GoodsGrp.Properties.CharacterCasing = CharacterCasing.Upper;
            this.Txt_GoodsGrp.Size = new Size(0x58, 20);
            this.Txt_GoodsGrp.TabIndex = 0x178;
            this.Txt_GoodsGrp.EditValueChanged += new EventHandler(this.Txt_GoodsGrp_EditValueChanged);
            this.Txt_GoodsGrp.KeyDown += new KeyEventHandler(this.Txt_GoodsGrp_KeyDown);
            this.LabelControl18.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl18.Appearance.Options.UseFont = true;
            this.LabelControl18.Location = new Point(0x20, 130);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new Size(40, 13);
            this.LabelControl18.TabIndex = 0x180;
            this.LabelControl18.Text = "Giảm gi\x00e1";
            int[] bits = new int[4];
            this.Txt_DiscPercent.EditValue = new decimal(bits);
            this.Txt_DiscPercent.EnterMoveNextControl = true;
            this.Txt_DiscPercent.Location = new Point(0x75, 0x7f);
            this.Txt_DiscPercent.Name = "Txt_DiscPercent";
            this.Txt_DiscPercent.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_DiscPercent.Properties.Appearance.Options.UseFont = true;
            this.Txt_DiscPercent.Properties.Appearance.Options.UseTextOptions = true;
            this.Txt_DiscPercent.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            this.Txt_DiscPercent.Properties.DisplayFormat.FormatString = "P1";
            this.Txt_DiscPercent.Properties.DisplayFormat.FormatType = FormatType.Numeric;
            this.Txt_DiscPercent.Properties.EditFormat.FormatString = "P1";
            this.Txt_DiscPercent.Properties.EditFormat.FormatType = FormatType.Numeric;
            this.Txt_DiscPercent.Properties.Mask.EditMask = "P1";
            this.Txt_DiscPercent.Properties.Mask.MaskType = MaskType.Numeric;
            this.Txt_DiscPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_DiscPercent.Size = new Size(0x58, 20);
            this.Txt_DiscPercent.TabIndex = 0x17d;
            this.Txt_FrDate.EditValue = new DateTime(0x7d8, 4, 0x18, 13, 0x34, 0x2b, 0x1a5);
            this.Txt_FrDate.EnterMoveNextControl = true;
            this.Txt_FrDate.Location = new Point(0x75, 0x65);
            this.Txt_FrDate.Name = "Txt_FrDate";
            this.Txt_FrDate.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_FrDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_FrDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_FrDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_FrDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_FrDate.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_FrDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_FrDate.Size = new Size(0x58, 20);
            this.Txt_FrDate.TabIndex = 0x17b;
            this.LabelControl17.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelControl17.Appearance.Options.UseFont = true;
            this.LabelControl17.Location = new Point(0x20, 0x68);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new Size(40, 13);
            this.LabelControl17.TabIndex = 0x17f;
            this.LabelControl17.Text = "Từ ng\x00e0y";
            this.Txt_ToDate.EditValue = new DateTime(0x7d8, 4, 0x18, 13, 0x34, 0x2b, 0x1a5);
            this.Txt_ToDate.EnterMoveNextControl = true;
            this.Txt_ToDate.Location = new Point(0x14f, 0x65);
            this.Txt_ToDate.Name = "Txt_ToDate";
            this.Txt_ToDate.Properties.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Txt_ToDate.Properties.Appearance.Options.UseFont = true;
            this.Txt_ToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
            this.Txt_ToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.EditFormat.FormatType = FormatType.DateTime;
            this.Txt_ToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.Txt_ToDate.Properties.Mask.MaskType = MaskType.DateTime;
            this.Txt_ToDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Txt_ToDate.Size = new Size(0x58, 20);
            this.Txt_ToDate.TabIndex = 380;
            this.IipWvDcZu.Appearance.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.IipWvDcZu.Appearance.Options.UseFont = true;
            this.IipWvDcZu.Location = new Point(0x111, 0x68);
            this.IipWvDcZu.Name = "LabelControl16";
            this.IipWvDcZu.Size = new Size(0x2d, 13);
            this.IipWvDcZu.TabIndex = 0x17e;
            this.IipWvDcZu.Text = "đến ng\x00e0y";
            this.radioGroup1.Location = new Point(0x20, 0x2c);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new RadioGroupItem[] { new RadioGroupItem(null, "Giảm theo nh\x00f3m"), new RadioGroupItem(null, "Giảm to\x00e0n bộ c\x00e1c mặt h\x00e0ng") });
            this.radioGroup1.Size = new Size(0x187, 0x19);
            this.radioGroup1.TabIndex = 0x181;
            this.btn_Confirm.Anchor = AnchorStyles.Bottom;
            this.btn_Confirm.Location = new Point(0x8b, 0xad);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new Size(80, 0x17);
            this.btn_Confirm.TabIndex = 0x182;
            this.btn_Confirm.Text = "Thực hiện";
            this.btn_Confirm.Click += new EventHandler(this.btn_Confirm_Click);
            this.btn_Exit.Anchor = AnchorStyles.Bottom;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new Point(0xef, 0xad);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new Size(80, 0x17);
            this.btn_Exit.TabIndex = 0x183;
            this.btn_Exit.Text = "ESC-Tho\x00e1t";
            this.btn_Exit.Click += new EventHandler(this.btn_Exit_Click);
            this.groupBox1.Location = new Point(-152, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x2fa, 5);
            this.groupBox1.TabIndex = 0x184;
            this.groupBox1.TabStop = false;
            this.labelControl1.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new Point(0x20, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new Size(0x14e, 0x13);
            this.labelControl1.TabIndex = 0x185;
            this.labelControl1.Text = "CHƯƠNG TR\x00ccNH KHUYẾN MẠI, GIẢM GI\x00c1";
            this.timer_0.Enabled = true;
            this.timer_0.Interval = 300;
            this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.CancelButton = this.btn_Exit;
            base.ClientSize = new Size(0x1ca, 0xce);
            base.Controls.Add(this.labelControl1);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btn_Confirm);
            base.Controls.Add(this.btn_Exit);
            base.Controls.Add(this.radioGroup1);
            base.Controls.Add(this.LabelControl18);
            base.Controls.Add(this.Txt_DiscPercent);
            base.Controls.Add(this.Txt_FrDate);
            base.Controls.Add(this.LabelControl17);
            base.Controls.Add(this.Txt_ToDate);
            base.Controls.Add(this.IipWvDcZu);
            base.Controls.Add(this.Lbl_GrpName);
            base.Controls.Add(this.LabelControl3);
            base.Controls.Add(this.Txt_GoodsGrp);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.Name = "FrmDiscount";
            this.Text = "FrmDiscount";
            base.Load += new EventHandler(this.FrmDiscount_Load);
            this.Txt_GoodsGrp.Properties.EndInit();
            this.Txt_DiscPercent.Properties.EndInit();
            this.Txt_FrDate.Properties.EndInit();
            this.Txt_ToDate.Properties.EndInit();
            this.radioGroup1.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private SimpleButton btn_Confirm;
        private SimpleButton btn_Exit;
        internal GroupBox groupBox1;
        //private IContainer components;
        internal LabelControl IipWvDcZu;
        internal LabelControl labelControl1;
        internal LabelControl LabelControl17;
        internal LabelControl LabelControl18;
        internal LabelControl LabelControl3;
        internal LabelControl Lbl_GrpName;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private RadioGroup radioGroup1;
        private string string_0;
        private Timer timer_0;
        internal TextEdit Txt_DiscPercent;
        internal TextEdit Txt_FrDate;
        internal TextEdit Txt_GoodsGrp;
        internal TextEdit Txt_ToDate;

        #endregion
    }
}
