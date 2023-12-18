using App1.Class;
using App1.DataBase;
using System;
using System.Windows;
using System.Windows.Controls;

namespace App1.users
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Page
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void createClient_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Klient klient = new Klient()
                {
                    name = TbxName.Text,
                    surname = TbxSurname.Text,
                    fname = TbxFname.Text,
                };
                odbConnectHelper.entObj.Klients.Add(klient);
                odbConnectHelper.entObj.SaveChanges();
                MessageBox.Show("Данные успешно добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуста проверьте ведённые данные" + ex.Message.ToString(), "Уведомление ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
