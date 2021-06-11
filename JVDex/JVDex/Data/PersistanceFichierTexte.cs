﻿using BibliothèqueApplication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data
{
    public class PersistanceFichierTexte : IPersistanceStockApp
    {
        public (IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises) ChargeDonnees()
        {
            Directory.SetCurrentDirectory(Path.Combine(Directory.GetCurrentDirectory(), "..//..//..//..//Data"));
            List<Jeu> lJeux = new List<Jeu>();
            Dictionary<Franchise, List<Jeu>> dFranchise = new Dictionary<Franchise, List<Jeu>>();

            using(FileStream fs = File.OpenRead("infoJVDex.txt"))
            {
                using (TextReader reader = new StreamReader(fs))
                {
                    int.TryParse(reader.ReadLine(), out int nbFranchises); //TryParse = convertit string to int => valeur récup avec out
                    for(int i = 0; i<nbFranchises; i++)
                    {
                        Franchise f = LireFranchise(reader);
                        dFranchise.Add(f, new List<Jeu>());
                        int.TryParse(reader.ReadLine(), out int nbJeux);
                        for(int k = 0; k<nbJeux; k++)
                        {
                            Jeu j = LireJeu(reader);
                            int.TryParse(reader.ReadLine(), out int nbVisuels);
                            for(int z = 0;  z < nbVisuels; z++) 
                            {
                                Visuel v = LireVisuel(reader);
                                j.AjouterVisuel(v);
                            }
                            int.TryParse(reader.ReadLine(), out int nbMusiques);
                            for (int z = 0; z < nbMusiques; z++)
                            {
                                string m = reader.ReadLine();
                                j.AjouterMusique(m);
                            }
                            int.TryParse(reader.ReadLine(), out int nbTheories);
                            for (int z  = 0; z < nbTheories; z++)
                            {
                                Theorie t = LireTheorie(reader);
                                j.AjouterTheorie(t);
                            }

                            j.IsFavoris = bool.TryParse(reader.ReadLine(), out bool isFavori);

                            lJeux.Add(j);
                            dFranchise.TryGetValue(f, out var lFranchise);
                            lFranchise.Add(j);
                        }
                    }
                }
            }
            return (lJeux, dFranchise);
        }

        private Theorie LireTheorie(TextReader reader)
        {
            return new Theorie(reader.ReadLine(), reader.ReadLine());
        }

        public void SauvegardeDonnees(IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises)
        {
            throw new NotImplementedException();
        }

        private Franchise LireFranchise(TextReader reader)
        {
            string nom = reader.ReadLine();
            string image = reader.ReadLine();
            string couleur = reader.ReadLine();
            return new Franchise(nom, image, couleur);
        }

        private Jeu LireJeu(TextReader reader)
        {
            CreateurJeu cj;

            string nom = reader.ReadLine();
            string nomCreateurJeu = reader.ReadLine();
            if (reader.ReadLine() == "c")
            {
                string prenom = reader.ReadLine();
                DateTime.TryParse(reader.ReadLine(), out var dateNaissance);
                cj = new Createur(nomCreateurJeu, prenom, dateNaissance);
            }
            else { cj = new Studio(nomCreateurJeu); }
            DateTime.TryParse(reader.ReadLine(), out var dateCreation);
            int.TryParse(reader.ReadLine(), out var limiteAge);
            string synopsis = reader.ReadLine();
            string image = reader.ReadLine();
            int.TryParse(reader.ReadLine(), out var nbGenres);
            ISet<Genres> genres = new HashSet<Genres>();
            for(int i=0; i<nbGenres; i++)
            {
                int.TryParse(reader.ReadLine(), out var genre);
                genres.Add((Genres)genre);
            }
            int.TryParse(reader.ReadLine(), out var nbPlateformes);
            ISet<Plateformes> plateformes = new HashSet<Plateformes>();
            for (int i = 0; i < nbPlateformes; i++)
            {
                int.TryParse(reader.ReadLine(), out var plateforme);
                plateformes.Add((Plateformes)plateforme);
            }
            return new Jeu(nom, cj, dateCreation, limiteAge, synopsis, image, genres, plateformes);
        }

        private Visuel LireVisuel(TextReader reader)
        {
            string image = reader.ReadLine();
            string legende = reader.ReadLine();
            return new Visuel(image, legende);
        }
    }
}