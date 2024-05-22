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
        public AddEditPage()
        {
            InitializeComponent();
            ComboProduct.ItemsSource = Entities2.GetContext().Categories_Table.Select(x => x.Name).ToList();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Products_Table goodsobj = new Products_Table()
                {
                    Name = Nametb.Text,
                    Description = Descriptiontb.Text,
                    Price = pricetb.Text,
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

       
    }
}

