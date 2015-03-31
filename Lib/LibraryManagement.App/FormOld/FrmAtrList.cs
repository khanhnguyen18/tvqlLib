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
    public partial class FrmAtrList : DevExpress.XtraEditors.XtraForm
    {
        public FrmAtrList()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Class7.smethod_15("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
            {
                DataSet set;
                this.string_0 = "update tblAcctrans set status = 0 where trans_num = '" + this.Lbl_TransNum.Text + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.string_0 = "SELECT tran_date, tran_time, ef_date, trans_num, voucher, trans_code, account_id, db_amount, cr_amount, user_id, corr_acc, remark, updated, recnum, status FROM tblAccTrans where trans_num = '" + this.Lbl_TransNum.Text + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                DataTable dataTable = new DataTable();
                this.oleDbDataAdapter_0.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    double num = Class7.smethod_2(row["db_amount"]);
                    double num2 = Class7.smethod_2(row["cr_amount"]);
                    this.string_0 = string.Concat(new object[] { "update tblAccount set debamt = debamt - ", num, ", creamt = creamt - ", num2, " where account_id = '", row["account_id"], "' " });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                Class7.smethod_15("X\x00f3a th\x00e0nh c\x00f4ng giao dịch " + this.Lbl_TransNum.Text, 1);
            }
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
            this.method_2(this.Lbl_TransCode.Text, ref Class6.string_2, ref Class6.string_1, ref Class7.string_1, ref Class6.string_3);
            Class6.string_5 = this.Lbl_TransNum.Text.Trim();
            Class7.smethod_27(Class6.string_3).ShowPreviewDialog();
        }



        private void FrmAtrList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmAtrList_Load(object sender, EventArgs e)
        {
            this.Text = "Danh s\x00e1ch giao dịch kế to\x00e1n";
            base.Tag = "tblAccTrans";
            this.method_0();
            this.method_1();
            StyleFormatCondition condition = null;
            condition = new StyleFormatCondition(
                FormatConditionEnum.Equal, this.TransView.Columns["status"], null, "False");
            condition.Appearance.BackColor= Color.Red;
            this.TransView.FormatConditions.Add(condition);
            condition.ApplyToRow = true;
            this.Lbl_duaration.Text = "Từ ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTime_0) + " đến ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", Class7.dateTime_1);
            this.btnDelete.Enabled = Class7.smethod_50();
        }

        private void GrdTransList_Click(object sender, EventArgs e)
        {
        }



        private void Lbl_TransCode_TextChanged(object sender, EventArgs e)
        {
            if (!(this.Lbl_TransCode.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("trans_name", "tblAtrCode", "trans_code", this.Lbl_TransCode.Text, "", this.oleDbConnection_0, ref str);
                this.Lbl_TransName.Text = str;
            }
        }

        private void Lbl_TransNum_TextChanged(object sender, EventArgs e)
        {
            string selectCommandText = "SELECT DISTINCT atr.account_id AS [T\x00e0i khoản], acc.name AS [T\x00ean t\x00e0i khoản], SUM(atr.db_amount) AS [Ghi nợ], SUM(atr.cr_amount) AS [Ghi c\x00f3]  FROM tblAccTrans AS atr INNER JOIN  tblAccount AS acc ON atr.account_id = acc.account_id  WHERE atr.trans_num = '" + this.Lbl_TransNum.Text + "'  GROUP BY atr.account_id, acc.name";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTranDetail.DataSource = dataSet.Tables[0];
            this.DetailView.OptionsBehavior.Editable = false;
            this.DetailView.Columns["Ghi nợ"].DisplayFormat.FormatType = FormatType.Numeric;
            this.DetailView.Columns["Ghi nợ"].DisplayFormat.FormatString = "n2";
            this.DetailView.Columns["Ghi c\x00f3"].DisplayFormat.FormatType = FormatType.Numeric;
            this.DetailView.Columns["Ghi c\x00f3"].DisplayFormat.FormatString = "n2";
            this.DetailView.BestFitColumns();
            this.DetailView.OptionsBehavior.Editable = false;
        }

        private void method_0()
        {
            this.string_0 = "Select DISTINCT trans_num AS [Số GD], tran_date AS [Ng\x00e0y GD], tran_time AS [Giờ], ";
            this.string_0 = this.string_0 + "trans_code AS [Loại],voucher AS [Chứng từ], remark AS [Diễn giải],user_id AS [M\x00e3 NV], status FROM " + base.Tag.ToString() + " ";
            object obj2 = this.string_0;
            this.string_0 = string.Concat(new object[] { obj2, "WHERE (tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "') " });
            this.string_0 = this.string_0 + "GROUP BY remark, trans_num, tran_date, tran_time, trans_code, user_id, status, voucher ";
            this.string_0 = this.string_0 + " ORDER BY tran_date,tran_time, trans_num ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.GrdTransList.DataSource = dataSet.Tables[0];
            this.TransView.Columns["Ng\x00e0y GD"].DisplayFormat.FormatType = FormatType.DateTime;
            this.TransView.Columns["Ng\x00e0y GD"].DisplayFormat.FormatString = "dd/MM/yyyy";
            this.TransView.BestFitColumns();
            this.TransView.OptionsBehavior.Editable = false;
        }

        private void method_1()
        {
        }

        private void method_2(string string_1, ref string string_2, ref string string_3, ref string string_4, ref string string_5)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT *  FROM tblAtrCode WHERE trans_code = '" + string_1 + "' ", this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    string_2 = set.Tables[0].Rows[0]["trans_code"].ToString().Trim();
                    string_3 = set.Tables[0].Rows[0]["trans_name"].ToString().Trim();
                    string_4 = set.Tables[0].Rows[0]["form"].ToString().Trim();
                    string_5 = set.Tables[0].Rows[0]["fvoucher"].ToString().Trim();
                }
                else
                {
                    string_2 = string.Empty;
                    string_3 = string.Empty;
                    string_4 = string.Empty;
                    string_5 = string.Empty;
                }
            }
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh s\x00e1ch giao dịch kế to\x00e1n";
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
                this.Lbl_Voucher.Text = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Chứng từ").ToString();
                rowCellValue = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Ng\x00e0y GD");
                this.Lbl_TransCode.Text = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Loại").ToString();
                this.Lbl_Remark.Text = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "Diễn giải").ToString();
                string str = this.TransView.GetRowCellValue(this.TransView.FocusedRowHandle, "M\x00e3 NV").ToString();
                string str2 = null;
                Class7.smethod_17("Name", "tblUser", "Id", str, "", this.oleDbConnection_0, ref str2);
                this.Lbl_UserName.Text = str2;
                this.Lbl_TranDate.Text = string.Format("{0:dd/MM/yyyy}", rowCellValue);
            }
            catch (Exception)
            {
            }
        }
   
    }
}