using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BibliothèqueApplication.Enums
{
    public static class EnumExtension
    {
        public static string ToDescription(this Enum enumeration)
        {
            Type type = enumeration.GetType();

            MemberInfo[] memInfo = type.GetMember(enumeration.ToString());

            if (null != memInfo && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(EnumDescription), false);
                if (null != attrs && attrs.Length > 0)
                    return (attrs[0] as EnumDescription).Text;
            }
            return enumeration.ToString();
        }
    }
}
