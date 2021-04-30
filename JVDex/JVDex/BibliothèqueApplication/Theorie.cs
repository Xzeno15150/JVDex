using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Theorie : Nommable
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
            return obj is Theorie theorie &&
                   Texte == theorie.Texte;
        }

        public override int GetHashCode()
        {
            return 1110574089 + EqualityComparer<string>.Default.GetHashCode(Texte);
        }
    }

}