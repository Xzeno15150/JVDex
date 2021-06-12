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
        private Franchise franchiseSelected;
        private Jeu jeuSelected;

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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TousLesJeux"));
                }
            }
        }

        public string TypeTriJeuSelectedToString 
        {
            get
            {
                return typeTriJeuSelected.ToDescription();
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

        public Jeu JeuSelected
        {
            get => jeuSelected;
            set
            {
                jeuSelected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("JeuSelected"));
               
            }
        }
        public IList<TypeTri> ListTypeTriJeux => new List<TypeTri>(Enum.GetValues(typeof(TypeTri)).Cast<TypeTri>());

        public Franchise FranchiseSelected
        {
            get => franchiseSelected; 
            set 
            { 
                franchiseSelected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FranchiseSelected"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("JeuxDeLaFranchiseSelected"));
            }
        }

        public IList<Jeu> JeuxDeLaFranchiseSelected
        {
            get
            {
                 if(franchiseSelected != null) return ToutesLesFranchises[franchiseSelected];
                return null;
            }
        }

        public Manager(StockApp stockApp)
        {
            tousLesJeux = stockApp.TousLesJeux;
            toutesLesFranchises = stockApp.ToutesLesFranchises;
        }
    }
}

//pour faire un changement sur un dico, n'entend pas les notifsmettre à null le dataContetxt pour le re activer    return new Collection (d.keys) -> créé une autre collection (je prends en note ce que fais le prof je ne pense pas que ça nous sera utile)
