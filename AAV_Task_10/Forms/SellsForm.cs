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

namespace AAV_Task_10.Forms
{
    public partial class SellsForm : Form
    {
        public SellsForm()
        {
            InitializeComponent();
            UpdateData();
        }

        public async void UpdateData()
        {
            using var context = new AuctionDbContext();
            var items = await context.Sales
                .Include(g => g.Item)
                .Include(u => u.Buyer)
                .Select(g => new
                {
                    Id = g.Id,
                    Name = g.Item.Name,
                    EstimatedPrice = g.StartSale,
                    DateCreate = g.StartPrice,
                    Description = g.EndPrice,
                    Category = g.Buyer.Name
                }).Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToListAsync();

            items = await context.Sales
            .Include(g => g.Item)
            .Include(u => u.Buyer)
            .Select(g => new
            {
                Id = g.Id,
                Name = g.Item.Name,
                EstimatedPrice = g.StartSale,
                DateCreate = g.StartPrice,
                Description = g.EndPrice,
                Category = g.Buyer.Name
            }).Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToListAsync();

            if (comboBoxSort.SelectedIndex >= 0)
            {
                if (comboBoxSort.SelectedIndex == 0)
                    items = items.OrderBy(g => g.EstimatedPrice).ToList();
                if (comboBoxSort.SelectedIndex == 1)
                    items = items.OrderByDescending(g => g.EstimatedPrice).ToList();
            }

            dataGridView1.DataSource = items;
            UpdateColumns();
        }

        private void UpdateColumns()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название товара";
            dataGridView1.Columns[2].HeaderText = "Дата продажи";
            dataGridView1.Columns[3].HeaderText = "Начальная цена";
            dataGridView1.Columns[4].HeaderText = "Конечная цена";
            dataGridView1.Columns[5].HeaderText = "Покупатель";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddSellForm addSellForm = new AddSellForm(this);
            addSellForm.ShowDialog();
        }

        private void textBoxShip_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
