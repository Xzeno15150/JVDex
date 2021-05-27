using BibliothèqueApplication;
using System;

namespace Data
{
    public static class Stub 
    {
        public static Manager Load()
        {
            Manager app = new Manager();

            Jeu test1 = new Jeu("Test1", new Createur("Matt", "Orillon", new DateTime(2020, 1, 1)), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis", "");
            Jeu test1_bis = new Jeu("Test1", new Createur("Matt", "Orillon", new DateTime(2020, 1, 1)), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis", "");

            Jeu zelda1 = new Jeu("The Legend Of Zelda Breath of the Wild", new Studio("Nintendo"), new DateTime(2020, 03, 30), 3, "Ceci est un test de synopsis 1", "Resources/Jeux/Zelda/pochette-jeu.jpg");
            Jeu zeldaWindwaker = new Jeu("The Legend Of Zelda Windwaker", new Studio("Nintendo"), new DateTime(2020, 03, 30), 3, "Ceci est un test de synopsis 1", "");
            Jeu test2 = new Jeu("Test2", new Createur("Victor", "Gaillard", new DateTime(2020, 10, 14)), new DateTime(2020, 05, 04), 7, "Ceci est un test de synopsis 2", "");
           
            Jeu mario = new Jeu("Super Mario", new Studio("Nintendo"),new DateTime(2012, 05, 04), 7, "Test du synopsis jeu", "");
            Jeu new_mario = new Jeu("New Super Mario Bros", new Studio("Nintendo"), new DateTime(2012, 05, 04), 7, "Test du synopsis jeu", "");
            
            Jeu dragonQuest = new Jeu("Dragon Quest", new Studio("Enix"),new DateTime(2012, 05, 04), 7, "Test du synopsis jeu", "");

            Franchise fMario = new Franchise("Mario", "Resources/Jeux/Mario/background.jpg", "#DE1111");
            Franchise fZelda = new Franchise("The Legend of Zelda","Resources/Jeux/Zelda/background.jpg", "#1BC213");
            Franchise fDragonQuest = new Franchise("Dragon Quest", "Resources/Jeux/DragonQuest/background.jpg", "#2092DC");
            Franchise fPokemon = new Franchise("Pokemon", "Resources/Jeux/Pokemon/background.jpg", "#FFFB00");
            Franchise fProfLayton = new Franchise("Professeur Layton", "Resources/Jeux/Layton/background.jpg", "#896335");

            try
            {
                test1.Informations.AjouterGenre(Genres.FPS);
                test1.Informations.AjouterGenre(Genres.RPG);
                test1.Informations.AjouterPlateforme(Plateformes.TroisDS);
                test1.Informations.AjouterPlateforme(Plateformes.PS4); 
                
                zelda1.Informations.AjouterGenre(Genres.Plateforme);
                zelda1.Informations.AjouterGenre(Genres.Reflexe);
                zelda1.Informations.AjouterGenre(Genres.RPG);
                zelda1.Informations.AjouterPlateforme(Plateformes.Gamecube);
                zelda1.Informations.AjouterPlateforme(Plateformes.DS); 
                
                test2.Informations.AjouterGenre(Genres.Simulation);
                test2.Informations.AjouterGenre(Genres.RPG);
                test2.Informations.AjouterPlateforme(Plateformes.PC);

                test1_bis.Informations.AjouterGenre(Genres.FPS);
                test1_bis.Informations.AjouterGenre(Genres.RPG);
                test1_bis.Informations.AjouterPlateforme(Plateformes.TroisDS);
                test1_bis.Informations.AjouterPlateforme(Plateformes.PS4);

                mario.Informations.AjouterGenre(Genres.Plateforme);
                mario.Informations.AjouterPlateforme(Plateformes.PC);
                mario.Informations.AjouterPlateforme(Plateformes.PS4);



                test1.AjouterAuxFavoris();
                test2.AjouterAuxFavoris();

                
                app.AjouterJeu(zelda1, fZelda);
                app.AjouterJeu(zeldaWindwaker, fZelda);
                app.AjouterJeu(test2, fPokemon);
                app.AjouterJeu(mario, fMario);
                app.AjouterJeu(new_mario, fMario);
                app.AjouterJeu(dragonQuest, fDragonQuest);
                app.AjouterJeu(test1, fProfLayton);
                app.AjouterJeu(test1_bis, fDragonQuest);

                //app.AjouterFranchise(fTest);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            return app;
        }
    }
}
