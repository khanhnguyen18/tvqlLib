using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using LibraryManagement.Dao.SqlClient;

namespace LibraryManagement.App
{
    public class DataProvider
    {
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(GetConnectionString());
        }

        public static string GetConnectionString()
        {
            return "Provider = sqloledb; " + ((SqlNetTiersProvider)Service.ConnectionScope.Current.DataProvider).ConnectionString;
        }

        public static string GetSqlConnectionString()
        {
            return ((SqlNetTiersProvider)Service.ConnectionScope.Current.DataProvider).ConnectionString;
        }
    }
}
