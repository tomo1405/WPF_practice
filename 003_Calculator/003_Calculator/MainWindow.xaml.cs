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

namespace _003_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Add.IsChecked == true)
            {
                Answer.Content = double.Parse(T1.Text) + double.Parse(T2.Text);
            }
            else if (Sub.IsChecked == true)
            {
                Answer.Content = double.Parse(T1.Text) - double.Parse(T2.Text);
            }
            else if (Multi.IsChecked == true)
            {
                Answer.Content = double.Parse(T1.Text) * double.Parse(T2.Text);
            }
            else if (Div.IsChecked == true)
            {
                Answer.Content = double.Parse(T1.Text) / double.Parse(T2.Text);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}