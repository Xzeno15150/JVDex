using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BibliothèqueApplication
{
    public enum Plateformes
    {
        PC,
        PS1,
        PS2,
        PS3,
        PS4,
        PS5,
        Gameboy,
        [EnumMember(Value = "Gameboy Color")]
        Gameboy_Color,
        [EnumMember(Value = "Gameboy Advance")]
        Gameboy_Advance,
        Gamecube,
        DS,
        Wii,
        [EnumMember(Value = "3DS")]
        TroisDS,
        [EnumMember(Value = "Nintendo Switch")]
        NintendoSwitch,
        Xbox,
        [EnumMember(Value = "Xbox 360")]
        Xbox360,
        [EnumMember(Value = "Xbox One")]
        XboxOne,
        [EnumMember(Value = "Xbox Serie X")]
        XboxSerieX,
        IOS,
        Android
    }
}
