using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagement.App
{
    public partial class FrmCsCard : DevExpress.XtraEditors.XtraForm
    {
        public FrmCsCard()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string text = this.btn_Delete.Text;
            if ((text != null) && (text == "&X\x00f3a"))
            {
                if (Class7.ShowMessageBox("Bạn chắc chắn muốn x\x00f3a m\x00e3 thẻ n\x00e0y ? ", 2) == 1)
                {
                    Class7.smethod_23(base.Tag.ToString(), 0, "card_id", this.Txt_Id.Text.Trim(), "", Class7.oleDbConnection_1);
                    this.Txt_Status.Text = "Đ\x00e3 bị x\x00f3a";
                    this.btn_Delete.Text = "&Phục hồi";
                }
            }
            else if (Class7.ShowMessageBox("Bạn chắc chắn muốn phục hồi m\x00e3 thẻ n\x00e0y ? ", 2) == 1)
            {
                Class7.smethod_23(base.Tag.ToString(), 1, "card_id", this.Txt_Id.Text.Trim(), "", Class7.oleDbConnection_1);
                this.Txt_Status.Text = "Đang hoạt động";
                this.btn_Delete.Text = "&X\x00f3a";
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Class11.smethod_4(this);
            Class11.smethod_5(this, "T");
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
            this.Txt_FullName.Focus();
            this.Txt_OpenDate.Text = Class7.smethod_19();
            this.Txt_DateOfIssue.Text = "1/1/1900";
            this.Txt_BirthDay.Text = "1/1/1900";
            this.xTveRubwQ.Checked = false;
            this.pictureEdit1.Image = null;
            DateTime time2 = DateTime.Now.AddMonths(12);
            this.Txt_DueDate.EditValue = time2;
            this.string_1 = "N";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.Txt_FullName.Text == string.Empty)
            {
                Class7.ShowMessageBox("Bạn chưa đăng k\x00fd t\x00ean kh\x00e1ch h\x00e0ng", 1);
                this.Txt_FullName.Focus();
            }
            else
            {
                DataSet set;
                string str = null;
                int num = this.xTveRubwQ.Checked ? 1 : 0;
                int selectedIndex = this.radioGroup1.SelectedIndex;
                string str3 = this.Txt_PersonId.Text.Trim();
                string str4 = string.Format("{0:d}", this.Txt_BirthDay.EditValue);
                string str5 = string.Format("{0:d}", this.Txt_DateOfIssue.EditValue);
                string str6 = this.Txt_PlaceOfIssue.Text.Trim();
                string str7 = this.Txt_FullName.Text.Trim();
                string str8 = this.Txt_Address.Text.Trim();
                string str9 = this.Txt_Phone.Text.Trim();
                string str10 = this.Txt_Email.Text.Trim();
                double num3 = Class7.smethod_0(this.Txt_DiscPc.Text);
                string str11 = string.Format("{0:d}", this.Txt_DueDate.EditValue);
                string str12 = this.Txt_Remark.Text.Trim();
                double num4 = Class7.smethod_0(this.Txt_BegMark.Text);
                switch (this.string_1)
                {
                    case "N":
                        this.btn_Skip_Click(this, new EventArgs());
                        this.Txt_Id.Text = Class7.smethod_9(base.Tag.ToString(), Class7.smethod_14("m_csprefix").ToString() + "{0:0000000}", this.oleDbConnection_0);
                        str = this.Txt_Id.Text.Trim();
                        this.string_0 = string.Concat(new object[] { 
                            "INSERT INTO ", base.Tag.ToString(), "(card_id, is_vip, cs_sex, person_id, birthday, ps_issuedate, ps_placeissuse, fullname, address, phone, email, disc_pc, iss_date, due_date, remark, status,begmark) VALUES ('", str, "',", num, ",", selectedIndex, ",'", str3, "','", str4, "','", str5, "',N'", str6, 
                            "',N'", str7, "',N'", str8, "','", str9, "','", str10, "',", num3, ",'", Class7.smethod_19(), "','", str11, "',N'", str12, 
                            "',1,", num4, ") "
                         });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                        }
                        Class7.smethod_20(this.pictureEdit1, base.Tag.ToString(), "Image", "card_id", str);
                        break;

                    case "E":
                        this.btn_Skip_Click(this, new EventArgs());
                        str = this.Txt_Id.Text.Trim();
                        this.string_0 = string.Concat(new object[] { 
                            "UPDATE  ", base.Tag.ToString(), " SET is_vip =", num, ", cs_sex =", selectedIndex, ", person_id ='", str3, "', birthday ='", str4, "', ps_issuedate ='", str5, "', ps_placeissuse =N'", str6, "', fullname =N'", str7, 
                            "', address =N'", str8, "', phone ='", str9, "',email ='", str10, "', disc_pc =", num3, ", due_date ='", str11, "', remark = N'", str12, "', begmark = ", num4, " WHERE card_id = '", str, 
                            "'"
                         });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                        }
                        Class7.smethod_20(this.pictureEdit1, base.Tag.ToString(), "Image", "card_id", str);
                        break;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Class11.smethod_2(this);
            Class11.smethod_5(this, "F");
            Class11.smethod_8(this);
            this.pictureEdit1.Image = null;
            this.string_1 = "S";
            this.Txt_Id.Enabled = true;
            this.Txt_Id.Focus();
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            Class11.EnableNewMode(this);
            Class11.smethod_5(this, "F");
            this.string_1 = "D";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            this.openFileDialog_0.InitialDirectory = Application.StartupPath;
            this.openFileDialog_0.Title = "Chọn file ảnh";
            this.openFileDialog_0.Filter = "JPEG Files|*.jpg|Bitmap Files|*.bmp|GIF Files|*.Gif";
            this.openFileDialog_0.ShowDialog();
        }

        private void FrmCsCard_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng k\x00fd thẻ kh\x00e1ch h\x00e0ng th\x00e2n thiết";
            base.Tag = "tblCsCard";
            Class11.smethod_8(this);
            this.btn_Skip_Click(this, new EventArgs());
        }



        private void openFileDialog_0_FileOk(object sender, CancelEventArgs e)
        {
            string filename = this.openFileDialog_0.FileName.ToString();
            this.pictureEdit1.Image = Image.FromFile(filename);
        }

        private void Txt_Id_EditValueChanged(object sender, EventArgs e)
        {
            if (this.string_1 == "S")
            {
                this.string_0 = "SELECT * FROM " + base.Tag.ToString() + " WHERE card_id = '" + this.Txt_Id.Text.Trim() + "' ";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.Txt_FullName.Text = set.Tables[0].Rows[0]["fullname"].ToString();
                        this.Txt_Address.Text = set.Tables[0].Rows[0]["address"].ToString();
                        this.Txt_Phone.Text = set.Tables[0].Rows[0]["phone"].ToString();
                        this.Txt_Email.Text = set.Tables[0].Rows[0]["email"].ToString();
                        this.Txt_PersonId.Text = set.Tables[0].Rows[0]["person_id"].ToString();
                        this.Txt_PlaceOfIssue.Text = set.Tables[0].Rows[0]["ps_placeissuse"].ToString();
                        this.Txt_BirthDay.Text = set.Tables[0].Rows[0]["birthday"].ToString();
                        this.Txt_DateOfIssue.Text = set.Tables[0].Rows[0]["ps_issuedate"].ToString();
                        this.Txt_OpenDate.EditValue = (DateTime)set.Tables[0].Rows[0]["iss_date"];
                        this.Txt_Remark.Text = set.Tables[0].Rows[0]["Remark"].ToString();
                        this.Txt_DiscPc.Text = set.Tables[0].Rows[0]["disc_pc"].ToString();
                        this.xTveRubwQ.Checked = (bool)set.Tables[0].Rows[0]["is_vip"];
                        this.radioGroup1.SelectedIndex = ((bool)set.Tables[0].Rows[0]["cs_sex"]) ? 1 : 0;
                        Class11.smethod_3(this);
                        Class11.smethod_5(this, "F");
                        this.Txt_Status.Text = ((bool)set.Tables[0].Rows[0]["Status"]) ? "Đang hoạt động" : "Đ\x00e3 bị x\x00f3a";
                        this.btn_Delete.Text = ((bool)set.Tables[0].Rows[0]["Status"]) ? "&X\x00f3a" : "&Phục hồi";
                        OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT [Image] FROM " + base.Tag.ToString() + " WHERE card_id = '" + this.Txt_Id.Text.Trim() + "'", this.oleDbConnection_0);
                        using (DataSet set2 = new DataSet())
                        {
                            adapter.Fill(set2);
                            this.oleDbConnection_0.Close();
                            try
                            {
                                byte[] buffer = (byte[])set2.Tables[0].Rows[0][0];
                                this.pictureEdit1.Image = Class7.smethod_21(buffer);
                            }
                            catch (Exception)
                            {
                                this.pictureEdit1.Image = null;
                            }
                        }
                    }
                }
            }
        }

        private void Txt_Id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                this.string_0 = "SELECT card_id AS [M\x00e3 thẻ], FullName AS [T\x00ean kh\x00e1ch h\x00e0ng], Status AS [Hiệu lực] FROM " + base.Tag.ToString();
                Class7.BrowserForm1(this.string_0, this.oleDbConnection_0);
                this.Txt_Id.Text = BrowseForm.strReturn;
                this.Txt_Id.SelectAll();
            }
        }
    }
}