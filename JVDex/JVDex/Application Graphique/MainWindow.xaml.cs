using Application_Graphique.Nos_UC;
using BibliothèqueApplication;
using Data;
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

namespace Application_Graphique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Manager mgr => (App.Current as App).LeManager;
        public Navigator nav => (App.Current as App).LeNavigateur;

        public MainWindow()
        {
            InitializeComponent();
            ListBoxFranchises.DataContext = mgr;
            ContentControl_NavigationPage.DataContext = nav;
            nav.NavigateTo("Main");
        }

        private void ListBoxFranchises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.FranchiseSelected = ListBoxFranchises.SelectedItem as Franchise;
            mgr.JeuSelected = null;
            nav.NavigateTo("Franchise");
        }

        private void Button_RetourMain_Click(object sender, RoutedEventArgs e)
        {
            mgr.FranchiseSelected = null;
            mgr.JeuSelected = null;
            nav.NavigateTo("Main");
        }

        private void Button_Favoris_Click(object sender, RoutedEventArgs e)
        {
            mgr.FranchiseSelected = null;
            mgr.JeuSelected = null;
            nav.NavigateTo("Favoris");
        }
    }
}
