﻿using App1.Class;
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
            CmbHardware.SelectedValuePath = "id";
            CmbHardware.DisplayMemberPath = "name_hardware";
            CmbHardware.ItemsSource = odbConnectHelper.entObj.Hardwares.ToList();

            CmbEmployee.SelectedValuePath = "id";
            CmbEmployee.DisplayMemberPath = "Name";
            CmbEmployee.ItemsSource = odbConnectHelper.entObj.Employees.ToList();

            CmbFault.SelectedValuePath = "id";
            CmbFault.DisplayMemberPath = "fault1";
            CmbFault.ItemsSource = odbConnectHelper.entObj.faults.ToList();

            CmbClient.SelectedValuePath = "id";
            CmbClient.DisplayMemberPath = "id";
            CmbClient.ItemsSource = odbConnectHelper.entObj.Klients.ToList();
        }
        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new AddClient());
        }

        private void BtnAddRequest_Click(object sender, RoutedEventArgs e)
        {
            request requeObj = new request()
            {
                description = Txtbox_description.Text,
                name = TxbNameRequest.Text,
                Hardware = CmbHardware.SelectedItem as Hardware,
                Klient = CmbClient.SelectedItem as Klient,
                fault = CmbFault.SelectedItem as fault,
                Employee = CmbEmployee.SelectedItem as Employee,
                date_request = DateTime.Now,
                status = ChkBox.IsChecked,
            };
            if (ChkBox.IsChecked == true)
            {
                odbConnectHelper.entObj.requests.Add(requeObj);
                odbConnectHelper.entObj.SaveChanges();
                MessageBox.Show("Заявка успешно отправлена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ChkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
