using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    class Visuel
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
            return base.Equals(obj);
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
