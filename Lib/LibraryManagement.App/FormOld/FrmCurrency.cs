using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmCurrency : DevExpress.XtraEditors.XtraForm
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string text = this.btn_Delete.Text;
            if ((text != null) && (text == "&X\x00f3a"))
            {
                if (Class7.ShowMessageBox("Bạn chắc chắn muốn x\x00f3a k\x00fd hiệu tiền tệ n\x00e0y ? ", 2) == 1)
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "id", this.Txt_Id.Text.Trim(), "", this.oleDbConnection_0);
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.ShowMessageBox("Bạn chắc chắn muốn phục hồi k\x00fd hiệu tiền tệ n\x00e0y ? ", 2) == 1)
            {
                Class7.smethod_23(base.Tag.ToString(), 1, "id", this.Txt_Id.Text.Trim(), "", this.oleDbConnection_0);
                this.Txt_Status.Text = "Đang hoạt động";
                this.btn_Delete.Text = "&X\x00f3a";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_Description.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            Class11.smethod_8(this);
            this.Txt_Id.Enabled = true;
            this.Txt_Id.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if ((this.Txt_Id.Text == string.Empty) | (this.Txt_Description.Text == string.Empty))
            {
                Class7.ShowMessageBox("Bạn chưa nhập đủ th\x00f4ng tin", 1);
            }
            else
            {
                this.method_0();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.Txt_Id.Enabled = true;
            this.Txt_Id.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd tiền tệ";
            base.Tag = "tblCurrency";
            this.btn_Skip_Click(this, new EventArgs());
        }



        private void method_0()
        {
            object obj2;
            DataSet set;
            string str = this.Txt_Id.Text.Trim();
            string str2 = this.Txt_Description.Text.Trim();
            double num = Class7.smethod_0(this.Txt_ExchangeRate.Text);
            string selectCommandText = null;
            switch (Class11.string_0)
            {
                case "N":
                    if (Class7.smethod_18(base.Tag.ToString(), "Id", str))
                    {
                        Class7.ShowMessageBox("K\x00fd hiệu n\x00e0y đ\x00e3 được đăng k\x00fd", 1);
                    }
                    else
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        obj2 = "INSERT INTO " + base.Tag.ToString() + "(id, Description,exchange) ";
                        selectCommandText = string.Concat(new object[] { obj2, "VALUES('", str, "',N'", str2, "',", num, ")" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
                        this.oleDbConnection_0.Close();
                    }
                    break;

                case "E":
                    this.btn_Skip_Click(this, new EventArgs());
                    obj2 = "UPDATE " + base.Tag.ToString() + " SET Description =N'" + str2 + "', ";
                    selectCommandText = string.Concat(new object[] { obj2, "exchange = ", num, " WHERE ID = '", str, "' " });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                    }
                    this.oleDbConnection_0.Close();
                    break;
            }
        }

        private void Txt_Id_EditValueChanged(object sender, EventArgs e)
        {
            if (!((Class11.string_0 != "S") | (this.Txt_Id.Text == string.Empty)))
            {
                string text = this.Txt_Id.Text;
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM " + base.Tag.ToString() + " WHERE Id = '" + this.Txt_Id.Text + "' ", this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_0.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    Class11.smethod_3(this);
                    Class11.smethod_5(this, "F");
                    this.Txt_ExchangeRate.Text = dataSet.Tables[0].Rows[0]["Exchange"].ToString();
                    this.Txt_Description.Text = dataSet.Tables[0].Rows[0]["Description"].ToString();
                    this.Txt_Status.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                }
            }
        }

        private void Txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Class7.BrowserForm1("select Id as 'K\x00fd hiệu', Description AS 'Diễn giải', exchange as 'Tỷ gi\x00e1', Status from " + base.Tag.ToString(), this.oleDbConnection_0);
                this.Txt_Id.Text = BrowseForm.strReturn;
            }
        }
    }
}