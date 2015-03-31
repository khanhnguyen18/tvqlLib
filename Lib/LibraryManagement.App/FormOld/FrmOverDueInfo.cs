using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
    public partial class FrmOverDueInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmOverDueInfo()
        {
            InitializeComponent();
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


        private void FrmOverDueInfo_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmOverDueInfo_Load(object sender, EventArgs e)
        {
            this.method_0();
        }


        private void method_0()
        {
            this.string_0 = "SELECT tr.trans_num, tr.cs_id, cs.fullname, tr.goods_id, gs.full_name, pr.rtprice, tr.due_date, cs.phone FROM tblLoanTran AS tr INNER JOIN tblCustomer AS cs ON tr.cs_id = cs.id INNER JOIN tblGoods AS gs ON tr.goods_id = gs.goods_id INNER JOIN tblPrice AS pr ON gs.goods_id = pr.goods_id AND tr.goods_id = pr.goods_id WHERE tr.status = 1 AND tr.trans_code = '60' AND tr.due_date < '" + Class7.smethod_19() + "' AND tr.corr_tran = '' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set, "overdue");
                this.oleDbConnection_0.Close();
                this.dataSet_0.Merge(set.Tables[0]);
            }
            for (int i = 0; i < this.dataSet_0.Tables["overdue"].Rows.Count; i++)
            {
                DateTime time = (DateTime)this.dataSet_0.Tables["overdue"].Rows[i]["due_date"];
                DateTime time2 = DateTime.Parse(Class7.smethod_19());
                long num2 = Class7.smethod_41((Class7.Enum0)3, time, time2);
                this.dataSet_0.Tables["overdue"].Rows[i]["overday"] = num2;
            }
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.BestFitColumns();
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch qu\x00e1 hạn trả s\x00e1ch";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, BorderSide.None);
        }
   
    }
}