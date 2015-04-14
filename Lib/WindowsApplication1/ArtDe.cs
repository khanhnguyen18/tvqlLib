using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArtDe;

namespace WindowsApplication1
{
    public partial class ArtDe : Form
    {
        public ArtDe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDecode.Text = Decode.EncodeCode(txtOriginal.Text);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            textBox1.Text = Decode.DecodeCode(textBox2.Text);
        }
    }
}