using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    public partial class FrmBookView : XtraForm
    {
        public FrmBookView()
        {
            InitializeComponent();
            this.oleDbConnection_0 = DataProvider.GetConnection();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
        }


        private void FrmBookView_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmBookView_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmBookView_Load(object sender, EventArgs e)
        {
            //this.kCnalMegv.SqlConnection_0.ConnectionString = Class7.string_6;
            //this.kCnalMegv.Fill(this.library_dataDataSet_0.tblGoods);
            this.Text = "Tra cứu danh mục s\x00e1ch";
            this.method_0();
        }



        private void method_0()
        {
        }
    }
}