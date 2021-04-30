
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Jeu
    {
        private HashSet<string> lesVisuels;
        private IList<string> lesMusiques;
        private bool isFavoris = false;
        private IList<Theorie> lesTheories;

        //Propriétés
        public InformationsJeu Informations { get; set; }

        public Jeu()
        {
            lesVisuels = new HashSet<string>();
            IList<string> lesMusiques = new List<string>();
            IList<Theorie> lesTheories = new List<Theorie>();
        }

        //Méthodes
        public bool GetIsFavoris()
        {
            return isFavoris;
        }

        public void AjouterAuxFavoris()
        {
            isFavoris = true;
        }

        public void EnleverDesFavoris()
        {
            isFavoris = false;
        }

        public override string ToString()
        {
            //TODO afficher toutes les infos du jeu dans la console
            string mes = $"{Informations}\n"; // je comprends pas pourquoi on met Information et pas InformationsJeu
            mes += "Liste des visuels : ";
            foreach (String s in lesVisuels)
            {
                mes += $"\t- {s}\n";
            } 
            mes += "Liste des musiques : ";
            foreach (String s in lesMusiques)
            {
                mes += $"\t- {s}\n";
            }
            mes += "Liste des théorie :";
            foreach (Theorie s in lesTheories)
            {
                mes += $"\t- {s}\n";
            }
            return mes;
        }
    }
}

//faut faire une propriété calculée pour faire le tri, la fonction retourne une liste triée
