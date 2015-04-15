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
    public partial class FrmPaymentOrder : DevExpress.XtraEditors.XtraForm
    {
        public FrmPaymentOrder()
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
                    Class12.smethod_4(this.Txt_CreAccId.EditValue.ToString(), this.double_0, true);
                    Class12.smethod_4(this.Txt_DbAccId.EditValue.ToString(), this.double_0, false);
                    this.btn_Delete.Text = "&Phục hồi";
                }
                else
                {
                    Class7.smethod_23(base.Tag.ToString(), 1, "trans_num", this.Txt_TransNum.Text.Trim(), "", this.oleDbConnection_0);
                    Class12.smethod_2(this.Txt_CreAccId.EditValue.ToString(), this.double_0, true);
                    Class12.smethod_4(this.Txt_DbAccId.EditValue.ToString(), this.double_0, false);
                    this.btn_Delete.Text = "&X\x00f3a";
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.IjSwogAv6 = "E";
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
            this.IjSwogAv6 = "N";
            this.Txt_Payer.Text = "Cty CP TM&DV Ohayo mart VN";
            this.Txt_PayAccId.Text = "11522358042013";
            this.Txt_PayerBank.Text = "Techcombank - CN Ba Đ\x00ecnh";
            this.Txt_PayerBranch.Text = "132-138 Kim M\x00e3, TP.H\x00e0 Nội";
            this.Txt_CreAccId.Text = "1121";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataSet set;
            if (DateTime.Parse(Class7.smethod_19()).Subtract(DateTime.ParseExact(this.Txt_TranDate.Text, "dd/MM/yyyy", null)).TotalDays < 0.0)
            {
                Class7.ShowMessageBox("Ng\x00e0y hiệu lực kh\x00f4ng thể chọn trong tương lai", 1);
                this.Txt_TranDate.Focus();
                return;
            }
            if (this.Txt_Voucher.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o số chứng từ", 1);
                this.Txt_Voucher.Focus();
                return;
            }
            if (this.Txt_Remark.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o diễn giải giao dịch", 1);
                this.Txt_Remark.Focus();
                return;
            }
            if (Class7.ParseDoubleValue(this.Txt_Amount.Text) <= 0.0)
            {
                Class7.ShowMessageBox("Số tiền kh\x00f4ng hợp lệ", 1);
                this.Txt_Amount.Focus();
                return;
            }
            string str = string.Format("{0:MM/dd/yyyy}", this.Txt_TranDate.EditValue);
            string str2 = this.Txt_Voucher.Text.Trim();
            string str3 = this.Txt_DbAccId.EditValue.ToString();
            double num = Class7.ParseDoubleValue(this.Txt_Amount.Text);
            double num2 = Class7.ParseDoubleValue(this.Txt_Amount.Text);
            string str4 = this.Txt_CreAccId.EditValue.ToString();
            string str5 = this.Txt_Remark.Text.Trim();
            string str6 = this.Txt_Payer.Text.Trim();
            string str7 = this.Txt_PayAccId.Text.Trim();
            string str8 = this.Txt_PayerBank.Text.Trim();
            string str9 = this.Txt_PayerBranch.Text.Trim();
            string str10 = this.Txt_Beneficiary.Text.Trim();
            string str11 = this.Txt_BenAccId.Text.Trim();
            string str12 = this.Txt_BenBank.Text.Trim();
            string str13 = this.Txt_BenBranch.Text.Trim();
            double num3 = Class7.ParseDoubleValue(this.Txt_Amount.Text);
            string str14 = this.Txt_TransNum.Text.Trim();
            string str15 = this.IjSwogAv6;
            switch (str15)
            {
                case null:
                    goto Label_0740;

                case "N":
                    break;

                default:
                    {
                        if (!(str15 == "E"))
                        {
                            goto Label_0740;
                        }
                        if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) != 1)
                        {
                            return;
                        }
                        this.iWyIskLbe(this, new EventArgs());
                        this.string_0 = "select account_id, db_amount, cr_amount from tblAccTrans where trans_num = '" + this.Txt_TransNum.Text.Trim() + "'";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (DataTable table = new DataTable())
                        {
                            this.oleDbDataAdapter_0.Fill(table);
                            foreach (DataRow row in table.Rows)
                            {
                                this.string_0 = string.Concat(new object[] { "update tblAccount set debamt = debamt - ", row["db_amount"], ",creamt = creamt - ", row["db_amount"], " where account_id = '", row["account_id"], "'" });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                                using (set = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set);
                                    this.oleDbConnection_0.Close();
                                    continue;
                                }
                            }
                        }
                        this.string_0 = "delete from tblAccTrans where trans_num = '" + this.Txt_TransNum.Text.Trim() + "'";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                        }
                        Class12.smethod_3(str14, str, str2, str3, num, 0.0, str4, str5, 1);
                        Class12.smethod_2(str3, num, true);
                        Class12.smethod_3(str14, str, str2, str4, 0.0, num2, str3, str5, 2);
                        Class12.smethod_2(str4, num2, false);
                        this.string_0 = string.Concat(new object[] { 
                        "UPDATE    tblPaymentOrder SET payer =N'", str6, "', payer_acc ='", str7, "', payer_bank =N'", str8, "', payer_branch =N'", str9, "', benef =N'", str10, "', benef_acc ='", str11, "',benef_bank =N'", str12, "', benef_branch =N'", str13, 
                        "', amount = ", num3, " WHERE trans_num = '", this.Txt_TransNum.Text.Trim(), "' "
                     });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            goto Label_0740;
                        }
                    }
            }
            this.iWyIskLbe(this, new EventArgs());
            Class12.smethod_3(str14, str, str2, str3, num, 0.0, str4, str5, 1);
            Class12.smethod_2(str3, num, true);
            Class12.smethod_3(str14, str, str2, str4, 0.0, num2, str3, str5, 2);
            Class12.smethod_2(str4, num2, false);
            this.string_0 = string.Concat(new object[] { 
                "INSERT INTO tblPaymentOrder (trans_num, payer, payer_acc, payer_bank, payer_branch, benef, benef_acc, benef_bank, benef_branch, amount) VALUES ('", this.Txt_TransNum.Text.Trim(), "',N'", str6, "','", str7, "',N'", str8, "',N'", str9, "',N'", str10, "','", str11, "',N'", str12, 
                "',N'", str13, "',", num3, ") "
             });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
            }
            new Class6().ComputeTransnum("A");
        Label_0740:
            Class6.transNum = this.Txt_TransNum.Text.Trim();
            Class7.CreateReportInstance(Class6.string_3).ShowPreviewDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            this.IjSwogAv6 = "S";
            this.Txt_TransNum.Enabled = true;
            this.Txt_TransNum.Focus();
        }


        private void FrmPaymentOrder_Load(object sender, EventArgs e)
        {
            this.Lbl_TranCode.Text = Class6.string_2;
            this.iWyIskLbe(this, new EventArgs());
            Class11.smethod_8(this);
            this.Text = Class6.string_1;
            base.Tag = "tblAccTrans";
            this.Lbl_Today.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }



        private void iWyIskLbe(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.IjSwogAv6 = "D";
        }

        private void Lbl_TranCode_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("trans_name", "tblAtrcode", "trans_code", this.Lbl_TranCode.Text, "", this.oleDbConnection_0, ref str);
            this.Lbl_TranName.Text = str;
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
                string str2 = (this.Txt_CreAccId.EditValue.ToString().Length != 0) ? this.Txt_CreAccId.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_0 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str2 + "%'";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_CreAccId.Text = BrowseForm.strReturn;
            }
            if (e.KeyCode == Keys.Return)
            {
                string str = "0" + this.Txt_CreAccId.Text.Replace("-", "").Substring(5, 4);
                this.string_0 = "SELECT  id, fullname, bankname, bank_br, accnum FROM tblStore where id = '" + str + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_Payer.Text = set.Tables[0].Rows[0]["fullname"].ToString();
                        this.Txt_PayerBank.Text = set.Tables[0].Rows[0]["bankname"].ToString();
                        this.Txt_PayAccId.Text = set.Tables[0].Rows[0]["accnum"].ToString();
                        this.Txt_PayerBranch.Text = set.Tables[0].Rows[0]["bank_br"].ToString();
                    }
                }
            }
        }

        private void Txt_DbAccId_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_DbAccId.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_DbAccName.Text = str;
        }

        private void Txt_DbAccId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str2 = (this.Txt_DbAccId.EditValue.ToString().Length != 0) ? this.Txt_DbAccId.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_0 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str2 + "%'";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_DbAccId.Text = BrowseForm.strReturn;
            }
            if (e.KeyCode == Keys.Return)
            {
                string str = "0" + this.Txt_DbAccId.Text.Replace("-", "").Substring(5, 4);
                this.string_0 = "SELECT  id, fullname, bankname, bank_br, accnum FROM tblStore where id = '" + str + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_Beneficiary.Text = set.Tables[0].Rows[0]["fullname"].ToString();
                        this.Txt_BenBank.Text = set.Tables[0].Rows[0]["bankname"].ToString();
                        this.Txt_BenAccId.Text = set.Tables[0].Rows[0]["accnum"].ToString();
                        this.Txt_BenBranch.Text = set.Tables[0].Rows[0]["bank_br"].ToString();
                    }
                }
            }
        }

        private void Txt_PayAccId_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_Payer_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) && (this.IjSwogAv6 == "S"))
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
                        this.Txt_DbAccId.Text = set.Tables[0].Rows[0]["account_id"].ToString();
                        this.Txt_CreAccId.Text = set.Tables[0].Rows[0]["corr_acc"].ToString();
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
                        this.iWyIskLbe(this, new EventArgs());
                    }
                }
            }
        }

        private void Txt_Voucher_EditValueChanged(object sender, EventArgs e)
        {
        }
   
    }
}