using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
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
    public partial class FrmMercList : DevExpress.XtraEditors.XtraForm
    {
        public FrmMercList()
        {
            InitializeComponent();
            this.oleDbConnection_0 = new OleDbConnection(Class7.string_5);
        }

        private void btn_ChangePrice_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.string_2))
            {
                Class6.string_0 = this.string_2;
                new FrmChangePrice().ShowDialog();
                this.loadgid();
            }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            DataSet set;
            OleDbDataAdapter adapter = new OleDbDataAdapter("DELETE FROM " + this.string_0, Class7.oleDbConnection_1);
            using (set = new DataSet())
            {
                adapter.Fill(set);
            }
            Class7.oleDbConnection_1.Close();
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                this.string_1 = string.Concat(new object[] { "select * from tblTransaction where goods_id = '", this.string_2, "' and (tran_date between '", Class7.dateTime_0, "' and '", Class7.dateTime_1, "')  and status = 1  order by tran_date, tran_time " });
                OleDbDataAdapter adapter3 = new OleDbDataAdapter(this.string_1, Class7.oleDbConnection_1);
                DataTable dataTable = new DataTable();
                adapter3.Fill(dataTable);
                Class7.oleDbConnection_1.Close();
                foreach (DataRow row in dataTable.Rows)
                {
                    string str = string.Format("{0:dd/MM/yyyy}", row["tran_date"]);
                    string str2 = string.Format("{0:n2}", row["amount"]);
                    OleDbDataAdapter adapter2 = new OleDbDataAdapter(string.Concat(new object[] { 
                        "insert into ", this.string_0, "(tran_date, trans_num, tran_time, trans_code, exp_id, imp_id, qty, amount,remark) Values('", str, "','", row["trans_num"], "', '", row["tran_time"], "', '", row["trans_code"], "', '", row["exp_id"], "', '", row["imp_id"], "',", row["qty"], 
                        ",'", str2, "',N'", row["remark"], "')"
                     }), Class7.oleDbConnection_1);
                    set = new DataSet();
                    adapter2.Fill(set);
                    Class7.oleDbConnection_1.Close();
                }
                Class7.BrowserForm1("select * from " + this.string_0, Class7.oleDbConnection_1);
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

        private void ddvqeXfa4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.string_2))
            {
                Class6.string_0 = this.string_2;
                new FrmMercDisc().ShowDialog();
                this.loadgid();
            }
        }

        private void FrmMercList_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmMercList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_0, Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
        }

        private void FrmMercList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.P))
            {
                this.btnPrint_Click(this, new EventArgs());
            }
        }

        private void FrmMercList_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter;
            DataSet set;
            this.Text = "Danh s\x00e1ch h\x00e0ng h\x00f3a";
            WaitDialogForm form = new WaitDialogForm();
            form.Caption = "Xin đợi một ch\x00fat ....";
            this.loadgid();
            form.Close();
            try
            {
                adapter = new OleDbDataAdapter("CREATE TABLE " + this.string_0 + "(tran_date [nvarchar](10),trans_num [nvarchar](12),tran_time [nvarchar](5),trans_code[nvarchar](2), exp_id [nvarchar](5),imp_id [nvarchar](5),qty DECIMAL(18,2) , amount [nvarchar](20), remark [nvarchar](100)) ", Class7.oleDbConnection_1);
                set = new DataSet();
                adapter.Fill(set);
                Class7.oleDbConnection_1.Close();
            }
            catch (Exception)
            {
                adapter = new OleDbDataAdapter("DELETE FROM " + this.string_0, Class7.oleDbConnection_1);
                set = new DataSet();
                adapter.Fill(set);
                Class7.oleDbConnection_1.Close();
            }
        }



        public void loadgid()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT A.goods_id AS [M\x00e3 h\x00e0ng],A.barcode, A.grp_id AS [Nh\x00f3m], A.full_name AS [T\x00ean h\x00e0ng], A.piceunit AS [Đơn vị], B.rtprice AS [Gi\x00e1 b\x00e1n lẻ], B.lastimppr AS [Gi\x00e1 nhập], A.supp_id AS [M\x00e3 NCC],B.discpercent AS [%CK], B.disc_frdate AS [Từ ng\x00e0y], B.disc_todate AS [Đến ng\x00e0y], A.Status FROM (tblGoods AS A INNER JOIN tblPrice AS B  ON A.goods_id = B.goods_id) INNER JOIN tblGoodsGrp AS C ON A.grp_id = C.Id  Order By A.goods_id, A.grp_id ", this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.GrdMercList.DataSource = set.Tables[0];
            }
            this.Merc_View.OptionsBehavior.Editable = false;
            this.Merc_View.BestFitColumns();
            this.Merc_View.Columns["M\x00e3 h\x00e0ng"].SummaryItem.FieldName = "M\x00e3 h\x00e0ng";
            this.Merc_View.Columns["M\x00e3 h\x00e0ng"].SummaryItem.SummaryType = SummaryItemType.Count;
            this.Merc_View.Columns["M\x00e3 h\x00e0ng"].SummaryItem.DisplayFormat = "{0:n0}";
            this.Merc_View.Columns["Gi\x00e1 b\x00e1n lẻ"].DisplayFormat.FormatType = FormatType.Numeric;
            this.Merc_View.Columns["Gi\x00e1 b\x00e1n lẻ"].DisplayFormat.FormatString = "{0:n0}";
            this.Merc_View.Columns["Gi\x00e1 nhập"].DisplayFormat.FormatType = FormatType.Numeric;
            this.Merc_View.Columns["Gi\x00e1 nhập"].DisplayFormat.FormatString = "{0:n0}";
            this.Merc_View.Columns["%CK"].DisplayFormat.FormatType = FormatType.Numeric;
            this.Merc_View.Columns["%CK"].DisplayFormat.FormatString = "{0:P2}";
            this.Merc_View.Columns["M\x00e3 NCC"].AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            this.Merc_View.Columns["Từ ng\x00e0y"].DisplayFormat.FormatType = FormatType.DateTime;
            this.Merc_View.Columns["Từ ng\x00e0y"].DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.Merc_View.Columns["Đến ng\x00e0y"].DisplayFormat.FormatType = FormatType.DateTime;
            this.Merc_View.Columns["Đến ng\x00e0y"].DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            StyleFormatCondition condition = null;
            condition = new StyleFormatCondition(FormatConditionEnum.Equal, this.Merc_View.Columns["Status"], null, false);
            condition.Appearance.BackColor = Color.Red;
            this.Merc_View.FormatConditions.Add(condition);
            condition.ApplyToRow = true;
            StyleFormatCondition condition2 = null;
            condition2 = new StyleFormatCondition(FormatConditionEnum.Greater, this.Merc_View.Columns["%CK"], null, 0);
            condition2.Appearance.BackColor = Color.Pink;
            this.Merc_View.FormatConditions.Add(condition2);
            condition2.ApplyToRow = false;
        }

        private void Merc_View_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
        }

        private void pfeZyQnoF(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.string_2 = this.Merc_View.GetRowCellValue(this.Merc_View.FocusedRowHandle, "M\x00e3 h\x00e0ng").ToString();
            }
            catch (Exception)
            {
            }
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = this.Text;
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, BorderSide.None);
        }
    
    }
}