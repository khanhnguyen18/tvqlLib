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
    public partial class FrmBalance : DevExpress.XtraEditors.XtraForm
    {
        public FrmBalance()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Lbl_MercName.Text))
            {
                this.Txt_GoodsId.Focus();
            }
            else if ((Class7.smethod_0(this.Txt_MinusQty.Text) < 0.0) | (Class7.smethod_0(this.Txt_PlusQty.Text) < 0.0))
            {
                this.Txt_MinusQty.Focus();
            }
            else
            {
                string str = this.Txt_GoodsId.Text.Trim();
                string str2 = this.Lbl_MercName.Text.Trim();
                double num = Class7.smethod_0(this.Txt_MinusQty.Text);
                double num2 = Class7.smethod_0(this.Txt_PlusQty.Text);
                double num3 = Class7.smethod_0(this.Txt_Price.Text);
                double num4 = num3 * num2;
                double num5 = num3 * num;
                string str3 = this.Cmb_Unit.Text.Trim();
                if (Class7.smethod_0(this.Txt_MinusQty.Text) < 0.0)
                {
                    Class7.smethod_15("Số lượng đăng k\x00fd kh\x00f4ng hợp lệ", 1);
                    this.Txt_MinusQty.Focus();
                }
                else if (Class7.smethod_0(this.Txt_PlusQty.Text) < 0.0)
                {
                    Class7.smethod_15("Số lượng đăng k\x00fd kh\x00f4ng hợp lệ", 1);
                    this.Txt_PlusQty.Focus();
                }
                else
                {
                    Class6 class2 = new Class6();
                    string selectCommandText = string.Concat(new object[] { 
                        "IF NOT EXISTS (SELECT goods_id FROM ", this.string_1, " where goods_id = '", str, "') INSERT INTO ", this.string_1, "(goods_id, Name, pqty, mqty, price, mamount, pamount, unitsymb, merc_type) VALUES('", str, "',N'", str2, "',", num2, ",", num, ", ", num3, 
                        ",", num5, ",", num4, ",'", str3, "','01') ELSE UPDATE ", this.string_1, " SET pqty =", num2, ",mqty=", num, ",pamount=", num4, ",mamount= ", num5, 
                        " where goods_id = '", str, "' ; DELETE FROM ", this.string_1, " where mqty = 0 and pqty = 0 "
                     });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                    DataSet dataSet = new DataSet();
                    this.oleDbDataAdapter_0.Fill(dataSet);
                    this.oleDbConnection_1.Close();
                    class2.method_2(this.string_1);
                    this.method_1();
                    this.Txt_PlusQty.Text = "0";
                    this.Txt_MinusQty.Text = "0";
                    this.Txt_GoodsId.Focus();
                    this.Txt_GoodsId.SelectAll();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class11.string_0 == "F")
            {
                string str = this.Txt_TransNum.Text.Trim();
                Class6 class2 = new Class6();
                string text = this.btn_Delete.Text;
                if (text != null)
                {
                    if (!(text == "&X\x00f3a"))
                    {
                        if ((text == "&Phục hồi") && (Class7.smethod_15("Bạn c\x00f3 chắc chắn phục hồi giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1))
                        {
                            class2.method_14("tblTransaction", str, 1);
                            this.method_2();
                            this.btn_Skip_Click(this, new EventArgs());
                        }
                    }
                    else if (Class7.smethod_15("Bạn c\x00f3 chắc chắn x\x00f3a giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1)
                    {
                        this.method_4();
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
            this.Txt_Price.Enabled = false;
            this.Txt_StockId.Enabled = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.method_1();
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            Class6 class2 = new Class6();
            this.Txt_Price.Enabled = false;
            this.Txt_TransNum.Text = class2.method_5("K");
            this.Txt_StockId.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Lbl_StockName.Text == string.Empty)
            {
                this.Txt_StockId.Focus();
            }
            else if (this.TransDetail.RowCount != 0)
            {
                string str5 = Class7.smethod_19();
                string str4 = DateTime.Now.ToString("HH:mm");
                string str3 = this.Txt_TransNum.Text.Trim();
                string str2 = this.Txt_StockId.Text.Trim();
                string str = this.Txt_Remark.Text.Trim();
                Class6 class2 = new Class6();
                string str6 = Class11.string_0;
                if (str6 != null)
                {
                    if (!(str6 == "N"))
                    {
                        if (str6 == "E")
                        {
                            this.bool_0 = false;
                            this.btn_Skip_Click(this, new EventArgs());
                            this.method_4();
                            class2.method_13(str3);
                            this.method_3();
                            this.method_2();
                        }
                    }
                    else
                    {
                        this.bool_0 = true;
                        this.btn_Skip_Click(this, new EventArgs());
                        class2.method_12("K");
                        this.method_3();
                        this.method_2();
                    }
                }
                Class6.string_8 = str;
                Class6.string_9 = str2;
                Class6.string_5 = str3;
                Class6.string_6 = str4;
                Class6.string_7 = str5;
                Class7.smethod_27(Class6.string_3).ShowPreviewDialog();
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
            Class11.smethod_0(this);
            Class11.smethod_5(this, "F");
            this.btn_New.Enabled = Class7.smethod_50();
        }


        private void FrmBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_1, this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
        }

        private void FrmBalance_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.Text = Class6.string_1.ToString();
            this.Lbl_Date.Text = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.btn_Skip_Click(this, new EventArgs());
            try
            {
                string selectCommandText = "CREATE TABLE " + this.string_1 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[pqty] [decimal](8, 2) DEFAULT ((0)),[mqty] [decimal](8, 2) DEFAULT ((0)),[price] [decimal](18, 2) DEFAULT ((0)),[mamount] [decimal](18, 2) DEFAULT ((0)),[pamount] [decimal](18, 2) DEFAULT ((0)),[unitsymb] [nvarchar](3) DEFAULT (('')),[merc_type] [nvarchar](2) DEFAULT (('')))";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
            catch (Exception)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_1, this.oleDbConnection_1);
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
                this.Txt_GoodsId.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "M\x00e3 h\x00e0ng").ToString();
                this.Txt_PlusQty.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "SL thừa").ToString();
                this.Txt_MinusQty.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "SL thiếu").ToString();
                this.Txt_Price.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn gi\x00e1").ToString();
                this.Lbl_MercName.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "T\x00ean h\x00e0ng").ToString();
                this.Cmb_Unit.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn vị").ToString();
            }
        }



        private void method_0()
        {
            Class11.smethod_8(this);
            this.Lbl_StockName.Text = string.Empty;
            this.Lbl_MercName.Text = string.Empty;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_1, this.oleDbConnection_1);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
            }
            this.oleDbConnection_1.Close();
        }

        private void method_1()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT idx AS [TT], goods_id AS [M\x00e3 h\x00e0ng], name AS [T\x00ean h\x00e0ng], unitsymb AS [Đơn vị], price AS [Đơn gi\x00e1], pqty AS [SL thừa], pamount AS [Tổng thừa], mqty AS [SL thiếu], mamount AS [Tổng thiếu] FROM " + this.string_1 + " ORDER BY autoid", this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
            this.GrdTran.DataSource = dataSet.Tables[0];
            this.TransDetail.OptionsBehavior.Editable = false;
            this.TransDetail.Columns["SL thừa"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["SL thừa"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["SL thừa"].SummaryItem.FieldName = "SL thừa";
            this.TransDetail.Columns["SL thừa"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["SL thừa"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.Columns["SL thiếu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["SL thiếu"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["SL thiếu"].SummaryItem.FieldName = "SL thiếu";
            this.TransDetail.Columns["SL thiếu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["SL thiếu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatString = "{0:n0}";
            this.TransDetail.Columns["Tổng thiếu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Tổng thiếu"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Tổng thiếu"].SummaryItem.FieldName = "Tổng thiếu";
            this.TransDetail.Columns["Tổng thiếu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Tổng thiếu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.Columns["Tổng thừa"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Tổng thừa"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Tổng thừa"].SummaryItem.FieldName = "Tổng thừa";
            this.TransDetail.Columns["Tổng thừa"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Tổng thừa"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.BestFitColumns();
        }

        private void method_2()
        {
            string str = this.Txt_StockId.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + this.string_1, this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                double num1 = (Class7.smethod_0(row["pqty"].ToString()) == 0.0) ? Class7.smethod_0(row["mqty"].ToString()) : Class7.smethod_0(row["pqty"].ToString());
                double num2 = (Class7.smethod_0(row["pamount"].ToString()) == 0.0) ? Class7.smethod_0(row["mamount"].ToString()) : Class7.smethod_0(row["pamount"].ToString());
                string selectCommandText = string.Concat(new object[] { 
                    "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '", str, "' and goods_id = '", row["goods_id"], "') UPDATE  tblStockInfo SET Imp_qty = imp_qty + ", row["pqty"], " , imp_amt = imp_amt + ", row["pamount"], ",  exp_qty = exp_qty + ", row["mqty"], ", exp_amt = exp_amt + ", row["mamount"], ", last_date ='", Class6.string_13, "' WHERE id = '", str, 
                    "' AND goods_id = '", row["goods_id"], "' Else INSERT INTO tblStockInfo(id,goods_id, Imp_qty,imp_amt,exp_qty, exp_amt, last_date )  VALUES('", str, "','", row["goods_id"], "',", row["pqty"], ", ", row["pamount"], ",", row["mqty"], ",", row["mamount"], ",'", Class6.string_13, 
                    "')"
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
        }

        private void method_3()
        {
            string str = Class7.smethod_19();
            string text1 = this.bool_0 ? Class7.smethod_53() : this.string_3;
            string str2 = this.Txt_TransNum.Text.Trim();
            string str3 = this.Txt_StockId.Text.Trim();
            string str4 = this.Txt_Remark.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + this.string_1, this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                string str6 = (Class7.smethod_0(row["mqty"].ToString()) == 0.0) ? "" : str3;
                string str5 = (Class7.smethod_0(row["pqty"].ToString()) == 0.0) ? "" : str3;
                double num = (Class7.smethod_0(row["pqty"].ToString()) == 0.0) ? Class7.smethod_0(row["mqty"].ToString()) : Class7.smethod_0(row["pqty"].ToString());
                double num2 = (Class7.smethod_0(row["mamount"].ToString()) == 0.0) ? Class7.smethod_0(row["pamount"].ToString()) : Class7.smethod_0(row["mamount"].ToString());
                string selectCommandText = string.Concat(new object[] { 
                    "INSERT INTO tblTransaction(tran_date, tran_time, trans_num, trans_code, voucher, invoice, post, exp_id, imp_id,goods_id, qty, unit_symb, amount, discount, vat_amt, surplus, commis_amt, user_id,cs_id,remark, updated, merc_type, tax_code, vat_incl, discpervat, disc_incl, copies, recnum, Status,station) VALUES('", str, "',convert(VARCHAR(5),getdate(),108),'", str2, "','", this.string_2, "','','',0,'", str6, "','", str5, "','", row["goods_id"], "',", num, ",'", row["unitsymb"], 
                    "',", num2, ",0,0,0,0, ", Class7.GetUserRight(), ",'',N'", str4, "',0,'01','',0,0,0,0,", row["idx"], ",1,", Class7.smethod_51(), ")"
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_1.Close();
            }
        }

        private void method_4()
        {
            string str = this.Txt_TransNum.Text.Trim();
            string str2 = this.Txt_StockId.Text.Trim();
            string selectCommandText = "SELECT  goods_id,imp_id,exp_id, qty, amount FROM tblTransaction WHERE trans_num = '" + str + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                double num = (row["exp_id"].ToString().Trim() == string.Empty) ? Class7.smethod_0(row["qty"].ToString()) : 0.0;
                double num2 = (row["imp_id"].ToString().Trim() == string.Empty) ? Class7.smethod_0(row["qty"].ToString()) : 0.0;
                double num3 = (row["exp_id"].ToString().Trim() == string.Empty) ? Class7.smethod_0(row["amount"].ToString()) : 0.0;
                double num4 = (row["imp_id"].ToString().Trim() == string.Empty) ? Class7.smethod_0(row["amount"].ToString()) : 0.0;
                double num1 = Class7.smethod_0(row["amount"].ToString()) / Class7.smethod_0(row["qty"].ToString());
                selectCommandText = string.Concat(new object[] { "UPDATE  tblStockInfo SET exp_qty = exp_qty - ", num2, ",exp_amt = exp_amt - ", num4, ", imp_qty = imp_qty - ", num, ", imp_amt = imp_amt - ", num3, " WHERE id = '", str2, "' AND goods_id = '", row["goods_id"].ToString(), "' " });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            if (Class7.smethod_0(this.Txt_MinusQty.Text) != 0.0)
            {
                this.Txt_PlusQty.Text = "0";
            }
            if (Class7.smethod_0(this.Txt_PlusQty.Text) != 0.0)
            {
                this.Txt_MinusQty.Text = "0";
            }
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            string str3;
            if (e.KeyCode == Keys.F5)
            {
                Class7.smethod_16("select goods_id as 'M\x00e3 số', full_name AS 'Diễn giải' from tblGoods where status = 1 and mbc = 0", this.oleDbConnection_1);
                this.Txt_GoodsId.Text = FrmBrowse.strReturn;
                this.Txt_GoodsId.SelectAll();
            }
            if (e.KeyCode != Keys.Return)
            {
                return;
            }
            string str = this.Txt_GoodsId.Text.Trim();
            string str2 = Class7.smethod_14("m_plu").ToString().Trim();
            if (str.Length > 6)
            {
                DataSet set;
                if (str.Substring(0, str2.Length) == str2)
                {
                    this.string_0 = "select goods_id from tblNon_Plu where nplu_code = '" + str.Substring(0, str2.Length) + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_1);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        if (set.Tables[0].Rows.Count != 0)
                        {
                            this.Txt_GoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                        }
                        this.oleDbConnection_1.Close();
                        goto Label_01F1;
                    }
                }
                this.string_0 = "select goods_id from tblbarcode where barcode = '" + str + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_1);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_GoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                    }
                    this.oleDbConnection_1.Close();
                }
            }
        Label_01F1:
            str3 = this.Txt_GoodsId.Text.Trim();
            string str4 = this.Txt_StockId.Text.Trim();
            if (str3 != string.Empty)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT  A.goods_id, A.full_name, A.packunit, A.piceunit, B.lastimppr, B.prefprice FROM  tblGoods AS A  INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id where A.goods_id = '" + str3 + "'", this.oleDbConnection_1);
                using (DataSet set2 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set2);
                    this.oleDbConnection_1.Close();
                    if (set2.Tables[0].Rows.Count != 0)
                    {
                        this.Lbl_MercName.Text = set2.Tables[0].Rows[0]["full_name"].ToString();
                        this.Cmb_Unit.Properties.Items.Add(set2.Tables[0].Rows[0]["piceunit"].ToString());
                        this.Cmb_Unit.Properties.Items.Add(set2.Tables[0].Rows[0]["piceunit"].ToString());
                        this.Cmb_Unit.SelectedIndex = 0;
                        Class6 class2 = new Class6();
                        this.Txt_EndQty.EditValue = class2.method_21(str3, str4);
                        if (class2.method_21(str3, str4) == 0.0)
                        {
                            this.Txt_Price.EditValue = Class7.smethod_0(set2.Tables[0].Rows[0]["lastimppr"].ToString());
                        }
                        else
                        {
                            this.Txt_Price.EditValue = class2.method_16(str4, str3);
                        }
                        this.Txt_GoodsId.Focus();
                    }
                    else
                    {
                        this.Lbl_MercName.Text = string.Empty;
                        this.Txt_Price.EditValue = 0;
                    }
                }
            }
        }

        private void Txt_StockId_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_StockId.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_StockId.Text, "and type IN('01','02') and status = 1", this.oleDbConnection_1, ref str);
                this.Lbl_StockName.Text = str;
            }
        }

        private void Txt_StockId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean kho h\x00e0ng', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('01','02') and status = 1";
                Class7.smethod_16(str, this.oleDbConnection_1);
                this.Txt_StockId.Text = FrmBrowse.strReturn;
                this.Txt_StockId.SelectAll();
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
                        bool flag = false;
                        string selectCommandText = "SELECT  A.goods_id,A.imp_id,A.exp_id, B.full_name, A.qty, A.amount, A.discount,A.unit_symb, A.merc_type, A.recnum, A.status, A.remark FROM tblTransaction AS A INNER JOIN tblGoods AS B ON A.goods_id = B.goods_id WHERE A.trans_num = '" + str + "' AND tran_date = '" + Class7.smethod_19() + "'  ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                        DataTable dataTable = new DataTable();
                        this.oleDbDataAdapter_0.Fill(dataTable);
                        this.oleDbConnection_1.Close();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            double num = (row["exp_id"].ToString().Trim() == string.Empty) ? Class7.smethod_0(row["qty"].ToString()) : 0.0;
                            double num4 = (row["imp_id"].ToString().Trim() == string.Empty) ? Class7.smethod_0(row["qty"].ToString()) : 0.0;
                            double num5 = (row["exp_id"].ToString().Trim() == string.Empty) ? Class7.smethod_0(row["amount"].ToString()) : 0.0;
                            double num2 = (row["imp_id"].ToString().Trim() == string.Empty) ? Class7.smethod_0(row["amount"].ToString()) : 0.0;
                            double num3 = Class7.smethod_0(row["amount"].ToString()) / Class7.smethod_0(row["qty"].ToString());
                            selectCommandText = string.Concat(new object[] { 
                                "INSERT INTO ", this.string_1, "(idx, goods_id, Name, pqty, mqty, price, mamount, pamount, unitsymb, merc_type) VALUES(", row["recnum"], ",'", row["goods_id"], "',N'", row["full_name"], "',", num, ",", num4, ", ", num3, ",", num2, 
                                ",", num5, ",'", row["unit_symb"], "','01') "
                             });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                            DataSet dataSet = new DataSet();
                            this.oleDbDataAdapter_0.Fill(dataSet);
                            this.oleDbConnection_1.Close();
                        }
                        this.Txt_StockId.Text = (dataTable.Rows[0]["imp_id"].ToString().Trim() == string.Empty) ? dataTable.Rows[0]["exp_id"].ToString().Trim() : dataTable.Rows[0]["imp_id"].ToString().Trim();
                        this.Txt_Remark.Text = dataTable.Rows[0]["remark"].ToString().Trim();
                        this.string_3 = dataTable.Rows[0]["tran_time"].ToString().Trim();
                        flag = (bool)dataTable.Rows[0]["status"];
                        this.method_1();
                        if (this.Lbl_StockName.Text != string.Empty)
                        {
                            Class11.smethod_3(this);
                            if (!Class7.smethod_50())
                            {
                                this.btn_Edit.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                                this.btn_Delete.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                            }
                            Class11.smethod_5(this, "F");
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
                    Class7.smethod_16("select trans_num as 'Số giao dịch', goods_id AS 'M\x00e3 h\x00e0ng', exp_id AS 'Nơi xuất', qty AS 'Số lượng', amount AS 'Tổng tiền', Status from tblTransaction where tran_date = '" + Class7.smethod_19() + "' and trans_code = '" + this.string_2 + "' order by trans_num ", this.oleDbConnection_1);
                    this.Txt_TransNum.Text = FrmBrowse.strReturn;
                    break;
            }
        }
  
    }
}