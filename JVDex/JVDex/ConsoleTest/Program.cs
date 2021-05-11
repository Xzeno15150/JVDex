using BibliothèqueApplication;
using Data;
using System;
using System.Collections.Generic;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test_Trier_Jeux();
            Test_Rechercher_Jeu();
            //Test_Favoris();
            //Test_Franchise();
        }

        //test pour trier les jeux

        private static void Test_Trier_Jeux() 
        {
            MainApp app = Stub.Load();

            Console.WriteLine("Comment voulez vous trié? ");
            Console.WriteLine("1) A-Z");
            Console.WriteLine("2) Z-A");
            Console.WriteLine("3) Les plus récents d'abord");
            Console.WriteLine("4) Les plus anciens d'abord");
            Console.WriteLine("5) Nom des créateur (A-Z)");

            var choix = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(UtilsListes.GetLesJeuxTriés(app.TousLesJeux, (TypeTri)choix));

        }

        private static void Test_Favoris()
        {
            MainApp app = Stub.Load();
            Console.WriteLine(UtilsListes.GetLesFavoris(app.TousLesJeux));
            Console.WriteLine("=============================");
        }

        private static void Test_Franchise()
        {
            MainApp app = Stub.Load();
            Console.WriteLine(UtilsListes.GetLesFranchises(app.ToutesLesFranchises));
            Console.WriteLine(app.ToutesLesFranchises[0]);

        }

        private static void Test_Rechercher_Jeu()
        {
            Console.WriteLine("Donnez le nom à rechercher :");
            var texte = Console.ReadLine();

        }

    }
}
