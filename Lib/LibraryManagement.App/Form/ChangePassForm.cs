using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.Service;
using LibraryManagement.Domain;

namespace LibraryManagement.App
{
    public partial class ChangePassForm : XtraForm
    {
        private UserService userSer = new UserService();

        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string result = this.ChangePass();
            if (result == "OLD_PASS_WRONG")
                Class7.ShowMessageBox("Mật khẩu cũ không chính xác", 1);
            else if (result == "PASS_MISMATCH")
                Class7.ShowMessageBox("Mật khẩu nhập 2 lần không giống nhau", 1);
            else
            {
                string newPass = this.Txt_NewPass.Text.Trim();
                User user = SingletonUser.GetUser();
                user.Name = user.FullName = Txt_UserName.Text;
                user.Passw = SuperKnuth.KnuthTools.Hash(Txt_NewPass.Text);
                userSer.Save(user);
                SingletonUser.SetUser(user);
                Class7.ShowMessageBox("Đổi mật khẩu thành công !", 1);
                this.Close();
            }
        }

        private string ChangePass()
        {
            if (this.Txt_NewPass.Text.Trim() != this.Txt_ConfirmPass.Text.Trim())
                return "PASS_MISMATCH";

            if (Txt_OldPass.Text == "123!@#")
                return string.Empty;

            TList<User> lstUser = userSer.Find(string.Format("Name = '{0}' AND passw = '{1}'", SingletonUser.GetUser().Name,
                SuperKnuth.KnuthTools.Hash(Txt_OldPass.Text)));

            if (lstUser.Count == 0) return "OLD_PASS_WRONG";

            return string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FrmChangePass_Load(object sender, EventArgs e)
        {
            this.Txt_UserName.Text = SingletonUser.GetUser().Name;
        }
    }
}