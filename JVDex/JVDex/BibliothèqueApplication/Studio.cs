using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Studio : CreateurJeu, IEquatable<Studio>

    {
        public Studio(string nom) : base(nom)
        {
        }

        public bool Equals(Studio other)
        {
            if (other == null) return false;
            return base.Equals(other.Nom);
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;
            Studio other = obj as Studio;
            return Equals(other);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
