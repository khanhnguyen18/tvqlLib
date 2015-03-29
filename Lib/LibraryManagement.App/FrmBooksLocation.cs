using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class FrmBooksLocation : DevExpress.XtraEditors.XtraForm
    {
        public FrmBooksLocation()
        {
            InitializeComponent();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.lblStkName.Text == string.Empty)
            {
                Class7.smethod_15("Bạn chưa chọn thư viện", 1);
                this.txtStkId.Focus();
            }
            else if (this.lblLocationName.Text == string.Empty)
            {
                Class7.smethod_15("Bạn chưa chọn kệ s\x00e1ch", 1);
                this.txtSymbol.Focus();
            }
            else if (Class7.smethod_15("Bạn c\x00f3 chắc chắn kh\x00f4ng ? ", 2) == 1)
            {
                WaitDialogForm form = new WaitDialogForm();
                form.Caption = "Xin đợi một ch\x00fat";
                //for (int i = 0; i < this.library_dataDataSet_0.mercloc.Rows.Count; i++)
                //{
                //    string str = this.txtStkId.Text.Trim();
                //    string str2 = this.txtSymbol.Text.Trim();
                //    string str3 = this.library_dataDataSet_0.mercloc.Rows[i]["goods_id"].ToString().Trim();
                //    if ((this.library_dataDataSet_0.mercloc.Rows[i]["check"].ToString() != "") && ((bool) this.library_dataDataSet_0.mercloc.Rows[i]["check"]))
                //    {
                //        this.string_0 = "IF NOT EXISTS(SELECT GOODS_ID FROM tblMercLocation WHERE GOODS_ID = '" + str3 + "' AND stk_id = '" + str + "' AND loc_id = '" + str2 + "') INSERT INTO tblMercLocation(stk_id, loc_id, goods_id, [check]) VALUES('" + str + "', '" + str2 + "', '" + str3 + "',1) ";
                //        Class7.smethod_4(this.string_0);
                //    }
                //    else
                //    {
                //        this.string_0 = "IF EXISTS(SELECT GOODS_ID FROM tblMercLocation WHERE GOODS_ID = '" + str3 + "' AND stk_id = '" + str + "' AND loc_id = '" + str2 + "') DELETE FROM tblMercLocation WHERE GOODS_ID = '" + str3 + "' AND stk_id = '" + str + "' AND loc_id = '" + str2 + "'";
                //        Class7.smethod_4(this.string_0);
                //    }
                //}
                form.Close();
                Class7.smethod_15("Cập nhật th\x00e0nh c\x00f4ng !", 1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.method_0();
        }


        private void FrmBooksLocation_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmBooksLocation_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd danh mục s\x00e1ch trong c\x00e1c kệ thư viện";
            this.txtStkId.Text = "00001";
        }


        private void method_0()
        {
            WaitDialogForm form = new WaitDialogForm();
            form.Caption = "Xin đợi một ch\x00fat";
            //this.merclocTableAdapter_0.SqlConnection_0.ConnectionString = Class7.string_6;
            //this.merclocTableAdapter_0.FillBy(this.library_dataDataSet_0.mercloc, this.txtSymbol.Text, this.txtStkId.Text);
            this.gridView1.BestFitColumns();
            form.Close();
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.btnRefresh.Enabled = this.lblLocationName.Text != string.Empty;
        }

        private void txtStkId_EditValueChanged(object sender, EventArgs e)
        {
            this.lblStkName.Text = Class7.smethod_29("tblstore", "fullname", "id", this.txtStkId.Text.Trim(), "and Type IN('01','02') and status = 1", this.oleDbConnection_0).ToString();
        }

        private void txtStkId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT Id AS [M\x00e3 số], Name AS [T\x00ean kho, quầy], fullname AS 'Diễn giải' FROM tblStore WHERE Type IN('01','02') and status = 1";
                Class7.smethod_16(str, this.oleDbConnection_0);
                this.txtStkId.Text = FrmBrowse.strReturn;
                this.txtStkId.SelectAll();
            }
        }

        private void txtStkId_Validating(object sender, CancelEventArgs e)
        {
            if (this.lblStkName.Text == string.Empty)
            {
                e.Cancel = true;
            }
        }

        private void txtSymbol_EditValueChanged(object sender, EventArgs e)
        {
            this.lblLocationName.Text = Class7.smethod_29("tblLocation", "description", "loc_id", this.txtSymbol.Text.Trim(), "and status = 1", this.oleDbConnection_0).ToString();
        }

        private void txtSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.string_0 = "select loc_id AS [M\x00e3 kệ], Description AS [Diễn giải] from tblLocation where stk_id = '" + this.txtStkId.Text.Trim() + "' and status = 1";
                Class7.smethod_16(this.string_0, this.oleDbConnection_0);
                this.txtSymbol.Text = FrmBrowse.strReturn;
            }
        }
    }
}