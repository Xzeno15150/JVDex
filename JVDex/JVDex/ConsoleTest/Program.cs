using BibliothèqueApplication;
using System;

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
            Jeu jeu1 = new Jeu("Test1", new Createur("Matt", "Orillon", new DateTime(2020, 1, 1)), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis");
            Jeu jeu2 = new Jeu("Zelda", new Studio("Nintendo"), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis 1");
            Jeu jeu3 = new Jeu("Test2", new Createur("Victor", "Gaillard", new DateTime(2020, 10, 14)), new DateTime(2020, 05, 04), 7, "Ceci est un test de synopsis 2");
            Jeu jeu4 = new Jeu("Test1", new Createur("Matt", "Orillon", new DateTime(2020, 1, 1)), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis");

            try
            {
                jeu1.Informations.AjouterGenre(Genres.FPS);
                jeu1.Informations.AjouterGenre(Genres.RPG);
                jeu1.Informations.AjouterPlateforme(Plateformes.PC);
                jeu1.Informations.AjouterPlateforme(Plateformes.PS4);

                jeu4.Informations.AjouterGenre(Genres.FPS);
                jeu4.Informations.AjouterGenre(Genres.RPG);
                jeu4.Informations.AjouterPlateforme(Plateformes.PC);
                jeu4.Informations.AjouterPlateforme(Plateformes.PS4);

                jeu2.Informations.AjouterGenre(Genres.Plateforme);
                jeu2.Informations.AjouterGenre(Genres.Reflexe);
                jeu2.Informations.AjouterGenre(Genres.RPG);
                jeu2.Informations.AjouterPlateforme(Plateformes.Gamecube);
                jeu2.Informations.AjouterPlateforme(Plateformes.DS);

                
                jeu3.Informations.AjouterGenre(Genres.Simulation);
                jeu3.Informations.AjouterGenre(Genres.RPG);
                jeu3.Informations.AjouterPlateforme(Plateformes.PC);

                MainApp.AjouterJeu(jeu1);
                MainApp.AjouterJeu(jeu2);
                MainApp.AjouterJeu(jeu3);
                MainApp.AjouterJeu(jeu4);



            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(MainApp.AfficherTousLesJeux());
            Console.WriteLine("=============================");
            MainApp.TrierLesJeuxPar(TypeTri.A_Z);
            Console.WriteLine(MainApp.AfficherTousLesJeux());
            Console.WriteLine("=============================");
            MainApp.TrierLesJeuxPar(TypeTri.Z_A);
            Console.WriteLine(MainApp.AfficherTousLesJeux());

        }
    }
}

