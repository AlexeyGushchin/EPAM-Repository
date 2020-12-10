using System;
using ArrayOptions;


namespace Task_1._1._8
{
    class Program
    {
        static void Main()
        {
            var numbers = MyArray.MakeRandom3DIntArray(3, 3, 3);

            Console.WriteLine("Массив до изменения:\n");
            MyArray.ShowArray(numbers);

            NoPositive(numbers);

            Console.WriteLine("\nМассив после изменения:\n");
            MyArray.ShowArray(numbers);

            Console.ReadKey();
        }


        public static void NoPositive(int[,,] numbers)
        {
            int x = numbers.GetUpperBound(0);
            int y = numbers.GetUpperBound(1);
            int z = numbers.GetUpperBound(2);

            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    for (int k = 0; k <= z; k++)
                    {
                        if (numbers[i, j, k] > 0)
                            numbers[i, j, k] = 0;

                    }
                }
            }
        }
    }
}
