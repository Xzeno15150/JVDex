using System;
using System.Collections.Generic;


namespace BibliothèqueApplication
{
    public class InformationsJeu : Nommable, IEquatable<InformationsJeu>
    {
        public ISet<Genres> LesGenres { get; }
        public ISet<Plateformes> LesPlateformes { get; }
        //PROPRIÉTÉS
        public CreateurJeu Createur { get; set; }
        public DateTime DateCreation { get; set; }
        public int LimiteAge { get; set; }
        public string Synopsis { get; set; }

        //Constructeur
        public InformationsJeu(string nom, CreateurJeu createur, DateTime dateCreation, int limiteAge, string synopsis) : base(nom)
        {
            this.Createur = createur;
            this.DateCreation = dateCreation;
            this.LimiteAge = limiteAge;
            this.Synopsis = synopsis;
            LesGenres = new HashSet<Genres>();
            LesPlateformes = new HashSet<Plateformes>();
        }

        public void AjouterGenre(Genres genre)
        {
            if (!LesGenres.Add(genre))
            {
                throw new ArgumentException("PB: ce genre est déjà dans la liste de genres");
            }
        }

        public void AjouterPlateforme(Plateformes plateforme)
        {
            if (!LesPlateformes.Add(plateforme))
            {
                throw new ArgumentException("PB: cette plateforme est déjà dans la liste des plateformes");
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
            foreach(Genres g in LesGenres)
            {
                mes += $"\t- {g}\n";
            }
            mes += "Plateformes : \n";
            foreach(Plateformes p in LesPlateformes)
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
            return Nom == other.Nom &&
                   Createur.Equals(other.Createur) &&
                   DateCreation == other.DateCreation &&
                   LimiteAge.Equals(other.LimiteAge) &&
                   Synopsis.Equals(other.Synopsis) &&
                   LesGenres.SetEquals(other.LesGenres) &&
                   LesPlateformes.SetEquals(other.LesPlateformes);
        }
    }
}
// pour afficher le genre et les plateformes il faut pas d'abord faire une recherche? vu que c'est une liste il faut afficher le genre qu'on a attribué non?
// je comprend pas la question la, on peut attribué plusieurs genres à un jeu, et ils sont stockés dans cette liste, c'est tout, comme pour les plateformes
// la "liste" de tous les genres c'est l'enum Genres, elle est pas ici. LesGenres c'est la liste des genres attribués (parce qu'un jeu peut avoir plusieurs genres)




