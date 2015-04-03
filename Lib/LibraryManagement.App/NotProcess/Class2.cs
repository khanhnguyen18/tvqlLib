using System;
using System.Data;
using System.Data.OleDb;

internal class Class2
{
    public static OleDbConnection oleDbConnection_0;
    public static OleDbDataAdapter oleDbDataAdapter_0;
    public static string string_0;

    static Class2()
    {
        Class15.smethod_5();
        Class17.smethod_0();
        oleDbConnection_0 = new OleDbConnection(Class7.string_5);
        string_0 = null;
    }

    public Class2()
    {
        Class17.smethod_0();
    }

    public static void iWyIskLbe(object object_0, object object_1, double double_0)
    {
        string_0 = string.Concat(new object[] { 
            "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '", object_0, "' AND goods_id = '", object_1, "') UPDATE  tblStockInfo SET exp_qty = exp_qty + ", double_0, " ,last_date ='", Class7.smethod_19(), "' WHERE id = '", object_0, "' AND goods_id = '", object_1, "' Else INSERT INTO tblStockInfo(id,goods_id, exp_qty,exp_amt,last_date )  VALUES('", object_0, "','", object_1, 
            "',", double_0, ", 0,'", Class7.smethod_19(), "')"
         });
        Class7.smethod_4(string_0);
    }

    public static void smethod_0(string string_1)
    {
        string_0 = "select exp_id, goods_id, qty from tblLoanTran where trans_num = '" + string_1 + "'";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataTable table = new DataTable())
        {
            oleDbDataAdapter_0.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string_0 = string.Concat(new object[] { "UPDATE  tblStockInfo SET exp_qty = exp_qty - ", row["qty"], " ,last_date ='", Class7.smethod_19(), "' WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "' " });
                Class7.smethod_4(string_0);
            }
        }
    }

    public static void smethod_1(object object_0, object object_1, double double_0)
    {
        string_0 = string.Concat(new object[] { 
            "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '", object_0, "' AND goods_id = '", object_1, "') UPDATE  tblStockInfo SET imp_qty = imp_qty + ", double_0, " ,last_date ='", Class7.smethod_19(), "' WHERE id = '", object_0, "' AND goods_id = '", object_1, "' Else INSERT INTO tblStockInfo(id,goods_id, imp_qty,imp_amt,last_date )  VALUES('", object_0, "','", object_1, 
            "',", double_0, ", 0,'", Class7.smethod_19(), "')"
         });
        Class7.smethod_4(string_0);
    }

    public static void smethod_2(string string_1)
    {
        string_0 = "select imp_id, goods_id, qty from tblLoanTran where trans_num = '" + string_1 + "'";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataTable table = new DataTable())
        {
            oleDbDataAdapter_0.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                string_0 = string.Concat(new object[] { "UPDATE  tblStockInfo SET imp_qty = imp_qty - ", row["qty"], " ,last_date ='", Class7.smethod_19(), "' WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "' " });
                Class7.smethod_4(string_0);
            }
        }
    }

    public static void smethod_3(string string_1)
    {
        string_0 = "DELETE FROM tblLoanTran where trans_num = '" + string_1 + "' ";
        Class7.smethod_4(string_0);
    }

    public static bool smethod_4(string string_1)
    {
        string_0 = "select goods_id from tblLoantran where corr_tran <> '' and trans_num = '" + string_1 + "' ";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
            if (set.Tables[0].Rows.Count != 0)
            {
                return false;
            }
            return true;
        }
    }

    public static bool CheckCsCard(object object_0)
    {
        string_0 = "select id from tblCustomer where id = '" + object_0 + "' AND due_date > '" + Class7.smethod_19() + "' AND status = 1 ";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
            return (set.Tables[0].Rows.Count != 0);
        }
    }
}

