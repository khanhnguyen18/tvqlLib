using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmLogIn : XtraForm
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnAutoUpdate_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ClientUpdate.exe");
            Environment.Exit(1);
        }


        private void FrmLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys.Equals(Keys.Control) && e.KeyCode.Equals(Keys.F2))
            {
                //TODO
                //new FrmSystemConfig().ShowDialog();
            }
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            string str = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (!Class7.smethod_18("tblStations", "name", SystemInformation.ComputerName))
            {
                this.string_0 = "update tblStations set name = '" + SystemInformation.ComputerName + "' where id = 1 ";
                Class7.smethod_4(this.string_0);
            }
            if (Class7.smethod_51() == 1)
            {
                this.string_0 = "UPDATE tblSysvar set m_value = '" + SystemInformation.ComputerName + "' where m_code = 'm_server'";
                Class7.smethod_4(this.string_0);
                this.btnAutoUpdate.Enabled = false;
                if (this.method_9() != string.Empty)
                {
                    if (str != this.method_9())
                    {
                        Class7.smethod_55(Application.StartupPath + @"\LIBRARY MANAGEMENT.exe", str, "LIBRARY MANAGEMENT.exe");
                    }
                }
                else
                {
                    Class7.smethod_55(Application.StartupPath + @"\LIBRARY MANAGEMENT.exe", str, "LIBRARY MANAGEMENT.exe");
                }
            }
            else if (this.method_9() != string.Empty)
            {
                if (str != this.method_9())
                {
                    Class7.smethod_15("Bạn cần tải xuống phi\x00ean bản mới để cập nhật cho phần mềm", 1);
                    this.IjSwogAv6.Enabled = false;
                    this.btnAutoUpdate.Enabled = true;
                    this.Txt_Password.Enabled = false;
                    this.Txt_UserName.Enabled = false;
                }
                else
                {
                    this.btnAutoUpdate.Enabled = false;
                }
            }
            if (!this.bool_0)
            {
                //TODO
                //new FrmRegister().ShowDialog();
            }
            else
            {
                this.Txt_UserName.Text = SystemInformation.UserName;
                this.Txt_UserName.SelectAll();
            }
            this.Text = "Version " + str;
            this.Txt_UserName.Text = SystemInformation.UserName;
            this.Txt_UserName.SelectAll();
            if (!File.Exists(string.Format(@"{0}\config.ini", Application.StartupPath)))
            {
                Class7.smethod_15("Kh\x00f4ng t\x00ecm thấy file config.ini, đề nghị li\x00ean hệ với nh\x00e0 cung cấp", 1);
            }
        }

        [DllImport("HardwareID.dll")]
        public static extern string GetHardwareID(bool HDD, bool NIC, bool CPU, bool BIOS, string sRegistrationCode);
        private void IjSwogAv6_Click(object sender, EventArgs e)
        {
            Class7.string_7 = this.Txt_UserName.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM tblUser WHERE Name = '" + Class7.string_7 + "' AND Status = 1", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            if (dataSet.Tables[0].Rows.Count == 0)
            {
                Class7.smethod_15("Kh\x00f4ng c\x00f3 t\x00ean người d\x00f9ng n\x00e0y trong hệ thống", 1);
                this.Txt_UserName.Text = string.Empty;
                this.Txt_UserName.Focus();
            }
            else if (this.method_3())
            {
                Class7.smethod_15(" Người n\x00e0y đang d\x00f9ng chương tr\x00ecnh tại trạm " + this.string_2, 1);
            }
            else if (this.method_1())
            {
                Class7.smethod_24();
                if (!this.bool_0)
                {
                    Class7.smethod_15("Chương tr\x00ecnh chưa đăng k\x00fd bản quyền, đề nghị li\x00ean hệ với nh\x00e0 cung cấp", 1);
                    base.TopMost = false;
                    new FrmCheckey().Show();
                }
                else
                {
                    this.IjSwogAv6.Enabled = false;
                    //TODO
                    //new FrmMain1().Show();
                    base.Hide();
                }
            }
            else
            {
                Class7.smethod_15("Sai mật khẩu, đề nghị kiểm tra lại", 1);
                this.Txt_Password.Focus();
                this.Txt_Password.Text = "";
            }
        }

        private void method_0()
        {
            string str = GetHardwareID(true, false, false, false, "R5LR-S4TQ");
            string str2 = null;
            this.method_4(Class13.string_0, str, ref str2);
            this.string_0 = "select serialkey from tblStations where name = '" + SystemInformation.ComputerName + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows[0][0].ToString().Trim() == str2.Trim())
                {
                    this.bool_0 = true;
                }
                else
                {
                    this.bool_0 = false;
                }
            }
        }

        private bool method_1()
        {
            string str = this.Txt_UserName.Text.Trim();
            string str2 = this.Txt_Password.Text.Trim();
            string selectCommandText = string.Empty;
            selectCommandText = "SELECT * FROM tblUser WHERE Name = '" + str + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            string str4 = (string)dataSet.Tables[0].Rows[0]["Passw"];
            string str5 = null;
            if (str4 == string.Empty)
            {
                str5 = str4;
            }
            else
            {
                str5 = Class13.smethod_1(str4, Class13.string_0);
            }
            return (str2 == str5);
        }

        private void method_10()
        {
            OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; data source= " + Application.StartupPath + @"\goods.xls;Extended Properties=Excel 8.0;");
            this.string_0 = "select * from [tblgoods$]";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, selectConnection);
            using (DataTable table = new DataTable())
            {
                this.oleDbDataAdapter_0.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    string str2 = row["goods_id"].ToString().Trim();
                    string str3 = row["short_name"].ToString().Trim().Replace("'", "");
                    string str4 = row["author"].ToString().Trim().Replace("'", "");
                    string str5 = row["publish"].ToString().Trim().Replace("'", "");
                    this.string_0 = "INSERT INTO tblGoods(goods_id,grp_id,short_name,full_name,piceunit,packunit,unitconv,open_date,merc_type) VALUES('" + str2 + "','0001',N'" + str3 + "',N'" + str3 + "','Q','Q',1,'" + Class7.smethod_19() + "','01') ";
                    Class7.smethod_4(this.string_0);
                    this.string_0 = string.Concat(new object[] { "INSERT INTO tblBookattr(goods_id, author, publish, pl_year) VALUES('", str2, "',N'", str4, "',N'", str5, "',", row["pl_year"], ") " });
                    Class7.smethod_4(this.string_0);
                    this.string_0 = "INSERT INTO tblPrice(goods_id) VALUES('" + str2 + "')";
                    Class7.smethod_4(this.string_0);
                }
            }
        }

        private bool method_2()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT ID FROM tblStations WHERE Name = '" + SystemInformation.ComputerName + "' and status =1", this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count == 0)
                {
                    return false;
                }
                return true;
            }
        }

        private bool method_3()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT * FROM tblStations WHERE user_id = ", Class7.GetUserRight(), " AND name <> '", SystemInformation.ComputerName, "' " }), this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.string_2 = (string)dataSet.Tables[0].Rows[0]["name"];
                return true;
            }
            return false;
        }

        private void method_4(string string_3, string string_4, ref string string_5)
        {
            string str = this.method_5(ref string_3, string_4.ToUpper());
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Remove(0x10, str.Length - 0x10).Insert(4, "-").Insert(8, "-").Insert(12, "-");
            }
            string_5 = str;
        }

        private string method_5(ref string string_3, string string_4)
        {
            if (string_3.Length > 0x10)
            {
                string_3 = string_3.Substring(0, 0x10);
            }
            if (string_4.Trim().Length == 0)
            {
                return string.Empty;
            }
            //Data key = new Data(string_3);
            //Symmetric symmetric = new Symmetric(Symmetric.Provider.Rijndael, true);
            //return symmetric.Encrypt(new Data(string_4), key).ToHex();

            return string.Empty;
        }

        private bool method_6()
        {
            string str = string.Empty;
            string str2 = string.Empty;
            this.method_4(Class13.string_0, Class13.smethod_5(Application.StartupPath.Substring(0, 1)), ref str);
            this.method_4(Class13.string_0, str, ref str2);
            RegistryKey key = null;
            key = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey(this.string_1);
            key = Registry.CurrentUser.OpenSubKey(@"Software\\" + this.string_1);
            key.GetValue("USERNAME", "").ToString();
            key.GetValue("COMPANY", "").ToString();
            string str3 = key.GetValue("ComputerID", "").ToString();
            key.Close();
            if (this.method_8(str2, str3))
            {
                Class7.bool_0 = true;
            }
            else
            {
                Class7.bool_0 = false;
            }
            return Class7.bool_0;
        }

        private string method_7(string string_3)
        {
            byte[] buffer = SHA1.Create().ComputeHash(Encoding.Default.GetBytes(string_3));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++)
            {
                builder.Append(buffer[i].ToString());
            }
            return builder.ToString();
        }

        private bool method_8(string string_3, string string_4)
        {
            return (string.Compare(this.method_7(string_3), string_4) == 0);
        }

        private string method_9()
        {
            string str = Assembly.GetEntryAssembly().GetName().Name.ToString() + ".exe";
            this.string_0 = "select version from tblFiles where filename = '" + str + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    return set.Tables[0].Rows[0][0].ToString();
                }
                return string.Empty;
            }
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.IjSwogAv6_Click(this, new EventArgs());
            }
        }

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = 520;
                return createParams;
            }
        }
    
    }
}