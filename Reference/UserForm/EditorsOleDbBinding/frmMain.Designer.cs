using DevExpress.Utils.Frames;
using DevExpress.XtraEditors;
namespace EditorsOleDbBinding {
    partial class frmMain {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dsCars1 = new EditorsOleDbBinding.dsCars();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.pnlTop = new DevExpress.Utils.Frames.ApplicationCaption8_1();
            this.lbTitle2 = new DevExpress.XtraEditors.LabelControl();
            this.lbTitle1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbStyleController = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.spinEdit4 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit3 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.styleController2 = new DevExpress.XtraEditors.StyleController(this.components);
            this.styleController3 = new DevExpress.XtraEditors.StyleController(this.components);
            this.styleController4 = new DevExpress.XtraEditors.StyleController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsCars1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStyleController.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController4)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCars1
            // 
            this.dsCars1.DataSetName = "dsCars";
            this.dsCars1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsCars1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Trademark", true));
            this.textEdit1.EditValue = "textEdit1";
            this.textEdit1.Location = new System.Drawing.Point(148, 14);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(136, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Model", true));
            this.textEdit2.EditValue = "textEdit2";
            this.textEdit2.Location = new System.Drawing.Point(292, 14);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(256, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(556, 60);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.TabStop = false;
            // 
            // lbTitle2
            // 
            this.lbTitle2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTitle2.Appearance.Options.UseBackColor = true;
            this.lbTitle2.Appearance.Options.UseFont = true;
            this.lbTitle2.Location = new System.Drawing.Point(8, 33);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(60, 20);
            this.lbTitle2.TabIndex = 3;
            this.lbTitle2.Text = "Cars.xml";
            // 
            // lbTitle1
            // 
            this.lbTitle1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle1.Appearance.Options.UseBackColor = true;
            this.lbTitle1.Appearance.Options.UseFont = true;
            this.lbTitle1.Location = new System.Drawing.Point(8, 6);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(110, 20);
            this.lbTitle1.TabIndex = 1;
            this.lbTitle1.Text = "OleDbBinding";
            // 
            // cmbStyleController
            // 
            this.cmbStyleController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStyleController.EditValue = "comboBoxEdit1";
            this.cmbStyleController.Location = new System.Drawing.Point(220, 29);
            this.cmbStyleController.Name = "cmbStyleController";
            this.cmbStyleController.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStyleController.Properties.Items.AddRange(new object[] {
            "Default style",
            "Custom style1 (Lavender)",
            "Custom style2 (Khaki)",
            "Custom style3 (Control)"});
            this.cmbStyleController.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbStyleController.Size = new System.Drawing.Size(152, 20);
            this.cmbStyleController.TabIndex = 4;
            this.cmbStyleController.SelectedIndexChanged += new System.EventHandler(this.cmbStyleController_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Appearance.Options.UseBackColor = true;
            this.label9.Appearance.Options.UseFont = true;
            this.label9.Location = new System.Drawing.Point(220, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Style Controller:";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.hyperLinkEdit1);
            this.pnlMain.Controls.Add(this.memoEdit1);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.checkEdit2);
            this.pnlMain.Controls.Add(this.dateEdit1);
            this.pnlMain.Controls.Add(this.calcEdit1);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.checkEdit1);
            this.pnlMain.Controls.Add(this.spinEdit4);
            this.pnlMain.Controls.Add(this.spinEdit3);
            this.pnlMain.Controls.Add(this.spinEdit2);
            this.pnlMain.Controls.Add(this.textEdit4);
            this.pnlMain.Controls.Add(this.spinEdit1);
            this.pnlMain.Controls.Add(this.textEdit3);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.pictureEdit1);
            this.pnlMain.Controls.Add(this.imageComboBoxEdit1);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.textEdit2);
            this.pnlMain.Controls.Add(this.textEdit1);
            this.pnlMain.Controls.Add(this.dataNavigator1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(556, 477);
            this.pnlMain.TabIndex = 3;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperLinkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Hyperlink", true));
            this.hyperLinkEdit1.EditValue = "hyperLinkEdit1";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(292, 202);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.AllowFocused = false;
            this.hyperLinkEdit1.Properties.Image = ((System.Drawing.Image)(resources.GetObject("hyperLinkEdit1.Properties.Image")));
            this.hyperLinkEdit1.Size = new System.Drawing.Size(256, 21);
            this.hyperLinkEdit1.TabIndex = 18;
            this.hyperLinkEdit1.TabStop = false;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Description", true));
            this.memoEdit1.EditValue = "memoEdit1";
            this.memoEdit1.Location = new System.Drawing.Point(148, 264);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(400, 179);
            this.memoEdit1.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Appearance.Options.UseFont = true;
            this.label8.Appearance.Options.UseTextOptions = true;
            this.label8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label8.Location = new System.Drawing.Point(8, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Description:";
            // 
            // checkEdit2
            // 
            this.checkEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Is In Stock", true));
            this.checkEdit2.Location = new System.Drawing.Point(436, 233);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "In stock?";
            this.checkEdit2.Size = new System.Drawing.Size(112, 19);
            this.checkEdit2.TabIndex = 21;
            this.checkEdit2.EditValueChanged += new System.EventHandler(this.checkEdit2_EditValueChanged);
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Delivery Date", true));
            this.dateEdit1.EditValue = new System.DateTime(2003, 4, 21, 0, 0, 0, 0);
            this.dateEdit1.Location = new System.Drawing.Point(292, 231);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.ShowWeekNumbers = true;
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(136, 20);
            this.dateEdit1.TabIndex = 20;
            // 
            // calcEdit1
            // 
            this.calcEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Price", true));
            this.calcEdit1.Location = new System.Drawing.Point(148, 231);
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.calcEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit1.Properties.DisplayFormat.FormatString = "$#,0.00";
            this.calcEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcEdit1.Properties.Mask.EditMask = "\\$###########,0.00";
            this.calcEdit1.Size = new System.Drawing.Size(136, 20);
            this.calcEdit1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Appearance.Options.UseFont = true;
            this.label7.Appearance.Options.UseTextOptions = true;
            this.label7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label7.Location = new System.Drawing.Point(8, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Price / Delivery Date:";
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Transmiss Automatic", true));
            this.checkEdit1.Location = new System.Drawing.Point(148, 204);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Automatic Transmission";
            this.checkEdit1.Properties.ValueChecked = "Yes";
            this.checkEdit1.Properties.ValueUnchecked = "No";
            this.checkEdit1.Size = new System.Drawing.Size(400, 19);
            this.checkEdit1.TabIndex = 16;
            // 
            // spinEdit4
            // 
            this.spinEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Transmiss Speed Count", true));
            this.spinEdit4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit4.Location = new System.Drawing.Point(148, 176);
            this.spinEdit4.Name = "spinEdit4";
            this.spinEdit4.Properties.Appearance.Options.UseTextOptions = true;
            this.spinEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.spinEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit4.Properties.IsFloatValue = false;
            this.spinEdit4.Properties.Mask.EditMask = "N00";
            this.spinEdit4.Size = new System.Drawing.Size(136, 20);
            this.spinEdit4.TabIndex = 15;
            // 
            // spinEdit3
            // 
            this.spinEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.MPG Highway", true));
            this.spinEdit3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit3.Location = new System.Drawing.Point(220, 143);
            this.spinEdit3.Name = "spinEdit3";
            this.spinEdit3.Properties.Appearance.Options.UseTextOptions = true;
            this.spinEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.spinEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit3.Properties.IsFloatValue = false;
            this.spinEdit3.Properties.Mask.EditMask = "N00";
            this.spinEdit3.Size = new System.Drawing.Size(64, 20);
            this.spinEdit3.TabIndex = 14;
            // 
            // spinEdit2
            // 
            this.spinEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.MPG City", true));
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(148, 143);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.spinEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit2.Properties.IsFloatValue = false;
            this.spinEdit2.Properties.Mask.EditMask = "N00";
            this.spinEdit2.Size = new System.Drawing.Size(64, 20);
            this.spinEdit2.TabIndex = 13;
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Liter", true));
            this.textEdit4.EditValue = "textEdit4";
            this.textEdit4.Location = new System.Drawing.Point(148, 111);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.DisplayFormat.FormatString = "#.## Liters";
            this.textEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit4.Size = new System.Drawing.Size(136, 20);
            this.textEdit4.TabIndex = 12;
            // 
            // spinEdit1
            // 
            this.spinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Cyl", true));
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(220, 79);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.spinEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEdit1.Properties.IsFloatValue = false;
            this.spinEdit1.Properties.Mask.EditMask = "N00";
            this.spinEdit1.Size = new System.Drawing.Size(64, 20);
            this.spinEdit1.TabIndex = 11;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.HP", true));
            this.textEdit3.EditValue = "textEdit3";
            this.textEdit3.Location = new System.Drawing.Point(148, 79);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit3.Size = new System.Drawing.Size(64, 20);
            this.textEdit3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Appearance.Options.UseFont = true;
            this.label6.Appearance.Options.UseTextOptions = true;
            this.label6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label6.Location = new System.Drawing.Point(8, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "# of Gears:";
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Appearance.Options.UseFont = true;
            this.label5.Appearance.Options.UseTextOptions = true;
            this.label5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MPG City / Highway:";
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Appearance.Options.UseFont = true;
            this.label4.Appearance.Options.UseTextOptions = true;
            this.label4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacity:";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Appearance.Options.UseTextOptions = true;
            this.label3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "HP / Cyl:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.Location = new System.Drawing.Point(292, 44);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(256, 151);
            this.pictureEdit1.TabIndex = 5;
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dsCars1, "Cars.Category", true));
            this.imageComboBoxEdit1.EditValue = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(148, 46);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sports", "SPORTS", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saloon", "SALOON", 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Truck", "TRUCK", 2)});
            this.imageComboBoxEdit1.Properties.SmallImages = this.imageList1;
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(136, 20);
            this.imageComboBoxEdit1.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Appearance.Options.UseTextOptions = true;
            this.label2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Appearance.Options.UseTextOptions = true;
            this.label1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.label1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trademark / Model:";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.DataMember = "Cars";
            this.dataNavigator1.DataSource = this.dsCars1;
            this.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNavigator1.Location = new System.Drawing.Point(2, 451);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(552, 24);
            this.dataNavigator1.TabIndex = 0;
            this.dataNavigator1.Text = "dataNavigator1";
            this.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.End;
            // 
            // styleController2
            // 
            this.styleController2.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.styleController2.Appearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.styleController2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.styleController2.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.styleController2.Appearance.Options.UseBackColor = true;
            this.styleController2.Appearance.Options.UseBorderColor = true;
            this.styleController2.Appearance.Options.UseFont = true;
            this.styleController2.Appearance.Options.UseForeColor = true;
            this.styleController2.AppearanceDisabled.BackColor = System.Drawing.Color.LightSteelBlue;
            this.styleController2.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.styleController2.AppearanceDisabled.Options.UseBackColor = true;
            this.styleController2.AppearanceDisabled.Options.UseFont = true;
            this.styleController2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            // 
            // styleController3
            // 
            this.styleController3.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.styleController3.Appearance.BorderColor = System.Drawing.Color.Khaki;
            this.styleController3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.styleController3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.styleController3.Appearance.Options.UseBackColor = true;
            this.styleController3.Appearance.Options.UseBorderColor = true;
            this.styleController3.Appearance.Options.UseFont = true;
            this.styleController3.Appearance.Options.UseForeColor = true;
            this.styleController3.AppearanceDisabled.BackColor = System.Drawing.Color.DarkKhaki;
            this.styleController3.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.styleController3.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.styleController3.AppearanceDisabled.Options.UseBackColor = true;
            this.styleController3.AppearanceDisabled.Options.UseFont = true;
            this.styleController3.AppearanceDisabled.Options.UseForeColor = true;
            this.styleController3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            // 
            // styleController4
            // 
            this.styleController4.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.styleController4.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.styleController4.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.styleController4.Appearance.Options.UseBackColor = true;
            this.styleController4.Appearance.Options.UseFont = true;
            this.styleController4.Appearance.Options.UseForeColor = true;
            this.styleController4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(556, 537);
            this.Controls.Add(this.lbTitle2);
            this.Controls.Add(this.cmbStyleController);
            this.Controls.Add(this.lbTitle1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OleDb Binding (C# Demo)";
            ((System.ComponentModel.ISupportInitialize)(this.dsCars1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStyleController.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EditorsOleDbBinding.dsCars dsCars1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private ApplicationCaption8_1 pnlTop;
        private PanelControl pnlMain;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl lbTitle1;
        private DevExpress.XtraEditors.LabelControl lbTitle2;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.SpinEdit spinEdit3;
        private DevExpress.XtraEditors.SpinEdit spinEdit4;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.CalcEdit calcEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
        private DevExpress.XtraEditors.StyleController styleController1;
        private DevExpress.XtraEditors.StyleController styleController2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbStyleController;
        private DevExpress.XtraEditors.LabelControl label9;
        private DevExpress.XtraEditors.StyleController styleController3;
        private DevExpress.XtraEditors.StyleController styleController4;
        private System.ComponentModel.IContainer components;

    }
}
