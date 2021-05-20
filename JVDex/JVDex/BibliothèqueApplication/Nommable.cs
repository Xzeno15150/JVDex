using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public abstract class Nommable : IEquatable<Nommable>
    {
        public string Nom { get; set; }

        public Nommable (string nom)
        {
            this.Nom = nom;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;
            Nommable other = obj as Nommable;
            return Equals(other);
        }

        public override int GetHashCode()
        {
            return 217408413 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }

        public bool Equals(Nommable other)
        {
            if (other is null) return false;
            return Nom.Equals(other.Nom);
        }
    }

}
