using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Theorie : Nommable, IEquatable<Theorie>
    {
        //Propriétés
        public string Texte { get; set; }

        public Theorie(string nom, string texte) : base(nom)
        {
            this.Texte = texte;
        }

        public override string ToString()
        {
            return Texte;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;

            Theorie other = (Theorie) obj;

            return Equals(other);
        }

        public override int GetHashCode()
        {
            return 1110574089 + EqualityComparer<string>.Default.GetHashCode(Texte);
        }

        public bool Equals(Theorie other)
        {
            if (other is null) return false;
            return Texte == other.Texte;
        }
    }

}