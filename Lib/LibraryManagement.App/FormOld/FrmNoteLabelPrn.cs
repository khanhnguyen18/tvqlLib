using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmNoteLabelPrn : DevExpress.XtraEditors.XtraForm
    {
        public FrmNoteLabelPrn()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!((Class7.smethod_0(this.Txt_Qty.Text) <= 0.0) | (this.Lbl_FullName.Text == string.Empty)))
            {
                string str = this.Txt_PosId.Text.Trim();
                string str2 = this.Txt_GoodsId.Text.Trim();
                string str3 = this.Lbl_ShortName.Text.Trim();
                string str4 = this.Lbl_FullName.Text.Trim();
                string str5 = this.Lbl_GrpId.Text.Trim();
                string str6 = this.Lbl_SuppId.Text.Trim();
                double num = Class7.smethod_0(this.Lbl_Rtprice.Text);
                string str7 = this.Txt_Remark.Text.Trim();
                string text = this.Lbl_Barcode.Text;
                string str9 = DateTime.Now.ToString("HH:mm:ss");
                double num2 = Class7.smethod_0(this.Txt_Qty.Text);
                string selectCommandText = string.Concat(new object[] { 
                    "IF NOT EXISTS(select goods_id from ", base.Tag.ToString(), " where goods_id = '", str2, "' and user_id = ", Class7.GetUserRight(), ") INSERT INTO ", base.Tag.ToString(), "([timeinput],[pos_id],[goods_id],[barcode],[shortname],[fullname],[grp_id],[supp_id],[rtprice],[qty],[remark],user_id) VALUES('", str9, "', '", str, "' ,'", str2, "','", text, 
                    "' ,N'", str3, "',N'", str4, "','", str5, "','", str6, "','", num, "',", num2, ",'", str7, "', ", Class7.GetUserRight(), 
                    ") Else UPDATE ", base.Tag.ToString(), " SET qty = qty + ", num2, ",timeinput = '", str9, "' where goods_id = '", str2, "' and user_id = ", Class7.GetUserRight()
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
                this.method_0();
                this.method_1();
                this.Txt_Qty.Text = "1";
                this.Txt_GoodsId.Focus();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_ListPrn_Click(object sender, EventArgs e)
        {
            this.printableComponentLink_0.Landscape = false;
            this.printableComponentLink_0.Margins.Left = 50;
            this.printableComponentLink_0.Margins.Right = 50;
            this.printableComponentLink_0.Margins.Bottom = 80;
            this.printableComponentLink_0.Margins.Top = 80;
            this.printableComponentLink_0.CreateDocument();
            this.printableComponentLink_0.ShowPreview();
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            if ((this.Labels_View.RowCount != 0) && (Class7.smethod_0(this.Txt_Qty.Text) > 0.0))
            {
                double num = Class7.smethod_0(this.Txt_Qty.Text);
                string str = this.Txt_GoodsId.Text.Trim();
                string str2 = DateTime.Now.ToString("HH:mm:ss");
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "update ", base.Tag.ToString(), " set qty = qty - ", num, ", timeinput = '", str2, "' where goods_id = '", str, "' and user_id = ", Class7.GetUserRight() }), this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
                this.method_2();
                this.method_1();
            }
        }

        private void btn_Print108_Click(object sender, EventArgs e)
        {
            if (this.Labels_View.RowCount != 0)
            {
                if (this.cnvLekth7.SelectedIndex == 0)
                {
                    _notebarcode = false;
                }
                else
                {
                    _notebarcode = true;
                }
                this.method_4();
                NoteA4 note = new NoteA4();
                note.PrintingSystem.ShowMarginsWarning = false;
                note.PrintingSystem.ShowPrintStatusDialog = false;
                note.ShowPreviewDialog();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if ((this.Labels_View.RowCount != 0) && (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a hết lượng tem đ\x00e3 đặt in kh\x00f4ng", 2) == 1))
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "DELETE FROM ", base.Tag.ToString(), " where user_id = ", Class7.GetUserRight() }), this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_1.Close();
                this.method_1();
            }
        }

        private void Chk_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_SelectAll.Checked)
            {
                if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn in bảng c\x00e0i kệ cho to\x00e0n bộ mặt h\x00e0ng", 2) != 1)
                {
                    this.Chk_SelectAll.Checked = false;
                }
                else
                {
                    DataSet set;
                    WaitDialogForm form = new WaitDialogForm();
                    form.Caption = "Xin chờ một ch\x00fat ....";
                    this.string_0 = string.Concat(new object[] { "DELETE FROM ", base.Tag.ToString(), " WHERE user_id = ", Class7.GetUserRight() });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_1);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_1.Close();
                    }
                    this.string_0 = "SELECT  gs.goods_id,gs.barcode, gs.grp_id, gs.short_name, gs.full_name, gs.supp_id, pr.rtprice  FROM tblGoods AS gs INNER JOIN  tblPrice AS pr ON gs.goods_id = pr.goods_id ";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_1);
                    using (DataTable table = new DataTable())
                    {
                        this.oleDbDataAdapter_0.Fill(table);
                        this.oleDbConnection_1.Close();
                        int num = 1;
                        foreach (DataRow row in table.Rows)
                        {
                            DateTime.Now.ToString("HH:mm:ss");
                            string str = row["rtprice"].ToString();
                            this.string_0 = string.Concat(new object[] { 
                                "INSERT INTO ", base.Tag.ToString(), "(idx,[pos_id],[goods_id],[barcode],[shortname],[fullname],[grp_id],[supp_id],[rtprice],[qty],[remark],user_id) VALUES(", num, ", '00002' ,'", row["goods_id"], "','", row["barcode"], "', N'", row["short_name"], "',N'", row["full_name"], "','", row["grp_id"], "','", row["supp_id"], 
                                "','", str, "',1,'', ", Class7.GetUserRight(), ") "
                             });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_1);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_1.Close();
                            }
                            num++;
                            form.Caption = "M\x00e3 h\x00e0ng số " + row["goods_id"].ToString();
                        }
                    }
                    this.method_1();
                    form.Close();
                }
            }
        }

        private void FrmNoteLabelPrn_Activated(object sender, EventArgs e)
        {
        }

        private void FrmNoteLabelPrn_Load(object sender, EventArgs e)
        {
            this.Text = " In bảng c\x00e0i kệ";
            base.Tag = "tblNoteLabels";
            this.Txt_PosId.Text = "00001";
            this.Txt_PosId.Enabled = false;
            this.method_1();
            this.Txt_GoodsId.Focus();
        }

        private void Grd_Labels_Click(object sender, EventArgs e)
        {
            this.Txt_GoodsId.Text = this.Labels_View.GetRowCellValue(this.Labels_View.FocusedRowHandle, this.Labels_View.Columns["M\x00e3 h\x00e0ng"]).ToString();
        }



        private void Lbl_GrpId_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("description", "tblGoodsGrp", "id", this.Lbl_GrpId.Text, "", Class7.oleDbConnection_1, ref str);
            this.Lbl_GrpName.Text = str;
        }

        private void Lbl_SuppId_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("fullname", "tblStore", "id", this.Lbl_SuppId.Text, "", Class7.oleDbConnection_1, ref str);
            this.Lbl_SuppName.Text = str;
        }

        private void method_0()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "select goods_id from ", base.Tag.ToString(), " where user_id = ", Class7.GetUserRight(), " Order by timeinput" }), this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            int num = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { " UPDATE ", base.Tag.ToString(), " set idx = ", num, " where goods_id = '", row["goods_id"], "' and user_id = ", Class7.GetUserRight() }), this.oleDbConnection_1);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    num++;
                }
                this.oleDbConnection_1.Close();
            }
        }

        private void method_1()
        {
            string selectCommandText = string.Concat(new object[] { "SELECT [idx] AS [TT],[goods_id] AS [M\x00e3 h\x00e0ng] ,barcode,[fullname] AS [T\x00ean h\x00e0ng], [qty] AS [Lượng tem], rtprice AS [Gi\x00e1 b\x00e1n lẻ] FROM ", base.Tag.ToString(), " where user_id = ", Class7.GetUserRight(), " ORDER BY timeinput" });
            using (this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_1))
            {
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.Grd_Labels.DataSource = set.Tables[0];
                    this.Labels_View.OptionsBehavior.Editable = false;
                    this.Labels_View.BestFitColumns();
                    this.Labels_View.Columns["Lượng tem"].SummaryItem.FieldName = "Lượng tem";
                    this.Labels_View.Columns["Lượng tem"].SummaryItem.SummaryType = SummaryItemType.Sum;
                    this.Labels_View.Columns["Lượng tem"].SummaryItem.DisplayFormat = "{0:n0}";
                    this.Labels_View.Columns["Gi\x00e1 b\x00e1n lẻ"].DisplayFormat.FormatType = FormatType.Numeric;
                    this.Labels_View.Columns["Gi\x00e1 b\x00e1n lẻ"].DisplayFormat.FormatString = "n0";
                }
            }
            this.oleDbConnection_1.Close();
        }

        private void method_2()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "delete from ", base.Tag.ToString(), " where qty <= 0 and user_id = ", Class7.GetUserRight() }), this.oleDbConnection_1);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
            }
            this.oleDbConnection_1.Close();
        }

        private void method_3(object sender, EventArgs e)
        {
            if (this.Labels_View.RowCount != 0)
            {
                this.method_4();
                Labels109 label = new Labels109();
                label.PrintingSystem.ShowMarginsWarning = false;
                label.PrintingSystem.ShowPrintStatusDialog = false;
                label.ShowPreviewDialog();
            }
        }

        private void method_4()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("delete from tblNotePrn where user_id = " + Class7.GetUserRight(), this.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_1.Close();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT * FROM ", base.Tag.ToString(), " where user_id = ", Class7.GetUserRight(), " order by timeinput" }), this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 1; i < (int.Parse(row["qty"].ToString()) + 1); i++)
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(string.Concat(new object[] { 
                        "INSERT INTO tblNotePrn([timeinput],[goods_id],[barcode],[shortname],[fullname],[grp_id],[supp_id],[rtprice],Pos_id,user_id) VALUES('", row["timeinput"], "', '", row["goods_id"], "', '", row["barcode"], "',N'", row["shortname"], "' ,N'", row["fullname"], "','", row["grp_id"], "','", row["supp_id"], "',", row["rtprice"], 
                        ",'", row["pos_id"], "',", Class7.GetUserRight(), ")"
                     }), this.oleDbConnection_1);
                    using (DataSet set2 = new DataSet())
                    {
                        adapter.Fill(set2);
                    }
                    this.oleDbConnection_1.Close();
                }
            }
        }

        private void method_5()
        {
            string str = string.Empty;
            string str2 = string.Empty;
            string str3 = string.Empty;
            string str4 = string.Empty;
            string str5 = string.Empty;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT * FROM ", base.Tag.ToString(), " where user_id = ", Class7.GetUserRight(), " order by timeinput" }), this.oleDbConnection_1);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_1.Close();
            using (StreamWriter writer = new StreamWriter(@"C:\labels.txt", false))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    str = row["goods_id"].ToString();
                    str2 = Class7.smethod_47(row["name"].ToString());
                    str3 = row["grp_id"].ToString();
                    str4 = row["supp_id"].ToString();
                    str5 = row["rtprice"].ToString();
                    for (int i = 1; i < (int.Parse(row["qty"].ToString()) + 1); i++)
                    {
                        writer.WriteLine(string.Format("{0};{1};{2};{3};{4}", new object[] { str, str2, str3, str4, str5 }));
                    }
                }
            }
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch bảng c\x00e0i kệ h\x00e0ng";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            string str3;
            if (e.KeyCode == Keys.F5)
            {
                Class7.BrowserForm1("select goods_id as 'M\x00e3 h\x00e0ng',barcode, full_name AS 'Diễn giải', piceunit AS [Đơn vị] from tblGoods where status = 1", Class7.oleDbConnection_1);
                this.Txt_GoodsId.Text = BrowseForm.strReturn;
            }
            if ((e.KeyCode != Keys.Return) || (this.Txt_GoodsId.Text == string.Empty))
            {
                return;
            }
            string str = this.Txt_GoodsId.Text.Trim();
            string str2 = Class7.smethod_14("m_plu").ToString().Trim();
            if (str == string.Empty)
            {
                return;
            }
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
                        goto Label_0215;
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
        Label_0215:
            str3 = this.Txt_GoodsId.Text.Trim();
            string str4 = null;
            string str5 = null;
            string str6 = null;
            string str7 = null;
            string str8 = null;
            string str9 = null;
            Class7.smethod_17("barcode", "tblGoods", "goods_id", str3, "", Class7.oleDbConnection_1, ref str9);
            this.Lbl_Barcode.Text = str9;
            Class7.smethod_17("full_name", "tblGoods", "goods_id", str3, "", Class7.oleDbConnection_1, ref str5);
            this.Lbl_FullName.Text = str5;
            Class7.smethod_17("short_name", "tblGoods", "goods_id", str3, "", Class7.oleDbConnection_1, ref str4);
            this.Lbl_ShortName.Text = str4;
            Class7.smethod_17("grp_id", "tblGoods", "goods_id", str3, "", Class7.oleDbConnection_1, ref str6);
            this.Lbl_GrpId.Text = str6;
            Class7.smethod_17("supp_id", "tblGoods", "goods_id", str3, "", Class7.oleDbConnection_1, ref str7);
            this.Lbl_SuppId.Text = str7;
            Class7.smethod_17("rtprice", "tblPrice", "goods_id", str3, "", Class7.oleDbConnection_1, ref str8);
            this.Lbl_Rtprice.Text = string.Format("{0:n0}", Class7.smethod_0(str8));
        }

        private void Txt_PosId_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("fullname", "tblStore", "id", this.Txt_PosId.Text, "", Class7.oleDbConnection_1, ref str);
            this.Lbl_PosName.Text = str;
        }


    }
}