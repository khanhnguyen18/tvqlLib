using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;

namespace LibraryManagement.App
{
    public class KitLabelsA4 : XtraReport
    {
        private BottomMarginBand bottomMarginBand_0;
        private DetailBand detailBand_0;
        private IContainer icontainer_0;
        private TopMarginBand topMarginBand_0;
        private XRBarCode xrbarCode_0;
        private XRLabel xrlabel_0;
        private XRTable xrtable_0;
        private XRTableCell xrtableCell_0;
        private XRTableCell xrtableCell_1;
        private XRTableRow xrtableRow_0;
        private XRTableRow xrtableRow_1;

        static KitLabelsA4()
        {
            Class15.smethod_5();
        }

        public KitLabelsA4()
        {
            Class17.smethod_0();
            this.icontainer_0 = null;
            this.method_0();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void KitLabelsA4_BeforePrint(object sender, PrintEventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT [kit_id],[description],[rtprice],[user_id],[timeinput]  FROM [tblKitLabelPrn] where user_id = " + Class7.GetUserId() + " Order By timeinput ", Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            base.DataAdapter = adapter;
            base.DataSource = dataSet.Tables[0];
            this.xrtableCell_1.DataBindings.Add("Text", base.DataSource, "rtprice", "{0:n0}");
            this.xrbarCode_0.DataBindings.Add("Text", base.DataSource, "kit_id", "");
            this.xrtableCell_0.DataBindings.Add("Text", base.DataSource, "description", "");
            this.xrlabel_0.Text = Class7.smethod_14("m_labeltitle").ToString();
        }

        private void method_0()
        {
            Code128Generator generator = new Code128Generator();
            this.detailBand_0 = new DetailBand();
            this.xrlabel_0 = new XRLabel();
            this.xrbarCode_0 = new XRBarCode();
            this.xrtable_0 = new XRTable();
            this.xrtableRow_0 = new XRTableRow();
            this.xrtableCell_0 = new XRTableCell();
            this.xrtableRow_1 = new XRTableRow();
            this.xrtableCell_1 = new XRTableCell();
            this.bottomMarginBand_0 = new BottomMarginBand();
            this.topMarginBand_0 = new TopMarginBand();
            this.xrtable_0.BeginInit();
            this.BeginInit();
            this.detailBand_0.Controls.AddRange(new XRControl[] { this.xrlabel_0, this.xrbarCode_0, this.xrtable_0 });
            this.detailBand_0.Dpi = 254f;
            this.detailBand_0.Height = 160;
            this.detailBand_0.MultiColumn.ColumnCount = 6;
            this.detailBand_0.MultiColumn.ColumnSpacing = 16f;
            this.detailBand_0.MultiColumn.ColumnWidth = 360f;
            this.detailBand_0.MultiColumn.Direction = ColumnDirection.AcrossThenDown;
            this.detailBand_0.MultiColumn.Mode = MultiColumnMode.UseColumnCount;
            this.detailBand_0.Name = "Detail";
            this.detailBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
            this.detailBand_0.RepeatCountOnEmptyDataSource = 90;
            this.detailBand_0.StylePriority.UseBorderWidth = false;
            this.detailBand_0.StylePriority.UseFont = false;
            this.detailBand_0.TextAlignment = TextAlignment.TopLeft;
            this.xrlabel_0.Dpi = 254f;
            this.xrlabel_0.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrlabel_0.Location = new Point(2, 0);
            this.xrlabel_0.Name = "Lbl_Name";
            this.xrlabel_0.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
            this.xrlabel_0.Size = new Size(0x145, 0x1c);
            this.xrlabel_0.StylePriority.UseFont = false;
            this.xrlabel_0.StylePriority.UsePadding = false;
            this.xrlabel_0.StylePriority.UseTextAlignment = false;
            this.xrlabel_0.Text = "Bella";
            this.xrlabel_0.TextAlignment = TextAlignment.MiddleCenter;
            this.xrbarCode_0.Alignment = TextAlignment.MiddleCenter;
            this.xrbarCode_0.AutoModule = true;
            this.xrbarCode_0.Dpi = 254f;
            this.xrbarCode_0.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrbarCode_0.Location = new Point(0x29, 0x21);
            this.xrbarCode_0.Module = 208f;
            this.xrbarCode_0.Name = "xrBarCode1";
            this.xrbarCode_0.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
            this.xrbarCode_0.Size = new Size(0xfd, 0x4f);
            this.xrbarCode_0.StylePriority.UseBorderColor = false;
            this.xrbarCode_0.StylePriority.UseFont = false;
            this.xrbarCode_0.StylePriority.UsePadding = false;
            this.xrbarCode_0.StylePriority.UseTextAlignment = false;
            this.xrbarCode_0.Symbology = generator;
            this.xrbarCode_0.Text = "000002";
            this.xrbarCode_0.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtable_0.Dpi = 254f;
            this.xrtable_0.Location = new Point(3, 0x66);
            this.xrtable_0.Name = "xrTable1";
            this.xrtable_0.Rows.AddRange(new XRTableRow[] { this.xrtableRow_0, this.xrtableRow_1 });
            this.xrtable_0.Size = new Size(0x144, 0x34);
            this.xrtableRow_0.Cells.AddRange(new XRTableCell[] { this.xrtableCell_0 });
            this.xrtableRow_0.Dpi = 254f;
            this.xrtableRow_0.Name = "xrTableRow1";
            this.xrtableRow_0.Weight = 1.0;
            this.xrtableCell_0.Dpi = 254f;
            this.xrtableCell_0.Font = new Font("Times New Roman", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_0.Name = "Txt_MercName";
            this.xrtableCell_0.StylePriority.UseFont = false;
            this.xrtableCell_0.StylePriority.UseTextAlignment = false;
            this.xrtableCell_0.Text = "Txt_MercName";
            this.xrtableCell_0.TextAlignment = TextAlignment.BottomCenter;
            this.xrtableCell_0.Weight = 1.8070866141732305;
            this.xrtableCell_0.WordWrap = false;
            this.xrtableRow_1.Cells.AddRange(new XRTableCell[] { this.xrtableCell_1 });
            this.xrtableRow_1.Dpi = 254f;
            this.xrtableRow_1.Name = "xrTableRow2";
            this.xrtableRow_1.Weight = 1.0;
            this.xrtableCell_1.Dpi = 254f;
            this.xrtableCell_1.Font = new Font("Tahoma", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_1.Name = "Txt_Price";
            this.xrtableCell_1.Padding = new PaddingInfo(0, 7, 0, 0, 254f);
            this.xrtableCell_1.StylePriority.UseFont = false;
            this.xrtableCell_1.StylePriority.UsePadding = false;
            this.xrtableCell_1.StylePriority.UseTextAlignment = false;
            this.xrtableCell_1.Text = "Txt_Price";
            this.xrtableCell_1.TextAlignment = TextAlignment.TopRight;
            this.xrtableCell_1.Weight = 1.8070866141732305;
            this.xrtableCell_1.WordWrap = false;
            this.bottomMarginBand_0.Dpi = 254f;
            this.bottomMarginBand_0.Height = 20;
            this.bottomMarginBand_0.Name = "BottomMargin";
            this.topMarginBand_0.Dpi = 254f;
            this.topMarginBand_0.Height = 20;
            this.topMarginBand_0.Name = "TopMargin";
            base.Bands.AddRange(new Band[] { this.detailBand_0, this.bottomMarginBand_0, this.topMarginBand_0 });
            this.Dpi = 254f;
            base.GridSize = new Size(7, 7);
            base.Margins = new Margins(20, 20, 20, 20);
            base.Name = "KitLabelsA4";
            base.PageHeight = 0xb99;
            base.PageWidth = 0x835;
            base.PaperKind = PaperKind.A4;
            base.PaperName = "TJ108";
            base.ReportUnit = ReportUnit.TenthsOfAMillimeter;
            base.ShowPrintingWarnings = false;
            base.SnapToGrid = false;
            base.Version = "9.1";
            this.BeforePrint += new PrintEventHandler(this.KitLabelsA4_BeforePrint);
            this.xrtable_0.EndInit();
            this.EndInit();
        }
    }
}
