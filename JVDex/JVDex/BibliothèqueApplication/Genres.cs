using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BibliothèqueApplication
{
    public enum Genres
    {
        
        Plateforme,
        RPG,
        FPS,
        Infiltration,
        Espionnage,
        Reflexe,
        Puzzle,
        [EnumMember(Value = "Survival Horror")]
        Survival_Horror,
        Simulation,
        Stratégie,
        Sport
    }
}
