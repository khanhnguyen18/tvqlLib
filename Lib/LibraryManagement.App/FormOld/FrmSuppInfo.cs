using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    public partial class FrmSuppInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmSuppInfo()
        {
            InitializeComponent();
        }



        private void btn_Detail_Click(object sender, EventArgs e)
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                Class6.string_11 = this.Txt_Id.Text.Trim();
                new lst_stktransbycs().ShowPreviewDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnSuppMerc_Click(object sender, EventArgs e)
        {
            string str = this.Txt_Id.Text.Trim();
            if (!(str == string.Empty))
            {
                this.string_0 = "SELECT stk.id AS [M\x00e3 kho], gs.goods_id AS [M\x00e3 h\x00e0ng], gs.full_name AS [T\x00ean h\x00e0ng], gs.piceunit AS [Đơn vị], stk.begin_qty - stk.exp_qty + stk.imp_qty AS Tồn, stk.averimppr AS [Gi\x00e1 vốn]  FROM  tblGoods AS gs INNER JOIN  tblStockInfo AS stk ON gs.goods_id = stk.goods_id  WHERE gs.supp_id = '" + str + "'";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            string str = this.Txt_Id.Text.Trim();
            if (!(str == string.Empty))
            {
                new FrmGetDates().ShowDialog();
                if (Class7.IsInputDate)
                {
                    this.string_0 = string.Concat(new object[] { "SELECT tran_date AS Ng\x00e0y, tran_time AS Giờ, trans_num AS [Số GD], trans_code AS Loại, exp_id AS Xuất, imp_id AS Nhập, SUM(amount) AS [Tổng tiền],remark AS [Diễn giải] FROM tblTransaction WHERE exp_id = '", str, "' OR imp_id = '", str, "' AND (tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "') GROUP BY tran_date,tran_time,trans_num,trans_code,exp_id,imp_id,remark " });
                    Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                }
            }
        }

        private void FrmSuppInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Th\x00f4ng tin kh\x00e1ch h\x00e0ng";
            this.Txt_ShortName.Properties.ReadOnly = true;
            this.Txt_Address.Properties.ReadOnly = true;
            this.Txt_Phone.Properties.ReadOnly = true;
            this.Txt_Fax.Properties.ReadOnly = true;
            this.Txt_Contactperson.Properties.ReadOnly = true;
            this.Txt_VatNumber.Properties.ReadOnly = true;
            this.Txt_Id.Focus();
        }



        private void Txt_Id_EditValueChanged(object sender, EventArgs e)
        {
            this.string_0 = "SELECT * FROM tblStore WHERE Id = '" + this.Txt_Id.Text.Trim() + "' and Type > '02' and status = 1 ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (set.Tables[0].Rows.Count != 0)
                {
                    this.Txt_ShortName.Text = (string)set.Tables[0].Rows[0]["fullname"];
                    this.Txt_Address.Text = (string)set.Tables[0].Rows[0]["address"];
                    this.Txt_Phone.Text = (string)set.Tables[0].Rows[0]["phone"];
                    this.Txt_Fax.Text = (string)set.Tables[0].Rows[0]["fax"];
                    this.Txt_Contactperson.Text = (string)set.Tables[0].Rows[0]["contactps"];
                    this.Txt_VatNumber.Text = (string)set.Tables[0].Rows[0]["vatnum"];
                    Class6.string_11 = this.Txt_Id.Text.Trim();
                }
            }
        }

        private void Txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.string_0 = "SELECT Id AS 'M\x00e3 số', Name AS 'T\x00ean KH', fullname AS 'Diễn giải', Status FROM  tblStore WHERE Type > '02' AND Status = 1";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_Id.Text = BrowseForm.strReturn;
                this.Txt_Id.SelectAll();
            }
        }
  
    }
}