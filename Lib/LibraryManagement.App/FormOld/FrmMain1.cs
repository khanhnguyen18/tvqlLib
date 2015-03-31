using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using LibraryManagement.Service;
using LibraryManagement.Domain;

namespace LibraryManagement.App
{
    public partial class FrmMain1 : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain1()
        {
            InitializeComponent();
        }



        private void alertControl_0_AlertClick(object sender, AlertClickEventArgs e)
        {
            this.form_0.Close();
            Class7.smethod_25();
            Process.Start(Application.StartupPath + @"\AutoUpdate.exe");
            Environment.Exit(1);
        }

        private void alertControl_0_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            this.form_0 = e.AlertForm;
        }

        private void alertControl_0_ButtonClick(object sender, AlertButtonClickEventArgs e)
        {
            if (e.ButtonName == "close")
            {
                e.AlertForm.Close();
            }
        }

        private void barManager_0_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FrmPtrList list;
                switch (e.Item.Tag.ToString())
                {
                    case "POSSALE":
                        if (Class10.smethod_0())
                        {
                            break;
                        }
                        Class7.smethod_15("Trạm " + SystemInformation.ComputerName + " kh\x00f4ng phải l\x00e0 trạm b\x00e1n h\x00e0ng", 1);
                        return;

                    case "PTRLIST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.rciIijbdca)
                        {
                            goto Label_04AF;
                        }
                        return;

                    case "MERCRT":
                        FrmPtrReturn frm = new FrmPtrReturn();
                        frm.MdiParent = this;
                        frm.Show();
                        return;

                    case "PTRDELETE":
                        FrmPtrDelete frm1 = new FrmPtrDelete();
                        frm1.MdiParent = this;
                        frm1.Show();
                        return;

                    case "PREPORTS":
                        Class11.string_1 = "P";
                        Class11.smethod_20(new FrmReports(), this);
                        return;

                    case "MERCSEARCH":
                        FrmMercPosView frm2 = new FrmMercPosView();
                        frm2.MdiParent = this;
                        frm2.Show();


                        return;

                    case "CURRENCY":
                        FrmCurrency frm3 = new FrmCurrency();
                        frm3.MdiParent = this;
                        frm3.Show();

                        return;

                    case "STOCKADD":
                        FrmLibraryDef frm4 = new FrmLibraryDef();
                        frm4.MdiParent = this;
                        frm4.Show();

                        return;

                    case "UNITS":
                        Class11.smethod_20(new FrmUnits(), this);
                        return;

                    case "GOODSGRP":
                        Class11.smethod_20(new FrmBooksGrp(), this);
                        return;

                    case "GOODS":
                        Class11.smethod_20(new FrmBookDef(), this);
                        return;

                    case "DIAGRAM":
                        Class11.smethod_20(new FrmLibraryLoc(), this);
                        return;

                    case "MERCLOCATION":
                        Class11.smethod_20(new FrmBooksLocation(), this);
                        return;

                    case "LABELS":
                        Class11.smethod_20(new FrmCardPrint(), this);
                        return;

                    case "KITS":
                        Class11.smethod_20(new FrmKitDef(), this);
                        return;

                    case "KITLABELS":
                        Class11.smethod_20(new FrmKitLabelPrn(), this);
                        return;

                    case "KITSLIST":
                        Class11.smethod_20(new FrmKitList(), this);
                        return;

                    case "NOTEPRN":
                        FrmNoteLabelPrn frm5 = new FrmNoteLabelPrn();
                        frm5.MdiParent = this;
                        frm5.Show();
                        return;

                    case "HISPRICE":
                        new FrmGetDates().ShowDialog();
                        if (Class7.rciIijbdca)
                        {
                            goto Label_0627;
                        }
                        return;

                    case "CUSTOMER":
                        FrmReaderDef frm6 = new FrmReaderDef();
                        frm6.MdiParent = this;
                        frm6.Show();

                        return;

                    case "STRLIST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.rciIijbdca)
                        {
                            goto Label_0666;
                        }
                        return;

                    case "ORDER":
                        Class11.smethod_20(new FrmMercOrder(), this);
                        return;

                    case "ORDERAUTO":
                        Class11.smethod_20(new FrmAutoOrder(), this);
                        return;

                    case "ORDERLIST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.rciIijbdca)
                        {
                            goto Label_06AD;
                        }
                        return;

                    case "MERCLIST":
                        Class11.smethod_20(new FrmMercList(), this);
                        return;

                    case "TRANSCODE":
                        Class11.string_1 = "K";
                        Class11.smethod_20(new FrmTransCode(), this);
                        return;

                    case "STKINFO":
                        Class11.smethod_20(new FrmLibraryInfo(), this);
                        return;

                    case "SUPPINFO":
                        Class11.smethod_20(new FrmSuppInfo(), this);
                        return;

                    case "MERCQR":
                        Class11.smethod_20(new FrmBookView(), this);
                        return;

                    case "KREPORTS":
                        Class11.string_1 = "K";
                        Class11.smethod_20(new FrmReports(), this);
                        return;

                    case "ADJUST":
                        Class11.smethod_20(new FrmAdjust_grp(), this);
                        return;

                    case "SUPPDEF":
                        Class11.smethod_20(new FrmCustomer(), this);
                        return;

                    case "EXIT":
                        if (Class7.smethod_15("Bạn chắc chắn tho\x00e1t khỏi chương tr\x00ecnh ?", 2) == 1)
                        {
                            goto Label_0766;
                        }
                        return;

                    case "STATIONS":
                        Class11.smethod_20(new FrmStations(), this);
                        return;

                    case "UTILS":
                        Class11.smethod_20(new FrmUtils(), this);
                        return;

                    case "PASSCHANGE":
                        Class11.smethod_20(new FrmChangePass(), this);
                        return;

                    case "USERMNG":
                        Class11.smethod_20(new FrmUser(), this);
                        return;

                    case "USERGRP":
                        Class11.smethod_20(new FrmUserGrp(), this);
                        return;

                    case "CLEARSYS":
                        Class7.smethod_43();
                        Class7.smethod_15("Ho\x00e0n th\x00e0nh khởi tạo trạng th\x00e1i", 2);
                        return;

                    case "ABOUT":
                        new FrmAbout().ShowDialog();
                        return;

                    case "USERGUIDE":
                        Process.Start("Library.chm");
                        return;

                    case "ACCTRANS":
                        Class11.string_1 = "A";
                        Class11.smethod_20(new FrmAtrCode(), this);
                        return;

                    case "ACCTRLIST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.rciIijbdca)
                        {
                            goto Label_082D;
                        }
                        return;

                    case "ACCLIST":
                        Class11.smethod_20(new FrmAcountList(), this);
                        return;

                    case "ACCLV1":
                        Class11.smethod_20(new FrmMap_01(), this);
                        return;

                    case "ACCLV2":
                        Class11.smethod_20(new FrmMap_02(), this);
                        return;

                    case "ACCLV3":
                        Class11.smethod_20(new FrmMap_03(), this);
                        return;

                    case "ACCDETAIL":
                        Class11.smethod_20(new FrmOpen_Acc(), this);
                        return;

                    case "ACCVIEW":
                        Class11.smethod_20(new FrmAccountInfo(), this);
                        return;

                    case "CREATETR":
                        Class11.smethod_20(new FrmCreateTran(), this);
                        return;

                    case "AREPORT":
                        Class11.string_1 = "A";
                        Class11.smethod_20(new FrmReports(), this);
                        return;

                    case "CSCARD":
                        if (!(SystemInformation.ComputerName != "TUANANH"))
                        {
                            goto Label_08E0;
                        }
                        return;

                    case "CSCARDINFO":
                        if (!(SystemInformation.ComputerName != "TUANANH"))
                        {
                            goto Label_0909;
                        }
                        return;

                    case "LOAN":
                        Class11.smethod_20(new FrmLoanInfo(), this);
                        return;

                    case "RECEIVED":
                        Class11.smethod_20(new FrmBookRb(), this);
                        return;

                    case "OVERDUELST":
                        Class11.smethod_20(new FrmOverDueInfo(), this);
                        return;

                    case "BOOKSEARCH":
                        Class11.smethod_20(new BookListForm(), this);
                        return;

                    case "LANGUAGE":
                        Class11.smethod_20(new FrmLanguage(), this);
                        return;

                    case "LOANLST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.rciIijbdca)
                        {
                            goto Label_096B;
                        }
                        return;

                    case "LREPORTS":
                        Class11.smethod_20(new FrmReaderInfo(), this);
                        return;

                    case "LBRCARD":
                        Class11.smethod_20(new FrmCardPrint(), this);
                        return;

                    default:
                        return;
                }
                FrmPosSale frm9 = new FrmPosSale();
                frm9.MdiParent = this;
                frm9.Show();

                return;
            Label_04AF:
                list = new FrmPtrList();
                list.MdiParent = this;
                list.Show();
                return;
            Label_0627:
                Class11.smethod_20(new FrmHisPrice(), this);
                return;
            Label_0666:
                Class11.smethod_20(new FrmStrList(), this);
                return;
            Label_06AD:
                Class11.smethod_20(new FrmOrderList(), this);
                return;
            Label_0766:
                Class7.smethod_25();
                Environment.Exit(0);
                return;
            Label_082D:
                Class11.smethod_20(new FrmAtrList(), this);
                return;
            Label_08E0:
                Class11.smethod_20(new FrmCsCard(), this);
                return;
            Label_0909:
                Class11.smethod_20(new FrmCsCardInfo(), this);
                return;
            Label_096B:
                Class11.smethod_20(new FrmLoanInvList(), this);
            }
            catch (Exception)
            {
            }
        }


        private void FrmMain1_Activated(object sender, EventArgs e)
        {
            //throw -559038242;
        }

        private void FrmMain1_Load(object sender, EventArgs e)
        {
            if (Class7.GetUserRight() < 4)
            {
                this.string_0 = "update tblMenus set skip = 1 ";
                Class7.smethod_4(this.string_0);
                this.string_0 = "update tblMenus set skip = 0 where menukey IN('USERGUIDE','STATIONS')";
                Class7.smethod_4(this.string_0);
                this.BuildMenu();
            }
            else
            {
                this.UpdateSkip();
                this.string_0 = "update tblMenus set skip = 0 where menukey IN('USERGUIDE','STATIONS')";
                Class7.smethod_4(this.string_0);
                this.BuildMenu();
            }
            string str = string.Format("{0:dd/MM/yyy}", DateTime.Parse(Class7.smethod_19().ToString()));
            this.Text = string.Concat(new object[] { Class7.smethod_14("m_softname"), " (USER NAME : ", Class7.string_7, "- COMPUTER NAME :", SystemInformation.ComputerName, " ", str, ")" });
            this.Txt_Date.Caption = str;
            this.Lbl_IpAddress.Caption = Class7.smethod_52();
            this.barStaticItem1.Caption = Class13.smethod_1(Class7.smethod_14("m_copyright").ToString(), Class13.string_0);
        }

        private void iBookFinder_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Class11.smethod_20(new BookListForm(), this);
        }

        private void iCardDef_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Class11.smethod_20(new FrmLoanInfo(), this);
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Class7.smethod_15("Bạn chắc chắn tho\x00e1t khỏi chương tr\x00ecnh ?", 2) == 1)
            {
                Class7.smethod_25();
                Environment.Exit(0);
            }
        }

        private void iLoan_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Class11.smethod_20(new FrmLoanInfo(), this);
        }

        private void iLoanList_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            new FrmGetDates().ShowDialog();
            if (Class7.rciIijbdca)
            {
                Class11.smethod_20(new FrmLoanInvList(), this);
            }
        }

        private void iMail_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class11.smethod_20(new FrmStationView(), this);
        }



        private void iPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class11.smethod_20(new FrmChangePass(), this);
        }

        private void iReaderInfo_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Class11.smethod_20(new FrmReaderInfo(), this);
        }

        private void iReaderInfo_LinkPressed(object sender, NavBarLinkEventArgs e)
        {
        }

        private void iReaderList_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Class11.smethod_20(new FrmReaderList(), this);
        }

        private void iReturn_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Class11.smethod_20(new FrmBookRb(), this);
        }

        private void BuildMenu()
        {
            this.barManager_0.ForceLinkCreate();
            BarManager manager = null;
            bool flag = false;
            BarSubItem item = new BarSubItem();

            MenusService menusSer = new MenusService();
            TList<Menus> lstMainMenu = menusSer.GetAll();

            foreach (Menus menu in lstMainMenu)
            {
                if (menu.Subitem == 1)
                {
                    item = new BarSubItem(manager, menu.Prompt.Trim());
                    item.Name = menu.Menukey.Trim();
                    this.bar_0.AddItem(item);
                    continue;
                }

                if (menu.Menukey.Trim() == "/-")
                {
                    flag = true;
                    continue;
                }

                if (menu.Subitem == 2)
                {
                    BarSubItem item2 = new BarSubItem(manager, menu.Prompt.ToString());
                    item2.Tag = menu.Id.ToString();
                    item2.Enabled = menu.Skip == null ? false : menu.Skip.Value;
                    item2.ImageIndex = menu.Imageidx == null ? -1 : menu.Imageidx.Value;
                    item.AddItem(item2);

                    TList<Menus> lstSubMenu = menusSer.Find("parent=" + int.Parse(item2.Tag.ToString()));
                    foreach (Menus submenu in lstSubMenu)
                    {
                        if (submenu.Menukey.Trim() == "/-")
                        {
                            flag = true;
                        }
                        else
                        {
                            BarButtonItem item3 = new BarButtonItem(manager, submenu.Prompt, submenu.Imageidx.Value);
                            item3.Tag = submenu.Menukey.Trim();
                            item3.Enabled = submenu.Skip.Value;

                            BarItemLink link = item2.AddItem(item3);
                            if (flag)
                            {
                                link.BeginGroup = true;
                                flag = false;
                            }
                        }
                    }
                    continue;

                }

                if ((menu.Subitem == 0) && (menu.Menukey.Trim() != "/-"))
                {
                    BarButtonItem item4 = new BarButtonItem(manager, menu.Prompt, menu.Imageidx.Value);

                    item4.Tag = menu.Menukey.Trim();
                    item4.Enabled = menu.Skip.Value;

                    BarItemLink link2 = item.AddItem(item4);
                    if (!flag)
                    {
                        continue;
                    }
                    link2.BeginGroup = true;
                    flag = false;
                }
            }
        }


        private void method_1()
        {
            if (SystemInformation.ComputerName == "ITMANAGER")
            {
                DataSet set;
                OleDbConnection selectConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; data source= " + Application.StartupPath + @"\Menus.xls;Extended Properties=Excel 8.0;");
                this.oleDbDataAdapter_0 = new OleDbDataAdapter("delete from tblMenus;DBCC CHECKIDENT(tblMenus, RESEED,0)", this.oleDbConnection_0);
                using (set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    this.oleDbConnection_0.Close();
                }
                this.string_0 = "SELECT subitem, parent, prompt, menukey, depcode, basicright,imageidx FROM [tblMenus$]";
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, selectConnection);
                int num = 1;
                using (DataTable table = new DataTable())
                {
                    this.oleDbDataAdapter_0.Fill(table);
                    this.oleDbConnection_0.Close();
                    foreach (DataRow row in table.Rows)
                    {
                        this.string_0 = string.Concat(new object[] { "INSERT INTO tblMenus (subitem, parent, prompt, menukey, depcode,basicright,skip,imageidx) VALUES('", row["subitem"], "','", row["parent"], "',N'", row["prompt"], "','", row["menukey"], "','", row["depcode"], "','", row["basicright"], "',1,'", row["imageidx"], "')" });
                        this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                        using (set = new DataSet())
                        {
                            this.oleDbDataAdapter_0.Fill(set);
                            this.oleDbConnection_0.Close();
                        }
                        num++;
                    }
                }
            }
        }

        private void method_2()
        {
            int count = this.barManager_0.Items.Count;
            for (int i = 0; i <= (count - 1); i++)
            {
                if ((((this.barManager_0.Items[i].Name == "POS") || (this.barManager_0.Items[i].Name == "GENERAL")) || ((this.barManager_0.Items[i].Name == "STOCK") || (this.barManager_0.Items[i].Name == "SYSTEM"))) || (this.barManager_0.Items[i].Name == "LIBRARY"))
                {
                    this.barManager_0.Items[i].Enabled = false;
                }
            }
            this.iPass.Enabled = false;
            this.iExit.Enabled = false;
            this.iBookFinder.Enabled = false;
            this.iLoan.Enabled = false;
            this.iLoanList.Enabled = false;
            this.iReturn.Enabled = false;
            this.iCardDef.Enabled = false;
            this.iReaderInfo.Enabled = false;
            this.iReaderList.Enabled = false;
        }

        private void method_3()
        {
            int count = this.barManager_0.Items.Count;
            for (int i = 0; i <= (count - 1); i++)
            {
                if ((((this.barManager_0.Items[i].Name == "POS") || (this.barManager_0.Items[i].Name == "GENERAL")) || ((this.barManager_0.Items[i].Name == "STOCK") || (this.barManager_0.Items[i].Name == "SYSTEM"))) || (this.barManager_0.Items[i].Name == "LIBRARY"))
                {
                    this.barManager_0.Items[i].Enabled = true;
                }
            }
            this.iPass.Enabled = true;
            this.iExit.Enabled = true;
            this.iBookFinder.Enabled = true;
            this.iLoan.Enabled = true;
            this.iLoanList.Enabled = true;
            this.iReturn.Enabled = true;
            this.iCardDef.Enabled = true;
            this.iReaderInfo.Enabled = true;
            this.iReaderList.Enabled = true;
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            Form[] mdiChildren = base.MdiChildren;
            if (base.MdiChildren.Length == 0)
            {
                this.method_3();
            }
            else
            {
                this.method_2();
            }
        }

        private void timer_1_Tick(object sender, EventArgs e)
        {
            string str = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string str2 = Class7.smethod_14("m_version").ToString();
            if (str != str2)
            {
                string text = "Hiện đang c\x00f3 phi\x00ean bản mới hơn phi\x00ean bản hiện thời, bạn h\x00e3y cập nhật để nhận được những sửa đổi mới nhất";
                this.alertControl_0.Show(this, "Update found", text, text, this.imageList_1.Images[1]);
            }
        }

        private void timer_2_Tick(object sender, EventArgs e)
        {
            Class7.smethod_24();
        }

        private void timer_3_Tick(object sender, EventArgs e)
        {
            try
            {
                this.string_0 = "SELECT [id],[fr_pos],[to_pos],[sender],[msg_date],[msg_time],[message]  FROM [tblQueuemsg]  where to_pos = " + Class7.smethod_51();
                this.oleDbDataAdapter_0 = new OleDbDataAdapter(this.string_0, this.oleDbConnection_0);
                using (DataSet set = new DataSet())
                {
                    this.oleDbDataAdapter_0.Fill(set);
                    if (set.Tables[0].Rows.Count != 0)
                    {
                        this.timer_3.Enabled = false;
                        new FrmMessageQue().ShowDialog();
                        this.timer_3.Enabled = true;
                    }
                }
                this.oleDbConnection_0.Close();
            }
            catch (Exception)
            {
            }
        }

        public void UpdateSkip()
        {
            this.oleDbDataAdapter_0 = new OleDbDataAdapter("Update tblMenus set Skip =0 where basicright <> 1 AND subitem <> -1", this.oleDbConnection_0);
            DataSet dataSet = new DataSet();
            this.oleDbDataAdapter_0.Fill(dataSet);
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from tblUser where id = " + Class7.GetUserRight(), this.oleDbConnection_0);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.string_1 = Class13.smethod_2(dataTable.Rows[0]["mright"].ToString());
            this.string_1.ToCharArray();
            int index = 0;
            string[] strArray = this.string_1.Split(new char[] { ';' });
            string str = null;
            string str2 = null;
            for (index = 0; index <= (strArray.Length - 2); index++)
            {
                str = strArray[index].ToString();
                for (int i = index + 1; i <= (strArray.Length - 1); i++)
                {
                    str2 = strArray[i].ToString();
                    if (str == str2)
                    {
                        strArray[i] = "";
                    }
                }
            }
            int length = strArray.Length;
            string str3 = null;
            new DataTable();
            for (index = 0; index <= (length - 1); index++)
            {
                str3 = strArray[index].ToString();
                if (!string.IsNullOrEmpty(str3))
                {
                    DataSet set2 = new DataSet();
                    using (new OleDbCommand())
                    {
                    }
                    new OleDbDataAdapter(" Update tblMenus set Skip =1 where [id] = " + int.Parse(str3), this.oleDbConnection_0).Fill(set2);
                }
            }
        }

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle = 520;
                return createParams;
            }
        }

    }
}