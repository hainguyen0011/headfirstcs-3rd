using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> test = new Dictionary<int, string>()
            {
                {1,"string 1"},
                {1,"string 2"},
                {1,"string 3"},
            };
            List<Player> players = new List<Player>()
            {
                new Player("Player 1", 10),
                new Player("Player 2", 1),
                new Player("Player 3", 1),
                new Player("Player 3", 5),
                new Player("Player 3", 5),
                new Player("Player 3", 5),
            };
            List<Shirt> shirts = new List<Shirt>()
            {
                new Shirt("Shirt 1", 35, 1),
                new Shirt("Shirt 2", 40, 10),
                new Shirt("Shirt 3", 30, 5),
            };
            var results =
                    from player in players
                    group player by player.Number
                    into groupPlayer
                    orderby groupPlayer.Key
                    select groupPlayer;
            foreach (var res in results)
            {
                Console.WriteLine(res.GetEnumerator());
            }
            Console.ReadKey();
        }
    }
}
