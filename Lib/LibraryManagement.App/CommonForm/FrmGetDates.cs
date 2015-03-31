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
            this.Txt_FrDate.EditValue = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
            this.Txt_ToDate.EditValue = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
        }

        public DateTime FirstDayOfMonth(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public DateTime LastDayOfMonth(DateTime dateTime)
        {
            DateTime time = new DateTime(dateTime.Year, dateTime.Month, 1);
            return time.AddMonths(1).AddDays(-1.0);
        }

        private void Txt_ToDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Class7.dateTime_0 = DateTime.ParseExact(this.Txt_FrDate.Text, "dd/MM/yyyy", null);
                Class7.dateTime_1 = DateTime.ParseExact(this.Txt_ToDate.Text, "dd/MM/yyyy", null);
                Class7.IsInputDate = true;
                base.Close();
            }
        }
    }
}