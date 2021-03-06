using DevExpress.Utils;
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
    public partial class LibraryLocationForm : XtraForm
    {
        public LibraryLocationForm()
        {
            InitializeComponent();
            this.oleDbConnection_0 = DataProvider.GetConnection();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            object text = this.txtSymbol.Text;
            string str = this.btn_Delete.Text;
            if ((str != null) && (str == "&X\x00f3a"))
            {
                if (Class7.ShowMessageBox("Bạn chắc chắn muốn x\x00f3a k\x00fd hiệu n\x00e0y ? ", 2) == 1)
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "id", text.ToString(), "", this.oleDbConnection_0);
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.ShowMessageBox("Bạn chắc chắn muốn phục hồi k\x00fd hiệu n\x00e0y ? ", 2) == 1)
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
            this.string_1 = "E";
            this.txtStkId.Enabled = false;
            this.txtSymbol.Enabled = false;
            this.txtDescription.Focus();
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
            this.string_1 = "N";
            this.txtStkId.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.lblStkName.Text))
            {
                Class7.ShowMessageBox("Bạn chưa chọn kho/quầy", 1);
                this.txtStkId.Focus();
            }
            else if (string.IsNullOrEmpty(this.txtSymbol.Text))
            {
                Class7.ShowMessageBox("Bạn chưa nhập k\x00fd hiệu", 1);
                this.txtSymbol.Focus();
            }
            else
            {
                string str2 = this.txtStkId.Text.Trim();
                string str3 = this.txtSymbol.Text.Trim();
                string str4 = this.txtDescription.Text.Trim();
                string str = this.string_1;
                if (str != null)
                {
                    if (!(str == "N"))
                    {
                        if (str == "E")
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            this.string_0 = "UPDATE " + base.Tag.ToString() + " SET stk_id = '" + str2 + "',description = N'" + str4 + "'  WHERE loc_id = '" + str3 + "'";
                            Class7.smethod_4(this.string_0);
                        }
                    }
                    else if (Class7.smethod_18(base.Tag.ToString(), "loc_id", str3))
                    {
                        Class7.ShowMessageBox("K\x00fd hiệu n\x00e0y đ\x00e3 được đăng k\x00fd", 1);
                    }
                    else
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        this.string_0 = "INSERT INTO " + base.Tag.ToString() + "(stk_id, loc_id, description, status)VALUES('" + str2 + "','" + str3 + "',N'" + str4 + "',1)";
                        Class7.smethod_4(this.string_0);
                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.txtSymbol.Enabled = true;
            this.txtSymbol.Focus();
            this.string_1 = "S";
            Class7.BrowserForm1("select loc_id AS [M\x00e3 kệ], stk_id as [Thư viện/Kho], Description AS [Diễn giải], Status from " + base.Tag.ToString(), this.oleDbConnection_0);
            this.txtSymbol.Text = BrowseForm.strReturn;
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }



        private void FrmLibraryLoc_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd kệ s\x00e1ch";
            base.Tag = "tblLocation";
            this.btn_Skip_Click(this, new EventArgs());
        }



        private void txtStkId_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtStkId.Text))
            {
                this.lblStkName.Text = Class7.smethod_29("tblStore", "fullname", "Id", this.txtStkId.Text, "and type IN('02','01') and status = 1", this.oleDbConnection_0).ToString();
            }
        }

        private void txtStkId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('01','02') and status = 1";
                Class7.BrowserForm1(str, this.oleDbConnection_0);
                this.txtStkId.Text = BrowseForm.strReturn;
                this.txtStkId.SelectAll();
            }
        }

        private void txtSymbol_EditValueChanged(object sender, EventArgs e)
        {
            if (!((this.string_1 != "S") | (this.txtSymbol.Text == string.Empty)))
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM " + base.Tag.ToString() + " WHERE loc_id = '" + this.txtSymbol.Text.Trim() + "' ", this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_0.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    this.txtStkId.Text = dataSet.Tables[0].Rows[0]["stk_id"].ToString();
                    this.txtDescription.Text = dataSet.Tables[0].Rows[0]["Description"].ToString();
                    this.Txt_Status.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                    Class11.smethod_3(this);
                    Class11.smethod_5(this, "F");
                    this.btn_Delete.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                }
            }
        }

        private void txtSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("select loc_id AS [M\x00e3 kệ], stk_id as [Quầy/Kho], Description AS [Diễn giải], Status from " + base.Tag.ToString(), this.oleDbConnection_0);
                this.txtSymbol.Text = BrowseForm.strReturn;
            }
        }
    }
}