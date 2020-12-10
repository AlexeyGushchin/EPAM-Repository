using System;
using Get;

namespace Task_1._1._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Для вычисления площади прямоугольника введите длины его сторон:");

            double a = GetFromUser.GetPositiveDouble("Введите длину:");
            double b = GetFromUser.GetPositiveDouble("Введите ширину:");

            Console.Clear();
            Console.WriteLine($"Площадь прямоугольника с сторонами {a} и {b} равна {a * b}!");

            Console.ReadKey();

        }




        //Вариант решения с созданием класса 
        //Вдруг захочется его расширить

        //static void Main()
        //{
        //    Console.WriteLine("Для вычисления площади прямоугольника введите длины его сторон:");

        //    double a = Get.GetPositiveDouble("Введите длину:");
        //    double b = Get.GetPositiveDouble("Введите ширину:");

        //    var rec = new Rectangle(a, b);

        //    Console.Clear();
        //    rec.ShowArea();

        //    Console.ReadKey();

        //}

    }





    //class Rectangle
    //{
    //    double sideA;
    //    double sideB;


    //    internal Rectangle(double a, double b)
    //    {
    //        sideA = a;
    //        sideB = b;
    //    }

    //    internal double Area()
    //    {
    //        return sideA * sideB;
    //    }

    //    internal void ShowArea()
    //    {
    //        Console.WriteLine($"Площадь прямоугольника с сторонами {sideA} и {sideB} равна {sideA * sideB}!");
    //    }
    //}
}

