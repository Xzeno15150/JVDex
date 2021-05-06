using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Créateur : CreateurJeu
    {
        public string Prenom { get; }
        public DateTime DateNaissance { get; }

        public Créateur(string nom, string prenom, DateTime dateNaissance) : base(nom)
        {
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom}";
        }
    }
}
