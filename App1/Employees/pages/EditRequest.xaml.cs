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
    /// Логика взаимодействия для EditRequest.xaml
    /// </summary>
    public partial class EditRequest : Page
    {


        public EditRequest(request request)
        {
            InitializeComponent();
            CmbHardware.SelectedValuePath = "id";
            CmbHardware.DisplayMemberPath = "name_harware";
            CmbHardware.SelectedItem = odbConnectHelper.entObj.Hardwares.ToList();

            CmbFault.SelectedValuePath = "id";
            CmbFault.DisplayMemberPath = "fault1";
            CmbFault.ItemsSource = odbConnectHelper.entObj.faults.ToList();

            TxbNameRequest.Text = request.name;
            Txtbox_description.Text = request.description;


        }

        private void BtnEditRequest_Click(object sender, RoutedEventArgs e)
        {
            request requeObj = new request()
            {

            };
        }
    }
}
