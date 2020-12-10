using System;
using ArrayOptions;


namespace Task_1._1._9
{
    class Program
    {
        static void Main()
        {
            var numbers = MyArray.MakeRandomSimpleIntArray(10);
            MyArray.ShowArray(numbers);

            int sum = Program.NonNegativeSum(numbers);

            Console.WriteLine($"\nСумма неотрицательных элементов массива равна: {sum}");

            Console.ReadKey();

            
        }

        public static int NonNegativeSum(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                    sum += number;
            }

            return sum;
        }
    }
}
