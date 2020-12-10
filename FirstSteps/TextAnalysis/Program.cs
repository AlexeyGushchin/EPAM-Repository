using System;
using MyLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;

            StringDecoration.MoveAndBlinK("TEXT ANALYSIS", 0, 0, 60);
            StringDecoration.LoadingImitation("Loading", 0, 1);

            Console.WriteLine("Press any key...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Welcome to the TEXT ANALYSIS!");
            Console.WriteLine("Enter your text please:");

            //var text = Console.ReadLine();

            string text = "Television in Britain is a part of mass media, a single public structure." +
                " It provides the society with up-to-date detailed information, which concerns political, " +
                "economical, social, cultural and other important aspects. British people are fond of watching TV." +
                " Most families watch TV more than 4 hours a day. Nowadays there is a big choice of channels and programmes." +
                " Everyone may choose something to their own taste.";

            Console.Clear();
            StringDecoration.LoadingImitation("Analysing", 0, 0);
            Console.Clear();

            Analysis.ShowCount(text);

            Console.ReadKey();

            
        }
    }
}
