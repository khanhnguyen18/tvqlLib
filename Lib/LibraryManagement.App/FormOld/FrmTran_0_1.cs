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
    public partial class FrmTran_0_1 : DevExpress.XtraEditors.XtraForm
    {
        public FrmTran_0_1()
        {
            InitializeComponent();
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
            {
                string text = this.btn_Delete.Text;
                if ((text != null) && (text == "&X\x00f3a"))
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "trans_num", this.Txt_TransNum.Text.Trim(), "", this.oleDbConnection_0);
                    Class12.smethod_4(this.Txt_Account.EditValue.ToString(), this.double_0, true);
                    this.btn_Delete.Text = "&Phục hồi";
                }
                else
                {
                    Class7.smethod_23(base.Tag.ToString(), 1, "trans_num", this.Txt_TransNum.Text.Trim(), "", this.oleDbConnection_0);
                    Class12.smethod_2(this.Txt_Account.EditValue.ToString(), this.double_0, true);
                    this.btn_Delete.Text = "&X\x00f3a";
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_Account.Enabled = false;
            this.string_1 = "E";
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
            this.Txt_TransNum.Text = class2.method_5("A");
            this.string_1 = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Txt_Voucher.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o số chứng từ", 1);
                this.Txt_Voucher.Focus();
            }
            else if (this.Lbl_DbAccName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Số t\x00e0i khoản kh\x00f4ng hợp lệ", 1);
                this.Txt_Account.Focus();
            }
            else if (this.Txt_Remark.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o diễn giải giao dịch", 1);
                this.Txt_Remark.Focus();
            }
            else if (DateTime.Parse(Class7.smethod_19()).Subtract(DateTime.ParseExact(this.Txt_TranDate.Text, "dd/MM/yyyy", null)).TotalDays < 0.0)
            {
                Class7.ShowMessageBox("Ng\x00e0y hiệu lực kh\x00f4ng thể chọn trong tương lai", 1);
                this.Txt_TranDate.Focus();
            }
            else
            {
                string str2 = string.Format("{0:MM/dd/yyyy}", this.Txt_TranDate.EditValue);
                string str3 = this.Txt_Voucher.Text.Trim();
                string str4 = this.Txt_Account.EditValue.ToString();
                double num = Class7.smethod_0(this.Txt_Amount.Text);
                double num2 = 0.0;
                string str5 = string.Empty;
                string str6 = this.Txt_Remark.Text.Trim();
                string str = this.Txt_TransNum.Text.Trim();
                int num3 = 1;
                if (num <= 0.0)
                {
                    Class7.ShowMessageBox("Số tiền kh\x00f4ng hợp lệ", 1);
                    this.Txt_Amount.Focus();
                }
                else
                {
                    string str7 = this.string_1;
                    if (str7 != null)
                    {
                        if (!(str7 == "N"))
                        {
                            if (str7 == "E")
                            {
                                if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) != 1)
                                {
                                    return;
                                }
                                this.btn_Skip_Click(this, new EventArgs());
                                Class12.smethod_5(str4, this.Txt_TransNum.Text.Trim(), num, str6, true);
                                Class12.smethod_4(str4, this.double_0, true);
                                Class12.smethod_2(str4, num, true);
                            }
                        }
                        else
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            Class12.smethod_3(str, str2, str3, str4, num, num2, str5, str6, num3);
                            new Class6().ComputeTransnum("A");
                            Class12.smethod_2(str4, num, true);
                        }
                    }
                    Class6.transNum = this.Txt_TransNum.Text.Trim();
                    Class7.smethod_27(Class6.string_3).ShowPreviewDialog();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "S";
            this.Txt_TransNum.Enabled = true;
            this.Txt_TransNum.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }


        private void FrmTran_0_1_Load(object sender, EventArgs e)
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

        private void Txt_Account_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_Account.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_DbAccName.Text = str;
        }

        private void Txt_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = (this.Txt_Account.EditValue.ToString().Length != 0) ? this.Txt_Account.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_0 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_Account.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) && (this.string_1 == "S"))
            {
                this.string_0 = "SELECT tran_date, tran_time, ef_date, trans_num, voucher, trans_code, account_id, db_amount, cr_amount, user_id, corr_acc, remark, updated, recnum, status FROM tblAccTrans where trans_num = '" + this.Txt_TransNum.Text.Trim() + "' and trans_code = '" + this.Lbl_TranCode.Text + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_TranDate.Text = set.Tables[0].Rows[0]["tran_date"].ToString();
                        this.Txt_Account.Text = set.Tables[0].Rows[0]["account_id"].ToString();
                        this.Txt_Amount.EditValue = set.Tables[0].Rows[0]["db_amount"];
                        this.double_0 = Class7.smethod_2(set.Tables[0].Rows[0]["db_amount"]);
                        this.Txt_Remark.Text = set.Tables[0].Rows[0]["remark"].ToString();
                        this.Txt_Voucher.Text = set.Tables[0].Rows[0]["voucher"].ToString();
                        this.btn_Delete.Text = (set.Tables[0].Rows[0]["status"].ToString() == "1") ? "&X\x00f3a" : "&Phục hồi";
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                    }
                    else
                    {
                        Class7.ShowMessageBox("Giao dịch kh\x00f4ng tồn tại", 1);
                        this.btn_Skip_Click(this, new EventArgs());
                    }
                }
            }
        }
  
    }
}