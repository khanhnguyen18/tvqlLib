using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace LibraryManagement.App
{   
    public class library_card : XtraReport
    {
        private BottomMarginBand bottomMarginBand_0;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private DataColumn dataColumn_5;
        public DataSet dataSet1;
        private DataTable dataTable_0;
        private DetailBand detailBand_0;
        private IContainer icontainer_0;
        private TopMarginBand topMarginBand_0;
        private XRBarCode xrbarCode_0;
        private XRLabel xrlabel_0;
        private XRLabel xrlabel_1;
        private XRLabel xrlabel_2;
        private XRLabel xrlabel_3;
        private XRLabel xrlabel_4;
        private XRLabel xrlabel_5;
        private XRLabel xrlabel_6;
        private XRLine xrline_0;
        private XRPanel xrpanel_0;
        private XRPictureBox xrpictureBox_0;

        static library_card()
        {
            Class15.smethod_5();
        }

        public library_card()
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

        private void method_0()
        {
            Code39ExtendedGenerator generator = new Code39ExtendedGenerator();
            this.detailBand_0 = new DetailBand();
            this.xrpanel_0 = new XRPanel();
            this.xrline_0 = new XRLine();
            this.xrlabel_6 = new XRLabel();
            this.xrlabel_0 = new XRLabel();
            this.xrpictureBox_0 = new XRPictureBox();
            this.xrlabel_2 = new XRLabel();
            this.xrlabel_1 = new XRLabel();
            this.xrbarCode_0 = new XRBarCode();
            this.xrlabel_3 = new XRLabel();
            this.xrlabel_4 = new XRLabel();
            this.xrlabel_5 = new XRLabel();
            this.topMarginBand_0 = new TopMarginBand();
            this.bottomMarginBand_0 = new BottomMarginBand();
            this.dataSet1 = new DataSet();
            this.dataTable_0 = new DataTable();
            this.dataColumn_0 = new DataColumn();
            this.dataColumn_1 = new DataColumn();
            this.dataColumn_2 = new DataColumn();
            this.dataColumn_3 = new DataColumn();
            this.dataColumn_4 = new DataColumn();
            this.dataColumn_5 = new DataColumn();
            this.dataSet1.BeginInit();
            this.dataTable_0.BeginInit();
            this.BeginInit();
            this.detailBand_0.Controls.AddRange(new XRControl[] { this.xrpanel_0 });
            this.detailBand_0.HeightF = 215f;
            this.detailBand_0.MultiColumn.ColumnCount = 2;
            //this.detailBand_0.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            this.detailBand_0.MultiColumn.Mode = MultiColumnMode.UseColumnCount;
            this.detailBand_0.Name = "Detail";
            this.detailBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.detailBand_0.TextAlignment = TextAlignment.TopLeft;
            this.xrpanel_0.BorderColor = SystemColors.ControlDarkDark;
            this.xrpanel_0.Borders = BorderSide.All;
            this.xrpanel_0.Controls.AddRange(new XRControl[] { this.xrline_0, this.xrlabel_6, this.xrlabel_0, this.xrpictureBox_0, this.xrlabel_2, this.xrlabel_1, this.xrbarCode_0, this.xrlabel_3, this.xrlabel_4, this.xrlabel_5 });
            this.xrpanel_0.LocationFloat = new PointFloat(5.999994f, 5f);
            this.xrpanel_0.Name = "xrPanel1";
            this.xrpanel_0.SizeF = new SizeF(388.0417f, 203.125f);
            this.xrpanel_0.StylePriority.UseBorderColor = false;
            this.xrpanel_0.StylePriority.UseBorders = false;
            this.xrline_0.Borders = BorderSide.None;
            this.xrline_0.ForeColor = SystemColors.Desktop;
            this.xrline_0.LocationFloat = new PointFloat(2.000006f, 42.20833f);
            this.xrline_0.Name = "xrLine1";
            this.xrline_0.SizeF = new SizeF(384.0417f, 5f);
            this.xrline_0.StylePriority.UseBorders = false;
            this.xrline_0.StylePriority.UseForeColor = false;
            this.xrlabel_6.Borders = BorderSide.None;
            this.xrlabel_6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrlabel_6.LocationFloat = new PointFloat(5.000014f, 25.125f);
            this.xrlabel_6.Name = "xrLabel7";
            this.xrlabel_6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_6.SizeF = new SizeF(376.9166f, 19f);
            this.xrlabel_6.StylePriority.UseBorders = false;
            this.xrlabel_6.StylePriority.UseFont = false;
            this.xrlabel_6.StylePriority.UseTextAlignment = false;
            this.xrlabel_6.Text = "Điện thoại : 0904843991";
            this.xrlabel_6.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_0.Borders = BorderSide.None;
            this.xrlabel_0.Font = new Font("Times New Roman", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrlabel_0.ForeColor = SystemColors.Desktop;
            this.xrlabel_0.LocationFloat = new PointFloat(2.000004f, 5f);
            this.xrlabel_0.Name = "xrLabel1";
            this.xrlabel_0.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_0.SizeF = new SizeF(384.0417f, 20.125f);
            this.xrlabel_0.StylePriority.UseBorders = false;
            this.xrlabel_0.StylePriority.UseFont = false;
            this.xrlabel_0.StylePriority.UseForeColor = false;
            this.xrlabel_0.StylePriority.UseTextAlignment = false;
            this.xrlabel_0.Text = "Phần mềm quản l\x00fd thư viện";
            this.xrlabel_0.TextAlignment = TextAlignment.MiddleCenter;
            this.xrpictureBox_0.Borders = BorderSide.None;
            this.xrpictureBox_0.DataBindings.AddRange(new XRBinding[] { new XRBinding("Image", null, "CardPrint.image") });
            this.xrpictureBox_0.LocationFloat = new PointFloat(276.9167f, 54.125f);
            this.xrpictureBox_0.Name = "xrPictureBox1";
            this.xrpictureBox_0.SizeF = new SizeF(100f, 115.875f);
            this.xrpictureBox_0.Sizing = ImageSizeMode.ZoomImage;
            this.xrpictureBox_0.StylePriority.UseBorders = false;
            this.xrlabel_2.Borders = BorderSide.None;
            this.xrlabel_2.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "CardPrint.fullname") });
            this.xrlabel_2.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrlabel_2.LocationFloat = new PointFloat(24.00001f, 48.125f);
            this.xrlabel_2.Name = "xrLabel2";
            this.xrlabel_2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_2.SizeF = new SizeF(252.9166f, 26.125f);
            this.xrlabel_2.StylePriority.UseBorders = false;
            this.xrlabel_2.StylePriority.UseFont = false;
            this.xrlabel_2.StylePriority.UseTextAlignment = false;
            this.xrlabel_2.Text = "xrLabel2";
            this.xrlabel_2.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_2.WordWrap = false;
            this.xrlabel_2.BeforePrint += new PrintEventHandler(this.xrlabel_2_BeforePrint);
            this.xrlabel_1.Borders = BorderSide.None;
            this.xrlabel_1.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "CardPrint.open_date", "{0:dd/MM/yyyy}") });
            this.xrlabel_1.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrlabel_1.LocationFloat = new PointFloat(157.0833f, 85.37502f);
            this.xrlabel_1.Name = "xrLabel3";
            this.xrlabel_1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_1.SizeF = new SizeF(102.375f, 23f);
            this.xrlabel_1.StylePriority.UseBorders = false;
            this.xrlabel_1.StylePriority.UseFont = false;
            this.xrlabel_1.StylePriority.UseTextAlignment = false;
            this.xrlabel_1.Text = "xrLabel3";
            this.xrlabel_1.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_1.WordWrap = false;
            this.xrbarCode_0.AutoModule = true;
            this.xrbarCode_0.Borders = BorderSide.None;
            this.xrbarCode_0.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, "CardPrint.card_id") });
            this.xrbarCode_0.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrbarCode_0.LocationFloat = new PointFloat(24.00001f, 149.25f);
            this.xrbarCode_0.Name = "xrBarCode1";
            this.xrbarCode_0.Padding = new PaddingInfo(10, 10, 0, 0, 100f);
            this.xrbarCode_0.SizeF = new SizeF(239.4583f, 42.74999f);
            this.xrbarCode_0.StylePriority.UseBorders = false;
            this.xrbarCode_0.StylePriority.UseFont = false;
            this.xrbarCode_0.StylePriority.UseTextAlignment = false;
            generator.WideNarrowRatio = 3f;
            this.xrbarCode_0.Symbology = generator;
            this.xrbarCode_0.Text = "xrBarCode1";
            this.xrbarCode_0.TextAlignment = TextAlignment.MiddleCenter;
            this.xrlabel_3.Borders = BorderSide.None;
            this.xrlabel_3.Font = new Font("Times New Roman", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrlabel_3.LocationFloat = new PointFloat(157.0833f, 111.5f);
            this.xrlabel_3.Name = "xrLabel4";
            this.xrlabel_3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_3.SizeF = new SizeF(102.375f, 23f);
            this.xrlabel_3.StylePriority.UseBorders = false;
            this.xrlabel_3.StylePriority.UseFont = false;
            this.xrlabel_3.StylePriority.UseTextAlignment = false;
            this.xrlabel_3.Text = "[due_date!dd/MM/yyyy]";
            this.xrlabel_3.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_3.WordWrap = false;
            this.xrlabel_4.Borders = BorderSide.None;
            this.xrlabel_4.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrlabel_4.LocationFloat = new PointFloat(56.00002f, 85.37502f);
            this.xrlabel_4.Name = "xrLabel5";
            this.xrlabel_4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_4.SizeF = new SizeF(100f, 23f);
            this.xrlabel_4.StylePriority.UseBorders = false;
            this.xrlabel_4.StylePriority.UseFont = false;
            this.xrlabel_4.StylePriority.UseTextAlignment = false;
            this.xrlabel_4.Text = "Ng\x00e0y cấp";
            this.xrlabel_4.TextAlignment = TextAlignment.MiddleLeft;
            this.xrlabel_5.Borders = BorderSide.None;
            this.xrlabel_5.Font = new Font("Arial", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrlabel_5.LocationFloat = new PointFloat(56.00002f, 111.5f);
            this.xrlabel_5.Name = "xrLabel6";
            this.xrlabel_5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrlabel_5.SizeF = new SizeF(100f, 23f);
            this.xrlabel_5.StylePriority.UseBorders = false;
            this.xrlabel_5.StylePriority.UseFont = false;
            this.xrlabel_5.StylePriority.UseTextAlignment = false;
            this.xrlabel_5.Text = "Ng\x00e0y hết hạn";
            this.xrlabel_5.TextAlignment = TextAlignment.MiddleLeft;
            this.topMarginBand_0.HeightF = 18f;
            this.topMarginBand_0.Name = "TopMargin";
            this.topMarginBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.topMarginBand_0.TextAlignment = TextAlignment.TopLeft;
            this.bottomMarginBand_0.HeightF = 21f;
            this.bottomMarginBand_0.Name = "BottomMargin";
            this.bottomMarginBand_0.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.bottomMarginBand_0.TextAlignment = TextAlignment.TopLeft;
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new DataTable[] { this.dataTable_0 });
            this.dataTable_0.Columns.AddRange(new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4, this.dataColumn_5 });
            this.dataTable_0.Constraints.AddRange(new Constraint[] { new UniqueConstraint("Constraint1", new string[] { "card_id" }, false) });
            this.dataTable_0.TableName = "CardPrint";
            this.dataColumn_0.ColumnName = "idx";
            this.dataColumn_0.DataType = typeof(short);
            this.dataColumn_1.ColumnName = "card_id";
            this.dataColumn_2.ColumnName = "fullname";
            this.dataColumn_3.ColumnName = "image";
            this.dataColumn_3.DataType = typeof(byte[]);
            this.dataColumn_4.ColumnName = "open_date";
            this.dataColumn_4.DataType = typeof(DateTime);
            this.dataColumn_5.ColumnName = "due_date";
            this.dataColumn_5.DataType = typeof(DateTime);
            base.Bands.AddRange(new Band[] { this.detailBand_0, this.topMarginBand_0, this.bottomMarginBand_0 });
            base.DataMember = "CardPrint";
            base.DataSource = this.dataSet1;
            base.Margins = new Margins(0x13, 0x19, 0x12, 0x15);
            base.SnapToGrid = false;
            base.Version = "10.2";
            this.dataSet1.EndInit();
            this.dataTable_0.EndInit();
            this.EndInit();
        }

        private void xrlabel_2_BeforePrint(object sender, PrintEventArgs e)
        {
            this.xrlabel_2.Text = this.xrlabel_2.Text.ToUpper();
        }
    }
}

