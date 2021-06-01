using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{

    public class StockApp
    {
        private IList<Jeu> tousLesJeux;

        public IList<Jeu> TousLesJeux
        {
            get { return tousLesJeux; }
            set { tousLesJeux = value; }
        }

        private Dictionary<Franchise, List<Jeu>> toutesLesFranchises;

        public Dictionary<Franchise, List<Jeu>> ToutesLesFranchises
        {
            get { return toutesLesFranchises; }
            set { toutesLesFranchises = value; }
        }

        public StockApp()
        {
            tousLesJeux = new List<Jeu>();
            toutesLesFranchises = new Dictionary<Franchise, List<Jeu>>();
        }

        /// <summary>
        /// Permet d'ajouter un jeu à la liste de tous les jeux
        /// </summary>
        /// <param name="jeu">jeu à ajouter</param>
        /// <param name="franchise">franchise associée au jeu (créée si inexistante)</param>
        public void AjouterJeu(Jeu jeu, Franchise franchise)
        {
            bool contientJeu = false;
            foreach (var lJeu in toutesLesFranchises.Values)
            {
                if (lJeu.Contains(jeu))
                {
                    contientJeu = true;
                }
            }
            if (!tousLesJeux.Contains(jeu) && !contientJeu)
            {
                AjouterFranchise(franchise);

                tousLesJeux.Add(jeu);
                toutesLesFranchises[franchise].Add(jeu);
            }
        }

        /// <summary>
        /// permet d'ajouter une franchise à la liste des franchises
        /// </summary>
        /// <param name="franchise">le nom de la franchise à ajouter si elle n'existe pas déjà</param>

        public void AjouterFranchise(Franchise franchise)
        {
            if (!toutesLesFranchises.ContainsKey(franchise))
            {
                toutesLesFranchises.Add(franchise, new List<Jeu>());
            }
        }

        /// <summary>
        /// permet de supprimer un jeu à la liste des jeux
        /// </summary>
        /// <param name="jeu"> le jeu qui sera supprimer</param>
        /// <param name="franchise">la franchise correspondante au jeu supprimé</param>
        public void SupprimerJeu(Jeu jeu, Franchise franchise)
        {
            if (tousLesJeux.Contains(jeu) && toutesLesFranchises[franchise].Contains(jeu))
            {
                tousLesJeux.Remove(jeu);
                toutesLesFranchises[franchise].Remove(jeu);
            }
        }


        /// <summary>
        /// permet de supprimer une franchise de jeu ainsi que tous ses jeux correspondnat
        /// </summary>
        /// <param name="franchise">la franchise à supprimer </param>
        public void SupprimerFranchise(Franchise franchise)
        {
            if (toutesLesFranchises.ContainsKey(franchise))
            {
                foreach (var jeu in toutesLesFranchises[franchise])
                {
                    tousLesJeux.Remove(jeu);
                }
                toutesLesFranchises.Remove(franchise);
            }

        }
    }

}
