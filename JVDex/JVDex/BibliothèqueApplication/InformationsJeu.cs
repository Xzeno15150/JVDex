using System;
using System.Collections.Generic;


namespace BibliothèqueApplication
{
    public class InformationsJeu:Nommable
    {
        private HashSet<Genres> lesGenres;
        private HashSet<Plateformes> lesPlateformes;
        //PROPRIÉTÉS
        public string NomCreateur { get; set; }
        public DateTime DateCreation { get; set; }
        public int LimiteAge { get; set; }
        public string Sysnopsis { get; set; }

        //TODO Constructeur
        public InformationsJeu(string nom, string nomCreateur, DateTime dateCreation, int limiteAge, string synopsis) : base(nom)    //4 param + ne pas oublier instancier les HashSet
        {
            this.NomCreateur = nomCreateur;
            this.DateCreation = dateCreation;
            this.LimiteAge = limiteAge;
            this.Sysnopsis = synopsis;
            lesGenres = new HashSet<Genres>();
            lesPlateformes = new HashSet<Plateformes>();
        }

      /*  public void AjouterGenre (Genres genres)
        {
            genres.Add(Genres);
        }

        public void AjouterPlateforme (Plateformes plateformes)
        {

        }
        */
        // je ne vois pas du tout comment faire pour uriliser les enums
        public override string ToString()
        {
            string mes = $"Nom du jeu: {Nom}\n";
            mes += $"Nom du créateur: {NomCreateur}\n";
            mes += $"Date de création: {DateCreation}\n";
            mes += $"Limite d'âge: {LimiteAge}\n";
            mes += $"Synopsis: {Sysnopsis}\n";

            //TODO ajouter à mes les informations restantes qui sont Genre et Plateforme 
            return mes;
        }

    }
}
// pour afficher le genre et les plateformes il faut pas d'abord faire une recherche? vu que c'est une liste il faut afficher le genre qu'on a attribué non?




