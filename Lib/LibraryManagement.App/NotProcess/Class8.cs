using System;
using System.Data;
using System.Data.OleDb;

internal class Class8
{
    public static OleDbConnection oleDbConnection_0;
    public static OleDbConnection oleDbConnection_1;
    public static OleDbDataAdapter oleDbDataAdapter_0;

    static Class8()
    {
        Class15.smethod_5();
        Class17.smethod_0();
        oleDbConnection_0 = new OleDbConnection(Class7.string_5);
        oleDbConnection_1 = new OleDbConnection(Class7.string_4);
    }

    public Class8()
    {
        Class17.smethod_0();
    }

    public static void RrqIxZxw5(object object_0, object object_1, object object_2)
    {
        string str = "Dep_Code,File_Name,Rela_File,Divided_by,Eod,Ds,Eom,Ms,Eoy,Ys";
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT " + str + " FROM FILEDIC WHERE DEP_CODE = '" + object_0 + "'", oleDbConnection_0);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        oleDbConnection_0.Close();
    }
}

