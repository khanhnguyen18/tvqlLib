using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    public partial class FrmTran_1_n : DevExpress.XtraEditors.XtraForm
    {
        public FrmTran_1_n()
        {
            InitializeComponent();
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.string_0 = "E";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_5(this, "T");
            Class11.smethod_1(this);
            Class6 class2 = new Class6();
            this.Txt_TranDate.Text = Class7.smethod_19();
            this.ddvqeXfa4.Text = class2.method_5("A");
            this.string_0 = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(Class7.smethod_19()).Subtract(DateTime.ParseExact(this.Txt_TranDate.Text, "dd/MM/yyyy", null)).TotalDays < 0.0)
            {
                Class7.ShowMessageBox("Ng\x00e0y hiệu lực kh\x00f4ng thể chọn trong tương lai", 1);
                this.Txt_TranDate.Focus();
            }
            else if (this.Txt_Voucher.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o số chứng từ", 1);
                this.Txt_Voucher.Focus();
            }
            else if (this.Txt_Remark.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o diễn giải giao dịch", 1);
                this.Txt_Remark.Focus();
            }
            else if (Class7.ParseDoubleValue(this.Txt_DbAmt1.Text) <= 0.0)
            {
                Class7.ShowMessageBox("Số tiền kh\x00f4ng hợp lệ", 1);
                this.Txt_DbAmt1.Focus();
            }
            else
            {
                string str = string.Format("{0:MM/dd/yyyy}", this.Txt_TranDate.EditValue);
                string str2 = this.Txt_Voucher.Text.Trim();
                string str3 = this.Txt_CreAccId.EditValue.ToString();
                double num2 = Class7.ParseDoubleValue(this.Txt_DbAmt1.Text);
                double num3 = Class7.ParseDoubleValue(this.Txt_DbAmt2.Text);
                double num = Class7.ParseDoubleValue(this.Txt_DbAmt3.Text);
                string str4 = this.Txt_Remark.Text.Trim();
                string str5 = this.ddvqeXfa4.Text.Trim();
                if (this.Lbl_CreAccName.Text == string.Empty)
                {
                    Class7.ShowMessageBox("T\x00e0i khoản ghi c\x00f3 kh\x00f4ng hợp lệ", 1);
                    this.Txt_CreAccId.Focus();
                }
                else
                {
                    string str6 = this.string_0;
                    if (str6 != null)
                    {
                        if (!(str6 == "N"))
                        {
                            if (str6 == "E")
                            {
                                this.btn_Skip_Click(this, new EventArgs());
                            }
                        }
                        else
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            Class12.smethod_3(str5, str, str2, str3, 0.0, num2, this.Txt_DbAccId1.EditValue.ToString(), str4, 2);
                            Class12.smethod_3(str5, str, str2, this.Txt_DbAccId1.EditValue.ToString(), num2, 0.0, str3, str4, 1);
                            if ((num3 > 0.0) && (this.Lbl_DbAccName2.Text != string.Empty))
                            {
                                Class12.smethod_3(str5, str, str2, str3, 0.0, num3, this.Txt_DbAccId2.EditValue.ToString(), str4, 4);
                                Class12.smethod_3(str5, str, str2, this.Txt_DbAccId2.EditValue.ToString(), num3, 0.0, str3, str4, 3);
                            }
                            if ((num > 0.0) && (this.Lbl_DbAccName3.Text != string.Empty))
                            {
                                Class12.smethod_3(str5, str, str2, str3, 0.0, num, this.Txt_DbAccId3.EditValue.ToString(), str4, 6);
                                Class12.smethod_3(str5, str, str2, this.Txt_DbAccId3.EditValue.ToString(), num, 0.0, str3, str4, 5);
                            }
                            Class12.smethod_2(this.Txt_DbAccId1.EditValue.ToString(), num2, true);
                            Class12.smethod_2(this.Txt_DbAccId2.EditValue.ToString(), num3, true);
                            Class12.smethod_2(this.Txt_DbAccId3.EditValue.ToString(), num, true);
                            Class12.smethod_2(this.Txt_CreAccId.EditValue.ToString(), Class7.ParseDoubleValue(this.Lbl_CreditAmt.Text), false);
                            new Class6().ComputeTransnum("A");
                        }
                    }
                    Class6.transNum = this.ddvqeXfa4.Text.Trim();
                    Class7.CreateReportInstance(Class6.string_3).ShowPreviewDialog();
                }
            }
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "D";
        }

        private void FrmTran_1_n_Load(object sender, EventArgs e)
        {
            this.Lbl_TranCode.Text = Class6.string_2;
            this.btn_Skip_Click(this, new EventArgs());
            Class11.smethod_8(this);
            this.Text = Class6.string_1;
            base.Tag = "tblAccTrans";
            this.Lbl_Today.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void Lbl_TranCode_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("trans_name", "tblAtrcode", "trans_code", this.Lbl_TranCode.Text, "", this.oleDbConnection_0, ref str);
            this.Lbl_TranName.Text = str;
        }

        private void pfeZyQnoF(object sender, KeyEventArgs e)
        {
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            try
            {
                double num = (Class7.ParseDoubleValue(this.Txt_DbAmt3.Text) + Class7.ParseDoubleValue(this.Txt_DbAmt2.Text)) + Class7.ParseDoubleValue(this.Txt_DbAmt1.Text);
                this.Lbl_CreditAmt.Text = string.Format("{0:n2}", num);
            }
            catch (Exception)
            {
                this.Lbl_CreditAmt.Text = "0.00";
            }
        }

        private void Txt_CreAccId_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_CreAccId.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_CreAccName.Text = str;
        }

        private void Txt_CreAccId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = (this.Txt_CreAccId.EditValue.ToString().Length != 0) ? this.Txt_CreAccId.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm1(this.string_1, this.oleDbConnection_0);
                this.Txt_CreAccId.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_DbAccId1_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_DbAccId1.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_DbAccName1.Text = str;
        }

        private void Txt_DbAccId1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = (this.Txt_DbAccId1.EditValue.ToString().Length != 0) ? this.Txt_DbAccId1.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm1(this.string_1, this.oleDbConnection_0);
                this.Txt_DbAccId1.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_DbAccId2_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_DbAccId2.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_DbAccName2.Text = str;
        }

        private void Txt_DbAccId2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = (this.Txt_DbAccId2.EditValue.ToString().Length != 0) ? this.Txt_DbAccId2.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm1(this.string_1, this.oleDbConnection_0);
                this.Txt_DbAccId2.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_DbAccId3_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_DbAccId3.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_DbAccName3.Text = str;
        }

        private void Txt_DbAccId3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = (this.Txt_DbAccId3.EditValue.ToString().Length != 0) ? this.Txt_DbAccId3.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm1(this.string_1, this.oleDbConnection_0);
                this.Txt_DbAccId3.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_DbAmt2_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void welftZbha_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "S";
            this.ddvqeXfa4.Enabled = true;
            this.ddvqeXfa4.Focus();
        }
   
    }
}