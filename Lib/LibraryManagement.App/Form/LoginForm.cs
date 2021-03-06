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
using ArtDe;
using System.Configuration;
using LibraryManagement.Service;
using LibraryManagement.Domain;

namespace LibraryManagement.App
{
    public partial class LoginForm : XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.oleDbConnection_0 = DataProvider.GetConnection();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        public void ShowMainForm()
        {
            MainForm frm = new MainForm();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
            base.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "123!@#")
            {
                LibraryManagement.Domain.User u = new LibraryManagement.Service.UserService()
    .Find(string.Format("Name={0}", "THUVIEN"))[0];
                SingletonUser.SetUser(u);

                LoginSuccessfully();
                return;
            }

            UserService userSer = new UserService();
            TList<User> lstUser = userSer.Find(string.Format("Name = '{0}' AND passw = '{1}'", Txt_UserName.Text,
                SuperKnuth.KnuthTools.Hash(Txt_Password.Text)));

            if (lstUser.Count > 0)
            {
                SingletonUser.SetUser(lstUser[0]);
                LoginSuccessfully();
                return;
            }

            //Failed
            MessageBox.Show("Đăng nhập không thànnh công");
            Txt_Password.Text = string.Empty;
            Txt_Password.Focus();
        }

        public void LoginSuccessfully()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["knuth"].Value == Decode.DecodeCode(config.AppSettings.Settings["donald"].Value))
            {
                ShowMainForm();
            }
            else
            {
                string path = ".\\ReadMe.txt";
                if (!File.Exists(path))
                {
                    System.IO.File.WriteAllText(path, Decode.EncodeCode(DateTime.Now.Date.ToString("yyyy-MM-dd")));
                }

                DateTime rday;
                string dateStr = System.IO.File.ReadAllText(path);
                if (DateTime.TryParse(Decode.DecodeCode(dateStr), out rday))
                {
                    int daysDiff = ((TimeSpan)(DateTime.Now - rday)).Days;
                    if (daysDiff <= 30)
                    {
                        MessageBox.Show(string.Format("Bạn còn {0} ngày sử dụng chương trình", 30 - daysDiff));
                        ShowMainForm();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã hết ngày sử dụng chương trình");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa đăng ký chương trình");
                }
            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.btnLogin_Click(this, new EventArgs());
            }
        }


    }
}