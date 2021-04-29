using System;
using System.Collections.Generic;

namespace BibliothèqueApplication
{
    public class InformationsJeu:Nommable
    {
        private HashSet<Genres> lesGenres;
        private HashSet<Plateformes> lesPlateformes;

        //TODO Constructeur
        public InformationsJeu()    //4 param + ne pas oublier instancier les HashSet
        {
            lesGenres = new HashSet<Genres>();
        }

       //PROPRIÉTÉS
        public string NomCreateur { get; set; }
        public DateTime DateCreation { get; set; }
        public int LimiteAge { get; set; }
        public string Sysnopsis { get; set; }

        public override string ToString()
        {
            string mes = $"Nom du jeu: {Nom}\n";
            mes += $"Nom du créateur: {NomCreateur}\n";
            //TODO ajouter à mes les informations restantes
            return mes;
        }

    }
}
// NomCreateur, DateCreation et LimiteAge en static



