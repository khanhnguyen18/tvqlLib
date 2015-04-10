using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    public partial class FrmUtils : DevExpress.XtraEditors.XtraForm
    {
        public FrmUtils()
        {
            InitializeComponent();
        }

        public void a_correct()
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
            {
                DataSet set;
                this.string_1 = "update tblAccount set debamt = 0, creamt = 0";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.string_1 = "select * from tblAccTrans where status = 1";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                DataTable dataTable = new DataTable();
                this.oleDbDataAdapter_0.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    this.string_1 = string.Concat(new object[] { "update tblAccount set debamt = debamt + ", row["db_amount"], ", creamt = creamt + ", row["cr_amount"], " where account_id = '", row["account_id"], "'" });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                        continue;
                    }
                }
                Class7.ShowMessageBox("Ho\x00e0n th\x00e0nh hiệu chỉnh dữ liệu !", 1);
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.string_0))
            {
                Class7.ShowMessageBox("Bạn chưa lựa chọn tiện \x00edch", 1);
            }
            else
            {
                //Interaction.CallByName(this, this.string_0.Trim(), CallType.Method, new object[0]);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        public void changedate()
        {
            new FrmChangeSysDate().ShowDialog();
        }

        public void companyinfo()
        {
            new FrmSystemInfo().ShowDialog();
        }

        public void correctall()
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn hiệu chỉnh dữ liệu kh\x00f4ng ?", 2) == 1)
            {
                DataSet set;
                DataTable table;
                WaitDialogForm form = new WaitDialogForm();
                form.Caption = "Xin đợi một ch\x00fat ....";
                string selectCommandText = null;
                selectCommandText = "DELETE FROM tblStockInfo";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
                string str = null;
                selectCommandText = "SELECT id FROM tblStore WHERE Type IN('01','02') ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                using (table = new DataTable())
                {
                    this.oleDbDataAdapter_0.Fill(table);
                    this.oleDbConnection_0.Close();
                    foreach (DataRow row in table.Rows)
                    {
                        str = str + row[0].ToString() + "/";
                    }
                }
                //string str4 = Class6.smethod_2("K");
                string str3 = "10";
                string str5 = "00";
                string str6 = "01";
                selectCommandText = "SELECT * FROM tblTransaction WHERE status = 1 ORDER BY tran_date, tran_time";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                using (table = new DataTable())
                {
                    this.oleDbDataAdapter_0.Fill(table);
                    this.oleDbConnection_0.Close();
                    foreach (DataRow row in table.Rows)
                    {
                        double num2;
                        form.Caption = "Đang xử l\x00fd ng\x00e0y " + string.Format("{0:dd/MM/yyyy}", row["tran_date"]);
                        if (row["trans_code"].ToString() == str3)
                        {
                            selectCommandText = string.Concat(new object[] { 
                                "IF EXISTS (SELECT goods_id FROM tblStockInfo WHERE id = '", row["imp_id"], "' AND goods_id = '", row["goods_id"], "' ) UPDATE  tblStockInfo SET Imp_qty = imp_qty + ", row["qty"], ", imp_amt = imp_amt + ", row["amount"], ", last_date ='", row["tran_date"], "' WHERE id = '", row["imp_id"], "' AND goods_id = '", row["goods_id"], "'  Else INSERT INTO tblStockInfo(id,goods_id,Imp_qty,imp_amt,last_date )  VALUES('", row["imp_id"], 
                                "','", row["goods_id"], "',", row["qty"], ",", row["amount"], ",'", row["tran_date"], "'); IF EXISTS (SELECT goods_id FROM tblStockInfo WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "' ) UPDATE  tblStockInfo SET exp_qty = exp_qty + ", row["qty"], ", exp_amt = exp_amt + ", row["amount"], 
                                ", last_date ='", row["tran_date"], "' WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "'  Else INSERT INTO tblStockInfo(id,goods_id,exp_qty,exp_amt,last_date )  VALUES('", row["exp_id"], "','", row["goods_id"], "',", row["qty"], ",", row["amount"], ",'", row["tran_date"], 
                                "')"
                             });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_0.Close();
                            }
                            selectCommandText = string.Concat(new object[] { "UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty) - exp_qty)  WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt) - exp_amt)/((begin_qty + imp_qty) - exp_qty) END   WHERE  goods_id = '", row["goods_id"], "' and id = '", row["imp_id"], "'" });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_0.Close();
                            }
                        }
                        if (str4.IndexOf(row["trans_code"].ToString()) >= 0)
                        {
                            if (str.IndexOf(row["imp_id"].ToString()) != -1)
                            {
                                selectCommandText = string.Concat(new object[] { 
                                    "IF EXISTS (SELECT goods_id FROM tblStockInfo WHERE id = '", row["imp_id"], "' AND goods_id = '", row["goods_id"], "' ) UPDATE  tblStockInfo SET Imp_qty = imp_qty + ", row["qty"], ", imp_amt = imp_amt + ", row["amount"], ", last_date ='", row["tran_date"], "' WHERE id = '", row["imp_id"], "' AND goods_id = '", row["goods_id"], "'  Else INSERT INTO tblStockInfo(id,goods_id,Imp_qty,imp_amt,last_date )  VALUES('", row["imp_id"], 
                                    "','", row["goods_id"], "',", row["qty"], ",", row["amount"], ",'", row["tran_date"], "') "
                                 });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                                using (set = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set);
                                    this.oleDbConnection_0.Close();
                                }
                                selectCommandText = string.Concat(new object[] { "UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty) - exp_qty)  WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt) - exp_amt)/((begin_qty + imp_qty) - exp_qty) END   WHERE  goods_id = '", row["goods_id"], "' and id = '", row["imp_id"], "'" });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                                using (set = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set);
                                    this.oleDbConnection_0.Close();
                                }
                                if (((row["trans_code"].ToString() == "13") || (row["trans_code"].ToString() == "30")) || (row["trans_code"].ToString() == "23"))
                                {
                                    selectCommandText = string.Concat(new object[] { "UPDATE  tblGoods SET supp_id = '", row["exp_id"], "'  WHERE  goods_id = '", row["goods_id"], "' " });
                                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                                    using (set = new DataSet())
                                    {
                                        this.oleDbDataAdapter_0.Fill(set);
                                        this.oleDbConnection_0.Close();
                                    }
                                    double num = Class7.smethod_2(row["amount"]) / Class7.smethod_2(row["qty"]);
                                    selectCommandText = string.Concat(new object[] { "UPDATE tblPrice SET lastimppr = ", num, " where goods_id = '", row["goods_id"], "' " });
                                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                                    using (set = new DataSet())
                                    {
                                        this.oleDbDataAdapter_0.Fill(set);
                                        this.oleDbConnection_0.Close();
                                    }
                                }
                            }
                            if (str.IndexOf(row["exp_id"].ToString()) != -1)
                            {
                                selectCommandText = string.Concat(new object[] { 
                                    "IF EXISTS (SELECT goods_id FROM tblStockInfo WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "' ) UPDATE  tblStockInfo SET exp_qty = exp_qty + ", row["qty"], ", exp_amt = exp_amt + ", row["amount"], ", last_date ='", row["tran_date"], "' WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "'  Else INSERT INTO tblStockInfo(id,goods_id,exp_qty,exp_amt,last_date )  VALUES('", row["exp_id"], 
                                    "','", row["goods_id"], "',", row["qty"], ",", row["amount"], ",'", row["tran_date"], "')"
                                 });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                                using (set = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set);
                                    this.oleDbConnection_0.Close();
                                }
                            }
                        }
                        if (row["trans_code"].ToString() == str5)
                        {
                            num2 = Math.Round((double) (((Class7.smethod_2(row["amount"]) - Class7.smethod_2(row["discount"])) - Class7.smethod_2(row["surplus"])) - Class7.smethod_2(row["vat_amt"])), 2);
                            selectCommandText = string.Concat(new object[] { 
                                "IF EXISTS (SELECT goods_id FROM tblStockInfo WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "' ) UPDATE  tblStockInfo SET exp_qty = exp_qty + ", row["qty"], ", exp_amt = exp_amt + ", num2, ", last_date ='", row["tran_date"], "' WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "'  Else INSERT INTO tblStockInfo(id,goods_id,exp_qty,exp_amt,last_date )  VALUES('", row["exp_id"], 
                                "','", row["goods_id"], "',", row["qty"], ",", num2, ",'", row["tran_date"], "')"
                             });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_0.Close();
                            }
                        }
                        if (row["trans_code"].ToString() == str6)
                        {
                            num2 = Math.Round((double) (((Class7.smethod_2(row["amount"]) - Class7.smethod_2(row["discount"])) - Class7.smethod_2(row["surplus"])) - Class7.smethod_2(row["vat_amt"])), 2);
                            selectCommandText = string.Concat(new object[] { 
                                "IF EXISTS (SELECT goods_id FROM tblStockInfo WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "' ) UPDATE  tblStockInfo SET imp_qty = imp_qty + ", row["qty"], ", imp_amt = imp_amt + ", num2, ", last_date ='", row["tran_date"], "' WHERE id = '", row["exp_id"], "' AND goods_id = '", row["goods_id"], "'  Else INSERT INTO tblStockInfo(id,goods_id,imp_qty,imp_amt,last_date )  VALUES('", row["exp_id"], 
                                "','", row["goods_id"], "',", row["qty"], ",", num2, ",'", row["tran_date"], "')"
                             });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_0.Close();
                            }
                            selectCommandText = string.Concat(new object[] { "UPDATE  tblStockInfo SET averimppr = CASE ((begin_qty + imp_qty) - exp_qty)  WHEN 0 THEN 0 ELSE ((begin_amt + imp_amt) - exp_amt)/((begin_qty + imp_qty) - exp_qty) END   WHERE  goods_id = '", row["goods_id"], "' and id = '", row["exp_id"], "'" });
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                            using (set = new DataSet())
                            {
                                this.oleDbDataAdapter_0.Fill(set);
                                this.oleDbConnection_0.Close();
                                continue;
                            }
                        }
                    }
                }
                form.Close();
                Class7.ShowMessageBox("Hiệu chỉnh dữ liệu đ\x00e3 ho\x00e0n th\x00e0nh", 1);
            }
        }

        public void delete_all_data()
        {
            Class7.ShowMessageBox("Bạn kh\x00f4ng được ph\x00e9p sử dụng t\x00ednh năng n\x00e0y", 1);
        }

        private void DetailView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.string_0 = this.DetailView.GetRowCellValue(this.DetailView.FocusedRowHandle, "subname").ToString().Trim();
                if (this.string_0 != string.Empty)
                {
                    this.memoEdit1.Text = this.DetailView.GetRowCellValue(this.DetailView.FocusedRowHandle, "description").ToString().Trim();
                }
                else
                {
                    this.memoEdit1.Text = string.Empty;
                }
            }
            catch (Exception)
            {
            }
        }

        public void discountprg()
        {
            new FrmDiscount().ShowDialog();
        }

        private void FrmUtils_Load(object sender, EventArgs e)
        {
            this.Text = Class7.smethod_14("m_softname").ToString();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select id as TT, name as 'Diễn giải', description,subname from tblUtils where status =1", Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            this.GrdUtils.DataSource = dataSet.Tables[0];
            this.DetailView.BestFitColumns();
            this.DetailView.Columns["subname"].Visible = false;
            this.DetailView.Columns["description"].Visible = false;
            this.memoEdit1.Properties.ReadOnly = true;
            this.btn_Confirm.Enabled = Class7.smethod_50();
        }

        public static void getTrans()
        {
            SqlConnection connection = new SqlConnection(Class7.string_6);
            SqlCommand command = new SqlCommand("GetTrans", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            using (DataTable table = new DataTable())
            {
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    row[0].ToString();
                }
            }
        }

        private void GrdUtils_Click(object sender, EventArgs e)
        {
        }

        public void songorder()
        {
            Class7.smethod_27("orderform").ShowPreviewDialog();
        }

        public void vatcorrect()
        {
            new FrmVatCorrect().ShowDialog();
        }
    }
}