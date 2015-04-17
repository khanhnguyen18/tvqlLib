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
        private string folderPath;
        private string fileNameWithoutExt;
        private readonly string dbName = "LibraryManagement";

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
            string backUpFileName = this.fileNameWithoutExt + ".bak";
            string fullBackupPath = this.folderPath + backUpFileName;

            string SQLBackUp =string.Format(@"BACKUP DATABASE {0} TO DISK = N'{1}'", dbName, fullBackupPath);

            SqlConnection cn = new SqlConnection(DataProvider.GetSqlConnectionString());
            SqlCommand cmdBkUp = new SqlCommand(SQLBackUp, cn);

            try
            {
                cn.Open();
                cmdBkUp.ExecuteNonQuery();

                FileStream fs = File.OpenRead(fullBackupPath);
                byte[] buffer = new byte[fs.Length];

                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                //Encrypt
                byte[] buffer1 = SuperKnuth.KnuthTools.Hash(buffer);

                //Save file
                File.WriteAllBytes(fullBackupPath.Replace(".bak", ".Klib"), buffer1);

                File.Delete(fullBackupPath);

                MessageBox.Show("Done");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Klib files (*.Klib)|*.Klib";
            saveFD.FileName = string.Format("{0}_{1}_{2}_{3}", fileNameWithoutExt, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            saveFD.InitialDirectory = folderPath;
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = saveFD.FileName;
                this.folderPath = Path.GetDirectoryName(saveFD.FileName);
                this.fileNameWithoutExt = Path.GetFileNameWithoutExtension(saveFD.FileName);

            }
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            fileNameWithoutExt = string.Format("LibraryManagement_{0}_{1}_{2}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            folderPath = Environment.CurrentDirectory;

            txtBackupPath.Text = folderPath + "\\" + fileNameWithoutExt+ ".Klib";
        }
    }
}