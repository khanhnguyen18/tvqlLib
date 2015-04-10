using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmTransCode : DevExpress.XtraEditors.XtraForm
    {
        public FrmTransCode()
        {
            InitializeComponent();
        }



        private void FrmTransCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        private void FrmTransCode_Load(object sender, EventArgs e)
        {
            Class6 class2 = new Class6();
            this.Txt_TransCode.Enabled = false;
            class2.method_3(Class11.string_1, this.LstTransCode);
        }


        private void LstTransCode_Click(object sender, EventArgs e)
        {
            string str = this.LstTransCode.SelectedItem.ToString().Substring(1, 4).Trim();
            string str2 = null;
            this.Txt_TransCode.Text = str;
            Class7.smethod_17("description", "tblTrcode", "trcode", str, "", Class7.oleDbConnection_1, ref str2);
            this.memoEdit1.Text = str2;
        }

        private void LstTransCode_DoubleClick(object sender, EventArgs e)
        {
            new Class6().method_4(this.Txt_TransCode.Text, ref Class6.string_2, ref Class6.string_1, ref Class7.string_1, ref Class6.string_3, ref Class6.string_4, ref Class6.object_0);
            base.Close();
            Class7.smethod_26(Class7.string_1).ShowDialog();
        }

        private void LstTransCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) & (this.Txt_TransCode.Text != string.Empty))
            {
                this.LstTransCode_DoubleClick(this, new EventArgs());
            }
        }

        private void LstTransCode_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
  
    }
}