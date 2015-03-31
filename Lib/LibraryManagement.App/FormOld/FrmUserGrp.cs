using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmUserGrp : DevExpress.XtraEditors.XtraForm
    {
        public FrmUserGrp()
        {
            InitializeComponent();
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter;
            DataSet set;
            string str = this.IjSwogAv6.Text.Trim();
            string text = this.btn_Delete.Text;
            if ((text != null) && (text == "&X\x00f3a"))
            {
                if (Class7.smethod_15("Bạn chắc chắn muốn x\x00f3a nh\x00f3m n\x00e0y ? ", 2) == 1)
                {
                    adapter = new OleDbDataAdapter("UPDATE " + base.Tag.ToString() + " SET Status = 0 WHERE ID = '" + str + "' ", Class7.oleDbConnection_1);
                    set = new DataSet();
                    adapter.Fill(set);
                    Class7.oleDbConnection_1.Close();
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.smethod_15("Bạn chắc chắn muốn phục hồi nh\x00f3m n\x00e0y ? ", 2) == 1)
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
                Class7.string_2 = this.Txt_Name.Text;
                new FrmUserGrpMng().ShowDialog();
                this.btn_Save_Click(this, new EventArgs());
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_1(this);
            Class11.smethod_8(this);
            Class11.smethod_5(this, "T");
            this.IjSwogAv6.Text = Class7.smethod_9(base.Tag.ToString(), "{0:00}", Class7.oleDbConnection_1);
            this.Txt_Name.Focus();
        }

        private void btn_ReportRight_Click(object sender, EventArgs e)
        {
            Class11.string_1 = "GRP";
            Class7.string_0 = this.IjSwogAv6.Text.Trim();
            new FrmUserReport().ShowDialog();
            this.btn_Save_Click(this, new EventArgs());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string str = this.Txt_Name.Text.Trim();
            string str2 = this.Txt_Description.Text.Trim();
            string str3 = this.IjSwogAv6.Text.Trim();
            if (string.IsNullOrEmpty(str) | string.IsNullOrEmpty(str2))
            {
                Class7.smethod_15("Th\x00f4ng tin khai b\x00e1o chưa đầy đủ.", 1);
            }
            else
            {
                string str5 = Class11.string_0;
                if (str5 != null)
                {
                    OleDbDataAdapter adapter;
                    DataSet set;
                    if (!(str5 == "N"))
                    {
                        if (str5 == "E")
                        {
                            this.iWyIskLbe(this, new EventArgs());
                            adapter = new OleDbDataAdapter(("UPDATE tblUserGrp SET Name = '" + str + "',Descript =N'" + str2 + "' ") + "WHERE ID = '" + str3 + "' ", Class7.oleDbConnection_1);
                            set = new DataSet();
                            adapter.Fill(set);
                            Class7.oleDbConnection_1.Close();
                        }
                    }
                    else if (Class7.smethod_18(base.Tag.ToString(), "Name", str))
                    {
                        Class7.smethod_15("T\x00ean nh\x00f3m đ\x00e3 được sử dụng", 1);
                        this.Txt_Name.Focus();
                    }
                    else
                    {
                        this.iWyIskLbe(this, new EventArgs());
                        adapter = new OleDbDataAdapter("insert into tblUserGrp (id, Name,Descript )  values ('" + str3 + "','" + str + "',N'" + str2 + "')", Class7.oleDbConnection_1);
                        set = new DataSet();
                        adapter.Fill(set);
                        Class7.oleDbConnection_1.Close();
                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_8(this);
            this.IjSwogAv6.Enabled = true;
            Class7.smethod_16("select Id AS 'M\x00e3 số', Name as 'T\x00ean nh\x00f3m', Descript as 'Diễn giải', Status from " + base.Tag.ToString(), Class7.oleDbConnection_1);
            this.IjSwogAv6.Text = FrmBrowse.strReturn;
            this.IjSwogAv6.Focus();
        }


        private void FrmUserGrp_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd nh\x00f3m người sử dụng";
            base.Tag = "tblUserGrp";
            this.iWyIskLbe(this, new EventArgs());
            Class11.smethod_8(this);
            this.btn_New.Enabled = Class7.smethod_50();
            this.btn_Search.Enabled = Class7.smethod_50();
        }

        private void IjSwogAv6_EditValueChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM tblUserGrp WHERE ID = '" + this.IjSwogAv6.Text.Trim() + "'", Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Txt_Name.Text = dataSet.Tables[0].Rows[0]["Name"].ToString();
                this.Txt_Description.Text = dataSet.Tables[0].Rows[0]["Descript"].ToString();
                this.Txt_Status.Text = (dataSet.Tables[0].Rows[0]["Status"].ToString() == "True") ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                Class11.smethod_3(this);
                Class11.smethod_5(this, "F");
                this.btn_Delete.Text = (dataSet.Tables[0].Rows[0]["Status"].ToString() == "True") ? "&X\x00f3a" : "&Phục hồi";
            }
        }

        private void IjSwogAv6_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F5) & (Class11.string_0 == "S"))
            {
                Class7.smethod_16("select Id AS 'M\x00e3 số', Name as 'T\x00ean nh\x00f3m', Descript as 'Diễn giải', Status from " + base.Tag.ToString(), Class7.oleDbConnection_1);
                this.IjSwogAv6.Text = FrmBrowse.strReturn;
            }
        }



        private void iWyIskLbe(object sender, EventArgs e)
        {
            Class11.smethod_0(this);
            Class11.smethod_5(this, "F");
        }
   
    }
}