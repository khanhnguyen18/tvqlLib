using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace LibraryManagement.App
{
    public partial class BrowseForm : Form
    {
        public static string strReturn;
        public BrowseForm()
        {
            InitializeComponent();
        }

        private void FrmBrowse_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    strReturn = this.Look_View.GetRowCellValue(this.Look_View.FocusedRowHandle, this.Look_View.Columns[0]).ToString();
                    base.Close();
                    break;

                case Keys.Escape:
                    base.Close();
                    break;
            }
            if (e.Control && (e.KeyCode == Keys.P))
            {
                this.printableComponentLink_0.Landscape = true;
                this.printableComponentLink_0.Margins.Left = 50;
                this.printableComponentLink_0.Margins.Right = 50;
                this.printableComponentLink_0.Margins.Bottom = 80;
                this.printableComponentLink_0.Margins.Top = 80;
                this.printableComponentLink_0.CreateDocument();
                this.printableComponentLink_0.ShowPreview();
            }
        }

        private void FrmBrowse_Load(object sender, EventArgs e)
        {
            this.Text = " Ấn Ctrl + P để in danh mục";
            this.Look_View.OptionsBehavior.Editable = false;
            this.Look_View.BestFitColumns();
            this.Look_View.Columns[0].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            this.Look_View.Columns[1].OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
            strReturn = string.Empty;
        }

        private void grd_Look_DoubleClick(object sender, EventArgs e)
        {
            strReturn = this.Look_View.GetRowCellValue(this.Look_View.FocusedRowHandle, this.Look_View.Columns[0]).ToString();
            base.Close();
        }
    }
}