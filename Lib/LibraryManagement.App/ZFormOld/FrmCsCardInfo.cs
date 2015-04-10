using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmCsCardInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmCsCardInfo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FrmCsCardInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Th\x00f4ng tin thẻ kh\x00e1ch h\x00e0ng";
            this.string_0 = "SELECT crd.card_id AS [M\x00e3 thẻ], crd.fullname AS [T\x00ean kh\x00e1ch h\x00e0ng],crd.disc_pc AS [% CK], crd.begmark AS [Điểm đầu], crd.endmark AS [Điểm cuối], MAX(tr.tran_date) AS [Ng\x00e0y GD cuối], crd.status AS [Hiệu lực], SUM(tr.amount) AS [Tổng mua] FROM  tblCsCard AS crd LEFT JOIN tblTransaction AS tr ON crd.card_id = tr.card_id GROUP BY  crd.card_id, crd.fullname, crd.disc_pc, crd.begmark, crd.endmark, crd.status";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
            this.gridView1.Columns["Tổng mua"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Tổng mua"].DisplayFormat.FormatString = "n0";
            this.gridView1.Columns["% CK"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["% CK"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["Ng\x00e0y GD cuối"].DisplayFormat.FormatType = FormatType.DateTime;
            this.gridView1.Columns["Ng\x00e0y GD cuối"].DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridView1.BestFitColumns();
        }

    }
}