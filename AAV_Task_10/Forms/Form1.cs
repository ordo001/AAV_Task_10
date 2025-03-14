using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAV_Task_10.Models;

namespace AAV_Task_10
{
    public partial class Form1 : Form
    {
        private Main _mainForm;
        public Form1(Main mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new AuctionDbContext())
                {
                    var users = db.Users.AsNoTracking().ToList();
                    User? user = users.FirstOrDefault(p => p.Login == textBox1.Text && p.Password == textBox2.Text);
                    if (user != null)
                    {
                        _mainForm.currentUser = user;
                        _mainForm.EnabledButtonSells();
                        this.Hide();

                    }
                    else
                        MessageBox.Show("Неверный логин или пароль.Попробуйте ещё раз", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Не подключена БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
