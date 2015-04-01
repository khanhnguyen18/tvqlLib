using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
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
    public partial class FrmMercOrder : DevExpress.XtraEditors.XtraForm
    {
        public FrmMercOrder()
        {
            InitializeComponent();
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            string str = this.Txt_GoodsId.Text.Trim();
            string text = this.Lbl_MercName.Text;
            double num = Class7.smethod_0(this.Txt_Price.Text);
            double num2 = Class7.smethod_0(this.Txt_Qty.Text);
            string str3 = this.Lbl_Unit.Text;
            double num3 = Class7.smethod_0(this.Txt_EndQty.Text);
            this.string_2 = string.Concat(new object[] { 
                "IF EXISTS(SELECT goods_id FROM ", this.string_0, " WHERE goods_id = '", str, "')  UPDATE ", this.string_0, " SET qty = ", num2, " WHERE goods_id = '", str, "'  ELSE  INSERT INTO ", this.string_0, " (goods_id, Name,unitsymb, qty, price,end_qty )  VALUES     ('", str, "',N'", text, 
                "','", str3, "',", num2, ",", num, ",", num3, ");  DELETE FROM ", this.string_0, " WHERE qty <= 0 "
             });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
            }
            this.method_0();
            new Class6().method_2(this.string_0);
            this.Txt_GoodsId.Focus();
            this.Txt_GoodsId.SelectAll();
        }

        private void btnCreateTrans_Click(object sender, EventArgs e)
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn tạo giao dịch đặt h\x00e0ng n\x00e0y kh\x00f4ng ?", 2) == 1)
            {
                Class6 class2 = new Class6();
                string str = class2.method_5("H");
                string str2 = DateTime.ParseExact(this.Txt_DtDelivery.Text, "dd/MM/yyyy", null).ToString();
                string str3 = Class7.smethod_53();
                string str4 = (this.Txt_Remark.Text == string.Empty) ? "Đặt h\x00e0ng từ nh\x00e0 cung cấp" : this.Txt_Remark.Text;
                string str5 = this.Txt_ExpID.Text.Trim();
                if (this.Lbl_ExpName.Text == string.Empty)
                {
                    Class7.ShowMessageBox("Bạn chưa chọn m\x00e3 nh\x00e0 cung cấp", 1);
                    this.Txt_ExpID.Focus();
                }
                else
                {
                    using (WaitDialogForm form = new WaitDialogForm())
                    {
                        form.Caption = "Tạo giao dịch số " + str;
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter("select  goods_id,unitsymb, Name, qty, price,end_qty  from " + this.string_0, this.oleDbConnection_0);
                        using (DataTable table = new DataTable())
                        {
                            this.oleDbDataAdapter_0.Fill(table);
                            this.oleDbConnection_0.Close();
                            foreach (DataRow row in table.Rows)
                            {
                                this.string_2 = string.Concat(new object[] { 
                                    "INSERT INTO tblOn_order (tran_date, tran_time, deliver_dt, trans_num, trans_code, exp_id, goods_id, qty, unit_symb, price, merc_type, user_id, remark,status,end_qty) VALUES     ('", Class7.smethod_19(), "','", str3, "','", str2, "','", str, "','30','", str5, "','", row["goods_id"], "',", row["qty"], ",'", row["unitsymb"], 
                                    "',", row["price"], ",'01',", Class7.GetUserRight(), ",N'", str4, "',1,", row["end_qty"], ") "
                                 });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                                using (DataSet set = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set);
                                    this.oleDbConnection_0.Close();
                                    continue;
                                }
                            }
                        }
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_0);
                        using (DataSet set2 = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set2);
                            this.oleDbConnection_0.Close();
                        }
                        form.Close();
                        this.Txt_GoodsId.Text = string.Empty;
                        this.Txt_ExpID.Text = string.Empty;
                        this.Txt_ExpID.Enabled = true;
                        this.Lbl_ExpName.Text = string.Empty;
                        this.Lbl_MercName.Text = string.Empty;
                        class2.ComputeTransnum("H");
                        Class6.transNum = str;
                        this.method_0();
                        this.Txt_ExpID.Focus();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
        }

        private void FrmMercOrder_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmMercOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        private void FrmMercOrder_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.Text = "Đặt h\x00e0ng từ nh\x00e0 cung cấp";
            base.Tag = "tblOn_order";
            this.Txt_DtDelivery.EditValue = DateTime.Now.AddDays(1.0);
            try
            {
                string selectCommandText = "CREATE TABLE " + this.string_0 + "([autoid] [int] IDENTITY(1,1) ,[idx] [decimal](8, 0) DEFAULT ((1)),[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((1)),[price] [decimal](18, 2) DEFAULT ((0)),[exp_id] [nvarchar](5) DEFAULT (''),[unitsymb] [nvarchar](3) DEFAULT (('')),[merc_type] [nvarchar](2) DEFAULT (('')),[end_qty] [decimal](8, 2) DEFAULT ((0)))";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
            catch (Exception)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
            this.method_0();
            this.Txt_EndQty.Enabled = false;
        }



        private void kCnalMegv(object sender, EventArgs e)
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a hết lượng h\x00e0ng đ\x00e3 đặt kh\x00f4ng ?", 2) == 1)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.Txt_GoodsId.Text = string.Empty;
                this.Txt_ExpID.Text = string.Empty;
                this.method_0();
                this.Txt_ExpID.Focus();
            }
        }

        private void method_0()
        {
            this.string_2 = "SELECT idx AS TT, goods_id AS [M\x00e3 h\x00e0ng], Name AS [T\x00ean h\x00e0ng], qty AS [Lượng đặt], price AS [Gi\x00e1 nhập] FROM " + this.string_0 + " ORDER BY autoid";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
            this.gridView1.Columns["Lượng đặt"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Lượng đặt"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Gi\x00e1 nhập"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Gi\x00e1 nhập"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.BestFitColumns();
        }

        private void Txt_ExpID_EditValueChanged(object sender, EventArgs e)
        {
            if (!(this.Txt_ExpID.Text == string.Empty))
            {
                string str = null;
                Class7.smethod_17("fullname", "tblStore", "Id", this.Txt_ExpID.Text, "and type IN('05','06') and status = 1", this.oleDbConnection_0, ref str);
                this.Lbl_ExpName.Text = str;
            }
        }

        private void Txt_ExpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('05','06') and status = 1 ";
                Class7.BrowserForm(str, this.oleDbConnection_0);
                this.Txt_ExpID.Text = FrmBrowse.strReturn;
                this.Txt_ExpID.SelectAll();
            }
        }

        private void Txt_ExpID_Validated(object sender, EventArgs e)
        {
            this.Txt_ExpID.Enabled = false;
        }

        private void Txt_ExpID_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
            string str3;
            string str = this.Txt_GoodsId.Text.Trim();
            string str2 = Class7.smethod_14("m_plu").ToString().Trim();
            if (str == string.Empty)
            {
                return;
            }
            if (str.Length > 6)
            {
                DataSet set2;
                if (str.Substring(0, str2.Length) == str2)
                {
                    this.string_2 = "select goods_id from tblNon_Plu where nplu_code = '" + str.Substring(0, str2.Length) + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                    using (set2 = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set2);
                        if (set2.Tables[0].Rows.Count != 0)
                        {
                            this.Txt_GoodsId.Text = set2.Tables[0].Rows[0][0].ToString();
                        }
                        this.oleDbConnection_0.Close();
                        goto Label_01C4;
                    }
                }
                this.string_2 = "select goods_id from tblbarcode where barcode = '" + str + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_2, this.oleDbConnection_0);
                using (set2 = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set2);
                    if (set2.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_GoodsId.Text = set2.Tables[0].Rows[0][0].ToString();
                    }
                    this.oleDbConnection_0.Close();
                }
            }
        Label_01C4:
            str3 = this.Txt_GoodsId.Text.Trim();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT  A.goods_id, A.supp_id, A.full_name, A.packunit, A.piceunit, B.lastimppr, B.prefprice FROM  tblGoods AS A  INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id where A.goods_id = '" + str3 + "'", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Lbl_MercName.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
                this.Txt_Price.EditValue = Class7.smethod_0(dataSet.Tables[0].Rows[0]["prefprice"].ToString());
                this.Txt_Qty.Text = "1";
                this.Lbl_Unit.Text = dataSet.Tables[0].Rows[0]["piceunit"].ToString();
                this.Txt_EndQty.EditValue = new Class6().method_21(str3, "00002");
                this.Txt_Qty.Focus();
            }
            else
            {
                this.Lbl_MercName.Text = string.Empty;
                this.Txt_Price.EditValue = 0;
            }
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Class7.BrowserForm("select goods_id as 'M\x00e3 h\x00e0ng',supp_id AS NCC, full_name AS 'Diễn giải', piceunit AS [Đơn vị] from tblGoods where status = 1 and mbc = 0", Class7.oleDbConnection_1);
                this.Txt_GoodsId.Text = FrmBrowse.strReturn;
                this.Txt_GoodsId.SelectAll();
            }
        }
    
    }
}