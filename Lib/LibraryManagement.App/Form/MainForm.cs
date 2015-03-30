using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using LibraryManagement.Service;
using LibraryManagement.Domain;

namespace LibraryManagement.App
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BuildMenu();
        }

        private void BuildMenu()
        {
            this.barManager1.ForceLinkCreate();
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
                    this.menuBar.AddItem(item);
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
                            item3.Tag =submenu.Menukey.Trim();
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

        //EVENT------------------------------------------------------
        #region NAVIGATE BAR
        private void iLoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //BindToParentForm(new FrmLoanInfo(), this);
        }
        private void iBookFinder_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //BindToParentForm(new BookListForm(), this);
        }

       
        private void iReturn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void iLoanList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }
        private void iCardDef_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //BindToParentForm(new FrmLoanInfo(), this);
        }

        private void iReaderList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void iReaderInfo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        #endregion

        public static void BindToParentForm(Form childForm, Form parentForm)
        {
            childForm.MdiParent = parentForm;
            childForm.Show();
        }

      

       

       
    }
}
