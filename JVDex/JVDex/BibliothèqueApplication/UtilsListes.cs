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
        public static string AfficherLesJeuxTriés(IList<Jeu> lesJeuxNonTries, TypeTri type)
        {
            IList<Jeu> lesJeux = TrierLesJeuxPar(lesJeuxNonTries, type);
            string mes = $"Les jeux triés par {type.ToDescription()}\n"; 

            foreach (Jeu j in lesJeux)
            {
                mes += $"\t- {j.Informations.Nom} ({j.Informations.Createur}, {j.Informations.DateCreation})\n";
            }
            return mes;
        }

        public static string AfficherLesFranchises(IList<Franchise> lesFranchises)
        {
            string mes = "Toutes les franchises\n";
            foreach (Franchise f in lesFranchises)
            {
                mes += $"\t- {f.Nom}\n";
            }
            return mes;
        }

        public static string AfficherLesFavoris(IList<Jeu> lesJeux)
        {
            string mes = "Tous les favoris\n";
            foreach (Jeu j in lesJeux.Where(jeu => jeu.IsFavoris == true))
            {
                mes += $"\t{j.Informations}\n";
            }
            return mes;
        }
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

      /*  private static IList<Jeu> Rechercher(IList<Jeu> lesJeux, string jeu)
        {
            IList<Jeu> JeuxRecherchés = new List<Jeu>() ;
            foreach(Jeu j in lesJeux)
            {
                if( lesJeux )
            }
            */

            
        
    }
}