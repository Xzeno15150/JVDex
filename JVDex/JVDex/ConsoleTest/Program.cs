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
            MainApp app = Stub.Load();
            //Test_Trier_Jeux(app);
            //Test_Rechercher_Jeu(app);
            Test_Afficher_Favoris(app);
            Test_Ajouter_Favoris(app);
            //Test_Afficher_Franchise(app);
            //Test_Afficher_Détail_Jeu(app);
        }

        //test pour trier les jeux

        private static void Test_Trier_Jeux(MainApp app) 
        {
            

            Console.WriteLine("Comment voulez vous trié? ");
            Console.WriteLine("1) A-Z");
            Console.WriteLine("2) Z-A");
            Console.WriteLine("3) Les plus récents d'abord");
            Console.WriteLine("4) Les plus anciens d'abord");
            Console.WriteLine("5) Nom des créateur (A-Z)");

            var choix = Convert.ToInt32(Console.ReadLine());
            app.TypeTriJeu = (TypeTri)choix;
            foreach(var jeu in app.TousLesJeux)
            {
                Console.WriteLine($"- {jeu.Informations.Nom}");
            }

        }

        private static void Test_Afficher_Favoris(MainApp app)
        {
            app.TypeTriJeu = TypeTri.A_Z;
            foreach (var jeu in app.TousLesJeux.Where(jeu => jeu.IsFavoris)) 
            {
                Console.WriteLine($"- {jeu.Informations.Nom}");
            }
        }

        public static void Test_Ajouter_Favoris(MainApp app)
        {
            Console.WriteLine($"Quel jeu ajouter aux favoris ? (1 à {app.TousLesJeux.Count})");

            var choix = Convert.ToInt32(Console.ReadLine()) - 1;
            app.TousLesJeux[choix].AjouterAuxFavoris();

            Test_Afficher_Favoris(app);
        }

        private static void Test_Afficher_Détail_Jeu(MainApp app)
        {
            Console.WriteLine("Donnez le nom à rechercher :");
            app.JeuRecherche = Console.ReadLine();
            app.TypeTriJeu = TypeTri.A_Z;
            Console.WriteLine(app.TousLesJeux);

            Console.WriteLine($"Quel jeu choissisez vous? (1-{app.TousLesJeux.Count})");
            var choix = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine(app.TousLesJeux[choix]);

        }

        private static void Test_Afficher_Franchise(MainApp app)
        {
            //Console.WriteLine(UtilsListes.GetLesFranchises(app.ToutesLesFranchises));
            //Console.WriteLine(app.ToutesLesFranchises[0]);

        }

        private static void Test_Rechercher_Jeu(MainApp app)
        {
            Console.WriteLine("Donnez le nom à rechercher :");
            app.JeuRecherche = Console.ReadLine();
            app.TypeTriJeu = TypeTri.A_Z;

            foreach (var jeu in app.TousLesJeux)
            {
                Console.WriteLine($"- {jeu.Informations.Nom}");
            }
        }

    }
}
