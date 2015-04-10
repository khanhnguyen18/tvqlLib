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
    public partial class FrmStrList : DevExpress.XtraEditors.XtraForm
    {
        public FrmStrList()
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
            //new Class6().method_4(this.Lbl_TransCode.Text, ref Class6.string_2, ref Class6.string_1, ref Class7.string_1, ref Class6.string_3, ref Class6.string_4, ref Class6.object_0);
            Class6.transNum = this.Lbl_TransNum.Text.Trim();
            Class7.smethod_27(Class6.string_3).ShowPreviewDialog();
            Class7.smethod_27(Class6.string_4).ShowPreviewDialog();
        }

        private void FrmStrList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmStrList_Load(object sender, EventArgs e)
        {
            this.Text = "Danh s\x00e1ch giao dịch kho h\x00e0ng";
            base.Tag = "tblTransaction";
            this.method_0();
            this.method_1();
            StyleFormatCondition condition = null;
            condition = new StyleFormatCondition(FormatConditionEnum.Equal, this.gridView1.Columns["status"], null, "False");
            condition.Appearance.BackColor = Color.Red;
            this.gridView1.FormatConditions.Add(condition);
            condition.ApplyToRow = true;
            this.Lbl_duaration.Text = "Từ ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTime_0) + " đến ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTime_1);
        }

        private void GrdTransList_Click(object sender, EventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                object rowCellValue = null;
                this.Lbl_TransNum.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Số GD").ToString();
                this.Lbl_ImpId.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Nơi nhập").ToString();
                this.Lbl_ExpId.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Nơi xuất").ToString();
                rowCellValue = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Ng\x00e0y GD");
                this.Lbl_TransCode.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Loại").ToString();
                this.Lbl_Remark.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "Ghi ch\x00fa").ToString();
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



        private void Lbl_ExpId_TextChanged(object sender, EventArgs e)
        {
            if (!(this.Lbl_ExpId.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Lbl_ExpId.Text, "", this.oleDbConnection_0, ref str);
                this.Lbl_ExpName.Text = str;
            }
        }

        private void Lbl_ImpId_TextChanged(object sender, EventArgs e)
        {
            if (!(this.Lbl_ImpId.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Lbl_ImpId.Text, "", this.oleDbConnection_0, ref str);
                this.Lbl_ImpName.Text = str;
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
            string selectCommandText = "SELECT stk.goods_id AS [M\x00e3 h\x00e0ng],gs.full_name As [T\x00ean h\x00e0ng], stk.qty AS [Số lượng], stk.discount AS [Chiết khấu], stk.vat_amt AS [Thuế VAT], stk.amount AS [Th\x00e0nh tiền], stk.remark AS [Ghi ch\x00fa] FROM tblTransaction AS stk INNER JOIN tblGoods AS gs ON stk.goods_id = gs.goods_id WHERE stk.trans_num = '" + this.Lbl_TransNum.Text.Trim() + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTranDetail.DataSource = dataSet.Tables[0];
            this.DetailView.OptionsBehavior.Editable = false;
            this.DetailView.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.DetailView.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatString = "n2";
            this.DetailView.Columns["Th\x00e0nh tiền"].SummaryItem.FieldName = "Th\x00e0nh tiền";
            this.DetailView.Columns["Th\x00e0nh tiền"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.DetailView.Columns["Th\x00e0nh tiền"].SummaryItem.DisplayFormat = "{0:n2}";
            this.DetailView.Columns["Chiết khấu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.DetailView.Columns["Chiết khấu"].DisplayFormat.FormatString = "n2";
            this.DetailView.Columns["Chiết khấu"].SummaryItem.FieldName = "Chiết khấu";
            this.DetailView.Columns["Chiết khấu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.DetailView.Columns["Chiết khấu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.DetailView.Columns["Thuế VAT"].DisplayFormat.FormatType = FormatType.Numeric;
            this.DetailView.Columns["Thuế VAT"].DisplayFormat.FormatString = "n2";
            this.DetailView.Columns["Thuế VAT"].SummaryItem.FieldName = "Thuế VAT";
            this.DetailView.Columns["Thuế VAT"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.DetailView.Columns["Thuế VAT"].SummaryItem.DisplayFormat = "{0:n2}";
            this.DetailView.Columns["Số lượng"].DisplayFormat.FormatType = FormatType.Numeric;
            this.DetailView.Columns["Số lượng"].DisplayFormat.FormatString = "n2";
            this.DetailView.Columns["Số lượng"].SummaryItem.FieldName = "Số lượng";
            this.DetailView.Columns["Số lượng"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.DetailView.Columns["Số lượng"].SummaryItem.DisplayFormat = "{0:n2}";
            this.DetailView.BestFitColumns();
        }

        private void method_0()
        {
            this.string_0 = "Select DISTINCT trans_num AS [Số GD], tran_date AS [Ng\x00e0y GD], tran_time AS [Giờ], ";
            this.string_0 = this.string_0 + "trans_code AS [Loại], exp_id AS [Nơi xuất], imp_id AS [Nơi nhập], SUM(discount) AS [C.khấu], SUM(amount)  ";
            this.string_0 = this.string_0 + "AS [Th\x00e0nh tiền],SUM(vat_amt) AS [Thuế VAT], remark AS [Ghi ch\x00fa],user_id, status FROM " + base.Tag.ToString() + " ";
            object obj2 = this.string_0;
            this.string_0 = string.Concat(new object[] { obj2, "WHERE (tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "') " });
            this.string_0 = this.string_0 + " AND trans_code <> '00' AND trans_code <> '01'  ";
            this.string_0 = this.string_0 + "GROUP BY remark, trans_num, tran_date, tran_time, trans_code, exp_id, imp_id,user_id, status ";
            this.string_0 = this.string_0 + " ORDER BY tran_date,tran_time, trans_num ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTransList.DataSource = dataSet.Tables[0];
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Th\x00e0nh tiền"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["Th\x00e0nh tiền"].SummaryItem.FieldName = "Th\x00e0nh tiền";
            this.gridView1.Columns["Th\x00e0nh tiền"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["Th\x00e0nh tiền"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["Thuế VAT"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Thuế VAT"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["Thuế VAT"].SummaryItem.FieldName = "Thuế VAT";
            this.gridView1.Columns["Thuế VAT"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["Thuế VAT"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["C.khấu"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["C.khấu"].DisplayFormat.FormatString = "n2";
            this.gridView1.Columns["C.khấu"].SummaryItem.FieldName = "C.khấu";
            this.gridView1.Columns["C.khấu"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["C.khấu"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["Ng\x00e0y GD"].DisplayFormat.FormatType = FormatType.DateTime;
            this.gridView1.Columns["Ng\x00e0y GD"].DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridView1.Columns["user_id"].Visible = false;
            this.gridView1.BestFitColumns();
        }

        private void method_1()
        {
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch giao dịch kho";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
        }
   
    }
}