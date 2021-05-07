using System;
using System.Collections.Generic;

namespace BibliothèqueApplication
{
    public class Franchise : Nommable, IEquatable<Franchise>
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

            Franchise other = obj as Franchise;
            return Equals(other);
        }

        public bool Equals(Franchise other)
        {
            if (other is null) return false;
            return base.Equals(other.Nom) &&
                   lesJeux.SetEquals(other.lesJeux);
        }

        public override int GetHashCode()
        {
            int hashCode = 1423109898;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<ISet<Jeu>>.Default.GetHashCode(lesJeux);
            return hashCode;
        }


        //à voir ensemble
    }

}
