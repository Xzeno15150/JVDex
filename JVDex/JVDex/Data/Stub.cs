﻿using BibliothèqueApplication;
using System;

namespace Data
{
    public static class Stub 
    {
        public static Manager Load()
        {
            StockApp app = new StockApp();

            Jeu test1 = new Jeu("Test1", new Createur("Matt", "Orillon", new DateTime(2020, 1, 1)), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis", "");
            Jeu test1_bis = new Jeu("Test1", new Createur("Matt", "Orillon", new DateTime(2020, 1, 1)), new DateTime(2020, 04, 30), 3, "Ceci est un test de synopsis", "");

            Jeu zelda1 = new Jeu("Breath of the Wild", new Studio("Nintendo"), new DateTime(2020, 03, 30), 3, "Ceci est un test de synopsis 1", "Franchises/Zelda/Jeux/BOTW/vignette.png");
            Jeu zeldaWindwaker = new Jeu("Windwaker", new Studio("Nintendo"), new DateTime(2020, 03, 30), 3, "Ceci est un test de synopsis 1", "Franchises/Zelda/Jeux/BOTW/vignette.png");
            Jeu zeldaWindwaker2 = new Jeu("Windwaker2", new Studio("Nintendo"), new DateTime(2020, 03, 30), 3, "Ceci est un test de synopsis 1", "Franchises/Zelda/Jeux/BOTW/vignette.png");
            Jeu zeldaWindwaker3 = new Jeu("Windwaker3", new Studio("Nintendo"), new DateTime(2020, 03, 30), 3, "Ceci est un test de synopsis 1", "Franchises/Zelda/Jeux/BOTW/vignette.png");
            Jeu zeldaWindwaker4 = new Jeu("Windwaker4", new Studio("Nintendo"), new DateTime(2020, 03, 30), 3, "Ceci est un test de synopsis 1", "Franchises/Zelda/Jeux/BOTW/vignette.png");
            Jeu test2 = new Jeu("Test2", new Createur("Victor", "Gaillard", new DateTime(2020, 10, 14)), new DateTime(2020, 05, 04), 7, "Ceci est un test de synopsis 2", "");
           
            Jeu mario = new Jeu("Super Mario", new Studio("Nintendo"),new DateTime(2012, 05, 04), 7, "Test du synopsis jeu", "");
            Jeu new_mario = new Jeu("New Super Mario Bros", new Studio("Nintendo"), new DateTime(2012, 05, 04), 7, "Test du synopsis jeu", "");
            
            Jeu dragonQuest = new Jeu("Dragon Quest", new Studio("Enix"),new DateTime(2012, 05, 04), 7, "Test du synopsis jeu", "");

            Franchise fMario = new Franchise("Mario", "Franchises/Mario/background.jpg", "#DE1111");
            Franchise fZelda = new Franchise("The Legend of Zelda", "Franchises/Zelda/background.jpg", "#1BC213");
            Franchise fDragonQuest = new Franchise("Dragon Quest", "Franchises/DragonQuest/background.jpg", "#2092DC");
            Franchise fPokemon = new Franchise("Pokemon", "Franchises/Pokemon/background.jpg", "#FFFB00");
            Franchise fProfLayton = new Franchise("Professeur Layton", "Franchises/Layton/background.jpg", "#896335");
            Theorie thZelda1 = new Theorie("vie de Link", "link est un farfadet");
            Theorie thZelda2 = new Theorie("vie de Link2", "link est un farfadet");
            Visuel V1 = new Visuel("Franchises/Zelda/Jeux/BOTW/vignette.png","Image du jeu");
            Visuel V2 = new Visuel("Franchises/Zelda/Jeux/BOTW/vignette.png","Image du jeu 2");

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

                zelda1.AjouterTheorie(thZelda1);
                zelda1.AjouterTheorie(thZelda2);

                zelda1.AjouterVisuel(V1);
                zelda1.AjouterVisuel(V2);


                test1.AjouterAuxFavoris();
                test2.AjouterAuxFavoris();

                
                app.AjouterJeu(zelda1, fZelda);
                app.AjouterJeu(zeldaWindwaker, fZelda);
                app.AjouterJeu(zeldaWindwaker2, fZelda);
                app.AjouterJeu(zeldaWindwaker3, fZelda);
                app.AjouterJeu(zeldaWindwaker4, fZelda);
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

            return new Manager(app);
        }
    }
}
