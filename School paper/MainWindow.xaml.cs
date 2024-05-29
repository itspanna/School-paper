
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace School_paper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserControl1 UserControl1;
        private UserControl2 UserControl2;
        private UserControl3 UserControl3;
        public MainWindow()
        {
            InitializeComponent();

            UserControl1 = new UserControl1();
            UserControl2 = new UserControl2();
            UserControl3 = new UserControl3();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            UserControl1.Content = new UserControl1();
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            UserControl2.Content = new UserControl2();
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            UserControl3.Content = new UserControl3();
        }

    }
}