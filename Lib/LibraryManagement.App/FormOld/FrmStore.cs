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
    public partial class FrmStore : DevExpress.XtraEditors.XtraForm
    {
        public FrmStore()
        {
            InitializeComponent();
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            object text = this.Txt_Id.Text;
            string str = this.btn_Delete.Text;
            if ((str != null) && (str == "&X\x00f3a"))
            {
                if (Class7.ShowMessageBox("Bạn chắc chắn muốn x\x00f3a m\x00e3 số n\x00e0y ? ", 2) == 1)
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "id", text.ToString(), "", this.oleDbConnection_0);
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.ShowMessageBox("Bạn chắc chắn muốn phục hồi m\x00e3 số n\x00e0y ? ", 2) == 1)
            {
                Class7.smethod_23(base.Tag.ToString(), 1, "id", text.ToString(), "", this.oleDbConnection_0);
                this.Txt_Status.Text = "Đang hoạt động";
                this.btn_Delete.Text = "&X\x00f3a";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.IipWvDcZu.Enabled = false;
            this.string_0 = "E";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_1(this);
            Class11.smethod_8(this);
            Class11.smethod_5(this, "T");
            this.string_0 = "N";
            this.Txt_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.IipWvDcZu.SelectedIndex == -1)
            {
                Class7.ShowMessageBox("Bạn chưa chọn loại kho, quầy", 1);
                this.IipWvDcZu.Focus();
            }
            else
            {
                string str8 = this.Txt_Id.Text.Trim();
                string str = this.Txt_Name.Text.Trim();
                string str2 = this.Txt_Description.Text.Trim();
                string str3 = string.Format("{0:00}", this.IipWvDcZu.SelectedIndex + 1);
                string str4 = this.Txt_Address.Text.Trim();
                string str5 = this.Txt_Phone.Text.Trim();
                string str7 = this.string_0;
                if (str7 != null)
                {
                    string str6;
                    DataSet set;
                    if (!(str7 == "N"))
                    {
                        if (str7 == "E")
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            str6 = "UPDATE " + base.Tag.ToString() + " SET Name = N'" + str + "',[Fullname]= N'" + str2 + "' , [type] = '" + str3 + "', address = N'" + str4 + "',phone = '" + str5 + "'  WHERE Id = '" + str8 + "' ";
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(str6, this.oleDbConnection_0);
                            set = new DataSet();
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                        }
                    }
                    else if (Class7.smethod_18(base.Tag.ToString(), "name", str))
                    {
                        Class7.ShowMessageBox("T\x00ean sử dụng n\x00e0y đ\x00e3 c\x00f3 trong cơ sở dữ liệu", 1);
                        this.Txt_Name.Focus();
                    }
                    else
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        this.Txt_Id.Text = Class7.smethod_9(base.Tag.ToString(), "{0:00000}", this.oleDbConnection_0);
                        str6 = "INSERT INTO " + base.Tag.ToString() + "([Id], [Name], [Fullname],[Type],open_date,[Status], address, phone) VALUES('" + this.Txt_Id.Text.Trim() + "',  '" + str + "' , N'" + str2 + "','" + str3 + "','" + Class7.smethod_19() + "', 1,N'" + str4 + "','" + str5 + "') ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(str6, this.oleDbConnection_0);
                        set = new DataSet();
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.string_0 = "S";
            this.Txt_Id.Enabled = true;
            this.Txt_Id.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "D";
        }


        private void FrmStore_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd kho, quầy";
            base.Tag = "tblStore";
            this.btn_Skip_Click(this, new EventArgs());
            Class11.smethod_8(this);
            this.IipWvDcZu.SelectedIndex = 1;
        }



        private void Txt_Id_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.string_0 != "S"))
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM " + base.Tag.ToString() + " WHERE Id = '" + this.Txt_Id.Text + "' ", this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_0.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    this.Txt_Name.Text = dataSet.Tables[0].Rows[0]["Name"].ToString();
                    this.Txt_Description.Text = dataSet.Tables[0].Rows[0]["fullname"].ToString();
                    this.Txt_OpenDate.EditValue = (DateTime)dataSet.Tables[0].Rows[0]["open_date"];
                    this.Txt_Address.Text = dataSet.Tables[0].Rows[0]["address"].ToString();
                    this.Txt_Phone.Text = dataSet.Tables[0].Rows[0]["phone"].ToString();
                    this.IipWvDcZu.SelectedIndex = int.Parse(dataSet.Tables[0].Rows[0]["type"].ToString()) - 1;
                    this.Txt_Status.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                    Class11.smethod_3(this);
                    Class11.smethod_5(this, "F");
                    this.btn_Delete.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                }
            }
        }

        private void Txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Class7.BrowserForm1("SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean kho quầy', fullname AS 'Diễn giải' FROM " + base.Tag.ToString() + " WHERE Type IN('01','02') ", this.oleDbConnection_0);
                this.Txt_Id.Text = BrowseForm.strReturn;
                this.Txt_Id.SelectAll();
            }
        }
   
    }
}