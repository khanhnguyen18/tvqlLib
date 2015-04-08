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

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings["Change"].Value == "1")
            {
                config.AppSettings.Settings["My"].Value = config.AppSettings.Settings["Linh"].Value;
                config.AppSettings.Settings["Linh"].Value = "No Name";
                config.AppSettings.Settings["Change"].Value = "0";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            
#if DEBUG
            Application.Run(new MainForm());
#else
            Application.Run(new FrmLogIn());
#endif


        }
    }
}