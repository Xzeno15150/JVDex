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
        public Manager manager = Stub.Load();
        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = manager;
        }

        private void ListBoxListeJeux_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }

        private void ButtonRecherche_Click(object sender, RoutedEventArgs e)
        {
            manager.JeuRecherche = TextBoxRecherche.Text;
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
            manager.TypeTriJeuSelected = (TypeTri)ComboBoxTri.SelectedItem;
        }
    }
}
