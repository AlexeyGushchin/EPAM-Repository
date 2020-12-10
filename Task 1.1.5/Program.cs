using System;
using Get;


namespace Task_1._1._5
{
    class Program
    {
        static void Main()
        {
            ShowSumOfNumbers();

            int n = GetFromUser.GetPositiveInt("Введите свое число:");

           ShowSumOfNumbers(n);

            Console.ReadKey();


        }



        internal static void ShowSumOfNumbers(int n = 1000)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }

            }

            Console.WriteLine("Сумма положительных чисел, " +
                $"не превышающих {n}, которые кратны трем или пяти равна {sum}");
        }
    }
}
