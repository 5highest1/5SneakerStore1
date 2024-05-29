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

namespace BuildingMaterialsStore.LogReg
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void btnRegIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AppConnect.modeldb.Users_Table.Any(x => x.Email == txbEmail.Text))
                {
                    MessageBox.Show("Пользователь с таким логином есть!",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    Users_Table userOdj = new Users_Table()
                    {
                        Email = txbEmail.Text,
                        FirstName = txbName.Text,
                        PasswordHash = txbPass.Text,
                        IDRole = 2
                    };
                    AppConnect.modeldb.Users_Table.Add(userOdj);
                    AppConnect.modeldb.SaveChanges();
                    MessageBox.Show("Пользователь Успешно добавлен!",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    AppFrame.framemain.Navigate(new Login());
                }
            }
           catch {
                MessageBox.Show("Ошибка при добавление данных",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
        }
        

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.framemain.GoBack();
        }

        private void txbPass_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbPass.Text != psbPass.Password)
            {
                btnRegIn.IsEnabled = false;
                psbPass.Background = Brushes.LightCoral;
                psbPass.BorderBrush = Brushes.Red;
            }
            else
            {
                btnRegIn.IsEnabled = true;
                psbPass.Background = Brushes.LightGreen;
                psbPass.BorderBrush = Brushes.Green;
            }
        }

        private void psbPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txbPass.Text != psbPass.Password)
            {
                btnRegIn.IsEnabled = false;
                psbPass.Background = Brushes.LightCoral;
                psbPass.BorderBrush = Brushes.Red;
            }
            else
            {
                btnRegIn.IsEnabled = true;
                psbPass.Background = Brushes.LightGreen;
                psbPass.BorderBrush = Brushes.Green;
            }
        }
    }
}
