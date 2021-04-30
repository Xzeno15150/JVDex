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
            return base.ToString();
        }



        //TODO toString

    }

}