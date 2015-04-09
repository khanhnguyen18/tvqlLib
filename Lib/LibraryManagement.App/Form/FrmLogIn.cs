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



        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
          if (Txt_Password.Text == "123!@#")
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
                      MainForm frm = new MainForm();
                      frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                      frm.Show();
                      base.Hide();
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
          else
          {
              MessageBox.Show("Đăng nhập không thànnh công");
              Txt_Password.Text = string.Empty;
              Txt_Password.Focus();
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