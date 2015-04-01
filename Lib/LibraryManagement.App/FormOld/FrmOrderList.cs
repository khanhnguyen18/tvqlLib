using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
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
    public partial class FrmOrderList : DevExpress.XtraEditors.XtraForm
    {
        public FrmOrderList()
        {
            InitializeComponent();
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Class6.transNum = this.Lbl_TransNum.Text;
            if (!string.IsNullOrEmpty(Class6.transNum) && (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a đơn h\x00e0ng n\x00e0y kh\x00f4ng ?", 2) == 1))
            {
                this.string_0 = "UPDATE " + base.Tag.ToString() + " set status = 0 where trans_num = '" + Class6.transNum + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.method_0();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.printableComponentLink_0.Landscape = true;
            this.printableComponentLink_0.Margins.Left = 50;
            this.printableComponentLink_0.Margins.Right = 50;
            this.printableComponentLink_0.Margins.Bottom = 80;
            this.printableComponentLink_0.Margins.Top = 80;
            this.printableComponentLink_0.CreateDocument();
            this.printableComponentLink_0.ShowPreview();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            Class6.transNum = this.Lbl_TransNum.Text;
            if (!string.IsNullOrEmpty(Class6.transNum))
            {
            }
        }

        private void FrmOrderList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmOrderList_Load(object sender, EventArgs e)
        {
            this.Text = "Danh s\x00e1ch đơn đặt h\x00e0ng";
            base.Tag = "tblOn_order";
            this.method_0();
            this.method_1();
            this.btn_Delete.Enabled = Class7.smethod_50();
        }

        private void GrdTransList_Click(object sender, EventArgs e)
        {
        }



        private void Lbl_TransNum_TextChanged(object sender, EventArgs e)
        {
        }

        private void method_0()
        {
            this.string_0 = string.Concat(new object[] { "SELECT DISTINCT ord.trans_num AS [Số GD], ord.tran_date AS [Ng\x00e0y GD], ord.tran_time AS Giờ, ord.deliver_dt AS [Ng\x00e0y giao], ord.exp_id AS [M\x00e3 NCC], spp.fullname AS [Nh\x00e0 cung cấp], ord.remark AS [Ghi ch\x00fa], ord.status, SUM(ord.qty*ord.price) AS [Tổng tiền],us.name AS [Người đặt] FROM  tblOn_order AS ord INNER JOIN  tblStore AS spp ON ord.exp_id = spp.id  INNER JOIN  tblUser AS us ON ord.user_id = us.ID   WHERE ord.tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "'    AND ord.status = 1 GROUP BY ord.remark, ord.trans_num, ord.tran_date, ord.tran_time, ord.exp_id, ord.deliver_dt,  spp.fullname, us.name ,ord.status ORDER BY ord.tran_date,ord.tran_time, ord.trans_num  " });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTransList.DataSource = dataSet.Tables[0];
            this.TransView.OptionsBehavior.Editable = false;
            this.TransView.Columns["Tổng tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.TransView.Columns["Tổng tiền"].DisplayFormat.FormatString = "n2";
            this.TransView.Columns["Ng\x00e0y GD"].DisplayFormat.FormatType = FormatType.DateTime;
            this.TransView.Columns["Ng\x00e0y GD"].DisplayFormat.FormatString = "dd/MM/yyyy";
            this.TransView.Columns["Ng\x00e0y giao"].DisplayFormat.FormatType = FormatType.DateTime;
            this.TransView.Columns["Ng\x00e0y giao"].DisplayFormat.FormatString = "dd/MM/yyyy";
            this.TransView.BestFitColumns();
        }

        private void method_1()
        {
            string selectCommandText = "SELECT ord.goods_id AS [M\x00e3 h\x00e0ng], gs.full_name AS [T\x00ean h\x00e0ng], ord.qty AS [Số lượng], ord.unit_symb AS [Đơn vị], ord.price AS [Đơn gi\x00e1],  ord.qty * ord.price AS [Th\x00e0nh tiền] FROM  tblGoods AS gs INNER JOIN tblOn_order AS ord ON gs.goods_id = ord.goods_id WHERE ord.trans_num = '" + this.Lbl_TransNum.Text.Trim() + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.GrdTranDetail.DataSource = set.Tables[0];
            }
            this.DetailView.OptionsBehavior.Editable = false;
            this.DetailView.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.DetailView.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatString = "n2";
            this.DetailView.Columns["Th\x00e0nh tiền"].SummaryItem.FieldName = "Th\x00e0nh tiền";
            this.DetailView.Columns["Th\x00e0nh tiền"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.DetailView.Columns["Th\x00e0nh tiền"].SummaryItem.DisplayFormat = "{0:n2}";
            this.DetailView.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
            this.DetailView.Columns["Số lượng"].DisplayFormat.FormatString = "n2";
            this.DetailView.Columns["Số lượng"].SummaryItem.FieldName = "Số lượng";
            this.DetailView.Columns["Số lượng"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.DetailView.Columns["Số lượng"].SummaryItem.DisplayFormat = "{0:n2}";
            this.DetailView.BestFitColumns();
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch đơn đặt h\x00e0ng";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }

        private void TransView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                object rowCellValue = null;
                this.Lbl_TransNum.Text = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Số GD").ToString();
                this.Lbl_ExpName.Text = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Nh\x00e0 cung cấp").ToString();
                this.Lbl_ExpId.Text = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "M\x00e3 NCC").ToString();
                rowCellValue = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Ng\x00e0y GD");
                object obj3 = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Ng\x00e0y giao");
                this.Lbl_Remark.Text = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Ghi ch\x00fa").ToString();
                this.Lbl_UserName.Text = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Người đặt").ToString();
                this.Lbl_TranDate.Text = string.Format("{0:dd/MM/yyyy}", rowCellValue);
                this.Lbl_Delevery.Text = string.Format("{0:dd/MM/yyyy}", obj3);
            }
            catch (Exception)
            {
            }
            this.method_1();
        }
   
    }
}