using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmMap_01 : DevExpress.XtraEditors.XtraForm
    {
        public FrmMap_01()
        {
            InitializeComponent();
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
            this.Txt_FirstLevel.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string str = this.Txt_FirstLevel.Text.Trim();
            string str2 = this.Txt_VnName.Text.Trim();
            string str3 = this.Txt_EngName.Text.Trim();
            if (str2 == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa đăng k\x00fd t\x00ean t\x00e0i khoản cấp 1", 1);
                this.Txt_VnName.Focus();
            }
            else
            {
                DataSet set;
                if (this.string_1 == "N")
                {
                    if (Class7.smethod_18(base.Tag.ToString(), "mof_gl", str))
                    {
                        Class7.ShowMessageBox("M\x00e3 cấp 1 n\x00e0y đ\x00e3 được đăng k\x00fd", 1);
                        this.Txt_FirstLevel.Focus();
                        return;
                    }
                    this.btn_Skip_Click(this, new EventArgs());
                    this.string_0 = "INSERT INTO tblMof_sys (mof_gl, mof_name, mof_nameb, ac_type, [glevel], last_level)  VALUES ('" + str + "',N'" + str2 + "',N'" + str3 + "','A',1,0) ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        return;
                    }
                }
                if (this.string_1 == "E")
                {
                    this.btn_Skip_Click(this, new EventArgs());
                    this.string_0 = "UPDATE    tblMof_sys SET   mof_name =N'" + str2 + "', mof_nameb =N'" + str3 + "' where mof_gl = '" + str + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
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
            this.Txt_FirstLevel.Enabled = true;
            this.Txt_FirstLevel.Focus();
            this.string_1 = "S";
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }


        private void FrmMap_01_Load(object sender, EventArgs e)
        {
            this.btn_Skip_Click(this, new EventArgs());
            base.Tag = "tblMof_sys";
            this.Text = "Tạo t\x00e0i khoản cấp 1";
        }



        private void Txt_FirstLevel_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_FirstLevel.Text.Trim();
            if (this.string_1 == "S")
            {
                this.string_0 = "select mof_gl, mof_name, mof_nameb FROM " + base.Tag.ToString() + " where mof_gl = '" + str + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_VnName.Text = set.Tables[0].Rows[0]["mof_name"].ToString();
                        this.Txt_EngName.Text = set.Tables[0].Rows[0]["mof_nameb"].ToString();
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                    }
                    else
                    {
                        this.Txt_VnName.Text = "";
                        this.Txt_EngName.Text = "";
                    }
                }
            }
        }

        private void Txt_FirstLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F5) && (this.string_1 == "S"))
            {
                this.string_0 = "select mof_gl, mof_name, mof_nameb FROM " + base.Tag.ToString() + " where glevel = 1 ";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_FirstLevel.Text = BrowseForm.strReturn;
            }
        }

    }
}