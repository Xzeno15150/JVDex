using BibliothèqueApplication.Enums;

namespace BibliothèqueApplication
{
    public enum Plateformes
    {
        PC, //1
        PS1, //2
        PS2, //3
        PS3, //4
        PS4, //5
        PS5, //6
        Gameboy, //7
        [EnumDescription("Gameboy Color")]
        Gameboy_Color, //8
        [EnumDescription("Gameboy Advance")]
        Gameboy_Advance, //9
        Gamecube, //10
        DS, //11
        Wii, //12
        [EnumDescription("Wii U")]
        Wii_U, //13
        [EnumDescription("3DS")]
        TroisDS, //14
        [EnumDescription("Nintendo Switch")]
        NintendoSwitch, //15
        Xbox,//16
        [EnumDescription("Xbox 360")]
        Xbox360, //17
        [EnumDescription("Xbox One")]
        XboxOne, //18
        [EnumDescription("Xbox Serie X")]
        XboxSerieX, //19
        IOS, //20
        Android,//21
        [EnumDescription("Nintendo 64")]
        Nintendo64,
        NES
    }
}
//enum des différentes plateformes des jeux
