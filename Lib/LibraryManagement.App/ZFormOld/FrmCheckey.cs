using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    public partial class FrmCheckey : Form
    {
        public FrmCheckey()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }


        private void FrmCheckey_Load(object sender, EventArgs e)
        {
            string str = null;
            this.method_0(Class13.string_0, Class13.smethod_5(Application.StartupPath.Substring(0, 1)), ref str);
            this.lblHDDserial.Text = str;
            this.method_0(Class13.string_0, this.lblHDDserial.Text, ref str);
            RegistryKey key = null;
            key = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey(this.string_0);
            key = Registry.CurrentUser.OpenSubKey(@"Software\\" + this.string_0);
            string str2 = key.GetValue("USERNAME", "").ToString();
            string str3 = key.GetValue("COMPANY", "").ToString();
            string str4 = key.GetValue("ComputerID", "").ToString();
            key.Close();
            if (this.method_5(str, str4))
            {
                this.txtUserName.Enabled = false;
                this.txtCompany.Enabled = false;
                this.txtCompany.Text = str3;
                this.txtUserName.Text = str2;
                this.Tx1.Enabled = false;
                this.Tx2.Enabled = false;
                this.Tx3.Enabled = false;
                this.Tx4.Enabled = false;
                this.IipWvDcZu.Enabled = false;
                string[] strArray = null;
                char[] separator = new char[] { '-' };
                strArray = Class7.smethod_14("m_serial").ToString().Split(separator);
                this.Tx1.Text = strArray[0];
                this.Tx2.Text = strArray[1];
                this.Tx3.Text = strArray[2];
                this.Tx4.Text = strArray[3];
            }
        }

        private void IipWvDcZu_Click(object sender, EventArgs e)
        {
            if (this.txtUserName.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa đăng k\x00fd t\x00ean người sử dụng", Class7.smethod_14("m_softname").ToString().Trim(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtUserName.Focus();
            }
            else if (this.txtCompany.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa đăng k\x00fd t\x00ean c\x00f4ng ty", Class7.smethod_14("m_softname").ToString().Trim(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.txtCompany.Focus();
            }
            else
            {
                string str = this.Tx1.Text + "-" + this.Tx2.Text + "-" + this.Tx3.Text + "-" + this.Tx4.Text;
                string str2 = null;
                this.method_0(Class13.string_0, this.lblHDDserial.Text.Trim(), ref str2);
                if (str2 == str)
                {
                    this.method_3(Class13.string_0, this.txtUserName.Text, this.txtCompany.Text);
                    Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("M\x00e3 số đăng k\x00fd kh\x00f4ng hợp lệ, đề nghị kiểm tra lại !!!!", Class7.smethod_14("m_softname").ToString().Trim(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }



        private void method_0(string string_1, string string_2, ref string string_3)
        {
            string str = this.method_1(ref string_1, string_2.ToUpper());
            if (!string.IsNullOrEmpty(str))
            {
                str = str.Remove(0x10, str.Length - 0x10).Insert(4, "-").Insert(8, "-").Insert(12, "-");
            }
            string_3 = str;
        }

        private string method_1(ref string string_1, string string_2)
        {
            if (string_1.Length > 0x10)
            {
                string_1 = string_1.Substring(0, 0x10);
            }
            if (string_2.Trim().Length == 0)
            {
                return string.Empty;
            }
            //Data key = new Data(string_1);
            //Symmetric symmetric = new Symmetric(Symmetric.Provider.Rijndael, true);
            //return symmetric.Encrypt(new Data(string_2), key).ToHex();

            return string.Empty;
        }

        private string method_2(ref string string_1, string string_2)
        {
            try
            {
                //Symmetric symmetric = new Symmetric(Symmetric.Provider.Rijndael, true);
                //Data encryptedData = new Data 
                //{
                //    Hex = string_2
                //};
                //return symmetric.Decrypt(encryptedData, new Data(string_1)).Text;
                return string.Empty;
            }
            catch
            {
                return null;
            }
        }

        private bool method_3(string string_1, string string_2, string string_3)
        {
            string str = null;
            this.method_0(Class13.string_0, this.lblHDDserial.Text.Trim(), ref str);
            try
            {
                string str2 = this.method_4(str);
                RegistryKey key = null;
                key = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey(this.string_0);
                key.SetValue("USERNAME", string_2);
                key.SetValue("COMPANY", string_3);
                key.SetValue("ComputerID", str2);
                key.Close();
                MessageBox.Show("Bạn đăng k\x00fd bản quyền th\x00e0nh c\x00f4ng, xin ch\x00fac mừng.", Class7.smethod_14("m_softname").ToString().Trim(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Class7.smethod_3("m_serial", str);
                return true;
            }
            catch
            {
                MessageBox.Show("Đăng k\x00fd bản quyền kh\x00f4ng th\x00e0nh c\x00f4ng, đề nghị kiểm tra lại !!!!", Class7.smethod_14("m_softname").ToString().Trim(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private string method_4(string string_1)
        {
            byte[] buffer = SHA1.Create().ComputeHash(Encoding.Default.GetBytes(string_1));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++)
            {
                builder.Append(buffer[i].ToString());
            }
            return builder.ToString();
        }

        private bool method_5(string string_1, string string_2)
        {
            return (string.Compare(this.method_4(string_1), string_2) == 0);
        }
    }
}