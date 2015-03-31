using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace LibraryManagement.App
{
    public partial class FrmGetDay : DevExpress.XtraEditors.XtraForm
    {
        public FrmGetDay()
        {
            InitializeComponent();
        }


        private void FrmGetDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                base.Close();
            }
        }

        private void FrmGetDay_Load(object sender, EventArgs e)
        {
            Class7.rciIijbdca = false;
            this.Txt_InDay.EditValue = DateTime.Parse(Class7.smethod_19());
        }



        private void Txt_InDay_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_InDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Class7.dateTime_2 = DateTime.ParseExact(this.Txt_InDay.Text, "dd/MM/yyyy", null);
                Class7.rciIijbdca = true;
                base.Close();
            }
        }
    }
}