using System.Windows;

namespace WpfBlinkText
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public Data Data { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Data = new Data();

            this.DataContext = this;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Data.State = 1;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Data.State = 0;
        }
    }
}
