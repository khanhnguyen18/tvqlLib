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

namespace LibraryManagement.App
{
    public partial class FrmImportMerc : XtraForm
    {
        public FrmImportMerc()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            new UnitsForm().ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.string_3 != "F")
            {
                return;
            }
            string str = this.Txt_TransNum.Text.Trim();
            string str2 = this.cmbImport.Text.Trim();
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
                    class2.method_14("tblTransaction", str, 1);
                    class2.method_17(str);
                    class2.method_7(str, str2);
                    this.btn_Skip_Click(this, new EventArgs());
                }
                return;
            }
            if (!class2.method_22())
            {
                this.string_2 = "select goods_id, imp_id, qty from tblTransaction where trans_num = '" + str + "'";
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
                            goto Label_0174;
                        }
                    }
                    goto Label_01AB;
                Label_0174:
                    Class7.ShowMessageBox("Số lượng tồn kh\x00f4ng đủ để x\x00f3a giao dịch n\x00e0y !", 1);
                    return;

                }
            }
        Label_01AB:
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1)
            {
                class2.method_18(str);
                class2.method_8(str);
                class2.method_14("tblTransaction", str, 0);
                this.btn_Skip_Click(this, new EventArgs());
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.cmbImport.Enabled = true;
            this.Txt_ExpID.Enabled = true;
            this.Txt_Date.Enabled = false;
            this.string_3 = "E";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            this.Txt_TransNum.Text = new Class6().method_5("K");
            this.string_3 = "N";
            this.Txt_Date.Text = Class7.smethod_19();
            this.Txt_Date.Enabled = false;
            this.Txt_ExpID.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Lbl_ExpName.Text == string.Empty)
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
                string str4 = this.Txt_ExpID.Text.Trim();
                string str5 = this.cmbImport.Text.Trim();
                this.Txt_Remark.Text.Trim();
                this.Txt_Voucher.Text.Trim();
                if (this.TransDetail.RowCount != 0)
                {
                    Class6 class2 = new Class6();
                    string str3 = this.string_3;
                    if (str3 != null)
                    {
                        if (!(str3 == "N"))
                        {
                            if (str3 == "E")
                            {
                                this.bool_0 = false;
                                this.string_6 = this.string_4;
                                this.btn_Skip_Click(this, new EventArgs());
                                class2.method_18(str);
                                class2.method_8(str);
                                class2.method_13(str);
                                class2.method_17(str);
                                class2.method_7(str, str5);
                                class2.kCnalMegv(this.string_0);
                                class2.method_11(this.string_0, str4);
                            }
                        }
                        else
                        {
                            this.bool_0 = true;
                            this.string_6 = Class7.smethod_19();
                            class2.ComputeTransnum("K");
                            class2.method_17(str);
                            class2.method_7(str, str5);
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
                            OleDbDataAdapter adapter = new OleDbDataAdapter(string.Concat(new object[] { obj2, "'", row["grp_id"], "','", row["exp_id"], "','", row["rtprice"], "',", row["qty"], ",", Class7.GetUserId(), ")" }), this.oleDbConnection_0);
                            using (DataSet set2 = new DataSet())
                            {
                                adapter.Fill(set2);
                            }
                            this.oleDbConnection_0.Close();
                        }
                    }
                    Class6.transNum = str;
                    Class7.CreateReportInstance("v_frsupp").ShowPreviewDialog();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            this.Txt_TransNum.Enabled = true;
            this.string_3 = "S";
            this.Txt_TransNum.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
        }

        private void iGoods_ItemClick(object sender, ItemClickEventArgs e)
        {
            new BookForm().ShowDialog();
        }

        private void iGoodsGrp_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmLanguage().ShowDialog();
        }



        private void iStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ReaderForm().ShowDialog();
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            string str;
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("select goods_id as 'M\x00e3 số', full_name AS 'Diễn giải' from tblGoods where status = 1 and mbc = 0", this.oleDbConnection_0);
                this.Txt_GoodsId.Text = BrowseForm.strReturn;
            }
            if (e.KeyCode != Keys.Return)
            {
                return;
            }
            string str2 = this.Txt_GoodsId.Text.Trim();
            string str3 = Class7.smethod_14("m_plu").ToString().Trim();
            if (str2.Length > 6)
            {
                DataSet set;
                if (str2.Substring(0, str3.Length) == str3)
                {
                    this.string_2 = "select goods_id from tblNon_Plu where nplu_code = '" + str2.Substring(0, str3.Length) + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        if (set.Tables[0].Rows.Count != 0)
                        {
                            this.Txt_GoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                        }
                        this.oleDbConnection_0.Close();
                        goto Label_01EA;
                    }
                }
                this.string_2 = "select goods_id from tblbarcode where barcode = '" + str2 + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_GoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                    }
                    this.oleDbConnection_0.Close();
                }
            }
        Label_01EA:
            str = this.Txt_GoodsId.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT  A.goods_id, A.full_name, A.packunit, A.piceunit, B.lastimppr, B.prefprice FROM  tblGoods AS A  INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id where A.goods_id = '" + str + "'", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Lbl_MercName.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
                this.Txt_Price.EditValue = Class7.ParseDoubleValue(dataSet.Tables[0].Rows[0]["prefprice"].ToString());
                this.Txt_Qty.Text = "1";
                this.Txt_GoodsId.Focus();
            }
            else
            {
                this.Lbl_MercName.Text = string.Empty;
                this.Txt_Price.EditValue = 0;
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
                    if (this.string_3 == "S")
                    {
                        string str = this.Txt_TransNum.Text.Trim();
                        new Class6();
                        if (Class7.GetUserId() == 1)
                        {
                            this.string_2 = "SELECT * FROM tblTransaction WHERE trans_num = '" + str + "' ";
                        }
                        else
                        {
                            this.string_2 = "SELECT * FROM tblTransaction WHERE trans_num = '" + str + "' AND tran_date = '" + Class7.smethod_19() + "'";
                        }
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                        DataSet dataSet = new DataSet();
                        this.oleDbDataAdapter_0.Fill(dataSet);
                        this.oleDbConnection_0.Close();
                        if (dataSet.Tables[0].Rows.Count != 0)
                        {
                            this.cmbImport.Text = dataSet.Tables[0].Rows[0]["imp_id"].ToString();
                            this.Txt_ExpID.Text = dataSet.Tables[0].Rows[0]["exp_id"].ToString();
                            this.Txt_Remark.Text = dataSet.Tables[0].Rows[0]["remark"].ToString();
                            this.Txt_Voucher.Text = dataSet.Tables[0].Rows[0]["voucher"].ToString();
                            this.Txt_Date.Text = dataSet.Tables[0].Rows[0]["tran_date"].ToString();
                            this.string_4 = dataSet.Tables[0].Rows[0]["tran_date"].ToString();
                            this.string_5 = dataSet.Tables[0].Rows[0]["tran_time"].ToString();
                            Class11.smethod_3(this);
                            this.string_3 = "F";
                            if (!Class7.smethod_50())
                            {
                                this.btn_Edit.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                                this.btn_Delete.Enabled = Class7.smethod_49(this.Txt_TransNum.Text);
                            }
                            Class11.smethod_5(this, "F");
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select sum(amount) + sum(vat_amt) AS t_amt, sum(amount) AS a_amt, sum(disc_amt) AS d_amt, sum(vat_amt) AS v_amt from " + this.string_0, this.oleDbConnection_0);
                            DataSet set2 = new DataSet();
                            this.oleDbDataAdapter_0.Fill(set2);
                            this.oleDbConnection_0.Close();
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
                    Class7.BrowserForm1("select trans_num as 'Số giao dịch', goods_id AS 'M\x00e3 h\x00e0ng', exp_id AS 'Nơi xuất', qty AS 'Số lượng', amount AS 'Tổng tiền', Status from tblTransaction where tran_date = '" + Class7.smethod_19() + "' and trans_code = '" + this.string_1 + "' order by trans_num ", this.oleDbConnection_0);
                    this.Txt_TransNum.Text = BrowseForm.strReturn;
                    break;
            }
        }
    }
}