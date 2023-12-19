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

namespace App1.pages
{
    /// <summary>
    /// Логика взаимодействия для AddRequest.xaml
    /// </summary>
    public partial class AddRequest : Page
    {
        public AddRequest()
        {
            InitializeComponent();
            CmbHardware.SelectedValuePath = "id";
            CmbHardware.DisplayMemberPath = "name";
            CmbHardware.ItemsSource = odbConnectHelper.entObj.Hardwares.ToList();

            CmbEmployee.SelectedValuePath= "id";
            CmbEmployee.DisplayMemberPath= "name";
            CmbEmployee.ItemsSource = odbConnectHelper.entObj.Employees.ToList();

            CmbFault.SelectedValuePath = "id";
            CmbFault.DisplayMemberPath = "fault";
            CmbFault.ItemsSource = odbConnectHelper.entObj.faults.ToList();

            CmbClient.SelectedValuePath = "id";
            CmbClient.DisplayMemberPath = "surname";
            CmbClient.DisplayMemberPath = "name";
            CmbClient.DisplayMemberPath = "fname";
            CmbClient.ItemsSource = odbConnectHelper.entObj.Klients.ToList();
        }
        private void BtnAddRequest_Click(object sender, RoutedEventArgs e)
        {
            request requeObj = new request()
            {
                name = TxbNameRequest.Text,
                date_request = DateTime.Now,
                description = Txtbox_description.Text,
                Hardware = CmbHardware.SelectedItem as Hardware,
                fault = CmbFault.SelectedItem as fault,
                Klient = CmbClient.SelectedItem as Klient,
                Employee = CmbEmployee.SelectedItem as Employee,

                
            };
            if (ChkBox.IsChecked == true)
            {

            }
        }

        private void TxbNameRequest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxbNameClient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new users.AddClient());
        }

        

        private void ChkBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ChkBox.IsChecked == true)
            {
                
            }
        }
    }
}
