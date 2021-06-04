using Application_Graphique.Nos_UC;
using BibliothèqueApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Application_Graphique

{
    public class Navigator : INotifyPropertyChanged
    {
        public static Manager mgr => (App.Current as App).LeManager; 

        private UserControl currentMainUserControl;
        /**/
        static Dictionary<string, Func<UserControl>> ucNavigation = new Dictionary<string, Func<UserControl>>()
        {
            ["Franchise"] = () => new UserControlFranchise(mgr.FranchiseSelected.Nom, mgr.FranchiseSelected.Background, mgr.JeuxDeLaFranchiseSelected),
            ["Favoris"] = () => new UserControlFranchise("Favoris", null, mgr.TousLesJeux.Where(jeu => jeu.IsFavoris == true).ToList()),
            ["Jeu"] = () => new UserControlVueJeu(),
            ["Main"] = () => new UserControlMain(),
        };

        static Dictionary<string, Func<UserControl>> ucNavigationTabJeu = new Dictionary<string, Func<UserControl>>()
        {
            ["Informations"] = () => new UserControlInformations(),
            ["Visuels"] = () => new UserControlVisuel(),
            ["Musiques"] = () => new UserControlMusique(),
            ["Théories"] = () => new UserControlTheorie(),
        };

        public void NavigateTo(string nomUC)
        {
            if (ucNavigation.ContainsKey(nomUC))
            {
                CurrentMainUserControl = ucNavigation[nomUC]();
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

        private UserControl currentTabJeu;

        public UserControl CurrentTabJeu
        {
            get { return currentTabJeu; }
            set
            {
                currentTabJeu = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentTabJeu"));
            }
        }

        public void NavigateToTabJeu(string nomUC)
        {
            if (ucNavigationTabJeu.ContainsKey(nomUC))
            {
                CurrentTabJeu = ucNavigationTabJeu[nomUC]();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    
}
// il faut refaire un navigator celui là ne convient pas: faire un tableau des UC pour les associer à des String, méthode NavigateTo(String). D'après le prof c'est plus facile et rapide de faire ça
// c'est pour éviter la dépendance aux UC