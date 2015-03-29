using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.Utils;
using System.Data.OleDb;
using DevExpress.Data;

namespace LibraryManagement.App
{
    public partial class FrmFastSlow : DevExpress.XtraEditors.XtraForm
    {
        private string string_0;
        public FrmFastSlow()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.printableComponentLink_0.Landscape = true;
            this.printableComponentLink_0.Margins.Left = 20;
            this.printableComponentLink_0.Margins.Right = 20;
            this.printableComponentLink_0.Margins.Bottom = 40;
            this.printableComponentLink_0.Margins.Top = 40;
            this.printableComponentLink_0.CreateDocument();
            this.printableComponentLink_0.ShowPreview();
        }

        private void FrmFastSlow_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmFastSlow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.P))
            {
                this.btnPrint_Click(this, new EventArgs());
            }
        }

        private void FrmFastSlow_Load(object sender, EventArgs e)
        {
            this.Text = "Đ\x00e1nh gi\x00e1 h\x00e0ng b\x00e1n chạy/chậm";
            this.string_0 = string.Concat(new object[] { "SELECT DISTINCT tr.goods_id AS [M\x00e3 h\x00e0ng], gs.supp_id AS NCC, gs.grp_id AS Nh\x00f3m, gs.full_name AS [T\x00ean h\x00e0ng], gs.piceunit AS [Đơn vị], SUM(tr.amount + tr.surplus)/ SUM(tr.qty) AS [Gi\x00e1 b\x00e1n TB], SUM(tr.qty) AS [Doanh số], SUM(tr.amount + tr.surplus) AS [Doanh thu], SUM(tr.surplus) AS [L\x00e3i gộp]  FROM         tblTransaction AS tr INNER JOIN  tblGoods AS gs ON tr.goods_id = gs.goods_id INNER JOIN  tblPrice AS pr ON tr.goods_id = pr.goods_id  WHERE tr.trans_code = '00' AND tr.Status = 1   AND (tr.tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "')  GROUP BY tr.goods_id,gs.grp_id, gs.supp_id, gs.full_name, gs.piceunit  ORDER BY SUM(tr.qty) DESC " });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
            this.gridView1.BestFitColumns();
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Columns["Gi\x00e1 b\x00e1n TB"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Gi\x00e1 b\x00e1n TB"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["Doanh số"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Doanh số"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["Doanh thu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Doanh thu"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["L\x00e3i gộp"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["L\x00e3i gộp"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["Doanh thu"].SummaryItem.FieldName = "Doanh thu";
            this.gridView1.Columns["Doanh thu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["Doanh thu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["L\x00e3i gộp"].SummaryItem.FieldName = "L\x00e3i gộp";
            this.gridView1.Columns["L\x00e3i gộp"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["L\x00e3i gộp"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["Doanh số"].AppearanceCell.BackColor = Color.Yellow;
            this.Lbl_duaration.Text = "Từ ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTime_0) + " đến ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTime_1);
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "B\x00e1n lẻ chạy/chậm " + this.Lbl_duaration.Text;
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, BorderSide.None);
        }
    }
}