using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LibraryManagement.App
{
    public partial class FrmGetAmount : DevExpress.XtraEditors.XtraForm
    {
        public FrmGetAmount()
        {
            InitializeComponent();
        }

        private void FrmGetAmount_Load(object sender, EventArgs e)
        {
            Class10.double_2 = 0.0;
            this.Txt_Amount.EditValue = 0;
            this.Txt_Amount.SelectAll();
        }

        private void Txt_Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!Class7.smethod_12(this.Txt_Amount.EditValue.ToString()))
                {
                    Class10.double_2 = 0.0;
                    base.Close();
                }
                else
                {
                    Class10.double_2 = Class7.smethod_0(this.Txt_Amount.Text);
                    base.Close();
                }
            }
        }
    }
}