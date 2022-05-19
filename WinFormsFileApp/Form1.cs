namespace WinFormsFileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonRapidCopy_Click(object sender, EventArgs e)
        {
           using FormCopy formCopy = new FormCopy();
            {
                formCopy.ShowDialog();
                this.Close();
            }
        }

        private void buttonRapidMove_Click(object sender, EventArgs e)
        {
            using(FormMove formMove = new FormMove())
            {
                formMove.ShowDialog();
                this.Close();
            }
            
        }

        private void buttonRapidDelete_Click(object sender, EventArgs e)
        {
            using FormDelete formDelete = new FormDelete();
            {
                formDelete.ShowDialog();
                this.Close();
            }
        }
    }
}