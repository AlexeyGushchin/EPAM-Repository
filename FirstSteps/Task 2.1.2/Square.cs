using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Square : Figure
    {
        public override string Name { get { return "Square"; } }

        protected double width;

        public Square(int width, string color) : base (color)
        {
            if (width <= 0)
                throw new Exception("Wrong value!");

            this.width = width;
        }

        public override double Area() => width * width;

        public override double Perimeter() => width * 4;

        public override void ShowInfo()
        {
            Console.WriteLine("This is a square:");
            base.ShowInfo();
        }



    }

    
}
