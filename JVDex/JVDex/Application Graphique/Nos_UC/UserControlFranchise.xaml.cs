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
        private string titrePage;

        public string TitrePage
        {
            get { return titrePage; }
            set { titrePage = value; }
        }

        private string backgroundImage;

        public string BackgroundImage
        {
            get { return backgroundImage; }
            set { backgroundImage = value; }
        }

        private IList<BibliothèqueApplication.Jeu> listeJeuxToShow;

        public IList<BibliothèqueApplication.Jeu> ListeJeuxToShow
        {
            get { return listeJeuxToShow; }
            set { listeJeuxToShow = value; }
        }


        public UserControlFranchise()
        {
            InitializeComponent();
            DataContext = this;
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
            mgr.FranchiseSelected = null;
            nav.NavigateTo("Jeu");
        }
    }
}
