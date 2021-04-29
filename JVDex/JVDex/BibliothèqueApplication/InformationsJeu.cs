using System;
using System.Collections.Generic;

namespace BibliothèqueApplication
{
    public class InformationsJeu:Nommable
    {
        private HashSet<Genres> lesGenres;
        private HashSet<Plateformes> lesPlateformes;
        private string nomCreateur1;

        enum Genres
        {
            Plateforme,
            RPG,
            FPS,
            Infiltration,
            Espionnage,
            Reflexe,
            Puzzle,
            Survival_Horror,
            Simulation,
            Stratégie,
            Sport
        }
        //TODO Verifier qu'il ne manque pas de genres
        enum Plateformes
        {
            PC,
            Playstation1,
            Playstation2,
            Playstation3,
            Playstation4,
            Playstation5
        }
        //TODO Faire l'enum des plateformes

        //PROPRIÉTÉS
        public string NomCreateur { get; set; }
        public DateTime DateCreation { get; set; }
        public int LimiteAge { get; set; }
        public string Sysnopsis { get; set; }

    }
}
