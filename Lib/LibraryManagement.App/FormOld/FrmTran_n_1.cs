using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmTran_n_1 : DevExpress.XtraEditors.XtraForm
    {
        public FrmTran_n_1()
        {
            InitializeComponent();
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.string_0 = "E";
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
            Class6 class2 = new Class6();
            this.Txt_TranDate.Text = Class7.smethod_19();
            this.Txt_TransNum.Text = class2.method_5("A");
            this.string_0 = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(Class7.smethod_19()).Subtract(DateTime.ParseExact(this.Txt_TranDate.Text, "dd/MM/yyyy", null)).TotalDays < 0.0)
            {
                Class7.ShowMessageBox("Ng\x00e0y hiệu lực kh\x00f4ng thể chọn trong tương lai", 1);
                this.Txt_TranDate.Focus();
            }
            else if (this.Txt_Voucher.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o số chứng từ", 1);
                this.Txt_Voucher.Focus();
            }
            else if (this.Txt_Remark.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o diễn giải giao dịch", 1);
                this.Txt_Remark.Focus();
            }
            else if (Class7.smethod_0(this.Txt_CreAmt1.Text) <= 0.0)
            {
                Class7.ShowMessageBox("Số tiền kh\x00f4ng hợp lệ", 1);
                this.Txt_CreAmt1.Focus();
            }
            else if (this.Lbl_DebAccName.Text == string.Empty)
            {
                Class7.ShowMessageBox("T\x00e0i khoản ghi nợ kh\x00f4ng hợp lệ", 1);
                this.Txt_DebAccId.Focus();
            }
            else
            {
                string str = this.string_0;
                if ((str != null) && (str == "N"))
                {
                    this.btn_Skip_Click(this, new EventArgs());
                    string str3 = string.Format("{0:MM/dd/yyyy}", this.Txt_TranDate.EditValue);
                    string str4 = this.Txt_Voucher.Text.Trim();
                    string str5 = this.Txt_DebAccId.EditValue.ToString();
                    double num2 = Class7.smethod_0(this.Txt_CreAmt1.Text);
                    double num3 = Class7.smethod_0(this.Txt_CreAmt2.Text);
                    double num = Class7.smethod_0(this.Txt_CreAmt3.Text);
                    string str6 = this.Txt_Remark.Text.Trim();
                    string str2 = this.Txt_TransNum.Text.Trim();
                    Class12.smethod_3(str2, str3, str4, str5, num2, 0.0, this.Txt_CreAccId1.EditValue.ToString(), str6, 2);
                    Class12.smethod_3(str2, str3, str4, this.Txt_CreAccId1.EditValue.ToString(), 0.0, num2, str5, str6, 1);
                    if ((num3 > 0.0) && (this.Lbl_CreAccName2.Text != string.Empty))
                    {
                        Class12.smethod_3(str2, str3, str4, str5, num3, 0.0, this.Txt_CreAccId2.EditValue.ToString(), str6, 4);
                        Class12.smethod_3(str2, str3, str4, this.Txt_CreAccId2.EditValue.ToString(), 0.0, num3, str5, str6, 3);
                    }
                    if ((num > 0.0) && (this.Lbl_CreAccName3.Text != string.Empty))
                    {
                        Class12.smethod_3(str2, str3, str4, str5, num, 0.0, this.Txt_CreAccId2.EditValue.ToString(), str6, 6);
                        Class12.smethod_3(str2, str3, str4, this.Txt_CreAccId2.EditValue.ToString(), 0.0, num, str5, str6, 5);
                    }
                    Class12.smethod_2(this.Txt_CreAccId1.EditValue.ToString(), num2, false);
                    Class12.smethod_2(this.Txt_CreAccId2.EditValue.ToString(), num3, false);
                    Class12.smethod_2(this.Txt_CreAccId3.EditValue.ToString(), num, false);
                    Class12.smethod_2(this.Txt_DebAccId.EditValue.ToString(), Class7.smethod_0(this.Lbl_DebitAmt.Text), true);
                    new Class6().ComputeTransnum("A");
                }
                Class6.transNum = this.Txt_TransNum.Text.Trim();
                Class7.smethod_27(Class6.string_3).ShowPreviewDialog();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "S";
            this.Txt_TransNum.Enabled = true;
            this.Txt_TransNum.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_0 = "D";
        }


        private void FrmTran_n_1_Load(object sender, EventArgs e)
        {
            this.Lbl_TranCode.Text = Class6.string_2;
            this.btn_Skip_Click(this, new EventArgs());
            Class11.smethod_8(this);
            this.Text = Class6.string_1;
            base.Tag = "tblAccTrans";
            this.Lbl_Today.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }



        private void kCnalMegv(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_CreAccId3.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_CreAccName3.Text = str;
        }

        private void Lbl_TranCode_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("trans_name", "tblAtrcode", "trans_code", this.Lbl_TranCode.Text, "", this.oleDbConnection_0, ref str);
            this.Lbl_TranName.Text = str;
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            try
            {
                double num = (Class7.smethod_0(this.Txt_CreAmt3.Text) + Class7.smethod_0(this.Txt_CreAmt2.Text)) + Class7.smethod_0(this.Txt_CreAmt1.Text);
                this.Lbl_DebitAmt.Text = string.Format("{0:n2}", num);
            }
            catch (Exception)
            {
                this.Lbl_DebitAmt.Text = "0.00";
            }
        }

        private void Txt_CreAccId1_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_CreAccId1.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_CreAccName1.Text = str;
        }

        private void Txt_CreAccId1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = (this.Txt_CreAccId1.EditValue.ToString().Length != 0) ? this.Txt_CreAccId1.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm(this.string_1, this.oleDbConnection_0);
                this.Txt_CreAccId1.Text = FrmBrowse.strReturn;
            }
        }

        private void Txt_CreAccId2_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_CreAccId2.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_CreAccName2.Text = str;
        }

        private void Txt_CreAccId2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = (this.Txt_CreAccId2.EditValue.ToString().Length != 0) ? this.Txt_CreAccId2.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm(this.string_1, this.oleDbConnection_0);
                this.Txt_CreAccId2.Text = FrmBrowse.strReturn;
            }
        }

        private void Txt_CreAccId3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = (this.Txt_CreAccId3.EditValue.ToString().Length != 0) ? this.Txt_CreAccId3.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm(this.string_1, this.oleDbConnection_0);
                this.Txt_CreAccId3.Text = FrmBrowse.strReturn;
            }
        }

        private void Txt_CreAmt2_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_DebAccId_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("name", "tblAccount", "account_id", this.Txt_DebAccId.EditValue.ToString(), "and status = 1 ", this.oleDbConnection_0, ref str);
            this.Lbl_DebAccName.Text = str;
        }

        private void Txt_DebAccId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = (this.Txt_DebAccId.EditValue.ToString().Length != 0) ? this.Txt_DebAccId.EditValue.ToString().Substring(0, 3) : string.Empty;
                this.string_1 = "SELECT account_id AS [Số TK], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean đầy đủ] FROM tblAccount where status = 1 and account_id LIKE '" + str + "%'";
                Class7.BrowserForm(this.string_1, this.oleDbConnection_0);
                this.Txt_DebAccId.Text = FrmBrowse.strReturn;
            }
        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
        }
  
    }
}