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

        
        //je comprends pas trop ta méthode de tri, IEnumerable permet de remplacer une boucle foreach pour parcourir les éléments?
        // non pas du tout: en fait la méthode OrderBy() de LINQ renvoie un IEnumarable (sachant que IList implémente IEnumerable)
        
    
        
    }
}
//les jeux s'affichent bien sans la méthode de tri ça doit venir de là le problème
