using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Ring : Circle
    {
        public override string Name { get { return "Ring"; } }
        
        public double innerRadius;

        public Ring(double x, double y, double radius, double innerRadius, string color) : base(x, y, radius, color)
        {
            if (radius <= 0 || innerRadius <= 0 || innerRadius >= radius)
                throw new Exception("Wrong values");

            this.innerRadius = innerRadius;
        }

        public double InnerArea() => Math.PI * innerRadius * innerRadius;

        public override double Area() => base.Area() - InnerArea();

        public double InnerPerimeter() => Math.PI * innerRadius * 2;

        public double SumOfPerimetres() => Perimeter() + InnerPerimeter();

        public override void ShowInfo()
        {
            Console.WriteLine("This is a ring:");
            Console.WriteLine("The inner perimeter is " + InnerPerimeter());
            base.ShowInfo();
            
        }


    }
}
