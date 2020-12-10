using System;
using ArrayOptions;


namespace Task_1._1._7
{
    class Program
    {
        static void Main()
        {
            var numbers = MyArray.MakeRandomSimpleIntArray(20);


            Console.WriteLine("Массив до сортировки:\n");
            MyArray.ShowArray(numbers);

            MySort.MargeSort(numbers);

            Console.WriteLine("\nМассив после сортировки:\n");
            MyArray.ShowArray(numbers);

            int max = MySort.Max(numbers);
            int min = MySort.Min(numbers);

            //или так, после сортировки
            //int max = numbers[numbers.Length - 1];
            //int min = numbers[0];


            Console.WriteLine($"\nМаксимальный элемент массива: {max}\n");
            Console.WriteLine($"Минимальный элемент массива: {min}");

            Console.ReadKey();
        }
    }


    class MySort
    {

        internal static void MargeSort(int[] numbers)
        {
            if (numbers.Length < 2)
                return;

            int mid = numbers.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[numbers.Length - mid];

            Array.Copy(numbers, 0, left, 0, left.Length);
            Array.Copy(numbers, mid, right, 0, right.Length);

            MargeSort(left);
            MargeSort(right);

            Marge(numbers, left, right);


        }

        internal static void Marge(int[] target, int[] a, int[] b)
        {
            int aIndex = 0;
            int bIndex = 0;
            int targetIndex = 0;

            while ((aIndex != a.Length) && (bIndex != b.Length))
            {
                if (a[aIndex] < b[bIndex])
                {
                    target[targetIndex] = a[aIndex];
                    aIndex++;
                    targetIndex++;
                }
                else
                {
                    target[targetIndex] = b[bIndex];
                    bIndex++;
                    targetIndex++;
                }
            }

            if (aIndex == a.Length)
            {
                Array.Copy(b, bIndex, target, targetIndex, (b.Length - bIndex));
            }
            else
            {
                Array.Copy(a, aIndex, target, targetIndex, (a.Length - aIndex));
            }
        }

        internal static int Max(int[] numbers)
        {
            int result = numbers[0];

            foreach (int n in numbers)
            {
                result = result > n ? result : n;
            }

            return result;
        }

        internal static int Min(int[] numbers)
        {
            int result = numbers[0];

            foreach (int n in numbers)
            {
                result = result < n ? result : n;
            }

            return result;
        }
    }
}
