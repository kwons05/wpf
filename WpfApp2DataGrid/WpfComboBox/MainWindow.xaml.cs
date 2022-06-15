using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using WpfComboBox.Model;

namespace WpfComboBox
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Book   MyBook { get; set; }

        public Book[] BookEntry { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            BookEntry = new Book[] { 
                new Book() { Title = "토지", Description = "박경리"},
                new Book() { Title = "조선가", Description = "김영사"},
            };

            this.DataContext = this;
        }



        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MyBook = new Book() { Title = "토지", Description = "박경리" };
            MyBook = BookEntry[1];

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyBook)));

        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Button");
        }
    }
}
