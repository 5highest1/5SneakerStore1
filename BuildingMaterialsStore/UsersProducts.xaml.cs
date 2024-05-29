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

namespace BuildingMaterialsStore
{
    /// <summary>
    /// Логика взаимодействия для UsersProducts.xaml
    /// </summary>
    public partial class UsersProducts : Page
    {
        public UsersProducts()
        {
            InitializeComponent();
            List<Products_Table> Products_Table = AppConnect.modeldb.Products_Table.ToList();

            if (Products_Table.Count > 0)
            {
                tbCounter.Text = "Найдено" + Products_Table.Count + "товаров";
            }
            else
            {
                tbCounter.Text = "Не найдено";
            }
            ListGoods.ItemsSource = Products_Table;
            ComboFilter.ItemsSource = Entities1.GetContext().Categories_Table.Select(c => c.Name).ToList();
            ComboSort.Items.Add("По возрастанию цены"); ComboSort.Items.Add("По убыванию цены");
        }


        private void ListGoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

      
    }
}
