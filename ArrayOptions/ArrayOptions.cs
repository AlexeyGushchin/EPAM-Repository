using System;



namespace ArrayOptions
{
    public class MyArray
    {
        
        public static void ShowArray(int[] numbers)
        {
            foreach (var i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void ShowArray(int[,] numbers)
        {
            int x = numbers.GetUpperBound(0);
            int y = numbers.GetUpperBound(1);


            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= y; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }


        public static void ShowArray(int[,,] numbers)
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
                        Console.Write(numbers[i, j, k] + " ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static int[] MakeRandomSimpleIntArray(int n)
        {
            var rng = new Random();
            var numbers = new int[n];

            for (var i = 0; i < n; i++)
            {
                numbers[i] = rng.Next(-99, 99);
            }

            return numbers;

        }

        public static int[,] MakeRandom2DIntArray(int x, int y)
        {
            var rng = new Random();
            var numbers = new int[x, y];


            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    numbers[i, j] = rng.Next(-99, 99);
                }

            }

            return numbers;
        }

        public static int[,,] MakeRandom3DIntArray(int x, int y, int z)
        {
            var rng = new Random();
            var numbers = new int[x, y, z];


            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        numbers[i, j, k] = rng.Next(-99, 99);
                    }
                }
            }

            return numbers;
        }
    }
}
