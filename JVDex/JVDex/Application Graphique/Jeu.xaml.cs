using Application_Graphique.Nos_UC;
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
using System.Windows.Shapes;

namespace Application_Graphique
{
    /// <summary>
    /// Logique d'interaction pour Jeu.xaml
    /// </summary>
    public partial class Jeu : Window
    {
        public Manager mgr = (App.Current as App).LeManager;

        static Dictionary<string, Func<UserControl>> factory = new Dictionary<string, Func<UserControl>>()
        {
            ["Informations"] = () => new UserControlInformations(),
            ["Visuels"] = () => new UserControlVisuel(),
            ["Musiques"] = () => new UserControlMusique(),
            ["Théories"] = () => new UserControlTheorie(),
        };

        public Jeu()
        {
            InitializeComponent();
            DataContext = mgr;

        }

        private void ListBoxFranchises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.FranchiseSelected = ListBoxFranchises.SelectedItem as Franchise;
            mgr.JeuSelected = null;
            new Franchises_Favoris().Show();
            this.Close();
        }

        //pour pouvoir faire une ListBoxItems cliquable
        /* private void ListBox_Selected(object sender, SelectionChangedEventArgs e)
         {
             ListBoxItem informations = e.Source as ListBoxItem;
             if (informations != null)
             {
                 MainGrid = UserControlInformations; // je sais pas du tout comment le faire
             }
         }*/

        void Informations_Click(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxNavigation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var content = (e.AddedItems[0] as ListBoxItem).Content as string;
            if (factory.ContainsKey(content))
            {
                factory[content]().DataContext = mgr.JeuSelected;
                ContentControlNav.Content = factory[content]();
                
            }
        }
    }
}

