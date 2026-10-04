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

namespace _004_NumberGuess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int CorrectNumber, Count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            CorrectNumber = rand.Next(1, 100);
            Count = 0;
            Times.Content = $"{Count}回目";
            Answer.Text = "0";
            Judge.Content = "正誤判定";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Count++;
            Times.Content = $"{Count}回目";

            int ans = int.Parse(Answer.Text);

            if (ans == CorrectNumber)
            {
                Judge.Content = "正解！";
            }
            else if (ans > CorrectNumber)
            {
                Judge.Content = "もっと小さいです";
            }
            else if (ans < CorrectNumber)
            {
                Judge.Content = "もっと大きいです";
            }
        }
    }
}