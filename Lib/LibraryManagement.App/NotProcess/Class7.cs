using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Microsoft.Win32;
using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using LibraryManagement.App;

internal class Class7
{
    public static bool bool_0;
    public static DateTime dateTimeFrom;
    public static DateTime dateTimeTo;
    public static DateTime dateTime_2;
    public static DateTime dateTime_3;
    public static int int_0;
    public static object object_0;
    public static object object_1;
    public static object object_2;
    public static object object_3;
    public static OleDbConnection oleDbConnection_0;
    public static OleDbConnection oleDbConnection_1;
    public static OleDbConnection oleDbConnection_2;
    private static OleDbDataAdapter oleDbDataAdapter_0;
    public static bool IsInputDate;
    public static string string_0;
    public static string string_1;
    public static string string_2;
    public static string string_3;
    public static string string_4;
    public static string string_5;
    public static string string_6;
    public static string Name = "KHANH";
    public static string string_8;

    static Class7()
    {
        //Class15.smethod_5();
        //Class17.smethod_0();
        bool_0 = false;
        string_0 = null;
        int_0 = 0;
        string_3 = "Provider=Microsoft.Jet.OLEDB.4.0; data source= " + Application.StartupPath + @"\Menus.xls;Extended Properties=Excel 8.0;";
        oleDbConnection_0 = new OleDbConnection(string_3);
        string_4 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\Share.mdb;User Id=admin;Password=;";
        string_5 = DataProvider.GetConnectionString();
        string_6 = DataProvider.GetSqlConnectionString();
        oleDbConnection_1 = new OleDbConnection(string_5);
        oleDbConnection_2 = new OleDbConnection(string_4);
        IsInputDate = false;
        string_8 = "Xin chờ một ch\x00fat ....";
    }

    public Class7()
    {
        Class17.smethod_0();
    }

    public static bool kCnalMegv(string string_9)
    {
        if (string_9 == null)
        {
            string_9 = "";
        }
        if (string_9.Length > 0)
        {
            try
            {
                DateTime.Parse(string_9);
            }
            catch
            {
                return false;
            }
            return true;
        }
        return false;
    }

    public void method_0(string string_9)
    {
        string str = null;
        string requestUriString = string_9;
        WebResponse response = null;
        StreamReader reader = null;
        try
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(requestUriString);
            request.Method = "GET";
            response = request.GetResponse();
            reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            str = reader.ReadToEnd();
            using (StreamWriter writer = new StreamWriter(Application.StartupPath + @"\config.ini", false))
            {
                writer.WriteLine(str);
                writer.Close();
            }
        }
        catch (Exception)
        {
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
            }
            if (response != null)
            {
                response.Close();
            }
        }
    }

    public DataSet method_1()
    {
        int num;
        DataSet set = new DataSet();
        DataTable table = new DataTable("Table");
        DataRow row = null;
        table.Columns.Add(new DataColumn("ID", typeof(int)));
        table.Columns.Add(new DataColumn("Name", typeof(string)));
        for (num = 0; num < 5; num++)
        {
            row = table.NewRow();
            table.Rows.Add(row);
            table.Rows[num]["ID"] = num;
            table.Rows[num]["Name"] = "NewName" + num.ToString();
        }
        set.Tables.Add(table);
        DataSet set3 = new DataSet();
        DataTable table2 = new DataTable("Table");
        DataRow row2 = null;
        table2.Columns.Add(new DataColumn("ID", typeof(int)));
        table2.Columns.Add(new DataColumn("Name", typeof(string)));
        set3.Tables.Add(table2);
        for (num = 0; num < 10; num++)
        {
            row2 = table2.NewRow();
            table2.Rows.Add(row2);
            table2.Rows[num]["ID"] = num;
            table2.Rows[num]["Name"] = "AddUpdatedName" + num.ToString();
        }
        string str = "";
        for (int i = 0; i < set3.Tables[0].Rows.Count; i++)
        {
            str = set3.Tables[0].Rows[i]["ID"].ToString();
            if (set.Tables[0].Select("ID = " + str).Length > 0)
            {
                for (int j = 0; j < set.Tables[0].Columns.Count; j++)
                {
                    set.Tables[0].Rows[i][j] = set3.Tables[0].Rows[i][j];
                }
            }
            else
            {
                set.Tables[0].Rows.Add(set3.Tables[0].Rows[i].ItemArray);
            }
        }
        return set;
    }

    public static double smethod_0(string string_9)
    {
        if (string.IsNullOrEmpty(string_9))
        {
            return 0.0;
        }
        return double.Parse(string_9);
    }

    public static decimal smethod_1(string string_9)
    {
        if (string.IsNullOrEmpty(string_9))
        {
            return 0M;
        }
        return decimal.Parse(string_9);
    }

    public static long smethod_10(string string_9)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + string_9, oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            long count = set.Tables[0].Rows.Count;
            return (count + 1L);
        }
    }

    public static long smethod_11(string string_9)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select DISTINCT(trans_num) from " + string_9, oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            long count = set.Tables[0].Rows.Count;
            return (count + 1L);
        }
    }

    public static bool smethod_12(string string_9)
    {
        if (string_9 == null)
        {
            string_9 = "";
        }
        if (string_9.Length > 0)
        {
            double result = 0.0;
            CultureInfo info = new CultureInfo("en-US", true);
            return double.TryParse(string_9, NumberStyles.Any, (IFormatProvider) info.NumberFormat, out result);
        }
        return false;
    }

    public static string smethod_13(object object_4, object object_5)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select id, description from " + object_4 + " where id = '" + object_5 + "'", oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            if (set.Tables[0].Rows.Count != 0)
            {
                return (set.Tables[0].Rows[0][0].ToString() + "  |  " + set.Tables[0].Rows[0][1].ToString());
            }
            return string.Empty;
        }
    }

    public static object smethod_14(string string_9)
    {
        object obj2 = null;
        string str = null;
        string str2 = null;
        oleDbDataAdapter_0 = new OleDbDataAdapter("select * from tblsysvar where m_code= '" + string_9 + "' ", oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            if (set.Tables[0].Rows.Count != 0)
            {
                str = set.Tables[0].Rows[0]["m_type"].ToString().Trim();
                str2 = set.Tables[0].Rows[0]["m_value"].ToString().Trim();
            }
        }
        if (string.IsNullOrEmpty(str))
        {
            return obj2;
        }
        string str3 = str;
        switch (str3)
        {
            case null:
                return obj2;

            case "N":
                if (smethod_12(str2))
                {
                    return smethod_0(str2);
                }
                return 0;
        }
        if (!(str3 == "D"))
        {
            if (str3 == "C")
            {
                obj2 = str2.ToString();
            }
            return obj2;
        }
        if (kCnalMegv(str2))
        {
            return DateTime.ParseExact(str2, "dd/MM/yyyy", null);
        }
        return DateTime.Parse("01/01/1900");
    }

    public static int ShowMessageBox(string content, int onlyOkButton)
    {
        FrmMsgbox msgbox = new FrmMsgbox();
        msgbox.Lbl_Info.Text = content;

        if (onlyOkButton == 1)
        {
            msgbox.btn_Accept.Visible = false;
            msgbox.btn_Skip.Visible = false;
            msgbox.btn_Ok.Visible = true;
        }
        else if (onlyOkButton == 2)
        {
            msgbox.btn_Accept.Visible = true;
            msgbox.btn_Skip.Visible = true;
            msgbox.btn_Ok.Visible = false;
        }
        msgbox.ShowDialog();
        return msgbox.ret;
    }

    public static void BrowserForm1(string string_9, OleDbConnection object_4)
    {
        BrowseForm browse = new BrowseForm();
        browse.grd_Look.DataSource = null;

        oleDbDataAdapter_0 = new OleDbDataAdapter(string_9,  object_4);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            object_4.Close();
            browse.grd_Look.DataSource = set.Tables[0];
        }
        browse.ShowDialog();
    }

    public static void smethod_17(object object_4, object object_5, object object_6, object object_7, object object_8, object object_9, ref string string_9)
    {
        //TODO:Need implement
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT " + object_4 + " FROM " + object_5 + " WHERE " + object_6 + " = '" + object_7 + "'  " + object_8, (OleDbConnection) object_9);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            //object_9.Close();
            if (set.Tables[0].Rows.Count != 0)
            {
                string_9 = set.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                string_9 = string.Empty;
            }
        }
    }

    public static bool smethod_18(object object_4, object object_5, object object_6)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + object_4 + " where " + object_5 + "= '" + object_6 + "' ", oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            return (set.Tables[0].Rows.Count != 0);
        }
    }

    public static string smethod_19()
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(" SELECT getdate()", oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            if (set.Tables[0].Rows.Count != 0)
            {
                CultureInfo provider = new CultureInfo("en-US");
                DateTime time2 = new DateTime();
                return DateTime.Parse(set.Tables[0].Rows[0][0].ToString(), provider).ToString("MM/dd/yyyy");
            }
            return DateTime.Now.ToString("MM/dd/yyyy");
        }
    }

    public static double smethod_2(object object_4)
    {
        if (string.IsNullOrEmpty(object_4.ToString()))
        {
            return 0.0;
        }
        return double.Parse(object_4.ToString());
    }

    public static void smethod_20(PictureEdit pictureEdit_0, object object_4, object object_5, object object_6, object object_7)
    {
        SqlConnection connection = new SqlConnection(string_6);
        SqlCommand command = new SqlCommand("UPDATE " + object_4 + " SET " + object_5 + " = (@PicData) WHERE " + object_6 + "= '" + object_7 + "' ", connection);
        MemoryStream stream = new MemoryStream();
        try
        {
            pictureEdit_0.Image.Save(stream, ImageFormat.Jpeg);
            byte[] buffer = new byte[stream.Length];
            stream.Position = 0L;
            stream.Read(buffer, 0, (int) stream.Length);
            SqlParameter parameter = new SqlParameter("@PicData", SqlDbType.VarBinary, buffer.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, buffer);
            command.Parameters.Add(parameter);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        catch (Exception)
        {
        }
    }

    public static Image smethod_21(byte[] byte_0)
    {
        if (byte_0 != null)
        {
            using (MemoryStream stream = new MemoryStream(byte_0))
            {
                return Image.FromStream(stream);
            }
        }
        return null;
    }

    public static int GetUserId()
    {
        return 1;
    }

    public static void smethod_23(object object_4, int int_1, object object_5, object object_6, object object_7, OleDbConnection oleDbConnection_3)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE ", object_4, " SET Status = ", int_1, " WHERE ", object_5, " = '", object_6, "' ", object_7 }), oleDbConnection_3);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
        }
        oleDbConnection_1.Close();
    }


    public static XtraForm smethod_26(string string_9)
    {
        return (XtraForm) Activator.CreateInstance(System.Type.GetType(Assembly.GetEntryAssembly().GetName().Name.Replace(" ", "_") + "." + string_9));
    }

    public static XtraReport CreateReportInstance(string string_9)
    {
        return (XtraReport) Activator.CreateInstance(System.Type.GetType(Assembly.GetEntryAssembly().GetName().Name.Replace(" ", "_") + "." + string_9));
    }

    public static bool smethod_28(string string_9)
    {
        string str = string_9.Trim().ToUpper();
        oleDbDataAdapter_0 = new OleDbDataAdapter("select * from sys.objects WHERE UPPER(RTRIM(LTRIM(NAME))) = '" + str + "'", oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            if (set.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
    }

    public static object smethod_29(object object_4, object object_5, object object_6, object object_7, object object_8, OleDbConnection oleDbConnection_3)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select " + object_5 + " from " + object_4 + " where " + object_6 + " = '" + object_7 + "' " + object_8, oleDbConnection_3);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            if (set.Tables[0].Rows.Count != 0)
            {
                return set.Tables[0].Rows[0][0];
            }
            return string.Empty;
        }
    }

    public static void smethod_3(object object_4, object object_5)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE tblsysvar SET M_VALUE = N'", object_5, "' WHERE M_CODE = '", object_4, "' " }), oleDbConnection_1);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet);
        oleDbConnection_1.Close();
    }

    public static void smethod_30()
    {
        if ((SystemInformation.ComputerName == "TUANANH") && System.IO.File.Exists(Application.StartupPath + @"\Menus.xls"))
        {
            oleDbDataAdapter_0 = new OleDbDataAdapter("delete tblMenus", oleDbConnection_1);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter_0.Fill(dataSet);
            string selectCommandText = "SELECT [ID], [Child_ID], [Menu_Key], [Shortcut], [Menu_Type], [Menu_Image], [Menu_Name],[Skip]  from [tblMenus$]";
            oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, oleDbConnection_0);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter_0.Fill(dataTable);
            string str2 = null;
            string str3 = null;
            string str4 = null;
            string str5 = null;
            string str6 = null;
            foreach (DataRow row in dataTable.Rows)
            {
                int num = int.Parse(row["ID"].ToString());
                str2 = row["Child_ID"].ToString().Trim();
                str3 = row["Menu_Key"].ToString().Trim();
                str6 = row["Shortcut"].ToString().Trim();
                str4 = row["Menu_Type"].ToString().Trim();
                str5 = row["Menu_Name"].ToString().Trim();
                selectCommandText = "INSERT INTO [tblMenus]([ID], [Child_ID], [Menu_Key], [Shortcut], [Menu_Type],  [Menu_Name])";
                object obj2 = selectCommandText;
                oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { obj2, " VALUES (", num, ",", str2, ",'", str3, "','", str6, "','", str4, "',N'", str5, "')" }), oleDbConnection_1);
                DataSet set2 = new DataSet();
                oleDbDataAdapter_0.Fill(set2);
            }
        }
    }

    public static void smethod_31()
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select Menu_Key from tblMenus where Menu_Key <>'BAR' ", oleDbConnection_1);
        DataTable dataTable = new DataTable();
        oleDbDataAdapter_0.Fill(dataTable);
        foreach (DataRow row in dataTable.Rows)
        {
            using (StreamWriter writer = new StreamWriter(Application.StartupPath + @"\menus.txt", true))
            {
                writer.WriteLine(string.Concat(new object[] { "case ", '"', row[0].ToString(), '"', ":" }));
                writer.WriteLine("");
                writer.WriteLine("break;");
                writer.Close();
                continue;
            }
        }
    }

    public static void smethod_32(Control control_0)
    {
        foreach (Control control in control_0.Controls)
        {
            if ((control is TextEdit) | (control is ComboBoxEdit))
            {
                using (StreamWriter writer = new StreamWriter(Application.StartupPath + @"\control.txt", true))
                {
                    writer.WriteLine(control.Name.ToString());
                    writer.Close();
                    continue;
                }
            }
        }
    }

    public static void smethod_33(object object_4, string string_9)
    {
        object target = Activator.CreateInstance(System.Type.GetTypeFromProgID("JRO.JetEngine"));
        object[] args = new object[] { object_4, @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\tempdb.mdb;Jet OLEDB:Engine Type=5" };
        target.GetType().InvokeMember("CompactDatabase", BindingFlags.InvokeMethod, null, target, args);
        System.IO.File.Delete(string_9);
        System.IO.File.Move(@"C:\tempdb.mdb", string_9);
        Marshal.ReleaseComObject(target);
        target = null;
    }

    public static string smethod_34(string string_9)
    {
        string[] strArray2 = new string[] { " Kh\x00f4ng", " Một", " Hai", " Ba", " Bốn", " Năm", " S\x00e1u", " Bảy", " T\x00e1m", " Ch\x00edn" };
        string str = "";
        if (string_9 == "000")
        {
            return "";
        }
        char ch = string_9[0];
        str = strArray2[int.Parse(ch.ToString())] + " Trăm";
        ch = string_9[1];
        if (ch.ToString() == "0")
        {
            ch = string_9[2];
            if (ch.ToString() == "0")
            {
                return str;
            }
            ch = string_9[2];
            return (str + " Lẻ" + strArray2[int.Parse(ch.ToString())]);
        }
        ch = string_9[1];
        str = str + strArray2[int.Parse(ch.ToString())] + " Mươi";
        ch = string_9[2];
        if (ch.ToString() == "5")
        {
            str = str + " Lăm";
        }
        else
        {
            ch = string_9[2];
            if (ch.ToString() != "0")
            {
                ch = string_9[2];
                str = str + strArray2[int.Parse(ch.ToString())];
            }
        }
        return str;
    }

    public static string smethod_35(string string_9)
    {
        string_9 = string_9.Replace(",", "");
        if (string_9 == string.Empty)
        {
            return "Kh\x00f4ng đồng chẵn";
        }
        string str2 = "";
        while (string_9.Length < 12)
        {
            string_9 = "0" + string_9;
        }
        string str6 = string_9.Substring(0, 3);
        string str = string_9.Substring(3, 3);
        string str4 = string_9.Substring(6, 3);
        string str3 = string_9.Substring(9, 3);
        if (str6 != "000")
        {
            str2 = smethod_34(str6) + " Tỷ";
        }
        if (str != "000")
        {
            str2 = str2 + smethod_34(str) + " Triệu";
        }
        if (str4 != "000")
        {
            str2 = str2 + smethod_34(str4) + " Ng\x00e0n";
        }
        str2 = (str2 + smethod_34(str3)).Replace("Một Mươi", "Mười").Trim();
        if (str2.IndexOf("Kh\x00f4ng Trăm") == 0)
        {
            str2 = str2.Remove(0, 10);
        }
        str2 = str2.Trim();
        if (str2.IndexOf("Lẻ") == 0)
        {
            str2 = str2.Remove(0, 2);
        }
        str2 = str2.Trim().Replace("Mươi Một", "Mươi Mốt").Trim();
        return (str2.Substring(0, 1).ToUpper() + str2.Substring(1).ToLower() + " đồng chẵn");
    }

    public static string smethod_36(TreeList treeList_0)
    {
        string str = null;
        string str2 = null;
        string str3 = null;
        foreach (TreeListNode node in treeList_0.Nodes[0].Nodes)
        {
            bool flag = false;
            int imageIndex = node.ImageIndex;
            TreeListNode node2 = node;
            node2.GetValue(2).ToString();
            node2.GetValue(1).ToString();
            Class11.smethod_18(node.Tag);
            if ((node.Tag != null) && (((int) node.Tag) == 1))
            {
                str2 = node.GetValue(1).ToString() + ";";
                foreach (TreeListNode node3 in node.Nodes)
                {
                    str = node3.GetValue(1).ToString();
                    str2 = str2 + str + ";";
                    flag = true;
                }
            }
            if ((node.Tag != null) && (((int) node.Tag) == 2))
            {
                str2 = node.GetValue(1).ToString() + ";";
                foreach (TreeListNode node3 in node.Nodes)
                {
                    if ((node3.Tag != null) && (((int) node3.Tag) == 2))
                    {
                        str = node3.GetValue(1).ToString();
                        str2 = str2 + str + ";";
                        flag = true;
                    }
                    if ((node3.Tag != null) && (((int) node3.Tag) == 1))
                    {
                        str = node3.GetValue(1).ToString();
                        str2 = str2 + str + ";";
                        flag = true;
                    }
                }
            }
            if (flag)
            {
                str3 = str3 + str2;
                flag = false;
            }
        }
        return str3;
    }

    public static void smethod_37()
    {
        if (ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a dữ liệu kh\x00f4ng ? ", 2) == 1)
        {
            string selectCommandText = "DELETE FROM tblStockInfo;DELETE FROM tblTransaction;DELETE FROM tblTransNum;DELETE FROM tblTransaction;DELETE FROM tblCust_Info";
            oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, oleDbConnection_1);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter_0.Fill(dataSet);
            oleDbConnection_1.Close();
        }
    }

    public static void smethod_38(object object_4)
    {
        using (StreamWriter writer = new StreamWriter(Application.StartupPath + @"\log.txt", true))
        {
            writer.WriteLine(string.Format("{0}:{1}", DateTime.Now.ToString(), object_4));
            writer.Close();
        }
    }

    public static void smethod_39()
    {
        string str = (string) Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\International", "sDate", "");
        if (str != "/")
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\International", "sDate", "/");
        }
        string str3 = (string) Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\International", "sShortDate", "");
        if (str3 != "M/d/yyyy")
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\International", "sShortDate", "M/d/yyyy");
        }
        string str4 = (string) Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\International", "sThousand", "");
        if (str4 != ",")
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\International", "sThousand", ",");
        }
        string str2 = (string) Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\International", "sDecimal", "");
        if (str2 != ".")
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\International", "sDecimal", ".");
        }
    }

    public static void smethod_4(string string_9)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string_9, oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
        }
    }

    //Get post id
    public static string smethod_40()
    {
        return "00001";
    }

    public static long smethod_41(Enum0 enum0_0, DateTime dateTime_4, DateTime dateTime_5)
    {
        TimeSpan span;
        span = span = (TimeSpan) (dateTime_5 - dateTime_4);
        switch (enum0_0)
        {
            case ((Enum0) 0):
                return (long) (dateTime_5.Year - dateTime_4.Year);

            case ((Enum0) 1):
                return (long) ((dateTime_5.Month - dateTime_4.Month) + (12 * (dateTime_5.Year - dateTime_4.Year)));

            case ((Enum0) 2):
                return (smethod_42(span.TotalDays) / 7L);

            case ((Enum0) 3):
                return smethod_42(span.TotalDays);

            case ((Enum0) 4):
                return smethod_42(span.TotalHours);

            case ((Enum0) 5):
                return smethod_42(span.TotalMinutes);
        }
        return smethod_42(span.TotalSeconds);
    }

    private static long smethod_42(double double_0)
    {
        if (double_0 >= 0.0)
        {
            return (long) Math.Floor(double_0);
        }
        return (long) Math.Ceiling(double_0);
    }

    public static void smethod_44(string string_9)
    {
        FrmGetAmount fr = new FrmGetAmount();
        fr.Text = string_9;
        fr.ShowDialog();
    }

    public static DateTime smethod_45()
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select min(tran_date) from tblTransaction", oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            if (!string.IsNullOrEmpty(set.Tables[0].Rows[0][0].ToString()))
            {
                return (DateTime) set.Tables[0].Rows[0][0];
            }
            return DateTime.Now;
        }
    }

    public static void smethod_46()
    {
        string str = null;
        string text1 = "CREATE TABLE StockInfo_" + str + "([id] [char](5) DEFAULT (''), [goods_id] [char](6) DEFAULT (''),\t[open_date] [datetime] NULL,[last_date] [datetime] NULL,[minus_date] [datetime] NULL,[stktake_dt] [datetime] NULL,[stktake_tm] [decimal](18, 2) DEFAULT ((0)),[begin_qty] [decimal](18, 2) NOT NULL DEFAULT ((0)),\t[exp_qty] [decimal](18, 2) NOT NULL DEFAULT ((0)),[imp_qty] [decimal](18, 2) NOT NULL DEFAULT ((0)),[begin_amt] [decimal](18, 2) NOT NULL DEFAULT ((0)),[exp_amt] [decimal](18, 2) NOT DEFAULT ((0)),\t[imp_amt] [decimal](18, 2) NOT NULL DEFAULT ((0)),[averimppr] [decimal](18, 2) NOT NULL DEFAULT ((0)))";
        for (int i = 0; i < ((((DateTime.Now.Year * 12) + DateTime.Now.Month) - (smethod_45().Year * 12)) - smethod_45().Month); i++)
        {
            DateTime time2 = smethod_45().AddMonths(i);
            str = string.Format("{0:00}", time2.Month);
            if (!smethod_28("ptr_" + str))
            {
                oleDbDataAdapter_0 = new OleDbDataAdapter("CREATE TABLE ptr_" + str + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)))", oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    oleDbDataAdapter_0.Fill(set);
                    oleDbConnection_1.Close();
                }
            }
        }
    }

    public static string smethod_47(string string_9)
    {
        string str = null;
        string str2 = null;
        string str3 = null;
        int startIndex = 0;
        str = "\x00c1\x00c0ẢẠ\x00c3ĂẶẮẰẲẴ\x00c2ẤẦẨẬẪ\x00caẾỀỆỂỄ\x00c9\x00c8ẺẸẼ\x00d4ỐỒỘỔỖƠỚỜỞỢỠƯỨỪỬỰỮ\x00da\x00d9ỦỤŨ\x00cd\x00ccỈĨỊ\x00ddỲỶỴỸĐă\x00e2\x00ea\x00f4ơưđ\x00e0ả\x00e3\x00e1ạằẳẵắặầẩẫấậ\x00e8ẻẽ\x00e9ẹềểễếệ\x00f2ỏ\x00f5\x00f3ọồổỗốộờởỡớợ\x00f9ủũ\x00faụừửữứự\x00ecỉĩ\x00edịỳỷỹ\x00fdỵ";
        str2 = "AAAAAAAAAAAAAAAAAEEEEEEEEEEEOOOOOOOOOOOOUUUUUUUUUUUIIIIIYYYYYDaaeooudaaaaaaaaaaaaaaaeeeeeeeeeeooooooooooooooouuuuuuuuuuiiiiiyyyyy";
        for (startIndex = 0; startIndex < string_9.Length; startIndex++)
        {
            int index = str.IndexOf(string_9.Substring(startIndex, 1));
            if (index > 0)
            {
                str3 = str3 + str2.Substring(index, 1);
            }
            else
            {
                str3 = str3 + string_9.Substring(startIndex, 1);
            }
        }
        return str3;
    }

    public static string smethod_48(string string_9)
    {
        string str = null;
        string str2 = null;
        string str3 = null;
        int startIndex = 0;
        str = "\x00a1\x00a2\x00a3\x00a4\x00a5\x00a6\x00a7\x00a8\x00a9\x00aa\x00ab\x00ac\x00ad\x00ae\x00b5\x00b6\x00b7\x00b8\x00b9\x00bb\x00bc\x00bd\x00be\x00c6\x00c7\x00c8\x00c9\x00ca\x00cb\x00cc\x00ce\x00cf\x00d0\x00d1\x00d2\x00d3\x00d4\x00d5\x00d6\x00df\x00e1\x00e2\x00e3\x00e4\x00e5\x00e7\x00e8\x00e9\x00ea\x00eb\x00ec\x00ed\x00ee\x00ef\x00f1\x00f2\x00f3\x00f4\x00f5\x00f6\x00f7\x00f8\x00f9\x00d7\x00d8\x00dc\x00dd\x00fa\x00fb\x00fc\x00fd";
        str2 = "AAEOOUDaaeooudaaaaaaaaaaaaaaaeeeeeeeeeeooooooooooooooouuuuuuuuuuiiiiiyyyyy";
        for (startIndex = 0; startIndex < string_9.Length; startIndex++)
        {
            int index = str.IndexOf(string_9.Substring(startIndex, 1));
            if (index > 0)
            {
                str3 = str3 + str2.Substring(index, 1);
            }
            else
            {
                str3 = str3 + string_9.Substring(startIndex, 1);
            }
        }
        return str3;
    }

    public static bool smethod_49(object object_4)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT * FROM tblTransaction WHERE trans_num = '", object_4, "' and user_id = ", GetUserId() }), oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            return (set.Tables[0].Rows.Count != 0);
        }
    }

    public static string smethod_5(string string_9)
    {
        string str = null;
        try
        {
            string str2;
            StreamReader reader = System.IO.File.OpenText(string.Format(@"{0}\config.ini", Application.StartupPath));
            while (!string.IsNullOrEmpty(str2 = reader.ReadLine()))
            {
                if (Class13.smethod_1(str2, Class13.string_0).Substring(0, Class13.smethod_1(str2, Class13.string_0).IndexOf('=')) == string_9)
                {
                    str = Class13.smethod_1(str2, Class13.string_0).Substring(Class13.smethod_1(str2, Class13.string_0).IndexOf('=') + 1);
                }
            }
            reader.Close();
        }
        catch (FileNotFoundException)
        {
            str = "";
        }
        return str;
    }

    public static bool smethod_50()
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM tblUser WHERE id = " + GetUserId() + " and groups = '01'", oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            return (set.Tables[0].Rows.Count != 0);
        }
    }

    public static int smethod_51()
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select id from tblstations where name = '" + "CODESTORE" + "' ", oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            return (int) set.Tables[0].Rows[0][0];
        }
    }

    public static string smethod_52()
    {
        WebClient client = new WebClient();
        string str = null;
        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR1.0.3705;)");
        string address = "http://checkip.dyndns.org/";
        try
        {
            Stream stream = client.OpenRead(address);
            StreamReader reader = new StreamReader(stream);
            str = reader.ReadToEnd();
            stream.Close();
            reader.Close();
            return str.Replace("<html><head><title>Current IP Check</title></head><body>", "").Replace("</body></html>", "").ToString();
        }
        catch (Exception)
        {
            return "000.000.000.000";
        }
    }

    public static string smethod_53()
    {
        string selectCommandText = "select convert(VARCHAR(5),getdate(),108) ";
        oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, oleDbConnection_1);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            oleDbConnection_1.Close();
            return set.Tables[0].Rows[0][0].ToString();
        }
    }

    public static void smethod_54(string string_9, string string_10, string string_11)
    {
        SqlConnection connection = new SqlConnection(string_6);
        SqlCommand command = new SqlCommand("select " + string_10 + " from " + string_9, connection);
        connection.Open();
        DataTable table = new DataTable();
        SqlDataReader reader = command.ExecuteReader();
        table.Load(reader);
        reader.Close();
        connection.Close();
        byte[] bytes = (byte[]) table.Rows[0][0];
        System.IO.File.WriteAllBytes(string_11, bytes);
    }

    public static void smethod_55(string string_9, object object_4, object object_5)
    {
        SqlConnection connection = new SqlConnection(string_6);
        SqlCommand command = new SqlCommand("if exists (select filename from tblFiles where filename = '" + object_5 + "') update tblFiles set version = '" + object_4 + "', filebinary = @file, last_date = '" + smethod_19() + "' where filename = '" + object_5 + "'  Else insert into tblFiles(filename,version, filebinary, last_date) values('" + object_5 + "','" + object_4 + "',@file,'" + smethod_19() + "' )", connection);
        byte[] buffer = System.IO.File.ReadAllBytes(string_9);
        if (buffer.Length > 0)
        {
            command.Parameters.AddWithValue("@file", buffer);
            connection.Open();
            if (command.ExecuteNonQuery() > 0)
            {
                connection.Close();
            }
        }
    }

    public static string smethod_6(string string_9)
    {
        string str = null;
        try
        {
            string str2;
            StreamReader reader = System.IO.File.OpenText(string.Format(@"{0}\config.ini", Application.StartupPath));
            while (null != (str2 = reader.ReadLine()))
            {
                if (str2.Substring(0, str2.IndexOf('=')) == string_9)
                {
                    str = str2.Substring(str2.IndexOf('=') + 1);
                }
            }
            reader.Close();
        }
        catch (FileNotFoundException)
        {
            str = "";
        }
        return str;
    }

    public static bool smethod_7(DbConnection dbConnection_0)
    {
        try
        {
            dbConnection_0.Open();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static int smethod_8(string string_9)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter(" SELECT ID FROM tblStations WHERE Name = '" + "CODESTORE" + "'", oleDbConnection_1);
        DataSet dataSet = new DataSet();
        oleDbDataAdapter_0.Fill(dataSet, "station");
        oleDbConnection_1.Close();
        return (int) dataSet.Tables["station"].Rows[0][0];
    }

    public static string smethod_9(string string_9, string string_10, object object_4)
    {
        oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + string_9, (OleDbConnection) object_4);
        using (DataSet set = new DataSet())
        {
            oleDbDataAdapter_0.Fill(set);
            long count = set.Tables[0].Rows.Count;
            return string.Format(string_10, count + 1L);
        }
    }

    public enum Enum0
    {
    }
}

