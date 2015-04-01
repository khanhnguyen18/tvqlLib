using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm
    {
        public FrmUser()
        {
            InitializeComponent();
        }




        private void btn_Delete_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter;
            DataSet set;
            string str = this.Txt_Id.Text.Trim();
            string text = this.btn_Delete.Text;
            if ((text != null) && (text == "&X\x00f3a"))
            {
                if (Class7.ShowMessageBox("Bạn chắc chắn muốn x\x00f3a người sử dụng n\x00e0y ? ", 2) == 1)
                {
                    adapter = new OleDbDataAdapter("UPDATE " + base.Tag.ToString() + " SET Status = 0 WHERE ID = '" + str + "' ", Class7.oleDbConnection_1);
                    set = new DataSet();
                    adapter.Fill(set);
                    Class7.oleDbConnection_1.Close();
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.ShowMessageBox("Bạn chắc chắn muốn phục hồi người sử dụng n\x00e0y ? ", 2) == 1)
            {
                adapter = new OleDbDataAdapter("UPDATE " + base.Tag.ToString() + " SET Status = 1 WHERE ID = '" + str + "' ", Class7.oleDbConnection_1);
                set = new DataSet();
                adapter.Fill(set);
                Class7.oleDbConnection_1.Close();
                this.Txt_Status.Text = "Đang hoạt động";
                this.btn_Delete.Text = "&X\x00f3a";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_5(this, "T");
            Class11.smethod_4(this);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_MenusRight_Click(object sender, EventArgs e)
        {
            if (!(Class11.string_0 == "N"))
            {
                Class7.string_2 = this.Txt_ShortName.Text;
                new FrmUserMng().ShowDialog();
                this.btn_Save_Click(this, new EventArgs());
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_1(this);
            Class11.smethod_8(this);
            Class11.smethod_5(this, "T");
            Class11.BindCombox("tblUserGrp", "id", "name", "where status = 1", this.Cmb_Group, 0, this.oleDbConnection_0);
            this.btn_MenusRight.Enabled = false;
            this.btn_ReportRight.Enabled = false;
            this.Txt_Id.Text = Class7.smethod_9(base.Tag.ToString(), "{0:0}", Class7.oleDbConnection_1);
            this.Txt_ShortName.Focus();
        }

        private void btn_ReportRight_Click(object sender, EventArgs e)
        {
            Class11.string_1 = "US";
            Class7.int_0 = int.Parse(this.Txt_Id.Text);
            new FrmUserReport().ShowDialog();
            this.btn_Save_Click(this, new EventArgs());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_8(this);
            Class11.BindCombox("tblUserGrp", "id", "name", "where status = 1", this.Cmb_Group, 0, this.oleDbConnection_0);
            this.Txt_Id.Enabled = true;
            Class7.BrowserForm("select Id AS 'M\x00e3 số', Name as 'T\x00ean sử dụng', full_name as 'Diễn giải', Status from " + base.Tag.ToString(), Class7.oleDbConnection_1);
            this.Txt_Id.Text = FrmBrowse.strReturn;
            this.Txt_Id.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
        }

        private void Cmb_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void FrmUser_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd người sử dụng";
            base.Tag = "tblUser";
            this.btn_Skip_Click(this, new EventArgs());
            Class11.smethod_8(this);
            Class11.smethod_9("tblUsergrp", "ID", "where status = 1", this.Cmb_Group, -1, Class7.oleDbConnection_1);
            this.btn_New.Enabled = Class7.smethod_50();
            this.btn_Search.Enabled = Class7.smethod_50();
        }



        private void method_0()
        {
            string str = this.Txt_Id.Text.Trim();
            string str2 = this.Txt_ShortName.Text.Trim();
            string str3 = this.Txt_FullName.Text.Trim();
            string str4 = (this.Txt_Password.Text == string.Empty) ? "" : Class13.smethod_0(this.Txt_Password.Text.Trim(), Class13.string_0);
            string str5 = (this.Txt_Password1.Text == string.Empty) ? "" : Class13.smethod_0(this.Txt_Password1.Text.Trim(), Class13.string_0);
            string str6 = Class11.smethod_11(this.Cmb_Group);
            if (str4 != str5)
            {
                Class7.ShowMessageBox("Mật khẩu nhập 2 lần kh\x00f4ng giống nhau", 1);
                this.Txt_Password.Focus();
            }
            else if (string.IsNullOrEmpty(this.Txt_FullName.Text) | string.IsNullOrEmpty(this.Txt_ShortName.Text))
            {
                Class7.ShowMessageBox("Th\x00f4ng tin khai b\x00e1o chưa đầy đủ", 1);
            }
            else
            {
                string str7 = Class11.string_0;
                if (str7 != null)
                {
                    OleDbDataAdapter adapter;
                    DataSet set;
                    if (!(str7 == "N"))
                    {
                        if (str7 == "E")
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            adapter = new OleDbDataAdapter("UPDATE " + base.Tag.ToString() + " SET [Full_name]= N'" + str3 + "' , [groups] = '" + str6 + "', [Passw]='" + str4 + "' WHERE ID = '" + str + "' ", Class7.oleDbConnection_1);
                            set = new DataSet();
                            adapter.Fill(set);
                            Class7.oleDbConnection_1.Close();
                        }
                    }
                    else if (Class7.smethod_18(base.Tag.ToString(), "name", str2))
                    {
                        Class7.ShowMessageBox("T\x00ean sử dụng n\x00e0y đ\x00e3 c\x00f3 trong cơ sở dữ liệu", 1);
                        this.Txt_ShortName.Focus();
                    }
                    else
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        adapter = new OleDbDataAdapter("INSERT INTO " + base.Tag.ToString() + "([ID], [Name], [Full_name],[groups], [Passw], [Status],mright,rpright) VALUES('" + str + "',  '" + str2 + "' , N'" + str3 + "','" + str6 + "',  '" + str4 + "', 1,'" + this.method_1(str6) + "','" + this.method_2(str6) + "') ", Class7.oleDbConnection_1);
                        set = new DataSet();
                        adapter.Fill(set);
                        Class7.oleDbConnection_1.Close();
                    }
                }
            }
        }

        private string method_1(string string_1)
        {
            this.string_0 = "select menuper from tblUserGrp where id = '" + string_1 + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                return set.Tables[0].Rows[0][0].ToString();
            }
        }

        private string method_2(string string_1)
        {
            this.string_0 = "select rpright from tblUserGrp where id = '" + string_1 + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                return set.Tables[0].Rows[0][0].ToString();
            }
        }

        private void Txt_Id_EditValueChanged(object sender, EventArgs e)
        {
            if (!(Class11.string_0 != "S"))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + base.Tag.ToString() + " WHERE ID = '" + this.Txt_Id.Text + "' ", Class7.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                Class7.oleDbConnection_1.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    this.Txt_ShortName.Text = dataSet.Tables[0].Rows[0]["Name"].ToString();
                    this.Txt_FullName.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
                    this.Txt_Password.Text = string.IsNullOrEmpty(dataSet.Tables[0].Rows[0]["passw"].ToString()) ? "" : Class13.smethod_1(dataSet.Tables[0].Rows[0]["passw"].ToString(), Class13.string_0);
                    this.Cmb_Group.SelectedIndex = int.Parse(dataSet.Tables[0].Rows[0]["groups"].ToString()) - 1;
                    this.Txt_Password1.Text = string.IsNullOrEmpty(dataSet.Tables[0].Rows[0]["passw"].ToString()) ? "" : Class13.smethod_1(dataSet.Tables[0].Rows[0]["passw"].ToString(), Class13.string_0);
                    this.Txt_Status.Text = (dataSet.Tables[0].Rows[0]["status"].ToString() == "True") ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                    Class11.smethod_3(this);
                    Class11.smethod_5(this, "F");
                    this.btn_Delete.Text = (dataSet.Tables[0].Rows[0]["status"].ToString() == "True") ? "&X\x00f3a" : "&Phục hồi";
                }
            }
        }

        private void Txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F5) & (Class11.string_0 == "S"))
            {
                Class7.BrowserForm("select Id AS 'M\x00e3 số', Name as 'T\x00ean sử dụng', full_name as 'Diễn giải', Status from " + base.Tag.ToString(), Class7.oleDbConnection_1);
                this.Txt_Id.Text = FrmBrowse.strReturn;
            }
        }
   
    }
}