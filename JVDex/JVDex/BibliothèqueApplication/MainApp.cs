using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueApplication
{
    public class MainApp
    {
        public IList<Jeu> TousLesJeux { get; } = new List<Jeu>();
        public IList<Franchise> ToutesLesFranshises { get;} = new List<Franchise>();


        public void AjouterJeu(Jeu jeu)
        {
            if (TousLesJeux.Contains(jeu))
            {
                throw new ArgumentException("PB: ce jeu est déjà dans la liste des jeux");
            }
            TousLesJeux.Add(jeu);
        }
        public void AjouterFranshise(Franchise franchise)
        {
            if (ToutesLesFranshises.Contains(franchise))
            {
                throw new ArgumentException("PB: cette franchise est déjà dans la liste des franchises");
            }
            ToutesLesFranshises.Add(franchise);
        }

        public IList<Jeu> TrierLesJeuxPar(TypeTri type)
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
                        .OrderBy(jeu => jeu.Informations.NomCreateur)
                        .ThenBy(jeu => jeu.Informations.Nom);
                    break;
                default:
                    l = TousLesJeux.OrderBy(jeu => jeu.Informations.Nom);
                    break;
            }
            return l as IList<Jeu>;
        } 
    }
}
