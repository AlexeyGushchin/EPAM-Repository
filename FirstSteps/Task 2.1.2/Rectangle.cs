using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Rectangle : Figure
    {
        public override string Name { get { return "Rectangle"; } }
        
        protected double sideA;
        protected double sideB;

        public Rectangle(double a, double b, string color) : base(color)
        {
            if (a <= 0 || b <= 0 || SameValues(a, b)) //конечно прямоугольник с одинаковыми сторонами это квадрат, но пусть будет ошибка
                throw new Exception("Wrong values!");

            sideA = a;
            sideB = b;
        }

        public override double Perimeter() => (sideB * sideB) * 2;

        public override double Area() => sideA * sideB;

        public override void ShowInfo()
        {
            Console.WriteLine("This is a rectangle: ");
            base.ShowInfo();
        }
    }
}
