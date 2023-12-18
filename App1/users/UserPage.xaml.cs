using App1.Class;
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
using System.Windows.Shapes;

namespace App1.users
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Window
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void TxbNameClient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxbNameRequest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new AddClient());
        }
    }
}
