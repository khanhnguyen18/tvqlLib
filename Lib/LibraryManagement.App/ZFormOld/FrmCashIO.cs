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
    public partial class FrmCashIO : Form
    {
        public FrmCashIO()
        {
            InitializeComponent();

            this.oleDbConnection_0 = DataProvider.GetConnection();
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
            this.Txt_TransNum.Text = class2.method_5("A");
            this.string_0 = "N";
            if (Class6.string_2 == "81")
            {
                this.Txt_Voucher.Text = "CK" + string.Format("{0:000}", this.method_0(Class6.string_2) + 1);
            }
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
            string str3 = string.Format("{0:MM/dd/yyyy}", this.Txt_TranDate.EditValue);
            string str4 = this.Txt_Voucher.Text.Trim();
            string str5 = this.Txt_DbAccId.EditValue.ToString();
            double num = Class7.ParseDoubleValue(this.Txt_Amount.Text);
            double num2 = Class7.ParseDoubleValue(this.Txt_Amount.Text);
            string str6 = this.Txt_CreAccId.EditValue.ToString();
            string str7 = this.Txt_Remark.Text.Trim();
            string str8 = this.Txt_Name.Text.Trim();
            string str9 = this.Txt_Address.Text.Trim();
            string str10 = this.Txt_PsId.Text.Trim();
            string str2 = this.Txt_TransNum.Text.Trim();
            string str = this.string_0;
            switch (str)
            {
                case null:
                    goto Label_0610;

                case "N":
                    break;

                default:
                    {
                        if (!(str == "E"))
                        {
                            goto Label_0610;
                        }
                        if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) != 1)
                        {
                            return;
                        }
                        this.RrqIxZxw5(this, new EventArgs());
                        this.string_1 = "select account_id, db_amount, cr_amount from tblAccTrans where trans_num = '" + this.Txt_TransNum.Text.Trim() + "'";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                        using (DataTable table = new DataTable())
                        {
                            this.oleDbDataAdapter_0.Fill(table);
                            foreach (DataRow row in table.Rows)
                            {
                                this.string_1 = string.Concat(new object[] { "update tblAccount set debamt = debamt - ", row["db_amount"], ",creamt = creamt - ", row["db_amount"], " where account_id = '", row["account_id"], "'" });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                                using (set = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set);
                                    this.oleDbConnection_0.Close();
                                    continue;
                                }
                            }
                        }
                        this.string_1 = "delete from tblAccTrans where trans_num = '" + this.Txt_TransNum.Text.Trim() + "'";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                        }
                        Class12.smethod_3(str2, str3, str4, str5, num, 0.0, str6, str7, 1);
                        Class12.smethod_2(str5, num, true);
                        Class12.smethod_3(str2, str3, str4, str6, 0.0, num2, str5, str7, 2);
                        Class12.smethod_2(str6, num2, false);
                        this.string_1 = "update tblAccTrans set name = N'" + str8 + "', address = N'" + str9 + "', person_id = '" + str10 + "', voucher =  '" + str4 + "' where trans_num = '" + this.Txt_TransNum.Text.Trim() + "'";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            goto Label_0610;
                        }
                    }
            }
            this.RrqIxZxw5(this, new EventArgs());
            Class12.smethod_3(str2, str3, str4, str5, num, 0.0, str6, str7, 1);
            Class12.smethod_2(str5, num, true);
            Class12.smethod_3(str2, str3, str4, str6, 0.0, num2, str5, str7, 2);
            Class12.smethod_2(str6, num2, false);
            this.string_1 = "update tblAccTrans set name = N'" + str8 + "', address = N'" + str9 + "', person_id = '" + str10 + "' where trans_num = '" + this.Txt_TransNum.Text.Trim() + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            using (set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
            }
            new Class6().ComputeTransnum("A");
        Label_0610:
            Class6.transNum = this.Txt_TransNum.Text.Trim();
            Class7.CreateReportInstance(Class6.string_3).ShowPreviewDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "S";
            this.Txt_TransNum.Enabled = true;
            this.Txt_TransNum.Focus();
        }


        private void FrmCashIO_Load(object sender, EventArgs e)
        {
            this.Lbl_TranCode.Text = Class6.string_2;
            this.RrqIxZxw5(this, new EventArgs());
            Class11.smethod_8(this);
            this.Text = Class6.string_1;
            base.Tag = "tblAccTrans";
            this.Lbl_Today.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }



        private void Lbl_PersonCap_Click(object sender, EventArgs e)
        {
        }

        private void Lbl_TranCode_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("trans_name", "tblAtrcode", "trans_code", this.Lbl_TranCode.Text, "", this.oleDbConnection_0, ref str);
            this.Lbl_TranName.Text = str;
        }

        private int method_0(string string_2)
        {
            this.string_1 = "select trans_num from " + base.Tag.ToString() + " where trans_code = '" + string_2 + "' and tran_date = '" + Class7.smethod_19() + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return set.Tables[0].Rows.Count;
            }
        }

        private string method_1()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT CONVERT(VARCHAR(10),GETDATE(),104)", this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return set.Tables[0].Rows[0][0].ToString();
            }
        }

        private void RrqIxZxw5(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "D";
        }

        private void Txt_CreAccId_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_CreAccId.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.AhxsdynSH.Text = str;
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
                string str = (this.Txt_DbAccId.EditValue.ToString().Length != 0) ? this.Txt_DbAccId.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm1(this.string_1, this.oleDbConnection_0);
                this.Txt_DbAccId.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_PsId_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_TranDate_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) && (this.string_0 == "S"))
            {
                this.string_1 = "SELECT tran_date, tran_time, ef_date, trans_num, voucher, trans_code, account_id, db_amount, cr_amount, user_id, corr_acc, remark, updated, recnum, status, name, address, person_id FROM tblAccTrans where trans_num = '" + this.Txt_TransNum.Text.Trim() + "' and trans_code = '" + this.Lbl_TranCode.Text + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
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
                        this.Txt_Address.Text = set.Tables[0].Rows[0]["address"].ToString();
                        this.Txt_Name.Text = set.Tables[0].Rows[0]["name"].ToString();
                        this.Txt_PsId.Text = set.Tables[0].Rows[0]["person_id"].ToString();
                        this.btn_Delete.Text = (set.Tables[0].Rows[0]["status"].ToString() == "1") ? "&X\x00f3a" : "&Phục hồi";
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                    }
                    else
                    {
                        Class7.ShowMessageBox("Giao dịch kh\x00f4ng tồn tại", 1);
                        this.RrqIxZxw5(this, new EventArgs());
                    }
                }
            }
        }
    }
}