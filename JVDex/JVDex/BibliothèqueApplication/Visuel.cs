using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Visuel : IEquatable<Visuel>
    {
        public string Vignette { get; set; }
        public string Legende { get; set; }

        public Visuel (string vignette, string legende)
        {
            this.Vignette = vignette;
            this.Legende = legende;
        }

        public override string ToString()
        {
            string mes = Vignette;
            mes += Legende;
            return mes;
        }

        public override bool Equals(object obj)
        {

            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;

            Visuel other = obj as Visuel;

            return Equals(other);
            
        }

        public bool Equals(Visuel other)
        {
            if (other is null) return false;
            return Vignette.Equals(other.Vignette) &&
                   Legende.Equals(other.Legende);
        }

        public override int GetHashCode()
        {
            var hashCode = -251894018;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Vignette);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Legende);
            return hashCode;
        }
    }
}

//TODO finir de faire la classe 
