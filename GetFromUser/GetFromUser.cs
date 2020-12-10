using System;


namespace Get
{
    public class GetFromUser
    {

        public static int GetPositiveInt(string text = "Введите целое число больше нуля:")
        {
            int number;
            bool flag;

            Console.WriteLine(text);
            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);

                if (flag)
                {
                    flag = number > 0 ? flag : !flag;
                }

                if (!flag)
                {
                    Console.WriteLine("Некорректный ввод!\n");
                    Console.WriteLine(text);
                }


            } while (!flag);

            return number;
        }

        public static int GetPositiveIntNoMore(int n, string text = " ")
        {

            int number;
            bool flag;

            Console.WriteLine(text);
            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);

                if (flag)
                {
                    flag = number > n ? !flag : flag;
                    flag = number > 0 ? flag : !flag;
                }

                if (!flag)
                {
                    Console.WriteLine("Некорректный ввод!\n");
                    Console.WriteLine(text);
                }


            } while (!flag);

            return number;
        }



        public static int GetInt(string text = "Введите целое число:")
        {

            int number;
            bool flag;

            Console.WriteLine(text);
            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);

                if (!flag)
                {
                    Console.WriteLine("Некорректный ввод!\n");
                    Console.WriteLine(text);
                }


            } while (!flag);

            return number;
        }

        

        public static double GetPositiveDouble(string text = "Введите число больше нуля:")
        {

            double number;
            bool flag;

            Console.WriteLine(text);
            do
            {
                flag = double.TryParse(Console.ReadLine(), out number);

                if (flag)
                {
                    flag = number > 0 ? flag : !flag;
                }


                if (!flag)
                {
                    Console.WriteLine("Некорректный ввод!\n");
                    Console.WriteLine(text);
                }


            } while (!flag);

            return number;
        }

        
        public static double GetDouble(string text = "Введите число:")
        {

            double number;
            bool flag;

            Console.WriteLine(text);
            do
            {
                flag = double.TryParse(Console.ReadLine(), out number);

                if (!flag)
                {
                    Console.WriteLine("Некорректный ввод!\n");
                    Console.WriteLine(text);
                }


            } while (!flag);

            return number;
        }


        public static string GetString(string text = "Введите сроку:")
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
    }
}
