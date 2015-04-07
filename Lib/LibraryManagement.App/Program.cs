using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using ArtDe;

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
            config.ConnectionStrings.ConnectionStrings["netTiersConnectionString"].ConnectionString =
                config.ConnectionStrings.ConnectionStrings["netTiersConnectionString"].ConnectionString.Replace("123456",
                Decode.DecodeCode(ConfigurationManager.AppSettings["Linh"]));
            ConfigurationManager.RefreshSection("connectionStrings");

            //Application.Run(new LoanBookForm());
            Application.Run(new MainForm());
        }
    }
}