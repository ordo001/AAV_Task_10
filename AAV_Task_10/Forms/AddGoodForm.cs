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

        private void button3_Click(object sender, EventArgs e)
        {
            var imageData = SelectImage();
            if (imageData != null)
            {
                pictureBox1.Image = ConvertByteArrayToImage(imageData);
            }
        }

        private byte[]? SelectImage()
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Выберите изображение"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return File.ReadAllBytes(openFileDialog.FileName);
            }
            return null;
        }

        public byte[] ImageToByteArray(System.Drawing.Image image)
        {
            try
            {
                if (image == null)
                    return null;

                using (var ms = new MemoryStream())
                {
                    using (var bitmap = new Bitmap(image))
                    {
                        bitmap.Save(ms, image.RawFormat);
                    }
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return null;
            }
        }

        //private void SaveImageToDatabase(ShopDbContext db, Good good)
        //{
        //    var image = pictureBox1.Image;
        //    good.Picture = ImageToByteArray(image);

        //}


        private System.Drawing.Image? ConvertByteArrayToImage(byte[]? byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                throw new ArgumentException("Массив байтов пуст или null.");
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
    }
}
