using System.Runtime.Serialization;

namespace BibliothèqueApplication
{
    public enum TypeTri
    {
        [EnumMember(Value = "ordre alphabétique")]
        A_Z, 
        [EnumMember(Value = "ordre alphabétique inverse")]
        Z_A, 
        [EnumMember(Value = "les plus récents d'abord")]
        Premier_Récents, 
        [EnumMember(Value = "les plus anciens d'abord")]
        Premier_Anciens, 
        [EnumMember(Value = "ordre alphabétique des noms de créateur")]
        NomCréateur 
    }
}