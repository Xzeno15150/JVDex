using BibliothèqueApplication;
using System;

namespace Data
{
    public static class Stub 
    {
        public static MainApp Load()
        {
            MainApp app = new MainApp();

            Jeu jeu1 = new Jeu("Test1", new Createur("Matt", "Orillon", new DateTime(2020, 1, 1)), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis", "");
            Jeu jeu2 = new Jeu("Zelda", new Studio("Nintendo"), new DateTime(2020, 03, 30), 3, "Ceci est un test de synopsis 1", "");
            Jeu jeu3 = new Jeu("Test2", new Createur("Victor", "Gaillard", new DateTime(2020, 10, 14)), new DateTime(2020, 05, 04), 7, "Ceci est un test de synopsis 2", "");
            Jeu jeu4 = new Jeu("Test1", new Createur("Matt", "Orillon", new DateTime(2020, 1, 1)), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis","");
            Jeu jeu5 = new Jeu("Super Mario", new Createur("Inés", "Orillon", new DateTime(2010, 06, 23)),new DateTime(2012, 05, 04), 7, "Test du synopsis jeu", "");
            Franchise franchise1 = new Franchise("Mario", "");
            Franchise franchise2 = new Franchise("The Legend of Zelda", "");
            Franchise franchise3 = new Franchise("Dragon Quest", "");
            Franchise franchise4 = new Franchise("Pokemon", "");
            Franchise franchise5 = new Franchise("Professeur Layton", "");

            try
            {
                jeu1.Informations.AjouterGenre(Genres.FPS);
                jeu1.Informations.AjouterGenre(Genres.RPG);
                jeu1.Informations.AjouterPlateforme(Plateformes.TroisDS);
                jeu1.Informations.AjouterPlateforme(Plateformes.PS4); 
                
                jeu2.Informations.AjouterGenre(Genres.Plateforme);
                jeu2.Informations.AjouterGenre(Genres.Reflexe);
                jeu2.Informations.AjouterGenre(Genres.RPG);
                jeu2.Informations.AjouterPlateforme(Plateformes.Gamecube);
                jeu2.Informations.AjouterPlateforme(Plateformes.DS); 
                
                jeu3.Informations.AjouterGenre(Genres.Simulation);
                jeu3.Informations.AjouterGenre(Genres.RPG);
                jeu3.Informations.AjouterPlateforme(Plateformes.PC);

                jeu4.Informations.AjouterGenre(Genres.FPS);
                jeu4.Informations.AjouterGenre(Genres.RPG);
                jeu4.Informations.AjouterPlateforme(Plateformes.PC);
                jeu4.Informations.AjouterPlateforme(Plateformes.PS4);

                jeu5.Informations.AjouterGenre(Genres.Plateforme);
                jeu5.Informations.AjouterPlateforme(Plateformes.PC);
                jeu5.Informations.AjouterPlateforme(Plateformes.PS4);



                jeu1.AjouterAuxFavoris();
                jeu3.AjouterAuxFavoris();


                app.AjouterJeu(jeu1, franchise1);
                app.AjouterJeu(jeu2, franchise2);
                app.AjouterJeu(jeu3, franchise2);
                app.AjouterJeu(jeu4, franchise3);
                app.AjouterJeu(jeu5, franchise5);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return app;
        }
    }
}
