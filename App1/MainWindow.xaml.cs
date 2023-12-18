using App1.Class;
using System.Windows;

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
            odbConnectHelper.entObj = new DataBase.requestbdEntities2();
            FrmManin.Navigate(new xaml.AllRequest());
        }
    }
}
