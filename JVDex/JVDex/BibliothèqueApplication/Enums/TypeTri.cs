using BibliothèqueApplication.Enums;

namespace BibliothèqueApplication
{
    public enum TypeTri
    {
        [EnumDescription("ordre alphabétique")]
        A_Z = 1, 
        [EnumDescription("ordre alphabétique inverse")]
        Z_A, 
        [EnumDescription("les plus récents d'abord")]
        Premier_Récents, 
        [EnumDescription("les plus anciens d'abord")]
        Premier_Anciens, 
        [EnumDescription("ordre alphabétique des noms de créateur")]
        NomCréateur 
    }
}
//enum des différents tri qui pourront être utilisé dans l'application