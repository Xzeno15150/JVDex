using Application_Graphique.Nos_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;

namespace Application_Graphique

{
    public class Navigator : INotifyPropertyChanged
    {
        private UserControl currentMainUserControl;
       /**/ static Dictionary<string, Func<UserControl>> ucNavigation = new Dictionary<string, Func<UserControl>>()
        {
            ["Franchise"] = () => new UserControlFranchise(),
            ["VueJeu"] = () => new UserControlVueJeu(),
            ["Jeu"] = () => new UserControlJeu(),
            ["Main"] = () => new UserControlMain(),
            ["InfoJeu"] = () => new UserControlInformations(),
        };

        public void NavigateTo(string nomUC)
        {
            if (ucNavigation.ContainsKey(nomUC))
            {
                new UserControl();
            }


        }

         public UserControl CurrentMainUserControl
         {
             get => currentMainUserControl;
             set
             {
                 currentMainUserControl = value;
                 PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentMainUserControl"));
             }
         }
         public event PropertyChangedEventHandler PropertyChanged;
    }
    
}
// il faut refaire un navigator celui là ne convient pas: faire un tableau des UC pour les associer à des String, méthode NavigateTo(String). D'après le prof c'est plus facile et rapide de faire ça
//c'est pour éviter la dépendance aux UC