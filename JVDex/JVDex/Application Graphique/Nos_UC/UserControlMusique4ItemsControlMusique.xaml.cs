using BibliothèqueApplication;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
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
using System.Windows.Threading;

namespace Application_Graphique.Nos_UC
{
    /// <summary>
    /// Logique d'interaction pour UserControlMusique4ItemsControlMusique.xaml
    /// </summary>
    public partial class UserControlMusique4ItemsControlMusique : UserControl
    {
        public Manager mgr = (App.Current as App).LeManager;
        MediaPlayer player = new MediaPlayer();
        public UserControlMusique4ItemsControlMusique()
        {
            InitializeComponent();

           // player.Open(new Uri(@"../musiques/botw-OST1.mp3", UriKind.Relative));
        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }
    }
}
