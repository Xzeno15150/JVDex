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

        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = mgr;
        }

        private void ListBoxFranchises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mgr.FranchiseSelected = ListBoxFranchises.SelectedItem as Franchise;
            mgr.JeuSelected = null;
            ContentControl_NavigationPage.Content = new UserControlFranchise();
        }
    }
}
