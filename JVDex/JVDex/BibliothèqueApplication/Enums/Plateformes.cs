using BibliothèqueApplication.Enums;

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
        [EnumDescription("Gameboy Color")]
        Gameboy_Color,
        [EnumDescription("Gameboy Advance")]
        Gameboy_Advance,
        Gamecube,
        DS,
        Wii,
        [EnumDescription("3DS")]
        TroisDS,
        [EnumDescription("Nintendo Switch")]
        NintendoSwitch,
        Xbox,
        [EnumDescription("Xbox 360")]
        Xbox360,
        [EnumDescription("Xbox One")]
        XboxOne,
        [EnumDescription("Xbox Serie X")]
        XboxSerieX,
        IOS,
        Android
    }
}
