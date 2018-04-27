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

namespace musicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Media.MediaPlayer mediaPlayer = new MediaPlayer();
        TimeSpan time = new TimeSpan();
        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer.Open(new Uri("ragtime.mp3", UriKind.Relative));
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Position = time;
            mediaPlayer.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            time = mediaPlayer.Position;
            mediaPlayer.Stop();
        }
    }
}
