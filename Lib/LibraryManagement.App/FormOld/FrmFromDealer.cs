using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
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
    public partial class FrmFromDealer : DevExpress.XtraEditors.XtraForm
    {
        public FrmFromDealer()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class11.string_0 == "F")
            {
                string str = this.Txt_TransNum.Text.Trim();
                string str2 = this.Txt_ImpID.Text.Trim();
                Class6 class2 = new Class6();
                string text = this.btn_Delete.Text;
                if (text != null)
                {
                    if (!(text == "&X\x00f3a"))
                    {
                        if ((text == "&Phục hồi") && (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn phục hồi giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1))
                        {
                            class2.method_14("tblTransaction", str, 1);
                            class2.method_17(str);
                            class2.method_7(str, str2);
                            this.btn_Skip_Click(this, new EventArgs());
                        }
                    }
                    else if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1)
                    {
                        class2.method_18(str);
                        class2.method_8(str);
                        class2.method_14("tblTransaction", str, 0);
                        this.btn_Skip_Click(this, new EventArgs());
                    }
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_ImpID.Enabled = false;
            this.Txt_ExpID.Enabled = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Lbl_ImpName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o nơi nhập h\x00e0ng", 1);
                this.Txt_ImpID.Focus();
            }
            else if (this.Lbl_ExpName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o nơi xuất h\x00e0ng", 1);
                this.Txt_ExpID.Focus();
            }
            else if (this.TransDetail.RowCount == 0)
            {
                this.Txt_GoodsId.Focus();
            }
            else
            {
                string str3 = this.Txt_TransNum.Text.Trim();
                string str4 = this.Txt_ExpID.Text.Trim();
                string str5 = this.Txt_ImpID.Text.Trim();
                string str7 = this.Txt_Remark.Text.Trim();
                string str6 = this.Txt_Voucher.Text.Trim();
                if (this.TransDetail.RowCount != 0)
                {
                    Class6 class2 = new Class6();
                    string str = Class11.string_0;
                    if (str != null)
                    {
                        if (!(str == "N"))
                        {
                            if (str == "E")
                            {
                                this.btn_Skip_Click(this, new EventArgs());
                                class2.method_18(str3);
                                class2.method_8(str3);
                                class2.method_13(str3);
                                class2.method_6(this.string_0, str3, this.welftZbha, str4, str5, str6, str7, this.string_2);
                                class2.method_7(str3, str5);
                            }
                        }
                        else
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            class2.ComputeTransnum("K");
                            string str2 = Class7.smethod_53();
                            class2.method_6(this.string_0, str3, this.welftZbha, str4, str5, str6, str7, str2);
                            class2.method_17(str3);
                            class2.method_7(str3, str5);
                        }
                    }
                    Class6.transNum = str3;
                    Class7.smethod_27(Class6.string_3).ShowPreviewDialog();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.method_1();
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            this.Txt_TransNum.Enabled = true;
            this.Txt_TransNum.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Lbl_MercName.Text))
            {
                this.Txt_GoodsId.Focus();
            }
            else
            {
                this.Txt_GoodsId.Text.Trim();
                this.Lbl_MercName.Text.Trim();
                Class7.smethod_0(this.Txt_Qty.Text);
                Class7.smethod_0(this.Txt_DiscPc.Text);
                Class7.smethod_0(this.Txt_Price.Text);
                this.Cmb_Unit.Text.Trim();
                if (Class7.smethod_0(this.Txt_Qty.Text) < 0.0)
                {
                    Class7.ShowMessageBox("Số lượng nhập đăng k\x00fd kh\x00f4ng hợp lệ", 1);
                    this.Txt_Qty.Focus();
                }
                else
                {
                    Class6 class2 = new Class6();
                    this.ddvqeXfa4();
                    class2.method_2(this.string_0);
                    this.method_1();
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter("select sum(amount) AS a_amt, sum(amount*disc_rate/100) AS d_amt, sum(amount) AS t_amt, sum(vat_amt) AS v_amt from " + this.string_0, this.oleDbConnection_1);
                    DataSet dataSet = new DataSet();
                    this.oleDbDataAdapter_0.Fill(dataSet);
                    this.oleDbConnection_1.Close();
                    if (dataSet.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_ImpAmt.Text = dataSet.Tables[0].Rows[0]["a_amt"].ToString();
                        this.Txt_TotalAmt.Text = dataSet.Tables[0].Rows[0]["t_amt"].ToString();
                        this.Txt_VatAmt.Text = dataSet.Tables[0].Rows[0]["v_amt"].ToString();
                        this.Txt_DiscAmt.Text = dataSet.Tables[0].Rows[0]["d_amt"].ToString();
                    }
                    else
                    {
                        this.Txt_ImpAmt.Text = "0";
                        this.Txt_TotalAmt.Text = "0";
                        this.Txt_VatAmt.Text = "0";
                        this.Txt_DiscAmt.Text = "0";
                    }
                    this.Txt_Qty.Text = "1";
                    this.Txt_DiscPc.EditValue = 0.0;
                    this.Txt_GoodsId.Focus();
                    this.Txt_GoodsId.SelectAll();
                }
            }
        }

        private void ddvqeXfa4()
        {
            string str = this.Txt_GoodsId.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id, unit_symb, qty, amount, discount, vat_amt, surplus  FROM  tblTransaction where tr.trans_num = '" + this.string_1 + "' and goods_id = '" + str + "'", this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
            double num = Class7.smethod_0(this.Txt_Qty.Text);
            double num2 = Class7.smethod_2(dataSet.Tables[0].Rows[0]["amount"]) / Class7.smethod_2(dataSet.Tables[0].Rows[0]["qty"]);
            double num3 = num * num2;
            double num4 = Class7.smethod_2(dataSet.Tables[0].Rows[0]["amount"]);
            double num5 = Class7.smethod_2(dataSet.Tables[0].Rows[0]["discount"]);
            Class7.smethod_2(dataSet.Tables[0].Rows[0]["vat_amt"]);
            double num6 = Class7.smethod_2(dataSet.Tables[0].Rows[0]["surplus"]);
            double num7 = ((num4 + num6) != 0.0) ? (num5 / (num4 + num6)) : 0.0;
            string text = this.Lbl_MercName.Text;
            string str3 = dataSet.Tables[0].Rows[0]["unit_symb"].ToString();
            string selectCommandText = string.Concat(new object[] { 
                "IF EXISTS (SELECT goods_id FROM ", this.string_0, " where goods_id = '", str, "') UPDATE ", this.string_0, " SET [qty] = ", num, " ,[amount] = ", num3, ",[price] = ", num2, ",[disc_rate] = ", num7, " WHERE goods_id = '", str, 
                "' Else INSERT INTO ", this.string_0, "(goods_id, name, qty, price, disc_rate,amount,unitsymb,merc_type)  VALUES('", str, "' , N'", text, "',", num, ",", num2, ",", num7, ",", num3, ", '", str3, 
                "', '01') ; DELETE FROM ", this.string_0, " WHERE qty <= 0 "
             });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
            using (DataSet set2 = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set2);
            }
            this.oleDbConnection_1.Close();
        }

        private void FrmFromDealer_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.Text = Class6.string_1.ToString();
            this.Lbl_Date.Text = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.btn_Skip_Click(this, new EventArgs());
            try
            {
                string selectCommandText = "CREATE TABLE " + this.string_0 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((1)),[price] [decimal](18, 2) DEFAULT ((0)),[amount] [decimal](18, 2) DEFAULT ((0)),[disc_rate] [decimal](18, 2) DEFAULT ((0)),[totalamt] [decimal](18, 2) DEFAULT ((0)),[vat_amt] [decimal](18, 2) DEFAULT ((0)),[surplus] [decimal](18, 2) DEFAULT ((0)),[unitsymb] [nvarchar](3) DEFAULT (('')),[merc_type] [nvarchar](2) DEFAULT (('')),[disc_amt] [decimal](18, 2) DEFAULT ((0)))";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
            catch (Exception)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_1);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
            this.method_0();
            this.method_1();
        }

        private void GrdTran_Click(object sender, EventArgs e)
        {
            if (this.TransDetail.RowCount != 0)
            {
                double num = Class7.smethod_0(this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Th\x00e0nh tiền").ToString());
                double num2 = (Class7.smethod_0(this.Txt_DiscAmt.Text) / num) * 100.0;
                this.Txt_GoodsId.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "M\x00e3 h\x00e0ng").ToString();
                this.Txt_Qty.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Số lượng").ToString();
                this.Txt_DiscPc.Text = num2.ToString();
                this.Txt_Price.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn gi\x00e1").ToString();
                this.Lbl_MercName.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "T\x00ean h\x00e0ng").ToString();
                this.Cmb_Unit.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn vị").ToString();
            }
        }

        private void iGoods_ItemClick(object sender, ItemClickEventArgs e)
        {
            new BookForm().ShowDialog();
        }

        private void method_0()
        {
            Class11.smethod_8(this);
            this.Lbl_ImpName.Text = string.Empty;
            this.Lbl_ExpName.Text = string.Empty;
            this.Lbl_MercName.Text = string.Empty;
            this.Txt_ImpAmt.Text = "0";
            this.Txt_TotalAmt.Text = "0";
            this.Txt_VatAmt.Text = "0";
            this.Txt_DiscAmt.Text = "0";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_1);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
            }
            this.oleDbConnection_1.Close();
        }

        private void method_1()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT idx AS [TT], goods_id AS [M\x00e3 h\x00e0ng], name AS [T\x00ean h\x00e0ng], qty AS [Số lượng], unitsymb AS [Đơn vị], price AS [Đơn gi\x00e1], amount AS [Th\x00e0nh tiền] FROM " + this.string_0 + " ORDER BY autoid", this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
            this.GrdTran.DataSource = dataSet.Tables[0];
            this.TransDetail.OptionsBehavior.Editable = false;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatString = "{0:n0}";
            this.TransDetail.Columns["Số lượng"].SummaryItem.FieldName = "Số lượng";
            this.TransDetail.Columns["Số lượng"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Số lượng"].SummaryItem.DisplayFormat = "{0:n0}";
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatString = "{0:n0}";
            this.TransDetail.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatString = "{0:n0}";
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.FieldName = "Th\x00e0nh tiền";
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.DisplayFormat = "{0:n0}";
            this.TransDetail.BestFitColumns();
        }

        private void method_2()
        {
            string str = this.Txt_ExpID.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id,qty,price,totalamt FROM " + this.string_0, this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            string str2 = string.Format("{0:d}", Class6.string_13);
            foreach (DataRow row in dataTable.Rows)
            {
                new Class6();
                double num = Class7.smethod_0(row["qty"].ToString());
                double num2 = Class7.smethod_0(row["totalamt"].ToString()) / num;
                string selectCommandText = string.Concat(new object[] { 
                    "IF NOT EXISTS (SELECT goods_id from tblCust_info where cust_id = '", str, "' and goods_id = '", row["goods_id"], "') INSERT INTO tblCust_info(Cust_id, goods_id,  exp_qty, exp_amt,imp_qty,imp_amt,lastwspr, last_date) VALUES ('", str, "','", row["goods_id"], "',", num, ",", row["totalamt"], ",0,0, ", num2, ",'", str2, 
                    "') Else UPDATE tblCust_info SET  imp_qty = exp_qty + ", num, ", exp_amt = exp_amt + ", row["totalamt"], ",  last_date = '", str2, "' where cust_id = '", str, "' and goods_id = '", row["goods_id"], "'"
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
        }

        private void method_3(string string_3)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT exp_id, goods_id, qty ,amount FROM tblTransaction where trans_num = '" + string_3 + "'", this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                new Class6();
                double num = Class7.smethod_0(row["qty"].ToString());
                double num1 = Class7.smethod_0(row["amount"].ToString()) / num;
                string selectCommandText = string.Concat(new object[] { "UPDATE tblCust_info SET  exp_qty = exp_qty - ", num, ", exp_amt = exp_amt - ", row["amount"], "where cust_id = '", row["exp_id"], "' and goods_id = '", row["goods_id"], "'" });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
        }

        private void pfeZyQnoF(object sender, FormClosingEventArgs e)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_0, this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
        }

        private void TgwIjsrYqS_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.method_1();
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            this.Txt_TransNum.Text = new Class6().method_5("K");
            this.Txt_DiscPc.Enabled = false;
            this.Txt_ImpID.Enabled = false;
            this.Txt_GoodsId.Enabled = false;
            this.Txt_ExpID.Enabled = false;
            this.Txt_Qty.Enabled = false;
            this.Txt_OldTrans.Focus();
        }

        private void Txt_ExpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ExpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ExpID.Text, "and type IN('04','06') and status = 1", this.oleDbConnection_1, ref str);
                this.Lbl_ExpName.Text = str;
            }
        }

        private void Txt_ExpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('04','06') and status = 1";
                Class7.BrowserForm1(str, this.oleDbConnection_1);
                this.Txt_ExpID.Text = BrowseForm.strReturn;
                this.Txt_ExpID.SelectAll();
            }
        }

        private void Txt_GoodsId_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            new BookForm().ShowDialog();
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_GoodsId.Text.Trim();
            if (str != string.Empty)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT tr.goods_id, gs.full_name, tr.unit_symb, tr.qty, tr.amount,  tr.discount, tr.vat_amt, tr.surplus, tr.trans_num, (tr.amount + tr.surplus)/tr.qty AS expprice FROM  tblGoods AS gs INNER JOIN  tblTransaction AS tr ON gs.goods_id = tr.goods_id where tr.trans_num = '" + this.string_1 + "' and tr.goods_id = '" + str + "'", this.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_1.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    this.Lbl_MercName.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
                    this.Txt_Price.EditValue = Class7.smethod_2(dataSet.Tables[0].Rows[0]["expprice"]);
                    this.Cmb_Unit.Properties.Items.Add(dataSet.Tables[0].Rows[0]["unit_symb"].ToString());
                    this.Cmb_Unit.Properties.Items.Add(dataSet.Tables[0].Rows[0]["unit_symb"].ToString());
                    this.Cmb_Unit.SelectedIndex = 0;
                    this.Txt_Qty.Text = "1";
                    this.Txt_GoodsId.Focus();
                }
                else
                {
                    this.Lbl_MercName.Text = string.Empty;
                    this.Txt_Price.EditValue = 0;
                }
            }
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Class7.BrowserForm1("SELECT tr.goods_id, gs.full_name, tr.unit_symb, tr.qty, tr.amount, tr.discount, tr.vat_amt,  tr.surplus, tr.trans_num FROM tblGoods AS gs INNER JOIN  tblTransaction AS tr ON gs.goods_id = tr.goods_id where tr.trans_num = '" + this.string_1 + "'", this.oleDbConnection_1);
                this.Txt_GoodsId.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_ImpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ImpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ImpID.Text, "and type IN('02','01') and status = 1", this.oleDbConnection_1, ref str);
                this.Lbl_ImpName.Text = str;
            }
        }

        private void Txt_ImpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('01','02') and status = 1";
                Class7.BrowserForm1(str, this.oleDbConnection_1);
                this.Txt_ImpID.Text = BrowseForm.strReturn;
                this.Txt_ImpID.SelectAll();
            }
        }

        private void Txt_OldTrans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.string_1 = this.Txt_OldTrans.Text.Trim();
                string selectCommandText = "select * from tblTransaction where trans_num = '" + this.string_1 + "' and trans_code = '11' and status = 1 ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_OldTrans.Enabled = false;
                        this.Txt_OldDate.Text = set.Tables[0].Rows[0]["tran_date"].ToString();
                        this.Txt_ExpID.Text = set.Tables[0].Rows[0]["exp_id"].ToString();
                        this.Txt_ImpID.Text = set.Tables[0].Rows[0]["imp_id"].ToString();
                        this.Txt_ExpID.Enabled = false;
                        this.Txt_ImpID.Enabled = true;
                        this.Txt_GoodsId.Enabled = true;
                        this.Txt_Qty.Enabled = true;
                        this.Txt_GoodsId.Focus();
                    }
                    else
                    {
                        Class7.ShowMessageBox("Kh\x00f4ng t\x00ecm thấy giao dịch n\x00e0y !", 1);
                        this.Txt_OldTrans.Focus();
                        this.Txt_OldTrans.SelectAll();
                        return;
                    }
                }
                this.oleDbConnection_1.Close();
            }
        }

        private void Txt_TransNum_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    if (Class11.string_0 == "S")
                    {
                        string str = this.Txt_TransNum.Text.Trim();
                        string str2 = null;
                        string str3 = null;
                        string str4 = null;
                        string str5 = null;
                        bool flag = false;
                        new Class6().method_15(this.string_0, str, ref str2, ref str3, ref str4, ref flag, ref str5, ref this.string_2);
                        this.Txt_ImpID.Text = str2;
                        this.Txt_ExpID.Text = str3;
                        this.Txt_Remark.Text = str4;
                        this.Txt_Voucher.Text = str5;
                        this.method_1();
                        if (this.Lbl_ImpName.Text != string.Empty)
                        {
                            Class11.smethod_3(this);
                            if (!Class7.smethod_50())
                            {
                                this.btn_Edit.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                                this.btn_Delete.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                            }
                            Class11.smethod_5(this, "F");
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select sum(amount) AS a_amt, sum(disc_rate*amount/100) AS d_amt, sum(amount) AS t_amt, sum(vat_amt) AS v_amt from " + this.string_0, this.oleDbConnection_1);
                            DataSet dataSet = new DataSet();
                            this.oleDbDataAdapter_0.Fill(dataSet);
                            this.oleDbConnection_1.Close();
                            if (dataSet.Tables[0].Rows.Count != 0)
                            {
                                this.Txt_ImpAmt.Text = dataSet.Tables[0].Rows[0]["a_amt"].ToString();
                                this.Txt_TotalAmt.Text = dataSet.Tables[0].Rows[0]["t_amt"].ToString();
                                this.Txt_VatAmt.Text = dataSet.Tables[0].Rows[0]["v_amt"].ToString();
                                this.Txt_DiscAmt.Text = dataSet.Tables[0].Rows[0]["d_amt"].ToString();
                            }
                            else
                            {
                                this.Txt_ImpAmt.Text = "0";
                                this.Txt_TotalAmt.Text = "0";
                                this.Txt_VatAmt.Text = "0";
                                this.Txt_DiscAmt.Text = "0";
                            }
                        }
                        if (flag)
                        {
                            this.btn_Delete.Text = "&X\x00f3a";
                            this.btn_Edit.Enabled = true;
                        }
                        else
                        {
                            this.btn_Delete.Text = "&Phục hồi";
                            this.btn_Edit.Enabled = false;
                        }
                    }
                    break;

                case Keys.F5:
                    Class7.BrowserForm1("select trans_num as 'Số giao dịch', goods_id AS 'M\x00e3 h\x00e0ng', exp_id AS 'Nơi xuất', qty AS 'Số lượng', amount AS 'Tổng tiền', Status from tblTransaction where tran_date = '" + Class7.smethod_19() + "' and trans_code = '" + this.welftZbha + "' order by trans_num ", this.oleDbConnection_1);
                    this.Txt_TransNum.Text = BrowseForm.strReturn;
                    break;
            }
        }

    }
}