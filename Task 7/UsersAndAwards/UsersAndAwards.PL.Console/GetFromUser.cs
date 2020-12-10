using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards.PLConsole
{
    public static class GetFromUser
    {
        public static uint GetPositiveNumber(string title = "Enter a positive number")
        {
            Console.WriteLine(title);

            while (true)
            {
                if(UInt32.TryParse(Console.ReadLine(), out uint result))
                {
                    if (result == 0)
                    {
                        Console.WriteLine("Wrong input!");
                        continue;
                    }
                    return result;
                }

                Console.WriteLine("Wrong input!");
            }
        }

        public static string GetString(string title = "Enter a string")
        {
            Console.WriteLine(title);

            while (true)
            {
                var result = Console.ReadLine();

                if(result.Trim().Length != 0)
                    return result;
                
                Console.WriteLine("Wrong input!");
            }
        }

        public static DateTime GetDate(string title = "Enter a date")
        {
            Console.WriteLine(title);
            Console.WriteLine("Input format - dd.mm.yyyy");

            while (true)
            {
                if (DateTime.TryParse(Console.ReadLine(), out DateTime result))
                    return result;
                
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
