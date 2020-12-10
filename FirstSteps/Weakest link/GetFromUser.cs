using System;

namespace Weakest_link
{
    class GetFromUser
    {
        public static int GetPositiveIntNoMore(int n, string message = "")
        {
            int number;
            bool flag;

            Console.Write(message);
            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);

                if (flag)
                {
                    flag = number > n ? !flag : flag;
                    flag = number > 0 ? flag : !flag;
                }

                if (!flag)
                    Console.WriteLine($"Invalid input! Try again:\n");

            } while (!flag);

            return number;
        }

        public static int GetPositiveInt(string message = "")
        {
            int number;
            bool flag;

            Console.Write(message);
            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);

                if (flag)
                    flag = number > 0 ? flag : !flag;

                if (!flag)
                    Console.WriteLine("Invalid input! Try again:");

            } while (!flag);

            return number;
        }

        public static double GetPositiveDoubleNoMore(double n, string message = "")
        {
            double number;
            bool flag;

            Console.Write(message);
            do
            {
                flag = double.TryParse(Console.ReadLine(), out number);

                if (flag)
                {
                    flag = number > n ? !flag : flag;
                    flag = number > 0 ? flag : !flag;
                }

                if (!flag)
                    Console.WriteLine($"Invalid input! Try again:\n");

            } while (!flag);

            return number;
        }

        public static string GetString(string message = "")
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
