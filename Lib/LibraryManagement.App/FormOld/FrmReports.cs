using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmReports : DevExpress.XtraEditors.XtraForm
    {
        public FrmReports()
        {
            InitializeComponent();
            this.oleDbConnection_0 = new OleDbConnection(Class7.string_5);
        }



        public void acc_detail()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                new acc_info().ShowPreviewDialog();
            }
        }

        public void acc_diary()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                new acc_diary().ShowPreviewDialog();
            }
        }

        public void acc_gl()
        {
            string str = "ACCGL_" + Class6.smethod_0(SystemInformation.ComputerName);
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                DataSet set;
                WaitDialogForm form = new WaitDialogForm();
                form.Caption = "Xin đợi một ch\x00fat ....";
                try
                {
                    this.string_2 = "CREATE TABLE " + str + "([account_id] [nchar](9) ,[name] [nvarchar](200) NULL,[mof_gl] [nchar](4) NULL,[beg_debit] [numeric](18, 2) DEFAULT ((0)),[beg_credit] [numeric](18, 2) DEFAULT ((0)),[db_amount] [numeric](18, 2) DEFAULT ((0)),[cr_amount] [numeric](18, 2) DEFAULT ((0)),[end_debit] [numeric](18, 2) DEFAULT ((0)),[end_credit] [numeric](18, 2) DEFAULT ((0)),[sumdebit] [numeric](18, 2) DEFAULT ((0)),[sumcredit] [numeric](18, 2) DEFAULT ((0))) ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                }
                catch (Exception)
                {
                    this.string_2 = "DELETE FROM " + str;
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                }
                this.string_2 = "INSERT INTO " + str + "(account_id, name, mof_gl) SELECT account_id, name, mof_gl from tblAccount";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.string_2 = string.Concat(new object[] { "select account_id, db_amount, cr_amount from tblAccTrans where status = 1 and (tran_date between '", Class7.dateTime_0, "' and '", Class7.dateTime_1, "') " });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable dataTable = new DataTable();
                this.oleDbDataAdapter_0.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    this.string_2 = string.Concat(new object[] { "update ", str, " set db_amount = db_amount + ", row["db_amount"], ", cr_amount = cr_amount + ", row["cr_amount"], " where account_id = '", row["account_id"], "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "select account_id, SUM(cr_amount) - SUM(db_amount) AS beg_amt from tblAccTrans where status = 1 and tran_date <= '" + Class7.dateTime_0 + "' GROUP BY account_id ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable table3 = new DataTable();
                this.oleDbDataAdapter_0.Fill(table3);
                foreach (DataRow row in table3.Rows)
                {
                    if (Class7.smethod_2(row["beg_amt"]) < 0.0)
                    {
                        this.string_2 = string.Concat(new object[] { "update ", str, " set beg_debit = ABS(", row["beg_amt"], ") where account_id = '", row["account_id"], "'" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    this.string_2 = string.Concat(new object[] { "update ", str, " set beg_credit = ", row["beg_amt"], " where account_id = '", row["account_id"], "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "select account_id, (cr_amount + beg_credit) - (db_amount + beg_debit) AS end_amt from " + str;
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable table2 = new DataTable();
                this.oleDbDataAdapter_0.Fill(table2);
                foreach (DataRow row in table2.Rows)
                {
                    if (Class7.smethod_2(row["end_amt"]) < 0.0)
                    {
                        this.string_2 = string.Concat(new object[] { "update ", str, " set end_debit = ABS(", row["end_amt"], ") where account_id = '", row["account_id"], "'" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    this.string_2 = string.Concat(new object[] { "update ", str, " set end_credit =", row["end_amt"], " where account_id = '", row["account_id"], "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "delete from " + str + " where beg_debit + beg_credit + db_amount + cr_amount + end_debit + end_credit = 0";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                form.Close();
                new acc_gl().ShowPreviewDialog();
                this.string_2 = "DROP TABLE " + str;
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
            }
        }

        public void acc_glmof()
        {
            string str = "MOFGL_" + Class6.smethod_0(SystemInformation.ComputerName);
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                DataSet set;
                WaitDialogForm form = new WaitDialogForm();
                form.Caption = "Xin đợi một ch\x00fat ....";
                try
                {
                    this.string_2 = "CREATE TABLE " + str + "([mof_gl] [nchar](4) ,[name] [nvarchar](200) NULL,[beg_debit] [numeric](18, 2) DEFAULT ((0)),[beg_credit] [numeric](18, 2) DEFAULT ((0)),[db_amount] [numeric](18, 2) DEFAULT ((0)),[cr_amount] [numeric](18, 2) DEFAULT ((0)),[end_debit] [numeric](18, 2) DEFAULT ((0)),[end_credit] [numeric](18, 2) DEFAULT ((0))) ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                }
                catch (Exception)
                {
                    this.string_2 = "DELETE FROM " + str;
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                }
                this.string_2 = "INSERT INTO " + str + "(mof_gl,name) SELECT mof_gl,mof_name from tblmof_sys where glevel = 3";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.string_2 = string.Concat(new object[] { "select LEFT(account_id,4) AS mof_gl, db_amount, cr_amount from tblAccTrans where status = 1 and (tran_date between '", Class7.dateTime_0, "' and '", Class7.dateTime_1, "') " });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable dataTable = new DataTable();
                this.oleDbDataAdapter_0.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    this.string_2 = string.Concat(new object[] { "update ", str, " set db_amount = db_amount + ", row["db_amount"], ", cr_amount = cr_amount + ", row["cr_amount"], " where mof_gl = '", row["mof_gl"].ToString().Substring(0, 4), "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "select LEFT(account_id,4) AS mof_gl, SUM(cr_amount) - SUM(db_amount) AS beg_amt from tblAccTrans where status = 1 and tran_date <= '" + Class7.dateTime_0 + "' GROUP BY LEFT(account_id,4) ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable table2 = new DataTable();
                this.oleDbDataAdapter_0.Fill(table2);
                foreach (DataRow row in table2.Rows)
                {
                    if (Class7.smethod_2(row["beg_amt"]) < 0.0)
                    {
                        this.string_2 = string.Concat(new object[] { "update ", str, " set beg_debit = ABS(", row["beg_amt"], ") where mof_gl = '", row["mof_gl"], "'" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    this.string_2 = string.Concat(new object[] { "update ", str, " set beg_credit = ", row["beg_amt"], " where mof_gl = '", row["mof_gl"], "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "select  mof_gl, (cr_amount + beg_credit) - (db_amount + beg_debit) AS end_amt from " + str;
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable table3 = new DataTable();
                this.oleDbDataAdapter_0.Fill(table3);
                foreach (DataRow row in table3.Rows)
                {
                    if (Class7.smethod_2(row["end_amt"]) < 0.0)
                    {
                        this.string_2 = string.Concat(new object[] { "update ", str, " set end_debit = ABS(", row["end_amt"], ") where mof_gl = '", row["mof_gl"], "'" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    this.string_2 = string.Concat(new object[] { "update ", str, " set end_credit =", row["end_amt"], " where mof_gl = '", row["mof_gl"], "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "delete from " + str + " where beg_debit + beg_credit + db_amount + cr_amount + end_debit + end_credit = 0";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                form.Close();
                new acc_glmof().ShowPreviewDialog();
                this.string_2 = "DROP TABLE " + str;
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
            }
        }

        public void acc_glmof2()
        {
            string str = "MOFGL2_" + Class6.smethod_0(SystemInformation.ComputerName);
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                DataSet set;
                WaitDialogForm form = new WaitDialogForm();
                form.Caption = "Xin đợi một ch\x00fat ....";
                try
                {
                    this.string_2 = "CREATE TABLE " + str + "([mof_gl] [nchar](4) ,[mof_gl2] [nchar](3) ,[name] [nvarchar](200) NULL,[beg_debit] [numeric](18, 2) DEFAULT ((0)),[beg_credit] [numeric](18, 2) DEFAULT ((0)),[db_amount] [numeric](18, 2) DEFAULT ((0)),[cr_amount] [numeric](18, 2) DEFAULT ((0)),[end_debit] [numeric](18, 2) DEFAULT ((0)),[end_credit] [numeric](18, 2) DEFAULT ((0))) ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                }
                catch (Exception)
                {
                    this.string_2 = "DELETE FROM " + str;
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                }
                this.string_2 = "INSERT INTO " + str + "(mof_gl,name) SELECT mof_gl,mof_name from tblmof_sys where glevel = 3";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.string_2 = "update " + str + " set mof_gl2 = LEFT(mof_gl,3)";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.string_2 = string.Concat(new object[] { "select LEFT(account_id,4) AS mof_gl, db_amount, cr_amount from tblAccTrans where status = 1 and (tran_date between '", Class7.dateTime_0, "' and '", Class7.dateTime_1, "') " });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable dataTable = new DataTable();
                this.oleDbDataAdapter_0.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    this.string_2 = string.Concat(new object[] { "update ", str, " set db_amount = db_amount + ", row["db_amount"], ", cr_amount = cr_amount + ", row["cr_amount"], " where mof_gl = '", row["mof_gl"].ToString().Substring(0, 4), "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "select LEFT(account_id,4) AS mof_gl, SUM(cr_amount) - SUM(db_amount) AS beg_amt from tblAccTrans where status = 1 and tran_date <= '" + Class7.dateTime_0 + "' GROUP BY LEFT(account_id,4) ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable table3 = new DataTable();
                this.oleDbDataAdapter_0.Fill(table3);
                foreach (DataRow row in table3.Rows)
                {
                    if (Class7.smethod_2(row["beg_amt"]) < 0.0)
                    {
                        this.string_2 = string.Concat(new object[] { "update ", str, " set beg_debit = ABS(", row["beg_amt"], ") where mof_gl = '", row["mof_gl"], "'" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    this.string_2 = string.Concat(new object[] { "update ", str, " set beg_credit = ", row["beg_amt"], " where mof_gl = '", row["mof_gl"], "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "select  mof_gl, (cr_amount + beg_credit) - (db_amount + beg_debit) AS end_amt from " + str;
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                DataTable table = new DataTable();
                this.oleDbDataAdapter_0.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    if (Class7.smethod_2(row["end_amt"]) < 0.0)
                    {
                        this.string_2 = string.Concat(new object[] { "update ", str, " set end_debit = ABS(", row["end_amt"], ") where mof_gl = '", row["mof_gl"], "'" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    this.string_2 = string.Concat(new object[] { "update ", str, " set end_credit =", row["end_amt"], " where mof_gl = '", row["mof_gl"], "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                this.string_2 = "delete from " + str + " where beg_debit + beg_credit + db_amount + cr_amount + end_debit + end_credit = 0";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                form.Close();
                new acc_glmof2().ShowPreviewDialog();
                this.string_2 = "DROP TABLE " + str;
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (this.bool_0 && !string.IsNullOrEmpty(this.string_1))
            {
                try
                {
                    _sumrp = this.chkSummary.Checked;
                    //Interaction.CallByName(this, this.string_1.Trim(), CallType.Method, new object[0]);
                }
                catch (Exception)
                {
                    Class7.ShowMessageBox("Chức năng chưa được k\x00edch hoạt bởi nh\x00e0 cung cấp", 1);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        public void delpostranlist()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                _status = 0;
                _trcode = "00";
                new lst_postrans().ShowPreviewDialog();
            }
        }

        public void delstktranlist()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                _status = 0;
                new lst_stktrans().ShowPreviewDialog();
            }
        }

        public void fastslow()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                new FrmFastSlow().ShowDialog();
            }
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            //this.method_0();
            this.string_2 = "SELECT  dep_id AS TT, rep_name AS [B\x00e1o c\x00e1o], description AS [Diễn giải], [procedure], dep_code, status,checked AS [Trạng th\x00e1i] FROM tblReports where dep_code = '" + Class11.string_1 + "' and status = 1  order by dep_id";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.gridControl1.DataSource = dataSet.Tables[0];
            this.gridView1.BestFitColumns();
            this.gridView1.Columns["procedure"].Visible = false;
            this.gridView1.Columns["dep_code"].Visible = false;
            this.gridView1.Columns["status"].Visible = false;
            StyleFormatCondition condition = null;
            condition = new StyleFormatCondition(FormatConditionEnum.Equal, this.gridView1.Columns["checked"], null, false);
            condition.Appearance.ForeColor = Color.Gray;
            this.gridView1.FormatConditions.Add(condition);
            condition.ApplyToRow = true;
        }

        public void generalinfo()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                new stk_history().ShowPreviewDialog();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.string_1 = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "procedure").ToString().Trim();
                Class6.string_10 = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "B\x00e1o c\x00e1o").ToString().Trim();
                this.bool_0 = (bool)this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Trạng th\x00e1i");
                if (!this.bool_0)
                {
                    this.btn_Confirm.Enabled = false;
                }
                else
                {
                    this.btn_Confirm.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }



        private void method_0()
        {
            this.string_2 = "update tblReports set checked = 0";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
            }
            string str4 = null;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("Select * from tblUser where id = " + Class7.GetUserRight(), this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            str4 = Class13.smethod_2(dataTable.Rows[0]["rpright"].ToString());
            str4.ToCharArray();
            int index = 0;
            string[] strArray = str4.Split(new char[] { ';' });
            string str3 = null;
            string str2 = null;
            for (index = 0; index <= (strArray.Length - 2); index++)
            {
                str3 = strArray[index].ToString();
                for (int i = index + 1; i <= (strArray.Length - 1); i++)
                {
                    str2 = strArray[i].ToString();
                    if (str3 == str2)
                    {
                        strArray[i] = "";
                    }
                }
            }
            int length = strArray.Length;
            string str = null;
            new DataTable();
            for (index = 0; index <= (length - 1); index++)
            {
                str = strArray[index].ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    DataSet dataSet = new DataSet();
                    using (new OleDbCommand())
                    {
                    }
                    new OleDbDataAdapter(" Update tblReports set checked = 1 where [idx] = " + int.Parse(str), this.oleDbConnection_0).Fill(dataSet);
                }
            }
        }

        public void posinfo_gl()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                Class9.RrqIxZxw5("WHERE type IN('01')");
                new stk_history().ShowPreviewDialog();
            }
        }

        public void posinfo_grp()
        {
            _stktype = "01";
            new mercinstock_grp().ShowPreviewDialog();
        }

        public void posinfo_supp()
        {
            _stktype = "01";
            new mercinstock_supp().ShowPreviewDialog();
        }

        public void postranlist()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                _status = 1;
                _trcode = "00";
                new lst_postrans().ShowPreviewDialog();
            }
        }

        public void rtpostranlist()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                _status = 1;
                _trcode = "01";
                new lst_postrans().ShowPreviewDialog();
            }
        }

        public void salebygrp()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                new saledetail_grp().ShowPreviewDialog();
            }
        }

        public void salebysupp()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                new saledetail_supp().ShowPreviewDialog();
            }
        }

        public void salebytaxcode()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                DataSet set;
                string str = "S05GTGT_" + Class6.smethod_0(SystemInformation.ComputerName);
                try
                {
                    this.string_2 = "DROP TABLE " + str;
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                    }
                    this.oleDbConnection_0.Close();
                }
                catch (Exception)
                {
                }
                this.string_2 = string.Concat(new object[] { "SELECT DISTINCT ptr.goods_id, gs.full_name, gs.grp_id, gs.piceunit, gs.tax_code, SUM(CASE ptr.trans_code WHEN '00' THEN ptr.qty ELSE 0 END) AS sold, SUM(CASE ptr.trans_code WHEN '01' THEN ptr.qty ELSE 0 END) AS rb, SUM(CASE ptr.trans_code WHEN '00' THEN ptr.amount - ptr.discount ELSE 0 END) AS in_amt, SUM(CASE ptr.trans_code WHEN '01' THEN ptr.amount - ptr.discount ELSE 0 END) AS out_amt,SUM(CASE ptr.trans_code WHEN '00' THEN ptr.surplus ELSE 0 END) AS soldsur, SUM(CASE ptr.trans_code WHEN '01' THEN ptr.surplus ELSE 0 END) AS rbsur, SUM(CASE ptr.trans_code WHEN '00' THEN ptr.vat_amt ELSE 0 END) AS vat_amt,SUM(CASE ptr.trans_code WHEN '01' THEN ptr.vat_amt ELSE 0 END) AS rbvat_amt, ptr.exp_id, stk.fullname INTO ", str, " FROM ((tblTransaction AS ptr INNER JOIN tblGoods AS gs ON ptr.goods_id = gs.goods_id) INNER JOIN tblStore AS stk ON ptr.exp_id = stk.id) WHERE     (ptr.Status = 1) AND (ptr.trans_code IN ('00', '01')) AND (ptr.tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "' ) GROUP BY ptr.goods_id, gs.full_name, ptr.exp_id, stk.fullname, gs.grp_id, gs.piceunit,  gs.tax_code" });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.string_2 = "delete from " + str + " where rb = sold ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                new saledetail_taxcode().ShowPreviewDialog();
            }
        }

        public void stkinfo_gl()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                Class9.RrqIxZxw5("WHERE type IN('02')");
                new stk_history().ShowPreviewDialog();
            }
        }

        public void stkinfo_grp()
        {
            _stktype = "02";
            new mercinstock_grp().ShowPreviewDialog();
        }

        public void stkinfo_supp()
        {
            _stktype = "02";
            new mercinstock_supp().ShowPreviewDialog();
        }

        public void stktranlist()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                _status = 1;
                new lst_stktrans().ShowPreviewDialog();
            }
        }

        public void sumbysaler()
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                new sumsaler().ShowPreviewDialog();
            }
        }
    }
}