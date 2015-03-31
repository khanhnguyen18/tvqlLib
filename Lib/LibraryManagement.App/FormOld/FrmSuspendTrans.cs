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
    public partial class FrmSuspendTrans : DevExpress.XtraEditors.XtraForm
    {
        public FrmSuspendTrans()
        {
            InitializeComponent();
        }





        private void iWyIskLbe(object sender, EventArgs e)
        {
            this.method_0();
        }

        private void method_0()
        {
            this.string_0 = "SELECT sp.trans_num AS [Số giao dịch], sp.goods_id AS [M\x00e3 h\x00e0ng], sp.Name AS [T\x00ean h\x00e0ng], sp.qty AS SL, sp.unit AS ĐVT, sp.price AS [Gi\x00e1 b\x00e1n], sp.user_id AS [NV], us.name AS [NV thu ng\x00e2n]  FROM  tblSuspend AS sp INNER JOIN  tblUser AS us ON sp.user_id = us.ID ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.BestFitColumns();
            this.gridView1.Columns["Gi\x00e1 b\x00e1n"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Gi\x00e1 b\x00e1n"].DisplayFormat.FormatString = "{0:n0}";
            this.gridView1.Columns["SL"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["SL"].DisplayFormat.FormatString = "{0:n0}";
        }
  
    }
}