using System;
using System.Collections.Generic;

namespace BibliothèqueApplication
{
    public class Franchise : Nommable, IEquatable<Franchise>
    {
        public string Background { get; set; }
        public ISet<Jeu> LesJeux { get; }

        public Franchise(string nom, string image) : base(nom)
        {
            LesJeux = new HashSet<Jeu>();
            Background = image;
        }
         
        //permet d'ajouter un jeu dans la liste des franchises
        public void ajouterJeu(Jeu jeu) 
        {
            if (!LesJeux.Add(jeu))
            {
                throw new ArgumentException("PB: le jeu est déjà dans la liste des jeux");
            }
        }

        // permet de supprimer un jeu dans la liste des franchises
        public void SupprimerJeu(Jeu jeu)
        {
            if (!LesJeux.Remove(jeu))
            {
                throw new ArgumentException("PB: ce jeu n'est plus sur la liste");
            }
        }
        public override string ToString()
        {
            string mes = $"Nom de la franchise :{Nom}\n";
            mes += "Liste des jeux : \n";
            foreach (Jeu j in LesJeux)
            {
                mes += $"\t- {j.Informations.Nom}\n";
            }
            mes += $"Image de background : {Background}\n";
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
                   LesJeux.SetEquals(other.LesJeux);
        }

        public override int GetHashCode()
        {
            int hashCode = 1423109898;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<ISet<Jeu>>.Default.GetHashCode(LesJeux);
            return hashCode;
        }
    }

}
