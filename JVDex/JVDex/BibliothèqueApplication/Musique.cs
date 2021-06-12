using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Musique : Nommable, IEquatable<Musique>
    {
        public string Path { get; set; }
        public string NomCreateur { get; set; }
        public DateTime DateCreation { get; set; }

        public Musique(string nom, string path, string nomCreateur, DateTime dateCreation) : base(nom)
        {
            Path = path;
            NomCreateur = nomCreateur;
            DateCreation = dateCreation;
        }

        public override string ToString()
        {
            return $"Nom : {Nom}\nChemin : {Path}\nCreateur: {NomCreateur}\nDate de creation: {DateCreation}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Musique);
        }

        public bool Equals(Musique other)
        {
            return other != null &&
                   base.Equals(other) &&
                   Nom == other.Nom &&
                   NomCreateur == other.NomCreateur &&
                   DateCreation == other.DateCreation;
        }

        public override int GetHashCode()
        {
            int hashCode = 1100406961;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomCreateur);
            hashCode = hashCode * -1521134295 + DateCreation.GetHashCode();
            return hashCode;
        }
    }
}
