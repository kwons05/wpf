using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppDataGrid
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Customer> CustomerData1;
        private ObservableCollection<Customer> CustomerData2;

        public MainWindow()
        {
            InitializeComponent();

            CustomerData1 = GetData();
            CustomerData2 = GetData();

            this.datagrid1.ItemsSource = CustomerData1;
            this.datagrid2.ItemsSource = CustomerData2;
        }
        private ObservableCollection<Customer> GetData()
        {
            return new ObservableCollection<Customer>()
            {
                new Customer() { FirstName = "kwon", LastName = "d" },
                new Customer() { FirstName = "kim", LastName = "q" },
                new Customer() { FirstName = "you", LastName = "r" },
            };
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            CustomerData1.Add(new Customer() { FirstName = "kwon", LastName = "d" });
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            CustomerData2.Add(new Customer() { FirstName = "you", LastName = "y" });
        }
    }
}
