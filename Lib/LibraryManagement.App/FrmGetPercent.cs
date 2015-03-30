using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryManagement.App
{
    public partial class FrmGetPercent : DevExpress.XtraEditors.XtraForm
    {
        public FrmGetPercent()
        {
            InitializeComponent();
        }



        private void FrmGetPercent_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmGetPercent_Load(object sender, EventArgs e)
        {
            Class10.double_0 = 0.0;
            this.Txt_Percent.EditValue = 0.0;
            this.Txt_Percent.SelectAll();
        }



        private void Txt_Percent_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void Txt_Percent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!Class7.smethod_12(this.Txt_Percent.EditValue.ToString()))
                {
                    Class10.double_0 = 0.0;
                    base.Close();
                }
                else
                {
                    Class10.double_0 = Class7.smethod_0(this.Txt_Percent.EditValue.ToString()) / 100.0;
                    base.Close();
                }
            }
        }
    }
}