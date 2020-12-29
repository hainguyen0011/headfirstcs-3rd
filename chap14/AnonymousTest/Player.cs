using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTest
{
    class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Player(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
