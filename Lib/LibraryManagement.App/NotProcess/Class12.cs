using System;
using System.Data;
using System.Data.OleDb;

internal class Class12
{
    public static bool bool_0;
    public static double double_0;
    public static double double_1;
    public static object object_0;
    public static object object_1;
    public static OleDbConnection oleDbConnection_0;
    public static OleDbConnection oleDbConnection_1;
    public static OleDbDataAdapter oleDbDataAdapter_0;
    public static string string_0;
    public static string string_1;
    public static string string_2;
    public static string string_3;

    static Class12()
    {
        Class15.smethod_5();
        Class17.smethod_0();
        oleDbConnection_0 = new OleDbConnection(Class7.string_5);
        oleDbConnection_1 = new OleDbConnection(Class7.string_4);
        string_0 = null;
        string_1 = "91,95,83,85";
        string_2 = "93,97,81,87";
        object_0 = null;
        bool_0 = false;
    }

    public Class12()
    {
        Class17.smethod_0();
    }

    public void method_0(string string_4, string string_5, int int_0, string string_6)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select amount from tblCashTrans  where trans_num = '" + string_4 + "' ", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        Class7.oleDbConnection_1.Close();
        double num = Class7.smethod_0(dataSet.Tables[0].Rows[0][0].ToString());
        if (string_1.Contains(string_6))
        {
            this.method_4(string_5, num);
            this.method_7(int_0, num);
        }
        if (string_2.Contains(string_6))
        {
            this.method_3(string_5, num);
            this.method_8(int_0, num);
        }
    }

    public void method_1(string string_4, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "IF NOT EXISTS (SELECT account_id FROM tblCsAccount where account_id = '", string_4, "')INSERT INTO tblCsAccount(account_id, debt_limit, begin_credit, credit_amt, debt_amt, last_date) VALUES ('", string_4, "',0,0,0,", double_2, ", '", Class7.smethod_19(), "') Else UPDATE tblCsAccount SET debt_amt = debt_amt + ", double_2, ",last_date = '", Class7.smethod_19(), "' where account_id = '", string_4, "' " }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_2(string string_4, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "IF NOT EXISTS (SELECT account_id FROM tblCsAccount where account_id = '", string_4, "')INSERT INTO tblCsAccount(account_id, debt_limit, begin_credit, credit_amt, debt_amt,last_date) VALUES ('", string_4, "',0,0,", double_2, ",0, '", Class7.smethod_19(), "') Else UPDATE tblCsAccount SET credit_amt = credit_amt + ", double_2, ", last_date = '", Class7.smethod_19(), "' where account_id = '", string_4, "' " }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_3(string string_4, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE tblCsAccount SET credit_amt = credit_amt - ", double_2, " where account_id = '", string_4, "' " }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_4(string string_4, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE tblCsAccount SET debt_amt = debt_amt - ", double_2, " where account_id = '", string_4, "' " }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_5(int int_0, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "update tblfundcash set debit_amt = debit_amt + ", double_2, " where id = ", int_0 }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_6(int int_0, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "update tblfundcash set credit_amt = credit_amt + ", double_2, " where id = ", int_0 }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_7(int int_0, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "update tblfundcash set credit_amt = credit_amt - ", double_2, " where id = ", int_0 }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_8(int int_0, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "update tblfundcash set debit_amt = debit_amt + ", double_2, " where id = ", int_0 }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public static double smethod_0(string string_4)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select credit_amt - debit_amt AS end_amt from tblFund_info where fund_id = '" + string_4 + "' and forex_id = 'VND'", oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
            if (set.Tables[0].Rows.Count != 0)
            {
                return Class7.smethod_0(set.Tables[0].Rows[0][0].ToString());
            }
            return 0.0;
        }
    }

    public static void smethod_1(string string_4)
    {
        DataSet set;
        double num;
        double num2;
        DateTime now = DateTime.Now;
        DateTime time2 = Class7.dateTime_1;
        TimeSpan timeOfDay = now.TimeOfDay;
        TimeSpan span2 = time2.TimeOfDay;
        if (timeOfDay <= span2)
        {
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT SUM(CASE trans_code WHEN 'a1' THEN amount ELSE 0 END) AS impamt,SUM(CASE trans_code WHEN 'a2' THEN amount ELSE 0 END) AS expamt  FROM dbo.tblAccTrans  WHERE tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "' " }), oleDbConnection_0);
            using (set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
                oleDbConnection_0.Close();
                num = Class7.smethod_2(set.Tables[0].Rows[0]["impamt"]);
                num2 = Class7.smethod_2(set.Tables[0].Rows[0]["exppamt"]);
                double_1 = smethod_0(string_4);
                double_0 = (double_1 - num) + num2;
            }
        }
        if (timeOfDay > span2)
        {
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT SUM(CASE trans_code WHEN 'a1' THEN amount ELSE 0 END) AS impamt,SUM(CASE trans_code WHEN 'a2' THEN amount ELSE 0 END) AS expamt  FROM dbo.tblAccTrans  WHERE tran_date BETWEEN '", Class7.dateTime_1, "' AND '", now, "' " }), oleDbConnection_0);
            using (set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
                oleDbConnection_0.Close();
                double num3 = Class7.smethod_2(set.Tables[0].Rows[0]["impamt"]);
                double num4 = Class7.smethod_2(set.Tables[0].Rows[0]["expamt"]);
                double_1 = (smethod_0(string_4) - num3) + num4;
            }
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT SUM(CASE trans_code WHEN 'a1' THEN amount ELSE 0 END) AS impamt,SUM(CASE trans_code WHEN 'a2' THEN amount ELSE 0 END) AS expamt  FROM dbo.tblAccTrans  WHERE tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "' " }), oleDbConnection_0);
            using (set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
                oleDbConnection_0.Close();
                num = Class7.smethod_2(set.Tables[0].Rows[0]["impamt"]);
                num2 = Class7.smethod_2(set.Tables[0].Rows[0]["expamt"]);
                double_1 = (smethod_0(string_4) - num) + num2;
                double_0 = (double_1 - num) + num2;
            }
        }
    }

    public static void smethod_2(object object_2, double double_2, bool bool_1)
    {
        if (bool_1)
        {
            string_0 = string.Concat(new object[] { "update tblAccount set debamt = debamt + ", double_2, " where account_id = '", object_2, "'" });
        }
        else
        {
            string_0 = string.Concat(new object[] { "update tblAccount set creamt = creamt + ", double_2, " where account_id = '", object_2, "'" });
        }
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
    }

    public static void smethod_3(object object_2, object object_3, object object_4, object object_5, double double_2, double double_3, object object_6, object object_7, int int_0)
    {
        new Class6();
        string_0 = string.Concat(new object[] { 
            "INSERT INTO tblAccTrans (tran_date, tran_time, ef_date, trans_num, voucher, trans_code, account_id, db_amount, cr_amount, user_id, corr_acc, remark, updated, recnum, status)  VALUES ('", object_3, "','", Class7.smethod_53(), "','", Class7.smethod_19(), "','", object_2, "' ,'", object_4, "','", Class6.string_2, "','", object_5, "',", double_2, 
            ", ", double_3, ",", Class7.GetUserRight(), ",'", object_6, "',N'", object_7, "',0,", int_0, ",1) "
         });
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
    }

    public static void smethod_4(object object_2, double double_2, bool bool_1)
    {
        if (bool_1)
        {
            string_0 = string.Concat(new object[] { "update tblAccount set debamt = debamt - ", double_2, " where account_id = '", object_2, "'" });
        }
        else
        {
            string_0 = string.Concat(new object[] { "update tblAccount set creamt = creamt - ", double_2, " where account_id = '", object_2, "'" });
        }
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
    }

    public static void smethod_5(object object_2, string string_4, double double_2, object object_3, bool bool_1)
    {
        DataSet set;
        string_0 = "update tblAccTrans set db_amount = 0, cr_amount = 0  where trans_num = '" + string_4 + "' ";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
        if (bool_1)
        {
            string_0 = string.Concat(new object[] { "update tblAccTrans set db_amount = ", double_2, ", remark = N'", object_3, "' where trans_num = '", string_4, "' and account_id = '", object_2, "' " });
        }
        else
        {
            string_0 = string.Concat(new object[] { "update tblAccTrans set cr_amount = ", double_2, ", remark = N'", object_3, "' where trans_num = '", string_4, "' and account_id = '", object_2, "' " });
        }
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
    }
}

