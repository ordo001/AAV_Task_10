using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using AAV_Task_10.Models;

namespace AAV_Task_10
{
    public partial class AdminForm : Form
    {
        public AAV_Task_10.Models.User? _currentUser;
        public AdminForm(Models.User? user)
        {
            _currentUser = user;
            InitializeComponent();
            EnabledButtonAdd();
            LoadCategoryInComboBox();
            UpdateData();
        }

        private async void LoadCategoryInComboBox()
        {
            using var context = new AuctionDbContext();
            var categoryList = await context.TypeItems.ToArrayAsync();
            comboBoxCategory.Items.Add("Всё категории");
            comboBoxCategory.Items.AddRange(categoryList);
            comboBoxCategory.SelectedIndex = 0;
        }

        public void EnabledButtonAdd()
        {
            if (_currentUser != null)
            {
                buttonAdd.Enabled = true;
            }
            else buttonAdd.Enabled = false;
        }

        public async void UpdateData()
        {
            using var context = new AuctionDbContext();
            var items = await context.Items
                .Include(g => g.TypeItem)
                .Include(u => u.OwnerItem)
                .Select(g => new
                {
                    Id = g.Id,
                    Name = g.Name,
                    EstimatedPrice = g.EstimatedPrice,
                    DateCreate = g.DateCreate,
                    Description = g.Description,
                    Category = g.TypeItem.Name,
                    Owner = g.OwnerItem.Name
                }).Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToListAsync();


            if (comboBoxCategory.SelectedIndex > 0)
            {
                items = items.Where(g => g.Category == comboBoxCategory.Text).ToList();
            }
            else
            {
                items = await context.Items
                .Include(g => g.TypeItem)
                .Include(u => u.OwnerItem)
                .Select(g => new
                {
                    Id = g.Id,
                    Name = g.Name,
                    EstimatedPrice = g.EstimatedPrice,
                    DateCreate = g.DateCreate,
                    Description = g.Description,
                    Category = g.TypeItem.Name,
                    Owner = g.OwnerItem.Name
                }).Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToListAsync();
            }

            if(comboBoxSort.SelectedIndex >= 0)
            {
                if(comboBoxSort.SelectedIndex == 0)
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
            dataGridView1.Columns[2].HeaderText = "Стоимость";
            dataGridView1.Columns[3].HeaderText = "Дата публикации";
            dataGridView1.Columns[4].HeaderText = "Описание";
            dataGridView1.Columns[5].HeaderText = "Категория";
            dataGridView1.Columns[6].HeaderText = "Владелец";
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void textBoxShip_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_currentUser is not null)
            {
                var addForm = new AddGoodForm(this);
                addForm.ShowDialog();
            }
        }
    }
}
