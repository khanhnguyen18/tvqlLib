using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
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
    public partial class FrmPtrReturn : DevExpress.XtraEditors.XtraForm
    {
        public FrmPtrReturn()
        {
            InitializeComponent();
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class6 class2 = new Class6();
            this.Txt_OldTrans.Enabled = true;
            this.Txt_Qty.Enabled = false;
            this.btn_New.Enabled = false;
            this.btn_Save.Enabled = true;
            this.btn_Skip.Enabled = true;
            this.Txt_TransNum.Text = class2.method_5("P");
            this.Txt_OldTrans.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.TransDetail.RowCount != 0)
            {
                double num;
                double num2;
                double num3;
                double num4;
                this.btn_Skip_Click(this, new EventArgs());
                new Class6().ComputeTransnum("P");
                Class6.transNum = this.Txt_TransNum.Text.Trim();
                string str4 = this.Txt_OldTrans.Text.Trim();
                string str = Class7.smethod_19();
                string str3 = Class7.smethod_53();
                string str2 = this.Txt_PosId.Text.Trim();
                int num6 = Class7.GetUserRight();
                int num7 = Class7.smethod_51();
                string str5 = "Trả lại h\x00e0ng b\x00e1n lẻ";
                this.string_1 = "select idx,goods_id, Name, qty, unit, amount, discount, surplus, vat_amt from " + this.string_0;
                this.cnvLekth7 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                DataTable dataTable = new DataTable();
                this.cnvLekth7.Fill(dataTable);
                this.oleDbConnection_0.Close();
                foreach (DataRow row in dataTable.Rows)
                {
                    num = Class7.smethod_2(row["amount"]);
                    num2 = Class7.smethod_2(row["vat_amt"]);
                    num3 = Class7.smethod_2(row["discount"]);
                    num4 = Class7.smethod_2(row["surplus"]);
                    this.string_1 = string.Concat(new object[] { 
                        "INSERT INTO tblTransaction(tran_date, tran_time, trans_num, trans_code, kit_id, kit_qty, goods_id, qty, amount, discount, surplus, vat_amt, commis_amt, user_id, ref, custax_id,card_id, exp_id, cs_id, merc_type, tax_code, vat_incl, invoice, updated, copies, Shift, recnum,remark, status,station) VALUES('", str, "','", str3, "','", Class6.transNum, "','01','',0,'", row["goods_id"], "',", row["qty"], ",", num, ",", num3, ",", num4, 
                        ",", num2, ",0,", num6, ",'", str4, "','','','", str2, "','','01','',0,'',0,1,0,", row["idx"], ",N'", str5, "',1,", num7, ")"
                     });
                    this.cnvLekth7 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (DataSet set3 = new DataSet())
                    {
                        this.cnvLekth7.Fill(set3);
                    }
                    this.oleDbConnection_0.Close();
                }
                this.cnvLekth7 = new OleDbDataAdapter("SELECT * FROM  tblTransaction where trans_num = '" + Class6.transNum + "'", this.oleDbConnection_0);
                DataTable table = new DataTable();
                this.cnvLekth7.Fill(table);
                this.oleDbConnection_0.Close();
                foreach (DataRow row in table.Rows)
                {
                    num = Class7.smethod_2(row["amount"]);
                    num2 = Class7.smethod_2(row["vat_amt"]);
                    num3 = Class7.smethod_2(row["discount"]);
                    num4 = Class7.smethod_2(row["surplus"]);
                    double num5 = num - ((num2 + num3) + num4);
                    this.string_1 = string.Concat(new object[] { "UPDATE  tblStockInfo SET exp_qty = exp_qty - ", row["qty"], " , exp_amt = exp_amt - ", num5, ", last_date ='", str, "' WHERE id = '", str2, "' AND goods_id = '", row["goods_id"], "' " });
                    this.cnvLekth7 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (DataSet set = new DataSet())
                    {
                        this.cnvLekth7.Fill(set);
                    }
                    this.oleDbConnection_0.Close();
                    this.string_1 = string.Concat(new object[] { "UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty) - exp_qty)  WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt) - exp_amt)/((begin_qty + imp_qty) - exp_qty) END   WHERE  goods_id = '", row["goods_id"], "' and id = '", row["exp_id"], "'" });
                    this.cnvLekth7 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (DataSet set2 = new DataSet())
                    {
                        this.cnvLekth7.Fill(set2);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                voucher_2 v2 = new voucher_2();
                v2.PrintingSystem.ShowMarginsWarning = false;
                v2.PrintingSystem.ShowPrintStatusDialog = false;
                v2.Print();
                this.btn_New.Focus();
            }
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_2 = "D";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.Lbl_MercName.Text != string.Empty)
            {
                if (Class7.smethod_0(this.Txt_Qty.Text) > Class7.smethod_0(this.Txt_OldQty.Text))
                {
                    Class7.ShowMessageBox("Lượng trả lại kh\x00f4ng thể lớn hơn lượng đ\x00e3 b\x00e1n !", 1);
                    this.Txt_Qty.Focus();
                    this.Txt_Qty.SelectAll();
                }
                else
                {
                    double num = Class7.smethod_0(this.Txt_Qty.Text);
                    string str = this.Txt_GoodsId.Text.Trim();
                    double num2 = (Class7.smethod_0(this.Txt_Amount.Text) / Class7.smethod_0(this.Txt_OldQty.Text)) * num;
                    double num3 = (Class7.smethod_0(this.Txt_Discount.Text) / Class7.smethod_0(this.Txt_OldQty.Text)) * num;
                    double num4 = (Class7.smethod_0(this.Txt_Surplus.Text) / Class7.smethod_0(this.Txt_OldQty.Text)) * num;
                    double num5 = (Class7.smethod_0(this.Txt_Vatamt.Text) / Class7.smethod_0(this.Txt_OldQty.Text)) * num;
                    string str2 = this.Lbl_MercName.Text.Trim();
                    string str3 = this.Lbl_Unit.Text.Trim();
                    this.string_1 = string.Concat(new object[] { 
                        "IF NOT EXISTS(SELECT goods_id from ", this.string_0, " where goods_id = '", str, "') INSERT INTO ", this.string_0, "(goods_id, Name, qty, unit, amount, discount,surplus,vat_amt) VALUES ('", str, "',N'", str2, "',", num, ",'", str3, "',", num2, 
                        ",", num3, ", ", num4, ",", num5, ") Else UPDATE ", this.string_0, " SET qty = '", num, "', amount = ", num2, ", discount = ", num3, ", surplus = ", num4, 
                        ",vat_amt = ", num5, " where goods_id = '", str, "';DELETE FROM ", this.string_0, " where qty <= 0 "
                     });
                    Class6 class2 = new Class6();
                    this.cnvLekth7 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    DataSet dataSet = new DataSet();
                    this.cnvLekth7.Fill(dataSet);
                    class2.method_2(this.string_0);
                    this.method_0();
                    this.Txt_GoodsId.Focus();
                }
            }
        }



        private void FrmPtrReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cnvLekth7 = new OleDbDataAdapter("DROP TABLE " + this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.cnvLekth7.Fill(set);
            }
            this.oleDbConnection_0.Close();
        }

        private void FrmPtrReturn_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.Text = "Giao dịch nhận h\x00e0ng trả lại";
            try
            {
                this.string_1 = "CREATE TABLE " + this.string_0 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((1)),[unit] [nvarchar](3) DEFAULT (('')),[amount] [decimal](18, 2) DEFAULT ((0)), [surplus] [decimal](18, 2) DEFAULT ((0)),[discount] [decimal](18, 2) DEFAULT ((0)),[vat_amt] [decimal](18, 2) DEFAULT ((0)))";
                this.cnvLekth7 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.cnvLekth7.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
            catch (Exception)
            {
                this.cnvLekth7 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.cnvLekth7.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
            string str = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.Lbl_Date.Text = str;
            this.btn_Skip_Click(this, new EventArgs());
            this.method_0();
        }



        private void method_0()
        {
            this.cnvLekth7 = new OleDbDataAdapter("SELECT idx AS [TT], goods_id AS [M\x00e3 h\x00e0ng], name AS [T\x00ean h\x00e0ng], qty AS [Số lượng], unit AS [Đơn vị], (amount+discount)/qty AS [Đơn gi\x00e1], discount AS [Chiết khấu], amount - discount AS [Thực thu] FROM " + this.string_0 + " ORDER BY autoid", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.cnvLekth7.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTran.DataSource = dataSet.Tables[0];
            this.TransDetail.OptionsBehavior.Editable = false;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Số lượng"].SummaryItem.FieldName = "Số lượng";
            this.TransDetail.Columns["Số lượng"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Số lượng"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Chiết khấu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Chiết khấu"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Chiết khấu"].SummaryItem.FieldName = "Chiết khấu";
            this.TransDetail.Columns["Chiết khấu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Chiết khấu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.Columns["Thực thu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Thực thu"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Thực thu"].SummaryItem.FieldName = "Thực thu";
            this.TransDetail.Columns["Thực thu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Thực thu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.BestFitColumns();
        }

        private void method_1()
        {
            string str = this.Txt_TransNum.Text.Trim();
            string str2 = this.Txt_PosId.Text.Trim();
            this.cnvLekth7 = new OleDbDataAdapter("SELECT goods_id FROM tblTransaction where trans_num = '" + str + "'", this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.cnvLekth7.Fill(dataTable);
            this.oleDbConnection_0.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                string selectCommandText = string.Concat(new object[] { "UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty) - exp_qty) WHEN  0 THEN 0 ELSE ((begin_amt + imp_amt) - exp_amt)/((begin_qty + imp_qty) - exp_qty)  END WHERE  goods_id = '", row["goods_id"], "' and id = '", str2, "'  " });
                this.cnvLekth7 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.cnvLekth7.Fill(dataSet);
                this.oleDbConnection_0.Close();
            }
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.btn_Save.Enabled = this.TransDetail.RowCount != 0;
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
            string selectCommandText = "SELECT ptr.exp_id,ptr.goods_id, gs.full_name, gs.piceunit,ptr.qty, ptr.amount,  ptr.discount, ptr.surplus,ptr.vat_amt FROM tblTransaction AS ptr INNER JOIN tblGoods AS gs ON ptr.goods_id = gs.goods_id where ptr.goods_id = '" + this.Txt_GoodsId.Text.Trim() + "' and ptr.trans_num = '" + this.Txt_OldTrans.Text.Trim() + "'";
            this.cnvLekth7 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.cnvLekth7.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Lbl_MercName.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
                this.Txt_OldQty.Text = dataSet.Tables[0].Rows[0]["qty"].ToString();
                this.Txt_Amount.Text = dataSet.Tables[0].Rows[0]["amount"].ToString();
                this.Txt_Discount.Text = dataSet.Tables[0].Rows[0]["discount"].ToString();
                this.Lbl_Unit.Text = dataSet.Tables[0].Rows[0]["piceunit"].ToString();
                this.Txt_PosId.Text = dataSet.Tables[0].Rows[0]["exp_id"].ToString();
                this.Txt_Surplus.Text = dataSet.Tables[0].Rows[0]["surplus"].ToString();
                this.Txt_Vatamt.Text = dataSet.Tables[0].Rows[0]["vat_amt"].ToString();
            }
            else
            {
                this.Lbl_MercName.Text = string.Empty;
                this.Txt_PosId.Text = string.Empty;
                this.Txt_OldQty.Text = "1";
                this.Txt_Amount.Text = "0";
                this.Txt_Discount.Text = "0";
                this.Lbl_Unit.Text = string.Empty;
            }
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("SELECT ptr.goods_id, gs.full_name, ptr.qty, ptr.amount, ptr.trans_num FROM tblTransaction AS ptr INNER JOIN tblGoods AS gs ON ptr.goods_id = gs.goods_id where ptr.trans_num = '" + this.Txt_OldTrans.Text + "'", this.oleDbConnection_0);
                this.Txt_GoodsId.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_GoodsId_Validating(object sender, CancelEventArgs e)
        {
            if (this.Lbl_MercName.Text == string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void Txt_OldDate_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_OldTrans_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_OldTrans_KeyDown(object sender, KeyEventArgs e)
        {
            string str = this.Txt_OldTrans.Text.Trim();
            if (e.KeyCode == Keys.Return)
            {
                string selectCommandText = "select * from tblTransaction where trans_num = '" + str + "' and status = 1";
                this.cnvLekth7 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.cnvLekth7.Fill(dataSet);
                this.oleDbConnection_0.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    this.Txt_OldDate.Text = dataSet.Tables[0].Rows[0]["tran_date"].ToString();
                    this.Txt_PosId.Text = dataSet.Tables[0].Rows[0]["exp_id"].ToString();
                    this.Txt_OldTrans.Enabled = false;
                    this.Txt_OldDate.Enabled = false;
                    this.btnAdd.Enabled = true;
                    this.Txt_Qty.Enabled = true;
                    this.Txt_OldQty.Enabled = false;
                    this.Txt_GoodsId.Enabled = true;
                    this.Txt_GoodsId.Focus();
                }
                else
                {
                    this.Txt_PosId.Text = string.Empty;
                    Class7.ShowMessageBox("Kh\x00f4ng t\x00ecm thấy h\x00f3a đơn n\x00e0y", 1);
                    this.Txt_OldTrans.SelectAll();
                }
            }
        }

    }
}