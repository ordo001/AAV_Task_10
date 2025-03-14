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
                �������ToolStripMenuItem.Visible = true;
            }else �������ToolStripMenuItem.Visible= false;
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new AdminForm(currentUser);
            mainForm.ShowDialog();
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fomrLog = new Form1(this);
            fomrLog.ShowDialog();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellsForm sellsForm = new SellsForm();
            sellsForm.ShowDialog();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ��� �����: Auction228@mail.ru\n�������: 88005553535\n���������:����������� �.�.",
                "��������",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}