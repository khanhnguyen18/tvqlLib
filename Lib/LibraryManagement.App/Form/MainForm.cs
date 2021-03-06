﻿using DevExpress.LookAndFeel;
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
using ArtDe;
using System.Configuration;

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
            SysvarService ser = new SysvarService();
            Sysvar sysV = ser.GetByMCode("Themes");
            if (sysV != null && !string.IsNullOrEmpty(sysV.MValue))
            {
                defaultLookAndFeel_0.LookAndFeel.SkinName = sysV.MValue;

                bool find = false;
                foreach (BarSubItemLink itemLink in barSubItem1.ItemLinks)
                {
                    foreach (BarItemLink styleMenu in itemLink.Item.ItemLinks)
                    {
                        BarCheckItem checkItem = styleMenu.Item as BarCheckItem;
                        if (checkItem != null && checkItem.Caption == sysV.MValue)
                        {
                            checkItem.Checked = true;
                            find = true;
                            break;
                        }
                    }

                    if (find)
                        break;
                }
            }


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
            //ToolsGui.BindToParentForm(new FrmStationView(), this);
        }

        private void iPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToolsGui.BindToParentForm(new ChangePassForm(), this);
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
                if (menu.Subitem == 1 && menu.Skip == true)
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

                if (e.Item.GetType() == typeof(BarCheckItem))
                {
                    BarCheckItem checkItem = e.Item as BarCheckItem;
                    if (checkItem != null && checkItem.GroupIndex == 1)
                    {
                        defaultLookAndFeel_0.LookAndFeel.SkinName = e.Item.Caption;
                        SysvarService ser = new SysvarService();
                        Sysvar sysV = ser.GetByMCode("Themes");
                        if (sysV == null)
                        {
                            sysV = new Sysvar();
                            sysV.MCode = "Themes";
                            sysV.Type = "G";
                        }

                        sysV.MValue = checkItem.Caption;
                        ser.Save(sysV);
                    }

                    return;
                }

                switch (e.Item.Tag.ToString())
                {
                    case "PREPORTS":
                        Class11.string_1 = "P";
                        ToolsGui.BindToParentForm(new FrmReports(), this);
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

                    case "CUSTOMER":
                        ReaderForm frm6 = new ReaderForm();
                        frm6.MdiParent = this;
                        frm6.Show();
                        return;

                    case "ORDER":
                        ToolsGui.BindToParentForm(new FrmMercOrder(), this);
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

                    case "SUPPDEF":
                        ToolsGui.BindToParentForm(new FrmCustomer(), this);
                        return;

                    case "ABOUT":
                        new AboutForm().ShowDialog();
                        return;

                    case "AREPORT":
                        Class11.string_1 = "A";
                        ToolsGui.BindToParentForm(new FrmReports(), this);
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
                            ToolsGui.BindToParentForm(new FrmLoanInvList(), this);
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


            }
            catch
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

        private void barLargeButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class6.string_1 = "13";
            ToolsGui.BindToParentForm(new FrmFromSupp(), this);
        }

        private void barLargeButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToolsGui.BindToParentForm(new FrmLibraryInfo(), this);
        }

        private void blbiChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            ToolsGui.BindToParentForm(new ChangePassForm(), this);

        }

        private void blbiSupplierReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class6.string_1 = "15";
            ToolsGui.BindToParentForm(new FrmToSupp(), this);
        }

        private void blbiBuyOld_ItemClick(object sender, ItemClickEventArgs e)
        {
            Class6.string_1 = "19";
            ToolsGui.BindToParentForm(new FrmBookLost(), this);
        }

        private void barLargeButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            BackupForm frm = new BackupForm();
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            RestoreForm frm = new RestoreForm();
            frm.Show();
        }

    }
}