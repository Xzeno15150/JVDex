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
    /// Logique d'interaction pour UserControlEssai.xaml
    /// </summary>
    public partial class UserControlEssai : UserControl
    {
        public Navigator nav => (App.Current as App).LeNavigateur;
        public Manager mgr => (App.Current as App).LeManager;
        public UserControlEssai()
        {
            InitializeComponent();
        }

        public void ButtonEssai(object sender, SelectionChangedEventArgs e)
        {
            nav.NavigateTo("Main");

        }
    }
}
