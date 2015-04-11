using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

internal class Class11
{
    public static string string_0;
    public static string string_1 = "K";

    //static Class11()
    //{
    //    //Class15.smethod_5();
    //}

    public Class11()
    {
        //Class17.smethod_0();
    }

    public static void EnableNewMode(Control button)
    {
        string_0 = "D";
        foreach (Control control in button.Controls)
        {
            if (control is SimpleButton)
            {
                switch (control.Name)
                {
                    case "btn_Exit":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Delete":
                    {
                        control.Enabled = false;
                        control.Text = "&X\x00f3a";
                        continue;
                    }
                    case "btn_Edit":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_New":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Save":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_Skip":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_Search":
                    {
                        control.Enabled = true;
                        continue;
                    }
                }
                control.Enabled = false;
            }
        }
    }

    public static void smethod_1(Control control_0)
    {
        string_0 = "N";
        foreach (Control control in control_0.Controls)
        {
            if (control is SimpleButton)
            {
                switch (control.Name)
                {
                    case "btn_Exit":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Delete":
                    {
                        control.Enabled = false;
                        control.Text = "&X\x00f3a";
                        continue;
                    }
                    case "btn_Edit":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_New":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_Save":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Skip":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Search":
                    {
                        control.Enabled = false;
                        continue;
                    }
                }
                control.Enabled = true;
            }
        }
    }

    public static void BindCombox(string string_2, object object_0, object object_1, object object_2, ComboBoxEdit comboBoxEdit_0, int int_0, OleDbConnection object_3)
    {
        comboBoxEdit_0.Properties.Items.Clear();
        using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT " + object_0 + ", " + object_1 + " FROM  " + string_2 + " " + object_2, (OleDbConnection) object_3))
        {
            using (DataSet set = new DataSet())
            {
                adapter.Fill(set, string_2);
                //object_3.Close();
                int num = 0;
                RepositoryItemComboBox properties = comboBoxEdit_0.Properties;
                for (num = 0; num <= (set.Tables[string_2].Rows.Count - 1); num++)
                {
                    properties.Items.Add(set.Tables[string_2].Rows[num][0].ToString() + "  |  " + set.Tables[string_2].Rows[num][1].ToString());
                }
            }
        }
        comboBoxEdit_0.SelectedIndex = int_0;
    }

    public static string smethod_11(Control control_0)
    {
        string str = null;
        str = control_0.Text.Trim();
        char[] separator = new char[] { '|' };
        return str.Split(separator)[0].Trim();
    }

    public static void smethod_12(TreeList treeList_0, object object_0, int int_0)
    {
        object_0 = treeList_0.AppendNode(null, 0);
        treeList_0.Columns.Add();
        treeList_0.Columns[0].Caption = "Menu";
        treeList_0.Columns[0].Visible = true;
        treeList_0.Columns.Add();
        treeList_0.Columns[1].Caption = "ID";
        treeList_0.Columns[1].Visible = true;
        treeList_0.Columns.Add();
        treeList_0.Columns[2].Caption = "MenuKey";
        treeList_0.Columns[2].Visible = true;
        TreeListNode node = null;
        DataTable dataTable = new DataTable();
        string str = null;
        string selectCommandText = "Select * from tblMenus";
        new OleDbDataAdapter(selectCommandText, Class7.oleDbConnection_1).Fill(dataTable);
        foreach (DataRow row in dataTable.Rows)
        {
            str = row["id"].ToString();
            if (((int) row["subitem"]) == 1)
            {
                object[] nodeData = new object[4];
                nodeData[0] = row["prompt"];
                nodeData[1] = row["prompt"];
                node = treeList_0.AppendNode(nodeData, 0);
                node.SetValue(1, row["id"].ToString());
                node.SetValue(2, row["MenuKey"].ToString());
                node.GetValue(1).ToString();
                smethod_16(treeList_0, node, 2, str);
            }
        }
    }

    public static void smethod_13(TreeListNode treeListNode_0, TreeList treeList_0)
    {
        CheckState @unchecked = smethod_18(treeListNode_0.Tag);
        if ((@unchecked == CheckState.Indeterminate) || (@unchecked == CheckState.Unchecked))
        {
            @unchecked = CheckState.Checked;
        }
        else
        {
            @unchecked = CheckState.Unchecked;
        }
        treeList_0.BeginUpdate();
        treeListNode_0.Tag = @unchecked;
        smethod_14(treeListNode_0, @unchecked);
        smethod_15(treeListNode_0, @unchecked);
        treeList_0.EndUpdate();
    }

    public static void smethod_14(TreeListNode treeListNode_0, CheckState checkState_0)
    {
        for (int i = 0; i < treeListNode_0.Nodes.Count; i++)
        {
            treeListNode_0.Nodes[i].Tag = checkState_0;
            smethod_14(treeListNode_0.Nodes[i], checkState_0);
        }
    }

    public static void smethod_15(TreeListNode treeListNode_0, CheckState checkState_0)
    {
        if (treeListNode_0.ParentNode != null)
        {
            bool flag = false;
            CheckState @unchecked = CheckState.Unchecked;
            for (int i = 0; i < treeListNode_0.ParentNode.Nodes.Count; i++)
            {
                if (treeListNode_0.ParentNode.Nodes[i].Tag == null)
                {
                    @unchecked = CheckState.Unchecked;
                }
                else
                {
                    @unchecked = (CheckState) treeListNode_0.ParentNode.Nodes[i].Tag;
                }
                if (!checkState_0.Equals(@unchecked))
                {
                    flag = !flag;
                    break;
                }
            }
            if (flag)
            {
                treeListNode_0.ParentNode.Tag = CheckState.Indeterminate;
            }
            else
            {
                treeListNode_0.ParentNode.Tag = checkState_0;
            }
            smethod_15(treeListNode_0.ParentNode, checkState_0);
        }
    }

    private static void smethod_16(TreeList treeList_0, TreeListNode treeListNode_0, int int_0, string string_2)
    {
        TreeListNode node = null;
        DataTable dataTable = new DataTable();
        string selectCommandText = "Select * from tblMenus";
        new OleDbDataAdapter(selectCommandText, Class7.oleDbConnection_1).Fill(dataTable);
        foreach (DataRow row in dataTable.Rows)
        {
            if ((((int) row["subitem"]) == 0) & (row["parent"].ToString() == string_2))
            {
                node = treeList_0.AppendNode(new object[] { row["prompt"] }, treeListNode_0);
                node.SetValue(1, row["id"].ToString());
                node.SetValue(2, row["menukey"].ToString());
                node.GetValue(1).ToString();
            }
            else if ((((int) row["subitem"]) == 2) & (row["parent"].ToString() == string_2))
            {
                node = treeList_0.AppendNode(new object[] { row["prompt"] }, treeListNode_0);
                node.SetValue(1, row["id"].ToString());
                node.SetValue(2, row["menukey"].ToString());
                node.GetValue(1).ToString();
                smethod_17(treeList_0, node, 2, row["id"].ToString());
            }
        }
    }

    private static void smethod_17(TreeList treeList_0, TreeListNode treeListNode_0, int int_0, string string_2)
    {
        TreeListNode node = null;
        DataTable dataTable = new DataTable();
        string selectCommandText = "Select * from tblMenus";
        new OleDbDataAdapter(selectCommandText, Class7.oleDbConnection_1).Fill(dataTable);
        foreach (DataRow row in dataTable.Rows)
        {
            if ((((int) row["subitem"]) == -1) & (row["parent"].ToString() == string_2))
            {
                node = treeList_0.AppendNode(new object[] { row["prompt"] }, treeListNode_0);
                node.SetValue(1, row["id"].ToString());
                node.SetValue(2, row["menukey"].ToString());
                node.GetValue(1).ToString();
            }
        }
    }

    public static CheckState smethod_18(object object_0)
    {
        if (object_0 != null)
        {
            return (CheckState) object_0;
        }
        return CheckState.Unchecked;
    }

    public static int smethod_19(List<TextEdit> _listTextEdit)
    {
        int num = 100;
        for (int i = 0; i < _listTextEdit.Count; i++)
        {
            if (string.IsNullOrEmpty(_listTextEdit[i].Text))
            {
                return i;
            }
            num = 100;
        }
        return num;
    }

    public static void smethod_2(Control control_0)
    {
        string_0 = "S";
        foreach (Control control in control_0.Controls)
        {
            if (control is SimpleButton)
            {
                switch (control.Name)
                {
                    case "btn_Exit":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Delete":
                    {
                        control.Enabled = false;
                        control.Text = "&X\x00f3a";
                        continue;
                    }
                    case "btn_Edit":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_New":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_Save":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_Skip":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Search":
                    {
                        control.Enabled = false;
                        continue;
                    }
                }
                control.Enabled = false;
            }
        }
    }

    public static void smethod_3(Control control_0)
    {
        string_0 = "F";
        foreach (Control control in control_0.Controls)
        {
            if (control is SimpleButton)
            {
                switch (control.Name)
                {
                    case "btn_Exit":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Delete":
                    {
                        control.Enabled = true;
                        control.Text = "&X\x00f3a";
                        continue;
                    }
                    case "btn_Edit":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_New":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Save":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_Skip":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_Search":
                    {
                        control.Enabled = true;
                        continue;
                    }
                }
                control.Enabled = false;
            }
        }
    }

    public static void smethod_4(Control control_0)
    {
        string_0 = "E";
        foreach (Control control in control_0.Controls)
        {
            if (control is SimpleButton)
            {
                switch (control.Name)
                {
                    case "btn_Exit":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Delete":
                    {
                        control.Enabled = false;
                        control.Text = "&X\x00f3a";
                        continue;
                    }
                    case "btn_Edit":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_New":
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case "btn_Save":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Skip":
                    {
                        control.Enabled = true;
                        continue;
                    }
                    case "btn_Search":
                    {
                        control.Enabled = false;
                        continue;
                    }
                }
                control.Enabled = true;
            }
        }
    }

    public static void smethod_5(Control control_0, string string_2)
    {
        foreach (Control control in control_0.Controls)
        {
            string str;
            if (((control is TextEdit) | (control is ComboBoxEdit)) | (control is CheckEdit))
            {
                str = string_2;
                if (str != null)
                {
                    if (!(str == "T"))
                    {
                        if (str == "F")
                        {
                            control.Enabled = false;
                        }
                    }
                    else
                    {
                        if (control.Name == "Txt_Status")
                        {
                            control.Enabled = false;
                        }
                        else
                        {
                            control.Enabled = true;
                        }
                        if (control.Name == "Txt_OpenDate")
                        {
                            control.Enabled = false;
                        }
                        if (control.Name == "Txt_Id")
                        {
                            control.Enabled = false;
                        }
                        if (control.Name == "Txt_TransNum")
                        {
                            control.Enabled = false;
                        }
                    }
                }
            }
            if ((control is RadioGroup) | (control is ListBoxControl))
            {
                str = string_2;
                if (str == null)
                {
                    continue;
                }
                if (!(str == "T"))
                {
                    if (str == "F")
                    {
                        control.Enabled = false;
                    }
                    continue;
                }
                control.Enabled = true;
            }
        }
    }

    public static void smethod_6(Control control_0, int int_0)
    {
        foreach (Control control in control_0.Controls)
        {
            if (((control is TextEdit) | (control is ComboBoxEdit)) | (control is CheckEdit))
            {
                switch (int_0)
                {
                    case 0:
                    {
                        control.Enabled = false;
                        continue;
                    }
                    case 1:
                    {
                        control.Enabled = true;
                        continue;
                    }
                }
            }
        }
    }

    public static void smethod_7(Control control_0)
    {
        foreach (Control control in control_0.Controls)
        {
            if (control is TextEdit)
            {
                control.Text = string.Empty;
            }
        }
    }

    public static void smethod_8(Control control_0)
    {
        foreach (Control control in control_0.Controls)
        {
            if (control is TextEdit)
            {
                control.Text = string.Empty;
            }
        }
    }

    public static void smethod_9(string string_2, string string_3, object object_0, ComboBoxEdit comboBoxEdit_0, int int_0, object object_1)
    {
        comboBoxEdit_0.Properties.Items.Clear();
        using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT " + string_3 + " FROM  " + string_2 + " " + object_0, (OleDbConnection) object_1))
        {
            using (DataSet set = new DataSet())
            {
                adapter.Fill(set, string_2);
                //object_1.Close();
                int num = 0;
                RepositoryItemComboBox properties = comboBoxEdit_0.Properties;
                for (num = 0; num <= (set.Tables[string_2].Rows.Count - 1); num++)
                {
                    properties.Items.Add(set.Tables[string_2].Rows[num][string_3].ToString());
                }
            }
        }
        comboBoxEdit_0.SelectedIndex = int_0;
    }
}

