using BibliothèqueApplication;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
        private bool mediaPlayerIsPlaying, userIsDraggingSlider;
        MediaPlayer player = new MediaPlayer();
        public UserControlMusique4ItemsControlMusique()
        {
            InitializeComponent();
            player.Open(new Uri(@"/Ressources;component/musiques/botw-OST1.mp3", UriKind.RelativeOrAbsolute));
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += timer_Tick;
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if ((player.Source != null) && (player.NaturalDuration.HasTimeSpan))
            {
                SliderTemps.Minimum = 0;
                SliderTemps.Maximum = player.NaturalDuration.TimeSpan.TotalSeconds;
                SliderTemps.Value = player.Position.TotalSeconds;
            }
        }
        private void SliderTemps_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void SliderTemps_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            player.Position = TimeSpan.FromSeconds(SliderTemps.Value);
        }
        private void SliderTemps_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TextBoxTimer.Text = TimeSpan.FromSeconds(SliderTemps.Value).ToString(@"mm\:ss");
        }

        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (player != null) && (player.Source != null);
        }

        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            player.Play();
            mediaPlayerIsPlaying = true;
        }

        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            player.Pause();
        }

        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            player.Stop();
            mediaPlayerIsPlaying = false;
        }
    }
}
