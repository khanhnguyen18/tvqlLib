using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class FrmMercPosView : DevExpress.XtraEditors.XtraForm
    {
        public FrmMercPosView()
        {
            InitializeComponent();
        }



        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        
        private void FrmMercPosView_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmMercPosView_Load(object sender, EventArgs e)
        {
            this.Text = "T\x00ecm kiếm h\x00e0ng h\x00f3a";
            this.method_1();
            this.Txt_GoodsId.Focus();
            this.method_0();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Txt_GoodsId.Text = this.gridView2.GetRowCellValue(this.gridView2.FocusedRowHandle, "M\x00e3 h\x00e0ng").ToString();
            }
            catch (Exception)
            {
            }
        }



        private void Lbl_GrpId_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("description", "tblGoodsGrp", "id", this.Lbl_GrpId.Text, "", Class7.oleDbConnection_1, ref str);
            this.Lbl_GrpName.Text = str;
        }

        private void method_0()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT stk.goods_id, stk.id AS [M\x00e3 số], store.fullname AS [T\x00ean kho, quầy], (stk.begin_qty + stk.imp_qty) - stk.exp_qty AS [Hiện tồn] ,stk.last_date AS [Ng\x00e0y GD cuối] FROM tblStockInfo AS stk INNER JOIN tblStore AS store ON stk.id = store.id where stk.goods_id = '" + this.Txt_GoodsId.Text.Trim() + "' and (stk.begin_qty + stk.imp_qty) - stk.exp_qty <> 0 ", Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
            this.gridControl1.DataSource = dataSet.Tables[0];
            this.gridView1.Columns["goods_id"].Visible = false;
            this.gridView1.Columns["Hiện tồn"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView1.Columns["Hiện tồn"].DisplayFormat.FormatString = "{0:n2}";
            this.gridView1.Columns["Hiện tồn"].SummaryItem.FieldName = "Hiện tồn";
            this.gridView1.Columns["Hiện tồn"].SummaryItem.SummaryType = SummaryItemType.Sum;
            this.gridView1.Columns["Hiện tồn"].SummaryItem.DisplayFormat = "{0:n2}";
            this.gridView1.Columns["Ng\x00e0y GD cuối"].DisplayFormat.FormatType = FormatType.DateTime;
            this.gridView1.Columns["Ng\x00e0y GD cuối"].DisplayFormat.FormatString = "{0:dd/MM/yyyy}";
            this.gridView1.BestFitColumns();
        }

        private void method_1()
        {
            this.string_1 = "SELECT gs.goods_id AS [M\x00e3 h\x00e0ng], gs.barcode, gs.grp_id AS Nh\x00f3m, gs.full_name AS [T\x00ean h\x00e0ng],  gs.piceunit AS [ĐVT], pr.rtprice AS [Gi\x00e1 b\x00e1n lẻ]  FROM tblGoods AS gs INNER JOIN tblPrice AS pr ON gs.goods_id = pr.goods_id ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.gridControl2.DataSource = set.Tables[0];
            }
            this.gridView2.Columns["Gi\x00e1 b\x00e1n lẻ"].DisplayFormat.FormatType = FormatType.Numeric;
            this.gridView2.Columns["Gi\x00e1 b\x00e1n lẻ"].DisplayFormat.FormatString = "{0:n0}";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.BestFitColumns();
        }

        private void Txt_GoodsId_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            DataSet set;
            string str3;
            if (e.KeyCode != Keys.Return)
            {
                return;
            }
            string str = this.Txt_GoodsId.Text.Trim();
            string str2 = Class7.smethod_14("m_plu").ToString().Trim();
            if (str == string.Empty)
            {
                return;
            }
            if (str.Length > 6)
            {
                if (str.Substring(0, str2.Length) == str2)
                {
                    this.string_1 = "select goods_id from tblNon_Plu where nplu_code = '" + str.Substring(0, str2.Length) + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        if (set.Tables[0].Rows.Count != 0)
                        {
                            this.Txt_GoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                            this.oleDbConnection_0.Close();
                        }
                        goto Label_01CA;
                    }
                }
                this.string_1 = "select goods_id from tblbarcode where barcode = '" + str + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_GoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                    }
                    this.oleDbConnection_0.Close();
                }
            }
        Label_01CA:
            str3 = this.Txt_GoodsId.Text.Trim();
            this.string_1 = "SELECT gs.full_name, gs.grp_id, pr.rtprice from tblGoods as gs inner join tblPrice as pr on gs.goods_id = pr.goods_id where gs.goods_id = '" + str3 + "'";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            using (set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    this.Lbl_MercName.Text = set.Tables[0].Rows[0]["full_name"].ToString();
                    this.Lbl_GrpId.Text = set.Tables[0].Rows[0]["grp_id"].ToString();
                    this.Lbl_Rtprice.Text = string.Format("{0:n0}", set.Tables[0].Rows[0]["rtprice"]);
                }
            }
            this.method_0();
            Class11.smethod_9("tblbarcode", "barcode", "where goods_id = '" + str3 + "'", this.Cmb_Barcode, 0, this.oleDbConnection_0);
        }
   
    }
}