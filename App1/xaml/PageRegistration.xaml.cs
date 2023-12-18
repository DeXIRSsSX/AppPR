using App1.Class;
using App1.DataBase;
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

namespace App1.xaml
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (odbConnectHelper.entObj.Users.Count(x => x.Login == Txblogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            else
            {
                try

                {
                    User UsersObj = new User()
                    {
                        Login = Txblogin.Text,
                        Password = PsbPassword.Password,
                        Idrole = 1
                    };

                    odbConnectHelper.entObj.Users.Add(UsersObj);
                    odbConnectHelper.entObj.SaveChanges();
                    MessageBox.Show("Студент добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка:" + ex.Message.ToString(), "Крит урон по работе", MessageBoxButton.OK, MessageBoxImage.Warning);
                }


            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new xaml.AllRequest());
        }
    }
}
