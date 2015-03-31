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
    public partial class FrmStations : DevExpress.XtraEditors.XtraForm
    {
        public FrmStations()
        {
            InitializeComponent();
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string text = this.btn_Delete.Text;
            if ((text != null) && (text == "&X\x00f3a"))
            {
                if (Class7.smethod_15("Bạn chắc chắn muốn x\x00f3a trạm n\x00e0y ? ", 2) == 1)
                {
                    this.RrqIxZxw5(this, new EventArgs());
                    Class7.smethod_23(base.Tag.ToString(), 0, "id", this.Txt_Id.Text.Trim(), "", this.oleDbConnection_0);
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.smethod_15("Bạn chắc chắn muốn phục hồi trạm n\x00e0y ? ", 2) == 1)
            {
                this.RrqIxZxw5(this, new EventArgs());
                Class7.smethod_23(base.Tag.ToString(), 1, "id", this.Txt_Id.Text.Trim(), "", this.oleDbConnection_0);
                this.Txt_Status.Text = "Đang hoạt động";
                this.btn_Delete.Text = "&X\x00f3a";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_5(this, "T");
            Class11.smethod_4(this);
            this.string_1 = "E";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_5(this, "T");
            Class11.smethod_1(this);
            Class11.smethod_8(this);
            this.Txt_Id.Text = Class7.smethod_9(base.Tag.ToString(), "{0:n0}", this.oleDbConnection_0);
            this.Cmb_StationList.Enabled = false;
            this.string_1 = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if ((this.Txt_StationName.Text == string.Empty) | (this.Txt_Description.Text == string.Empty))
            {
                Class7.smethod_15("Bạn chưa nhập đủ th\x00f4ng tin", 1);
            }
            else
            {
                object obj2;
                DataSet set;
                if (this.Cmb_Stock.SelectedIndex == -1)
                {
                    this.Cmb_Stock.SelectedIndex = 0;
                }
                string str3 = this.Txt_StationName.Text.Trim();
                string str4 = this.Txt_Description.Text.Trim();
                string str5 = this.Cmb_Stock.Text.Trim();
                int num2 = int.Parse(this.Txt_Id.Text);
                int selectedIndex = 0;
                if (this.Chk_Printer.Checked)
                {
                    selectedIndex = 3;
                }
                else
                {
                    selectedIndex = this.Cmb_PrnPorts.SelectedIndex;
                }
                string selectCommandText = null;
                switch (this.string_1)
                {
                    case "N":
                        if (Class7.smethod_18(base.Tag.ToString(), "Name", str3))
                        {
                            Class7.smethod_15("T\x00ean trạm đ\x00e3 được đăng k\x00fd, đề nghị kiểm tra lại", 1);
                        }
                        else
                        {
                            this.RrqIxZxw5(this, new EventArgs());
                            obj2 = "INSERT INTO " + base.Tag.ToString() + "(id, name,Description, login, user_id,pos_id,prnport, Status) ";
                            obj2 = string.Concat(new object[] { obj2, "VALUES(", num2, ",N'", str3, "'," });
                            selectCommandText = string.Concat(new object[] { obj2, "N'", str4, "',0,0 ,'", str5, "',", selectedIndex, ",1)" });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                            }
                            this.oleDbConnection_0.Close();
                        }
                        break;

                    case "E":
                        this.RrqIxZxw5(this, new EventArgs());
                        obj2 = "UPDATE " + base.Tag.ToString() + " SET Description =N'" + str4 + "',pos_id = '" + str5 + "', ";
                        selectCommandText = string.Concat(new object[] { obj2, "prnport = ", selectedIndex, " WHERE ID = ", num2, " " });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
                        this.oleDbConnection_0.Close();
                        break;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_8(this);
            Class11.smethod_9("tblStations", "name", "", this.Cmb_StationList, 0, this.oleDbConnection_0);
            Class11.smethod_5(this, "T");
            this.string_1 = "S";
        }

        private void Cmb_StationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.string_1 == "S")
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM " + base.Tag.ToString() + " WHERE name = '" + this.Cmb_StationList.Text + "' ", this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    this.Txt_Id.Text = dataSet.Tables[0].Rows[0]["Id"].ToString();
                    this.Txt_StationName.Text = dataSet.Tables[0].Rows[0]["name"].ToString();
                    this.Txt_Description.Text = dataSet.Tables[0].Rows[0]["Description"].ToString();
                    this.Txt_Status.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                    this.Cmb_Stock.Text = dataSet.Tables[0].Rows[0]["pos_id"].ToString();
                    this.Chk_Printer.Checked = dataSet.Tables[0].Rows[0]["prnport"].ToString() == "3";
                    if (!this.Chk_Printer.Checked)
                    {
                        this.Cmb_PrnPorts.SelectedIndex = (int)dataSet.Tables[0].Rows[0]["prnport"];
                    }
                    Class11.smethod_3(this);
                    Class11.smethod_5(this, "F");
                }
                else
                {
                    this.Txt_Id.Text = string.Empty;
                    this.Txt_StationName.Text = string.Empty;
                    this.Txt_Description.Text = string.Empty;
                }
            }
        }

        private void Cmb_Stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("fullname", "tblstore", "id", this.Cmb_Stock.Text.Trim(), "", this.oleDbConnection_0, ref str);
            this.Lbl_Stock.Text = str;
        }

        private void Cmb_Stock_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("fullname", "tblstore", "id", this.Cmb_Stock.Text.Trim(), "", this.oleDbConnection_0, ref str);
            this.Lbl_Stock.Text = str;
        }

        private void FrmStations_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd trạm l\x00e0m việc";
            base.Tag = "tblStations";
            this.RrqIxZxw5(this, new EventArgs());
            Class11.smethod_8(this);
            Class11.smethod_9("tblStations", "name", "", this.Cmb_StationList, 0, this.oleDbConnection_0);
            Class11.smethod_9("tblStore", "Id", "where status = 1 and type = '01'", this.Cmb_Stock, 0, this.oleDbConnection_0);
            this.btn_New.Enabled = Class7.smethod_50();
            this.btn_Search.Enabled = Class7.smethod_50();
        }



        private void RrqIxZxw5(object sender, EventArgs e)
        {
            Class11.smethod_0(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            if (((this.string_1 != "D") || (this.string_1 != "F")) || (this.string_1 != "S"))
            {
                this.Cmb_PrnPorts.Enabled = !this.Chk_Printer.Checked;
            }
        }
   
    }
}