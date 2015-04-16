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
        private string folderPath = Environment.CurrentDirectory;
        private string fileName = "LibraryManagement";
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
            BackupDatabase();
        }

        public void BackupDatabase()
        {
            string databaseName = "[" + fileName + "]";


            string BackUpFileName = fileName + ".bak";
            string SQLBackUp = @"BACKUP DATABASE " + fileName + " TO DISK = N'" + folderPath + @"\" + BackUpFileName + @"'";

            SqlConnection cnBk = new SqlConnection(DataProvider.GetSqlConnectionString());
            SqlCommand cmdBkUp = new SqlCommand(SQLBackUp, cnBk);

            try
            {
                cnBk.Open();
                cmdBkUp.ExecuteNonQuery();

                string bakFile = folderPath + "\\" + BackUpFileName;
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
            saveFD.FileName = string.Format("{0}_{1}_{2}_{3}", fileName, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            saveFD.InitialDirectory = folderPath;
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                Txt_UserName.Text = saveFD.FileName;
            }
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {

            Txt_UserName.Text = folderPath + "\\" + string.Format("LibraryManagement_{0}_{1}_{2}.lib", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
    }
}