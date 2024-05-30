using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuildingMaterialsStore
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Products_Table _productsTable = new Products_Table();
        public AddEditPage(Products_Table productsTable)
        {
            InitializeComponent();
            ComboProduct.ItemsSource = Entities2.GetContext().Categories_Table.ToList();
         if (productsTable != null )
            {
                _productsTable = productsTable;
            }
            DataContext = productsTable;
        }

        private void EditGoods()
        {
            if(_productsTable.ProductID > 0){
                try
                {
                    _productsTable.Name = Nametb.Text;
                    _productsTable.Description = Descriptiontb.Text;
                    _productsTable.Price = Convert.ToInt32(pricetb.Text);
                    _productsTable.CategoryID = Convert.ToInt32(ComboProduct.SelectedIndex + 1);
                    _productsTable.ImageURL = "16.jpg";
                    AppConnect.modeldb.SaveChanges();
                    MessageBox.Show("Товар успешно изменен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    AppFrame.framemain.Navigate(new DataOutput());
                }
                catch
                {
                    MessageBox.Show("Ошибка при добавлении данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
        }

        private void AddGoods()
        {
            try
            {
                Products_Table goodsobj = new Products_Table()
                {
                    Name = Nametb.Text,
                    Description = Descriptiontb.Text,
                    Price = Convert.ToInt32(pricetb.Text),
                    CategoryID = Convert.ToInt32(ComboProduct.SelectedIndex + 1),
                    ImageURL = "16.jpg",
                };
                AppConnect.modeldb.Products_Table.Add(goodsobj);
                AppConnect.modeldb.SaveChanges();
                MessageBox.Show("Товар успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                AppFrame.framemain.Navigate(new DataOutput());
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if(_productsTable.ProductID == 0)
            {
                AddGoods();
            }
            else
            {
                EditGoods();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.framemain.GoBack();
        }
    }
}

