using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;

namespace LibraryManagement.App
{
    public partial class BackupForm : DevExpress.XtraEditors.XtraForm
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupDatabase("D:\\", "Lib.bak", "LibraryManagement");
        }

        public void BackupDatabase(string location, string BackUpFileName, string DatabaseName)
        {

            DatabaseName = "[" + DatabaseName + "]";

            string fileName = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString();

            BackUpFileName = BackUpFileName + fileName + ".bak";
            string SQLBackUp = @"BACKUP DATABASE " + DatabaseName + " TO DISK = N'" + location + @"\" + BackUpFileName + @"'";

            string svr = @"Data Source=.\sqlexpress;Initial Catalog=LibraryManagement;;User ID=sa;Password=ndkhanh";

            SqlConnection cnBk = new SqlConnection(svr);
            SqlCommand cmdBkUp = new SqlCommand(SQLBackUp, cnBk);

            try
            {
                cnBk.Open();
                cmdBkUp.ExecuteNonQuery();

                string bakFile = location + "\\" + BackUpFileName;
                FileStream fs = File.OpenRead(bakFile);
                byte[] buffer = new byte[fs.Length - 1];


                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                //Encrypt
                byte[] buffer1 = SuperKnuth.KnuthTools.Hash(buffer);

                //Save file
                File.WriteAllBytes(bakFile.Replace(".bak", ".lib"), buffer1);

                File.Delete(bakFile);

                MessageBox.Show("Done");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (cnBk.State == ConnectionState.Open)
                {

                    cnBk.Close();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Zip files (*.lib)|*.lib";
            saveFD.FileName = string.Format("LibraryManagement_{0}_{1}_{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                Txt_UserName.Text = saveFD.FileName;
            }
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {

            Txt_UserName.Text = Environment.CurrentDirectory + "\\" + string.Format("LibraryManagement_{0}_{1}_{2}.lib", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
    }
}