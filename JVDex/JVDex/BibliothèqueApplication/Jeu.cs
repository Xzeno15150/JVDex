
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Jeu : IEquatable<Jeu>
    {
        public ISet<string> LesVisuels { get; private set;}
        public ISet<string> LesMusiques { get; private set; }
        public ISet<Theorie> LesTheories { get; private set; }

        //Propriétés
        public InformationsJeu Informations { get; set; }
        public bool IsFavoris { get; private set; }

        public Jeu(string nom, CreateurJeu createur, DateTime dateCreation, int limiteAge, string synopsis)
        {
            Informations = new InformationsJeu(nom, createur, dateCreation, limiteAge, synopsis);
            LesVisuels = new HashSet<string>();
            LesMusiques = new HashSet<string>();
            LesTheories = new HashSet<Theorie>();
        }

        //Méthodes
        public void AjouterAuxFavoris()
        {
            IsFavoris = true;
        }

        public void EnleverDesFavoris()
        {
            IsFavoris = false;
        }

        public void AjouterVisuel(string visuel)
        {
            if (!LesVisuels.Add(visuel))
            {
                throw new ArgumentException("PB: cette image est déjà dans la liste des visuels");
            }
        }
        public void AjouterMusique(string musique)
        {
            if (!LesMusiques.Add(musique))
            {
                throw new ArgumentException("PB: cette musique est déjà dans la liste des musiques");
            }
        }

        public void AjouterTheorie(Theorie theorie)
        {
            if (!LesTheories.Add(theorie))
            {
                throw new ArgumentException("PB: cette théorie est déjà dans la liste des théories.");
            }
        }
        public override string ToString()
        {
            string mes = Informations.ToString();
            // je comprends pas pourquoi on met Information et pas InformationsJeu
            // on met Informations puisque ce que l'on cherche ce trouve dans la propriété (="variable", en gros) Informations, InformationsJeu est le type de cette propriété, donc rien à voir
            // regarde en dessous, tu prend des valeurs de la liste LesVisuels, tu ne les prend pas dans le type string

            mes += "Liste des visuels : \n";
            foreach (string s in LesVisuels)
            {
                mes += $"\t- {s}\n";
            } 
            mes += "Liste des musiques : \n";
            foreach (string s in LesMusiques)
            {
                mes += $"\t- {s}\n";
            }
            mes += "Théories : \n";
            foreach (Theorie s in LesTheories)
            {
                mes += $"\t- {s.Nom}\n";
            }
            return mes;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;

            Jeu other = obj as Jeu;
            return Equals(other);
        }

        public override int GetHashCode()
        {
            return -878831966 + EqualityComparer<InformationsJeu>.Default.GetHashCode(Informations);
        }

        public bool Equals(Jeu other)
        {
            if (other is null) return false;
            return Informations.Equals(other.Informations);
        }
    }
}
