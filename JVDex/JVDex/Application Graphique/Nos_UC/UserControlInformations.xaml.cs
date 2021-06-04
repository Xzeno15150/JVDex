using BibliothèqueApplication;
using Data;
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
    /// Logique d'interaction pour Informations.xaml
    /// </summary>
    public partial class UserControlInformations : UserControl
    {
        public Manager manager => (App.Current as App).LeManager; //instance de l'application
        public UserControlInformations()
        {
            InitializeComponent();
            DataContext = manager.JeuSelected;

        }

        public string SourceImage
        {
            get { return (string)GetValue(SourceImageProperty); }
            set { SetValue(SourceImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SourceImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceImageProperty =
            DependencyProperty.Register("SourceImage", typeof(string), typeof(UserControlInformations));
    }
    
}
//j'arrive pas à trouver le data contexte, il faudrait le bind sur le manager je sais pas comment faire