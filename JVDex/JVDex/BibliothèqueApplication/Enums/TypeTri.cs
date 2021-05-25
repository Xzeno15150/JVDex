using BibliothèqueApplication.Enums;

namespace BibliothèqueApplication
{
    public enum TypeTri
    {
        [EnumDescription("Ordre alphabétique")]
        A_Z = 1, 
        [EnumDescription("Ordre alphabétique inverse")]
        Z_A, 
        [EnumDescription("Les plus récents d'abord")]
        Premier_Récents, 
        [EnumDescription("Les plus anciens d'abord")]
        Premier_Anciens, 
        [EnumDescription("Ordre alphabétique des noms de créateur")]
        NomCréateur 
    }
}
//enum des différents tri qui pourront être utilisé dans l'application