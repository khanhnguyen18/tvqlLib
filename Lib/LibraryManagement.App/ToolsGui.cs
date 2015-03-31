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
    }
}
