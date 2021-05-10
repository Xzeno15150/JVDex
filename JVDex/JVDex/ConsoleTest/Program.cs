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
        }

        private static void Test_Trier_Jeux()
        {
            MainApp app = Stub.Load();
            Console.WriteLine(UtilsListes.AfficherLesJeuxTriés(app.TousLesJeux, TypeTri.A_Z));
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

        private static void Text_()
        {

        }
    }
}
