using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Createur : CreateurJeu, IEquatable<Createur>
    {
        public string Prenom { get; }
        public DateTime DateNaissance { get; }

        public Createur(string nom, string prenom, DateTime dateNaissance) : base(nom)
        {
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom}";
        }

        public bool Equals(Createur other)
        {
            if (other is null) return false;
            return Nom.Equals(other.Nom) &&
                   Prenom.Equals(other.Prenom) &&
                   DateNaissance.Equals(other.DateNaissance);
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;

            Createur other = obj as Createur;
            return Equals(other);
        }

        public override int GetHashCode()
        {
            var hashCode = -2125302532;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            hashCode = hashCode * -1521134295 + DateNaissance.GetHashCode();
            return hashCode;
        }

        
    }
}
