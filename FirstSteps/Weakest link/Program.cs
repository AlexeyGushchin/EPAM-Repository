using System;


namespace Weakest_link
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            Console.WriteLine("\tWelcome to the \"WEAKEST LINK\"!\n\tChoose option:\n" +
                "\t\t1 - Show demo\n\t\t2 - Start game");

            var option = GetFromUser.GetPositiveIntNoMore(2);

            var game = new Game();

            switch (option)
            {
                case (1):
                    game.ShowDemo();
                    break;

                case (2):
                    game.StartGame();
                    break;
            }
                

            Console.ReadKey();
        }



        


    }
}
