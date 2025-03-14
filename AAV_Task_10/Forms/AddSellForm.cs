using AAV_Task_10.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AAV_Task_10.Forms
{
    public partial class AddSellForm : Form
    {
        private SellsForm _sellsForm;
        public AddSellForm(SellsForm sellsForm)
        {
            _sellsForm = sellsForm;
            InitializeComponent();
            LoadCategoryInComboBox();
            LoadUsersInComboBox();
        }

        private async void LoadCategoryInComboBox()
        {
            using var context = new AuctionDbContext();
            var categoryList = await context.Items.ToArrayAsync();
            comboBoxItem.Items.AddRange(categoryList);
            comboBoxItem.SelectedIndex = 0;

        }

        private async void LoadUsersInComboBox()
        {
            using var context = new AuctionDbContext();
            var usersList = await context.Users.ToArrayAsync();
            comboBoxBuyer.Items.AddRange(usersList);
            comboBoxBuyer.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using AuctionDbContext dbContext = new AuctionDbContext();
            var currentItem = dbContext.Items.FirstOrDefault(c => c.Name == comboBoxItem.Text);
            var currentBuyer = dbContext.Users.FirstOrDefault(c => c.Name == comboBoxBuyer.Text);
            if (currentItem == null)
                MessageBox.Show("Неверная категория");

            var newSale = new Sale
            {
                ItemId = currentItem.Id,
                StartPrice = Convert.ToDouble(numericUpDownStartPrice.Value),
                EndPrice = Convert.ToDouble(numericUpDownEndPrice.Value),
                StartSale = DateTime.Now,
                BuyerId = currentBuyer.Id,
            };

            dbContext.Sales.Add(newSale);
            dbContext.SaveChanges();
            _sellsForm.UpdateData();
            this.Hide();
        }

        private void numericUpDownStartPrice_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownEndPrice.Minimum = numericUpDownStartPrice.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
