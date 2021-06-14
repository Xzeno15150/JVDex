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
        /// <summary>
        /// Instance du manager de l'App lancée
        /// </summary>
        public static Manager mgr => (App.Current as App).LeManager;

        /// <summary>
        /// Champ privé contenant le UserControl courant dans le ContentControl de MainWindow 
        /// </summary>
        private UserControl currentMainUserControl;

        /// <summary>
        /// Dictionnaire qui contient une string comme clé, et un Func<UserControl>() comme value.
        /// Chaque Func<UserControl>() retourne le UserControl souhaité en fonction du string (clé) voulu
        /// </summary>
        static Dictionary<string, Func<UserControl>> ucNavigation = new Dictionary<string, Func<UserControl>>()
        {
            ["Franchise"] = () => new UserControlFranchise(mgr.FranchiseSelected.Nom, mgr.FranchiseSelected.Background, mgr.JeuxDeLaFranchiseSelected),
            ["Favoris"] = () => new UserControlFranchise("Favoris", null, mgr.TousLesJeux.Where(jeu => jeu.IsFavoris == true).ToList()),
            ["Jeu"] = () => new UserControlVueJeu(),
            ["Main"] = () => new UserControlMain(),
        };

        /// <summary>
        /// Dictionnaire qui contient un string comme clé, et un Func<UserControl>() comme value
        /// Chaque Func<UserControl>() retourne le UserControl souhaité en fonction du string (clé) voulu qui sont égaux
        /// aux noms des items de la ListBox dans UserControlVueJeu
        /// </summary>
        static Dictionary<string, Func<UserControl>> ucNavigationTabJeu = new Dictionary<string, Func<UserControl>>()
        {
            ["Informations"] = () => new UserControlInformations(),
            ["Visuels"] = () => new UserControlVisuel(),
            ["Musiques"] = () => new UserControlMusique(),
            ["Théories"] = () => new UserControlTheorie(),

        };

        /// <summary>
        /// Permet de naviguer entre les UserControl dans MainWindow
        /// </summary>
        /// <param name="nomUC">String qui correspond à une clé de ucNavigation</param>
        public void NavigateTo(string nomUC)
        {
            if (ucNavigation.ContainsKey(nomUC))
            {
                CurrentMainUserControl = ucNavigation[nomUC]();
            }
        }
        /// <summary>
        /// Propriété associé au champ privé currentMainUserControl
        /// retourne le UserControl contenu dans ce champ privé
        /// </summary>
        public UserControl CurrentMainUserControl
        {
            get => currentMainUserControl;
            set
            {
                currentMainUserControl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentMainUserControl"));
            }
        }
        /// <summary>
        /// Champ privé contenant le UserControl courant dans le ContentControl de UserControlVueJeu 
        /// </summary>
        private UserControl currentTabJeu;

        /// <summary>
        /// Propriété associé au champ privé currentTabJeu
        /// retourne le UserControl contenu dans ce champ privé
        /// </summary>
        public UserControl CurrentTabJeu
        {
            get { return currentTabJeu; }
            set
            {
                currentTabJeu = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentTabJeu"));
            }
        }

        /// <summary>
        /// Permet de naviguer entre les UserControl dans UserControlVueJeu
        /// </summary>
        /// <param name="nomUC">String qui correspond à une clé de ucNavigationTabJeu</param>
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