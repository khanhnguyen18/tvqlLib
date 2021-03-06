using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Data;
using System.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.Utils;

namespace LibraryManagement.App
{
    public class acc_diary : XtraReport
    {
        private BottomMarginBand bottomMarginBand_0;
        private DetailBand detailBand_0;
        private IContainer icontainer_0;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PageFooterBand pageFooterBand_0;
        private PageHeaderBand pageHeaderBand_0;
        private ReportFooterBand reportFooterBand_0;
        private ReportHeaderBand reportHeaderBand_0;
        private string string_0;
        private TopMarginBand topMarginBand_0;
        private XRLabel xrlabel_0;
        private XRLabel xrlabel_1;
        private XRLabel xrlabel_10;
        private XRLabel xrlabel_11;
        private XRLabel xrlabel_2;
        private XRLabel xrlabel_3;
        private XRLabel xrlabel_4;
        private XRLabel xrlabel_5;
        private XRLabel xrlabel_6;
        private XRLabel xrlabel_7;
        private XRLabel xrlabel_8;
        private XRLabel xrlabel_9;
        private XRPageInfo xrpageInfo_0;
        private XRPageInfo xrpageInfo_1;
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

        static acc_diary()
        {
            Class15.smethod_5();
        }

        public acc_diary()
        {
            Class17.smethod_0();
            this.icontainer_0 = null;
            this.oleDbConnection_0 = new OleDbConnection(Class7.string_5);
            this.string_0 = null;
            this.method_0();
        }

        private void acc_diary_BeforePrint(object sender, PrintEventArgs e)
        {
            if (FrmReports._sumrp)
            {
                this.detailBand_0.Visible = false;
            }
            this.string_0 = string.Concat(new object[] { "SELECT DISTINCT trans_num, CASE db_amount WHEN 0 THEN account_id ELSE corr_acc END AS craccount, CASE cr_amount WHEN 0 THEN account_id ELSE corr_acc END AS dbaccount, remark, db_amount + cr_amount AS amount, tran_date, voucher FROM [pos_data].[dbo].[tblAccTrans]  where (tran_date between '", Class7.dateTimeFrom, "' and '", Class7.dateTimeTo, "')  and status = 1  GROUP BY trans_num, account_id, corr_acc, db_amount, cr_amount, remark, tran_date, voucher  order by tran_date " });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                base.DataAdapter = this.oleDbDataAdapter_0;
                base.DataSource = set.Tables[0];
            }
            this.xrtableCell_11.DataBindings.Add("Text", base.DataSource, "amount", "{0:n0}");
            this.xrtableCell_6.DataBindings.Add("Text", base.DataSource, "voucher", "");
            this.xrtableCell_13.DataBindings.Add("Text", base.DataSource, "trans_num", "");
            this.xrtableCell_7.DataBindings.Add("Text", base.DataSource, "tran_date", "{0:dd/MM/yyyy}");
            this.xrtableCell_8.DataBindings.Add("Text", base.DataSource, "remark", "");
            this.xrtableCell_10.DataBindings.Add("Text", base.DataSource, "dbaccount", "");
            this.xrtableCell_9.DataBindings.Add("Text", base.DataSource, "craccount", "");
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
            this.detailBand_0 = new DetailBand();
            this.xrtable_1 = new XRTable();
            this.xrtableRow_1 = new XRTableRow();
            this.xrtableCell_6 = new XRTableCell();
            this.xrtableCell_7 = new XRTableCell();
            this.xrtableCell_13 = new XRTableCell();
            this.xrtableCell_8 = new XRTableCell();
            this.xrtableCell_9 = new XRTableCell();
            this.xrtableCell_10 = new XRTableCell();
            this.xrtableCell_11 = new XRTableCell();
            this.pageHeaderBand_0 = new PageHeaderBand();
            this.xrtable_0 = new XRTable();
            this.xrtableRow_0 = new XRTableRow();
            this.xrtableCell_0 = new XRTableCell();
            this.xrtableCell_1 = new XRTableCell();
            this.xrtableCell_12 = new XRTableCell();
            this.xrtableCell_2 = new XRTableCell();
            this.xrtableCell_3 = new XRTableCell();
            this.xrtableCell_4 = new XRTableCell();
            this.xrtableCell_5 = new XRTableCell();
            this.xrpageInfo_0 = new XRPageInfo();
            this.xrlabel_2 = new XRLabel();
            this.pageFooterBand_0 = new PageFooterBand();
            this.reportHeaderBand_0 = new ReportHeaderBand();
            this.xrpageInfo_1 = new XRPageInfo();
            this.xrlabel_3 = new XRLabel();
            this.xrlabel_4 = new XRLabel();
            this.xrlabel_5 = new XRLabel();
            this.xrlabel_0 = new XRLabel();
            this.xrlabel_1 = new XRLabel();
            this.reportFooterBand_0 = new ReportFooterBand();
            this.xrtable_2 = new XRTable();
            this.xrtableRow_2 = new XRTableRow();
            this.xrtableCell_14 = new XRTableCell();
            this.xrlabel_6 = new XRLabel();
            this.xrlabel_7 = new XRLabel();
            this.xrlabel_8 = new XRLabel();
            this.xrlabel_9 = new XRLabel();
            this.xrlabel_10 = new XRLabel();
            this.xrlabel_11 = new XRLabel();
            this.topMarginBand_0 = new TopMarginBand();
            this.bottomMarginBand_0 = new BottomMarginBand();
            this.xrtable_1.BeginInit();
            this.xrtable_0.BeginInit();
            this.xrtable_2.BeginInit();
            this.BeginInit();
            this.detailBand_0.Controls.AddRange(new XRControl[] { this.xrtable_1 });
            this.detailBand_0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.detailBand_0.HeightF = 25f;
            this.detailBand_0.Name = "Detail";
            this.detailBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.detailBand_0.StylePriority.UseFont = false;
            this.detailBand_0.TextAlignment = TextAlignment.TopLeft;
            this.xrtable_1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrtable_1.LocationFloat = new PointFloat(1.5625f, 0f);
            this.xrtable_1.Name = "xrTable1";
            this.xrtable_1.Rows.AddRange(new XRTableRow[] { this.xrtableRow_1 });
            this.xrtable_1.SizeF = new SizeF(785.4375f, 25f);
            this.xrtable_1.StylePriority.UseFont = false;
            this.xrtable_1.StylePriority.UseTextAlignment = false;
            this.xrtable_1.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableRow_1.Cells.AddRange(new XRTableCell[] { this.xrtableCell_6, this.xrtableCell_7, this.xrtableCell_13, this.xrtableCell_8, this.xrtableCell_9, this.xrtableCell_10, this.xrtableCell_11 });
            this.xrtableRow_1.Name = "xrTableRow1";
            this.xrtableRow_1.Weight = 1.0;
            this.xrtableCell_6.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_6.Name = "colVoucher";
            this.xrtableCell_6.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_6.StylePriority.UseBorders = false;
            this.xrtableCell_6.StylePriority.UsePadding = false;
            this.xrtableCell_6.StylePriority.UseTextAlignment = false;
            this.xrtableCell_6.Text = "colVoucher";
            this.xrtableCell_6.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_6.Weight = 0.81150501246962559;
            this.xrtableCell_6.WordWrap = false;
            this.xrtableCell_7.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_7.Name = "colDate";
            this.xrtableCell_7.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_7.StylePriority.UseBorders = false;
            this.xrtableCell_7.StylePriority.UsePadding = false;
            this.xrtableCell_7.Text = "colDate";
            this.xrtableCell_7.Weight = 0.69162180392647521;
            this.xrtableCell_13.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_13.Name = "colTransNum";
            this.xrtableCell_13.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_13.StylePriority.UseBorders = false;
            this.xrtableCell_13.StylePriority.UsePadding = false;
            this.xrtableCell_13.Text = "colTransNum";
            this.xrtableCell_13.Weight = 0.93242173337283607;
            this.xrtableCell_8.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_8.Name = "colRemark";
            this.xrtableCell_8.Padding = new PaddingInfo(3, 0, 0, 0, 100f);
            this.xrtableCell_8.StylePriority.UseBorders = false;
            this.xrtableCell_8.StylePriority.UsePadding = false;
            this.xrtableCell_8.StylePriority.UseTextAlignment = false;
            this.xrtableCell_8.Text = "colRemark";
            this.xrtableCell_8.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_8.Weight = 2.5039875056813612;
            this.xrtableCell_8.WordWrap = false;
            this.xrtableCell_9.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_9.Name = "colCrAccount";
            this.xrtableCell_9.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_9.StylePriority.UseBorders = false;
            this.xrtableCell_9.StylePriority.UsePadding = false;
            this.xrtableCell_9.Text = "colCrAccount";
            this.xrtableCell_9.Weight = 0.68805428834343063;
            this.xrtableCell_9.WordWrap = false;
            this.xrtableCell_10.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_10.Name = "colDebAccount";
            this.xrtableCell_10.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_10.StylePriority.UseBorders = false;
            this.xrtableCell_10.StylePriority.UsePadding = false;
            this.xrtableCell_10.StylePriority.UseTextAlignment = false;
            this.xrtableCell_10.Text = "colDebAccount";
            this.xrtableCell_10.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_10.Weight = 0.74786009682869947;
            this.xrtableCell_10.WordWrap = false;
            this.xrtableCell_11.Borders = BorderSide.Bottom | BorderSide.Right | BorderSide.Left;
            this.xrtableCell_11.Name = "colAmount";
            this.xrtableCell_11.Padding = new PaddingInfo(0, 5, 0, 0, 100f);
            this.xrtableCell_11.StylePriority.UseBorders = false;
            this.xrtableCell_11.StylePriority.UsePadding = false;
            this.xrtableCell_11.StylePriority.UseTextAlignment = false;
            this.xrtableCell_11.Text = "colAmount";
            this.xrtableCell_11.TextAlignment = TextAlignment.MiddleRight;
            this.xrtableCell_11.Weight = 0.91321573874439244;
            this.pageHeaderBand_0.Controls.AddRange(new XRControl[] { this.xrtable_0, this.xrpageInfo_0, this.xrlabel_2 });
            this.pageHeaderBand_0.HeightF = 50f;
            this.pageHeaderBand_0.Name = "PageHeader";
            this.pageHeaderBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.pageHeaderBand_0.TextAlignment = TextAlignment.TopLeft;
            this.xrtable_0.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtable_0.LocationFloat = new PointFloat(0f, 25f);
            this.xrtable_0.Name = "xrTable2";
            this.xrtable_0.Rows.AddRange(new XRTableRow[] { this.xrtableRow_0 });
            this.xrtable_0.SizeF = new SizeF(787f, 25f);
            this.xrtable_0.StylePriority.UseFont = false;
            this.xrtable_0.StylePriority.UseTextAlignment = false;
            this.xrtable_0.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableRow_0.Cells.AddRange(new XRTableCell[] { this.xrtableCell_0, this.xrtableCell_1, this.xrtableCell_12, this.xrtableCell_2, this.xrtableCell_3, this.xrtableCell_4, this.xrtableCell_5 });
            this.xrtableRow_0.Name = "xrTableRow2";
            this.xrtableRow_0.Weight = 1.0;
            this.xrtableCell_0.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_0.Name = "xrTableCell7";
            this.xrtableCell_0.StylePriority.UseBorders = false;
            this.xrtableCell_0.Text = "Số chứng từ";
            this.xrtableCell_0.Weight = 0.82600466229448832;
            this.xrtableCell_1.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_1.Name = "xrTableCell8";
            this.xrtableCell_1.StylePriority.UseBorders = false;
            this.xrtableCell_1.Text = "Ng\x00e0y";
            this.xrtableCell_1.Weight = 0.691621910124823;
            this.xrtableCell_12.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_12.Name = "xrTableCell13";
            this.xrtableCell_12.StylePriority.UseBorders = false;
            this.xrtableCell_12.Text = "Số giao dịch";
            this.xrtableCell_12.Weight = 0.93242173337283629;
            this.xrtableCell_2.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_2.Name = "xrTableCell1";
            this.xrtableCell_2.StylePriority.UseBorders = false;
            this.xrtableCell_2.Text = "Diễn giải giao dịch";
            this.xrtableCell_2.Weight = 2.5039873640835637;
            this.xrtableCell_3.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_3.Name = "xrTableCell10";
            this.xrtableCell_3.StylePriority.UseBorders = false;
            this.xrtableCell_3.Text = "TK ghi c\x00f3";
            this.xrtableCell_3.Weight = 0.68805428834343063;
            this.xrtableCell_4.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_4.Name = "xrTableCell11";
            this.xrtableCell_4.StylePriority.UseBorders = false;
            this.xrtableCell_4.Text = "TK ghi nợ";
            this.xrtableCell_4.Weight = 0.74786009682869925;
            this.xrtableCell_5.Borders = BorderSide.All;
            this.xrtableCell_5.Name = "xrTableCell12";
            this.xrtableCell_5.StylePriority.UseBorders = false;
            this.xrtableCell_5.Text = "Số tiền";
            this.xrtableCell_5.Weight = 0.91321573874439266;
            this.xrpageInfo_0.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrpageInfo_0.LocationFloat = new PointFloat(749f, 0f);
            this.xrpageInfo_0.Name = "xrPageInfo1";
            this.xrpageInfo_0.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrpageInfo_0.SizeF = new SizeF(36.125f, 23f);
            this.xrpageInfo_0.StylePriority.UseFont = false;
            this.xrpageInfo_0.StylePriority.UseTextAlignment = false;
            this.xrpageInfo_0.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrlabel_2.LocationFloat = new PointFloat(649f, 0f);
            this.xrlabel_2.Name = "xrLabel11";
            this.xrlabel_2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_2.SizeF = new SizeF(100f, 23f);
            this.xrlabel_2.StylePriority.UseFont = false;
            this.xrlabel_2.StylePriority.UseTextAlignment = false;
            this.xrlabel_2.Text = "Trang số :";
            this.xrlabel_2.TextAlignment = TextAlignment.MiddleRight;
            this.pageFooterBand_0.HeightF = 12f;
            this.pageFooterBand_0.Name = "PageFooter";
            this.pageFooterBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.pageFooterBand_0.TextAlignment = TextAlignment.TopLeft;
            this.reportHeaderBand_0.Controls.AddRange(new XRControl[] { this.xrpageInfo_1, this.xrlabel_3, this.xrlabel_4, this.xrlabel_5, this.xrlabel_0, this.xrlabel_1 });
            this.reportHeaderBand_0.HeightF = 93f;
            this.reportHeaderBand_0.Name = "ReportHeader";
            this.reportHeaderBand_0.BeforePrint += new PrintEventHandler(this.reportHeaderBand_0_BeforePrint);
            this.xrpageInfo_1.Font = new Font("Arial Narrow", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrpageInfo_1.LocationFloat = new PointFloat(516f, 0f);
            this.xrpageInfo_1.Name = "xrPageInfo2";
            this.xrpageInfo_1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrpageInfo_1.PageInfo = PageInfo.DateTime;
            this.xrpageInfo_1.SizeF = new SizeF(271f, 23f);
            this.xrpageInfo_1.StylePriority.UseFont = false;
            this.xrpageInfo_1.StylePriority.UseTextAlignment = false;
            this.xrpageInfo_1.TextAlignment = TextAlignment.MiddleRight;
            this.xrlabel_3.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_3.LocationFloat = new PointFloat(6.000002f, 0f);
            this.xrlabel_3.Name = "Lbl_CompName";
            this.xrlabel_3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_3.SizeF = new SizeF(483f, 25f);
            this.xrlabel_3.StylePriority.UseFont = false;
            this.xrlabel_3.StylePriority.UseTextAlignment = false;
            this.xrlabel_3.Text = "C\x00d4NG TY V\x00c0NG BẠC Đ\x00c1 QU\x00dd PH\x00da QU\x00dd";
            this.xrlabel_3.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_3.WordWrap = false;
            this.xrlabel_4.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_4.LocationFloat = new PointFloat(6.000002f, 25f);
            this.xrlabel_4.Name = "xrLabel16";
            this.xrlabel_4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_4.SizeF = new SizeF(58f, 25f);
            this.xrlabel_4.StylePriority.UseFont = false;
            this.xrlabel_4.StylePriority.UseTextAlignment = false;
            this.xrlabel_4.Text = "MST :";
            this.xrlabel_4.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_4.WordWrap = false;
            this.xrlabel_5.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0xa3);
            this.xrlabel_5.LocationFloat = new PointFloat(68.5f, 25f);
            this.xrlabel_5.Name = "Lbl_CompVatNumber";
            this.xrlabel_5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_5.SizeF = new SizeF(112.8333f, 25f);
            this.xrlabel_5.StylePriority.UseFont = false;
            this.xrlabel_5.StylePriority.UseTextAlignment = false;
            this.xrlabel_5.Text = "123546513213";
            this.xrlabel_5.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_5.WordWrap = false;
            this.xrlabel_0.BorderColor = Color.FromArgb(0x81, 0x8e, 0x9e);
            this.xrlabel_0.Borders = BorderSide.None;
            this.xrlabel_0.BorderWidth = 2;
            this.xrlabel_0.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrlabel_0.ForeColor = Color.Black;
            this.xrlabel_0.LocationFloat = new PointFloat(150f, 50f);
            this.xrlabel_0.Name = "Lbl_Title";
            this.xrlabel_0.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_0.SizeF = new SizeF(477.8333f, 28f);
            this.xrlabel_0.StylePriority.UseBorders = false;
            this.xrlabel_0.StylePriority.UseFont = false;
            this.xrlabel_0.StylePriority.UseForeColor = false;
            this.xrlabel_0.StylePriority.UseTextAlignment = false;
            this.xrlabel_0.Text = "SỔ NHẬT K\x00dd";
            this.xrlabel_0.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_0.WordWrap = false;
            this.xrlabel_1.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0);
            this.xrlabel_1.ForeColor = Color.Black;
            this.xrlabel_1.LocationFloat = new PointFloat(187.5f, 75f);
            this.xrlabel_1.Name = "Lbl_Interval";
            this.xrlabel_1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_1.SizeF = new SizeF(407.2917f, 16f);
            this.xrlabel_1.StylePriority.UseFont = false;
            this.xrlabel_1.StylePriority.UseForeColor = false;
            this.xrlabel_1.StylePriority.UseTextAlignment = false;
            this.xrlabel_1.Text = "Từ ng\x00e0y 01/01/2009 đến ng\x00e0y 12/12/2009";
            this.xrlabel_1.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_1.WordWrap = false;
            this.reportFooterBand_0.Controls.AddRange(new XRControl[] { this.xrtable_2, this.xrlabel_6, this.xrlabel_7, this.xrlabel_8, this.xrlabel_9, this.xrlabel_10, this.xrlabel_11 });
            this.reportFooterBand_0.HeightF = 136f;
            this.reportFooterBand_0.Name = "ReportFooter";
            this.xrtable_2.LocationFloat = new PointFloat(0f, 0f);
            this.xrtable_2.Name = "xrTable3";
            this.xrtable_2.Rows.AddRange(new XRTableRow[] { this.xrtableRow_2 });
            this.xrtable_2.SizeF = new SizeF(786.9999f, 25f);
            this.xrtableRow_2.Cells.AddRange(new XRTableCell[] { this.xrtableCell_14 });
            this.xrtableRow_2.Name = "xrTableRow3";
            this.xrtableRow_2.Weight = 1.0;
            this.xrtableCell_14.Borders = BorderSide.Top;
            this.xrtableCell_14.Name = "xrTableCell2";
            this.xrtableCell_14.StylePriority.UseBorders = false;
            this.xrtableCell_14.Weight = 3.0;
            this.xrlabel_6.Font = new Font("Arial", 9f, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_6.LocationFloat = new PointFloat(626.0417f, 25f);
            this.xrlabel_6.Name = "xrLabel20";
            this.xrlabel_6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_6.SizeF = new SizeF(125f, 25f);
            this.xrlabel_6.StylePriority.UseFont = false;
            this.xrlabel_6.StylePriority.UseTextAlignment = false;
            this.xrlabel_6.Text = "Người lập b\x00e1o c\x00e1o";
            this.xrlabel_6.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_6.WordWrap = false;
            this.xrlabel_7.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0xa3);
            this.xrlabel_7.LocationFloat = new PointFloat(376.0417f, 50.00006f);
            this.xrlabel_7.Name = "xrLabel24";
            this.xrlabel_7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_7.SizeF = new SizeF(50f, 25f);
            this.xrlabel_7.StylePriority.UseFont = false;
            this.xrlabel_7.StylePriority.UseTextAlignment = false;
            this.xrlabel_7.Text = "(K\x00fd t\x00ean)";
            this.xrlabel_7.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_7.WordWrap = false;
            this.xrlabel_8.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0xa3);
            this.xrlabel_8.LocationFloat = new PointFloat(663.5417f, 50.00006f);
            this.xrlabel_8.Name = "xrLabel25";
            this.xrlabel_8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_8.SizeF = new SizeF(50f, 25f);
            this.xrlabel_8.StylePriority.UseFont = false;
            this.xrlabel_8.StylePriority.UseTextAlignment = false;
            this.xrlabel_8.Text = "(K\x00fd t\x00ean)";
            this.xrlabel_8.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_8.WordWrap = false;
            this.xrlabel_9.Font = new Font("Arial", 9f, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_9.LocationFloat = new PointFloat(38.54168f, 25f);
            this.xrlabel_9.Name = "xrLabel21";
            this.xrlabel_9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_9.SizeF = new SizeF(125f, 25f);
            this.xrlabel_9.StylePriority.UseFont = false;
            this.xrlabel_9.StylePriority.UseTextAlignment = false;
            this.xrlabel_9.Text = "Thủ trưởng đơn vị";
            this.xrlabel_9.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_9.WordWrap = false;
            this.xrlabel_10.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0xa3);
            this.xrlabel_10.LocationFloat = new PointFloat(63.54168f, 50.00006f);
            this.xrlabel_10.Name = "xrLabel23";
            this.xrlabel_10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_10.SizeF = new SizeF(50f, 25f);
            this.xrlabel_10.StylePriority.UseFont = false;
            this.xrlabel_10.StylePriority.UseTextAlignment = false;
            this.xrlabel_10.Text = "(K\x00fd t\x00ean)";
            this.xrlabel_10.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_10.WordWrap = false;
            this.xrlabel_11.Font = new Font("Arial", 9f, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_11.LocationFloat = new PointFloat(338.5417f, 25f);
            this.xrlabel_11.Name = "xrLabel19";
            this.xrlabel_11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_11.SizeF = new SizeF(125f, 25f);
            this.xrlabel_11.StylePriority.UseFont = false;
            this.xrlabel_11.StylePriority.UseTextAlignment = false;
            this.xrlabel_11.Text = "Kế to\x00e1n trưởng";
            this.xrlabel_11.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_11.WordWrap = false;
            this.topMarginBand_0.HeightF = 40f;
            this.topMarginBand_0.Name = "topMarginBand1";
            this.bottomMarginBand_0.HeightF = 40f;
            this.bottomMarginBand_0.Name = "bottomMarginBand1";
            base.Bands.AddRange(new Band[] { this.detailBand_0, this.pageHeaderBand_0, this.pageFooterBand_0, this.reportHeaderBand_0, this.reportFooterBand_0, this.topMarginBand_0, this.bottomMarginBand_0 });
            base.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margins = new Margins(20, 20, 40, 40);
            base.PageHeight = 0x491;
            base.PageWidth = 0x33b;
            base.PaperKind = PaperKind.A4;
            base.SnapToGrid = false;
            base.Version = "9.3";
            this.BeforePrint += new PrintEventHandler(this.acc_diary_BeforePrint);
            this.xrtable_1.EndInit();
            this.xrtable_0.EndInit();
            this.xrtable_2.EndInit();
            this.EndInit();
        }

        private void reportHeaderBand_0_BeforePrint(object sender, PrintEventArgs e)
        {
            this.xrlabel_3.Text = Class13.smethod_1(Class7.smethod_14("m_name").ToString(), Class13.string_0);
            this.xrlabel_5.Text = Class13.smethod_1(Class7.smethod_14("m_vatnum").ToString(), Class13.string_0);
            this.xrlabel_0.Text = Class6.string_10.ToUpper();
            string str = string.Format("{0:dd/MM/yyyy}", Class7.dateTimeFrom);
            string str2 = string.Format("{0:dd/MM/yyyy}", Class7.dateTimeTo);
            this.xrlabel_1.Text = (Class7.dateTimeFrom == Class7.dateTimeTo) ? ("Trong ng\x00e0y " + str) : ("Từ ng\x00e0y :" + str + " đến ng\x00e0y :" + str2);
        }
    }
}
