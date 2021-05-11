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
            Test_Trier_Jeux();
            Test_Favoris();
            Test_Franchise();
        }

        //test pour trier les jeux

        private static void Test_Trier_Jeux() 
        {
            MainApp app = Stub.Load();
            Console.WriteLine(UtilsListes.AfficherLesJeuxTriés(app.TousLesJeux, TypeTri.A_Z)); //appel de la méthode de tri dans la class UtilsList
            Console.WriteLine("=============================");
            Console.WriteLine(UtilsListes.AfficherLesJeuxTriés(app.TousLesJeux, TypeTri.Z_A));
            Console.WriteLine("=============================");
            Console.WriteLine(UtilsListes.AfficherLesJeuxTriés(app.TousLesJeux, TypeTri.NomCréateur));
            Console.WriteLine("=============================");
            Console.WriteLine(UtilsListes.AfficherLesJeuxTriés(app.TousLesJeux, TypeTri.Premier_Anciens));
            Console.WriteLine("=============================");
            Console.WriteLine(UtilsListes.AfficherLesJeuxTriés(app.TousLesJeux, TypeTri.Premier_Récents));
            Console.WriteLine("=============================");
        }

        private static void Test_Favoris()
        {
            MainApp app = Stub.Load();
            Console.WriteLine(UtilsListes.AfficherLesFavoris(app.TousLesJeux));
            Console.WriteLine("=============================");
        }

        private static void Test_Franchise()
        {
            MainApp app = Stub.Load();
            Console.WriteLine(UtilsListes.AfficherLesFranchises(app.ToutesLesFranchises));
            Console.WriteLine(app.ToutesLesFranchises[0]);

        }

    }
}
