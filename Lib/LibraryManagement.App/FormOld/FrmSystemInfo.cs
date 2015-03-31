using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    public partial class FrmSystemInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmSystemInfo()
        {
            InitializeComponent();
        }



        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string str = this.Chk_Minus.Checked ? "1" : "0";
            this.method_0("m_address", Class13.smethod_0(this.Txt_Address.Text, Class13.string_0));
            this.method_0("m_fax", Class13.smethod_0(this.Txt_Fax.Text, Class13.string_0));
            this.method_0("m_name", Class13.smethod_0(this.Txt_FullName.Text, Class13.string_0));
            this.method_0("m_phone", Class13.smethod_0(this.Txt_Phone.Text, Class13.string_0));
            this.method_0("m_vatnum", Class13.smethod_0(this.Txt_VatNumb.Text, Class13.string_0));
            this.method_0("m_minus", str);
            Class7.smethod_15("Thay đổi th\x00f4ng tin th\x00e0nh c\x00f4ng", 1);
            base.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }


        private void FrmSystemInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Chỉnh sửa th\x00f4ng số hệ thống";
            this.Txt_Address.Text = Class13.smethod_1(Class7.smethod_14("m_address").ToString(), Class13.string_0);
            this.Txt_Fax.Text = Class13.smethod_1(Class7.smethod_14("m_fax").ToString(), Class13.string_0);
            this.Txt_Phone.Text = Class13.smethod_1(Class7.smethod_14("m_phone").ToString(), Class13.string_0);
            this.Txt_FullName.Text = Class13.smethod_1(Class7.smethod_14("m_name").ToString(), Class13.string_0);
            this.Txt_VatNumb.Text = Class13.smethod_1(Class7.smethod_14("m_vatnum").ToString(), Class13.string_0);
            this.Chk_Minus.Checked = Class7.smethod_14("m_minus").ToString() == "1";
            this.btn_Confirm.Enabled = Class7.smethod_50();
        }



        private void method_0(string string_0, object object_0)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(string.Concat(new object[] { "UPDATE tblsysvar SET M_VALUE = N'", object_0, "' WHERE M_CODE = '", string_0, "' " }), Class7.oleDbConnection_1);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            Class7.oleDbConnection_1.Close();
        }
    }
}