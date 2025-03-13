namespace AAV_Task_10
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ñïèñîêÒîâàğîâToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new AdminForm(null);
            mainForm.ShowDialog();
        }
    }
}