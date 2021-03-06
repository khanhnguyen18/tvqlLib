using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTab;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class BookForm : Form
    {
     
        public BookForm()
        {
            InitializeComponent();

            this.oleDbConnection_0 = DataProvider.GetConnection();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string text = this.btn_Delete.Text;
            if ((text != null) && (text == "&X\x00f3a"))
            {
                this.string_1 = "select goods_id from tblStockInfo where imp_qty - exp_qty <> 0 and goods_id = '" + this.txtGoodsid.Text.Trim() + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        Class7.ShowMessageBox("H\x00e0ng c\x00f2n tồn kh\x00f4ng thể x\x00f3a", 1);
                        return;
                    }
                }
                if (Class7.ShowMessageBox("Bạn chắc chắn muốn x\x00f3a m\x00e3 h\x00e0ng n\x00e0y ? ", 2) == 1)
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "goods_id", this.txtGoodsid.Text.Trim(), "", this.oleDbConnection_0);
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.ShowMessageBox("Bạn chắc chắn muốn phục hồi m\x00e3 h\x00e0ng n\x00e0y ? ", 2) == 1)
            {
                Class7.smethod_23(base.Tag.ToString(), 1, "goods_id", this.txtGoodsid.Text.Trim(), "", this.oleDbConnection_0);
                this.Txt_Status.Text = "Đang hoạt động";
                this.btn_Delete.Text = "&X\x00f3a";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            Class11.smethod_6(this.xtraTabPage1, 1);
            this.string_0 = "E";
            this.txtName.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            int num = 0;
            this.string_1 = "select count(goods_id) from tblGoods";
            this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
            using (DataSet set = new DataSet())
            {
                this.oleDbDataAdapter_0.Fill(set);
                this.oleDbConnection_0.Close();
                if (!string.IsNullOrEmpty(set.Tables[0].Rows[0][0].ToString()))
                {
                    num = (int)set.Tables[0].Rows[0][0];
                }
                else
                {
                    num = 0;
                }
            }
            if (num > 0x1f3)
            {
                Class7.ShowMessageBox("Phi\x00ean bản miễn ph\x00ed chỉ hỗ trợ 500 m\x00e3 s\x00e1ch", 1);
            }
            else
            {
                Class11.smethod_1(this);
                Class11.smethod_5(this, "T");
                Class11.smethod_6(this.xtraTabPage1, 1);
                Class11.smethod_7(this.xtraTabPage1);
                Class11.smethod_8(this);
                this.pictureEdit1.Image = null;
                this.txtIntro.Text = "Giới thiệu về nội dung";
                this.string_0 = "N";
                this.method_0();
                this.cmbMonth.SelectedIndex = 0;
                this.Txt_OpenDate.DateTime = DateTime.Now;
                this.txtGoodsid.Enabled = false;
                if (this.xtraTabControl1.SelectedTabPageIndex != 0)
                {
                    this.xtraTabControl1.SelectedTabPageIndex = 0;
                }
                this.txtName.Focus();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa đăng k\x00fd t\x00ean s\x00e1ch", 1);
                this.txtName.Focus();
            }
            else
            {
                string str = this.txtGoodsid.Text.Trim();
                string str6 = string.Format("{0:d}", Class7.smethod_19());
                string str4 = this.txtName.Text.Trim();
                string str3 = this.cmbGroup.Text.Substring(0, 4);
                string str11 = (this.txtAuthor.Text.Trim() == string.Empty) ? "Unknow" : this.txtAuthor.Text.Trim();
                string str12 = (this.txtPublish.Text.Trim() == string.Empty) ? "Unknow" : this.txtAuthor.Text.Trim();
                string str7 = (this.CdCbuygdy.Text.Trim() == string.Empty) ? "Unknow" : this.txtAuthor.Text.Trim();
                string str8 = this.txtDimension.Text.Trim();
                string str2 = this.txtBarcode.Text.Trim();
                string str5 = this.cmbUnit.Text.Substring(0, 3);
                int num2 = int.Parse(this.cmbForm.Text.Substring(0, 1));
                int num3 = int.Parse(this.cmbLanguage.Text.Substring(0, 1));
                double num = Class7.ParseDoubleValue(this.txtRtPrice.Text);
                int num4 = this.cmbMonth.SelectedIndex + 1;
                int num5 = int.Parse(this.cmbYear.Text);
                int num6 = int.Parse(this.txtWeight.Text.Replace(",", ""));
                int num7 = int.Parse(this.txtNumOfPage.Text.Replace(",", ""));
                string str9 = this.txtIntro.Text.Trim();
                string str10 = this.string_0;
                if (str10 != null)
                {
                    if (!(str10 == "N"))
                    {
                        if (str10 == "E")
                        {
                            this.btn_Skip_Click(this, new EventArgs());
                            this.string_1 = "UPDATE tblGoods SET grp_id ='" + str3 + "', ref = '',short_name =N'" + str4 + "',mbc = 0,  full_name =N'" + str4 + "', packunit ='" + str5 + "', piceunit ='" + str5 + "', unitconv =1 , barcode ='" + str2 + "', domestic=0, warranty= 0 ,supp_id = '',tax_code = '0'  WHERE goods_id = '" + str + "'";
                            Class7.smethod_4(this.string_1);
                            this.string_1 = string.Concat(new object[] { "IF EXISTS (select goods_id from tblPrice WHERE goods_id = '", str, "') UPDATE tblPrice SET  rtprice =", num, " , wsprice = 0, prefprice = 0, discpercent = 0, disc_frdate = '1/1/1900', disc_todate = '1/1/1900'  WHERE goods_id = '", str, "' Else INSERT INTO tblPrice(goods_id, rtprice, wsprice, prefprice, discpercent, disc_frdate, disc_todate) VALUES('", str, "',", num, ",0, 0, 0, '1/1/1900', '1/1/1900' )" });
                            Class7.smethod_4(this.string_1);
                        }
                    }
                    else
                    {
                        this.btn_Skip_Click(this, new EventArgs());
                        this.txtGoodsid.Text = Class7.smethod_9(base.Tag.ToString(), "{0:000000}", this.oleDbConnection_0);
                        str = this.txtGoodsid.Text.Trim();
                        this.string_1 = "INSERT INTO tblGoods(goods_id, barcode, grp_id, supp_id, mbc, ref, short_name, full_name, packunit, piceunit, unitconv, open_date,tax_code, domestic, warranty, status) VALUES('" + str + "','" + str2 + "' , '" + str3 + "','',0,'',N'" + str4 + "',N'" + str4 + "','" + str5 + "','" + str5 + "', 1,'" + str6 + "','0',0  , 0, 1  )";
                        Class7.smethod_4(this.string_1);
                        this.string_1 = string.Concat(new object[] { "INSERT INTO tblPrice(goods_id, rtprice, wsprice, prefprice, discpercent, disc_frdate, disc_todate) VALUES('", str, "',", num, ",0, 0, 0, '1/1/1900', '1/1/1900' )" });
                        Class7.smethod_4(this.string_1);
                        Class7.smethod_4("insert into tblBookAttr(goods_id) values('" + str + "')");
                    }
                }
                this.string_1 = string.Concat(new object[] { 
                    "UPDATE tblBookAttr SET author = N'", str11, "', publish = N'", str12, "', translator = N'", str7, "', form_type = ", num2, ", language = ", num3, ",pl_month = ", num4, ", pl_year = ", num5, ", dimension = '", str8, 
                    "',weight = ", num6, ", pages = ", num7, ", introinfo = N'", str9, "'  WHERE goods_id = '", str, "'"
                 });
                Class7.smethod_4(this.string_1);
                Class7.smethod_20(this.pictureEdit1, "tblGoods", "Image", "goods_id", str);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_6(this.xtraTabPage1, 0);
            Class11.smethod_8(this);
            Class11.smethod_7(this.xtraTabPage1);
            this.string_0 = "S";
            this.pictureEdit1.Image = null;
            this.txtGoodsid.Enabled = true;
            if (this.xtraTabControl1.SelectedTabPageIndex != 0)
            {
                this.xtraTabControl1.SelectedTabPageIndex = 0;
            }
            this.txtGoodsid.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_6(this.xtraTabPage1, 0);
            this.string_0 = "D";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            this.openFileDialog_0.InitialDirectory = Application.StartupPath;
            this.openFileDialog_0.Title = "Chọn file ảnh";
            this.openFileDialog_0.Filter = "JPEG Files|*.jpg|Bitmap Files|*.bmp|GIF Files|*.Gif";
            this.openFileDialog_0.ShowDialog();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            new UnitsForm().ShowDialog();
        }


        private void FrmBookDef_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd th\x00f4ng tin s\x00e1ch";
            base.Tag = "tblGoods";
            this.btn_Skip_Click(this, new EventArgs());
            this.method_0();
        }

        private void IipWvDcZu(object sender, EventArgs e)
        {
            new BookCategoryForm().ShowDialog();
        }

        private void method_0()
        {
            this.cmbYear.Properties.Items.Clear();
            RepositoryItemComboBox properties = this.cmbYear.Properties;
            for (int i = 0x76c; i < (DateTime.Now.Year + 1); i++)
            {
                properties.Items.Add(i);
            }
            this.cmbYear.SelectedIndex = this.cmbYear.Properties.Items.Count - 1;
            Class11.BindCombox("tblLanguage", "id", "description", "where status = 1", this.cmbLanguage, 0, this.oleDbConnection_0);
            Class11.BindCombox("tblGoodsGrp", "id", "description", "where status = 1", this.cmbGroup, 0, this.oleDbConnection_0);
            Class11.BindCombox("tblFrmType", "id", "description", "where status = 1", this.cmbForm, 0, this.oleDbConnection_0);
            Class11.BindCombox("tblUnit", "id", "description", "where status = 1", this.cmbUnit, 1, this.oleDbConnection_0);
        }

        private void method_1(string string_2, ListBoxControl listBoxControl_0)
        {
            int num = 0;
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("SELECT * FROM tblBarcode WHERE goods_id = '" + string_2 + "'  ", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                listBoxControl_0.Items.Clear();
                for (num = 0; num <= (dataSet.Tables[0].Rows.Count - 1); num++)
                {
                    listBoxControl_0.Items.Add(dataSet.Tables[0].Rows[num]["barcode"]);
                }
            }
            else
            {
                listBoxControl_0.Items.Clear();
            }
        }

        private void method_2(object sender, EventArgs e)
        {
        }

        private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
        {
            string filename = this.openFileDialog_0.FileName.ToString();
            this.pictureEdit1.Image = Image.FromFile(filename);
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            this.btnChoose.Enabled = this.btn_Save.Enabled;
        }

        private void txtGoodsid_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void txtGoodsid_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F2) & (this.string_0 == "S"))
            {
                this.string_1 = "SELECT gs.goods_id AS [M\x00e3 số],gs.short_name AS [T\x00ean s\x00e1ch],grp.description AS [Loại s\x00e1ch], PARSENAME(convert(varchar,convert(MONEY,pr.rtprice),1),0 ) AS [Gi\x00e1 b\x00eca], gs.Status AS [Trạng th\x00e1i] FROM tblGoods AS gs INNER JOIN tblGoodsGrp AS grp ON gs.grp_id = grp.id INNER JOIN tblPrice AS pr ON gs.goods_id = pr.goods_id ";
                Class7.BrowserForm1(this.string_1, Class7.oleDbConnection_1);
                this.txtGoodsid.Text = BrowseForm.strReturn;
                this.txtGoodsid.SelectAll();
                this.txtGoodsid_KeyDown(this.txtGoodsid, new KeyEventArgs(Keys.Return));
            }
            if (e.KeyCode == Keys.Return)
            {
                string str2 = this.txtGoodsid.Text.Trim();
                Class7.smethod_14("m_plu").ToString().Trim();
                if (str2.Length > 6)
                {
                    this.string_1 = "select goods_id from tblGoods where barcode = '" + str2 + "'";
                    this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_1, this.oleDbConnection_0);
                    using (DataSet set = new DataSet())
                    {
                        this.oleDbDataAdapter_0.Fill(set);
                        if (set.Tables[0].Rows.Count != 0)
                        {
                            this.txtGoodsid.Text = set.Tables[0].Rows[0][0].ToString();
                        }
                        this.oleDbConnection_0.Close();
                    }
                }
                string str = this.txtGoodsid.Text.Trim();
                if ((this.string_0 == "S") & (str.Length == 6))
                {
                    this.txtName.Text = Class7.smethod_29(base.Tag.ToString(), "full_name", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.Txt_OpenDate.DateTime = (DateTime)Class7.smethod_29(base.Tag.ToString(), "open_date", "goods_id", str, "", this.oleDbConnection_0);
                    this.txtBarcode.Text = Class7.smethod_29(base.Tag.ToString(), "barcode", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.Txt_Status.Text = ((bool)Class7.smethod_29(base.Tag.ToString(), "status", "goods_id", str, "", this.oleDbConnection_0)) ? "Đang sử dụng" : "Đ\x00e3 bị đ\x00f3ng";
                    this.txtAuthor.Text = Class7.smethod_29("tblBookAttr", "author", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.CdCbuygdy.Text = Class7.smethod_29("tblBookAttr", "translator", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.txtPublish.Text = Class7.smethod_29("tblBookAttr", "publish", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.txtNumOfPage.Text = Class7.smethod_29("tblBookAttr", "pages", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.txtWeight.Text = Class7.smethod_29("tblBookAttr", "weight", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.txtDimension.Text = Class7.smethod_29("tblBookAttr", "dimension", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.cmbMonth.Text = Class7.smethod_29("tblBookAttr", "pl_month", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.cmbYear.Text = Class7.smethod_29("tblBookAttr", "pl_year", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.cmbLanguage.SelectedIndex = ((int)Class7.smethod_29("tblBookAttr", "language", "goods_id", str, "", this.oleDbConnection_0)) - 1;
                    this.cmbForm.SelectedIndex = ((int)Class7.smethod_29("tblBookAttr", "form_type", "goods_id", str, "", this.oleDbConnection_0)) - 1;
                    this.txtIntro.Text = Class7.smethod_29("tblBookAttr", "introinfo", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.txtRtPrice.Text = Class7.smethod_29("tblPrice", "rtprice", "goods_id", str, "", this.oleDbConnection_0).ToString();
                    this.cmbUnit.Text = Class7.smethod_13("tblUnit", Class7.smethod_29(base.Tag.ToString(), "piceunit", "goods_id", str, "", this.oleDbConnection_0).ToString());
                    this.cmbGroup.Text = Class7.smethod_13("tblGoodsGrp", Class7.smethod_29(base.Tag.ToString(), "grp_id", "goods_id", str, "", this.oleDbConnection_0).ToString());
                    if (this.txtName.Text.Trim().Length > 0)
                    {
                        Class11.smethod_3(this);
                        this.btn_Delete.Text = ((bool)Class7.smethod_29(base.Tag.ToString(), "status", "goods_id", str, "", this.oleDbConnection_0)) ? "&X\x00f3a" : "&Phục hồi";
                        this.string_0 = "F";
                    }
                    try
                    {
                        byte[] buffer = (byte[])Class7.smethod_29(base.Tag.ToString(), "image", "goods_id", str, "", this.oleDbConnection_0);
                        this.pictureEdit1.Image = Class7.smethod_21(buffer);
                    }
                    catch (Exception)
                    {
                        this.pictureEdit1.Image = null;
                    }
                }
            }
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnFormType_Click(object sender, EventArgs e)
        {

        }
    }
}