using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmMessageQue : DevExpress.XtraEditors.XtraForm
    {
        public FrmMessageQue()
        {
            InitializeComponent();
        }



        private void FrmMessageQue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.string_0 = "delete from tblQueuemsg where id = '" + this.lbl_id.Text + "' ";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
            }
            this.oleDbConnection_0.Close();
        }

        private void FrmMessageQue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        private void FrmMessageQue_Load(object sender, EventArgs e)
        {
            this.string_0 = "SELECT  TOP 1   tblQueuemsg.id, tblQueuemsg.fr_pos, tblQueuemsg.msg_date, tblQueuemsg.msg_time, tblQueuemsg.message, tblStations.name, tblUser.name AS usname  FROM  tblQueuemsg INNER JOIN  tblUser ON tblQueuemsg.sender = tblUser.ID INNER JOIN  tblStations ON tblQueuemsg.fr_pos = tblStations.id  where tblQueuemsg.to_pos = " + Class7.smethod_51();
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.lblStationName.Text = set.Tables[0].Rows[0]["name"].ToString();
                this.lblSenderName.Text = set.Tables[0].Rows[0]["usname"].ToString();
                this.lblSendTime.Text = set.Tables[0].Rows[0]["msg_time"].ToString();
                this.lblSendDate.Text = string.Format("{0:dd/MM/yyyy}", set.Tables[0].Rows[0]["msg_date"]);
                this.txtMessage.Text = set.Tables[0].Rows[0]["message"].ToString();
                this.lbl_id.Text = set.Tables[0].Rows[0]["id"].ToString();
            }
            this.oleDbConnection_0.Close();
        }

    }
}