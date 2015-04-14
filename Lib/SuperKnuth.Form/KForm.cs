using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SuperKnuth;

namespace SuperKnuthForm
{
    public partial class KForm : Form
    {
        public KForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDecode.Text = KnuthTools.Hash(txtOriginal.Text);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            textBox1.Text = KnuthTools.Dehash(textBox2.Text);
        }
    }
}