using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weakest_link
{
    class Game
    {
        public void StartGame()
        {
            var players = SetPlayers();
            var color = SetColor();
            var looserPosition = SetLooserPosition(players.Count);
            var delay = GetFromUser.GetPositiveDoubleNoMore(5, "Enter the game speed from 1,0 to 5:");

            Start(players, color, looserPosition, delay);
        }

        public void ShowDemo()
        {
            var players = SetPlayers(ProgrammersList.programmers);
            var color = SetColor();
            var looserPosition = SetLooserPosition(players.Count);
            var delay = GetFromUser.GetPositiveDoubleNoMore(5, "Enter the game speed from 1,0 to 5:");

            Start(players, color, looserPosition, delay);
        }



        


        public void Start(List<Player> players, Colors color, int LooserPosition, double delay)
        {
            
            Console.Clear();
            
            
            WritePlayers(players);
            CountDown(5, 30, 0);

            var step = LooserPosition - 1;

            ///Main logic
            for (int i = step; players.Count > step; i += step)
            {
                i %= players.Count;

                players[i].WriteColorPlayer(color);

                players.RemoveAt(i);

                Thread.Sleep((int)(delay * 1000));

            }

            Console.SetCursorPosition(30, 0);
            Console.ResetColor();
            Console.WriteLine("Winners:");
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0, j = 1; i < players.Count; i++, j++)
            {
                Console.SetCursorPosition(30, j);
                Console.WriteLine(players[i].name);
            }

        }


        #region SET METHODS
        public List<Player> SetPlayers()
        {
            var playersCount = GetFromUser.GetPositiveInt("Enter the number of players:");
            var players = new List<Player>(playersCount);

            for (int i = 0; i < playersCount; i++)
            {
                var name = GetFromUser.GetString($"Enter the name of the player number {i + 1}");
                players.Add(new Player(name, 0, i));
            }

            return players;
        }

        public List<Player> SetPlayers(string[] playersList)
        {
            var players = new List<Player>(playersList.Length);

            for (int i = 0; i < players.Capacity; i++)
                players.Add(new Player(playersList[i], 0, i));
            
            return players;
        }


        public Colors SetColor()
        {
            string message = "Choose a color for the losing player:" +
                "\n\t1 - Black" +
                "\n\t2 - Red\n";

            var choice = GetFromUser.GetPositiveIntNoMore(2, message);

            if (choice == 1)
                return Colors.Black;

            else return Colors.Red;
        }

        public int SetLooserPosition(int maxValue)
        {
            string message = "Enter the number of weakest link:";
            return GetFromUser.GetPositiveIntNoMore(maxValue, message); ;
        }

        #endregion

        #region WRITE METHODS

        public void WritePlayers(List<Player> players)
        {
            foreach (var i in players)
            {
                i.WritePlayer();
                Thread.Sleep(50);
            }
        }

        public void WriteColorPlayers(List<Player> players, Colors color)
        {
            foreach (var i in players)
            {
                i.WriteColorPlayer(color);
            }
        }

        #endregion

        public static void CountDown(int count, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = count; i >= 0; i--)
            {
                Console.SetCursorPosition(x, y);
                if (i == 2)
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (i == 1)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                if (i == 0)
                {
                    Console.WriteLine("START");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine();
                    return;
                }
                
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }


}
