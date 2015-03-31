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
    public partial class FrmUserGrpMng : DevExpress.XtraEditors.XtraForm
    {
        public FrmUserGrpMng()
        {
            InitializeComponent();
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.method_2();
            Class7.smethod_15("Cập nhật th\x00e0nh c\x00f4ng !", 1);
            base.Close();
        }


        private void FrmUserGrpMng_Load(object sender, EventArgs e)
        {
            this.Text = "Ph\x00e2n quyền sử dụng thực đơn theo nh\x00f3m";
            Class11.smethod_12(this.Tls_Menus, null, 1);
            this.Txt_ShortName.Text = Class7.string_2;
            this.method_0(this.Txt_ShortName.Text);
            this.Tls_Menus.Enabled = true;
            this.Tls_Menus.Nodes[0].Expanded = true;
            this.Tls_Menus.ExpandAll();
            this.Tls_Menus.BestFitColumns();
            this.Txt_Description.Enabled = false;
            this.Txt_ShortName.Enabled = false;
        }



        private void method_0(string string_0)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(" Select * from tblUsergrp where Name = '" + string_0 + "'", Class7.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string[] strArray = Class13.smethod_2(dataTable.Rows[0]["menuper"].ToString()).Split(new char[] { ';' });
            int index = 0;
            string str2 = null;
            TreeListNodes nodes = this.Tls_Menus.Nodes[0].Nodes;
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
            this.Tls_Menus.ExpandAll();
        }

        public string method_1()
        {
            string str = null;
            string str2 = null;
            string str3 = null;
            foreach (TreeListNode node in this.Tls_Menus.Nodes[0].Nodes)
            {
                bool flag = false;
                int imageIndex = node.ImageIndex;
                TreeListNode node2 = node;
                node2.GetValue(2).ToString();
                if ((node.Tag != null) && (((int)node.Tag) == 1))
                {
                    str2 = node.GetValue(1).ToString() + ";";
                    foreach (TreeListNode node3 in node.Nodes)
                    {
                        str = node3.GetValue(1).ToString();
                        str2 = str2 + str + ";";
                        flag = true;
                    }
                }
                if ((node.Tag != null) && (((int)node.Tag) == 2))
                {
                    str2 = node.GetValue(1).ToString() + ";";
                    foreach (TreeListNode node3 in node.Nodes)
                    {
                        if (((int)node3.Tag) == 2)
                        {
                            str = node3.GetValue(1).ToString();
                            str2 = str2 + str + ";";
                            flag = true;
                        }
                    }
                }
                if (flag)
                {
                    str3 = str3 + str2;
                    flag = false;
                }
            }
            return str3;
        }

        private void method_2()
        {
            this.Txt_Description.Text.Trim();
            string str = Class7.smethod_36(this.Tls_Menus);
            if (this.Txt_Description.Text == string.Empty)
            {
                Class7.smethod_15("Th\x00f4ng tin chưa đủ", 1);
            }
            else
            {
                foreach (TreeListNode node in this.Tls_Menus.Nodes[0].Nodes)
                {
                    if (!((node.ImageIndex == 1) | (node.ImageIndex == 2)))
                    {
                    }
                }
                OleDbDataAdapter adapter = new OleDbDataAdapter("UPDATE [tblUserGrp] SET [menuper] = '" + Class13.smethod_2(str) + "' WHERE Name = '" + this.Txt_ShortName.Text.Trim() + "' ", Class7.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                Class7.oleDbConnection_1.Close();
            }
        }

        private void Tls_Menus_GetStateImage(object sender, GetStateImageEventArgs e)
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

        private void Tls_Menus_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeListHitInfo info = this.Tls_Menus.CalcHitInfo(new Point(e.X, e.Y));
                if (info.HitInfoType == HitInfoType.StateImage)
                {
                    Class11.smethod_13(info.Node, this.Tls_Menus);
                }
            }
        }

        private void Txt_ShortName_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("Descript", "tblusergrp", "Name", this.Txt_ShortName.Text.Trim(), "", Class7.oleDbConnection_1, ref str);
            this.Txt_Description.Text = str;
        }
   
    }
}