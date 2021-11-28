using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Uno.Extensions.Specialized;

namespace MD5Duplicate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//CLEAR FORM FUNCTION
        public void ClearBoxes()
        {
            sLabel.Text = "";
            zCount.Text = "";
            cCount.Text = "";
            rCount.Text = "";

            zipGrid.DataSource = null;
            SQLGrid.DataSource = null;
            resGrid.DataSource = null;

            mfgBox.Text = "";
            pBox.Text = "";
        }

//CHOOSE ZIP PATH
        private void button2_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox.Text = openFileDialog1.FileName;
            }
            sLabel.Text = "Zip Selected";

            ClearBoxes();
        }

//CHOOSE DIRECTORY PATH
        private void flder_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox.Text = folderBrowserDialog1.SelectedPath;
            }
            sLabel.Text = "Folder Selected";

            ClearBoxes();
        }

//STRING AND DATA TABLE INFO  
        public void button1_Click(object sender, EventArgs e)
        {        
            string path = @"" + pBox.Text;
            string workingPath = Path.GetDirectoryName(path) + "\\tmp";
            string newDirName = Path.GetDirectoryName(path) + "\\" + mfgBox.Text + "\\";
            string connString = Properties.Settings.Default.ConString;

            DataTable dt = new DataTable("List");
            DataTable dtRaw = new DataTable("List2");
            DataColumn Filen = new DataColumn("filename", typeof(String));
            DataColumn hValue = new DataColumn("file_checksum", typeof(String));
            dt.Columns.AddRange(new DataColumn[] { Filen, hValue });

//CREATE WORKING PATH
            if (!Directory.Exists(workingPath))
            {
                Directory.CreateDirectory(workingPath);
            }

//CHECK IF WORKING WITH ZIP OR DIRECTORY
            if (sLabel.Text == "Zip Selected")
            {
                ZipFile.ExtractToDirectory(path, workingPath);
            }

//CHECK IF MFG IS POPULATED
            if (mfgBox.Text == "")
            {
                MessageBox.Show("Please Input A Valid Vendor ID!");
            }

//GATHER FILE HASH INFO
            string[] files = Directory.GetFiles(workingPath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {

                using (MD5 MD5 = MD5.Create())
                {
                    using (FileStream fileStream = File.OpenRead(file))

                        dt.Rows.Add(
                            file.Replace(".jpeg", "")
                                .Replace(".bmp", "")
                                .Replace(".png", "")
                                .Replace(".webp", "")
                                .Replace(".tiff", "")
                                .Replace(".tif", "")
                                .Replace(".gif", "")
                                .Replace(".exe", "")
                                .Replace(" ", "")
                                .Replace(Path.GetDirectoryName(file) + "\\", "")
                            .Trim(), BitConverter.ToString(MD5.ComputeHash(fileStream)).Replace("-", "").ToUpperInvariant());
                }

            }

            zCount.Text = "File Count: " + dt.Rows.Count().ToString();

//GATHER STORED HASH INFO
            SqlConnection sqlConn = new SqlConnection(connString);
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT replace(filename,'.jpg','') as [filename], upper(file_checksum) as [file_checksum] FROM dbo.infohash", sqlConn);
            DataTable dt2 = new DataTable();
            sqlDA.Fill(dt2);
            sqlConn.Close();

            zipGrid.DataSource = dt;
            SQLGrid.DataSource = dt2;
            cCount.Text = "File Count: " + dt2.Rows.Count;

//GENERATE DIFFERENCE REPORT
            var differences = dt.AsEnumerable().Except(dt2.AsEnumerable(), DataRowComparer.Default);
            DataTable compare = differences.Any() ? differences.CopyToDataTable() : new DataTable();
            compare.Columns.Remove("file_checksum");
            List<string> fNames = compare.AsEnumerable().Select(x => x[0].ToString()).ToList();

//MOVE NET CHANGES TO NEW DIRECTORY
            Directory.CreateDirectory(newDirName);
            foreach (string fName in fNames)
            {
                string dFile = Path.Combine(newDirName, fName.ToString());
                string sFile = Path.Combine(workingPath, fName.ToString());

                File.Copy(sFile, dFile, true);
            }

//DELETE WORKING DIRECTORY
        }

    }

}
