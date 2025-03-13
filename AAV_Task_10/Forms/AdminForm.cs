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
        public AdminForm(AAV_Task_10.Models.User? user)
        {
            _currentUser = user;
            InitializeComponent();
            if(user != null)
            {
                buttonAdd.Enabled = true;
            }
            //toolStripStatusLabel1.Text += _currentUser.Name;
            //toolStripStatusLabel2.Text += _currentUser.Role;
            LoadCategoryInComboBox();
            UpdateData();
            //LoadAndInitData();
        }

        private async void LoadCategoryInComboBox()
        {
            using var context = new AuctionDbContext();
            var categoryList = await context.TypeItems.ToArrayAsync();
            comboBoxCategory.Items.Add("Всё категории");
            comboBoxCategory.Items.AddRange(categoryList);
            comboBoxCategory.SelectedIndex = 0;
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
                    Owner = g.OwnerItem
                }).Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToListAsync();

            //goods = goods.Where(g => g.Name.ToLower().Contains(textBoxShip.Text.ToLower())).ToList();

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
                    Owner = g.OwnerItem
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

       

        private static System.Drawing.Image? ConvertByteArrayToImage(byte[]? byteArray)
        {
            if (byteArray == null)
            {
                //throw new ArgumentException("Массив байтов пуст или null.");
                return null;
            }

            try
            {
                using var ms = new MemoryStream(byteArray);
                return System.Drawing.Image.FromStream(ms);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Ошибка: массив байтов не содержит корректное изображение." + ex.ToString());
                return null;
            }
        }

        private void UpdateColumns()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название товара";
            dataGridView1.Columns[2].HeaderText = "Стоимость";
            //dataGridView1.Columns[2].HeaderText = "Изображение";
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //panel1.Visible = true;
            //using ShopDbContext dbContext = new ShopDbContext();

            //int selectedIndex = dataGridView1.Rows[e.RowIndex].Index;

            //var selectedGood = dbContext.Goods.FirstOrDefault(g => g.Id == (int)dataGridView1.Rows[selectedIndex].Cells[0].Value);

            //if(selectedGood != null)
            //{
            //    labelName.Text = selectedGood.GoodName;
            //    labelPrice.Text = selectedGood.Price.ToString();
            //    textBoxDesc.Text = selectedGood.Description;
            //    pictureBox1.Image = ConvertByteArrayToImage(selectedGood.Picture);

            //}
        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form1 form1 = new Form1();
        //    this.Hide();
        //    form1.Show();
        //}

        //private void buttonSearch_Click_1(object sender, EventArgs e)
        //{
        //    UpdateData();
        //}


    }
}
