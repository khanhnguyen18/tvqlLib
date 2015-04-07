using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace LibraryManagement.App
{
    public partial class FrmAbout : XtraForm
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
        }

        private void LabelControl4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.quanlytaichinhcanhan.com");
        }

    }
}