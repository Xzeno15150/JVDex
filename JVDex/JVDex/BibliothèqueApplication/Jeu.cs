
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Jeu
    {
        private ISet<string> lesVisuels;
        private ISet<string> lesMusiques;
        private ISet<Theorie> lesTheories;

        //Propriétés
        public InformationsJeu Informations { get; set; }
        public bool IsFavoris { get; private set; }

        public Jeu(string nom, string nomCreateur, DateTime dateCreation, int limiteAge, string synopsis)
        {
            Informations = new InformationsJeu(nom, nomCreateur, dateCreation, limiteAge, synopsis);
            lesVisuels = new HashSet<string>();
            lesMusiques = new HashSet<string>();
            lesTheories = new HashSet<Theorie>();
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
            if (!lesVisuels.Add(visuel))
            {
                throw new ArgumentException("PB: cette image est déjà dans la liste des visuels");
            }
        }
        public void AjouterMusique(string musique)
        {
            if (!lesMusiques.Add(musique))
            {
                throw new ArgumentException("PB: cette musique est déjà dans la liste des musiques");
            }
        }

        public void AjouterTheorie(Theorie theorie)
        {
            if (!lesTheories.Add(theorie))
            {
                throw new ArgumentException("PB: cette théorie est déjà dans la liste des théories.");
            }
        }
        public override string ToString()
        {
            string mes = Informations.ToString();
            // je comprends pas pourquoi on met Information et pas InformationsJeu
            // on met Informations puisque ce que l'on cherche ce trouve dans la propriété (="variable", en gros) Informations, InformationsJeu est le type de cette propriété, donc rien à voir
            // regarde en dessous, tu prend des valeurs de la liste lesVisuels, tu ne les prend pas dans le type string

            mes += "Liste des visuels : \n";
            foreach (string s in lesVisuels)
            {
                mes += $"\t- {s}\n";
            } 
            mes += "Liste des musiques : \n";
            foreach (string s in lesMusiques)
            {
                mes += $"\t- {s}\n";
            }
            mes += "Théories : \n";
            foreach (Theorie s in lesTheories)
            {
                mes += $"\t- {s.Nom}\n";
            }
            return mes;
        }

        public override bool Equals(object obj)
        {
            return obj is Jeu jeu &&
                   EqualityComparer<InformationsJeu>.Default.Equals(Informations, jeu.Informations);
        }

        public override int GetHashCode()
        {
            return -878831966 + EqualityComparer<InformationsJeu>.Default.GetHashCode(Informations);
        }
    }
}

//faut faire une propriété calculée pour faire le tri, la fonction retourne une liste triée
