using App1.Class;
using App1.pages;
using App1.xaml;
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

namespace App1.Employee
{
    /// <summary>
    /// Логика взаимодействия для WindowEmployee.xaml
    /// </summary>
    public partial class WindowEmployee : Window
    {
        public WindowEmployee()
        {
            InitializeComponent();
            FrameApp.frnObj = FrmEmployee;
            FrmEmployee.Navigate(new pages.AllRequest());
        }
 
        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {
          FrameApp.frnObj.Navigate(new AddRequest());
        }

        private void AllRequest_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new pages.AllRequest());
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frnObj.Navigate(new СompletedRequest());
        }
    }
}
