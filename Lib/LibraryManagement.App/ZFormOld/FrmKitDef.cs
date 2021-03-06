using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
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
    public partial class FrmKitDef : XtraForm
    {
        public FrmKitDef()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.Txt_Description.Focus();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            Class11.smethod_9("tblUnit", "Id", "where status =1", this.Cmb_PackUnit, 1, this.oleDbConnection_0);
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("delete from " + this.string_1, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
            }
            this.method_0();
            this.Txt_Id.Text = Class7.smethod_9(base.Tag.ToString(), "K{0:00000}", this.oleDbConnection_0);
            new Class6();
            this.ddvqeXfa4.Enabled = false;
            this.Txt_RtPrice.Enabled = false;
            this.Txt_Description.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Txt_Description.Text == string.Empty)
            {
                this.Txt_Description.Focus();
            }
            else if (this.Cmb_PackUnit.SelectedIndex == -1)
            {
                Class7.ShowMessageBox("Bạn chưa chọn đơn vị cho g\x00f3i h\x00e0ng", 1);
                this.Cmb_PackUnit.Focus();
            }
            else
            {
                string selectCommandText = null;
                string str3 = this.Txt_Id.Text.Trim();
                string str4 = this.Txt_Description.Text.Trim();
                double num = Class7.ParseDoubleValue(this.Txt_RtPrice.Text);
                string str5 = this.Cmb_PackUnit.Text.Trim();
                string str = Class11.string_0;
                if (str != null)
                {
                    DataSet set;
                    DataTable table;
                    if (str != "N")
                    {
                        if (!(str == "E"))
                        {
                            return;
                        }
                        this.btn_Skip_Click(this, new EventArgs());
                        selectCommandText = string.Concat(new object[] { "UPDATE ", base.Tag, " SET rtprice = ", num, " WHERE id = '", str3, "',unitsymb = '", str5, "';DELETE FROM tblKit_Info WHERE kit_id = '", str3, "' " });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                        }
                        selectCommandText = "SELECT goods_id, qty from " + this.string_1;
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                        using (table = new DataTable())
                        {
                            this.oleDbDataAdapter_0.Fill(table);
                            this.oleDbConnection_0.Close();
                            foreach (DataRow row in table.Rows)
                            {
                                selectCommandText = string.Concat(new object[] { "INSERT INTO tblKit_Info(kit_id,goods_id,qty) VALUES('", str3, "','", row[0], "','", row[1], "') " });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                                using (set = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set);
                                    this.oleDbConnection_0.Close();
                                    continue;
                                }
                            }
                            return;
                        }
                    }
                    this.btn_Skip_Click(this, new EventArgs());
                    selectCommandText = string.Concat(new object[] { "INSERT INTO ", base.Tag, "(id, description,unitsymb, rtprice,open_date) VALUES ('", str3, "',N'", str4, "','", str5, "',", num, ",'", Class7.smethod_19(), "') " });
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        this.oleDbConnection_0.Close();
                    }
                    selectCommandText = "SELECT goods_id, qty from " + this.string_1;
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                    using (table = new DataTable())
                    {
                        this.oleDbDataAdapter_0.Fill(table);
                        this.oleDbConnection_0.Close();
                        foreach (DataRow row in table.Rows)
                        {
                            selectCommandText = string.Concat(new object[] { "INSERT INTO tblKit_Info(kit_id,goods_id,qty) VALUES('", str3, "','", row[0], "','", row[1], "') " });
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
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_8(this);
            Class11.smethod_5(this, "F");
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("delete from " + this.string_1, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
            }
            this.method_0();
            this.Txt_Id.Enabled = true;
            this.Txt_Id.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
        }


        private void FrmKitDef_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("DROP TABLE " + this.string_1, this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            this.oleDbConnection_0.Close();
        }

        private void FrmKitDef_Load(object sender, EventArgs e)
        {
            DataSet set;
            this.btn_Skip_Click(this, new EventArgs());
            try
            {
                string selectCommandText = "CREATE TABLE " + this.string_1 + "([autoid] [int] IDENTITY(1,1) ,[goods_id] [nvarchar](6) DEFAULT (''),[Name] [nvarchar](80) DEFAULT (''),[qty] [decimal](8, 2) DEFAULT ((1)),[unitsymb] [nvarchar](3) DEFAULT (('')),[price] [decimal](18, 2) DEFAULT ((0)))";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
            catch (Exception)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("DELETE FROM " + this.string_1, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                }
                this.oleDbConnection_0.Close();
            }
            base.Tag = "tblKit";
            this.Text = "Đăng k\x00fd m\x00e3 g\x00f3i b\x00f3";
            this.method_0();
        }



        private void method_0()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select goods_id AS [M\x00e3 h\x00e0ng], Name AS [T\x00ean h\x00e0ng], unitsymb AS [Đơn vị], qty AS SL, price AS [Gi\x00e1 b\x00e1n] from " + this.string_1, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl1.DataSource = set.Tables[0];
            }
            this.gridView1.BestFitColumns();
            this.gridView1.Columns["Gi\x00e1 b\x00e1n"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Gi\x00e1 b\x00e1n"].DisplayFormat.FormatString = "{0:n2}";
        }

        private void pfeZyQnoF(object sender, EventArgs e)
        {
            if (this.Lbl_MercName.Text != string.Empty)
            {
                DataSet set;
                string str2 = this.Txt_GoodsId.Text.Trim();
                string text = this.Lbl_MercName.Text;
                string str4 = this.Txt_Unit.Text;
                double num = Class7.ParseDoubleValue(this.Txt_Qty.Text);
                double num2 = Class7.ParseDoubleValue(this.ddvqeXfa4.Text);
                string selectCommandText = string.Concat(new object[] { 
                    "IF NOT EXISTS (SELECT goods_id from ", this.string_1, " WHERE goods_id = '", str2, "')INSERT INTO ", this.string_1, "(goods_id, Name, qty, unitsymb, price) VALUES ('", str2, "',N'", text, "',", num, ",'", str4, "',", num2, 
                    ")  ELSE UPDATE ", this.string_1, " SET qty = ", num, " WHERE goods_id = '", str2, "'; DELETE FROM ", this.string_1, " WHERE qty <= 0 "
                 });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.Txt_GoodsId.Focus();
                this.method_0();
                selectCommandText = "SELECT SUM(qty*price) FROM " + this.string_1;
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(selectCommandText, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    this.Txt_RtPrice.Text = set.Tables[0].Rows[0][0].ToString();
                }
            }
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_GoodsId.Text.Trim();
            if (str != string.Empty)
            {
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT  A.goods_id, A.full_name, A.packunit, A.piceunit, B.lastimppr, B.rtprice FROM  tblGoods AS A  INNER JOIN tblPrice AS B ON A.goods_id = B.goods_id where A.goods_id = '" + str + "'", this.oleDbConnection_0);
                DataSet dataSet = new DataSet();
                this.oleDbDataAdapter_0.Fill(dataSet);
                this.oleDbConnection_0.Close();
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    this.Lbl_MercName.Text = dataSet.Tables[0].Rows[0]["full_name"].ToString();
                    this.ddvqeXfa4.EditValue = Class7.ParseDoubleValue(dataSet.Tables[0].Rows[0]["rtprice"].ToString());
                    this.Txt_Unit.Text = dataSet.Tables[0].Rows[0]["piceunit"].ToString();
                    this.Txt_Qty.Text = "1";
                    this.Txt_GoodsId.Focus();
                }
                else
                {
                    this.Lbl_MercName.Text = string.Empty;
                    this.ddvqeXfa4.EditValue = 0;
                }
            }
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("SELECT goods_id AS 'M\x00e3 số',short_name AS 'Diễn giải',Grp_id AS 'Nh\x00f3m', Status FROM tblGoods ", Class7.oleDbConnection_1);
                this.Txt_GoodsId.Text = BrowseForm.strReturn;
                this.Txt_GoodsId.SelectAll();
            }
        }

        private void Txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            string str = this.Txt_Id.Text.Trim();
            if (e.KeyCode == Keys.F2)
            {
                this.string_0 = "select id, description, rtprice from tblKit ";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_Id.Text = BrowseForm.strReturn;
                this.Txt_Id.SelectAll();
            }
            if (e.KeyCode == Keys.Return)
            {
                this.string_0 = "select id, description, rtprice from tblKit where id = '" + str + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count == 0)
                    {
                        Class7.ShowMessageBox("M\x00e3 g\x00f3i, b\x00f3 kh\x00f4ng tồn tại, bạn h\x00e3y kiểm tra lại", 1);
                        this.Txt_Id.SelectAll();
                    }
                    else
                    {
                        this.Txt_Description.Text = set.Tables[0].Rows[0]["description"].ToString();
                        this.Txt_RtPrice.Text = set.Tables[0].Rows[0]["rtprice"].ToString();
                        this.string_0 = "SELECT  kit.kit_id, kit.goods_id, kit.qty, gs.full_name, gs.piceunit, pr.rtprice  FROM tblGoods AS gs INNER JOIN  tblPrice AS pr ON gs.goods_id = pr.goods_id INNER JOIN  tblKit_info AS kit ON gs.goods_id = kit.goods_id  WHERE kit.kit_id = '" + str + "' ";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (DataTable table = new DataTable())
                        {
                            this.oleDbDataAdapter_0.Fill(table);
                            this.oleDbConnection_0.Close();
                            foreach (DataRow row in table.Rows)
                            {
                                this.string_0 = string.Concat(new object[] { "INSERT INTO ", this.string_1, "(goods_id, Name, qty, unitsymb, price)  VALUES('", row["goods_id"], "',N'", row["full_name"], "', ", row["qty"], ",'", row["piceunit"], "',", row["rtprice"], ")" });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                                using (DataSet set2 = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set2);
                                    this.oleDbConnection_0.Close();
                                    continue;
                                }
                            }
                        }
                        this.method_0();
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                    }
                }
            }
        }

        private void welftZbha_Click(object sender, EventArgs e)
        {
            base.Close();
        }
   
    }
}