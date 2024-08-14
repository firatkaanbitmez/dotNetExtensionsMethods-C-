using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetExtensionsMethods.Extensions
{
    public static class CharExtensions
    {
        public static char[] ConvertToChars(this string text)
        {
            char[] chars = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                chars[i] = text[i];
            }
            return chars;

        
        }
    
    }
}
