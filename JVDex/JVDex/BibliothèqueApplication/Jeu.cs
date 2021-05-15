
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public class Jeu : IEquatable<Jeu>
    {
        public string Vignette { get; set; }
        public ISet<string> LesVisuels { get; private set;}
        public ISet<string> LesMusiques { get; private set; }
        public ISet<Theorie> LesTheories { get; private set; }

        //Propriétés
        public InformationsJeu Informations { get; set; }
        public bool IsFavoris { get; private set; } //permet de savoir si jeu est en favoris
        public Jeu(string nom, CreateurJeu createur, DateTime dateCreation, int limiteAge, string synopsis, string image)
        {
            Informations = new InformationsJeu(nom, createur, dateCreation, limiteAge, synopsis); //utilisation de la class InformationsJeu pour récupérer les informations du jeu correspondante
            LesVisuels = new HashSet<string>();
            LesMusiques = new HashSet<string>();
            LesTheories = new HashSet<Theorie>();
            Vignette = image;
        }

        //les deux méthodes (AjouterAuxFavoris et EnleverDesFavoris) permettent de mettre le jeu en favoris ou non
        public void AjouterAuxFavoris()
        {
            IsFavoris = true;
        }

        public void EnleverDesFavoris()
        {
            IsFavoris = false;
        }

        //ajouter des visuels à la liste des visuels
        public void AjouterVisuel(string visuel)
        {
            if (!LesVisuels.Add(visuel))
            {
                throw new ArgumentException("PB: cette image est déjà dans la liste des visuels");
            }
        }

        //ajouter des musiques à la liste des musiques
        public void AjouterMusique(string musique)
        {
            if (!LesMusiques.Add(musique))
            {
                throw new ArgumentException("PB: cette musique est déjà dans la liste des musiques");
            }
        }
        
      //ajouter des théories à la liste des théories
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
            mes += $"Vignette du Jeu : {Vignette}\n";
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
