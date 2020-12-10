using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SyperArray
{
    public static class StringExtension
    {
        public static Language Getlanguage(this string word)
        {
            if (word.All(i => Char.IsNumber(i)))
                return Language.Number;

            if (word.All(i => Char.ToUpper(i) >= 'A' && Char.ToUpper(i) <= 'Z'))
                return Language.English;

            if (word.All(i => Char.ToUpper(i) >= 'А' && Char.ToUpper(i) <= 'Я'))
                return Language.Russian;

            return Language.Mixed;
        }
        
    }
    
    public enum Language
    {
        None = 0,
        Russian,
        English,
        Number,
        Mixed,
    }

        

    
}
