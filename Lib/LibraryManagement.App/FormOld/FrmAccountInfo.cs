using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace LibraryManagement.App
{
    public partial class FrmAccountInfo : DevExpress.XtraEditors.XtraForm
    {

        private string string_0;
        public FrmAccountInfo()
        {
            InitializeComponent();

            this.oleDbConnection_0 = DataProvider.GetConnection();

        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                Class12.string_3 = this.Txt_Account.Text.Replace("-", "");
                new acc_detail().ShowPreviewDialog();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.btn_Detail.Enabled = false;
            this.btn_Search.Enabled = false;
            this.Txt_Account.Focus();
        }


        private void FrmAccountInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Tra cứu t\x00e0i khoản chi tiết";
            this.method_0();
            this.btn_Detail.Enabled = false;
            if (!string.IsNullOrEmpty(FrmAcountList._accdetail))
            {
                this.Txt_Account.Text = FrmAcountList._accdetail;
            }
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void method_0()
        {
            this.Lbl_Balance.Text = string.Empty;
            this.Lbl_BodAmt.Text = string.Empty;
            this.Lbl_BoyAmt.Text = string.Empty;
            this.Lbl_DayCredit.Text = string.Empty;
            this.Lbl_DayDebit.Text = string.Empty;
            this.Lbl_LatsDate.Text = string.Empty;
            this.Lbl_MonthCredit.Text = string.Empty;
            this.Lbl_MonthDebit.Text = string.Empty;
            this.Lbl_Name.Text = string.Empty;
            this.Lbl_Status.Text = string.Empty;
            this.Lbl_YearCredit.Text = string.Empty;
            this.Lbl_YearDebit.Text = string.Empty;
            this.Txt_ShortName.Text = string.Empty;
        }

        private double method_1(string string_1)
        {
            this.string_0 = "select creamt - debamt as balance from tblAccount where account_id = '" + string_1 + "'";
            //this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            //using (DataSet set = new DataSet())
            //{
            //    this.oleDbDataAdapter_0.Fill(set);
            //    this.oleDbConnection_0.Close();
            //    return Class7.smethod_2(set.Tables[0].Rows[0][0]);
            //}

            return 0;
        }

        private double method_10(string string_1)
        {
            return ((this.method_1(string_1) - this.method_6(string_1)) + this.method_5(string_1));
        }

        private double method_11(string string_1)
        {
            return ((this.method_1(string_1) - this.method_8(string_1)) + this.method_7(string_1));
        }

        private string method_2(string string_1)
        {
            this.string_0 = "select MAX(convert(VARCHAR(10),tran_date,103)) from tblAccTrans where account_id = '" + string_1 + "' and YEAR(tran_date) = (SELECT MAX(YEAR(tran_date)) FROM dbo.tblAccTrans)";
            //this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            //using (DataSet set = new DataSet())
            //{
            //    this.oleDbDataAdapter_0.Fill(set);
            //    this.oleDbConnection_0.Close();
            //    if (set.Tables[0].Rows[0][0] != null)
            //    {
            //        return set.Tables[0].Rows[0][0].ToString();
            //    }
            //    return string.Empty;
            //}

            return string.Empty;
        }

        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;

        private double method_3(string string_1)
        {
            this.string_0 = "select  SUM(db_amount) AS ydeb  FROM dbo.tblAccTrans WHERE YEAR(tran_date) = YEAR(GETDATE()) and account_id = '" + string_1 + "' and status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return Class7.smethod_2(set.Tables[0].Rows[0][0]);
            }
        }

        private double method_4(string string_1)
        {
            this.string_0 = "select  SUM(cr_amount) AS ycre  FROM dbo.tblAccTrans WHERE YEAR(tran_date) = YEAR(GETDATE()) and account_id = '" + string_1 + "' and status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return Class7.smethod_2(set.Tables[0].Rows[0][0]);
            }
        }

        private double method_5(string string_1)
        {
            this.string_0 = "select  SUM(db_amount) AS ydeb  FROM dbo.tblAccTrans WHERE MONTH(tran_date) = MONTH(GETDATE()) and YEAR(tran_date) = YEAR(GETDATE()) and account_id = '" + string_1 + "' and status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return Class7.smethod_2(set.Tables[0].Rows[0][0]);
            }
        }

        private double method_6(string string_1)
        {
            this.string_0 = "select  SUM(cr_amount) AS ycre  FROM dbo.tblAccTrans WHERE MONTH(tran_date) = MONTH(GETDATE()) and YEAR(tran_date) = YEAR(GETDATE()) and account_id = '" + string_1 + "' and status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return Class7.smethod_2(set.Tables[0].Rows[0][0]);
            }
        }

        private double method_7(string string_1)
        {
            this.string_0 = "select  SUM(db_amount) AS daydeb  FROM dbo.tblAccTrans WHERE tran_date = '" + Class7.smethod_19() + "' and account_id = '" + string_1 + "' and status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return Class7.smethod_2(set.Tables[0].Rows[0][0]);
            }
        }

        private double method_8(string string_1)
        {
            this.string_0 = "select  SUM(cr_amount) AS daycre  FROM tblAccTrans WHERE tran_date = '" + Class7.smethod_19() + "' and account_id = '" + string_1 + "' and status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return Class7.smethod_2(set.Tables[0].Rows[0][0]);
            }
        }

        private double method_9(string string_1)
        {
            this.string_0 = "select  SUM(cr_amount) - SUM(db_amount) AS ybegin  FROM dbo.tblAccTrans WHERE YEAR(tran_date) = YEAR(GETDATE()) - 1 and account_id = '" + string_1 + "' and status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                return Class7.smethod_2(set.Tables[0].Rows[0][0]);
            }
        }

        private void Txt_Account_EditValueChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void Txt_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                string str = this.Txt_Account.Text.Replace("-", "");
                this.string_0 = "SELECT account_id , abbreviat , mof_gl , name ,cust_id, open_date , status  FROM  tblAccount where account_id = '" + str + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        Class7.ShowMessageBox("Số TK kh\x00f4ng tồn tại !", 1);
                        return;
                    }
                    this.Txt_ShortName.Text = set.Tables[0].Rows[0]["abbreviat"].ToString();
                    this.Lbl_Name.Text = set.Tables[0].Rows[0]["name"].ToString();
                    this.Lbl_Status.Text = (set.Tables[0].Rows[0]["status"].ToString() == "True") ? "Đang hoạt động" : "Đ\x00e3 bị đ\x00f3ng";
                }
                if (this.method_1(str) < 0.0)
                {
                    this.Lbl_Balance.Text = "Nợ: " + string.Format("{0:n0}", Math.Abs(this.method_1(str)));
                }
                else if (this.method_1(str) > 0.0)
                {
                    this.Lbl_Balance.Text = "C\x00f3: " + string.Format("{0:n0}", Math.Abs(this.method_1(str)));
                }
                else if (this.method_1(str) == 0.0)
                {
                    this.Lbl_Balance.Text = "0";
                }
                this.Lbl_DayCredit.Text = string.Format("{0:n0}", this.method_8(str));
                this.Lbl_DayDebit.Text = string.Format("{0:n0}", this.method_7(str));
                this.Lbl_MonthCredit.Text = string.Format("{0:n0}", this.method_6(str));
                this.Lbl_MonthDebit.Text = string.Format("{0:n0}", this.method_5(str));
                this.Lbl_YearCredit.Text = string.Format("{0:n0}", this.method_4(str));
                this.Lbl_YearDebit.Text = string.Format("{0:n0}", this.method_3(str));
                if (this.method_9(str) < 0.0)
                {
                    this.Lbl_BoyAmt.Text = "Nợ: " + string.Format("{0:n0}", Math.Abs(this.method_9(str)));
                }
                else if (this.method_9(str) > 0.0)
                {
                    this.Lbl_BoyAmt.Text = "C\x00f3: " + string.Format("{0:n0}", Math.Abs(this.method_9(str)));
                }
                else if (this.method_9(str) == 0.0)
                {
                    this.Lbl_BoyAmt.Text = "0";
                }
                if (this.method_10(str) < 0.0)
                {
                    this.Lbl_BomAmt.Text = "Nợ: " + string.Format("{0:n0}", Math.Abs(this.method_10(str)));
                }
                else if (this.method_10(str) > 0.0)
                {
                    this.Lbl_BomAmt.Text = "C\x00f3: " + string.Format("{0:n0}", Math.Abs(this.method_10(str)));
                }
                else if (this.method_10(str) == 0.0)
                {
                    this.Lbl_BomAmt.Text = "0";
                }
                if (this.method_11(str) < 0.0)
                {
                    this.Lbl_BodAmt.Text = "Nợ: " + string.Format("{0:n0}", Math.Abs(this.method_11(str)));
                }
                else if (this.method_11(str) > 0.0)
                {
                    this.Lbl_BodAmt.Text = "C\x00f3: " + string.Format("{0:n0}", Math.Abs(this.method_11(str)));
                }
                else if (this.method_11(str) == 0.0)
                {
                    this.Lbl_BodAmt.Text = "0";
                }
                this.Lbl_LatsDate.Text = this.method_2(str);
                this.btn_Detail.Enabled = true;
                this.btn_Search.Enabled = true;
            }
            if (e.KeyCode == Keys.F5)
            {
                string str2 = (this.Txt_Account.EditValue.ToString().Length != 0) ? this.Txt_Account.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_0 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str2 + "%'";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_Account.Text = BrowseForm.strReturn;
            }
        }
    }
}