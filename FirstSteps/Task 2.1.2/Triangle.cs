using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Triangle : Figure
    {
        public override string Name { get { return "Triangle"; } }

        protected double sideA;
        protected double sideB;
        protected double sideC;

        public Triangle(double a, double b, double c, string color) : base(color)
        {
            if (a + b < c || a + c < b || b + c < a)
                throw new Exception("Wrong values!");

            sideA = a;
            sideB = b;
            sideC = c;
        }

        private double P() => (sideA + sideB + sideC) / 2; // half-perimeter

        public override double Area() => Math.Sqrt(P() * (P() - sideA) * (P() - sideB) * (P() - sideC));

        public override double Perimeter() => sideA + sideB + sideC;

        public override void ShowInfo()
        {
            Console.WriteLine("This is triangle:");
            base.ShowInfo();
        }
    }
}
