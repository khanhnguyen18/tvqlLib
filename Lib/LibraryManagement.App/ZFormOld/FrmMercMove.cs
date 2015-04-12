using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmMercMove : DevExpress.XtraEditors.XtraForm
    {
        public FrmMercMove()
        {
            InitializeComponent();
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class11.string_0 != "F")
            {
                return;
            }
            string str = this.Txt_TransNum.Text.Trim();
            this.Txt_ImpID.Text.Trim();
            Class6 class2 = new Class6();
            string text = this.btn_Delete.Text;
            if (text == null)
            {
                return;
            }
            if (!(text == "&X\x00f3a"))
            {
                if ((text == "&Phục hồi") && (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn phục hồi giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1))
                {
                    this.iWyIskLbe(this, new EventArgs());
                    class2.method_14("tblTransaction", str, 1);
                    class2.method_17(str);
                    this.method_2();
                    this.method_3();
                }
                return;
            }
            if (!class2.method_22())
            {
                this.string_0 = "select goods_id, imp_id, qty from tblTransaction where trans_num = '" + str + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_1);
                using (DataTable table = new DataTable())
                {
                    this.oleDbDataAdapter_0.Fill(table);
                    this.oleDbConnection_1.Close();
                    IEnumerator enumerator = table.Rows.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            DataRow current = (DataRow)enumerator.Current;
                            if (class2.method_21(current["goods_id"].ToString(), current["imp_id"].ToString()) < Class7.smethod_2(current["qty"]))
                            {
                                goto Label_0174;
                            }
                        }
                        goto Label_01A9;
                    Label_0174:
                        Class7.ShowMessageBox("Số lượng tồn kh\x00f4ng đủ để x\x00f3a giao dịch n\x00e0y !", 1);
                        return;
                }
            }
        Label_01A9:
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1)
            {
                this.iWyIskLbe(this, new EventArgs());
                class2.method_18(str);
                this.IjSwogAv6();
                this.method_4();
                class2.method_14("tblTransaction", str, 0);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_ImpID.Enabled = false;
            this.Txt_ExpID.Enabled = false;
            this.Txt_Price.Enabled = false;
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
            this.Txt_TransNum.Text = new Class6().method_5("K");
            this.Txt_Price.Enabled = false;
            this.Txt_ExpID.Focus();
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
                string str = this.Txt_TransNum.Text.Trim();
                string str3 = this.Txt_ExpID.Text.Trim();
                string str4 = this.Txt_ImpID.Text.Trim();
                string str6 = this.Txt_Remark.Text.Trim();
                string str5 = string.Empty;
                if (this.TransDetail.RowCount != 0)
                {
                    Class6 class2 = new Class6();
                    WaitDialogForm form = new WaitDialogForm();
                    form.Caption = "Xin chờ một ch\x00fat ....";
                    
                    string str7 = Class11.string_0;
                    if (str7 != null)
                    {
                        if (!(str7 == "N"))
                        {
                            if (str7 == "E")
                            {
                                this.iWyIskLbe(this, new EventArgs());
                                class2.method_18(str);
                                this.IjSwogAv6();
                                this.method_4();
                                this.method_2();
                                this.method_3();
                                class2.method_13(str);
                                class2.method_6(this.string_1, str, this.string_4, str3, str4, str5, str6, this.string_3);
                            }
                        }
                        else
                        {
                            this.iWyIskLbe(this, new EventArgs());
                            class2.ComputeTransnum("K");
                            string str8 = Class7.smethod_53();
                            class2.method_6(this.string_1, str, this.string_4, str3, str4, str5, str6, str8);
                            class2.method_17(str);
                            this.method_3();
                            this.method_2();
                        }
                    }
                    if (this.chkLabelPrn.Checked)
                    {
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE  FROM tblLABELS", this.oleDbConnection_1);
                        DataSet dataSet = new DataSet();
                        this.oleDbDataAdapter_0.Fill(dataSet);
                        this.oleDbConnection_1.Close();
                        string selectCommandText = "SELECT A.goods_id, A.full_name, A.grp_id,A.piceunit, A.merc_type, B.rtprice, C.trans_num,C.qty, C.exp_id,C.imp_id, C.recnum FROM tblGoods AS A INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id  INNER JOIN tblTransaction AS C ON A.goods_id = C.goods_id where C.trans_num = '" + str + "' ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, Class7.oleDbConnection_1);
                        DataTable dataTable = new DataTable();
                        this.oleDbDataAdapter_0.Fill(dataTable);
                        Class7.oleDbConnection_1.Close();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            selectCommandText = "INSERT INTO tblLABELS([idx],[timeinput],[goods_id],[fullname],[shortname],[grp_id],[supp_id],[rtprice],[qty],user_id) ";
                            object obj2 = selectCommandText;
                            obj2 = string.Concat(new object[] { obj2, "VALUES(", row["recnum"], ",'", row["recnum"].ToString(), "','", row["goods_id"], "','", row["full_name"], "','", row["full_name"], "'," });
                            OleDbDataAdapter adapter = new OleDbDataAdapter(string.Concat(new object[] { obj2, "'", row["grp_id"], "','", row["exp_id"], "','", row["rtprice"], "',", row["qty"], ",", Class7.GetUserId(), ")" }), this.oleDbConnection_1);
                            using (DataSet set2 = new DataSet())
                            {
                                adapter.Fill(set2);
                            }
                            this.oleDbConnection_1.Close();
                        }
                    }
                    form.Close();
                    Class6.transNum = str;
                    Class7.CreateReportInstance("v_mercmove").ShowPreviewDialog();
                    Class7.CreateReportInstance("v_mercmove1").ShowPreviewDialog();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Lbl_MercName.Text))
            {
                this.Txt_GoodsId.Focus();
            }
            else
            {
                string str = this.Txt_GoodsId.Text.Trim();
                string str2 = this.Txt_ExpID.Text.Trim();
                string str3 = this.Lbl_MercName.Text.Trim();
                double num = Class7.smethod_0(this.Txt_Qty.Text);
                double num2 = Class7.smethod_0(this.Txt_Price.Text);
                string str4 = this.Cmb_Unit.Text.Trim();
                Class6 class2 = new Class6();
                if (!class2.method_22() && (class2.method_21(str, str2) < num))
                {
                    Class7.ShowMessageBox("Số lượng tồn kh\x00f4ng đủ để xuất kho !", 1);
                    this.Txt_Qty.Focus();
                }
                else if (Class7.smethod_0(this.Txt_Qty.Text) < 0.0)
                {
                    Class7.ShowMessageBox("Số lượng nhập đăng k\x00fd kh\x00f4ng hợp lệ", 1);
                    this.Txt_Qty.Focus();
                }
                else
                {
                    class2.method_1(this.string_1, str, str3, num, 0.0, num2, str4, "01");
                    class2.method_2(this.string_1);
                    this.method_1();
                    this.Txt_Qty.Text = "1";
                    this.Txt_GoodsId.Focus();
                    this.Txt_GoodsId.SelectAll();
                }
            }
        }

        private void chkLabelPrn_CheckedChanged(object sender, EventArgs e)
        {
        }


        private void FrmMercMove_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_1, this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
        }

        private void FrmMercMove_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.Text = Class6.string_1.ToString();
            this.Lbl_Date.Text = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.iWyIskLbe(this, new EventArgs());
            try
            {
                string selectCommandText = "CREATE TABLE " + this.string_1 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((1)),[price] [decimal](18, 2) DEFAULT ((0)),[amount] [decimal](18, 2) DEFAULT ((0)),[disc_amt] [decimal](18, 2) DEFAULT ((0)),[surplus] [decimal](18, 2) DEFAULT ((0)),[unitsymb] [nvarchar](3) DEFAULT (('')),[vat_amt] [decimal](18, 2) DEFAULT ((0)),[merc_type] [nvarchar](2) DEFAULT (('')))";
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
                this.Txt_Qty.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Số lượng").ToString();
                this.Txt_Price.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn gi\x00e1").ToString();
                this.Lbl_MercName.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "T\x00ean h\x00e0ng").ToString();
                this.Cmb_Unit.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn vị").ToString();
            }
        }

        private void IjSwogAv6()
        {
            string str = this.Txt_TransNum.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT imp_id, goods_id, qty, amount FROM  tblTransaction WHERE trans_num = '" + str + "' ", this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                string selectCommandText = string.Concat(new object[] { "UPDATE  tblStockInfo SET Imp_qty = imp_qty - ", row["qty"], " ,imp_amt = imp_amt - ", row["amount"], ",  last_date ='", Class6.string_13, "' WHERE id = '", row["imp_id"].ToString(), "' AND goods_id = '", row["goods_id"].ToString(), "' " });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
        }



        private void iWyIskLbe(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
        }

        private void method_0()
        {
            Class11.smethod_8(this);
            this.Lbl_ImpName.Text = string.Empty;
            this.Lbl_ExpName.Text = string.Empty;
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
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT idx AS [TT], goods_id AS [M\x00e3 h\x00e0ng], name AS [T\x00ean h\x00e0ng], qty AS [Số lượng], unitsymb AS [Đơn vị], price AS [Đơn gi\x00e1], amount AS [Th\x00e0nh tiền] FROM " + this.string_1 + " ORDER BY autoid", this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
            this.GrdTran.DataSource = dataSet.Tables[0];
            this.TransDetail.OptionsBehavior.Editable = false;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Số lượng"].SummaryItem.FieldName = "Số lượng";
            this.TransDetail.Columns["Số lượng"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Số lượng"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Đơn gi\x00e1"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.FieldName = "Th\x00e0nh tiền";
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Th\x00e0nh tiền"].SummaryItem.DisplayFormat = "{0:n2}";
            this.TransDetail.BestFitColumns();
        }

        private void method_2()
        {
            string str = this.Txt_ImpID.Text.Trim();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT goods_id, qty, amount FROM  " + this.string_1, this.oleDbConnection_1);
            using (DataTable table = new DataTable())
            {
                adapter.Fill(table);
                this.oleDbConnection_1.Close();
                foreach (DataRow row in table.Rows)
                {
                    adapter = new OleDbDataAdapter(string.Concat(new object[] { 
                        "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '", str, "' AND goods_id = '", row["goods_id"], "') UPDATE  tblStockInfo SET Imp_qty = imp_qty + ", row["qty"], " , imp_amt = imp_amt + ", row["amount"], ",  last_date ='", Class6.string_13, "'  WHERE id = '", str, "' AND goods_id = '", row["goods_id"], "'  Else INSERT INTO tblStockInfo(id,goods_id, Imp_qty,imp_amt,last_date )   VALUES('", str, 
                        "','", row["goods_id"], "',", row["qty"], ",", row["amount"], ",'", Class6.string_13, "')"
                     }), this.oleDbConnection_1);
                    using (DataSet set = new DataSet())
                    {
                        adapter.Fill(set);
                    }
                    this.oleDbConnection_1.Close();
                }
            }
        }

        private void method_3()
        {
            string str = this.Txt_ExpID.Text.Trim();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT goods_id, qty, amount FROM  " + this.string_1, this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.oleDbConnection_1.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                adapter = new OleDbDataAdapter(string.Concat(new object[] { 
                    "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '", str, "' AND goods_id = '", row["goods_id"], "') UPDATE  tblStockInfo SET exp_qty = exp_qty + ", row["qty"], " ,exp_amt = exp_amt + ", row["amount"], ", last_date ='", Class6.string_13, "' WHERE id = '", str, "' AND goods_id = '", row["goods_id"], "' Else INSERT INTO tblStockInfo(id,goods_id, exp_qty,exp_amt,last_date )  VALUES('", str, 
                    "','", row["goods_id"], "',", row["qty"], ", ", row["amount"], ",'", Class6.string_13, "')"
                 }), this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    adapter.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
        }

        private void method_4()
        {
            string str = this.Txt_TransNum.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT exp_id, goods_id, qty, amount FROM  tblTransaction WHERE trans_num = '" + str + "' ", this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                string selectCommandText = string.Concat(new object[] { "UPDATE  tblStockInfo SET exp_qty = exp_qty - ", row["qty"], ",exp_amt = exp_amt - ", row["amount"], ", last_date ='", Class6.string_13, "' WHERE id = '", row["exp_id"].ToString(), "' AND goods_id = '", row["goods_id"].ToString(), "' " });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
        }

        private void method_5(object sender, KeyEventArgs e)
        {
        }

        private void Txt_EndQty_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_ExpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ExpID.Text == string.Empty))
            {
                string str = "and id <> '" + this.Txt_ImpID.Text.Trim() + "' and type IN('02','01') and status = 1";
                string str2 = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ExpID.Text, str, this.oleDbConnection_1, ref str2);
                this.Lbl_ExpName.Text = str2;
            }
        }

        private void Txt_ExpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải' FROM tblStore " + ("where id <> '" + this.Txt_ImpID.Text.Trim() + "' and type IN('02','01') and status = 1"), this.oleDbConnection_1);
                this.Txt_ExpID.Text = BrowseForm.strReturn;
                this.Txt_ExpID.SelectAll();
            }
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            string str3;
            DataSet set2;
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("select goods_id as 'M\x00e3 số', full_name AS 'Diễn giải' from tblGoods where status = 1", this.oleDbConnection_1);
                this.Txt_GoodsId.Text = BrowseForm.strReturn;
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
                        goto Label_01E6;
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
        Label_01E6:
            str3 = this.Txt_GoodsId.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT  A.goods_id, A.full_name, A.packunit, A.piceunit, B.lastimppr, B.prefprice FROM  tblGoods AS A  INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id where A.goods_id = '" + str3 + "'", this.oleDbConnection_1);
            using (set2 = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set2);
                this.oleDbConnection_1.Close();
                if (set2.Tables[0].Rows.Count != 0)
                {
                    this.Lbl_MercName.Text = set2.Tables[0].Rows[0]["full_name"].ToString();
                    this.Txt_Price.EditValue = Class7.smethod_0(set2.Tables[0].Rows[0]["prefprice"].ToString());
                    this.Cmb_Unit.Properties.Items.Add(set2.Tables[0].Rows[0]["piceunit"].ToString());
                    this.Cmb_Unit.Properties.Items.Add(set2.Tables[0].Rows[0]["piceunit"].ToString());
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
            string str4 = this.Txt_ExpID.Text.Trim();
            if (str3 != string.Empty)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT  A.goods_id, A.full_name, A.packunit, A.piceunit, B.lastimppr,B.prefprice  FROM  tblGoods AS A INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id where A.goods_id = '" + str3 + "'", this.oleDbConnection_1);
                using (set2 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set2);
                    this.oleDbConnection_1.Close();
                    if (set2.Tables[0].Rows.Count != 0)
                    {
                        this.Lbl_MercName.Text = set2.Tables[0].Rows[0]["full_name"].ToString();
                        this.Cmb_Unit.Properties.Items.Add(set2.Tables[0].Rows[0]["piceunit"].ToString());
                        this.Cmb_Unit.Properties.Items.Add(set2.Tables[0].Rows[0]["piceunit"].ToString());
                        this.Cmb_Unit.SelectedIndex = 0;
                        this.Txt_Qty.Text = "1";
                        Class6 class2 = new Class6();
                        this.Txt_EndQty.EditValue = class2.method_21(str3, str4);
                        this.Txt_Price.EditValue = class2.method_16(str4, str3);
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

        private void Txt_ImpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ImpID.Text == string.Empty))
            {
                string str = null;
                string str2 = "and id <> '" + this.Txt_ExpID.Text.Trim() + "' and type IN('02','01') and status = 1";
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ImpID.Text, str2, this.oleDbConnection_1, ref str);
                this.Lbl_ImpName.Text = str;
            }
        }

        private void Txt_ImpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải' FROM tblStore " + ("where id <> '" + this.Txt_ExpID.Text.Trim() + "' and type IN('02','01') and status = 1"), this.oleDbConnection_1);
                this.Txt_ImpID.Text = BrowseForm.strReturn;
                this.Txt_ImpID.SelectAll();
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
                        if (Class7.GetUserId() == 1)
                        {
                            this.string_0 = "SELECT * FROM tblTransaction WHERE trans_num = '" + this.Txt_TransNum.Text.Trim() + "' ";
                        }
                        else
                        {
                            this.string_0 = "SELECT * FROM tblTransaction WHERE trans_num = '" + this.Txt_TransNum.Text.Trim() + "' AND tran_date = '" + Class7.smethod_19() + "'";
                        }
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_1);
                        using (DataSet set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_1.Close();
                            if (set.Tables[0].Rows.Count == 0)
                            {
                                Class7.ShowMessageBox("Kh\x00f4ng t\x00ecm thấy giao dịch n\x00e0y", 1);
                                this.Txt_TransNum.Focus();
                                this.Txt_TransNum.SelectAll();
                                return;
                            }
                        }
                        string str = this.Txt_TransNum.Text.Trim();
                        string str2 = null;
                        string str3 = null;
                        string str4 = null;
                        string str5 = null;
                        bool flag = false;
                        new Class6().method_15(this.string_1, str, ref str2, ref str3, ref str4, ref flag, ref str5, ref this.string_3);
                        this.Txt_ImpID.Text = str2;
                        this.Txt_ExpID.Text = str3;
                        this.Txt_Remark.Text = str4;
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

                case Keys.F2:
                    Class7.BrowserForm1("select trans_num as 'Số giao dịch', goods_id AS 'M\x00e3 h\x00e0ng', exp_id AS 'Nơi xuất', qty AS 'Số lượng', amount AS 'Tổng tiền', Status from tblTransaction where tran_date = '" + Class7.smethod_19() + "' and trans_code = '" + this.string_4 + "' order by trans_num ", this.oleDbConnection_1);
                    this.Txt_TransNum.Text = BrowseForm.strReturn;
                    break;
            }
        }
  
    }
}