using App1.Admin;
using App1.Class;
using App1.Employees;
using App1.pages;
using App1.users;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace App1.xaml
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class AllRequest : Page
    {
        public AllRequest()
        {
            InitializeComponent();
            if (Properties.Settings.Default.EventSaveLogin != string.Empty)
            {
                TxbLogin.Text = Properties.Settings.Default.EventSaveLogin;
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageRegistration());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = odbConnectHelper.entObj.Users.FirstOrDefault(
                    x => x.Login == TxbLogin.Text && x.Password == PsbPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Не верен логин или пароль", "Уведомление", MessageBoxButton.OK);
                }

                else
                {
                    UserControlHelp.iduser = userObj.id;

                    switch (userObj.Idrole)
                    {   // 1 - пользваотель (1\1)
                        case 1:
                            UserPage userPage = new UserPage();
                            userPage.Show();
                            break;
                        // 2 - работник (qwe\qwe)
                        case 2:
                            WindowEmployee windowEmployee = new WindowEmployee();
                            windowEmployee.Show();
                            break;
                        // 3 - Админ (123\123)
                        case 3:
                            WindowAdmin windowAdmin = new WindowAdmin();
                            windowAdmin.Show();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail","Warning" + ex.Message.ToString(), MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
