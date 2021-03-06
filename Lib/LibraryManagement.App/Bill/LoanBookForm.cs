using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.CoreServices;
namespace LibraryManagement.App
{
    public partial class LoanBookForm : XtraForm
    {
        public LoanBookForm()
        {
            InitializeComponent();
            this.oleDbConnection_0 = DataProvider.GetConnection();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.txtGoodsid.Text == string.Empty)
                return;

            if (!Class2.CheckCsCard(this.txtCsId.Text.Trim()))
            {
                Class7.ShowMessageBox("Số thẻ này đã hết hạn hoặc đã bị xóa !", 1);
                return;
            }

            if (this.lblBookName.Text == string.Empty)
            {
                this.txtGoodsid.Focus();
                return;
            }

            if (System.Configuration.ConfigurationManager.AppSettings["tk"] == "1")
            {
                Class6 class2 = new Class6();
                if (!class2.method_22() && (class2.method_21(this.txtGoodsid.Text, Class7.smethod_40()) < 1.0))
                {
                    Class7.ShowMessageBox("Số lượng tồn kh\x00f4ng đủ để cho mượn !", 1);
                    this.txtGoodsid.Focus();
                    this.txtGoodsid.SelectAll();
                    return;
                }
            }

            try
            {
                string str = string.Format("{0:d}", this.txtDuedate.EditValue);
                DataRow row = this.dataSet_0.Tables["loantran"].NewRow();
                row["idx"] = this.dataSet_0.Tables["loantran"].Rows.Count + 1;
                row["goods_id"] = this.txtGoodsid.Text;
                row["full_name"] = this.lblBookName.Text;
                row["due_date"] = str;
                row["csname"] = this.lblName.Text;
                row["address"] = this.lblAddress.Text;
                row["trannum"] = this.txtTransNum.Text;
                row["phone"] = this.cnvLekth7.Text;
                row["remark"] = this.txtRemark.Text;
                this.dataSet_0.Tables["loantran"].Rows.Add(row);
                this.gridControl1.Refresh();
            }
            catch (Exception)
            {
                Class7.ShowMessageBox("Đ\x00e3 c\x00f3 s\x00e1ch n\x00e0y trong danh mục mượn", 1);
            }
            finally
            {
                this.txtGoodsid.Text = string.Empty;
                this.txtGoodsid.Focus();
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Class11.string_0 == "F")
            {
                string str = this.txtTransNum.Text.Trim();
                string str4 = Class7.smethod_40();
                Class6 class2 = new Class6();
                string text = this.btn_Delete.Text;
                if (text != null)
                {
                    if (text != "&X\x00f3a")
                    {
                        if ((text == "&Phục hồi") && (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn phục hồi phiếu n\x00e0y kh\x00f4ng ?", 2) == 1))
                        {
                            class2.method_14("tblLoantran", str, 1);
                            for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
                            {
                                string str3 = this.dataSet_0.Tables["loantran"].Rows[i]["goods_id"].ToString();
                                Class2.iWyIskLbe(str4, str3, 1.0);
                            }
                            this.btn_Skip_Click(this, new EventArgs());
                        }
                    }
                    else if (!Class2.smethod_4(this.txtTransNum.Text))
                    {
                        Class7.ShowMessageBox("Phiếu n\x00e0y đ\x00e3 c\x00f3 s\x00e1ch được trả kh\x00f4ng thể x\x00f3a", 1);
                    }
                    else if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn x\x00f3a phiếu n\x00e0y kh\x00f4ng ?", 2) == 1)
                    {
                        class2.method_14("tblLoantran", str, 0);
                        Class2.smethod_0(str);
                        this.btn_Skip_Click(this, new EventArgs());
                    }
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_Move_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataSet_0.Tables[0].Rows[this.int_0].Delete();
            }
            catch (Exception)
            {
            }
            for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
            {
                this.dataSet_0.Tables["loantran"].Rows[i]["idx"] = i + 1;
            }
            this.gridControl1.Refresh();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_1(this);
            Class11.smethod_5(this, "T");
            Class11.smethod_8(this);
            this.txtTransNum.Text = new Class6().method_5("H");
            this.txtDate.Text = Class7.smethod_19();
            this.txtDate.Enabled = false;
            this.txtTransNum.Enabled = false;
            this.dataSet_0.Clear();
            this.gridControl1.Refresh();
            this.txtCsId.Focus();
            this.status = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.lblName.Text == string.Empty)
            {
                ToolsGui.ShowMessageBox("Bạn chưa chọn thông tin người mượn", 1);
                this.txtCsId.Focus();
                return;
            }

            string transNum = this.txtTransNum.Text.Trim();
            string stat = this.status;
            if (stat != null)
            {
                if (!(stat == "N"))//new
                {
                    if (stat == "E")//Edit
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        this.method_0();
                        LoanTransServiceManage.DeleteByTransactionCode(transNum);
                        this.Insert();
                    }
                }
                else
                {
                    this.btn_Skip_Click(this, new EventArgs());
                    new Class6().ComputeTransnum("H");
                    this.method_0();
                    this.Insert();
                }
                Class6.transNum = transNum;
                new loan_inv().ShowPreviewDialog();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.status = "S";
            this.string_0 = "SELECT DISTINCT tr.trans_num AS [Số phiếu], tr.tran_time AS [Giờ], tr.cs_id AS [Số thẻ],cs.fullname AS [Họ t\x00ean], tr.status AS [Trạng th\x00e1i] FROM tblLoanTran AS tr INNER JOIN tblCustomer AS cs ON tr.cs_id = cs.id WHERE tr.trans_code = '60'";
            Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
            this.txtTransNum.Enabled = true;
            this.txtTransNum.Text = BrowseForm.strReturn;
            this.txtTransNum.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.status = "D";
        }

        private void btnAddGrp_Click(object sender, EventArgs e)
        {
            new ReaderForm().ShowDialog();
        }


        private void FrmLoanInfo_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
                base.WindowState = FormWindowState.Maximized;
        }

        private void FrmLoanInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Quản l\x00fd s\x00e1ch mượn";

            this.gridView1.OptionsBehavior.Editable = false;
            this.txtDuedate.EditValue = DateTime.Now.AddDays(10.0);
            this.btn_Skip_Click(this, new EventArgs());
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.txtGoodsid.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "goods_id").ToString();
                this.int_0 = int.Parse(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "idx").ToString()) - 1;
            }
            catch (Exception)
            {
                this.int_0 = -1;
            }
        }

        private void method_0()
        {
            for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
            {
                this.dataSet_0.Tables["loantran"].Rows[i]["remark"] = this.txtRemark.Text;
            }
        }

        private void Insert()
        {
            string str = string.Format("{0:d}", this.txtDuedate.EditValue);
            string str2 = this.txtTransNum.Text.Trim();
            string str4 = (this.txtRemark.Text == string.Empty) ? "Phiếu cho mượn s\x00e1ch" : this.txtRemark.Text.Trim();
            string str3 = this.txtCsId.Text.Trim();
            for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
            {
                object obj2 = this.dataSet_0.Tables["loantran"].Rows[i]["goods_id"];
                this.string_0 = string.Concat(new object[] { 
                    "INSERT INTO tblLoanTran(trans_num, tran_date,trans_code, tran_time, exp_id, cs_id, goods_id, qty, due_date, user_id, remark, status) VALUES ('", str2, "','", Class7.smethod_19(), "','", this.string_2, "','", Class7.smethod_53(), "','", Class7.smethod_40(), "','", str3, "','", obj2, "',1,'", str, 
                    "',", Class7.GetUserId(), ",N'", str4, "',1)"
                 });
                Class7.smethod_4(this.string_0);
                Class2.iWyIskLbe(Class7.smethod_40(), obj2.ToString(), 1.0);
            }
        }

        private void method_2(object sender, EventArgs e)
        {
            if (!Class2.smethod_4(this.txtTransNum.Text))
            {
                Class7.ShowMessageBox("Phiếu n\x00e0y đ\x00e3 c\x00f3 s\x00e1ch được trả kh\x00f4ng thể sửa", 1);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new BookForm().ShowDialog();
        }

        private void txtCsId_EditValueChanged(object sender, EventArgs e)
        {
            if (this.txtCsId.Text.Length >= 8)
            {
                string str = this.txtCsId.Text.Trim();
                this.lblName.Text = Class7.smethod_29("tblCustomer", "fullname", "id", str, "", this.oleDbConnection_0).ToString();
                this.cnvLekth7.Text = Class7.smethod_29("tblCustomer", "phone", "id", str, "", this.oleDbConnection_0).ToString();
                this.lblEmail.Text = Class7.smethod_29("tblCustomer", "email", "id", str, "", this.oleDbConnection_0).ToString();
                this.lblAddress.Text = Class7.smethod_29("tblCustomer", "address", "id", str, "", this.oleDbConnection_0).ToString();
                try
                {
                    byte[] buffer = (byte[])Class7.smethod_29("tblCustomer", "image", "id", str, "", this.oleDbConnection_0);
                    this.pictureEdit1.Image = Class7.smethod_21(buffer);
                }
                catch (Exception)
                {
                    this.pictureEdit1.Image = null;
                }
            }
        }

        private void txtCsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.string_0 = "SELECT id AS [M\x00e3 thẻ], fullname AS [Họ v\x00e0 t\x00ean], phone AS [Số ĐT], status AS [Trạng th\x00e1i] from tblCustomer";
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.txtCsId.Text = BrowseForm.strReturn;
            }
        }

        private void txtGoodsid_EditValueChanged(object sender, EventArgs e)
        {
            this.lblBookName.Text = Class7.smethod_29("tblGoods", "full_name", "goods_id", this.txtGoodsid.Text.Trim(), "", this.oleDbConnection_0).ToString();
        }

        private void txtGoodsid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.string_0 = "SELECT gs.goods_id AS [M\x00e3 số],gs.short_name AS [T\x00ean s\x00e1ch],grp.description AS [Loại s\x00e1ch], PARSENAME(convert(varchar,convert(MONEY,pr.rtprice),1),0 ) AS [Gi\x00e1 b\x00eca], gs.Status AS [Trạng th\x00e1i] FROM tblGoods AS gs INNER JOIN tblGoodsGrp AS grp ON gs.grp_id = grp.id INNER JOIN tblPrice AS pr ON gs.goods_id = pr.goods_id ";
                Class7.BrowserForm1(this.string_0, Class7.oleDbConnection_1);
                this.txtGoodsid.Text = BrowseForm.strReturn;
                this.txtGoodsid.SelectAll();
            }
        }

        private void txtTransNum_EditValueChanged(object sender, EventArgs e)
        {
            if ((this.status == "S") && (this.txtTransNum.Text.Length >= 12))
            {
                WaitDialogForm form = new WaitDialogForm();
                form.Caption = "Xin đợi một ch\x00fat";
                this.string_0 = "SELECT tr.trans_num,tr.tran_date, tr.cs_id, tr.goods_id, tr.qty, tr.due_date, tr.remark, tr.status, gs.full_name FROM tblLoanTran AS tr INNER JOIN tblGoods AS gs ON tr.goods_id = gs.goods_id WHERE tr.trans_num = '" + this.txtTransNum.Text.Trim() + "' AND trans_code = '60' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set, "loantran");
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.dataSet_0.Merge(set.Tables["loantran"]);
                        this.txtCsId.Text = set.Tables[0].Rows[0]["cs_id"].ToString();
                        this.txtRemark.Text = set.Tables[0].Rows[0]["remark"].ToString();
                        this.txtDate.Text = set.Tables[0].Rows[0]["tran_date"].ToString();
                        for (int i = 0; i < this.dataSet_0.Tables["loantran"].Rows.Count; i++)
                        {
                            this.dataSet_0.Tables["loantran"].Rows[i]["idx"] = i + 1;
                        }
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                        this.btn_Delete.Text = ((bool)set.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                        this.gridControl1.Refresh();
                        this.status = "F";
                        form.Close();
                    }
                    else
                    {
                        form.Close();
                        Class7.ShowMessageBox("Kh\x00f4ng t\x00ecm thấy số phiếu n\x00e0y !", 1);
                    }
                }
            }
        }

    }
}