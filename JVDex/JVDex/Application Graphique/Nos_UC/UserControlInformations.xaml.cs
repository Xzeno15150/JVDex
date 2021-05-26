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
        public Manager manager = Stub.Load();
        public UserControlInformations()
        {
            InitializeComponent();

            MainGrid.DataContext = manager.JeuSelected;
        }

    }
    //alors ça j'ai un peu de mal à le coder. Mais en gros ça va ye permettre de changer les informations de ton UserControl en fonction d'un jeu, et pour cela on a besoin 
    //d'une DependencyProprety. Les get et set il faut SURTOUT  pas les changer normalement. C'est expliquer dans la vidéo mais voilà à quoi ça sert
    
}
