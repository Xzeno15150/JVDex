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
    }

}
