using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LibraryManagement.App
{
    public partial class FrmMsgbox : XtraForm
    {
        public int ret;
        public FrmMsgbox()
        {
            InitializeComponent();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            this.ret = 1;
            base.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.ret = 0;
            base.Close();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            this.ret = -1;
            base.Close();
        }

        private void FrmMsgbox_Load(object sender, EventArgs e)
        {
            this.Text = Class7.smethod_14("m_softname").ToString();
        }

    }
}