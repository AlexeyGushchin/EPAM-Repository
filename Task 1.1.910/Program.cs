using System;
using ArrayOptions;


namespace Task_1._1._910
{
    class Program
    {
        static void Main()
        {
            var numbers = MyArray.MakeRandom2DIntArray(10, 10);
            MyArray.ShowArray(numbers);

            int sum = Array2D(numbers);

            Console.WriteLine($"\nСумма элементов массива, стоящих на четных позициях равна: {sum}");

            Console.ReadKey();
        }



        public static int Array2D(int[,] numbers)
        {
            int x = numbers.GetUpperBound(0);
            int y = numbers.GetUpperBound(1);
            int sum = 0;

            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    if (Program.IsEven(i + j))
                        sum += numbers[i, j];
                }
            }

            return sum;

        }

        public static bool IsEven(int i)
        {
            return i % 2 == 0 ? true : false;
        }
    }
}
