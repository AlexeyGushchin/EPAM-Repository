using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyperArray
{
    public static class NumbersArrayExtension
    {
        public static void DoWithEach(this int[] array, Func<int, int> function)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = function(array[i]);
        }

        public static void DoWithEach(this double[] array, Func<double, double> function)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = function(array[i]);
        }
        //Дальше без дублирования однотипных методов
        public static void DoWithAny(this int[] array, Func<int, int> function, int index)
        {
            if (index < 0 || index >= array.Length)
                throw new ArgumentOutOfRangeException();

            array[index] = function(array[index]);
        }

        public static int Sum(this int[] array)
        {
            // LONQ : return array.Sum();

            var result = 0;

            foreach (var i in array)
                result += i;

            return result;

        }

        public static double Average(this int[] array)
        {
            //LINQ : return array.Average();

            double result = 0;

            foreach (var i in array)
                result += i;

            return result / array.Length;
        }

        public static int MostOften(this int[] array)/////////////////////////////////////////////////////////////
        {
            var dict = new Dictionary<int, int>();

            foreach (var i in array)
            {
                var key = i;
                if (dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                    dict[key] = 1;
            }

            var resultKey = dict.Values.Max();

            return dict[resultKey];
        }




    }
}
