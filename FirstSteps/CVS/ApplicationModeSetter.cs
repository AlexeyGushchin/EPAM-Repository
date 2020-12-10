using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CVS
{
    public static class ApplicationModeSetter
    {
        public static AppMode SetMode()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Choose app mode:" + Environment.NewLine);

                int counter = 0;

                foreach (var i in Enum.GetValues(typeof(AppMode)))
                {
                    Console.WriteLine(++counter + " - " + i);
                }

                if (Int32.TryParse(Console.ReadLine(), out int choose))
                {
                    if (choose >= 1 && choose <= counter)
                        return (AppMode)Enum.GetValues(typeof(AppMode)).GetValue(--choose);
                }


                Console.WriteLine("Wrong input!");
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
            }

        }
    }

    public enum AppMode
    { 
        Watching = 1,
        Restoring
    }

}
