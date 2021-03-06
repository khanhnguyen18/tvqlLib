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
    public partial class FrmKitLabelPrn : XtraForm
    {
        public FrmKitLabelPrn()
        {
            InitializeComponent();
        }



        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!((Class7.ParseDoubleValue(this.Txt_Qty.Text) <= 0.0) | (this.Lbl_FullName.Text == string.Empty)))
            {
                this.Txt_PosId.Text.Trim();
                string str = this.Txt_GoodsId.Text.Trim();
                string str2 = this.Lbl_FullName.Text.Trim();
                string text = this.Lbl_Rtprice.Text;
                string str4 = DateTime.Now.ToString("HH:mm:ss");
                double num = Class7.ParseDoubleValue(this.Txt_Qty.Text);
                this.string_0 = string.Concat(new object[] { 
                    "IF NOT EXISTS(select kit_id from ", base.Tag.ToString(), " where kit_id = '", str, "' and user_id = ", Class7.GetUserId(), ") INSERT INTO ", base.Tag.ToString(), "([timeinput],[kit_id],[description],[rtprice],[copies],user_id) VALUES('", str4, "','", str, "',N'", str2, "','", text, 
                    "',", num, ", ", Class7.GetUserId(), ") Else UPDATE ", base.Tag.ToString(), " SET copies = copies + ", num, ",timeinput = '", str4, "' where kit_id = '", str, "' and user_id = ", Class7.GetUserId()
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
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
            if ((this.Labels_View.RowCount != 0) && (Class7.ParseDoubleValue(this.Txt_Qty.Text) > 0.0))
            {
                double num = Class7.ParseDoubleValue(this.Txt_Qty.Text);
                string str = this.Txt_GoodsId.Text.Trim();
                string str2 = DateTime.Now.ToString("HH:mm:ss");
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "update ", base.Tag.ToString(), " set copies = copies - ", num, ", timeinput = '", str2, "' where kit_id = '", str, "' and user_id = ", Class7.GetUserId() }), this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
                this.method_2();
                this.method_1();
            }
        }

        private void btn_Print108_Click(object sender, EventArgs e)
        {
            if (this.Labels_View.RowCount != 0)
            {
                this.method_4();
                KitLabelsA4 a4= new KitLabelsA4();
                a4.PrintingSystem.ShowMarginsWarning = false;
                a4.PrintingSystem.ShowPrintStatusDialog = false;
                a4.ShowPreviewDialog();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if ((this.Labels_View.RowCount != 0) && (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a hết lượng tem đ\x00e3 đặt in kh\x00f4ng", 2) == 1))
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "DELETE FROM ", base.Tag.ToString(), " where user_id = ", Class7.GetUserId() }), this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
                this.method_1();
            }
        }


        private void FrmKitLabelPrn_Activated(object sender, EventArgs e)
        {
        }

        private void FrmKitLabelPrn_Load(object sender, EventArgs e)
        {
            this.Text = " In tem g\x00f3i b\x00f3 h\x00e0ng h\x00f3a";
            base.Tag = "tblKitLabel";
            this.Txt_PosId.Text = "00001";
            this.Txt_PosId.Enabled = false;
            this.method_1();
            this.Txt_GoodsId.Focus();
        }

        private void Grd_Labels_Click(object sender, EventArgs e)
        {
            this.Txt_GoodsId.Text = this.Labels_View.GetRowCellValue(this.Labels_View.FocusedRowHandle, this.Labels_View.Columns["M\x00e3 số"]).ToString();
        }



        private void method_0()
        {
            this.string_0 = string.Concat(new object[] { "select kit_id from ", base.Tag.ToString(), " where user_id = ", Class7.GetUserId(), " Order by timeinput" });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_0.Close();
            int num = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                this.string_0 = string.Concat(new object[] { " UPDATE ", base.Tag.ToString(), " set idx = ", num, " where kit_id = '", row["kit_id"], "' and user_id = ", Class7.GetUserId() });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    num++;
                }
                this.oleDbConnection_0.Close();
            }
        }

        private void method_1()
        {
            this.string_0 = string.Concat(new object[] { "SELECT [idx] AS [TT],[kit_id] AS [M\x00e3 số] ,[description] AS [T\x00ean h\x00e0ng], [copies] AS [Lượng tem], rtprice AS [Gi\x00e1 b\x00e1n lẻ] FROM ", base.Tag.ToString(), " where user_id = ", Class7.GetUserId(), " ORDER BY timeinput" });
            using (this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0))
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
            this.oleDbConnection_0.Close();
        }

        private void method_2()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "delete from ", base.Tag.ToString(), " where copies <= 0 and user_id = ", Class7.GetUserId() }), this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
            }
            this.oleDbConnection_0.Close();
        }

        private void method_3(object sender, EventArgs e)
        {
            if (this.Labels_View.RowCount != 0)
            {
                this.method_4();
            }
        }

        private void method_4()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("delete from tblKitLabelPrn where user_id = " + Class7.GetUserId(), this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT * FROM ", base.Tag.ToString(), " where user_id = ", Class7.GetUserId(), " order by timeinput" }), this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_0.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                for (int i = 1; i < (int.Parse(row["copies"].ToString()) + 1); i++)
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(string.Concat(new object[] { "INSERT INTO tblKitLabelPrn([timeinput],[kit_id],[description],[rtprice],user_id) VALUES('", row["timeinput"], "', '", row["kit_id"], "',N'", row["description"], "','", row["rtprice"], "',", Class7.GetUserId(), ")" }), this.oleDbConnection_0);
                    using (DataSet set2 = new DataSet())
                    {
                        adapter.Fill(set2);
                    }
                    this.oleDbConnection_0.Close();
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
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(string.Concat(new object[] { "SELECT * FROM ", base.Tag.ToString(), " where user_id = ", Class7.GetUserId(), " order by timeinput" }), this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            this.oleDbDataAdapter_0.Fill(dataTable);
            this.oleDbConnection_0.Close();
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
            string text = "Danh s\x00e1ch tem b\x00f3 g\x00f3i h\x00e0ng";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_GoodsId.Text == string.Empty))
            {
                string str = this.Txt_GoodsId.Text.Trim();
                string str2 = null;
                string str3 = null;
                Class7.smethod_17("description", "tblKit", "id", str, "", Class7.oleDbConnection_1, ref str2);
                this.Lbl_FullName.Text = str2;
                Class7.smethod_17("rtprice", "tblKit", "id", str, "", Class7.oleDbConnection_1, ref str3);
                this.Lbl_Rtprice.Text = string.Format("{0:n0}", Class7.ParseDoubleValue(str3));
            }
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("select id as 'M\x00e3 số', description AS 'M\x00f4 tả', rtprice AS [Gi\x00e1 b\x00e1n] from tblKit where status = 1", Class7.oleDbConnection_1);
                this.Txt_GoodsId.Text = BrowseForm.strReturn;
            }
        }

        private void Txt_PosId_EditValueChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("fullname", "tblStore", "id", this.Txt_PosId.Text, "", Class7.oleDbConnection_1, ref str);
            this.Lbl_PosName.Text = str;
        }
   
    }
}