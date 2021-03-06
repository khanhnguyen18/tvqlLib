using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using LibraryManagement.Service;

namespace LibraryManagement.App
{
    public partial class BookListForm : DevExpress.XtraEditors.XtraForm
    {
        public BookListForm()
        {
            InitializeComponent();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
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

        private void FrmBookList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh mục s\x00e1ch trong thư viện";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }


        private void FrmBookList_Load(object sender, EventArgs e)
        {
            //this.booksTableAdapter_0.SqlConnection_0.ConnectionString = Class7.string_6;
            this.Text = "Danh mục s\x00e1ch trong thư viện";

            GoodsService goodsSer = new GoodsService();
            this.gridControl1.DataSource = goodsSer.GetListBook().Tables[0];

            this.gridView1.BestFitColumns();
        }

    }
}