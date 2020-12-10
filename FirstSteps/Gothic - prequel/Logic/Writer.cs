using Gothic___prequel.Bot;
using Gothic___prequel.Interfaces_and_Enums;
using Gothic___prequel.Map;
using System;
using System.Collections.Generic;

namespace Gothic___prequel
{
    class Writer
    {
       public static void Write(AbstractGameObject obj)
        {
            Console.SetCursorPosition(obj.point.x, obj.point.y);
            ColorSetter.SetColor(obj.Color);
            Console.Write((char)obj.Sign);
            Console.ResetColor();


        }




        public static void WriteSame(List<AbstractEnemy> objects)
        {
            ColorSetter.SetColor(objects[0].Color);

            foreach (var obj in objects)
            {
                Console.SetCursorPosition(obj.point.x, obj.point.y);
                Console.Write((char)obj.Sign);
            }

            Console.ResetColor();
        }

        public static void WriteSpace(Point point)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write(' ');
        }


        



        
    }
}
