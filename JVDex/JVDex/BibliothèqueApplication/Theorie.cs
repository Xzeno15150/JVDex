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

        public string AjouterTexte(string texte)
        {
            return texte;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;

            Theorie other = obj as Theorie;

            return Equals(other);
        }

        public override int GetHashCode()
        {
            return 1110574089 + EqualityComparer<string>.Default.GetHashCode(Texte);
        }

        public bool Equals(Theorie other)
        {
            if (other is null) return false;
            return Nom.Equals(other.Nom) &&
                   Texte.Equals(other.Texte);
        }
    }

}

//va falloir faire quelque chose pour ajouter des théories, ça ne fonctionne pas