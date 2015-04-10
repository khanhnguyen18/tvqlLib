using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using LibraryManagement.App;

internal class Class6
{
    public static double double_0;
    public static string object_0;
    public static object object_1;
    public static OleDbConnection oleDbConnection_0;
    public static OleDbConnection oleDbConnection_1;
    public static OleDbDataAdapter oleDbDataAdapter_0;
    public static string string_0;
    public static string string_1;
    public static string string_10;
    public static string string_11;
    public static string string_12;
    public static string string_13;
    public static string string_2;
    public static string string_3;
    public static string string_4;
    public static string transNum;
    public static string string_6;
    public static string string_7;
    public static string string_8;
    public static string string_9;

    static Class6()
    {
        Class15.smethod_5();
        Class17.smethod_0();
        string_12 = DateTime.Now.ToString("HH:mm");
        oleDbConnection_0 = new OleDbConnection(Class7.string_5);
        oleDbConnection_1 = new OleDbConnection(Class7.string_4);
        string_13 = Class7.smethod_19();
    }

    public Class6()
    {
        Class17.smethod_0();
    }

    public void kCnalMegv(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id,qty,amount FROM " + string_14, oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        double num2 = 0.0;
        foreach (DataRow row in dataTable.Rows)
        {
            num2 = Class7.smethod_2(row["amount"]) / Class7.smethod_2(row["qty"]);
            object obj2 = "IF EXISTS (SELECT goods_id FROM tblPrice WHERE  goods_id = '" + row["goods_id"] + "') ";
            obj2 = string.Concat(new object[] { obj2, "UPDATE  tblPrice SET lastimppr = ", num2, " WHERE  goods_id = '", row["goods_id"], "' Else " });
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { obj2, "INSERT INTO tblPrice(goods_id, lastimppr) VALUES('", row["goods_id"], "',", num2, ")" }), oleDbConnection_0);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter_0.Fill(dataSet);
            oleDbConnection_0.Close();
        }
    }

    public void method_0(string string_14, string string_15, double double_1, double double_2)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM tblPrice WHERE goods_id = '" + string_14 + "'", oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
            double num = Class7.smethod_0(set.Tables[0].Rows[0]["rtprice"].ToString());
            double num2 = Class7.smethod_0(set.Tables[0].Rows[0]["wsprice"].ToString());
            string str = "INSERT INTO tblHisprice(Hisdate, Histime, goods_id, oldwsprice, newwsprice, oldrtprice, newrtprice, user_id) ";
            object obj2 = str;
            obj2 = string.Concat(new object[] { obj2, " VALUES('", string_13, "','", string_15, "','", string_14, "',", num2, ",", double_1, ",", num, "," });
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { obj2, " ", double_1, " ,", Class7.GetUserId(), " )" }), oleDbConnection_0);
            using (DataSet set2 = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set2);
            }
        }
        oleDbConnection_0.Close();
    }

    public void method_1(string string_14, string string_15, string string_16, double double_1, double double_2, double double_3, string string_17, string string_18)
    {
        double num = double_1 * double_3;
        double num2 = (num * double_2) / 100.0;
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { 
            "IF EXISTS (SELECT goods_id FROM ", string_14, " where goods_id = '", string_15, "') UPDATE ", string_14, " SET [qty] = ", double_1, " ,[amount] = ", double_3 * double_1, ",[price] = ", double_3, ",[disc_amt] = ", num2, " WHERE goods_id = '", string_15, 
            "' Else INSERT INTO ", string_14, "(goods_id, name, qty, price, disc_amt,amount,unitsymb,merc_type)  VALUES('", string_15, "' , N'", string_16, "',", double_1, ",", double_3, ",", num2, ",", num, ", '", string_17, 
            "', '", string_18, "') ; DELETE FROM ", string_14, " WHERE qty <= 0 "
         }), oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
        }
        oleDbConnection_0.Close();
    }

    public void method_10(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT exp_id, goods_id,qty,amount FROM  tblTransaction  WHERE trans_num = '" + string_14 + "' ", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            object obj2 = "UPDATE  tblStockInfo SET exp_qty = exp_qty - " + row["qty"] + " , ";
            obj2 = string.Concat(new object[] { obj2, "exp_amt = exp_amt - ", row["amount"], ", last_date ='", string_13, "' " });
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { obj2, "WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "' " }), oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
            }
            oleDbConnection_0.Close();
        }
    }

    public void method_11(string string_14, string string_15)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id FROM " + string_14, oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE  tblGoods SET supp_id = '", string_15, "'  WHERE  goods_id = '", row["goods_id"], "' " }), oleDbConnection_0);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter_0.Fill(dataSet);
            oleDbConnection_0.Close();
        }
    }

    public void ComputeTransnum(string string_14)
    {
        string str2 = ("IF EXISTS (SELECT * FROM tbltransNum WHERE Trans_type = '" + 
            smethod_0(SystemInformation.ComputerName) + string_14 + "') ") + "UPDATE tblTransNum SET last_num = last_num + 1 , last_date =  '" + string_13 + "'";
        str2 = (str2 + "WHERE Trans_type = '" + smethod_0(SystemInformation.ComputerName) + string_14 + "' ELSE ") + " INSERT INTO tblTransNum(trans_type,last_num,last_date)";
        oleDbDataAdapter_0 = new OleDbDataAdapter(str2 + " VALUES('" + smethod_0(SystemInformation.ComputerName) + string_14 + "',1,'" + string_13 + "')", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_13(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM tblTransaction WHERE trans_num = '" + string_14 + "' ", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_14(string string_14, string string_15, int int_0)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE ", string_14, " SET Status = ", int_0, " WHERE trans_num = '", string_15, "' " }), oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
    }

    public void method_15(string string_14, string string_15, ref string string_16, ref string string_17, ref string string_18, ref bool bool_0, ref string string_19, ref string string_20)
    {
        string str = "SELECT  A.goods_id, B.full_name, A.qty, A.amount, A.discount,A.surplus,A.vat_amt, A.unit_symb, A.merc_type, A.recnum ";
        oleDbDataAdapter_0 = new OleDbDataAdapter((str + "FROM tblTransaction AS A INNER JOIN tblGoods AS B ON A.goods_id = B.goods_id ") + "WHERE A.trans_num = '" + string_15 + "' ", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            Class7.smethod_2(row["vat_amt"]);
            double num = Class7.smethod_0(row["surplus"].ToString());
            double num2 = Class7.smethod_0(row["discount"].ToString());
            double num3 = (Class7.smethod_0(row["amount"].ToString()) + num2) + num;
            double num4 = ((num3 + num2) + num) / Class7.smethod_0(row["qty"].ToString());
            object obj2 = "INSERT INTO " + string_14 + "(goods_id, name, qty, price, disc_amt, amount,surplus, unitsymb,merc_type,idx) ";
            obj2 = string.Concat(new object[] { obj2, " VALUES('", row["goods_id"], "' ,N'", row["full_name"], "',", row["qty"], ",", num4, ", ", row["discount"], "," });
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { obj2, num3, ",", row["surplus"], ",'", row["unit_symb"], "','", row["merc_type"], "',", row["recnum"], " )" }), oleDbConnection_0);
            DataSet set = new DataSet();
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM tblTransaction WHERE trans_num = '" + string_15 + "' ", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
        if (dataSet.Tables[0].Rows.Count != 0)
        {
            string_16 = dataSet.Tables[0].Rows[0]["imp_id"].ToString();
            string_17 = dataSet.Tables[0].Rows[0]["exp_id"].ToString();
            string_18 = dataSet.Tables[0].Rows[0]["remark"].ToString();
            string_19 = dataSet.Tables[0].Rows[0]["voucher"].ToString();
            string_20 = dataSet.Tables[0].Rows[0]["tran_time"].ToString();
            bool_0 = (bool) dataSet.Tables[0].Rows[0]["Status"];
        }
    }

    public double method_16(string string_14, string string_15)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select averimppr from tblStockInfo where id = '" + string_14 + "' and goods_id = '" + string_15 + "'", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
        if (dataSet.Tables[0].Rows.Count != 0)
        {
            return Class7.smethod_0(dataSet.Tables[0].Rows[0][0].ToString());
        }
        return 0.0;
    }

    public void method_17(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT imp_id, goods_id, qty, amount FROM tblTransaction where trans_num = '" + string_14 + "'", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            double num = Class7.smethod_0(row["amount"].ToString()) / Class7.smethod_0(row["qty"].ToString());
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { 
                "IF EXISTS(Select goods_id from tblStockInfo WHERE  goods_id = '", row["goods_id"], "' and id = '", row["imp_id"], "')UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty + ", row["qty"], ") - exp_qty) WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt + ", row["amount"], ") - exp_amt)/((begin_qty + imp_qty + ", row["qty"], ") - exp_qty)  END WHERE  goods_id = '", row["goods_id"], "' and id = '", row["imp_id"], "' Else INSERT INTO tblStockInfo(id, goods_id, averimppr) VALUES('", row["imp_id"], 
                "','", row["goods_id"], "',", num, ")"
             }), oleDbConnection_0);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter_0.Fill(dataSet);
            oleDbConnection_0.Close();
        }
    }

    public void method_18(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT imp_id, goods_id, qty, amount FROM tblTransaction where trans_num = '" + string_14 + "'", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            try
            {
                oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty - ", row["qty"], ") - exp_qty) WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt - ", row["amount"], ") - exp_amt)/((begin_qty + imp_qty - ", row["qty"], ") - exp_qty) END WHERE  goods_id = '", row["goods_id"], "' and id = '", row["imp_id"], "'" }), oleDbConnection_0);
                DataSet dataSet = new DataSet();
                oleDbDataAdapter_0.Fill(dataSet);
                oleDbConnection_0.Close();
                continue;
            }
            catch (Exception exception)
            {
                Class7.smethod_38(exception.Message);
                continue;
            }
        }
    }

    public void method_19(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT exp_id, goods_id, qty, amount FROM tblTransaction where trans_num = '" + string_14 + "'", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            double num = Class7.smethod_0(row["amount"].ToString()) / Class7.smethod_0(row["qty"].ToString());
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { 
                "IF EXISTS(Select goods_id from tblStockInfo WHERE  goods_id = '", row["goods_id"], "' and id = '", row["exp_id"], "')UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty - ", row["qty"], ") - exp_qty) WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt - ", row["amount"], ") - exp_amt)/((begin_qty + imp_qty - ", row["qty"], ") - exp_qty)  END WHERE  goods_id = '", row["goods_id"], "' and id = '", row["exp_id"], "' Else INSERT INTO tblStockInfo(id, goods_id, averimppr) VALUES('", row["exp_id"], 
                "','", row["goods_id"], "',", num, ")"
             }), oleDbConnection_0);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter_0.Fill(dataSet);
            oleDbConnection_0.Close();
        }
    }

    public void method_2(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select goods_id from " + string_14, oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        int num = 1;
        foreach (DataRow row in dataTable.Rows)
        {
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { " UPDATE ", string_14, " set idx = ", num, " where goods_id = '", row["goods_id"].ToString(), "'" }), oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
                num++;
            }
            oleDbConnection_0.Close();
        }
    }

    public void method_20(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT exp_id, goods_id, qty, amount FROM tblTransaction where trans_num = '" + string_14 + "'", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            try
            {
                oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty + ", row["qty"], ") - exp_qty) WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt + ", row["amount"], ") - exp_amt)/((begin_qty + imp_qty + ", row["qty"], ") - exp_qty) END  WHERE  goods_id = '", row["goods_id"], "' and id = '", row["exp_id"], "'" }), oleDbConnection_0);
                DataSet dataSet = new DataSet();
                oleDbDataAdapter_0.Fill(dataSet);
                oleDbConnection_0.Close();
                continue;
            }
            catch (Exception exception)
            {
                Class7.smethod_38(exception.Message);
                continue;
            }
        }
    }

    public double method_21(string string_14, string string_15)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT (begin_qty + imp_qty) - exp_qty AS end_qty FROM tblStockInfo where id = '" + string_15 + "' and goods_id = '" + string_14 + "'", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        if (dataSet.Tables[0].Rows.Count != 0)
        {
            return Class7.smethod_0(dataSet.Tables[0].Rows[0][0].ToString());
        }
        return 0.0;
    }

    public bool method_22()
    {
        return (Class7.smethod_14("m_minus").ToString() == "1");
    }

    public void method_23()
    {
        DateTime time = DateTime.ParseExact(string_13, "dd/MM/yyyy", null);
        string str = string.Format("{0:00}", time.Month) + time.Year.ToString();
        string str2 = "STKINFO_" + str;
        if ((this.method_24(time).ToOADate() - time.ToOADate()) == 2.0)
        {
            DataSet set;
            if (Class7.smethod_28(str2))
            {
                oleDbDataAdapter_0 = new OleDbDataAdapter("delete from " + str2 + "; insert into " + str2 + " select * from tblStockInfo ;update tblStockInfo set begin_qty = (begin_qty + imp_qty) - exp_qty, begin_amt = (begin_amt + imp_amt) - exp_amt ;update tblStockInfo set imp_qty = 0, imp_amt = 0,exp_qty = 0, exp_amt = 0", oleDbConnection_0);
                set = new DataSet();
                oleDbDataAdapter_0.Fill(set);
                oleDbConnection_0.Close();
            }
            else
            {
                oleDbDataAdapter_0 = new OleDbDataAdapter("select * into " + str2 + " from tblStockInfo;update tblStockInfo set begin_qty = (begin_qty + imp_qty) - exp_qty, begin_amt = (begin_amt + imp_amt) - exp_amt ;update tblStockInfo set imp_qty = 0, imp_amt = 0,exp_qty = 0, exp_amt = 0", oleDbConnection_0);
                set = new DataSet();
                oleDbDataAdapter_0.Fill(set);
                oleDbConnection_0.Close();
            }
        }
    }

    public DateTime method_24(DateTime dateTime_0)
    {
        DateTime time = new DateTime(dateTime_0.Year, dateTime_0.Month, 1);
        return time.AddMonths(1).AddDays(-1.0);
    }

    public DateTime method_25(DateTime dateTime_0)
    {
        return new DateTime(dateTime_0.Year, dateTime_0.Month, 1);
    }

    public void method_26()
    {
        new FrmGetDates().ShowDialog();
        if (Class7.IsInputDate)
        {
            DataSet set;
            DataSet set2;
            DateTime time2 = Class7.dateTime_0;
            DateTime time3 = Class7.dateTime_1;
            string str6 = string.Format("{0:00}", time2.Month) + time2.Year.ToString();
            string str = "STKGL_" + smethod_0(SystemInformation.ComputerName);
            try
            {
                oleDbDataAdapter_0 = new OleDbDataAdapter("CREATE TABLE " + str + "([id] [nvarchar](5) DEFAULT (''),[grp_id] [nvarchar](3) DEFAULT (''),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[begin_qty] [decimal](18, 2) DEFAULT ((0)),[begin_amt] [decimal](18, 2) DEFAULT ((0)),[imP_qty] [decimal](18, 2) DEFAULT ((0)),[imp_amt] [decimal](18, 2) DEFAULT ((0)),[exp_qty] [decimal](18, 2) DEFAULT ((0)),[exp_amt] [decimal](18, 2) DEFAULT ((0)),[end_qty] [decimal](18, 2) DEFAULT ((0)),[end_amt] [decimal](18, 2) DEFAULT ((0)))", oleDbConnection_0);
                using (set = new DataSet())
                {
                    oleDbDataAdapter_0.Fill(set);
                }
                oleDbConnection_0.Close();
            }
            catch (Exception)
            {
                oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + str, oleDbConnection_0);
                using (set = new DataSet())
                {
                    oleDbDataAdapter_0.Fill(set);
                }
                oleDbConnection_0.Close();
            }
            string str3 = string.Empty;
            string str4 = string.Empty;
            oleDbDataAdapter_0 = new OleDbDataAdapter("select id from tblStore where type in('01','02') and status = 1", oleDbConnection_0);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter_0.Fill(dataTable);
            oleDbConnection_0.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                str4 = str4 + "'" + row["id"].ToString() + "',";
            }
            str3 = "(" + str4.Substring(0, str4.Length - 1) + ")";
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT stk.tran_date, stk.exp_id, stk.imp_id, stk.goods_id, stk.qty, stk.unit_symb, stk.amount, stk.vat_amt, stk.surplus, stk.Status, gs.full_name,gs.status AS gsstt FROM tblTransaction AS stk INNER JOIN tblGoods AS gs ON stk.goods_id = gs.goods_id WHERE (gs.status = 1) AND (stk.Status = 1) AND (stk.tran_date between '", time2, "' and '", time3, "') " }), oleDbConnection_0);
            DataTable table2 = new DataTable();
            oleDbDataAdapter_0.Fill(table2);
            oleDbConnection_0.Close();
            foreach (DataRow row in table2.Rows)
            {
                if (str3.Contains(row["imp_id"].ToString()))
                {
                    oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { 
                        "if not exists (select * from ", str, " where id = '", row["imp_id"], "' and goods_id = '", row["goods_id"], "') insert into ", str, "(id, goods_id, name, imp_qty, imp_amt) values('", row["imp_id"], "', '", row["goods_id"], "',N'", row["full_name"], "',", row["qty"], 
                        ",", row["amount"], ") Else update ", str, " set imp_qty = imp_qty + ", row["qty"], ", imp_amt = imp_amt + ", row["amount"], " where id = '", row["imp_id"], "' and goods_id = '", row["goods_id"], "'"
                     }), oleDbConnection_0);
                    set = new DataSet();
                    oleDbDataAdapter_0.Fill(set);
                    oleDbConnection_0.Close();
                }
                if (str3.Contains(row["exp_id"].ToString()))
                {
                    oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { 
                        "if not exists (select * from ", str, " where id = '", row["exp_id"], "' and goods_id = '", row["goods_id"], "') insert into ", str, "(id, goods_id, name, exp_qty, exp_amt) values('", row["exp_id"], "', '", row["goods_id"], "',N'", row["full_name"], "',", row["qty"], 
                        ",", row["amount"], ") Else update ", str, " set exp_qty = exp_qty + ", row["qty"], ", exp_amt = exp_amt + ", row["amount"], " where id = '", row["exp_id"], "' and goods_id = '", row["goods_id"], "'"
                     }), oleDbConnection_0);
                    set2 = new DataSet();
                    oleDbDataAdapter_0.Fill(set2);
                    oleDbConnection_0.Close();
                }
            }
            DateTime time = DateTime.ParseExact(string_13, "dd/MM/yyyy", null);
            if (((string.Format("{0:00}", time.Day) + string.Format("{0:00}", time.Month)) != str6) && Class7.smethod_28("STKINFO_" + str6))
            {
                oleDbDataAdapter_0 = new OleDbDataAdapter("select * from STKINFO_" + str6, oleDbConnection_0);
                DataTable table3 = new DataTable();
                oleDbDataAdapter_0.Fill(table3);
                oleDbConnection_0.Close();
                foreach (DataRow row in table3.Rows)
                {
                    oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { 
                        "if not exists (select * from ", str, " where id = '", row["id"], "' and goods_id = '", row["goods_id"], "') insert into ", str, "(id, goods_id, begin_qty, begin_amt) values('", row["id"], "', '", row["goods_id"], "',", row["qty"], ",", row["amount"], 
                        ") Else update ", str, " set begin_qty = begin_qty + ", row["qty"], ", begin_amt = begin_amt + ", row["amount"], " where id = '", row["id"], "' and goods_id = '", row["goods_id"], "'"
                     }), oleDbConnection_0);
                    set2 = new DataSet();
                    oleDbDataAdapter_0.Fill(set2);
                    oleDbConnection_0.Close();
                }
            }
            Class7.smethod_27("stk_gl").ShowPreviewDialog();
        }
    }

    public void method_3(string string_14, ListBoxControl listBoxControl_0)
    {
        int num = 0;
        OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT trCode, trName FROM tblTrcode WHERE trDepart = '" + string_14 + "' AND Status = 1 ORDER BY Trcode ", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        oleDbConnection_0.Close();
        if (dataSet.Tables[0].Rows.Count != 0)
        {
            listBoxControl_0.Items.Clear();
            for (num = 0; num <= (dataSet.Tables[0].Rows.Count - 1); num++)
            {
                listBoxControl_0.Items.Add(string.Concat(new object[] { "  ", dataSet.Tables[0].Rows[num]["Trcode"], "    ", dataSet.Tables[0].Rows[num]["TrName"] }));
            }
        }
        else
        {
            listBoxControl_0.Items.Clear();
        }
    }

    public void method_4(string string_14, ref string string_15, ref string string_16, ref string string_17, ref string string_18, ref string string_19, ref string string_20)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT *  FROM tblTrcode WHERE trCode = '" + string_14 + "' ", oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
            if (set.Tables[0].Rows.Count != 0)
            {
                string_15 = set.Tables[0].Rows[0]["trCode"].ToString().Trim();
                string_16 = set.Tables[0].Rows[0]["trName"].ToString().Trim();
                string_17 = set.Tables[0].Rows[0]["frmCaption"].ToString().Trim();
                string_18 = set.Tables[0].Rows[0]["VoucherFile"].ToString().Trim();
                string_19 = set.Tables[0].Rows[0]["VoucherFile1"].ToString().Trim();
                string_20 = set.Tables[0].Rows[0]["VoucherFile2"].ToString().Trim();
            }
            else
            {
                string_15 = string.Empty;
                string_16 = string.Empty;
                string_17 = string.Empty;
                string_18 = string.Empty;
                string_19 = string.Empty;
                string_20 = string.Empty;
            }
        }
    }

    public string method_5(string string_14)
    {
        string str = smethod_0(SystemInformation.ComputerName) + string_14;
        OleDbDataAdapter adapter = new OleDbDataAdapter(" SELECT * FROM tblTransnum WHERE Trans_Type = '" + str + "' ", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        adapter.Fill(dataSet);
        oleDbConnection_0.Close();
        if (dataSet.Tables[0].Rows.Count == 0)
        {
            return (str + "00000001");
        }
        double num = Class7.smethod_0(dataSet.Tables[0].Rows[0]["last_num"].ToString()) + 1.0;
        return (str + string.Format("{0:00000000}", num));
    }

    public void method_6(string string_14, string string_15, string string_16, string string_17, string string_18, string string_19, string string_20, string string_21)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id,qty,price,amount,idx,unitsymb, disc_amt,vat_amt,surplus,merc_type FROM " + string_14, oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        string str = string.Format("{0:d}", string_13);
        double num = 0.0;
        foreach (DataRow row in dataTable.Rows)
        {
            num = Class7.smethod_2(row["amount"]);
            string str2 = "INSERT INTO tblTransaction(tran_date, tran_time, trans_num, trans_code, voucher, invoice, post, exp_id, imp_id, ";
            string str3 = str2 + "goods_id, qty, unit_symb, amount, discount, vat_amt, surplus, commis_amt, user_id, cs_id, " + "remark, updated, merc_type, tax_code, vat_incl, discpervat, disc_incl, copies, recnum, Status,station) ";
            object obj2 = str3 + "VALUES('" + str + "','" + string_21 + "','" + string_15 + "','" + string_16 + "','" + string_19 + "','',0,'" + string_17 + "',";
            obj2 = string.Concat(new object[] { obj2, "'", string_18, "','", row["goods_id"], "', ", row["qty"], ", '", row["unitsymb"], "',", num, ", " });
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { 
                obj2, row["disc_amt"], ", ", row["vat_amt"], ", ", row["surplus"], ", 0, ", Class7.GetUserId(), ",'' ,N'", string_20, "' ,0 ,'", row["merc_type"], "' ,'' ,0 ,0 ,0 ,0 ,", row["idx"], " ,1,", Class7.smethod_51(), 
                " )"
             }), oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
            }
            oleDbConnection_0.Close();
        }
    }

    public void method_7(string string_14, string string_15)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id,qty,amount FROM  tblTransaction WHERE trans_num = '" + string_14 + "' ", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            double num = Class7.smethod_2(row["amount"]);
            string str = row["goods_id"].ToString().Trim();
            double num2 = Class7.smethod_2(row["qty"]);
            object obj2 = "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '" + string_15 + "' AND goods_id = '" + str + "') ";
            obj2 = string.Concat(new object[] { obj2, "UPDATE  tblStockInfo SET Imp_qty = imp_qty + ", num2, " ," });
            string str3 = string.Concat(new object[] { obj2, "imp_amt = imp_amt + ", num, " , last_date ='", string_13, "' " });
            obj2 = (str3 + "WHERE id = '" + string_15 + "' AND goods_id = '" + str + "' Else ") + "INSERT INTO tblStockInfo(id,goods_id, Imp_qty,imp_amt,last_date )  ";
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { obj2, "VALUES('", string_15, "','", str, "',", num2, ",", num, ",'", string_13, "')" }), oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
            }
            oleDbConnection_0.Close();
        }
    }

    public void method_8(string string_14)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT imp_id, goods_id,qty,amount FROM  tblTransaction  WHERE trans_num = '" + string_14 + "' ", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        foreach (DataRow row in dataTable.Rows)
        {
            object obj2 = "UPDATE  tblStockInfo SET Imp_qty = Imp_qty - " + row["qty"] + " ,";
            obj2 = string.Concat(new object[] { obj2, "imp_amt = imp_amt - ", row["amount"], ", last_date ='", string_13, "' " });
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { obj2, "WHERE id = '", row["imp_id"], "' AND goods_id = '", row["goods_id"], "' " }), oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
            }
            oleDbConnection_0.Close();
        }
    }

    public void method_9(string string_14, string string_15)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT imp_id, goods_id,qty,amount,discount,surplus FROM  tblTransaction  WHERE trans_num = '" + string_14 + "' ", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
        double num = 0.0;
        foreach (DataRow row in dataTable.Rows)
        {
            num = (Class7.smethod_2(row["amount"]) - Class7.smethod_2(row["discount"])) - Class7.smethod_2(row["surplus"]);
            Class7.smethod_2(row["qty"]);
            object obj2 = string.Concat(new object[] { "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '", string_15, "' AND goods_id = '", row["goods_id"], "') " });
            obj2 = string.Concat(new object[] { obj2, "UPDATE  tblStockInfo SET exp_qty = exp_qty + ", row["qty"], " ," });
            obj2 = string.Concat(new object[] { obj2, "exp_amt = exp_amt + ", num, ", last_date ='", string_13, "' " });
            obj2 = string.Concat(new object[] { obj2, "WHERE id = '", string_15, "' AND goods_id = '", row["goods_id"], "' Else " }) + "INSERT INTO tblStockInfo(id,goods_id, exp_qty,exp_amt,last_date )  ";
            oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { obj2, "VALUES('", string_15, "','", row["goods_id"], "',", row["qty"], ",", num, ",'", string_13, "')" }), oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                oleDbDataAdapter_0.Fill(set);
            }
            oleDbConnection_0.Close();
        }
    }

    public static string smethod_0(string string_14)
    {
        return string.Format("{0:000}", 1);
    }

    public static string smethod_3(string string_14)
    {
        string str = null;
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT trCode FROM tblTrcode WHERE trDepart = '" + string_14 + "' ", oleDbConnection_0);
        using (DataTable table = new DataTable())
        {
            oleDbDataAdapter_0.Fill(table);
            oleDbConnection_0.Close();
            foreach (DataRow row in table.Rows)
            {
                str = str + "'" + row[0].ToString() + "',";
            }
        }
        return str.Substring(0, str.Length - 1);
    }

    public static bool smethod_4(object object_2)
    {
        return true;
    }
}

