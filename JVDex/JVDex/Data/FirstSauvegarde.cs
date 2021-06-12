using BibliothèqueApplication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class FirstSauvegarde : IPersistanceStockApp
    {
        public (IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises) ChargeDonnees()
        {
            Franchise fZelda = new Franchise("Zelda", @"/Ressources;Component/images/Franchises/Zelda/background.jpg", "#1BC213");
            Franchise fMario = new Franchise("Mario", @"/Ressources;Component/images/Franchises/Mario/background.jpg", "#DE1111");
            Franchise fPokemon = new Franchise("Pokemon", @"/Ressources;Component/images/Franchises/Pokemon/background.jpg", "#FFFB00");
            Franchise fDragon = new Franchise("Dragon Quest", @"/Ressources;Component/images/Franchises/DragonQuest/background.jpg", "#2092DC");
            Franchise fLayton = new Franchise("Professeur Layton", @"/Ressources;Component/images/Franchises/Layton/background.jpg", "#896335");


            Jeu BOTW = new Jeu("Breath Of The Wild", new Studio("Nintendo"), new DateTime(2017, 03, 03), 12, "synospsis", @"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/vignette.png",
                new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG,
                Genres.Action
                },
                new HashSet<Plateformes>(){
                Plateformes.NintendoSwitch,
                Plateformes.Wii_U
                },
                new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/visuel1.jpg", "Dans la forêt"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/visuel2.jpg", "Dans la pleine d'Hyrule"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/visuel3.jpg", "Dans les airs"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/visuel4.jpg","La cité Guerudo")
                },
                new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
                },
                new HashSet<Theorie>(){
                    new Theorie("A la recherche d'un ancêtre de Ganon", "Elle explique que dans la vidéo, Zelda et Link traversent une grotte sombre et inquiétante, qui semble être une civilisation antique, souterraine dont des fresques sont visibles sur les murs. On peut y voir des signes divers et variés, mais aussi une forme d\'un homme sur un cheval. Rapidement, la ressemblance avec Ganondorf dans Ocarina of Time est faite. Sur les murs environnants, on voit également des sceaux qui pourraient bloquer le réel danger : l\'Avatar du Néant, véritable danger du monde d\'Hyrule. Les ressemblances entre les formes et celles trouvables dans Skyward Sword sont frappantes. Pour rappel, dans Skyward Sword, Link affronte justement l\'ancêtre de Ganondorf, qui, une fois battu, le maudit lui et Zelda pour qu\'une incarnation du mal vienne mettre en péril la paix dans Hyrule à répétition. Cela irait dans le sens des derniers mots que l\'Avatar du Néant lance à Link avant d\'être scellé dans le jeu sorti en 2011 : \"Ceci n'est pas la fin. Ma haine... la malédiction des démons... renaîtront sans fin à travers les âges. Ne l'oublie jamais ! L\'histoire se répétera ! Vous... héritiers du sang de la Déesse et de l\'âme du héros, vous ne pourrez échapper à ma malédiction ! Vous errerez à jamais sur une sombre mer de sang, poursuivis par l'incarnation de ma haine !\". Ganondorf est vraisemblablement cette incarnation, qui revient dans tous les jeux Zelda. Dans la vidéo montrée par Nintendo à l'E3, quelque chose camoufle le front du cadavre... où se trouve la cicatrice de l\'Avatar du Néant. Nous aurions donc affaire à l\'Avatar du Néant en personne, dont la malédiction prend place depuis le coeur d'Hyrule : son sol. Une théorie qui signifierait qu'un épisode d'une importance capitale arriverait pour la suite de Breath of the Wild. Elle pourrait même signifier la fin du lore de la franchise, si Link et Zelda parvenaient à le terrasser une fois pour toutes. Bien sûr, Nintendo reste dans le silence pour laisser ses fans créer les théories les plus développées, et faire monter l\'excitation. En tout cas, celle-ci semble plausible, et serait une suite grandiose pour un jeu qui a déjà tant marché.")



                }) ;



            Dictionary<Franchise, List<Jeu>> lesFranchises = new Dictionary<Franchise, List<Jeu>>() 
            {
                [fZelda] = new List<Jeu>()
                {
                    BOTW,
                   
                },
            };

            IList<Jeu> lesJeux = new List<Jeu>()
            {
                BOTW,
            };

            return (lesJeux, lesFranchises);
        }

        public void SauvegardeDonnees(IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises)
        {
            throw new NotImplementedException();
        }

        
    }
}
