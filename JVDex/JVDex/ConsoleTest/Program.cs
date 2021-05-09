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

            Console.WriteLine(UtilsListes.AfficherLesFranchises(app.ToutesLesFranchises));
            Console.WriteLine("=============================");
            // Console.WriteLine(UtilsListes.AfficherLesFavoris(app.lesJeux));
            Console.WriteLine(UtilsListes.AfficherJeux(app.TousLesJeux));
            Console.WriteLine("=============================");
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

            Console.WriteLine(app.TousLesJeux[0]);

        }
    }
}

//j'ai essayé de faire des test sur les methodes d'ajout des franchises normalement tout fonctionne sauf avec les boucles
//j'ai pas réussi à faire fonctionner beaucoup de choses, j'ai des problèmes haha

// alors ce que t'as fais est pas mal mais il faut séparer dans des méthodes différentes
// la pour les franchises il ne faut pas les mettre dans la méthode Test_Trier_Jeu, mais dans une autre
// j'ai déplacé les données en dur dans le Data.Stub
