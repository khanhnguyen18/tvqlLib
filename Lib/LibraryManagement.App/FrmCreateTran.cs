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
    public partial class FrmCreateTran : DevExpress.XtraEditors.XtraForm
    {
        public FrmCreateTran()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class7.smethod_15("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
            {
                string text = this.btn_Delete.Text;
                if ((text != null) && (text == "&X\x00f3a"))
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "trans_code", this.txtId.Text.Trim(), "", this.oleDbConnection_0);
                    this.btn_Delete.Text = "&Phục hồi";
                }
                else
                {
                    Class7.smethod_23(base.Tag.ToString(), 1, "trans_code", this.txtId.Text.Trim(), "", this.oleDbConnection_0);
                    this.btn_Delete.Text = "&X\x00f3a";
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.txtDescription.Focus();
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
            this.txtId.Enabled = true;
            this.txtId.Focus();
            this.string_0 = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string str = this.txtId.Text.Trim();
            string str2 = this.txtDescription.Text.Trim();
            string str3 = null;
            string str4 = "avoucher";
            if (str2 == string.Empty)
            {
                Class7.smethod_15("Bạn chưa khai b\x00e1o diễn giải giao dịch", 1);
                this.txtDescription.Focus();
            }
            else
            {
                switch (this.cmbTranType.SelectedIndex)
                {
                    case 0:
                        str3 = "FrmTran_1_1";
                        break;

                    case 1:
                        str3 = "FrmTran_n_1";
                        break;

                    case 2:
                        str3 = "FrmTran_1_n";
                        break;

                    case 3:
                        str3 = "FrmCashIO";
                        break;

                    case -1:
                        Class7.smethod_15("Bạn chưa chọn loại giao dịch", 1);
                        this.cmbTranType.Focus();
                        return;
                }
                string str5 = this.string_0;
                if (str5 != null)
                {
                    if (str5 != "N")
                    {
                        if (!(str5 == "E"))
                        {
                            return;
                        }
                        this.btn_Skip_Click(this, new EventArgs());
                        this.kCnalMegv = "UPDATE " + base.Tag.ToString() + " SET trans_name =N'" + str2 + "',form = '" + str3 + "'  WHERE trans_code = '" + str + "' ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.kCnalMegv, this.oleDbConnection_0);
                        using (DataSet set2 = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set2);
                            this.oleDbConnection_0.Close();
                            return;
                        }
                    }
                    if (Class7.smethod_18(base.Tag.ToString(), "trans_code", str))
                    {
                        Class7.smethod_15("K\x00fd hiệu n\x00e0y đ\x00e3 được đăng k\x00fd", 1);
                    }
                    else
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        this.kCnalMegv = "INSERT INTO " + base.Tag.ToString() + "(trans_code, trans_name, status, form, fvoucher, tr_type) VALUES('" + str + "',N'" + str2 + "',1,'" + str3 + "','" + str4 + "','01')";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.kCnalMegv, this.oleDbConnection_0);
                        using (DataSet set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
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
            this.txtId.Enabled = true;
            this.txtId.Focus();
            this.string_0 = "S";
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.smethod_0(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "D";
        }

        private void FrmCreateTran_Load(object sender, EventArgs e)
        {
            base.Tag = "tblAtrcode";
            this.Text = "Đăng k\x00fd giao dịch kế to\x00e1n";
            this.btn_Skip_Click(this, new EventArgs());
        }



        private void txtId_EditValueChanged(object sender, EventArgs e)
        {
            if (this.string_0 == "S")
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + base.Tag.ToString() + " where trans_code = '" + this.txtId.Text + "'", this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.txtDescription.Text = set.Tables[0].Rows[0]["trans_name"].ToString();
                        string str = set.Tables[0].Rows[0]["form"].ToString();
                        switch (str)
                        {
                            case null:
                                break;

                            case "FrmTran_1_1":
                                this.cmbTranType.SelectedIndex = 0;
                                break;

                            case "FrmTran_n_1":
                                this.cmbTranType.SelectedIndex = 1;
                                break;

                            default:
                                if (!(str == "FrmTran_1_n"))
                                {
                                    if (str == "FrmCashIO")
                                    {
                                        this.cmbTranType.SelectedIndex = 3;
                                    }
                                }
                                else
                                {
                                    this.cmbTranType.SelectedIndex = 2;
                                }
                                break;
                        }
                        this.Txt_Status.Text = ((bool)set.Tables[0].Rows[0]["Status"]) ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                        this.btn_Delete.Text = ((bool)set.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                    }
                }
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Class7.smethod_16("select trans_code, trans_name, status from " + base.Tag.ToString(), this.oleDbConnection_0);
                this.txtId.Text = FrmBrowse.strReturn;
            }
        }
    }
}