//DJ21
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Uno.Extensions.Specialized;

namespace MD5Duplicate
{
    public partial class formMain : Form
    {
        public formMain()
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
            status.Text = "";

            zipGrid.DataSource = null;
            SQLGrid.DataSource = null;
            resGrid.DataSource = null;

            mfgBox.Text = "";
            pBox.Text = "";
        }

//CHOOSE ZIP PATH
        private void file_Click(object sender, EventArgs e)
        {
            ClearBoxes();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox.Text = openFileDialog1.FileName;
            }
            sLabel.Text = "Zip Selected";           
        }

//CHOOSE DIRECTORY PATH
        private void flder_Click(object sender, EventArgs e)
        {
            ClearBoxes();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pBox.Text = folderBrowserDialog1.SelectedPath;
            }
            sLabel.Text = "Folder Selected";
        }

//STRING AND DATA TABLE INFO  
        public void go_Click(object sender, EventArgs e)
        {

            status.Text = "Working...";


            MessageBox.Show("Confirm Path: " + pBox.Text);
           
            try
            {

                string path = @"" + pBox.Text;

 //CHECK IF FILE UNZIPPED OR SELECTED PATH
                string workingPath;
                if (sLabel.Text == "Zip Selected")
                {
                    workingPath = Path.GetDirectoryName(path) + "\\tmp";
                }
                else
                {
                    workingPath = path;

                }

                string newDirName;
                if (sLabel.Text == "Zip Selected")
                {
                    newDirName = Path.GetDirectoryName(path) + "\\" + mfgBox.Text + "\\";
                }
                else
                {
                    newDirName = path + "\\" + mfgBox.Text + "\\";
                }

                string connString = Properties.Settings.Default.ConString;

                DataTable dt = new DataTable("List");
                DataTable dtRaw = new DataTable("List2");
                DataColumn Filen = new DataColumn("filename", typeof(String));
                DataColumn hValue = new DataColumn("file_checksum", typeof(String));
                dt.Columns.AddRange(new DataColumn[] { Filen, hValue });

//CREATE WORKING PATH IF ZIP SELECTED
                if (sLabel.Text == "Zip Selected")
                {

                    if (!Directory.Exists(workingPath))
                    {
                        Directory.CreateDirectory(workingPath);
                    }

                }

//CHECK IF WORKING WITH ZIP OR DIRECTORY FOR UNZIP FUNCTION
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
                                file.Replace(".jpeg", ".jpg")
                                    .Replace(".bmp", ".jpg")
                                    .Replace(".png", ".jpg")
                                    .Replace(".webp", ".jpg")
                                    .Replace(".tiff", ".jpg")
                                    .Replace(".tif", ".jpg")
                                    .Replace(".gif", ".jpg")
                                    .Replace(" ", "")
                                    .Replace(Path.GetDirectoryName(file) + "\\", "")
                                .Trim(), BitConverter.ToString(MD5.ComputeHash(fileStream)).Replace("-", "").ToUpperInvariant());
                    }

                }

                zCount.Text = "File Count: " + dt.Rows.Count().ToString();

                zipGrid.DataSource = dt;

                MessageBox.Show("Sucessfully gathered file info for "+dt.Rows.Count().ToString()+" Images in "+workingPath);


//GATHER STORED HASH INFO
                SqlConnection sqlConn = new SqlConnection(connString);
                SqlDataAdapter sqlDA = new SqlDataAdapter(Properties.Settings.Default.SQL, sqlConn); //NEED TO ADD WHERE CLAUSE IN SQL SETTING FOR MFG CODE TO FILTER
                DataTable dt2 = new DataTable();
                sqlDA.Fill(dt2);
                sqlConn.Close();

                
                SQLGrid.DataSource = dt2;
                cCount.Text = "File Count: " + dt2.Rows.Count;

                MessageBox.Show("SQL - Sucessfully imported " + dt2.Rows.Count().ToString()+" Checksums for '"+mfgBox.Text+"' "+" Images.");

//GENERATE DIFFERENCE REPORT
                var differences = dt.AsEnumerable().Except(dt2.AsEnumerable(), DataRowComparer.Default);
                DataTable compare = differences.Any() ? differences.CopyToDataTable() : new DataTable();
                compare.Columns.Remove("file_checksum");

                resGrid.DataSource = compare;
                rCount.Text = "File Count: " + compare.Rows.Count;

//MOVE NET CHANGES TO NEW DIRECTORY
                Directory.CreateDirectory(newDirName);

                foreach (DataRow fName in compare.Rows)
                {
                    string dFile = Path.Combine(newDirName, fName.ToString());
                    string sFile = Path.Combine(workingPath, fName.ToString());

                    if (File.Exists(sFile + ".jpg"))
                    {
                        File.Copy(sFile + ".jpg", dFile + ".jpg", true);
                    }
                    if (File.Exists(sFile + ".bmp"))
                    {
                        File.Copy(sFile + ".bmp", dFile + ".bmp", true);
                    }
                    if (File.Exists(sFile + ".jpeg"))
                    {
                        File.Copy(sFile + ".jpeg", dFile + ".jpeg", true);
                    }
                    if (File.Exists(sFile + ".tiff"))
                    {
                        File.Copy(sFile + ".tiff", dFile + ".tiff", true);
                    }
                    if (File.Exists(sFile + ".tif"))
                    {
                        File.Copy(sFile + ".svg", dFile + ".svg", true);
                    }
                    if (File.Exists(sFile + ".gif"))
                    {
                        File.Copy(sFile + ".gif", dFile + ".gif", true);
                    }
                    if (File.Exists(sFile + ".png"))
                    {
                        File.Copy(sFile + ".png", dFile + ".png", true);
                    }
                    if (File.Exists(sFile + ".webp"))
                    {
                        File.Copy(sFile + ".webp", dFile + ".webp", true);
                    }
                    
                }
//CONFIRM IMAGES POPULATED NEW DIRECTORY
                string[] moveConfirm = Directory.GetFiles(newDirName, "*.*", SearchOption.AllDirectories);

                int a = moveConfirm.Count();
                int b = compare.Rows.Count();

                if (a == b)
                {
                    MessageBox.Show("Files have been processed successfully!");            
                }
                else
                {
                    MessageBox.Show("File Count mismatch in '"+newDirName+"'." +
                        " Please confirm there are supposed to be files in this directory." +
                        " If so, Please extract the ZIP file manually and confirm the images are not within a sud-directory." +
                        " Then use the 'FOLDER' button to choose your extracted images folder.","Opps...");
                }

//DELETE WORKING DIRECTORY AND OPEN NEW DIRECTORY
                if (sLabel.Text == "Zip Selected")
                {
                    Directory.Delete(workingPath, true);
                }

                status.Text = "Complete!";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Uh Oh...");

                ClearBoxes();
            }

        }

    }

}
