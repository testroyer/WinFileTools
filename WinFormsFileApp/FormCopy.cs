using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFileApp
{
    public partial class FormCopy : Form
    {
        public string copyPath { get; set; }
        public string pastePath { get; set; }


        public FormCopy()
        {
            InitializeComponent();
            pastePath = "";
            copyPath = "";
        }

        private void FormCopy_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialogCopy = new FolderBrowserDialog())
            {
                if (folderBrowserDialogCopy.ShowDialog() == DialogResult.OK)
                {
                    copyPath = folderBrowserDialogCopy.SelectedPath;
                }
            }
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialogPaste = new FolderBrowserDialog())
            {
                if (folderBrowserDialogPaste.ShowDialog() == DialogResult.OK)
                {
                    pastePath = folderBrowserDialogPaste.SelectedPath;
                }
            }
        }

        // What if there are folders in a folder ???
        private async Task<int> CopyAsync(string copyPath, string pastePath)
        {
            int counter = 1;
            string[] filesInTheSelectedPath = Directory.GetFiles(copyPath);
            foreach (string file in filesInTheSelectedPath)
            {
                string filename = Path.GetFileName(file);
                using (FileStream sourceFile = new FileStream(file, FileMode.Open))
                {
                    if (!File.Exists(pastePath + $@"\{filename}"))
                    {
                        using (FileStream destinationFile = new FileStream(pastePath + $@"\{filename}", FileMode.CreateNew))
                        {
                            await sourceFile.CopyToAsync(destinationFile);
                            sourceFile.Close();
                        }
                    }
                    else if (File.Exists(pastePath + $@"\{filename}"))
                    {
                        while (File.Exists(pastePath + "/" + Path.GetFileNameWithoutExtension(file) + $" ({counter})" + Path.GetExtension(file)))
                        {
                            counter++;
                        }
                        string newPastePath = pastePath + "/" + Path.GetFileNameWithoutExtension(file) + $" ({counter})" + Path.GetExtension(file);
                        using (FileStream destinationFile = new FileStream(newPastePath, FileMode.CreateNew))
                        {
                            await sourceFile.CopyToAsync(destinationFile);
                            destinationFile.Close();
                        }
                    }
                }
            }

            return 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await CopyAsync(copyPath, pastePath);
                MessageBox.Show("File(s) copied succesfuly");
                
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
    }
}
