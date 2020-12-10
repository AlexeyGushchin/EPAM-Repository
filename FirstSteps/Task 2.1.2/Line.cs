using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Line : SomethingColored
    {
        
        public override string Name { get { return "Line"; } }

        protected double X1;
        protected double Y1;
        protected double X2;
        protected double Y2;

        public double Length()
        {
            return Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
        }

        public Line(double x1, double y1, double x2, double y2, string color) : base(color)
        {
            if (SameValues(x1, y1, x2, y2))
                throw new Exception("Wrong values!");

            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("This is a line:");
            Console.WriteLine($"It length in {Length()}");
            Console.WriteLine("It color is " + color);
            Console.WriteLine($"Сoordinates:\nX1 = {X1}\nY1 = {Y1}\nX2 = {X2}\nY2 = {Y2}\n");
        }

    }
}
