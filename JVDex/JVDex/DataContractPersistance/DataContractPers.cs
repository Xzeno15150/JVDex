using BibliothèqueApplication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace DataContractPersistance
{
    public class DataContractPers : IPersistanceStockApp

    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");
        public string FileName { get; set; } = "infoJVDex.xml";
       // (IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises) ChargeDonnees();
        public (IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises) ChargeDonnees()
        {
            if (!File.Exists(Path.Combine(FilePath, FileName)))
            {
                throw new FileNotFoundException("le fichier pour la persistance n'existe pas");

            }
            var serializer = new DataContractSerializer(typeof(IList<Jeu>));
            //using (Stream s = )

            return (null, null);


        }


        public void SauvegardeDonnees(IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises)
        {
            throw new NotImplementedException();
        }
        //throw new NotImplementedException();
    }
}
         

