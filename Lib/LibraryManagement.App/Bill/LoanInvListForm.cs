using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
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
    public partial class FrmLoanInvList : XtraForm
    {
        public FrmLoanInvList()
        {
            InitializeComponent();

            this.oleDbConnection_0 = DataProvider.GetConnection();

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

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            Class6.transNum = this.lblTransNum.Text;
            string text = this.lblTransCode.Text;
            if (text != null)
            {
                if (!(text == "60"))
                {
                    if (text == "61")
                    {
                        new return_book().ShowPreviewDialog();
                    }
                }
                else
                {
                    new loan_inv().ShowPreviewDialog();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                this.Query();
            }
        }


        private void FrmLoanInvList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.lblTransNum.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "trans_num").ToString();
                this.lblTranDate.Text = string.Format("{0:dd/MM/yyyy}", this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "tran_date"));
                this.lblCsId.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "cs_id").ToString();
                this.lblTransCode.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "trans_code").ToString();
                this.lblLibraryId.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "exp_id").ToString();
                this.lblUserName.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "user_name").ToString();
                this.lblCsName.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "fullname").ToString();
                string text = this.lblTransCode.Text;
                if (text != null)
                {
                    if (!(text == "60"))
                    {
                        if (text == "61")
                        {
                            this.lblTransName.Text = "Phiếu trả s\x00e1ch";
                        }
                    }
                    else
                    {
                        this.lblTransName.Text = "Phiếu mượn s\x00e1ch";
                    }
                }
                this.lblLibraryName.Text = Class7.smethod_29("tblStore", "fullname", "id", this.lblLibraryId.Text, "", this.oleDbConnection_0).ToString();
            }
            catch (Exception)
            {
            }
        }



        private void iWyIskLbe(object sender, EventArgs e)
        {
            this.Text = "Danh s\x00e1ch phiếu mượn, trả s\x00e1ch";
            this.Query();
        }

        private void lblTransNum_TextChanged(object sender, EventArgs e)
        {
            this.queryString = "select tr.goods_id, gs.full_name, tr.due_date from tblLoantran AS tr INNER JOIN tblGoods AS gs ON tr.goods_id = gs.goods_id WHERE tr.trans_num = '" + this.lblTransNum.Text + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.queryString, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set, "loandetail");
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    this.dataSet_0.Tables["loandetail"].Rows.Clear();
                    this.dataSet_0.Merge(set.Tables[0]);
                    this.gridControl2.Refresh();
                }
            }
        }

        private void Query()
        {
            WaitDialogForm form = new WaitDialogForm();
            form.Caption = "Xin đợi một ch\x00fat";
            this.dataSet_0.Tables["loantran"].Rows.Clear();
            this.queryString = string.Concat(new object[] { "SELECT DISTINCT tr.trans_num, tr.tran_date, tr.trans_code,tr.exp_id, tr.tran_time, tr.cs_id, tr.user_id, tr.remark,  cs.fullname, cs.phone, us.name AS user_name FROM tblLoanTran AS tr INNER JOIN tblGoods AS gs ON tr.goods_id = gs.goods_id INNER JOIN tblCustomer AS cs ON tr.cs_id = cs.id INNER JOIN tblUser AS us ON tr.user_id = us.id WHERE tr.tran_date BETWEEN '", Class7.dateTimeFrom, "' AND '", Class7.dateTimeTo, "' GROUP BY tr.trans_num, tr.tran_date, tr.trans_code,tr.exp_id, tr.tran_time, tr.cs_id, tr.user_id, tr.remark,  cs.fullname, cs.phone , us.name " });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.queryString, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set, "loantran");
                this.oleDbConnection_0.Close();
                this.dataSet_0.Merge(set.Tables[0]);
            }
            this.gridControl1.Refresh();
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.BestFitColumns();
            this.Lbl_duaration.Text = "Từ ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTimeFrom) + " đến ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTimeTo);
            form.Close();
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch phiếu mượn, trả s\x00e1ch";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }

    }
}