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
        /// <summary>
        /// Instance de Manager de l'App lancée
        /// </summary>
        public Manager mgr => (App.Current as App).LeManager;
        /// <summary>
        /// Instance de Navigator de l'App lancée
        /// </summary>
        public Navigator nav => (App.Current as App).LeNavigateur;
        /// <summary>
        /// Instance de PersistanceFichierTexte de l'App lancée
        /// </summary>
        public IPersistanceStockApp pers => (App.Current as App).Pers;

        public MainWindow()
        {
            InitializeComponent();
            ListBoxFranchises.DataContext = mgr;
            ContentControl_NavigationPage.DataContext = nav;
            nav.NavigateTo("Main");
        }

        /// <summary>
        /// Permet d'afficher la page de la franchise sélectionnée.
        /// On affiche UserControlFranchise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxFranchises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBoxFranchises.SelectedItem != null)
                mgr.FranchiseSelected = ListBoxFranchises.SelectedItem as Franchise;
            mgr.JeuSelected = null;
            nav.NavigateTo("Franchise");
        }

        /// <summary>
        /// Permet de revenir à la page principale.
        /// On affiche UserControlMain.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_RetourMain_Click(object sender, RoutedEventArgs e)
        {
            mgr.FranchiseSelected = null;
            mgr.JeuSelected = null;
            nav.NavigateTo("Main");
        }

        /// <summary>
        /// Permet d'afficher la page des favoris.
        /// On affiche UserControlFranchise mais en utilisant des données différente d'une franchise
        /// (voir Navigator.ucNavigation)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Favoris_Click(object sender, RoutedEventArgs e)
        {
            mgr.FranchiseSelected = null;
            mgr.JeuSelected = null;
            nav.NavigateTo("Favoris");
        }
        private void ListBoxFranchises_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as ListBox).SelectedItem = null;
        }
        /// <summary>
        /// Permet de sauvegarder les favoris ajoutés dans le fichier texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            new PersistanceFichierTexte().SauvegardeDonnees(mgr.TousLesJeux, mgr.ToutesLesFranchises);
        }
    }
}
