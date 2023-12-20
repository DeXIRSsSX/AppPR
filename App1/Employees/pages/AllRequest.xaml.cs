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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App1.pages
{
    /// <summary>
    /// Логика взаимодействия для AllRequest.xaml
    /// </summary>
    public partial class AllRequest : Page
    {
        public AllRequest()
        {
            InitializeComponent();
            AllRequestDT.ItemsSource = odbConnectHelper.entObj.requests.Where(x => x.status == true).ToList();
        }

        private void BtnEditRequest_Click(object sender, RoutedEventArgs e)
        {
            HelpClass.MainFrame.Navigate(new EditRequest());
        }
    }
}
