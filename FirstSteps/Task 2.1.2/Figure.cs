using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public abstract class Figure : SomethingColored
    {
        
        public abstract double Area();
        public abstract double Perimeter();
        public override void ShowInfo()
        {
            Console.WriteLine("It area is " + Area() + "\n" +
                              "It perimeter is " + Perimeter() + "\n" +
                              "It color is " + color + ".\n");
        }

        public Figure(string color) : base(color)
        {

        }


    }
}
