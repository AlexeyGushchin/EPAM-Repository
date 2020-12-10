using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis
{
    public static class Analysis
    {
        public static string[] TextToListWords(string text)
        {

            var separators = new char[] { ' ', '.', ',', '!', '?', '-', ':', ';', '"', ')', '(' };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        public static Dictionary<string, int> WordsDictionary(string text)
        {
            var list = TextToListWords(text);

            var dict = new Dictionary<string, int>();

            foreach(var i in list)
            {
                var key = i.ToLower();
                if (dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                    dict[key] = 1;
            }

            return dict;
        }


        public static void ShowCount(string text)
        {
            var dict = WordsDictionary(text);
            var count = CountWord(dict);

            int start = count[0].Item1;
            int x = 3;

            Console.ForegroundColor = ConsoleColor.Red;

            foreach(var i in count)
            {
                if (x != 0 && start != i.Item1)
                {
                    x--;
                    start = i.Item1;
                }
                    

                Semafore(x);
                Console.WriteLine(i.Item2 + " - " + i.Item1);
            }
        }

        
        public static List<(int, string)> CountWord(Dictionary<string, int> dict)
        {
            var list2 = new List<(int, string)>(dict.Count);
            
            foreach(var pair in dict)
            {
                int count = pair.Value;
                string word = pair.Key;
                list2.Add((count, word));
                
            }
            list2.Sort();
            list2.Reverse();
            return list2;
        }


        public static void Semafore(int index)
        {
            if (index == 3)
                Console.ForegroundColor = ConsoleColor.Red;
            if (index == 2)
                Console.ForegroundColor = ConsoleColor.Yellow;
            if (index == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            if (index == 0)
                Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
