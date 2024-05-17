using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Xaml;

namespace BuildingMaterialsStore
{
    /// <summary>
    /// Логика взаимодействия для DataOutput.xaml
    /// </summary>
    public partial class DataOutput : Page
    {
        public DataOutput()
        {
            InitializeComponent();
            List<Products_Table> Prodects_Table = AppConnect.modeldb.Products_Table.ToList();

            if (Prodects_Table.Count > 0)
            {
                tbCounter.Text = "Найдено" + Prodects_Table.Count + "товаров";
            }
            else
            {
                tbCounter.Text = "Не найдено";
            }
            ListGoods.ItemsSource = Prodects_Table;
            ComboFilter.ItemsSource = Entities.GetContext().Categories_Table.Select(c => c.Name).ToList();
            ComboSort.Items.Add("По возрастанию цены"); ComboSort.Items.Add("По убыванию цены");
        }

        Products_Table[] FindProduct()
        {
            var product = AppConnect.modeldb.Products_Table.ToList();
            var productall = product;
            if (TextSearch != null)
            {
                product = product.Where(x => x.Name.ToLower().Contains(TextSearch.Text.ToLower())).ToList();

               if (ComboFilter.SelectedIndex >= 0)
                {
                    switch (ComboFilter.SelectedIndex)
                    {
                        case 0:
                            product = product.Where(x => x.CategoryID == 1).ToList();
                            break;
                        case 1:
                            product = product.Where(x => x.CategoryID == 2).ToList();
                            break;
                        case 2:
                            product = product.Where(x => x.CategoryID == 3).ToList();
                            break;
                        case 3:
                            product = product.Where(x => x.CategoryID == 4).ToList();
                            break;
                        case 4:
                            product = product.Where(x => x.CategoryID == 6).ToList();
                            break;
                    }
                }
               if (ComboSort.SelectedIndex >= 0) 
                    switch(ComboSort.SelectedIndex)
                    {
                        case 0:
                            product = product.OrderBy(x => x.Price).ToList();
                            break;
                        case 1:
                            product = product.OrderByDescending(x => x.Price).ToList();
                            break;
                     

                    }
            }
            ListGoods.ItemsSource = product;
            return product.ToArray();
        }

        private void addBasket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FindProduct();
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FindProduct();
        }

        private void TextSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListGoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //тест строка
        }
    }
}
