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
       public Manager LeManager { get; set; } = new Manager(new StockApp ( new Stub()));
        public Navigator LeNavigateur { get; set; } = new Navigator();
    }
}
