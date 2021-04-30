using BibliothèqueApplication;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeu jeu1 = new Jeu("Test", "Matt", new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis");
            jeu1.Informations.AjouterGenre(Genres.FPS);
            jeu1.Informations.AjouterGenre(Genres.RPG);
            jeu1.Informations.AjouterPlateforme(Plateformes.PC);
            jeu1.Informations.AjouterPlateforme(Plateformes.PS4);
            Console.WriteLine(jeu1);
        }
    }
}
