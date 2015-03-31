using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
    public partial class FrmReaderInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmReaderInfo()
        {
            InitializeComponent();
        }




        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            this.printableComponentLink_0.Landscape = true;
            this.printableComponentLink_0.Margins.Left = 20;
            this.printableComponentLink_0.Margins.Right = 20;
            this.printableComponentLink_0.Margins.Bottom = 40;
            this.printableComponentLink_0.Margins.Top = 40;
            this.printableComponentLink_0.CreateDocument();
            this.printableComponentLink_0.ShowPreview();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new FrmReaderDef().ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new FrmGetDates().ShowDialog();
            if (Class7.rciIijbdca)
            {
                this.dataSet_0.Tables["histrans"].Clear();
                this.string_0 = string.Concat(new object[] { "SELECT DISTINCT  trans_num , tran_date , tran_time , trans_code , remark  FROM tblLoanTran WHERE status = 1 AND (tran_date BETWEEN '", Class7.dateTime_0, "' AND '", Class7.dateTime_1, "') AND cs_id = '", this.txtCsId.Text.Trim(), "' GROUP BY trans_num, tran_date, tran_time, trans_code, remark " });
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set, "histrans");
                    this.oleDbConnection_0.Close();
                    this.dataSet_0.Merge(set.Tables[0]);
                    this.gridView2.BestFitColumns();
                    this.gridView2.OptionsBehavior.Editable = false;
                }
            }
        }


        private void FrmReaderInfo_Activated(object sender, EventArgs e)
        {
            if (base.WindowState != FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmReaderInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Th\x00f4ng tin bạn đọc";
            base.Tag = "tblCustomer";
            this.method_0();
        }



        private void method_0()
        {
            this.dataSet_0.Tables["booklst"].Clear();
            this.string_0 = "SELECT tr.trans_num , tr.goods_id , tr.due_date , gs.full_name FROM tblLoanTran AS tr INNER JOIN tblGoods AS gs ON tr.goods_id = gs.goods_id WHERE tr.cs_id = '" + this.txtCsId.Text.Trim() + "' and tr.status = 1 and tr.corr_tran = ''";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set, "booklst");
                this.oleDbConnection_0.Close();
                this.dataSet_0.Merge(set.Tables[0]);
                this.kCnalMegv.BestFitColumns();
            }
        }

        private void printableComponentLink_0_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string text = "Danh mục s\x00e1ch chưa trả";
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Arial", 14f, FontStyle.Bold);
            RectangleF rect = new RectangleF(0f, 0f, e.Graph.ClientPageSize.Width, 50f);
            e.Graph.DrawString(text, Color.Black, rect, DevExpress.XtraPrinting.BorderSide.None);
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
            if (this.lblFullName.Text != string.Empty)
            {
                this.method_0();
            }
        }

        private void txtCsId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                string str = "SELECT id AS [M\x00e3 thẻ], fullname AS [Họ v\x00e0 t\x00ean], phone AS [Số ĐT], status AS [Trạng th\x00e1i] from tblCustomer WHERE status =1";
                Class7.smethod_16(str, this.oleDbConnection_0);
                this.txtCsId.Text = FrmBrowse.strReturn;
            }
        }
   
    }
}