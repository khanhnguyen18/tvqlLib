using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
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
using LibraryManagement.Domain;
using LibraryManagement.Service;

namespace LibraryManagement.App
{
    public partial class FrmFromSupp : DevExpress.XtraEditors.XtraForm
    {
        public FrmFromSupp()
        {
            InitializeComponent();
            this.oleDbConnection_0 = new OleDbConnection(Class7.string_5);
            this.string_0 = "FRSUPP_" + Class6.smethod_0(SystemInformation.ComputerName);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            new UnitsForm().ShowDialog();
        }

        #region BUTTONS
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.string_3 != "F")
            {
                return;
            }
            string str2 = this.Txt_TransNum.Text.Trim();
            string str3 = this.Txt_ImpID.Text.Trim();
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
                    class2.method_14("tblTransaction", str2, 1);
                    class2.method_17(str2);
                    class2.method_7(str2, str3);
                    this.btn_Skip_Click(this, new EventArgs());
                }
                return;
            }
            if (!class2.method_22())
            {
                this.string_2 = "select goods_id, imp_id, qty from tblTransaction where trans_num = '" + str2 + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (DataTable table = new DataTable())
                {
                    this.oleDbDataAdapter_0.Fill(table);
                    this.oleDbConnection_0.Close();
                    IEnumerator enumerator = table.Rows.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = (DataRow)enumerator.Current;
                        if (class2.method_21(current["goods_id"].ToString(), current["imp_id"].ToString()) < Class7.smethod_2(current["qty"]))
                        {
                            goto Label_0175;
                        }
                    }
                    goto Label_01A9;
                Label_0175:
                    Class7.ShowMessageBox("Số lượng tồn kh\x00f4ng đủ để x\x00f3a giao dịch n\x00e0y !", 1);
                    return;
                }
            }
        Label_01A9:
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1)
            {
                class2.method_18(str2);
                class2.method_8(str2);
                class2.method_14("tblTransaction", str2, 0);
                this.btn_Skip_Click(this, new EventArgs());
            }
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
            this.string_3 = "N";
            this.dateEdit1.DateTime = DateTime.Now;
            this.dateEdit1.Enabled = false;
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
                string str2 = this.Txt_TransNum.Text.Trim();
                string str4 = this.Txt_ExpID.Text.Trim();
                string str3 = this.Txt_ImpID.Text.Trim();
                this.Txt_Remark.Text.Trim();
                this.Txt_Voucher.Text.Trim();
                int num1 = this.chk_inclVat.Checked ? 1 : 0;
                int num2 = this.Chk_includedisc.Checked ? 1 : 0;
                int num3 = this.Chk_discpervat.Checked ? 1 : 0;
                this.Cmb_TaxCode.Text.Trim();
                if (this.TransDetail.RowCount != 0)
                {
                    Class6 class2 = new Class6();
                    string str = this.string_3;
                    if (str != null)
                    {
                        if (!(str == "N"))
                        {
                            if (str == "E")
                            {
                                this.bool_0 = false;
                                this.string_6 = this.string_4;
                                this.btn_Skip_Click(this, new EventArgs());
                                class2.method_18(str2);//UpdateStock
                                class2.method_8(str2);
                                class2.method_13(str2);
                                this.Insert();
                                class2.method_17(str2);
                                class2.method_7(str2, str3);
                                class2.kCnalMegv(this.string_0);
                                class2.method_11(this.string_0, str4);
                            }
                        }
                        else
                        {
                            this.bool_0 = true;
                            this.string_6 = DateTime.Now;
                            this.btn_Skip_Click(this, new EventArgs());
                            class2.ComputeTransnum("K");
                            this.Insert();
                            class2.method_17(str2);
                            class2.method_7(str2, str3);
                            class2.kCnalMegv(this.string_0);
                            class2.method_11(this.string_0, str4);
                        }
                    }
                    if (this.chkLabelPrn.Checked)
                    {
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE  FROM tblLABELS", this.oleDbConnection_0);
                        DataSet dataSet = new DataSet();
                        this.oleDbDataAdapter_0.Fill(dataSet);
                        this.oleDbConnection_0.Close();
                        string selectCommandText = "SELECT A.goods_id, A.full_name, A.grp_id,A.piceunit, A.merc_type, B.rtprice, C.trans_num,C.qty, C.exp_id,C.imp_id, C.recnum FROM tblGoods AS A INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id  INNER JOIN tblTransaction AS C ON A.goods_id = C.goods_id where C.trans_num = '" + str2 + "' ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, Class7.oleDbConnection_1);
                        DataTable dataTable = new DataTable();
                        this.oleDbDataAdapter_0.Fill(dataTable);
                        Class7.oleDbConnection_1.Close();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            selectCommandText = "INSERT INTO tblLABELS([idx],[timeinput],[goods_id],[fullname],[shortname],[grp_id],[supp_id],[rtprice],[qty],user_id) ";
                            object obj2 = selectCommandText;
                            obj2 = string.Concat(new object[] { obj2, "VALUES(", row["recnum"], ",'", row["recnum"].ToString(), "','", row["goods_id"], "','", row["full_name"], "','", row["full_name"], "'," });
                            OleDbDataAdapter adapter = new OleDbDataAdapter(string.Concat(new object[] { obj2, "'", row["grp_id"], "','", row["exp_id"], "','", row["rtprice"], "',", row["qty"], ",", Class7.GetUserId(), ")" }), this.oleDbConnection_0);
                            using (DataSet set2 = new DataSet())
                            {
                                adapter.Fill(set2);
                            }
                            this.oleDbConnection_0.Close();
                        }
                    }
                    Class6.transNum = str2;
                    v_frsupp sup = new v_frsupp();
                    sup.ShowPreviewDialog();
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
            this.string_3 = "S";
            this.Txt_TransNum.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_3 = "D";
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
                string str2 = this.Lbl_MercName.Text.Trim();
                double num = Class7.smethod_0(this.Txt_Qty.Text);
                double num2 = Class7.smethod_0(this.CdCbuygdy.Text);
                double num3 = Class7.smethod_0(this.Txt_DiscPc.Text);
                string str3 = this.Cmb_Unit.Text.Trim();
                if (num2 <= 0.0)
                {
                    Class7.ShowMessageBox("Gi\x00e1 nhập đăng k\x00fd kh\x00f4ng hợp lệ", 1);
                    this.CdCbuygdy.Focus();
                }
                else if (Class7.smethod_0(this.Txt_Qty.Text) < 0.0)
                {
                    Class7.ShowMessageBox("Số lượng nhập đăng k\x00fd kh\x00f4ng hợp lệ", 1);
                    this.Txt_Qty.Focus();
                }
                else
                {
                    string selectCommandText = string.Concat(new object[] { 
                        "IF EXISTS (SELECT goods_id FROM ", this.string_0, " where goods_id = '", str, "') UPDATE ", this.string_0, " SET [qty] = ", num, " ,[amount] = ", num2 * num, ",[price] = ", num2, ",disc_pc = ", num3, " WHERE goods_id = '", str, 
                        "' Else INSERT INTO ", this.string_0, "(goods_id, name, qty, price, vat_amt, disc_amt,disc_pc, amount,unitsymb,merc_type)  VALUES('", str, "' , N'", str2, "',", num, ",", num2, ",0,0,", num3, ", ", num2 * num, ", '", str3, 
                        "', '01') ; DELETE FROM ", this.string_0, " WHERE qty <= 0 "
                     });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                    using (DataSet set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                    }
                    this.oleDbConnection_0.Close();
                    this.method_5();
                    new Class6().method_2(this.string_0);
                    this.method_1();
                    this.Txt_GoodsId.Focus();
                    this.Txt_GoodsId.SelectAll();
                }
            }
        } 
        #endregion

        private void CdCbuygdy_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Chk_discpervat_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.string_3 == "N") || (this.string_3 == "E"))
            {
                this.method_5();
            }
        }

        private void Chk_includedisc_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.string_3 == "N") || (this.string_3 == "E"))
            {
                this.method_5();
            }
        }

        private void chk_inclVat_CheckedChanged(object sender, EventArgs e)
        {
            if ((this.string_3 == "N") || (this.string_3 == "E"))
            {
                this.method_5();
            }
        }

        private void Cmb_TaxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((this.string_3 == "N") || (this.string_3 == "E"))
            {
                this.method_5();
            }
            string text = this.Cmb_TaxCode.Text;
            if (text != null)
            {
                if (text != "A00")
                {
                    if (!(text == "A05"))
                    {
                        if (text == "A10")
                        {
                            this.Txt_Vatrate.EditValue = 10;
                        }
                    }
                    else
                    {
                        this.Txt_Vatrate.EditValue = 5;
                    }
                }
                else
                {
                    this.Txt_Vatrate.EditValue = 0;
                }
            }
        }

        private void Cmb_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmFromSupp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_0, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
        }

        private void FrmFromSupp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                this.method_5();
            }
        }

        private void FrmFromSupp_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.Text = "Nhập kho";
            this.dateEdit1.DateTime = DateTime.Now;
            this.btn_Skip_Click(this, new EventArgs());
            this.Txt_Vatrate.Properties.ReadOnly = true;
            try
            {
                string selectCommandText = "CREATE TABLE " + this.string_0 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((1)),[price] [decimal](18, 2) DEFAULT ((0)),[amount] [decimal](18, 2) DEFAULT ((0)),[disc_amt] [decimal](18, 2) DEFAULT ((0)),[vat_amt] [decimal](18, 2) DEFAULT ((0)),[surplus] [decimal](18, 2) DEFAULT ((0)),[disc_pc] [decimal](8, 2) DEFAULT ((0)),[unitsymb] [nvarchar](3) DEFAULT (('')),[merc_type] [nvarchar](2) DEFAULT (('')))";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
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
        }

        private void GrdTran_Click(object sender, EventArgs e)
        {
            if (this.TransDetail.RowCount != 0)
            {
                Class7.smethod_0(this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Th\x00e0nh tiền").ToString());
                this.Txt_GoodsId.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "M\x00e3 h\x00e0ng").ToString();
                this.Txt_Qty.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Số lượng").ToString();
                this.Txt_DiscPc.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "% CK").ToString();
                this.CdCbuygdy.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn gi\x00e1").ToString();
                this.Lbl_MercName.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "T\x00ean h\x00e0ng").ToString();
                this.Cmb_Unit.Text = this.TransDetail.GetRowCellValue(this.TransDetail.FocusedRowHandle, "Đơn vị").ToString();
            }
        }

        private void iGoods_ItemClick(object sender, ItemClickEventArgs e)
        {
            new BookForm().ShowDialog();
        }

        private void iGoodsGrp_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmLanguage().ShowDialog();
        }

        private void IipWvDcZu(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_ImpID.Enabled = true;
            this.Txt_ExpID.Enabled = true;
            this.dateEdit1.Enabled = false;
            this.string_3 = "E";
        }

        private void iStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ReaderForm().ShowDialog();
        }

        private void method_0()
        {
            Class11.smethod_8(this);
            this.Lbl_ImpName.Text = string.Empty;
            this.Lbl_ExpName.Text = string.Empty;
            this.Lbl_MercName.Text = string.Empty;
            this.Cmb_TaxCode.SelectedIndex = 0;
            this.chk_inclVat.Checked = false;
            this.Txt_ImpAmt.EditValue = 0;
            this.Txt_TotalAmt.EditValue = 0;
            this.Txt_VatAmt.EditValue = 0;
            this.Txt_DiscAmt.EditValue = 0;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
            }
            this.oleDbConnection_0.Close();
        }

        private void method_1()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT idx AS [TT], goods_id AS [M\x00e3 h\x00e0ng], name AS [T\x00ean h\x00e0ng], qty AS [Số lượng], unitsymb AS [Đơn vị], price AS [Đơn gi\x00e1],disc_pc AS [% CK], price*qty AS [Th\x00e0nh tiền] FROM " + this.string_0 + " ORDER BY autoid", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
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
            this.TransDetail.Columns["% CK"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["% CK"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransDetail.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatString = "{0:n2}";
            this.TransDetail.BestFitColumns();
        }

        private void method_2()
        {
            DataSet set2;
            DataSet set3;
            double num = Class7.smethod_0(this.Txt_Vatrate.Text) / 100.0;
            Class7.smethod_0(this.Txt_DiscPc.Text);
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
            this.Txt_Vatrate.EditValue = num * 100.0;
            this.Txt_ImpAmt.EditValue = 0;
            this.Txt_TotalAmt.EditValue = 0;
            this.Txt_VatAmt.EditValue = 0;
            this.Txt_DiscAmt.EditValue = 0;
            if (this.chk_inclVat.Checked)
            {
                this.string_2 = string.Concat(new object[] { "UPDATE ", this.string_0, " set vat_amt = amount - (amount / (1 + ", num, "))" });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set3 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set3);
                }
                this.oleDbConnection_0.Close();
            }
            else
            {
                this.string_2 = string.Concat(new object[] { "UPDATE ", this.string_0, " set vat_amt = amount * ", num });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set3 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set3);
                }
                this.oleDbConnection_0.Close();
            }
            if (this.Chk_includedisc.Checked)
            {
                if (this.chk_inclVat.Checked)
                {
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter("UPDATE " + this.string_0 + " set disc_amt = ((amount - vat_amt)*disc_pc)/100 ", this.oleDbConnection_0);
                    using (set2 = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set2);
                    }
                    this.oleDbConnection_0.Close();
                }
                else
                {
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter("UPDATE " + this.string_0 + " set disc_amt = (amount*disc_pc)/100 ", this.oleDbConnection_0);
                    using (set2 = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set2);
                    }
                    this.oleDbConnection_0.Close();
                }
            }
            if (this.Chk_discpervat.Checked)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("UPDATE " + this.string_0 + " set disc_amt = (amount - vat_amt) * disc_pc/100 ", this.oleDbConnection_0);
                using (set2 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set2);
                }
                this.oleDbConnection_0.Close();
            }
            else
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("UPDATE " + this.string_0 + " set disc_amt = (amount + vat_amt)*disc_pc/100 ", this.oleDbConnection_0);
                using (set2 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set2);
                }
                this.oleDbConnection_0.Close();
            }
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select sum(amount) AS a_amt, sum(disc_amt) AS d_amt, sum(vat_amt) AS v_amt from " + this.string_0, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                num2 = Class7.smethod_0(dataSet.Tables[0].Rows[0]["a_amt"].ToString());
                num3 = Class7.smethod_0(dataSet.Tables[0].Rows[0]["d_amt"].ToString());
                num4 = Class7.smethod_0(dataSet.Tables[0].Rows[0]["v_amt"].ToString());
                if (this.chk_inclVat.Checked)
                {
                    this.Txt_TotalAmt.EditValue = num2 + num4;
                    this.Txt_ImpAmt.EditValue = Class7.smethod_0(this.Txt_TotalAmt.Text) - num4;
                    this.Txt_VatAmt.EditValue = num4;
                    this.Txt_DiscAmt.EditValue = num3;
                }
                else
                {
                    this.Txt_TotalAmt.EditValue = num2 + num4;
                    this.Txt_ImpAmt.EditValue = Class7.smethod_0(this.Txt_TotalAmt.Text) + num4;
                    this.Txt_VatAmt.EditValue = num4;
                    this.Txt_DiscAmt.EditValue = num3;
                }
            }
            else
            {
                this.Txt_ImpAmt.EditValue = 0;
                this.Txt_TotalAmt.EditValue = 0;
                this.Txt_VatAmt.EditValue = 0;
                this.Txt_DiscAmt.EditValue = 0;
            }
        }

        private void method_3(string string_7, string string_8)
        {
            string selectCommandText = "SELECT  A.goods_id, B.full_name, A.qty, A.amount, A.discount,A.surplus,";
            selectCommandText = (selectCommandText + "A.vat_amt, A.unit_symb, A.merc_type, A.recnum,A.vat_incl,A.disc_incl,A.discpervat, A.tax_code " + " FROM tblTransaction AS A INNER JOIN tblGoods AS B ON A.goods_id = B.goods_id ") + " WHERE A.trans_num = '" + string_8 + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_0.Close();
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
                object obj2 = "INSERT INTO " + string_7 + "(goods_id, name, qty, price, disc_amt,disc_pc, amount,vat_amt, surplus, unitsymb,merc_type,idx) ";
                obj2 = string.Concat(new object[] { obj2, " VALUES('", row["goods_id"], "' ,N'", row["full_name"], "',", row["qty"], ",", num3, ", ", num6, ",", num2, ", " });
                selectCommandText = string.Concat(new object[] { obj2, num, ",", num4, ",", num5, ",'", row["unit_symb"], "','", row["merc_type"], "',", row["recnum"], " )" });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_0.Close();
            }
        }

        private void Insert()
        {
            string str = this.Txt_TransNum.Text.Trim();
            string str3 = this.bool_0 ? Class7.smethod_53() : this.string_5;
            string str4 = this.Txt_ExpID.Text.Trim();
            string str5 = this.Txt_ImpID.Text.Trim();
            string str6 = this.Txt_Remark.Text.Trim();
            string str7 = this.Txt_Voucher.Text.Trim();
            int num8 = this.chk_inclVat.Checked ? 1 : 0;
            int num7 = this.Chk_includedisc.Checked ? 1 : 0;
            int num = this.Chk_discpervat.Checked ? 1 : 0;
            string str2 = this.Cmb_TaxCode.Text.Trim();
            double num2 = Class7.smethod_0(this.Txt_Vatrate.Text) / 100.0;
            this.string_2 = "SELECT goods_id,qty,price,amount,idx,unitsymb, disc_amt,vat_amt,surplus,merc_type,disc_pc FROM " + this.string_0;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            double num6 = 0.0;
            foreach (DataRow row in dataTable.Rows)
            {
                num3 = Class7.smethod_2(row["price"]) * Class7.smethod_2(row["qty"]);
                double num9 = Class7.smethod_2(row["disc_pc"]);
                if (this.Chk_discpervat.Checked)
                {
                    if (this.Chk_includedisc.Checked)
                    {
                        num3 /= 1.0 + ((num9 / 100.0) / (1.0 - (num9 / 100.0)));
                    }
                    num4 = Math.Round((double)((num3 * (num9 / 100.0)) / (1.0 - (num9 / 100.0))), 2);
                    if (this.chk_inclVat.Checked)
                    {
                        num3 /= 1.0 + num2;
                    }
                }
                else
                {
                    num5 = 0.0;
                    if (this.chk_inclVat.Checked)
                    {
                        num5 = num2;
                    }
                    if (this.Chk_includedisc.Checked)
                    {
                        num5 += (num9 / 100.0) / (1.0 - (num9 / 100.0));
                    }
                    num3 = Math.Round((double)((Class7.smethod_2(row["price"]) * Class7.smethod_2(row["qty"])) / (1.0 + num5)), 2);
                    num4 = Math.Round((double)((num3 * (num9 / 100.0)) / (1.0 - (num9 / 100.0))), 2);
                }
                num6 = Math.Round((double)(num3 * num2), 2);
                this.string_2 = "INSERT INTO tblTransaction(tran_date, tran_time, trans_num, trans_code, voucher, invoice, post, exp_id, imp_id, ";
                this.string_2 = this.string_2 + "goods_id, qty, unit_symb, amount, discount, vat_amt, surplus, commis_amt, user_id, cs_id, ";
                this.string_2 = this.string_2 + "remark, updated, merc_type, tax_code, vat_incl, discpervat, disc_incl, copies, recnum, Status,station) ";
                string str8 = this.string_2;
                this.string_2 = str8 + "VALUES('" + this.string_6.Date+ "','" + str3 + "','" + str + "','" + this.string_1 + "','" + str7 + "','',0,'" + str4 + "',";
                object obj2 = this.string_2;
                this.string_2 = string.Concat(new object[] { obj2, "'", str5, "','", row["goods_id"], "', ", row["qty"], ", '", row["unitsymb"], "',", num3, ", " });
                obj2 = this.string_2;
                this.string_2 = string.Concat(new object[] { obj2, num4, ", ", num6, ", ", row["surplus"], ", 0, " });
                obj2 = this.string_2;
                this.string_2 = string.Concat(new object[] { obj2, Class7.GetUserId(), ",'' ,N'", str6, "' ,0 ,'", row["merc_type"], "' ," });
                obj2 = this.string_2;
                this.string_2 = string.Concat(new object[] { obj2, "'", str2, "' ,", num8, ",", num, ",", num7, ",0 ,", row["idx"], " ,1 ,", Class7.smethod_51(), ")" });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
        }

        private void method_5()
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
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select * from " + this.string_0, this.oleDbConnection_0);
            using (DataTable table = new DataTable())
            {
                this.oleDbDataAdapter_0.Fill(table);
                this.oleDbConnection_0.Close();
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

        private double method_6(string string_7)
        {
            this.string_2 = "select prefprice from tblPrice where goods_id = '" + string_7 + "'";
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

        private void Txt_ExpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ExpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ExpID.Text, "and type IN('05','06') and status = 1", this.oleDbConnection_0, ref str);
                this.Lbl_ExpName.Text = str;
            }
        }

        private void Txt_ExpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS [T\x00ean nh\x00e0 cung cấp], fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('05','06') and status = 1 ";
                Class7.BrowserForm1(str, this.oleDbConnection_0);
                this.Txt_ExpID.Text = BrowseForm.strReturn;
                this.Txt_ExpID.SelectAll();
            }
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
            Goods good = new GoodsService().GetByGoodsId(Txt_GoodsId.Text);
            if (good != null)
                Lbl_MercName.Text = good.FullName;
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            string str3;
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("select goods_id as 'M\x00e3 số', full_name AS 'Diễn giải' from tblGoods where status = 1 and mbc = 0", this.oleDbConnection_0);
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
                DataSet set2;
                if (str.Substring(0, str2.Length) == str2)
                {
                    this.string_2 = "select goods_id from tblNon_Plu where nplu_code = '" + str.Substring(0, str2.Length) + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set2 = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set2);
                        if (set2.Tables[0].Rows.Count != 0)
                        {
                            this.Txt_GoodsId.Text = set2.Tables[0].Rows[0][0].ToString();
                        }
                        this.oleDbConnection_0.Close();
                        goto Label_01E6;
                    }
                }
                this.string_2 = "select goods_id from tblbarcode where barcode = '" + str + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set2 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set2);
                    if (set2.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_GoodsId.Text = set2.Tables[0].Rows[0][0].ToString();
                    }
                    this.oleDbConnection_0.Close();
                }
            }
        Label_01E6:
            str3 = this.Txt_GoodsId.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT  A.goods_id, A.full_name, A.packunit, A.piceunit, B.lastimppr, B.prefprice, B.rtprice FROM  tblGoods AS A  INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id where A.goods_id = '" + str3 + "'", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Lbl_MercName.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
                this.CdCbuygdy.EditValue = Class7.smethod_0(dataSet.Tables[0].Rows[0]["rtprice"].ToString());
                this.Cmb_Unit.Properties.Items.Add(dataSet.Tables[0].Rows[0]["piceunit"].ToString());
                this.Cmb_Unit.Properties.Items.Add(dataSet.Tables[0].Rows[0]["piceunit"].ToString());
                this.Cmb_Unit.SelectedIndex = 0;
                this.Txt_Qty.Text = "1";
                this.Txt_GoodsId.Focus();
            }
            else
            {
                this.Lbl_MercName.Text = string.Empty;
                this.CdCbuygdy.EditValue = 0;
            }
        }

        private void Txt_ImpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ImpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ImpID.Text, "and type IN('02','01') and status = 1", this.oleDbConnection_0, ref str);
                this.Lbl_ImpName.Text = str;
            }
        }

        private void Txt_ImpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = "SELECT Id AS [M\x00e3 số], Name AS [T\x00ean kho, quầy], fullname AS [Diễn giải] FROM tblStore WHERE Type IN('01','02') and status = 1";
                Class7.BrowserForm1(str, this.oleDbConnection_0);
                this.Txt_ImpID.Text = BrowseForm.strReturn;
                this.Txt_ImpID.SelectAll();
            }
        }

        private void Txt_TransNum_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_TransNum.Text.Trim();
            if (string.IsNullOrEmpty(str)) return;

            this.string_2 = "SELECT * FROM tblTransaction WHERE trans_num = '" + str + "' ";


            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Txt_ImpID.Text = dataSet.Tables[0].Rows[0]["imp_id"].ToString();
                this.Txt_ExpID.Text = dataSet.Tables[0].Rows[0]["exp_id"].ToString();
                this.Txt_Remark.Text = dataSet.Tables[0].Rows[0]["remark"].ToString();
                this.Txt_Voucher.Text = dataSet.Tables[0].Rows[0]["voucher"].ToString();
                this.dateEdit1.DateTime = (DateTime)dataSet.Tables[0].Rows[0]["tran_date"];
                this.string_4 = (DateTime)dataSet.Tables[0].Rows[0]["tran_date"];
                this.string_5 = dataSet.Tables[0].Rows[0]["tran_time"].ToString();
                this.chk_inclVat.Checked = (bool)dataSet.Tables[0].Rows[0]["vat_incl"];
                this.Chk_discpervat.Checked = (bool)dataSet.Tables[0].Rows[0]["discpervat"];
                this.Chk_includedisc.Checked = (bool)dataSet.Tables[0].Rows[0]["disc_incl"];
                this.method_3(this.string_0, dataSet.Tables[0].Rows[0]["trans_num"].ToString());
                this.Cmb_TaxCode.Text = dataSet.Tables[0].Rows[0]["tax_code"].ToString();
                Class11.smethod_3(this);
                this.string_3 = "F";
                if (!Class7.smethod_50())
                {
                    this.btn_Edit.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                    this.btn_Delete.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                }
                Class11.smethod_5(this, "F");
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("select sum(amount) + sum(vat_amt) AS t_amt, sum(amount) AS a_amt, sum(disc_amt) AS d_amt, sum(vat_amt) AS v_amt from " + this.string_0, this.oleDbConnection_0);
                DataSet set = new DataSet();
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.method_5();
                this.method_1();
            }

        }

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    if (this.string_3 == "S")
                    {
                        string str = this.Txt_TransNum.Text.Trim();
                        new Class6();

                        this.string_2 = "SELECT * FROM tblTransaction WHERE trans_num = '" + str + "' ";


                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                        DataSet dataSet = new DataSet();
                        this.oleDbDataAdapter_0.Fill(dataSet);
                        this.oleDbConnection_0.Close();
                        if (dataSet.Tables[0].Rows.Count != 0)
                        {
                            this.Txt_ImpID.Text = dataSet.Tables[0].Rows[0]["imp_id"].ToString();
                            this.Txt_ExpID.Text = dataSet.Tables[0].Rows[0]["exp_id"].ToString();
                            this.Txt_Remark.Text = dataSet.Tables[0].Rows[0]["remark"].ToString();
                            this.Txt_Voucher.Text = dataSet.Tables[0].Rows[0]["voucher"].ToString();
                            this.dateEdit1.DateTime = (DateTime)dataSet.Tables[0].Rows[0]["tran_date"];
                            this.string_4 = (DateTime)dataSet.Tables[0].Rows[0]["tran_date"];
                            this.string_5 = dataSet.Tables[0].Rows[0]["tran_time"].ToString();
                            this.chk_inclVat.Checked = (bool)dataSet.Tables[0].Rows[0]["vat_incl"];
                            this.Chk_discpervat.Checked = (bool)dataSet.Tables[0].Rows[0]["discpervat"];
                            this.Chk_includedisc.Checked = (bool)dataSet.Tables[0].Rows[0]["disc_incl"];
                            this.method_3(this.string_0, dataSet.Tables[0].Rows[0]["trans_num"].ToString());
                            this.Cmb_TaxCode.Text = dataSet.Tables[0].Rows[0]["tax_code"].ToString();
                            Class11.smethod_3(this);
                            this.string_3 = "F";
                            if (!Class7.smethod_50())
                            {
                                this.btn_Edit.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                                this.btn_Delete.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                            }
                            Class11.smethod_5(this, "F");
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select sum(amount) + sum(vat_amt) AS t_amt, sum(amount) AS a_amt, sum(disc_amt) AS d_amt, sum(vat_amt) AS v_amt from " + this.string_0, this.oleDbConnection_0);
                            DataSet set = new DataSet();
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                            this.method_5();
                            this.method_1();
                        }
                        if ((bool)dataSet.Tables[0].Rows[0]["status"])
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
                    Class7.BrowserForm1("select trans_num as 'Số giao dịch', goods_id AS 'M\x00e3 h\x00e0ng', exp_id AS 'Nơi xuất', qty AS 'Số lượng', amount AS 'Tổng tiền', Status from tblTransaction where trans_code = '" + this.string_1 + "' order by trans_num ", this.oleDbConnection_0);
                    this.Txt_TransNum.Text = BrowseForm.strReturn;
                    break;
            }
        }

    }
}