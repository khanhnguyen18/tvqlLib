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
    public partial class FrmToSuppByTr : DevExpress.XtraEditors.XtraForm
    {
        public FrmToSuppByTr()
        {
            InitializeComponent();
        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class11.string_0 == "F")
            {
                string str = this.Txt_TransNum.Text.Trim();
                string str3 = this.Txt_ExpID.Text.Trim();
                Class6 class2 = new Class6();
                string text = this.btn_Delete.Text;
                if (text != null)
                {
                    if (!(text == "&X\x00f3a"))
                    {
                        if ((text == "&Phục hồi") && (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn phục hồi giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1))
                        {
                            class2.method_14("tblTransaction", str, 1);
                            class2.method_19(str);
                            class2.method_9(str, str3);
                            this.btn_Skip_Click(this, new EventArgs());
                        }
                    }
                    else if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1)
                    {
                        class2.method_20(str);
                        class2.method_10(str);
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

        private void btn_New_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.method_1();
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            this.Txt_TransNum.Text = new Class6().method_5("K");
            this.Txt_OldTrans.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string str7;
            string str = this.Txt_TransNum.Text.Trim();
            string str2 = this.Txt_OldTrans.Text.Trim();
            string str3 = this.Txt_ExpID.Text.Trim();
            string str4 = this.Txt_ImpID.Text.Trim();
            string str5 = this.Txt_Remark.Text.Trim();
            string str6 = this.Txt_Voucher.Text.Trim();
            if (this.TransDetail.RowCount == 0)
            {
                return;
            }
            Class6 class2 = new Class6();
            if (!class2.method_22())
            {
                this.string_4 = "select goods_id, imp_id, qty from tblTransaction where trans_num = '" + str2 + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_4, this.oleDbConnection_1);
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
                                goto Label_0149;
                            }
                        }
                        goto Label_0183;
                    Label_0149:
                        Class7.ShowMessageBox("Số lượng tồn kh\x00f4ng đủ để xuất kho !", 1);
                        return;
                }
            }
        Label_0183:
            str7 = Class11.string_0;
            if (str7 != null)
            {
                if (!(str7 == "N"))
                {
                    if (str7 == "E")
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        class2.method_20(str);
                        class2.method_10(str);
                        class2.method_13(str);
                        class2.method_6(this.string_0, str, this.string_1, str3, str4, str6, str5, this.string_3);
                        class2.method_9(str, str3);
                    }
                }
                else
                {
                    this.btn_Skip_Click(this, new EventArgs());
                    class2.ComputeTransnum("K");
                    this.ddvqeXfa4(this.string_0, str, this.string_1, str3, str4, str6, str5);
                    class2.method_19(str);
                    class2.method_9(str, str3);
                }
            }
            Class6.transNum = str;
            Class7.smethod_27(Class6.string_3).ShowPreviewDialog();
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
                string str = this.Txt_GoodsId.Text.Trim();
                string str4 = this.Txt_ExpID.Text.Trim();
                string str2 = this.Lbl_MercName.Text.Trim();
                double num = Class7.smethod_0(this.Txt_Qty.Text);
                double num2 = Class7.smethod_0(this.Txt_Price.Text);
                string str3 = this.Cmb_Unit.Text.Trim();
                Class6 class2 = new Class6();
                if (!class2.method_22() && (class2.method_21(str, str4) < num))
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
                    class2.method_1(this.string_0, str, str2, num, 0.0, num2, str3, "01");
                    class2.method_2(this.string_0);
                    this.method_1();
                    this.Txt_Qty.Text = "1";
                    this.Txt_GoodsId.Focus();
                    this.Txt_GoodsId.SelectAll();
                }
            }
        }

        private void ddvqeXfa4(string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id,qty,price,amount,idx,unitsymb, disc_amt,vat_amt,surplus,merc_type FROM " + string_5, this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            string str = string.Format("{0:d}", Class7.smethod_19());
            double num = 0.0;
            string str2 = Class7.smethod_53();
            foreach (DataRow row in dataTable.Rows)
            {
                num = Class7.smethod_2(row["amount"]);
                this.string_4 = string.Concat(new object[] { 
                    "INSERT INTO tblTransaction(tran_date, tran_time, trans_num, trans_code, voucher, invoice, post, exp_id, imp_id, goods_id, qty, unit_symb, amount, discount, vat_amt, surplus, commis_amt, user_id, cs_id, remark, updated, merc_type, tax_code, vat_incl, discpervat, disc_incl, copies, recnum, Status,station,ref) VALUES('", str, "','", str2, "','", string_6, "','", string_7, "','", string_10, "','',0,'", string_8, "','", string_9, "','", row["goods_id"], 
                    "', ", row["qty"], ", '", row["unitsymb"], "',", num, ", ", row["disc_amt"], ", ", row["vat_amt"], ", ", row["surplus"], ", 0, ", Class7.GetUserRight(), ",'' ,N'", string_11, 
                    "' ,0 ,'", row["merc_type"], "' ,'' ,0 ,0 ,0 ,0 ,", row["idx"], " ,1,", Class7.smethod_51(), ",'", this.Txt_OldTrans.Text, "')"
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_4, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
            }
        }



        private void FrmToSuppByTr_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_0, this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
        }

        private void FrmToSuppByTr_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.Text = Class6.string_1.ToString();
            this.Lbl_Date.Text = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.btn_Skip_Click(this, new EventArgs());
            try
            {
                string selectCommandText = "CREATE TABLE " + this.string_0 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((1)),[price] [decimal](18, 2) DEFAULT ((0)),[amount] [decimal](18, 2) DEFAULT ((0)),[disc_amt] [decimal](18, 2) DEFAULT ((0)),[unitsymb] [nvarchar](3) DEFAULT (('')),[vat_amt] [decimal](18, 2) DEFAULT ((0)),[merc_type] [nvarchar](2) DEFAULT (('')),[surplus] [decimal](18, 2) DEFAULT ((0)),[disc_pc] [decimal](3, 2) DEFAULT ((0)))";
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
                Class7.smethod_0(this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Th\x00e0nh tiền").ToString());
                this.Txt_GoodsId.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "M\x00e3 h\x00e0ng").ToString();
                this.Txt_Qty.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Số lượng").ToString();
                this.Txt_Price.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn gi\x00e1").ToString();
                this.Lbl_MercName.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "T\x00ean h\x00e0ng").ToString();
                this.Cmb_Unit.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn vị").ToString();
            }
        }



        private void method_0()
        {
            Class11.smethod_8(this);
            this.welftZbha.Text = string.Empty;
            this.Lbl_ExpName.Text = string.Empty;
            this.Lbl_MercName.Text = string.Empty;
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
            this.TransDetail.Columns["Số lượng"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Số lượng"].SummaryItem.FieldName = "Số lượng";
            this.TransDetail.Columns["Số lượng"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.TransDetail.Columns["Số lượng"].SummaryItem.DisplayFormat = "{0:n2}";
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
            this.Txt_ImpAmt.EditValue = 0;
            this.Txt_TotalAmt.EditValue = 0;
            this.Txt_VatAmt.EditValue = 0;
            this.Txt_DiscAmt.EditValue = 0;
            double num = Class7.smethod_0(this.Txt_Vatrate.Text) / 100.0;
            string text = this.Cmb_TaxCode.Text;
            if (text != null)
            {
                if (text != "A00")
                {
                    if (!(text == "A05"))
                    {
                        if (text == "A10")
                        {
                            num = 0.1;
                        }
                    }
                    else
                    {
                        num = 0.05;
                    }
                }
                else
                {
                    num = 0.0;
                }
            }
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + this.string_0, this.oleDbConnection_1);
            using (DataTable table = new DataTable())
            {
                this.oleDbDataAdapter_0.Fill(table);
                this.oleDbConnection_1.Close();
                foreach (DataRow row in table.Rows)
                {
                    double num2 = Class7.smethod_2(row["amount"]);
                    double num3 = Class7.smethod_2(row["amount"]);
                    double num4 = Class7.smethod_2(row["disc_pc"]);
                    if (this.Chk_discpervat.Checked)
                    {
                        if (this.Chk_includedisc.Checked)
                        {
                            num2 /= 1.0 + ((num4 / 100.0) / (1.0 - (num4 / 100.0)));
                        }
                        this.Txt_DiscAmt.EditValue = Class7.smethod_2(this.Txt_DiscAmt.EditValue) + ((num2 * (num4 / 100.0)) / (1.0 - (num4 / 100.0)));
                        if (this.chk_inclVat.Checked)
                        {
                            num2 /= 1.0 + num;
                        }
                    }
                    else
                    {
                        double num5 = 0.0;
                        if (this.chk_inclVat.Checked)
                        {
                            num5 = num;
                        }
                        if (this.Chk_includedisc.Checked)
                        {
                            num5 += (num4 / 100.0) / (1.0 - (num4 / 100.0));
                        }
                        num2 = num3 / (1.0 + num5);
                        this.Txt_DiscAmt.EditValue = Class7.smethod_2(this.Txt_DiscAmt.EditValue) + ((num2 * (num4 / 100.0)) / (1.0 - (num4 / 100.0)));
                    }
                    this.Txt_ImpAmt.EditValue = num2 + Class7.smethod_2(this.Txt_ImpAmt.EditValue);
                    this.Txt_VatAmt.EditValue = Class7.smethod_2(this.Txt_ImpAmt.EditValue) * num;
                }
            }
            this.Txt_TotalAmt.EditValue = Class7.smethod_2(this.Txt_ImpAmt.EditValue) + Class7.smethod_2(this.Txt_VatAmt.EditValue);
        }

        private void method_3(string string_5, string string_6)
        {
            string selectCommandText = "SELECT  A.goods_id, B.full_name, A.qty, A.amount, A.discount,A.surplus,";
            selectCommandText = (selectCommandText + "A.vat_amt, A.unit_symb, A.merc_type, A.recnum,A.vat_incl,A.disc_incl,A.discpervat, A.tax_code " + " FROM tblTransaction AS A INNER JOIN tblGoods AS B ON A.goods_id = B.goods_id ") + " WHERE A.trans_num = '" + string_6 + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            double num = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            foreach (DataRow row in dataTable.Rows)
            {
                double num4 = Class7.smethod_2(row["vat_amt"]);
                double num5 = Class7.smethod_2(row["surplus"]);
                double num6 = Class7.smethod_2(row["discount"]);
                num = Math.Round(Class7.smethod_2(row["amount"]));
                bool flag = (bool)row["vat_incl"];
                bool flag1 = (bool)row["disc_incl"];
                if ((bool)row["discpervat"])
                {
                    if (flag)
                    {
                        num2 = (((num + num4) + num6) != 0.0) ? Math.Round((double)((num6 * 100.0) / ((num + num4) + num6)), 2) : 0.0;
                    }
                    else
                    {
                        num2 = (((num + num4) + num6) != 0.0) ? Math.Round((double)((num6 * 100.0) / (num + num6)), 2) : 0.0;
                    }
                }
                else
                {
                    num2 = ((num + num6) != 0.0) ? Math.Round((double)((num6 * 100.0) / (num + num6)), 2) : 0.0;
                }
                if (flag)
                {
                    num = Math.Round((double)((Class7.smethod_2(row["amount"]) + num6) + num4), 0);
                    num3 = Math.Round((double)(num / Class7.smethod_2(row["qty"])), 2);
                }
                else
                {
                    num = Math.Round((double)(Class7.smethod_2(row["amount"]) + num6), 0);
                    num3 = Math.Round((double)(num / Class7.smethod_2(row["qty"])), 2);
                }
                object obj2 = "INSERT INTO " + string_5 + "(goods_id, name, qty, price, disc_amt,disc_pc, amount,vat_amt, surplus, unitsymb,merc_type,idx) ";
                obj2 = string.Concat(new object[] { obj2, " VALUES('", row["goods_id"], "' ,N'", row["full_name"], "',", row["qty"], ",", num3, ", ", num6, ",", num2, ", " });
                selectCommandText = string.Concat(new object[] { obj2, num, ",", num4, ",", num5, ",'", row["unit_symb"], "','", row["merc_type"], "',", row["recnum"], " )" });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_1.Close();
            }
        }

        private void pfeZyQnoF(object sender, EventArgs e)
        {
            base.Close();
        }

        private void Txt_ExpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ExpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ExpID.Text, "", this.oleDbConnection_1, ref str);
                this.Lbl_ExpName.Text = str;
            }
        }

        private void Txt_ExpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean kho h\x00e0ng', fullname AS 'Diễn giải' FROM tblStore ";
                Class7.BrowserForm(str, this.oleDbConnection_1);
                this.Txt_ExpID.Text = FrmBrowse.strReturn;
                this.Txt_ExpID.SelectAll();
            }
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_GoodsId.Text.Trim();
            string str2 = this.Txt_ExpID.Text.Trim();
            if (str != string.Empty)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT  A.goods_id, A.full_name, A.packunit, A.piceunit, B.lastimppr, B.prefprice FROM  tblGoods AS A  INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id where A.goods_id = '" + str + "'", this.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_1.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    this.Lbl_MercName.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
                    this.Txt_Price.EditValue = Class7.smethod_0(dataSet.Tables[0].Rows[0]["lastimppr"].ToString());
                    this.Cmb_Unit.Properties.Items.Add(dataSet.Tables[0].Rows[0]["piceunit"].ToString());
                    this.Cmb_Unit.Properties.Items.Add(dataSet.Tables[0].Rows[0]["piceunit"].ToString());
                    this.Cmb_Unit.SelectedIndex = 0;
                    this.Txt_EndQty.EditValue = new Class6().method_21(str, str2);
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
                Class7.BrowserForm("select goods_id as 'M\x00e3 số', full_name AS 'Diễn giải' from tblGoods where status = 1 and mbc = 0", this.oleDbConnection_1);
                this.Txt_GoodsId.Text = FrmBrowse.strReturn;
            }
        }

        private void Txt_ImpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ImpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ImpID.Text, "", this.oleDbConnection_1, ref str);
                this.welftZbha.Text = str;
            }
        }

        private void Txt_ImpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải' FROM tblStore  ";
                Class7.BrowserForm(str, this.oleDbConnection_1);
                this.Txt_ImpID.Text = FrmBrowse.strReturn;
                this.Txt_ImpID.SelectAll();
            }
        }

        private void Txt_OldTrans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.string_2 = this.Txt_OldTrans.Text.Trim();
                string selectCommandText = "select * from tblTransaction where trans_num = '" + this.string_2 + "' and trans_code IN('13','30') and status = 1 ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_OldTrans.Enabled = false;
                        this.Txt_OldDate.Text = set.Tables[0].Rows[0]["tran_date"].ToString();
                        this.Txt_ExpID.Text = set.Tables[0].Rows[0]["imp_id"].ToString();
                        this.Txt_ImpID.Text = set.Tables[0].Rows[0]["exp_id"].ToString();
                        this.Txt_ExpID.Enabled = false;
                        this.Txt_ImpID.Enabled = false;
                        this.Txt_OldDate.Enabled = false;
                        this.Txt_GoodsId.Enabled = false;
                        this.Txt_Qty.Enabled = false;
                        this.Txt_Price.Enabled = false;
                        this.Cmb_Unit.Enabled = false;
                        this.chk_inclVat.Checked = (bool)set.Tables[0].Rows[0]["vat_incl"];
                        this.Chk_discpervat.Checked = (bool)set.Tables[0].Rows[0]["discpervat"];
                        this.Chk_includedisc.Checked = (bool)set.Tables[0].Rows[0]["disc_incl"];
                        this.Cmb_TaxCode.Text = set.Tables[0].Rows[0]["tax_code"].ToString();
                        this.chk_inclVat.Enabled = false;
                        this.Chk_includedisc.Enabled = false;
                        this.Chk_discpervat.Enabled = false;
                        this.Cmb_TaxCode.Enabled = false;
                        this.Txt_Vatrate.Enabled = false;
                        this.Txt_DiscAmt.Enabled = false;
                        this.Txt_VatAmt.Enabled = false;
                        this.Txt_TotalAmt.Enabled = false;
                        this.Txt_ImpAmt.Enabled = false;
                        this.method_3(this.string_0, this.Txt_OldTrans.Text);
                        this.method_2();
                        this.method_1();
                        this.Txt_Remark.Text = "Theo giao dịch " + this.Txt_OldTrans.Text + " Ng\x00e0y : " + this.Txt_OldDate.Text;
                        this.Txt_Remark.Focus();
                    }
                    else
                    {
                        Class7.ShowMessageBox("Kh\x00f4ng t\x00ecm thấy giao dịch n\x00e0y", 1);
                        this.Txt_OldTrans.Focus();
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
                        if (Class7.GetUserRight() == 1)
                        {
                            this.string_4 = "SELECT * FROM tblTransaction WHERE trans_num = '" + this.Txt_TransNum.Text.Trim() + "' ";
                        }
                        else
                        {
                            this.string_4 = "SELECT * FROM tblTransaction WHERE trans_num = '" + this.Txt_TransNum.Text.Trim() + "' AND tran_date = '" + Class7.smethod_19() + "'";
                        }
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_4, this.oleDbConnection_1);
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
                        new Class6().method_15(this.string_0, str, ref str2, ref str3, ref str4, ref flag, ref str5, ref this.string_3);
                        this.Txt_ImpID.Text = str2;
                        this.Txt_ExpID.Text = str3;
                        this.Txt_Remark.Text = str4;
                        this.Txt_Voucher.Text = str5;
                        this.method_1();
                        if (this.Txt_ImpID.Text != string.Empty)
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
                    Class7.BrowserForm("select trans_num as 'Số giao dịch', goods_id AS 'M\x00e3 h\x00e0ng', exp_id AS 'Nơi xuất', qty AS 'Số lượng', amount AS 'Tổng tiền', Status from tblTransaction where tran_date = '" + Class7.smethod_19() + "' and trans_code = '" + this.string_1 + "' order by trans_num ", this.oleDbConnection_1);
                    this.Txt_TransNum.Text = FrmBrowse.strReturn;
                    break;
            }
        }
    
    }
}