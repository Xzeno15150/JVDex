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
    /// Logique d'interaction pour UserControlTheorie.xaml
    /// </summary>
    public partial class UserControlTheorie : UserControl
    {
        public Manager mgr = (App.Current as App).LeManager;
        public UserControlTheorie()
        {
            InitializeComponent();
            DataContext = mgr.JeuSelected;
        }

        private void ListBoxNomTheories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListBoxNomTheories.SelectedItem != null)
            {
                var uiElement = ItemsControlTexteTheories.ItemContainerGenerator.ContainerFromItem(ListBoxNomTheories.SelectedItem) as ContentPresenter;
                ListBoxNomTheories.SelectedItem = null;
                Point p = uiElement.TranslatePoint(new Point(), this);
                ScrollViewerMain.ScrollToVerticalOffset(p.Y + 300);
            }
        }
    }
}
