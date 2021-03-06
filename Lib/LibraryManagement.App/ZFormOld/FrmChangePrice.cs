using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    public partial class FrmChangePrice : XtraForm
    {
        public FrmChangePrice()
        {
            InitializeComponent();
            this.oleDbConnection_0 = DataProvider.GetConnection();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if ((this.Txt_NewPrice.Text != "0") || (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1))
            {
                double num = Class7.ParseDoubleValue(this.Txt_NewPrice.Text);
                double num2 = Class7.ParseDoubleValue(this.txtNewPreferPr.Text);
                double num3 = 0.0;
                string str = DateTime.Now.ToString("HH:mm");
                new Class6().method_0(Class6.string_0, str, num, num3);
                this.string_0 = string.Concat(new object[] { "update tblprice set rtprice = ", num, ", prefprice = ", num2, " where goods_id = '", Class6.string_0, "'" });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                base.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FrmChangePrice_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void FrmChangePrice_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmChangePrice_Load(object sender, EventArgs e)
        {
            this.Text = "Thay đổi gi\x00e1 b\x00e1n lẻ";
            this.Lbl_GoodsId.Text = Class6.string_0;
            this.Txt_Averimppr.Enabled = false;
            this.Txt_RtPrice.Enabled = false;
            this.txtPreferPrice.Enabled = false;
            this.string_0 = "select gs.full_name, gs.grp_id, gs.supp_id, pr.rtprice, pr.lastimppr,pr.prefprice  FROM tblGoods AS gs INNER JOIN tblPrice AS pr ON gs.goods_id = pr.goods_id  WHERE gs.goods_id = '" + Class6.string_0 + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.Lbl_MercName.Text = set.Tables[0].Rows[0]["full_name"].ToString();
                this.Lbl_GrpId.Text = set.Tables[0].Rows[0]["grp_id"].ToString();
                this.Lbl_SuppId.Text = set.Tables[0].Rows[0]["supp_id"].ToString();
                this.Txt_Averimppr.Text = set.Tables[0].Rows[0]["lastimppr"].ToString();
                this.Txt_RtPrice.Text = set.Tables[0].Rows[0]["rtprice"].ToString();
                this.txtPreferPrice.Text = set.Tables[0].Rows[0]["prefprice"].ToString();
                this.txtNewPreferPr.Text = set.Tables[0].Rows[0]["prefprice"].ToString();
            }
        }



        private void Lbl_SuppId_Click(object sender, EventArgs e)
        {
        }

        private void Lbl_SuppId_TextChanged(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("fullname", "tblStore", "Id", this.Lbl_SuppId.Text, "", this.oleDbConnection_0, ref str);
            this.Lbl_SuppName.Text = str;
        }

        private void pfeZyQnoF(object sender, EventArgs e)
        {
            string str = null;
            Class7.smethod_17("description", "tblGoodsGrp", "Id", this.Lbl_GrpId.Text, "", this.oleDbConnection_0, ref str);
            this.ddvqeXfa4.Text = str;
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            double num = Class7.ParseDoubleValue(this.Txt_RtPrice.Text);
            double num2 = Class7.ParseDoubleValue(this.Txt_Averimppr.Text);
            double num3 = Class7.ParseDoubleValue(this.Txt_NewPrice.Text);
            double num5 = ((num2 == 0.0) || (num3 == 0.0)) ? 0.0 : (((num3 - num2) * 100.0) / num2);
            double num4 = ((num2 == 0.0) || (num == 0.0)) ? 0.0 : (((num - num2) * 100.0) / num2);
            this.Txt_SurplusPc.Text = num5.ToString();
            this.Txt_OldPc.Text = num4.ToString();
        }
    }
}