using System;
using System.Collections.Generic;

namespace BibliothèqueApplication
{
    public class InformationsJeu:Nommable
    {
        private HashSet<Genres> lesGenres;
        private HashSet<Plateformes> lesPlateformes;
       // private string nomCreateur1; //pourquoi tu l'as mis ici? une propriété ne suffit pas?

       //PROPRIÉTÉS
        public static string NomCreateur { get; set; }
        public static DateTime DateCreation { get; set; }
        public static int LimiteAge { get; set; }
        public  string Sysnopsis { get; set; }

    }
}
// NomCreateur, DateCreation et LimiteAge en static

    //il faut une class par fichier les enums je les mets ailleurs

