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
    public class acc_info : XtraReport
    {
        private BottomMarginBand bottomMarginBand_0;
        private DetailBand detailBand_0;
        private GroupFooterBand groupFooterBand_0;
        private GroupHeaderBand groupHeaderBand_0;
        private IContainer icontainer_0;
        private XRTable IjSwogAv6;
        private OleDbConnection oleDbConnection_0;
        private OleDbDataAdapter oleDbDataAdapter_0;
        private PageFooterBand pageFooterBand_0;
        private PageHeaderBand pageHeaderBand_0;
        private string string_0;
        private TopMarginBand topMarginBand_0;
        private XRLabel xrlabel_0;
        private XRLabel xrlabel_1;
        private XRLabel xrlabel_2;
        private XRLabel xrlabel_3;
        private XRLabel xrlabel_4;
        private XRLabel xrlabel_5;
        private XRLabel xrlabel_6;
        private XRLine xrline_0;
        private XRPageInfo xrpageInfo_0;
        private XRPageInfo xrpageInfo_1;
        private XRTable xrtable_0;
        private XRTable xrtable_1;
        private XRTableCell xrtableCell_0;
        private XRTableCell xrtableCell_1;
        private XRTableCell xrtableCell_10;
        private XRTableCell xrtableCell_11;
        private XRTableCell xrtableCell_12;
        private XRTableCell xrtableCell_13;
        private XRTableCell xrtableCell_14;
        private XRTableCell xrtableCell_15;
        private XRTableCell xrtableCell_16;
        private XRTableCell xrtableCell_17;
        private XRTableCell xrtableCell_18;
        private XRTableCell xrtableCell_19;
        private XRTableCell xrtableCell_2;
        private XRTableCell xrtableCell_20;
        private XRTableCell xrtableCell_21;
        private XRTableCell xrtableCell_22;
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

        static acc_info()
        {
            Class15.smethod_5();
        }

        public acc_info()
        {
            Class17.smethod_0();
            this.oleDbConnection_0 = new OleDbConnection(Class7.string_5);
            this.string_0 = null;
            this.icontainer_0 = null;
            this.method_2();
        }

        private void acc_info_BeforePrint(object sender, PrintEventArgs e)
        {
            if (FrmReports._sumrp)
            {
                this.detailBand_0.Visible = false;
            }
            this.string_0 = string.Concat(new object[] { "SELECT tran_date, tran_time, ef_date, trans_num, voucher, trans_code, account_id, db_amount, cr_amount , user_id, corr_acc, remark, updated, status  FROM tblAccTrans  where (tran_date between '", Class7.dateTimeFrom, "' and '", Class7.dateTimeTo, "')  and status = 1  order by account_id, tran_date" });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                base.DataAdapter = this.oleDbDataAdapter_0;
                base.DataSource = set.Tables[0];
            }
            this.groupHeaderBand_0.GroupFields.AddRange(new GroupField[] { new GroupField("account_id", XRColumnSortOrder.Ascending) });
            this.xrlabel_2.DataBindings.Add("Text", base.DataSource, "account_id", "");
            this.xrtableCell_5.DataBindings.Add("Text", base.DataSource, "cr_amount", "{0:n0}");
            this.xrtableCell_0.DataBindings.Add("Text", base.DataSource, "voucher", "");
            this.xrtableCell_6.DataBindings.Add("Text", base.DataSource, "trans_num", "");
            this.xrtableCell_1.DataBindings.Add("Text", base.DataSource, "tran_date", "{0:dd/MM/yyyy}");
            this.xrtableCell_2.DataBindings.Add("Text", base.DataSource, "remark", "");
            this.xrtableCell_4.DataBindings.Add("Text", base.DataSource, "db_amount", "{0:n0}");
            this.xrtableCell_3.DataBindings.Add("Text", base.DataSource, "corr_acc", "");
            XRSummary summary = new XRSummary();
            this.xrtableCell_9.DataBindings.Add("Text", base.DataSource, "db_amount", "{0:n0}");
            summary.Running = SummaryRunning.Group;
            summary.FormatString = "{0:n0}";
            this.xrtableCell_9.Summary = summary;
            XRSummary summary2 = new XRSummary();
            this.xrtableCell_10.DataBindings.Add("Text", base.DataSource, "cr_amount", "{0:n0}");
            summary2.Running = SummaryRunning.Group;
            summary2.FormatString = "{0:n0}";
            this.xrtableCell_10.Summary = summary2;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void iWyIskLbe(object sender, PrintEventArgs e)
        {
        }

        private double method_0(string string_1)
        {
            this.string_0 = string.Concat(new object[] { "select sum(cr_amount) - sum(db_amount) as begamt from tblAccTrans where account_id = '", string_1, "'  and status = 1 and (tran_date between '", Class7.dateTimeFrom, "' and '", Class7.dateTimeTo, "') GROUP BY account_id" });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    return (Class7.smethod_2(set.Tables[0].Rows[0][0]) + this.method_1(string_1));
                }
                return this.method_1(string_1);
            }
        }

        private double method_1(string string_1)
        {
            this.string_0 = string.Concat(new object[] { "select sum(cr_amount) - sum(db_amount) as begamt from tblAccTrans where account_id = '", string_1, "' and tran_date < '", Class7.dateTimeFrom, "' and status = 1 GROUP BY account_id" });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    return Class7.smethod_2(set.Tables[0].Rows[0][0]);
                }
                return 0.0;
            }
        }

        private void method_2()
        {
            this.detailBand_0 = new DetailBand();
            this.IjSwogAv6 = new XRTable();
            this.xrtableRow_0 = new XRTableRow();
            this.xrtableCell_0 = new XRTableCell();
            this.xrtableCell_1 = new XRTableCell();
            this.xrtableCell_6 = new XRTableCell();
            this.xrtableCell_2 = new XRTableCell();
            this.xrtableCell_3 = new XRTableCell();
            this.xrtableCell_4 = new XRTableCell();
            this.xrtableCell_5 = new XRTableCell();
            this.pageHeaderBand_0 = new PageHeaderBand();
            this.xrline_0 = new XRLine();
            this.xrlabel_4 = new XRLabel();
            this.xrpageInfo_0 = new XRPageInfo();
            this.xrlabel_0 = new XRLabel();
            this.pageFooterBand_0 = new PageFooterBand();
            this.xrpageInfo_1 = new XRPageInfo();
            this.topMarginBand_0 = new TopMarginBand();
            this.bottomMarginBand_0 = new BottomMarginBand();
            this.groupHeaderBand_0 = new GroupHeaderBand();
            this.xrlabel_5 = new XRLabel();
            this.xrlabel_6 = new XRLabel();
            this.xrtable_1 = new XRTable();
            this.xrtableRow_3 = new XRTableRow();
            this.xrtableCell_16 = new XRTableCell();
            this.xrtableCell_17 = new XRTableCell();
            this.xrtableCell_18 = new XRTableCell();
            this.xrtableCell_19 = new XRTableCell();
            this.xrtableCell_20 = new XRTableCell();
            this.xrtableCell_21 = new XRTableCell();
            this.xrtableCell_22 = new XRTableCell();
            this.xrlabel_1 = new XRLabel();
            this.xrlabel_2 = new XRLabel();
            this.xrlabel_3 = new XRLabel();
            this.groupFooterBand_0 = new GroupFooterBand();
            this.xrtable_0 = new XRTable();
            this.xrtableRow_1 = new XRTableRow();
            this.xrtableCell_7 = new XRTableCell();
            this.xrtableCell_8 = new XRTableCell();
            this.xrtableCell_9 = new XRTableCell();
            this.xrtableCell_10 = new XRTableCell();
            this.xrtableRow_2 = new XRTableRow();
            this.xrtableCell_11 = new XRTableCell();
            this.xrtableCell_12 = new XRTableCell();
            this.xrtableCell_13 = new XRTableCell();
            this.xrtableCell_14 = new XRTableCell();
            this.xrtableCell_15 = new XRTableCell();
            this.IjSwogAv6.BeginInit();
            this.xrtable_1.BeginInit();
            this.xrtable_0.BeginInit();
            this.BeginInit();
            this.detailBand_0.Controls.AddRange(new XRControl[] { this.IjSwogAv6 });
            this.detailBand_0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.detailBand_0.HeightF = 25f;
            this.detailBand_0.Name = "Detail";
            this.detailBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.detailBand_0.StylePriority.UseFont = false;
            this.detailBand_0.TextAlignment = TextAlignment.TopLeft;
            this.IjSwogAv6.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.IjSwogAv6.LocationFloat = new PointFloat(1.5625f, 0f);
            this.IjSwogAv6.Name = "xrTable1";
            this.IjSwogAv6.Rows.AddRange(new XRTableRow[] { this.xrtableRow_0 });
            this.IjSwogAv6.SizeF = new SizeF(785.4375f, 25f);
            this.IjSwogAv6.StylePriority.UseFont = false;
            this.IjSwogAv6.StylePriority.UseTextAlignment = false;
            this.IjSwogAv6.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableRow_0.Cells.AddRange(new XRTableCell[] { this.xrtableCell_0, this.xrtableCell_1, this.xrtableCell_6, this.xrtableCell_2, this.xrtableCell_3, this.xrtableCell_4, this.xrtableCell_5 });
            this.xrtableRow_0.Name = "xrTableRow1";
            this.xrtableRow_0.Weight = 1.0;
            this.xrtableCell_0.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_0.Name = "colVoucher";
            this.xrtableCell_0.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_0.StylePriority.UseBorders = false;
            this.xrtableCell_0.StylePriority.UsePadding = false;
            this.xrtableCell_0.StylePriority.UseTextAlignment = false;
            this.xrtableCell_0.Text = "colVoucher";
            this.xrtableCell_0.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_0.Weight = 0.81150501246962559;
            this.xrtableCell_0.WordWrap = false;
            this.xrtableCell_1.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_1.Name = "colDate";
            this.xrtableCell_1.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_1.StylePriority.UseBorders = false;
            this.xrtableCell_1.StylePriority.UsePadding = false;
            this.xrtableCell_1.Text = "colDate";
            this.xrtableCell_1.Weight = 0.69162180392647521;
            this.xrtableCell_6.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_6.Name = "colTransNum";
            this.xrtableCell_6.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_6.StylePriority.UseBorders = false;
            this.xrtableCell_6.StylePriority.UsePadding = false;
            this.xrtableCell_6.Text = "colTransNum";
            this.xrtableCell_6.Weight = 0.93242173337283607;
            this.xrtableCell_2.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_2.Name = "colRemark";
            this.xrtableCell_2.Padding = new PaddingInfo(3, 0, 0, 0, 100f);
            this.xrtableCell_2.StylePriority.UseBorders = false;
            this.xrtableCell_2.StylePriority.UsePadding = false;
            this.xrtableCell_2.StylePriority.UseTextAlignment = false;
            this.xrtableCell_2.Text = "colRemark";
            this.xrtableCell_2.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_2.Weight = 2.5039875056813612;
            this.xrtableCell_2.WordWrap = false;
            this.xrtableCell_3.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_3.Name = "colCrAccount";
            this.xrtableCell_3.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_3.StylePriority.UseBorders = false;
            this.xrtableCell_3.StylePriority.UsePadding = false;
            this.xrtableCell_3.Text = "colCrAccount";
            this.xrtableCell_3.Weight = 0.68805428834343063;
            this.xrtableCell_3.WordWrap = false;
            this.xrtableCell_4.Borders = BorderSide.Bottom | BorderSide.Left;
            this.xrtableCell_4.Name = "colDebitAmt";
            this.xrtableCell_4.Padding = new PaddingInfo(0, 2, 0, 0, 100f);
            this.xrtableCell_4.StylePriority.UseBorders = false;
            this.xrtableCell_4.StylePriority.UsePadding = false;
            this.xrtableCell_4.StylePriority.UseTextAlignment = false;
            this.xrtableCell_4.Text = "colDebitAmt";
            this.xrtableCell_4.TextAlignment = TextAlignment.MiddleRight;
            this.xrtableCell_4.Weight = 0.74786009682869947;
            this.xrtableCell_4.WordWrap = false;
            this.xrtableCell_5.Borders = BorderSide.Bottom | BorderSide.Right | BorderSide.Left;
            this.xrtableCell_5.Name = "colCreditAmt";
            this.xrtableCell_5.Padding = new PaddingInfo(0, 5, 0, 0, 100f);
            this.xrtableCell_5.StylePriority.UseBorders = false;
            this.xrtableCell_5.StylePriority.UsePadding = false;
            this.xrtableCell_5.StylePriority.UseTextAlignment = false;
            this.xrtableCell_5.Text = "colCreditAmt";
            this.xrtableCell_5.TextAlignment = TextAlignment.MiddleRight;
            this.xrtableCell_5.Weight = 0.91321573874439244;
            this.pageHeaderBand_0.Controls.AddRange(new XRControl[] { this.xrline_0, this.xrlabel_4, this.xrpageInfo_0, this.xrlabel_0 });
            this.pageHeaderBand_0.HeightF = 26.87501f;
            this.pageHeaderBand_0.Name = "PageHeader";
            this.pageHeaderBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.pageHeaderBand_0.TextAlignment = TextAlignment.TopLeft;
            this.pageHeaderBand_0.BeforePrint += new PrintEventHandler(this.pageHeaderBand_0_BeforePrint);
            this.xrline_0.LocationFloat = new PointFloat(0f, 23.91669f);
            this.xrline_0.Name = "xrLine1";
            this.xrline_0.SizeF = new SizeF(785.375f, 2.958328f);
            this.xrlabel_4.Font = new Font("Arial", 9f, FontStyle.Italic, GraphicsUnit.Point, 0);
            this.xrlabel_4.ForeColor = Color.Black;
            this.xrlabel_4.LocationFloat = new PointFloat(0f, 4.000001f);
            this.xrlabel_4.Name = "Lbl_Interval";
            this.xrlabel_4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_4.SizeF = new SizeF(407.2917f, 16f);
            this.xrlabel_4.StylePriority.UseFont = false;
            this.xrlabel_4.StylePriority.UseForeColor = false;
            this.xrlabel_4.StylePriority.UseTextAlignment = false;
            this.xrlabel_4.Text = "Từ ng\x00e0y 01/01/2009 đến ng\x00e0y 12/12/2009";
            this.xrlabel_4.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_4.WordWrap = false;
            this.xrpageInfo_0.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrpageInfo_0.LocationFloat = new PointFloat(749f, 0f);
            this.xrpageInfo_0.Name = "xrPageInfo1";
            this.xrpageInfo_0.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrpageInfo_0.SizeF = new SizeF(36.125f, 23f);
            this.xrpageInfo_0.StylePriority.UseFont = false;
            this.xrpageInfo_0.StylePriority.UseTextAlignment = false;
            this.xrpageInfo_0.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_0.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrlabel_0.LocationFloat = new PointFloat(649f, 0f);
            this.xrlabel_0.Name = "xrLabel11";
            this.xrlabel_0.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_0.SizeF = new SizeF(100f, 23f);
            this.xrlabel_0.StylePriority.UseFont = false;
            this.xrlabel_0.StylePriority.UseTextAlignment = false;
            this.xrlabel_0.Text = "Trang số :";
            this.xrlabel_0.TextAlignment = TextAlignment.MiddleRight;
            this.pageFooterBand_0.Controls.AddRange(new XRControl[] { this.xrpageInfo_1 });
            this.pageFooterBand_0.HeightF = 23f;
            this.pageFooterBand_0.Name = "PageFooter";
            this.pageFooterBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.pageFooterBand_0.TextAlignment = TextAlignment.TopLeft;
            this.xrpageInfo_1.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrpageInfo_1.LocationFloat = new PointFloat(514.125f, 0f);
            this.xrpageInfo_1.Name = "xrPageInfo2";
            this.xrpageInfo_1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrpageInfo_1.PageInfo = PageInfo.DateTime;
            this.xrpageInfo_1.SizeF = new SizeF(271f, 23f);
            this.xrpageInfo_1.StylePriority.UseFont = false;
            this.xrpageInfo_1.StylePriority.UseTextAlignment = false;
            this.xrpageInfo_1.TextAlignment = TextAlignment.MiddleRight;
            this.topMarginBand_0.HeightF = 40f;
            this.topMarginBand_0.Name = "topMarginBand1";
            this.bottomMarginBand_0.HeightF = 40f;
            this.bottomMarginBand_0.Name = "bottomMarginBand1";
            this.groupHeaderBand_0.Controls.AddRange(new XRControl[] { this.xrlabel_5, this.xrlabel_6, this.xrtable_1, this.xrlabel_1, this.xrlabel_2, this.xrlabel_3 });
            this.groupHeaderBand_0.HeightF = 50f;
            this.groupHeaderBand_0.Name = "GroupHeader1";
            this.xrlabel_5.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_5.ForeColor = Color.RoyalBlue;
            this.xrlabel_5.LocationFloat = new PointFloat(667.4167f, 0f);
            this.xrlabel_5.Name = "Lbl_BeginAmt";
            this.xrlabel_5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_5.SizeF = new SizeF(119.5832f, 25f);
            this.xrlabel_5.StylePriority.UseFont = false;
            this.xrlabel_5.StylePriority.UseForeColor = false;
            this.xrlabel_5.StylePriority.UseTextAlignment = false;
            this.xrlabel_5.Text = "0";
            this.xrlabel_5.TextAlignment = TextAlignment.MiddleRight;
            this.xrlabel_5.WordWrap = false;
            this.xrlabel_5.BeforePrint += new PrintEventHandler(this.xrlabel_5_BeforePrint);
            this.xrlabel_6.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_6.LocationFloat = new PointFloat(569.8334f, 0f);
            this.xrlabel_6.Name = "xrLabel1";
            this.xrlabel_6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_6.SizeF = new SizeF(97.58331f, 25f);
            this.xrlabel_6.StylePriority.UseFont = false;
            this.xrlabel_6.StylePriority.UseTextAlignment = false;
            this.xrlabel_6.Text = "Số dư đầu kỳ :";
            this.xrlabel_6.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_6.WordWrap = false;
            this.xrtable_1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtable_1.LocationFloat = new PointFloat(0f, 25f);
            this.xrtable_1.Name = "xrTable2";
            this.xrtable_1.Rows.AddRange(new XRTableRow[] { this.xrtableRow_3 });
            this.xrtable_1.SizeF = new SizeF(787f, 25f);
            this.xrtable_1.StylePriority.UseFont = false;
            this.xrtable_1.StylePriority.UseTextAlignment = false;
            this.xrtable_1.TextAlignment = TextAlignment.MiddleCenter;
            this.xrtableRow_3.Cells.AddRange(new XRTableCell[] { this.xrtableCell_16, this.xrtableCell_17, this.xrtableCell_18, this.xrtableCell_19, this.xrtableCell_20, this.xrtableCell_21, this.xrtableCell_22 });
            this.xrtableRow_3.Name = "xrTableRow2";
            this.xrtableRow_3.Weight = 1.0;
            this.xrtableCell_16.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_16.Name = "xrTableCell7";
            this.xrtableCell_16.StylePriority.UseBorders = false;
            this.xrtableCell_16.Text = "Số chứng từ";
            this.xrtableCell_16.Weight = 0.82600466229448832;
            this.xrtableCell_17.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_17.Name = "xrTableCell8";
            this.xrtableCell_17.StylePriority.UseBorders = false;
            this.xrtableCell_17.Text = "Ng\x00e0y";
            this.xrtableCell_17.Weight = 0.691621910124823;
            this.xrtableCell_18.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_18.Name = "xrTableCell13";
            this.xrtableCell_18.StylePriority.UseBorders = false;
            this.xrtableCell_18.Text = "Số giao dịch";
            this.xrtableCell_18.Weight = 0.93242173337283629;
            this.xrtableCell_19.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_19.Name = "xrTableCell1";
            this.xrtableCell_19.StylePriority.UseBorders = false;
            this.xrtableCell_19.Text = "Diễn giải giao dịch";
            this.xrtableCell_19.Weight = 2.5039873640835637;
            this.xrtableCell_20.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_20.Name = "xrTableCell10";
            this.xrtableCell_20.StylePriority.UseBorders = false;
            this.xrtableCell_20.Text = "TK đối ứng";
            this.xrtableCell_20.Weight = 0.68805428834343063;
            this.xrtableCell_21.Borders = BorderSide.Bottom | BorderSide.Top | BorderSide.Left;
            this.xrtableCell_21.Name = "xrTableCell11";
            this.xrtableCell_21.StylePriority.UseBorders = false;
            this.xrtableCell_21.Text = "Ghi nợ";
            this.xrtableCell_21.Weight = 0.74786009682869925;
            this.xrtableCell_22.Borders = BorderSide.All;
            this.xrtableCell_22.Name = "xrTableCell12";
            this.xrtableCell_22.StylePriority.UseBorders = false;
            this.xrtableCell_22.Text = "Ghi c\x00f3";
            this.xrtableCell_22.Weight = 0.91321573874439266;
            this.xrlabel_1.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_1.ForeColor = Color.RoyalBlue;
            this.xrlabel_1.LocationFloat = new PointFloat(217.6562f, 0f);
            this.xrlabel_1.Name = "Lbl_AccountName";
            this.xrlabel_1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_1.SizeF = new SizeF(352.1772f, 25f);
            this.xrlabel_1.StylePriority.UseFont = false;
            this.xrlabel_1.StylePriority.UseForeColor = false;
            this.xrlabel_1.StylePriority.UseTextAlignment = false;
            this.xrlabel_1.Text = "123546513213";
            this.xrlabel_1.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_1.WordWrap = false;
            this.xrlabel_1.BeforePrint += new PrintEventHandler(this.xrlabel_1_BeforePrint);
            this.xrlabel_2.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_2.ForeColor = Color.RoyalBlue;
            this.xrlabel_2.LocationFloat = new PointFloat(114.3969f, 0f);
            this.xrlabel_2.Name = "Lbl_Account";
            this.xrlabel_2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_2.SizeF = new SizeF(102.2593f, 25f);
            this.xrlabel_2.StylePriority.UseFont = false;
            this.xrlabel_2.StylePriority.UseForeColor = false;
            this.xrlabel_2.StylePriority.UseTextAlignment = false;
            this.xrlabel_2.Text = "3331-1-0003";
            this.xrlabel_2.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_2.WordWrap = false;
            this.xrlabel_3.Font = new Font("Arial", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0xa3);
            this.xrlabel_3.ForeColor = Color.RoyalBlue;
            this.xrlabel_3.LocationFloat = new PointFloat(5.000003f, 0f);
            this.xrlabel_3.Name = "xrLabel2";
            this.xrlabel_3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_3.SizeF = new SizeF(108.5417f, 25f);
            this.xrlabel_3.StylePriority.UseFont = false;
            this.xrlabel_3.StylePriority.UseForeColor = false;
            this.xrlabel_3.StylePriority.UseTextAlignment = false;
            this.xrlabel_3.Text = "Số t\x00e0i khoản :";
            this.xrlabel_3.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_3.WordWrap = false;
            this.groupFooterBand_0.Controls.AddRange(new XRControl[] { this.xrtable_0 });
            this.groupFooterBand_0.HeightF = 50f;
            this.groupFooterBand_0.Name = "GroupFooter1";
            this.groupFooterBand_0.PageBreak = PageBreak.AfterBand;
            this.xrtable_0.LocationFloat = new PointFloat(6.103516E-05f, 0f);
            this.xrtable_0.Name = "xrTable3";
            this.xrtable_0.Rows.AddRange(new XRTableRow[] { this.xrtableRow_1, this.xrtableRow_2 });
            this.xrtable_0.SizeF = new SizeF(786.9999f, 50f);
            this.xrtableRow_1.Cells.AddRange(new XRTableCell[] { this.xrtableCell_7, this.xrtableCell_8, this.xrtableCell_9, this.xrtableCell_10 });
            this.xrtableRow_1.Name = "xrTableRow3";
            this.xrtableRow_1.Weight = 1.0;
            this.xrtableCell_7.Name = "xrTableCell3";
            this.xrtableCell_7.Weight = 1.1588311835563974;
            this.xrtableCell_8.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_8.Name = "xrTableCell2";
            this.xrtableCell_8.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_8.StylePriority.UseFont = false;
            this.xrtableCell_8.StylePriority.UsePadding = false;
            this.xrtableCell_8.StylePriority.UseTextAlignment = false;
            this.xrtableCell_8.Text = "Tổng cộng :";
            this.xrtableCell_8.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_8.Weight = 1.0794158632179445;
            this.xrtableCell_9.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_9.Name = "colSumDebit";
            this.xrtableCell_9.Padding = new PaddingInfo(0, 2, 0, 0, 100f);
            this.xrtableCell_9.StylePriority.UseFont = false;
            this.xrtableCell_9.StylePriority.UsePadding = false;
            this.xrtableCell_9.StylePriority.UseTextAlignment = false;
            this.xrtableCell_9.Text = "colSumDebit";
            this.xrtableCell_9.TextAlignment = TextAlignment.MiddleRight;
            this.xrtableCell_9.Weight = 0.38662202232537624;
            this.xrtableCell_10.Borders = BorderSide.None;
            this.xrtableCell_10.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_10.Name = "colSumCredit";
            this.xrtableCell_10.Padding = new PaddingInfo(0, 5, 0, 0, 100f);
            this.xrtableCell_10.StylePriority.UseBorders = false;
            this.xrtableCell_10.StylePriority.UseFont = false;
            this.xrtableCell_10.StylePriority.UsePadding = false;
            this.xrtableCell_10.StylePriority.UseTextAlignment = false;
            this.xrtableCell_10.Text = "colSumCredit";
            this.xrtableCell_10.TextAlignment = TextAlignment.MiddleRight;
            this.xrtableCell_10.Weight = 0.37513093090028188;
            this.xrtableRow_2.Cells.AddRange(new XRTableCell[] { this.xrtableCell_11, this.xrtableCell_12, this.xrtableCell_13, this.xrtableCell_14, this.xrtableCell_15 });
            this.xrtableRow_2.Name = "xrTableRow4";
            this.xrtableRow_2.Weight = 1.0;
            this.xrtableCell_11.Name = "xrTableCell4";
            this.xrtableCell_11.Weight = 1.1588311835563974;
            this.xrtableCell_12.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_12.Name = "xrTableCell15";
            this.xrtableCell_12.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_12.StylePriority.UseFont = false;
            this.xrtableCell_12.StylePriority.UsePadding = false;
            this.xrtableCell_12.StylePriority.UseTextAlignment = false;
            this.xrtableCell_12.Text = "Số dư cuối kỳ :";
            this.xrtableCell_12.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_12.Weight = 0.39374196441409426;
            this.xrtableCell_13.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrtableCell_13.Name = "colEndAmt";
            this.xrtableCell_13.Padding = new PaddingInfo(2, 0, 0, 0, 100f);
            this.xrtableCell_13.StylePriority.UseFont = false;
            this.xrtableCell_13.StylePriority.UsePadding = false;
            this.xrtableCell_13.StylePriority.UseTextAlignment = false;
            this.xrtableCell_13.Text = "colEndAmt";
            this.xrtableCell_13.TextAlignment = TextAlignment.MiddleLeft;
            this.xrtableCell_13.Weight = 0.7650892191423031;
            this.xrtableCell_13.BeforePrint += new PrintEventHandler(this.xrtableCell_13_BeforePrint);
            this.xrtableCell_14.Name = "xrTableCell6";
            this.xrtableCell_14.Weight = 0.30720670198692346;
            this.xrtableCell_15.Name = "xrTableCell9";
            this.xrtableCell_15.Weight = 0.37513093090028188;
            base.Bands.AddRange(new Band[] { this.detailBand_0, this.pageHeaderBand_0, this.pageFooterBand_0, this.topMarginBand_0, this.bottomMarginBand_0, this.groupHeaderBand_0, this.groupFooterBand_0 });
            base.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margins = new Margins(20, 20, 40, 40);
            base.PageHeight = 0x491;
            base.PageWidth = 0x33b;
            base.PaperKind = PaperKind.A4;
            base.SnapToGrid = false;
            base.Version = "9.3";
            this.BeforePrint += new PrintEventHandler(this.acc_info_BeforePrint);
            this.IjSwogAv6.EndInit();
            this.xrtable_1.EndInit();
            this.xrtable_0.EndInit();
            this.EndInit();
        }

        private void pageHeaderBand_0_BeforePrint(object sender, PrintEventArgs e)
        {
            string str = string.Format("{0:dd/MM/yyyy}", Class7.dateTimeFrom);
            string str2 = string.Format("{0:dd/MM/yyyy}", Class7.dateTimeTo);
            this.xrlabel_4.Text = (Class7.dateTimeFrom == Class7.dateTimeTo) ? ("Trong ng\x00e0y " + str) : ("Từ ng\x00e0y :" + str + " đến ng\x00e0y :" + str2);
        }

        private void xrlabel_1_BeforePrint(object sender, PrintEventArgs e)
        {
            string str = null;
            string str2 = this.xrlabel_2.Text.Replace("-", "");
            Class7.smethod_17("name", "tblAccount", "account_id", str2, "", this.oleDbConnection_0, ref str);
            this.xrlabel_1.Text = str;
        }

        private void xrlabel_5_BeforePrint(object sender, PrintEventArgs e)
        {
            string str = this.xrlabel_2.Text.Replace("-", "");
            if (this.method_1(str) < 0.0)
            {
                this.xrlabel_5.Text = "Nợ:  " + string.Format("{0:n0}", Math.Abs(this.method_1(str)));
            }
            else if (this.method_0(str) > 0.0)
            {
                this.xrlabel_5.Text = "C\x00f3:  " + string.Format("{0:n0}", Math.Abs(this.method_1(str)));
            }
            else if (this.method_1(str) == 0.0)
            {
                this.xrlabel_5.Text = "0";
            }
        }

        private void xrtableCell_13_BeforePrint(object sender, PrintEventArgs e)
        {
            string str = this.xrlabel_2.Text.Replace("-", "");
            if (this.method_0(str) < 0.0)
            {
                this.xrtableCell_13.Text = "Nợ:  " + string.Format("{0:n0}", Math.Abs(this.method_0(str)));
            }
            else if (this.method_0(str) > 0.0)
            {
                this.xrtableCell_13.Text = "C\x00f3:  " + string.Format("{0:n0}", Math.Abs(this.method_0(str)));
            }
            else if (this.method_0(str) == 0.0)
            {
                this.xrtableCell_13.Text = "0";
            }
        }
    }
}
