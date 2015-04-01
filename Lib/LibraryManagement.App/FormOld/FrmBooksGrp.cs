﻿using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmBooksGrp : DevExpress.XtraEditors.XtraForm
    {
        public FrmBooksGrp()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            object text = this.Txt_Id.Text;
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
            this.IjSwogAv6.Focus();
            this.string_0 = "E";
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
            this.Txt_Id.Text = Class7.smethod_9(base.Tag.ToString(), "{0:0000}", this.oleDbConnection_0);
            this.IjSwogAv6.Focus();
            this.string_0 = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.Txt_Id.Enabled = true;
            this.Txt_Id.Focus();
            this.string_0 = "S";
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "D";
        }


        private void FrmBooksGrp_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd thể loại s\x00e1ch";
            base.Tag = "tblGoodsGrp";
            this.btn_Skip_Click(this, new EventArgs());
        }

        private void method_0()
        {
            DataSet set;
            string str = this.Txt_Id.Text.Trim();
            string str2 = this.IjSwogAv6.Text.Trim();
            string selectCommandText = null;
            switch (this.string_0)
            {
                case "N":
                    if (Class7.smethod_18(base.Tag.ToString(), "Description", str2))
                    {
                        Class7.ShowMessageBox("Nh\x00f3m h\x00e0ng n\x00e0y đ\x00e3 được đăng k\x00fd", 1);
                    }
                    else
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        selectCommandText = "INSERT INTO " + base.Tag.ToString() + "(id, Description,status) VALUES('" + str + "',N'" + str2 + "',1 )";
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
                    selectCommandText = ("UPDATE " + base.Tag.ToString() + " SET Description =N'" + str2 + "' ") + " WHERE ID = '" + str + "' ";
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
                    this.IjSwogAv6.Text = dataSet.Tables[0].Rows[0]["Description"].ToString();
                    this.Txt_Status.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                    Class11.smethod_3(this);
                    Class11.smethod_5(this, "F");
                    this.btn_Delete.Text = ((bool)dataSet.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                }
            }
        }

        private void Txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F5) && (Class11.string_0 == "S"))
            {
                Class7.BrowserForm("select Id as 'M\x00e3 số', Description AS 'Diễn giải', Status from " + base.Tag.ToString(), this.oleDbConnection_0);
                this.Txt_Id.Text = FrmBrowse.strReturn;
            }
        }
  
    }
}