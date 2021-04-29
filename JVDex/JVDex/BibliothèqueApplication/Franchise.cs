using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Franchise : Nommable
    {
        private IList<Jeu> lesJeux;

        public override string ToString()
        {
            //TODO nom de franchise + liste des NOMS des jeux 
            string mes = "";
            foreach (Jeu j in lesJeux)
            {
                mes += $"\t- {j.Informations.Nom}\n";
            }
            return mes;
        }
    }

}
