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
            return Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1110574089 + EqualityComparer<string>.Default.GetHashCode(Texte);
        }

        public bool Equals(Theorie other)
        {
            if (this == other) return true;
            if (other is null) return false;
            if (GetType() != other.GetType()) return false;

            return Texte == other.Texte;
        }
    }

}