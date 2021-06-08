using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication
{
    public interface IPersistanceStockApp
    {
        (IEnumerable<Jeu> jeux, IEnumerable<Franchise> franchise) ChargeDonnees();

        void SauvegardeDonnees(IEnumerable<Jeu> jeux, IEnumerable<Franchise> franchise);
    }
}
