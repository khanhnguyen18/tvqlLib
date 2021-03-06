using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    public partial class FrmLibraryInfo : XtraForm
    {
        public FrmLibraryInfo()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.IjSwogAv6.Landscape = true;
            this.IjSwogAv6.Margins.Left = 20;
            this.IjSwogAv6.Margins.Right = 20;
            this.IjSwogAv6.Margins.Bottom = 40;
            this.IjSwogAv6.Margins.Top = 40;
            this.IjSwogAv6.CreateDocument();
            this.IjSwogAv6.ShowPreview();
        }


        private void FrmLibraryInfo_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmLibraryInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.P))
            {
                this.btnPrint_Click(this, new EventArgs());
            }
        }

        private void IjSwogAv6_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Chi tiết h\x00e0ng tồn tại " + this.Lbl_StockName.Text.Trim();
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }

        private void iWyIskLbe(object sender, EventArgs e)
        {
            this.Text = "Th\x00f4ng tin s\x00e1ch trong thư viện, kho";
            this.Txt_StockId.Text = "00001";
            this.method_0();
        }

        private void method_0()
        {
            WaitDialogForm form = new WaitDialogForm();
            form.Caption= "Xin chờ một ch\x00fat ....";
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT gs.goods_id AS [M\x00e3 h\x00e0ng],gs.barcode, gs.full_name AS [T\x00ean h\x00e0ng], gs.grp_id AS [Nh\x00f3m],pr.rtprice AS [Gi\x00e1 b\x00eca],stk.id ,stk.exp_qty AS [Xuất],stk.imp_qty AS [Nhập],(stk.begin_qty + stk.imp_qty) - stk.exp_qty AS [Hiện tồn], stk.imp_amt AS [Tổng nhập],stk.exp_amt AS [Tổng xuất],(stk.begin_amt + stk.imp_amt)- stk.exp_amt AS [Tổng tồn] FROM tblGoods AS gs INNER JOIN tblPrice AS pr ON gs.goods_id = pr.goods_id LEFT JOIN (select * from tblStockInfo where id = '" + this.Txt_StockId.Text.Trim() + "') AS stk ON gs.goods_id = stk.goods_id  Order by gs.goods_id ", Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            this.GrdStockInfo.DataSource = dataSet.Tables[0];
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Columns["id"].Visible = false;
            this.gridView1.BestFitColumns();
            this.gridView1.Columns["Gi\x00e1 b\x00eca"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Gi\x00e1 b\x00eca"].DisplayFormat.FormatString = "{0:n0}";
            this.gridView1.Columns["Xuất"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Xuất"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Nhập"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Nhập"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Hiện tồn"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Hiện tồn"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Tổng xuất"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Tổng xuất"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Tổng nhập"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Tổng nhập"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Tổng tồn"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Tổng tồn"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Tổng xuất"].SummaryItem.FieldName = "Tổng xuất";
            this.gridView1.Columns["Tổng xuất"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["Tổng xuất"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["Tổng nhập"].SummaryItem.FieldName = "Tổng nhập";
            this.gridView1.Columns["Tổng nhập"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["Tổng nhập"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["Tổng tồn"].SummaryItem.FieldName = "Tổng tồn";
            this.gridView1.Columns["Tổng tồn"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["Tổng tồn"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.FieldName = "M\x00e3 h\x00e0ng";
            this.gridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.SummaryType = SummaryItemType.Count;
            this.gridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.DisplayFormat = "{0:n0}";
            this.gridView1.Columns["M\x00e3 h\x00e0ng"].Fixed = FixedStyle.Left;
            form.Close();
        }

        private void Txt_StockId_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_StockId.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_StockId.Text, "and type IN('01','02') and status = 1", Class7.oleDbConnection_1, ref str);
                this.Lbl_StockName.Text = str;
                this.method_0();
            }
        }

        private void Txt_StockId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean kho h\x00e0ng', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('01','02') and status = 1";
                Class7.BrowserForm1(str, Class7.oleDbConnection_1);
                this.Txt_StockId.Text = BrowseForm.strReturn;
                this.Txt_StockId.SelectAll();
            }
        }
    }
}