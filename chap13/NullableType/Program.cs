using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter birthday: ");
            string birthday = Console.ReadLine();
            Console.Write("Enter height: ");
            string height = Console.ReadLine();
            RobustGuy robustGuy = new RobustGuy(birthday, height);
            Console.WriteLine(robustGuy);
            Console.ReadKey();
        }
    }
}
