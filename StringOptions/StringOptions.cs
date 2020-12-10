using System;


namespace StringOptions
{
    public class MyString
    {


        



        public static string[] TextToListWords(string text)
        {

            var separators = new char[] { ' ', '.', ',', '!', '?', '-', ':', ';', '"' };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }

    


}
