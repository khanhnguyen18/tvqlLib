using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmReaderList : DevExpress.XtraEditors.XtraForm
    {
        public FrmReaderList()
        {
            InitializeComponent();
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            this.printableComponentLink_0.Landscape = true;
            this.printableComponentLink_0.Margins.Left = 20;
            this.printableComponentLink_0.Margins.Right = 20;
            this.printableComponentLink_0.Margins.Bottom = 40;
            this.printableComponentLink_0.Margins.Top = 40;
            this.printableComponentLink_0.CreateDocument();
            this.printableComponentLink_0.ShowPreview();
        }


        private void FrmReaderList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }


        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch thẻ thư viện";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }

        private void RrqIxZxw5(object sender, EventArgs e)
        {
            //TODO
            //this.tblCustomerTableAdapter_0.SqlConnection_0.ConnectionString = Class7.string_6;
            //this.tblCustomerTableAdapter_0.Fill(this.library_dataDataSet_0.tblCustomer);
            this.Text = "Danh s\x00e1ch thẻ thư viện";
            this.gridView1.BestFitColumns();
        }
   
    }
}