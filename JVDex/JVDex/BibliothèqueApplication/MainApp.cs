using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueApplication
{
    public class MainApp
    {
        public IList<Jeu> TousLesJeux { get; private set; }
        public IList<Franchise> ToutesLesFranchises { get; private set; }

        public MainApp()
        {
            TousLesJeux = new List<Jeu>();
            ToutesLesFranchises = new List<Franchise>();
        }

        public void AjouterJeu(Jeu jeu)
        {
            if (TousLesJeux.Contains(jeu))
            {
                throw new ArgumentException("PB: ce jeu est déjà dans la liste des jeux");
            }
            TousLesJeux.Add(jeu);
        }
        public void AjouterFranchise(Franchise franchise)
        {
            if (ToutesLesFranchises.Contains(franchise))
            {
                throw new ArgumentException("PB: cette franchise est déjà dans la liste des franchises");
            }
            ToutesLesFranchises.Add(franchise);
        }
    }
}
