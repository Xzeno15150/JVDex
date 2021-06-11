using BibliothèqueApplication;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StockApp sa = new StockApp(new Stub());
            sa.ChargeDonnees();
            Manager app = new Manager(sa);
            //Test_Trier_Jeux(app);
            //Test_Rechercher_Jeu(app);
            //Test_Afficher_Jeux(app);
            //Test_Afficher_Favoris(app);
            //Test_Ajouter_Favoris(app);
            //Test_Effacer_Favoris(app);
            //Test_Afficher_Franchise(app);
            Test_Afficher_Détail_Jeu(app);
        }

        //test pour trier les jeux

        private static void Test_Trier_Jeux(Manager app) 
        {
            

            Console.WriteLine("Comment voulez vous trié? ");
            Console.WriteLine("1) A-Z");
            Console.WriteLine("2) Z-A");
            Console.WriteLine("3) Les plus récents d'abord");
            Console.WriteLine("4) Les plus anciens d'abord");
            Console.WriteLine("5) Nom des créateur (A-Z)");

            var choix = Convert.ToInt32(Console.ReadLine());
            app.TypeTriJeuSelected = (TypeTri)choix;
            Test_Afficher_Jeux(app);

        }

        public static void Test_Afficher_Jeux(Manager mgr)
        {
            foreach(Jeu j in mgr.TousLesJeux)
            {
                Console.WriteLine($"- {j.Informations.Nom}");
            }
        }

        private static void Test_Afficher_Favoris(Manager app)
        {
            app.TypeTriJeuSelected = TypeTri.A_Z;
            foreach (var jeu in app.TousLesJeux.Where(jeu => jeu.IsFavoris)) 
            {
                Console.WriteLine($"- {jeu.Informations.Nom}");
            }
        }

        public static void Test_Ajouter_Favoris(Manager app)
        {
            Console.WriteLine($"Quel jeu ajouter aux favoris ? (1 à {app.TousLesJeux.Count})");

            var choix = Convert.ToInt32(Console.ReadLine()) - 1;
            app.TousLesJeux[choix].AjouterAuxFavoris();

            Test_Afficher_Favoris(app);
        }

        public static void Test_Effacer_Favoris(Manager app)
        {
            Console.WriteLine($"Quel jeu supprimer des favoris ? (1-{app.TousLesJeux.Where(jeu => jeu.IsFavoris).ToList().Count})");

            var choix = Convert.ToInt32(Console.ReadLine()) - 1;
            app.TousLesJeux.Where(jeu => jeu.IsFavoris).ToList()[choix].EnleverDesFavoris();
            Test_Afficher_Favoris(app);
        }

        private static void Test_Afficher_Détail_Jeu(Manager app)
        {
            Test_Afficher_Jeux(app);
            Test_Rechercher_Jeu(app);

            Console.WriteLine($"Quel jeu choissisez vous? (1-{app.TousLesJeux.Count})");
            var choix = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine(app.TousLesJeux[choix]);

        }

        private static void Test_Afficher_Franchise(Manager mgr)
        {
            foreach (var f in mgr.ToutesLesFranchises.Keys)
            {
                Console.WriteLine($"- {f.Nom}");
            }

            Console.WriteLine($"De quelle franchise voulez vous avoir le détail? (1-{mgr.ToutesLesFranchises.Keys.Count})");
            var choix = Convert.ToInt32(Console.ReadLine()) - 1;

            var franchise = mgr.ToutesLesFranchises.Keys.ToList()[choix];
            Console.WriteLine(franchise);
            Console.WriteLine("Liste des jeux : ");

            foreach (var j in mgr.ToutesLesFranchises[franchise])
            {
                Console.WriteLine(j);
            }
        }

        private static void Test_Rechercher_Jeu(Manager app)
        {
            Console.WriteLine("Donnez le nom à rechercher :");
            app.JeuRecherche = Console.ReadLine();
            app.TypeTriJeuSelected = TypeTri.A_Z;

            Test_Afficher_Jeux(app);
        }

    }
}
