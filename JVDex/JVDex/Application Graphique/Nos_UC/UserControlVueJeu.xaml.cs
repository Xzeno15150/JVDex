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
    /// Logique d'interaction pour UserControlVueJeu.xaml
    /// </summary>
    public partial class UserControlVueJeu : UserControl
    {

        public Manager mgr => (App.Current as App).LeManager;
        public Navigator nav => (App.Current as App).LeNavigateur;

        static Dictionary<string, Func<UserControl>> factory = new Dictionary<string, Func<UserControl>>()
        {
            ["Informations"] = () => new UserControlInformations(),
            ["Visuels"] = () => new UserControlVisuel(),
            ["Musiques"] = () => new UserControlMusique(),
            ["Théories"] = () => new UserControlTheorie(),
        };
        public UserControlVueJeu()
        {
            InitializeComponent();
            DataContext = mgr;
        }

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
