using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Configuration;
using ArtDe;

namespace LibraryManagement.App
{
    public partial class AboutForm : XtraForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
             Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
             if (config.AppSettings.Settings["knuth"].Value == string.Empty)
             {
                 string id = Guid.NewGuid().ToString().Trim('-').Substring(0, 2).ToUpper();
                 config.AppSettings.Settings["knuth"].Value = Decode.EncodeCode(id);
                 config.Save(ConfigurationSaveMode.Modified);

                 textEdit1.Text = id;
             }
             else
             {
                 textEdit1.Text = Decode.DecodeCode(config.AppSettings.Settings["knuth"].Value);
             }

            //Check visilbe
             if (Decode.EncodeCode(textEdit1.Text) == Decode.DecodeCode(config.AppSettings.Settings["donald"].Value))
             {
                 panelControl1.Visible = false;
                 btnExit.Visible = true;
             }
        }

        private void LabelControl4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.quanlytaichinhcanhan.com");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Decode.EncodeCode(textEdit1.Text) == Decode.DecodeCode(textEdit2.Text))
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["donald"].Value = textEdit2.Text;
                config.Save(ConfigurationSaveMode.Modified);

                MessageBox.Show("Đăng ký thàng công");
                this.Close();
            }
            else
                MessageBox.Show("Sai mật khẩu");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}