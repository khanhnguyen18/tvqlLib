using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmChangePass : XtraForm
    {
        public FrmChangePass()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!this.method_0())
            {
                Class7.ShowMessageBox("Mật khẩu cũ kh\x00f4ng ch\x00ednh x\x00e1c", 1);
            }
            else if (this.Txt_NewPass.Text.Trim() != this.Txt_ConfirmPass.Text.Trim())
            {
                Class7.ShowMessageBox("Mật khẩu nhập 2 lần kh\x00f4ng giống nhau", 1);
            }
            else
            {
                string str = this.Txt_NewPass.Text.Trim();
                OleDbDataAdapter adapter = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE [tblUser]SET  [Passw]='", Class13.smethod_0(str, Class13.string_0), "' WHERE ID = '", Class7.GetUserRight(), "' " }), Class7.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                Class7.oleDbConnection_1.Close();
                base.Close();
                Class7.ShowMessageBox("Đổi mật khẩu th\x00e0nh c\x00f4ng !", 1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FrmChangePass_Load(object sender, EventArgs e)
        {
            this.Text = "Đổi mật khẩu sử dụng";
            this.Txt_UserName.Text = Class7.string_7;
            this.Txt_UserName.Enabled = false;
        }

        private bool method_0()
        {
            bool flag = false;
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tblUser WHERE ID = " + Class7.GetUserRight(), Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            string str = dataSet.Tables[0].Rows[0]["Passw"].ToString();
            if ((str == string.Empty) & (this.Txt_OldPass.Text == string.Empty))
            {
                flag = true;
            }
            if (!(str != string.Empty))
            {
                return flag;
            }
            return (this.Txt_OldPass.Text == Class13.smethod_1(dataSet.Tables[0].Rows[0]["Passw"].ToString(), Class13.string_0));
        }
    }
}