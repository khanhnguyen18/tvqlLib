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
    public partial class FrmPtrList : DevExpress.XtraEditors.XtraForm
    {
        public FrmPtrList()
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

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            Class6.string_5 = this.Lbl_TransNum.Text.Trim();
            string text = this.Lbl_TransCode.Text;
            if (text != null)
            {
                if (!(text == "00"))
                {
                    if (text == "01")
                    {
                        new voucher_2().Print();
                    }
                }
                else
                {
                    Class11.string_1 = "R";
                    new voucher_1().ShowPreviewDialog();
                }
            }
        }


        private void FrmPtrList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmPtrList_Load(object sender, EventArgs e)
        {
            this.Text = "Danh s\x00e1ch giao dịch b\x00e1n lẻ";
            base.Tag = "tblTransaction";
            this.method_0();
            StyleFormatCondition condition = null;
            condition = new StyleFormatCondition(FormatConditionEnum.Equal, this.gridView1.Columns["Loại"], null, "01");
            condition.Appearance.BackColor = Color.LightSkyBlue;
            this.gridView1.FormatConditions.Add(condition);
            condition.ApplyToRow = true;
            StyleFormatCondition condition2 = null;
            condition2 = new StyleFormatCondition(FormatConditionEnum.Equal, this.gridView1.Columns["status"], null, "False");
            condition2.Appearance.BackColor = Color.Red;
            this.gridView1.FormatConditions.Add(condition2);
            condition2.ApplyToRow = true;
            this.Lbl_duaration.Text = "Từ ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTime_0) + " đến ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTime_1);
        }

        private void GrdTransList_Click(object sender, EventArgs e)
        {
            try
            {
                object rowCellValue = null;
                this.Lbl_TransNum.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Số GD").ToString();
                this.Lbl_PosId.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Quầy").ToString();
                rowCellValue = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Ng\x00e0y GD");
                this.Lbl_TransCode.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Loại").ToString();
                string str = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "NV").ToString();
                string str2 = null;
                Class7.smethod_17("Name", "tblUser", "Id", str, "", this.oleDbConnection_0, ref str2);
                this.Lbl_UserName.Text = str2;
                this.Lbl_TranDate.Text = string.Format("{0:dd/MM/yyyy}", rowCellValue);
                this.Lbl_Remark.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "remark").ToString();
            }
            catch (Exception)
            {
            }
        }

        private void GrdTransList_CursorChanged(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                object rowCellValue = null;
                this.Lbl_TransNum.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Số GD").ToString();
                this.Lbl_PosId.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Quầy").ToString();
                rowCellValue = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Ng\x00e0y GD");
                this.Lbl_TransCode.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Loại").ToString();
                string str = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "user_id").ToString();
                string str2 = null;
                Class7.smethod_17("Name", "tblUser", "Id", str, "", this.oleDbConnection_0, ref str2);
                this.Lbl_UserName.Text = str2;
                this.Lbl_TranDate.Text = string.Format("{0:dd/MM/yyyy}", rowCellValue);
            }
            catch (Exception)
            {
            }
        }

        private void gridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Lbl_PosId_TextChanged(object sender, EventArgs e)
        {
            if (!(this.Lbl_PosId.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Lbl_PosId.Text, "", this.oleDbConnection_0, ref str);
                this.Lbl_PosName.Text = str;
            }
        }

        private void Lbl_TransCode_TextChanged(object sender, EventArgs e)
        {
            if (!(this.Lbl_TransCode.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("trName", "tblTrcode", "trCode", this.Lbl_TransCode.Text, "", this.oleDbConnection_0, ref str);
                this.Lbl_TransName.Text = str;
            }
        }

        private void Lbl_TransNum_TextChanged(object sender, EventArgs e)
        {
            string selectCommandText = "SELECT ptr.goods_id AS [M\x00e3 h\x00e0ng],gs.full_name As [T\x00ean h\x00e0ng],ptr.unit_symb AS [Đơn vị], ptr.qty AS [Số lượng],ptr.amount /ptr.qty AS [Gi\x00e1 b\x00e1n lẻ],ptr.discount AS [C.khấu], ptr.amount - ptr.discount AS [Thực thu] FROM tblTransaction AS ptr INNER JOIN tblGoods AS gs ON ptr.goods_id = gs.goods_id WHERE ptr.trans_num = '" + this.Lbl_TransNum.Text.Trim() + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.GrdTranDetail.DataSource = dataSet.Tables[0];
                this.DetailView.OptionsBehavior.Editable = false;
                this.DetailView.Columns["Thực thu"].DisplayFormat.FormatType = FormatType.Numeric;
                this.DetailView.Columns["Thực thu"].DisplayFormat.FormatString = "n2";
                this.DetailView.Columns["Gi\x00e1 b\x00e1n lẻ"].DisplayFormat.FormatType = FormatType.Numeric;
                this.DetailView.Columns["Gi\x00e1 b\x00e1n lẻ"].DisplayFormat.FormatString = "n2";
                this.DetailView.Columns["Thực thu"].SummaryItem.FieldName = "Thực thu";
                this.DetailView.Columns["Thực thu"].SummaryItem.SummaryType = SummaryItemType.Sum;
                this.DetailView.Columns["Thực thu"].SummaryItem.DisplayFormat = "{0:n2}";
                this.DetailView.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
                this.DetailView.Columns["Số lượng"].DisplayFormat.FormatString = "n2";
                this.DetailView.Columns["Số lượng"].SummaryItem.FieldName = "Số lượng";
                this.DetailView.Columns["Số lượng"].SummaryItem.SummaryType = SummaryItemType.Sum;
                this.DetailView.Columns["Số lượng"].SummaryItem.DisplayFormat = "{0:n2}";
                this.DetailView.Columns["C.khấu"].DisplayFormat.FormatType = FormatType.Numeric;
                this.DetailView.Columns["C.khấu"].DisplayFormat.FormatString = "n2";
                this.DetailView.Columns["C.khấu"].SummaryItem.FieldName = "C.khấu";
                this.DetailView.Columns["C.khấu"].SummaryItem.SummaryType = SummaryItemType.Sum;
                this.DetailView.Columns["C.khấu"].SummaryItem.DisplayFormat = "{0:n2}";
                this.DetailView.BestFitColumns();
            }
        }

        private void method_0()
        {
            this.string_0 = string.Concat(new object[] { "SELECT DISTINCT trans_num AS [Số GD], tran_date AS [Ng\x00e0y GD], tran_time AS Giờ, trans_code AS Loại, exp_id AS Quầy, SUM(amount - discount) AS [Thực thu],SUM(discount) AS [C.khấu],SUM(vat_amt) AS [Thuế GTGT],SUM(surplus) AS [L\x00e3i gộp], user_id AS [NV], Status, remark FROM ", base.Tag.ToString(), "  WHERE (tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "') AND trans_code IN('00','01') GROUP BY trans_num, tran_date, tran_time, trans_code, user_id, exp_id,Status,remark ORDER BY tran_date,tran_time,trans_num" });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTransList.DataSource = dataSet.Tables[0];
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Columns["Số GD"].SummaryItem.FieldName = "Số GD";
            this.gridView1.Columns["Số GD"].SummaryItem.SummaryType = SummaryItemType.Count;
            this.gridView1.Columns["Số GD"].SummaryItem.DisplayFormat = "Tổng số HĐ :{0:n0}";
            this.gridView1.Columns["Thực thu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Thực thu"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["Thuế GTGT"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Thuế GTGT"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["L\x00e3i gộp"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["L\x00e3i gộp"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["C.khấu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["C.khấu"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["Ng\x00e0y GD"].DisplayFormat.FormatType = FormatType.DateTime;
            this.gridView1.Columns["Ng\x00e0y GD"].DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridView1.Columns["C.khấu"].SummaryItem.FieldName = "C.khấu";
            this.gridView1.Columns["C.khấu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["C.khấu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["Thực thu"].SummaryItem.FieldName = "Thực thu";
            this.gridView1.Columns["Thực thu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["Thực thu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["L\x00e3i gộp"].SummaryItem.FieldName = "L\x00e3i gộp";
            this.gridView1.Columns["L\x00e3i gộp"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["L\x00e3i gộp"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["Số GD"].SummaryItem.FieldName = "Số GD";
            this.gridView1.Columns["Số GD"].SummaryItem.SummaryType = SummaryItemType.Count;
            this.gridView1.Columns["Số GD"].SummaryItem.DisplayFormat = "Tổng số GD :{0:n0}";
            this.gridView1.Columns["remark"].Visible = false;
            this.gridView1.BestFitColumns();
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch giao dịch b\x00e1n lẻ";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }


    }
}