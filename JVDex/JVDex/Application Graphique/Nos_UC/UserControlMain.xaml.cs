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
    /// Logique d'interaction pour UserControlMain.xaml
    /// </summary>
    public partial class UserControlMain : UserControl
    {
        public Manager mgr => (App.Current as App).LeManager;
        public UserControlMain()
        {
            InitializeComponent();
            DataContext = mgr;

        }
        private void ListBoxListeJeux_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.JeuSelected = (sender as ListBox).SelectedItem as BibliothèqueApplication.Jeu;
            
        }

        private void ButtonRecherche_Click(object sender, RoutedEventArgs e)
        {
            mgr.JeuRecherche = TextBoxRecherche.Text;
        }

        private void TextBoxRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                (sender as TextBox).MoveFocus(new TraversalRequest(FocusNavigationDirection.Previous));
            }
        }

        private void ComboBoxTri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.TypeTriJeuSelected = (TypeTri)ComboBoxTri.SelectedItem;
        }

    }
}
