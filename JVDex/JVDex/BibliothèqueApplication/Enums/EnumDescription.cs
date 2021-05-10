using System;
using System.Collections.Generic;
using System.Text;

namespace BibliothèqueApplication.Enums
{
    class EnumDescription : Attribute
    {
        public string Text { get; set; }

        public EnumDescription(string text)
        {
            Text = text;
        }
    }
}
