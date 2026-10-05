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

namespace _005_Janken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pcHand, cnt;

        string[] imagePaths = 
        { 
            "pack://application:,,,/Assets/janken_gu.png" ,
            "pack://application:,,,/Assets/janken_choki.png" ,
            "pack://application:,,,/Assets/janken_pa.png" 
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Gu_Click(object sender, RoutedEventArgs e)
        {
            if (Player.Visibility == Visibility.Hidden)
            {
                Player.Source = new BitmapImage(new Uri(imagePaths[0]));
                PCHand.Visibility = Visibility.Visible;
                Player.Visibility = Visibility.Visible;
            }

            switch (pcHand)
            {
                case 0:
                    Judge.Content = "あいこ";
                    break;
                case 1:
                    Judge.Content = "あなたの勝ち";
                    cnt++;
                    Count.Content = $"{cnt}連勝";
                    break;
                case 2:
                    Judge.Content = "あなたの負け";
                    cnt = 0;
                    Count.Content = $"{cnt}連勝";
                    break;
            }
        }

        private void Choki_Click(object sender, RoutedEventArgs e)
        {
            if (Player.Visibility == Visibility.Hidden)
            {
                Player.Source = new BitmapImage(new Uri(imagePaths[1]));
                PCHand.Visibility = Visibility.Visible;
                Player.Visibility = Visibility.Visible;
            }

            switch (pcHand)
            {
                case 0:
                    Judge.Content = "あなたの負け";
                    cnt = 0;
                    Count.Content = $"{cnt}連勝";
                    break;
                case 1:
                    Judge.Content = "あいこ";
                    break;
                case 2:
                    Judge.Content = "あなたの勝ち";
                    cnt++;
                    Count.Content = $"{cnt}連勝";
                    break;
            }
        }

        private void Pa_Click(object sender, RoutedEventArgs e)
        {
            if (Player.Visibility == Visibility.Hidden)
            {
                Player.Source = new BitmapImage(new Uri(imagePaths[2]));
                PCHand.Visibility = Visibility.Visible;
                Player.Visibility = Visibility.Visible;
            }

            switch (pcHand)
            {
                case 0:
                    Judge.Content = "あなたの勝ち";
                    cnt++;
                    Count.Content = $"{cnt}連勝";
                    break;
                case 1:
                    Judge.Content = "あなたの負け";
                    cnt = 0;
                    Count.Content = $"{cnt}連勝";
                    break;
                case 2:
                    Judge.Content = "あいこ";
                    break;
            }
        }

        private void Janken_Click(object sender, RoutedEventArgs e)
        {
            PCHand.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Hidden;
            var rand = new Random();
            pcHand = rand.Next(0, 3);
            PCHand.Source = new BitmapImage(new Uri(imagePaths[pcHand]));
        }
    }
}