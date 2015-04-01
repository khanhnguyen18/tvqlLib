using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class ReturnBookForm : DevExpress.XtraEditors.XtraForm
    {
        public ReturnBookForm()
        {
            InitializeComponent();
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
            this.txtTransNum.Text = new Class6().method_5("H");
            this.txtDate.Text = Class7.smethod_19();
            this.txtDate.Enabled = false;
            this.txtTransNum.Enabled = false;
            this.txtCsId.Text = string.Empty;
            this.txtCsId.Focus();
            this.dataSet_0.Clear();
            this.gridControl1.Refresh();
            this.string_1 = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.dataSet_0.Tables["loantran"].Rows.Count != 0)
            {
                if (this.lblName.Text == string.Empty)
                {
                    Class7.ShowMessageBox("Bạn chưa chọn th\x00f4ng tin người mượn", 1);
                    this.txtCsId.Focus();
                }
                else
                {
                    string str = this.txtTransNum.Text.Trim();
                    string str2 = this.string_1;
                    if (str2 != null)
                    {
                        if (!(str2 == "N"))
                        {
                            if (str2 == "E")
                            {
                                this.btn_Skip_Click(this, new EventArgs());
                                this.method_0();
                                Class2.smethod_2(str);
                                this.method_3(str);
                                Class2.DeleteByTransactionCode(str);
                                this.method_1();
                            }
                        }
                        else
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            new Class6().ComputeTransnum("H");
                            this.method_0();
                            this.method_1();
                            this.method_2();
                        }
                    }
                    Class6.transNum = str;
                    new return_book().ShowPreviewDialog();
                }
            }
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }

        private void btnAddGrp_Click(object sender, EventArgs e)
        {
            new FrmReaderDef().ShowDialog();
        }


        private void FrmBookRb_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmBookRb_Load(object sender, EventArgs e)
        {
            this.Text = "Quản l\x00fd s\x00e1ch trả";
            this.lblCopyright.Text = Class13.smethod_1(Class7.smethod_14("m_copyright").ToString(), Class13.string_0);
            this.btn_Skip_Click(this, new EventArgs());
        }



        private void method_0()
        {
            for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
            {
                if ((bool)this.dataSet_0.Tables["loantran"].Rows[i]["chk_rb"])
                {
                    this.dataSet_0.Tables["loantran"].Rows[i]["remark"] = this.txtRemark.Text;
                }
            }
        }

        private void method_1()
        {
            string str = this.txtTransNum.Text.Trim();
            string str3 = (this.txtRemark.Text == string.Empty) ? "Phiếu trả s\x00e1ch" : this.txtRemark.Text.Trim();
            string str2 = this.txtCsId.Text.Trim();
            for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
            {
                if ((bool)this.dataSet_0.Tables["loantran"].Rows[i]["chk_rb"])
                {
                    object obj2 = this.dataSet_0.Tables["loantran"].Rows[i]["goods_id"];
                    object obj3 = this.dataSet_0.Tables["loantran"].Rows[i]["oldtran"];
                    this.string_0 = string.Concat(new object[] { 
                        "INSERT INTO tblLoanTran(trans_num, tran_date,trans_code, tran_time, exp_id, cs_id, goods_id, qty, user_id, remark, status, corr_tran) VALUES ('", str, "','", Class7.smethod_19(), "','", this.string_2, "','", Class7.smethod_53(), "','", Class7.smethod_40(), "','", str2, "','", obj2, "',1,", Class7.GetUserRight(), 
                        ",N'", str3, "',1,'", obj3, "')"
                     });
                    Class7.smethod_4(this.string_0);
                    Class2.smethod_1(Class7.smethod_40(), obj2.ToString(), 1.0);
                }
            }
        }

        private void method_2()
        {
            for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
            {
                if ((bool)this.dataSet_0.Tables["loantran"].Rows[i]["chk_rb"])
                {
                    object obj2 = this.dataSet_0.Tables["loantran"].Rows[i]["goods_id"];
                    object obj3 = this.dataSet_0.Tables["loantran"].Rows[i]["oldtran"];
                    this.string_0 = string.Concat(new object[] { "UPDATE tblLoanTran SET corr_tran = '", this.txtTransNum.Text, "' WHERE trans_num = '", obj3, "' AND goods_id = '", obj2, "'" });
                    Class7.smethod_4(this.string_0);
                    Class2.smethod_1(Class7.smethod_40(), obj2.ToString(), 1.0);
                }
            }
        }

        private void method_3(string string_3)
        {
            this.string_0 = "SELECT goods_id, corr_tran from tblLoantran where trans_num = '" + string_3 + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataTable table = new DataTable())
            {
                this.oleDbDataAdapter_0.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    this.string_0 = string.Concat(new object[] { "UPDATE tblLoanTran SET corr_acc = '' WHERE trans_num = '", row["corr_tran"], "' AND goods_id = '", row["goods_id"], "'" });
                    Class7.smethod_4(this.string_0);
                }
            }
            for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
            {
                object obj2 = this.dataSet_0.Tables["loantran"].Rows[i]["goods_id"];
                object obj3 = this.dataSet_0.Tables["loantran"].Rows[i]["oldtran"];
                object obj4 = this.dataSet_0.Tables["loantran"].Rows[i]["trans_num"];
                this.string_0 = string.Concat(new object[] { "UPDATE tblLoanTran SET corr_acc = '", obj4, "' WHERE trans_num = '", obj3, "' AND goods_id = '", obj2, "'" });
                Class7.smethod_4(this.string_0);
                Class2.smethod_1(Class7.smethod_40(), obj2.ToString(), 1.0);
            }
        }

        private void method_4(object sender, EventArgs e)
        {
        }

        private void method_5(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.string_1 = "S";
            this.string_0 = "SELECT DISTINCT tr.trans_num AS [Số phiếu], tr.tran_time AS [Giờ], tr.cs_id AS [Số thẻ],cs.fullname AS [Họ t\x00ean], tr.status AS [Trạng th\x00e1i] FROM tblLoanTran AS tr INNER JOIN tblCustomer AS cs ON tr.cs_id = cs.id WHERE tr.trans_code = '61'";
            Class7.BrowserForm(this.string_0, this.oleDbConnection_0);
            this.txtTransNum.Enabled = true;
            this.txtTransNum.Text = FrmBrowse.strReturn;
            this.txtTransNum.Focus();
        }

        private void txtCsId_EditValueChanged(object sender, EventArgs e)
        {
            if (this.txtCsId.Text.Length >= 8)
            {
                string str = this.txtCsId.Text.Trim();
                this.lblName.Text = Class7.smethod_29("tblCustomer", "fullname", "id", str, "", this.oleDbConnection_0).ToString();
                this.lblPhone.Text = Class7.smethod_29("tblCustomer", "phone", "id", str, "", this.oleDbConnection_0).ToString();
                this.lblEmail.Text = Class7.smethod_29("tblCustomer", "email", "id", str, "", this.oleDbConnection_0).ToString();
                this.lblAddress.Text = Class7.smethod_29("tblCustomer", "address", "id", str, "", this.oleDbConnection_0).ToString();
                try
                {
                    byte[] buffer = (byte[])Class7.smethod_29("tblCustomer", "image", "id", str, "", this.oleDbConnection_0);
                    this.pictureEdit1.Image = Class7.smethod_21(buffer);
                }
                catch (Exception)
                {
                    this.pictureEdit1.Image = null;
                }
                if (this.lblName.Text != string.Empty)
                {
                    this.dataSet_0.Clear();
                    this.string_0 = "SELECT tr.trans_num AS oldtran, tr.goods_id, tr.due_date, gs.full_name FROM tblLoanTran AS tr INNER JOIN tblGoods AS gs ON tr.goods_id = gs.goods_id WHERE tr.cs_id = '" + this.txtCsId.Text.Trim() + "' and tr.status = 1 and tr.corr_tran = ''";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                    using (DataSet set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set, "loantran");
                        this.oleDbConnection_0.Close();
                        this.dataSet_0.Merge(set.Tables[0]);
                        this.gridControl1.Refresh();
                    }
                }
            }
        }

        private void txtCsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.string_0 = "SELECT id AS [M\x00e3 thẻ], fullname AS [Họ v\x00e0 t\x00ean], phone AS [Số ĐT], status AS [Trạng th\x00e1i] from tblCustomer";
                Class7.BrowserForm(this.string_0, this.oleDbConnection_0);
                this.txtCsId.Text = FrmBrowse.strReturn;
            }
        }

        private void txtTransNum_EditValueChanged(object sender, EventArgs e)
        {
        }
    
    }
}