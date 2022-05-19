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
    public partial class FormDelete : Form
    {

        string deletePath;
        public FormDelete()
        {
            deletePath = "";
            InitializeComponent();
        }

        private void buttonTarget_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    deletePath = dialog.SelectedPath;
                }
            }
        }

        private Task<int> RapidDelete(string deletePath)
        {
            string[] files = Directory.GetFiles(deletePath);
            foreach (string file in files)
            {
                string filename = Path.GetFileName(file);
                File.Delete(file);
            }



            return Task.FromResult(0);
        }


        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await RapidDelete(deletePath);
                MessageBox.Show("Files deleted succesfully");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
