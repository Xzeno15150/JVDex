using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueApplication
{
    public class MainApp
    {
        private IList<Jeu> tousLesJeux;
        private Dictionary<Franchise, List<Jeu>> toutesLesFranchises;


        //liste de tous les jeux de l'application
        public IList<Jeu> TousLesJeux
        {
            get
            {

                IList<Jeu> JeuxRecherchés = new List<Jeu>();
                if (String.IsNullOrEmpty(JeuRecherche))
                {
                    JeuxRecherchés = tousLesJeux;
                }
                else
                {
                    foreach (Jeu j in tousLesJeux)
                    {
                        if (j.Informations.Nom.ToLower().Contains(JeuRecherche.ToLower()))
                        {
                            JeuxRecherchés.Add(j);
                        }
                    }
                }

                switch (TypeTriJeu)
                {
                    case TypeTri.Z_A:
                        return JeuxRecherchés.OrderByDescending(jeu => jeu.Informations.Nom).ToList();

                    case TypeTri.Premier_Anciens:
                        return JeuxRecherchés
                           .OrderBy(jeu => jeu.Informations.DateCreation.Date)
                           .ThenBy(jeu => jeu.Informations.Nom)
                           .ToList();

                    case TypeTri.Premier_Récents:
                        return JeuxRecherchés
                            .OrderByDescending(jeu => jeu.Informations.DateCreation.Date)
                            .ThenBy(jeu => jeu.Informations.Nom)
                            .ToList();
                    case TypeTri.NomCréateur:
                        return JeuxRecherchés
                            .OrderBy(jeu => jeu.Informations.Createur.Nom)
                            .ThenBy(jeu => jeu.Informations.Nom)
                            .ToList();
                    default:
                        return JeuxRecherchés.OrderBy(jeu => jeu.Informations.Nom).ToList();

                }

            }

            set => tousLesJeux = value;
        }

        //liste de toutes les franchises
        public Dictionary<Franchise, List<Jeu>> ToutesLesFranchises { get => toutesLesFranchises; set => toutesLesFranchises = value; }
        public TypeTri TypeTriJeu { get; set; }
        public string JeuRecherche { get; set; }

        public MainApp()
        {
            tousLesJeux = new List<Jeu>();
            ToutesLesFranchises = new Dictionary<Franchise, List<Jeu>>();
        }

        //permet d'ajouter un jeu à la liste de tous les jeux
        public void AjouterJeu(Jeu jeu, Franchise franchise)
        {
            if (tousLesJeux.Contains(jeu))
            {
                throw new ArgumentException("PB: ce jeu est déjà dans la liste des jeux");
            }
            if (!toutesLesFranchises.ContainsKey(franchise))
            {
                toutesLesFranchises.Add(franchise, new List<Jeu>());
            }
            if (toutesLesFranchises[franchise].Contains(jeu))
            {
                throw new ArgumentException($"PB: ce jeu est déjà dans la franchise {franchise.Nom}");
            }
            
            tousLesJeux.Add(jeu);
            toutesLesFranchises[franchise].Add(jeu);
        }

        //permet de supprimer un jeu à la liste de tous les jeux
        public void SupprimerJeu(Jeu jeu, Franchise franchise)
        {
            if (!tousLesJeux.Contains(jeu))
            {
                throw new ArgumentException("PB: ce jeu n'est déjà plus dans la liste des jeux");
            }
            if (!toutesLesFranchises[franchise].Contains(jeu))
            {
                throw new ArgumentException($"PB: ce jeu n'est déjà plus dans la liste des jeux de la franchise {franchise.Nom}");
            }
            tousLesJeux.Remove(jeu);
            toutesLesFranchises[franchise].Remove(jeu);
        }


        // permet de supprimer une franchise ainsi que tous les jeux associés
        public void SupprimerFranchise(Franchise franchise)
        {
            if (!toutesLesFranchises.ContainsKey(franchise))
            {
                throw new ArgumentException("PB: cette franchise n'existe pas dans le dictionnaire, supression impossible");
            }
            foreach (var jeu in toutesLesFranchises[franchise])
            {
                tousLesJeux.Remove(jeu);
            }
            toutesLesFranchises.Remove(franchise);
        }

        

    }
}
