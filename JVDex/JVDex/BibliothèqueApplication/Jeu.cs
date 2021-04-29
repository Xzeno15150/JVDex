
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

        public bool GetIsFavoris()
        {
            return isFavoris;
        }

        public void InverserIsFavoris()
        {
            isFavoris = !isFavoris;
        }


    }
}
