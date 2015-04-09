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
            if (config.AppSettings.Settings["buzan"].Value == "9FDAD6D3")
            {
                config.AppSettings.Settings["sdfew"].Value = Decode.EncodeCode(config.AppSettings.Settings["somm"].Value);
                config.AppSettings.Settings["somm"].Value = "";
                config.AppSettings.Settings["dffeew"].Value = Decode.EncodeCode(config.AppSettings.Settings["millionaire"].Value);
                config.AppSettings.Settings["millionaire"].Value = "";
                config.AppSettings.Settings["fdff"].Value = Decode.EncodeCode(config.AppSettings.Settings["eker"].Value);
                config.AppSettings.Settings["eker"].Value = "";

                config.AppSettings.Settings["buzan"].Value = "91C9CDE1CD";
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