using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    public partial class FrmGetDates : DevExpress.XtraEditors.XtraForm
    {
        public FrmGetDates()
        {
            InitializeComponent();
        }

        private void FrmGetDates_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        private void FrmGetDates_Load(object sender, EventArgs e)
        {
            Class7.IsInputDate = false;
            dateEdit1.EditValue = DateTime.Now;
            dateEdit2.EditValue = DateTime.Now;
            //this.Txt_FrDate.EditValue = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
            //this.Txt_ToDate.EditValue = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Class7.dateTimeFrom = dateEdit1.DateTime.Date; //DateTime.ParseExact(this.Txt_FrDate.Text, "dd/MM/yyyy", null);
            Class7.dateTimeTo = dateEdit2.DateTime.Date;// DateTime.ParseExact(this.Txt_ToDate.Text, "dd/MM/yyyy", null);
            Class7.IsInputDate = true;
            base.Close();
        }
    }
}