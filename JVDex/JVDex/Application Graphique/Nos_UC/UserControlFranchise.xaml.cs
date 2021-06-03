using BibliothèqueApplication;
using System;
using System.Collections.Generic;
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

namespace Application_Graphique.Nos_UC
{
    /// <summary>
    /// Logique d'interaction pour UserControlFranchise.xaml
    /// </summary>
    public partial class UserControlFranchise : UserControl
    {
        public Manager mgr => (App.Current as App).LeManager;
        public Navigator nav => (App.Current as App).LeNavigateur;
        public UserControlFranchise()
        {
            InitializeComponent();
        }

        public UserControlFranchise(string titre, string bg, IList<BibliothèqueApplication.Jeu> lj) : this()
        {
            TitrePage = titre;
            BackgroundImage = bg;
            ListeJeuxToShow = lj;
        }

        private void ListBoxJeuxDeLaFranchise_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.JeuSelected = (sender as ListBox).SelectedItem as BibliothèqueApplication.Jeu;
        }



        public string TitrePage
        {
            get { return (string)GetValue(TitrePageProperty); }
            set { SetValue(TitrePageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titre.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitrePageProperty =
            DependencyProperty.Register("Titre", typeof(string), typeof(UserControlFranchise));



        public string BackgroundImage
        {
            get { return (string)GetValue(BackgroundImageProperty); }
            set { SetValue(BackgroundImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackgroundImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundImageProperty =
            DependencyProperty.Register("BackgroundImage", typeof(string), typeof(UserControlFranchise));



        public IList<BibliothèqueApplication.Jeu> ListeJeuxToShow
        {
            get { return (IList<BibliothèqueApplication.Jeu>)GetValue(ListeJeuxToShowProperty); }
            set { SetValue(ListeJeuxToShowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ListeJeuxToShow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListeJeuxToShowProperty =
            DependencyProperty.Register("ListeJeuxToShow", typeof(IList<BibliothèqueApplication.Jeu>), typeof(UserControlFranchise));

    }
}
