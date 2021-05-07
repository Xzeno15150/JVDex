using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueApplication
{
    public static class MainApp
    {
        public static IList<Jeu> TousLesJeux { get; private set; } = new List<Jeu>();
        public static IList<Franchise> ToutesLesFranchises { get; private set; } = new List<Franchise>();


        public static void AjouterJeu(Jeu jeu)
        {
            if (TousLesJeux.Contains(jeu))
            {
                throw new ArgumentException("PB: ce jeu est déjà dans la liste des jeux");
            }
            TousLesJeux.Add(jeu);
        }
        public static void AjouterFranchise(Franchise franchise)
        {
            if (ToutesLesFranchises.Contains(franchise))
            {
                throw new ArgumentException("PB: cette franchise est déjà dans la liste des franchises");
            }
            ToutesLesFranchises.Add(franchise);
        }

        public static void TrierLesJeuxPar(TypeTri type)
        {
            IEnumerable<Jeu> l;
            switch (type)
            {
                case TypeTri.Z_A:
                    l = TousLesJeux.OrderByDescending(jeu => jeu.Informations.Nom);
                    break;
                case TypeTri.Premier_Récents:
                    l = TousLesJeux
                        .OrderBy(jeu => jeu.Informations.DateCreation.Date)
                        .ThenBy(jeu => jeu.Informations.Nom);
                    break;
                case TypeTri.Premier_Anciens:
                    l = TousLesJeux
                        .OrderByDescending(jeu => jeu.Informations.DateCreation.Date)
                        .ThenBy(jeu => jeu.Informations.Nom);
                    break;
                case TypeTri.NomCréateur:
                    l = TousLesJeux
                        .OrderBy(jeu => jeu.Informations.Createur.Nom)
                        .ThenBy(jeu => jeu.Informations.Nom);
                    break;
                default:
                    l = TousLesJeux.OrderBy(jeu => jeu.Informations.Nom);
                    break;
            }
            TousLesJeux = l as IList<Jeu>;
        } 

        public static string AfficherTousLesJeux()
        {
            string mes = "Tous les jeux\n"; 
            foreach(Jeu j in TousLesJeux) // j'ai pas eu le temps de regarder pourquoi ça marche pas
            {
                mes += $"\t- {j.Informations.Nom}\n";
            }
            return mes;
        }
    }
}
