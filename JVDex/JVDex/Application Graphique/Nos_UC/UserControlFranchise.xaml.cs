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
            DataContext = mgr;
        }

        private void ListBoxJeuxDeLaFranchise_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.JeuSelected = (sender as ListBox).SelectedItem as BibliothèqueApplication.Jeu;
        }
    }
}
