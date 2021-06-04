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
    /// Logique d'interaction pour UserControlJeu.xaml
    /// </summary>
    public partial class UserControlJeu : UserControl
    {
        public Manager manager => (App.Current as App).LeManager;
        
        public UserControlJeu()
        {
            InitializeComponent();
        }
        private void Button_JeuFavori_Click(object sender, RoutedEventArgs e)
        {
            Jeu j = (DataContext as Jeu);
            if (!j.IsFavoris) j.AjouterAuxFavoris();
            else j.EnleverDesFavoris();

        }
        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(string), typeof(UserControlJeu));

        public string Nom
        {
            get { return (string)GetValue(NomProperty); }
            set { SetValue(NomProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Nom.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NomProperty =
            DependencyProperty.Register("Nom", typeof(string), typeof(UserControlJeu));



        public string LogoFavori
        {
            get { return (string)GetValue(LogoFavoriProperty); }
            set { SetValue(LogoFavoriProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LogoFavori.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LogoFavoriProperty =
            DependencyProperty.Register("LogoFavori", typeof(string), typeof(UserControlJeu));


    }
}
