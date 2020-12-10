using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Weakest_link
{
    class Players<T> 
    {
        public List<Player> players = new List<Player>();

        public int Count
        {
            get => players.Count;
        }

        public Players(T[] players)
        {
            for (int i = 0; i < players.Length; i++)
                this.players.Add(new Player(players[i].ToString(), 0, i));
        }

        public Players(int quantity)
        {
            for (int i = 0; i < quantity; i++)
                this.players.Add(new Player((i + 1).ToString(), 0, 1));
            
        }

        public void WritePlayers()
        {
            foreach (var i in players)
            {
                i.WritePlayer();
            }
        }

        public void WriteColorPlayers(Colors color)
        {
            foreach (var i in players)
            {
                i.WriteColorPlayer(color);
            }
        }



        public Player this[int index]
        { 
            get
            {
                return players[index];
            }
        }

    }
}
