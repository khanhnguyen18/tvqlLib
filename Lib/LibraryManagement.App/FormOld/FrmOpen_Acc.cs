using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmOpen_Acc : DevExpress.XtraEditors.XtraForm
    {
        public FrmOpen_Acc()
        {
            InitializeComponent();
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_basic.Enabled = false;
            this.Txt_CustId.Enabled = false;
            this.Txt_ThirdLevel.Enabled = false;
            this.Txt_ShortName.Focus();
            this.string_1 = "E";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            this.string_1 = "N";
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            Class11.smethod_8(this);
            this.Txt_Account.Properties.ReadOnly = true;
            this.Txt_ThirdLevel.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Txt_basic.Text.Trim().Length < 4)
            {
                Class7.ShowMessageBox("M\x00e3 t\x00e0i khoản c\x00f3 độ d\x00e0i l\x00e0 4", 1);
                this.Txt_basic.Focus();
            }
            else if (this.Lbl_VietName.Text == string.Empty)
            {
                Class7.ShowMessageBox("M\x00e3 t\x00e0i khoản cấp 3 kh\x00f4ng tồn tại", 1);
                this.Txt_ThirdLevel.Focus();
            }
            else
            {
                string str2 = this.Txt_Account.EditValue.ToString();
                if (Class7.smethod_18("tblAccount", "account_id", str2) && (this.string_1 == "N"))
                {
                    Class7.ShowMessageBox("M\x00e3 t\x00e0i khoản đ\x00e3 được đăng k\x00fd", 1);
                    this.Txt_basic.Focus();
                }
                else if (this.Txt_ShortName.Text == string.Empty)
                {
                    Class7.ShowMessageBox("Bạn chưa khai b\x00e1o t\x00ean viết tắt", 1);
                    this.Txt_ShortName.Focus();
                }
                else if (Class7.smethod_18("tblAccount", "abbreviat", this.Txt_ShortName.Text) && (this.string_1 == "N"))
                {
                    Class7.ShowMessageBox("T\x00ean viết tắt đ\x00e3 được đăng k\x00fd", 1);
                    this.Txt_ShortName.Focus();
                }
                else if (this.Txt_Name.Text == string.Empty)
                {
                    Class7.ShowMessageBox("Bạn chưa khai b\x00e1o t\x00ean đầy đủ", 1);
                    this.Txt_Name.Focus();
                }
                else if (Class7.smethod_18("tblAccount", "name", this.Txt_ShortName.Text) && (this.string_1 == "N"))
                {
                    Class7.ShowMessageBox("T\x00ean t\x00e0i khoản đ\x00e3 được đăng k\x00fd", 1);
                    this.Txt_Name.Focus();
                }
                else
                {
                    string str3 = this.Txt_ShortName.Text.Trim();
                    string str4 = this.Txt_ThirdLevel.Text.Trim();
                    string str5 = this.Txt_CustId.Text.Trim();
                    int num = 1;
                    string str6 = this.Txt_Name.Text.Trim();
                    string str = this.string_1;
                    if (str != null)
                    {
                        DataSet set;
                        if (str != "N")
                        {
                            if (!(str == "E"))
                            {
                                return;
                            }
                            this.btn_Skip_Click(this, new EventArgs());
                            this.string_0 = "UPDATE tblAccount SET abbreviat = '" + str3 + "',name = N'" + str6 + "'  WHERE account_id = '" + str2 + "'";
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_0.Close();
                                return;
                            }
                        }
                        this.btn_Skip_Click(this, new EventArgs());
                        this.string_0 = string.Concat(new object[] { "INSERT INTO tblAccount (branch, account_id, abbreviat, mof_gl, cust_id, name, open_date, creamt, debamt, status)  VALUES(", num, ",'", str2, "','", str3, "','", str4, "','", str5, "',N'", str6, "','", Class7.smethod_19(), "',0,0,1)" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                        }
                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.string_1 = "S";
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.Txt_Account.Enabled = true;
            this.Txt_Account.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }


        private void FrmOpen_Acc_Load(object sender, EventArgs e)
        {
            this.btn_Skip_Click(this, new EventArgs());
            base.Tag = "";
            this.Text = "Tạo t\x00e0i khoản chi tiết";
        }



        private void Txt_Account_EditValueChanged(object sender, EventArgs e)
        {
            if (this.string_1 == "S")
            {
                this.string_0 = "SELECT account_id , abbreviat , mof_gl , name ,cust_id, open_date , status  FROM  tblAccount where account_id = '" + this.Txt_Account.EditValue.ToString() + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_ShortName.Text = set.Tables[0].Rows[0]["abbreviat"].ToString();
                        this.Txt_Name.Text = set.Tables[0].Rows[0]["name"].ToString();
                        this.Txt_ThirdLevel.Text = set.Tables[0].Rows[0]["mof_gl"].ToString();
                        this.Txt_basic.Text = set.Tables[0].Rows[0]["account_id"].ToString().Substring(5, 4);
                        this.Txt_CustId.Text = set.Tables[0].Rows[0]["cust_id"].ToString();
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                        this.btn_Delete.Text = (set.Tables[0].Rows[0]["status"].ToString() == "True") ? "&X\x00f3a" : "&Phục hồi";
                        this.Txt_Account.Text = set.Tables[0].Rows[0]["account_id"].ToString();
                    }
                    else
                    {
                        this.Txt_ShortName.Text = string.Empty;
                        this.Txt_Name.Text = string.Empty;
                        this.Txt_ThirdLevel.Text = string.Empty;
                        this.Txt_basic.Text = string.Empty;
                        this.Txt_CustId.Text = string.Empty;
                    }
                }
            }
        }

        private void Txt_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(this.string_1 != "S") && (e.KeyCode == Keys.F5))
            {
                string str = (this.Txt_Account.EditValue.ToString().Length != 0) ? this.Txt_Account.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_0 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_Account.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_basic_EditValueChanged(object sender, EventArgs e)
        {
            if ((this.string_1 == "N") && (this.Txt_basic.Text.Length == 4))
            {
                this.Txt_Account.Text = this.Txt_ThirdLevel.Text + "1" + this.Txt_basic.Text;
            }
        }

        private void Txt_basic_Validated(object sender, EventArgs e)
        {
            if (this.string_1 == "N")
            {
                this.Txt_Account.Text = this.Txt_ThirdLevel.Text + "1" + this.Txt_basic.Text;
            }
        }

        private void Txt_CustId_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_CustId.Text, "and type IN('05','06') ", this.oleDbConnection_0, ref str);
            this.Lbl_CustName.Text = str;
            if ((this.Lbl_CustName.Text != string.Empty) && (this.string_1 == "N"))
            {
                this.Txt_basic.Text = this.Txt_CustId.Text.Substring(1, 4);
            }
        }

        private void Txt_CustId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS [M\x00e3 số], Name AS [T\x00ean KH], fullname AS [Diễn giải] FROM tblStore WHERE Type IN('05','06') and status = 1 ";
                Class7.BrowserForm1(str, this.oleDbConnection_0);
                this.Txt_CustId.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_ThirdLevel_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_ThirdLevel.Text.Trim();
            if (this.string_1 == "N")
            {
                this.string_0 = "select mof_gl, mof_name, mof_nameb FROM tblMof_sys where mof_gl = '" + str + "' and glevel = 3 ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Lbl_VietName.Text = set.Tables[0].Rows[0]["mof_name"].ToString();
                        this.Lbl_EngName.Text = set.Tables[0].Rows[0]["mof_nameb"].ToString();
                        this.Txt_Account.Text = this.Txt_ThirdLevel.Text.Trim() + "1";
                        string str2 = "331,131";
                        this.Txt_CustId.Enabled = str2.IndexOf(this.Txt_ThirdLevel.Text.Substring(0, 3)) != -1;
                        this.Txt_basic.Focus();
                    }
                    else
                    {
                        this.Lbl_VietName.Text = string.Empty;
                        this.Lbl_EngName.Text = string.Empty;
                        this.Txt_Account.Text = string.Empty;
                    }
                    return;
                }
            }
            string str3 = null;
            Class7.smethod_17("mof_name", "tblMof_sys", "mof_gl", this.Txt_ThirdLevel.Text, "", this.oleDbConnection_0, ref str3);
            this.Lbl_VietName.Text = str3;
        }

        private void Txt_ThirdLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.string_0 = "select mof_gl, mof_name FROM tblMof_sys where glevel = 3 ";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_ThirdLevel.Text = BrowseForm.strReturn;
            }
        }
   
    }
}