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

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new PageRegistration());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var userObj = odbConnectHelper.entObj.Users.First(
                x => x.Login == TxbLogin.Text && x.Password == PsbPassword.Password);
           
            UserControlHelp.iduser = userObj.id;
            switch (userObj.IDrole)
            {
                case 1:
                    UserPage userPage = new UserPage();
                    break;
                case 2:
                    FrameApp.frnObj.Navigate(new AddRequest());
                    break;
                case 3:
                    FrameApp.frnObj.Navigate(new AddRequest());
                    break;

            }
        }
    }
}
