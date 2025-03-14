using AAV_Task_10.Models;
using AAV_Task_10.Forms;

namespace AAV_Task_10
{
    public partial class Main : Form
    {
        public User currentUser;
        public Main()
        {
            currentUser = null;
            InitializeComponent();
            EnabledButtonSells();
        }

        public void EnabledButtonSells()
        {
            if(currentUser != null) 
            {
                продажиToolStripMenuItem.Visible = true;
            }else продажиToolStripMenuItem.Visible= false;
        }

        private void списокТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new AdminForm(currentUser);
            mainForm.ShowDialog();
        }

        private void авторизоватьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fomrLog = new Form1(this);
            fomrLog.ShowDialog();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellsForm sellsForm = new SellsForm();
            sellsForm.ShowDialog();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Почта для связи: Auction228@mail.ru\nТелефон: 88005553535\nСоздатель:Александров А.В.",
                "Контакты",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}