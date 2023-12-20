using App1.Class;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

namespace App1.pages
{
    /// <summary>
    /// Логика взаимодействия для СompletedRequest.xaml
    /// </summary>
    public partial class СompletedRequest : Page
    {
        public СompletedRequest()
        {
            InitializeComponent();
            CompletedRequest.ItemsSource =odbConnectHelper.entObj.requests.Where(x => x.status == false).ToList();   
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxbNameClient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
