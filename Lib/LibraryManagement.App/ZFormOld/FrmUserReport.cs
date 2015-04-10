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
    public partial class FrmUserReport : DevExpress.XtraEditors.XtraForm
    {
        public FrmUserReport()
        {
            InitializeComponent();
        }




        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataSet set;
            string str = this.method_1(this.treeList1);
            TreeListNodes nodes = this.treeList1.Nodes[0].Nodes;
            switch (Class11.string_1)
            {
                case "US":
                    this.string_0 = string.Concat(new object[] { "UPDATE [tblUser]SET [rpright] ='", Class13.smethod_2(str), "' WHERE id = ", Class7.int_0 });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                    }
                    this.oleDbConnection_0.Close();
                    break;

                case "GRP":
                    this.string_0 = "UPDATE [tblUserGrp]SET [rpright] ='" + Class13.smethod_2(str) + "' WHERE id = '" + Class7.string_0 + "' ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                    }
                    this.oleDbConnection_0.Close();
                    break;
            }
            base.Close();
        }


        private void FrmUserReport_Load(object sender, EventArgs e)
        {
            this.Text = "Ph\x00e2n quyền sử dụng b\x00e1o c\x00e1o";
            this.method_0(this.treeList1, null, 1);
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.BestFitColumns();
            this.treeList1.ExpandAll();
            string str = Class11.string_1;
            if (str != null)
            {
                if (!(str == "US"))
                {
                    if (str == "GRP")
                    {
                        this.method_2(Class7.string_0);
                    }
                }
                else
                {
                    this.pfeZyQnoF(Class7.int_0);
                }
            }
        }



        private void method_0(TreeList treeList_0, TreeListNode treeListNode_0, int int_0)
        {
            treeListNode_0 = treeList_0.AppendNode(null, 0);
            treeList_0.Columns.Add();
            treeList_0.Columns[0].Caption = "TT";
            treeList_0.Columns[0].Visible = true;
            treeList_0.Columns.Add();
            treeList_0.Columns[1].Caption = "B\x00e1o c\x00e1o";
            treeList_0.Columns[1].Visible = true;
            treeList_0.Columns.Add();
            treeList_0.Columns[2].Caption = "Diễn giải";
            treeList_0.Columns[2].Visible = true;
            TreeListNode node = null;
            DataTable dataTable = new DataTable();
            string selectCommandText = "Select * from tblReports";
            new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0).Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                if ((bool)row["status"])
                {
                    object[] nodeData = new object[5];
                    nodeData[0] = row["idx"];
                    nodeData[1] = row["rep_name"];
                    nodeData[2] = row["description"];
                    node = treeList_0.AppendNode(nodeData, 0);
                    node.SetValue(1, row["rep_name"].ToString());
                    node.SetValue(2, row["description"].ToString());
                    node.GetValue(1).ToString();
                }
            }
        }

        private string method_1(TreeList treeList_0)
        {
            string str = null;
            string str2 = null;
            string str3 = null;
            foreach (TreeListNode node in treeList_0.Nodes[0].Nodes)
            {
                bool flag = false;
                int imageIndex = node.ImageIndex;
                TreeListNode node2 = node;
                node2.GetValue(2).ToString();
                node2.GetValue(0).ToString();
                Class11.smethod_18(node.Tag);
                if ((node.Tag != null) && (((int)node.Tag) == 1))
                {
                    str2 = node.GetValue(0).ToString() + ";";
                    foreach (TreeListNode node3 in node.Nodes)
                    {
                        str = node3.GetValue(1).ToString();
                        str2 = str2 + str + ";";
                    }
                    flag = true;
                }
                if ((node.Tag != null) && (((int)node.Tag) == 2))
                {
                    str2 = node.GetValue(1).ToString() + ";";
                    foreach (TreeListNode node3 in node.Nodes)
                    {
                        if ((node3.Tag != null) && (((int)node3.Tag) == 2))
                        {
                            str = node3.GetValue(1).ToString();
                            str2 = str2 + str + ";";
                            flag = true;
                        }
                        if ((node3.Tag != null) && (((int)node3.Tag) == 1))
                        {
                            str = node3.GetValue(1).ToString();
                            str2 = str2 + str + ";";
                            flag = true;
                        }
                    }
                }
                if ((node.Tag != null) && (((int)node.Tag) == 3))
                {
                    str2 = node.GetValue(1).ToString() + ";";
                    foreach (TreeListNode node3 in node.Nodes)
                    {
                        if ((node3.Tag != null) && (((int)node3.Tag) == 3))
                        {
                            str = node3.GetValue(1).ToString();
                            str2 = str2 + str + ";";
                            flag = true;
                        }
                        if ((node3.Tag != null) && (((int)node3.Tag) == 2))
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

        private void method_2(string string_1)
        {
            this.string_0 = " Select * from tblUserGrp where id = '" + string_1 + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            string[] strArray = Class13.smethod_2(dataTable.Rows[0]["rpright"].ToString()).Split(new char[] { ';' });
            int index = 0;
            string str2 = null;
            TreeListNodes nodes = this.treeList1.Nodes[0].Nodes;
            string str3 = null;
            foreach (TreeListNode node in nodes)
            {
                str3 = node.GetValue(0).ToString();
                for (index = 0; index <= (strArray.Length - 1); index++)
                {
                    str2 = strArray[index].ToString();
                    if (str3 == str2)
                    {
                        node.Tag = 1;
                    }
                }
            }
            this.treeList1.ExpandAll();
        }

        private void pfeZyQnoF(int int_0)
        {
            this.string_0 = " Select * from tblUser where id = " + int_0;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            string[] strArray = Class13.smethod_2(dataTable.Rows[0]["rpright"].ToString()).Split(new char[] { ';' });
            int index = 0;
            string str2 = null;
            TreeListNodes nodes = this.treeList1.Nodes[0].Nodes;
            string str3 = null;
            foreach (TreeListNode node in nodes)
            {
                str3 = node.GetValue(0).ToString();
                for (index = 0; index <= (strArray.Length - 1); index++)
                {
                    str2 = strArray[index].ToString();
                    if (str3 == str2)
                    {
                        node.Tag = 1;
                    }
                }
            }
            this.treeList1.ExpandAll();
        }

        private void treeList1_GetStateImage(object sender, GetStateImageEventArgs e)
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

        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeListHitInfo info = this.treeList1.CalcHitInfo(new Point(e.X, e.Y));
                if (info.HitInfoType == HitInfoType.StateImage)
                {
                    Class11.smethod_13(info.Node, this.treeList1);
                }
            }
        }
   
    }
}