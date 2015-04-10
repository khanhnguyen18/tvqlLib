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
    public partial class FrmSTK_GL : DevExpress.XtraEditors.XtraForm
    {
        public FrmSTK_GL()
        {
            InitializeComponent();
        }



        private void FrmSTK_GL_Load(object sender, EventArgs e)
        {
            Class9.RrqIxZxw5("WHERE type IN('01','02')");
            this.string_0 = "SELECT * FROM STK_GL ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
        }

 

    }
}