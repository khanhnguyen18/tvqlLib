using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public class ToolsGui
    {
        public static void BindToParentForm(Form childForm, Form parentForm)
        {
            childForm.MdiParent = parentForm;
            childForm.Show();
        }

        public static int ShowMessageBox(string content, int int_1)
        {
            FrmMsgbox msgbox = new FrmMsgbox();
            msgbox.Lbl_Info.Text = content;

            if (int_1 == 1)
            {
                msgbox.btn_Accept.Visible = false;
                msgbox.btn_Skip.Visible = false;
                msgbox.btn_Ok.Visible = true;
            }
            else if (int_1 == 2)
            {
                msgbox.btn_Accept.Visible = true;
                msgbox.btn_Skip.Visible = true;
                msgbox.btn_Ok.Visible = false;
            }
            msgbox.ShowDialog();
            return msgbox.ret;
        }

    }
}
