
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

      
        public InformationsJeu Informations { get; set; }

        /// <summary>
        /// ce boolean permet de savoir si le jeu est mis en favoris ou non: true quand il est en favoris, false quand il ne l'est pas
        /// </summary>
        public bool IsFavoris { get; private set; }

        /// <summary>
        /// utilisation de la class InformationsJeu pour récupérer les informations du jeu correspondante
        /// </summary>
        /// <param name="nom"> nom du jeu </param>
        /// <param name="createur"> nom du créateur </param>
        /// <param name="dateCreation"> la date de création du jeu </param>
        /// <param name="limiteAge"> la limite d'âge attribué au jeu </param>
        /// <param name="synopsis"> le synopsis du jeu </param>
        /// <param name="image"> l'image associée au jeu </param>
        public Jeu(string nom, CreateurJeu createur, DateTime dateCreation, int limiteAge, string synopsis, string image)
        {
            Informations = new InformationsJeu(nom, createur, dateCreation, limiteAge, synopsis); //
            LesVisuels = new HashSet<string>();
            LesMusiques = new HashSet<string>();
            LesTheories = new HashSet<Theorie>();
            Vignette = image;
        }

        /// <summary>
        /// permet de mettre un jeu en favoris
        /// </summary>
        public void AjouterAuxFavoris()
        {
            IsFavoris = true;
        }

        /// <summary>
        /// permet d'enlever un jeu en favoris
        /// </summary>
        public void EnleverDesFavoris()
        {
            IsFavoris = false;
        }

        /// <summary>
        /// ajoute des visuels, images, à la liste des visuels. Ne peut pas en ajouter deux identiques
        /// </summary>
        /// <param name="visuel"> visuels à ajouter </param>
        public void AjouterVisuel(string visuel)
        {
            if (!LesVisuels.Add(visuel))
            {
                throw new ArgumentException("PB: cette image est déjà dans la liste des visuels");
            }
        }

        /// <summary>
        /// supprime un visuels à la liste des visuels
        /// </summary>
        /// <param name="visuel"> le visuel à supprimer </param>
        public void SupprimerVisuel(string visuel)
        {
            if (!LesVisuels.Remove(visuel))
            {
                throw new ArgumentException("PB: ce visuel n'est plus sur la liste");
            }
        }

        /// <summary>
        /// ajoute une musique à la liste des musiques, ne peut pas ajouter deux musiques identiques
        /// </summary>
        /// <param name="musique"> musique à ajouter </param>
        public void AjouterMusique(string musique)
        {
            if (!LesMusiques.Add(musique))
            {
                throw new ArgumentException("PB: cette musique est déjà dans la liste des musiques");
            }
        }

       /// <summary>
       /// supprime une musique que de liste
       /// </summary>
       /// <param name="musique"> la musique à supprimer </param>
        public void SupprimerMusique(string musique)
        {
            if (!LesMusiques.Remove(musique))
            {
                throw new ArgumentException("PB: cette musique n'est plus sur la liste");
            }
        }

        //ajouter des théories à la liste des théories
        /// <summary>
        /// ajouter une théorie à la liste des théories, elle ne peut être qu'unique
        /// </summary>
        /// <param name="theorie"> la théorie à ajouter de type Théorie</param>
        public void AjouterTheorie(Theorie theorie)
        {
            if (!LesTheories.Add(theorie))
            {
                throw new ArgumentException("PB: cette théorie est déjà dans la liste des théories.");
            }
        }

       /// <summary>
       /// supprime une théorie de la liste
       /// </summary>
       /// <param name="theorie"> la théorie correspondnate </param>
        public void SupprimerTheorie(Theorie theorie)
        {
            if (!LesTheories.Remove(theorie))
            {
                throw new ArgumentException("PB: cette théorie n'est plus sur la liste");
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

        public bool Equals(Jeu other)
        {
            if (other is null) return false;
            return Informations.Equals(other.Informations) && Vignette == other.Vignette;
        }

        public override int GetHashCode()
        {
            int hashCode = -74474083;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Vignette);
            hashCode = hashCode * -1521134295 + EqualityComparer<InformationsJeu>.Default.GetHashCode(Informations);
            return hashCode;
        }
    }
}
