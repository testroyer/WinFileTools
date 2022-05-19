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
    public partial class FormMove : Form
    {
        string rootPath { get; set; }
        string destinationPath { get; set; }

        public FormMove()
        {
            rootPath = "";
            destinationPath = "";
            InitializeComponent();
        }

        private void FormMove_Load(object sender, EventArgs e)
        {

        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialogRoot = new FolderBrowserDialog())
            {
                if (dialogRoot.ShowDialog() == DialogResult.OK)
                {
                    rootPath = dialogRoot.SelectedPath;
                }
            }
        }

        private void buttonTarget_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialogDestination = new FolderBrowserDialog())
            {
                if (dialogDestination.ShowDialog() == DialogResult.OK)
                {
                    destinationPath = dialogDestination.SelectedPath;
                }
                
            }
        }


        private async Task<int> RapidMoveAsync(string rootPath, string destinationPath)
        {
            string[] files = Directory.GetFiles(rootPath);
            string[] filesInDestination = Directory.GetFiles(destinationPath);
            
            foreach (string file in files)
            {
                int counter = 1;
                string filename = Path.GetFileName(file);
                using (FileStream root = new FileStream(file , FileMode.Open))
                {
                    if (!File.Exists(destinationPath + $"/{filename}"))
                    {
                        using (FileStream destination = new FileStream(destinationPath + $"/{filename}", FileMode.CreateNew))
                        {
                            await root.CopyToAsync(destination);
                            root.Close();
                            File.Delete(file);
                        }
                    }
                    else if (File.Exists(destinationPath + $"/{filename}")){

                        while (File.Exists(destinationPath + "/" + Path.GetFileNameWithoutExtension(file) + $" ({counter})" + Path.GetExtension(file))){
                            counter++;
                        }
                        string newDesitnation = destinationPath + "" + Path.GetFileNameWithoutExtension(file) + $" ({counter})" + Path.GetExtension(file);
                        using (FileStream destination = new FileStream(newDesitnation, FileMode.CreateNew))
                        {
                            await root.CopyToAsync(destination);
                            root.Close();
                            File.Delete(file);
                        }
                    }
                }
            }

            return 0;

        }



        private async void buttonMove_Click(object sender, EventArgs e)
        {
            try
            {
                await RapidMoveAsync(rootPath, destinationPath);
                MessageBox.Show("Files moved succesfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
