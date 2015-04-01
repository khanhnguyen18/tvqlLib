using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmDiscInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmDiscInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dataSet_0.Tables[0].Rows.Count; i++)
            {
                string str = this.dataSet_0.Tables[0].Rows[i][0].ToString().Trim();
                this.string_0 = "INSERT INTO DISCINFO(goods_id) VALUES('" + str + "')";
                Class7.smethod_4(this.string_0);
            }
            MessageBox.Show("OK");
        }


        private void FrmDiscInfo_Load(object sender, EventArgs e)
        {
            this.string_0 = "SELECT gs.goods_id, gs.full_name, pr.rtprice FROM tblgoods AS gs INNER JOIN tblPrice AS pr ON gs.goods_id = pr.goods_id WHERE gs.status = 1";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataTable table = new DataTable())
            {
                this.oleDbDataAdapter_0.Fill(table);
                this.oleDbConnection_0.Close();
                this.dataSet_0.Tables.Add(table);
            }
            this.gridView1.BestFitColumns();
        }



        private void method_0()
        {
        }

        private void method_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.pfeZyQnoF();
            }
        }

        private void method_2()
        {
        }

        private void method_3(object sender, EventArgs e)
        {
        }

        private void pfeZyQnoF()
        {
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
        }

        private void repositoryItemButtonEdit1_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
        }

        private void repositoryItemPopupContainerEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            Class7.BrowserForm("SELECT goods_id AS 'M\x00e3 số',short_name AS 'Diễn giải',Grp_id AS 'Nh\x00f3m', Status FROM tblGoods ", Class7.oleDbConnection_1);
        }

        private void repositoryItemPopupContainerEdit1_QueryDisplayText(object sender, QueryDisplayTextEventArgs e)
        {
        }

        private void repositoryItemPopupContainerEdit1_QueryPopUp(object sender, CancelEventArgs e)
        {
        }

        private void repositoryItemPopupContainerEdit1_QueryResultValue(object sender, QueryResultValueEventArgs e)
        {
        }

        private void repositoryItemTextEdit1_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            Class7.BrowserForm("SELECT goods_id AS 'M\x00e3 số',short_name AS 'Diễn giải',Grp_id AS 'Nh\x00f3m', Status FROM tblGoods ", Class7.oleDbConnection_1);
            this.repositoryItemTextEdit1.NullText = FrmBrowse.strReturn;
        }

        private void Txt_GoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            string str3;
            if (e.KeyCode == Keys.F5)
            {
                Class7.BrowserForm("select goods_id as 'M\x00e3 h\x00e0ng',barcode, full_name AS 'Diễn giải', grp_id AS [Nh\x00f3m], supp_id AS [M\x00e3 NCC] from tblGoods where status = 1 and mbc = 0", Class7.oleDbConnection_1);
                this.Txt_GoodsId.Text = FrmBrowse.strReturn;
                this.Txt_GoodsId.SelectAll();
            }
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
                DataSet set;
                if (str.Substring(0, str2.Length) == str2)
                {
                    this.string_0 = "select goods_id from tblNon_Plu where nplu_code = '" + str.Substring(0, str2.Length) + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        if (set.Tables[0].Rows.Count != 0)
                        {
                            this.Txt_GoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                        }
                        this.oleDbConnection_0.Close();
                        goto Label_0203;
                    }
                }
                this.string_0 = "select goods_id from tblbarcode where barcode = '" + str + "'";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
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
        Label_0203:
            str3 = this.Txt_GoodsId.Text.Trim();
            string str4 = null;
            string str5 = null;
            string str6 = null;
            string str7 = null;
            string str8 = null;
            string str9 = null;
            string str10 = null;
            Class7.smethod_17("full_name", "tblGoods", "goods_id", str3, "", Class7.oleDbConnection_1, ref str4);
            this.Lbl_MercName.Text = str4;
            Class7.smethod_17("grp_id", "tblGoods", "goods_id", str3, "", Class7.oleDbConnection_1, ref str5);
            this.Lbl_GrpId.Text = str5;
            Class7.smethod_17("supp_id", "tblGoods", "goods_id", str3, "", Class7.oleDbConnection_1, ref str6);
            this.Lbl_SuppId.Text = str6;
            Class7.smethod_17("rtprice", "tblPrice", "goods_id", str3, "", Class7.oleDbConnection_1, ref str7);
            this.Lbl_Rtprice.Text = string.Format("{0:n0}", Class7.smethod_0(str7));
            Class7.smethod_17("wsprice", "tblPrice", "goods_id", str3, "", Class7.oleDbConnection_1, ref str8);
            this.Lbl_WsPrice.Text = string.Format("{0:n2}", Class7.smethod_0(str8));
            Class7.smethod_17("lastimppr", "tblPrice", "goods_id", str3, "", Class7.oleDbConnection_1, ref str9);
            this.Lbl_Lastimppr.Text = string.Format("{0:n2}", Class7.smethod_0(str9));
            Class7.smethod_17("prefprice", "tblPrice", "goods_id", str3, "", Class7.oleDbConnection_1, ref str10);
            if (this.Lbl_MercName.Text != string.Empty)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT [Image] FROM tblGoods WHERE goods_id = '" + str3 + "'", Class7.oleDbConnection_1);
                using (DataSet set2 = new DataSet())
                {
                    adapter.Fill(set2);
                    Class7.oleDbConnection_1.Close();
                    try
                    {
                        byte[] buffer = (byte[])set2.Tables[0].Rows[0][0];
                        this.PicGoods.Image = Class7.smethod_21(buffer);
                    }
                    catch (Exception)
                    {
                        this.PicGoods.Image = null;
                    }
                }
                this.method_0();
            }
        }
    }
}