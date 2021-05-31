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

        static Dictionary<string, Func<UserControl>> factory = new Dictionary<string, Func<UserControl>>()
        {
            [""] = () => new UserControlJeu(),
            [""] = () => new UserControlMain(),
            [""] = () => new UserControlFranchise(),
            
        };

        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = mgr;
        }

        private void ListBoxListeJeux_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.JeuSelected = (sender as ListBox).SelectedItem as BibliothèqueApplication.Jeu;
            new Jeu().Show();
            this.Close();

        }

       private void ButtonRecherche_Click(object sender, RoutedEventArgs e)
        {
            mgr.JeuRecherche = TextBoxRecherche.Text;
        }

        private void TextBoxRecherche_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                (sender as TextBox).MoveFocus(new TraversalRequest(FocusNavigationDirection.Previous));
            }
        }

        private void ComboBoxTri_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.TypeTriJeuSelected = (TypeTri)ComboBoxTri.SelectedItem;
        }

        private void ListBoxFranchises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.FranchiseSelected = ListBoxFranchises.SelectedItem as Franchise;
            mgr.JeuSelected = null;
            new Franchises_Favoris().Show();
            this.Close();
        }
    }
}
