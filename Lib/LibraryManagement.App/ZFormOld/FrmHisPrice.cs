using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class FrmHisPrice : XtraForm
    {
        public FrmHisPrice()
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


        private void FrmHisPrice_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmHisPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.P))
            {
                this.btnPrint_Click(this, new EventArgs());
            }
        }

        private void FrmHisPrice_Load(object sender, EventArgs e)
        {
            this.Text = "Nhật k\x00fd thay đổi gi\x00e1 b\x00e1n";
            this.string_0 = string.Concat(new object[] { "SELECT hspr.Hisdate AS Ng\x00e0y, hspr.Histime AS Giờ, hspr.goods_id AS [M\x00e3 h\x00e0ng], tblGoods.full_name AS [T\x00ean h\x00e0ng], hspr.oldrtprice AS [Gi\x00e1 b\x00e1n cũ], hspr.newrtprice AS [Gi\x00e1 b\x00e1n mới], hspr.user_id AS [M\x00e3 NV], us.name AS [T\x00ean nh\x00e2n vi\x00ean] FROM  ((tblHisprice AS hspr INNER JOIN tblUser AS us ON hspr.user_id = us.ID) INNER JOIN tblGoods ON hspr.goods_id = tblGoods.goods_id)  WHERE hspr.Hisdate BETWEEN '", Class7.dateTimeFrom, "' AND '", Class7.dateTimeTo, "'  ORDER BY hspr.Hisdate, hspr.Histime" });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
            this.gridView1.BestFitColumns();
            this.gridView1.Columns["Gi\x00e1 b\x00e1n cũ"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Gi\x00e1 b\x00e1n cũ"].DisplayFormat.FormatString = "{0:n0}";
            this.gridView1.Columns["Gi\x00e1 b\x00e1n mới"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Gi\x00e1 b\x00e1n mới"].DisplayFormat.FormatString = "{0:n0}";
            this.gridView1.Columns["Ng\x00e0y"].DisplayFormat.FormatType = FormatType.DateTime;
            this.gridView1.Columns["Ng\x00e0y"].DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
        }


        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "NHẬT K\x00dd THAY ĐỔI GI\x00c1";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Regular);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, BorderSide.None);
        }

        private void printingSystem_0_EndPrint(object sender, EventArgs e)
        {
            this.printingSystem_0.PreviewFormEx.Close();
        }
    }
}