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
    public partial class FrmStationView : DevExpress.XtraEditors.XtraForm
    {
        public FrmStationView()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.memoEdit1.Text != string.Empty)
            {
                int rowCount = this.gridView1.RowCount;
                for (int i = 0; i < rowCount; i++)
                {
                    if ((bool)this.gridView1.GetRowCellValue(i, "Gửi"))
                    {
                        int rowCellValue = (int)this.gridView1.GetRowCellValue(i, "M\x00e3");
                        this.string_0 = string.Concat(new object[] { "INSERT INTO tblQueuemsg(fr_pos, to_pos, sender, msg_date, msg_time, message) VALUES('", Class7.smethod_51(), "',", rowCellValue, ",'", Class7.GetUserId(), "','", Class7.smethod_19(), "','", Class7.smethod_53(), "' ,N'", this.memoEdit1.Text.Trim(), "' )" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (DataSet set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
                        this.oleDbConnection_0.Close();
                    }
                }
                base.Close();
            }
        }


        private void FrmStationView_Load(object sender, EventArgs e)
        {
            this.Text = "Gửi tin nhắn";
            this.string_0 = "SELECT tblStations.id AS M\x00e3, tblStations.name AS [Trạm giao dịch], tblUser.name AS [Người sử dụng], message AS Gửi  FROM  tblStations LEFT JOIN tblUser ON tblStations.user_id = tblUser.ID  where tblStations.id <> " + Class7.smethod_51() + " and tblStations.status = 1 ";
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            this.gridControl1.DataSource = dataSet.Tables[0];
            this.gridView1.BestFitColumns();
            this.gridView1.Columns[0].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[3].OptionsColumn.AllowEdit = true;
            StyleFormatCondition condition = null;
            condition = new StyleFormatCondition(FormatConditionEnum.Equal, this.gridView1.Columns[2], null, null);
              condition.Appearance.ForeColor = Color.Gray;
            this.gridView1.FormatConditions.Add(condition);
            condition.ApplyToRow = true;
            this.memoEdit1.Focus();
        }


        private void RrqIxZxw5(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                if (this.gridView1.GetRowCellValue(i, "Người sử dụng").ToString() != string.Empty)
                {
                    this.gridView1.GetDataRow(i)[3] = this.chk_SendAll.Checked;
                }
            }
        }
 
    }
}