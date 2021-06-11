using BibliothèqueApplication.Enums;
using System;
using System.Collections.Generic;


namespace BibliothèqueApplication
{
    public class InformationsJeu : Nommable, IEquatable<InformationsJeu>
    {
        private DateTime dateCreation;

        public ISet<Genres> LesGenres { get; }
        public List<string> LesGenresToString
        {
            get
            {
                List<string> lSGenres = new List<string>();
                foreach(Genres g in LesGenres)
                {
                    lSGenres.Add(g.ToDescription() + " ");
                }
                return lSGenres;
            }
        }

        public List<string> LesPlateformesToString
        {
            get
            {
                List<string> lSPlateformes = new List<string>();
                foreach (Plateformes p in LesPlateformes)
                {
                    lSPlateformes.Add(p.ToDescription() + " ");
                }
                return lSPlateformes;
            }
        }
        public ISet<Plateformes> LesPlateformes { get; }
      
        public CreateurJeu Createur { get; set; }

        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public int LimiteAge { get; set; }
        public string Synopsis { get; set; }


        public InformationsJeu(string nom, CreateurJeu createur, DateTime dateCreation, int limiteAge, string synopsis) 
            : this(nom, createur, dateCreation, limiteAge, synopsis, new HashSet<Genres>(), new HashSet<Plateformes>())
        {
        }
        public InformationsJeu(string nom, CreateurJeu createur, DateTime dateCreation, int limiteAge, string synopsis, ISet<Genres> genres, ISet<Plateformes> plateformes) : base(nom)
        {
            this.Createur = createur;
            this.DateCreation = dateCreation;
            this.LimiteAge = limiteAge;
            this.Synopsis = synopsis;
            LesGenres = genres;
            LesPlateformes = plateformes;
        }


        /// <summary>
        /// permet d'ajouter un genre correspondant au jeu, celui-ci ne peut pas être écrit deux fois. Nous utilisons un enum pour récupérer le genre 
        /// </summary>
        /// <param name="genre"> le genre à ajouter</param>
        public void AjouterGenre(Genres genre)
        {
            if (!LesGenres.Add(genre))
            {
                throw new ArgumentException("PB: ce genre est déjà dans la liste de genres");
            }
        }

        /// <summary>
        /// supprimer un genre à la liste des genres, il doit exister pour le supprimer
        /// </summary>
        /// <param name="genre">genre à supprimer</param>
        public void SupprimerGenre(Genres genre)
        {
            if (!LesGenres.Remove(genre))
            {
                throw new ArgumentException("PB: ce genre n'est plus sur la liste");
            }
        }

        //
        //

        /// <summary>
        /// permet d'ajouter uns plateforme correspondante au jeu, celle-ci ne peut pas être écrite deux fois. Nous utilisons un enum pour récupérer la plateforme
        /// </summary>
        /// <param name="plateforme"> la plateforme à ajouter</param>
        public void AjouterPlateforme(Plateformes plateforme)
        {
            if (!LesPlateformes.Add(plateforme))
            {
                throw new ArgumentException("PB: cette plateforme est déjà dans la liste des plateformes");
            }
        }

        /// <summary>
        /// permet de supprimer une plateforme de la liste des plateformes, doit déjà exister pour être supprimé
        /// </summary>
        /// <param name="plateforme">la plateforme à supprimer</param>
        public void SupprimerPlateforme(Plateformes plateforme)
        {
            if (!LesPlateformes.Remove(plateforme))
            {
                throw new ArgumentException("PB: cette plateforme n'est plus sur la liste");
            }
        }

        public override string ToString()
        {
            string mes = $"Nom du jeu: {Nom}\n";
            mes += $"Nom du créateur: {Createur}\n";
            mes += $"Date de création: {DateCreation.ToString("dd/MM/yyyy")}\n";
            mes += $"Limite d'âge: {LimiteAge} ans\n";
            mes += $"Synopsis: {Synopsis}\n";
            mes += "Genres : \n";
            foreach (Genres g in LesGenres)
            {
                mes += $"\t- {g}\n";
            }
            mes += "Plateformes : \n";
            foreach (Plateformes p in LesPlateformes)
            {
                mes += $"\t- {p}\n";
            }
            return mes;
        }


        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (!GetType().Equals(obj.GetType())) return false;

            InformationsJeu other = obj as InformationsJeu;

            return Equals(other);
        }


        public override int GetHashCode()
        {
            var hashCode = -1562044350;
            hashCode = hashCode * -1521134295 + EqualityComparer<ISet<Genres>>.Default.GetHashCode(LesGenres);
            hashCode = hashCode * -1521134295 + EqualityComparer<ISet<Plateformes>>.Default.GetHashCode(LesPlateformes);
            hashCode = hashCode * -1521134295 + EqualityComparer<CreateurJeu>.Default.GetHashCode(Createur);
            hashCode = hashCode * -1521134295 + DateCreation.GetHashCode();
            hashCode = hashCode * -1521134295 + LimiteAge.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Synopsis);
            return hashCode;
        }

        public bool Equals(InformationsJeu other)
        {
            if (other is null) return false;
            return Nom.Equals(other.Nom)&&
                   Createur.Equals(other.Createur) &&
                   DateCreation.Equals(other.DateCreation) &&
                   LimiteAge.Equals(other.LimiteAge) &&
                   Synopsis.Equals(other.Synopsis) &&
                   LesGenres.SetEquals(other.LesGenres) &&
                   LesPlateformes.SetEquals(other.LesPlateformes);
        }
    }
}


