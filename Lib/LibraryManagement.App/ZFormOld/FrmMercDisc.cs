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
    public partial class FrmMercDisc : DevExpress.XtraEditors.XtraForm
    {
        public FrmMercDisc()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string str = string.Format("{0:d}", this.Txt_FrDate.EditValue);
            string str2 = string.Format("{0:d}", this.Txt_ToDate.EditValue);
            double num = Class7.smethod_0(this.Txt_DiscPercent.EditValue.ToString()) / 100.0;
            this.string_0 = string.Concat(new object[] { "UPDATE tblPrice SET  discpercent = ", num, ", disc_frdate = '", str, "',disc_todate = '", str2, "'  WHERE goods_id = '", this.Lbl_GoodsId.Text, "'" });
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
            }
            base.Close();
        }


        private void FrmMercDisc_Load(object sender, EventArgs e)
        {
            this.Text = "Đặt chiết khấu b\x00e1n lẻ";
            this.Lbl_GoodsId.Text = Class6.string_0;
            this.string_0 = "select gs.full_name, pr.rtprice, pr.discpercent,pr.disc_frdate, pr.disc_todate  FROM tblGoods AS gs INNER JOIN tblPrice AS pr ON gs.goods_id = pr.goods_id  WHERE gs.goods_id = '" + Class6.string_0 + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                this.Lbl_MercName.Text = set.Tables[0].Rows[0]["full_name"].ToString();
                this.Txt_RtPrice.Text = set.Tables[0].Rows[0]["rtprice"].ToString();
                this.Txt_FrDate.Text = set.Tables[0].Rows[0]["disc_frdate"].ToString();
                this.Txt_ToDate.Text = set.Tables[0].Rows[0]["disc_todate"].ToString();
                this.Txt_DiscPercent.EditValue = Class7.smethod_0(set.Tables[0].Rows[0]["discpercent"].ToString()) * 100.0;
                this.Txt_RtPrice.Enabled = false;
            }
        }

        private void IipWvDcZu_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}