using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTest
{
    class Shirt
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public int Number { get; set; }
        public Shirt(string name, int size, int number)
        {
            Name = name;
            Size = size;
            Number = number;
        }
    }
}
