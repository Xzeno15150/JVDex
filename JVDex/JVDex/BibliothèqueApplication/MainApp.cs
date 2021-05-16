using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliothèqueApplication
{
    public class MainApp
    {
        private IList<Jeu> tousLesJeux;
        

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
        public IList<Franchise> ToutesLesFranchises { get; set; }
        public TypeTri TypeTriJeu { get; set; }
        public string JeuRecherche { get;  set; }

        public MainApp()
        {
            tousLesJeux = new List<Jeu>();
            ToutesLesFranchises = new List<Franchise>();
        }

        //permet d'ajouter un jeu à la liste de tous les jeux
        public void AjouterJeu(Jeu jeu)
        {
            if (tousLesJeux.Contains(jeu))
            {
                throw new ArgumentException("PB: ce jeu est déjà dans la liste des jeux");
            }
            tousLesJeux.Add(jeu);
        }

        //permet de supprimer  un jeu à la liste de tous les jeux
        public void SupprimerJeu(Jeu jeu)
        {
            if (!tousLesJeux.Contains(jeu))
            {
                throw new ArgumentException("PB: ce jeu n'est déjà plus dans la liste des jeux");
            }
            tousLesJeux.Remove(jeu);
        }

        //permet d'ajouter une franchise à la liste de toutes les franchises
        public void AjouterFranchise(Franchise franchise)
        {
            if (ToutesLesFranchises.Contains(franchise))
            {
                throw new ArgumentException("PB: cette franchise est déjà dans la liste des franchises");
            }
            ToutesLesFranchises.Add(franchise);
        }
        //permet de supprimer  un jeu à la liste de tous les jeux
        public void SupprimerFranchise(Franchise franchise)
        {
            if (!ToutesLesFranchises.Contains(franchise))
            {
                throw new ArgumentException("PB: ce jeu n'est déjà plus dans la liste des jeux");
            }
            ToutesLesFranchises.Remove(franchise);
        }

    }
}
