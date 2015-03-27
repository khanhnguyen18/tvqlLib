using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting;
using DevExpress.Utils;

namespace LibraryManagement.App
{
    public partial class FrmAcountList : DevExpress.XtraEditors.XtraForm
    {
        public static string _accdetail;
        private string string_0;

        public FrmAcountList()
        {
            this.oleDbConnection_0 = new OleDbConnection(Class7.string_5);
            this.InitializeComponent();
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            new FrmAccountInfo().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
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
        private void FrmAcountList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmAcountList_FormClosing(object sender, FormClosingEventArgs e)
        {
            _accdetail = string.Empty;
        }

        private void FrmAcountList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.P))
            {
                this.btnPrint_Click(this, new EventArgs());
            }
        }

        private void FrmAcountList_Load(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                _accdetail = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Số t\x00e0i khoản").ToString();
            }
            catch (Exception)
            {
            }
        }

        private void method_0()
        {
            this.string_0 = "SELECT account_id AS [Số t\x00e0i khoản], abbreviat AS [T\x00ean viết tắt], mof_gl AS [Cấp 3], name AS [T\x00ean t\x00e0i khoản], open_date AS [Ng\x00e0y tạo], creamt AS [Ph\x00e1t sinh c\x00f3], debamt AS [Ph\x00e1t sinh nợ], last_date AS [Ng\x00e0y GD cuối], status AS [T.th\x00e1i]  FROM  tblAccount ORDER BY account_id";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
            this.gridView1.Columns["Ph\x00e1t sinh c\x00f3"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Ph\x00e1t sinh c\x00f3"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Ph\x00e1t sinh nợ"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Ph\x00e1t sinh nợ"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Ng\x00e0y GD cuối"].DisplayFormat.FormatType = FormatType.DateTime;
            this.gridView1.Columns["Ng\x00e0y GD cuối"].DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.gridView1.Columns["Số t\x00e0i khoản"].DisplayFormat.FormatType = FormatType.Custom;
            this.gridView1.Columns["Số t\x00e0i khoản"].DisplayFormat.FormatString = "{0:####-#-####}";
            this.gridView1.BestFitColumns();
        }

        private void pfeZyQnoF(object sender, EventArgs e)
        {
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch t\x00e0i khoản";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, BorderSide.None);
        }


    }
}