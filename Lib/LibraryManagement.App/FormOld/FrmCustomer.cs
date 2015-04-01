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
    public partial class FrmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string text = this.btn_Delete.Text;
            if ((text != null) && (text == "&X\x00f3a"))
            {
                if (Class7.ShowMessageBox("Bạn chắc chắn muốn x\x00f3a kh\x00e1ch h\x00e0ng n\x00e0y ? ", 2) == 1)
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "id", this.Txt_Id.Text.Trim(), "", Class7.oleDbConnection_1);
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.ShowMessageBox("Bạn chắc chắn muốn phục hồi kh\x00e1ch h\x00e0ng n\x00e0y ? ", 2) == 1)
            {
                Class7.smethod_23(base.Tag.ToString(), 1, "id", this.Txt_Id.Text.Trim(), "", Class7.oleDbConnection_1);
                this.Txt_Status.Text = "Đang hoạt động";
                this.btn_Delete.Text = "&X\x00f3a";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.string_1 = "E";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_5(this, "T");
            Class11.smethod_1(this);
            this.Txt_ShortName.Focus();
            this.Cmb_CustType.SelectedIndex = 1;
            this.Txt_OpenDate.EditValue = DateTime.Now;
            this.string_1 = "N";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.string_1 = "S";
            this.Txt_Id.Enabled = true;
            this.Txt_Id.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            this.btn_Skip_Click(this, new EventArgs());
            Class11.smethod_8(this);
            this.Text = "Đăng k\x00fd kh\x00e1ch h\x00e0ng";
            base.Tag = "tblStore";
        }

        private void method_0()
        {
            string str16;
            string str = this.Txt_Id.Text.Trim();
            string str2 = string.Format("{0:d}", Class7.smethod_19());
            string str3 = this.Txt_ShortName.Text.Trim();
            string str4 = this.Txt_FullName.Text.Trim();
            string str5 = this.Txt_Address.Text.Trim();
            string str6 = this.Txt_Phone.Text.Trim();
            string str7 = this.welftZbha.Text.Trim();
            string str8 = this.Txt_BankName.Text.Trim();
            string str9 = this.txtBankBranch.Text.Trim();
            string str10 = this.Txt_AccountId.Text.Trim();
            string str11 = this.ddvqeXfa4.Text.Trim();
            string str12 = this.Txt_Contactperson.Text.Trim();
            string str13 = this.Txt_Remark.Text.Trim();
            string str14 = Class11.smethod_11(this.Cmb_CustType);
            switch (this.string_1)
            {
                case "N":
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        this.Txt_Id.Text = Class7.smethod_9(base.Tag.ToString(), "{0:00000}", this.oleDbConnection_0);
                        this.string_0 = "INSERT INTO " + base.Tag.ToString() + "(id, Type, Name, fullname, address, phone, fax, bankname,bank_br, accnum, Vatnum, contactps, remark, open_date, Status) ";
                        str16 = this.string_0;
                        this.string_0 = str16 + "VALUES('" + this.Txt_Id.Text.Trim() + "','" + str14 + "',N'" + str3 + "',N'" + str4 + "',N'" + str5 + "','" + str6 + "', ";
                        str16 = this.string_0;
                        this.string_0 = str16 + " '" + str7 + "',N'" + str8 + "',N'" + str9 + "','" + str10 + "','" + str11 + "',N'" + str12 + "',N'" + str13 + "','" + str2 + "',1 )";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        DataSet dataSet = new DataSet();
                        this.oleDbDataAdapter_0.Fill(dataSet);
                        this.oleDbConnection_0.Close();
                        this.string_0 = "UPDATE tblCounter SET lastnum = lastnum +1 WHERE TableName = 'tblStore' ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (DataSet set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
                        this.oleDbConnection_0.Close();
                        break;
                    }
                case "E":
                    this.btn_Skip_Click(this, new EventArgs());
                    this.string_0 = "UPDATE " + base.Tag.ToString() + " SET Type ='" + str14 + "', Name =N'" + str3 + "', fullname =N'" + str4 + "', ";
                    str16 = this.string_0;
                    this.string_0 = str16 + "address =N'" + str5 + "', phone ='" + str6 + "', fax ='" + str7 + "', bankname =N'" + str8 + "', ";
                    str16 = this.string_0;
                    this.string_0 = str16 + "accnum ='" + str10 + "', Vatnum ='" + str11 + "', contactps =N'" + str12 + "', remark =N'" + str13 + "', bank_br = N'" + str9 + "' ";
                    this.string_0 = this.string_0 + " WHERE ID = '" + str + "' ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                    using (DataSet set2 = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set2);
                    }
                    this.oleDbConnection_0.Close();
                    break;
            }
        }

        private void pfeZyQnoF(object sender, EventArgs e)
        {
            if (this.Cmb_CustType.SelectedIndex == -1)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o quan hệ kh\x00e1ch h\x00e0ng", 1);
                this.Cmb_CustType.Focus();
            }
            else if (this.Txt_FullName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa nhập t\x00ean đầy đủ", 1);
                this.Txt_FullName.Focus();
            }
            else if (this.Txt_ShortName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa nhập t\x00ean viết tắt", 1);
                this.Txt_ShortName.Focus();
            }
            else if (Class7.smethod_18(base.Tag.ToString(), "name", this.Txt_ShortName.Text.Trim()) && (this.string_1 == "N"))
            {
                Class7.ShowMessageBox("T\x00ean viết tắt đ\x00e3 được sử dụng, đề nghị kiểm tra lại", 1);
                this.Txt_ShortName.Focus();
            }
            else if (Class7.smethod_18(base.Tag.ToString(), "fullname", this.Txt_FullName.Text.Trim()) && (this.string_1 == "N"))
            {
                Class7.ShowMessageBox("T\x00ean đầy đủ đ\x00e3 được sử dụng, đề nghị kiểm tra lại", 1);
                this.Txt_FullName.Focus();
            }
            else
            {
                this.method_0();
            }
        }

        private void Txt_Id_EditValueChanged(object sender, EventArgs e)
        {
            if (Class11.string_0 == "S")
            {
                this.string_0 = "SELECT * FROM " + base.Tag.ToString() + " WHERE Id = '" + this.Txt_Id.Text.Trim() + "' and Type IN('04','05','06') ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_ShortName.Text = set.Tables[0].Rows[0]["name"].ToString();
                        this.Txt_FullName.Text = set.Tables[0].Rows[0]["fullname"].ToString();
                        this.Txt_Address.Text = set.Tables[0].Rows[0]["address"].ToString();
                        this.Txt_Phone.Text = set.Tables[0].Rows[0]["phone"].ToString();
                        this.welftZbha.Text = set.Tables[0].Rows[0]["fax"].ToString();
                        this.Txt_Contactperson.Text = set.Tables[0].Rows[0]["contactps"].ToString();
                        this.Txt_AccountId.Text = set.Tables[0].Rows[0]["accnum"].ToString();
                        this.ddvqeXfa4.Text = set.Tables[0].Rows[0]["vatnum"].ToString();
                        this.Txt_BankName.Text = set.Tables[0].Rows[0]["bankname"].ToString();
                        this.Txt_OpenDate.EditValue = (DateTime)set.Tables[0].Rows[0]["open_date"];
                        this.Txt_Remark.Text = set.Tables[0].Rows[0]["Remark"].ToString();
                        this.txtBankBranch.Text = set.Tables[0].Rows[0]["bank_br"].ToString();
                        this.Cmb_CustType.SelectedIndex = int.Parse(set.Tables[0].Rows[0]["type"].ToString()) - 4;
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                        this.Txt_Status.Text = ((bool)set.Tables[0].Rows[0]["Status"]) ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                        this.btn_Delete.Text = ((bool)set.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                    }
                }
            }
        }

        private void Txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.string_0 = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải', Status FROM " + base.Tag.ToString() + " WHERE Type > '02' ";
                Class7.BrowserForm(this.string_0, this.oleDbConnection_0);
                this.Txt_Id.Text = FrmBrowse.strReturn;
                this.Txt_Id.SelectAll();
            }
        }
    }
}