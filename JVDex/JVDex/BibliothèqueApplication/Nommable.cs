using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public abstract class Nommable
    {
        public string Nom { get; set; }

        public Nommable (string nom)
        {
            this.Nom = nom;
        }

        public override bool Equals(object obj)
        {
            return obj is Nommable nommable &&
                   Nom == nommable.Nom;
        }

        public override int GetHashCode()
        {
            return 217408413 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
    }

}
