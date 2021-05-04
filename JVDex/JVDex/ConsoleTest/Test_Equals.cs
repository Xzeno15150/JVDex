using BibliothèqueApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTest
{
    class Test_Equals
    {
        public static void TestEqualsJeu1()
        {
            Jeu jeu1 = new Jeu("Tes1", "Matt", new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis");
            Jeu jeu2 = new Jeu("Tes1", "Matt", new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis");
            Jeu jeu3 = new Jeu("Test3", "Victor", new DateTime(2020, 05, 04), 7, "Ceci est un test de synopsis 2");
            Object o = new object();
            try
            {
                jeu1.Informations.AjouterGenre(Genres.FPS);
                jeu1.Informations.AjouterGenre(Genres.RPG);
                jeu1.Informations.AjouterPlateforme(Plateformes.PC);
                jeu1.Informations.AjouterPlateforme(Plateformes.PS4);

                jeu1.Informations.AjouterGenre(Genres.FPS);
                jeu1.Informations.AjouterGenre(Genres.RPG);
                jeu1.Informations.AjouterPlateforme(Plateformes.PC);
                jeu1.Informations.AjouterPlateforme(Plateformes.PS4);

                jeu1.Informations.AjouterGenre(Genres.Plateforme);
                jeu1.Informations.AjouterGenre(Genres.Reflexe);
                jeu1.Informations.AjouterGenre(Genres.RPG);
                jeu1.Informations.AjouterPlateforme(Plateformes.Gamecube);
                jeu1.Informations.AjouterPlateforme(Plateformes.DS);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(jeu1);
            Console.WriteLine(jeu2);
            Console.WriteLine(jeu3);
            //////////////////////////  
            Console.WriteLine(jeu1.Equals(jeu2));
            Console.WriteLine(jeu1.Equals(jeu3));
            Console.WriteLine(jeu1.Equals(o));
        }
    }
}
