using BibliothèqueApplication;
using Data;
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
using System.Windows.Shapes;

namespace Application_Graphique
{
    /// <summary>
    /// Logique d'interaction pour Franchises_Favoris.xaml
    /// </summary>
    public partial class Franchises_Favoris : Window
    {
        public Manager mgr => (App.Current as App).LeManager;
        public Franchises_Favoris()
        {
            InitializeComponent();
            DataContext = mgr;
        }

        private void ListBoxFranchises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.FranchiseSelected = ListBoxFranchises.SelectedItem as Franchise;
        }
    }
}
