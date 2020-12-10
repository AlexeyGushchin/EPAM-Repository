using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Circle : Figure
    {
        public override string Name { get { return "Circle"; } }
        protected double X;
        protected double Y;

        protected double radius;

        public Circle(double x, double y, double radius, string color) : base(color)
        {
            if (radius <= 0)
                throw new Exception("Wrong radius!");

            X = x;
            Y = y;
            this.radius = radius;
        }

        public override double Area() => Math.PI * radius * radius;

        public override double Perimeter() => Math.PI * radius * 2;

        public void ShowCenter()
        {
            Console.WriteLine($"X = {X}\nY = {Y}");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("This is a circle:");
            Console.WriteLine("Сoordinates of center:");
            ShowCenter();
            base.ShowInfo();
        }
    }
}
