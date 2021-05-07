using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueApplication
{
    public static class UtilsListes
    {
        public static string AfficherLesJeux(IList<Jeu> lesJeuxNonTries, TypeTri type)
        {
            IList<Jeu> lesJeux = TrierLesJeuxPar(lesJeuxNonTries, type);
            string mes = $"Les jeux trié par {type}\n";

            foreach (Jeu j in lesJeux) // j'ai pas eu le temps de regarder pourquoi ça marche pas 
            {
                mes += $"\t- {j.Informations.Nom} ({j.Informations.Createur})\n";
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
        public static IList<Jeu> TrierLesJeuxPar(IList<Jeu> lesJeux,TypeTri type)
        {
            switch (type)
            {
                case TypeTri.Z_A:
                    return lesJeux.OrderByDescending(jeu => jeu.Informations.Nom).ToList();

                case TypeTri.Premier_Récents:
                    return lesJeux
                       .OrderBy(jeu => jeu.Informations.DateCreation.Date)
                       .ThenBy(jeu => jeu.Informations.Nom)
                       .ToList();

                case TypeTri.Premier_Anciens:
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
    }
}
