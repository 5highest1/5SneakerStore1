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
    /// Логика взаимодействия для CartUser.xaml
    /// </summary>
    public partial class CartUser : Page
    {
        public CartUser()
        {
            InitializeComponent();
        }

        private void gobackbutton_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.framemain.GoBack();
        }

        private void cartUser_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void cartUser_ContextMenuClosing_1(object sender, ContextMenuEventArgs e)
        {

        }

        private void removecart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void orderbutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cart_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
    }
}
