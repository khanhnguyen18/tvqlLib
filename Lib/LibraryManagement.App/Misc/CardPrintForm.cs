using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class CardPrintForm : XtraForm
    {
        public CardPrintForm()
        {
            InitializeComponent();
            this.oleDbConnection_0 = DataProvider.GetConnection();
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
            for (int i = 0; i < this.dataSet_0.Tables["CardPrint"].Rows.Count; i++)
            {
                this.dataSet_0.Tables["CardPrint"].Rows[i]["idx"] = i + 1;
            }
            this.gridControl1.Refresh();
        }

        private void btn_Print108_Click(object sender, EventArgs e)
        {
            library_card _card = new library_card();
            _card.dataSet1.Merge(this.dataSet_0.Tables[0]);
            _card.ShowPreviewDialog();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn kh\x00f4ng ?", 2) == 1)
            {
                this.dataSet_0.Tables[0].Clear();
                this.gridControl1.Refresh();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new ReaderForm().ShowDialog();
        }

        private void FrmCardPrint_Load(object sender, EventArgs e)
        {
            this.Text = "In thẻ thư viện";
            base.Tag = "tblCustomer";
            this.txtCsId.Focus();
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                this.txtCsId.Text = this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "card_id").ToString();
                this.int_0 = int.Parse(this.gridView1.GetRowCellValue(this.gridView1.FocusedRowHandle, "idx").ToString()) - 1;
            }
            catch (Exception)
            {
                this.int_0 = -1;
            }
        }

        private void IjSwogAv6_Click(object sender, EventArgs e)
        {
            if (this.lblFullName.Text != string.Empty)
            {
                try
                {
                    DataRow row = this.dataSet_0.Tables["CardPrint"].NewRow();
                    row["idx"] = this.dataSet_0.Tables["CardPrint"].Rows.Count + 1;
                    row["card_id"] = this.txtCsId.Text;
                    row["fullname"] = this.lblFullName.Text;
                    row["open_date"] = DateTime.ParseExact(this.lblOpenDate.Text, "dd/MM/yyyy", null);
                    row["due_date"] = DateTime.ParseExact(this.lblDueDate.Text, "dd/MM/yyyy", null);
                    try
                    {
                        row["image"] = (byte[])Class7.smethod_29(base.Tag.ToString(), "image", "id", this.txtCsId.Text, "", this.oleDbConnection_0);
                    }
                    catch (Exception)
                    {
                    }
                    this.dataSet_0.Tables["CardPrint"].Rows.Add(row);
                    this.gridControl1.Refresh();
                }
                catch (Exception)
                {
                    Class7.ShowMessageBox("Đ\x00e3 c\x00f3 số thẻ n\x00e0y trong danh mục in", 1);
                }
                finally
                {
                    this.txtCsId.Text = string.Empty;
                    this.txtCsId.Focus();
                }
            }
        }


        private void method_0()
        {
        }

        private void txtCsId_EditValueChanged(object sender, EventArgs e)
        {
            string str = this.txtCsId.Text.Trim();
            this.lblFullName.Text = Class7.smethod_29(base.Tag.ToString(), "fullname", "id", str, "", this.oleDbConnection_0).ToString();
            this.lblAddress.Text = Class7.smethod_29(base.Tag.ToString(), "address", "id", str, "", this.oleDbConnection_0).ToString();
            this.lblPhone.Text = Class7.smethod_29(base.Tag.ToString(), "phone", "id", str, "", this.oleDbConnection_0).ToString();
            this.lblEmail.Text = Class7.smethod_29(base.Tag.ToString(), "email", "id", str, "", this.oleDbConnection_0).ToString();
            this.lblDueDate.Text = string.Format("{0:dd/MM/yyyy}", Class7.smethod_29(base.Tag.ToString(), "due_date", "id", str, "", this.oleDbConnection_0));
            this.lblOpenDate.Text = string.Format("{0:dd/MM/yyyy}", Class7.smethod_29(base.Tag.ToString(), "open_date", "id", str, "", this.oleDbConnection_0));
            try
            {
                byte[] buffer = (byte[])Class7.smethod_29(base.Tag.ToString(), "image", "id", str, "", this.oleDbConnection_0);
                this.pictureEdit1.Image = Class7.smethod_21(buffer);
            }
            catch (Exception)
            {
                this.pictureEdit1.Image = null;
            }
        }

        private void txtCsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                string str = "SELECT id AS [M\x00e3 thẻ], fullname AS [Họ v\x00e0 t\x00ean], phone AS [Số ĐT], status AS [Trạng th\x00e1i] from tblCustomer WHERE status =1";
                Class7.BrowserForm1(str, this.oleDbConnection_0);
                this.txtCsId.Text = BrowseForm.strReturn;
            }
            if (e.KeyCode == Keys.Return)
            {
                this.IjSwogAv6_Click(this, new EventArgs());
            }
        }
    }
}