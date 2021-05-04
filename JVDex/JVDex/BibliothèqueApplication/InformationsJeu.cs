﻿using System;
using System.Collections.Generic;


namespace BibliothèqueApplication
{
    public class InformationsJeu : Nommable
    {
        private ISet<Genres> lesGenres;
        private ISet<Plateformes> lesPlateformes;
        //PROPRIÉTÉS
        public string NomCreateur { get; set; }
        public DateTime DateCreation { get; set; }
        public int LimiteAge { get; set; }
        public string Synopsis { get; set; }

        //Constructeur
        public InformationsJeu(string nom, string nomCreateur, DateTime dateCreation, int limiteAge, string synopsis) : base(nom)
        {
            this.NomCreateur = nomCreateur;
            this.DateCreation = dateCreation;
            this.LimiteAge = limiteAge;
            this.Synopsis = synopsis;
            lesGenres = new HashSet<Genres>();
            lesPlateformes = new HashSet<Plateformes>();
        }

        public void AjouterGenre(Genres genre)
        {
            if (!lesGenres.Add(genre))
            {
                throw new ArgumentException("PB: ce genre est déjà dans la liste de genres");
            }
        }

        public void AjouterPlateforme(Plateformes plateforme)
        {
            if (!lesPlateformes.Add(plateforme))
            {
                throw new ArgumentException("PB: cette plateforme est déjà dans la liste des plateformes");
            }
        }
        public override string ToString()
        {
            string mes = $"Nom du jeu: {Nom}\n";
            mes += $"Nom du créateur: {NomCreateur}\n";
            mes += $"Date de création: {DateCreation.ToString("dd/MM/yyyy")}\n";
            mes += $"Limite d'âge: {LimiteAge} ans\n";
            mes += $"Synopsis: {Synopsis}\n";
            mes += "Genres : \n";
            foreach(Genres g in lesGenres)
            {
                mes += $"\t- {g}\n";
            }
            mes += "Plateformes : \n";
            foreach(Plateformes p in lesPlateformes)
            {
                mes += $"\t- {p}\n";
            }
            return mes;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj is null) return false;
            if (GetType() != obj.GetType()) return false;

            InformationsJeu other = (InformationsJeu) obj;

            return NomCreateur == other.NomCreateur &&
                   DateCreation == other.DateCreation &&
                   LimiteAge == other.LimiteAge &&
                   Synopsis == other.Synopsis &&
                   lesGenres.SetEquals(other.lesGenres) &&
                   lesPlateformes.SetEquals(other.lesPlateformes);
        }


        public override int GetHashCode()
        {
            var hashCode = -1562044350;
            hashCode = hashCode * -1521134295 + EqualityComparer<ISet<Genres>>.Default.GetHashCode(lesGenres);
            hashCode = hashCode * -1521134295 + EqualityComparer<ISet<Plateformes>>.Default.GetHashCode(lesPlateformes);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NomCreateur);
            hashCode = hashCode * -1521134295 + DateCreation.GetHashCode();
            hashCode = hashCode * -1521134295 + LimiteAge.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Synopsis);
            return hashCode;
        }
    }
}
// pour afficher le genre et les plateformes il faut pas d'abord faire une recherche? vu que c'est une liste il faut afficher le genre qu'on a attribué non?




