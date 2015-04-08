using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using ArtDe;
using Microsoft.Win32;
using System.IO;
using System.Web.Configuration;

namespace LibraryManagement.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
#if DEBUG
            Application.Run(new MainForm());
#else
            Application.Run(new FrmLogIn());
#endif


        }
    }
}