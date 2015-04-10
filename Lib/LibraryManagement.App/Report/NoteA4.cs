using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;

namespace LibraryManagement.App
{
    public class NoteA4 : XtraReport
    {
        private BottomMarginBand bottomMarginBand_0;
        private DetailBand detailBand_0;
        private IContainer icontainer_0;
        private XRLine IjSwogAv6;
        private TopMarginBand topMarginBand_0;
        private XRLine xrline_0;
        private XRLine xrline_1;
        private XRLine xrline_2;
        private XRTable xrtable_0;
        private XRTableCell xrtableCell_0;
        private XRTableCell xrtableCell_1;
        private XRTableCell xrtableCell_2;
        private XRTableCell xrtableCell_3;
        private XRTableCell xrtableCell_4;
        private XRTableCell xrtableCell_5;
        private XRTableCell xrtableCell_6;
        private XRTableRow xrtableRow_0;
        private XRTableRow xrtableRow_1;
        private XRTableRow xrtableRow_2;
        private XRTableRow xrtableRow_3;

        static NoteA4()
        {
            Class15.smethod_5();
        }

        public NoteA4()
        {
            Class17.smethod_0();
            this.icontainer_0 = null;
            this.iWyIskLbe();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void iWyIskLbe()
        {
            this.detailBand_0 = new DetailBand();
            this.xrtable_0 = new XRTable();
            this.xrtableRow_2 = new XRTableRow();
            this.xrtableCell_2 = new XRTableCell();
            this.xrtableRow_3 = new XRTableRow();
            this.xrtableCell_3 = new XRTableCell();
            this.xrtableCell_4 = new XRTableCell();
            this.xrtableRow_0 = new XRTableRow();
            this.xrtableCell_5 = new XRTableCell();
            this.xrtableCell_0 = new XRTableCell();
            this.xrtableRow_1 = new XRTableRow();
            this.xrtableCell_6 = new XRTableCell();
            this.xrtableCell_1 = new XRTableCell();
            this.bottomMarginBand_0 = new BottomMarginBand();
            this.topMarginBand_0 = new TopMarginBand();
            this.xrline_0 = new XRLine();
            this.xrline_1 = new XRLine();
            this.IjSwogAv6 = new XRLine();
            this.xrline_2 = new XRLine();
            this.xrtable_0.BeginInit();
            this.BeginInit();
            this.detailBand_0.Controls.AddRange(new XRControl[] { this.xrtable_0, this.xrline_0, this.xrline_1, this.IjSwogAv6, this.xrline_2 });
            this.detailBand_0.Dpi = 254f;
            this.detailBand_0.Height = 0x164;
            this.detailBand_0.MultiColumn.ColumnCount = 2;
            this.detailBand_0.MultiColumn.ColumnSpacing = 26f;
            this.detailBand_0.MultiColumn.ColumnWidth = 360f;
            this.detailBand_0.MultiColumn.Direction = ColumnDirection.AcrossThenDown;
            this.detailBand_0.MultiColumn.Mode = MultiColumnMode.UseColumnCount;
            this.detailBand_0.Name = "Detail";
            this.detailBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
            this.detailBand_0.RepeatCountOnEmptyDataSource = 40;
            this.detailBand_0.StylePriority.UseBorderWidth = false;
            this.detailBand_0.StylePriority.UseFont = false;
            this.detailBand_0.TextAlignment = TextAlignment.TopLeft;
            this.xrtable_0.Dpi = 254f;
            this.xrtable_0.Location = new Point(15, 12);
            this.xrtable_0.Name = "xrTable1";
            this.xrtable_0.Rows.AddRange(new XRTableRow[] { this.xrtableRow_2, this.xrtableRow_3, this.xrtableRow_0, this.xrtableRow_1 });
            this.xrtable_0.Size = new Size(0x396, 0x14b);
            this.xrtableRow_2.Cells.AddRange(new XRTableCell[] { this.xrtableCell_2 });
            this.xrtableRow_2.Dpi = 254f;
            this.xrtableRow_2.Name = "xrTableRow4";
            this.xrtableRow_2.Weight = 1.0;
            this.xrtableCell_2.Dpi = 254f;
            this.xrtableCell_2.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_2.Name = "Txt_Title";
            this.xrtableCell_2.StylePriority.UseFont = false;
            this.xrtableCell_2.StylePriority.UseTextAlignment = false;
            this.xrtableCell_2.Text = "Txt_Title";
            this.xrtableCell_2.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_2.Weight = 1.8070866141732305;
            this.xrtableRow_3.Cells.AddRange(new XRTableCell[] { this.xrtableCell_3, this.xrtableCell_4 });
            this.xrtableRow_3.Dpi = 254f;
            this.xrtableRow_3.Name = "xrTableRow3";
            this.xrtableRow_3.Weight = 1.0;
            this.xrtableCell_3.Dpi = 254f;
            this.xrtableCell_3.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_3.Name = "xrTableCell4";
            this.xrtableCell_3.Padding = new PaddingInfo(5, 0, 0, 0, 254f);
            this.xrtableCell_3.StylePriority.UseFont = false;
            this.xrtableCell_3.StylePriority.UsePadding = false;
            this.xrtableCell_3.StylePriority.UseTextAlignment = false;
            this.xrtableCell_3.Text = "M\x00c3 H\x00c0NG :";
            this.xrtableCell_3.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_3.Weight = 0.61417322834645738;
            this.xrtableCell_4.Dpi = 254f;
            this.xrtableCell_4.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_4.Name = "Txt_GoodsId";
            this.xrtableCell_4.StylePriority.UseFont = false;
            this.xrtableCell_4.StylePriority.UseTextAlignment = false;
            this.xrtableCell_4.Text = "Txt_GoodsId";
            this.xrtableCell_4.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_4.Weight = 1.1929133858267731;
            this.xrtableRow_0.Cells.AddRange(new XRTableCell[] { this.xrtableCell_5, this.xrtableCell_0 });
            this.xrtableRow_0.Dpi = 254f;
            this.xrtableRow_0.Name = "xrTableRow1";
            this.xrtableRow_0.Weight = 1.0;
            this.xrtableCell_5.Dpi = 254f;
            this.xrtableCell_5.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_5.Name = "xrTableCell5";
            this.xrtableCell_5.StylePriority.UseFont = false;
            this.xrtableCell_5.StylePriority.UseTextAlignment = false;
            this.xrtableCell_5.Text = "T\x00caN :";
            this.xrtableCell_5.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_5.Weight = 0.30118110236220508;
            this.xrtableCell_0.Dpi = 254f;
            this.xrtableCell_0.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_0.Name = "Txt_MercName";
            this.xrtableCell_0.Padding = new PaddingInfo(3, 0, 0, 0, 254f);
            this.xrtableCell_0.StylePriority.UseFont = false;
            this.xrtableCell_0.StylePriority.UsePadding = false;
            this.xrtableCell_0.StylePriority.UseTextAlignment = false;
            this.xrtableCell_0.Text = "Txt_MercName";
            this.xrtableCell_0.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_0.Weight = 1.5059055118110254;
            this.xrtableCell_0.WordWrap = false;
            this.xrtableRow_1.Cells.AddRange(new XRTableCell[] { this.xrtableCell_6, this.xrtableCell_1 });
            this.xrtableRow_1.Dpi = 254f;
            this.xrtableRow_1.Name = "xrTableRow2";
            this.xrtableRow_1.Weight = 1.0;
            this.xrtableCell_6.Dpi = 254f;
            this.xrtableCell_6.Font = new Font("Times New Roman", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_6.Name = "xrTableCell6";
            this.xrtableCell_6.StylePriority.UseFont = false;
            this.xrtableCell_6.StylePriority.UseTextAlignment = false;
            this.xrtableCell_6.Text = "GI\x00c1 B\x00c1N :";
            this.xrtableCell_6.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_6.Weight = 0.61417322834645738;
            this.xrtableCell_1.Dpi = 254f;
            this.xrtableCell_1.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_1.Name = "Txt_Price";
            this.xrtableCell_1.Padding = new PaddingInfo(0, 7, 0, 0, 254f);
            this.xrtableCell_1.StylePriority.UseFont = false;
            this.xrtableCell_1.StylePriority.UsePadding = false;
            this.xrtableCell_1.StylePriority.UseTextAlignment = false;
            this.xrtableCell_1.Text = "Txt_Price";
            this.xrtableCell_1.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_1.Weight = 1.1929133858267731;
            this.xrtableCell_1.WordWrap = false;
            this.bottomMarginBand_0.Dpi = 254f;
            this.bottomMarginBand_0.Height = 0x33;
            this.bottomMarginBand_0.Name = "BottomMargin";
            this.topMarginBand_0.Dpi = 254f;
            this.topMarginBand_0.Height = 0x33;
            this.topMarginBand_0.Name = "TopMargin";
            this.xrline_0.Dpi = 254f;
            this.xrline_0.LineDirection = LineDirection.Vertical;
            this.xrline_0.Location = new Point(0x3b7, 4);
            this.xrline_0.Name = "xrLine1";
            this.xrline_0.Size = new Size(8, 0x15d);
            this.xrline_1.Dpi = 254f;
            this.xrline_1.Location = new Point(8, 0);
            this.xrline_1.Name = "xrLine2";
            this.xrline_1.Size = new Size(0x3b2, 12);
            this.IjSwogAv6.Dpi = 254f;
            this.IjSwogAv6.Location = new Point(8, 0x158);
            this.IjSwogAv6.Name = "xrLine3";
            this.IjSwogAv6.Size = new Size(0x3b2, 12);
            this.xrline_2.Dpi = 254f;
            this.xrline_2.LineDirection = LineDirection.Vertical;
            this.xrline_2.Location = new Point(3, 4);
            this.xrline_2.Name = "xrLine4";
            this.xrline_2.Size = new Size(8, 0x15d);
            base.Bands.AddRange(new Band[] { this.detailBand_0, this.bottomMarginBand_0, this.topMarginBand_0 });
            this.Dpi = 254f;
            base.GridSize = new Size(7, 7);
            base.Margins = new Margins(30, 30, 0x33, 0x33);
            base.PageHeight = 0xb99;
            base.PageWidth = 0x835;
            base.PaperKind = PaperKind.A4;
            base.PaperName = "TJ108";
            base.ReportUnit = ReportUnit.TenthsOfAMillimeter;
            base.ShowPrintingWarnings = false;
            base.SnapToGrid = false;
            base.Version = "9.1";
            this.BeforePrint += new PrintEventHandler(this.NoteA4_BeforePrint);
            this.xrtable_0.EndInit();
            this.EndInit();
        }

        private void NoteA4_BeforePrint(object sender, PrintEventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Pos_id ,goods_id,barcode,shortname,fullname,grp_id,supp_id,rtprice,remark ,user_id ,timeinput FROM tblNotePrn where user_id = " + Class7.GetUserId() + " Order By timeinput ", Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            base.DataAdapter = adapter;
            base.DataSource = dataSet.Tables[0];
            this.xrtableCell_1.DataBindings.Add("Text", base.DataSource, "rtprice", "{0:n0}");
            if (FrmNoteLabelPrn._notebarcode)
            {
                this.xrtableCell_4.DataBindings.Add("Text", base.DataSource, "barcode", "");
            }
            else
            {
                this.xrtableCell_4.DataBindings.Add("Text", base.DataSource, "goods_id", "");
            }
            this.xrtableCell_0.DataBindings.Add("Text", base.DataSource, "fullname", "");
            this.xrtableCell_2.Text = Class7.smethod_14("m_labeltitle").ToString();
        }
    }
}
