using DevExpress.Utils;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

internal class Class9
{
    public static OleDbConnection oleDbConnection_0;
    public static OleDbDataAdapter oleDbDataAdapter_0;
    public static string string_0;

    static Class9()
    {
        Class15.smethod_5();
        Class17.smethod_0();
        oleDbConnection_0 = new OleDbConnection(Class7.string_5);
        string_0 = null;
    }

    public Class9()
    {
        Class17.smethod_0();
    }

    public static void RrqIxZxw5(string string_1)
    {
        DataTable table;
        DataSet set;
        WaitDialogForm form = new WaitDialogForm();
        form.Caption = "Xin chờ một ch\x00fat ...";

        string str = "STK_GL";
        string str2 = null;
        string str3 = ",";
        string_0 = "SELECT id FROM tblStore " + string_1;
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (table = new DataTable())
        {
            oleDbDataAdapter_0.Fill(table);
            oleDbConnection_0.Close();
            foreach (DataRow row in table.Rows)
            {
                string str4 = str2;
                str2 = str4 + "'" + row[0].ToString().Trim() + "'" + str3;
            }
        }
        str2 = str2.Substring(1, str2.Length - 3);
        string_0 = string.Concat(new object[] { "DELETE FROM ", str, " WHERE user_id = ", Class7.GetUserId() });
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
        string_0 = "SELECT stk.id, stk.goods_id, gs.full_name,gs.grp_id,(stk.begin_qty + stk.imp_qty - stk.exp_qty) AS end_qty,(stk.begin_amt + stk.imp_amt - stk.exp_amt) as end_amt  FROM tblGoods AS gs INNER JOIN tblStockInfo AS stk ON gs.goods_id = stk.goods_id WHERE stk.id IN('" + str2 + "')";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (table = new DataTable())
        {
            oleDbDataAdapter_0.Fill(table);
            oleDbConnection_0.Close();
            foreach (DataRow row in table.Rows)
            {
                string_0 = string.Concat(new object[] { 
                    "INSERT INTO ", str, "(id,goods_id,grp_id,full_name,tend_qty,tend_amt,user_id)  VALUES('", row["id"], "','", row["goods_id"], "','", row["grp_id"], "', N'", row["full_name"], "',", row["end_qty"], ",", row["end_amt"], ", ", Class7.GetUserId(), 
                    ") "
                 });
                oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                using (set = new DataSet())
                {
                    oleDbDataAdapter_0.Fill(set);
                    oleDbConnection_0.Close();
                    continue;
                }
            }
        }
        string_0 = "SELECT * FROM tblTransaction WHERE  status = 1 AND tran_date >= '" + Class7.dateTimeFrom + "'";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (table = new DataTable())
        {
            oleDbDataAdapter_0.Fill(table);
            oleDbConnection_0.Close();
            foreach (DataRow row in table.Rows)
            {
                string str5 = row["trans_code"].ToString();
                double num = Class7.smethod_2(row["amount"]);
                double num2 = Class7.smethod_2(row["discount"]);
                double num3 = Class7.smethod_2(row["surplus"]);
                double num4 = Class7.smethod_2(row["vat_amt"]);
                string str6 = row["exp_id"].ToString().Trim();
                string str7 = row["goods_id"].ToString().Trim();
                string str8 = row["imp_id"].ToString().Trim();
                DateTime time = DateTime.Parse(row["tran_date"].ToString());
                switch (str5)
                {
                    case "00":
                    {
                        form.Caption = "Giao dịch b\x00e1n lẻ ...";
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET texp_qty = texp_qty + ", row["qty"], ", texp_amt = texp_amt + ", num - ((num2 + num4) + num3), " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET rt_qty = rt_qty + ", row["qty"], ", rt_amt = rt_amt + ", num - ((num2 + num4) + num3), " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "01":
                    {
                        form.Caption = "Giao dịch trả lại ...";
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET timp_qty = timp_qty + ", row["qty"], ", timp_amt = timp_amt + ", num - ((num2 + num4) + num3), " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET rb_qty = rb_qty + ", row["qty"], ", rb_amt = rb_amt + ", num - ((num2 + num4) + num3), " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "13":
                    {
                        form.Caption = "Giao dịch nhập kho ...";
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET timp_qty = timp_qty + ", row["qty"], ", timp_amt = timp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET  frsupp_qty = frsupp_qty + ", row["qty"], ", frsupp_amt = frsupp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "23":
                    {
                        form.Caption = "Giao dịch nhập kho ...";
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET timp_qty = timp_qty + ", row["qty"], ", timp_amt = timp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET  frsupp_qty = frsupp_qty + ", row["qty"], ", frsupp_amt = frsupp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "30":
                    {
                        form.Caption = "Giao dịch nhập kho ...";
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET timp_qty = timp_qty + ", row["qty"], ", timp_amt = timp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET  frsupp_qty = frsupp_qty + ", row["qty"], ", frsupp_amt = frsupp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "15":
                    {
                        form.Caption = "Giao dịch xuất trả ...";
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET texp_qty = texp_qty + ", row["qty"], ", texp_amt = texp_amt + ", num, " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET tosupp_qty = tosupp_qty + ", row["qty"], ", tosupp_amt = tosupp_amt + ", num, " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "10":
                    {
                        form.Caption = "Giao dịch nội bộ ...";
                        string_0 = string.Concat(new object[] { 
                            "UPDATE ", str, " SET timp_qty = timp_qty + ", row["qty"], ", timp_amt = timp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "'; UPDATE ", str, " SET texp_qty = texp_qty + ", row["qty"], ", texp_amt = texp_amt + ", num, 
                            " WHERE id = '", str6, "' AND goods_id = '", str7, "' "
                         });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { 
                            "UPDATE ", str, " SET frstk_qty = frstk_qty + ", row["qty"], ", frstk_amt = frstk_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "'; UPDATE ", str, " SET tostk_qty = tostk_qty + ", row["qty"], ", tostk_amt = tostk_amt + ", num, 
                            " WHERE id = '", str6, "' AND goods_id = '", str7, "' "
                         });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "50":
                    {
                        form.Caption = "Giao dịch c\x00e2n đối ...";
                        string_0 = string.Concat(new object[] { 
                            "UPDATE ", str, " SET timp_qty = timp_qty + ", row["qty"], ", timp_amt = timp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "'; UPDATE ", str, " SET texp_qty = texp_qty + ", row["qty"], ", texp_amt = texp_amt + ", num, 
                            " WHERE id = '", str6, "' AND goods_id = '", str7, "' "
                         });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { 
                            "UPDATE ", str, " SET frwstk_qty = frwstk_qty + ", row["qty"], ", frwstk_amt = frwstk_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' ; UPDATE ", str, " SET towstk_qty = towstk_qty + ", row["qty"], ", towstk_amt = towstk_amt + ", num, 
                            " WHERE id = '", str6, "' AND goods_id = '", str7, "' "
                         });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "19":
                    {
                        form.Caption = "Giao dịch thanh l\x00fd ...";
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET texp_qty = texp_qty + ", row["qty"], ", texp_amt = texp_amt + ", num, " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET toowner_qty = toowner_qty + ", row["qty"], ", toowner_amt = toowner_amt + ", num, " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "11":
                    {
                        form.Caption = "Giao dịch b\x00e1n bu\x00f4n ...";
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET texp_qty = texp_qty + ", row["qty"], ", texp_amt = texp_amt + ", num, " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                        }
                        if (time > Class7.dateTimeTo)
                        {
                            continue;
                        }
                        string_0 = string.Concat(new object[] { "UPDATE ", str, " SET todealer_qty = todealer_qty + ", row["qty"], ", todealer_amt = todealer_amt + ", num, " WHERE id = '", str6, "' AND goods_id = '", str7, "' " });
                        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            oleDbDataAdapter_0.Fill(set);
                            oleDbConnection_0.Close();
                            continue;
                        }
                    }
                    case "12":
                        goto Label_1727;

                    default:
                    {
                        continue;
                    }
                }
            Label_1727:
                form.Caption = "Giao dịch từ đại l\x00fd ...";
                string_0 = string.Concat(new object[] { "UPDATE ", str, " SET timp_qty = timp_qty + ", row["qty"], ", timp_amt = timp_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' " });
                oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                using (set = new DataSet())
                {
                    oleDbDataAdapter_0.Fill(set);
                    oleDbConnection_0.Close();
                }
                if (time <= Class7.dateTimeTo)
                {
                    string_0 = string.Concat(new object[] { "UPDATE ", str, " SET frdealer_qty = frdealer_qty + ", row["qty"], ", frdealer_amt = frdealer_amt + ", num, " WHERE id = '", str8, "' AND goods_id = '", str7, "' " });
                    oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        oleDbDataAdapter_0.Fill(set);
                        oleDbConnection_0.Close();
                        continue;
                    }
                }
            }
        }
        form.Close();
        string_0 = "UPDATE " + str + " SET beg_qty = tend_qty + texp_qty - timp_qty, beg_amt = tend_amt + texp_amt - timp_amt";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
        string_0 = "UPDATE " + str + " SET end_qty = beg_qty + (frsupp_qty + frdealer_qty + frstk_qty + frwstk_qty + rb_qty) - (tosupp_qty + todealer_qty + tostk_qty + towstk_qty + toowner_qty + rt_qty), end_amt = beg_amt + (frsupp_amt + frdealer_amt + frstk_amt + frwstk_amt + rb_amt) - (tosupp_amt + todealer_amt + tostk_amt + towstk_amt + toowner_amt + rt_amt)";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
    }

    public static void smethod_0(string string_1)
    {
        string str = null;
        DataSet set;
        string str2 = ",";
        string_0 = "SELECT id FROM tblStore " + string_1;
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataTable table = new DataTable())
        {
            oleDbDataAdapter_0.Fill(table);
            oleDbConnection_0.Close();
            foreach (DataRow row in table.Rows)
            {
                string str4 = str;
                str = str4 + "'" + row[0].ToString().Trim() + "'" + str2;
            }
        }
        str = str.Substring(1, str.Length - 3);
        string str3 = "STKGL_" + Class6.smethod_0(SystemInformation.ComputerName);
        string_0 = "CREATE TABLE " + str3 + "([id] [nchar](5) DEFAULT (('')),[goods_id] [nchar](6) DEFAULT (('')), [grp_id] [nchar](4) DEFAULT (('')),[full_name] [nvarchar](200) DEFAULT (('')),[tend_qty] [numeric](18, 2) DEFAULT ((0)),[tend_amt] [numeric](18, 2) DEFAULT ((0)),[beg_qty] [numeric](18, 2) DEFAULT ((0)),[beg_amt] [numeric](18, 2) DEFAULT ((0)),[rt_qty] [numeric](18, 2) DEFAULT ((0)),[rt_amt] [numeric](18, 2) DEFAULT ((0)),[rb_qty] [numeric](18, 2) DEFAULT ((0)),[rb_amt] [numeric](18, 2) DEFAULT ((0)),[todealer_qty] [numeric](18, 2) DEFAULT ((0)),[todealer_amt] [numeric](18, 2) DEFAULT ((0)),[frdealer_qty] [numeric](18, 2) DEFAULT ((0)),[frdealer_amt] [numeric](18, 2) DEFAULT ((0)),[tostk_qty] [numeric](18, 2) DEFAULT ((0)),[tostk_amt] [numeric](18, 2) DEFAULT ((0)),[frstk_qty] [numeric](18, 2) DEFAULT ((0)),[frstk_amt] [numeric](18, 2) DEFAULT ((0)),[frsupp_qty] [numeric](18, 2) DEFAULT ((0)),[frsupp_amt] [numeric](18, 2) DEFAULT ((0)),[tosupp_qty] [numeric](18, 2) DEFAULT ((0)),[tosupp_amt] [numeric](18, 2) DEFAULT ((0)),[end_qty] [numeric](18, 2) DEFAULT ((0)),[end_amt] [numeric](18, 2) DEFAULT ((0)),[texp_qty] [numeric](18, 2) DEFAULT ((0)),[texp_amt] [numeric](18, 2) DEFAULT ((0)),[timp_qty] [numeric](18, 2) DEFAULT ((0)),[timp_amt] [numeric](18, 2) DEFAULT ((0)),[frwstk_qty] [numeric](18, 2) DEFAULT ((0)),[frwstk_amt] [numeric](18, 2) DEFAULT ((0)), [towstk_qty] [numeric](18, 2) DEFAULT ((0)),[towstk_amt] [numeric](18, 2) DEFAULT ((0)),[toowner_qty] [numeric](18, 2) DEFAULT ((0)),[toowner_amt] [numeric](18, 2) DEFAULT ((0))) ";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
        string_0 = "INSERT INTO " + str3 + "(id,goods_id,grp_id,full_name,tend_qty,tend_amt)  SELECT stk.id, stk.goods_id, gs.full_name,gs.grp_id,(stk.begin_qty + stk.imp_qty - stk.exp_qty) AS end_qty,(stk.begin_amt + stk.imp_amt - stk.exp_amt) as end_amt  FROM tblGoods AS gs INNER JOIN tblStockInfo AS stk ON gs.goods_id = stk.goods_id  WHERE stk.id IN('" + str + "')";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
        }
    }
}

