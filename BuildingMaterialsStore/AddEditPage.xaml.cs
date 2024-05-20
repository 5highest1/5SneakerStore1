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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Products_Table _currentMaterials = new Products_Table ();
        public AddEditPage()
        {
            InitializeComponent();
            DataContext = _currentMaterials;
            ComboProduct.ItemsSource = Entities.GetContext().Products_Table.ToList ();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder ();
            if (string.IsNullOrWhiteSpace(_currentMaterials.Name))
                errors.AppendLine("Укажите название материала");
            if (string.IsNullOrWhiteSpace(_currentMaterials.Description))
                errors.AppendLine("Укажите описание товара");
            if (_currentMaterials.CategoryID == null)
                errors.AppendLine("Выберете категорию");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
        }
    }
}
