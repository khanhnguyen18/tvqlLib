using LibraryManagement.Domain;
using LibraryManagement.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BookService bookSer = new BookService();
            
            TList<Book> lst = bookSer.GetAll();
            dataGridView1.DataSource = lst;
        }
    }
}
