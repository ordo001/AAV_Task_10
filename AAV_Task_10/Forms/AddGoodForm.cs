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
using Microsoft.EntityFrameworkCore;

namespace AAV_Task_10
{
    public partial class AddGoodForm : Form
    {
        private AdminForm _adminForm;
        public AddGoodForm(AdminForm adminForm)
        {
            _adminForm = adminForm;
            InitializeComponent();
            LoadCategoryInComboBox();
        }

        private async void LoadCategoryInComboBox()
        {
            using var context = new AuctionDbContext();
            var categoryList = await context.TypeItems.ToArrayAsync();
            comboBox1.Items.AddRange(categoryList);
            comboBox1.SelectedIndex = 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using AuctionDbContext dbContext = new AuctionDbContext();
            var currentCategory = dbContext.TypeItems.FirstOrDefault(c => c.Name == comboBox1.Text);
            if (currentCategory == null)
                MessageBox.Show("sdfd");

            var newGood = new Item
            {
                Name = textBox1.Text,
                EstimatedPrice = Convert.ToDouble(numericUpDown1.Value),
                Description = textBox3.Text,
                TypeItemId = currentCategory.Id,
                DateCreate = DateTime.Now,
                OwnerItemId = _adminForm._currentUser.Id,
            };

            dbContext.Items.Add(newGood);
            dbContext.SaveChanges();
            _adminForm.UpdateData();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
