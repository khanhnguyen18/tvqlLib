using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    public partial class FrmMsgbox : DevExpress.XtraEditors.XtraForm
    {
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