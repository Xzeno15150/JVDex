using Application_Graphique.Nos_UC;
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
        static Dictionary<string, Func<UserControl>> factory = new Dictionary<string, Func<UserControl>>();
        public Jeu()
        {
            InitializeComponent();
            /*factory.Add("informations", UserControlInformations);
            factory.Add("visuels", UserControlVisuel);
            factory.Add("theories", UserControlTheorie);
            factory.Add("musiques", UserControlMusique);*/

            //var content = ()


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

        void Informations_Click (object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
// il faut peut-être utiliser BindingNavigator pour pouvoir naviguer entre les UC, j'arrive vraiment pas à voir comment je peux faire :/
