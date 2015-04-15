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
    public partial class FrmToSupp : DevExpress.XtraEditors.XtraForm
    {
        public FrmToSupp()
        {
            InitializeComponent();

            this.oleDbConnection_0 = new OleDbConnection(Class7.string_4);
            this.oleDbConnection_1 = new OleDbConnection(Class7.string_5);
            this.string_0 = "TOSUPP_" + Class6.smethod_0(SystemInformation.ComputerName);

        }



        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class11.string_0 == "F")
            {
                string str2 = this.Txt_TransNum.Text.Trim();
                string str3 = this.Txt_ExpID.Text.Trim();
                Class6 class2 = new Class6();
                string text = this.btn_Delete.Text;
                if (text != null)
                {
                    if (!(text == "&X\x00f3a"))
                    {
                        if ((text == "&Phục hồi") && (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn phục hồi giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1))
                        {
                            class2.method_14("tblTransaction", str2, 1);
                            class2.method_19(str2);
                            class2.method_9(str2, str3);
                            this.btn_Skip_Click(this, new EventArgs());
                        }
                    }
                    else if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a giao dịch n\x00e0y kh\x00f4ng ?", 2) == 1)
                    {
                        class2.method_20(str2);
                        class2.method_10(str2);
                        class2.method_14("tblTransaction", str2, 0);
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

        private void btn_New_Click(object sender, EventArgs e)
        {
            this.method_0();
            this.method_1();
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            this.Txt_TransNum.Text = new Class6().method_5("K");
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
                string str3 = this.Txt_ExpID.Text.Trim();
                string str4 = this.Txt_ImpID.Text.Trim();
                string str5 = this.Txt_Remark.Text.Trim();
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
                                class2.method_20(str2);
                                class2.method_10(str2);
                                class2.method_13(str2);
                                class2.method_6(this.string_0, str2, this.string_1, str3, str4, str6, str5, this.string_3);
                                class2.method_9(str2, str3);
                            }
                        }
                        else
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            class2.ComputeTransnum("K");
                            string str7 = Class7.smethod_53();
                            class2.method_6(this.string_0, str2, this.string_1, str3, str4, str6, str5, str7);
                            class2.method_19(str2);
                            class2.method_9(str2, str3);
                        }
                    }
                    Class6.transNum = str2;
                    v_tosupp sup = new v_tosupp();
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


        private void FrmToSupp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_0, this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
        }

        private void FrmToSupp_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.Text = Class6.string_1.ToString();
            this.Lbl_Date.Text = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.btn_Skip_Click(this, new EventArgs());
            try
            {
                string selectCommandText = "CREATE TABLE " + this.string_0 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((1)),[price] [decimal](18, 2) DEFAULT ((0)),[amount] [decimal](18, 2) DEFAULT ((0)),[disc_amt] [decimal](18, 2) DEFAULT ((0)),[unitsymb] [nvarchar](3) DEFAULT (('')),[vat_amt] [decimal](18, 2) DEFAULT ((0)),[merc_type] [nvarchar](2) DEFAULT (('')),[surplus] [decimal](18, 2) DEFAULT ((0)))";
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



        private void kCnalMegv(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("select goods_id as 'M\x00e3 số', full_name AS 'Diễn giải' from tblGoods where status = 1 and mbc = 0", this.oleDbConnection_1);
                this.Txt_GoodsId.Text = BrowseForm.strReturn;
            }
        }

        private void method_0()
        {
            Class11.smethod_8(this);
            this.Lbl_ImpName.Text = string.Empty;
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

        private void Txt_ExpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ExpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ExpID.Text, "and type IN('01','02') and status = 1", this.oleDbConnection_1, ref str);
                this.Lbl_ExpName.Text = str;
            }
        }

        private void Txt_ExpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean kho h\x00e0ng', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('01','02') and status = 1";
                Class7.BrowserForm1(str, this.oleDbConnection_1);
                this.Txt_ExpID.Text = BrowseForm.strReturn;
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

        private void Txt_ImpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ImpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ImpID.Text, "and type IN('05','06') and status = 1", this.oleDbConnection_1, ref str);
                this.Lbl_ImpName.Text = str;
            }
        }

        private void Txt_ImpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('05','06') and status = 1";
                Class7.BrowserForm1(str, this.oleDbConnection_1);
                this.Txt_ImpID.Text = BrowseForm.strReturn;
                this.Txt_ImpID.SelectAll();
            }
        }

        private void Txt_TransNum_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Txt_TransNum.Text.Trim())) return;

            this.string_2 = "SELECT * FROM tblTransaction WHERE trans_num = '" + this.Txt_TransNum.Text.Trim() + "' ";

            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_1);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_1.Close();
                if (set.Tables[0].Rows.Count == 0)
                {
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

        private void Txt_TransNum_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    if (Class11.string_0 == "S")
                    {

                        this.string_2 = "SELECT * FROM tblTransaction WHERE trans_num = '" + this.Txt_TransNum.Text.Trim() + "' ";

                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_1);
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

                case Keys.F2:
                    Class7.BrowserForm1("select trans_num as 'Số giao dịch', goods_id AS 'M\x00e3 h\x00e0ng', exp_id AS 'Nơi xuất', qty AS 'Số lượng', amount AS 'Tổng tiền', Status from tblTransaction where trans_code = '" + this.string_1 + "' order by trans_num ", this.oleDbConnection_1);
                    this.Txt_TransNum.Text = BrowseForm.strReturn;
                    break;
            }
        }

    }
}