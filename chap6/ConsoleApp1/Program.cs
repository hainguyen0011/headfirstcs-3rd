using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            Jewels jewels = new Jewels();
            jewelThief.ReturnContents(jewels, owner);
            Console.ReadKey();
            new Owner();
        }
    }
}
