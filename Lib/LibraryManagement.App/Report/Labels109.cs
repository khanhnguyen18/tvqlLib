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
    public class Labels109 : XtraReport
    {
        private BottomMarginBand bottomMarginBand_0;
        private DetailBand detailBand_0;
        private IContainer icontainer_0;
        private TopMarginBand topMarginBand_0;
        private XRBarCode xrbarCode_0;
        private XRLabel xrlabel_0;

        static Labels109()
        {
            Class15.smethod_5();
        }

        public Labels109()
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

        private void Labels109_BeforePrint(object sender, PrintEventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Pos_id ,goods_id,shortname,fullname,grp_id,supp_id,rtprice,remark ,user_id ,timeinput FROM tblLabelPrn where user_id = " + Class7.GetUserId() + " Order By timeinput ", Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            base.DataAdapter = adapter;
            base.DataSource = dataSet.Tables[0];
            this.xrlabel_0.DataBindings.Add("Text", base.DataSource, "rtprice", "{0:n0}");
            this.xrbarCode_0.DataBindings.Add("Text", base.DataSource, "goods_id", "");
        }

        private void method_0()
        {
            Code128Generator generator = new Code128Generator();
            this.detailBand_0 = new DetailBand();
            this.xrbarCode_0 = new XRBarCode();
            this.xrlabel_0 = new XRLabel();
            this.bottomMarginBand_0 = new BottomMarginBand();
            this.topMarginBand_0 = new TopMarginBand();
            this.BeginInit();
            this.detailBand_0.Controls.AddRange(new XRControl[] { this.xrlabel_0, this.xrbarCode_0 });
            this.detailBand_0.Dpi = 254f;
            this.detailBand_0.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.detailBand_0.Height = 0x8a;
            this.detailBand_0.MultiColumn.ColumnCount = 5;
            this.detailBand_0.MultiColumn.ColumnSpacing = 20f;
            this.detailBand_0.MultiColumn.ColumnWidth = 370f;
            this.detailBand_0.MultiColumn.Direction = ColumnDirection.AcrossThenDown;
            this.detailBand_0.MultiColumn.Mode = MultiColumnMode.UseColumnWidth;
            this.detailBand_0.Name = "Detail";
            this.detailBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
            this.detailBand_0.RepeatCountOnEmptyDataSource = 0x37;
            this.detailBand_0.StylePriority.UseBorderWidth = false;
            this.detailBand_0.StylePriority.UseFont = false;
            this.detailBand_0.TextAlignment = TextAlignment.TopLeft;
            this.xrbarCode_0.Alignment = TextAlignment.MiddleCenter;
            this.xrbarCode_0.AutoModule = true;
            this.xrbarCode_0.Dpi = 254f;
            this.xrbarCode_0.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrbarCode_0.Location = new Point(3, 0x18);
            this.xrbarCode_0.Module = 208f;
            this.xrbarCode_0.Name = "xrBarCode1";
            this.xrbarCode_0.Padding = new PaddingInfo(5, 0, 0, 0, 254f);
            this.xrbarCode_0.Size = new Size(0x151, 0x56);
            this.xrbarCode_0.StylePriority.UseBorderColor = false;
            this.xrbarCode_0.StylePriority.UseFont = false;
            this.xrbarCode_0.StylePriority.UsePadding = false;
            this.xrbarCode_0.StylePriority.UseTextAlignment = false;
            this.xrbarCode_0.Symbology = generator;
            this.xrbarCode_0.Text = "000003";
            this.xrbarCode_0.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_0.Dpi = 254f;
            this.xrlabel_0.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrlabel_0.Location = new Point(0x95, 0x47);
            this.xrlabel_0.Name = "Txt_Price";
            this.xrlabel_0.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
            this.xrlabel_0.Size = new Size(0xbc, 0x22);
            this.xrlabel_0.StylePriority.UseFont = false;
            this.xrlabel_0.StylePriority.UseTextAlignment = false;
            this.xrlabel_0.Text = "Txt_Price";
            this.xrlabel_0.TextAlignment = TextAlignment.MiddleRight;
            this.xrlabel_0.WordWrap = false;
            this.bottomMarginBand_0.Dpi = 254f;
            this.bottomMarginBand_0.Height = 0x530;
            this.bottomMarginBand_0.Name = "BottomMargin";
            this.topMarginBand_0.Dpi = 254f;
            this.topMarginBand_0.Height = 30;
            this.topMarginBand_0.Name = "TopMargin";
            base.Bands.AddRange(new Band[] { this.detailBand_0, this.bottomMarginBand_0, this.topMarginBand_0 });
            base.DataMember = "tblLabelPrn";
            this.Dpi = 254f;
            base.GridSize = new Size(7, 7);
            base.Margins = new Margins(0x54, 0x4f, 30, 0x530);
            base.PageHeight = 0xb99;
            base.PageWidth = 0x835;
            base.PaperKind = PaperKind.A4;
            base.PaperName = "Tom109";
            base.ReportUnit = ReportUnit.TenthsOfAMillimeter;
            base.SnapToGrid = false;
            base.Version = "9.1";
            this.BeforePrint += new PrintEventHandler(this.Labels109_BeforePrint);
            this.EndInit();
        }
    }
}
