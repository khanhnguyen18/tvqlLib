using System;
using System.Data;
using System.Data.OleDb;

internal class Class10
{
    public static double double_0;
    public static double double_1;
    public static double double_2;
    private static OleDbConnection oleDbConnection_0;
    private static OleDbDataAdapter oleDbDataAdapter_0;
    private static string string_0;

    static Class10()
    {
        Class15.smethod_5();
        Class17.smethod_0();
        oleDbConnection_0 = new OleDbConnection(Class7.string_5);
        string_0 = null;
    }

    public Class10()
    {
        Class17.smethod_0();
    }

    public static bool smethod_0()
    {
        string_0 = "select id from tblstore where id = '" + Class7.smethod_40() + "' and type = '01' ";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
        return (dataSet.Tables[0].Rows.Count != 0);
    }

    public static double smethod_1(string string_1)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select tax_code from tblGoods where goods_id = '" + string_1 + "'", oleDbConnection_0);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_0.Close();
        return Class7.smethod_2(dataSet.Tables[0].Rows[0][0]);
    }

    public static bool smethod_2(string string_1)
    {
        string_0 = "SELECT mbc from tblGoods WHERE goods_id = '" + string_1 + "' ";
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_0, oleDbConnection_0);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_0.Close();
            return (bool) set.Tables[0].Rows[0][0];
        }
    }
}

