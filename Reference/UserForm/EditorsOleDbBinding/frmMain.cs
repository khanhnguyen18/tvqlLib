using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Utils.Frames;

namespace EditorsOleDbBinding {
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public partial class frmMain : XtraForm {
		public frmMain() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			InitData();
			InitMenu();
			pictureEdit1.DataBindings.Add(new Binding("EditValue", dsCars1, "Cars.Picture"));
			cmbStyleController.SelectedIndex = 0;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		#region Init
		private void InitMenu() {
			DevExpress.Utils.LookAndFeelMenu menu = 
				new DevExpress.Utils.LookAndFeelMenu(this, defaultLookAndFeel1, "OleDb Binding Demo for the XtraEditors by Developer Express Inc."); 
		}
		private void InitData() {
			string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\\Cars.xml");
			if(DBFileName != "") {
				dsCars1.ReadXml(DBFileName);
			}
		}
		#endregion
		#region Editing
		private void checkEdit2_EditValueChanged(object sender, System.EventArgs e) {
			calcEdit1.Enabled = dateEdit1.Enabled = checkEdit2.Checked;
		}

		private StyleController CurrentStyleController {
			get {
				if(cmbStyleController.SelectedIndex == 1) return styleController2;
				if(cmbStyleController.SelectedIndex == 2) return styleController3;
				if(cmbStyleController.SelectedIndex == 3) return styleController4;
				return styleController1;
			}
		}

		private void cmbStyleController_SelectedIndexChanged(object sender, System.EventArgs e) {
			foreach(Control ctrl in pnlMain.Controls) {
				if(ctrl is BaseEdit && !(ctrl is CheckEdit))
					((BaseEdit)ctrl).StyleController = CurrentStyleController;
			}		
		}
		#endregion
	}
}
