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
    public partial class FrmMap_03 : DevExpress.XtraEditors.XtraForm
    {
        public FrmMap_03()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_ThirdLevel.Enabled = false;
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
            this.Lbl_SecondLevel.Text = string.Empty;
            this.Lbl_FstLevel.Text = string.Empty;
            this.Txt_ThirdLevel.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string str = this.Txt_ThirdLevel.Text.Trim();
            string str2 = this.Txt_VnName.Text.Trim();
            string str3 = this.Txt_EngName.Text.Trim();
            string str4 = this.cmb_Negative.Text.Substring(0, 1);
            string text = this.Txt_OtherEqui.Text;
            if (this.Lbl_SndLevelName.Text == string.Empty)
            {
                Class7.smethod_15("M\x00e3 t\x00e0i khoản cấp 2 kh\x00f4ng tồn tại", 1);
                this.Txt_ThirdLevel.Focus();
            }
            else if (this.Lbl_FstLevelName.Text == string.Empty)
            {
                Class7.smethod_15("M\x00e3 t\x00e0i khoản cấp 1 kh\x00f4ng tồn tại", 1);
                this.Txt_ThirdLevel.Focus();
            }
            else if (str2 == string.Empty)
            {
                Class7.smethod_15("Bạn chưa đăng k\x00fd t\x00ean t\x00e0i khoản cấp 3", 1);
                this.Txt_VnName.Focus();
            }
            else if (this.cmb_Negative.SelectedIndex == -1)
            {
                Class7.smethod_15("Bạn chưa đăng k\x00fd loại số dư", 1);
                this.cmb_Negative.SelectedIndex = 0;
            }
            else
            {
                DataSet set;
                if (this.string_1 == "N")
                {
                    if (Class7.smethod_18(base.Tag.ToString(), "mof_gl", str))
                    {
                        Class7.smethod_15("M\x00e3 cấp 3 n\x00e0y đ\x00e3 được đăng k\x00fd", 1);
                        this.Txt_ThirdLevel.Focus();
                        return;
                    }
                    this.btn_Skip_Click(this, new EventArgs());
                    this.string_0 = "INSERT INTO tblMof_sys (mof_gl, mof_name, mof_nameb, ac_type, [glevel], last_level,master,negative,other_equi)  VALUES ('" + str + "',N'" + str2 + "',N'" + str3 + "','A',3,0,0,'" + str4 + "','" + text + "') ";
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
                    this.string_0 = "UPDATE    tblMof_sys SET   mof_name =N'" + str2 + "', mof_nameb =N'" + str3 + "', negative = '" + str4 + "', other_equi = '" + text + "' where mof_gl = '" + str + "'";
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
            this.Lbl_SecondLevel.Text = string.Empty;
            this.Lbl_FstLevel.Text = string.Empty;
            this.Txt_ThirdLevel.Enabled = true;
            this.Txt_ThirdLevel.Focus();
            this.string_1 = "S";
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.smethod_0(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }


        private void FrmMap_03_Load(object sender, EventArgs e)
        {
            this.btn_Skip_Click(this, new EventArgs());
            base.Tag = "tblMof_sys";
            this.Text = "Tạo t\x00e0i khoản cấp 3";
        }



        private void Lbl_FstLevel_Click(object sender, EventArgs e)
        {
        }

        private void Lbl_FstLevel_TextChanged(object sender, EventArgs e)
        {
            this.string_0 = "select mof_gl, mof_name, mof_nameb FROM " + base.Tag.ToString() + " where glevel = 1 and mof_gl = '" + this.Lbl_FstLevel.Text + "' ";
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

        private void Lbl_SecondLevel_TextChanged(object sender, EventArgs e)
        {
            this.string_0 = "select mof_gl, mof_name, mof_nameb FROM " + base.Tag.ToString() + " where glevel = 2 and mof_gl = '" + this.Lbl_SecondLevel.Text + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    this.Lbl_SndLevelName.Text = set.Tables[0].Rows[0]["mof_name"].ToString();
                    this.Lbl_SndLevelEName.Text = set.Tables[0].Rows[0]["mof_nameb"].ToString();
                }
                else
                {
                    this.Lbl_SndLevelName.Text = string.Empty;
                    this.Lbl_SndLevelEName.Text = string.Empty;
                }
            }
        }

        private void Txt_ThirdLevel_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_ThirdLevel.Text.Trim();
            if (this.string_1 == "S")
            {
                this.string_0 = "select mof_gl, mof_name, mof_nameb, negative, other_equi FROM " + base.Tag.ToString() + " where mof_gl = '" + str + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        goto Label_0220;
                    }
                    this.Txt_VnName.Text = set.Tables[0].Rows[0]["mof_name"].ToString();
                    this.Txt_EngName.Text = set.Tables[0].Rows[0]["mof_nameb"].ToString();
                    this.Txt_OtherEqui.Text = set.Tables[0].Rows[0]["other_equi"].ToString();
                    string str2 = set.Tables[0].Rows[0]["negative"].ToString();
                    switch (str2)
                    {
                        case null:
                            break;

                        case "Y":
                            this.cmb_Negative.SelectedIndex = 0;
                            goto Label_01D3;

                        default:
                            if (!(str2 == "N"))
                            {
                                if (!(str2 == "C"))
                                {
                                    break;
                                }
                                this.cmb_Negative.SelectedIndex = 2;
                            }
                            else
                            {
                                this.cmb_Negative.SelectedIndex = 1;
                            }
                            goto Label_01D3;
                    }
                    this.cmb_Negative.SelectedIndex = -1;
                Label_01D3:
                    Class11.smethod_3(this);
                    Class11.smethod_5(this, "F");
                    this.Lbl_FstLevel.Text = this.Txt_ThirdLevel.Text.Substring(0, 1);
                    this.Lbl_SecondLevel.Text = this.Txt_ThirdLevel.Text.Substring(0, 3);
                    return;
                Label_0220:
                    this.Txt_VnName.Text = "";
                    this.Txt_EngName.Text = "";
                }
            }
        }

        private void Txt_ThirdLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F5) && (this.string_1 == "S"))
            {
                this.string_0 = "select mof_gl, mof_name, mof_nameb FROM " + base.Tag.ToString() + " where glevel = 3 ";
                Class7.smethod_16(this.string_0, this.oleDbConnection_0);
                this.Txt_ThirdLevel.Text = FrmBrowse.strReturn;
            }
        }

        private void Txt_ThirdLevel_Validated(object sender, EventArgs e)
        {
            if ((this.string_1 == "N") && (this.Txt_ThirdLevel.Text.Length >= 4))
            {
                string str = this.Txt_ThirdLevel.Text.Substring(0, 1);
                string str2 = this.Txt_ThirdLevel.Text.Substring(0, 3);
                this.Lbl_FstLevel.Text = str;
                this.Lbl_SecondLevel.Text = str2;
                this.string_0 = "select mof_gl, mof_name, mof_nameb FROM " + base.Tag.ToString() + " where glevel = 3 and mof_gl = '" + this.Txt_ThirdLevel.Text.Trim() + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        Class7.smethod_15("M\x00e3 t\x00e0i khoản cấp 3 đ\x00e3 được đăng k\x00fd", 1);
                        this.Txt_ThirdLevel.Focus();
                    }
                }
            }
        }
  
    }
}