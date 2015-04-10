using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmReaderDef : DevExpress.XtraEditors.XtraForm
    {
        public FrmReaderDef()
        {
            InitializeComponent();

            this.oleDbConnection_0 = DataProvider.GetConnection();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string text = this.btn_Delete.Text;
            if ((text != null) && (text == "&X\x00f3a"))
            {
                if (Class7.ShowMessageBox("Bạn chắc chắn muốn x\x00f3a số thẻ n\x00e0y ? ", 2) == 1)
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "id", this.txtCsId.Text.Trim(), "", Class7.oleDbConnection_1);
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.ShowMessageBox("Bạn chắc chắn muốn phục hồi số thẻ n\x00e0y ? ", 2) == 1)
            {
                Class7.smethod_23(base.Tag.ToString(), 1, "id", this.txtCsId.Text.Trim(), "", Class7.oleDbConnection_1);
                this.Txt_Status.Text = "Đang hoạt động";
                this.btn_Delete.Text = "&X\x00f3a";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
            this.txtCsId.Enabled = false;
            this.string_1 = "E";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Class11.smethod_8(this);
            Class11.smethod_5(this, "T");
            Class11.smethod_1(this);
            this.string_1 = "N";
            this.txtCsId.Enabled = false;
            this.txtDuedate.Focus();
            this.txtDuedate.EditValue = DateTime.Now.AddYears(1);
            this.Txt_OpenDate.EditValue = DateTime.Now;
            this.pictureEdit1.Image = null;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa nhập họ t\x00ean", 1);
                this.txtName.Focus();
            }
            else
            {
                string str10 = this.txtCsId.Text.Trim();
                string str = this.txtName.Text.Trim();
                string str2 = this.txtAddress.Text.Trim();
                string str3 = this.txtPhone.Text.Trim();
                string str4 = this.txtFax.Text.Trim();
                string str9 = this.txtRemark.Text.Trim();
                string str5 = this.txtPersonId.Text.Trim();
                string str6 = this.txtPlaceOfIssue.Text.Trim();
                string str7 = this.txtEmail.Text.Trim();
                string str11 = string.Format("{0:d}", Class7.smethod_19());
                string str8 = string.Format("{0:d}", this.txtDuedate.EditValue);
                string str12 = this.string_1;
                if (str12 != null)
                {
                    if (!(str12 == "N"))
                    {
                        if (str12 == "E")
                        {
                            this.RrqIxZxw5(this, new EventArgs());
                            this.string_0 = "UPDATE    tblCustomer SET fullname = N'" + str + "', address = N'" + str2 + "', phone = '" + str3 + "', fax = '" + str4 + "', person_id = '" + str5 + "', place_issue = N'" + str6 + "',email = '" + str7 + "', due_date = '" + str8 + "', remark = N'" + str9 + "' WHERE id = '" + str10 + "'";
                            Class7.smethod_4(this.string_0);
                        }
                    }
                    else
                    {
                        this.RrqIxZxw5(this, new EventArgs());
                        this.txtCsId.Text = Class7.smethod_9(base.Tag.ToString(), "TV{0:000000}", this.oleDbConnection_0);
                        str10 = this.txtCsId.Text.Trim();
                        this.string_0 = "INSERT INTO tblCustomer (id, fullname, address, phone, fax, person_id,place_issue, email, due_date, remark, open_date, Status) VALUES ('" + str10 + "',N'" + str + "',N'" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "',N'" + str6 + "','" + str7 + "','" + str8 + "',N'" + str9 + "','" + str11 + "',1) ";
                        Class7.smethod_4(this.string_0);
                    }
                }
                Class7.smethod_20(this.pictureEdit1, base.Tag.ToString(), "Image", "id", str10);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.string_1 = "S";
            this.pictureEdit1.Image = null;
            this.txtCsId.Enabled = true;
            this.string_0 = "SELECT id AS [M\x00e3 thẻ], fullname AS [Họ v\x00e0 t\x00ean], phone AS [Số ĐT], status AS [Trạng th\x00e1i] from " + base.Tag.ToString();
            Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
            this.txtCsId.Text = BrowseForm.strReturn;
            this.txtCsId.Focus();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            this.openFileDialog_0.InitialDirectory = Application.StartupPath;
            this.openFileDialog_0.Title = "Chọn file ảnh";
            this.openFileDialog_0.Filter = "JPEG Files|*.jpg|Bitmap Files|*.bmp|GIF Files|*.Gif";
            this.openFileDialog_0.ShowDialog();
        }



        private void FrmReaderDef_Load(object sender, EventArgs e)
        {
            this.RrqIxZxw5(this, new EventArgs());
            Class11.smethod_8(this);
            this.Text = "Đăng k\x00fd thẻ thư viện";
            base.Tag = "tblCustomer";
        }



        private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
        {
            string filename = this.openFileDialog_0.FileName.ToString();
            this.pictureEdit1.Image = Image.FromFile(filename);
        }

        private void RrqIxZxw5(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }

        private void txtCsId_EditValueChanged(object sender, EventArgs e)
        {
            if ((this.string_1 == "S") && (this.txtCsId.Text.Length >= 8))
            {
                string str = this.txtCsId.Text.Trim();
                this.txtName.Text = Class7.smethod_29(base.Tag.ToString(), "fullname", "id", str, "", this.oleDbConnection_0).ToString();
                this.txtAddress.Text = Class7.smethod_29(base.Tag.ToString(), "address", "id", str, "", this.oleDbConnection_0).ToString();
                this.txtPhone.Text = Class7.smethod_29(base.Tag.ToString(), "phone", "id", str, "", this.oleDbConnection_0).ToString();
                this.txtFax.Text = Class7.smethod_29(base.Tag.ToString(), "fax", "id", str, "", this.oleDbConnection_0).ToString();
                this.txtEmail.Text = Class7.smethod_29(base.Tag.ToString(), "email", "id", str, "", this.oleDbConnection_0).ToString();
                this.txtRemark.Text = Class7.smethod_29(base.Tag.ToString(), "remark", "id", str, "", this.oleDbConnection_0).ToString();
                this.txtPersonId.Text = Class7.smethod_29(base.Tag.ToString(), "person_id", "id", str, "", this.oleDbConnection_0).ToString();
                this.txtPlaceOfIssue.Text = Class7.smethod_29(base.Tag.ToString(), "place_issue", "id", str, "", this.oleDbConnection_0).ToString();
                this.txtDuedate.Text = Class7.smethod_29(base.Tag.ToString(), "due_date", "id", str, "", this.oleDbConnection_0).ToString();
                if (this.txtName.Text.Trim().Length > 0)
                {
                    Class11.smethod_3(this);
                    this.btn_Delete.Text = ((bool)Class7.smethod_29(base.Tag.ToString(), "status", "id", str, "", this.oleDbConnection_0)) ? "&X\x00f3a" : "&Phục hồi";
                    this.string_1 = "F";
                    this.Txt_Status.Text = ((bool)Class7.smethod_29(base.Tag.ToString(), "status", "id", str, "", this.oleDbConnection_0)) ? "Đang sử dụng" : "Đ\x00e3 bị đ\x00f3ng";
                    try
                    {
                        byte[] buffer = (byte[])Class7.smethod_29(base.Tag.ToString(), "image", "id", str, "", this.oleDbConnection_0);
                        this.pictureEdit1.Image = Class7.smethod_21(buffer);
                    }
                    catch (Exception)
                    {
                        this.pictureEdit1.Image = null;
                    }
                    this.txtCsId.Enabled = false;
                    this.btn_Edit.Focus();
                }
            }
        }

        private void txtCsId_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.F2) && (this.string_1 == "S"))
            {
                this.string_0 = "SELECT id AS [M\x00e3 thẻ], fullname AS [Họ v\x00e0 t\x00ean], phone AS [Số ĐT], status AS [Trạng th\x00e1i] from " + base.Tag.ToString();
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.txtCsId.Text = BrowseForm.strReturn;
            }
        }
    }
}