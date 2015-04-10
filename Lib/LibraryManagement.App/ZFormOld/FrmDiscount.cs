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
    public partial class FrmDiscount : DevExpress.XtraEditors.XtraForm
    {
        public FrmDiscount()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
            {
                DataSet set;
                string str = string.Format("{0:d}", this.Txt_FrDate.EditValue);
                string str2 = string.Format("{0:d}", this.Txt_ToDate.EditValue);
                double num = Class7.smethod_0(this.Txt_DiscPercent.EditValue.ToString());
                switch (this.radioGroup1.SelectedIndex)
                {
                    case 0:
                        if (!(this.Lbl_GrpName.Text == string.Empty))
                        {
                            this.oleDbDataAdapter_0 = new OleDbDataAdapter("select goods_id from tblgoods where grp_id = '" + this.Txt_GoodsGrp.Text.Trim() + "'", this.oleDbConnection_0);
                            DataTable dataTable = new DataTable();
                            this.oleDbDataAdapter_0.Fill(dataTable);
                            this.oleDbConnection_0.Close();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                this.string_0 = string.Concat(new object[] { "UPDATE tblPrice SET discpercent = ", num, ", disc_frdate = '", str, "', disc_todate = '", str2, "' where goods_id = '", row["goods_id"], "'" });
                                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                                using (set = new DataSet())
                                {
                                    this.oleDbDataAdapter_0.Fill(set);
                                }
                                this.oleDbConnection_0.Close();
                            }
                            Class7.ShowMessageBox("Đặt chiết khấu th\x00e0nh c\x00f4ng", 1);
                            base.Close();
                            break;
                        }
                        Class7.ShowMessageBox("Bạn chưa chọn nh\x00f3m h\x00e0ng được chiết khấu", 1);
                        this.Txt_GoodsGrp.Focus();
                        break;

                    case 1:
                        this.string_0 = string.Concat(new object[] { "UPDATE tblPrice SET discpercent = ", num, ", disc_frdate = '", str, "', disc_todate = '", str2, "' " });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                        }
                        this.oleDbConnection_0.Close();
                        Class7.ShowMessageBox("Đặt chiết khấu th\x00e0nh c\x00f4ng", 1);
                        base.Close();
                        break;
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void FrmDiscount_Load(object sender, EventArgs e)
        {
            this.Text = Class7.smethod_14("m_softname").ToString();
            this.Txt_ToDate.EditValue = DateTime.Parse(Class7.smethod_19());
            this.Txt_FrDate.EditValue = DateTime.Parse(Class7.smethod_19());
        }



        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.Txt_GoodsGrp.Enabled = this.radioGroup1.SelectedIndex == 0;
        }

        private void Txt_GoodsGrp_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.Txt_GoodsGrp.Text.Trim();
            string str2 = null;
            Class7.smethod_17("description", "tblGoodsGrp", "Id", str, "and status = 1", this.oleDbConnection_0, ref str2);
            this.Lbl_GrpName.Text = str2;
        }

        private void Txt_GoodsGrp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Class7.BrowserForm1("select Id as 'M\x00e3 số', description AS 'Diễn giải', Status from tblGoodsGrp", this.oleDbConnection_0);
                this.Txt_GoodsGrp.Text = BrowseForm.strReturn;
            }
        }
  
    }
}