using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmKitList : XtraForm
    {
        public FrmKitList()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.printableComponentLink_0.Landscape = false;
            this.printableComponentLink_0.Margins.Left = 50;
            this.printableComponentLink_0.Margins.Right = 50;
            this.printableComponentLink_0.Margins.Bottom = 80;
            this.printableComponentLink_0.Margins.Top = 80;
            this.printableComponentLink_0.CreateDocument();
            this.printableComponentLink_0.ShowPreview();
        }

        private void FrmKitList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.P))
            {
                this.btnPrint_Click(this, new EventArgs());
            }
        }

        private void FrmKitList_Load(object sender, EventArgs e)
        {
            this.Text = "Danh s\x00e1ch g\x00f3i, b\x00f3 h\x00e0ng h\x00f3a";
            this.method_0();
            this.iWyIskLbe();
        }

        private void IjSwogAv6_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.string_1 = this.IjSwogAv6.GetRowCellValue(this.IjSwogAv6.FocusedRowHandle, "M\x00e3 số").ToString();
                this.iWyIskLbe();
            }
            catch (Exception)
            {
            }
        }



        private void iWyIskLbe()
        {
            this.string_0 = "SELECT  tblKit_info.goods_id AS [M\x00e3 h\x00e0ng], tblGoods.full_name AS [T\x00ean h\x00e0ng h\x00f3a], tblGoods.piceunit AS [Đơn vị], tblKit_info.qty AS [SL] FROM  ((tblKit INNER JOIN tblKit_info ON tblKit.id = tblKit_info.kit_id) INNER JOIN tblGoods ON tblKit_info.goods_id = tblGoods.goods_id) WHERE tblKit.id = '" + this.string_1 + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
            this.gridView1.Columns["SL"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["SL"].DisplayFormat.FormatString = "{0:n0}";
            this.gridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.FieldName = "M\x00e3 h\x00e0ng";
            this.gridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.SummaryType = SummaryItemType.Count;
            this.gridView1.Columns["M\x00e3 h\x00e0ng"].SummaryItem.DisplayFormat = "Tổng số :{0:n0}";
            this.gridView1.BestFitColumns();
        }

        private void method_0()
        {
            this.string_0 = "SELECT  id AS [M\x00e3 số], description AS [Diễn giải], unitsymb AS [Đơn vị], rtprice AS [Gi\x00e1 b\x00e1n], open_date AS [Ng\x00e0y tạo], status AS [Hiệu lực] FROM  tblKit ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl2.DataSource = set.Tables[0];
            }
            this.IjSwogAv6.Columns["Gi\x00e1 b\x00e1n"].DisplayFormat.FormatType = FormatType.Numeric;
            this.IjSwogAv6.Columns["Gi\x00e1 b\x00e1n"].DisplayFormat.FormatString = "{0:n0}";
            this.IjSwogAv6.Columns["Ng\x00e0y tạo"].DisplayFormat.FormatType = FormatType.DateTime;
            this.IjSwogAv6.Columns["Ng\x00e0y tạo"].DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.IjSwogAv6.Columns["M\x00e3 số"].SummaryItem.FieldName = "M\x00e3 số";
            this.IjSwogAv6.Columns["M\x00e3 số"].SummaryItem.SummaryType = SummaryItemType.Count;
            this.IjSwogAv6.Columns["M\x00e3 số"].SummaryItem.DisplayFormat = "Tổng số :{0:n0}";
            this.IjSwogAv6.BestFitColumns();
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = this.Text;
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, BorderSide.None);
        }

        private void printingSystem_0_EndPrint(object sender, EventArgs e)
        {
            this.printingSystem_0.PreviewFormEx.Close();
        }
    }
}