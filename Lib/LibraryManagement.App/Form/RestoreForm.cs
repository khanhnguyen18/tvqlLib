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
    public partial class RestoreForm : DevExpress.XtraEditors.XtraForm
    {
        private string folderPath;
        private string fileNameWithoutExt;

        public RestoreForm()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            //Check pw
            if (txtPass.Text != "88")
            {
                MessageBox.Show("Pass sai");
                return;
            }

            string backUpFileName = this.fileNameWithoutExt + ".bak";
            string fullBackupPath = this.folderPath + backUpFileName;
            string targetFile = folderPath + fileNameWithoutExt + ".Klib";

            //Open Klib file----------------------------------------------
            FileStream fs = File.OpenRead(targetFile);
            byte[] buffer = new byte[fs.Length];

            fs.Read(buffer, 0, buffer.Length);
            fs.Close();

            //Decrypt-------------------------------------------------------------------------------------                
            byte[] buffer1 = SuperKnuth.KnuthTools.DeHash(buffer);

            //Save file----------------------------------------------------------------
            File.WriteAllBytes(fullBackupPath, buffer1);

            string sqlBackUp = string.Format(@"RESTORE DATABASE {0} FROM DISK = N'{1}' WITH FILE=1, 
                           MOVE 'library_data_Data' TO '{2}\{0}.mdf',
		MOVE 'library_data_Log' TO '{2}\{0}.ldf',
		NOUNLOAD, STATS = 5;", txtDB.Text, fullBackupPath, folderPath);

            SqlConnection cn = new SqlConnection(DataProvider.GetSqlConnectionString());
            SqlCommand cmdBkUp = new SqlCommand(sqlBackUp, cn);
            try
            {

                cn.Open();
                cmdBkUp.ExecuteNonQuery();

                MessageBox.Show("Done");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                File.Delete(fullBackupPath);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Klib files (*.Klib)|*.Klib";
            ofd.InitialDirectory = folderPath;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = ofd.FileName;
                this.folderPath = Path.GetDirectoryName(ofd.FileName);
                this.fileNameWithoutExt = Path.GetFileNameWithoutExtension(ofd.FileName);
            }
        }

        private void BackupForm_Load(object sender, EventArgs e)
        {
            fileNameWithoutExt = string.Empty;
            folderPath = Environment.CurrentDirectory;

#if DEBUG
            txtPass.Text = "88";
            txtDB.Text = "Lib1";
            txtBackupPath.Text = "D:\\LibraryManagement_2015_4_16_2015_4_16.Klib";
            folderPath = "D:\\";
            fileNameWithoutExt = "LibraryManagement_2015_4_16_2015_4_16";
#endif
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Check pw
            if (txtPass.Text != "88")
            {
                MessageBox.Show("Pass sai");
                return;
            }

            string sqlBackUp = string.Format(@"DROP DATABASE {0}", txtDB.Text);


            using (SqlConnection cn = new SqlConnection(DataProvider.GetSqlConnectionString()))
            {
                SqlCommand cmdBkUp = new SqlCommand(sqlBackUp, cn);
                try
                {
                    cn.Open();
                    cmdBkUp.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công");
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại\r\n" + ex.Message);
                }
            }
        }
    }
}