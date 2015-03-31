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
    public partial class FrmTran_1_1 : DevExpress.XtraEditors.XtraForm
    {
        public FrmTran_1_1()
        {
            InitializeComponent();
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class7.smethod_15("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
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
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(Class7.smethod_19()).Subtract(DateTime.ParseExact(this.Txt_TranDate.Text, "dd/MM/yyyy", null)).TotalDays < 0.0)
            {
                Class7.smethod_15("Ng\x00e0y hiệu lực kh\x00f4ng thể chọn trong tương lai", 1);
                this.Txt_TranDate.Focus();
            }
            else if (this.Txt_Voucher.Text == string.Empty)
            {
                Class7.smethod_15("Bạn chưa khai b\x00e1o số chứng từ", 1);
                this.Txt_Voucher.Focus();
            }
            else if (this.Txt_Remark.Text == string.Empty)
            {
                Class7.smethod_15("Bạn chưa khai b\x00e1o diễn giải giao dịch", 1);
                this.Txt_Remark.Focus();
            }
            else if (Class7.smethod_0(this.Txt_Amount.Text) <= 0.0)
            {
                Class7.smethod_15("Số tiền kh\x00f4ng hợp lệ", 1);
                this.Txt_Amount.Focus();
            }
            else
            {
                string str3 = string.Format("{0:MM/dd/yyyy}", this.Txt_TranDate.EditValue);
                string str4 = this.Txt_Voucher.Text.Trim();
                string str5 = this.Txt_DbAccId.EditValue.ToString();
                double num = Class7.smethod_0(this.Txt_Amount.Text);
                double num2 = Class7.smethod_0(this.Txt_Amount.Text);
                string str6 = this.Txt_CreAccId.EditValue.ToString();
                string str7 = this.Txt_Remark.Text.Trim();
                string str2 = this.Txt_TransNum.Text.Trim();
                string str = this.string_0;
                switch (str)
                {
                    case null:
                        break;

                    case "N":
                        this.btn_Skip_Click(this, new EventArgs());
                        Class12.smethod_3(str2, str3, str4, str5, num, 0.0, str6, str7, 1);
                        Class12.smethod_2(str5, num, true);
                        Class12.smethod_3(str2, str3, str4, str6, 0.0, num2, str5, str7, 2);
                        Class12.smethod_2(str6, num2, false);
                        new Class6().method_12("A");
                        break;

                    default:
                        if (str == "E")
                        {
                            DataSet set;
                            if (Class7.smethod_15("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) != 1)
                            {
                                return;
                            }
                            this.btn_Skip_Click(this, new EventArgs());
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
                        }
                        break;
                }
                Class6.string_5 = this.Txt_TransNum.Text.Trim();
                Class7.smethod_27(Class6.string_3).ShowPreviewDialog();
            }
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

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.smethod_0(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "D";
        }

        private void FrmTran_1_1_Load(object sender, EventArgs e)
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

        private void Txt_CreAccId_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_CreAccId.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_CreAccName.Text = str;
        }

        private void Txt_CreAccId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = (this.Txt_CreAccId.EditValue.ToString().Length != 0) ? this.Txt_CreAccId.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.smethod_16(this.string_1, this.oleDbConnection_0);
                this.Txt_CreAccId.Text = FrmBrowse.strReturn;
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
            if (e.KeyCode == Keys.F5)
            {
                string str = (this.Txt_DbAccId.EditValue.ToString().Length != 0) ? this.Txt_DbAccId.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.smethod_16(this.string_1, this.oleDbConnection_0);
                this.Txt_DbAccId.Text = FrmBrowse.strReturn;
            }
        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) && (this.string_0 == "S"))
            {
                this.string_1 = "SELECT tran_date, tran_time, ef_date, trans_num, voucher, trans_code, account_id, db_amount, cr_amount, user_id, corr_acc, remark, updated, recnum, status FROM tblAccTrans where trans_num = '" + this.Txt_TransNum.Text.Trim() + "' and trans_code = '" + this.Lbl_TranCode.Text + "'";
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
                        this.btn_Delete.Text = (set.Tables[0].Rows[0]["status"].ToString() == "1") ? "&X\x00f3a" : "&Phục hồi";
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                    }
                    else
                    {
                        Class7.smethod_15("Giao dịch kh\x00f4ng tồn tại", 1);
                        this.btn_Skip_Click(this, new EventArgs());
                    }
                }
            }
        }
  
    }
}