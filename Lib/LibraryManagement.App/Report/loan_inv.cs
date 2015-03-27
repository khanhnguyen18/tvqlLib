﻿namespace LibraryManagement.App
{
    using DevExpress.Utils;
    using DevExpress.XtraPrinting;
    using DevExpress.XtraReports.UI;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Drawing.Printing;

    public class loan_inv : XtraReport
    {
        private DataColumn AhxsdynSH;
        private BottomMarginBand bottomMarginBand_0;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private DataColumn dataColumn_9;
        public DataSet dataSet1;
        private DataTable dataTable_0;
        private DetailBand detailBand_0;
        private IContainer icontainer_0;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PageHeaderBand pageHeaderBand_0;
        private ReportFooterBand reportFooterBand_0;
        private ReportHeaderBand reportHeaderBand_0;
        private string string_0;
        private TopMarginBand topMarginBand_0;
        private XRLabel xrlabel_0;
        private XRLabel xrlabel_1;
        private XRLabel xrlabel_10;
        private XRLabel xrlabel_11;
        private XRLabel xrlabel_12;
        private XRLabel xrlabel_13;
        private XRLabel xrlabel_14;
        private XRLabel xrlabel_15;
        private XRLabel xrlabel_16;
        private XRLabel xrlabel_2;
        private XRLabel xrlabel_3;
        private XRLabel xrlabel_4;
        private XRLabel xrlabel_5;
        private XRLabel xrlabel_6;
        private XRLabel xrlabel_7;
        private XRLabel xrlabel_8;
        private XRLabel xrlabel_9;
        private XRTable xrtable_0;
        private XRTable xrtable_1;
        private XRTable xrtable_2;
        private XRTableCell xrtableCell_0;
        private XRTableCell xrtableCell_1;
        private XRTableCell xrtableCell_10;
        private XRTableCell xrtableCell_11;
        private XRTableCell xrtableCell_12;
        private XRTableCell xrtableCell_13;
        private XRTableCell xrtableCell_14;
        private XRTableCell xrtableCell_15;
        private XRTableCell xrtableCell_2;
        private XRTableCell xrtableCell_3;
        private XRTableCell xrtableCell_4;
        private XRTableCell xrtableCell_5;
        private XRTableCell xrtableCell_6;
        private XRTableCell xrtableCell_7;
        private XRTableCell xrtableCell_8;
        private XRTableCell xrtableCell_9;
        private XRTableRow xrtableRow_0;
        private XRTableRow xrtableRow_1;
        private XRTableRow xrtableRow_2;
        private XRTableRow xrtableRow_3;
        private XRTableRow xrtableRow_4;

        static loan_inv()
        {
            Class15.smethod_5();
        }

        public loan_inv()
        {
            Class17.smethod_0();
            this.oleDbConnection_0 = new OleDbConnection(Class7.string_5);
            this.string_0 = null;
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

        private void method_0()
        {
            XRSummary summary = new XRSummary();
            this.detailBand_0 = new DetailBand();
            this.xrtable_1 = new XRTable();
            this.xrtableRow_2 = new XRTableRow();
            this.xrtableCell_5 = new XRTableCell();
            this.xrtableCell_6 = new XRTableCell();
            this.xrtableCell_7 = new XRTableCell();
            this.xrtableCell_8 = new XRTableCell();
            this.topMarginBand_0 = new TopMarginBand();
            this.bottomMarginBand_0 = new BottomMarginBand();
            this.pageHeaderBand_0 = new PageHeaderBand();
            this.xrtable_2 = new XRTable();
            this.xrtableRow_3 = new XRTableRow();
            this.xrtableCell_9 = new XRTableCell();
            this.xrtableCell_10 = new XRTableCell();
            this.xrtableCell_11 = new XRTableCell();
            this.xrtableCell_12 = new XRTableCell();
            this.reportHeaderBand_0 = new ReportHeaderBand();
            this.xrtable_0 = new XRTable();
            this.xrtableRow_0 = new XRTableRow();
            this.xrtableCell_0 = new XRTableCell();
            this.xrtableCell_1 = new XRTableCell();
            this.xrtableCell_2 = new XRTableCell();
            this.xrtableCell_13 = new XRTableCell();
            this.xrtableRow_1 = new XRTableRow();
            this.xrtableCell_3 = new XRTableCell();
            this.xrtableCell_4 = new XRTableCell();
            this.xrtableRow_4 = new XRTableRow();
            this.xrtableCell_14 = new XRTableCell();
            this.xrtableCell_15 = new XRTableCell();
            this.xrlabel_8 = new XRLabel();
            this.xrlabel_9 = new XRLabel();
            this.xrlabel_10 = new XRLabel();
            this.xrlabel_0 = new XRLabel();
            this.xrlabel_1 = new XRLabel();
            this.xrlabel_2 = new XRLabel();
            this.xrlabel_3 = new XRLabel();
            this.xrlabel_4 = new XRLabel();
            this.xrlabel_5 = new XRLabel();
            this.xrlabel_6 = new XRLabel();
            this.xrlabel_7 = new XRLabel();
            this.reportFooterBand_0 = new ReportFooterBand();
            this.xrlabel_11 = new XRLabel();
            this.xrlabel_12 = new XRLabel();
            this.xrlabel_13 = new XRLabel();
            this.xrlabel_14 = new XRLabel();
            this.xrlabel_15 = new XRLabel();
            this.xrlabel_16 = new XRLabel();
            this.dataSet1 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.AhxsdynSH = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.dataColumn_6 = new DataColumn();
            this.dataColumn_7 = new DataColumn();
            this.dataColumn_8 = new DataColumn();
            this.dataColumn_9 = new DataColumn();
            this.xrtable_1.BeginInit();
            this.xrtable_2.BeginInit();
            this.xrtable_0.BeginInit();
            this.dataSet1.BeginInit();
            this.dataTable_0.BeginInit();
            this.BeginInit();
            this.detailBand_0.Controls.AddRange(new XRControl[] { this.xrtable_1 });
            this.detailBand_0.HeightF = 25f;
            this.detailBand_0.Name = "Detail";
            this.detailBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.detailBand_0.TextAlignment = TextAlignment.TopLeft;
            this.xrtable_1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtable_1.LocationFloat = new PointFloat(0f, 0f);
            this.xrtable_1.Name = "xrTable3";
            this.xrtable_1.Padding = new PaddingInfo(3, 0, 0, 0, 100f);
            this.xrtable_1.Rows.AddRange(new XRTableRow[] { this.xrtableRow_2 });
            this.xrtable_1.SizeF = new SizeF(789.9999f, 25f);
            this.xrtable_1.StylePriority.UseFont = false;
            this.xrtable_1.StylePriority.UsePadding = false;
            this.xrtable_1.StylePriority.UseTextAlignment = false;
            this.xrtable_1.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableRow_2.Cells.AddRange(new XRTableCell[] { this.xrtableCell_5, this.xrtableCell_6, this.xrtableCell_7, this.xrtableCell_8 });
            this.xrtableRow_2.Name = "xrTableRow5";
            this.xrtableRow_2.Weight = 1.0;
            this.xrtableCell_5.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_5.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.idx") });
            this.xrtableCell_5.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_5.Name = "xrTableCell12";
            this.xrtableCell_5.Padding = new PaddingInfo(3, 3, 0, 0, 100f);
            this.xrtableCell_5.StylePriority.UseBorders = false;
            this.xrtableCell_5.StylePriority.UseFont = false;
            this.xrtableCell_5.StylePriority.UsePadding = false;
            this.xrtableCell_5.StylePriority.UseTextAlignment = false;
            summary.FormatString = "{0:n0}";
            summary.Func = SummaryFunc.RecordNumber;
            this.xrtableCell_5.Summary = summary;
            this.xrtableCell_5.Text = "xrTableCell12";
            this.xrtableCell_5.TextAlignment = TextAlignment.MiddleRight;
            this.xrtableCell_5.Weight = 0.16139237407383975;
            this.xrtableCell_5.WordWrap = false;
            this.xrtableCell_6.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_6.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.goods_id") });
            this.xrtableCell_6.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_6.Name = "xrTableCell14";
            this.xrtableCell_6.StylePriority.UseBorders = false;
            this.xrtableCell_6.StylePriority.UseFont = false;
            this.xrtableCell_6.StylePriority.UseTextAlignment = false;
            this.xrtableCell_6.Text = "xrTableCell14";
            this.xrtableCell_6.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_6.Weight = 0.32753177227796881;
            this.xrtableCell_6.WordWrap = false;
            this.xrtableCell_7.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_7.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.full_name") });
            this.xrtableCell_7.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_7.Name = "xrTableCell15";
            this.xrtableCell_7.StylePriority.UseBorders = false;
            this.xrtableCell_7.StylePriority.UseFont = false;
            this.xrtableCell_7.StylePriority.UseTextAlignment = false;
            this.xrtableCell_7.Text = "xrTableCell15";
            this.xrtableCell_7.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_7.Weight = 1.8917724912057219;
            this.xrtableCell_7.WordWrap = false;
            this.xrtableCell_8.Borders = BorderSide.Bottom | BorderSide.Right | BorderSide.Left;
            this.xrtableCell_8.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.due_date", "{0:dd/MM/yyyy}") });
            this.xrtableCell_8.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtableCell_8.Name = "xrTableCell16";
            this.xrtableCell_8.StylePriority.UseBorders = false;
            this.xrtableCell_8.StylePriority.UseFont = false;
            this.xrtableCell_8.StylePriority.UseTextAlignment = false;
            this.xrtableCell_8.Text = "xrTableCell16";
            this.xrtableCell_8.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_8.Weight = 0.6193033624424702;
            this.xrtableCell_8.WordWrap = false;
            this.topMarginBand_0.HeightF = 29f;
            this.topMarginBand_0.Name = "TopMargin";
            this.topMarginBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.topMarginBand_0.TextAlignment = TextAlignment.TopLeft;
            this.bottomMarginBand_0.HeightF = 19f;
            this.bottomMarginBand_0.Name = "BottomMargin";
            this.bottomMarginBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.bottomMarginBand_0.TextAlignment = TextAlignment.TopLeft;
            this.pageHeaderBand_0.Controls.AddRange(new XRControl[] { this.xrtable_2 });
            this.pageHeaderBand_0.HeightF = 25f;
            this.pageHeaderBand_0.Name = "PageHeader";
            this.xrtable_2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtable_2.LocationFloat = new PointFloat(3.051758E-05f, 0f);
            this.xrtable_2.Name = "xrTable2";
            this.xrtable_2.Padding = new PaddingInfo(3, 0, 0, 0, 100f);
            this.xrtable_2.Rows.AddRange(new XRTableRow[] { this.xrtableRow_3 });
            this.xrtable_2.SizeF = new SizeF(789.9999f, 25f);
            this.xrtable_2.StylePriority.UseFont = false;
            this.xrtable_2.StylePriority.UsePadding = false;
            this.xrtable_2.StylePriority.UseTextAlignment = false;
            this.xrtable_2.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableRow_3.Cells.AddRange(new XRTableCell[] { this.xrtableCell_9, this.xrtableCell_10, this.xrtableCell_11, this.xrtableCell_12 });
            this.xrtableRow_3.Name = "xrTableRow4";
            this.xrtableRow_3.Weight = 1.0;
            this.xrtableCell_9.BackColor = Color.LightCyan;
            this.xrtableCell_9.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_9.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_9.Name = "xrTableCell9";
            this.xrtableCell_9.StylePriority.UseBackColor = false;
            this.xrtableCell_9.StylePriority.UseBorders = false;
            this.xrtableCell_9.StylePriority.UseFont = false;
            this.xrtableCell_9.StylePriority.UseTextAlignment = false;
            this.xrtableCell_9.Text = "TT";
            this.xrtableCell_9.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_9.Weight = 0.16139237407383975;
            this.xrtableCell_10.BackColor = Color.LightCyan;
            this.xrtableCell_10.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_10.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_10.Name = "xrTableCell10";
            this.xrtableCell_10.StylePriority.UseBackColor = false;
            this.xrtableCell_10.StylePriority.UseBorders = false;
            this.xrtableCell_10.StylePriority.UseFont = false;
            this.xrtableCell_10.StylePriority.UseTextAlignment = false;
            this.xrtableCell_10.Text = "M\x00e3 s\x00e1ch";
            this.xrtableCell_10.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_10.Weight = 0.32753177227796881;
            this.xrtableCell_11.BackColor = Color.LightCyan;
            this.xrtableCell_11.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_11.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_11.Name = "xrTableCell11";
            this.xrtableCell_11.StylePriority.UseBackColor = false;
            this.xrtableCell_11.StylePriority.UseBorders = false;
            this.xrtableCell_11.StylePriority.UseFont = false;
            this.xrtableCell_11.StylePriority.UseTextAlignment = false;
            this.xrtableCell_11.Text = "T\x00ean s\x00e1ch";
            this.xrtableCell_11.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_11.Weight = 1.8917724912057219;
            this.xrtableCell_12.BackColor = Color.LightCyan;
            this.xrtableCell_12.Borders = BorderSide.All;
            this.xrtableCell_12.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_12.Name = "xrTableCell13";
            this.xrtableCell_12.StylePriority.UseBackColor = false;
            this.xrtableCell_12.StylePriority.UseBorders = false;
            this.xrtableCell_12.StylePriority.UseFont = false;
            this.xrtableCell_12.StylePriority.UseTextAlignment = false;
            this.xrtableCell_12.Text = "Ng\x00e0y hẹn trả";
            this.xrtableCell_12.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableCell_12.Weight = 0.6193033624424702;
            this.reportHeaderBand_0.Controls.AddRange(new XRControl[] { this.xrtable_0, this.xrlabel_8, this.xrlabel_9, this.xrlabel_10, this.xrlabel_0, this.xrlabel_1, this.xrlabel_2, this.xrlabel_3, this.xrlabel_4, this.xrlabel_5, this.xrlabel_6, this.xrlabel_7 });
            this.reportHeaderBand_0.HeightF = 209.375f;
            this.reportHeaderBand_0.Name = "ReportHeader";
            this.reportHeaderBand_0.BeforePrint += new PrintEventHandler(this.RrqIxZxw5);
            this.xrtable_0.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtable_0.LocationFloat = new PointFloat(0f, 134.375f);
            this.xrtable_0.Name = "xrTable1";
            this.xrtable_0.Padding = new PaddingInfo(3, 0, 0, 0, 100f);
            this.xrtable_0.Rows.AddRange(new XRTableRow[] { this.xrtableRow_0, this.xrtableRow_1, this.xrtableRow_4 });
            this.xrtable_0.SizeF = new SizeF(789.9999f, 75f);
            this.xrtable_0.StylePriority.UseFont = false;
            this.xrtable_0.StylePriority.UsePadding = false;
            this.xrtable_0.StylePriority.UseTextAlignment = false;
            this.xrtable_0.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableRow_0.Cells.AddRange(new XRTableCell[] { this.xrtableCell_0, this.xrtableCell_1, this.xrtableCell_2, this.xrtableCell_13 });
            this.xrtableRow_0.Name = "xrTableRow1";
            this.xrtableRow_0.Weight = 1.0;
            this.xrtableCell_0.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_0.Name = "xrTableCell1";
            this.xrtableCell_0.StylePriority.UseFont = false;
            this.xrtableCell_0.Text = "Họ v\x00e0 t\x00ean :";
            this.xrtableCell_0.Weight = 0.28006325483207262;
            this.xrtableCell_1.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.csname") });
            this.xrtableCell_1.Name = "xrTableCell2";
            this.xrtableCell_1.Text = "xrTableCell2";
            this.xrtableCell_1.Weight = 0.98022165266373285;
            this.xrtableCell_1.WordWrap = false;
            this.xrtableCell_2.Name = "xrTableCell3";
            this.xrtableCell_2.Text = "Điện thoại :";
            this.xrtableCell_2.Weight = 0.28575980547244323;
            this.xrtableCell_13.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.phone") });
            this.xrtableCell_13.Name = "xrTableCell7";
            this.xrtableCell_13.Text = "xrTableCell7";
            this.xrtableCell_13.Weight = 1.453955287031752;
            this.xrtableCell_13.WordWrap = false;
            this.xrtableRow_1.Cells.AddRange(new XRTableCell[] { this.xrtableCell_3, this.xrtableCell_4 });
            this.xrtableRow_1.Name = "xrTableRow2";
            this.xrtableRow_1.Weight = 1.0;
            this.xrtableCell_3.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_3.Name = "xrTableCell4";
            this.xrtableCell_3.StylePriority.UseFont = false;
            this.xrtableCell_3.Text = "Địa chỉ :";
            this.xrtableCell_3.Weight = 0.28006325483207262;
            this.xrtableCell_4.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.address") });
            this.xrtableCell_4.Name = "xrTableCell5";
            this.xrtableCell_4.Text = "xrTableCell5";
            this.xrtableCell_4.Weight = 2.7199367451679275;
            this.xrtableCell_4.WordWrap = false;
            this.xrtableRow_4.Cells.AddRange(new XRTableCell[] { this.xrtableCell_14, this.xrtableCell_15 });
            this.xrtableRow_4.Name = "xrTableRow3";
            this.xrtableRow_4.Weight = 1.0;
            this.xrtableCell_14.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_14.Name = "xrTableCell6";
            this.xrtableCell_14.StylePriority.UseFont = false;
            this.xrtableCell_14.Text = "Ghi ch\x00fa :";
            this.xrtableCell_14.Weight = 0.28006325483207262;
            this.xrtableCell_15.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.remark") });
            this.xrtableCell_15.Name = "xrTableCell8";
            this.xrtableCell_15.Text = "xrTableCell8";
            this.xrtableCell_15.Weight = 2.7199367451679275;
            this.xrtableCell_15.WordWrap = false;
            this.xrlabel_8.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.tran_time") });
            this.xrlabel_8.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xa3);
            this.xrlabel_8.LocationFloat = new PointFloat(748.4583f, 0f);
            this.xrlabel_8.Name = "lblTranTime";
            this.xrlabel_8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_8.SizeF = new SizeF(40.95837f, 25f);
            this.xrlabel_8.StylePriority.UseFont = false;
            this.xrlabel_8.StylePriority.UseTextAlignment = false;
            this.xrlabel_8.Text = "lblTranTime";
            this.xrlabel_8.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_8.WordWrap = false;
            this.xrlabel_9.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_9.LocationFloat = new PointFloat(576.25f, 0f);
            this.xrlabel_9.Name = "xrLabel2";
            this.xrlabel_9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_9.SizeF = new SizeF(97.91669f, 25f);
            this.xrlabel_9.StylePriority.UseFont = false;
            this.xrlabel_9.StylePriority.UseTextAlignment = false;
            this.xrlabel_9.Text = "Ng\x00e0y mượn :";
            this.xrlabel_9.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_9.WordWrap = false;
            this.xrlabel_10.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.tran_date", "{0:dd/MM/yyyy}") });
            this.xrlabel_10.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xa3);
            this.xrlabel_10.LocationFloat = new PointFloat(674.1666f, 0f);
            this.xrlabel_10.Name = "lblTranDate";
            this.xrlabel_10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_10.SizeF = new SizeF(74.29169f, 25f);
            this.xrlabel_10.StylePriority.UseFont = false;
            this.xrlabel_10.StylePriority.UseTextAlignment = false;
            this.xrlabel_10.Text = "lblTranDate";
            this.xrlabel_10.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_10.WordWrap = false;
            this.xrlabel_0.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_0.LocationFloat = new PointFloat(0f, 50f);
            this.xrlabel_0.Name = "xrLabel15";
            this.xrlabel_0.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_0.SizeF = new SizeF(58f, 25f);
            this.xrlabel_0.StylePriority.UseFont = false;
            this.xrlabel_0.StylePriority.UseTextAlignment = false;
            this.xrlabel_0.Text = "Đ.thoại :";
            this.xrlabel_0.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_0.WordWrap = false;
            this.xrlabel_1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_1.LocationFloat = new PointFloat(0f, 25f);
            this.xrlabel_1.Name = "xrLabel14";
            this.xrlabel_1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_1.SizeF = new SizeF(58f, 25f);
            this.xrlabel_1.StylePriority.UseFont = false;
            this.xrlabel_1.StylePriority.UseTextAlignment = false;
            this.xrlabel_1.Text = "Địa chỉ :";
            this.xrlabel_1.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_1.WordWrap = false;
            this.xrlabel_2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xa3);
            this.xrlabel_2.LocationFloat = new PointFloat(58.00001f, 50f);
            this.xrlabel_2.Name = "Lbl_CompPhone";
            this.xrlabel_2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_2.SizeF = new SizeF(333f, 25f);
            this.xrlabel_2.StylePriority.UseFont = false;
            this.xrlabel_2.StylePriority.UseTextAlignment = false;
            this.xrlabel_2.Text = "0433.863050; Fax: 0433.864.111";
            this.xrlabel_2.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_2.WordWrap = false;
            this.xrlabel_3.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_3.LocationFloat = new PointFloat(328f, 102.5417f);
            this.xrlabel_3.Name = "xrLabel1";
            this.xrlabel_3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_3.SizeF = new SizeF(42.00003f, 25f);
            this.xrlabel_3.StylePriority.UseFont = false;
            this.xrlabel_3.StylePriority.UseTextAlignment = false;
            this.xrlabel_3.Text = "Số :";
            this.xrlabel_3.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_3.WordWrap = false;
            this.xrlabel_4.CanShrink = true;
            this.xrlabel_4.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_4.LocationFloat = new PointFloat(259.0625f, 75f);
            this.xrlabel_4.Name = "Lbl_Title";
            this.xrlabel_4.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.xrlabel_4.SizeF = new SizeF(271.875f, 33f);
            this.xrlabel_4.StylePriority.UseFont = false;
            this.xrlabel_4.StylePriority.UsePadding = false;
            this.xrlabel_4.StylePriority.UseTextAlignment = false;
            this.xrlabel_4.Text = "PHIẾU MƯỢN S\x00c1CH";
            this.xrlabel_4.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_5.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "loantran.trans_num") });
            this.xrlabel_5.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_5.LocationFloat = new PointFloat(370f, 102.5417f);
            this.xrlabel_5.Name = "Lbl_TransNum";
            this.xrlabel_5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_5.SizeF = new SizeF(92f, 25f);
            this.xrlabel_5.StylePriority.UseFont = false;
            this.xrlabel_5.StylePriority.UseTextAlignment = false;
            this.xrlabel_5.Text = "Lbl_TransNum";
            this.xrlabel_5.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_5.WordWrap = false;
            this.xrlabel_6.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xa3);
            this.xrlabel_6.LocationFloat = new PointFloat(58.00001f, 25f);
            this.xrlabel_6.Name = "Lbl_CompAddress";
            this.xrlabel_6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_6.SizeF = new SizeF(333f, 25f);
            this.xrlabel_6.StylePriority.UseFont = false;
            this.xrlabel_6.StylePriority.UseTextAlignment = false;
            this.xrlabel_6.Text = "Thuỵ An – Ba V\x00ec – H\x00e0 Nội";
            this.xrlabel_6.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_6.WordWrap = false;
            this.xrlabel_7.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_7.LocationFloat = new PointFloat(0f, 0f);
            this.xrlabel_7.Name = "Lbl_CompName";
            this.xrlabel_7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_7.SizeF = new SizeF(548.625f, 25f);
            this.xrlabel_7.StylePriority.UseFont = false;
            this.xrlabel_7.StylePriority.UseTextAlignment = false;
            this.xrlabel_7.Text = "Trường Cao đẳng nghề GTVT Trung ương I";
            this.xrlabel_7.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_7.WordWrap = false;
            this.reportFooterBand_0.Controls.AddRange(new XRControl[] { this.xrlabel_11, this.xrlabel_12, this.xrlabel_13, this.xrlabel_14, this.xrlabel_15, this.xrlabel_16 });
            this.reportFooterBand_0.HeightF = 122f;
            this.reportFooterBand_0.Name = "ReportFooter";
            this.xrlabel_11.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0xa3);
            this.xrlabel_11.LocationFloat = new PointFloat(70.50008f, 24f);
            this.xrlabel_11.Name = "xrLabel23";
            this.xrlabel_11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_11.SizeF = new SizeF(50f, 25f);
            this.xrlabel_11.StylePriority.UseFont = false;
            this.xrlabel_11.StylePriority.UseTextAlignment = false;
            this.xrlabel_11.Text = "(K\x00fd t\x00ean)";
            this.xrlabel_11.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_11.WordWrap = false;
            this.xrlabel_12.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0xa3);
            this.xrlabel_12.LocationFloat = new PointFloat(378.5001f, 24f);
            this.xrlabel_12.Name = "xrLabel24";
            this.xrlabel_12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_12.SizeF = new SizeF(50f, 25f);
            this.xrlabel_12.StylePriority.UseFont = false;
            this.xrlabel_12.StylePriority.UseTextAlignment = false;
            this.xrlabel_12.Text = "(K\x00fd t\x00ean)";
            this.xrlabel_12.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_12.WordWrap = false;
            this.xrlabel_13.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0xa3);
            this.xrlabel_13.LocationFloat = new PointFloat(670.4999f, 24f);
            this.xrlabel_13.Name = "xrLabel25";
            this.xrlabel_13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_13.SizeF = new SizeF(50f, 25f);
            this.xrlabel_13.StylePriority.UseFont = false;
            this.xrlabel_13.StylePriority.UseTextAlignment = false;
            this.xrlabel_13.Text = "(K\x00fd t\x00ean)";
            this.xrlabel_13.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_13.WordWrap = false;
            this.xrlabel_14.Font = new Font("Arial", 9f, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_14.LocationFloat = new PointFloat(339.5001f, 6.999996f);
            this.xrlabel_14.Name = "xrLabel19";
            this.xrlabel_14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_14.SizeF = new SizeF(125f, 25f);
            this.xrlabel_14.StylePriority.UseFont = false;
            this.xrlabel_14.StylePriority.UseTextAlignment = false;
            this.xrlabel_14.Text = "Thủ thư";
            this.xrlabel_14.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_14.WordWrap = false;
            this.xrlabel_15.Font = new Font("Arial", 9f, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_15.LocationFloat = new PointFloat(628.4999f, 6.999996f);
            this.xrlabel_15.Name = "xrLabel20";
            this.xrlabel_15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_15.SizeF = new SizeF(125f, 25f);
            this.xrlabel_15.StylePriority.UseFont = false;
            this.xrlabel_15.StylePriority.UseTextAlignment = false;
            this.xrlabel_15.Text = "Người lập phiếu";
            this.xrlabel_15.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_15.WordWrap = false;
            this.xrlabel_16.Font = new Font("Arial", 9f, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_16.LocationFloat = new PointFloat(36.50006f, 6.999996f);
            this.xrlabel_16.Name = "xrLabel21";
            this.xrlabel_16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_16.SizeF = new SizeF(125f, 25f);
            this.xrlabel_16.StylePriority.UseFont = false;
            this.xrlabel_16.StylePriority.UseTextAlignment = false;
            this.xrlabel_16.Text = "Người mượn s\x00e1ch";
            this.xrlabel_16.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_16.WordWrap = false;
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.Tables.AddRange(new DataTable[] { this.dataTable_0 });
            this.dataTable_0.Columns.AddRange(new DataColumn[] { this.dataColumn_0, this.AhxsdynSH, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4, this.dataColumn_5, this.dataColumn_6, this.dataColumn_7, this.dataColumn_8, this.dataColumn_9 });
            this.dataTable_0.Constraints.AddRange(new Constraint[] { new UniqueConstraint("Constraint1", new string[] { "goods_id" }, true) });
            this.dataTable_0.PrimaryKey = new DataColumn[] { this.AhxsdynSH };
            this.dataTable_0.TableName = "loantran";
            this.dataColumn_0.ColumnName = "idx";
            this.dataColumn_0.DataType = typeof(short);
            this.AhxsdynSH.AllowDBNull = false;
            this.AhxsdynSH.ColumnName = "goods_id";
            this.AhxsdynSH.MaxLength = 6;
            this.dataColumn_1.ColumnName = "full_name";
            this.dataColumn_2.ColumnName = "due_date";
            this.dataColumn_2.DataType = typeof(DateTime);
            this.dataColumn_3.ColumnName = "csname";
            this.dataColumn_4.ColumnName = "address";
            this.dataColumn_5.ColumnName = "phone";
            this.dataColumn_6.ColumnName = "trans_num";
            this.dataColumn_7.ColumnName = "remark";
            this.dataColumn_8.ColumnName = "tran_date";
            this.dataColumn_8.DataType = typeof(DateTime);
            this.dataColumn_9.ColumnName = "tran_time";
            base.Bands.AddRange(new Band[] { this.detailBand_0, this.topMarginBand_0, this.bottomMarginBand_0, this.pageHeaderBand_0, this.reportHeaderBand_0, this.reportFooterBand_0 });
            base.DataMember = "loantran";
            base.DataSource = this.dataSet1;
            base.Margins = new Margins(30, 30, 0x1d, 0x13);
            base.SnapToGrid = false;
            base.Version = "10.1";
            this.xrtable_1.EndInit();
            this.xrtable_2.EndInit();
            this.xrtable_0.EndInit();
            this.dataSet1.EndInit();
            this.dataTable_0.EndInit();
            this.EndInit();
        }

        private void RrqIxZxw5(object sender, PrintEventArgs e)
        {
            this.string_0 = "SELECT tr.goods_id, gs.full_name, tr.trans_num, tr.corr_tran AS oldtran, tr.tran_date, tr.trans_code, tr.tran_time, tr.exp_id, tr.cs_id, tr.qty, tr.due_date, tr.user_id, tr.remark,  cs.fullname AS csname, cs.address, cs.phone FROM tblLoanTran AS tr INNER JOIN tblGoods AS gs ON tr.goods_id = gs.goods_id INNER JOIN tblCustomer AS cs ON tr.cs_id = cs.id WHERE tr.trans_num = '" + Class6.string_5 + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set, "loantran");
                this.oleDbConnection_0.Close();
                this.dataSet1.Merge(set.Tables[0]);
            }
            for (int i = 0; i < this.dataSet1.Tables["loantran"].Rows.Count; i++)
            {
                this.dataSet1.Tables["loantran"].Rows[i]["idx"] = i + 1;
            }
            this.xrlabel_7.Text = Class13.smethod_1(Class7.smethod_14("m_name").ToString(), Class13.string_0);
            this.xrlabel_6.Text = Class13.smethod_1(Class7.smethod_14("m_address").ToString(), Class13.string_0);
            this.xrlabel_2.Text = Class13.smethod_1(Class7.smethod_14("m_phone").ToString(), Class13.string_0);
        }
    }
}

