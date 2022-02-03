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

namespace sssssssss
{
    /// <summary>
    /// Логика взаимодействия для MainWindowClient.xaml
    /// </summary>
    public partial class MainWindowClient : Window
    {
        doka2Entities context;
        public MainWindowClient()
        {
            InitializeComponent();
            context = new doka2Entities();
            ShowTable();
        }

        private void ShowTable()
        {
            DataGridClient.ItemsSource = context.Client.ToList();
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAd_Click(object sender, RoutedEventArgs e)
        {
            var NewRental = new Client();
            context.Client.Add(NewRental);
            var addRentalWindow = new AddDataClient(context, NewRental);
            addRentalWindow.ShowDialog();
        }

        private void BtnD_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
