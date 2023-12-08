using App1.Class;
using App1.pages;
using App1.users;
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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
            if (Properties.Settings.Default.EventSaveLogin != string.Empty)
            {
                TxbLogin.Text = Properties.Settings.Default.EventSaveLogin;
            }
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = odbConnectHelper.entObj.Users.FirstOrDefault(
                   x => x.login == TxbLogin.Text && x.password == PsbPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нету!", "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                    FrameApp.frnObj.Navigate(new PageRegistration());
                }
                else
                {
                    UserControlHelp.id = userObj.id;
                    
                    switch (userObj.role)
                    {
                        case 1:
                            UserPage userPage = new UserPage();
                            userPage.Show();
                            break; 
                        case 2:
                            FrameApp.frnObj.Navigate(new AllRequest());
                            break;
                        case 3:
                            UserControlHelp.login = TxbLogin.Text;
                            FrameApp.frnObj.Navigate(new AllRequest());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", "Уведомление" + ex.Message.ToString(),
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageRegistration());
        }
    }
}
