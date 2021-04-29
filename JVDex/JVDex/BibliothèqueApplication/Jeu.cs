
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

        public bool GetIsFavoris()
        {
            return isFavoris;
        }

        public void InverserIsFavoris()
        {
            isFavoris = !isFavoris;
        }

       /* public void AfficherEtat()
        {
            if(isFavoris)
            {
                Console.WriteLine("jeu n'est pas en favoris");
            }
            else
            {
                Console.WriteLine("jeu en favoris");
            }
        }
        */ //pour pouvoir faire un test si InverserIsFavoris fonctionne

    }
}

//faut faire une propriété calculée pour faire le tri, la fonction retourne une liste triée
//afficher un jeu peut être une méthode?
