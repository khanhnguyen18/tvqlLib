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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region LOAD FORM
        private void FrmMain1_Load(object sender, EventArgs e)
        {
            BuildMenu();
            //if (Class7.GetUserRight() < 4)
            //{
            //    this.string_0 = "update tblMenus set skip = 1 ";
            //    Class7.smethod_4(this.string_0);
            //    this.string_0 = "update tblMenus set skip = 0 where menukey IN('USERGUIDE','STATIONS')";
            //    Class7.smethod_4(this.string_0);
            //    this.BuildMenu();
            //}
            //else
            //{
            //    this.UpdateSkip();
            //    this.string_0 = "update tblMenus set skip = 0 where menukey IN('USERGUIDE','STATIONS')";
            //    Class7.smethod_4(this.string_0);
            //    this.BuildMenu();
            //}

            this.Txt_Date.Caption = string.Format("{0:dd/MM/yyy}", DateTime.Now); ;

            //this.Text = string.Concat(new object[] { Class7.smethod_14("m_softname"), " (USER NAME : ", Class7.string_7, "- COMPUTER NAME :", SystemInformation.ComputerName, " ", str, ")" });
            //this.Lbl_IpAddress.Caption = Class7.smethod_52();
            //this.barStaticItem1.Caption = Class13.smethod_1(Class7.smethod_14("m_copyright").ToString(), Class13.string_0);
        }

      

        //Maybe use
        //public void UpdateSkip()
        //{
        //    this.oleDbDataAdapter_0 = new OleDbDataAdapter("Update tblMenus set Skip =0 where basicright <> 1 AND subitem <> -1", this.oleDbConnection_0);
        //    DataSet dataSet = new DataSet();
        //    this.oleDbDataAdapter_0.Fill(dataSet);
        //    OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from tblUser where id = " + Class7.GetUserRight(), this.oleDbConnection_0);
        //    DataTable dataTable = new DataTable();
        //    adapter.Fill(dataTable);
        //    this.string_1 = Class13.smethod_2(dataTable.Rows[0]["mright"].ToString());
        //    this.string_1.ToCharArray();
        //    int index = 0;
        //    string[] strArray = this.string_1.Split(new char[] { ';' });
        //    string str = null;
        //    string str2 = null;
        //    for (index = 0; index <= (strArray.Length - 2); index++)
        //    {
        //        str = strArray[index].ToString();
        //        for (int i = index + 1; i <= (strArray.Length - 1); i++)
        //        {
        //            str2 = strArray[i].ToString();
        //            if (str == str2)
        //            {
        //                strArray[i] = "";
        //            }
        //        }
        //    }
        //    int length = strArray.Length;
        //    string str3 = null;
        //    new DataTable();
        //    for (index = 0; index <= (length - 1); index++)
        //    {
        //        str3 = strArray[index].ToString();
        //        if (!string.IsNullOrEmpty(str3))
        //        {
        //            DataSet set2 = new DataSet();
        //            using (new OleDbCommand())
        //            {
        //            }
        //            new OleDbDataAdapter(" Update tblMenus set Skip =1 where [id] = " + int.Parse(str3), this.oleDbConnection_0).Fill(set2);
        //        }
        //    }
        //}
        #endregion

        #region LIBRARY MANAGEMENT GROUP(4 item)
        private void iLoan_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ToolsGui.BindToParentForm(new LoanBookForm(), this);
        }

        private void iReturn_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ToolsGui.BindToParentForm(new ReturnBookForm(), this);
        }

        private void iLoanList_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            new FrmGetDates().ShowDialog();
            if (Class7.IsInputDate)
            {
                ToolsGui.BindToParentForm(new FrmLoanInvList(), this);
            }
        }

        private void iBookFinder_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ToolsGui.BindToParentForm(new BookListForm(), this);
        }

        #endregion

        #region USER MANAGEMENT GROUP(3 items)
        private void iCardDef_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ToolsGui.BindToParentForm(new ReaderForm(), this);
        }

        private void iReaderList_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ToolsGui.BindToParentForm(new FrmReaderList(), this);
        }

        private void iReaderInfo_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            ToolsGui.BindToParentForm(new FrmReaderInfo(), this);
        }
        #endregion

        #region STANDARD BAR
  

        private void iMail_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToolsGui.BindToParentForm(new FrmStationView(), this);
        }

        private void iPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToolsGui.BindToParentForm(new FrmChangePass(), this);
        }
        #endregion

        #region MENU BAR
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
                if (menu.Subitem == 1 && menu.Skip== true)
                {
                    item = new BarSubItem(manager, menu.Prompt.Trim());
                    item.Name = menu.Menukey.Trim();
                    this.menuBar.AddItem(item);
                    continue;
                }

                if (menu.Menukey.Trim() == "/-")
                {
                    flag = true;
                    continue;
                }

                if (menu.Subitem == 2 && menu.Skip == true)
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

                if ((menu.Subitem == 0) && (menu.Menukey.Trim() != "/-") && menu.Skip == true)
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
                        Class7.ShowMessageBox("Trạm " + SystemInformation.ComputerName + " kh\x00f4ng phải l\x00e0 trạm b\x00e1n h\x00e0ng", 1);
                        return;

                    case "PTRLIST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.IsInputDate)
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
                        ToolsGui.BindToParentForm(new FrmReports(), this);
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
                        ToolsGui.BindToParentForm(new UnitsForm(), this);
                        return;

                    case "GOODSGRP":
                        ToolsGui.BindToParentForm(new BookCategoryForm(), this);
                        return;

                    case "GOODS":
                        ToolsGui.BindToParentForm(new BookForm(), this);
                        return;

                    case "DIAGRAM":
                        ToolsGui.BindToParentForm(new LibraryLocationForm(), this);
                        return;

                    case "MERCLOCATION":
                        ToolsGui.BindToParentForm(new BooksLocationForm(), this);
                        return;

                    case "LABELS":
                        ToolsGui.BindToParentForm(new CardPrintForm(), this);
                        return;

                    case "KITS":
                        ToolsGui.BindToParentForm(new FrmKitDef(), this);
                        return;

                    case "KITLABELS":
                        ToolsGui.BindToParentForm(new FrmKitLabelPrn(), this);
                        return;

                    case "KITSLIST":
                        ToolsGui.BindToParentForm(new FrmKitList(), this);
                        return;

                    case "NOTEPRN":
                        FrmNoteLabelPrn frm5 = new FrmNoteLabelPrn();
                        frm5.MdiParent = this;
                        frm5.Show();
                        return;

                    case "HISPRICE":
                        new FrmGetDates().ShowDialog();
                        if (Class7.IsInputDate)
                        {
                            goto Label_0627;
                        }
                        return;

                    case "CUSTOMER":
                        ReaderForm frm6 = new ReaderForm();
                        frm6.MdiParent = this;
                        frm6.Show();

                        return;

                    case "STRLIST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.IsInputDate)
                        {
                            goto Label_0666;
                        }
                        return;

                    case "ORDER":
                        ToolsGui.BindToParentForm(new FrmMercOrder(), this);
                        return;

                    case "ORDERAUTO":
                        ToolsGui.BindToParentForm(new FrmAutoOrder(), this);
                        return;

                    case "ORDERLIST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.IsInputDate)
                        {
                            goto Label_06AD;
                        }
                        return;

                    case "MERCLIST":
                        ToolsGui.BindToParentForm(new FrmMercList(), this);
                        return;

                    case "TRANSCODE":
                        Class11.string_1 = "K";
                        ToolsGui.BindToParentForm(new FrmTransCode(), this);
                        return;

                    case "STKINFO":
                        ToolsGui.BindToParentForm(new FrmLibraryInfo(), this);
                        return;

                    case "SUPPINFO":
                        ToolsGui.BindToParentForm(new FrmSuppInfo(), this);
                        return;

                    case "MERCQR":
                        ToolsGui.BindToParentForm(new FrmBookView(), this);
                        return;

                    case "KREPORTS":
                        Class11.string_1 = "K";
                        ToolsGui.BindToParentForm(new FrmReports(), this);
                        return;

                    case "ADJUST":
                        ToolsGui.BindToParentForm(new FrmAdjust_grp(), this);
                        return;

                    case "SUPPDEF":
                        ToolsGui.BindToParentForm(new FrmCustomer(), this);
                        return;

                    case "EXIT":
                        if (Class7.ShowMessageBox("Bạn chắc chắn tho\x00e1t khỏi chương tr\x00ecnh ?", 2) == 1)
                        {
                            goto Label_0766;
                        }
                        return;

                    case "STATIONS":
                        ToolsGui.BindToParentForm(new FrmStations(), this);
                        return;

                    case "UTILS":
                        //ToolsGui.BindToParentForm(new FrmUtils(), this);
                        return;

                    case "PASSCHANGE":
                        ToolsGui.BindToParentForm(new FrmChangePass(), this);
                        return;

                    case "USERMNG":
                        ToolsGui.BindToParentForm(new FrmUser(), this);
                        return;

                    case "USERGRP":
                        ToolsGui.BindToParentForm(new FrmUserGrp(), this);
                        return;

                    

                    case "ABOUT":
                        new AboutForm().ShowDialog();
                        return;

                    case "USERGUIDE":
                        Process.Start("Library.chm");
                        return;

                    case "ACCTRANS":
                        Class11.string_1 = "A";
                        ToolsGui.BindToParentForm(new FrmAtrCode(), this);
                        return;

                    case "ACCTRLIST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.IsInputDate)
                        {
                            goto Label_082D;
                        }
                        return;

                    case "ACCLIST":
                        ToolsGui.BindToParentForm(new FrmAcountList(), this);
                        return;

                    case "ACCLV1":
                        ToolsGui.BindToParentForm(new FrmMap_01(), this);
                        return;

                    case "ACCLV2":
                        ToolsGui.BindToParentForm(new FrmMap_02(), this);
                        return;

                    case "ACCLV3":
                        ToolsGui.BindToParentForm(new FrmMap_03(), this);
                        return;

                    case "ACCDETAIL":
                        ToolsGui.BindToParentForm(new FrmOpen_Acc(), this);
                        return;

                    case "ACCVIEW":
                        ToolsGui.BindToParentForm(new FrmAccountInfo(), this);
                        return;

                    case "CREATETR":
                        ToolsGui.BindToParentForm(new FrmCreateTran(), this);
                        return;

                    case "AREPORT":
                        Class11.string_1 = "A";
                        ToolsGui.BindToParentForm(new FrmReports(), this);
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
                        ToolsGui.BindToParentForm(new LoanBookForm(), this);
                        return;

                    case "RECEIVED":
                        ToolsGui.BindToParentForm(new ReturnBookForm(), this);
                        return;

                    case "OVERDUELST":
                        ToolsGui.BindToParentForm(new OverDueForm(), this);
                        return;

                    case "BOOKSEARCH":
                        ToolsGui.BindToParentForm(new BookListForm(), this);
                        return;

                    case "LANGUAGE":
                        ToolsGui.BindToParentForm(new FrmLanguage(), this);
                        return;

                    case "LOANLST":
                        new FrmGetDates().ShowDialog();
                        if (Class7.IsInputDate)
                        {
                            goto Label_096B;
                        }
                        return;

                    case "LREPORTS":
                        ToolsGui.BindToParentForm(new FrmReaderInfo(), this);
                        return;

                    case "LBRCARD":
                        ToolsGui.BindToParentForm(new CardPrintForm(), this);
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
                ToolsGui.BindToParentForm(new FrmHisPrice(), this);
                return;
            Label_0666:
                ToolsGui.BindToParentForm(new FrmStrList(), this);
                return;
            Label_06AD:
                ToolsGui.BindToParentForm(new FrmOrderList(), this);
                return;
            Label_0766:
                //Class7.smethod_25();
                //Environment.Exit(0);
                return;
            Label_082D:
                ToolsGui.BindToParentForm(new FrmAtrList(), this);
                return;
            Label_08E0:
                ToolsGui.BindToParentForm(new FrmCsCard(), this);
                return;
            Label_0909:
                ToolsGui.BindToParentForm(new FrmCsCardInfo(), this);
                return;
            Label_096B:
                ToolsGui.BindToParentForm(new FrmLoanInvList(), this);
            }
            catch (Exception)
            {
            }
        }
        #endregion

        private void blbiBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            new BookForm().ShowDialog();
        }

        private void blbiPrintCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            new CardPrintForm().ShowDialog();
        }

        private void barLargeButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            new ReaderForm().ShowDialog();
        }

        private void barLargeButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToolsGui.BindToParentForm(new OverDueForm(), this);
        }
    }
}