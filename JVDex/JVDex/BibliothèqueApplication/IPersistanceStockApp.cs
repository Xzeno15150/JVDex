using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public interface IPersistanceStockApp
    {
        (IList<Jeu> jeux, Dictionary<Franchise,List<Jeu>> franchises) ChargeDonnees();

        void SauvegardeDonnees(IList<Jeu> jeux, Dictionary<Franchise, List<Jeu>> franchises);
    }
}
