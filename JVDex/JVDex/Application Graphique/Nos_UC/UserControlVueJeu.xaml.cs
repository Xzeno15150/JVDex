using BibliothèqueApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Logique d'interaction pour UserControlVueJeu.xaml
    /// </summary>
    public partial class UserControlVueJeu : UserControl
    {

        public Manager mgr => (App.Current as App).LeManager;
        public Navigator nav => (App.Current as App).LeNavigateur;

        public UserControlVueJeu()
        {
            InitializeComponent();
            DataContext = nav;
        }

        private void ListBoxNavigation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxNavigation.SelectedItem != null)
            {
                var content = (ListBoxNavigation.SelectedItem as ListBoxItem).Content as string;
                ListBoxNavigation.SelectedItem = null;
                nav.NavigateToTabJeu(content);
            }
            
        }
    }
}
