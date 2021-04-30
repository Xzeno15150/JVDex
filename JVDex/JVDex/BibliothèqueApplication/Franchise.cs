using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Franchise : Nommable
    {
        private IList<Jeu> lesJeux;

        public Franchise(string nom) :base(nom)
            {
         IList<Jeu> lesJeux = new List<Jeu>();   //j'ai réussi à instancier en faisant un new de List et non de IList

            }

        public override string ToString()
        {
            //TODO nom de franchise + liste des NOMS des jeux 
            string mes = $"Nom de la franchise :{Nom}\n";
            foreach (Jeu j in lesJeux)
            {
                mes += $"\t- {j.Informations.Nom}\n";
            }
            return mes;
        }
    }

}
