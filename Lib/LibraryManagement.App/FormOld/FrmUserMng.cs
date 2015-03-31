using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmUserMng : DevExpress.XtraEditors.XtraForm
    {
        public FrmUserMng()
        {
            InitializeComponent();
        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.method_2();
            Class7.smethod_15("Cập nhật th\x00e0nh c\x00f4ng !", 1);
            base.Close();
        }


        private void FrmUserMng_Load(object sender, EventArgs e)
        {
            this.Text = "Ph\x00e2n quyền sử dụng thực đơn theo người d\x00f9ng";
            Class11.smethod_12(this.Tls_Menus1, null, 1);
            this.Txt_ShortName.Text = Class7.string_2;
            this.InvitAbleGroupMenu();
            this.method_1(this.Txt_ShortName.Text.Trim());
            this.Tls_Menus1.Enabled = true;
            this.Tls_Menus1.Nodes[0].Expanded = true;
            this.Tls_Menus1.ExpandAll();
            this.Tls_Menus1.BestFitColumns();
            this.Txt_Description.Enabled = false;
            this.Txt_ShortName.Enabled = false;
        }

        private void IipWvDcZu_Click(object sender, EventArgs e)
        {
            base.Close();
        }


        public void InvitAbleGroupMenu()
        {
            string str = null;
            string str2 = this.Txt_ShortName.Text.Trim();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from tblUser where Name = '" + str2 + "'", Class7.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            str = dataTable.Rows[0]["Groups"].ToString().Trim();
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(" Select * from tblUserGrp where Name = '" + str + "'", Class7.oleDbConnection_1);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            string str3 = null;
            try
            {
                str3 = Class13.smethod_2(table2.Rows[0]["MenuPer"].ToString());
            }
            catch (Exception)
            {
                return;
            }
            string[] strArray = str3.Split(new char[] { ';' });
            string str4 = null;
            TreeListNodes nodes = this.Tls_Menus1.Nodes[0].Nodes;
            string str5 = null;
            foreach (TreeListNode node in nodes)
            {
                int count = node.Nodes.Count;
                foreach (TreeListNode node2 in node.Nodes)
                {
                    str5 = node2.GetValue(1).ToString();
                    for (int i = 0; i <= (strArray.Length - 1); i++)
                    {
                        str4 = strArray[i];
                        if (str5 == str4)
                        {
                            node2.Visible = false;
                            count--;
                        }
                    }
                }
                if (count == 0)
                {
                    node.Visible = false;
                }
            }
        }

        private string method_0()
        {
            string str = null;
            string str2 = null;
            string str3 = null;
            foreach (TreeListNode node in this.Tls_Menus1.Nodes[0].Nodes)
            {
                int imageIndex = node.ImageIndex;
                if (((int)node.Tag) == 1)
                {
                    str2 = node.GetValue(1).ToString() + ";";
                    foreach (TreeListNode node2 in node.Nodes)
                    {
                        str = node2.GetValue(1).ToString();
                        str2 = string.Format("{0}{1};", str2, str);
                    }
                }
                if (((int)node.Tag) == 2)
                {
                    str2 = node.GetValue(1).ToString() + ";";
                    foreach (TreeListNode node2 in node.Nodes)
                    {
                        if (((int)node2.Tag) == 1)
                        {
                            str = node2.GetValue(1).ToString();
                            str2 = str2 + str + ";";
                        }
                    }
                }
                str3 = str3 + str2;
                str2 = null;
            }
            return str3;
        }

        private void method_1(string string_0)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(" Select * from tblUser where Name = '" + string_0 + "'", Class7.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string[] strArray = Class13.smethod_2(dataTable.Rows[0]["mRight"].ToString()).Split(new char[] { ';' });
            int index = 0;
            string str2 = null;
            TreeListNodes nodes = this.Tls_Menus1.Nodes[0].Nodes;
            string str3 = null;
            bool flag = false;
            foreach (TreeListNode node in nodes)
            {
                flag = false;
                foreach (TreeListNode node2 in node.Nodes)
                {
                    str3 = node2.GetValue(1).ToString();
                    for (index = 0; index <= (strArray.Length - 1); index++)
                    {
                        str2 = strArray[index].ToString();
                        if (str3 == str2)
                        {
                            node2.Tag = 1;
                            flag = true;
                        }
                    }
                }
                if (flag)
                {
                    node.Tag = 2;
                }
            }
            this.Tls_Menus1.ExpandAll();
        }

        private void method_2()
        {
            string str = Class7.smethod_36(this.Tls_Menus1);
            TreeListNodes nodes = this.Tls_Menus1.Nodes[0].Nodes;
            OleDbDataAdapter adapter = new OleDbDataAdapter("UPDATE [tblUser]SET [mright] ='" + Class13.smethod_2(str) + "' WHERE Name = '" + this.Txt_ShortName.Text.Trim() + "' ", Class7.oleDbConnection_1);
            using (DataSet set = new DataSet())
            {
                adapter.Fill(set);
            }
            Class7.oleDbConnection_1.Close();
        }

        private void Tls_Menus1_GetStateImage(object sender, GetStateImageEventArgs e)
        {
            CheckState state = Class11.smethod_18(e.Node.Tag);
            if (state == CheckState.Unchecked)
            {
                e.NodeImageIndex = 0;
            }
            else if (state == CheckState.Checked)
            {
                e.NodeImageIndex = 1;
            }
            else
            {
                e.NodeImageIndex = 2;
            }
        }

        private void Tls_Menus1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeListHitInfo info = this.Tls_Menus1.CalcHitInfo(new Point(e.X, e.Y));
                if (info.HitInfoType == HitInfoType.StateImage)
                {
                    Class11.smethod_13(info.Node, this.Tls_Menus1);
                }
            }
        }

        private void Txt_Description_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_ShortName_EditValueChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tblUser WHERE Name = '" + this.Txt_ShortName.Text + "' ", Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Txt_Description.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
            }
        }

    }
}