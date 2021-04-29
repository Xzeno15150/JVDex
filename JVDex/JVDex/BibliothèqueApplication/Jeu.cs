
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Jeu
    {
        private HashSet<string> lesVisuels;
        private IList<string> lesMusiques;
        private bool isFavoris;
        private IList<Theorie> lesTheories;
        public InformationsJeu Informations { get; set; }


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
            string mes = $"{Informations}\n";
            mes += "Liste des visuels : ";
            foreach (String s in lesVisuels)
            {
                mes += $"\t- {s}\n";
            }
            return mes;
        }
    }
}

//faut faire une propriété calculée pour faire le tri, la fonction retourne une liste triée
