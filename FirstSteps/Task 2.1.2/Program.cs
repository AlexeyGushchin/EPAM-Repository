using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome!\nWhat is your name?");
            var user = new User(Console.ReadLine());
            Console.Clear();
            user.Hello();
            ShowCommands();
            
            while (true)
            {
                Console.WriteLine("Enter option:");
                var option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        user.Add(new Line(2, 2, 3, 3, "Green"));
                        break;

                    case "2":
                        user.Add(new Circle(2, 2, 2, "Green"));
                        break;

                    case "3":
                        user.Add(new Ring(2, 2, 4, 3, "Green"));
                        break;

                    case "4":
                        user.Add(new Square(2, "Green"));
                        break;

                    case "5":
                        user.Add(new Rectangle(2, 3, "Green"));
                        break;

                    case "6":
                        user.Add(new Triangle(2, 2, 2, "Green"));
                        break;

                    case "7":
                        user.ShowCollection();
                        break;

                    case "8":
                        user.ShowInformation();
                        break;

                    case "9":
                        user.Clear();
                        break;

                    case "0":
                        Console.WriteLine("Welcome!\nWhat is your name?");
                        user = new User(Console.ReadLine());
                        Console.Clear();
                        user.Hello();
                        ShowCommands();
                        break;

                    default:
                        Environment.Exit(0);
                        break;

                }
            }
            









        }

        static void ShowCommands()
        {
            Console.WriteLine("Option:" +
                "\n\t 1 - Add line.\n\t 2 - Add circle. \n\t 3 - Add ring." +
                "\n\t 4 - Add square.\n\t 5 - Add rectangle. \n\t 6 - Add triangle." +
                "\n\t 7 - Show collection.\n\t 8 - Show information about collection. " +
                "\n\t 9 - Clear collection. \n\t 0 - Change user." +
                "\n\t Any different key - exit app.");
        }
    }
}
