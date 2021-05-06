using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Studio : CreateurJeu
    {
        public Studio(string nom) : base(nom)
        {
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
