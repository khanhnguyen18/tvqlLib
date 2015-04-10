using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmPayment : DevExpress.XtraEditors.XtraForm
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
        }


        private void FrmPayment_Load(object sender, EventArgs e)
        {
            this.Lbl_AccountId.Text = Class6.string_11;
            string str = null;
            Class7.smethod_17("fullname", "tblStore", "Id", this.Lbl_AccountId.Text, "", this.oleDbConnection_0, ref str);
            this.Lbl_AccName.Text = str;
            if (this.Lbl_AccName.Text != string.Empty)
            {
                this.Txt_TotalAmt.EditValue = Class6.double_0;
            }
            this.Txt_TotalAmt.Enabled = false;
        }



        private void timer_0_Tick(object sender, EventArgs e)
        {
        }
    }
}