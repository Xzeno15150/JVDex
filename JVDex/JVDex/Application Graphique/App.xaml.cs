using Application_Graphique.Nos_UC;
using BibliothèqueApplication;
using Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Application_Graphique
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Instance de PersistanceFichierTexte qui est la persistance utilisée
        /// </summary>
        public IPersistanceStockApp Pers { get; } = new PersistanceFichierTexte();
        private static StockApp sa;
        /// <summary>
        /// Propriété qui stocke le Manager utilisé dans l'application
        /// </summary>
        public Manager LeManager { get; set; }
        /// <summary>
        /// Propriété qui stocke le Navigator utilisé dans l'application
        /// </summary>
        public Navigator LeNavigateur { get; set; } = new Navigator();
        /// <summary>
        /// Constructeur de App, appelé au lancement de l'application.
        /// Il permet de charger les données depuis le fichier texte JVDex.txt
        /// </summary>
        public App()
        {
            sa = new StockApp(Pers);
            sa.ChargeDonnees();
            LeManager = new Manager(sa);
        }
    }
}
