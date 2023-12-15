using App1.Class;
using App1.pages;
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

namespace App1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameApp.frnObj = FrmManin;
            odbConnectHelper.entObj = new DataBase.requestbdEntities1();
            FrmManin.Navigate(new xaml.PageLogin());
        }

        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {
            HelpClass.MainFrame.Navigate(new AddRequest());
        }

        private void AllRequest_Click(object sender, RoutedEventArgs e)
        {
            HelpClass.MainFrame.Navigate(new AllRequest());
        }
    }
}
