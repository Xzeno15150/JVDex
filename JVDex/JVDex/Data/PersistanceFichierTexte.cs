using BibliothèqueApplication;
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
                            bool.TryParse(reader.ReadLine(), out bool isFavori);
                            j.IsFavoris = isFavori;
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
            string nom = reader.ReadLine();
            string texte = "";
            string lecture = reader.ReadLine();
            while (lecture != "$$$")
            {
                texte += lecture;
                lecture = reader.ReadLine();
            }
            return new Theorie(nom, texte);
        }

        private string LireSynopsis(TextReader reader)
        {
            string texte = "";
            string lecture = reader.ReadLine();
            while (lecture != "***")
            {
                texte += lecture;
                lecture = reader.ReadLine();
            }
            return texte;
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
            string synopsis = LireSynopsis(reader);
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
            int.TryParse(reader.ReadLine(), out var nbVisuel);
            ISet<Visuel> visuels = new HashSet<Visuel>();
            for (int i = 0; i < nbVisuel; i++)
            {
                visuels.Add(LireVisuel(reader));
            }

            int.TryParse(reader.ReadLine(), out var nbMusique);
            ISet<Musique> musiques = new HashSet<Musique>();
            for (int i = 0; i < nbMusique; i++)
            {
                musiques.Add(LireMusique(reader));
            }

            int.TryParse(reader.ReadLine(), out var nbTheorie);
            ISet<Theorie> theories = new HashSet<Theorie>();
            for (int i = 0; i < nbTheorie; i++)
            {
                theories.Add(LireTheorie(reader));
            }

            return new Jeu(nom, cj, dateCreation, limiteAge, synopsis, image, genres, plateformes,visuels, musiques, theories);
        }

        private Visuel LireVisuel(TextReader reader)
        {
            string image = reader.ReadLine();
            string legende = reader.ReadLine();
            return new Visuel(image, legende);
        }
        private Musique LireMusique(TextReader reader)
        {
            string nom = reader.ReadLine();
            string path = reader.ReadLine();
            string nomcreateur = reader.ReadLine();
            DateTime.TryParse(reader.ReadLine(), out var dateCreation);
            return new Musique(nom, path, nomcreateur, dateCreation);
        }

        public void SauvegardeDonnees(IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises)
        {
            using (FileStream fs = File.OpenWrite("infoJVDex.txt"))
            {
                using (TextWriter writer = new StreamWriter(fs)) 
                {
                    writer.WriteLine(franchises.Keys.Count);
                    foreach(Franchise f in franchises.Keys)
                    {
                        SauvegardeFranchise(f, writer);
                        writer.WriteLine(franchises[f].Count);
                        foreach(Jeu j in franchises[f])
                        {
                            SauvegardeJeu(j, writer);
                        }
                    }

                }
            }

        }

        private void SauvegardeJeu(Jeu j, TextWriter writer)
        {
            writer.WriteLine(j.Informations.Nom);
            writer.WriteLine(j.Informations.Createur);
            writer.WriteLine(j.Informations.DateCreation);
            writer.WriteLine(j.Informations.LimiteAge);
            writer.WriteLine(j.Informations.Synopsis);
            writer.WriteLine("***");
            writer.WriteLine(j.Vignette);
            //genres, plateformes, visuels, musiques, theories

            writer.WriteLine(j.Informations.LesGenres.Count);
            foreach (Genres g in j.Informations.LesGenres)
            {
                writer.WriteLine((int) g);
            }
            writer.WriteLine(j.Informations.LesPlateformes.Count);
            foreach(Plateformes p in j.Informations.LesPlateformes)
            {
                writer.WriteLine((int)p);
            }
            writer.WriteLine(j.LesVisuels.Count);
            foreach(Visuel v in j.LesVisuels)
            {
                SauvegardeVisuel(v, writer);
            }
            writer.WriteLine(j.LesMusiques.Count);
            foreach (Musique m in j.LesMusiques)
            {
                SauvegardeMusique(m, writer);
            }
            writer.WriteLine(j.LesTheories.Count);
            foreach (Theorie t in j.LesTheories)
            {
                SauvegardeTheorie(t, writer);
            }
            writer.WriteLine(j.IsFavoris);

        }

        private void SauvegardeTheorie(Theorie t, TextWriter writer)
        {
            writer.WriteLine(t.Nom);
            writer.WriteLine(t.Texte);
            writer.WriteLine("$$$");
        }

        private void SauvegardeVisuel(Visuel v, TextWriter writer)
        {
            writer.WriteLine(v.Vignette);
            writer.WriteLine(v.Legende);
        }

        private void SauvegardeMusique(Musique m, TextWriter writer)
        {
            //nom, path, nomc, date
            writer.WriteLine(m.Nom);
            writer.WriteLine(m.Path);
            writer.WriteLine(m.NomCreateur);
            writer.WriteLine(m.DateCreation);
        }

        private void SauvegardeFranchise(Franchise f, TextWriter writer)
        {
            writer.WriteLine(f.Nom);
            writer.WriteLine(f.Background);
            writer.WriteLine(f.Couleur);
        }
    }
}
