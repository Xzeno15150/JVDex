using System;
using System.Collections.Generic;

namespace BibliothèqueApplication
{
    public class Franchise : Nommable, IEquatable
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

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;

            Franchise other = (Franchise)obj;
            return Equals(other);
        }

        public bool Equals(Franchise other)
        {
            if (other is null) return false;
            return lesJeux.SetEquals(other.lesJeux);
        }

        public override int GetHashCode()
        {
            var hashCode = 89;
            var constante = 8;
            hashCode = hashCode * lesJeux.GetHashCode() + constante;
            return hashCode;
        }
        //à voir ensemble
    }

}
