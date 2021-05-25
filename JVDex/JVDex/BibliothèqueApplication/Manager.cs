using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BibliothèqueApplication
{
    public class Manager : INotifyPropertyChanged
    {
        private IList<Jeu> tousLesJeux;
        private Dictionary<Franchise, List<Jeu>> toutesLesFranchises;
        private string jeuRecherche;
        private TypeTri typeTriJeu;

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Propriété qui rend la liste des jeux, recherchés ou non, trié
        /// </summary>
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
        public TypeTri TypeTriJeuSelected
        { 
            get => typeTriJeu;
            set
            {
                if(typeTriJeu != value)
                {
                    typeTriJeu = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TousLesJeux"));
                }
            }
        }
        public string JeuRecherche
        {
            get => jeuRecherche;
            set
            {
                if (jeuRecherche != value)
                {
                    jeuRecherche = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TousLesJeux"));
                }

            }
        }
        public IList<TypeTri> ListTypeTriJeux => new List<TypeTri>(Enum.GetValues(typeof(TypeTri)).Cast<TypeTri>());

        public Manager()
        {
            tousLesJeux = new List<Jeu>();
            ToutesLesFranchises = new Dictionary<Franchise, List<Jeu>>();
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

        public void AjouterFranchise(Franchise franchise)
        {
            if (!toutesLesFranchises.Keys.Contains(franchise))
            {
                toutesLesFranchises.Add(franchise, new List<Jeu>());
            }
        }

        //permet de supprimer un jeu à la liste de tous les jeux
        public void SupprimerJeu(Jeu jeu, Franchise franchise)
        {
            if (tousLesJeux.Contains(jeu) && toutesLesFranchises[franchise].Contains(jeu))
            {
                tousLesJeux.Remove(jeu);
                toutesLesFranchises[franchise].Remove(jeu);
            }
        }


        // permet de supprimer une franchise ainsi que tous les jeux associés
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
