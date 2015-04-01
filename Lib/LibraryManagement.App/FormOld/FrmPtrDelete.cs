using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmPtrDelete : DevExpress.XtraEditors.XtraForm
    {
        public FrmPtrDelete()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
            {
                DataSet set;
                string str = this.Txt_TransNum.Text.Trim();
                string text = this.Lbl_PosId.Text;
                switch (this.Cmb_Type.SelectedIndex)
                {
                    case 0:
                        this.btn_Skip_Click(this, new EventArgs());
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter("delete from tblsuspend where trans_num = '" + str + "'", this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
                        this.oleDbConnection_0.Close();
                        this.method_1();
                        break;

                    case 1:
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            string str3 = "Bị x\x00f3a bởi : " + Class7.string_7;
                            this.string_0 = "update tblTransaction set status = 0, remark = N'" + str3 + "' where trans_num = '" + str + "' ";
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                            }
                            this.oleDbConnection_0.Close();
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM  tblTransaction where trans_num = '" + str + "'", this.oleDbConnection_0);
                            DataTable dataTable = new DataTable();
                            this.oleDbDataAdapter_0.Fill(dataTable);
                            this.oleDbConnection_0.Close();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                double num2 = Class7.smethod_2(row["amount"]);
                                double num3 = Class7.smethod_2(row["vat_amt"]);
                                double num4 = Class7.smethod_2(row["discount"]);
                                double num5 = Class7.smethod_2(row["surplus"]);
                                double num6 = num2 - ((num3 + num4) + num5);
                                this.string_0 = string.Concat(new object[] { "UPDATE  tblStockInfo SET exp_qty = exp_qty - ", row["qty"], " , exp_amt = exp_amt - ", num6, " WHERE id = '", text, "' AND goods_id = '", row["goods_id"], "' " });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                                using (DataSet set2 = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set2);
                                }
                                this.oleDbConnection_0.Close();
                            }
                            this.method_2();
                            this.method_0();
                            break;
                        }
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            this.Lbl_TransCode.Text = string.Empty;
            this.Lbl_PosId.Text = string.Empty;
            this.Lbl_UserName.Text = string.Empty;
            this.Txt_TransNum.Text = string.Empty;
            this.Cmb_Type.Enabled = true;
            this.Cmb_Type.SelectedIndex = 1;
            this.Txt_TransNum.Enabled = true;
            this.Txt_TransNum.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.btn_Delete.Enabled = false;
            this.btn_Search.Enabled = true;
            this.btn_Skip.Enabled = false;
            this.btn_Exit.Enabled = true;
            this.IipWvDcZu = "D";
        }

        private void FrmPtrDelete_Load(object sender, EventArgs e)
        {
            string str = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.Lbl_Date.Text = str;
            this.Text = "Hủy giao dịch";
            this.btn_Skip_Click(this, new EventArgs());
            this.method_1();
        }



        private void Lbl_PosId_TextChanged(object sender, EventArgs e)
        {
            if (!(this.Lbl_PosId.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Lbl_PosId.Text, "", this.oleDbConnection_0, ref str);
                this.Lbl_PosName.Text = str;
            }
        }

        private void Lbl_TransCode_TabStopChanged(object sender, EventArgs e)
        {
            if (!(this.Lbl_TransCode.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("trName", "tblTrcode", "trCode", this.Lbl_TransCode.Text, "", this.oleDbConnection_0, ref str);
                this.Lbl_TransName.Text = str;
            }
        }

        private void method_0()
        {
            this.TransDetail.Columns.Clear();
            string str = this.Txt_TransNum.Text.Trim();
            this.string_0 = "SELECT A.trans_num, A.status,A.goods_id AS [M\x00e3 h\x00e0ng], B.full_name AS [T\x00ean h\x00e0ng], A.qty AS [Số lượng], B.piceunit AS [Đơn vị], A.amount/A.qty AS [Đơn gi\x00e1], A.discount AS [Chiết khấu],(A.amount - A.discount) AS [Thực thu] FROM tblTransaction AS A inner join tblGoods AS B on A.goods_id = B.goods_id where A.trans_num = '" + str + "' and A.status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTran.DataSource = dataSet.Tables[0];
            this.TransDetail.OptionsBehavior.Editable = false;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Thực thu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Thực thu"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Thực thu"].SummaryItem.FieldName = "Thực thu";
            this.TransDetail.Columns["Thực thu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Thực thu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.Columns["Chiết khấu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Chiết khấu"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Chiết khấu"].SummaryItem.FieldName = "Chiết khấu";
            this.TransDetail.Columns["Chiết khấu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Chiết khấu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.BestFitColumns();
            this.TransDetail.Columns["trans_num"].Visible = false;
            this.TransDetail.Columns["status"].Visible = false;
        }

        private void method_1()
        {
            this.TransDetail.Columns.Clear();
            string str = this.Txt_TransNum.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT trans_num, goods_id AS [M\x00e3 h\x00e0ng], name AS [T\x00ean h\x00e0ng], qty AS [Số lượng], unit AS [Đơn vị], price AS [Đơn gi\x00e1], price*qty AS [Th\x00e0nh tiền] FROM tblsuspend where trans_num = '" + str + "'", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTran.DataSource = dataSet.Tables[0];
            this.TransDetail.OptionsBehavior.Editable = false;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.FieldName = "Th\x00e0nh tiền";
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.BestFitColumns();
            this.TransDetail.Columns["trans_num"].Visible = false;
        }

        private void method_2()
        {
            string str = this.Txt_TransNum.Text.Trim();
            string text = this.Lbl_PosId.Text;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id FROM tblTransaction where trans_num = '" + str + "'", this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_0.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                string selectCommandText = string.Concat(new object[] { "UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty) - exp_qty) WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt) - exp_amt)/((begin_qty + imp_qty) - exp_qty)  END WHERE  goods_id = '", row["goods_id"], "' and id = '", text, "' " });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_0.Close();
            }
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.btn_Delete.Enabled = this.TransDetail.RowCount != 0;
        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (this.Cmb_Type.SelectedIndex == 0)
                {
                    Class7.BrowserForm(" SELECT trans_num, goods_id, Name, qty  FROM tblSuspend ", this.oleDbConnection_0);
                    this.Txt_TransNum.Text = FrmBrowse.strReturn;
                }
                else if (this.Cmb_Type.SelectedIndex == 1)
                {
                    Class7.BrowserForm(" SELECT trans_num, goods_id, qty,amount   FROM tblTransaction WHERE trans_code = '00' AND tran_date = '" + Class7.smethod_19() + "' AND status = 1", this.oleDbConnection_0);
                    this.Txt_TransNum.Text = FrmBrowse.strReturn;
                }
            }
            string str = this.Txt_TransNum.Text.Trim();
            if (e.KeyCode == Keys.Return)
            {
                DataSet set;
                switch (this.Cmb_Type.SelectedIndex)
                {
                    case 0:
                        this.string_0 = "select tblsuspend.*, tblUser.name from tblsuspend inner join tbluser on tblsuspend.user_id = tbluser.id where tblsuspend.trans_num = '" + str + "' ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            if (set.Tables[0].Rows.Count != 0)
                            {
                                this.Lbl_TransCode.Text = "00";
                                this.Lbl_PosId.Text = set.Tables[0].Rows[0]["pos_id"].ToString();
                                this.Lbl_UserName.Text = set.Tables[0].Rows[0]["name"].ToString();
                                this.btn_Delete.Enabled = true;
                                this.btn_Search.Enabled = false;
                                this.btn_Skip.Enabled = true;
                                this.btn_Exit.Enabled = true;
                            }
                            else
                            {
                                this.Lbl_TransCode.Text = string.Empty;
                                this.Lbl_PosId.Text = string.Empty;
                                this.Lbl_UserName.Text = string.Empty;
                                this.btn_Delete.Enabled = false;
                                this.btn_Search.Enabled = true;
                                this.btn_Skip.Enabled = true;
                                this.btn_Exit.Enabled = true;
                            }
                        }
                        this.method_1();
                        break;

                    case 1:
                        this.string_0 = "select tblTransaction.*, tblUser.name from tblTransaction inner join tbluser on tblTransaction.user_id = tbluser.id where tblTransaction.trans_num = '" + str + "' and tblTransaction.tran_date = '" + Class7.smethod_19() + "' and tblTransaction.trans_code = '00' and tblTransaction.status = 1";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            if (set.Tables[0].Rows.Count != 0)
                            {
                                this.Lbl_TransCode.Text = set.Tables[0].Rows[0]["trans_code"].ToString();
                                this.Lbl_PosId.Text = set.Tables[0].Rows[0]["exp_id"].ToString();
                                this.Lbl_UserName.Text = set.Tables[0].Rows[0]["name"].ToString();
                                this.btn_Delete.Enabled = true;
                                this.btn_Search.Enabled = false;
                                this.btn_Skip.Enabled = true;
                                this.btn_Exit.Enabled = true;
                            }
                            else
                            {
                                this.Lbl_TransCode.Text = string.Empty;
                                this.Lbl_PosId.Text = string.Empty;
                                this.Lbl_UserName.Text = string.Empty;
                                Class7.ShowMessageBox("Kh\x00f4ng t\x00ecm thấy giao dịch b\x00e1n h\x00e0ng n\x00e0y", 1);
                            }
                        }
                        this.method_0();
                        break;

                    case -1:
                        Class7.ShowMessageBox("Bạn chưa chọn loại giao dịch cần x\x00f3a", 1);
                        this.Cmb_Type.Focus();
                        break;
                }
            }
        }
   
    }
}