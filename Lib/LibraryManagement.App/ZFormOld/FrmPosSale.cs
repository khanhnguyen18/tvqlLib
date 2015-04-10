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
    public partial class FrmPosSale : DevExpress.XtraEditors.XtraForm
    {
        public FrmPosSale()
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
            this.Txt_Barcode.Enabled = true;
            this.Txt_Qty.Enabled = true;
            this.Txt_Rtprice.Enabled = false;
            this.method_0();
            this.btn_New.Enabled = false;
            this.btn_Save.Enabled = true;
            this.method_1();
            this.Txt_TransNum.Text = class2.method_5("P");
            this.string_2 = "N";
            this.btnSuspend.Text = "F12-Ho\x00e3n";
            this.btn_Skip.Enabled = false;
            this.Txt_Barcode.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Sales_View.RowCount != 0)
            {
                this.Txt_Barcode.Enabled = false;
                this.Txt_Qty.Enabled = false;
                this.Txt_Unit.Enabled = false;
                this.btn_New.Enabled = true;
                this.btn_Save.Enabled = false;
                Class6 class2 = new Class6();
                class2.ComputeTransnum("P");
                Class6.transNum = this.Txt_TransNum.Text.Trim();
                string str5 = Class7.smethod_19();
                string str2 = Class7.smethod_40();
                string str6 = Class7.smethod_53();
                int num12 = Class7.GetUserRight();
                string str8 = "B\x00e1n lẻ h\x00e0ng h\x00f3a";
                string str4 = "";
                this.string_1 = "select idx, goods_id,price, qty, qty*price as amount,(qty*price)*(rt_discpc + pc_disc + card_disc) as discamt, kit_qty, kit_id  from " + this.string_0 + " where goods_id <> '' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                DataTable dataTable = new DataTable();
                this.oleDbDataAdapter_0.Fill(dataTable);
                this.oleDbConnection_0.Close();
                string str7 = this.Txt_Unit.Text.Trim();
                foreach (DataRow row in dataTable.Rows)
                {
                    string str = row["goods_id"].ToString().Trim();
                    double num2 = class2.method_16(str2, str);
                    double num3 = Class7.smethod_2(row["qty"]);
                    double num4 = Class7.smethod_2(row["kit_qty"]);
                    string str3 = row["kit_id"].ToString().Trim();
                    double num5 = Class7.smethod_2(row["price"]);
                    Math.Round((double)(num2 * num3), 2);
                    double num6 = Class7.smethod_2(row["discamt"]);
                    double num7 = Class7.smethod_2(row["amount"]) - num6;
                    double num8 = Math.Round((double)((num7 / (1.0 + (Class10.smethod_1(str) / 100.0))) * (Class10.smethod_1(str) / 100.0)), 2);
                    double num9 = Math.Round((double)((((num5 - num2) * num3) - num8) - num6), 2);
                    int num10 = Class7.smethod_51();
                    str4 = Class10.smethod_1(str).ToString();
                    this.string_1 = string.Concat(new object[] { 
                        "INSERT INTO tblTransaction(tran_date, tran_time, trans_num, trans_code, voucher, kit_id, kit_qty, goods_id, qty,unit_symb, amount, discount, surplus, vat_amt, commis_amt, user_id, ref, custax_id,card_id, exp_id, cs_id, merc_type, tax_code, vat_incl, invoice, updated, copies, Shift, recnum,remark, status, discpervat, disc_incl,station) VALUES('", str5, "','", str6, "','", Class6.transNum, "','00','','", str3, "', ", num4, ",'", str, "',", num3, ",'", str7, 
                        "',", num5 * num3, ",", num6, ",", num9, ",", num8, ",0,", num12, ",'','','','", str2, "','','01','", str4, "',0,'',0,1,0,", row["idx"], 
                        ",N'", str8, "',1,0,0,", num10, ")"
                     });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (DataSet set2 = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set2);
                    }
                    this.oleDbConnection_0.Close();
                }
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT goods_id,qty,amount FROM  tblTransaction where trans_num = '" + Class6.transNum + "'", this.oleDbConnection_0);
                DataTable table = new DataTable();
                this.oleDbDataAdapter_0.Fill(table);
                this.oleDbConnection_0.Close();
                foreach (DataRow row in table.Rows)
                {
                    double num13 = class2.method_16(str2, row["goods_id"].ToString()) * Class7.smethod_0(row["qty"].ToString());
                    this.string_1 = string.Concat(new object[] { 
                        "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '", str2, "' AND goods_id = '", row["goods_id"], "') UPDATE  tblStockInfo SET exp_qty = exp_qty + ", row["qty"], " , exp_amt = exp_amt + ", num13, ", last_date ='", str5, "' WHERE id = '", str2, "' AND goods_id = '", row["goods_id"], "' Else INSERT INTO tblStockInfo(id,goods_id, exp_qty,exp_amt,last_date ) VALUES('", str2, 
                        "','", row["goods_id"], "',", row["qty"], ",", num13, ",'", str5, "')"
                     });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (DataSet set3 = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set3);
                    }
                    this.oleDbConnection_0.Close();
                }
                this.string_2 = "D";
                if (Class10.double_2 != 0.0)
                {
                    double num = Class7.smethod_0(this.Lbl_LastAmount.Text);
                    this.string_1 = string.Concat(new object[] { "INSERT INTO tblTransValue([trans_num],[amount],[frcustomer]) VALUES('", Class6.transNum, "',", num, ",", Class10.double_2, ")" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (DataSet set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                }
                Class11.string_1 = "N";
                voucher_1 r_ = new voucher_1();
                r_.PrintingSystem.ShowMarginsWarning = false;
                r_.PrintingSystem.ShowPrintStatusDialog = false;

                this.btn_Skip_Click(this, new EventArgs());
                this.btn_New.Focus();
                try
                {
                    r_.Print();
                }
                catch (Exception)
                {
                    Class7.ShowMessageBox("Kh\x00f4ng t\x00ecm thấy m\x00e1y in", 1);
                }
            }
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            this.string_2 = "D";
            this.Txt_Barcode.Enabled = false;
            this.Txt_Qty.Enabled = false;
            this.Txt_Unit.Enabled = false;
            this.Txt_Rtprice.Enabled = false;
            this.btn_New.Enabled = true;
            this.btn_Save.Enabled = false;
            this.btnSuspend.Text = "F6-T\x00ecm";
        }

        private void btn_SuspendLst_Click(object sender, EventArgs e)
        {
            new FrmSuspendTrans().ShowDialog();
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            if ((this.string_2 == "D") && !(this.Txt_TransNum.Text == string.Empty))
            {
                Class11.string_1 = "R";
                Class6.transNum = this.Txt_TransNum.Text.Trim();
                voucher_1 r_ = new voucher_1();
                r_.PrintingSystem.ShowMarginsWarning = false;
                r_.PrintingSystem.ShowPrintStatusDialog = false;
                try
                {
                    r_.Print();
                }
                catch (Exception)
                {
                    Class7.ShowMessageBox("Kh\x00f4ng t\x00ecm thấy m\x00e1y in", 1);
                }
            }
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            string str = this.Txt_TransNum.Text.Trim();
            string str2 = this.string_2;
            if (str2 != null)
            {
                if (!(str2 == "N"))
                {
                    if (str2 == "D")
                    {
                        this.method_0();
                        this.Txt_TransNum.Enabled = true;
                        this.Txt_TransNum.Focus();
                        this.btn_New.Enabled = false;
                        this.method_1();
                    }
                }
                else if (this.Sales_View.RowCount != 0)
                {
                    this.btn_Skip_Click(this, new EventArgs());
                    new Class6().ComputeTransnum("P");
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + this.string_0, this.oleDbConnection_0);
                    DataTable dataTable = new DataTable();
                    this.oleDbDataAdapter_0.Fill(dataTable);
                    this.oleDbConnection_0.Close();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        this.string_1 = string.Concat(new object[] { 
                            "INSERT INTO tblSuspend(trans_num, idx, goods_id, Name, qty, unit, price, rt_discpc, pc_disc, card_disc,user_id,pos_id) VALUES ('", str, "',", row["idx"], ",'", row["goods_id"], "',N'", row["Name"], "',", row["qty"], ",'", row["unit"], "',", row["price"], ",", row["rt_discpc"], 
                            ",", row["pc_disc"], ",", row["card_disc"], ",", Class7.GetUserRight(), ", '", Class7.smethod_40(), "')"
                         });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                        using (DataSet set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
                        this.oleDbConnection_0.Close();
                    }
                    Class6.transNum = str;
                    voucher_3 r = new voucher_3();
                    r.PrintingSystem.ShowMarginsWarning = false;
                    r.PrintingSystem.ShowPrintStatusDialog = false;
                    r.Print();
                }
            }
        }

        private void cboCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboCurrency_TextChanged(object sender, EventArgs e)
        {
            string str = this.cboCurrency.Text.Trim();
            string str2 = null;
            string str3 = null;
            Class7.smethod_17("description", "tblCurrency", "Id", str, "", Class7.oleDbConnection_1, ref str2);
            Class7.smethod_17("exchange", "tblCurrency", "Id", str, "", Class7.oleDbConnection_1, ref str3);
            this.Lbl_CurrencyName.Text = str2;
            this.Lbl_Exchange.Text = string.Format("{0:n0}", Class7.smethod_0(str3));
            this.Lbl_Foreign.Text = string.Format("{0:n2}", Math.Round((double)(Class7.smethod_0(this.Lbl_PayAmt.Text) / Class7.smethod_0(str3)), 2));
            this.Lbl_CurrencyCap.Text = str;
        }


        private void FrmPosSale_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmPosSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.Sales_View.RowCount != 0) & !this.btn_New.Enabled)
            {
                e.Cancel = true;
            }
            else
            {
                this.string_1 = "select * from tblSuspend where user_id = " + Class7.GetUserRight();
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        Class7.ShowMessageBox("Lưu \x00fd : Bạn c\x00f2n tồn tại giao dịch bị ho\x00e3n", 1);
                    }
                }
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_0, this.oleDbConnection_0);
                using (DataSet set2 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set2);
                }
                this.oleDbConnection_0.Close();
            }
        }

        private void FrmPosSale_KeyDown(object sender, KeyEventArgs e)
        {
            DataSet set;
            double num = Class7.smethod_0(this.Txt_Qty.Text);
            string str = this.Txt_Barcode.Text.Trim();
            switch (e.KeyCode)
            {
                case Keys.F2:
                    if (this.string_2 == "D")
                    {
                        this.btn_New_Click(this, new EventArgs());
                    }
                    break;

                case Keys.F3:
                    if ((this.Sales_View.RowCount != 0) && !(this.string_2 != "N"))
                    {
                        new FrmGetPercent().ShowDialog();
                        if (Class10.double_0 != 0.0)
                        {
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "update ", this.string_0, " set pc_disc = pc_disc + ", Class10.double_0, " ; delete from ", this.string_0, " where qty <= 0 " }), this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                            }
                            this.oleDbConnection_0.Close();
                            this.method_1();
                        }
                    }
                    break;

                case Keys.F4:
                    if ((this.Sales_View.RowCount != 0) && !(this.string_2 != "N"))
                    {
                        new FrmGetPercent().ShowDialog();
                        if (Class10.double_0 != 0.0)
                        {
                            this.string_1 = string.Concat(new object[] { "update ", this.string_0, " set pc_disc = pc_disc + ", Class10.double_0, " where goods_id = '", this.Txt_Barcode.Text.Trim(), "' ; delete from ", this.string_0, " where qty <= 0 " });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                            }
                            this.oleDbConnection_0.Close();
                            this.method_1();
                        }
                    }
                    break;

                case Keys.F6:
                    Class7.ShowMessageBox("Chức năng n\x00e0y đ\x00e3 bị kh\x00f3a bởi bộ phận quản l\x00fd", 1);
                    break;

                case Keys.F7:
                    if (this.btn_Save.Enabled)
                    {
                        this.btn_Save_Click(this, new EventArgs());
                    }
                    break;

                case Keys.F9:
                    Class7.smethod_44("Nhận của kh\x00e1ch h\x00e0ng");
                    break;

                case Keys.F10:
                    this.btnReprint_Click(this, new EventArgs());
                    break;

                case Keys.F11:
                    if (Class7.smethod_50())
                    {
                        if (!this.btn_New.Enabled)
                        {
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "update ", this.string_0, " set qty = qty - ", num, " where goods_id = '", str, "'; delete from ", this.string_0, " where qty <= 0 " }), this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                            }
                            this.oleDbConnection_0.Close();
                            this.method_1();
                        }
                        break;
                    }
                    Class7.ShowMessageBox("Chức năng n\x00e0y đ\x00e3 bị kh\x00f3a bởi bộ phận quản l\x00fd", 1);
                    break;

                case Keys.F12:
                    Class7.ShowMessageBox("Chức năng n\x00e0y đ\x00e3 bị kh\x00f3a bởi bộ phận quản l\x00fd", 1);
                    break;
            }
        }

        private void FrmPosSale_Load(object sender, EventArgs e)
        {
            DataSet set;
            WaitDialogForm form = new WaitDialogForm();
            form.Caption = Class7.string_8;
            this.Text = "F3 Chiết khấu, F9 Thanh to\x00e1n";
            this.btn_Skip_Click(this, new EventArgs());
            try
            {
                this.string_1 = "CREATE TABLE " + this.string_0 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((0)),[unit] [nvarchar](3) DEFAULT (('')),[price] [decimal](18, 2) DEFAULT ((0)),[rt_discpc] [decimal](4, 2) DEFAULT ((0)),[pc_disc] [decimal](4, 2) DEFAULT ((0)),[card_disc] [decimal](4, 2) DEFAULT ((0)),[kit_id] [nvarchar](8) DEFAULT (''),[kit_qty] [decimal](8, 0) DEFAULT ((0)))";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
            catch (Exception)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
            this.method_0();
            this.method_1();
            form.Close();
            Class11.smethod_9("tblCurrency", "Id", "where status = 1", this.cboCurrency, 0, this.oleDbConnection_0);
            this.Txt_TransNum.Enabled = false;
            string str = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.Lbl_Date.Text = str;
            this.btn_Skip.Enabled = false;
            this.btnSuspend.Enabled = false;
            this.btn_New.Focus();
        }

        private void GrdSale_Click(object sender, EventArgs e)
        {
            if (this.Sales_View.RowCount != 0)
            {
                this.Txt_Barcode.Text = this.Sales_View.GetRowCellValue(this.Sales_View.FocusedRowHandle, "M\x00e3 h\x00e0ng").ToString();
                this.Txt_Rtprice.Text = this.Sales_View.GetRowCellValue(this.Sales_View.FocusedRowHandle, "Đơn gi\x00e1").ToString();
                this.Lbl_MercName.Text = this.Sales_View.GetRowCellValue(this.Sales_View.FocusedRowHandle, "T\x00ean h\x00e0ng").ToString();
                this.Txt_Unit.Text = this.Sales_View.GetRowCellValue(this.Sales_View.FocusedRowHandle, "Đơn vị").ToString();
            }
        }


        private void method_0()
        {
            this.Txt_Barcode.Text = string.Empty;
            this.Lbl_MercName.Text = string.Empty;
            this.Txt_Unit.Text = string.Empty;
            this.Txt_Rtprice.Text = "0";
            this.Lbl_TotalAmount.Text = "0";
            this.Lbl_Discount.Text = "0";
            this.Lbl_LastAmount.Text = "0";
            this.Lbl_Exchange.Text = "0";
            this.Lbl_Foreign.Text = "0";
            this.Lbl_PaybackAmt.Text = "0";
            this.Lbl_ReceivAmt.Text = "0";
            this.cboCurrency.SelectedIndex = 0;
            this.Txt_TransNum.Text = string.Empty;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
            }
            this.oleDbConnection_0.Close();
            Class10.double_1 = 0.0;
            Class10.double_0 = 0.0;
            Class10.double_2 = 0.0;
            this.btnSuspend.Text = "F6-T\x00ecm";
        }

        private void method_1()
        {
            this.string_1 = "SELECT idx AS [TT],kit_id AS [M\x00e3 g\x00f3i/b\x00f3],kit_qty AS [SL g\x00f3i/b\x00f3], goods_id AS [M\x00e3 h\x00e0ng], name AS [T\x00ean h\x00e0ng], rt_discpc AS [%CK], qty AS [Số lượng], unit AS [Đơn vị], price AS [Đơn gi\x00e1], price*qty AS [Th\x00e0nh tiền]  FROM " + this.string_0 + " ORDER BY autoid DESC";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdSale.DataSource = dataSet.Tables[0];
            this.Sales_View.OptionsBehavior.Editable = false;
            this.Sales_View.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
            this.Sales_View.Columns["Số lượng"].DisplayFormat.FormatString = "{0:n2}";
            this.Sales_View.Columns["Số lượng"].SummaryItem.FieldName = "Số lượng";
            this.Sales_View.Columns["Số lượng"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.Sales_View.Columns["Số lượng"].SummaryItem.DisplayFormat = "{0:n2}";
            this.Sales_View.Columns["Đơn gi\x00e1"].DisplayFormat.FormatType = FormatType.Numeric;
            this.Sales_View.Columns["Đơn gi\x00e1"].DisplayFormat.FormatString = "{0:n0}";
            this.Sales_View.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.Sales_View.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatString = "{0:n0}";
            this.Sales_View.Columns["Th\x00e0nh tiền"].SummaryItem.FieldName = "Th\x00e0nh tiền";
            this.Sales_View.Columns["Th\x00e0nh tiền"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.Sales_View.Columns["Th\x00e0nh tiền"].SummaryItem.DisplayFormat = "{0:n0}";
            this.Sales_View.Columns["%CK"].DisplayFormat.FormatType = FormatType.Numeric;
            this.Sales_View.Columns["%CK"].DisplayFormat.FormatString = "{0:P2}";
            this.Sales_View.Columns["%CK"].AppearanceCell.BackColor = Color.PapayaWhip;
            this.Sales_View.Columns["M\x00e3 g\x00f3i/b\x00f3"].AppearanceCell.BackColor = Color.PapayaWhip;
            this.Sales_View.BestFitColumns();
            this.string_1 = "select  sum(qty * price) as amount,sum(qty * price) - (sum(qty * price*rt_discpc) + sum(qty*price*pc_disc) + sum(qty*price*card_disc)) as totalamt,sum(qty * price*rt_discpc) + sum(qty*price*pc_disc) + sum(qty*price*card_disc) as discamt from " + this.string_0;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            DataSet set2 = new DataSet();
            this.oleDbDataAdapter_0.Fill(set2);
            this.oleDbConnection_0.Close();
            this.Lbl_TotalAmount.Text = string.Format("{0:n0}", set2.Tables[0].Rows[0]["amount"]);
            this.Lbl_Discount.Text = string.Format("{0:n0}", set2.Tables[0].Rows[0]["discamt"]);
            double num = Class7.smethod_0(set2.Tables[0].Rows[0]["totalamt"].ToString());
            this.Lbl_LastAmount.Text = string.Format("{0:n0}", num);
            this.Lbl_PayAmt.Text = string.Format("{0:n0}", num);
            if (this.Lbl_PayAmt.Text == string.Empty)
            {
                this.Lbl_PayAmt.Text = "0";
            }
            string str = this.cboCurrency.Text.Trim();
            string str2 = null;
            string str3 = null;
            Class7.smethod_17("description", "tblCurrency", "Id", str, "and status = 1", Class7.oleDbConnection_1, ref str2);
            Class7.smethod_17("exchange", "tblCurrency", "Id", str, "and status = 1", Class7.oleDbConnection_1, ref str3);
            this.Lbl_CurrencyName.Text = str2;
            this.Lbl_Exchange.Text = string.Format("{0:n0}", Class7.smethod_0(str3));
            this.Lbl_Foreign.Text = string.Format("{0:n2}", Math.Round((double) (num / Class7.smethod_0(str3)), 2));
            this.Lbl_CurrencyCap.Text = str;
            StyleFormatCondition condition = null;
            condition = new StyleFormatCondition(FormatConditionEnum.NotEqual, this.Sales_View.Columns["M\x00e3 g\x00f3i/b\x00f3"], null, "");
            condition.Appearance.ForeColor = Color.Red;
            this.Sales_View.FormatConditions.Add(condition);
            condition.ApplyToRow = true;
            condition = new StyleFormatCondition(FormatConditionEnum.Equal, this.Sales_View.Columns["M\x00e3 h\x00e0ng"], null, "");
            condition.Appearance.BackColor = Color.SkyBlue;
            this.Sales_View.FormatConditions.Add(condition);
            condition.ApplyToRow = true;
        }

        private void method_2()
        {
            string str = this.Txt_Barcode.Text.Trim();
            if (str != string.Empty)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT gs.goods_id, gs.full_name ,pr.rtprice ,gs.piceunit,gs.status FROM tblGoods as gs INNER JOIN tblPrice as pr ON gs.goods_id = pr.goods_id   where gs.status = 1 and gs.goods_id = '" + str + "' ", this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Lbl_MercName.Text = set.Tables[0].Rows[0]["full_name"].ToString();
                        this.Txt_Rtprice.Text = set.Tables[0].Rows[0]["rtprice"].ToString();
                        this.Txt_Unit.Text = set.Tables[0].Rows[0]["piceunit"].ToString();
                        double num = Class7.smethod_0(this.Txt_Qty.Text);
                        string str2 = this.Txt_Barcode.Text.Trim();
                        double num2 = Class7.smethod_0(this.Txt_Rtprice.Text);
                        string str3 = this.Lbl_MercName.Text.Trim();
                        string str4 = this.Txt_Unit.Text.Trim();
                        Class6 class2 = new Class6();
                        if (!class2.method_22() && (class2.method_21(str2, Class7.smethod_40()) < (num + this.method_9(str2))))
                        {
                            Class7.ShowMessageBox("Số lượng tồn kh\x00f4ng đủ để xuất kho !", 1);
                            this.Txt_Barcode.Focus();
                            this.Txt_Barcode.SelectAll();
                        }
                        else
                        {
                            this.string_1 = string.Concat(new object[] { 
                                "if exists (select goods_id from ", this.string_0, " where goods_id = '", str2, "') update ", this.string_0, " set qty = qty + ", num, " where goods_id = '", str2, "'  else insert into ", this.string_0, "(goods_id,name,qty,unit,price, rt_discpc, pc_disc,card_disc,kit_qty) values('", str2, "',N'", str3, 
                                "', ", num, ",'", str4, "',", num2, ",", this.method_5(str2), ",", Class10.double_0, ",", Class10.double_1, ",0); delete from ", this.string_0, " where qty <= 0 "
                             });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                            using (DataSet set2 = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set2);
                            }
                            this.oleDbConnection_0.Close();
                            this.method_8();
                            this.method_1();
                            this.Txt_Barcode.SelectAll();
                        }
                    }
                    else
                    {
                        Class7.ShowMessageBox("M\x00e3 h\x00e0ng kh\x00f4ng tồn tại, bạn h\x00e3y kiểm tra lại", 1);
                        this.Txt_Barcode.SelectAll();
                    }
                }
            }
        }

        private void method_3()
        {
            this.Txt_Barcode.Text.Trim();
            double num = 1.0;
            string str = this.Txt_Barcode.Text.Trim();
            double num2 = Class7.smethod_0(this.Txt_Rtprice.Text);
            string str2 = this.Lbl_MercName.Text.Trim();
            string str3 = this.Txt_Unit.Text.Trim();
            Class6 class2 = new Class6();
            if (!class2.method_22() && (class2.method_21(str, Class7.smethod_40()) < num))
            {
                Class7.ShowMessageBox("Số lượng tồn kh\x00f4ng đủ để xuất kho !", 1);
                this.Txt_Barcode.Focus();
                this.Txt_Barcode.SelectAll();
            }
            else
            {
                this.string_1 = string.Concat(new object[] { 
                    "if exists (select goods_id from ", this.string_0, " where goods_id = '", str, "') update ", this.string_0, " set qty = qty + ", num, " where goods_id = '", str, "'  else insert into ", this.string_0, "(goods_id,name,qty,unit,price, rt_discpc, pc_disc,card_disc,kit_qty) values('", str, "',N'", str2, 
                    "', ", num, ",'", str3, "',", num2, ",0,", Class10.double_0, ",", Class10.double_1, ",0); delete from ", this.string_0, " where qty <= 0 "
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
                this.method_8();
                this.method_1();
                this.Txt_Barcode.SelectAll();
            }
        }

        private void method_4()
        {
            string str = this.Txt_Barcode.Text.Trim();
            if (str != string.Empty)
            {
                this.string_1 = "select id, description, rtprice from tblKit where id = '" + str + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        DataSet set2;
                        this.Lbl_MercName.Text = set.Tables[0].Rows[0]["description"].ToString();
                        this.Txt_Rtprice.Text = set.Tables[0].Rows[0]["rtprice"].ToString();
                        double num = Class7.smethod_0(this.Txt_Qty.Text);
                        double num2 = 0.0;
                        string str2 = this.Lbl_MercName.Text.Trim();
                        string str3 = "";
                        new Class6();
                        this.string_1 = string.Concat(new object[] { 
                            "if exists (select kit_id from ", this.string_0, " where kit_id = '", str, "') update ", this.string_0, " set kit_qty = kit_qty + ", num, " where kit_id = '", str, "'  else insert into ", this.string_0, "(kit_id,name,qty,unit,price, rt_discpc, pc_disc,card_disc, kit_qty) values('", str, "',N'", str2, 
                            "', ", num, ",'", str3, "',", num2, ",0,0,0,", num, ") ; delete from ", this.string_0, " where qty <= 0 AND goods_id <> ''"
                         });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                        using (set2 = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set2);
                        }
                        this.oleDbConnection_0.Close();
                        this.string_1 = "SELECT goods_id, qty from tblKit_info where kit_id = '" + str + "' ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                        using (DataTable table = new DataTable())
                        {
                            this.oleDbDataAdapter_0.Fill(table);
                            this.oleDbConnection_0.Close();
                            foreach (DataRow row in table.Rows)
                            {
                                string str4 = row["goods_id"].ToString().Trim();
                                double num3 = Class7.smethod_2(Class7.smethod_29("tblPrice", "rtprice", "goods_id", "", str4, this.oleDbConnection_0));
                                double num4 = Class7.smethod_2(row["qty"]);
                                string str5 = Class7.smethod_29("tblGoods", "full_name", "goods_id", str4, "", this.oleDbConnection_0).ToString();
                                string str6 = Class7.smethod_29("tblGoods", "piceunit", "goods_id", str4, "", this.oleDbConnection_0).ToString();
                                this.string_1 = string.Concat(new object[] { 
                                    "if exists (select goods_id from ", this.string_0, " where goods_id = '", str4, "' AND kit_id = '", str, "') update ", this.string_0, " set qty = qty + ", num4, " ,kit_qty = kit_qty + 1  where goods_id = '", str4, "' AND kit_id = '", str, "'  else insert into ", this.string_0, 
                                    "(goods_id,name,qty,unit,price, rt_discpc, pc_disc,card_disc, kit_id,kit_qty) values('", str4, "',N'", str5, "', ", num4, ",'", str6, "',", num3, ",", this.method_5(str4), ",", Class10.double_0, ",", Class10.double_1, 
                                    ", '", str, "', 1); delete from ", this.string_0, " where qty <= 0 AND goods_id <> ''"
                                 });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                                using (set2 = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set2);
                                    continue;
                                }
                            }
                        }
                        this.method_8();
                        this.method_1();
                        this.Txt_Barcode.SelectAll();
                    }
                    else
                    {
                        Class7.ShowMessageBox("M\x00e3 h\x00e0ng kh\x00f4ng tồn tại, bạn h\x00e3y kiểm tra lại", 1);
                        this.Txt_Barcode.SelectAll();
                    }
                }
            }
        }

        private double method_5(string string_3)
        {
            double num = 0.0;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select discpercent, disc_frdate, disc_todate from tblPrice where goods_id = '" + string_3 + "'", this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                DateTime time = DateTime.Parse(set.Tables[0].Rows[0]["disc_frdate"].ToString());
                DateTime time2 = DateTime.Parse(set.Tables[0].Rows[0]["disc_todate"].ToString());
                DateTime time3 = DateTime.Parse(Class7.smethod_19());
                if ((time3.ToOADate() >= time.ToOADate()) && (time3.ToOADate() <= time2.ToOADate()))
                {
                    num = Class7.smethod_2(set.Tables[0].Rows[0]["discpercent"]);
                }
                else
                {
                    num = 0.0;
                }
            }
            this.oleDbConnection_0.Close();
            return num;
        }

        private void method_6(object sender, EventArgs e)
        {
            if (this.btn_New.Enabled)
            {
                this.btn_New.Focus();
            }
            this.Lbl_ReceivAmt.Text = string.Format("{0:n0}", Class10.double_2);
            double num = Class7.smethod_0(this.Lbl_ReceivAmt.Text) - Class7.smethod_0(this.Lbl_LastAmount.Text);
            if (num > 0.0)
            {
                this.Lbl_PaybackAmt.Text = string.Format("{0:n0}", num);
            }
            else
            {
                this.Lbl_PaybackAmt.Text = "0";
            }
        }

        private void method_7(string string_3)
        {
            this.string_1 = "SELECT kit_id, goods_id, qty FROM tblKit_info WHERE kit_id = '" + string_3 + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            using (DataTable table = new DataTable())
            {
                this.oleDbDataAdapter_0.Fill(table);
                this.oleDbConnection_0.Close();
                foreach (DataRow row in table.Rows)
                {
                    new Class6().method_16(Class7.smethod_40(), row["goods_id"].ToString());
                    this.string_1 = "insert into";
                }
            }
        }

        private void method_8()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + this.string_0 + " order by autoid", this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_0.Close();
            int num = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { " UPDATE ", this.string_0, " set idx = ", num, " where autoid = ", row["autoid"] }), this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    num++;
                }
                this.oleDbConnection_0.Close();
            }
        }

        private double method_9(string string_3)
        {
            this.string_1 = "select qty from " + this.string_0 + " where goods_id = '" + string_3 + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    return Class7.smethod_2(set.Tables[0].Rows[0][0]);
                }
                return 0.0;
            }
        }

        private void Txt_Barcode_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            DataSet set;
            string str = this.Txt_Barcode.Text.Trim();
            Keys keyCode = e.KeyCode;
            if (keyCode != Keys.Return)
            {
                if (keyCode == Keys.F2)
                {
                    Class7.BrowserForm1("SELECT gs.goods_id AS 'M\x00e3 h\x00e0ng',gs.barcode,gs.full_name AS 'T\x00ean h\x00e0ng',pr.rtprice AS 'Gi\x00e1 b\x00e1n lẻ', gs.grp_id AS Nh\x00f3m FROM tblGoods AS gs INNER JOIN tblPrice as pr ON gs.goods_id = pr.goods_id where gs.status = 1", Class7.oleDbConnection_1);
                    this.Txt_Barcode.Text = BrowseForm.strReturn;
                    this.Txt_Barcode.SelectAll();
                }
                return;
            }
            string str2 = Class7.smethod_14("m_kits").ToString().Trim();
            string str3 = Class7.smethod_14("m_plu").ToString().Trim();
            if (str.Length > 6)
            {
                if (str.Substring(0, str3.Length) == str3)
                {
                    this.string_1 = "select goods_id from tblNon_Plu where nplu_code = '" + str.Substring(str3.Length, 4) + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        if (set.Tables[0].Rows.Count != 0)
                        {
                            this.Txt_Barcode.Text = set.Tables[0].Rows[0][0].ToString();
                            string str4 = null;
                            string str5 = null;
                            Class7.smethod_17("full_name", "tblGoods", "goods_id", this.Txt_Barcode.Text.Trim(), "", Class7.oleDbConnection_1, ref str4);
                            this.Lbl_MercName.Text = str4;
                            Class7.smethod_17("rtprice", "tblPrice", "goods_id", this.Txt_Barcode.Text.Trim(), "", Class7.oleDbConnection_1, ref str5);
                            this.Txt_Rtprice.EditValue = Class7.smethod_0(str5);
                            this.oleDbConnection_0.Close();
                            this.Txt_Qty.Focus();
                            goto Label_02BE;
                        }
                        Class7.ShowMessageBox("M\x00e3 h\x00e0ng kh\x00f4ng tồn tại, bạn h\x00e3y kiểm tra lại", 1);
                        this.Txt_Barcode.SelectAll();
                        return;
                    }
                }
                this.string_1 = "select goods_id from tblbarcode where barcode = '" + str + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_Barcode.Text = set.Tables[0].Rows[0][0].ToString();
                    }
                    this.oleDbConnection_0.Close();
                    this.method_2();
                }
            }
        Label_02BE:
            if (str.Length == 6)
            {
                if (str.Substring(0, str2.Length) == str2)
                {
                    this.string_1 = "select id, description, rtprice from tblKit where id = '" + str + "' ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        if (set.Tables[0].Rows.Count == 0)
                        {
                            Class7.ShowMessageBox("M\x00e3 h\x00e0ng kh\x00f4ng tồn tại, bạn h\x00e3y kiểm tra lại", 1);
                            this.Txt_Barcode.SelectAll();
                            return;
                        }
                        this.Lbl_MercName.Text = set.Tables[0].Rows[0]["description"].ToString();
                        this.Txt_Rtprice.Text = set.Tables[0].Rows[0]["rtprice"].ToString();
                        this.method_4();
                        goto Label_0513;
                    }
                }
                if (Class10.smethod_2(str))
                {
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT gs.goods_id, gs.full_name ,pr.rtprice ,gs.piceunit,gs.status FROM tblGoods as gs INNER JOIN tblPrice as pr ON gs.goods_id = pr.goods_id   where gs.status = 1 and gs.goods_id = '" + str + "' ", this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        this.Lbl_MercName.Text = set.Tables[0].Rows[0]["full_name"].ToString();
                        this.Txt_Rtprice.Text = set.Tables[0].Rows[0]["rtprice"].ToString();
                        this.Txt_Unit.Text = set.Tables[0].Rows[0]["piceunit"].ToString();
                    }
                    this.Txt_Rtprice.Enabled = true;
                    this.Txt_Rtprice.Focus();
                    this.Txt_Rtprice.SelectAll();
                }
                else
                {
                    this.Txt_Qty.Text = "1";
                    this.method_2();
                }
            }
        Label_0513:
            if ((str.Length < 4) & Class7.smethod_12(this.Txt_Barcode.Text))
            {
                this.Txt_Qty.Text = str;
                this.Txt_Barcode.Text = string.Empty;
            }
        }

        private void Txt_MercSearch_Click(object sender, EventArgs e)
        {
            new FrmMercPosView().ShowDialog();
        }

        private void Txt_Qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.method_2();
                this.Txt_Qty.Text = "1";
                this.Txt_Barcode.Focus();
                this.Txt_Barcode.SelectAll();
            }
        }

        private void Txt_Rtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.Txt_Qty.Text = "1";
                this.method_3();
                this.Txt_Rtprice.Enabled = false;
                this.Txt_Barcode.Focus();
                this.Txt_Barcode.SelectAll();
            }
        }

        private void Txt_TransNum_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1(" SELECT trans_num, goods_id, Name, qty  FROM tblSuspend WHERE user_id = " + Class7.GetUserRight(), this.oleDbConnection_0);
                this.Txt_TransNum.Text = BrowseForm.strReturn;
            }
            if (e.KeyCode == Keys.Return)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("select * from tblsuspend where trans_num = '" + this.Txt_TransNum.Text.Trim() + "'", this.oleDbConnection_0);
                DataTable dataTable = new DataTable();
                this.oleDbDataAdapter_0.Fill(dataTable);
                this.oleDbConnection_0.Close();
                if (dataTable.Rows.Count != 0)
                {
                    DataSet set;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { 
                            "insert into ", this.string_0, "(goods_id,name,qty,unit,price, rt_discpc,pc_disc,card_disc) values('", row["goods_id"], "',N'", row["name"], "', ", row["qty"], ",'", row["unit"], "',", row["price"], ",", row["rt_discpc"], ",", row["pc_disc"], 
                            ",", row["card_disc"], ")"
                         }), this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
                        this.oleDbConnection_0.Close();
                    }
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter("delete from tblsuspend where trans_num = '" + this.Txt_TransNum.Text.Trim() + "'", this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                    }
                    this.oleDbConnection_0.Close();
                    this.method_1();
                    this.Txt_TransNum.Enabled = false;
                    this.btn_New.Enabled = false;
                    this.btn_Save.Enabled = true;
                    this.Txt_Barcode.Enabled = true;
                    this.Txt_Qty.Enabled = true;
                    this.btnSuspend.Text = "F12-Ho\x00e3n";
                    this.Txt_Barcode.Focus();
                }
            }
        }

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = 520;
                return createParams;
            }
        }

    }
}