using BibliothèqueApplication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BibliothèqueApplication
{
    public static class UtilsListes
    {
        public static string GetLesJeuxTriés(IList<Jeu> lesJeuxNonTries, TypeTri type)
        {
            IList<Jeu> lesJeux = TrierLesJeuxPar(lesJeuxNonTries, type);
            string mes = $"Les jeux triés par {type.ToDescription()}\n"; 

            foreach (Jeu j in lesJeux)
            {
                mes += $"\t- {j.Informations.Nom} ({j.Informations.Createur}, {j.Informations.DateCreation})\n";
            }
            return mes;
        }
        //permet de retourner une liste de jeux triés. La méthode prend en paramettre la liste de tous les jeux non triés et le type de tri
        //le type de tri se trouve dans un enum, il est associé à un tri dans la méthode TrierLesJeuxPar

        public static string GetLesFranchises(IList<Franchise> lesFranchises)
        {
            string mes = "Toutes les franchises\n";
            foreach (Franchise f in lesFranchises)
            {
                mes += $"\t- {f.Nom}\n";
            }
            return mes;
        }
        //retourne la liste des franchises

        public static string GetLesFavoris(IList<Jeu> lesJeux)
        {
            string mes = "Tous les favoris\n";
            foreach (Jeu j in lesJeux.Where(jeu => jeu.IsFavoris == true))
            {
                mes += $"\t{j.Informations}\n";
            }
            return mes;
        }
        //retourne la liste des favoris
        private static IList<Jeu> TrierLesJeuxPar(IList<Jeu> lesJeux,TypeTri type)
        {
            switch (type)
            {
                case TypeTri.Z_A:
                    return lesJeux.OrderByDescending(jeu => jeu.Informations.Nom).ToList();

                case TypeTri.Premier_Anciens:
                    return lesJeux
                       .OrderBy(jeu => jeu.Informations.DateCreation.Date)
                       .ThenBy(jeu => jeu.Informations.Nom)
                       .ToList();

                case TypeTri.Premier_Récents:
                    return lesJeux
                        .OrderByDescending(jeu => jeu.Informations.DateCreation.Date)
                        .ThenBy(jeu => jeu.Informations.Nom)
                        .ToList();
                case TypeTri.NomCréateur:
                    return lesJeux
                        .OrderBy(jeu => jeu.Informations.Createur.Nom)
                        .ThenBy(jeu => jeu.Informations.Nom)
                        .ToList();
                default:
                    return lesJeux.OrderBy(jeu => jeu.Informations.Nom).ToList();

            }
        }
        //retourne une liste de jeux triés

        public static IList<Jeu> RechercheDesJeuxDeLaListe(IList<Jeu> lesJeux, string jeu)
        {
            IList<Jeu> JeuxRecherchés = new List<Jeu>() ;
            foreach(Jeu j in lesJeux)
            {
                if (j.Informations.Nom.ToLower().Contains(jeu.ToLower()))
                {
                    JeuxRecherchés.Add(j);
                }
            }
            return JeuxRecherchés;
        }
        //permet de faire une recherche pour trouver un jeu
            
        
    }
}