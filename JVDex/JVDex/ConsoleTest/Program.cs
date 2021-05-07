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
            Franchise franchise1 = new Franchise("Mario");
            Franchise franchise2 = new Franchise("The Legend of Zelda");
            Franchise franchise3 = new Franchise("Dragon Quest");
            Franchise franchise4 = new Franchise("Pokemon");
            Franchise franchise5 = new Franchise("Professeur Layton");

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

                jeu1.AjouterAuxFavoris();
                jeu3.AjouterAuxFavoris();

                MainApp.AjouterFavoris(jeu1);
                MainApp.AjouterFavoris(jeu3);

                franchise1.ajouterJeu(jeu1);
                franchise1.ajouterJeu(jeu3);
                franchise2.ajouterJeu(jeu2);

                MainApp.AjouterJeu(jeu1);
                MainApp.AjouterJeu(jeu2);
                MainApp.AjouterJeu(jeu3);
                MainApp.AjouterJeu(jeu4);

                MainApp.AjouterFranchise(franchise1);
                MainApp.AjouterFranchise(franchise2);
                MainApp.AjouterFranchise(franchise3);
                MainApp.AjouterFranchise(franchise4);
                MainApp.AjouterFranchise(franchise5);



            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(MainApp.AfficherTousLesJeux());
            Console.WriteLine("=============================");
            Console.WriteLine(MainApp.AfficherToutesLesFranchises());
            Console.WriteLine("=============================");
            Console.WriteLine(MainApp.AfficherTousLesFavoris()); // ne fonctionne pas
            Console.WriteLine("============================="); 
            Console.WriteLine(franchise1); // les méthodes d'ajout des franchises avec les jeux fonctionnent, je n'arrive pas à le faire avec la boucle foreach de MainApp
            Console.WriteLine("=============================");
            Console.WriteLine(jeu2);  //l'affichage du jeu fonctionne aussi

            MainApp.TrierLesJeuxPar(TypeTri.A_Z);
            Console.WriteLine(MainApp.AfficherTousLesJeux());
            Console.WriteLine("=============================");
            MainApp.TrierLesJeuxPar(TypeTri.Z_A);
            Console.WriteLine(MainApp.AfficherTousLesJeux()); /**/

        }
    }
}

//j'ai essayé de faire des test sur les methodes d'ajout des franchises normalement tout fonctionne sauf avec les boucles
//j'ai pas réussi à faire fonctionner beaucoup de choses, j'ai des problèmes haha

