using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    public partial class FrmSystemConfig : DevExpress.XtraEditors.XtraForm
    {
        public FrmSystemConfig()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(Application.StartupPath + @"\config.ini", false))
            {
                writer.WriteLine(Class13.smethod_0("SERVER=" + this.Txt_ServerName.Text.Trim(), Class13.string_0));
                writer.WriteLine(Class13.smethod_0("NAMEDB=" + this.Txt_DbName.Text.Trim(), Class13.string_0));
                writer.WriteLine(Class13.smethod_0("USERDB=" + this.Txt_UserName.Text.Trim(), Class13.string_0));
                writer.WriteLine(Class13.smethod_0("PASSDB=" + this.Txt_DbPass.Text.Trim(), Class13.string_0));
                writer.Close();
            }
            Class7.smethod_15("Cập nhật th\x00e0nh c\x00f4ng file config", 1);
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            Class7.smethod_30();
            Class7.smethod_15("Tạo xong bảng menus mới, đề nghị kiểm tra lại", 1);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.method_1();
        }


        private void FrmSystemConfig_Load(object sender, EventArgs e)
        {
            this.method_0();
        }



        private void method_0()
        {
            this.Txt_ServerName.Text = Class7.smethod_6("SERVER");
            this.Txt_DbName.Text = Class7.smethod_6("NAMEDB");
            this.Txt_UserName.Text = Class7.smethod_6("USERDB");
            this.Txt_DbPass.Text = Class7.smethod_6("PASSDB");
        }

        private void method_1()
        {
            if (Class7.smethod_15("Bạn c\x00f3 chắc chắn x\x00f3a dữ liệu kh\x00f4ng ? ", 2) == 1)
            {
                this.string_0 = "DELETE FROM tblStockInfo;DELETE FROM tblTransaction;DELETE FROM tblTransNum;DELETE FROM tblTransaction;DELETE FROM tblGoods;DELETE FROM tblUnit;DELETE FROM tblPrice;DELETE FROM tblHisPrice;DELETE FROM tblSuspend;DELETE FROM tblGoodsGrp";
                this.sqlConnection_0.Open();
                this.sqlCommand_0 = new SqlCommand(this.string_0, this.sqlConnection_0);
                this.sqlCommand_0.ExecuteNonQuery();
                this.sqlCommand_0.Dispose();
                this.sqlConnection_0.Close();
            }
        }
    }
}