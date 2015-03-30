using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmEncyptCode : DevExpress.XtraEditors.XtraForm
    {
        public FrmEncyptCode()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            this.txtDecrypted.Text = Class13.smethod_1(this.txtEncrypted1.Text.Trim(), this.txtPassword1.Text.Trim());
        }

        private void FrmEncyptCode_Load(object sender, EventArgs e)
        {
        }



        private void RrqIxZxw5(object sender, EventArgs e)
        {
            this.txtEncrypted.Text = Class13.smethod_0(this.txtOriginal.Text.Trim(), this.txtPassword.Text.Trim());
        }
    }
}