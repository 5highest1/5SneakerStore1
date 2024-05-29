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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txbEmail.Text) || String.IsNullOrWhiteSpace(txbEmail.Text))  {
                    MessageBox.Show("Введите логин", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            else {
                    var userObj = AppConnect.modeldb.Users_Table.FirstOrDefault(x => x.Email == txbEmail.Text && x.PasswordHash == psbPassword.Password);
                    if (userObj == null)
                    {
                        MessageBox.Show("Такого пользователя нет", "Ошибка",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        switch (userObj.IDRole)
                        {
                            case 1:
                                MessageBox.Show("Здравсвуйте, Администратор " + userObj.FirstName + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                AppFrame.framemain.Navigate(new DataOutput());
                                break;
                            case 2:
                                MessageBox.Show("Здравсвуйте, Покупатель " + userObj.FirstName + "!",
                                "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                AppFrame.framemain.Navigate(new UsersProducts());
                                break;
                            default:
                                MessageBox.Show("Данные не обноружены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                                break;
                        }
                         
                        
                    }
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая работа приложения",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);

                    
            }
        }
        private void Log_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.framemain.Navigate(new Reg());
        }
    }
}
