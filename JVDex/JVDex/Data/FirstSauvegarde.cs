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

            // Jeu type
            Jeu Nom = new Jeu("", new Studio("Nintendo"), new DateTime(2002, 12, 13), 7, "",
               @"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Action
              },
              new HashSet<Plateformes>(){
                Plateformes.Gamecube,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/visuel1.jpg", ""),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/visuel2.jpg", ""),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/visuel3.jpg", ""),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/visuel4.png","")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme","botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });


            //

            //Breath Of The Wilde
            Jeu BOTW = new Jeu("Breath Of The Wild", new Studio("Nintendo"), new DateTime(2017, 03, 03), 12, "Breath of the Wild propose d'incarner Link, amnésique, réveillé après un long sommeil d'une centaine d'années par une mystérieuse voix qui le guide afin d'éliminer Ganon, « Le Fléau », et restaurer la paix dans le royaume d'Hyrule. Link va alors explorer l'univers étendu et sauvage qu'est devenu le royaume d'Hyrule. Il devra à lui seul trouvé le secret autour de son réveil. ", 
                @"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/vignette.png",
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
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/visuel2.jpg", "Dans la plaine d'Hyrule"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/visuel3.jpg", "Dans les airs"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/BOTW/visuel4.jpg","La cité Guerudo")
                },
                new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
                },
                new HashSet<Theorie>(){
                    new Theorie("A la recherche d'un ancêtre de Ganon", "Elle explique que dans la vidéo, Zelda et Link traversent une grotte sombre et inquiétante, qui semble être une civilisation antique, souterraine dont des fresques sont visibles sur les murs. On peut y voir des signes divers et variés, mais aussi une forme d\'un homme sur un cheval. Rapidement, la ressemblance avec Ganondorf dans Ocarina of Time est faite. Sur les murs environnants, on voit également des sceaux qui pourraient bloquer le réel danger : l\'Avatar du Néant, véritable danger du monde d\'Hyrule. Les ressemblances entre les formes et celles trouvables dans Skyward Sword sont frappantes. Pour rappel, dans Skyward Sword, Link affronte justement l\'ancêtre de Ganondorf, qui, une fois battu, le maudit lui et Zelda pour qu\'une incarnation du mal vienne mettre en péril la paix dans Hyrule à répétition. Cela irait dans le sens des derniers mots que l\'Avatar du Néant lance à Link avant d\'être scellé dans le jeu sorti en 2011 : \"Ceci n'est pas la fin. Ma haine... la malédiction des démons... renaîtront sans fin à travers les âges. Ne l'oublie jamais ! L\'histoire se répétera ! Vous... héritiers du sang de la Déesse et de l\'âme du héros, vous ne pourrez échapper à ma malédiction ! Vous errerez à jamais sur une sombre mer de sang, poursuivis par l'incarnation de ma haine !\". Ganondorf est vraisemblablement cette incarnation, qui revient dans tous les jeux Zelda. Dans la vidéo montrée par Nintendo à l'E3, quelque chose camoufle le front du cadavre... où se trouve la cicatrice de l\'Avatar du Néant. Nous aurions donc affaire à l\'Avatar du Néant en personne, dont la malédiction prend place depuis le coeur d'Hyrule : son sol. Une théorie qui signifierait qu'un épisode d'une importance capitale arriverait pour la suite de Breath of the Wild. Elle pourrait même signifier la fin du lore de la franchise, si Link et Zelda parvenaient à le terrasser une fois pour toutes. Bien sûr, Nintendo reste dans le silence pour laisser ses fans créer les théories les plus développées, et faire monter l\'excitation. En tout cas, celle-ci semble plausible, et serait une suite grandiose pour un jeu qui a déjà tant marché."),
                    new Theorie("Le secret des Sheika?","Cette race mentionnée dans Skyward Sword , qui a accès à la fois à une technologie de pointe et à un voyage dans le temps, ressemble énormément au Sheikah dont nous entendons parler de l\'époque d'avant Breath of the Wild . Par conséquent, ma théorie folle est que le Sheikah qui a construit les Bêtes divines et tout le reste il y a 10 000 ans étaient des voyageurs temporels de l\'ère d'Hylia. Cela expliquerait pourquoi nous en voyons si peu par Ocarina of Time ; une grande faction d'entre eux ont \"sauté la ville\" pour ainsi dire en voyageant dans le futur."),
                    new Theorie("La chronologie de Breath Of The Wilde","La chronologie \"Failed Hero\" est précisément ce à quoi elle ressemble: c'est la troisième chronologie possible après Ocarina of Time qui voit Link tomber aux mains de Ganon. Les théoriciens du jeu décomposent cette théorie dans une vidéo étonnamment détaillée, mais leur thèse peut se résumer en deux points principaux. Dans cette chronologie, Ganon est finalement vaincu et réincarné quatre fois, résultant en le monstrueux Calamity Ganon de BotW  qui a perdu toute l\'humanité pour devenir un pur mal. La pièce d'armure découvrable dans le jeu connue sous le nom de Cap of the Wild a une bande jaune qui correspond exclusivement à la conception des costumes de Link des jeux de la chronologie Failed Hero. Affaire classée."),
                    new Theorie("Un parallèle avec Wind Walker?","Wind Waker se déroule dans un Hyrule qui a été complètement inondé par les dieux dans le but de contenir Ganon. Un fan pense que cela aide à expliquer le monde de Breath of the Wild . Ces mêmes dieux ,Hylia, Din, Farore et Nayru , créent un monde alternatif, un peu comme Lorule, pour donner aux habitants d\'Hyrule inondé un endroit où vivre. Avance rapide de 10 000 ans et vous atteignez le monde de BotW. Le monde du jeu propose même une technologie de pointe comme la Sheikah Slate, qui rappelle la Tour des Dieux de Wind Waker . En théorie, cela prouve qu\'il existe un lien entre les deux mondes. "),
                    new Theorie("Breath Of The Wilde n\'appartient pas à la chronologie?","Hyrule Historia  propose trois chronologies officielles pour le monde de Zelda. Après que le voyage dans le temps de Link dans Ocarina of Time ait  divisé la chronologie, l\'histoire se déroule dans trois directions distinctes. Dans Wind Waker, Hyrule se retrouve sans héros lorsque Link voyage dans le temps. Dans  Majora\'s Mask and Twilight Princess ,  Link revient à Hyrule lorsqu\'il était enfant. Dans  The Legend of Zelda  et The Adventure of Link ,  Link est vaincu par Ganon. Le créateur de la série Shigeru Miyamoto et le producteur Eiji Aonuma  affirment que BotW  tombe après Ocarina of Time  dans la chronologie globale, mais ne précisent pas dans laquelle des trois intrigues il s\'inscrit. Cela ne peut pas être la chronologie de Wind Waker car dans ce jeu, un nouvel Hyrule est fondé, mais BotW  présente le Temple du Temps de l\'ancien royaume d'Hyrule. YouTuber Zeltic  théorise que le jeu doit s'inscrire dans la troisième chronologie, en raison de l'emplacement de Master Sword dans les bois perdus, mais il liste également des preuves contradictoires à ce sujet. À un moment donné dans  BotW,  Zelda dit: \"Que ce soit vers le ciel, à la dérive dans le temps ou plongé dans les braises incandescentes du crépuscule…\" C'est une référence évidente à la deuxième chronologie, mais l\'épée maîtresse devrait être dans le temple Il est temps que tout s'emboîte. En bref, chaque chronologie possible a un élément de réfutation.Comme le suggère Redditor /u/ yay855 , \" Breath of the Wild est le premier jeu Zelda qui n\'est pas directement connecté à d\'autres en dehors des références. Nintendo a officiellement annulé la chronologie dans le but d\'arrêter de se restreindre. \"")
                }) ;


            //Phantom Hourglass
            Jeu Phantom= new Jeu("Phantom Hourglass", new Studio("Nintendo"), new DateTime(2007, 06, 23), 7, "Link et l\'équipage des pirates de Tetra naviguent sur la Grande Mer et rencontrent un nuage de brouillard, dans lequel se trouve un navire abandonné, soupçonné par le groupe d\'être un navire fantôme. Tetra se décide à explorer ce vaisseau, mais est transportée dans une autre dimension peu de temps après avoir abordé le navire. Link tente de la secourir, mais tombe à l\'eau et échoue inconscient sur une plage voisine. Riche en forces vitales, cette dimension est victime de raids de la part de Bellum, un spectre maléfique se nourrissant de ces ressources. Celui-ci capture ainsi les esprits tutélaires de la Force et de la Sagesse, et force le Roi des Mers et l\'esprit du Courage à fuir en dissimulant leur identité.", 
                @" /Ressources;Component/images/Franchises/Zelda/Jeux/PhantomHourglass/vignette.jpg",
               new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Action
               },
               new HashSet<Plateformes>(){
                Plateformes.DS,
               },
               new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/PhantomHourglass/visuel1.jpg", "Au bord du navire"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/PhantomHourglass/visuel2.jpg", "Le Navire Fantôme"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/PhantomHourglass/visuel3.png", "Lindebeck et Link"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/PhantomHourglass/visuel4.jpg","L'île du froid")
               },
               new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
               },
               new HashSet<Theorie>(){
                   new Theorie("Quatre chevaliers du royaume de galets","Il est probable que les quatre chevaliers du royaume de galets sont basés sur les charpentiers de jeux précédents. Cela semble possible car il y a quatre chevaliers et quatre charpentiers, et les chevaliers servent sous le roi Mutoh, tandis que les charpentiers travaillent pour Mutoh. De plus, les noms des quatre chevaliers sont très similaires aux noms des charpentiers tels qu'ils apparaissent dans The Legend of Zelda : The Minish Cap."),
                   new Theorie("Lindebeck","Il n'est jamais précisé si Linebeck vient du monde de l'océan King ou du même monde en tant que Link. Bien que Link le rencontre pour la première fois dans le monde du roi de l'océan et qu'il y ait une certaine histoire (comme l'indiquent les habitants de Mercay Island et de Jolene), à la fin du jeu, lui et son navire sont renvoyés dans la Grande Mer avec Link et Tetra. Il est également noté que vers la fin du jeu, lorsque le roi de l'océan, sous sa forme de baleine, dit qu'ils sont dans un monde différent, il est clair que Linebeck semble surpris d'entendre la déclaration, suggérant qu'il est de Link's monde. Cependant, cela est contredit par sa relation avec Jolene, car elle semble être du monde du roi de l'océan. Il se peut qu'il vienne du monde de Link, mais qu'il soit arrivé dans le monde d'Ocean King bien avant Link. Il est finalement retourné dans le monde de Link."),
                   new Theorie("Le Navire fantôme","Il est possible que la conception du Ghost Ship soit basée sur le Ferry to the Other World de The Legende de Zelda : Ocarina of Time. Les deux navires ont une figure de proue avec deux mains tenant des cloches en dessous, et les deux navires sont structurés autour du thème de la mort."),
               });

            //Spirit Track
            Jeu Spirit = new Jeu("Spirit Track", new Studio("Nintendo"), new DateTime(2009, 12, 07), 7, "The Legend of Zelda: Spirit TracksNote est le quinzième opus de la saga The Legend of Zelda. Le jeu se situe chronologiquement dans la temporalité où Link a réussi à vaincre Ganon dans l'épisode The Legend of Zelda: Ocarina of Time et reste à l'âge adulte. L'intrigue de The Legend of Zelda: Spirit Tracks se déroule cent ans après les événements de Phantom Hourglassa, dans le nouveau Royaume d'Hyrule fondé à la fin du jeu précédenta. En effet, Hyrule est inondé et scellé au fond des eaux avant le déroulement de The Wind Waker et puis le sceau est détruit, les derniers vestiges d'Hyrule sont définitivement engloutis à la fin de cet épisodea 3. Les habitants sont ainsi des descendants des protagonistes du précédent jeu, et certains des personnages secondaires ayant vieillis", 
                @"/Ressources;Component/images/Franchises/Zelda/Jeux/SpiritTrack/vignette.jpg",
               new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Action
               },
               new HashSet<Plateformes>(){
                Plateformes.DS,
               },
               new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/SpiritTrack/visuel1.jpeg", "Dans le train"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/SpiritTrack/visuel2.jpg", "Link et l'esprit de la Princesse"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/SpiritTrack/visuel3.jpg", "La flûte de pan"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/SpiritTrack/visuel4.png","La tour des Dieux")
               },
               new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
               },
               new HashSet<Theorie>()
               {
                   new Theorie ("Lokomos","Il est possible que les Lokomos soient d'autres réincarnations des  Sept Sages ou des  Anciens Sages  puisqu'il y a au nombre de sept au moment de leur retour au ciel. Ceci est encore soutenu par Anjean lorsqu'elle déclare que Byrne renaîtrait des années plus tard, soutenant la réincarnation de l'esprit. Aussi, lors de leur ascension, leurs couleurs spirituelles sont les mêmes que celles des sages. Les éléments que les Lokomos semblent représenter sont généralement les mêmes que les éléments des Sept Sages (même Byrne peut représenter l'élément Ombre), bien que l'élément Glace de Steem ne corresponde pas au thème des Sept Sages.  "),
                   new Theorie ("Princesse du Crépuscule","Le bosquet sacré dans ce jeu est considéré par beaucoup comme faisant partie des bois perdus. Bien que cela n'ait jamais été officiellement déclaré; ils portent des thèmes musicaux identiques, et les deux bois sont parcourus par le Skull Kid. L'une des plus grandes similitudes entre les bois perdus d'Ocarina of Time et les bois perdus de Twilight Princess est que la zone qui détient l'épée maîtresse dans le bosquet sacré est exactement la même que la zone où Saria se trouve dans les bois perdus à Ocarina de Temps.Les deux zones de chaque jeu sont de hautes chambres circulaires au fond de la forêt. De plus, lorsque Link lève les yeux dans le bosquet sacré, il peut en fait voir ce qui semble être le temple de la forêt d'Ocarina of Time, qui apparaît comme une immense arche. Il y a aussi une pièce avec un rocher pouvant être bombardé cachant un Imp Poe et l'entrée d'une Caverne Dig qui ressemble également à cette zone.  "),
               });

            //Ocarina Of Time
            Jeu Ocarina = new Jeu("Ocarina Of Time", new Studio("Nintendo"), new DateTime(1998, 11, 21), 12, "Le royaume d'Hyrule est le résultat de l'unification de plusieurs contrées où vivent différents peuples, avec lesquels Link peut interagir. Les Kokiris sont des enfants semblables à des Hyliens mais qui ne grandissent jamais. Ils reçoivent à leur naissance une fée chargée de veiller sur chacun d'eux et ne peuvent pas quitter la forêt. Les Gorons, êtres robustes dotés d'une force phénoménale et semblables à un rocher une fois repliés sur eux-mêmes, sont insensibles à la lave et se déplacent en roulant. Ils ont à leur tête Darunia. Les Zoras sont des êtres marins mi-hommes, mi-poissons avec à leur tête le roi Zora. Les Sheikahs sont un peuple quasiment éteint puisqu'on ne dénombre plus qu'un seul individu : Impa, la nourrice de Zelda. Enfin, les Gerudos ont la grande particularité de n'être composés que de femmes. Un seul homme Gerudo naît par siècle et le dernier en date n'est autre que Ganondorf. ",
                @"/Ressources;Component/images/Franchises/Zelda/Jeux/OcarinaOfTime/vignette.png",
               new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Action
               },
               new HashSet<Plateformes>(){
                Plateformes.NintendoSwitch,
                Plateformes.Wii_U
               },
               new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/OcarinaOfTime/visuel.jpg", "Link et la princesse Zelda enfants"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/OcarinaOfTime/visuel2.jpg", "Link et Saria enfants"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/OcarinaOfTime/visuel3.jpg", "Le Temple du Temps"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/OcarinaOfTime/visuel4.jpg","Epona")
               },
               new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
               },
               new HashSet<Theorie>()
               {
                 new Theorie ("Navi","Navi est un personnage de  The Legend of Zelda : Ocarina of Time . Une  fée , Navi sert  lien de  compagnon de fées tout au long du jeu. Elle se voit confier la tâche d'aider Link par le  Grand Arbre Mojo . Bien qu'elle soit d'abord un peu frustrée par ce devoir et ne pense pas que Link soit capable d'actes d'héroïsme, elle devient bientôt beaucoup plus attachée à lui, et ils deviennent une équipe inséparable. A la fin du jeu, Navi quitte le pays d'Hyrule  pour des raisons inconnues. Navi se présente comme une étape importante dans la  Légende de Zelda  série , comme elle est le premier de nombreux personnages de compagnie-side kick qui apparaissent dans les jeux plus tard dans la série. Elle est également le premier personnage des entrées canoniques de la série à avoir un doublage, prononçant des mots comme « hé », « faites attention » et « écoutez » chaque fois que Link rencontre quelque chose d'intéressant ou de dangereux, ainsi que de dire \" bonjour\" !  à un Kokiri  sur son chemin vers  la maison de Link , et quand elle rencontre Link pour la première fois. Elle fournit également occasionnellement à Link le dernier objectif connu du jeu pour la commodité du joueur. Navi active Link to  personnes, objets et  ennemis, en changeant sa couleur pour indiquer ce qu'ils sont. Elle peut ensuite fournir des conseils, des astuces ou des informations sur l'objet ou l'ennemi que Link cible, y compris ses faiblesses. Son doublage a été fourni par  Kaori Mizuhashi , qui fournira plus tard la voix de  Ciela , un autre compagnon féerique de Link de  The Legend of Zelda: Phantom Hourglass ."), 
                 new Theorie ("Temple Sheika","En raison de l'emplacement du temple dans le  cimetière de Kakariko , à proximité du  village de Kakariko,  un ancien village de Sheikah, l'association Sheikah avec des ombres telles qu'elle est appelée « Shadows of Hyruleans » ou « Shadow Folk » , et le   statut Impa en tant que Sage of Shadow . Le Sheikah a peut-être servi de gardiens du Temple de la même manière que les relations entre les  Kokiri et le Temple de la  Forêt , les Gorons  et le Temple du Feu , les Zoras  et le Temple de l\'  Eau ,  et le Temple de l\'  Esprit , et Hylians  et le  Temple du Temps.Le Sheikah a peut-être utilisé le Temple à diverses fins liées à son rôle de protecteur de la famille royale, comme une prison, un terrain d\'entraînement ou les deux. Compte tenu de la nature obscure du cheikah, il est possible qu'ils aient utilisé le temple pour y mener des activités plus discutables en secret, loin de la population civile en général. Des choses comme emprisonner, interroger, torturer et / ou exécuter les ennemis d'Hyrule, y compris les criminels, les traîtres et les espions étrangers."), 
                 new Theorie ("Gardien du temple","Il est possible que la statue en forme de corbeau trouvée partout dans le Temple de l'Ombre symbolise la divinité protectrice du donjon. Cette statue n'est jamais mentionnée, mais on la voit assez souvent dans tout le temple. Cet être ressemblant à un corbeau pourrait très bien être un dieu ou une déesse du Sheikah, bien que ni Sheik ni Impa ne mentionnent jamais une divinité protectrice du peuple de l'ombre. De plus, tous les autres donjons pour adultes semblent avoir leurs propres représentations. Un autre fait soutenant cette théorie est que cette statue est présente dans le fond du puits, une autre zone qui a été liée au Sheikah."), 
               });

            //Wind Waker
            Jeu Wind = new Jeu("Wind Waker", new Studio("Nintendo"), new DateTime(2002, 12, 13), 7, "L'intrigue de The Wind Waker se déroule un siècle après les événements survenant dans l'épisode Ocarina of Time. Dans cette branche de la temporalité appelée « Le Nouveau Monde », Link a réussi à vaincre Ganondorf et reste à l'âge adulte. L'antagoniste de la série est scellé dans la Triforce de la force, celle du courage est divisée en huit et dispersée. Cependant, Ganondorf réussit à se libérer et revenir, mais Link ne réapparaît pas. Ainsi, les déesses immergent le monde d'Hyrule, puis l'emprisonnent dans un sceau magique sous les eaux de la Grande Mer recouvrant alors le royaume. La Triforce de la sagesse est à ce moment-là scindée en deux, le roi d'Hyrule Daphnès Nohansen Hyrule III, également scellé, en conserve un élément, alors que l'autre est attribué à la princesse Zelda. Pourtant, Ganondorf, qui semblait être piégé, réussit à se libérer une centaine d'années plus tard.", 
                @"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/vignette.jpg",
               new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Action
               },
               new HashSet<Plateformes>(){
                Plateformes.Gamecube,
               },
               new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/visuel1.jpg", "Sur le beateau"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/visuel2.jpg", "Dans la plaine"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/visuel3.jpg", "Link et la Princesse Zelda"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Zelda/Jeux/WindWaker/visuel4.png","Sur la plage")
               },
               new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
               },
               new HashSet<Theorie>()
               {
                   new Theorie("Voix Pols","Le Bunny Hood ressemble à un Pols Voice, un ennemi récurrent dans la série. Ce n'est peut-être pas une coïncidence, cependant; Lorsque Link vend le Bunny Hood au Running Man dans Ocarina of Time, il déclare en recevant le masque: \"Je parie qu'avec ces longues oreilles, vous pouvez entendre les voix.\" Cette citation peut très bien indiquer un lien entre le Bunny Hood et le Pols Voice. Le Bunny Hood lui-même peut simplement être une référence à The Legend of Zelda: A Link to the Past, dans lequel Link devient un lapin dans le monde des ténèbres avant d\'obtenir la perle de lune."),
                   new Theorie("Fado","Le fado est peut-être un descendant du sage de la forêt, Saria, puisque tous deux sont des sages Kokiri qui partageait une coiffure similaire. Ceci est également soutenu par l'observation que les nouveaux sages ont tendance à être les descendants des anciens sages, comme c'est le cas avec Makar et Fado. Cependant, certaines personnes croient, en raison de la couleur des cheveux et du nom identiques, que Fado est le descendant de la fille Kokiri du même nom d'Ocarina of Time."),
               });

            //Jeux Mario

            Jeu Kart = new Jeu("Mario Kart", new Studio("Nintendo"), new DateTime(2005, 11, 14), 3, "Mario Kart DS est un jeu de courses reprenant l'univers de Mario et de ses amis (et ennemis). Sur de nombreux circuits, choisissez votre personnage préféré et lancez-vous dans des courses de folie. Balancez divers objets comme des carapaces ou des peaux de bananes sur vos concurrents afin de prendre la tête. Un mode multi permet, en wi-fi ou en local, d'affronter ses amis pour de grands moments d'anthologie.",
               @"/Ressources;Component/images/Franchises/Mario/Jeux/MarioKart/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Course,
              },
              new HashSet<Plateformes>(){
                Plateformes.DS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioKart/visuel.jpg", "Circuit plage Cheep Cheep"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioKart/visuel1.bmp", "Circuit Mario"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioKart/visuel3.jpg", "Circuit Cascades Yoshi"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioKart/visuel4.jpg","Les caractéristiques du kart")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  
              });

            //

            Jeu Galaxy = new Jeu("Mario Galaxy", new Studio("Nintendo"), new DateTime(2007, 11, 01), 3, "Tous les cent ans, une comète traverse le ciel du Royaume Champignon et y déverse des milliers de fragments d'étoile. Les Toads, gardiens du royaume, s'arment alors de courage et ramassent les fragments d'étoile puis les rassemblent près du château Champignon, où ils fusionnent pour donner naissance à une super étoile. Pour souligner ce don du ciel, une fête est organisée. Dans sa grande bonté, la princesse Peach invite Mario et lui confie au passage qu'elle a quelque chose à lui donner. Fort de cette invitation, Mario se rend au château. Lorsqu'il arrive il est émerveillé par la fête qui bat son plein. Tout semble se passer pour le mieux. Malheureusement pour les invités, les navires volants de Bowser arrivent et attaquent le village des Toads. Des boulets de feu détruisent la ville et des rayons de glace enferment les Toads dans des cristaux. Mario remarque le navire de Bowser qui se dirige vers le château. Le monstre kidnappe Peach ainsi que le château tout entier. Mario tente en vain de sauver Peach, mais Kamek, le bras droit de Bowser, l'en empêche. Mario est projeté dans l'espace et atterrit sur une planète inconnue. Il y rencontre un Luma, un petit personnage étoile, qui se change en lapin lunaire et se met à lui parler. Grâce à lui, Mario fait bientôt la rencontre de la mystérieuse princesse Harmonie, mère des étoiles. Elle lui ouvre les portes de la station orbitale, à partir de laquelle Mario aura accès aux différentes galaxies. Mario part alors à travers elles dans l'espoir de repeupler la station des Luma et de retrouver la trace de Peach et de Bowser.",
                @"/Ressources;Component/images/Franchises/Mario/Jeux/MarioGalaxy/vignette.jpeg",
              new HashSet<Genres>() {
                Genres.Plateforme,
                Genres.Aventure
              },
              new HashSet<Plateformes>(){
                Plateformes.Wii,
                Plateformes.Wii_U,
                Plateformes.NintendoSwitch,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioGalaxy/visuel1.jpg", "Mario contre Bowser"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioGalaxy/visuel2.jpg", "La princesse Harmonie"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioGalaxy/visuel3.jpg", "La carte des différentes galaxies"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioGalaxy/visuel4.jpg","GamePlay")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("La famille de la princesse Harmonie","L’une des parties les plus mémorables de Super Mario Galaxy est le livre d’histoire d’Harmonie, qui révèle son passé bouleversant à mesure que l’on avance dans le jeu. Harmonie (qui a passé une éternité à attendre que sa mère revienne) finit par s’effondrer et admettre qu’elle ne reviendra jamais, car « elle dort sous l'arbre au sommet de la colline ». Mais à un autre moment dans l’histoire, il est expliqué comment Harmonie avait pour habitude de « suivre son père sur la colline pour observer les étoiles » et comment « elle et son frère descendaient en hiver en bas de la colline. » Ce qui est clair, c'est que sa mère est morte et est enterrée sous la colline. Mais qu’est-il arrivé à son père et à son frère, et pourquoi ne sont-ils pas revenus pour elle ?"),
                  new Theorie("Les véritables parents d'Harmonie","En 2007, les fans de Mario font la connaissance d’un tout nouveau personnage, Harmonie. Un personnage complètement inédit mais qui va soulever très vite de nombreuses questions, à commencer par celle qui demeure encore inconnue : qui est-elle vraiment ? Certains éléments nous permettent d’appuyer une théorie très populaire : ce personnage est en réalité la fille… de Mario et Peach. Premier point important : le personnage ressemble assez étrangement à Peach. En plus d’être blonde, elle a aussi les mêmes yeux que cette dernière. On peut alors penser, grâce au physique, qu’il existe un lien de parenté avec Peach (soeur, mère, ou encore fille). D’où vient Harmonie ? Dans Super Mario Galaxy, on découvre petit à petit son histoire dans la bibliothèque de l'observatoire, mais l’histoire de sa naissance ainsi que de ses parents sont totalement restés secrets. La seule chose que nous savons est que son père possède une moustache longue (tiens, tiens), et que sa mère est morte il y a déjà longtemps. On sait aussi au début de son histoire qu'elle adore regarder les étoiles depuis une colline très haute, une passion qui pourrait très bien avoir été transmise par un père qui adorait lui aussi collectionner les étoiles (ça ne vous rappelle pas quelqu’un ?). De plus, on voit sur l'image qui illustre cette page un château ressemblant énormément à celui du royaume Champignon, celui où réside bien souvent Peach. Très vite devenue populaire chez les fans, la théorie faisant d’Harmonie la fille de Mario et Peach, qui aurait donc pu rencontrer ses parents grâce à une histoire de voyage dans le temps, donnerait un peu plus de magie et d’émotions à cet univers...en tout cas nous on y croit."),
              });

            //

            Jeu Odyssey = new Jeu("Mario Odyssey", new Studio("Nintendo"), new DateTime(2017, 10, 2), 3, "Bowser enlève Peach pour se marier avec elle. Mario rencontre une créature ressemblant à un chapeau, un Chapiforme, portant le nom de Cappy. Bowser a aussi enlevé sa sœur, Tiara. Mario et Cappy récupèrent un vaisseau abandonné, l'Odyssée, et voyagent de pays en pays à la poursuite de Bowser. Dans la majorité des mondes, ils doivent combattre les Broodals, une bande de lapins anthropomorphiques organisateurs de mariage qui essaie de les empêcher de rattraper Bowser et d'arrêter le mariage.",
               @"/Ressources;Component/images/Franchises/Mario/Jeux/MarioOdyssey/vignette.png",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Plateforme,
                Genres.Action,
              },
              new HashSet<Plateformes>(){
                Plateformes.NintendoSwitch,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioOdyssey/visuel1.jpg", "Mario avec Cappy à bord de l'Odyssée"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioOdyssey/visuel2.jpg", "Mario découvre une lune"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioOdyssey/visuel3.jpg", "Mario en tenue d'explorateur"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioOdyssey/visuel4.jpg","Mario au Pays des Sables")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("Donkey Kong a sa propre ville?","Commençons par le mystère le plus récent, celui qui a inspiré l’idée de cet article au départ. Le trailer de Super Mario Odyssey s’ouvre dans une ville qui ressemble un peu à New York, mais qui s’appelle en fait New Donk City. Il y a aussi des rues nommées d’après Dixie Kong et Cranky Kong, donc c’est quoi ce bordel ? Comment Donkey Kong a-t-il pu hériter de toute une ville, alors qu’il vit d’habitude dans la jungle ? Espérons que le jeu final fera un peu la lumière sur cette situation. Mais on a remarqué que l’un des gratte-ciels ressemble dangereusement à l’Empire State Building. Est-ce que Mario pourrait se retrouver dans un combat à la King Kong au sommet du building avec le singe de Nintendo ?"),
                  new Theorie("La mort de Mario?","Voici une théorie effrayante : Mario est mort tout au long des événements de Super Mario Odyssey . Il n'est pas difficile de croire que le jeu est le fantasme de la mort de Mario, compte tenu à quel point la prémisse est étrange depuis le tout début. Après avoir été pris en embuscade par Bowser sur un dirigeable, Mario tombe apparemment à mort, pour se retrouver dans un étrange monde noir et blanc (poilu ?) Peuplé de fantômes portant des chapeaux (essentiellement ce qu'est Cappy), qui donnent au nouvel environnement du héros une sensation nettement surnaturelle. À partir de là, l'aventure de Mario commence véritablement, alors qu'il explore de nombreux mondes étranges, dont de nombreux nostalgiques qui reviennent sur ses aventures passées. Serait-ce la vie de Mario qui défile devant ses yeux ? Cela expliquerait certainement pourquoi New Donk City fait penser à sa première aventure dans Donkey Kong ..."),
                  new Theorie("Mario et Cappy","Une théorie suggère que Mario et Cappy sont le même être... C'est fou, mais il y a quelques indices que celui-ci pourrait être vrai. D'une part, comment se fait-il que Mario perde sa forme physique lorsqu'il jette son chapeau pour posséder des objets dans le jeu ? S'il s'avère que Mario et Cappy sont des entités distinctes, le héros ne devrait-il pas garder son propre corps lorsqu'il possède des choses ? La théorie postule que le Mario que nous rencontrons dans ce jeu n'est pas du tout Mario mais un power-up sensible qui a pris la forme du personnage comme un vaisseau pour sa grande aventure. Fondamentalement, cette théorie répondrait à la question : « Où vont les bonus de Mario après leur suppression ? »"),
              });

            //

            Jeu Bros = new Jeu("Super Mario Bros", new Studio("Nintendo"), new DateTime(1985, 09, 13), 3, "L'action se déroule dans un univers fictif nommé le Royaume Champignon où habitent la princesse Toadstool et ses serviteurs, les Toads. Un jour, une horde de Koopas maléfiques et de résistants Goombas envahit le Royaume Champignon et transforme tous ses habitants en briques, engendrant la chute du royaume. Seule la princesse Toadstool peut inverser le sort et restaurer la paix dans le royaume, mais malheureusement, elle se fait kidnapper par Bowser, le roi des Koopas. Mario, le héros de l'histoire, est mis au courant de la situation catastrophique du royaume et de ses habitants, et décide de partir à l'aventure pour libérer la princesse Toadstool des griffes de Bowser.",
               @"/Ressources;Component/images/Franchises/Mario/Jeux/MarioBros/vignette.png",
              new HashSet<Genres>() {
                Genres.Plateforme,
              },
              new HashSet<Plateformes>(){
                Plateformes.Gameboy_Color,
                Plateformes.Gameboy,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioBros/visuel1.jpg", "GamePlay du jeu"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioBros/visuel2.png", "Menu principal"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioBros/visuel3.jpg", ""),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioBros/visuel4.jpg","")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("Mario le gentil de l'histoire?","Le lore de Mario a été réécrit pas mal de fois au fil des années. Mais dans le premier Super Mario Bros. de 1985, un élément particulier de l’histoire semblait un peu perturbant. D’après le manuel du jeu, le Royaume Champignon a été envahi par les Koopa, « une tribu de tortues reconnue pour sa magie noire » dirigée par Roi Koopa (qui sera plus tard renommé Bowser). Les Koopa commencent à utiliser cette magie partout, et « le peuple Champignon, tranquille et paisible, fut transformé en pierres, en briques, et le royaume Champignon tomba en ruine ». Eh oui, en briques. Autrement dit, à chaque fois que Mario sautait et cassait une brique, il brisait en fait en petits morceaux un habitant sans défense du Royaume Champignon. Et vous qui pensiez que Mario était inoffensif !"),
                  new Theorie("La profession de Mario","C’est un véritable mythe qui pourrait bien s’effondrer… Depuis plus de 30 ans, il y a une chose dont nous sommes sûrs, c’est que Mario est un plombier. Doté de capacités exceptionnelles certes mais un plombier avant tout, toujours avec sa salopette et sa casquette de travail. Mais une théorie apparue il y a quelques années vient tout remettre en question puisque Mario serait en fait… un jardinier. Comment l’expliquer ? Grâce aux fameuses plantes-piranhas qui sortent de tuyaux. Dans le tout premier Super Mario Bros, le manuel du jeu nous explique que ces créatures sortent en fait de pots de fleurs. On pourrait aussi se pencher sur les Goomba qui, pour les défenseurs de cette théorie, représentent en fait les pucerons qui pullulent parfois dans un jardin. Même chose pour les Koopa, qui seraient en réalité les tortues, souvent décrites comme les ennemis d’un jardin et d’un potager. Dans Super Mario Bros 2, le héros a même la possibilité de déterrer des légumes et dans Mario Sunshine, le voici équipé d’un canon à eau, lui permettant d’arroser ses ennemis. Plombier, charpentier (dans sa toute première apparition), sportif de haut niveau, docteur et donc jardinier… Mario sait décidément tout faire."),
              });

            //

            Jeu Time = new Jeu("Partners in Time", new Studio("Nintendo"), new DateTime(2005, 11, 28), 3, "Le professeur K. Tastroff a inventé une machine permettant de voyager dans le temps. La princesse Peach, enthousiaste, décide d'aller visiter le Royaume Champignon d'antan. Au même moment, dans le passé, celui-ci est envahi par les Xhampis, sortes d'extraterrestre mycéliformes violets, et la princesse va une fois de plus se faire enlever. La machine, fortement endommagée à la suite de l'attaque, est inutilisable. Mario et Luigi partent alors à sa rescousse dans le passé, au moyen de failles spatiotemporelles apparues dans le château, où ils retrouveront leurs alter ego du passé (bébés). Les deux frères les prennent alors sur le dos et l'aventure se poursuit désormais à quatre.",
               @"/Ressources;Component/images/Franchises/Mario/Jeux/MarioPartnersTime/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Action
              },
              new HashSet<Plateformes>(){
                Plateformes.Gamecube,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioPartnersTime/visuel1.jpg", "Yoshi Géant"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioPartnersTime/visuel2.jpg", "Château de Bowser"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioPartnersTime/visuel3.jpg", "Dans le territoire des Xhampis a"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Mario/Jeux/MarioPartnersTime/visuel4.jpg","GamePlay")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
             
              });

            // Layton

            Jeu Village = new Jeu("Professeur Layton l'étrange village", new Studio("Nintendo/Level-5"), new DateTime(2007, 02, 15), 7, "Le professeur Layton et son assistant Luke se rendent au petit village de Saint-Mystère à la demande de Dahlia Reinhold, deuxième femme de feu le baron Reinhold, qui souhaite leur aide pour résoudre une énigme laissée par son défunt époux. Le baron avait écrit dans son testament que quiconque retrouverait la Pomme d'Or, cachée dans le village, hériterait de toute sa fortune.Les deux investigateurs parviennent aux abords de la ville et constatent rapidement que la majorité des habitants est passionnée d'énigmes et de casse-tête en tout genre, desquels le professeur et le jeune garçon sont aussi férus. Ils peuvent également voir au loin une mystérieuse tour située au centre du village...",
               @"/Ressources;Component/images/Franchises/Layton/Jeux/Village/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Reflexe
              },
              new HashSet<Plateformes>(){
                Plateformes.DS,
                Plateformes.Android,
                Plateformes.IOS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Village/visuel1.jpg", "L'entrée du village"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Village/visuel2.jpg", "Mini Jeu"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Village/visuel3.jpg", "Menu principal"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Village/visuel4.jpg","Enigme 1"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Village/visuel5.jpg","Enigme 2")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });

            //

            Jeu BoitePandore = new Jeu("Professeur Layton et la Boîte de Pandore", new Studio("Nintendo/Level-5"), new DateTime(2007, 11, 29), 7, "Les événements de ce jeu se déroulent un an après Professeur Layton et l'Étrange Village.Le professeur Hershel Layton et son apprenti, Luke, reçoivent une lettre d'Andrew Schrader, savant respecté, mentor et ami du professeur, qui contient des informations sur le coffret céleste, communément appelé la \"Boîte de Pandore\". Inquiets, Layton et Luke décident d'aller voir Andrew, mais une fois sur place ces derniers le trouvent mort et le coffret a disparu.Dans le bureau du défunt, Layton et Luke trouvent un ticket pour le Molentary Express et une photo déchirée.Ils décident de prendre le train pour retrouver la Boîte de Pandore.Une fois arrivés à Dropstone, les deux héros découvrent une destination mystère du Molentary Express: Folsense, une ville fantôme.",
               @"/Ressources;Component/images/Franchises/Layton/Jeux/BoitePandore/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Reflexion
              },
              new HashSet<Plateformes>(){
                Plateformes.DS,
                Plateformes.Android,
                Plateformes.IOS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/BoitePandore/visuel1.jpg", "L'écran d'acceuil"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/BoitePandore/visuel2.png", "Les deux amants"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/BoitePandore/visuel3.jpg", "Fans le train"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/BoitePandore/visuel4.png","Mini jeu")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });

            //

            Jeu Destin = new Jeu("Professeur Layton et le Destin Perdu", new Studio("Nintendo/Level-5"), new DateTime(2008, 12, 13), 7, "Les évènements de ce jeu se déroulent un an après Professeur Layton et la Boîte de Pandore.Le Professeur Layton et Luke, reçoivent une lettre leur demandant de l\'aide envoyée par...Luke, 10 ans après. Le professeur croyant à une farce de son jeune assistant n\'y accordera pas d\'importance mais part enquêter une semaine plus tard après la disparition de Bill Hawks, le premier ministre de Londres, dans l\'explosion d\'une hypothétique machine à remonter le temps. La lettre lui disant de se rendre à une horlogerie, Layton et Luke découvriront une horloge qui les propulsera 10 ans dans le futur. Retrouvez un Luke adulte mais aussi Flora, l\'inspecteur Chelmey et Don Paolo dans 165 nouvelles énigmes et casses - tête où l\'adversaire de Hershel Layton sera...Hershel Layton lui-même, son futur puis son passé ",
               @"/Ressources;Component/images/Franchises/Layton/Jeux/Destin/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Reflexion
              },
              new HashSet<Plateformes>(){
                Plateformes.DS,
                Plateformes.TroisDS,
                Plateformes.Android,
                Plateformes.IOS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Destin/visuel1.jpg", "Professeur Layton, Luke, Luke du Futur et Flora"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Destin/visuel2.jpg", "Dans le futur"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Destin/visuel3.png", "Professeur Layton jeune et Claire"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Destin/visuel4.jpg","Mini jeu")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });

            //

            Jeu Spectre = new Jeu("Professeur Layton et L'appel du Spectre", new Studio("Nintendo/Level-5"), new DateTime(2009, 11, 26), 7, "Les évènements de ce jeu se déroulent trois ans avant Professeur Layton et l'étrange village. Le professeur Hershel Layton est un archéologue respecté par ses pairs, grand amateur d'énigmes, casse-tête, rébus et autres mystères. Ses capacités de réflexion font de lui un homme hors du commun lui permettant de faire la lumière sur toutes les affaires qu'on lui soumet, même les plus déroutantes. Un jour, le professeur Layton reçoit une missive des plus surprenantes de la part de Clark Triton, l'un de ses vieux amis : \"La nuit, un effroyable géant nimbé de brume rase nos maisons !\" Guidés par un message caché dans la lettre, le professeur Layton et Emmy, sa nouvelle assistante, se rendent dans la ville de Misthallery afin de faire toute la lumière sur ce mystère. Dans cette ville, ils rencontreront Luke, un petit garçon qui affirme savoir quand la fin du monde arrivera. \"Lorsque le son de la flûte résonnera dans toute la ville, le spectre apparaîtra...\" Voilà un extrait de la légende du spectre, transmise de génération en génération à Misthallery.Serait - il la cause de la vague de destruction qui déferle sur la ville ? Cette question est au cœur d'autres mystères que le professeur Layton est bien déterminé à résoudre. Quelle est cette sombre menace qui pèse sur la ville ? Nos héros découvrirons-ils la vérité sur le spectre ?",
               @"/Ressources;Component/images/Franchises/Layton/Jeux/Spectre/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Reflexion
              },
              new HashSet<Plateformes>(){
                Plateformes.DS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Spectre/visuel1.jpg", "Professeur Layton et Emmy"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Spectre/visuel2.jpg", "GamePlay"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Spectre/visuel3.jpg", "Luc et Arianna"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Spectre/visuel4.jpg","La découverte de la brume")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });

            //

            Jeu Aslante = new Jeu("Professeur Layton et l'Héritage des Aslantes", new Studio("Nintendo/Level-5"), new DateTime(2013, 02, 28), 7, "Un an après les événements du Masque des Miracles, le Docteur Sycamore découvre les vestiges d'une ancienne civilisation, les Aslantes. Au coeur de ces vestiges se cacherait la momie d'une fille à la beauté enivrante qui - malgré les années - serait toujours en vie.Accompagnez le Professeur Layton et Luke son apprenti vers 5 destinations et menez l'enquête à travers 500 énigmes inédites pour percer le secret de cette momie et de sa civilisation. Ces 500 épreuves comprennent plus de 150 casse-tête ponctuant le long de l'aventure, et plus de 365 à télécharger gratuitement chaque jour pendant un an après le lancement du jeu.",
               @"/Ressources;Component/images/Franchises/Layton/Jeux/Aslantes/vignette.png",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.Reflexion
              },
              new HashSet<Plateformes>(){
                Plateformes.TroisDS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Aslantes/visuel1.jpg", "Enigme 1"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Aslantes/visuel2.png", "Gaïa"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Aslantes/visuel3.jpg", "Enigme 2"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Layton/Jeux/Aslantes/visuel4.jpg","Professeur Layton, Emma, Luc et l'archéologue Desmond Sycamore")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("Jean Descol?","Jean Descole est un éminent scientifique, notamment dans le domaine de l'archéologie. Il est âgé de quelques années de plus que Layton et porte un costume noir, agrémenté d'un boa de plumes blanches, un masque totalement blanc, un chapeau de type un peu \"pirate\" (de très loin) et une grande cape noire. Son nom de naissance est Hershel Bronev, il est le fils de Rachel Bronev et Léon Bronev. Son petit frère, Théodore Bronev est plus connu sous le nom d'Hershel Layton. Ils furent séparés peu après l'enlèvement de leurs parents par l'organisation TARGET. C'est à ce moment qu'il abandonna ce nom contre Desmond Sycamore. Il tira ainsi un trait sur son passé. Il aurai pu rester ainsi si un second drame n'avait pas secoué sa vie: La disparition de sa femme et de sa fille. Il jette alors son nom et l'humanité qu'il lui restait pour devenir un monstre : Jean Descole. Il ne vit alors plus que pour sa vengeance contre TARGET et les Aslantes, qu'il estime responsables de son malheur. Une phrase de Gaïa sème cependant le doute dans son esprit :  \"Vous vous cachez derrière ce masque, mais je vous sais capable d\'aimer et d\'espérer\" Ce qui lui arrive après l'héritage des Aslantes est flou. "),
              });

            //DragonQuest

            //
            Jeu Neuf = new Jeu("Dragon Quest IX: Les Sentinelles du firmament", new Studio("Level-5"), new DateTime(2009, 07, 11), 12, "L'Observatoire est le foyer de l'Yggdrasil, le grand arbre du monde, ainsi que des Célestelliens, des êtres chargés par le Tout-Puissant de surveiller et de protéger le monde des mortels. D'après la légende, quand les fyggs sacrées pousseront enfin sur les branches de l'Yggdrasil, un train doré céleste du nom d'Orion Express viendra chercher les Célestelliens pour les emmener au royaume du Tout-Puissant. Dans le but de faire pousser les fyggs, les Célestelliens recueillent depuis la nuit des temps la bienveillessence, matérialisation de la reconnaissance des humains, et l'offrent au grand arbre du monde. Mais aujourd'hui, alors que les fyggs sont sur le point de naître, une histoire incroyable va se dérouler, au cours de laquelle les Célestelliens vont plus que jamais partager le sort de leurs mortels protégés.",
             @"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Neuf/vignette.jpg",
            new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
            },
            new HashSet<Plateformes>(){
                Plateformes.DS,
            },
            new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Neuf/visuel1.jpg", "L'Observatoir"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Neuf/visuel2.jpg", "Entrée d'un village"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Neuf/visuel3.jpg", "GamePlay"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Neuf/visuel4.jpg","Combat")
            },
            new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
            },
            new HashSet<Theorie>()
            {
                  new Theorie("",""),
            });

            //

            Jeu Dix = new Jeu("Dragon Quest X", new Studio("Square Enix"), new DateTime(2012, 08, 02), 12, "Dragon Quest X est un MMO dans l'univers de Dragon Quest. Le jeu offre la possibilité d'incarner six races différentes : les humains, les ogres, les elfes, les nains, les pukuripos et les wedis. Elles sont réparties sur les cinq continents du nouveau monde appelé Astortia. En plus de ces six races, six vocations sont disponibles dès le début du jeu : guerrier, mage, prêtre, artiste martial, voleur et troubadour.",
          @"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Dix/vignette.jpg",
         new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
         },
         new HashSet<Plateformes>(){
                Plateformes.Wii,
                Plateformes.Wii_U,
                Plateformes.TroisDS,
                Plateformes.NintendoSwitch,
                Plateformes.PS4,
         },
         new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Dix/visuel1.jpg", "Les différents personnages"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Dix/visuel2.jpg", "Combat"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Dix/visuel3.jpg", "Personnalisation d'un personnage"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Dix/visuel4.jpg","Image du jeu")
         },
         new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
         },
         new HashSet<Theorie>()
         {
                  new Theorie("",""),
         });

            //

            Jeu Onze = new Jeu("Dragon Quest XI : Les Combattants de la destinée", new Studio("	Square Enix"), new DateTime(2017, 07, 29), 12, "Partez à l’aventure dans l’édition définitive de Dragon Quest XI S : les combattants de la destinée. Incarnez l'Éclairé, un jeune héros qu'on accuse d'être l’enfant de l'Ombre, et réunissez une attachante bande d'aventuriers dessinés par le célèbre mangaka Akira Toriyama. Voyagez aux confins du monde, prenez part à des combats en tour par tour, guidez vos compagnons dans des quêtes épiques pour découvrir vos origines et celle du mal qui plane sur le monde…",
          @"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Onze/vignette.jpg",
         new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
         },
         new HashSet<Plateformes>(){
                Plateformes.PS4,
                Plateformes.NintendoSwitch,
                Plateformes.TroisDS,
                Plateformes.XboxOne,
         },
         new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Onze/visuel1.jpg", "Les différents personnages"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Onze/visuel2.jpg", "Le mode \"rétro\""),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Onze/visuel3.jpg", "Dans une ville"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Onze/visuel4.jpg","Combat")
         },
         new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
         },
         new HashSet<Theorie>()
         {
                  new Theorie("",""),
         });

            //

            Jeu Quatre = new Jeu("Dragon Quest IV: L'Épopée des élus", new Studio("Chunsoft"), new DateTime(1990, 02, 11), 12, "Tout commence par l'étrange disparition de tous les enfants du royaume de Bastione. Le roi, inquiet, décide alors d'envoyer son meilleur et plus fidèle élément, Ragnar, le capitaine des soldats royaux, enquêter sur cette tragédie. À l'autre bout du continent, la jeune tsarine de Zamoksva, Alina, veut quitter le château de son père et partir à l'aventure. À Lakanabe, Torneko rêve d'ouvrir un magasin d'armes: il travaille chez un marchand et connaît tout de ce commerce mais n'a pas assez d'argent pour créer son entreprise et travailler à son propre compte. Il décide de quitter sa femme et son fils pour partir dans le désert dans l'espoir de devenir le plus grand marchand d'armes du monde. Mina et Maya, deux sœurs, filles de Mahabala, un alchimiste renommé, assassiné mystérieusement, décident de quitter leur cabaret pour venger la mort de leur père. Mina est diseuse de bonne aventure et Maya est une danseuse hors pair. Dans le dernier chapitre du jeu, le héros -vous-, après la dévastation de votre village, retrouve progressivement tous les personnages dont on a vécu les aventures dans les chapitres précédents. Ainsi, Ragnar, Alina (ainsi que Borya le magicien et Kiryl le prêtre, qui accompagnent Alina), Torneko, Mina et Maya vont unir leurs forces pour combattre un ennemi commun, Psaro l'Exterminateur, le maître du Mal.",
          @"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Quatre/vignette.png",
         new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
         },
         new HashSet<Plateformes>(){
                Plateformes.NES,
                Plateformes.PS1,
                Plateformes.IOS,
                Plateformes.Android,
         },
         new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Quatre/visuel1.jpg", "GamePlay"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Quatre/visuel2.jpg", "L'extérieur de la ville"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Quatre/visuel3.jpg", "Dans l'église"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Quatre/visuel4.jpg","Les différents personnages")
         },
         new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
         },
         new HashSet<Theorie>()
         {
                  new Theorie("",""),
         });

            //

            Jeu Builder = new Jeu("Dragon Quest Builders 2", new Studio("Square Enix"), new DateTime(2018, 12, 20), 7, "Dragon Quest Builders 2 est un jeu vidéo d'action-RPG et bac-à-sable développé et édité par Square Enix. Il s'agit d'une série dérivée de la franchise Dragon Quest et de la suite de Dragon Quest Builders. Il est sorti sur Nintendo Switch et PlayStation 4 le 20 décembre 2018 au Japon et le 12 juillet 2019 dans le reste du monde. Le jeu dispose d'un style graphique en blocs et introduit un système de collecte et de construction comparable au jeu Minecraft2. Contrairement à son prédécesseur, cet opus à la particularité de pouvoir être joué à plusieurs adoptant ainsi une dimension multijoueur. Aussi l'histoire n'est plus divisée en chapitres représentés par des îles, mais constituée d'un seul vaste monde.",
          @"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Builder/vignette.jpg",
         new HashSet<Genres>() {
                Genres.RPG,
                Genres.Action
         },
         new HashSet<Plateformes>(){
                Plateformes.PS4,
                Plateformes.NintendoSwitch,
         },
         new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Builder/visuel1.jpg", "Mode construction"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Builder/visuel2.jpg", "Récupération de ressources"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Builder/visuel3.jpg", "La ville"),
                    new Visuel(@"/Ressources;Component/images/Franchises/DragonQuest/Jeux/Builder/visuel4.jpg","Le village construit")
         },
         new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
         },
         new HashSet<Theorie>()
         {
                  new Theorie("",""),
         });

            //Pokemon

            //

            Jeu Diamant = new Jeu("Pokémon version Diamant", new Studio("Game Freak"), new DateTime(2006, 09, 28), 3, "L'action de Pokémon Diamant et Perle se déroule à Sinnoh, basée sur la région japonaise d'Hokkaido. Insulaire, elle est constituée de quatorze villes peuplées par des humains et de routes terrestres et maritimes qui les relient entre elles. Chaque zone géographique de la région est habitée par différentes espèces de créatures appelées Pokémon. Si le joueur prend le personnage masculin, Louka de Bonaugure est le protagoniste de Pokémon Diamant et Perle, sinon ce sera Aurore, le protagoniste féminin et personnage important de la série.Louka ou Aurore vit à Bonaugure(Twinleaf TownN 1), dans la région de Sinnoh.Un jour, alors qu'il/elle se promenait avec son meilleur ami Barry, il/elle tombe sur une mallette contenant des Poké Balls. Tout d'un coup, des Étourmi les attaquent, lui / elle et Barry.Les deux enfants se servent d'un des Pokémon dans la mallette pour vaincre les Étourmi. Les Pokémon sont Tortipouss, Ouisticram et Tiplouf (Turtwig, Chimchar et Piplup). Le professeur Sorbier (Rowan), qui est le propriétaire des Pokémon, décide de le leur confier comme « Pokémon de départ »1. Tout au long du jeu, les deux personnages devront déjouer les plans maléfiques de la Team Galaxy, qui tente de s'approprier le Pokémon légendaire Dialga ou Palkia, selon la version, afin de créer un nouvel univers.",
               @"/Ressources;Component/images/Franchises/Pokemon/Jeux/Diamant/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
              },
              new HashSet<Plateformes>(){
                Plateformes.DS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Diamant/visuel1.png", "Pokémon légendaire"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Diamant/visuel2.jpg", "Combat"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Diamant/visuel3.png", "Duel"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Diamant/visuel4.jpg","La Pokémontre")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });

            //

            Jeu Perle = new Jeu("Pokémon version Perle", new Studio("Game Freak"), new DateTime(2002, 12, 13), 7, "L'action de Pokémon Diamant et Perle se déroule à Sinnoh, basée sur la région japonaise d'Hokkaido. Insulaire, elle est constituée de quatorze villes peuplées par des humains et de routes terrestres et maritimes qui les relient entre elles. Chaque zone géographique de la région est habitée par différentes espèces de créatures appelées Pokémon. Si le joueur prend le personnage masculin, Louka de Bonaugure est le protagoniste de Pokémon Diamant et Perle, sinon ce sera Aurore, le protagoniste féminin et personnage important de la série.Louka ou Aurore vit à Bonaugure(Twinleaf TownN 1), dans la région de Sinnoh.Un jour, alors qu'il/elle se promenait avec son meilleur ami Barry, il/elle tombe sur une mallette contenant des Poké Balls. Tout d'un coup, des Étourmi les attaquent, lui / elle et Barry.Les deux enfants se servent d'un des Pokémon dans la mallette pour vaincre les Étourmi. Les Pokémon sont Tortipouss, Ouisticram et Tiplouf (Turtwig, Chimchar et Piplup). Le professeur Sorbier (Rowan), qui est le propriétaire des Pokémon, décide de le leur confier comme « Pokémon de départ ». Tout au long du jeu, les deux personnages devront déjouer les plans maléfiques de la Team Galaxy, qui tente de s'approprier le Pokémon légendaire Dialga ou Palkia, selon la version, afin de créer un nouvel univers.",
               @"/Ressources;Component/images/Franchises/Pokemon/Jeux/Perle/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
              },
              new HashSet<Plateformes>(){
                Plateformes.DS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Perle/visuel1.jpg", "Pokémon Légendaire"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Perle/visuel2.jpg", "La Pokémontre"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Perle/visuel3.jpg", "Dans un champ de fleurs"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Perle/visuel4.jpg","Le centre de soin")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });

            //

            Jeu Rubis = new Jeu("Pokémon version Rubis", new Studio("Game Freak"), new DateTime(2002, 11, 21), 3, "L'action de Pokémon Rubis et Saphir se déroule dans la région fictive de Hoenn. Insulaire, elle est constituée de six villes et neuf villages peuplés par des humains et de routes terrestres, maritimes et sous-marines qui les relient entre elles. Chaque zone géographique de la région est habitée par différentes espèces de créatures appelées Pokémon. Le protagoniste de Pokémon Rubis et Saphir est un jeune garçon appelé Ruby ou Brice ou une jeune fille nommée Sapphire ou Flora qui vient d'emménager à Bourg-en-Vol2 (Littleroot TownN 1). Le père du héros ou de l'héroïne est champion d'arène. Au début du jeu, il ou elle va aider le professeur Seko (Birch) attaqué par une espèce de Pokémon. Le professeur demande au protagoniste de lui venir en aide en choisissant un Pokémon parmi les trois proposés : Arcko, Poussifeu et Gobou (Treecko, Torchic et Mudkip). Afin de le remercier, le professeur donnera au joueur le Pokémon choisi comme « Pokémon de départ ». Après avoir traversé la première ville, le rival défie le joueur dans un combat où s'affrontent leurs deux Pokémon de départ ; il continuera de combattre le héros tout au long de son aventure. Le joueur entame alors une quête à travers Hoenn, capturant les Pokémon sauvages, les entraînant et combattant avec ceux des autres dresseurs Pokémon, avec pour but de d'obtenir le titre de « Maître Pokémon », comme pour les opus précédents. Pour cela, il rencontrera dans certaines villes des établissements spéciaux appelées « arènes », à l'intérieur desquelles demeure un champion que le joueur devra battre dans un combat Pokémon pour obtenir un badge. Une fois les huit badges acquis, le joueur sera autorisé à combattre la Ligue Pokémon, qui se compose des meilleurs dresseurs de Pokémon de la région. Le héros devra défaire les quatre membres de la Ligue et le maître ultime afin de devenir Maître Pokémon2. Au cours de l'aventure, le joueur rencontrera plusieurs fois deux organisations criminelles : la Team Magma et la Team Aqua. La Team Magma souhaite contrôler Groudon, afin d'agrandir les terres et la Team Aqua souhaite contrôler Kyogre, afin d'étendre les mers. Dans Pokémon Rubis, la Team Magma est l'adversaire du joueur, dans Pokémon Saphir, il s'agit de la Team Aqua. L'autre organisation est alliée.",
               @"/Ressources;Component/images/Franchises/Pokemon/Jeux/Rubis/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
              },
              new HashSet<Plateformes>(){
                Plateformes.Gameboy_Advance,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Rubis/visuel1.png", "Pokémon Légendaire"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Rubis/visuel2.jpg", "Dans le vilage au bord de l'eau"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Rubis/visuel3.png", "Lecture sur une pierre"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Rubis/visuel4.png","Pokémon Légendaire 2")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });


            //


            Jeu Saphire = new Jeu("Pokémon version Saphir", new Studio("Game Freak"), new DateTime(2002, 11, 21), 3, "L'action de Pokémon Rubis et Saphir se déroule dans la région fictive de Hoenn. Insulaire, elle est constituée de six villes et neuf villages peuplés par des humains et de routes terrestres, maritimes et sous-marines qui les relient entre elles. Chaque zone géographique de la région est habitée par différentes espèces de créatures appelées Pokémon. Le protagoniste de Pokémon Rubis et Saphir est un jeune garçon appelé Ruby ou Brice ou une jeune fille nommée Sapphire ou Flora qui vient d'emménager à Bourg-en-Vol2 (Littleroot TownN 1). Le père du héros ou de l'héroïne est champion d'arène. Au début du jeu, il ou elle va aider le professeur Seko (Birch) attaqué par une espèce de Pokémon. Le professeur demande au protagoniste de lui venir en aide en choisissant un Pokémon parmi les trois proposés : Arcko, Poussifeu et Gobou (Treecko, Torchic et Mudkip). Afin de le remercier, le professeur donnera au joueur le Pokémon choisi comme « Pokémon de départ ». Après avoir traversé la première ville, le rival défie le joueur dans un combat où s'affrontent leurs deux Pokémon de départ ; il continuera de combattre le héros tout au long de son aventure. Le joueur entame alors une quête à travers Hoenn, capturant les Pokémon sauvages, les entraînant et combattant avec ceux des autres dresseurs Pokémon, avec pour but de d'obtenir le titre de « Maître Pokémon », comme pour les opus précédents. Pour cela, il rencontrera dans certaines villes des établissements spéciaux appelées « arènes », à l'intérieur desquelles demeure un champion que le joueur devra battre dans un combat Pokémon pour obtenir un badge. Une fois les huit badges acquis, le joueur sera autorisé à combattre la Ligue Pokémon, qui se compose des meilleurs dresseurs de Pokémon de la région. Le héros devra défaire les quatre membres de la Ligue et le maître ultime afin de devenir Maître Pokémon2. Au cours de l'aventure, le joueur rencontrera plusieurs fois deux organisations criminelles : la Team Magma et la Team Aqua. La Team Magma souhaite contrôler Groudon, afin d'agrandir les terres et la Team Aqua souhaite contrôler Kyogre, afin d'étendre les mers. Dans Pokémon Rubis, la Team Magma est l'adversaire du joueur, dans Pokémon Saphir, il s'agit de la Team Aqua. L'autre organisation est alliée.",
               @"/Ressources;Component/images/Franchises/Pokemon/Jeux/Saphir/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
              },
              new HashSet<Plateformes>(){
                Plateformes.Gameboy_Advance,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Saphir/visuel1.png", "Combat"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Saphir/visuel2.jpg", "Au bord de l'eau"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Saphir/visuel3.png", "Centre de soin"),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/Saphir/visuel4.png","Pokémon Légendaire")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });


            //

            Jeu X = new Jeu("Pokémon X", new Studio("Game Freak"), new DateTime(2013, 10, 12),3, "L'action se situe dans la région fictive de Kalos, inspirée de la France1,2. Elle est constituée de plusieurs villes peuplées par des humains et de routes terrestres ou maritimes qui les relient entre elles. Chaque zone géographique de la région est habitée par différentes espèces de créatures appelées Pokémon, chacune des espèces possédant une zone de répartition différente ; il en existe trois, le centre, la côte et les monts3. Le ou la protagoniste débute dans la ville de Bourg Croquis.Le joueur aura à choisir entre le protagoniste masculin(Kalem) ou le protagoniste féminin(Serena).Il ou elle part avec quatre compagnons4.Parmi eux, Tierno proposera au joueur de choisir entre trois Pokémon de départ, Marisson, Feunnec et Grenousse, puis Trovato lui distribuera un Pokédex, l'encyclopédie fictive recensant les différentes espèces de Pokémon. Le joueur entame alors une quête à travers Kalos, capturant les Pokémon sauvages, les entraînant et combattant avec ceux des autres dresseurs Pokémon, avec pour but de d'obtenir le titre de « Maître Pokémon ». Pour cela, il rencontrera dans certaines villes des établissements spéciaux appelées « arènes », à l'intérieur desquelles demeure un Champion que le joueur devra battre dans un combat Pokémon pour obtenir un badge.Une fois les huit badges acquis, le joueur sera autorisé à combattre la Ligue Pokémon, qui se compose des meilleurs dresseurs de Pokémon de la région.Le héros devra défaire les quatre membres de la Ligue puis, in fine, le maître de la Ligue pour devenir Maître Pokémon5. Tout au long du jeu, le joueur devra combattre les forces de la Team Flare",
               @"/Ressources;Component/images/Franchises/Pokemon/Jeux/X/vignette.jpg",
              new HashSet<Genres>() {
                Genres.Aventure,
                Genres.RPG
              },
              new HashSet<Plateformes>(){
                Plateformes.TroisDS,
              },
              new HashSet<Visuel>() {
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/X/visuel1.jpg", ""),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/X/visuel2.jpg", ""),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/X/visuel3.jpg", ""),
                    new Visuel(@"/Ressources;Component/images/Franchises/Pokemon/Jeux/X/visuel4.png","")
              },
              new HashSet<Musique>(){
                    new Musique("Main theme",@"Ressources;Component/musiques/botw-OST1.mp3","Nintendo",new DateTime(2017, 03, 03))
              },
              new HashSet<Theorie>()
              {
                  new Theorie("",""),
              });


            




            Dictionary<Franchise, List<Jeu>> lesFranchises = new Dictionary<Franchise, List<Jeu>>()
            {
                [fZelda] = new List<Jeu>()
                {
                    BOTW,
                    Phantom,
                    Spirit,
                    Ocarina,
                    Wind,
                   
                },
                [fMario] = new List<Jeu>() 
                {
                    Bros,
                    Kart,
                    Time,
                    Odyssey,
                    Galaxy,
                },
                [fPokemon] = new List<Jeu>() 
                {
                    Perle,
                    Diamant,
                    X,
                    Saphire,
                    Rubis
                },
                [fDragon] = new List<Jeu>() 
                {
                    Neuf,
                    Dix,
                    Onze,
                    Quatre,
                    Builder,
                },
                [fLayton] = new List<Jeu>() 
                {
                    Village,
                    BoitePandore,
                    Destin,
                    Spectre,
                    Aslante,
                },

        };

            IList<Jeu> lesJeux = new List<Jeu>()
            {
                BOTW,
                Phantom,
                Spirit,
                Ocarina,
                Wind,
                Bros,
                Kart,
                Time,
                Odyssey,
                Galaxy,
                Village,
                BoitePandore,
                Destin,
                Spectre,
                Aslante,
                Neuf,
                Dix,
                Onze,
                Quatre,
                Builder,
                Perle,
                Diamant,
                X,
                Saphire,
                Rubis
            };

            return (lesJeux, lesFranchises);
        }

        public void SauvegardeDonnees(IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises)
        {
            throw new NotImplementedException();
        }

        
    }
}
