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
        private static IPersistanceStockApp pers = new Stub();
        private static StockApp sa = new StockApp(pers);
        public Manager LeManager { get; set; } 
        public Navigator LeNavigateur { get; set; } = new Navigator();

        public App()
        {
            sa.ChargeDonnees();
            LeManager = new Manager(sa);
        }
    }
}
