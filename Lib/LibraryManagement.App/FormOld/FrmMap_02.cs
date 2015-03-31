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
    public partial class FrmMap_02 : DevExpress.XtraEditors.XtraForm
    {
        public FrmMap_02()
        {
            InitializeComponent();
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_SecondLevel.Enabled = false;
            this.Txt_VnName.Focus();
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
            this.Lbl_FirstLevel.Text = string.Empty;
            this.Txt_SecondLevel.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string str = this.Txt_SecondLevel.Text.Trim();
            string str2 = this.Txt_VnName.Text.Trim();
            string str3 = this.Txt_EngName.Text.Trim();
            if (this.Lbl_FstLevelName.Text == string.Empty)
            {
                Class7.smethod_15("M\x00e3 t\x00e0i khoản cấp 1 kh\x00f4ng tồn tại", 1);
                this.Txt_SecondLevel.Focus();
            }
            else if (str2 == string.Empty)
            {
                Class7.smethod_15("Bạn chưa đăng k\x00fd t\x00ean t\x00e0i khoản cấp 2", 1);
                this.Txt_VnName.Focus();
            }
            else
            {
                DataSet set;
                if (this.string_1 == "N")
                {
                    if (Class7.smethod_18(base.Tag.ToString(), "mof_gl", str))
                    {
                        Class7.smethod_15("M\x00e3 cấp 2 n\x00e0y đ\x00e3 được đăng k\x00fd", 1);
                        this.Txt_SecondLevel.Focus();
                        return;
                    }
                    this.btn_Skip_Click(this, new EventArgs());
                    this.string_0 = "INSERT INTO tblMof_sys (mof_gl, mof_name, mof_nameb, ac_type, [glevel], last_level)  VALUES ('" + str + "',N'" + str2 + "',N'" + str3 + "','A',2,0) ";
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
            this.Lbl_FirstLevel.Text = string.Empty;
            this.Txt_SecondLevel.Enabled = true;
            this.Txt_SecondLevel.Focus();
            this.string_1 = "S";
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.smethod_0(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }

        private void FrmMap_02_Load(object sender, EventArgs e)
        {
            this.btn_Skip_Click(this, new EventArgs());
            base.Tag = "tblMof_sys";
            this.Text = "Tạo t\x00e0i khoản cấp 2";
        }


        private void Lbl_FirstLevel_TextChanged(object sender, EventArgs e)
        {
            this.string_0 = "select mof_gl, mof_name, mof_nameb FROM " + base.Tag.ToString() + " where glevel = 1 and mof_gl = '" + this.Lbl_FirstLevel.Text + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    this.Lbl_FstLevelName.Text = set.Tables[0].Rows[0]["mof_name"].ToString();
                    this.Lbl_FstLevelEName.Text = set.Tables[0].Rows[0]["mof_nameb"].ToString();
                }
                else
                {
                    this.Lbl_FstLevelName.Text = string.Empty;
                    this.Lbl_FstLevelEName.Text = string.Empty;
                }
            }
        }

        private void Txt_SecondLevel_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_SecondLevel.Text.Trim();
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
                        this.Lbl_FirstLevel.Text = this.Txt_SecondLevel.Text.Substring(0, 1);
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

        private void Txt_SecondLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F5) && (this.string_1 == "S"))
            {
                this.string_0 = "select mof_gl, mof_name, mof_nameb FROM " + base.Tag.ToString() + " where glevel = 2 ";
                Class7.smethod_16(this.string_0, this.oleDbConnection_0);
                this.Txt_SecondLevel.Text = FrmBrowse.strReturn;
            }
        }

        private void Txt_SecondLevel_Validated(object sender, EventArgs e)
        {
            if (this.Txt_SecondLevel.Text.Length >= 3)
            {
                string str = this.Txt_SecondLevel.Text.Substring(0, 1);
                this.Lbl_FirstLevel.Text = str;
            }
        }
   
    }
}