using System;
using System.Collections.Generic;

namespace BibliothèqueApplication
{
    public class Franchise : Nommable, IEquatable<Franchise>
    {
        public string Background { get; set; }
        public string Couleur { get; set; }

        public Franchise(string nom, string image, string color) : base(nom)
        {
            Background = image;
            Couleur = color;
        }
         
       
        public override string ToString()
        {
            string mes = $"Nom de la franchise :{Nom}\n";
            mes += $"Image de background : {Background}\n";
            mes += $"Couleur : {Couleur}\n";
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
            return Nom.Equals(other.Nom) &&
                Background.Equals(other.Background);
        }

        public override int GetHashCode()
        {
            int hashCode = 1423109898;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Background);
            return hashCode;
        }
    }

}
