using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmRegister : DevExpress.XtraEditors.XtraForm
    {
        public FrmRegister()
        {
            InitializeComponent();
        }




        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            GetHardwareID(true, false, false, false, "R5LR-S4TQ");
            string str = null;
            this.method_0(Class13.string_0, this.Txt_HDDinfo.Text.Trim(), ref str);
            if (this.Txt_Serial.Text.Trim() == str)
            {
                this.string_0 = "update tblStations set serialkey = '" + this.Txt_Serial.Text.Trim() + "' where name = '" + SystemInformation.ComputerName + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                MessageBox.Show("Bạn đăng k\x00fd bản quyền th\x00e0nh c\x00f4ng, xin ch\x00fac mừng.", Class7.smethod_14("m_softname").ToString().Trim(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                base.Close();
            }
            else
            {
                MessageBox.Show("M\x00e3 số đăng k\x00fd kh\x00f4ng hợp lệ, đề nghị kiểm tra lại !!!!", Class7.smethod_14("m_softname").ToString().Trim(), MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void FrmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.Text = "tuan1971hanoi@yahoo.com - 0904843991";
            this.Txt_HDDinfo.Text = GetHardwareID(true, false, false, false, "R5LR-S4TQ");
            this.Txt_HDDinfo.Properties.ReadOnly = true;
        }

        [DllImport("HardwareID.dll")]
        public static extern string GetHardwareID(bool HDD, bool NIC, bool CPU, bool BIOS, string sRegistrationCode);


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
   
    }
}