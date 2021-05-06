using System;
using System.Collections.Generic;

namespace BibliothèqueApplication
{
    public class Franchise : Nommable
    {
        public ISet<Jeu> lesJeux { get; }

        public Franchise(string nom) : base(nom)
        {
            lesJeux = new HashSet<Jeu>();
        }
           
        public void ajouterJeu(Jeu jeu) 
        {
            if (!lesJeux.Add(jeu))
            {
                throw new ArgumentException("PB: le jeu est déjà dans la liste des jeux");
            }
        }
        public override string ToString()
        {
            string mes = $"Nom de la franchise :{Nom}\n";
            mes += "Liste des jeux : \n";
            foreach (Jeu j in lesJeux)
            {
                mes += $"\t- {j.Informations.Nom}\n";
            }
            return mes;
        }
    }

}
