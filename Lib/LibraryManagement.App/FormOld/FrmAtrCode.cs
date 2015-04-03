using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmAtrCode : DevExpress.XtraEditors.XtraForm
    {
        public FrmAtrCode()
        {
            InitializeComponent();
            this.oleDbConnection_0 = DataProvider.GetConnection();
        }

        private void btn_Correct_Click(object sender, EventArgs e)
        {
            if (this.GridView1.RowCount != 0)
            {
                if (this.Lbl_StockName.Text == string.Empty)
                {
                    Class7.ShowMessageBox("Bạn chưa chọn m\x00e3 kho, quầy !", 1);
                    this.Txt_StockId.Focus();
                }
                else if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn hiệu chỉnh kh\x00f4ng ?", 2) == 1)
                {
                    Class6 class2 = new Class6();
                    string str5 = class2.method_5("K");
                    WaitDialogForm form = new WaitDialogForm();
                    form.Caption = "Tạo giao dịch " + str5;
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter("select tblAdjust.*, tblgoods.piceunit from tblAdjust inner join tblgoods on tblAdjust.goods_id = tblgoods.goods_id where tblAdjust.real_qty <> 0 ", this.oleDbConnection_0);
                    DataTable dataTable = new DataTable();
                    this.oleDbDataAdapter_0.Fill(dataTable);
                    this.oleDbConnection_0.Close();
                    if (dataTable.Rows.Count == 0)
                    {
                        Class7.ShowMessageBox("Kh\x00f4ng c\x00f3 sự ch\x00eanh lệch, kh\x00f4ng cần hiệu chỉnh !", 1);
                        form.Close();
                    }
                    else
                    {
                        string str = Class7.smethod_19();
                        string str2 = Class7.smethod_53();
                        string str3 = this.Txt_StockId.Text.Trim();
                        string str4 = "Giao dịch c\x00e2n đối kiểm k\x00ea tự động";
                        int num = 1;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string str6 = (Class7.smethod_0(row["real_qty"].ToString()) > 0.0) ? "" : str3;
                            string str7 = (Class7.smethod_0(row["real_qty"].ToString()) < 0.0) ? "" : str3;
                            double num2 = Math.Abs(Class7.smethod_0(row["real_qty"].ToString()));
                            double num3 = num2 * Class7.smethod_0(row["averimppr"].ToString());
                            string selectCommandText = string.Concat(new object[] { 
                                "INSERT INTO tblTransaction(tran_date, tran_time, trans_num, trans_code, voucher, invoice, post, exp_id, imp_id,goods_id, qty, unit_symb, amount, discount, vat_amt, surplus, commis_amt, user_id,cs_id,remark, updated, merc_type, tax_code, vat_incl, discpervat, disc_incl, copies, recnum, Status) VALUES('", str, "','", str2, "','", str5, "','", this.string_0, "','','',0,'", str6, "','", str7, "','", row["goods_id"], "',", num2, 
                                ",'", row["piceunit"], "',", num3, ",0,0,0,0, ", Class7.GetUserRight(), ",'',N'", str4, "',0,'01','',0,0,0,0,", num, ",1)"
                             });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                            using (DataSet set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_0.Close();
                            }
                            num++;
                        }
                        class2.ComputeTransnum("K");
                        form.Caption = "Tạo giao dịch " + str5;
                        this.method_2();
                        Class7.ShowMessageBox("Hiệu chỉnh dữ liệu th\x00e0nh c\x00f4ng !", 1);
                        form.Close();
                    }
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if ((this.GridView1.RowCount != 0) || (this.ErrorView.RowCount != 0))
            {
                if (this.XtraTabControl1.SelectedTabPageIndex == 0)
                {
                    this.printableComponentLink_0.Component = this.GrdMercLst;
                }
                else
                {
                    this.printableComponentLink_0.Component = this.GrdErrorId;
                }
                this.printableComponentLink_0.Landscape = false;
                this.printableComponentLink_0.Margins.Left = 20;
                this.printableComponentLink_0.Margins.Right = 20;
                this.printableComponentLink_0.Margins.Bottom = 40;
                this.printableComponentLink_0.Margins.Top = 40;
                this.printableComponentLink_0.CreateDocument();
                this.printableComponentLink_0.ShowPreview();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a danh mục kiểm k\x00ea kh\x00f4ng ?", 2) == 1)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("delete from tblAdjust", Class7.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                Class7.oleDbConnection_1.Close();
                this.method_0();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.Lbl_StockName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa chọn kho, quầy kiểm k\x00ea", 1);
                this.Txt_StockId.Focus();
            }
            else if (this.Txt_TextFile.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa chọn file kiểm k\x00ea", 1);
                this.Txt_TextFile.Focus();
            }
            else
            {
                string str = this.Txt_StockId.Text.Trim();
                WaitDialogForm form = new WaitDialogForm();
                form.Caption = "Tạo danh mục kiểm k\x00ea ....";

                this.ReadCollectTextfile();
                form.Caption = "Cập nhật lượng tồn ....";
                OleDbDataAdapter adapter = new OleDbDataAdapter("select adj.goods_id, (stk.begin_qty + stk.imp_qty) - stk.exp_qty as stk_qty, stk.averimppr from tbladjust as adj inner join tblStockInfo as stk on adj.goods_id = stk.goods_id where stk.id = '" + str + "'", Class7.oleDbConnection_1);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Class7.oleDbConnection_1.Close();
                foreach (DataRow row in dataTable.Rows)
                {
                    adapter = new OleDbDataAdapter(string.Concat(new object[] { "update tblAdjust set end_qty = ", row["stk_qty"], ", averimppr = ", row["averimppr"], " where goods_id = '", row["goods_id"], "'" }), Class7.oleDbConnection_1);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                    Class7.oleDbConnection_1.Close();
                }
                adapter = new OleDbDataAdapter("update tblAdjust set real_qty = qty - end_qty ", Class7.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                Class7.oleDbConnection_1.Close();
                this.method_0();
                this.method_1();
                if (this.ErrorView.RowCount != 0)
                {
                    this.Lbl_Warning.Visible = true;
                    this.Lbl_Warning.Text = "Lưu \x00fd : c\x00f3 " + this.ErrorView.RowCount + " m\x00e3 sai";
                    this.XtraTabControl1.SelectedTabPageIndex = 1;
                }
                else
                {
                    this.Lbl_Warning.Visible = false;
                }
                form.Close();
            }
        }

        private void chk_ByStore_CheckedChanged(object sender, EventArgs e)
        {
            string str = this.Txt_StockId.Text.Trim();
            if (this.chk_ByStore.Checked)
            {
                if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn hiệu chỉnh to\x00e0n bộ kho, quầy n\x00e0y kh\x00f4ng ?", 2) != 1)
                {
                    this.chk_ByStore.Checked = false;
                }
                else
                {
                    Class7.ShowMessageBox("Bạn đ\x00e3 chọn tự động hiệu chỉnh to\x00e0n bộ c\x00e1c mặt h\x00e0ng trong kho, quầy n\x00e0y", 1);

                    WaitDialogForm form = new WaitDialogForm();
                    form.Caption = "Kiểm tra lượng tồn kho, xin đợi ....";


                    string selectCommandText = "SELECT tblStockInfo.id, tblStockInfo.goods_id,tblStockInfo.averimppr, tblStockInfo.imp_qty - tblStockInfo.exp_qty + tblStockInfo.begin_qty AS endqty FROM tblStockInfo LEFT JOIN tblAdjust ON tblAdjust.goods_id = tblStockInfo.goods_id  WHERE tblStockInfo.id = '" + str + "'  AND  not exists(select goods_id from tblNon_plu where tblNon_plu.goods_id = tblStockInfo.goods_id) ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                    using (DataTable table = new DataTable())
                    {
                        this.oleDbDataAdapter_0.Fill(table);
                        this.oleDbConnection_0.Close();
                        foreach (DataRow row in table.Rows)
                        {
                            form.Caption = "M\x00e3 h\x00e0ng " + row["goods_id"].ToString();
                            double num = 0.0 - Class7.smethod_2(row["endqty"]);
                            selectCommandText = string.Concat(new object[] { "IF NOT EXISTS (SELECT goods_id from tblAdjust WHERE goods_id = '", row["goods_id"], "')  INSERT INTO tblAdjust(pos_id, goods_id, qty, end_qty, real_qty, averimppr)  VALUES ('", str, "','", row["goods_id"], "',0,", row["endqty"], ",", num, ",", row["averimppr"], ") " });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                            using (DataSet set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_0.Close();
                                continue;
                            }
                        }
                    }
                    form.Caption = "Đ\x00e3 tạo xong số lượng to\x00e0n bộ kho, quầy";
                    form.Close();
                    this.method_0();
                }
            }
        }
        private void FrmAdjust_grp_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmAdjust_grp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.string_1 = "DELETE  FROM tblAdjust ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
            }
        }

        private void FrmAdjust_grp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.P))
            {
                this.btn_Print_Click(this, new EventArgs());
            }
        }

        private void FrmAdjust_grp_Load(object sender, EventArgs e)
        {
            this.Text = "C\x00e2n đối kiểm k\x00ea tự động";
            this.Txt_StockId.Focus();
            this.method_0();
            this.method_1();
            this.Chk_mbc.Enabled = false;
            this.Lbl_Warning.Visible = false;
        }

        private void IjSwogAv6(object sender, EventArgs e)
        {
            this.toolTipController_0.ShowHint("Lưu \x00fd : Hiệu chỉnh to\x00e0n bộ m\x00e3 h\x00e0ng c\x00f2n tồn trong kho, quầy " + this.Txt_StockId.Text + " nhưng kh\x00f4ng nằm trong danh mục kiểm k\x00ea về 0");
        }

        private void method_0()
        {
            string selectCommandText = "SELECT adj.goods_id AS [M\x00e3 h\x00e0ng], gs.full_name AS [T\x00ean h\x00e0ng h\x00f3a], gs.grp_id AS Nh\x00f3m, gs.piceunit AS [Đ.vị], gs.supp_id AS NCC, adj.end_qty AS [Hiện tồn], adj.qty AS [Thực tồn], adj.real_qty AS [Ch\x00eanh lệch]  FROM tblAdjust AS adj INNER JOIN tblGoods AS gs ON adj.goods_id = gs.goods_id Order By gs.grp_id, adj.goods_id ";
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommandText, Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            this.GrdMercLst.DataSource = dataSet.Tables[0];
            this.GridView1.OptionsBehavior.Editable = false;
            this.GridView1.BestFitColumns();
            this.GridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.FieldName = "M\x00e3 h\x00e0ng";
            this.GridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.SummaryType = SummaryItemType.Count;
            this.GridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.DisplayFormat = "{0:n0}";
        }

        private void method_1()
        {
            string selectCommandText = "SELECT tblAdjust.goods_id AS [M\x00e3 h\x00e0ng sai], tblAdjust.qty AS [Số lượng] FROM tblAdjust LEFT JOIN tblGoods ON tblAdjust.goods_id = tblGoods.goods_id  WHERE  tblGoods.goods_id Is null ";
            OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommandText, Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            this.GrdErrorId.DataSource = dataSet.Tables[0];
        }

        private void method_2()
        {
            string str = this.Txt_StockId.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select tblAdjust.*, tblgoods.piceunit from tblAdjust inner join tblgoods on tblAdjust.goods_id = tblgoods.goods_id where tblAdjust.real_qty <> 0 ", this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_0.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                double num = (Class7.smethod_0(row["real_qty"].ToString()) > 0.0) ? Class7.smethod_0(row["real_qty"].ToString()) : 0.0;
                double num2 = (Class7.smethod_0(row["real_qty"].ToString()) < 0.0) ? Math.Abs(Class7.smethod_0(row["real_qty"].ToString())) : 0.0;
                double num3 = (num2 != 0.0) ? (num2 * Class7.smethod_0(row["averimppr"].ToString())) : 0.0;
                double num4 = (num != 0.0) ? (num * Class7.smethod_0(row["averimppr"].ToString())) : 0.0;
                string str2 = row["goods_id"].ToString().Trim();
                string selectCommandText = string.Concat(new object[] { 
                    "IF EXISTS (SELECT id FROM tblStockInfo WHERE id = '", str, "' and goods_id = '", str2, "') UPDATE  tblStockInfo SET Imp_qty = imp_qty + ", num, " , imp_amt = imp_amt + ", num4, ",  exp_qty = exp_qty + ", num2, ", exp_amt = exp_amt + ", num3, ", last_date ='", Class6.string_13, "' WHERE id = '", str, 
                    "' AND goods_id = '", str2, "' Else INSERT INTO tblStockInfo(id,goods_id, Imp_qty,imp_amt,exp_qty, exp_amt, last_date )  VALUES('", str, "','", str2, "',", num, ", ", num4, ",", num2, ",", num3, ",'", Class6.string_13, 
                    "')"
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
        }

        private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
        {
            this.Txt_TextFile.Text = this.openFileDialog_0.FileName.ToString();
            this.Txt_TextFile.Properties.ReadOnly = true;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = null;
            if (this.XtraTabControl1.SelectedTabPageIndex == 0)
            {
                text = "Danh s\x00e1ch h\x00e0ng kiểm k\x00ea";
            }
            else
            {
                text = "Danh s\x00e1ch m\x00e3 h\x00e0ng sai";
            }
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }

        public void ReadCollectTextfile()
        {
            string path = this.Txt_TextFile.Text.Trim();
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string str2 = this.Txt_StockId.Text.Trim();
            string str3 = null;
            string str4 = null;
            double num = 0.0;
            reader.BaseStream.Seek(0L, SeekOrigin.Begin);
            try
            {
                string str5 = null;
                TextReader reader2 = new StreamReader(path);
                while (!string.IsNullOrEmpty(str5 = reader.ReadLine()))
                {
                    str5 = reader2.ReadLine();
                    str3 = str5.Substring(0, 14).Trim();
                    if (str3.Length == 6)
                    {
                        str4 = str3;
                    }
                    else
                    {
                        OleDbDataAdapter adapter = new OleDbDataAdapter("select goods_id from tblbarcode where barcode = '" + str3 + "'", Class7.oleDbConnection_1);
                        DataSet set = new DataSet();
                        adapter.Fill(set);
                        Class7.oleDbConnection_1.Close();
                        if (set.Tables[0].Rows.Count != 0)
                        {
                            str4 = set.Tables[0].Rows[0][0].ToString();
                        }
                        else
                        {
                            str4 = str3;
                        }
                    }
                    str5.ToCharArray();
                    string[] strArray = str5.Split(new char[] { ',' });
                    num = (Class7.smethod_0(strArray[1].ToString()) == 0.0) ? 1.0 : Class7.smethod_0(strArray[1].ToString());
                    object obj2 = " IF EXISTS (SELECT goods_id FROM tblAdjust WHERE goods_id = '" + str4 + "')  ";
                    obj2 = string.Concat(new object[] { obj2, "UPDATE tblAdjust SET qty = qty + ", num, " WHERE goods_id = '", str4, "' Else " });
                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(string.Concat(new object[] { obj2, "INSERT INTO tblAdjust(pos_id,goods_id,QTy) VALUES('", str2, "','", str4, "',", num, ")" }), Class7.oleDbConnection_1);
                    DataSet dataSet = new DataSet();
                    adapter2.Fill(dataSet);
                    Class7.oleDbConnection_1.Close();
                }
                reader2.Close();
                reader2 = null;
            }
            catch (IOException)
            {
                Class7.ShowMessageBox("C\x00f3 lỗi trong file txt, bạn h\x00e3y kiểm tra lại", 1);
            }
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.chk_ByStore.Enabled = this.Lbl_StockName.Text != string.Empty;
            this.btnUpdate.Enabled = this.Txt_TextFile.Text != string.Empty;
        }

        private void Txt_StockId_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_StockId.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_StockId.Text, "and type IN('01','02') and status = 1", Class7.oleDbConnection_1, ref str);
                this.Lbl_StockName.Text = str;
            }
        }

        private void Txt_StockId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean kho h\x00e0ng', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('01','02') and status = 1";
                Class7.BrowserForm1(str, Class7.oleDbConnection_1);
                this.Txt_StockId.Text = BrowseForm.strReturn;
                this.Txt_StockId.SelectAll();
            }
        }

        private void Txt_TextFile_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            this.openFileDialog_0.InitialDirectory = Application.StartupPath;
            this.openFileDialog_0.Title = "Chọn file dữ liệu kiểm k\x00ea";
            this.openFileDialog_0.Filter = "TXT Files|*.txt";
            this.openFileDialog_0.ShowDialog();
        }


    }
}