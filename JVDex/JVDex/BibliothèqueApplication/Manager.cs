using BibliothèqueApplication.Enums;
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
        private TypeTri typeTriJeuSelected;

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Propriété qui rend la liste des jeux, recherchés ou non, trié. Elle nous permet de faire une recherche et un tri sur la listes des jeux
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

                switch (TypeTriJeuSelected)
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

        /// <summary>
        /// permet de savoir quel est le type de tri sélectionné 
        /// </summary>
        public Dictionary<Franchise, List<Jeu>> ToutesLesFranchises { get => toutesLesFranchises; set => toutesLesFranchises = value; }
        public TypeTri TypeTriJeuSelected
        { 
            get => typeTriJeuSelected;
            set
            {
                if(typeTriJeuSelected != value)
                {
                    typeTriJeuSelected = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TousLesJeux")); //ça j'ai pas compris
                }
            }
        }

        public string DescriptionTypeTri => typeTriJeuSelected.ToDescription();


        /// <summary>
        /// propriété
        /// </summary>
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
        public IList<TypeTri> ListTypeTriJeu => new List<TypeTri>(Enum.GetValues(typeof(TypeTri)).Cast<TypeTri>());

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

        /// <summary>
        /// permet d'ajouter une franchise à la liste des franchises
        /// </summary>
        /// <param name="franchise">le nom de la franchise à ajouter si elle n'existe pas déjà</param>

        public void AjouterFranchise(Franchise franchise)
        {
            if (!toutesLesFranchises.Keys.Contains(franchise))
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
