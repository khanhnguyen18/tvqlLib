using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmVatCorrect : DevExpress.XtraEditors.XtraForm
    {
        public FrmVatCorrect()
        {
            InitializeComponent();
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.cmbVatRate.SelectedIndex == -1)
            {
                Class7.ShowMessageBox("Bạn chưa khai b\x00e1o thuế suất mới ?", 1);
            }
            else if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
            {
                DataSet set;
                string str2 = this.txtGoodsId.Text.Trim();
                string str = "";
                switch (this.cmbVatRate.SelectedIndex)
                {
                    case 0:
                        str = "10";
                        break;

                    case 1:
                        str = "5";
                        break;

                    case 2:
                        str = "0";
                        break;
                }
                this.IjSwogAv6 = "update tblGoods set tax_code =  '" + str + "' where goods_id = '" + str2 + "' ";
                Class7.smethod_4(this.IjSwogAv6);
                double num = new Class6().method_16("00002", this.txtGoodsId.Text.Trim());
                double num2 = (1.0 + (Class10.smethod_1(this.txtGoodsId.Text.Trim()) / 100.0)) * (Class10.smethod_1(this.txtGoodsId.Text.Trim()) / 100.0);
                if (num2 != 0.0)
                {
                    this.IjSwogAv6 = string.Concat(new object[] { "update tblTransaction set vat_amt = amount/ ", num2 * 100.0, " where trans_code = '00' and goods_id = '", this.txtGoodsId.Text.Trim(), "'" });
                }
                else
                {
                    this.IjSwogAv6 = "update tblTransaction set vat_amt = 0 where trans_code = '00' and goods_id = '" + this.txtGoodsId.Text.Trim() + "'";
                }
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.IjSwogAv6, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.IjSwogAv6 = string.Concat(new object[] { "update tbltransaction set surplus = amount - (vat_amt + (", num, " * qty )) where trans_code = '00' and goods_id = '", this.txtGoodsId.Text.Trim(), "'" });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.IjSwogAv6, this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                Class7.ShowMessageBox("Hiệu chỉnh th\x00e0nh c\x00f4ng", 1);
            }
        }

        private void FrmVatCorrect_Load(object sender, EventArgs e)
        {
            this.Text = "Hiệu chỉnh lại thuế GTGT đầu ra";
            this.cmbVatRate.SelectedIndex = 0;
        }



        private void txtGoodsId_EditValueChanged(object sender, EventArgs e)
        {
            this.lblMercName.Text = Class7.smethod_29("tblGoods", "full_name", "goods_id", this.txtGoodsId.Text.Trim(), "", this.oleDbConnection_0).ToString();
            this.lblOldTaxRate.Text = Class7.smethod_29("tblGoods", "tax_code", "goods_id", this.txtGoodsId.Text.Trim(), "", this.oleDbConnection_0).ToString();
        }

        private void txtGoodsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.IjSwogAv6 = "SELECT goods_id AS [M\x00e3 số],short_name AS [Diễn giải],Grp_id AS [Nh\x00f3m], Status FROM tblGoods ORDER BY goods_id";
                Class7.BrowserForm1(this.IjSwogAv6, this.oleDbConnection_0);
                this.txtGoodsId.Text = BrowseForm.strReturn;
                this.txtGoodsId.SelectAll();
            }
            if (e.KeyCode == Keys.Return)
            {
                string str = this.txtGoodsId.Text.Trim();
                string str2 = Class7.smethod_14("m_plu").ToString().Trim();
                if (str.Length > 6)
                {
                    DataSet set;
                    if (str.Substring(0, str2.Length) == str2)
                    {
                        this.IjSwogAv6 = "select goods_id from tblNon_Plu where nplu_code = '" + str.Substring(0, str2.Length) + "'";
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.IjSwogAv6, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            if (set.Tables[0].Rows.Count != 0)
                            {
                                this.txtGoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                            }
                            this.oleDbConnection_0.Close();
                            return;
                        }
                    }
                    this.IjSwogAv6 = "select goods_id from tblbarcode where barcode = '" + str + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.IjSwogAv6, this.oleDbConnection_0);
                    using (set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        if (set.Tables[0].Rows.Count != 0)
                        {
                            this.txtGoodsId.Text = set.Tables[0].Rows[0][0].ToString();
                        }
                        this.oleDbConnection_0.Close();
                    }
                }
            }
        }
   
    }
}