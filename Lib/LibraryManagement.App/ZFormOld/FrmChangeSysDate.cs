using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmChangeSysDate : XtraForm
    {
        public FrmChangeSysDate()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Class7.ShowMessageBox("Bạn c\x00f3 chắc chắn sửa lại ng\x00e0y hệ thống kh\x00f4ng ?", 2) == 1)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("update tblDate set org_date = '" + this.Txt_NewDate.EditValue + "'", Class7.oleDbConnection_1);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                Class7.oleDbConnection_1.Close();
                Class7.ShowMessageBox("Đổi ng\x00e0y th\x00e0nh c\x00f4ng, bạn h\x00e3y khởi động lại chương tr\x00ecnh", 1);
                base.Close();
            }
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            base.Close();
        }


        private void FrmChangeSysDate_Load(object sender, EventArgs e)
        {
            this.Text = "Sửa lại ng\x00e0y hệ thống";
            this.Txt_SysDate.EditValue = DateTime.Parse(Class7.smethod_19());
            this.Txt_NewDate.EditValue = DateTime.Parse(Class7.smethod_19());
            this.btn_Save.Enabled = Class7.smethod_50();
        }

    }
}