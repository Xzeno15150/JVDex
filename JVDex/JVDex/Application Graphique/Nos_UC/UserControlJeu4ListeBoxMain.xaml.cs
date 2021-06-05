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
    /// Logique d'interaction pour UserControlJeu4ListeBoxMain.xaml
    /// </summary>
    public partial class UserControlJeu4ListeBoxMain : UserControl
    {
        public Manager mgr => (App.Current as App).LeManager;
        public UserControlJeu4ListeBoxMain()
        {
            InitializeComponent();
        }

        private void Button_JeuFavori_Click(object sender, RoutedEventArgs e)
        {
            Jeu j = (DataContext as Jeu);
            if (!j.IsFavoris) j.AjouterAuxFavoris();
            else j.EnleverDesFavoris();
        }
    }
}
